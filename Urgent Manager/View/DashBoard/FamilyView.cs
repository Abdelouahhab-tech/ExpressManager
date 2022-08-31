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
    public partial class FamilyView : Form
    {
        FamilyController familyController = new FamilyController();
        public FamilyView()
        {
            InitializeComponent();
        }

        private void Family_Load(object sender, EventArgs e)
        {
            gtxtFamilyName.Focus();
            LoadData();
        }

        // Load Data From Family Table

        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<FamilyModel> families = familyController.fetchRecords();
            foreach(FamilyModel family in families)
            {
                guna2DataGridView1.Rows.Add(family.FamilyName, family.UserID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(gtxtFamilyName.Text.Trim() != "")
            {
                if (!familyController.IsExist(gtxtFamilyName.Text, "Family", "FAM"))
                {
                    FamilyModel family = new FamilyModel();
                    family.FamilyName = gtxtFamilyName.Text;
                    family.UserID = Login.username;
                    familyController.InsertFamily(gtxtFamilyName.Text,Login.username);
                    gtxtFamilyName.Text = "";
                    gtxtFamilyName.Focus();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("This Family Already Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFamilyName.ForeColor = Color.Red;
                    gtxtFamilyName.Focus();
                    gtxtFamilyName.SelectAll();
                    gtxtFamilyName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblFamilyName.ForeColor = Color.Red;
                gtxtFamilyName.Focus();
                gtxtFamilyName.FocusedState.BorderColor = Color.White;
            }
        }

        private void gtxtFamilyName_KeyDown(object sender, KeyEventArgs e)
        {
            lblFamilyName.ForeColor = Color.White;
            gtxtFamilyName.FocusedState.BorderColor = Color.FromArgb(255, 94,148,255);
        }

        private void gtxtFamilyName_KeyUp(object sender, KeyEventArgs e)
        {
            if (gtxtFamilyName.Text == "")
                LoadData();
            else if (gtxtFamilyName.Text.Trim() != "")
                getSingleRecord(gtxtFamilyName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gtxtFamilyName.Text.Trim() != "")
            {
                if (familyController.IsExist(gtxtFamilyName.Text, "Family", "FAM"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Family ? You Will Lost All The Data That Is Related With This Family", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        familyController.Delete(gtxtFamilyName.Text,"Family","FAM");
                        LoadData();
                        gtxtFamilyName.Text = "";
                        gtxtFamilyName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("This Family Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFamilyName.ForeColor = Color.Red;
                    gtxtFamilyName.Focus();
                    gtxtFamilyName.SelectAll();
                    gtxtFamilyName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblFamilyName.ForeColor = Color.Red;
                gtxtFamilyName.Focus();
                gtxtFamilyName.FocusedState.BorderColor = Color.White;
            }
        }

        // Fetch Single Record

        private void getSingleRecord(string familyName)
        {
            if (familyController.IsExist(familyName, "Family", "FAM"))
            {
                FamilyModel family = new FamilyModel();
                family = familyController.fetchSingleFamily(familyName);
                gtxtFamilyName.Text = family.FamilyName;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(family.FamilyName, family.UserID);
                lblFamilyName.ForeColor = Color.White;
                gtxtFamilyName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string familyName = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (familyName != "")
                    getSingleRecord(familyName);
            }
        }

        private void gtxtFamilyName_Leave(object sender, EventArgs e)
        {
            lblFamilyName.ForeColor = Color.White;
            gtxtFamilyName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }
    }
}
