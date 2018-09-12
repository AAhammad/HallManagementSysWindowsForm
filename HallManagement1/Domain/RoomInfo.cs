using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallManagement1.Domain
{
    public class RoomInfo
    {
        public int rm_No { get; set; }

        public string block_No { get; set; }

        public string floor_No { get; set; }

        public int available_Seat { get; set; }
    }
}
