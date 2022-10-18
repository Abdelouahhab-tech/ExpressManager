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

        private void WireData_Load(object sender, EventArgs e)
        {
            try
            {
                lblLoadingMsg.Visible = true;
                AutoComplete.AutoComplete auto = new AutoComplete.AutoComplete();
                auto.autoComplete(cmbMachines, DbHelper.connection, "SELECT Machine FROM Machine");
                auto.autoComplete(cmbGroupe, DbHelper.connection, $"SELECT GroupRef FROM {GroupController.TABLENAME}");
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                guna2DataGridView1.ScrollBars = ScrollBars.Both;
                gtxtSearch.Focus();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void gtxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (gtxtSearch.Text == "")
                {
                    lblLoading.Visible = true;
                    await Task.Run(new Action(fetchRecordsWithNewItems));
                }
                if (gtxtSearch.Text.Trim() != "")
                {
                    if (gtxtSearch.Text.Contains("-"))
                    {
                       wireController.fetchRecords(guna2DataGridView1, list, gtxtSearch.Text);
                    }
                    else
                    {
                        wireController.fetchRecordsPerFamily(guna2DataGridView1, list, gtxtSearch.Text);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        ArrayList list = new ArrayList();

        private async void guna2CheckBox13_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                gtxtSearch.Text = "";
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
            catch (Exception)
            {

            }
        }

        private async void chProtection_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                gtxtSearch.Text = "";
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
            catch (Exception)
            {

            }
        }

        private async void chLeadPrep_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                gtxtSearch.Text = "";
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
            catch (Exception)
            {

            }
        }

        // Fetch Recods Asyncrounously
        private void fetch()
        {
            try
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {
                    wireController.fetchRecords(guna2DataGridView1,list);
                    lblLoading.Visible = false;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fetch Recods Syncrounously depend on machine

        private void fetchRecordsPerMac()
        {
            try
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {
                   
                        wireController.fetchRecordsPerMachine(guna2DataGridView1, list, "MC", cmbMachines.Text);
                        lblLoading.Visible = false;

                });
            }
            catch (Exception)
            {

            }
        }

        // Fetch Reords Per Groupe

        private void fetchRecordsPeGroupe()
        {
            try
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {

                    wireController.fetchRecordsPerMachine(guna2DataGridView1, list, "Groupe", cmbGroupe.Text);
                    lblLoading.Visible = false;

                });
            }
            catch (Exception)
            {

            }
        }

        // Fetch Recods Syncrounously deprnd on machine and new added Items

        private void fetchRecordsWithNewItems()
        {
            try
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {
                    wireController.fetchRecords(guna2DataGridView1, list);
                    lblLoading.Visible = false;
                });
            }
            catch (Exception)
            {

            }
        }

        private async void icExport_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            try
            {
                await Task.Run(new Action(generateExcel));
            }
            catch (Exception)
            {
                lblLoading.Visible = false;
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

        private void icExport_MouseEnter(object sender, EventArgs e)
        {
            icExport.IconColor = Color.FromArgb(255, 234, 79, 12);
        }

        private void icExport_MouseLeave(object sender, EventArgs e)
        {
            icExport.IconColor = Color.White;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await Task.Run(new Action(fetch));
            lblLoadingMsg.Visible = false;
            foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
            {
                if (col.HeaderText == "Location" || col.HeaderText == "Entry Agent" || col.HeaderText == "Unico" || col.HeaderText == "Lead Code")
                    col.Width = 180;
                else
                    col.Width = 100;
            }
            timer1.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbGroupe.Text = "";
            cmbMachines.Text = "";
            fetch();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UpdateMCORGroupe update = new UpdateMCORGroupe();
            update.ShowDialog();
        }

        private async void cmbMachines_KeyUp(object sender, KeyEventArgs e)
        {
            if(cmbMachines.Text.Trim() != "")
            {
                if (wireController.IsExist(cmbMachines.Text, "Machine", "Machine"))
                {
                    lblLoading.Visible = true;
                    await Task.Run(new Action(fetchRecordsPerMac));
                }
            }
            else
            {
                lblLoading.Visible = true;
                await Task.Run(new Action(fetch));
            }
        }

        private async void cmbGroupe_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbGroupe.Text.Trim() != "")
            {
                if (wireController.IsExist(cmbGroupe.Text, GroupController.TABLENAME, "GroupRef"))
                {
                    lblLoading.Visible = true;
                    await Task.Run(new Action(fetchRecordsPeGroupe));
                }
            }
            else
            {
                lblLoading.Visible = true;
                await Task.Run(new Action(fetch));
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.FromArgb(255, 234, 79, 12);

        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.White;
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
