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

namespace Urgent_Manager.View.DashBoard
{
    public partial class Directories : Form
    {
        WPCSController wpcsController = new WPCSController();
        public Directories()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(gtxtPathName.Text.Trim() != "")
                {
                    wpcsController.updatePath(gtxtPathName.Text,Login.username);
                    gtxtPathName.Text = "";
                    gtxtPathName.Focus();
                    LoadData();
                }
                else
                {
                    lblPathName.ForeColor = Color.Red;
                    gtxtPathName.Focus();
                    gtxtPathName.FocusedState.BorderColor = Color.White;
                }
            }
            catch (Exception)
            {
               
            }
        }

        // Load Data

        private void LoadData()
        {
            try
            {
                List<DirectoriesModel> directories = wpcsController.directories();
                guna2DataGridView1.Rows.Clear();
                if(directories.Count > 0)
                {
                    foreach(DirectoriesModel directory in directories)
                    {
                        guna2DataGridView1.Rows.Add(directory.PathName, directory.UserID);
                    }
                }
            }
            catch (Exception)
            {
               
            }
        }

        private void Directories_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gtxtPathName_KeyDown(object sender, KeyEventArgs e)
        {
            lblPathName.ForeColor = Color.White;
            gtxtPathName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if(gtxtPathName.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }
    }
}
