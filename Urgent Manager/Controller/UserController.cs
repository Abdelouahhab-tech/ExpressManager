using Guna.UI2.WinForms;
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
    public class UserController
    {
        // Insert Data To dbo_User
       public void InsertUser(UserModel user)
        {
            try
            {

                    DbHelper.connection.Open();

                    string QUERY = $"INSERT INTO dbo_User VALUES(@userID,@Pass,@FullName,@role,@isUpdated,@EntryAgent,@dbOwner)";

                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                    cmd.Parameters.AddWithValue("@userID", user.UserName);
                    string encryptedPass = Eramake.eCryptography.Encrypt(user.Password);
                    cmd.Parameters.AddWithValue("@Pass", encryptedPass);
                    cmd.Parameters.AddWithValue("@FullName", user.Fullname);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@isUpdated", user.IsUpdated);
                    cmd.Parameters.AddWithValue("@EntryAgent", user.Entry);
                cmd.Parameters.AddWithValue("@dbOwner", user.DbOwner);

                int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                        MessageBox.Show("Data Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sorry It Was An Error While Saving Your Data Try Again !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    DbHelper.connection.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request \n\n" + ex.Message,"Failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Delete Data From dbo_User

        public void Delete(string ID,string table,string column)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "DELETE FROM "+table+" WHERE "+column+" = @id";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@id", ID);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                    MessageBox.Show("Data Deleted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry It Was An Error While Deleting Your Data Try Again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DbHelper.connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Update Data From dbo_User

        public void UpdateUser(UserModel user)
        {
            try
            {

                DbHelper.connection.Open();

                string QUERY = $"UPDATE dbo_User SET Pass=@Pass,FullName=@FullName,role=@role,isUpdated=@isUpdated,EntryAgent=@EntryAgent WHERE userID = @id";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                string encryptedPass = Eramake.eCryptography.Encrypt(user.Password);
                cmd.Parameters.AddWithValue("@Pass", encryptedPass);
                cmd.Parameters.AddWithValue("@FullName", user.Fullname);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@isUpdated", user.IsUpdated);
                cmd.Parameters.AddWithValue("@EntryAgent", user.Entry);
                cmd.Parameters.AddWithValue("@id", user.UserName);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry It Was An Error While Updating Your Data Try Again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                DbHelper.connection.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("It Was An Error While Updating Data Try Again !\n\n" + ex.Message,"Failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }

        // Check If The User Already Exist

        public bool IsExist(string id,string table,string column)
        {
            try
            {

                DbHelper.connection.Open();

                string QUERY = "SELECT * FROM "+table+" WHERE "+column+"=@id";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DbHelper.connection.Close();
                    return true;
                }
                else
                {
                    DbHelper.connection.Close();
                    return false;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return false;
            }
        }

        // Get Data From dbo_User

        public List<UserModel> fetch(bool dbRole)
        {
            List<UserModel> list = new List<UserModel>();

            try
            {
                DbHelper.connection.Open();

                string QUERY = dbRole ? $"SELECT * FROM dbo_User" : $"SELECT * FROM dbo_User WHERE DbRole <> 1 AND role <> 'Administrator'";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserModel user = new UserModel();
                        user.UserName = reader[0].ToString();
                        user.Password = reader[1].ToString();
                        user.Fullname = reader[2].ToString();
                        user.Role = reader[3].ToString();
                        user.IsUpdated = Convert.ToInt32(reader[4]);
                        user.Entry = reader[5].ToString();
                        user.DbOwner = Convert.ToInt32(reader[6]);
                        list.Add(user);
                    }

                    DbHelper.connection.Close();
                    DbHelper.connection.Open();
                    string Q = $"SELECT * FROM dbo_User WHERE DbRole <> 1 AND userID=@user";
                    SqlCommand command = new SqlCommand(Q, DbHelper.connection);
                    command.Parameters.AddWithValue("@user", Login.username);
                    SqlDataReader r = command.ExecuteReader();

                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            UserModel user = new UserModel();
                            user.UserName = r[0].ToString();
                            user.Password = r[1].ToString();
                            user.Fullname = r[2].ToString();
                            user.Role = r[3].ToString();
                            user.IsUpdated = Convert.ToInt32(r[4]);
                            user.Entry = r[5].ToString();
                            user.DbOwner = Convert.ToInt32(r[6]);
                            list.Add(user);
                        }
                    }

                    DbHelper.connection.Close();
                    return list;
                }
                else
                {
                    DbHelper.connection.Close();
                    return list;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("It Was An Error While Fethcing Data !\n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return list;
            }
        }

        // Get Single User From dbo_User

        public UserModel SingleRecord(string id)
        {
            UserModel user = new UserModel();

            try
            {

                DbHelper.connection.Open();

                string QUERY = $"SELECT * FROM dbo_User WHERE userID=@userID";
                SqlCommand cmd = new SqlCommand(QUERY,DbHelper.connection);
                cmd.Parameters.AddWithValue("@userID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.UserName = reader[0].ToString();
                        user.Password = Eramake.eCryptography.Decrypt(reader[1].ToString());
                        user.Fullname = reader[2].ToString();
                        user.Role = reader[3].ToString();
                        user.IsUpdated = Convert.ToInt32(reader[4]);
                        user.DbOwner = Convert.ToInt32(reader[6]);
                    }

                    DbHelper.connection.Close();
                    return user;
                }

                DbHelper.connection.Close();
                return user;

            }catch(Exception ex)
            {
                MessageBox.Show("It Was An Error While Fetching Data Try Again ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return user;
            }
        }

        // Get Single User From dbo_User

        public UserModel SingleRecordForUserForm(string id)
        {
            UserModel user = new UserModel();

            try
            {

                DbHelper.connection.Open();

                string QUERY = id == Login.username && Login.DbRole == 0 ? $"SELECT * FROM dbo_User WHERE userID=@userID" : Login.DbRole == 1 ? $"SELECT * FROM dbo_User WHERE userID=@userID" : $"SELECT * FROM dbo_User WHERE userID=@userID AND role <> 'Administrator'";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@userID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.UserName = reader[0].ToString();
                        user.Password = Eramake.eCryptography.Decrypt(reader[1].ToString());
                        user.Fullname = reader[2].ToString();
                        user.Role = reader[3].ToString();
                        user.IsUpdated = Convert.ToInt32(reader[4]);
                        user.DbOwner = Convert.ToInt32(reader[6]);
                    }

                    DbHelper.connection.Close();
                    return user;
                }

                DbHelper.connection.Close();
                return user;

            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Fetching Data Try Again ! \n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return user;
            }
        }

        // Check If The User Is Authenticated

        public bool IsAuth(string username,string password)
        {
            try
            {

                DbHelper.connection.Open();

                string QUERY = $"SELECT * FROM dbo_User WHERE userID=@userId and Pass=@pass";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@userId", username);
                cmd.Parameters.AddWithValue("@pass", password);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DbHelper.connection.Close();
                    return true;
                }
                else
                {
                    DbHelper.connection.Close();
                    return false;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request!\n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return false;
            }
        }

        // Check If The User Is Login For The First Time

        public bool IsLoggingForTheFirstTime(string username)
        {
            try
            {
                DbHelper.connection.Open();
                string QUERY = $"SELECT isUpdated FROM dbo_User WHERE userID=@userId and isUpdated=@isUpdated";
                SqlCommand cmd = new SqlCommand(QUERY,DbHelper.connection);
                cmd.Parameters.AddWithValue("@userID", username);
                cmd.Parameters.AddWithValue("@isupdated", 1);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DbHelper.connection.Close();
                    return true;
                }
                else
                {
                    DbHelper.connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request Try Again !\n\n" + ex.Message,"Failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return false;
            }
        }

        // Update User's Credentials

        public int UpdatePass(string username,string pass)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = $"UPDATE dbo_User SET Pass= @pass,isUpdated=@isUpdated WHERE userID=@userId";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@isUpdated", 1);
                cmd.Parameters.AddWithValue("@userId", username);
                int result = cmd.ExecuteNonQuery();
                DbHelper.connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error While Processing Your Request Try Again !\n\n" + ex.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
                return 0;
            }
        }

        // Fill Combobox With Data

        public void FillCombobox(string table,string column,Guna2ComboBox cmb)
        {
            try
            {
                DbHelper.connection.Open();

                string QUERY = "SELECT "+column+" FROM "+table+" ORDER BY "+column+"";
                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cmb.Items.Add(reader[0].ToString());
                    }
                }

                DbHelper.connection.Close();
            }
            catch (Exception ex)
            {
                DbHelper.connection.Close();
            }
        }
    }
}
