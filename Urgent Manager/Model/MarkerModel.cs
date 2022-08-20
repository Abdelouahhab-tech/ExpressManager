using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class MarkerModel
    {
        private string markerColor = "";
        private string userID = "";

        public string MarkerColor
        {
            get
            {
                return markerColor;
            }

            set
            {
                markerColor = value;
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
