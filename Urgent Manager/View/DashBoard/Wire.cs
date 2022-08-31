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
using Guna.UI2.WinForms;
using Urgent_Manager.Model;
using System.Text.RegularExpressions;

namespace Urgent_Manager.View.DashBoard
{
    public partial class Wire : Form
    {
        WireController wireController = new WireController();
        public Wire()
        {
            InitializeComponent();
        }

        private void cmbLeadPrep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Wire_Load(object sender, EventArgs e)
        {
            gtxtUnico.Focus();
            try
            {
                AutoComplete.AutoComplete auto = new AutoComplete.AutoComplete();
                auto.autoComplete(gtxtCable, DbHelper.connection, "SELECT Cable FROM Cable");
                auto.autoComplete(gtxtFamily, DbHelper.connection, "SELECT FAM FROM Family");
                auto.autoComplete(gtxtGroup, DbHelper.connection, "SELECT GroupRef FROM Groupe");
                auto.autoComplete(gtxtMachine, DbHelper.connection, "SELECT Machine FROM Machine");
                auto.autoComplete(gtxtMarkerD, DbHelper.connection, "SELECT Color FROM Marker");
                auto.autoComplete(gtxtMarkerG, DbHelper.connection, "SELECT Color FROM Marker");
                auto.autoComplete(gtxtProtectionD, DbHelper.connection, "SELECT Type FROM Protection");
                auto.autoComplete(gtxtProtectionG, DbHelper.connection, "SELECT Type FROM Protection");
                auto.autoComplete(gtxtSealD, DbHelper.connection, "SELECT Seal FROM Seal");
                auto.autoComplete(gtxtSealG, DbHelper.connection, "SELECT Seal FROM Seal");
                auto.autoComplete(gtxtTerminalD, DbHelper.connection, "SELECT TerminalID FROM Terminal");
                auto.autoComplete(gtxtTerminalG, DbHelper.connection, "SELECT TerminalID FROM Terminal");
                auto.autoComplete(gtxtToolD, DbHelper.connection, "SELECT ToolID FROM Tool");
                auto.autoComplete(gtxtToolG, DbHelper.connection, "SELECT ToolID FROM Tool");
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[1-9]");
            try
            {
                if (gtxtUnico.Text.Trim() != "" && gtxtLeadCode.Text.Trim() != "" 
                    && gtxtLength.Text.Trim() != "" && regex.IsMatch(gtxtLength.Text) 
                    && gtxtCable.Text.Trim() != "" && gtxtFamily.Text.Trim() != "" 
                    && gtxtMachine.Text.Trim() != "" && gtxtGroup.Text.Trim() != "" 
                    && Login.username != "" && wireController.IsExist(gtxtCable.Text,"Cable","Cable")
                    && wireController.IsExist(gtxtFamily.Text, "Family", "FAM") && wireController.IsExist(gtxtGroup.Text, "Groupe", "GroupRef")
                    && wireController.IsExist(gtxtMachine.Text, "Machine", "Machine") && wireController.IsExist(gtxtMarkerD.Text, "Marker", "Color")
                    && wireController.IsExist(gtxtMarkerG.Text, "Marker", "Color") && wireController.IsExist(gtxtProtectionD.Text, "Protection", "Type")
                    && wireController.IsExist(gtxtProtectionG.Text, "Protection", "Type") && wireController.IsExist(gtxtSealD.Text, "Seal", "Seal")
                    && wireController.IsExist(gtxtSealG.Text, "Seal", "Seal") && wireController.IsExist(gtxtTerminalD.Text, "Terminal", "TerminalID")
                    && wireController.IsExist(gtxtTerminalG.Text, "Terminal", "TerminalID") && wireController.IsExist(gtxtToolD.Text, "Tool", "ToolID")
                    && wireController.IsExist(gtxtToolG.Text, "Tool", "ToolG"))
                {
                    if (!wireController.IsExist(gtxtUnico.Text, "Wire", "Unico"))
                    {
                        WireModel wire = new WireModel();
                        wire.Family = gtxtFamily.Text;
                        wire.Unico = gtxtUnico.Text;
                        wire.LeadCode = gtxtLeadCode.Text;
                        wire.Length = gtxtLength.Text;
                        wire.Cable = gtxtCable.Text;
                        wire.MarkL = gtxtMarkerG.Text;
                        wire.SealL = gtxtSealG.Text;
                        wire.TerL = gtxtTerminalG.Text;
                        wire.ToolL = gtxtToolG.Text;
                        wire.ProtectionL = gtxtProtectionG.Text;
                        wire.MarkR = gtxtMarkerD.Text;
                        wire.SealR = gtxtSealD.Text;
                        wire.TerR = gtxtTerminalD.Text;
                        wire.ToolR = gtxtToolD.Text;
                        wire.ProtectionR = gtxtProtectionD.Text;
                        wire.GroupRef = gtxtGroup.Text;
                        wire.LeadPrep = gtxtLeadPrep.Text;
                        wire.Adress = gtxtAdress.Text;
                        wire.Mc = gtxtMachine.Text;
                        wire.UserID = Login.username;

                        wireController.InsertWire(wire);
                        init();
                        
                    }
                    else
                    {
                        MessageBox.Show("Sorry This Wire Already Exist Try To Add Another One", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblUnico.ForeColor = Color.Red;
                        gtxtUnico.Focus();
                        gtxtUnico.FocusedState.BorderColor = Color.White;
                    }
                }
                else
                {
                    if(gtxtUnico.Text == "")
                    {
                        lblUnico.ForeColor = Color.Red;
                        gtxtUnico.Focus();
                        gtxtUnico.FocusedState.BorderColor = Color.White;

                    }else if(gtxtLeadCode.Text == "")
                    {

                        lblLeadCode.ForeColor = Color.Red;
                        gtxtLeadCode.Focus();
                        gtxtLeadCode.FocusedState.BorderColor = Color.White;

                    }
                    else if(gtxtLength.Text == "")
                    {

                        lblLength.ForeColor = Color.Red;
                        gtxtLength.Focus();
                        gtxtLength.FocusedState.BorderColor = Color.White;

                    }
                    else if (!regex.IsMatch(gtxtLength.Text))
                    {

                        lblLength.ForeColor = Color.Red;
                        gtxtLength.Focus();
                        gtxtLength.SelectAll();
                        gtxtLength.FocusedState.BorderColor = Color.White;
                        MessageBox.Show("The Length Must Be a Number More Than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (gtxtCable.Text == "")
                    {
                        lblCable.ForeColor = Color.Red;
                        gtxtCable.Focus();
                        gtxtCable.FocusedState.BorderColor = Color.White;
                    }
                    else if (gtxtFamily.Text == "")
                    {

                        lblFamily.ForeColor = Color.Red;
                        gtxtFamily.Focus();
                        gtxtFamily.FocusedState.BorderColor = Color.White;

                    }
                    else if (gtxtGroup.Text == "")
                    {
                        lblGroup.ForeColor = Color.Red;
                        gtxtGroup.Focus();
                        gtxtGroup.FocusedState.BorderColor = Color.White;
                    }
                    else if (gtxtMachine.Text == "")
                    {
                        lblMc.ForeColor = Color.Red;
                        gtxtMachine.Focus();
                        gtxtMachine.FocusedState.BorderColor = Color.White;
                    }
                    else if (Login.username == "")
                    {
                        MessageBox.Show("Sorry You Don't Have Prmissions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Login l = new Login();
                        this.Close();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Choose The Data From The List", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry An Error Accured While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void init()
        {
            gtxtUnico.Text = "";
            gtxtLeadCode.Text = "";
            gtxtAdress.Text = "";
            gtxtLeadPrep.Text = "";
            gtxtLength.Text = "";
            gtxtGroup.Text = "";
            gtxtTerminalG.Text = "";
            gtxtTerminalD.Text = "";
            gtxtSealG.Text = "";
            gtxtSealD.Text = "";
            gtxtToolG.Text = "";
            gtxtToolD.Text = "";
            gtxtMarkerD.Text = "";
            gtxtMarkerG.Text = "";
            gtxtProtectionD.Text = "";
            gtxtProtectionG.Text = "";
            gtxtMachine.Text = "";
            gtxtFamily.Text = "";
            gtxtGroup.Text = "";
            gtxtUnico.Focus();
        }

        private void gtxtUnico_KeyDown(object sender, KeyEventArgs e)
        {
            lblUnico.ForeColor = Color.White;
            gtxtUnico.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtUnico_Leave(object sender, EventArgs e)
        {
            lblUnico.ForeColor = Color.White;
            gtxtUnico.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtUnico_KeyUp(object sender, KeyEventArgs e)
        {
           if(gtxtUnico.Text.Trim() != "")
            {
                fetchData(gtxtUnico.Text);
            }
            else
            {
                init();
            }
        }

        private void gtxtLeadCode_KeyDown(object sender, KeyEventArgs e)
        {
            lblLeadCode.ForeColor = Color.White;
            gtxtLeadCode.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtLeadCode_Leave(object sender, EventArgs e)
        {
            lblLeadCode.ForeColor = Color.White;
            gtxtLeadCode.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtLength_KeyDown(object sender, KeyEventArgs e)
        {
            lblLength.ForeColor = Color.White;
            gtxtLength.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtLength_Leave(object sender, EventArgs e)
        {
            lblLength.ForeColor = Color.White;
            gtxtLength.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbCable_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCable.ForeColor = Color.White;
            gtxtCable.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFamily.ForeColor = Color.White;
            gtxtFamily.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroup.ForeColor = Color.White;
            gtxtGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbMc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMc.ForeColor = Color.White;
            gtxtMachine.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[1-9]");
            
            if(gtxtUnico.Text.Trim() != "")
            {
                try
                {
                    if (wireController.IsExist(gtxtUnico.Text, "Wire", "Unico"))
                    {
                        if (gtxtLeadCode.Text.Trim() != "" && gtxtLength.Text.Trim() != "" && regex.IsMatch(gtxtLength.Text) && gtxtCable.Text.Trim() != "" && gtxtFamily.Text.Trim() != "" && gtxtMachine.Text.Trim() != "" && gtxtGroup.Text.Trim() != "" && Login.username != "")
                        {
                            WireModel wire = new WireModel();
                            wire.Family = gtxtFamily.Text;
                            wire.Unico = gtxtUnico.Text;
                            wire.LeadCode = gtxtLeadCode.Text;
                            wire.Length = gtxtLength.Text;
                            wire.Cable = gtxtCable.Text;
                            wire.MarkL = gtxtMarkerG.Text;
                            wire.SealL = gtxtSealG.Text;
                            wire.TerL = gtxtTerminalG.Text;
                            wire.ToolL = gtxtToolG.Text;
                            wire.ProtectionL = gtxtProtectionG.Text;
                            wire.MarkR = gtxtMarkerD.Text;
                            wire.SealR = gtxtSealD.Text;
                            wire.TerR = gtxtTerminalD.Text;
                            wire.ToolR = gtxtToolD.Text;
                            wire.ProtectionR = gtxtProtectionD.Text;
                            wire.GroupRef = gtxtGroup.Text;
                            wire.LeadPrep = gtxtLeadPrep.Text;
                            wire.Adress = gtxtAdress.Text;
                            wire.Mc = gtxtMachine.Text;
                            wire.UserID = Login.username;

                            wireController.UpdateWire(wire);
                            init();
                        }
                        else
                        {

                            if (gtxtLeadCode.Text == "")
                            {

                                lblLeadCode.ForeColor = Color.Red;
                                gtxtLeadCode.Focus();
                                gtxtLeadCode.FocusedState.BorderColor = Color.White;

                            }
                            else if (gtxtLength.Text == "")
                            {

                                lblLength.ForeColor = Color.Red;
                                gtxtLength.Focus();
                                gtxtLength.FocusedState.BorderColor = Color.White;

                            }
                            else if (!regex.IsMatch(gtxtLength.Text))
                            {

                                lblLength.ForeColor = Color.Red;
                                gtxtLength.Focus();
                                gtxtLength.SelectAll();
                                gtxtLength.FocusedState.BorderColor = Color.White;
                                MessageBox.Show("The Length Must Be a Number More Than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else if (gtxtCable.Text == "")
                            {
                                lblCable.ForeColor = Color.Red;
                                gtxtCable.Focus();
                                gtxtCable.FocusedState.BorderColor = Color.White;
                            }
                            else if (gtxtFamily.Text == "")
                            {

                                lblFamily.ForeColor = Color.Red;
                                gtxtFamily.Focus();
                                gtxtFamily.FocusedState.BorderColor = Color.White;

                            }
                            else if (gtxtGroup.Text == "")
                            {
                                lblGroup.ForeColor = Color.Red;
                                gtxtGroup.Focus();
                                gtxtGroup.FocusedState.BorderColor = Color.White;
                            }
                            else if (gtxtMachine.Text == "")
                            {
                                lblMc.ForeColor = Color.Red;
                                gtxtMachine.Focus();
                                gtxtMachine.FocusedState.BorderColor = Color.White;
                            }
                            else if (Login.username == "")
                            {
                                MessageBox.Show("Sorry You Don't Have Prmissions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                Login l = new Login();
                                this.Close();
                                l.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry This Wire Doesn't Exist Try", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblUnico.ForeColor = Color.Red;
                        gtxtUnico.Focus();
                        gtxtUnico.FocusedState.BorderColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry An Error Accured While Processing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblUnico.ForeColor = Color.Red;
                gtxtUnico.Focus();
                gtxtUnico.FocusedState.BorderColor = Color.White;
            }
        }

        private void fetchData(string unico)
        {
            try
            {
                WireModel wire = wireController.fetchSingleRecord(unico);

                gtxtLeadCode.Text = wire.LeadCode;
                gtxtLength.Text = wire.Length;
                gtxtCable.Text = wire.Cable;
                gtxtLeadPrep.Text = wire.LeadPrep;
                gtxtAdress.Text = wire.Adress;
                gtxtTerminalG.Text = wire.TerL;
                gtxtTerminalD.Text = wire.TerR;
                gtxtSealG.Text = wire.SealL;
                gtxtSealD.Text = wire.SealR;
                gtxtMarkerG.Text = wire.MarkL;
                gtxtMarkerD.Text = wire.MarkR;
                gtxtProtectionG.Text = wire.ProtectionL;
                gtxtProtectionD.Text = wire.ProtectionR;
                gtxtToolG.Text = wire.ToolL;
                gtxtToolD.Text = wire.ToolR;
                gtxtFamily.Text = wire.Family;
                gtxtGroup.Text = wire.GroupRef;
                gtxtMachine.Text = wire.Mc;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry It Was An Error\n" + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gtxtUnico.Text.Trim() != "")
                {
                    if (wireController.IsExist(gtxtUnico.Text, "Wire", "Unico"))
                    {
                        DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Wire ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Yes)
                        {
                            wireController.Delete(gtxtUnico.Text, "Wire", "Unico");
                            
                            init();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Wire Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblUnico.ForeColor = Color.Red;
                        gtxtUnico.Focus();
                        gtxtUnico.SelectAll();
                        gtxtUnico.FocusedState.BorderColor = Color.White;
                    }
                }
                else
                {
                    lblUnico.ForeColor = Color.Red;
                    gtxtUnico.Focus();
                    gtxtUnico.FocusedState.BorderColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
