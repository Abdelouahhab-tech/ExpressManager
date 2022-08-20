using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class GroupModel
    {
        private string group = "";
        private string userID = "";

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
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
