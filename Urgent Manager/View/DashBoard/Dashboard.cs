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
using Urgent_Manager.View.OptimaisationWindows;

namespace Urgent_Manager.View.DashBoard
{
    public partial class Dashboard : Form
    {

        UrgentController urgentController = new UrgentController();
        string selectedItem = "";
        Color mainColor = Color.FromArgb(255, 234, 79, 12);
        Color secondColor = Color.FromArgb(255, 0, 152, 120);
        public Dashboard()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icUrgent_Click(object sender, EventArgs e)
        {
            if (panelControls.Visible)
            {
                panelControls.Visible = false;
                btnCredentials.Location = new Point(0, 102);
                btnStatistics.Location = new Point(0, 140);
                btnUrgentManager.Location = new Point(0, 178);
                btnArchiveManager.Location = new Point(0, 216);
                selectedItem = icUrgent.Text;
                ChangeColor(sideBar,mainColor);
            }
            else
            {
                panelControls.Visible = true;
                btnCredentials.Location = new Point(0, 423);
                btnStatistics.Location = new Point(0, 461);
                btnUrgentManager.Location = new Point(0, 499);
                btnArchiveManager.Location = new Point(0, 537);
                selectedItem = icUrgent.Text;
                ChangeColor(sideBar,mainColor);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            urgentController.DeleteUrgent();
            if (Login.FullName != "")
                lblUser.Text = "Welcome " + Login.FullName;
            else
                lblUser.Text = "";

            btnCredentials.Location = new Point(0, 102);
            btnStatistics.Location = new Point(0, 140);
            btnUrgentManager.Location = new Point(0, 178);
            btnArchiveManager.Location = new Point(0, 216);

            // Give The Access Depend On User's Role
            if (Login.role != "")
            {
                if(Login.role == "Entry Agent")
                {
                    btnCredentials.Visible = false;
                    btnUrgentManager.Visible = false;
                    btnArchiveManager.Visible = false;
                    btnStatistics.Visible = false;
                    panelControls.Height = 500;
                    panelControls.Visible = true;
                    subForm(new WireData());
                    selectedItem = icUrgent.Text;
                    icUrgent.BackColor = Color.FromArgb(255,234,79,12);
                    iconButton1.BackColor = secondColor;
                    
                }
                else if(Login.role == "Shift Leader")
                {
                    icUrgent.Visible = false;
                    btnCredentials.Visible = false;
                    btnUrgentManager.Location = new Point(0, 64);
                    btnStatistics.Location = new Point(0, 102);
                    btnArchiveManager.Location = new Point(0, 140);
                    subForm(new Statistics());
                    selectedItem = btnStatistics.Text;
                    btnStatistics.BackColor = Color.FromArgb(255, 234, 79, 12);
                }
                else
                {
                    subForm(new Statistics());
                    selectedItem = btnStatistics.Text;
                    btnStatistics.BackColor = Color.FromArgb(255, 234, 79, 12);
                }
            }
            else
            {
                Login log = new Login();
                log.Show();
                Close();
            }
        }

        private void btnMachine_Click(object sender, EventArgs e)
        {
            subForm(new Machine());
            selectedItem = btnMachine.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        // Creating Method To Fiil The Main Panel With SubForms

        Form active = null;
        private void subForm(Form ChildForm)
        {
            if (active != null)
                active.Close();
            active = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            subForm(new Area());
            selectedItem = btnArea.Text;
            ChangeColor(panelControls,secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnFamille_Click(object sender, EventArgs e)
        {
            subForm(new FamilyView());
            selectedItem = btnFamille.Text;
            ChangeColor(panelControls, secondColor);
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnBobine_Click(object sender, EventArgs e)
        {
            subForm(new Bobine());
            selectedItem = btnBobine.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnOutil_Click(object sender, EventArgs e)
        {
            subForm(new Tool());
            selectedItem = btnOutil.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            subForm(new Terminal());
            selectedItem = btnTerminal.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnSeal_Click(object sender, EventArgs e)
        {
            subForm(new Seal());
            selectedItem = btnSeal.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnProtection_Click(object sender, EventArgs e)
        {
            subForm(new Protection());
            selectedItem = btnProtection.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            subForm(new Group());
            selectedItem = btnGroup.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void btnMarker_Click(object sender, EventArgs e)
        {
            subForm(new Marker());
            selectedItem = btnMarker.Text;
            ChangeColor(panelControls, secondColor);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            subForm(new Wire());
            selectedItem = iconButton2.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            subForm(new WireData());
            selectedItem = iconButton1.Text;
            ChangeColor(panelControls, secondColor);
            ControlsPanelInitBkColor(sideBar);
        }

        private void NavBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {
            subForm(new User());
            selectedItem = btnCredentials.Text;
            ChangeColor(sideBar,mainColor);
            ControlsPanelInitBkColor(panelControls);
        }

        private void btnUrgentManager_Click(object sender, EventArgs e)
        {
            subForm(new UrgentManager());
            selectedItem = btnUrgentManager.Text;
            ChangeColor(sideBar,mainColor);
            ControlsPanelInitBkColor(panelControls);
        }

        private void btnArchiveManager_Click(object sender, EventArgs e)
        {
            subForm(new ArchiveManager());
            selectedItem = btnArchiveManager.Text;
            ChangeColor(sideBar,mainColor);
            ControlsPanelInitBkColor(panelControls);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            subForm(new Statistics());
            selectedItem = btnStatistics.Text;
            ChangeColor(sideBar,mainColor);
            ControlsPanelInitBkColor(panelControls);
        }

        private void icServerData_Click(object sender, EventArgs e)
        {
            subForm(new ServerData());
        }

        // Initialize Buttons BackColor
        private void ChangeColor(Panel p,Color c)
        {
            try
            {
                foreach (Control btn in p.Controls)
                {
                    if(btn is FontAwesome.Sharp.IconButton)
                    {
                        if (selectedItem == btn.Text)
                        {
                            btn.BackColor = c;
                        }
                        else
                        {
                            btn.BackColor = Color.FromArgb(255, 17, 17, 17);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        // Initialize Controls Panel BackColor
        private void ControlsPanelInitBkColor(Panel p)
        {
            try
            {
                foreach (Control btn in p.Controls)
                {
                    if (btn is FontAwesome.Sharp.IconButton)
                    {
                        btn.BackColor = Color.FromArgb(255, 17, 17, 17);
                        if (p == sideBar)
                            icUrgent.BackColor = mainColor;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
