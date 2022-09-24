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
        MachineController machineController = new MachineController();
        public Directories()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(gtxtOldPathName.Text.Trim() != "" && gtxtNewPathName.Text.Trim() != "")
                {
                    if (wpcsController.IsExist(gtxtOldPathName.Text,"Directories","PathName"))
                    {
                        wpcsController.updatePath(gtxtNewPathName.Text, Login.username, gtxtOldPathName.Text);
                        gtxtOldPathName.Text = "";
                        gtxtNewPathName.Text = "";
                        gtxtOldPathName.Focus();
                        LoadData();
                    }
                }
                else
                {
                   if(gtxtOldPathName.Text == "")
                    {
                        lblOldPathName.ForeColor = Color.Red;
                        gtxtOldPathName.Focus();
                        gtxtOldPathName.FocusedState.BorderColor = Color.White;
                    }else if(gtxtNewPathName.Text == "")
                    {
                        lblNewPathName.ForeColor = Color.Red;
                        gtxtNewPathName.Focus();
                        gtxtNewPathName.FocusedState.BorderColor = Color.White;
                    }
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
            machineController.FillCombobox("Machine", "Machine", cmbMachine);
            LoadData();
        }

        private void gtxtPathName_KeyDown(object sender, KeyEventArgs e)
        {
            lblOldPathName.ForeColor = Color.White;
            gtxtOldPathName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            if(gtxtOldPathName.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                gtxtNewPathName.Focus();
            }
        }

        private void gtxtNewPathName_KeyDown(object sender, KeyEventArgs e)
        {
            lblNewPathName.ForeColor = Color.White;
            gtxtNewPathName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(gtxtOldPathName.Text.Trim() != "")
                {
                    if (!wpcsController.IsExist(gtxtOldPathName.Text, "Directories", "PathName"))
                    {
                        DirectoriesModel dir = new DirectoriesModel();
                        dir.PathName = gtxtOldPathName.Text;
                        dir.UserID = Login.username;
                        wpcsController.SaveDirectory(dir);
                        LoadData();
                        gtxtOldPathName.Text = "";
                        gtxtOldPathName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Sorry This Path Already Exist Try To Add An Other One", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gtxtOldPathName.Focus();
                        gtxtOldPathName.SelectAll();
                    }
                }
                else
                {
                    lblOldPathName.ForeColor = Color.Red;
                    gtxtOldPathName.Focus();
                    gtxtOldPathName.FocusedState.BorderColor = Color.White;
                }
            }
            catch (Exception)
            {
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DirectoriesModel dir = wpcsController.singlePath(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                gtxtOldPathName.Text = dir.PathName;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(gtxtOldPathName.Text.Trim() != "")
                {
                    if (wpcsController.IsExist(gtxtOldPathName.Text, "Directories", "PathName"))
                    {
                        DialogResult res = MessageBox.Show("Are You Sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            wpcsController.Delete(gtxtOldPathName.Text, "Directories", "PathName");
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Path Doesn't Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    lblOldPathName.ForeColor = Color.Red;
                    gtxtOldPathName.Focus();
                    gtxtOldPathName.FocusedState.BorderColor = Color.White;
                }
            }
            catch (Exception)
            {

            }
        }

        private void gtxtOldPathName_Leave(object sender, EventArgs e)
        {
            lblOldPathName.ForeColor = Color.White;
            gtxtOldPathName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtNewPathName_Leave(object sender, EventArgs e)
        {
            lblNewPathName.ForeColor = Color.White;
            gtxtNewPathName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbMachine.Text.Trim() != "" && chIsConnect.Checked)
                {
                    machineController.UpdateIsConnect(cmbMachine.Text, 1);
                    MessageBox.Show("Your Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else if(cmbMachine.Text.Trim() != "" && !chIsConnect.Checked)
                {
                    machineController.UpdateIsConnect(cmbMachine.Text, 0);
                    MessageBox.Show("Your Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
