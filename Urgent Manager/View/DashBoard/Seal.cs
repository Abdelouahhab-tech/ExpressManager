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

namespace Urgent_Manager.View.DashBoard
{
    public partial class Seal : Form
    {

        SealController sealController = new SealController();
        public Seal()
        {
            InitializeComponent();
        }

        private void Seal_Load(object sender, EventArgs e)
        {
            gtxtSealRef.Focus();
            LoadData();
        }


        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<SealModel> list = sealController.fetchRecords();
            foreach (SealModel seal in list)
            {
                guna2DataGridView1.Rows.Add(seal.SealID,seal.Color,seal.UserID);
            }
            gtxtSealRef.Text = "";
            gtxtSealRef.Focus();
            gtxtSealColor.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtSealRef.Text.Trim() != "" && gtxtSealColor.Text.Trim() != "")
            {
                if (!sealController.IsExist(gtxtSealRef.Text, "Seal", "Seal"))
                {
                    SealModel seal = new SealModel();
                    seal.SealID = gtxtSealRef.Text;
                    seal.Color = gtxtSealColor.Text;
                    seal.UserID = Login.username;

                    sealController.InsertSeal(seal);
                    LoadData();
                    gtxtSealRef.Text = "";
                    gtxtSealRef.Focus();
                    gtxtSealColor.Text = "";
                }
                else
                {
                    MessageBox.Show("Sorry This Seal Aleardy Exist Try To Add An Other One !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblSealName.ForeColor = System.Drawing.Color.Red;
                    gtxtSealRef.Focus();
                    gtxtSealRef.SelectAll();
                    gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 48, 148, 255);
                }
            }
            else
            {
                if(gtxtSealRef.Text == "")
                {
                    lblSealName.ForeColor = System.Drawing.Color.Red;
                    gtxtSealRef.Focus();
                    gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 48, 148, 255);
                }else if(gtxtSealColor.Text == "")
                {
                    lblSealColor.ForeColor = System.Drawing.Color.Red;
                    gtxtSealColor.Focus();
                    gtxtSealColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 48, 148, 255);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gtxtSealRef.Text.Trim() != "")
            {

                if (sealController.IsExist(gtxtSealRef.Text, "Seal", "Seal"))
                {
                    if (gtxtSealColor.Text.Trim() != "")
                    {
                        SealModel seal = new SealModel();
                        seal.SealID = gtxtSealRef.Text;
                        seal.Color = gtxtSealColor.Text;
                        seal.UserID = Login.username;

                        sealController.UpdateSeal(seal);
                        LoadData();
                        gtxtSealRef.Text = "";
                        gtxtSealRef.Focus();
                        gtxtSealColor.Text = "";
                    }
                    else
                    {
                        lblSealColor.ForeColor = System.Drawing.Color.Red;
                        gtxtSealColor.Focus();
                        gtxtSealColor.FocusedState.BorderColor = System.Drawing.Color.White;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry This Seal Doesn't Exist ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblSealName.ForeColor = System.Drawing.Color.Red;
                    gtxtSealRef.Focus();
                    gtxtSealRef.SelectAll();
                    gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.White;
                }
            }
            else
            {
                lblSealName.ForeColor = System.Drawing.Color.Red;
                gtxtSealRef.Focus();
                gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gtxtSealRef.Text.Trim() != "")
            {
                if (sealController.IsExist(gtxtSealRef.Text, "Seal", "Seal"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Seal ? You Will Lost All The Data That Is Related With This Seal", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        sealController.Delete(gtxtSealRef.Text, "Seal", "Seal");
                        LoadData();
                        gtxtSealRef.Text = "";
                        gtxtSealRef.Focus();
                        gtxtSealColor.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("This Seal Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblSealName.ForeColor = System.Drawing.Color.Red;
                    gtxtSealRef.Focus();
                    gtxtSealRef.SelectAll();
                    gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.White;
                }
            }
            else
            {
                lblSealName.ForeColor = System.Drawing.Color.Red;
                gtxtSealRef.Focus();
                gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.White;
            }
        }


        // Fetch Single Record

        private void getSingleRecord(string sealRef)
        {
            if (sealController.IsExist(sealRef, "Seal", "Seal"))
            {
                SealModel seal = new SealModel();
                seal = sealController.fetchSingleRecord(sealRef);
                gtxtSealRef.Text = seal.SealID;
                gtxtSealColor.Text = seal.Color;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(seal.SealID,seal.Color,seal.UserID);
                lblSealName.ForeColor = System.Drawing.Color.White; ;
                gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string sealRef = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(sealRef != "")
                {
                    getSingleRecord(sealRef);
                }
            }
        }

        private void gtxtSealRef_KeyDown(object sender, KeyEventArgs e)
        {
            lblSealName.ForeColor = System.Drawing.Color.White;
            gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 48, 148, 255);
        }

        private void gtxtSealRef_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtSealRef.Text == "")
            {
                LoadData();
                gtxtSealRef.Text = "";
                gtxtSealRef.Focus();
            }else if(gtxtSealRef.Text.Trim() != "")
            {
                getSingleRecord(gtxtSealRef.Text);
            }
        }

        private void gtxtSealRef_Leave(object sender, EventArgs e)
        {
            lblSealName.ForeColor = System.Drawing.Color.White;
            gtxtSealRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 48, 148, 255);
        }

        private void gtxtSealColor_KeyDown(object sender, KeyEventArgs e)
        {
            lblSealColor.ForeColor = System.Drawing.Color.White;
            gtxtSealColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 48, 148, 255);
        }

        private void gtxtSealColor_Leave(object sender, EventArgs e)
        {
            lblSealColor.ForeColor = System.Drawing.Color.White;
            gtxtSealColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(255, 48, 148, 255);
        }
    }
}
