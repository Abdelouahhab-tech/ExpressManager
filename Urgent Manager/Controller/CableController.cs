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
    public class CableController : UserController
    {
        // Insert Data Into Cable Table

        public void InsertCable(CableModel cable)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Cable VALUES(@cableRef,@section,@pvc,@color,@guide,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY,DbHelper.connection);
                cmd.Parameters.AddWithValue("@cableRef",cable.Cable);
                cmd.Parameters.AddWithValue("@section", cable.Section);
                cmd.Parameters.AddWithValue("@pvc", cable.Pvc);
                cmd.Parameters.AddWithValue("@color", cable.Color);
                cmd.Parameters.AddWithValue("@guide", cable.Guide);
                cmd.Parameters.AddWithValue("@userID", cable.UserID);

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

        // Update Data Into Cable Table

        public void UpdateCable(CableModel cable)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Cable SET Section = @section,Pvc = @pvc,Color = @color,Guide=@guide,UserID = @userID WHERE Cable = @cableRef";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@section",cable.Section);
                cmd.Parameters.AddWithValue("@pvc", cable.Pvc);
                cmd.Parameters.AddWithValue("@color", cable.Color);
                cmd.Parameters.AddWithValue("@guide", cable.Guide);
                cmd.Parameters.AddWithValue("@userID", cable.UserID);
                cmd.Parameters.AddWithValue("@cableRef", cable.Cable);

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

        public List<CableModel> fetchRecords()
        {

            List<CableModel> list = new List<CableModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT C.*,U.FullName FROM Cable C,dbo_User U WHERE C.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CableModel cable = new CableModel();
                        cable.Cable = reader[0].ToString();
                        cable.Section = reader[1].ToString();
                        cable.Pvc = reader[2].ToString();
                        cable.Color = reader[3].ToString();
                        cable.Guide = reader[4].ToString();
                        cable.UserID = reader[6].ToString();
                        list.Add(cable);
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

        public CableModel fetchSingleRecord(string cableRef)
        {
            CableModel cable = new CableModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT C.*,U.FullName FROM Cable C,dbo_User U WHERE C.userID=U.userID AND C.Cable =@cableRef";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@cableRef",cableRef);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cable.Cable = reader[0].ToString();
                        cable.Section = reader[1].ToString();
                        cable.Pvc = reader[2].ToString();
                        cable.Color = reader[3].ToString();
                        cable.Guide = reader[4].ToString();
                        cable.UserID = reader[6].ToString();
                    }

                    DbHelper.connection.Close();
                    return cable;
                }

                DbHelper.connection.Close();
                return cable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return cable;
            }
        }
    }
}
