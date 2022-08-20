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
    public partial class Marker : Form
    {
        MarkerController markerController = new MarkerController();
        public Marker()
        {
            InitializeComponent();
        }

        private void Marker_Load(object sender, EventArgs e)
        {
            gtxtMarkerColor.Focus();
            LoadData();
        }


        // Load Data From Marker Table

        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<MarkerModel> markers = markerController.fetchRecords();
            foreach (MarkerModel marker in markers)
            {
                guna2DataGridView1.Rows.Add(marker.MarkerColor, marker.UserID);
            }
        }

        // Fetch Single Record

        private void getSingleRecord(string color)
        {
            if (markerController.IsExist(color, "Marker", "Color"))
            {
                MarkerModel marker = new MarkerModel();
                marker = markerController.fetchSingleRecord(color);
                gtxtMarkerColor.Text = marker.MarkerColor;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(marker.MarkerColor, marker.UserID);
                lblMarkerColor.ForeColor = Color.White;
                gtxtMarkerColor.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtMarkerColor.Text.Trim() != "")
            {
                if (!markerController.IsExist(gtxtMarkerColor.Text, "Marker", "Color"))
                {
                    MarkerModel marker = new MarkerModel();
                    marker.MarkerColor = gtxtMarkerColor.Text;
                    marker.UserID = Login.username;
                    markerController.InsertMarker(marker);
                    LoadData();
                    gtxtMarkerColor.Text = "";
                    gtxtMarkerColor.Focus();
                }
                else
                {
                    MessageBox.Show("This Marker Already Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMarkerColor.ForeColor = Color.Red;
                    gtxtMarkerColor.Focus();
                    gtxtMarkerColor.SelectAll();
                    gtxtMarkerColor.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblMarkerColor.ForeColor = Color.Red;
                gtxtMarkerColor.Focus();
                gtxtMarkerColor.FocusedState.BorderColor = Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gtxtMarkerColor.Text.Trim() != "")
            {
                if (markerController.IsExist(gtxtMarkerColor.Text, "Marker", "Color"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Marker ? You Will Lost All The Data That Is Related With This Marker", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        markerController.Delete(gtxtMarkerColor.Text, "Marker", "Color");
                        LoadData();
                        gtxtMarkerColor.Text = "";
                        gtxtMarkerColor.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("This Marker Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMarkerColor.ForeColor = Color.Red;
                    gtxtMarkerColor.Focus();
                    gtxtMarkerColor.SelectAll();
                    gtxtMarkerColor.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblMarkerColor.ForeColor = Color.Red;
                gtxtMarkerColor.Focus();
                gtxtMarkerColor.FocusedState.BorderColor = Color.White;
            }
        }

        private void gtxtMarkerColor_KeyDown(object sender, KeyEventArgs e)
        {
            lblMarkerColor.ForeColor = Color.White;
            gtxtMarkerColor.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtMarkerColor_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtMarkerColor.Text == "")
            {
                LoadData();
                gtxtMarkerColor.Text = "";
                gtxtMarkerColor.Focus();
            }else if(gtxtMarkerColor.Text.Trim() != "")
            {
                getSingleRecord(gtxtMarkerColor.Text);
            }
        }

        private void gtxtMarkerColor_Leave(object sender, EventArgs e)
        {
            lblMarkerColor.ForeColor = Color.White;
            gtxtMarkerColor.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string color = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (color != "")
                    getSingleRecord(color);
            }
        }
    }
}
