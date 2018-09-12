using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.Domain;
using HallManagement1.UI;

namespace HallManagement1.DataAccess
{
    internal class StudentDataAccess
    {
        private SqlConnection connection;

        public StudentDataAccess()
        {
            string server = @"ALI\SQLEXPRESS";
            string database = "hallmanagement";

            string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
                database);


            connection = new SqlConnection(connectionString);


        }

        public int saveStudent(StudentInfo stObj)
        {

            connection.Open();
            SqlDataAdapter sda =
                new SqlDataAdapter(
                    "insert into tbl_student(stu_id,stu_name,stu_father_name,stu_mother_name,stu_address,stu_phone,stu_email,stu_dept,stu_roll,stu_CGPA,stu_session,stu_blood) values(" +stObj.st_Id +",'"+
                    stObj.st_Name + "','" + stObj.st_FatherName + "','" + stObj.st_MotherName + "','" + stObj.st_Address +
                    "','" + stObj.st_Phone + "','" + stObj.st_Email + "','" + stObj.st_Dept + "','" + stObj.st_Roll +
                    "'," + stObj.st_Cgpa + ",'" +
                    stObj.st_Session + "','" + stObj.st_Blood + "')", connection);

            int d=sda.SelectCommand.ExecuteNonQuery();
            connection.Close();
            //MessageBox.Show("save successfully");
            return d;
            


        }


        //public List<StudentInfo> viewStudentInfo() { 
        //    connection.Open();
        // SqlDataAdapter sdaObj=new SqlDataAdapter("select * from tbl_student",connection);
        //    DataTable tb=new DataTable();
        //    sdaObj.Fill(tb);




        public List<StudentInfo> viewStudentInfo()
        {
            //part1:connection 


            connection.Open();

            //part 2:command
            string selectQuery = "select * from tbl_student";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<StudentInfo> students = new List<StudentInfo>();

            while (reader.Read())
            {
                object id = reader[0];
                object name = reader[1];
                object f_name = reader[2];
                object m_name = reader[3];
                object s_address = reader[4];
                object s_phone = reader[5];
                object s_email = reader[6];
                object s_dept = reader[7];
                object s_roll = reader[8];
                object s_cgpa = reader[9];
                object s_session = reader[10];
                object s_blood = reader[11];

                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

                StudentInfo student = new StudentInfo()
                {
                    st_Id = (int) id,
                    st_Name = name.ToString(),
                    st_FatherName = f_name.ToString(),
                    st_MotherName = m_name.ToString(),
                    st_Address = s_address.ToString(),
                    st_Phone = s_phone.ToString(),
                    st_Email = s_email.ToString(),
                    st_Dept = s_dept.ToString(),
                    st_Roll = s_roll.ToString(),
                    st_Cgpa = (decimal) s_cgpa,
                    st_Session = s_session.ToString(),
                    st_Blood = s_blood.ToString()
                };
                students.Add(student);

                
            }
            connection.Close();
            return students;
        }
        
        public void updateStudentInfo(StudentInfo stObj)
        {
            connection.Open();
            SqlDataAdapter sdaob =
                new SqlDataAdapter(
                    "update tbl_student set stu_name='" + stObj.st_Name + "',stu_father_name='" + stObj.st_FatherName +
                    "',stu_mother_name='" + stObj.st_MotherName + "', stu_address='" + stObj.st_Address +
                    "',stu_phone='" + stObj.st_Phone + "',stu_email='" + stObj.st_Email + "',stu_dept='" + stObj.st_Dept +
                    "',stu_roll='" + stObj.st_Roll + "',stu_CGPA='" + stObj.st_Cgpa + "',stu_session='" +
                    stObj.st_Session + "',stu_blood='" + stObj.st_Blood + "' where stu_id=" + stObj.st_Id + "",
                    connection);
            sdaob.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("update successfully.");
        }

        public void deleteStudentInfo(StudentInfo stObj)
        {
            connection.Open();
            SqlDataAdapter sdaob = new SqlDataAdapter("delete from tbl_student where stu_id=" + stObj.st_Id + "",
                connection);
            sdaob.SelectCommand.ExecuteNonQuery();
           
            connection.Close();
            //updateAvailableSeat(stObj);
           

        }

        //public void deleteStudentIn()
        //{

        //    connection.Open();


        //    string selectQuery = "select min(stu_id) from tbl_student";
        //    SqlCommand command = new SqlCommand(selectQuery, connection);



        //    SqlDataReader reader = command.ExecuteReader();

        //    List<StudentInfo> students = new List<StudentInfo>();
        //    StudentInfo stud = new StudentInfo();
        //    while (reader.Read())
        //    {
        //        object id = reader[0];


        //        stud.st_Id= (int)id;
        //        //stud.name = name.ToString();
        //        //stud.department = department.ToString();

        //        //StudentInfo student = new StudentInfo()
        //        //{
        //        //    st_Id = (int)id,

        //        //};




        //    }
        //   connection.Close();
        //    deleteStudentInfo(stud);
        //}


