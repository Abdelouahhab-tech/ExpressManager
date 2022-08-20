using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Model;
using Guna.UI2.WinForms;
using System.Data;
using System.Collections;

namespace Urgent_Manager.Controller
{
    public class WireController : UserController
    {
        // Insert Data Into Wire Table

        public void InsertWire(WireModel wire)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "INSERT INTO Wire VALUES(@Family,@Unico,@LeadCode,@Cable,@Length,@MarkL,@SealL,@TerL,@ToolL,@ProtectionL,@MarkR,@SealR,@TerR,@ToolR,@ProtectionR,@GroupRef,@MC,@Adress,@LeadPrep,@UserID)";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@Family", wire.Family);
                cmd.Parameters.AddWithValue("@Unico", wire.Unico);
                cmd.Parameters.AddWithValue("@LeadCode", wire.LeadCode);
                cmd.Parameters.AddWithValue("@Cable", wire.Cable);
                cmd.Parameters.AddWithValue("@Length", wire.Length);
                cmd.Parameters.AddWithValue("@MarkL", wire.MarkL);
                cmd.Parameters.AddWithValue("@SealL", wire.SealL);
                cmd.Parameters.AddWithValue("@TerL", wire.TerL);
                cmd.Parameters.AddWithValue("@ToolL", wire.ToolL);
                cmd.Parameters.AddWithValue("@ProtectionL", wire.ProtectionL);
                cmd.Parameters.AddWithValue("@MarkR", wire.MarkR);
                cmd.Parameters.AddWithValue("@SealR", wire.SealR);
                cmd.Parameters.AddWithValue("@TerR", wire.TerR);
                cmd.Parameters.AddWithValue("@ToolR", wire.ToolR);
                cmd.Parameters.AddWithValue("@ProtectionR", wire.ProtectionR);
                cmd.Parameters.AddWithValue("@GroupRef", wire.GroupRef);
                cmd.Parameters.AddWithValue("@MC", wire.Mc);
                cmd.Parameters.AddWithValue("@Adress", wire.Adress);
                cmd.Parameters.AddWithValue("@LeadPrep", wire.LeadPrep);
                cmd.Parameters.AddWithValue("@UserID", wire.UserID);

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

        // Update Data Into Wire Table
        public void UpdateWire(WireModel wire)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Wire SET Family = @Family,LeadCode = @LeadCode,Cable=@Cable,WireLength=@Length,MarL=@MarkL,SealL=@SealL,TerL=@TerL,ToolL=@ToolL,ProtectionL=@ProtectionL,MarR=@MarkR,SealR=@SealR,TerR=@TerR,ToolR=@ToolR,ProtectionR=@ProtectionR,Groupe=@GroupRef,MC=@MC,Adress=@Adress,LeadPrep=@LeadPrep,UserID=@UserID WHERE Unico = @Unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@Family", wire.Family);
                cmd.Parameters.AddWithValue("@LeadCode", wire.LeadCode);
                cmd.Parameters.AddWithValue("@Cable", wire.Cable);
                cmd.Parameters.AddWithValue("@Length", wire.Length);
                cmd.Parameters.AddWithValue("@MarkL", wire.MarkL);
                cmd.Parameters.AddWithValue("@SealL", wire.SealL);
                cmd.Parameters.AddWithValue("@TerL", wire.TerL);
                cmd.Parameters.AddWithValue("@ToolL", wire.ToolL);
                cmd.Parameters.AddWithValue("@ProtectionL", wire.ProtectionL);
                cmd.Parameters.AddWithValue("@MarkR", wire.MarkR);
                cmd.Parameters.AddWithValue("@SealR", wire.SealR);
                cmd.Parameters.AddWithValue("@TerR", wire.TerR);
                cmd.Parameters.AddWithValue("@ToolR", wire.ToolR);
                cmd.Parameters.AddWithValue("@ProtectionR", wire.ProtectionR);
                cmd.Parameters.AddWithValue("@GroupRef", wire.GroupRef);
                cmd.Parameters.AddWithValue("@MC", wire.Mc);
                cmd.Parameters.AddWithValue("@Adress", wire.Adress);
                cmd.Parameters.AddWithValue("@LeadPrep", wire.LeadPrep);
                cmd.Parameters.AddWithValue("@UserID", wire.UserID);
                cmd.Parameters.AddWithValue("@Unico", wire.Unico);

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


