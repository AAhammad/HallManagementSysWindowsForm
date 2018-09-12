using System.Data;
using System.Data.SqlClient;
using HallManagement1.Domain;

namespace HallManagement1.DataAccess
{
    class LoginDataAccess
    {
        private SqlConnection connection;
       public LoginDataAccess()
       {
           string server = @".\SQLEXPRESS";
           string database = "hallmanagement";
     
           string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
               database);


            connection = new SqlConnection(connectionString);

           
       }

        public int haveAnyUserId(UserLogin userObj)
        {
            connection.Open();
            SqlDataAdapter sdaObj=new SqlDataAdapter("select * from tbl_login where username='"+userObj.username+"' and password='"+userObj.userpassword +"'",connection);
            DataTable  dtObj=new DataTable();
            sdaObj.Fill(dtObj);
            int i = dtObj.Rows.Count;
            connection.Close();
            return i;

        }
    }
}
