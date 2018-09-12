using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.checking;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.UI
{
    public partial class InsertUpdateDeleteApplicantInfoUI : Form
    {
        public InsertUpdateDeleteApplicantInfoUI()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            deleteIdtextBox.Text = "";
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
               deleteIdtextBox.Text = "";
           
              StudentInfo stuObj = new StudentInfo()
            {   
                st_Id = Convert.ToInt32(studentIdTextBox.Text),
                st_Name= studentNameTextBox.Text,
                st_FatherName = studentFatherNameTextBox.Text,
                st_MotherName = studentMotherNameTextBox.Text,
                st_Address = studentAddresTextBox.Text,
                st_Phone = studentPhoneNumTextBox.Text,
                st_Email = studentEmailTextBox.Text,
                st_Dept = studentDepartmentComboBox.Text,
                st_Roll = studentRollTextBox.Text,
                st_Session = studentSessionComboBox.Text,
               
               
                
                st_Blood = studentBloodGroupTextBox.Text,
               


            };
              if (studentCgpaTextBox.Text == "")
              {
                  stuObj.st_Cgpa = -1;
              }
              else
              {
                  stuObj.st_Cgpa = Convert.ToDecimal(studentCgpaTextBox.Text);
              }
          
            InsertUpdateDeleteApplicantChecking obj = new InsertUpdateDeleteApplicantChecking();
            obj.saveButtonCheck(stuObj);


            deleteIdtextBox.Text = "";
            StudentDataAccess dataAccess = new StudentDataAccess();
            List<StudentInfo> students = dataAccess.viewStudentInfo();
            studentDataGridView.AutoGenerateColumns = false;
            studentDataGridView.DataSource = students;
          
        }

       

        private void studentDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             //this.studentDepartmentComboBox.DropDownStyle=ComboBoxStyle.DropDownList;
            //e.Handled = true;
        }


        private SqlConnection connection;
        public void viewButton_Click(object sender, EventArgs e)
        {
            deleteIdtextBox.Text = "";
            //string server = "ali";
            //string database = "hallmanagement";

            //string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
            //    database);
            //connection = new SqlConnection(connectionString);


            StudentDataAccess dataAccess = new StudentDataAccess();
            List<StudentInfo> students = dataAccess.viewStudentInfo();
            studentDataGridView.AutoGenerateColumns = false;
            studentDataGridView.DataSource = students;
            studentDataGridView.Columns[0].DataPropertyName = "st_Id";
            studentDataGridView.Columns[1].DataPropertyName = "st_Name";
            studentDataGridView.Columns[2].DataPropertyName = "st_FatherName";
            studentDataGridView.Columns[3].DataPropertyName = "st_MotherName";
            studentDataGridView.Columns[4].DataPropertyName = "st_Address";
            studentDataGridView.Columns[5].DataPropertyName = "st_Phone";
            studentDataGridView.Columns[6].DataPropertyName = "st_Email";
            studentDataGridView.Columns[7].DataPropertyName = "st_Dept";
            studentDataGridView.Columns[8].DataPropertyName = "st_Roll";
            studentDataGridView.Columns[9].DataPropertyName = "st_Cgpa";
            studentDataGridView.Columns[10].DataPropertyName = "st_Session";
            studentDataGridView.Columns[11].DataPropertyName = "st_Blood";
            //connection.Open();
            //SqlDataAdapter sdaObj = new SqlDataAdapter("select * from tbl_student", connection);
            //DataTable tb = new DataTable();
            //sdaObj.Fill(tb);
            //studentDataGridView.DataSource = tb;


        }

        private void studentDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                deleteIdtextBox.Text = "";


                studentIdTextBox.Text = studentDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                studentNameTextBox.Text = studentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                studentFatherNameTextBox.Text = studentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                studentMotherNameTextBox.Text = studentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                studentAddresTextBox.Text = studentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                studentPhoneNumTextBox.Text = studentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                studentEmailTextBox.Text = studentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                studentDepartmentComboBox.Text = studentDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                studentRollTextBox.Text = studentDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                studentCgpaTextBox.Text = studentDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                studentSessionComboBox.Text = studentDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                studentBloodGroupTextBox.Text = studentDataGridView.SelectedRows[0].Cells[11].Value.ToString();
                   
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            deleteIdtextBox.Text = "";
            StudentInfo stuObj = new StudentInfo()
            {   
               
                st_Name = studentNameTextBox.Text,
                st_FatherName = studentFatherNameTextBox.Text,
                st_MotherName = studentMotherNameTextBox.Text,
                st_Address = studentAddresTextBox.Text,
                st_Phone = studentPhoneNumTextBox.Text,
                st_Email = studentEmailTextBox.Text,
                st_Dept = studentDepartmentComboBox.Text,
                st_Roll = studentRollTextBox.Text,
                st_Session = studentSessionComboBox.Text,
           
                st_Blood = studentBloodGroupTextBox.Text,



            };
            if (studentCgpaTextBox.Text == "" || studentIdTextBox.Text=="")
            {
                stuObj.st_Cgpa = 0;
            }
            else
            {
                stuObj.st_Id = Convert.ToInt32(studentIdTextBox.Text);
                stuObj.st_Cgpa = Convert.ToDecimal(studentCgpaTextBox.Text);
            }
            InsertUpdateDeleteApplicantChecking obj = new InsertUpdateDeleteApplicantChecking();
            obj.updateButtonCheck(stuObj);

            deleteIdtextBox.Text = "";
            StudentDataAccess dataAccess = new StudentDataAccess();
            List<StudentInfo> students = dataAccess.viewStudentInfo();
            studentDataGridView.AutoGenerateColumns = false;
            studentDataGridView.DataSource = students;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
                deleteIdtextBox.Text = "";   

                studentNameTextBox.Clear();
                studentFatherNameTextBox.Clear();
                studentMotherNameTextBox.Clear();
                studentAddresTextBox.Clear();
                studentPhoneNumTextBox.Clear();
                studentEmailTextBox.Clear();    
                studentRollTextBox.Clear();
                studentCgpaTextBox.Clear();
                studentBloodGroupTextBox.Clear();
                studentDepartmentComboBox.SelectedIndex = -1;
                studentSessionComboBox.SelectedIndex = -1;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            deleteIdtextBox.Text = "";
            StudentDataAccess dataAccess = new StudentDataAccess();
            List<StudentInfo> students = dataAccess.viewStudentInfo();
            studentDataGridView.AutoGenerateColumns = false;
            studentDataGridView.DataSource = students;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            //if (deleteIdtextBox.Text =="")
            //{
            //    StudentDataAccess obj = new StudentDataAccess();
            //    obj.deleteStudentIn();
            //}
            if (deleteIdtextBox.Text =="")
            {
                MessageBox.Show("please click on the row.");
            }

            else  {
                StudentInfo stuObj = new StudentInfo()
                {



                    st_Id = Convert.ToInt32(deleteIdtextBox.Text),



                };

                DialogResult dr = MessageBox.Show("Are you want to delete ID:" + stuObj.st_Id, "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    StudentDataAccess obj = new StudentDataAccess();
                    obj.updateRoomavailableSeat(stuObj);
                    obj.deleteStudentInfo(stuObj);
                  
                    //obj.updateAvailableSeat(stuObj);
                    deleteIdtextBox.Text = "";
                    MessageBox.Show("deleted ");
                    deleteIdtextBox.Text = "";
                    StudentDataAccess dataAccess = new StudentDataAccess();
                    List<StudentInfo> students = dataAccess.viewStudentInfo();
                    studentDataGridView.AutoGenerateColumns = false;
                    studentDataGridView.DataSource = students;
                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("not deleted.");
                }

            }

        }

        private void searchByRollLabel_Click(object sender, EventArgs e)
        {
            deleteIdtextBox.Text = "";
            StudentInfo stuObj = new StudentInfo()
            {
                st_Roll = studentRollTextBox.Text



            };
            StudentDataAccess dataAccess = new StudentDataAccess();
            List<StudentInfo> students = dataAccess.searchByRoll(stuObj);
            studentDataGridView.DataSource = students;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void refreshButtonToolTip_Popup(object sender, PopupEventArgs e)
        {
         
        }

        //private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    deleteIdtextBox.Text = studentDataGridView.SelectedRows[0].Cells[0].Value.ToString();

        //}
        private void studentDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteIdtextBox.Text = "";
        }
        //private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    deleteIdtextBox.Text = studentDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        //}

      

       

        private void searchByBloodGroup_Click_1(object sender, EventArgs e)
        {
            deleteIdtextBox.Text = "";
            StudentInfo stuObj = new StudentInfo()
            {
                st_Blood = studentBloodGroupTextBox.Text



            };
            StudentDataAccess dataAccess = new StudentDataAccess();
            List<StudentInfo> students = dataAccess.searchByBloodGroup(stuObj);
            studentDataGridView.DataSource = students;


        }

        private void studentDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void studentDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteIdtextBox.Text = "";
        }



        //private void studentDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{

        //    deleteIdtextBox.Text = studentDataGridView.SelectedRows[0].Cells[0].Value.ToString();

        //}

       

        private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteIdtextBox.Text = studentDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

      
        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentCgpaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(studentCgpaTextBox.Text, "[^0-9 .]"))
            {
                MessageBox.Show("please enter only numbers.");
               studentCgpaTextBox.Text.Remove(studentCgpaTextBox.TextLength - 1);
               studentCgpaTextBox.Clear();
            }
        }

        private void InsertUpdateDeleteApplicantInfoUI_Load(object sender, EventArgs e)
        {

        }

        private void studentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void studentFatherNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void studentMotherNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentPhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void studentEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void studentRollTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void studentSessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(studentIdTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                studentIdTextBox.Text.Remove(studentIdTextBox.TextLength - 1);
                studentIdTextBox.Clear();
            }
        }


      
    }
}
