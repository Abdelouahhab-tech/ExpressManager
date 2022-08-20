using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urgent_Manager.Controller
{
    public class Generator
    {
        Guna2DataGridView data;
        public Generator(Guna2DataGridView data)

        {
            this.data = data;
        }

        public void GenerateExcel(DataGridView data)
        {
            try
            {
                if (data != null)
                {

                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    app.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < data.Columns.Count + 1; i++)
                    {
                        app.Cells[1, i] = data.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < data.Rows.Count; i++)
                    {

                        for (int j = 0; j < data.Columns.Count; j++)
                        {
                            if (data.Rows[i].Cells[j].Value != null)
                                app.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    app.Columns.AutoFit();
                    app.Visible = true;

                }
                else
                {
                    MessageBox.Show("La Liste Est Vide");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public async void GenerateExcel()
        {
            try
            {

                await Task.Run(new Action(generate));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generate()
        {
            try
            {
                if (data != null)
                {

                    data.Invoke((MethodInvoker)delegate
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        app.Application.Workbooks.Add(Type.Missing);

                        for (int i = 1; i < data.Columns.Count + 1; i++)
                        {
                            app.Cells[1, i] = data.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < data.Rows.Count; i++)
                        {

                            for (int j = 0; j < data.Columns.Count; j++)
                            {
                                if (data.Rows[i].Cells[j].Value != null)
                                    app.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        app.Columns.AutoFit();
                        app.Visible = true;
                    });

                }
                else
                {
                    MessageBox.Show("La Liste Est Vide");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
