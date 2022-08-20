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
    public class TerminalController : UserController
    {

        // Insert Data Into Terminal Table

        public void InsertTerminal(TerminalModel Terminal)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Terminal VALUES(@TerID,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@TerID", Terminal.TerID);
                cmd.Parameters.AddWithValue("@userID", Terminal.UserID);

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

        // FetchRecords From Cable Table

        public List<TerminalModel> fetchRecords()
        {

            List<TerminalModel> list = new List<TerminalModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT T.TerminalID,U.FullName FROM Terminal T,dbo_User U WHERE T.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TerminalModel Terminal = new TerminalModel();
                        Terminal.TerID = reader[0].ToString();
                        Terminal.UserID = reader[1].ToString();
                        list.Add(Terminal);
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

        // Fetch Single Record From Cable Table

        public TerminalModel fetchSingleRecord(string Terminal)
        {
            TerminalModel Ter = new TerminalModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT T.TerminalID,U.FullName FROM Terminal T,dbo_User U WHERE T.userID=U.userID AND T.TerminalID =@TerID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@TerID", Terminal);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Ter.TerID = reader[0].ToString();
                        Ter.UserID = reader[1].ToString();
                    }

                    DbHelper.connection.Close();
                    return Ter;
                }

                DbHelper.connection.Close();
                return Ter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return Ter;
            }
        }
    }
}