        // Fetch All The Records
        public void fetchRecords(Guna2DataGridView dg)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Family,W.Unico,W.LeadCode,C.Cable,C.Section,C.Color,C.Pvc,C.Guide,W.WireLength,W.TerL,W.ToolL,W.SealL,W.TerR,W.ToolR,W.SealR,W.MC,W.Adress,U.FullName as 'Entry Agent' FROM Wire W,Cable C,dbo_User U WHERE W.Cable = C.Cable AND U.userID = W.UserID ORDER BY W.Groupe ";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dg.DataSource = dt.DefaultView;
                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        public void fetchRecords(Guna2DataGridView dg,ArrayList list)
        {
            string columns = "";
            foreach(string item in list)
            {
                columns += "W." + item + ",";
            }

            try
            {
                DbHelper.connection.Open();

                string QUERY = columns != "" ? "SELECT W.Family,W.Unico,W.LeadCode,C.Cable,C.Section,C.Color,C.Pvc,C.Guide,W.WireLength," + columns+"W.TerL,W.ToolL,W.SealL,W.TerR,W.ToolR,W.SealR,W.MC,W.Adress,U.FullName as 'Entry Agent' FROM Wire W,Cable C,dbo_User U WHERE W.Cable = C.Cable AND U.userID = W.UserID ORDER BY W.Groupe" : "SELECT W.Family,W.Unico,W.LeadCode,C.Cable,C.Color,C.Pvc,C.Guide,W.WireLength,W.TerL,W.ToolL,W.SealL,W.TerR,W.ToolR,W.SealR,W.MC,W.Adress,U.FullName as 'Entry Agent' FROM Wire W,Cable C,dbo_User U WHERE W.Cable = C.Cable AND U.userID = W.UserID ORDER BY W.Groupe ";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dg.DataSource = dt.DefaultView;
                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Fetch Single Record Per Unico
        public void fetchRecords(Guna2DataGridView dg,ArrayList list,string unico)
        {

            string columns = "";
            foreach (string item in list)
            {
                columns += "W." + item + ",";
            }
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Family,W.Unico,W.LeadCode,C.Cable,C.Section,C.Color,C.Pvc,C.Guide,W.WireLength," + columns+"W.TerL,W.ToolL,W.SealL,W.TerR,W.ToolR,W.SealR,W.MC,W.Adress,U.FullName as 'Entry Agent' FROM Wire W,Cable C,dbo_User U WHERE W.Cable = C.Cable AND U.userID = W.UserID AND W.Unico = @unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@unico", unico);
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dg.DataSource = dt.DefaultView;
                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Fetch Single Record Per Machine
        public void fetchRecordsPerMachine(Guna2DataGridView dg, ArrayList list, string column,string value)
        {

            string columns = "";
            foreach (string item in list)
            {
                columns += "W." + item + ",";
            }
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Family,W.Unico,W.LeadCode,C.Cable,C.Section,C.Color,C.Pvc,C.Guide,W.WireLength," + columns + "W.TerL,W.ToolL,W.SealL,W.TerR,W.ToolR,W.SealR,W.MC,W.Adress,U.FullName as 'Entry Agent' FROM Wire W,Cable C,dbo_User U WHERE W.Cable = C.Cable AND U.userID = W.UserID AND W."+column+" = @value ORDER BY Groupe";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@value", value);
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dg.DataSource = dt.DefaultView;
                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Fetch Single Record

        public WireModel fetchSingleRecord(string unico)
        {
            WireModel wire = new WireModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Unico,W.LeadCode,W.WireLength,C.Cable,W.LeadPrep,W.Adress,W.TerL,W.TerR,W.SealL,W.SealR,W.MarL,W.MarR,W.ProtectionL,W.ProtectionR,W.ToolL,W.ToolR,W.Family,W.Groupe,W.MC FROM Wire W,Cable C WHERE W.Cable = C.Cable AND W.Unico = @unico";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@unico",unico);

                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        wire.Unico = r[0].ToString();
                        wire.LeadCode = r[1].ToString();
                        wire.Length = r[2].ToString();
                        wire.Cable = r[3].ToString();
                        wire.LeadPrep = r[4].ToString();
                        wire.Adress = r[5].ToString();
                        wire.TerL = r[6].ToString();
                        wire.TerR = r[7].ToString();
                        wire.SealL = r[8].ToString();
                        wire.SealR = r[9].ToString();
                        wire.MarkL = r[10].ToString();
                        wire.MarkR = r[11].ToString();
                        wire.ProtectionL = r[12].ToString();
                        wire.ProtectionR = r[13].ToString();
                        wire.ToolL = r[14].ToString();
                        wire.ToolR = r[15].ToString();
                        wire.Family = r[16].ToString();
                        wire.GroupRef = r[17].ToString();
                        wire.Mc = r[18].ToString();
                    }

                    DbHelper.connection.Close();
                    return wire;
                }

                DbHelper.connection.Close();
                return wire;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return wire;
            }
        }

