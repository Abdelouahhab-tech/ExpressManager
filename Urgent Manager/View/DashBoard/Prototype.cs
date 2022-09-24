using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;
using Urgent_Manager.Model;
using ZXing;

namespace Urgent_Manager.View.DashBoard
{
    public partial class Prototype : Form
    {
        WireController wireController = new WireController();
        public Prototype()
        {
            InitializeComponent();
        }

        private void Prototype_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
            timer1.Start();
            txtUnico.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss ");
        }

        private void txtUnico_KeyDown(object sender, KeyEventArgs e)
        {
            txtUnico.PlaceholderForeColor = Color.FromArgb(255, 221, 221, 221);

            if (txtUnico.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                txtMachine.Focus();
            }
        }

        private void txtMachine_KeyDown(object sender, KeyEventArgs e)
        {
            txtMachine.PlaceholderForeColor = Color.FromArgb(255, 221, 221, 221);

            if (txtMachine.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                txtMatricule.Focus();
            }
        }

        private void txtMatricule_KeyDown(object sender, KeyEventArgs e)
        {
            txtMatricule.Focus();
            txtMatricule.PlaceholderForeColor = Color.FromArgb(255, 221, 221, 221);

            if (txtMatricule.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"^\d+$");
                if (txtUnico.Text.Trim() != "" && txtMachine.Text.Trim() != "" && txtMatricule.Text.Trim() != "" && txtQty.Text.Trim() != "" && regex.IsMatch(txtQty.Text))
                {
                        printDocument1.Print();
                        txtUnico.Text = "";
                        txtMachine.Text = "";
                        txtMatricule.Text = "";
                        txtQty.Text = "";
                        txtUnico.Focus();
                }
                else
                {
                    if(txtUnico.Text == "")
                    {
                        txtUnico.Focus();
                        txtUnico.PlaceholderForeColor = Color.FromArgb(255, 240, 0, 0);

                    }else if(txtMachine.Text == "")
                    {
                        txtMachine.Focus();
                        txtMachine.PlaceholderForeColor = Color.FromArgb(255, 240, 0, 0);
                    }
                    else if(txtMatricule.Text == "")
                    {
                        txtMatricule.Focus();
                        txtMatricule.PlaceholderForeColor = Color.FromArgb(255, 240, 0, 0);
                    }else if(txtQty.Text == "")
                    {
                        txtQty.Focus();
                        txtQty.PlaceholderForeColor = Color.FromArgb(255, 240, 0, 0);
                    }else if (!regex.IsMatch(txtQty.Text))
                    {
                        txtQty.Focus();
                        txtQty.PlaceholderForeColor = Color.FromArgb(255, 240, 0, 0);
                        txtQty.SelectAll();
                        MessageBox.Show("Type a Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It Was An Error While Processing Your Request Try Again\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                Font f = new Font("Arial", 9, FontStyle.Bold);
                e.Graphics.DrawString("Prototype", f,Brushes.Black,new Point(50,10));
                e.Graphics.DrawLine(Pens.Black, new Point(5,f.Height + 20), new Point(e.PageBounds.Width - 7,f.Height + 20));
                e.Graphics.DrawString("Unico", f, Brushes.Black, new Point(5, f.Height + 40));
                Rectangle rect = new Rectangle(50, f.Height + 40, e.PageBounds.Width - 65, f.Height + 30);
                e.Graphics.DrawString(txtUnico.Text.ToUpper(), f, Brushes.Black,rect);
                e.Graphics.DrawString("MC", f, Brushes.Black, new Point(5, f.Height + 80));
                e.Graphics.DrawString(txtMachine.Text.ToUpper(), f, Brushes.Black, new Point(e.PageBounds.Width - 110, f.Height + 80));
                e.Graphics.DrawString("Mat OP", f, Brushes.Black, new Point(5, f.Height + 120));
                e.Graphics.DrawString(txtMatricule.Text.ToUpper(), f, Brushes.Black, new Point(e.PageBounds.Width - 110, f.Height + 120));
                e.Graphics.DrawString("Qty", f, Brushes.Black, new Point(5, f.Height + 160));
                e.Graphics.DrawString(txtQty.Text.ToUpper(), f, Brushes.Black, new Point(e.PageBounds.Width - 110, f.Height + 160));
                e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), f, Brushes.Black, new Point((e.PageBounds.Width / 2 - 80), f.Height + 200));

            }
            catch (Exception ex)
            {
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            txtQty.Focus();
            txtQty.PlaceholderForeColor = Color.FromArgb(255, 221, 221, 221);

            if (txtQty.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                btnPrint.PerformClick();
            }
        }
    }
}
