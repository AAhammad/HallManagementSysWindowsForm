using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HallManagement1.DataAccess;
using HallManagement1.Domain;

namespace HallManagement1.UI
{
    public partial class HomePageUI : Form
    {
        public HomePageUI()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccountUI obj=new CreateAccountUI();
            obj.MdiParent = this;
            obj.StartPosition=FormStartPosition.CenterScreen;
            obj.Show();
            
        }

        private void resetAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPasswordUI obj=new ResetPasswordUI();
            //obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
            this.Close();
        }

        private void applicantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertUpdateDeleteApplicantInfoUI obj=new InsertUpdateDeleteApplicantInfoUI();
            obj.MdiParent = this;
            obj.StartPosition=FormStartPosition.CenterScreen;
            obj.Show();
            obj.viewButton_Click(null, null);

            

        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to lock your application !!!", "continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LoginFormUI obj = new LoginFormUI();
                obj.Show();
                obj.StartPosition = FormStartPosition.CenterScreen;
                this.Close();
            }
            else if (dr == DialogResult.No)
            {
                
            }


           
        }

        private void HomePageUI_Load(object sender, EventArgs e)
        {

        }

        private void roomEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveupdatedeleteAndViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomEntryUI obj=new RoomEntryUI();
          
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();

            obj.viewButton_Click(null,null);
        }

        private void newAllotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAllotUI obj=new NewAllotUI();
             obj.MdiParent = this;
             obj.StartPosition = FormStartPosition.CenterScreen;
             obj.Show();

             obj.viewNotAllotStudentInfoButton_Click(null, null);
            obj.viewAvailableSeatFillUpButton_Click(null,null);
           
             //NewAllotDataAccess dataAccess = new NewAllotDataAccess();
             //List<RoomInfo> rooms = dataAccess.viewRoomNotFillUpInfo();
             ////roomNotFillUPDataGridView.AutoGenerateColumns = false;
             ////roomNotFillUPDataGridView.DataSource = rooms;

        }

        private void allotedStudentsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AllotmentInfoUI obj = new AllotmentInfoUI();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();

            obj.viewButton_Click(null,null);
        }

        private void deleteAllotmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllotmentInfoDeleteUI obj=new AllotmentInfoDeleteUI();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();

            obj.deleteAllotViewButton_Click(null, null);
            //obj.deleteAllotViewButton_Click(null, null);
           
        }

        private void newComplainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplainUI obj=new ComplainUI();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
            obj.viewButton_Click(null,null);
        }

       
        }
    }

