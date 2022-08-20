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
    public class MarkerController : UserController
    {
        // Add Data To Marker Table
        public void InsertMarker(MarkerModel marker)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Marker VALUES(@Color,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@Color", marker.MarkerColor);
                cmd.Parameters.AddWithValue("@userID", marker.UserID);

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

        // FetchRecords From Marker Table

        public List<MarkerModel> fetchRecords()
        {

            List<MarkerModel> list = new List<MarkerModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT M.Color,U.FullName FROM Marker M,dbo_User U WHERE M.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MarkerModel marker = new MarkerModel();
                        marker.MarkerColor = reader[0].ToString();
                        marker.UserID = reader[1].ToString();
                        list.Add(marker);
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

        // Fetch Single Record From Marker Table

        public MarkerModel fetchSingleRecord(string color)
        {
            MarkerModel marker = new MarkerModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT M.Color,U.FullName FROM Marker M,dbo_User U WHERE M.userID=U.userID AND M.Color =@color";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@color", color);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        marker.MarkerColor = reader[0].ToString();
                        marker.UserID = reader[1].ToString();
                    }

                    DbHelper.connection.Close();
                    return marker;
                }

                DbHelper.connection.Close();
                return marker;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return marker;
            }
        }
    }
}
