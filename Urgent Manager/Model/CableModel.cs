using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class CableModel
    {
        private string cable = "";

        private string section = "";

        private string pvc = "";

        private string color = "";

        private string guide = "";

        private string userID = "";

        public string Cable
        {
            get
            {
                return cable;
            }

            set
            {
                cable = value;
            }
        }

        public string Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
            }
        }

        public string Pvc
        {
            get
            {
                return pvc;
            }

            set
            {
                pvc = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
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

        public string Guide
        {
            get
            {
                return guide;
            }

            set
            {
                guide = value;
            }
        }
    }
}
