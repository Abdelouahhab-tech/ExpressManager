using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;
using Urgent_Manager.Model;
using Urgent_Manager.View;
using Urgent_Manager.View.DashBoard;

namespace Urgent_Manager
{
    public partial class Login : Form
    {
        private bool isUpdate = false;
        private bool update = false;
        public static string username = "";
        public static string FullName = "";
        public static string role = "";
        UserController controller = new UserController();
        public Login()
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

        private void icUpdatedPass_Click(object sender, EventArgs e)
        {
            if (gtxtUpdatedPass.UseSystemPasswordChar)
            {
                gtxtUpdatedPass.UseSystemPasswordChar = false;
                gtxtUpdatedPass.PasswordChar = '\0';
                icUpdatedPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                gtxtUpdatedPass.UseSystemPasswordChar = true;
                icUpdatedPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            btnLogin.Location = new Point(28,270);
            this.Size = new Size(755, 500);
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRoles.Text.Trim() != "Operator")
            {
                update = false;
                gtxtUserName.Text = "";
                gtxtPass.Text = "";
                gtxtUserName.Focus();
                if (!isUpdate)
                {
                    gtxtUpdatedPass.Visible = false;
                    icUpdatedPass.Visible = false;
                    gtxtUserName.Visible = true;
                    gtxtUserName.Focus();
                    gtxtPass.Visible = true;
                    icEyes.Visible = true;
                    btnLogin.Visible = true;
                    btnLogin.Location = new Point(28,400);
                    lblLoading.Location = new Point(28, 480);
                    this.Size = new Size(755, 600);
                    btnLogin.Image = Properties.Resources.user__1_;
                    btnLogin.Text = "Log In";
                }
                else
                {
                    gtxtUserName.Visible = true;
                    gtxtPass.Visible = true;
                    icEyes.Visible = true;
                    btnLogin.Visible = true;
                    btnLogin.Location = new Point(28, 400);
                    lblLoading.Location = new Point(28, 480);
                    this.Size = new Size(755, 600);
                    btnLogin.Image = Properties.Resources.user__1_;
                    btnLogin.Text = "Log In";
                }
            }
            else
            {
                lblLoading.Visible = true;
                lblLoading.Location = new Point(28, 270);
                Operateur op = new Operateur();
                op.Show();
                Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If The Users Role Is Different To Operateur

            if(cmbRoles.Text.Trim() != "Operator")
            {
                if (!update)
                {
                    // Check if The Required Fields Are Filled
                    if (gtxtUserName.Text.Trim() != "" && gtxtPass.Text.Trim() != "")
                    {
                        // Check The Users Credentials
                        bool isAuth = controller.IsAuth(gtxtUserName.Text,Eramake.eCryptography.Encrypt(gtxtPass.Text));
                        if (isAuth)
                        {
                            // Check If He Is Logged In For The First Time Or Not
                            isUpdate = controller.IsLoggingForTheFirstTime(gtxtUserName.Text);
                            if (isUpdate)
                            {
                                // Connect The Specific User To His Window
                                UserModel user = controller.SingleRecord(gtxtUserName.Text);
                                username = user.UserName;
                                FullName = user.Fullname;
                                role = user.Role;
                                if(user.Role == "Administrator" || user.Role == "Shift Leader" || user.Role == "Entry Agent")
                                {
                                    lblLoading.Visible = true;
                                    Dashboard dash = new Dashboard();
                                    dash.Show();
                                    Hide();
                                }else if(user.Role == "Alimentation")
                                {
                                    lblLoading.Visible = true;
                                    Alimentation alimentation = new Alimentation();
                                    alimentation.Show();
                                    Hide();
                                }
                            }
                            else
                            {
                                update = true;
                                gtxtUpdatedPass.Visible = true;
                                gtxtUpdatedPass.Focus();
                                icUpdatedPass.Visible = true;
                                gtxtUserName.Visible = true;
                                gtxtPass.Visible = true;
                                icEyes.Visible = true;
                                btnLogin.Visible = true;
                                btnLogin.Location = new Point(28, 464);
                                lblLoading.Location = new Point(28, 520);
                                btnLogin.Image = Properties.Resources.update;
                                btnLogin.Text = "Update";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sorry You Are Not Authorized To This Session !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gtxtUserName.Text = "";
                            gtxtUserName.Focus();
                            gtxtPass.Text = "";
                            lblWrongCredentials.Visible = true;
                            timer1.Start();
                        }
                    }
                    else
                    {
                        if(gtxtUserName.Text == "")
                        {

                            gtxtUserName.Focus();
                            gtxtUserName.FocusedState.BorderColor = Color.Red;
                            gtxtUserName.IconLeft = Properties.Resources.userWrong;

                        }else if(gtxtPass.Text == "")
                        {
                            gtxtPass.Focus();
                            gtxtPass.FocusedState.BorderColor = Color.Red;
                            gtxtPass.IconLeft = Properties.Resources.LockWrong;
                        }
                    }
                }
                else
                {
                    // Check If The Required Fields Are Filled
                    if (gtxtUserName.Text.Trim() != "" && gtxtPass.Text.Trim() != "" && gtxtUpdatedPass.Text != "")
                    {
                        // Check If The User Is Auth Again
                        bool isAuth = controller.IsAuth(gtxtUserName.Text, Eramake.eCryptography.Encrypt(gtxtPass.Text));
                        if (isAuth)
                        {
                            // Check If The New Password Is Different From The Old Password
                            if (gtxtPass.Text.Trim() != gtxtUpdatedPass.Text.Trim() && gtxtUpdatedPass.Text.Trim().Length >= 4)
                            {
                                // Update Users Credentials With The New Ones and Connect The User To His Specific Window
                                int result = controller.UpdatePass(gtxtUserName.Text, Eramake.eCryptography.Encrypt(gtxtUpdatedPass.Text));
                                if(result == 1)
                                {
                                    UserModel user = controller.SingleRecord(gtxtUserName.Text);
                                    username = user.UserName;
                                    FullName = user.Fullname;
                                    role = user.Role;
                                    if (user.Role == "Administrator" || user.Role == "Shift Leader" || user.Role == "Entry Agent")
                                    {
                                        lblLoading.Visible = true;
                                        Dashboard dash = new Dashboard();
                                        dash.Show();
                                        Hide();
                                    }
                                    else if (user.Role == "Alimentation")
                                    {
                                        lblLoading.Visible = true;
                                        Alimentation alimentation = new Alimentation();
                                        alimentation.Show();
                                        Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("It Was An Error While Processing Your Update !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    init();
                                }
                            }
                            else
                            {
                                if(gtxtPass.Text.Trim() == gtxtUpdatedPass.Text.Trim())
                                {
                                    // Choose a diffent Password To Your Old One
                                    MessageBox.Show("Choose a deffirent Password To Your Old One", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    gtxtUpdatedPass.Focus();
                                    gtxtUpdatedPass.SelectAll();
                                    gtxtUpdatedPass.FocusedState.BorderColor = Color.Red;
                                    gtxtUpdatedPass.IconLeft = Properties.Resources.LockWrong;
                                }else if(gtxtUpdatedPass.Text.Trim().Length < 4)
                                {
                                    MessageBox.Show("Password Must Be More Than 4 Letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    gtxtUpdatedPass.Focus();
                                    gtxtUpdatedPass.SelectAll();
                                    gtxtUpdatedPass.FocusedState.BorderColor = Color.Red;
                                    gtxtUpdatedPass.IconLeft = Properties.Resources.LockWrong;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sorry You Are Not Authorized To This Session !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gtxtUserName.Text = "";
                            gtxtUserName.Focus();
                            gtxtPass.Text = "";
                            lblWrongCredentials.Visible = true;
                            timer1.Start();
                        }
                    }
                    else
                    {
                        // All The Fields Are Required
                        if (gtxtUserName.Text == "")
                        {

                            gtxtUserName.Focus();
                            gtxtUserName.FocusedState.BorderColor = Color.Red;
                            gtxtUserName.IconLeft = Properties.Resources.userWrong;

                        }
                        else if (gtxtPass.Text == "")
                        {
                            gtxtPass.Focus();
                            gtxtPass.FocusedState.BorderColor = Color.Red;
                            gtxtPass.IconLeft = Properties.Resources.LockWrong;
                        }
                        else if (gtxtUpdatedPass.Text == "")
                        {
                            gtxtUpdatedPass.Focus();
                            gtxtUpdatedPass.FocusedState.BorderColor = Color.Red;
                            gtxtUpdatedPass.IconLeft = Properties.Resources.LockWrong;
                        }
                    }
                }
            }
        }

        private void init()
        {
            gtxtUserName.Text = "";
            gtxtPass.Text = "";
            gtxtUpdatedPass.Text = "";
            gtxtUserName.Visible = false;
            gtxtPass.Visible = false;
            gtxtUpdatedPass.Visible = false;
            icEyes.Visible = false;
            icUpdatedPass.Visible = false;
            btnLogin.Visible = false;
            cmbRoles.SelectedIndex = -1;
        }

        private void gtxtUpdatedPass_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtUpdatedPass.FocusedState.BorderColor = Color.FromArgb(255, 234, 79, 12);
            gtxtUpdatedPass.IconLeft = Properties.Resources.locked_padlock_;
            lblWrongCredentials.Visible = false;
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void gtxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

            gtxtPass.FocusedState.BorderColor = Color.FromArgb(255, 234, 79, 12);
            gtxtPass.IconLeft = Properties.Resources.locked_padlock_;
            lblWrongCredentials.Visible = false;
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count == 3)
            {
                timer1.Stop();
                lblWrongCredentials.Visible = false;
                count = 0;
                return;
            }
            count++;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gtxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtUserName.FocusedState.BorderColor = Color.FromArgb(255, 234, 79, 12);
            gtxtUserName.IconLeft = Properties.Resources.user;
            lblWrongCredentials.Visible = false;
        }
    }
}
