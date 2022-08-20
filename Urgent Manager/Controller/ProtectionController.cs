using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Model;

namespace Urgent_Manager.Controller
{
    public class ProtectionController : UserController
    {

        // Add Data To Protection Table
        public void InsertProtection(ProtectionModel protection)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Protection VALUES(@type,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@type", protection.Type);
                cmd.Parameters.AddWithValue("@userID", protection.UserID);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Data Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry It Was An Error While Saving Your Data Try Again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();

            }
        }

        // FetchRecords From Seal Table

        public List<ProtectionModel> fetchRecords()
        {

            List<ProtectionModel> list = new List<ProtectionModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT P.Type,U.FullName FROM Protection P,dbo_User U WHERE P.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProtectionModel protection = new ProtectionModel();
                        protection.Type = reader[0].ToString();
                        protection.UserID = reader[1].ToString();
                        list.Add(protection);
                    }

                    DbHelper.connection.Close();
                    return list;
                }

                DbHelper.connection.Close();
                return list;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return list;
            }
        }

        // Fetch Single Record From Seal Table

        public ProtectionModel fetchSingleRecord(string type)
        {
            ProtectionModel protection = new ProtectionModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT P.Type,U.FullName FROM Protection P,dbo_User U WHERE P.userID=U.userID AND P.Type =@type";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@type", type);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        protection.Type = reader[0].ToString();
                        protection.UserID = reader[1].ToString();
                    }

                    DbHelper.connection.Close();
                    return protection;
                }

                DbHelper.connection.Close();
                return protection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return protection;
            }
        }
    }
}
