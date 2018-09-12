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
    public partial class NewAllotUI : Form
    {
        public NewAllotUI()
        {
            InitializeComponent();
        }

        private void studentNotAllotDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void viewNotAllotStudentInfoButton_Click(object sender, EventArgs e)
        {
            //deleteIdtextBox.Text = "";
            //string server = "ali";
            //string database = "hallmanagement";

            //string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
            //    database);
            //connection = new SqlConnection(connectionString);


            NewAllotDataAccess dataAccess = new NewAllotDataAccess();
            List<StudentInfo> students = dataAccess.viewNotAllotStudentInfo();
            studentNotAllotDataGridView.AutoGenerateColumns = false;
            studentNotAllotDataGridView.DataSource = students;
            studentNotAllotDataGridView.Columns[0].DataPropertyName = "st_Id";
            studentNotAllotDataGridView.Columns[1].DataPropertyName = "st_Name";
            //studentDataGridView.Columns[2].DataPropertyName = "st_FatherName";
            //studentDataGridView.Columns[3].DataPropertyName = "st_MotherName";
            studentNotAllotDataGridView.Columns[2].DataPropertyName = "st_Address";
            studentNotAllotDataGridView.Columns[7].DataPropertyName = "st_Phone";
            studentNotAllotDataGridView.Columns[8].DataPropertyName = "st_Email";
            studentNotAllotDataGridView.Columns[3].DataPropertyName = "st_Dept";
            studentNotAllotDataGridView.Columns[5].DataPropertyName = "st_Roll";
            studentNotAllotDataGridView.Columns[4].DataPropertyName = "st_Cgpa";
            studentNotAllotDataGridView.Columns[6].DataPropertyName = "st_Session";
            studentNotAllotDataGridView.Columns[9].DataPropertyName = "st_Blood";
        }

      public void viewAvailableSeatFillUpButton_Click(object sender, EventArgs e)
        {

            //deleteRoomTextBox.Text = "";



          NewAllotDataAccess dataAccess = new NewAllotDataAccess();
            List<RoomInfo> rooms = dataAccess.viewRoomNotFillUpInfo();
            roomNotFillUPDataGridView.AutoGenerateColumns = false;
            roomNotFillUPDataGridView.DataSource = rooms;
            roomNotFillUPDataGridView.Columns[0].DataPropertyName = "rm_No";
            roomNotFillUPDataGridView.Columns[1].DataPropertyName = "block_No";
            roomNotFillUPDataGridView.Columns[2].DataPropertyName = "floor_No";
            roomNotFillUPDataGridView.Columns[3].DataPropertyName = "available_Seat";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            allotIdTextBox.Clear();
            allotRoomNOTextBox.Clear();
            allotStudentIDTextBox.Clear();
            allotInDateTextBox.Clear();
        }

        private void studentNotAllotDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            allotStudentIDTextBox.Text = studentNotAllotDataGridView.SelectedRows[0].Cells[0].Value.ToString();
           
        }

        private void roomNotFillUPDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           allotRoomNOTextBox.Text = roomNotFillUPDataGridView.SelectedRows[0].Cells[0].Value.ToString();
           allotAvailableSeatTextBox.Text = roomNotFillUPDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            NewAllotInfo Obj = new NewAllotInfo()
            {
               
                inDate = allotInDateTextBox.Text
               


            };
            //if (allotIdTextBox.Text == "" )
            //{
            //    Obj.allot_id= -1;
            //}
            if (allotRoomNOTextBox.Text == "" || allotStudentIDTextBox.Text=="" )
            {
                Obj.allot_room_no = -1;
                
            }
            //if (allotStudentID.Text == "")
            //{
            //    Obj.allot_student_id = -1;
            //}
            else
            {
                //Obj.allot_id = Convert.ToInt32(allotIdTextBox.Text);
                Obj.allot_room_no = Convert.ToInt32(allotRoomNOTextBox.Text);
                Obj.allot_student_id = Convert.ToInt32(allotStudentIDTextBox.Text);
                Obj.availabe_seat = Convert.ToInt32(allotAvailableSeatTextBox.Text);
            }

            NewAllotCheck ob = new NewAllotCheck();
            ob.saveAllotCheck(Obj);

            allotRoomNOTextBox.Clear();
            allotStudentIDTextBox.Clear();
            allotAvailableSeatTextBox.Clear();
            allotInDateTextBox.Clear();

            NewAllotDataAccess dataAc = new NewAllotDataAccess();
            List<StudentInfo> students = dataAc.viewNotAllotStudentInfo();
            studentNotAllotDataGridView.AutoGenerateColumns = false;
            studentNotAllotDataGridView.DataSource = students;


            NewAllotDataAccess dataAccess = new NewAllotDataAccess();
            List<RoomInfo> rooms = dataAccess.viewRoomNotFillUpInfo();
            roomNotFillUPDataGridView.AutoGenerateColumns = false;
            roomNotFillUPDataGridView.DataSource = rooms;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
