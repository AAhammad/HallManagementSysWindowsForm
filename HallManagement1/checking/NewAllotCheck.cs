using System.Windows.Forms;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.checking
{
    class NewAllotCheck
    {
        public void saveAllotCheck(NewAllotInfo aObj)
        {



            if (aObj.allot_room_no == -1 || aObj.allot_student_id == -1 || aObj.inDate == "") 
            {
                MessageBox.Show("please fill up all properties successfully !!!");
            }
            else
            {  
                NewAllotDataAccess dobj =new NewAllotDataAccess();
                dobj.saveAllotment(aObj);

                dobj.updateAvailableSeatInfo(aObj);


            }


        
        } 
    }
}
