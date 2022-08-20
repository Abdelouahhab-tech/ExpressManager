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
    public class SealController : UserController
    {

        public void InsertSeal(SealModel seal)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Seal VALUES(@seal,@color,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@seal", seal.SealID);
                cmd.Parameters.AddWithValue("@color", seal.Color);
                cmd.Parameters.AddWithValue("@userID", seal.UserID);

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

        // Update Data Into Seal Table

        public void UpdateSeal(SealModel seal)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Seal SET Color = @color,UserID = @userID WHERE Seal = @seal";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@color", seal.Color);
                cmd.Parameters.AddWithValue("@userID", seal.UserID);
                cmd.Parameters.AddWithValue("@seal", seal.SealID);

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

        // FetchRecords From Seal Table

        public List<SealModel> fetchRecords()
        {

            List<SealModel> list = new List<SealModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT S.*,U.FullName FROM Seal S,dbo_User U WHERE S.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SealModel seal = new SealModel();
                        seal.SealID = reader[0].ToString();
                        seal.Color = reader[1].ToString() != "Null" ? reader[1].ToString() : "Empty";
                        seal.UserID = reader[3].ToString();
                        list.Add(seal);
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

        public SealModel fetchSingleRecord(string sealRef)
        {
            SealModel seal = new SealModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT S.*,U.FullName FROM Seal S,dbo_User U WHERE S.userID=U.userID AND S.Seal =@seal";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@seal", sealRef);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        seal.SealID = reader[0].ToString();
                        seal.Color = reader[1].ToString() != "Null" ? reader[1].ToString() : "Empty";
                        seal.UserID = reader[3].ToString();
                    }

                    DbHelper.connection.Close();
                    return seal;
                }

                DbHelper.connection.Close();
                return seal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return seal;
            }
        }
    }
}
