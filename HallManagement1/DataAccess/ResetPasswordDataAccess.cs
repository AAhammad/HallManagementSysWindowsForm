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
    class ResetPasswordDataAccess
    {
        private SqlConnection connection;
        public ResetPasswordDataAccess()
       {
           string server = ".\\SQLEXPRESS";
           string database = "hallmanagement";
     
           string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
               database);


            connection = new SqlConnection(connectionString);

           
       }

        public int haveAnyUserIdReset(UserLogin userObj)
        {
            connection.Open();
            SqlDataAdapter sdaObj = new SqlDataAdapter("select * from tbl_login where username='" + userObj.username + "' and password='" + userObj.userpassword + "'", connection);
            DataTable dtObj = new DataTable();
            sdaObj.Fill(dtObj);
            int i = dtObj.Rows.Count;
            connection.Close();
            return i;

        }

        //public int resetPassword(UserLogin userObjj)
        //{
        //    LoginDataAccess obj=new LoginDataAccess();
        //    int j=obj.haveAnyUserId(userObjj);
        //    int t = updatePassword(userObjj, j);
        //    return t;
        //}

        public int  updtpassword(UserLogin user)
        {
            int j = haveAnyUserIdReset(user);

            int ret = 0;
            if (j == 1)
            {

                connection.Open();
                SqlDataAdapter sdaob=new SqlDataAdapter("update tbl_login set password='"+user.resetNewPassword+"' where password='"+user.userpassword+"'and username='"+user.username+"'",connection);
               ret= sdaob.SelectCommand.ExecuteNonQuery();
                connection.Close();
              
                //string query = string.Format("update tbl_login set password ='{0}' where password='{1}'", user.resetNewpassword, user.userpassword);


                //SqlCommand command = new SqlCommand(query, connection);

                ////part3:execution

                //ret = command.ExecuteNonQuery();
                //connection.Close();
                //MessageBox.Show(ret.ToString());


            }
            return ret;
           

          


        }
        }
    }

