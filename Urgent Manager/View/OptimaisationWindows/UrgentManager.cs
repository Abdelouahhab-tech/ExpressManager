using DGVPrinterHelper;
using Guna.UI2.WinForms;
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
    public partial class UrgentManager : Form
    {

        UrgentController urgentController = new UrgentController();
        bool isLeadPrep = false;
        public UrgentManager()
        {
            InitializeComponent();
        }

        private void gtxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUrgentDelete_Click(object sender, EventArgs e)
        {
            ArchivedUrgents archive = new ArchivedUrgents();
            archive.ShowDialog();
        }

        private void UrgentManager_Load(object sender, EventArgs e)
        {
            urgentController.FillCombobox("Machine", "Machine", cmbMac);
            if (chAllUrgents.Checked)
            {
                urgentController.UrgentManagerExpress(guna2DataGridView1, false);
            }else if (chOptimizedRecords.Checked)
            {
                urgentController.UrgentManagerExpress(guna2DataGridView1, true);
            }
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach(DataGridViewColumn column in guna2DataGridView1.Columns)
            {
                if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                    column.Width = 150;
                else
                    column.Width = 100;
            }
            guna2DataGridView1.ScrollBars = ScrollBars.Both;
            gtxtSearch.Focus();
            if(Login.role != "")
            {
                if (Login.role != "Administrator")
                {
                    icExport.Location = new Point(534, 23);
                    icPrint.Location = new Point(483, 23);
                    btnRefresh.Location = new Point(432,21);
                    lblLoading.Location = new Point(336, 31);
                    btnUrgentDelete.Visible = false;
                    btnOptimized.Visible = false;
                }
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

                if (isLeadPrep)
                {
                    if (guna2DataGridView1.Rows.Count > 0)
                    {
                        lblMessage.Visible = false;
                        guna2DataGridView1.Visible = true;

                        DGVPrinter printer = new DGVPrinter();
                        printer.Title = "Express Wires";
                        printer.SubTitle = $"{cmbLeadPrep.Text} Area";
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
                    }
                    else
                    {
                        lblMessage.Visible = true;
                        guna2DataGridView1.Visible = false;
                    }
                }
                else
                {
                    if (cmbMac.Text.Trim() != "")
                    {
                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            lblMessage.Visible = false;
                            guna2DataGridView1.Visible = true;

                            DGVPrinter printer = new DGVPrinter();
                            printer.Title = "Express Wires";
                            printer.SubTitle = cmbMac.Text;
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
                            urgentController.UrgentManagerExpress(guna2DataGridView1, cmbMac.Text, false);
                            printer.PrintDataGridView(guna2DataGridView1);
                            urgentController.UrgentManagerExpress(guna2DataGridView1,false);
                            cmbMac.SelectedIndex = -1;
                            if (chAllUrgents.Checked)
                            {
                                urgentController.UrgentManagerExpress(guna2DataGridView1, false);
                            }
                            else if (chOptimizedRecords.Checked)
                            {
                                urgentController.UrgentManagerExpress(guna2DataGridView1, true);
                            }
                            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                            foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                            {
                                if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                                    column.Width = 150;
                                else
                                    column.Width = 100;
                            }
                        }
                        else
                        {
                            lblMessage.Visible = true;
                            guna2DataGridView1.Visible = false;
                        }
                    }
                    else
                    {
                        ArrayList machines = urgentController.machines("Express");
                        int i = 0;
                        foreach (string machine in machines)
                        {
                            DGVPrinter printer = new DGVPrinter();
                            printer.Title = "Express Wires";
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
                            urgentController.UrgentManagerExpress(guna2DataGridView1, machine, false);
                            printer.PrintDataGridView(guna2DataGridView1);
                            i++;
                        }
                        if (chAllUrgents.Checked)
                        {
                            urgentController.UrgentManagerExpress(guna2DataGridView1, false);
                        }
                        else if (chOptimizedRecords.Checked)
                        {
                            urgentController.UrgentManagerExpress(guna2DataGridView1, true);
                        }
                        guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                        {
                            if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                                column.Width = 150;
                            else
                                column.Width = 100;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isLeadPrep = false;
            cmbMac.SelectedIndex = -1;
            if (chAllUrgents.Checked)
            {
                urgentController.UrgentManagerExpress(guna2DataGridView1, false);
            }
            else if (chOptimizedRecords.Checked)
            {
                urgentController.UrgentManagerExpress(guna2DataGridView1, true);
            }
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
            {
                if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                    column.Width = 150;
                else
                    column.Width = 100;
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

        private void cmbMac_SelectedIndexChanged(object sender, EventArgs e)
        {
            isLeadPrep = false;
            try
            {
                urgentController.UrgentManagerExpress(guna2DataGridView1, cmbMac.Text, true);
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                {
                    if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                        column.Width = 150;
                    else
                        column.Width = 100;
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
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gtxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            isLeadPrep = false;
            chAllUrgents.Checked = true;
            try
            {
                if(gtxtSearch.Text.Trim() != "")
                {

                    urgentController.singleUrgentExpress(guna2DataGridView1, gtxtSearch.Text, true);
                   
                }
                else
                {
                    if (chAllUrgents.Checked)
                    {
                        urgentController.UrgentManagerExpress(guna2DataGridView1, false);
                    }
                    else if (chOptimizedRecords.Checked)
                    {
                        urgentController.UrgentManagerExpress(guna2DataGridView1, true);
                    }
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
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void icExport_Click(object sender, EventArgs e)
        {
            try
            {
               if(guna2DataGridView1.Rows.Count > 0)
                {
                    lblLoading.Visible = true;
                    await Task.Run(new Action(generateExcel));
                    lblMessage.Visible = false;
                    guna2DataGridView1.Visible = true;
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
            foreach(DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Selected = false;
            }
            guna2DataGridView1.Rows[0].Selected = true;
        }

        private void cmbLeadPrep_SelectedIndexChanged(object sender, EventArgs e)
        {
            isLeadPrep = true;
            try
            {
                urgentController.fetchAllExpressRecords(guna2DataGridView1, cmbLeadPrep.Text);
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                throw;
            }
        }

        private void btnOptimized_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                if(guna2DataGridView1.Rows.Count > 0 && chOptimizedRecords.Checked)
                {
                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                       result += urgentController.UpdateUrgent(row.Cells[0].Value.ToString(), 1) ? 1 : 0;
                    }

                    if (result > 0)
                        MessageBox.Show($"{result} Records Optimized Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    urgentController.UrgentManagerExpress(guna2DataGridView1, false);
                    chAllUrgents.Checked = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void chAllUrgents_CheckedChanged(object sender, EventArgs e)
        {
            if (chAllUrgents.Checked)
            {
                chOptimizedRecords.Checked = false;
                urgentController.UrgentManagerExpress(guna2DataGridView1, false);
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                {
                    if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                        column.Width = 150;
                    else
                        column.Width = 100;
                }
                guna2DataGridView1.ScrollBars = ScrollBars.Both;
            }
            else
                chOptimizedRecords.Checked = true;

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

        private void chOptimizedRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (chOptimizedRecords.Checked)
            {
                chAllUrgents.Checked = false;
                urgentController.UrgentManagerExpress(guna2DataGridView1, true);
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                {
                    if (column.HeaderText == "Unico" || column.HeaderText == "Lead Code" || column.HeaderText == "Urgent Date" || column.HeaderText == "Alimentation" || column.HeaderText == "Location")
                        column.Width = 150;
                    else
                        column.Width = 100;
                }
                guna2DataGridView1.ScrollBars = ScrollBars.Both;
            }
            else
                chAllUrgents.Checked = true;

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
    }
}
