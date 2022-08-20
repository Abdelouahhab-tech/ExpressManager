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
    public class MachineController : UserController
    {
        // Insert Data Into Machine Table

        public void InsertMachine(MachineModel Machine)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Machine VALUES(@Machine,@parentZone,@userID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@Machine", Machine.Machine);
                cmd.Parameters.AddWithValue("@parentZone", Machine.ParentZone);
                cmd.Parameters.AddWithValue("@userID", Machine.UserID);

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

        // Update Data Into Machine Table

        public void UpdateMachine(MachineModel Machine)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Machine SET ParentZone=@parentZone ,UserID = @userID WHERE Machine = @Machine";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@parentZone", Machine.ParentZone);
                cmd.Parameters.AddWithValue("@userID", Machine.UserID);
                cmd.Parameters.AddWithValue("@Machine", Machine.Machine);

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

        public List<MachineModel> fetchRecords()
        {

            List<MachineModel> list = new List<MachineModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT M.*,U.FullName FROM Machine M,dbo_User U WHERE M.userID=U.userID";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MachineModel machine = new MachineModel();
                        machine.Machine = reader[0].ToString();
                        machine.ParentZone = reader[1].ToString();
                        machine.UserID = reader[3].ToString();
                        list.Add(machine);
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

        // Fetch Single Record From Machine Table

        public MachineModel fetchSingleRecord(string machineName)
        {
            MachineModel machine = new MachineModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT M.*,U.FullName FROM Machine M,dbo_User U WHERE M.userID=U.userID AND M.Machine =@machineName";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machineName", machineName);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        machine.Machine = reader[0].ToString();
                        machine.ParentZone = reader[1].ToString();
                        machine.UserID = reader[3].ToString();
                    }

                    DbHelper.connection.Close();
                    return machine;
                }

                DbHelper.connection.Close();
                return machine;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return machine;
            }
        }

        // FetchRecords From Cable Table

        public List<MachineModel> fetchRecordsCMB(string value)
        {

            List<MachineModel> list = new List<MachineModel>();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT M.*,U.FullName FROM Machine M,dbo_User U WHERE M.userID=U.userID AND M.ParentZone=@value";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@value", value);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MachineModel machine = new MachineModel();
                        machine.Machine = reader[0].ToString();
                        machine.ParentZone = reader[1].ToString();
                        machine.UserID = reader[3].ToString();
                        list.Add(machine);
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

    }
}
