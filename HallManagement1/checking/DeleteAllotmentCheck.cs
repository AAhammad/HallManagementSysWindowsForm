using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.checking
{
    class DeleteAllotmentCheck
    {
        public void deleteallot(AllotmentInfo aOb)
        {
              if ( aOb.aRoom_No==""||aOb.ast_Id==-1||aOb.allot_Id=="")
            {
                MessageBox.Show("please click on the row.");
            }
              else
              {
                  DialogResult dr = MessageBox.Show("Are you want to delete Allot ID :" + aOb.allot_Id, "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  if (dr == DialogResult.Yes)
                  {
                      AllotmentInfoDataAccess dObj = new AllotmentInfoDataAccess();
                      dObj.updateAvailableSeat(aOb);
                      dObj.deleteInfo(aOb);
                      MessageBox.Show("deleted ");

                  }
                  else if (dr == DialogResult.No)
                  {
                      MessageBox.Show("not deleted.");
                  }
              }
        }
    }
}
