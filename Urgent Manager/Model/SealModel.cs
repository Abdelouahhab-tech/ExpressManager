using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class SealModel
    {
        private string sealID = "";

        private string color = "";

        private string userID = "";

        public string SealID
        {
            get
            {
                return sealID;
            }

            set
            {
                sealID = value;
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
    }
}
