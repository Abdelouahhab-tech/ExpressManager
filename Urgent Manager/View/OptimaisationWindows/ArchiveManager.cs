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
            gdateTimeUrgent.Value = DateTime.Now;
            isPerDate = false;
            urgentController.FillCombobox("Machine", "Machine", cmbPlanBMc);
            urgentController.UrgentManagerFinished(guna2DataGridView1,gdateTimeUrgent.Value.ToShortDateString());
            urgentController.DeleteUrgent();
            if(guna2DataGridView1.Rows.Count <= 0)
            {
                lblMessage.Visible = true;
                guna2DataGridView1.Visible = false;
            }
        }

        private void gdateTimeUrgent_ValueChanged(object sender, EventArgs e)
        {
            if (gSwitchFilter.Checked)
            {
                urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString(),cmbPlanBMc.Text);
                isPerDate = true;
            }
            else
            {
                urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString());
                isPerDate = true;
            }
            if(guna2DataGridView1.Rows.Count > 0)
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

        private void cmbPlanBMc_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCmbPlanBMachine.BackColor = Color.FromArgb(255, 128, 255, 255);
            if (cmbPlanBMc.Text.Trim() != "")
            {
                if (gSwitchFilter.Checked)
                    urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString(), cmbPlanBMc.Text);
                else
                    urgentController.UrgentManagerFinishedPerMachine(guna2DataGridView1, cmbPlanBMc.Text);
            }
            if(guna2DataGridView1.Rows.Count > 0)
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

        private void gSwitchFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (gSwitchFilter.Checked)
            {
                if(cmbPlanBMc.Text.Trim() != "")
                {
                    urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString(), cmbPlanBMc.Text);
                }
                else
                {
                    cmbPlanBMc.Focus();
                    panelCmbPlanBMachine.BackColor = Color.Red;
                }
                chPrintAll.Checked = false;

            }
            else
            {
                urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString());
                cmbPlanBMc.SelectedIndex = -1;
            }

            if(guna2DataGridView1.Rows.Count > 0)
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

        private void icPrint_Click(object sender, EventArgs e)
        {
            try
            {
                    if (chPrintAll.Checked)
                    {
                        lblMessage.Visible = false;
                        guna2DataGridView1.Visible = true;
                        ArrayList machines = urgentController.machines("Finished");
                        int i = 0;
                        foreach (string machine in machines)
                        {
                            DGVPrinter printer = new DGVPrinter();
                            printer.Title = "Finished Wires";
                            printer.SubTitle = machine;
                            printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                            printer.PageNumbers = true;
                            printer.PageNumberInHeader = false;
                            printer.PorportionalColumns = true;
                            printer.HeaderCellAlignment = StringAlignment.Near;
                            printer.Footer = "Printed By " + Login.FullName + " | " + DateTime.Now.ToShortDateString();
                            printer.FooterColor = Color.LightGray;
                            printer.SubTitleSpacing = 15;
                            printer.FooterSpacing = 15;
                            printer.SubTitleColor = Color.Gray;
                            printer.printDocument.DefaultPageSettings.Landscape = true;
                            printer.showDialogue = i == 0 ? true : false;
                            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            urgentController.UrgentManagerFinishedPerMachine(guna2DataGridView1, machine);
                            printer.PrintDataGridView(guna2DataGridView1);
                            i++;
                        }
                        urgentController.UrgentManagerFinished(guna2DataGridView1, gdateTimeUrgent.Value.ToShortDateString());
                    }
                    else
                    {
                        if(guna2DataGridView1.Rows.Count > 0)
                        {
                            lblMessage.Visible = false;
                            guna2DataGridView1.Visible = true;

                            if (gSwitchFilter.Checked)
                            {
                                if (cmbPlanBMc.Text.Trim() != "")
                                {
                                    DGVPrinter printer = new DGVPrinter();
                                    printer.Title = "Finished Wires";
                                    printer.SubTitle = cmbPlanBMc.Text + " | " + gdateTimeUrgent.Value.ToShortDateString();
                                    printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                                    printer.PageNumbers = true;
                                    printer.PageNumberInHeader = false;
                                    printer.PorportionalColumns = true;
                                    printer.HeaderCellAlignment = StringAlignment.Near;
                                    printer.Footer = "Printed By " + Login.FullName + " | " + DateTime.Now.ToShortDateString();
                                    printer.FooterColor = Color.LightGray;
                                    printer.SubTitleSpacing = 15;
                                    printer.FooterSpacing = 15;
                                    printer.SubTitleColor = Color.Gray;
                                    printer.printDocument.DefaultPageSettings.Landscape = true;
                                    printer.showDialogue = true;
                                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    printer.PrintDataGridView(guna2DataGridView1);
                                    cmbPlanBMc.SelectedIndex = -1;
                                }
                            }
                            else
                            {
                                if (cmbPlanBMc.Text.Trim() != "")
                                {
                                    DGVPrinter printer = new DGVPrinter();
                                    printer.Title = "Finished Wires";
                                    printer.SubTitle = cmbPlanBMc.Text;
                                    printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                                    printer.PageNumbers = true;
                                    printer.PageNumberInHeader = false;
                                    printer.PorportionalColumns = true;
                                    printer.HeaderCellAlignment = StringAlignment.Near;
                                    printer.Footer = "Printed By " + Login.FullName + " | " + DateTime.Now.ToShortDateString();
                                    printer.FooterColor = Color.LightGray;
                                    printer.SubTitleSpacing = 15;
                                    printer.FooterSpacing = 15;
                                    printer.SubTitleColor = Color.Gray;
                                    printer.printDocument.DefaultPageSettings.Landscape = true;
                                    printer.showDialogue = true;
                                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    printer.PrintDataGridView(guna2DataGridView1);
                                    cmbPlanBMc.SelectedIndex = -1;
                                }
                                else
                                {
                                    DGVPrinter printer = new DGVPrinter();
                                    printer.Title = "Finished Wires";
                                    printer.SubTitle = isPerDate ? gdateTimeUrgent.Value.ToShortDateString() : "";
                                    printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                                    printer.PageNumbers = true;
                                    printer.PageNumberInHeader = false;
                                    printer.PorportionalColumns = true;
                                    printer.HeaderCellAlignment = StringAlignment.Near;
                                    printer.Footer = "Printed By " + Login.FullName + " | " + DateTime.Now.ToShortDateString();
                                    printer.FooterColor = Color.LightGray;
                                    printer.SubTitleSpacing = 15;
                                    printer.FooterSpacing = 15;
                                    printer.SubTitleColor = Color.Gray;
                                    printer.printDocument.DefaultPageSettings.Landscape = true;
                                    printer.showDialogue = true;
                                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    printer.PrintDataGridView(guna2DataGridView1);
                                    isPerDate = false;
                                }
                            }
                        }
                        else
                        {
                            lblMessage.Visible = true;
                            guna2DataGridView1.Visible = false;
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (chPrintAll.Checked)
            {
                gSwitchFilter.Checked = false;
                panelCmbPlanBMachine.BackColor = Color.FromArgb(255, 128, 255, 255);
                cmbPlanBMc.SelectedIndex = -1;
            }
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
                    urgentController.UrgentManagerFinished(guna2DataGridView1);
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
                urgentController.UrgentManagerFinished(guna2DataGridView1);
            }
            catch (Exception)
            {

            }
        }
    }
}
