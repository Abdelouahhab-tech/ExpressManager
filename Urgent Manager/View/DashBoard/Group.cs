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
    public partial class Group : Form
    {

        GroupController groupController = new GroupController();
        DataTable groupData = new DataTable();
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            gtxtGroup.Focus();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtGroup.Text.Trim() != "")
            {
                if (!groupController.IsExist(gtxtGroup.Text, "Groupe", "GroupRef"))
                {
                    GroupModel group = new GroupModel();
                    group.Group = gtxtGroup.Text;
                    group.UserID = Login.username;
                    groupController.InsertGroup(group);
                    gtxtGroup.Text = "";
                    gtxtGroup.Focus();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("This Group Already Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblGroup.ForeColor = Color.Red;
                    gtxtGroup.Focus();
                    gtxtGroup.SelectAll();
                    gtxtGroup.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblGroup.ForeColor = Color.Red;
                gtxtGroup.Focus();
                gtxtGroup.FocusedState.BorderColor = Color.White;
            }
        }

        // Load Data From Group Table

        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<GroupModel> groupes = groupController.fetchRecords();
            foreach (GroupModel group in groupes)
            {
                guna2DataGridView1.Rows.Add(group.Group, group.UserID);
            }
        }

        // Fetch Single Record

        private void getSingleRecord(string groupRef)
        {
            if (groupController.IsExist(groupRef, "Groupe", "GroupRef"))
            {
                GroupModel group = new GroupModel();
                group = groupController.fetchSingleRecord(groupRef);
                gtxtGroup.Text = group.Group;
                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(group.Group, group.UserID);
                lblGroup.ForeColor = Color.White;
                gtxtGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gtxtGroup.Text.Trim() != "")
            {
                if (groupController.IsExist(gtxtGroup.Text, "Groupe", "GroupRef"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Group ? You Will Lost All The Data That Is Related With This Group", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        groupController.Delete(gtxtGroup.Text, "Groupe", "GroupRef");
                        gtxtGroup.Text = "";
                        gtxtGroup.Focus();
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("This Group Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblGroup.ForeColor = Color.Red;
                    gtxtGroup.Focus();
                    gtxtGroup.SelectAll();
                    gtxtGroup.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblGroup.ForeColor = Color.Red;
                gtxtGroup.Focus();
                gtxtGroup.FocusedState.BorderColor = Color.White;
            }
        }

        private void gtxtGroup_KeyDown(object sender, KeyEventArgs e)
        {
            lblGroup.ForeColor = Color.White;
            gtxtGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtGroup.Text == "")
            {
                LoadData();
                gtxtGroup.Text = "";
                gtxtGroup.Focus();
            }else if(gtxtGroup.Text.Trim() != "")
            {
                getSingleRecord(gtxtGroup.Text);
            }
        }

        private void gtxtGroup_Leave(object sender, EventArgs e)
        {
            lblGroup.ForeColor = Color.White;
            gtxtGroup.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string groupRef = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (groupRef != "")
                    getSingleRecord(groupRef);
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
                    groupData.Clear();
                    groupData = db[0];
                    gPFamilyLoad.Visible = true;
                    await Task.Run(new Action(SaveData));
                    gPFamilyLoad.Visible = false;
                    lblFileName.Text = "Drag The Groupe File Here";
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
                if (groupData.Rows.Count > 0)
                {
                    if (groupData.Columns.Count == 1)
                    {
                        for (int i = 0; i < groupData.Rows.Count; i++)
                        {
                            if (!groupController.IsExist(groupData.Rows[i][0].ToString(), "Groupe", "GroupRef"))
                            {
                                DbHelper.connection.Open();
                                string QUERY = "INSERT INTO Groupe VALUES (@group,@userId)";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@group",groupData.Rows[i][0].ToString());
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
    }
}
