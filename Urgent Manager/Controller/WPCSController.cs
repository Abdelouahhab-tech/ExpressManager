using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Model;
using Urgent_Manager.View;

namespace Urgent_Manager.Controller
{
    public class WPCSController : UserController
    {
        private string path = "";
        UrgentController urgentController = new UrgentController();
        public WPCSController()
        {
            path = pathName();
        }

        public bool DeleteUrgent()
        {
            try
            {
                string shift = "";
                if(DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14)
                {
                    shift = "Matin";
                }else if(DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22)
                {
                    shift = "Soir";
                }
                else
                {
                    shift = "Nuit";
                }
                ArrayList list = updateStatus();
                string unico = urgentController.getUnico(list[1].ToString());
                string dateUrgent = DateUrgent(unico);
                bool isDeleted = false;
                if(DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6)
                {
                    string date = dateUrgent != "" ? Convert.ToDateTime(dateUrgent).Subtract(TimeSpan.FromDays(-1)).ToString("dd/MM/yyyy HH:mm:ss") : "";
                    int isDown = date != "" ? DateTime.Compare(Convert.ToDateTime(list[0].ToString()), Convert.ToDateTime(date)) : -1;
                    isDeleted = isDown < 0 ? false : true;
                }
                else
                {
                    int isDown = dateUrgent != "" ? DateTime.Compare(Convert.ToDateTime(list[0].ToString().Trim()), Convert.ToDateTime(dateUrgent)) : -1;
                    isDeleted = isDown < 0 ? false : true;
                }
                SortedList<string, string> qty = updateQty();
                UpdateQtyStatus(qty["DateTimeStamp"], qty["ArticleKey"], Convert.ToInt32(qty["TotalGoodPieces"]));

                if (isDeleted)
                {
                    bool isUpdated = urgentController.UpdateUrgent(UrgentModel.Status.Finished.ToString(), DateTime.Now.ToShortDateString(), urgentController.getUnico(list[1].ToString()), shift, DateTime.Now.ToShortTimeString(), Convert.ToInt32(list[2]));
                    return isUpdated ? true : false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public ArrayList updateStatus()
        {
                FileStream file = new FileStream(path+@"\Job.sdc.arc", FileMode.Open, FileAccess.Read,FileShare.Read);
                StreamReader stream = new StreamReader(file);
                ArrayList list = new ArrayList();
            try { 
                    string line = stream.ReadToEnd();
                    string item = line.Substring(line.LastIndexOf("[JobTerminated]"));
                    string[] lines = item.Split('\n');
                    bool isFirstLineNull = true;
                    foreach (string l in lines)
                    {
                        if (l.Contains("="))
                        {
                            string[] items = new string[2];
                            items = l.Split('=');
                            if (items[0].Trim() == "ArticleKey")
                            {
                                list.Add(items[1].Trim().ToString());
                            }
                            if (items[0].Trim() == "TotalGoodPieces")
                            {
                                list.Add(items[1].Trim().ToString());
                                return list;
                            }
                            if (items[0].Trim() == "DateTimeStamp")
                            {
                                list.Add(items[1].Trim().ToString());
                            }
                            isFirstLineNull = false;
                        }
                        else
                        {
                            if (!isFirstLineNull)
                                break;
                        }
                    }
                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }

        public SortedList<string,string> updateQty()
        {
            SortedList<string, string> list = new SortedList<string, string>();
            try
            {
                    FileStream file = new FileStream(path+@"\Producti.sdc.arc", FileMode.Open, FileAccess.Read, FileShare.Read);
                    StreamReader stream = new StreamReader(file);
                    string line = stream.ReadToEnd();
                    string item = line.Substring(line.LastIndexOf("[ProductionInterrupted]"));
                    string[] lines = item.Split('\n');
                    bool isFirstLineNull = true;
                    foreach (string l in lines)
                    {
                        if (l.Contains("="))
                        {
                            string[] items = new string[3];
                            items = l.Split('=');
                            if (items[0].Trim() == "DateTimeStamp")
                            {
                                list.Add("DateTimeStamp", items[1].Trim().ToString());
                            }
                            if (items[0].Trim() == "ArticleKey")
                            {
                                list.Add("ArticleKey", items[1].Trim().ToString());
                            }
                            if (items[0].Trim() == "TotalGoodPieces")
                            {
                                list.Add("TotalGoodPieces", items[1].Trim().ToString());
                                return list;
                            }
                            isFirstLineNull = false;
                        }
                        else
                        {
                            if (!isFirstLineNull)
                                break;
                        }
                    }
                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }

        // Chack If DataTimeStamp Is ALREADY Exist
        public bool isAlreadyExist(string date,string leadCode)
        {
            try
            {
                string unico = urgentController.getUnico(leadCode);
                DbHelper.connection.Open();
                string QUERY = "SELECT * FROM Urgent WHERE UrgentUnico=@unico AND interruptedDate=@date";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@unico", unico);
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DbHelper.connection.Close();
                    return true;
                }
                DbHelper.connection.Close();
                return false;             
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return false;
            }
        }

        public void UpdateQtyStatus(string date,string leadCode,int Qty)
        {
            try
            {
                if (!isAlreadyExist(date, leadCode))
                {
                    string unico = urgentController.getUnico(leadCode);
                    DbHelper.connection.Open();
                    string QUERY = "UPDATE Urgent SET Qty=@qty,interruptedDate=@date WHERE UrgentUnico=@unico";
                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                    cmd.Parameters.AddWithValue("@qty", Qty);
                    cmd.Parameters.AddWithValue("@unico", unico);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.ExecuteNonQuery();
                    DbHelper.connection.Close();
                }
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
            }
        }

        // Get Directory

        public string pathName()
        {
            string pathName = "";
            try
            {
                pathName = Properties.Settings.Default.WpcsDirectory;
                return pathName;
            }
            catch (Exception ex)
            {
                return pathName;
            }
        }

        // Fetch Records

        public List<DirectoriesModel> directories()
        {
            List<DirectoriesModel> directories = new List<DirectoriesModel>();
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT PathName,userID FROM Directories";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DirectoriesModel directory = new DirectoriesModel();
                        directory.PathName = reader[0].ToString();
                        directory.UserID = reader[1].ToString();
                        directories.Add(directory);
                    }
                    DbHelper.connection.Close();
                    return directories;
                }
                DbHelper.connection.Close();
                return directories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Their Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return directories;
            }
        }

        // Fetch Single Directory

        public DirectoriesModel singlePath(string pathName)
        {
            DirectoriesModel dir = new DirectoriesModel();
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT * FROM Directories WHERE PathName=@path";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@path", pathName);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dir.PathName = reader[0].ToString();
                        dir.UserID = reader[2].ToString();
                    }
                }
                DbHelper.connection.Close();
                return dir;
            }
            catch (Exception)
            {
                DbHelper.connection.Close();
                return dir;
            }
        }

        // Save The Directory Path

        public void SaveDirectory(DirectoriesModel dir)
        {
            try
            {
                DbHelper.connection.Open();
                string QUERY = "INSERT INTO Directories VALUES(@path,@isConnect,@user)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@path", dir.PathName);
                cmd.Parameters.AddWithValue("@isConnect", 1);
                cmd.Parameters.AddWithValue("@user", dir.UserID);
                cmd.ExecuteNonQuery();
                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Update The Directory Path

        public bool updatePath(string pathName,string userID,string OldPathName)
        {
           
            try
            {
                DbHelper.connection.Open();
                string QUERY = "UPDATE Directories SET PathName=@pathName,userID=@user WHERE PathName=@oldPathName";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@pathName", pathName);
                cmd.Parameters.AddWithValue("@oldPathName", OldPathName);
                cmd.Parameters.AddWithValue("@user", userID);
                int result = cmd.ExecuteNonQuery();
                DbHelper.connection.Close();
                return result > 0 ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Their Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return false;
            }
        }

        // Check If Is Connect Or Not

        public static bool isConnect()
        {
            try
            {
                DbHelper.connection.Open();
                string QUERY = "select isConnect From Directories";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader[0]) == 1)
                        {
                            DbHelper.connection.Close();
                            return true;
                        }
                        else
                        {
                            DbHelper.connection.Close();
                            return false;
                        }
                    }
                }

                DbHelper.connection.Close();
                return false;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return false;
            }
        }

        public void updateIsConnect(int isConnect)
        {
            try
            {
                DbHelper.connection.Open();
                string QUERY = "UPDATE Directories SET isConnect=@isConnect";
                SqlCommand cmd = new SqlCommand(QUERY,DbHelper.connection);
                cmd.Parameters.AddWithValue("@isConnect", isConnect);
                cmd.ExecuteNonQuery();
                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Get DateUrgent From Urgent Table

        public string DateUrgent(string unico)
        {
            string date = "";
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT CONCAT(DateUrgent,'  ',HUrgent) FROM Urgent WHERE UrgentUnico =@unico AND UrgentStatus = 'Express'";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@unico", unico);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        date = reader[0].ToString();
                        DbHelper.connection.Close();
                        return date;
                    }
                }

                DbHelper.connection.Close();
                return date;
            }
            catch (Exception)
            {
                DbHelper.connection.Close();
                return date;
            }
        }
    }
}
