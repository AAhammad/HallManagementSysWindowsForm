using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class RoomEntryUI : Form
    {
        public RoomEntryUI()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //deleteIdtextBox.Text = "";
            this.Close();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            //deleteIdtextBox.Text = "";

            RoomInfo rmObj = new RoomInfo()
            {
               
               block_No = blockNoTextBox.Text,
               floor_No = floorNoTextBox.Text



            };
            if (roomNoTextBox.Text == "" || availableSeatTextBox.Text=="")
            {
                rmObj.rm_No = -1;
                rmObj.available_Seat = -1;
            }

            else 
            {
                rmObj.rm_No = Convert.ToInt32(roomNoTextBox.Text);
                rmObj.available_Seat = Convert.ToInt32(availableSeatTextBox.Text);

            }

     
            RoomEntryCheck obj = new RoomEntryCheck();
            obj.entryButtonCheck(rmObj);

            deleteRoomTextBox.Text = "";

            RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();
            List<RoomInfo> rooms = dataAccess.viewRoomInfo();
            roomEntryDataGridView.AutoGenerateColumns = false;
            roomEntryDataGridView.DataSource = rooms;
        }

        

       public void viewButton_Click(object sender, EventArgs e)
        {
            deleteRoomTextBox.Text = "";
          


            RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();
            List<RoomInfo> rooms = dataAccess.viewRoomInfo();
            roomEntryDataGridView.AutoGenerateColumns = false;
            roomEntryDataGridView.DataSource = rooms;
            roomEntryDataGridView.Columns[0].DataPropertyName = "rm_No";
            roomEntryDataGridView.Columns[1].DataPropertyName = "block_No";
            roomEntryDataGridView.Columns[2].DataPropertyName = "floor_No";
            roomEntryDataGridView.Columns[3].DataPropertyName = "available_Seat";
            
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
          
            deleteRoomTextBox.Text = "";

              RoomInfo rmObj = new RoomInfo()
            {
               
               block_No = blockNoTextBox.Text,
               floor_No = floorNoTextBox.Text



            };
            if (roomNoTextBox.Text == "" || availableSeatTextBox.Text=="")
            {
                rmObj.rm_No = -1;
                rmObj.available_Seat = -1;
            }
            else
            {
                rmObj.rm_No = Convert.ToInt32(roomNoTextBox.Text);
                rmObj.available_Seat = Convert.ToInt32(availableSeatTextBox.Text);

            }

            RoomEntryCheck obj = new RoomEntryCheck();
            obj.updateButtonCheck(rmObj);


            deleteRoomTextBox.Text = "";

            RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();
            List<RoomInfo> rooms = dataAccess.viewRoomInfo();
            roomEntryDataGridView.AutoGenerateColumns = false;
            roomEntryDataGridView.DataSource = rooms;
            //roomNoTextBox.ReadOnly = false;

        }

        private void roomEntryDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deleteRoomTextBox.Text = "";


            roomNoTextBox.Text = roomEntryDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            blockNoTextBox.Text = roomEntryDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            floorNoTextBox.Text =roomEntryDataGridView.SelectedRows[0].Cells[2].Value.ToString();
           availableSeatTextBox.Text = roomEntryDataGridView.SelectedRows[0].Cells[3].Value.ToString();

           //roomNoTextBox.ReadOnly = true;

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            deleteRoomTextBox.Text = "";

            roomNoTextBox.Clear();
            blockNoTextBox.Clear();
            floorNoTextBox.Clear();
            availableSeatTextBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
              if (deleteRoomTextBox.Text =="")
            {
                MessageBox.Show("please click on the row.");
            }

            else  {
                RoomInfo rmObj = new RoomInfo()
                {



                   rm_No = Convert.ToInt32(deleteRoomTextBox.Text),



                };

                DialogResult dr = MessageBox.Show("Are you want to delete Room no:" + rmObj.rm_No, "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    RoomEntryDateAccess ob = new RoomEntryDateAccess();
                    ob.deleteRoomInfo(rmObj);
                   deleteRoomTextBox.Text = "";
                    MessageBox.Show("deleted ");
                    deleteRoomTextBox.Text = "";

                    RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();
                    List<RoomInfo> rooms = dataAccess.viewRoomInfo();
                    roomEntryDataGridView.AutoGenerateColumns = false;
                    roomEntryDataGridView.DataSource = rooms;
                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("not deleted.");
                }

            }

        }

        private void roomEntryDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteRoomTextBox.Text = "";
        }

        private void roomEntryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
                deleteRoomTextBox.Text = roomEntryDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            
               
        }

        private void roomEntryDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteRoomTextBox.Text = "";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            deleteRoomTextBox.Text = "";

            RoomEntryDateAccess dataAccess = new RoomEntryDateAccess();
            List<RoomInfo> rooms = dataAccess.viewRoomInfo();
            roomEntryDataGridView.AutoGenerateColumns = false;
            roomEntryDataGridView.DataSource = rooms;

        }

        private void roomNoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(roomNoTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                roomNoTextBox.Text.Remove(roomNoTextBox.TextLength - 1);
                roomNoTextBox.Clear();
            }
        }

        private void availableSeatTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(availableSeatTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                availableSeatTextBox.Text.Remove(availableSeatTextBox.TextLength - 1);
                availableSeatTextBox.Clear();
            }
        }

        private void floorNoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(floorNoTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                floorNoTextBox.Text.Remove(floorNoTextBox.TextLength - 1);
                floorNoTextBox.Clear();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            deleteRoomTextBox.Text = "";



            RoomInfo Obj = new RoomInfo();

            if (roomNoTextBox.Text == "" )
            {
                Obj.rm_No = -1;
               
            }

            else
            {
                Obj.rm_No = Convert.ToInt32(roomNoTextBox.Text);
               

            }
           RoomEntryCheck dataAccess = new RoomEntryCheck();
           List<RoomInfo> rooms = dataAccess.RoomSearchCheck(Obj);
            roomEntryDataGridView.DataSource =rooms;
        }

      

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void RoomEntryUI_Load(object sender, EventArgs e)
        {

        }

       
    }
        }

   

