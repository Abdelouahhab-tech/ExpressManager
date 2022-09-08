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
    public class FamilyController : UserController
    {
        // Insert New Family

        public void InsertFamily(string familyName,string userId)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Family (FAM,UserID) VALUES('"+ familyName+"','"+ userId+"')";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);

                int result = cmd.ExecuteNonQuery();

                if(result == 1)
                {
                    MessageBox.Show("Data Inserted Successfuly");
                }
                else
                {
                    MessageBox.Show("It Was An Error");
                }

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                DbHelper.connection.Close();
            }
        }

        // Fetch All The Records From Area Table

        public List<FamilyModel> fetchRecords()
        {
            List<FamilyModel> list = new List<FamilyModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT F.FAM,U.FullName from Family F, dbo_User U where F.UserID = U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FamilyModel family = new FamilyModel();
                        family.FamilyName = reader[0].ToString();
                        family.UserID = reader[1].ToString();
                        list.Add(family);
                    }

                    DbHelper.connection.Close();
                    return list;
                }
                else
                {
                    MessageBox.Show("No Data To Show", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DbHelper.connection.Close();
                    return list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return list;
            }
        }

        // Fetch Single Record From Area Table

        public FamilyModel fetchSingleFamily(string familyName)
        {
            FamilyModel family = new FamilyModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT F.FAM,U.FullName from Family F,dbo_User U WHERE F.UserID = U.userID and F.FAM =@familyName";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@familyName", familyName);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        family.FamilyName = reader[0].ToString();
                        family.UserID = reader[1].ToString();
                    }

                    DbHelper.connection.Close();
                    return family;
                }

                return family;
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return family;
            }
        }
    }
}
