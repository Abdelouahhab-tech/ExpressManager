using ExcelDataReader;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;
using Urgent_Manager.Model;

namespace Urgent_Manager.View.DashBoard
{
    public partial class Bobine : Form
    {
        CableController cableController = new CableController();
        DataTable cableData = new DataTable();
        public Bobine()
        {
            InitializeComponent();
        }

        private void Bobine_Load(object sender, EventArgs e)
        {
            try
            {
                gtxtCableName.Focus();
                LoadData();
            }
            catch (Exception)
            {

            }
        }

        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<CableModel> list = cableController.fetchRecords();
            foreach (CableModel cable in list)
            {
                guna2DataGridView1.Rows.Add(cable.Cable,cable.Section,cable.Pvc,cable.Color,cable.Guide,cable.UserID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gtxtCableName.Text.Trim() != "" && gtxtPvc.Text.Trim() != "" && gtxtColor.Text.Trim() != "" && gtxtSection.Text.Trim() != "")
                {
                    if (!cableController.IsExist(gtxtCableName.Text, "Cable", "Cable"))
                    {
                        CableModel cable = new CableModel();
                        cable.Cable = gtxtCableName.Text;
                        cable.Pvc = gtxtPvc.Text;
                        cable.Color = gtxtColor.Text;
                        cable.Section = gtxtSection.Text;
                        cable.Guide = gtxtGReference.Text != "" ? gtxtGReference.Text : "";
                        cable.UserID = Login.username;

                        cableController.InsertCable(cable);
                        LoadData();
                        init();
                    }
                    else
                    {
                        MessageBox.Show("Sorry This Cable Aleardy Exist Try To Add An Other One !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblCable.ForeColor = Color.Red;
                        gtxtCableName.Focus();
                        gtxtCableName.SelectAll();
                    }
                }
                else
                {
                    if (gtxtCableName.Text.Trim() == "")
                    {
                        lblCable.ForeColor = Color.Red;
                        gtxtCableName.Focus();
                        gtxtCableName.SelectAll();
                        gtxtCableName.FocusedState.BorderColor = Color.White;

                    }
                    else if (gtxtPvc.Text.Trim() == "")
                    {
                        lblPvc.ForeColor = Color.Red;
                        gtxtPvc.Focus();
                        gtxtPvc.FocusedState.BorderColor = Color.White;
                    }
                    else if (gtxtColor.Text.Trim() == "")
                    {
                        lblColor.ForeColor = Color.Red;
                        gtxtColor.Focus();
                        gtxtColor.FocusedState.BorderColor = Color.White;
                    }
                    else if (gtxtSection.Text.Trim() == "")
                    {
                        lblSection.ForeColor = Color.Red;
                        gtxtSection.Focus();
                        gtxtSection.FocusedState.BorderColor = Color.White;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        // initialize Components

        private void init()
        {
            gtxtCableName.Text = "";
            gtxtPvc.Text = "";
            gtxtColor.Text = "";
            gtxtSection.Text = "";
            gtxtGReference.Text = "";
            gtxtCableName.Focus();
        }

        private void gtxtCableName_KeyDown(object sender, KeyEventArgs e)
        {
            lblCable.ForeColor = Color.White;
            gtxtCableName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtPvc_KeyDown(object sender, KeyEventArgs e)
        {
            lblPvc.ForeColor = Color.White;
            gtxtPvc.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtColor_KeyDown(object sender, KeyEventArgs e)
        {
            lblColor.ForeColor = Color.White;
            gtxtColor.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtSection_KeyDown(object sender, KeyEventArgs e)
        {
            lblSection.ForeColor = Color.White;
            gtxtSection.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (gtxtCableName.Text.Trim() != "")
                {

                    if (cableController.IsExist(gtxtCableName.Text, "Cable", "Cable"))
                    {

                        if (gtxtPvc.Text.Trim() != "" && gtxtColor.Text.Trim() != "" && gtxtSection.Text.Trim() != "")
                        {
                            CableModel cable = new CableModel();
                            cable.Cable = gtxtCableName.Text;
                            cable.Pvc = gtxtPvc.Text;
                            cable.Color = gtxtColor.Text;
                            cable.Guide = gtxtGReference.Text != "" ? gtxtGReference.Text : "";
                            cable.Section = gtxtSection.Text;
                            cable.UserID = Login.username;

                            cableController.UpdateCable(cable);
                            LoadData();
                            init();
                        }
                        else
                        {
                            if (gtxtPvc.Text.Trim() == "")
                            {
                                lblPvc.ForeColor = Color.Red;
                                gtxtPvc.Focus();
                                gtxtPvc.FocusedState.BorderColor = Color.White;
                            }
                            else if (gtxtColor.Text.Trim() == "")
                            {
                                lblColor.ForeColor = Color.Red;
                                gtxtColor.Focus();
                                gtxtColor.FocusedState.BorderColor = Color.White;
                            }
                            else if (gtxtSection.Text.Trim() == "")
                            {
                                lblSection.ForeColor = Color.Red;
                                gtxtSection.Focus();
                                gtxtSection.FocusedState.BorderColor = Color.White;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry This Cable Doesn't Exist ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblCable.ForeColor = Color.Red;
                        gtxtCableName.Focus();
                        gtxtCableName.SelectAll();
                        gtxtCableName.FocusedState.BorderColor = Color.White;
                    }
                }
                else
                {
                    lblCable.ForeColor = Color.Red;
                    gtxtCableName.Focus();
                    gtxtCableName.FocusedState.BorderColor = Color.White;
                }
            }
            catch (Exception)
            {

            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string cableName = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (cableName != "")
                    {
                        getSingleRecord(cableName);
                        gtxtCableName.Text = cableName;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        // Fetch Single Record

        private void getSingleRecord(string cableName)
        {
            if (cableController.IsExist(cableName, "Cable", "Cable"))
            {
                CableModel cable = new CableModel();
                cable = cableController.fetchSingleRecord(cableName);
                gtxtPvc.Text = cable.Pvc;
                gtxtColor.Text = cable.Color;
                gtxtSection.Text = cable.Section;
                gtxtGReference.Text = cable.Guide;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(cable.Cable,cable.Section,cable.Pvc,cable.Color,cable.Guide,cable.UserID);
                lblCable.ForeColor = Color.White;
                gtxtCableName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void gtxtCableName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (gtxtCableName.Text.Trim() != "")
                {
                    getSingleRecord(gtxtCableName.Text);
                }
                else
                {
                    LoadData();
                    init();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gtxtCableName.Text.Trim() != "")
                {
                    if (cableController.IsExist(gtxtCableName.Text, "Cable", "Cable"))
                    {
                        DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Cable ? You Will Lost All The Data That Is Related With This Cable", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Yes)
                        {
                            cableController.Delete(gtxtCableName.Text, "Cable", "Cable");
                            LoadData();
                            init();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Cable Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblCable.ForeColor = Color.Red;
                        gtxtCableName.Focus();
                        gtxtCableName.SelectAll();
                        gtxtCableName.FocusedState.BorderColor = Color.White;
                    }
                }
                else
                {
                    lblCable.ForeColor = Color.Red;
                    gtxtCableName.Focus();
                    gtxtCableName.FocusedState.BorderColor = Color.White;
                }
            }
            catch (Exception)
            {

            }
        }

        private void gtxtCableName_Leave(object sender, EventArgs e)
        {
            lblCable.ForeColor = Color.White;
            gtxtCableName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtPvc_Leave(object sender, EventArgs e)
        {
            lblPvc.ForeColor = Color.White;
            gtxtPvc.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtColor_Leave(object sender, EventArgs e)
        {
            lblColor.ForeColor = Color.White;
            gtxtColor.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtSection_Leave(object sender, EventArgs e)
        {
            lblSection.ForeColor = Color.White;
            gtxtSection.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gPUpload_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private async void gPUpload_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string extension = Path.GetExtension(files[0]);
                if (extension.ToLower() == ".xlsx" || extension.ToLower() == ".xls")
                {
                    lblFileName.Text = files[0];
                    FileStream stream = File.Open(files[0], FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    DataTableCollection db = result.Tables;
                    cableData.Clear();
                    cableData = db[0];
                    gPFamilyLoad.Visible = true;
                    await Task.Run(new Action(SaveData));
                    gPFamilyLoad.Visible = false;
                    lblFileName.Text = "Drag The Cable File Here";
                    stream.Close();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Save Data In DataBase

        public void SaveData()
        {
            try
            {
                int count = 0;
                if (cableData.Rows.Count > 0)
                {
                    if (cableData.Columns.Count == 5)
                    {
                        for (int i = 0; i < cableData.Rows.Count; i++)
                        {
                            if (!cableController.IsExist(cableData.Rows[i][0].ToString(), "Cable", "Cable"))
                            {
                                DbHelper.connection.Open();
                                string QUERY = "INSERT INTO Cable VALUES (@cable,@section,@pvc,@color,@guide,@userId)";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@cable",cableData.Rows[i][0].ToString());
                                cmd.Parameters.AddWithValue("@section", cableData.Rows[i][1].ToString());
                                cmd.Parameters.AddWithValue("@color", cableData.Rows[i][2].ToString());
                                cmd.Parameters.AddWithValue("@pvc", cableData.Rows[i][3].ToString());
                                cmd.Parameters.AddWithValue("@guide", cableData.Rows[i][4].ToString());
                                cmd.Parameters.AddWithValue("@userId", Login.username);
                                count += cmd.ExecuteNonQuery();
                                DbHelper.connection.Close();
                            }
                            else
                            {
                                if (cableController.IsExist(cableData.Rows[i][0].ToString(), "Cable", "Cable"))
                                {
                                    DbHelper.connection.Open();
                                    string QUERY = "UPDATE Cable SET Section=@section,Pvc=@pvc,Color=@color,Guide=@guide,UserID=@userid WHERE Cable=@cable";
                                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                    cmd.Parameters.AddWithValue("@cable", cableData.Rows[i][0].ToString());
                                    cmd.Parameters.AddWithValue("@section", cableData.Rows[i][1].ToString());
                                    cmd.Parameters.AddWithValue("@color", cableData.Rows[i][2].ToString());
                                    cmd.Parameters.AddWithValue("@pvc", cableData.Rows[i][3].ToString());
                                    cmd.Parameters.AddWithValue("@guide", cableData.Rows[i][4].ToString());
                                    cmd.Parameters.AddWithValue("@userId", Login.username);
                                    count += cmd.ExecuteNonQuery();
                                    DbHelper.connection.Close();
                                }
                            }
                        }

                        if (count > 0)
                        {
                            MessageBox.Show($"Your Request Is Done {count} Records Performed Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sorry It Seems Like All The Records Already Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry Your Data Didn't Match The Data Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry Your Data Is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Pricessing Your Request\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DbHelper.connection.Close();
            }
        }
    }
}
