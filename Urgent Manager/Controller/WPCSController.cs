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

namespace Urgent_Manager.Controller
{
    public class WPCSController
    {
        private string path = "";
        UrgentController urgentController = new UrgentController();
        public WPCSController()
        {
            path = pathName();
        }

        public  bool DeleteUrgent()
        {
            try
            {
                bool isUpdated = urgentController.UpdateUrgent(UrgentModel.Status.Finished.ToString(), DateTime.Now.ToShortDateString(), urgentController.getUnico(updateStatus()));
                return isUpdated ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public string updateStatus()
        {
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader stream = new StreamReader(file);
            try
            {
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
                            return items[1].Trim().ToString();
                        }
                        isFirstLineNull = false;
                    }
                    else
                    {
                        if (!isFirstLineNull)
                            break;
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        // Get Directory

        public string pathName()
        {
            string pathName = "";
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT PathName FROM Directories WHERE id=1";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pathName = reader[0].ToString();
                        DbHelper.connection.Close();
                        return pathName;
                    }
                }
                DbHelper.connection.Close();
                return pathName;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
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

        // Update The Directory Path

        public bool updatePath(string pathName,string userID)
        {
           
            try
            {
                DbHelper.connection.Open();
                string QUERY = "UPDATE Directories SET PathName=@pathName,userID=@user WHERE id=1";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@pathName", pathName);
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
                string QUERY = "SELECT isConnect FROM Directories WHERE id=1";
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
    }
}
