using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.Domain;

namespace HallManagement1.DataAccess
{
    class AllotmentInfoDataAccess
    {
        
        private SqlConnection connection;

        public AllotmentInfoDataAccess()
        {
            string server = ".\\SQLEXPRESS";
            string database = "hallmanagement";

            string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
                database);


            connection = new SqlConnection(connectionString);


        }
        public List<AllotmentInfo> viewAllotStudentInfo()
        {



            connection.Open();

            //part 2:command
            //string selectQuery = "select * from tbl_student inner join tbl_allot  on tbl_student.stu_id!=tbl_allot.student_id order by tbl_student.stu_CGPA desc";

            string selectQuery =
                "select * from tbl_student inner join tbl_allot on tbl_student.stu_id=tbl_allot.stu_id  ";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            //part 3:execution
            //int a = command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            
            List<AllotmentInfo> students = new List<AllotmentInfo>();

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
                object a_id = reader[12];
                object room_id = reader[13];
                object s_id = reader[14];
                object inDate = reader[15];
                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

               AllotmentInfo student = new AllotmentInfo()
                {
                    ast_Id = (int)id,
                    ast_Name = name.ToString(),
                    ast_FatherName = f_name.ToString(),
                    ast_MotherName = m_name.ToString(),
                    ast_Address = s_address.ToString(),
                    ast_Phone = s_phone.ToString(),
                    ast_Email = s_email.ToString(),
                    ast_Dept = s_dept.ToString(),
                    ast_Roll = s_roll.ToString(),
                    ast_Cgpa = (decimal)s_cgpa,
                    ast_Session = s_session.ToString(),
                    ast_Blood = s_blood.ToString(),
                    allot_Id = a_id.ToString(),
                    aRoom_No = room_id.ToString(),
                    astudentId = s_id.ToString(),
                    aInDate = inDate.ToString()
                };
                students.Add(student);


            }
            //connection.Close();
            //if (a == 0) { return null;}
          
            
                return students;
            
          


