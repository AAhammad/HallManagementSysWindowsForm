using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.checking
{
    class RoomEntryCheck
    {

        public void entryButtonCheck(RoomInfo rmObj)
        {

            if (rmObj.rm_No== -1 || rmObj.block_No == "" || rmObj.floor_No == "" || rmObj.available_Seat == -1)
            {
                MessageBox.Show("please fill up all properties successfully !!!");
            }
            //else if (rmObj.rm_No < 0 )
            //{
            //    MessageBox.Show("room number should be positive !!!");
            //}
            ////else if (rmObj.floor_No < 0)
            ////{
            ////    MessageBox.Show("room number should be positive !!!");
            ////}
            //else if (rmObj.available_Seat<0)
            //{
            //    MessageBox.Show("available seat should be positive !!!");
            //}
            else
            {

               
               RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();

                int i = dataAccess.haveAnyRoomNO(rmObj);
                if (i == 0)
                {

                    RoomEntryDateAccess obj = new RoomEntryDateAccess();
                    int j = obj.roomAdd(rmObj);

                    string Message = j > 0 ? "create successfully" : "data not saved";
                    MessageBox.Show(Message);

                }
                else
                {
                    MessageBox.Show("there is exit another account has same room no !!!\n\t please try again.");

                }
            }


        }


        public void updateButtonCheck(RoomInfo rmObj)
        {
            if (rmObj.rm_No ==-1 || rmObj.block_No == "" || rmObj.floor_No == "" || rmObj.available_Seat ==-1)
            {
                MessageBox.Show("please fill up all properties successfully !!!");
            }

            else if (rmObj.rm_No < 0)
            {
                MessageBox.Show("room number should be positive !!!");
            }
            else if (rmObj.available_Seat < 0)
            {
                MessageBox.Show("available seat should be positive !!!");
            }
            else
            {
                RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();

                int i = dataAccess.haveAnyRoomNO(rmObj);
                if (i == 1)
                {

                    RoomEntryDateAccess obj = new RoomEntryDateAccess();
                    obj.updateRoomInfo(rmObj);

                }
                else
                {
                    MessageBox.Show("there is exit no room of "+rmObj.rm_No+"  !!!\n  please try again.");

                }

               

            }



        }

        public List<RoomInfo> RoomSearchCheck(RoomInfo rmObj)
        {
            List<RoomInfo> rooms;
            if (rmObj.rm_No == -1 )
            {
                MessageBox.Show("please fill up \"Room No\" property successfully !!!");
                rooms = null;
            }
           
            else
            {


                RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();
                rooms=dataAccess.viewRoomInfoSearch(rmObj);

            }

            return rooms;

        }
    }
}
