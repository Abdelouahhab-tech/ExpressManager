using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class UserModel
    {
        private string username = "";
        private string password = "";
        private string FullName = "";
        private string role = "";
        private string zone = "";
        private string EntryAgent = "";
        private int isUpdated = 0;
        
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Fullname
        {
            get { return FullName; }
            set { FullName = value; }
        }

        public string Zone
        {
            get { return zone; }
            set { zone = value; }
        }

        public string Entry
        {
            get { return EntryAgent; }
            set { EntryAgent = value; }
        }
        public int IsUpdated
        {
            get { return isUpdated; }
            set { isUpdated = value; }
        }
    }
}
