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
    public partial class Terminal : Form
    {
        TerminalController terminalController = new TerminalController();
        public Terminal()
        {
            InitializeComponent();
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            gtxtTerminalName.Focus();
            LoadData();
        }

        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<TerminalModel> list = terminalController.fetchRecords();
            foreach (TerminalModel terminal in list)
            {
                guna2DataGridView1.Rows.Add(terminal.TerID,terminal.UserID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtTerminalName.Text.Trim() != "")
            {
                if (!terminalController.IsExist(gtxtTerminalName.Text, "Terminal", "TerminalID"))
                {
                    TerminalModel Terminal = new TerminalModel();
                    Terminal.TerID = gtxtTerminalName.Text;
                    Terminal.UserID = Login.username;

                    terminalController.InsertTerminal(Terminal);
                    LoadData();
                    gtxtTerminalName.Text = "";
                    gtxtTerminalName.Focus();
                }
                else
                {
                    MessageBox.Show("Sorry This Terminal Aleardy Exist Try To Add An Other One !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblTerminal.ForeColor = Color.Red;
                    gtxtTerminalName.Focus();
                    gtxtTerminalName.SelectAll();
                    gtxtTerminalName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                    lblTerminal.ForeColor = Color.Red;
                    gtxtTerminalName.Focus();
                    gtxtTerminalName.FocusedState.BorderColor = Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gtxtTerminalName.Text.Trim() != "")
            {
                if (terminalController.IsExist(gtxtTerminalName.Text, "Terminal", "TerminalID"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Terminal ? You Will Lost All The Data That Is Related With This Terminal", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        terminalController.Delete(gtxtTerminalName.Text, "Terminal", "TerminalID");
                        LoadData();
                        gtxtTerminalName.Text = "";
                        gtxtTerminalName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("This Terminal Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblTerminal.ForeColor = Color.Red;
                    gtxtTerminalName.Focus();
                    gtxtTerminalName.SelectAll();
                    gtxtTerminalName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblTerminal.ForeColor = Color.Red;
                gtxtTerminalName.Focus();
                gtxtTerminalName.FocusedState.BorderColor = Color.White;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string Terminal = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (Terminal != "")
                    getSingleRecord(Terminal);
            }
        }


        // Fetch Single Record

        private void getSingleRecord(string Terminal)
        {
            if (terminalController.IsExist(Terminal, "Terminal", "TerminalID"))
            {
                TerminalModel Ter = new TerminalModel();
                Ter = terminalController.fetchSingleRecord(Terminal);

                gtxtTerminalName.Text = Ter.TerID;

                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(Ter.TerID,Ter.UserID);
                lblTerminal.ForeColor = Color.White;
                gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void gtxtTerminalName_KeyDown(object sender, KeyEventArgs e)
        {
            lblTerminal.ForeColor = Color.White;
            gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtTerminalName_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtTerminalName.Text == "")
            {
                LoadData();
                lblTerminal.ForeColor = Color.White;
                gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);

            }else if(gtxtTerminalName.Text.Trim() != "")
            {
                getSingleRecord(gtxtTerminalName.Text);
            }
        }

        private void gtxtTerminalName_Leave(object sender, EventArgs e)
        {
            lblTerminal.ForeColor = Color.White;
            gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }
    }
}
