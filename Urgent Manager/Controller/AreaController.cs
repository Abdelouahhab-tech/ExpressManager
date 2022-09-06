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
    public class AreaController : UserController
    {
        // Insert Records Into Area Table

        public void InsertArea(AreaModel area)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Area VALUES(@area,@parentArea,@userid)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@area", area.AreaName);
                cmd.Parameters.AddWithValue("@parentArea", area.ParentArea);
                cmd.Parameters.AddWithValue("@userid", area.UserID);

                int result = cmd.ExecuteNonQuery();

                if(result == 1)
                {
                    MessageBox.Show("Your Data Inserted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("It Was An Error While Inserting Your Data Try Again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Update Records Into Area Table
        
        public void UpdateArea(AreaModel area,string AreaName)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Area SET ParentZone=@parentArea,UserID=@userid WHERE ZoneName=@areaName";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@parentArea", area.ParentArea);
                cmd.Parameters.AddWithValue("@userid", area.UserID);
                cmd.Parameters.AddWithValue("@areaName", area.AreaName);

                int result = cmd.ExecuteNonQuery();

                if(result > 0)
                {
                    MessageBox.Show("Your Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("It Was An Error While Updating Your Data Try Again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Fetch All The Records From Area Table

        public List<AreaModel> fetchRecords()
        {
            List<AreaModel> list = new List<AreaModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT * FROM Area ORDER BY ZoneName";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        AreaModel area = new AreaModel();
                        area.AreaName = reader[0].ToString();
                        area.ParentArea = reader[1].ToString();
                        area.UserID = reader[2].ToString();
                        list.Add(area);
                    }

                    DbHelper.connection.Close();
                    return list;
                }
                DbHelper.connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return list;
            }
        }

        // Fetch Single Record From Area Table

        public AreaModel fetchSingleArea(string areaName)
        {
            AreaModel area = new AreaModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT * FROM Area WHERE ZoneName=@areaName";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@areaName", areaName);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        area.AreaName = reader[0].ToString();
                        area.ParentArea = reader[1].ToString();
                        area.UserID = reader[2].ToString();
                    }

                    DbHelper.connection.Close();
                    return area;
                }

                DbHelper.connection.Close();
                return area;
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return area;
            }
        }

    }
}
