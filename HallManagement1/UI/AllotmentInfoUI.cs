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
    public partial class AllotmentInfoUI : Form
    {    private SqlConnection connection;
        public AllotmentInfoUI()
        {
            InitializeComponent();
            

       
        
            string server = "ali";
            string database = "hallmanagement";

            string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
                database);


            connection = new SqlConnection(connectionString);


        
        }

      public void viewButton_Click(object sender, EventArgs e)
        {
            //AllotmentInfoDataAccess dataAccess = new AllotmentInfoDataAccess();
            //DataTable tbl = dataAccess.viewAllotStudentInfo();
            //AllotedStudentDataGridView.AutoGenerateColumns = false;
            //AllotedStudentDataGridView.DataSource = tbl;
            AllotmentInfoDataAccess dataAccess = new AllotmentInfoDataAccess();
            List<AllotmentInfo> stu= dataAccess.viewAllotStudentInfo();
            AllotedStudentDataGridView.AutoGenerateColumns = false;
            AllotedStudentDataGridView.DataSource = stu;
            AllotedStudentDataGridView.Columns[0].DataPropertyName = "ast_Id";
            AllotedStudentDataGridView.Columns[2].DataPropertyName = "ast_Name";
            AllotedStudentDataGridView.Columns[3].DataPropertyName = "ast_FatherName";
            AllotedStudentDataGridView.Columns[4].DataPropertyName = "ast_MotherName";
            AllotedStudentDataGridView.Columns[5].DataPropertyName = "ast_Address";
            AllotedStudentDataGridView.Columns[6].DataPropertyName = "ast_Phone";
            AllotedStudentDataGridView.Columns[7].DataPropertyName = "ast_Email";
            AllotedStudentDataGridView.Columns[8].DataPropertyName = "ast_Dept";
            AllotedStudentDataGridView.Columns[9].DataPropertyName = "ast_Roll";
            AllotedStudentDataGridView.Columns[10].DataPropertyName = "ast_Cgpa";
            AllotedStudentDataGridView.Columns[11].DataPropertyName = "ast_Session";
            AllotedStudentDataGridView.Columns[12].DataPropertyName = "ast_Blood";

            AllotedStudentDataGridView.Columns[1].DataPropertyName = "allot_Id";
            AllotedStudentDataGridView.Columns[13].DataPropertyName = "aRoom_No";
            AllotedStudentDataGridView.Columns[14].DataPropertyName = "aInDate";


        }

        private void searchByAllotIdButton_Click(object sender, EventArgs e)
        {
            //deleteIdtextBox.Text = "";
            AllotmentInfo Obj = new AllotmentInfo();
            if(allotSearchByAllotIdTextBox.Text=="")
            {

                MessageBox.Show("please fill up \"the TextBox\"");



            }
            else
            {
                Obj.allot_Id = allotSearchByAllotIdTextBox.Text;

                AllotmentInfoDataAccess dataAccess = new AllotmentInfoDataAccess();
                List<AllotmentInfo> students = dataAccess.searchByAllotId(Obj);
                AllotedStudentDataGridView.DataSource = students;
                
            }
           //AllotmentInfoCheck Cobj=new AllotmentInfoCheck();
           // List<AllotmentInfo> students=Cobj.searchByAllotIdCheck(Obj);
             
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            AllotmentInfo Obj = new AllotmentInfo()
            {
               ast_Name = allotSearchByNameTextBox.Text



            };
            AllotmentInfoDataAccess dataAccess = new AllotmentInfoDataAccess();
            List<AllotmentInfo> students = dataAccess.searchByName(Obj);
            AllotedStudentDataGridView.DataSource = students;
        }

        private void searchByRollButton_Click(object sender, EventArgs e)
        {
             AllotmentInfo Obj = new AllotmentInfo()
            {
               ast_Roll = allotSearchByRollTextBox.Text



            };
            AllotmentInfoDataAccess dataAccess = new AllotmentInfoDataAccess();
            List<AllotmentInfo> students = dataAccess.searchByRoll(Obj);
            AllotedStudentDataGridView.DataSource = students;
        }

        private void allotSearchByAllotIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(allotSearchByAllotIdTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                allotSearchByAllotIdTextBox.Text.Remove(allotSearchByAllotIdTextBox.TextLength - 1);
               allotSearchByAllotIdTextBox.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllotmentInfoUI_Load(object sender, EventArgs e)
        {

        }

      
        }
    }

