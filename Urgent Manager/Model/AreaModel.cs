using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class AreaModel
    {
        private string areaName = "";
        private string parentArea = "";
        private string userID = "";


        public string AreaName
        {
            get { return areaName; }
            set { areaName = value; }
        }

        public string ParentArea
        {
            get { return parentArea; }
            set { parentArea = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

    }
}
