using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                user.Zone = cmbArea.Text != "" && cmbArea.Text != "None" ? cmbArea.Text : "";
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
                        user.Zone = cmbArea.Text != "" && cmbArea.Text != "None" ? cmbArea.Text : "";
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
            cmbArea.SelectedIndex = -1;
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
                icDirectories.Visible = true;
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
                guna2DataGridView1.Rows.Add(user.UserName, user.Password, user.Fullname, user.Role, user.Zone, status, user.Entry);
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
                cmbArea.Text = user.Zone != "" ? user.Zone : "";
                chUpdate.Checked = user.IsUpdated == 0 ? false : true;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(user.UserName, Eramake.eCryptography.Encrypt(user.Password),user.Fullname,user.Role,user.Zone,user.IsUpdated == 0 ? "No" : "Yes",user.Entry);
            }
            else
            {
                MessageBox.Show("This User Doesn't Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                init();
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
    }
}