        public List<StudentInfo> searchByBloodGroup(StudentInfo stObj)
        {


            connection.Open();

            //part 2:command
            string selectQuery = "select * from tbl_student where stu_blood='" + stObj.st_Blood + "'";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<StudentInfo> students = new List<StudentInfo>();

            while (reader.Read())
            {
                object id = reader[0];
                object name = reader[1];
                object f_name = reader[2];
                object m_name = reader[3];
                object s_address = reader[4];
                object s_phone = reader[5];
                object s_email = reader[6];
                object s_dept = reader[7];
                object s_roll = reader[8];
                object s_cgpa = reader[9];
                object s_session = reader[10];
                object s_blood = reader[11];

                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

                StudentInfo student = new StudentInfo()
                {
                    st_Id = (int) id,
                    st_Name = name.ToString(),
                    st_FatherName = f_name.ToString(),
                    st_MotherName = m_name.ToString(),
                    st_Address = s_address.ToString(),
                    st_Phone = s_phone.ToString(),
                    st_Email = s_email.ToString(),
                    st_Dept = s_dept.ToString(),
                    st_Roll = s_roll.ToString(),
                    st_Cgpa = (decimal) s_cgpa,
                    st_Session = s_session.ToString(),
                    st_Blood = s_blood.ToString()
                };
                students.Add(student);


            }
            connection.Close();
            return students;
        }





        public List<StudentInfo> searchByRoll(StudentInfo stObj)
        {


            connection.Open();

            //part 2:command
            string selectQuery = "select * from tbl_student where stu_roll='" + stObj.st_Roll + "'";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<StudentInfo> students = new List<StudentInfo>();

            while (reader.Read())
            {
                object id = reader[0];
                object name = reader[1];
                object f_name = reader[2];
                object m_name = reader[3];
                object s_address = reader[4];
                object s_phone = reader[5];
                object s_email = reader[6];
                object s_dept = reader[7];
                object s_roll = reader[8];
                object s_cgpa = reader[9];
                object s_session = reader[10];
                object s_blood = reader[11];

                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

                StudentInfo student = new StudentInfo()
                {
                    st_Id = (int) id,
                    st_Name = name.ToString(),
                    st_FatherName = f_name.ToString(),
                    st_MotherName = m_name.ToString(),
                    st_Address = s_address.ToString(),
                    st_Phone = s_phone.ToString(),
                    st_Email = s_email.ToString(),
                    st_Dept = s_dept.ToString(),
                    st_Roll = s_roll.ToString(),
                    st_Cgpa = (decimal) s_cgpa,
                    st_Session = s_session.ToString(),
                    st_Blood = s_blood.ToString()
                };
                students.Add(student);


            }
            connection.Close();
            return students;
        }


        //private int roomNO = 0;
        public void updateRoomavailableSeat(StudentInfo obj)
        {
            connection.Open();

            

            string selectQuery =
                "select * from tbl_student inner join tbl_allot on tbl_student.stu_id=tbl_allot.stu_id where tbl_allot.stu_id='" + obj.st_Id + "'";
            SqlCommand command = new SqlCommand(selectQuery, connection);
           

            SqlDataReader reader = command.ExecuteReader();

            AllotmentInfo ob=new AllotmentInfo();
            ob.aRoom_No = null;
            //List<AllotmentInfo> students = new List<AllotmentInfo>();

            while (reader.Read())
            {
                //object id = reader[0];
                //object name = reader[1];
                //object f_name = reader[2];
                //object m_name = reader[3];
                //object s_address = reader[4];
                //object s_phone = reader[5];
                //object s_email = reader[6];
                //object s_dept = reader[7];
                //object s_roll = reader[8];
                //object s_cgpa = reader[9];
                //object s_session = reader[10];
                //object s_blood = reader[11];
                //object a_id = reader[12];
                object room_id = reader[13];
                //object s_id = reader[14];
                //object inDate = reader[15];
                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

                AllotmentInfo student = new AllotmentInfo()
                {
                    //ast_Id = (int)id,
                    //ast_Name = name.ToString(),
                    //ast_FatherName = f_name.ToString(),
                    //ast_MotherName = m_name.ToString(),
                    //ast_Address = s_address.ToString(),
                    //ast_Phone = s_phone.ToString(),
                    //ast_Email = s_email.ToString(),
                    //ast_Dept = s_dept.ToString(),
                    //ast_Roll = s_roll.ToString(),
                    //ast_Cgpa = (decimal)s_cgpa,
                    //ast_Session = s_session.ToString(),
                    //ast_Blood = s_blood.ToString(),
                    //allot_Id = a_id.ToString(),
                    aRoom_No = room_id.ToString(),
                    //astudentId = s_id.ToString(),
                    //aInDate = inDate.ToString()
                };
                //students.Add(student);
                ob.aRoom_No = student.aRoom_No;

            }
            connection.Close();



            if (ob.aRoom_No != null)
            {
                AllotmentInfoDataAccess dObj = new AllotmentInfoDataAccess();
                dObj.updateAvailableSeat(ob);
            }

        }

        public int haveAnyStuId(StudentInfo stObj)
        {
            connection.Open();
            SqlDataAdapter sdaObj = new SqlDataAdapter("select * from tbl_student where stu_id=" + stObj.st_Id + "", connection);
            DataTable dtObj = new DataTable();
            sdaObj.Fill(dtObj);
            int i = dtObj.Rows.Count;
            connection.Close();
            return i;

        }


        }



    }

                   
        
    

