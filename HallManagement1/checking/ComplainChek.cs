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
    class ComplainChek
    {

        public void submitChek(ComplainInfo obj)
        {
            if (obj.cName == "" || obj.cAllot_id==-1 || obj.cRoll == "" || obj.cMb == "" || obj.cDate == "" || obj.complain == "")
            {
                MessageBox.Show("please fill up all the require information!!!");
            }

            else
            {
                ComplainDataAccess dataAccess=new ComplainDataAccess();
                  int i=dataAccess.nameRollChek(obj);
                if (i > 0)
                {
                    dataAccess.saveComplain(obj);
                }
               
                else
                {
                    MessageBox.Show("your allot id or name or roll don't match  !!!!!");
                }
            }
        }

        public void deleteComplainCheck(ComplainInfo ob)
        {
            if (ob.cId == 0)
            {
                MessageBox.Show("plese click on a row .");
            }

            else
            {
                DialogResult dr = MessageBox.Show("Are you want to delete complain ID :" + ob.cId, "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ComplainDataAccess dObj = new ComplainDataAccess();
                  
                    dObj.deleteComplain(ob);
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
