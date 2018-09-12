using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.Domain;

namespace HallManagement1.DataAccess
{
    class NewAllotDataAccess
    {  


        private SqlConnection connection;

        public NewAllotDataAccess()
        {
            string server = @".\SQLEXPRESS";
            string database = "hallmanagement";

            string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
                database);


            connection = new SqlConnection(connectionString);


        }

        public List<StudentInfo> viewNotAllotStudentInfo()
        {
            //part1:connection 


            connection.Open();

            //part 2:command
            //string selectQuery = "select * from tbl_student inner join tbl_allot  on tbl_student.stu_id!=tbl_allot.student_id order by tbl_student.stu_CGPA desc";
           
            string selectQuery =
                "select * from tbl_student left join tbl_allot on tbl_student.stu_id=tbl_allot.stu_id  where tbl_allot.stu_id is null order by tbl_student.stu_CGPA desc";
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
                    st_Id = (int)id,
                    st_Name = name.ToString(),
                    st_FatherName = f_name.ToString(),
                    st_MotherName = m_name.ToString(),
                    st_Address = s_address.ToString(),
                    st_Phone = s_phone.ToString(),
                    st_Email = s_email.ToString(),
                    st_Dept = s_dept.ToString(),
                    st_Roll = s_roll.ToString(),
                    st_Cgpa = (decimal)s_cgpa,
                    st_Session = s_session.ToString(),
                    st_Blood = s_blood.ToString()
                };
                students.Add(student);


            }
            connection.Close();
            return students;
        }


        public List<RoomInfo> viewRoomNotFillUpInfo()
        {
            //part1:connection 


            connection.Open();

            //part 2:command
            string selectQuery = "select * from tbl_roomEntry where available_seat>0";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<RoomInfo> rooms = new List<RoomInfo>();

            while (reader.Read())
            {
                object roomNO = reader[0];
                object blockNo = reader[1];
                object floorNo = reader[2];
                object availableSeat = reader[3];




                RoomInfo room = new RoomInfo()
                {
                    rm_No = (int)roomNO,
                    block_No = blockNo.ToString(),
                    floor_No = floorNo.ToString(),
                    available_Seat = (int)availableSeat
                };
                rooms.Add(room);


            }
            connection.Close();
            return rooms;
        }


        public void saveAllotment(NewAllotInfo aObj)
        {

            connection.Open();
            SqlDataAdapter sda =
                new SqlDataAdapter(
                    "insert into tbl_allot(allot_room_no,stu_id,in_date) values("+aObj.allot_room_no +"," + aObj.allot_student_id + ",'" + aObj.inDate+ "')", connection);

            sda.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("save successfully");


        }

        public void updateAvailableSeatInfo(NewAllotInfo aObj)
        {
            connection.Open();
            SqlDataAdapter sdaob = new SqlDataAdapter("update tbl_roomEntry set available_seat=" + (aObj.availabe_seat-1) + " where room_no="+aObj.allot_room_no+"", connection);
            sdaob.SelectCommand.ExecuteNonQuery();
            connection.Close();
            //MessageBox.Show("update successfully.");
        }

    }
}
