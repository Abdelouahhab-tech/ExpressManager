using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urgent_Manager
{
    public partial class ServerAccess : Form
    {
        public ServerAccess()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(gtxtUsername.Text.Trim() != "" && gtxtPass.Text.Trim() != "")
                {
                    if (gtxtUsername.Text == Properties.Settings.Default.userConnect && gtxtPass.Text == Properties.Settings.Default.userPass)
                    {
                        ServerData server = new ServerData();
                        lblLoading.Visible = true;
                        Hide();
                        server.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sorry You Don't Have Access !", "Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gtxtUsername.Focus();
                        gtxtUsername.SelectAll();
                    }
                }
                else
                {
                    if(gtxtUsername.Text == "")
                    {
                        gtxtUsername.Focus();
                        gtxtUsername.FocusedState.BorderColor = Color.Red;
                        gtxtUsername.IconLeft = Properties.Resources.userWrong;

                    }else if(gtxtPass.Text == "")
                    {
                        gtxtPass.Focus();
                        gtxtPass.FocusedState.BorderColor = Color.Red;
                        gtxtPass.IconLeft = Properties.Resources.LockWrong;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request Try Again !\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gtxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtUsername.FocusedState.BorderColor = Color.FromArgb(255,94,148,255);
            gtxtUsername.IconLeft = Properties.Resources.user;
            if (gtxtUsername.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                gtxtPass.Focus();
                gtxtPass.SelectAll();
            }
        }

        private void gtxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtPass.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            gtxtPass.IconLeft = Properties.Resources.locked_padlock_;
            if (gtxtPass.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
