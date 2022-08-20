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

namespace Urgent_Manager.View.OptimaisationWindows
{
    public partial class ArchivedUrgents : Form
    {
        UrgentController urgentController = new UrgentController();
        UrgentModel urgent = new UrgentModel();
        public ArchivedUrgents()
        {
            InitializeComponent();
        }
        int i = 0;

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUnicos.Text.Trim() != "")
                {
                    string[] str = txtUnicos.Text.Split('\n');
                    foreach (string l in str)
                    {
                        if (l.Trim() != "")
                            i += urgentController.UpdateUrgent("Finished",Login.username, DateTime.Now.ToShortDateString(), l.Trim()) == true ? 1 : 0;
                    }

                    if (i > 0)
                    {
                        MessageBox.Show("Your Data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnicos.Text = "";
                        txtUnicos.Focus();
                        i = 0;
                    }
                    else
                    {
                        txtUnicos.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error Try Again\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
