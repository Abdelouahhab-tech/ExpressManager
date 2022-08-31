using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class DirectoriesModel
    {
        private string pathName = "";
        private string userID = "";

        public string PathName
        {
            get
            {
                return pathName;
            }

            set
            {
                pathName = value;
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
