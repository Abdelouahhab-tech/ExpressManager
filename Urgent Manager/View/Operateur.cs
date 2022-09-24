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
using Urgent_Manager.View.DashBoard;
using ZXing;

namespace Urgent_Manager.View
{
    public partial class Operateur : Form
    {
        UrgentController urgentController = new UrgentController();
        WireController wireController = new WireController();
        WPCSController wpcsController = new WPCSController();
        int selectedRow = 0;
        string mc = Environment.MachineName;
        string bobine = "";
        public Operateur()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();
        }

        private void Operateur_Load(object sender, EventArgs e)
        {
            try
            {
                if (!urgentController.IsExist(Environment.MachineName, "Machine", "Machine"))
                {
                    MessageBox.Show("Access Denied", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Login l = new Login();
                    l.Show();
                    Close();
                    return;
                }
                updateUrgentStatus();
                urgentController.DeleteUrgent();
                wireController.FillCombobox("Machine", "Machine", cmbPlanBMc);
                AutoComplete.AutoComplete auto = new AutoComplete.AutoComplete();
                auto.autoComplete(gtxtUnico, DbHelper.connection, "SELECT Unico FROM Wire WHERE WireStatus=1");
                cmbPlanBMc.Text = mc;
                Wpcs.Start();
                timer2.Start();
                fetchData(mc);
                if (guna2DataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewColumn c in guna2DataGridView1.Columns)
                    {
                        c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    string unico = guna2DataGridView1.Rows[0].Cells[1].Value.ToString();
                    if (unico != "")
                    {
                        fetchExpressSingleRecord(mc, unico);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            guna2ControlBox2.PerformClick();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (chNormalWire.Checked)
                    {
                        fetchNormalSingleRecord(mc, guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    }
                    else
                    {
                        fetchExpressSingleRecord(mc, guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                        selectedRow = e.RowIndex;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Fetch All The Express Data From Urgent Table

        public void fetchData(string machine)
        {
            try
            {
                urgentController.fetchAllExpressRecords(machine,guna2DataGridView1);

                if (guna2DataGridView1.Rows.Count > 0)
                {
                    guna2DataGridView1.Rows[selectedRow].Selected = true;
                }
                else
                {
                    selectedRow = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetch Wire Records

        public void fetchExpressSingleRecord(string machine,string unico)
        {
            try
            {
                UrgentModel urgent = new UrgentModel();
                urgent = urgentController.fetchSingleExpressRecord(machine, unico);

                // Header Data
                lblUnico.Text = urgent.UrgentUnico;
                lblLeadCode.Text = urgent.LeadCode;
                lblUrgentDate.Text = urgent.DateUrgent + "  " + urgent.Time;
                lblMachine.Text = machine;
                lblAdress.Text = urgent.Adress;
                lblUrgents.Text = urgentController.actualUrgents(machine).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void chNormalWire_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chNormalWire.Checked)
                {
                    initBackColor(true);
                    foreach(DataGridViewColumn c in guna2DataGridView1.Columns)
                    {
                        c.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    gtxtUnico.Visible = true;
                    gtxtUnico.Focus();
                    panelBorderBottom.Visible = true;
                    lblUrgentDate.Text = "Loading...";
                    // Fill DataGridView With Normal Wires

                    fetchNormalRecords(mc);
                    if(guna2DataGridView1.Rows.Count > 0)
                    {
                        fetchNormalSingleRecord(mc, guna2DataGridView1.Rows[0].Cells[1].Value.ToString());
                    }
                }
                else
                {
                    initBackColor(false);
                    foreach (DataGridViewColumn c in guna2DataGridView1.Columns)
                    {
                        c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    gtxtUnico.Visible = false;
                    panelBorderBottom.Visible = false;
                    gtxtUnico.Text = "";


                    // Fill DataGridView With Express Wires
                    fetchData(mc);
                    if (guna2DataGridView1.Rows.Count > 0)
                    {
                        fetchExpressSingleRecord(mc, guna2DataGridView1.Rows[selectedRow].Cells[1].Value.ToString());
                    }
                    else
                    {
                        lblUnico.Text = "Loading...";
                        lblLeadCode.Text = "Loading...";
                        lblAdress.Text = "Loading...";
                        lblUrgents.Text = "Loading...";
                        lblUrgentDate.Text = "Loading...";
                        lblMachine.Text = mc;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fetch Normal Records

        private void fetchNormalRecords(string machine)
        {
            try
            {
                wireController.fetchNormalRecords(machine,guna2DataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Handling Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetch a Single Normal Data Record From Wire Table

        public void fetchNormalSingleRecord(string machine, string unico)
        {
            try
            {
                WireModel wire = new WireModel();
                wire = wireController.fetchNormalSingleRecord(machine, unico);

                // Header Data
                lblUnico.Text = wire.Unico;
                lblLeadCode.Text = wire.LeadCode;
                lblMachine.Text = machine;
                lblAdress.Text = wire.Adress;
                lblUrgents.Text = urgentController.actualUrgents(machine).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gtxtUnico_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (gtxtUnico.Text.Trim() != "")
                {
                    wireController.fetchSingleRecord(gtxtUnico.Text,guna2DataGridView1);

                    if (guna2DataGridView1.Rows.Count > 0)
                    {
                        fetchNormalSingleRecord(wireController.Machine(guna2DataGridView1.Rows[0].Cells[1].Value.ToString()), guna2DataGridView1.Rows[0].Cells[1].Value.ToString());
                    }
                    else
                    {
                        lblUnico.Text = "Loading...";
                        lblLeadCode.Text = "Loading...";
                        lblAdress.Text = "Loading...";
                        lblUrgents.Text = "Loading...";
                        lblUrgentDate.Text = "Loading...";
                        lblMachine.Text = mc;
                    }
                }
                else if(gtxtUnico.Text == "")
                {
                    fetchNormalRecords(mc);
                    if(guna2DataGridView1.Rows.Count > 1)
                    {
                        fetchNormalSingleRecord(mc, guna2DataGridView1.Rows[0].Cells[1].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                CableModel cable = wireController.fetchCable(bobine.ToUpper());

                Font f = new Font("Arial", 9, FontStyle.Bold);
                e.Graphics.DrawString("Commande Bobine", f, Brushes.Black, new Point(20,10));
                e.Graphics.DrawLine(Pens.Black, new Point(5, f.Height + 20), new Point(e.PageBounds.Width - 14, f.Height + 20));
                e.Graphics.DrawString("Bobine", f, Brushes.Black, new Point(5, f.Height + 40));
                Rectangle rect = new Rectangle(70, f.Height + 40, e.PageBounds.Width - 70, f.Height + 30);
                e.Graphics.DrawString(bobine.ToUpper(), f, Brushes.Black, rect);
                e.Graphics.DrawString("Section", f, Brushes.Black, new Point(5, f.Height + 80));
                e.Graphics.DrawString(cable.Section.ToUpper(), f, Brushes.Black, new Point(70, f.Height + 80));
                e.Graphics.DrawString("Color", f, Brushes.Black, new Point(5, f.Height + 120));
                e.Graphics.DrawString(cable.Color.ToUpper(), f, Brushes.Black, new Point(70, f.Height + 120));
                e.Graphics.DrawString("MC", f, Brushes.Black, new Point(5, f.Height + 160));
                e.Graphics.DrawString(Environment.MachineName.ToUpper(), f, Brushes.Black, new Point(70, f.Height + 160));
                BarcodeWriter br = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                br.Options.Height = 25;
                br.Options.Margin = 0;
                br.Options.PureBarcode = true;
                Image img = br.Write("1P" + bobine.ToUpper());
                e.Graphics.DrawImage(img, new Point(2, f.Height + 190));
                e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), f, Brushes.Black, new Point(20, img.Height + 210));
            }
            catch (Exception ex)
            {
            }
        }

        private void Wpcs_Tick(object sender, EventArgs e)
        {
            updateUrgentStatus();
        }

        private void updateUrgentStatus()
        {
        
            try
            {
                if (wpcsController.DeleteUrgent())
                {
                    if (!chNormalWire.Checked)
                    {
                        selectedRow -= 1;
                        selectedRow = selectedRow <= 0 ? 0 : selectedRow;
                        fetchData(mc);
                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            fetchExpressSingleRecord(mc, guna2DataGridView1.Rows[selectedRow].Cells[1].Value.ToString());
                        }
                        else
                        {
                            lblUnico.Text = "Loading...";
                            lblLeadCode.Text = "Loading...";
                            lblAdress.Text = "Loading...";
                            lblMachine.Text = "Loading...";
                            lblUrgents.Text = "Loading...";
                            lblUrgentDate.Text = "Loading...";
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!WPCSController.isConnect())
                {
                    Application.Exit();
                }
                if (!chNormalWire.Checked)
                {
                    fetchData(mc);
                    if (guna2DataGridView1.Rows.Count == 0)
                    {
                        lblUnico.Text = "Loading...";
                        lblLeadCode.Text = "Loading...";
                        lblAdress.Text = "Loading...";
                        lblMachine.Text = "Loading...";
                        lblUrgents.Text = "Loading...";
                        lblUrgentDate.Text = "Loading...";
                    }
                    else
                    {
                        guna2DataGridView1.Rows[selectedRow].Selected = true;
                        fetchExpressSingleRecord(mc, guna2DataGridView1.Rows[selectedRow].Cells[1].Value.ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void chIsPlanB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chIsPlanB.Checked)
                {
                    cmbPlanBMc.Visible = true;
                    pnlCmbPlanBMachine.Visible = true;
                }
                else
                {
                    cmbPlanBMc.Visible = false;
                    cmbPlanBMc.SelectedIndex = -1;
                    selectedRow = 0;
                    pnlCmbPlanBMachine.Visible = false;
                    mc = Environment.MachineName;
                    if (chNormalWire.Checked)
                    {
                        fetchNormalRecords(mc);
                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            string unico = guna2DataGridView1.Rows[0].Cells[1].Value.ToString();
                            if (unico != "")
                            {
                                fetchNormalSingleRecord(mc, unico);
                            }
                        }
                        else
                        {
                            lblUnico.Text = "Loading...";
                            lblLeadCode.Text = "Loading...";
                            lblAdress.Text = "Loading...";
                            lblMachine.Text = "Loading...";
                            lblUrgents.Text = "Loading...";

                        }
                    }
                    else
                    {
                        fetchData(mc);
                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            string unico = guna2DataGridView1.Rows[0].Cells[1].Value.ToString();
                            if (unico != "")
                            {
                                fetchExpressSingleRecord(mc, unico);
                            }
                        }
                        else
                        {
                            lblUnico.Text = "Loading...";
                            lblLeadCode.Text = "Loading...";
                            lblAdress.Text = "Loading...";
                            lblMachine.Text = "Loading...";
                            lblUrgents.Text = "Loading...";
                            lblUrgentDate.Text = "Loading...";
                        }
                    }

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
                if (cmbPlanBMc.Text.Trim() != "")
                {
                    mc = cmbPlanBMc.Text;
                    selectedRow = 0;
                    if (chNormalWire.Checked)
                    {
                        fetchNormalRecords(mc);
                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            string unico = guna2DataGridView1.Rows[0].Cells[1].Value.ToString();
                            if (unico != "")
                            {
                                fetchNormalSingleRecord(mc, unico);
                            }
                        }
                        else
                        {
                            lblUnico.Text = "Loading...";
                            lblLeadCode.Text = "Loading...";
                            lblAdress.Text = "Loading...";
                            lblMachine.Text = "Loading...";
                            lblUrgents.Text = "Loading...";
                            lblUrgentDate.Text = "Loading...";
                        }
                    }
                    else
                    {
                        fetchData(mc);
                        if (guna2DataGridView1.Rows.Count > 0)
                        {
                            foreach (DataGridViewColumn c in guna2DataGridView1.Columns)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                            }
                            string unico = guna2DataGridView1.Rows[0].Cells[1].Value.ToString();
                            if (unico != "")
                            {
                                fetchExpressSingleRecord(mc, unico);
                            }
                        }
                        else
                        {
                            lblUnico.Text = "Loading...";
                            lblLeadCode.Text = "Loading...";
                            lblAdress.Text = "Loading...";
                            lblMachine.Text = "Loading...";
                            lblUrgents.Text = "Loading...";
                            lblUrgentDate.Text = "Loading...";
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void gbtnPrototype_Click(object sender, EventArgs e)
        {
            Prototype proto = new Prototype();
            proto.ShowDialog();
        }

        private void gbtnPrototype_MouseEnter(object sender, EventArgs e)
        {
            gbtnPrototype.Image = Properties.Resources.WhiteDimensions;
        }

        private void gbtnPrototype_MouseLeave(object sender, EventArgs e)
        {
            gbtnPrototype.Image = Properties.Resources.dimensions;
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    bobine = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if(bobine != "")
                         printDocument1.Print();
                }
            }
            catch (Exception)
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_AllowUserToOrderColumnsChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ordered");
        }

        // Initialize Datagrid View Back Color
        public void initBackColor(bool ischecked)
        {
            try
            {
                if (ischecked)
                {
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 94, 148, 255);
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Red;
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
                    guna2DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
