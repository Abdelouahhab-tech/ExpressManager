using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class TerminalModel
    {
        private string terID = "";

        private string userID = "";

        public string TerID
        {
            get
            {
                return terID;
            }

            set
            {
                terID = value;
            }
        }

        public string UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }
    }
}
