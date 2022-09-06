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
    public partial class Area : Form
    {
        AreaController areaController = new AreaController();
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            gtxtAreaName.Focus();
            LoadData();
        }

        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<AreaModel> list = areaController.fetchRecords();
            foreach (AreaModel area in list)
            {
                guna2DataGridView1.Rows.Add(area.AreaName, area.ParentArea, area.UserID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(gtxtAreaName.Text.Trim() != "" && cmbParentArea.Text.Trim() != "")
            {
                if (!areaController.IsExist(gtxtAreaName.Text, "Area", "ZoneName"))
                {
                    AreaModel area = new AreaModel();
                    area.AreaName = gtxtAreaName.Text;
                    area.ParentArea = cmbParentArea.Text;
                    area.UserID = Login.username;
                    areaController.InsertArea(area);
                    init();
                }
                else
                {
                    MessageBox.Show("This Area Is Already Exist !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gtxtAreaName.Focus();
                    gtxtAreaName.SelectAll();
                    lblAreaName.ForeColor = Color.Red;
                    gtxtAreaName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                if(gtxtAreaName.Text.Trim() == "")
                {
                    lblAreaName.ForeColor = Color.Red;
                    gtxtAreaName.Focus();
                    gtxtAreaName.FocusedState.BorderColor = Color.White;
                }
                else if(cmbParentArea.Text.Trim() == "")
                {
                    lblParentArea.ForeColor = Color.Red;
                    cmbParentArea.Focus();
                    cmbParentArea.FocusedState.BorderColor = Color.White;
                }
            }
        }
        private void init()
        {
            gtxtAreaName.Text = "";
            cmbParentArea.SelectedIndex = -1;
            gtxtAreaName.Focus();
            LoadData();
        }

        private void cmbParentArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblParentArea.ForeColor = Color.White;
            cmbParentArea.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(gtxtAreaName.Text.Trim() != "")
            {
                if (areaController.IsExist(gtxtAreaName.Text, "Area", "ZoneName"))
                {
                    if (cmbParentArea.Text.Trim() != "")
                    {
                        AreaModel area = new AreaModel();
                        area.AreaName = gtxtAreaName.Text;
                        area.ParentArea = cmbParentArea.Text;
                        area.UserID = Login.username;
                        areaController.UpdateArea(area, gtxtAreaName.Text);
                        init();
                    }
                    else
                    {
                        lblParentArea.ForeColor = Color.Red;
                        cmbParentArea.Focus();
                        cmbParentArea.FocusedState.BorderColor = Color.White;
                    }
                }
                else
                {
                    MessageBox.Show("This Area Doesn't Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAreaName.ForeColor = Color.Red;
                    gtxtAreaName.Focus();
                    gtxtAreaName.SelectAll();
                    gtxtAreaName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblAreaName.ForeColor = Color.Red;
                gtxtAreaName.Focus();
                gtxtAreaName.FocusedState.BorderColor = Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gtxtAreaName.Text.Trim() != "")
            {
                if (areaController.IsExist(gtxtAreaName.Text, "Area", "ZoneName"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Area ? You Will Lost All The Data That Is Related With This Area", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
                    if(result == DialogResult.Yes)
                    {
                        areaController.Delete(gtxtAreaName.Text, "Area", "ZoneName");
                        init();
                    }
                }
                else
                {
                    MessageBox.Show("This Area Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblAreaName.ForeColor = Color.Red;
                    gtxtAreaName.Focus();
                    gtxtAreaName.SelectAll();
                    gtxtAreaName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblAreaName.ForeColor = Color.Red;
                gtxtAreaName.Focus();
                gtxtAreaName.FocusedState.BorderColor = Color.White;
            }
        }


        // Fetch Single Record

        private void getSingleRecord(string areaName)
        {
            if (areaController.IsExist(areaName, "Area", "ZoneName"))
            {
                AreaModel area = new AreaModel();
                area = areaController.fetchSingleArea(areaName);
                cmbParentArea.Text = area.ParentArea;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(area.AreaName, area.ParentArea, area.UserID);
                lblAreaName.ForeColor = Color.White;
                gtxtAreaName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string areaName = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (areaName != "")
                    getSingleRecord(areaName);
            }
        }

        private void gtxtAreaName_Leave(object sender, EventArgs e)
        {
            lblAreaName.ForeColor = Color.White;
            gtxtAreaName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbParentArea_Leave(object sender, EventArgs e)
        {
            lblParentArea.ForeColor = Color.White;
            cmbParentArea.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtCableName_KeyDown(object sender, KeyEventArgs e)
        {
            lblAreaName.ForeColor = Color.White;
            gtxtAreaName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtAreaName_KeyUp_2(object sender, KeyEventArgs e)
        {
            if (gtxtAreaName.Text.Trim() != "")
                getSingleRecord(gtxtAreaName.Text);
            else
                LoadData();
        }

        private void gtxtAreaName_Leave_1(object sender, EventArgs e)
        {
            lblAreaName.ForeColor = Color.White;
            gtxtAreaName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }
    }
}
