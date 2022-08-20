using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Controller
{
    public class DbHelper
    {
        // Connection Instance
        public static SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Express;User ID=Aptiv;Password=Aptiv22");
    }
}
