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
                wireController.FillCombobox("Cable", "Cable", cmbCable);
                wireController.FillCombobox("Terminal", "TerminalID", cmbTerG);
                wireController.FillCombobox("Marker", "Color", cmbMarkerG);
                wireController.FillCombobox("Marker", "Color", cmbMarkerD);
                wireController.FillCombobox("Terminal", "TerminalID", cmbTerD);
                wireController.FillCombobox("Seal", "Seal", cmbSealG);
                wireController.FillCombobox("Seal", "Seal", cmbSealD);
                wireController.FillCombobox("Protection", "Type", cmbProtectionG);
                wireController.FillCombobox("Protection", "Type", cmbProtectionD);
                wireController.FillCombobox("Tool", "ToolID", cmbToolG);
                wireController.FillCombobox("Tool", "ToolID", cmbToolD);
                wireController.FillCombobox("Family", "FAM", cmbFamily);
                wireController.FillCombobox("Groupe", "GroupRef", cmbGroup);
                wireController.FillCombobox("Machine", "Machine", cmbMc);
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
                if (gtxtUnico.Text.Trim() != "" && gtxtLeadCode.Text.Trim() != "" && gtxtLength.Text.Trim() != "" && regex.IsMatch(gtxtLength.Text) && cmbCable.Text.Trim() != "" && cmbFamily.Text.Trim() != "" && cmbMc.Text.Trim() != "" && cmbGroup.Text.Trim() != "" && Login.username != "" )
                {
                    if (!wireController.IsExist(gtxtUnico.Text, "Wire", "Unico"))
                    {
                        WireModel wire = new WireModel();
                        wire.Family = cmbFamily.Text;
                        wire.Unico = gtxtUnico.Text;
                        wire.LeadCode = gtxtLeadCode.Text;
                        wire.Length = gtxtLength.Text;
                        wire.Cable = cmbCable.Text;
                        wire.MarkL = cmbMarkerG.Text;
                        wire.SealL = cmbSealG.Text;
                        wire.TerL = cmbTerG.Text;
                        wire.ToolL = cmbToolG.Text;
                        wire.ProtectionL = cmbProtectionG.Text;
                        wire.MarkR = cmbMarkerD.Text;
                        wire.SealR = cmbSealD.Text;
                        wire.TerR = cmbTerD.Text;
                        wire.ToolR = cmbToolD.Text;
                        wire.ProtectionR = cmbProtectionD.Text;
                        wire.GroupRef = cmbGroup.Text;
                        wire.LeadPrep = gtxtLeadPrep.Text;
                        wire.Adress = gtxtAdress.Text;
                        wire.Mc = cmbMc.Text;
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
                    else if (cmbCable.Text == "")
                    {
                        lblCable.ForeColor = Color.Red;
                        cmbCable.Focus();
                        cmbCable.FocusedState.BorderColor = Color.White;
                    }
                    else if (cmbFamily.Text == "")
                    {

                        lblFamily.ForeColor = Color.Red;
                        cmbFamily.Focus();
                        cmbFamily.FocusedState.BorderColor = Color.White;

                    }
                    else if (cmbGroup.Text == "")
                    {
                        lblGroup.ForeColor = Color.Red;
                        cmbGroup.Focus();
                        cmbGroup.FocusedState.BorderColor = Color.White;
                    }
                    else if (cmbMc.Text == "")
                    {
                        lblMc.ForeColor = Color.Red;
                        cmbMc.Focus();
                        cmbMc.FocusedState.BorderColor = Color.White;
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
            cmbCable.SelectedIndex = -1;
            cmbTerG.SelectedIndex = -1;
            cmbTerD.SelectedIndex = -1;
            cmbSealG.SelectedIndex = -1;
            cmbSealD.SelectedIndex = -1;
            cmbToolG.SelectedIndex = -1;
            cmbToolD.SelectedIndex = -1;
            cmbMarkerG.SelectedIndex = -1;
            cmbMarkerD.SelectedIndex = -1;
            cmbProtectionG.SelectedIndex = -1;
            cmbProtectionD.SelectedIndex = -1;
            cmbMc.SelectedIndex = -1;
            cmbFamily.SelectedIndex = -1;
            cmbGroup.SelectedIndex = -1;
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
            cmbCable.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFamily.ForeColor = Color.White;
            cmbFamily.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroup.ForeColor = Color.White;
            cmbGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void cmbMc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMc.ForeColor = Color.White;
            cmbMc.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
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
                        if (gtxtLeadCode.Text.Trim() != "" && gtxtLength.Text.Trim() != "" && regex.IsMatch(gtxtLength.Text) && cmbCable.Text.Trim() != "" && cmbFamily.Text.Trim() != "" && cmbMc.Text.Trim() != "" && cmbGroup.Text.Trim() != "" && Login.username != "")
                        {
                            WireModel wire = new WireModel();
                            wire.Family = cmbFamily.Text;
                            wire.Unico = gtxtUnico.Text;
                            wire.LeadCode = gtxtLeadCode.Text;
                            wire.Length = gtxtLength.Text;
                            wire.Cable = cmbCable.Text;
                            wire.MarkL = cmbMarkerG.Text;
                            wire.SealL = cmbSealG.Text;
                            wire.TerL = cmbTerG.Text;
                            wire.ToolL = cmbToolG.Text;
                            wire.ProtectionL = cmbProtectionG.Text;
                            wire.MarkR = cmbMarkerD.Text;
                            wire.SealR = cmbSealD.Text;
                            wire.TerR = cmbTerD.Text;
                            wire.ToolR = cmbToolD.Text;
                            wire.ProtectionR = cmbProtectionD.Text;
                            wire.GroupRef = cmbGroup.Text;
                            wire.LeadPrep = gtxtLeadPrep.Text;
                            wire.Adress = gtxtAdress.Text;
                            wire.Mc = cmbMc.Text;
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
                            else if (cmbCable.Text == "")
                            {
                                lblCable.ForeColor = Color.Red;
                                cmbCable.Focus();
                                cmbCable.FocusedState.BorderColor = Color.White;
                            }
                            else if (cmbFamily.Text == "")
                            {

                                lblFamily.ForeColor = Color.Red;
                                cmbFamily.Focus();
                                cmbFamily.FocusedState.BorderColor = Color.White;

                            }
                            else if (cmbGroup.Text == "")
                            {
                                lblGroup.ForeColor = Color.Red;
                                cmbGroup.Focus();
                                cmbGroup.FocusedState.BorderColor = Color.White;
                            }
                            else if (cmbMc.Text == "")
                            {
                                lblMc.ForeColor = Color.Red;
                                cmbMc.Focus();
                                cmbMc.FocusedState.BorderColor = Color.White;
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
                cmbCable.Text = wire.Cable;
                gtxtLeadPrep.Text = wire.LeadPrep;
                gtxtAdress.Text = wire.Adress;
                cmbTerG.Text = wire.TerL;
                cmbTerD.Text = wire.TerR;
                cmbSealG.Text = wire.SealL;
                cmbSealD.Text = wire.SealR;
                cmbMarkerG.Text = wire.MarkL;
                cmbMarkerD.Text = wire.MarkR;
                cmbProtectionG.Text = wire.ProtectionL;
                cmbProtectionD.Text = wire.ProtectionR;
                cmbToolG.Text = wire.ToolL;
                cmbToolD.Text = wire.ToolR;
                cmbFamily.Text = wire.Family;
                cmbGroup.Text = wire.GroupRef;
                cmbMc.Text = wire.Mc;
                
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
