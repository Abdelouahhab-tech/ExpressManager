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

namespace Urgent_Manager.View.OptimaisationWindows
{
    public partial class ArchiveManager : Form
    {
        UrgentController urgentController = new UrgentController();
        private bool isPerDate = false;
        public ArchiveManager()
        {
            InitializeComponent();
        }

        private void ArchiveManager_Load(object sender, EventArgs e)
        {
            try
            {
                gdateTimeUrgent.Value = DateTime.Now;
                gtxtUnico.Focus();
                isPerDate = false;
                urgentController.FillCombobox("Machine", "Machine", cmbPlanBMc);
                urgentController.UrgentManagerFinished(guna2DataGridView1, DateTime.Now.ToShortDateString());
                urgentController.DeleteUrgent();
                if (guna2DataGridView1.Rows.Count <= 0)
                {
                    lblMessage.Visible = true;
                    guna2DataGridView1.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void gdateTimeUrgent_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                urgentController.DeleteUrgent();
                if (gSwitchFilter.Checked)
                {
                    urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString(), cmbPlanBMc.Text);
                    isPerDate = true;
                }
                else
                {
                    urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString());
                    isPerDate = true;
                }
                if (guna2DataGridView1.Rows.Count > 0)
                {
                    lblMessage.Visible = false;
                    guna2DataGridView1.Visible = true;
                }
                else
                {
                    lblMessage.Visible = true;
                    guna2DataGridView1.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbPlanBMc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                panelCmbPlanBMachine.BackColor = Color.FromArgb(255, 128, 255, 255);
                if (cmbPlanBMc.Text.Trim() != "")
                {
                    if (gSwitchFilter.Checked)
                        urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString(), cmbPlanBMc.Text);
                    else
                        urgentController.UrgentManagerFinishedPerMachine(guna2DataGridView1, cmbPlanBMc.Text);
                }
                if (guna2DataGridView1.Rows.Count > 0)
                {
                    lblMessage.Visible = false;
                    guna2DataGridView1.Visible = true;
                }
                else
                {
                    lblMessage.Visible = true;
                    guna2DataGridView1.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void gSwitchFilter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (gSwitchFilter.Checked)
                {
                    if (cmbPlanBMc.Text.Trim() != "")
                    {
                        urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString(), cmbPlanBMc.Text);
                    }
                    else
                    {
                        cmbPlanBMc.Focus();
                        panelCmbPlanBMachine.BackColor = Color.Red;
                    }

                }
                else
                {
                    urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString());
                    cmbPlanBMc.SelectedIndex = -1;
                }

                if (guna2DataGridView1.Rows.Count > 0)
                {
                    lblMessage.Visible = false;
                    guna2DataGridView1.Visible = true;
                }
                else
                {
                    lblMessage.Visible = true;
                    guna2DataGridView1.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        // Generate Excel File

        private void generateExcel()
        {
            try
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {
                    guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
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
                foreach (DataGridViewCell c in row.Cells)
                {
                    c.Selected = false;
                }
            }
            guna2DataGridView1.Rows[0].Cells[0].Selected = true;
        }

        private async void icExport_Click(object sender, EventArgs e)
        {
            try
            {
                if(guna2DataGridView1.Rows.Count > 0)
                {
                    lblMessage.Visible = false;
                    guna2DataGridView1.Visible = true;
                    lblLoading.Visible = true;
                    await Task.Run(new Action(generateExcel));
                }
                else
                {
                    lblMessage.Visible = true;
                    guna2DataGridView1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chPrintAll_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void gtxtUnico_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(gtxtUnico.Text.Trim() != "")
                {
                    urgentController.UrgentManagerFinishedPerUnico(guna2DataGridView1,gtxtUnico.Text);
                }
                else
                {
                    urgentController.UrgentManagerFinished(guna2DataGridView1,gdateTimeUrgent.Value.ToShortDateString());
                }

                if (guna2DataGridView1.Rows.Count > 0)
                {
                    lblMessage.Visible = false;
                    guna2DataGridView1.Visible = true;
                }
                else
                {
                    lblMessage.Visible = true;
                    guna2DataGridView1.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void gtxtUnico_Leave(object sender, EventArgs e)
        {
            try
            {
                if(gtxtUnico.Text.Trim() != "")
                {
                    urgentController.UrgentManagerFinishedPerUnico(guna2DataGridView1,gtxtUnico.Text);
                }
                else
                {
                    urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString());
                }
            }
            catch (Exception)
            {

            }
        }

        private void icExport_MouseEnter(object sender, EventArgs e)
        {
            icExport.IconColor = Color.FromArgb(255, 234, 79, 12);
        }

        private void icExport_MouseLeave(object sender, EventArgs e)
        {
            icExport.IconColor = Color.White;
        }

    }
}
