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
                string QUERY = "SELECT M.ParentZone,count(U.UrgentUnico) AS 'Number' FROM Machine M,Urgent U, Wire W WHERE W.MC=M.Machine AND W.Unico=U.UrgentUnico AND U.UrgentStatus=@status AND M.ParentZone=@area AND U.FinishedDate=@date  AND EXISTS(SELECT * FROM Machine WHERE Machine = UserFinished) GROUP BY M.ParentZone";
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
                    string QUERY = isFinished ? "SELECT count(*) as total FROM Urgent WHERE UrgentStatus=@status AND FinishedDate=@date AND DATEPART(HOUR,HUrgent) = @hour AND EXISTS(SELECT * FROM Machine WHERE Machine = UserFinished)" : "SELECT count(*) as total FROM Urgent WHERE DATEPART(HOUR,HUrgent) = @hour AND UrgentStatus = @status AND DateUrgent=@date";
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
                    string QUERY = isFinished ? "SELECT count(*) as total FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus=@status AND U.FinishedDate=@date AND DATEPART(HOUR,U.HUrgent) = @hour AND W.MC=@MC AND EXISTS(SELECT * FROM Machine WHERE Machine = UserFinished)" : "SELECT count(*) as total FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus=@status AND DATEPART(HOUR,U.HUrgent) = @hour AND W.MC=@MC AND U.DateUrgent=@date";
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
                    string QUERY = isFinished ? "SELECT count(*) as total FROM Urgent U,Wire W,Machine M WHERE U.UrgentUnico=W.Unico AND M.Machine=W.MC AND M.ParentZone=@area AND U.UrgentStatus=@status AND U.FinishedDate=@date AND DATEPART(HOUR,U.HUrgent) = @hour  AND EXISTS(SELECT * FROM Machine WHERE Machine = UserFinished)" : "SELECT count(*) as total FROM Urgent U,Wire W,Machine M WHERE U.UrgentUnico=W.Unico AND M.Machine=W.MC AND M.ParentZone=@area AND U.UrgentStatus=@status AND DATEPART(HOUR,U.HUrgent) = @hour AND U.DateUrgent=@date";
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
                string QUERY = "";
                if(status == "Express")
                {
                    QUERY = withDate ? "SELECT COUNT(*) as number from Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus =@status AND W.LeadPrep=@LeadPrep AND FinishedDate=@date" : "SELECT COUNT(*) as number from Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus =@status AND W.LeadPrep=@LeadPrep";
                }
                else
                {
                    QUERY = withDate ? "SELECT COUNT(*) as number from Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus =@status AND W.LeadPrep=@LeadPrep AND FinishedDate=@date AND EXISTS(SELECT * FROM Machine WHERE Machine = UserFinished)" : "SELECT COUNT(*) as number from Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus =@status AND W.LeadPrep=@LeadPrep";
                }
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

        // Get Total Urgents Per Machine

        public int totalCount(string MC,string shift,bool isAll,string urgentDate)
        {
            int count = 0;
            try
            {
                DbHelper.connection.Open();
                string QUERY = isAll ? "SELECT COUNT(*) FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND W.MC=@machine AND U.UrgentStatus='Express'" : "SELECT COUNT(*) FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND W.MC=@machine AND U.UrgentStatus='Express' AND U.Shift = @shift AND U.DateUrgent =@date";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machine", MC);
                cmd.Parameters.AddWithValue("@date", urgentDate);
                cmd.Parameters.AddWithValue("@shift", shift);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                        DbHelper.connection.Close();
                        return count;
                    }
                }

                DbHelper.connection.Close();
                return count;
            }
            catch (Exception)
            {

                DbHelper.connection.Close();
                return count;
            }
        }

        // Get Total Finished Per Machine

        public int totalCount(string MC,string finishedShift,string finishedDate)
        {
            int count = 0;
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT COUNT(*) FROM Urgent U,Wire W WHERE U.UrgentUnico=W.Unico AND U.UrgentStatus='Finished' AND U.FinishedShift=@shift AND U.FinishedDate =@date AND W.MC = @mc  AND EXISTS(SELECT * FROM Machine WHERE Machine = UserFinished)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@mc", MC);
                cmd.Parameters.AddWithValue("@shift", finishedShift);
                cmd.Parameters.AddWithValue("@date", finishedDate);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                        DbHelper.connection.Close();
                        return count;
                    }
                }

                DbHelper.connection.Close();
                return count;
            }
            catch (Exception)
            {

                DbHelper.connection.Close();
                return count;
            }
        }

    }
}
