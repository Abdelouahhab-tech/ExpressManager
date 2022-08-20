using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class FamilyModel
    {
        private string family = "";

        private string userID = "";

        public string FamilyName
        {
            get { return family; }
            set { family = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
