using LiveCharts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urgent_Manager.Controller
{
    public class StatisticsController : UrgentController
    {
        // Get Urgents Per Area And Per Status
        public int urgentCount(string area,string status)
        {
            int count = 0;
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT M.ParentZone,count(U.UrgentUnico) AS 'Number' FROM Machine M,Urgent U, Wire W WHERE W.MC=M.Machine AND W.Unico=U.UrgentUnico AND U.UrgentStatus=@status AND M.ParentZone=@area GROUP BY M.ParentZone";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@area", area);
                cmd.Parameters.AddWithValue("@status", status);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[1]);
                    }

                    DbHelper.connection.Close();
                    return count;
                }
                DbHelper.connection.Close();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DbHelper.connection.Close();
                return count;
            }
        }

        public int urgentCount(string area, string status,string date)
        {
            int count = 0;
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT M.ParentZone,count(U.UrgentUnico) AS 'Number' FROM Machine M,Urgent U, Wire W WHERE W.MC=M.Machine AND W.Unico=U.UrgentUnico AND U.UrgentStatus=@status AND M.ParentZone=@area AND U.FinishedDate=@date GROUP BY M.ParentZone";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@area", area);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[1]);
                    }

                    DbHelper.connection.Close();
                    return count;
                }
                DbHelper.connection.Close();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DbHelper.connection.Close();
                return count;
            }
        }

        // Get All area Per Express Urgent

        public ArrayList getAreas()
        {
            ArrayList list = new ArrayList();
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT DISTINCT M.ParentZone FROM Machine M,Wire W,Urgent U WHERE W.Unico=U.UrgentUnico AND W.MC=M.Machine";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }
                    DbHelper.connection.Close();
                    return list;
                }

                DbHelper.connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return list;
            }
        }

        public ChartValues<int> getValues(string status,string[] hours,bool isFinished,string date)
        {
            ChartValues<int> values = new ChartValues<int>();
            try
            {
                foreach(string hour in hours)
                {
                    DbHelper.connection.Open();
                    string QUERY = isFinished ? "SELECT count(*) as total FROM Urgent WHERE UrgentStatus=@status AND FinishedDate=@date AND DATEPART(HOUR,HUrgent) = @hour" : "SELECT count(*) as total FROM Urgent WHERE DATEPART(HOUR,HUrgent) = @hour AND UrgentStatus = @status";
                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@hour", hour);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            values.Add(Convert.ToInt32(reader[0]));
                        }
                    }

                    DbHelper.connection.Close();
                }

                return values;
            }
            catch (Exception)
            {
                DbHelper.connection.Close();
                return values;
            }
        }

        // Get Values Per Machine
        public ChartValues<int> getValues(string Machine, string status, string[] hours, bool isFinished, string date)
        {
            ChartValues<int> values = new ChartValues<int>();
            try
            {
                foreach (string hour in hours)
                {
                    DbHelper.connection.Open();
                    string QUERY = isFinished ? "SELECT count(*) as total FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus=@status AND U.FinishedDate=@date AND DATEPART(HOUR,U.HUrgent) = @hour AND W.MC=@MC" : "SELECT count(*) as total FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus=@status AND DATEPART(HOUR,U.HUrgent) = @hour AND W.MC=@MC";
                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@hour", hour);
                    cmd.Parameters.AddWithValue("@MC", Machine);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            values.Add(Convert.ToInt32(reader[0]));
                        }
                    }

                    DbHelper.connection.Close();
                }

                return values;
            }
            catch (Exception)
            {
                DbHelper.connection.Close();
                return values;
            }
        }

        // Get Values Per Machine
        public ChartValues<int> getValuesPerArea(string Area, string status, string[] hours, bool isFinished, string date)
        {
            ChartValues<int> values = new ChartValues<int>();
            try
            {
                foreach (string hour in hours)
                {
                    DbHelper.connection.Open();
                    string QUERY = isFinished ? "SELECT count(*) as total FROM Urgent U,Wire W,Machine M WHERE U.UrgentUnico=W.Unico AND M.Machine=W.MC AND M.ParentZone=@area AND U.UrgentStatus=@status AND U.FinishedDate=@date AND DATEPART(HOUR,U.HUrgent) = @hour" : "SELECT count(*) as total FROM Urgent U,Wire W,Machine M WHERE U.UrgentUnico=W.Unico AND M.Machine=W.MC AND M.ParentZone=@area AND U.UrgentStatus=@status AND DATEPART(HOUR,U.HUrgent) = @hour";
                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@hour", hour);
                    cmd.Parameters.AddWithValue("@area", Area);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            values.Add(Convert.ToInt32(reader[0]));
                        }
                    }

                    DbHelper.connection.Close();
                }

                return values;
            }
            catch (Exception)
            {
                DbHelper.connection.Close();
                return values;
            }
        }

        // Get Total Count Of Lead Prep

        public int leadPrepTotal(string leadPrep,string status,bool withDate,string date)
        {
            int total = 0;
            try
            {
                DbHelper.connection.Open();
                string QUERY = withDate ? "SELECT COUNT(*) as number from Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus =@status AND W.LeadPrep=@LeadPrep AND FinishedDate=@date" : "SELECT COUNT(*) as number from Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus =@status AND W.LeadPrep=@LeadPrep";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@LeadPrep", leadPrep);
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        total = Convert.ToInt32(reader[0]);
                        DbHelper.connection.Close();
                        return total;
                    }
                }
                DbHelper.connection.Close();
                return total;
            }
            catch (Exception)
            {
                DbHelper.connection.Close();
                return total;
            }
        }

    }
}
