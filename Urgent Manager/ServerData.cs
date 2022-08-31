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

namespace Urgent_Manager
{
    public partial class ServerData : Form
    {

        WPCSController wpcsController = new WPCSController();
        public ServerData()
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

        private void iconPictureBox1_Click(object sender, EventArgs e)
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
            try
            {
                if(gtxtServerName.Text.Trim() != "" && gtxtDbName.Text.Trim() != "" && gtxtUser.Text.Trim() != "" && gtxtPass.Text.Trim() != "")
                {
                    Properties.Settings.Default.ServerName = gtxtServerName.Text;
                    Properties.Settings.Default.DatabaseName = gtxtDbName.Text;
                    Properties.Settings.Default.userName = gtxtUser.Text;
                    Properties.Settings.Default.password = gtxtPass.Text;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();

                    Application.Exit();
                }
                else
                {
                    if(gtxtServerName.Text == "")
                    {

                        gtxtServerName.Focus();
                        gtxtServerName.FocusedState.BorderColor = Color.Red;

                    }else if(gtxtDbName.Text == "")
                    {
                        gtxtDbName.Focus();
                        gtxtDbName.FocusedState.BorderColor = Color.Red;
                    }
                    else if(gtxtUser.Text == "")
                    {
                        gtxtUser.Focus();
                        gtxtUser.FocusedState.BorderColor = Color.Red;
                    }
                    else if(gtxtPass.Text == "")
                    {
                        gtxtPass.Focus();
                        gtxtPass.FocusedState.BorderColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void gtxtServerName_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtServerName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if (gtxtServerName.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                gtxtDbName.Focus();
            }
        }

        private void gtxtDbName_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtDbName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if (gtxtDbName.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                gtxtUser.Focus();
            }
        }

        private void gtxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtUser.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if (gtxtUser.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                gtxtPass.Focus();
            }
        }

        private void gtxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtPass.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if (gtxtPass.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void chIsConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (chIsConnect.Checked)
            {
                wpcsController.updateIsConnect(1);
                Application.Restart();
            }
            else
            {
                wpcsController.updateIsConnect(0);
                Application.Restart();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(gtxtUserConnect.Text.Trim() != "" && gtxtUserPass.Text.Trim() != "")
                {
                    Properties.Settings.Default.userConnect = gtxtUserConnect.Text;
                    Properties.Settings.Default.userPass = gtxtUserPass.Text;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    Application.Exit();
                }
                else
                {
                    if(gtxtUserConnect.Text == "")
                    {

                        gtxtUserConnect.Focus();
                        gtxtUserConnect.FocusedState.BorderColor = Color.Red;

                    }
                    else if(gtxtUserPass.Text == "")
                    {
                        gtxtUserPass.Focus();
                        gtxtUserPass.FocusedState.BorderColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gtxtUserConnect_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtUserConnect.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if (gtxtUserConnect.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                gtxtUserPass.Focus();
            }
        }

        private void gtxtUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            gtxtUserPass.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if (gtxtUserPass.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
