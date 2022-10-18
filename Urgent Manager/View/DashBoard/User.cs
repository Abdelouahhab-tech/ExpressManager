using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;
using Urgent_Manager.Model;

namespace Urgent_Manager.View.DashBoard
{
    public partial class User : Form
    {

        UserController userController = new UserController();
        UserModel user = new UserModel();
        DataTable wireTest = new DataTable();
        public User()
        {
            InitializeComponent();
        }

        private void icEyes_Click(object sender, EventArgs e)
        {
            if (gtxtPass.UseSystemPasswordChar)
            {
                gtxtPass.UseSystemPasswordChar = false;
                gtxtPass.PasswordChar = '\0';
                icEyes.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                gtxtPass.UseSystemPasswordChar = true;
                icEyes.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(gtxtUsername.Text.Trim() != "" && gtxtPass.Text.Trim()!= "" && cmbRole.Text.Trim() != "" && gtxtPass.Text.Trim().Length >= 4)
            {
                user.UserName = gtxtUsername.Text;
                user.Password = gtxtPass.Text;
                user.Fullname = gtxtFullName.Text != "" ? gtxtFullName.Text : "";
                user.Role = cmbRole.Text;
                user.Entry = Login.username != "" ? Login.username : "";
                user.IsUpdated = chUpdate.Checked ? 1 : 0;
                user.DbOwner = 0;

                if (!userController.IsExist(gtxtUsername.Text, "dbo_User", "userID"))
                    userController.InsertUser(user);
                else
                {
                    MessageBox.Show("This User Is Already Exist Try To Add An Other One! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblUsername.ForeColor = Color.Red;
                    gtxtUsername.Focus();
                    gtxtUsername.SelectAll();
                    gtxtUsername.FocusedState.BorderColor = Color.White;
                }
                LoadData();
                init();
                
            }
            else
            {
                if(gtxtUsername.Text.Trim() == "")
                {
                    lblUsername.ForeColor = Color.Red;
                    gtxtUsername.Focus();
                    gtxtUsername.FocusedState.BorderColor = Color.White;
                }
                else if (gtxtPass.Text.Trim() == "")
                {
                    lblPass.ForeColor = Color.Red;
                    gtxtPass.Focus();
                    gtxtPass.FocusedState.BorderColor = Color.White;
                }
                else if (cmbRole.Text.Trim() == "")
                {
                    lblRole.ForeColor = Color.Red;
                    cmbRole.Focus();
                    cmbRole.FocusedState.BorderColor = Color.White;
                }else if(gtxtPass.Text.Length < 4)
                {
                    lblPass.ForeColor = Color.Red;
                    gtxtPass.Focus();
                    gtxtPass.FocusedState.BorderColor = Color.White;
                    MessageBox.Show("Password Must Be More Than Four Letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gtxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            lblUsername.ForeColor = Color.White;
            gtxtUsername.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if (e.KeyCode == Keys.Enter)
               if(gtxtUsername.Text.Trim() != "")
                    getSingleRecord(gtxtUsername.Text);

        }

        private void gtxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            lblPass.ForeColor = Color.White;
            gtxtPass.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRole.ForeColor = Color.White;
            cmbRole.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gtxtUsername.Text.Trim() != "")
            {
                if (userController.IsExist(gtxtUsername.Text,"dbo_User","userID"))
                {
                   if(gtxtPass.Text.Trim() != "" && cmbRole.Text.Trim() != "" && gtxtPass.Text.Trim().Length >= 4)
                    {
                        UserModel user = new UserModel();
                        user.UserName = gtxtUsername.Text;
                        user.Password = gtxtPass.Text;
                        user.Role = cmbRole.Text;
                        user.Fullname = gtxtFullName.Text != "" ? gtxtFullName.Text : "";
                        user.Entry = Login.username != "" ? Login.username : "";
                        user.IsUpdated = chUpdate.Checked ? 1 : 0;

                        if (userController.IsExist(gtxtUsername.Text, "dbo_User", "userID"))
                            userController.UpdateUser(user);
                        else
                            MessageBox.Show("This User Is Not Exist! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        init();
                        LoadData();
                    }
                    else
                    {
                        if(gtxtPass.Text == "")
                        {
                            lblPass.ForeColor = Color.Red;
                            gtxtPass.Focus();
                            gtxtPass.FocusedState.BorderColor = Color.White;
                        }
                        else if (cmbRole.Text == "")
                        {
                            lblRole.ForeColor = Color.Red;
                            cmbRole.Focus();
                            cmbRole.FocusedState.BorderColor = Color.White;
                        }
                        else if (gtxtPass.Text.Length < 4)
                        {
                            lblPass.ForeColor = Color.Red;
                            gtxtPass.Focus();
                            gtxtPass.FocusedState.BorderColor = Color.White;
                            MessageBox.Show("Password Must Be More Than 4 Letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This User Doesn't Exist !", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lblUsername.ForeColor = Color.Red;
                    gtxtUsername.Focus();
                    gtxtUsername.SelectAll();
                    gtxtUsername.SelectAll();
                }
            }
            else
            {
                lblUsername.ForeColor = Color.Red;
                gtxtUsername.Focus();
                gtxtUsername.FocusedState.BorderColor = Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gtxtUsername.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Are You Sure To Delete This User ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if(result == DialogResult.Yes)
                {
                    if (userController.IsExist(gtxtUsername.Text,"dbo_User","userID"))
                    {
                        //userController.Delete(gtxtUsername.Text, "dbo_User", "userID");
                        DbHelper.connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM dbo_User WHERE userID=@id AND DbRole <> 1",DbHelper.connection);
                        cmd.Parameters.AddWithValue("@id", gtxtUsername.Text);
                        cmd.ExecuteNonQuery();
                        DbHelper.connection.Close();
                        init();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("This User Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblUsername.ForeColor = Color.Red;
                        gtxtUsername.Focus();
                        gtxtUsername.SelectAll();
                        gtxtUsername.FocusedState.BorderColor = Color.White;
                    }
                }
            }
            else
            {
                lblUsername.ForeColor = Color.Red;
                gtxtUsername.Focus();
                gtxtUsername.FocusedState.BorderColor = Color.White;
            }
        }

        private void init()
        {
            gtxtUsername.Text = "";
            gtxtPass.Text = "";
            gtxtFullName.Text = "";
            cmbRole.SelectedIndex = -1;
            chUpdate.Checked = false;
            gtxtUsername.Focus();
        }

        private void User_Load(object sender, EventArgs e)
        {
            gtxtUsername.Focus();
            LoadData();
            if (Login.DbRole == 1)
            {
                icServerConnection.Visible = true;
                icUploadUrgents.Visible = true;
            }
            
        }

        // Load Data

        private void LoadData()
        {
            // fetch Data
            guna2DataGridView1.Rows.Clear();
            List<UserModel> list;
            list = Login.DbRole == 1 ? userController.fetch(true) : userController.fetch(false);

            foreach (var user in list)
            {
                string status = user.IsUpdated == 0 ? "No" : "Yes";
                guna2DataGridView1.Rows.Add(user.UserName, user.Password, user.Fullname, user.Role, status, user.Entry);
            }   
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string userName = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(userName != null)
                {
                    getSingleRecord(userName);
                }
            }
        }

        private void gtxtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (gtxtUsername.Text == "")
            {
                init();
                LoadData();
            }else if(gtxtUsername.Text.Trim() != "")
            {
                getSingleRecord(gtxtUsername.Text);
            }
        }

        private void getSingleRecord(string userName)
        {
            if (userController.IsExist(userName, "dbo_User", "userID"))
            {
                UserModel user = new UserModel();
                user = userController.SingleRecordForUserForm(userName);
                gtxtUsername.Text = user.UserName;
                gtxtPass.Text = user.Password;
                gtxtFullName.Text = user.Fullname != "" ? user.Fullname : "";
                cmbRole.Text = user.Role;
                chUpdate.Checked = user.IsUpdated == 0 ? false : true;
                guna2DataGridView1.Rows.Clear();
                if (user.UserName != "")
                    guna2DataGridView1.Rows.Add(user.UserName, Eramake.eCryptography.Encrypt(user.Password), user.Fullname, user.Role, user.IsUpdated == 0 ? "No" : "Yes", user.Entry);
                else
                {
                    init();
                    LoadData();
                }
            }
        }

        private void icServerConnection_Click(object sender, EventArgs e)
        {
            ServerData server = new ServerData();
            server.ShowDialog();
        }

        private void icDirectories_Click(object sender, EventArgs e)
        {
            Directories directories = new Directories();
            directories.ShowDialog();
        }

        private async void icUploadUrgents_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                if(op.ShowDialog() == DialogResult.OK)
                {
                    FileStream stream = File.Open(op.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    DataTableCollection db = result.Tables;
                    wireTest.Clear();
                    wireTest = db[0];
                    lblLoading.Visible = true;
                    await Task.Run(new Action(UploadUrgents));
                    lblLoading.Visible = false;
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UploadUrgents()
        {
            try
            {
                int res = 0;
                if(wireTest.Rows.Count > 0)
                {
                    if (wireTest.Columns.Count == 3)
                    {
                        DbHelper.connection.Open();
                        string Q = "DELETE FROM Urgent";
                        SqlCommand cmmd = new SqlCommand(Q, DbHelper.connection);
                        cmmd.ExecuteNonQuery();
                        DbHelper.connection.Close();

                        for (int i = 0;i < wireTest.Rows.Count; i++)
                        {
                            if (userController.IsExist(wireTest.Rows[i][0].ToString().Trim(), "Wire", "Unico"))
                            {
                                DateTime date = Convert.ToDateTime(wireTest.Rows[i][1].ToString());
                                string date1 = Convert.ToDateTime(date).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
                                string dateUrgent = date.Hour >= 00 && date.Hour < 6 ? date1 : date.ToString("dd/MM/yyyy");
                                string time = date.ToString("HH:mm");
                                int h = date.Hour;
                                string shift = Shift(h);
                                DbHelper.connection.Open();

                                string QUERY = "INSERT INTO Urgent (UrgentUnico,DateUrgent,HUrgent,Shift,UrgentStatus,Alimentation,UserFinished,FinishedDate,isOptimized) VALUES(@Urgent,@Date,@time,@Shift,@Status,@Alimentation,@UserFinished,@FinishedDate,@isOptimized)";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);

                                cmd.Parameters.AddWithValue("@Urgent", wireTest.Rows[i][0].ToString());
                                cmd.Parameters.AddWithValue("@Date", dateUrgent);
                                cmd.Parameters.AddWithValue("@time", time);
                                cmd.Parameters.AddWithValue("@Shift", shift);
                                cmd.Parameters.AddWithValue("@Status", "Express");
                                cmd.Parameters.AddWithValue("@Alimentation", Login.username);
                                cmd.Parameters.AddWithValue("@UserFinished", "");
                                cmd.Parameters.AddWithValue("@FinishedDate", "");
                                cmd.Parameters.AddWithValue("@isOptimized", 0);

                                res += cmd.ExecuteNonQuery();

                                DbHelper.connection.Close();
                            }
                        }

                        if(res > 0)
                        {
                            MessageBox.Show($"{res} Records Was Uploaded Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Sorry The Data In Your File Didn't Mutch The Fields In Your Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                        MessageBox.Show("Sorry It Seems Like You Don't Have Any Records In Your File", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Shift(int h)
        {
            try
            {
                if(h >= 6 && h < 14)
                {
                    return "Matin";
                }else if(h >= 14 && h < 22)
                {
                    return "Soir";
                }
                else
                {
                    return "Nuit";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
