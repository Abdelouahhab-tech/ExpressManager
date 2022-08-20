using DGVPrinterHelper;
using System;
using System.Collections;
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
    public partial class WireData : Form
    {
        WireController wireController = new WireController();
        public WireData()
        {
            InitializeComponent();
        }

        private async void WireData_Load(object sender, EventArgs e)
        {
            gtxtSearch.Focus();
            wireController.FillCombobox("Machine", "Machine", cmbMachine);
            wireController.FillCombobox("Machine", "Machine", cmbPlanBMc);
            lblLoading.Visible = true;
            await Task.Run(new Action(fetch));
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            guna2DataGridView1.ScrollBars = ScrollBars.Both;
            foreach(DataGridViewColumn col in guna2DataGridView1.Columns)
            {
                if (col.HeaderText == "Location" || col.HeaderText == "Entry Agent" || col.HeaderText == "Unico" || col.HeaderText == "Lead Code")
                    col.Width = 180;
                else
                    col.Width = 100;
            }
        }

        private async void gtxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtSearch.Text == "")
            {
                    lblLoading.Visible = true;
                    await Task.Run(new Action(fetchRecordsWithNewItems));
            }
            if (gtxtSearch.Text.Trim() != "")
            {
                wireController.fetchRecords(guna2DataGridView1, list,gtxtSearch.Text);
            }
        }

        private void gtxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        ArrayList list = new ArrayList();

        private async void guna2CheckBox13_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chGroup.Checked)
            {
                list.Add("Groupe");
                if (list.Count > 0)
                {
                    lblLoading.Visible = true;
                    await Task.Run(new Action(fetchRecordsWithNewItems));
                }
            }
            else
            {
                list.Remove("Groupe");
                lblLoading.Visible = true;
                await Task.Run(new Action(fetchRecordsWithNewItems));
            }
        }

        private async void chProtection_CheckedChanged(object sender, EventArgs e)
        {
            if (chProtection.Checked)
            {
                list.Add("ProtectionL");
                list.Add("ProtectionR");

                if (list.Count > 0)
                {
                    lblLoading.Visible = true;
                    await Task.Run(new Action(fetchRecordsWithNewItems));
                }
            }
            else
            {
                list.Remove("ProtectionR");
                list.Remove("ProtectionL");
                lblLoading.Visible = true;
                await Task.Run(new Action(fetchRecordsWithNewItems));
            }
        }

        private async void chLeadPrep_CheckedChanged(object sender, EventArgs e)
        {
            if (chLeadPrep.Checked)
            {
                list.Add("LeadPrep");
                lblLoading.Visible = true;
                await Task.Run(new Action(fetchRecordsWithNewItems));
            }
            else
            {
                list.Remove("LeadPrep");
                lblLoading.Visible = true;
                await Task.Run(new Action(fetchRecordsWithNewItems));
            }
        }

        private async void cmbMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCmbMachine.BackColor = Color.FromArgb(255, 128, 255, 255);
            if (cmbMachine.Text.Trim() != "")
            {
                lblLoading.Visible = true;
                await Task.Run(new Action(fetchRecordsPerMac));
            }
        }

        // Fetch Recods Asyncrounously
        private void fetch()
        {
            guna2DataGridView1.Invoke((MethodInvoker)delegate
            {
                wireController.fetchRecords(guna2DataGridView1);
                lblLoading.Visible = false;
            });
        }

        // Fetch Recods Syncrounously depend on machine

        private void fetchRecordsPerMac()
        {
            guna2DataGridView1.Invoke((MethodInvoker)delegate
            {
                if (chGroupe.Checked)
                {
                    wireController.fetchRecordsPerMachine(guna2DataGridView1, list, "Groupe", cmbMachine.Text);
                    lblLoading.Visible = false;
                }
                else
                {
                    wireController.fetchRecordsPerMachine(guna2DataGridView1, list, "MC", cmbMachine.Text);
                    lblLoading.Visible = false;
                }

            });
        }

        // Fetch Recods Syncrounously deprnd on machine and new added Items

        private void fetchRecordsWithNewItems()
        {
            guna2DataGridView1.Invoke((MethodInvoker)delegate
            {
                wireController.fetchRecords(guna2DataGridView1, list);
                lblLoading.Visible = false;
            });
        }

        private void chGroupe_CheckedChanged(object sender, EventArgs e)
        {
            if (chGroupe.Checked)
            {
                chMachine.Checked = false;
                cmbMachine.Items.Clear();
                cmbPlanBMc.Items.Clear();
                wireController.FillCombobox("Groupe", "GroupRef", cmbMachine);
                wireController.FillCombobox("Groupe", "GroupRef", cmbPlanBMc);
                lblNew.Text = "New Group";
                lblOld.Text = "Old Group";

            }
        }

        private void chMachine_CheckedChanged(object sender, EventArgs e)
        {
            if (chMachine.Checked)
            {

                chGroupe.Checked = false;
                cmbMachine.Items.Clear();
                cmbPlanBMc.Items.Clear();
                wireController.FillCombobox("Machine", "Machine", cmbMachine);
                wireController.FillCombobox("Machine", "Machine", cmbPlanBMc);
                lblNew.Text = "New Machine";
                lblOld.Text = "Old Machine";
            }
        }

        private void icUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMachine.Text.Trim() != "" && cmbPlanBMc.Text.Trim() != "")
                {
                    if (chGroupe.Checked)
                    {
                        wireController.UpdateWirePerGroupMC("Groupe", cmbMachine.Text, cmbPlanBMc.Text);
                        cmbMachine.Text = cmbPlanBMc.Text;
                        fetchRecordsPerMac();
                        cmbMachine.SelectedIndex = -1;
                        cmbPlanBMc.SelectedIndex = -1;
                    }
                    else
                    {
                        wireController.UpdateWirePerGroupMC("MC", cmbMachine.Text, cmbPlanBMc.Text);
                        cmbMachine.Text = cmbPlanBMc.Text;
                        fetchRecordsPerMac();
                        cmbMachine.SelectedIndex = -1;
                        cmbPlanBMc.SelectedIndex = -1;
                    }
                }
                else
                {
                    if(cmbMachine.Text == "")
                    {
                        cmbMachine.Focus();
                        panelCmbMachine.BackColor = Color.Red;
                    }else if(cmbPlanBMc.Text == "")
                    {
                        cmbPlanBMc.Focus();
                        panelCmbPlanBMachine.BackColor = Color.Red;
                    }
                }
               }
            catch (Exception ex)
            {
            }
}

        private void cmbPlanBMc_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCmbPlanBMachine.BackColor = Color.FromArgb(255, 128, 255, 255);
        }

        private async void icExport_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            await Task.Run(new Action(generateExcel));

        }

        // Generate Excel File

        private void generateExcel()
        {
            try
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {
                    guna2DataGridView1.SelectAll();
                    DataObject copyData = guna2DataGridView1.GetClipboardContent();
                    if (copyData != null) Clipboard.SetDataObject(copyData);
                    Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                    xlapp.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWSheet;
                    Object misedData = System.Reflection.Missing.Value;
                    xlWBook = xlapp.Workbooks.Add(misedData);
                    xlWSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWBook.Worksheets[1];
                    Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlWSheet.Cells[1, 1];
                    xlr.Select();
                    xlWSheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                    init();
                    lblLoading.Visible = false;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialize Datagridview selection mode

        private void init()
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Selected = false;
            }
            guna2DataGridView1.Rows[0].Selected = true;
        }
    }
}
