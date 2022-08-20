using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace AutoComplete
{
    public class AutoComplete
    {

        public void autoComplete(Guna2TextBox txt, SqlConnection con, string Query)
        {

            try
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        coll.Add(r[0].ToString());
                    }

                }

                con.Close();

                txt.AutoCompleteCustomSource = coll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

    }
}