            //connection.Open();
            //SqlDataAdapter sdaObj = new SqlDataAdapter("select * from tbl_student left join tbl_allot on tbl_student.stu_id=tbl_allot.student_id ", connection);
            //DataTable tb = new DataTable();
            //sdaObj.Fill(tb);
            //return tb;
            ////AllotedStudentDataGridView.DataSource = tb;

        }


        public List<AllotmentInfo> searchByAllotId(AllotmentInfo ob)
        {
            

            connection.Open();

            //part 2:command
            //string selectQuery = "select * from tbl_student inner join tbl_allot  on tbl_student.stu_id!=tbl_allot.student_id order by tbl_student.stu_CGPA desc";

            string selectQuery =
                "select * from tbl_student inner join tbl_allot on tbl_student.stu_id=tbl_allot.stu_id where allot_id="+ob.allot_Id+"";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<AllotmentInfo> students = new List<AllotmentInfo>();

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
                object a_id = reader[12];
                object room_id = reader[13];
                object s_id = reader[14];
                object inDate = reader[15];
                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

               AllotmentInfo student = new AllotmentInfo()
                {
                    ast_Id = (int)id,
                    ast_Name = name.ToString(),
                    ast_FatherName = f_name.ToString(),
                    ast_MotherName = m_name.ToString(),
                    ast_Address = s_address.ToString(),
                    ast_Phone = s_phone.ToString(),
                    ast_Email = s_email.ToString(),
                    ast_Dept = s_dept.ToString(),
                    ast_Roll = s_roll.ToString(),
                    ast_Cgpa = (decimal)s_cgpa,
                    ast_Session = s_session.ToString(),
                    ast_Blood = s_blood.ToString(),
                    allot_Id = a_id.ToString(),
                    aRoom_No = room_id.ToString(),
                    astudentId = s_id.ToString(),
                    aInDate = inDate.ToString()
                };
                students.Add(student);


            }
            connection.Close();
            return students;
        }

        public List<AllotmentInfo> searchByName(AllotmentInfo ob)
        {


            connection.Open();

            //part 2:command
            //string selectQuery = "select * from tbl_student inner join tbl_allot  on tbl_student.stu_id!=tbl_allot.student_id order by tbl_student.stu_CGPA desc";

            string selectQuery =
                "select * from tbl_student inner join tbl_allot on tbl_student.stu_id=tbl_allot.stu_id where stu_name='" + ob.ast_Name + "'";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<AllotmentInfo> students = new List<AllotmentInfo>();

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
                object a_id = reader[12];
                object room_id = reader[13];
                object s_id = reader[14];
                object inDate = reader[15];
                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

                AllotmentInfo student = new AllotmentInfo()
                {
                    ast_Id = (int)id,
                    ast_Name = name.ToString(),
                    ast_FatherName = f_name.ToString(),
                    ast_MotherName = m_name.ToString(),
                    ast_Address = s_address.ToString(),
                    ast_Phone = s_phone.ToString(),
                    ast_Email = s_email.ToString(),
                    ast_Dept = s_dept.ToString(),
                    ast_Roll = s_roll.ToString(),
                    ast_Cgpa = (decimal)s_cgpa,
                    ast_Session = s_session.ToString(),
                    ast_Blood = s_blood.ToString(),
                    allot_Id = a_id.ToString(),
                    aRoom_No = room_id.ToString(),
                    astudentId = s_id.ToString(),
                    aInDate = inDate.ToString()
                };
                students.Add(student);


            }
            connection.Close();
            return students;
        }


        public List<AllotmentInfo> searchByRoll(AllotmentInfo ob)
        {


            connection.Open();

            //part 2:command
            //string selectQuery = "select * from tbl_student inner join tbl_allot  on tbl_student.stu_id!=tbl_allot.student_id order by tbl_student.stu_CGPA desc";

            string selectQuery =
                "select * from tbl_student inner join tbl_allot on tbl_student.stu_id=tbl_allot.stu_id where stu_roll='" + ob.ast_Roll + "'";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<AllotmentInfo> students = new List<AllotmentInfo>();

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
                object a_id = reader[12];
                object room_id = reader[13];
                object s_id = reader[14];
                object inDate = reader[15];
                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

                AllotmentInfo student = new AllotmentInfo()
                {
                    ast_Id = (int)id,
                    ast_Name = name.ToString(),
                    ast_FatherName = f_name.ToString(),
                    ast_MotherName = m_name.ToString(),
                    ast_Address = s_address.ToString(),
                    ast_Phone = s_phone.ToString(),
                    ast_Email = s_email.ToString(),
                    ast_Dept = s_dept.ToString(),
                    ast_Roll = s_roll.ToString(),
                    ast_Cgpa = (decimal)s_cgpa,
                    ast_Session = s_session.ToString(),
                    ast_Blood = s_blood.ToString(),
                    allot_Id = a_id.ToString(),
                    aRoom_No = room_id.ToString(),
                    astudentId = s_id.ToString(),
                    aInDate = inDate.ToString()
                };
                students.Add(student);


            }
            connection.Close();
            return students;
        }

        public void deleteInfo(AllotmentInfo obj)
        {
            connection.Open();
            SqlDataAdapter sdaob = new SqlDataAdapter("delete  from tbl_allot where allot_id=" + obj.allot_Id + "", connection);
            sdaob.SelectCommand.ExecuteNonQuery();

            connection.Close();
            //MessageBox.Show("delete successfully.");
        }

        private int avSeat = 9696;
        public void updateAvailableSeat(AllotmentInfo aObj)
        {

           

            //if ()
            //{
            //    MessageBox.Show("not allow.");
            //}

            //else
            //{



                connection.Open();

                //part 2:command
                string selectQuery = "select * from tbl_roomEntry where room_no=" + aObj.aRoom_No+ "";
                SqlCommand command = new SqlCommand(selectQuery, connection);

                //part 3:execution

                SqlDataReader reader = command.ExecuteReader();

                //List<RoomInfo> rooms = new List<RoomInfo>();



                while (reader.Read())
                {
                    //object roomNO = reader[0];
                    //object blockNo = reader[1];
                    //object floorNo = reader[2];
                    object availableSeat = reader[3];




                    RoomInfo room = new RoomInfo()
                    {
                        // rm_No = (int)roomNO,
                        //block_No = blockNo.ToString(),
                        //floor_No = floorNo.ToString(),
                        available_Seat = (int)availableSeat
                    };

                     avSeat = room.available_Seat;
                }
            
            connection.Close();

            if ( avSeat== 9696)
            {
                MessageBox.Show("not allow.");
            }

            else
            {
                connection.Open();
                SqlDataAdapter sdaob =
                    new SqlDataAdapter(
                        "update tbl_roomEntry set  available_seat='" + (avSeat + 1) + "' where room_no=" + aObj.aRoom_No + "",
                        connection);
                sdaob.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("update successfully.");
            }
        }
    }
}
