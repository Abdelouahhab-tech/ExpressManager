using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class UrgentModel
    {
        private string urgentUnico = "";
        private string family = "";
        private string leadCode = "";
        private string machine = "";
        private string adress = "";
        private string cable = "";
        private string color = "";
        private string length = "";
        private string marL = "";
        private string marR = "";
        private string sealL = "";
        private string sealR = "";
        private string terL = "";
        private string terR = "";
        private string toolL = "";
        private string toolR = "";
        private string group = "";
        private string leadPrep = "";
        private string dateUrgent = "";
        private string shift = "";
        private string status = "";
        private string alimentation = "";
        private string userFinished = "";
        private string finishedDate = "";
        private string time = "";
        private string ftime = "";
        private int isOptimized = 0;

        public enum Shifts
        {
            Matin,
            Soir,
            Nuit
        }

        public enum Status
        {
            Express,
            Finished
        }

        public string UrgentUnico
        {
            get
            {
                return urgentUnico;
            }

            set
            {
                urgentUnico = value;
            }
        }

        public string DateUrgent
        {
            get
            {
                return dateUrgent;
            }

            set
            {
                dateUrgent = value;
            }
        }

        public string Alimentation
        {
            get
            {
                return alimentation;
            }

            set
            {
                alimentation = value;
            }
        }

        public string UserFinished
        {
            get
            {
                return userFinished;
            }

            set
            {
                userFinished = value;
            }
        }

        public string FinishedDate
        {
            get
            {
                return finishedDate;
            }

            set
            {
                finishedDate = value;
            }
        }

        public string Shift
        {
            get
            {
                return shift;
            }

            set
            {
                shift = value;
            }
        }

        public string UrgentStatus
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Family
        {
            get
            {
                return family;
            }

            set
            {
                family = value;
            }
        }

        public string LeadCode
        {
            get
            {
                return leadCode;
            }

            set
            {
                leadCode = value;
            }
        }

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

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

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

        public string Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public string MarL
        {
            get
            {
                return marL;
            }

            set
            {
                marL = value;
            }
        }

        public string MarR
        {
            get
            {
                return marR;
            }

            set
            {
                marR = value;
            }
        }

        public string SealL
        {
            get
            {
                return sealL;
            }

            set
            {
                sealL = value;
            }
        }

        public string SealR
        {
            get
            {
                return sealR;
            }

            set
            {
                sealR = value;
            }
        }

        public string TerL
        {
            get
            {
                return terL;
            }

            set
            {
                terL = value;
            }
        }

        public string TerR
        {
            get
            {
                return terR;
            }

            set
            {
                terR = value;
            }
        }

        public string LeadPrep
        {
            get
            {
                return leadPrep;
            }

            set
            {
                leadPrep = value;
            }
        }

        public string ToolL
        {
            get
            {
                return toolL;
            }

            set
            {
                toolL = value;
            }
        }

        public string ToolR
        {
            get
            {
                return toolR;
            }

            set
            {
                toolR = value;
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

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public int IsOptimized
        {
            get
            {
                return isOptimized;
            }

            set
            {
                isOptimized = value;
            }
        }

        public string Ftime
        {
            get
            {
                return ftime;
            }

            set
            {
                ftime = value;
            }
        }
    }
}
