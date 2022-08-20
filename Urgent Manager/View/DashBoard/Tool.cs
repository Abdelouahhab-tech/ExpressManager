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
    public partial class Tool : Form
    {
        ToolController toolController = new ToolController();
        public Tool()
        {
            InitializeComponent();
        }

        private void Tool_Load(object sender, EventArgs e)
        {
            gtxtToolName.Focus();
            LoadData();
            toolController.FillCombobox("Terminal","TerminalID",cmbTerminal);
        }

        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<ToolModel> list = toolController.fetchRecords();
            foreach (ToolModel tool in list)
            {
                guna2DataGridView1.Rows.Add(tool.ToolID,tool.TerID,tool.UserID);
            }
        }

        // Initialize Fields

        private void init()
        {
            gtxtToolName.Text = "";
            cmbTerminal.SelectedIndex = -1;
            gtxtToolName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtToolName.Text.Trim() != "" && cmbTerminal.Text.Trim() != "")
            {
                if (!toolController.IsExist(gtxtToolName.Text, "Tool", "ToolID"))
                {
                    ToolModel tool = new ToolModel();
                    tool.ToolID = gtxtToolName.Text;
                    tool.TerID = cmbTerminal.Text;
                    tool.UserID = Login.username;

                    toolController.InsertTool(tool);
                    LoadData();
                    init();
                }
                else
                {
                    MessageBox.Show("Sorry This Tool Aleardy Exist Try To Add An Other One !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblToolName.ForeColor = Color.Red;
                    gtxtToolName.Focus();
                    gtxtToolName.SelectAll();
                    gtxtToolName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                if (gtxtToolName.Text.Trim() == "")
                {
                    lblToolName.ForeColor = Color.Red;
                    gtxtToolName.Focus();
                    gtxtToolName.FocusedState.BorderColor = Color.White;

                }
                else if (cmbTerminal.Text.Trim() == "")
                {
                    lblTerminal.ForeColor = Color.Red;
                    cmbTerminal.Focus();
                    cmbTerminal.FocusedState.BorderColor = Color.White;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gtxtToolName.Text.Trim() != "")
            {
                if (toolController.IsExist(gtxtToolName.Text, "Tool", "ToolID"))
                {
                    if (cmbTerminal.Text.Trim() != "")
                    {
                        ToolModel tool = new ToolModel();

                        tool.ToolID = gtxtToolName.Text;
                        tool.TerID = cmbTerminal.Text;
                        tool.UserID = Login.username;

                        toolController.UpdateTool(tool);

                        LoadData();
                        init();
                    }
                    else
                    {
                        lblTerminal.ForeColor = Color.Red;
                        cmbTerminal.Focus();
                        cmbTerminal.FocusedState.BorderColor = Color.White;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry This Tool Doesn't Exist ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblTerminal.ForeColor = Color.Red;
                    gtxtToolName.Focus();
                    gtxtToolName.SelectAll();
                    gtxtToolName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblToolName.ForeColor = Color.Red;
                gtxtToolName.Focus();
                gtxtToolName.FocusedState.BorderColor = Color.White;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string toolName = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (toolName != "")
                    getSingleRecord(toolName);
            }
        }

        // Fetch Single Record

        private void getSingleRecord(string toolName)
        {
            if (toolController.IsExist(toolName, "Tool", "ToolID"))
            {
                ToolModel tool = new ToolModel();
                tool = toolController.fetchSingleRecord(toolName);

                gtxtToolName.Text = tool.ToolID;
                cmbTerminal.Text = tool.TerID;

                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(tool.ToolID,tool.TerID,tool.UserID);
                lblToolName.ForeColor = Color.White;
                gtxtToolName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void gtxtToolName_KeyDown(object sender, KeyEventArgs e)
        {
            lblToolName.ForeColor = Color.White;
            gtxtToolName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtToolName_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtToolName.Text == "")
            {
                LoadData();
                init();

            }else if(gtxtToolName.Text.Trim() != "")
            {
                getSingleRecord(gtxtToolName.Text);
            }
        }

        private void gtxtToolName_Leave(object sender, EventArgs e)
        {
            lblToolName.ForeColor = Color.White;
            gtxtToolName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbTerminal_Leave(object sender, EventArgs e)
        {
            lblTerminal.ForeColor = Color.White;
            cmbTerminal.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTerminal.ForeColor = Color.White;
            cmbTerminal.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gtxtToolName.Text.Trim() != "")
            {
                if (toolController.IsExist(gtxtToolName.Text, "Tool", "ToolID"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Tool ? You Will Lost All The Data That Is Related With This Tool", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        toolController.Delete(gtxtToolName.Text, "Tool", "ToolID");
                        LoadData();
                        init();
                    }
                }
                else
                {
                    MessageBox.Show("This Tool Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblToolName.ForeColor = Color.Red;
                    gtxtToolName.Focus();
                    gtxtToolName.SelectAll();
                    gtxtToolName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblToolName.ForeColor = Color.Red;
                gtxtToolName.Focus();
                gtxtToolName.FocusedState.BorderColor = Color.White;
            }
        }
    }
}
