using ExcelDataReader;
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
    public partial class Seal : Form
    {

        SealController sealController = new SealController();
        DataTable sealData = new DataTable();
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
                    sealData.Clear();
                    sealData = db[0];
                    gPFamilyLoad.Visible = true;
                    await Task.Run(new Action(SaveData));
                    gPFamilyLoad.Visible = false;
                    lblFileName.Text = "Drag The Seal File Here";
                    stream.Close();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gPUpload_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        // Save Data In DataBase

        public void SaveData()
        {
            try
            {
                int count = 0;
                if (sealData.Rows.Count > 0)
                {
                    if (sealData.Columns.Count == 2)
                    {
                        for (int i = 0; i < sealData.Rows.Count; i++)
                        {
                            if (!sealController.IsExist(sealData.Rows[i][0].ToString(), "Seal", "Seal"))
                            {
                                DbHelper.connection.Open();
                                string QUERY = "INSERT INTO Seal VALUES (@seal,@color,@userId)";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@seal", sealData.Rows[i][0].ToString());
                                cmd.Parameters.AddWithValue("@color", sealData.Rows[i][1].ToString());
                                cmd.Parameters.AddWithValue("@userId", Login.username);
                                count += cmd.ExecuteNonQuery();
                                DbHelper.connection.Close();
                            }
                            else
                            {
                                if (sealController.IsExist(sealData.Rows[i][0].ToString(), "Seal", "Seal"))
                                {
                                    DbHelper.connection.Open();
                                    string QUERY = "UPDATE Seal SET Color=@color,UserID=@userId WHERE Seal=@seal";
                                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                    cmd.Parameters.AddWithValue("@seal", sealData.Rows[i][0].ToString());
                                    cmd.Parameters.AddWithValue("@color", sealData.Rows[i][1].ToString());
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
