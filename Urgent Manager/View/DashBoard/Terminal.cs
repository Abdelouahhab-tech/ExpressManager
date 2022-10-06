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
    public partial class Terminal : Form
    {
        TerminalController terminalController = new TerminalController();
        DataTable terData = new DataTable();
        public Terminal()
        {
            InitializeComponent();
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            gtxtTerminalName.Focus();
            LoadData();
        }

        // Load Records From Database
        private void LoadData()
        {
            guna2DataGridView1.Rows.Clear();
            List<TerminalModel> list = terminalController.fetchRecords();
            foreach (TerminalModel terminal in list)
            {
                guna2DataGridView1.Rows.Add(terminal.TerID,terminal.UserID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gtxtTerminalName.Text.Trim() != "")
            {
                if (!terminalController.IsExist(gtxtTerminalName.Text, "Terminal", "TerminalID"))
                {
                    TerminalModel Terminal = new TerminalModel();
                    Terminal.TerID = gtxtTerminalName.Text;
                    Terminal.UserID = Login.username;

                    terminalController.InsertTerminal(Terminal);
                    LoadData();
                    gtxtTerminalName.Text = "";
                    gtxtTerminalName.Focus();
                }
                else
                {
                    MessageBox.Show("Sorry This Terminal Aleardy Exist Try To Add An Other One !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblTerminal.ForeColor = Color.Red;
                    gtxtTerminalName.Focus();
                    gtxtTerminalName.SelectAll();
                    gtxtTerminalName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                    lblTerminal.ForeColor = Color.Red;
                    gtxtTerminalName.Focus();
                    gtxtTerminalName.FocusedState.BorderColor = Color.White;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gtxtTerminalName.Text.Trim() != "")
            {
                if (terminalController.IsExist(gtxtTerminalName.Text, "Terminal", "TerminalID"))
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Terminal ? You Will Lost All The Data That Is Related With This Terminal", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        terminalController.Delete(gtxtTerminalName.Text, "Terminal", "TerminalID");
                        LoadData();
                        gtxtTerminalName.Text = "";
                        gtxtTerminalName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("This Terminal Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblTerminal.ForeColor = Color.Red;
                    gtxtTerminalName.Focus();
                    gtxtTerminalName.SelectAll();
                    gtxtTerminalName.FocusedState.BorderColor = Color.White;
                }
            }
            else
            {
                lblTerminal.ForeColor = Color.Red;
                gtxtTerminalName.Focus();
                gtxtTerminalName.FocusedState.BorderColor = Color.White;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string Terminal = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (Terminal != "")
                    getSingleRecord(Terminal);
            }
        }


        // Fetch Single Record

        private void getSingleRecord(string Terminal)
        {
            if (terminalController.IsExist(Terminal, "Terminal", "TerminalID"))
            {
                TerminalModel Ter = new TerminalModel();
                Ter = terminalController.fetchSingleRecord(Terminal);

                gtxtTerminalName.Text = Ter.TerID;

                guna2DataGridView1.Rows.Clear();
                guna2DataGridView1.Rows.Add(Ter.TerID,Ter.UserID);
                lblTerminal.ForeColor = Color.White;
                gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
            }
        }

        private void gtxtTerminalName_KeyDown(object sender, KeyEventArgs e)
        {
            lblTerminal.ForeColor = Color.White;
            gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        private void gtxtTerminalName_KeyUp(object sender, KeyEventArgs e)
        {
            if(gtxtTerminalName.Text == "")
            {
                LoadData();
                lblTerminal.ForeColor = Color.White;
                gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);

            }else if(gtxtTerminalName.Text.Trim() != "")
            {
                getSingleRecord(gtxtTerminalName.Text);
            }
        }

        private void gtxtTerminalName_Leave(object sender, EventArgs e)
        {
            lblTerminal.ForeColor = Color.White;
            gtxtTerminalName.FocusedState.BorderColor = Color.FromArgb(255, 94, 148, 255);
        }

        // Save Data In DataBase

        public void SaveData()
        {
            try
            {
                int count = 0;
                if (terData.Rows.Count > 0)
                {
                    if (terData.Columns.Count == 1)
                    {
                        for (int i = 0; i < terData.Rows.Count; i++)
                        {
                            if (!terminalController.IsExist(terData.Rows[i][0].ToString(), "Terminal", "TerminalID"))
                            {
                                DbHelper.connection.Open();
                                string QUERY = "INSERT INTO Terminal VALUES (@ter,@userId)";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@ter", terData.Rows[i][0].ToString());
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
                    terData.Clear();
                    terData = db[0];
                    gPFamilyLoad.Visible = true;
                    await Task.Run(new Action(SaveData));
                    gPFamilyLoad.Visible = false;
                    lblFileName.Text = "Drag The Terminal File Here";
                    stream.Close();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Accured While Processing Your Request!\n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
