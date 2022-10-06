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

namespace Urgent_Manager.View
{
    public partial class Alimentation : Form
    {
        UrgentController urgentController = new UrgentController();
        AutoComplete.AutoComplete auto = new AutoComplete.AutoComplete();
        private int count = 0;
        public Alimentation()
        {
            InitializeComponent();
        }

        private void Alimentation_Load(object sender, EventArgs e)
        {
            try
            {
                auto.autoComplete(gtxtScanne, DbHelper.connection, "SELECT Unico FROM Wire WHERE WireStatus=1");
                lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                timer1.Start();
                gtxtScanne.Focus();
                timer1.Start();
                urgentController.DeleteUrgent();
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

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScanneUrgent_Click(object sender, EventArgs e)
        {
            string machine = "";
            string date = Convert.ToDateTime(DateTime.Now).Subtract(TimeSpan.FromDays(1)).ToString("dd/MM/yyyy");
            try
            {
                if(gtxtScanne.Text.Trim() != "")
                {
                    if (urgentController.IsExist(gtxtScanne.Text))
                    {
                        if (!urgentController.isAlreadyExist(gtxtScanne.Text))
                        {
                            UrgentModel urgent = new UrgentModel();
                            urgent.UrgentUnico = gtxtScanne.Text;
                            urgent.DateUrgent = DateTime.Now.Hour >= 00 && DateTime.Now.Hour < 6 ? date : DateTime.Now.ToShortDateString();
                            urgent.Time = DateTime.Now.ToShortTimeString();
                            urgent.Shift = Shift().ToString();
                            urgent.UrgentStatus = UrgentModel.Status.Express.ToString();
                            urgent.Alimentation = Login.username;
                            urgent.UserFinished = "";
                            urgent.FinishedDate = "";

                            urgentController.InsertUrgent(urgent);
                            machine = urgentController.getMachine(gtxtScanne.Text);
                            
                            lblUnico.Text = $"LeadCode: {urgentController.getLeadCode(gtxtScanne.Text)}";
                            lblMachine.Text = $"Machine: {machine}";
                            lblUnico.Visible = true;
                            lblMachine.Visible = true;
                            icValid.IconChar = FontAwesome.Sharp.IconChar.Check;
                            icValid.IconColor = Color.Green;
                            icValid.Visible = true;

                            gtxtScanne.Text = "";
                            gtxtScanne.Focus();
                        }
                        else
                        {
                            machine = urgentController.getMachine(gtxtScanne.Text);
                            MessageBox.Show($"Sorry This Urgent Is Already Planned In Machine {machine}", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                            lblUnico.Text = gtxtScanne.Text.ToUpper() == urgentController.getUnico(urgentController.getLeadCode(gtxtScanne.Text)).ToUpper() ? $"Unico : {gtxtScanne.Text}" : $"Similar Wire : {urgentController.getUnico(urgentController.getLeadCode(gtxtScanne.Text))}";
                            lblMachine.Text = $"Machine: {machine}";
                            lblUnico.Visible = true;
                            lblMachine.Visible = true;
                            icValid.IconChar = FontAwesome.Sharp.IconChar.Times;
                            icValid.IconColor = Color.Red;
                            icValid.Visible = true;
                            gtxtScanne.Text = "";
                            gtxtScanne.Focus();
                            gtxtScanne.FocusedState.BorderColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Sorry This Urgent Is Not Exist Or It Was Stopped", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gtxtScanne.FocusedState.BorderColor = Color.Red;
                        gtxtScanne.Focus();
                        gtxtScanne.SelectAll();
                    }
                }
                else
                {
                    gtxtScanne.FocusedState.BorderColor = Color.Red;
                    gtxtScanne.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Gets The Shift Work

        private UrgentModel.Shifts Shift()
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14)
            {
                return UrgentModel.Shifts.Matin;
            }
            else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22)
            {
                return UrgentModel.Shifts.Soir;
            }
            else
            {
                return UrgentModel.Shifts.Nuit;
            }
        }

        private void gtxtScanne_Leave(object sender, EventArgs e)
        {
            gtxtScanne.FocusedState.BorderColor = Color.FromArgb(255, 90, 167, 167);
        }

        private void gtxtScanne_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void gtxtScanne_KeyDown_1(object sender, KeyEventArgs e)
        {
            count = 0;
            if (e.KeyCode == Keys.Enter)
                btnScanneUrgent.PerformClick();
            else if(e.KeyCode != Keys.Enter)
            {
                gtxtScanne.FocusedState.BorderColor = Color.White;
                lblUnico.Visible = false;
                lblMachine.Visible = false;
                icValid.Visible = false;
            }
        }

        private void gtxtScanne_Leave_1(object sender, EventArgs e)
        {
            gtxtScanne.FocusedState.BorderColor = Color.White;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(count == 10)
            {
                Login lg = new Login();
                Close();
                lg.Show();
            }
            count++;
        }
    }
}
