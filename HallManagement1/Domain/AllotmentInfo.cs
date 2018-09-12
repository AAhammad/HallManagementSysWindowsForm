using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallManagement1.Domain
{
   public class AllotmentInfo
    {
        public int ast_Id { get; set; }
        public string ast_Name { get; set; }
        public string ast_FatherName { get; set; }
        public string ast_MotherName { get; set; }
        public string ast_Address { get; set; }
        public string ast_Phone { get; set; }
        public string ast_Email { get; set; }
        public string ast_Dept { get; set; }
        public string ast_Roll { get; set; }
        public decimal ast_Cgpa { get; set; }
        public string ast_Session { get; set; }
        public string ast_Blood { get; set; }

        public string allot_Id { get; set; }

        public string  aRoom_No { get; set; }

        public string astudentId { get; set; }
        public string aInDate { get; set; }

    }
}
