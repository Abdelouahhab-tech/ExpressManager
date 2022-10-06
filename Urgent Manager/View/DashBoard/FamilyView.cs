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
    public partial class FamilyView : Form
    {
        FamilyController familyController = new FamilyController();
        DataTable familyData = new DataTable();
        public FamilyView()
        {
            InitializeComponent();
        }

        private void Family_Load(object sender, EventArgs e)
        {
            gtxtFamilyName.Focus();
            LoadData();
        }

        // Load Data From Family Table

        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<FamilyModel> families = familyController.fetchRecords();
            foreach(FamilyModel family in families)
            {
                guna2DataGridView1.Rows.Add(family.FamilyName, family.UserID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(gtxtFamilyName.Text.Trim() != "")
            {
                if (!familyController.IsExist(gtxtFamilyName.Text, "Family", "FAM"))
                {
                    FamilyModel family = new FamilyModel();
                    family.FamilyName = gtxtFamilyName.Text;
                    family.UserID = Login.username;
                    familyController.InsertFamily(gtxtFamilyName.Text,Login.username);
                    gtxtFamilyName.Text = "";
                    gtxtFamilyName.Focus();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("This Family Already Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFamilyName.ForeColor = Color.Red;
                    gtxtFamilyName.Focus();
                    gtxtFamilyName.SelectAll();
                    gtxtFamilyName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblFamilyName.ForeColor = Color.Red;
                gtxtFamilyName.Focus();
                gtxtFamilyName.FocusedState.BorderColor = Color.White;
            }
        }

        private void gtxtFamilyName_KeyDown(object sender, KeyEventArgs e)
        {
            lblFamilyName.ForeColor = Color.White;
            gtxtFamilyName.FocusedState.BorderColor = Color.FromArgb(255, 94,148,255);
        }

        private void gtxtFamilyName_KeyUp(object sender, KeyEventArgs e)
        {
            if (gtxtFamilyName.Text == "")
                LoadData();
            else if (gtxtFamilyName.Text.Trim() != "")
                getSingleRecord(gtxtFamilyName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gtxtFamilyName.Text.Trim() != "")
            {
                if (familyController.IsExist(gtxtFamilyName.Text, "Family", "FAM"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Family ? You Will Lost All The Data That Is Related With This Family", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        familyController.Delete(gtxtFamilyName.Text,"Family","FAM");
                        LoadData();
                        gtxtFamilyName.Text = "";
                        gtxtFamilyName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("This Family Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFamilyName.ForeColor = Color.Red;
                    gtxtFamilyName.Focus();
                    gtxtFamilyName.SelectAll();
                    gtxtFamilyName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblFamilyName.ForeColor = Color.Red;
                gtxtFamilyName.Focus();
                gtxtFamilyName.FocusedState.BorderColor = Color.White;
            }
        }

        // Fetch Single Record

        private void getSingleRecord(string familyName)
        {
            if (familyController.IsExist(familyName, "Family", "FAM"))
            {
                FamilyModel family = new FamilyModel();
                family = familyController.fetchSingleFamily(familyName);
                gtxtFamilyName.Text = family.FamilyName;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(family.FamilyName, family.UserID);
                lblFamilyName.ForeColor = Color.White;
                gtxtFamilyName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string familyName = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (familyName != "")
                    getSingleRecord(familyName);
            }
        }

        private void gtxtFamilyName_Leave(object sender, EventArgs e)
        {
            lblFamilyName.ForeColor = Color.White;
            gtxtFamilyName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if(gtxtFamilyName.Text.Trim() != "" && familyController.IsExist(gtxtFamilyName.Text.Trim(), "Family", "FAM"))
                {
                    DbHelper.connection.Open();
                    string QUERY = "UPDATE Wire SET WireStatus=@status WHERE Family=@family";
                    SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                    cmd.Parameters.AddWithValue("@status", chStatus.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@family", gtxtFamilyName.Text);
                    cmd.ExecuteNonQuery();
                    DbHelper.connection.Close();
                    MessageBox.Show("Your Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gtxtFamilyName.Text = "";
                    gtxtFamilyName.Focus();
                }
                else
                {
                    if(gtxtFamilyName.Text == "")
                    {

                        lblFamilyName.ForeColor = Color.Red;
                        gtxtFamilyName.Focus();
                        gtxtFamilyName.FocusedState.BorderColor = Color.White;

                    }
                    else if(familyController.IsExist(gtxtFamilyName.Text.Trim(), "Family", "FAM"))
                    {
                        MessageBox.Show("This Family Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblFamilyName.ForeColor = Color.Red;
                        gtxtFamilyName.Focus();
                        gtxtFamilyName.SelectAll();
                        gtxtFamilyName.FocusedState.BorderColor = Color.White;
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        // Save Data In DataBase

        public void SaveData()
        {
            try
            {
                int count = 0;
                if (familyData.Rows.Count > 0)
                {
                    if (familyData.Columns.Count == 1)
                    {
                        for (int i = 0; i < familyData.Rows.Count; i++)
                        {
                            if (!familyController.IsExist(familyData.Rows[i][0].ToString(), "Family", "FAM"))
                            {
                                DbHelper.connection.Open();
                                string QUERY = "INSERT INTO Family VALUES (@fam,@userId)";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@fam", familyData.Rows[i][0].ToString());
                                cmd.Parameters.AddWithValue("@userId", Login.username);
                                count += cmd.ExecuteNonQuery();
                                DbHelper.connection.Close();
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
                    familyData.Clear();
                    familyData = db[0];
                    gPFamilyLoad.Visible = true;
                    await Task.Run(new Action(SaveData));
                    gPFamilyLoad.Visible = false;
                    lblFileName.Text = "Drag The Family File Here";
                    stream.Close();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
