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
    public partial class Group : Form
    {

        GroupController groupController = new GroupController();
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            gtxtGroup.Focus();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtGroup.Text.Trim() != "")
            {
                if (!groupController.IsExist(gtxtGroup.Text, "Groupe", "GroupRef"))
                {
                    GroupModel group = new GroupModel();
                    group.Group = gtxtGroup.Text;
                    group.UserID = Login.username;
                    groupController.InsertGroup(group);
                    gtxtGroup.Text = "";
                    gtxtGroup.Focus();
                }
                else
                {
                    MessageBox.Show("This Group Already Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblGroup.ForeColor = Color.Red;
                    gtxtGroup.Focus();
                    gtxtGroup.SelectAll();
                    gtxtGroup.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblGroup.ForeColor = Color.Red;
                gtxtGroup.Focus();
                gtxtGroup.FocusedState.BorderColor = Color.White;
            }
        }

        // Load Data From Group Table

        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<GroupModel> groupes = groupController.fetchRecords();
            foreach (GroupModel group in groupes)
            {
                guna2DataGridView1.Rows.Add(group.Group, group.UserID);
            }
        }

        // Fetch Single Record

        private void getSingleRecord(string groupRef)
        {
            if (groupController.IsExist(groupRef, "Groupe", "GroupRef"))
            {
                GroupModel group = new GroupModel();
                group = groupController.fetchSingleRecord(groupRef);
                gtxtGroup.Text = group.Group;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(group.Group, group.UserID);
                lblGroup.ForeColor = Color.White;
                gtxtGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gtxtGroup.Text.Trim() != "")
            {
                if (groupController.IsExist(gtxtGroup.Text, "Groupe", "GroupRef"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Group ? You Will Lost All The Data That Is Related With This Group", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        groupController.Delete(gtxtGroup.Text, "Groupe", "GroupRef");
                        gtxtGroup.Text = "";
                        gtxtGroup.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("This Group Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblGroup.ForeColor = Color.Red;
                    gtxtGroup.Focus();
                    gtxtGroup.SelectAll();
                    gtxtGroup.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblGroup.ForeColor = Color.Red;
                gtxtGroup.Focus();
                gtxtGroup.FocusedState.BorderColor = Color.White;
            }
        }

        private void gtxtGroup_KeyDown(object sender, KeyEventArgs e)
        {
            lblGroup.ForeColor = Color.White;
            gtxtGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtGroup.Text == "")
            {
                LoadData();
                gtxtGroup.Text = "";
                gtxtGroup.Focus();
            }else if(gtxtGroup.Text.Trim() != "")
            {
                getSingleRecord(gtxtGroup.Text);
            }
        }

        private void gtxtGroup_Leave(object sender, EventArgs e)
        {
            lblGroup.ForeColor = Color.White;
            gtxtGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string groupRef = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (groupRef != "")
                    getSingleRecord(groupRef);
            }
        }
    }
}
