using System.Data.SqlClient;
using HallManagement1.Domain;

namespace HallManagement1.DataAccess
{
     public class CreateAccountDataAccess
    {
     private SqlConnection connection;
       public CreateAccountDataAccess()
       {
           string server = ".\\SQLEXPRESS";
           string database = "hallmanagement";
     
           string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
               database);


            connection = new SqlConnection(connectionString);

           
       }
       //public List<Student> GetAll()
       //{
       //    //part1:connection 
          

       //    connection.Open();

       //    //part 2:command
       //    string selectQuery = "select * from tbl_student";
       //    SqlCommand command = new SqlCommand(selectQuery, connection);

       //    //part 3:execution

       //    SqlDataReader reader = command.ExecuteReader();

       //    List<Student> students = new List<Student>();

       //    while (reader.Read())
       //    {
       //        object id = reader[0];
       //        object name = reader[1];
       //        object department = reader[2];

       //        //Student stud = new Student();
       //        //stud.id = (int)id;
       //        //stud.name = name.ToString();
       //        //stud.department = department.ToString();

       //        Student student = new Student
       //        {
       //            id = (int)id,
       //            name = name.ToString(),
       //            department = department.ToString()
       //        };
       //        students.Add(student);
              

       //    }
       //    connection.Close();
       //    return students;
       //}

        

       public int saveAccount(UserLogin user)
       {
          

           connection.Open();


          string query = string.Format("insert into tbl_login values('{0}','{1}')", user.username, user.userpassword);


           SqlCommand command = new SqlCommand(query, connection);

           //part3:execution

           int i = command.ExecuteNonQuery();
           connection.Close();
           return i;
       }
    }
    }

