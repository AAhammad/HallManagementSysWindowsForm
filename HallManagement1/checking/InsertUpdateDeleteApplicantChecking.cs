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
    internal class InsertUpdateDeleteApplicantChecking
    {
        public void saveButtonCheck(StudentInfo stObj)
        {

            if (stObj.st_Name == "" || stObj.st_FatherName == "" || stObj.st_MotherName == "" || stObj.st_Address == "" ||
                stObj.st_Dept == "" || stObj.st_Roll == "" || stObj.st_Session == "" || stObj.st_Cgpa == -1)
            {
                MessageBox.Show("please fill up all properties successfully !!!");
            }
            else
            {
               StudentDataAccess dataAccess = new StudentDataAccess();

                int i = dataAccess.haveAnyStuId(stObj);
                if (i == 0)
                {

                    StudentDataAccess ob = new StudentDataAccess();

                    int j = ob.saveStudent(stObj);

                    string Message = j > 0 ? "create successfully" : "data not saved";
                    MessageBox.Show(Message);

                }
                else
                {
                    MessageBox.Show("there is exit another account has same room no !!!\n\t please try again.");

                }


               
            }


        }


        public void updateButtonCheck(StudentInfo stObj)
        {

            if (stObj.st_Name == "" || stObj.st_FatherName == "" || stObj.st_MotherName == "" || stObj.st_Address == "" ||
                stObj.st_Dept == "" || stObj.st_Roll == "" || stObj.st_Session == "" || stObj.st_Cgpa == 0)
            {
                MessageBox.Show("please fill up all properties successfully !!!");
            }
          
            else
            {
                StudentDataAccess obj = new StudentDataAccess();
                obj.updateStudentInfo(stObj);
            }


        }



       

    }
}
