using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallManagement1.Domain
{
    class ComplainInfo
    {
        public int cId { get; set; }
        public int cAllot_id { get; set; }
        public string cName { get; set; }
        public string cRoll { get; set; }
        public string cMb { get; set; }
        public string cDate { get; set; }

        public string complain { get; set; }
    }
}
