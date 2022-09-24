using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;

namespace Urgent_Manager.View.DashBoard
{
    public partial class UpdateMCORGroupe : Form
    {
        WireController wireController = new WireController();
        public UpdateMCORGroupe()
        {
            InitializeComponent();
        }

        private void UpdateMCORGroupe_Load(object sender, EventArgs e)
        {
            AutoComplete.AutoComplete auto = new AutoComplete.AutoComplete();
            auto.autoComplete(gUpdate, DbHelper.connection, "SELECT Machine FROM Machine");
        }

        private void rdMachine_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMachine.Checked)
            {
                gUpdate.Text = "";
                gUpdate.PlaceholderText = "Machine";
                AutoComplete.AutoComplete auto = new AutoComplete.AutoComplete();
                auto.autoComplete(gUpdate, DbHelper.connection, "SELECT Machine FROM Machine");
            }
        }

        private void rdGroupe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGroupe.Checked)
            {
                gUpdate.Text = "";
                gUpdate.PlaceholderText = "Groupe";
                AutoComplete.AutoComplete auto = new AutoComplete.AutoComplete();
                auto.autoComplete(gUpdate, DbHelper.connection, "SELECT GroupRef FROM Groupe");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                if (txtUnicos.Text.Trim() != "" && gUpdate.Text.Trim() != "")
                {
                    string[] str = txtUnicos.Text.Split('\n');
                    if (rdMachine.Checked && wireController.IsExist(gUpdate.Text,"Machine","Machine"))
                    {
                        foreach (string l in str)
                        {
                            if (l.Trim() != "")
                            {
                                DbHelper.connection.Open();
                                string QUERY = "UPDATE Wire SET MC =@mc,UserID=@id WHERE Unico=@unico";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@mc", gUpdate.Text.ToUpper());
                                cmd.Parameters.AddWithValue("@unico", l.Trim());
                                cmd.Parameters.AddWithValue("@id", Login.username);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                    i += 1;
                                DbHelper.connection.Close();
                            }
                        }

                    }
                    else if (rdGroupe.Checked && wireController.IsExist(gUpdate.Text, "Groupe", "GroupRef"))
                    {
                        foreach (string l in str)
                        {
                            if (l.Trim() != "")
                            {
                                DbHelper.connection.Open();
                                string QUERY = "UPDATE Wire SET Groupe =@group,UserID=@id WHERE Unico=@unico";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@group", gUpdate.Text.ToUpper());
                                cmd.Parameters.AddWithValue("@unico", l.Trim());
                                cmd.Parameters.AddWithValue("@id", Login.username);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                    i += 1;
                                DbHelper.connection.Close();
                            }
                        }
                    }
                    else
                    {
                        if(!wireController.IsExist(gUpdate.Text, "Groupe", "GroupRef"))
                        {
                            MessageBox.Show("This Groupe Doesn't Exist Make Sure That The Groupe Is Exist!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else if (!wireController.IsExist(gUpdate.Text, "Machine", "Machine"))
                        {
                            MessageBox.Show("This Machine Doesn't Exist Make Sure That The Machine Is Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (i > 0)
                    {
                        MessageBox.Show($"{i} Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnicos.Text = "";
                        gUpdate.Text = "";
                        txtUnicos.Focus();
                        i = 0;
                    }
                    else
                    {
                        MessageBox.Show($"SomeThing Is Wrong No Data Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnicos.Text = "";
                        gUpdate.Text = "";
                        txtUnicos.Focus();
                        i = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill The Required Values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnicos.Focus();
                }
            }
            catch (Exception)
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                string[] str = txtUnicos.Text.Split('\n');
                if (chStatus.Checked)
                {
                    if(txtUnicos.Text.Trim() != "")
                    {
                        foreach (string l in str)
                        {
                            if (l.Trim() != "")
                            {
                                DbHelper.connection.Open();
                                string QUERY = "UPDATE Wire SET WireStatus=@wireStatus,UserID=@id WHERE Unico=@unico";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@wireStatus",1);
                                cmd.Parameters.AddWithValue("@unico", l.Trim());
                                cmd.Parameters.AddWithValue("@id", Login.username);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                    i += 1;
                                DbHelper.connection.Close();
                            }
                        }

                        if(i > 0)
                        {
                            MessageBox.Show($"{i} Records Were Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i = 0;
                            txtUnicos.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No Data Were Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Unicos Field Is Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (txtUnicos.Text.Trim() != "")
                    {
                        foreach (string l in str)
                        {
                            if (l.Trim() != "")
                            {
                                DbHelper.connection.Open();
                                string QUERY = "UPDATE Wire SET WireStatus=@wireStatus,UserID=@id WHERE Unico=@unico";
                                SqlCommand cmd = new SqlCommand(QUERY, DbHelper.connection);
                                cmd.Parameters.AddWithValue("@wireStatus", 0);
                                cmd.Parameters.AddWithValue("@unico", l.Trim());
                                cmd.Parameters.AddWithValue("@id", Login.username);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                    i += 1;
                                DbHelper.connection.Close();
                            }
                        }

                        if (i > 0)
                        {
                            MessageBox.Show($"{i} Records Were Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i = 0;
                            txtUnicos.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No Data Were Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Unicos Field Is Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
