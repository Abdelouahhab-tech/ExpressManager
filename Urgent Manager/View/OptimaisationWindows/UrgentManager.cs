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
        WPCSController wpcs = new WPCSController();

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
            try
            {
                urgentController.FillCombobox("Machine", "Machine", cmbMac);
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
                guna2DataGridView1.ScrollBars = ScrollBars.Both;
                gtxtSearch.Focus();
                if (Login.role != "")
                {
                    if (Login.role != "Administrator")
                    {
                        icExport.Location = new Point(534, 38);
                        icPrint.Location = new Point(483, 38);
                        btnRefresh.Location = new Point(432, 36);
                        lblLoading.Location = new Point(336, 46);
                        btnUrgentDelete.Visible = false;
                        btnOptimized.Visible = false;
                        chAllUrgents.Visible = false;
                        chOptimizedRecords.Visible = false;
                    }
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
                        DialogResult res = MessageBox.Show("Are You Sure You Want To Print This LeadPrep Urgents ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if(res == DialogResult.Yes)
                        {
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
                            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
                            printer.PrintNoDisplay(guna2DataGridView1);
                            guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
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
                    if (cmbMac.Text.Trim() != "")
                    {
                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            lblMessage.Visible = false;
                            guna2DataGridView1.Visible = true;
                            DialogResult res = MessageBox.Show("Are You Sure You Want To Print This Machine Urgents ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if(res == DialogResult.Yes)
                            {
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
                                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;

                                urgentController.UrgentManagerExpress(guna2DataGridView1, cmbMac.Text, false);
                                foreach (DataGridViewColumn c in guna2DataGridView1.Columns)
                                {
                                    if (c.HeaderText == "Location")
                                        c.Width = 140;
                                    else if (c.HeaderText == "Unico" || c.HeaderText == "Lead Code" || c.HeaderText == "Express Date" || c.HeaderText == "Cable")
                                        c.Width = 80;
                                    else if (c.HeaderText == "MarL" || c.HeaderText == "MarR")
                                        c.Width = 40;
                                }
                                printer.PrintNoDisplay(guna2DataGridView1);
                                guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
                                urgentController.UrgentManagerExpress(guna2DataGridView1, false);
                            }
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
                        machines.Sort();
                        int i = 0;
                        DialogResult res = MessageBox.Show("Are You Sure You Want To Print All Machines Urgents ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
                        if(res == DialogResult.Yes)
                        {
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
                                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
                                urgentController.UrgentManagerExpress(guna2DataGridView1, machine, false);
                                foreach (DataGridViewColumn c in guna2DataGridView1.Columns)
                                {
                                    if (c.HeaderText == "Location")
                                        c.Width = 140;
                                    else if (c.HeaderText == "Unico" || c.HeaderText == "Lead Code" || c.HeaderText == "Express Date" || c.HeaderText == "Cable")
                                        c.Width = 80;
                                    else if (c.HeaderText == "MarL" || c.HeaderText == "MarR")
                                        c.Width = 40;
                                }
                                printer.PrintNoDisplay(guna2DataGridView1);
                                i++;
                            }
                            guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
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
            try
            {
                cmbMac.SelectedIndex = -1;
                isLeadPrep = false;
                gtxtSearch.Text = "";
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
                foreach(DataGridViewCell c in row.Cells)
                {
                    c.Selected = false;
                }
            }
            guna2DataGridView1.Rows[0].Cells[0].Selected = true;
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
            try
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
            catch (Exception)
            {
                
            }
        }

        private void chOptimizedRecords_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chOptimizedRecords.Checked)
                {
                    chAllUrgents.Checked = false;
                    gtxtSearch.Text = "";
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

        private void icPrint_MouseEnter(object sender, EventArgs e)
        {
            icPrint.IconColor = Color.FromArgb(255, 234, 79, 12);
        }

        private void icPrint_MouseLeave(object sender, EventArgs e)
        {
            icPrint.IconColor = Color.White;
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.Image = Properties.Resources.refreshRed;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.Image = Properties.Resources.refresh;
        }
    }
}
