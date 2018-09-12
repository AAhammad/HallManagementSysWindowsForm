using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallManagement1.Domain
{
    class NewAllotInfo
    {
        public int allot_id { get; set; }

        public int allot_room_no {get; set; }

        public int allot_student_id { get; set; }

        public string inDate { get; set; }

        public int availabe_seat { get; set; }
    }
}