        // Fetch Records Per Machine For Operator User

        public List<WireModel> fetchNormalRecords(string machine)
        {

            List<WireModel> list = new List<WireModel>();
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT W.Family,W.Unico,W.LeadCode,C.Color,W.WireLength,W.Groupe,W.LeadPrep FROM Wire W,Cable C WHERE W.Cable = C.Cable AND W.MC=@machine ORDER BY W.Groupe";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machine", machine);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        WireModel wire = new WireModel();
                        wire.Family = reader[0].ToString();
                        wire.Unico = reader[1].ToString();
                        wire.LeadCode = reader[2].ToString();
                        wire.Color = reader[3].ToString();
                        wire.Length = reader[4].ToString();
                        wire.GroupRef = reader[5].ToString();
                        wire.LeadPrep = reader[6].ToString();
                      
                        list.Add(wire);
                    }

                    DbHelper.connection.Close();
                    return list;
                }

                DbHelper.connection.Close();
                return list;
            }
            catch (Exception)
            {
                DbHelper.connection.Close();
                return list;
            }
        }



        // Fetch Single Normal Record Depend On Machine

        public WireModel fetchNormalSingleRecord(string machine,string unico)
        {
            WireModel wire = new WireModel();
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT W.Unico,W.LeadCode,M.Machine,W.Adress,W.Cable,W.MarL,W.MarR,W.SealL,W.SealR,W.TerL,W.TerR,W.ToolL,W.ToolR FROM Wire W,Machine M WHERE M.Machine=W.MC AND W.Unico=@unico AND W.MC=@machine";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@machine", machine);
                cmd.Parameters.AddWithValue("@unico", unico);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        wire.Unico = reader[0].ToString();
                        wire.LeadCode = reader[1].ToString();
                        wire.Mc = reader[2].ToString();
                        wire.Adress = reader[3].ToString();
                        wire.Cable = reader[4].ToString();
                        wire.MarkL = reader[5].ToString();
                        wire.MarkR = reader[6].ToString();
                        wire.SealL = reader[7].ToString();
                        wire.SealR = reader[8].ToString();
                        wire.TerL = reader[9].ToString();
                        wire.TerR = reader[10].ToString();
                        wire.ToolL = reader[11].ToString();
                        wire.ToolR = reader[12].ToString();
                    }

                    DbHelper.connection.Close();
                    return wire;
                }

                DbHelper.connection.Close();
                return wire;
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
                return wire;
            }
        }

        // Fetch Cable Data

        public CableModel fetchCable(string cableName)
        {
                CableModel cable = new CableModel();
            try
            {
                DbHelper.connection.Open();
                string QUERY = "SELECT Section,Color FROM Cable WHERE Cable =@cable";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@cable", cableName);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cable.Section = reader[0].ToString();
                        cable.Color = reader[1].ToString();
                    }
                    DbHelper.connection.Close();
                    return cable;
                }

                DbHelper.connection.Close();
                return cable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error Try Again\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return cable;
            }
        }

        // Update Wire Per Machine Or Per Groupe

        public void UpdateWirePerGroupMC(string column,string oldValue,string newValue)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "UPDATE Wire SET "+column+"=@newValue WHERE "+column+"=@oldValue";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@newValue", newValue);
                cmd.Parameters.AddWithValue("@oldValue", oldValue);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("It Was An Error While Processing Your Request Try Again\n\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error Try Again\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

    }
}