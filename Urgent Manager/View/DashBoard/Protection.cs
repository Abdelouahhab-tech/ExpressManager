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
    public partial class Protection : Form
    {
        ProtectionController protectionController = new ProtectionController();
        public Protection()
        {
            InitializeComponent();
        }

        private void Protection_Load(object sender, EventArgs e)
        {
            gtxtProtectionRef.Focus();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtProtectionRef.Text.Trim() != "")
            {
                if (!protectionController.IsExist(gtxtProtectionRef.Text, "Protection", "Type"))
                {
                    ProtectionModel protection = new ProtectionModel();
                    protection.Type = gtxtProtectionRef.Text;
                    protection.UserID = Login.username;
                    protectionController.InsertProtection(protection);
                    LoadData();
                    gtxtProtectionRef.Text = "";
                    gtxtProtectionRef.Focus();
                }
                else
                {
                    MessageBox.Show("This Protection Already Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblProtectionRef.ForeColor = Color.Red;
                    gtxtProtectionRef.Focus();
                    gtxtProtectionRef.SelectAll();
                    gtxtProtectionRef.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblProtectionRef.ForeColor = Color.Red;
                gtxtProtectionRef.Focus();
                gtxtProtectionRef.FocusedState.BorderColor = Color.White;
            }
        }


        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<ProtectionModel> list = protectionController.fetchRecords();
            foreach (ProtectionModel protection in list)
            {
                guna2DataGridView1.Rows.Add(protection.Type, protection.UserID);
            }
            gtxtProtectionRef.Text = "";
            gtxtProtectionRef.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gtxtProtectionRef.Text.Trim() != "")
            {
                if (protectionController.IsExist(gtxtProtectionRef.Text, "Protection", "Type"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Protection ? You Will Lost All The Data That Is Related With This Protection", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        protectionController.Delete(gtxtProtectionRef.Text, "Protection", "Type");
                        LoadData();
                        gtxtProtectionRef.Text = "";
                        gtxtProtectionRef.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("This Protection Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblProtectionRef.ForeColor = Color.Red;
                    gtxtProtectionRef.Focus();
                    gtxtProtectionRef.SelectAll();
                    gtxtProtectionRef.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblProtectionRef.ForeColor = Color.Red;
                gtxtProtectionRef.Focus();
                gtxtProtectionRef.FocusedState.BorderColor = Color.White;
            }
        }

        private void gtxtProtectionRef_KeyDown(object sender, KeyEventArgs e)
        {
            lblProtectionRef.ForeColor = Color.White;
            gtxtProtectionRef.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtProtectionRef_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtProtectionRef.Text == "")
            {
                LoadData();
                gtxtProtectionRef.Text = "";
                gtxtProtectionRef.Focus();
            }
        }

        private void gtxtProtectionRef_Leave(object sender, EventArgs e)
        {
            lblProtectionRef.ForeColor = Color.White;
            gtxtProtectionRef.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }


        // Fetch Single Record

        private void getSingleRecord(string type)
        {
            if (protectionController.IsExist(type, "Protection", "Type"))
            {
                ProtectionModel protection = new ProtectionModel();
                protection = protectionController.fetchSingleRecord(type);
                gtxtProtectionRef.Text = protection.Type;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(protection.Type, protection.UserID);
                lblProtectionRef.ForeColor = Color.White;
                gtxtProtectionRef.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string type = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (type != "")
                    getSingleRecord(type);
            }
        }
    }
}
