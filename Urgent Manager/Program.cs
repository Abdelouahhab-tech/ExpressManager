using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urgent_Manager.Controller;
using Urgent_Manager.View;
using Urgent_Manager.View.DashBoard;

namespace Urgent_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WPCSController wpcs = new WPCSController();
            MachineController machineController = new MachineController();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (WPCSController.isConnect())
            //    if (wpcs.IsExist(Environment.MachineName, "Machine", "Machine"))
            //    {
            //        if (machineController.isConnect(Environment.MachineName))
            //        {
            //            Application.Run(new Operateur());
            //        }
            //        else
            //        {
            //            Application.Run(new ServerAccess());
            //        }
            //    }
            //    else
            //    {
            //        Application.Run(new Login());
            //    }
            //else
            //    Application.Run(new ServerAccess());
            Application.Run(new Operateur());
        }
    }
}
