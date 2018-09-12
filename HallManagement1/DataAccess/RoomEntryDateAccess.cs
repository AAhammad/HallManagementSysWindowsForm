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
    class RoomEntryDateAccess
    {
         private SqlConnection connection;

        public RoomEntryDateAccess()
        {
            string server = @"ALI\SQLEXPRESS";
            string database = "hallmanagement";

            string connectionString = string.Format("server={0};database={1};Integrated security=true;", server,
                database);


            connection = new SqlConnection(connectionString);


        }

        public int roomAdd(RoomInfo rmObj)
        {

            connection.Open();
            SqlDataAdapter sda =
                new SqlDataAdapter(
                    "insert into tbl_roomEntry(room_no,block_no,floor_no,available_seat) values(" +
                    rmObj.rm_No + ",'" + rmObj.block_No + "','" + rmObj.floor_No + "'," + rmObj.available_Seat+")", connection);

           int i= sda.SelectCommand.ExecuteNonQuery();
            connection.Close();
            return i;

        }


        public List<RoomInfo> viewRoomInfo()
        {
            //part1:connection 


            connection.Open();

            //part 2:command
            string selectQuery = "select * from tbl_roomEntry";
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
                   available_Seat = (int) availableSeat
                };
                rooms.Add(room);


            }
            connection.Close();
            return rooms;
        }

        public void updateRoomInfo(RoomInfo rmObj)
        {
            connection.Open();
            SqlDataAdapter sdaob = new SqlDataAdapter("update tbl_roomEntry set block_no='" + rmObj.block_No + "',floor_no='" + rmObj.floor_No + "', available_seat='" + rmObj.available_Seat + "' where room_no=" +rmObj.rm_No+ "", connection);
            sdaob.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("update successfully.");
        }


        public void deleteRoomInfo(RoomInfo rmObj)
        {
            connection.Open();
            SqlDataAdapter sdaob = new SqlDataAdapter("delete from tbl_roomEntry where room_no=" + rmObj.rm_No + "", connection);
            sdaob.SelectCommand.ExecuteNonQuery();

            connection.Close();

        }



        public int haveAnyRoomNO(RoomInfo rmObj)
        {
            connection.Open();
            SqlDataAdapter sdaObj = new SqlDataAdapter("select * from tbl_roomEntry where room_no=" + rmObj.rm_No + "", connection);
            DataTable dtObj = new DataTable();
            sdaObj.Fill(dtObj);
            int i = dtObj.Rows.Count;
            connection.Close();
            return i;

        }
        public List<RoomInfo> viewRoomInfoSearch(RoomInfo rmOb)
        {
            //part1:connection 


            connection.Open();

            //part 2:command
            string selectQuery = "select * from tbl_roomEntry  where room_no=" + rmOb.rm_No + "";
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



    }
}
