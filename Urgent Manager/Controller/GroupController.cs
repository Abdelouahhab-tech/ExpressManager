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
    public class GroupController : UserController
    {
        // Add Data To Groupe Table
        public void InsertGroup(GroupModel groupe)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Groupe VALUES(@groupRef,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@groupRef", groupe.Group);
                cmd.Parameters.AddWithValue("@userID", groupe.UserID);

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

        // FetchRecords From Group Table

        public List<GroupModel> fetchRecords()
        {

            List<GroupModel> list = new List<GroupModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT G.GroupRef,U.FullName FROM Groupe G,dbo_User U WHERE G.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        GroupModel group = new GroupModel();
                        group.Group = reader[0].ToString();
                        group.UserID = reader[1].ToString();
                        list.Add(group);
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

        public GroupModel fetchSingleRecord(string groupRef)
        {
            GroupModel group = new GroupModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT G.GroupRef,U.FullName FROM Groupe G,dbo_User U WHERE G.userID=U.userID AND G.GroupRef =@groupRef";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@groupRef", groupRef);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        group.Group = reader[0].ToString();
                        group.UserID = reader[1].ToString();
                    }

                    DbHelper.connection.Close();
                    return group;
                }

                DbHelper.connection.Close();
                return group;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return group;
            }
        }
    }
}
