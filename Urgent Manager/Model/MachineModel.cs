using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class MachineModel
    {
        private string machine = "";

        private string parentZone = "";

        private string userID = "";

        public string Machine
        {
            get
            {
                return machine;
            }

            set
            {
                machine = value;
            }
        }

        public string ParentZone
        {
            get
            {
                return parentZone;
            }

            set
            {
                parentZone = value;
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
