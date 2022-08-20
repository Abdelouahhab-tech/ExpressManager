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
    public partial class Machine : Form
    {
        MachineController machineController = new MachineController();
        public Machine()
        {
            InitializeComponent();
        }

        private void Machine_Load(object sender, EventArgs e)
        {
            gtxtMachineName.Focus();
            cmbZone.Items.Add("All");
            machineController.FillCombobox("Area", "ZoneName", cmbZone);
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtMachineName.Text.Trim() != "" && cmbZone.Text.Trim() != "" )
            {
                if (!machineController.IsExist(gtxtMachineName.Text, "Machine", "Machine"))
                {
                    MachineModel machine = new MachineModel();

                    machine.Machine = gtxtMachineName.Text;
                    machine.ParentZone = cmbZone.Text;
                    machine.UserID = Login.username;

                    machineController.InsertMachine(machine);
                    LoadData();
                    init();
                }
                else
                {
                    MessageBox.Show("Sorry This Machine Aleardy Exist Try To Add An Other One !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (gtxtMachineName.Text.Trim() == "")
                {
                    lblMachine.ForeColor = Color.Red;
                    gtxtMachineName.Focus();
                    gtxtMachineName.SelectAll();
                    gtxtMachineName.FocusedState.BorderColor = Color.White;

                }
                else if (cmbZone.Text.Trim() == "")
                {
                    lblZones.ForeColor = Color.Red;
                    cmbZone.Focus();
                    cmbZone.SelectAll();
                    cmbZone.FocusedState.BorderColor = Color.White;
                }
            }
        }

        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<MachineModel> list = machineController.fetchRecords();
            foreach (MachineModel machine in list)
            {
                guna2DataGridView1.Rows.Add(machine.Machine,machine.ParentZone,machine.UserID);
            }
        }


        // initialize Components

        private void init()
        {
            gtxtMachineName.Text = "";
            cmbZone.SelectedIndex = -1;
            gtxtMachineName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gtxtMachineName.Text.Trim() != "")
            {
                if (machineController.IsExist(gtxtMachineName.Text, "Machine", "Machine"))
                {
                    if (cmbZone.Text.Trim() != "")
                    {
                        MachineModel machine = new MachineModel();
                        machine.Machine = gtxtMachineName.Text;
                        machine.ParentZone = cmbZone.Text;
                        machine.UserID = Login.username;

                        machineController.UpdateMachine(machine);

                        LoadData();
                        init();
                    }
                    else
                    {
                        if (gtxtMachineName.Text.Trim() == "")
                        {
                            lblMachine.ForeColor = Color.Red;
                            gtxtMachineName.Focus();
                            gtxtMachineName.FocusedState.BorderColor = Color.White;
                        }
                        else if (cmbZone.Text.Trim() == "")
                        {
                            lblZones.ForeColor = Color.Red;
                            cmbZone.Focus();
                            cmbZone.FocusedState.BorderColor = Color.White;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sorry This Machine Doesn't Exist ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMachine.ForeColor = Color.Red;
                    gtxtMachineName.Focus();
                    gtxtMachineName.SelectAll();
                    gtxtMachineName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblMachine.ForeColor = Color.Red;
                gtxtMachineName.Focus();
                gtxtMachineName.FocusedState.BorderColor = Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gtxtMachineName.Text.Trim() != "")
            {
                if (machineController.IsExist(gtxtMachineName.Text, "Machine", "Machine"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Machine ? You Will Lost All The Data That Is Related With This Machine", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        machineController.Delete(gtxtMachineName.Text, "Machine", "Machine");
                        LoadData();
                        init();
                    }
                }
                else
                {
                    MessageBox.Show("This Machine Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMachine.ForeColor = Color.Red;
                    gtxtMachineName.Focus();
                    gtxtMachineName.SelectAll();
                    gtxtMachineName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblMachine.ForeColor = Color.Red;
                gtxtMachineName.Focus();
                gtxtMachineName.FocusedState.BorderColor = Color.White;
            }
        }

        private void gtxtMachineName_KeyDown(object sender, KeyEventArgs e)
        {
            lblMachine.ForeColor = Color.White;
            gtxtMachineName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtMachineName_KeyUp(object sender, KeyEventArgs e)
        {
            if (gtxtMachineName.Text == "")
            {
                LoadData();
                init();
            }
            else if (gtxtMachineName.Text != "")
            {
                getSingleRecord(gtxtMachineName.Text);
            }
        }

        private void gtxtMachineName_Leave(object sender, EventArgs e)
        {
            lblMachine.ForeColor = Color.White;
            gtxtMachineName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        // Fetch Single Record

        private void getSingleRecord(string machineName)
        {
            if (machineController.IsExist(machineName, "Machine", "Machine"))
            {
                MachineModel machine = new MachineModel();
                machine = machineController.fetchSingleRecord(machineName);

                gtxtMachineName.Text = machine.Machine;
                cmbZone.Text = machine.ParentZone;

                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(machine.Machine, machine.ParentZone, machine.UserID);
                lblMachine.ForeColor = Color.White;
                gtxtMachineName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string machineName = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(machineName != "")
                {
                    getSingleRecord(machineName);
                }
            }
        }

        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblZones.ForeColor = Color.White;
            cmbZone.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);

            if(cmbZone.Text != "" && cmbZone.Text != "All")
            {
                List<MachineModel> machines = machineController.fetchRecordsCMB(cmbZone.Text);

                guna2DataGridView1.Rows.Clear();
                foreach (MachineModel machine in machines)
                {
                    guna2DataGridView1.Rows.Add(machine.Machine, machine.ParentZone, machine.UserID);
                }
            }
            else
            {
                LoadData();
            }
        }

        private void cmbZone_Leave(object sender, EventArgs e)
        {
            lblZones.ForeColor = Color.White;
            cmbZone.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }
    }
}
