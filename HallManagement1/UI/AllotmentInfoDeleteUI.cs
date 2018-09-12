using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class AllotmentInfoDeleteUI : Form
    {
        public AllotmentInfoDeleteUI()
        {
            InitializeComponent();
        }

        public void deleteAllotViewButton_Click(object sender, EventArgs e)
        {
            AllotmentInfoDataAccess dataAccess = new AllotmentInfoDataAccess();
            List<AllotmentInfo> stu = dataAccess.viewAllotStudentInfo();
            AllotedStudentDeleteDataGridView.AutoGenerateColumns = false;
            AllotedStudentDeleteDataGridView.DataSource = stu;
            AllotedStudentDeleteDataGridView.Columns[1].DataPropertyName = "ast_Id";
            AllotedStudentDeleteDataGridView.Columns[2].DataPropertyName = "ast_Name";
            AllotedStudentDeleteDataGridView.Columns[3].DataPropertyName = "ast_FatherName";
            AllotedStudentDeleteDataGridView.Columns[4].DataPropertyName = "ast_MotherName";
            AllotedStudentDeleteDataGridView.Columns[5].DataPropertyName = "ast_Address";
            AllotedStudentDeleteDataGridView.Columns[6].DataPropertyName = "ast_Phone";
            AllotedStudentDeleteDataGridView.Columns[7].DataPropertyName = "ast_Email";
            AllotedStudentDeleteDataGridView.Columns[8].DataPropertyName = "ast_Dept";
            AllotedStudentDeleteDataGridView.Columns[9].DataPropertyName = "ast_Roll";
            AllotedStudentDeleteDataGridView.Columns[10].DataPropertyName = "ast_Cgpa";
            AllotedStudentDeleteDataGridView.Columns[11].DataPropertyName = "ast_Session";
            AllotedStudentDeleteDataGridView.Columns[12].DataPropertyName = "ast_Blood";

            AllotedStudentDeleteDataGridView.Columns[0].DataPropertyName = "allot_Id";
            AllotedStudentDeleteDataGridView.Columns[13].DataPropertyName = "aRoom_No";
            AllotedStudentDeleteDataGridView.Columns[14].DataPropertyName = "aInDate";
        }

        private void AllotedStudentDeleteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //deleteIdtextBox.Text = "";


            studentIdTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            allotIdTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            roomNoTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            //studentMotherNameTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            //studentAddresTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            //studentPhoneNumTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            //studentEmailTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            //studentDepartmentComboBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            //studentRollTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            //studentCgpaTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            //studentSessionComboBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            //studentBloodGroupTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

          

             AllotmentInfo ob = new AllotmentInfo()
            {

              
               allot_Id = allotIdTextBox.Text,
               aRoom_No = roomNoTextBox.Text,



            };
          if (studentIdTextBox.Text == "" )
            {
                ob.ast_Id = -1;
                
             }
            else
            { ob.ast_Id = Convert.ToInt32(studentIdTextBox.Text);

            }

           DeleteAllotmentCheck obj=new DeleteAllotmentCheck();
            obj.deleteallot(ob);
           

            studentIdTextBox.Text = "";
            allotIdTextBox.Text = "";
            roomNoTextBox.Text = "";

            AllotmentInfoDataAccess dataAccess = new AllotmentInfoDataAccess();
            List<AllotmentInfo> stu = dataAccess.viewAllotStudentInfo();
            AllotedStudentDeleteDataGridView.AutoGenerateColumns = false;
            AllotedStudentDeleteDataGridView.DataSource = stu;
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllotedStudentDeleteDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            studentIdTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            allotIdTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            roomNoTextBox.Text = AllotedStudentDeleteDataGridView.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void AllotedStudentDeleteDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentIdTextBox.Text = "";
            allotIdTextBox.Text = "";
            roomNoTextBox.Text = "";

        }

        private void AllotmentInfoDeleteUI_Load(object sender, EventArgs e)
        {

        }

      
    }
}
