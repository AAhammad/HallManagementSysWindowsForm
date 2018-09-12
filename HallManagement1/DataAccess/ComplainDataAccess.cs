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
    
    class ComplainDataAccess
    {
        private SqlConnection connection;

        public ComplainDataAccess()
        {
            string server = ".\\SQLEXPRESS";
            string database = "hallmanagement";

            string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
                database);


            connection = new SqlConnection(connectionString);
        }


        public void saveComplain(ComplainInfo obj)
        {
            connection.Open();
            SqlDataAdapter sda =
                new SqlDataAdapter(
                    "insert into tbl_complain(C_name,C_allot_id,C_roll,C_mobile,C_date,Complain) values('" +
                    obj.cName + "'," + obj.cAllot_id +",'" + obj.cRoll + "','" + obj.cMb + "','" + obj.cDate +
                    "','" + obj.complain + "')", connection);

            sda.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("save successfully");

        }


        public int nameRollChek(ComplainInfo obj)
        {
            


            //connection.Open();

            ////part 2:command
            ////string selectQuery = "select * from tbl_student inner join tbl_allot  on tbl_student.stu_id!=tbl_allot.student_id order by tbl_student.stu_CGPA desc";

            //string selectQuery =
            //    "select * from tbl_student inner join tbl_allot on tbl_student.stu_id=tbl_allot.student_id where stu_name='" + obj.cName + "'and stu_roll='"+obj.cRoll+"'";
            //SqlCommand command = new SqlCommand(selectQuery, connection);
            //int i = command.ExecuteNonQuery();
            //connection.Open();
            //SqlDataAdapter sdaObj1 = new SqlDataAdapter(" select * from tbl_allot inner join tbl_complain on tbl_allot.allot_id=tbl_complain.allot_id where C_allot_id='" + obj.cAllot_id + "'", connection);
            //DataTable dtObj1 = new DataTable();
            //sdaObj1.Fill(dtObj1);
            //int j = dtObj1.Rows.Count;

            //connection.Close();
            //return i;
            //if (j > 0)
            //{
                connection.Open();
                SqlDataAdapter sdaObj =
                    new SqlDataAdapter(
                        " select * from tbl_student inner join tbl_allot on tbl_student.stu_id=tbl_allot.stu_id where allot_id='"+obj.cAllot_id+"'and(stu_name='" +
                        obj.cName + "'and stu_roll='" + obj.cRoll + "')", connection);
                DataTable dtObj = new DataTable();
                sdaObj.Fill(dtObj);
                int i = dtObj.Rows.Count;

                connection.Close();
                return i;
            //}
            //else
            //{
            //    return j;
            //}
        }


        public List<ComplainInfo> viewComplain()
        {


            connection.Open();

            //part 2:command
            //string selectQuery = "select * from tbl_student inner join tbl_allot  on tbl_student.stu_id!=tbl_allot.student_id order by tbl_student.stu_CGPA desc";

            string selectQuery =
                "select * from tbl_complain ";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            //part 3:execution

            SqlDataReader reader = command.ExecuteReader();

            List<ComplainInfo> complains = new List<ComplainInfo>();

            while (reader.Read())
            {
                object id = reader[0];
                object a_id = reader[1];
                object name = reader[2];
                object roll = reader[3];
                object mbNo = reader[4];
                object date = reader[5];
                object compla = reader[6];
               
                //Student stud = new Student();
                //stud.id = (int)id;
                //stud.name = name.ToString();
                //stud.department = department.ToString();

               ComplainInfo com = new ComplainInfo()
                {
                    cId = (int)id,
                    cName = name.ToString(),
                    cAllot_id = (int) a_id,
                    cRoll = roll.ToString(),
                    cMb = mbNo.ToString(),
                    cDate = date.ToString(),
                    complain = compla.ToString(),
                    
                };
               complains.Add(com);


            }
            connection.Close();
            return complains;
        }


        public void deleteComplain(ComplainInfo ob)
        {

            connection.Open();
            SqlDataAdapter sdaob = new SqlDataAdapter("delete  from tbl_complain where C_id=" + ob.cId+ "", connection);
            sdaob.SelectCommand.ExecuteNonQuery();

            connection.Close();
        }


    }
}
