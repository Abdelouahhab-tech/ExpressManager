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
    public class ToolController : UserController
    {
        // Insert Data Into Tool Table

        public void InsertTool(ToolModel Tool)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Tool VALUES(@ToolID,@TerID,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@ToolID", Tool.ToolID.ToUpper());
                cmd.Parameters.AddWithValue("@TerID", Tool.TerID);
                cmd.Parameters.AddWithValue("@userID", Tool.UserID);

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


        // Update Data Into Tool Table

        public void UpdateTool(ToolModel Tool)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Tool SET TerID = @TerID,UserID = @userID WHERE ToolID = @ToolID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@TerID", Tool.TerID);
                cmd.Parameters.AddWithValue("@userID", Tool.UserID);
                cmd.Parameters.AddWithValue("@ToolID", Tool.ToolID);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry It Was An Error While Updating Your Data Try Again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // FetchRecords From Cable Table

        public List<ToolModel> fetchRecords()
        {

            List<ToolModel> list = new List<ToolModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT T.*,U.FullName FROM Tool T,dbo_User U WHERE T.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ToolModel Tool = new ToolModel();
                        Tool.ToolID = reader[0].ToString();
                        Tool.TerID = reader[1].ToString();
                        Tool.UserID = reader[3].ToString();
                        list.Add(Tool);
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

        public ToolModel fetchSingleRecord(string ToolID)
        {
            ToolModel Tool = new ToolModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT T.*,U.FullName FROM Tool T,dbo_User U WHERE T.userID=U.userID AND T.ToolID =@ToolID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@ToolID", ToolID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Tool.ToolID = reader[0].ToString();
                        Tool.TerID = reader[1].ToString();
                        Tool.UserID = reader[3].ToString();
                    }

                    DbHelper.connection.Close();
                    return Tool;
                }

                DbHelper.connection.Close();
                return Tool;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return Tool;
            }
        }
    }
}
