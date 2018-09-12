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
    public partial class ComplainUI : Form
    {
        public ComplainUI()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {




            ComplainInfo obj = new ComplainInfo()
            {
                cName = nameTextBox.Text,
                
                cRoll = rollTextBox.Text,
                cMb = mbTextbox.Text,
                cDate = dateTextBox.Text,
                complain=complainRichTextBox.Text

            };

            if (cAllotIdTextBox.Text == "")
            {
                obj.cAllot_id = -1;
            }
            else
            {
                obj.cAllot_id = Convert.ToInt32(cAllotIdTextBox.Text);
            }

             ComplainChek ob=new ComplainChek();
             ob.submitChek(obj);

             ComplainDataAccess dataAccess = new ComplainDataAccess();
             List<ComplainInfo> complains = dataAccess.viewComplain();
             complainDataGridView.AutoGenerateColumns = false;
             complainDataGridView.DataSource = complains;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void viewButton_Click(object sender, EventArgs e)
        {
            ComplainDataAccess dataAccess = new ComplainDataAccess();
            List<ComplainInfo> complains = dataAccess.viewComplain();
           complainDataGridView.AutoGenerateColumns = false;
            complainDataGridView.DataSource = complains;
            complainDataGridView.Columns[0].DataPropertyName = "cId";
             complainDataGridView.Columns[1].DataPropertyName = "cAllot_id";
            complainDataGridView.Columns[2].DataPropertyName = "cName";
            complainDataGridView.Columns[3].DataPropertyName = "cRoll";
            complainDataGridView.Columns[4].DataPropertyName = "cMb";
            complainDataGridView.Columns[5].DataPropertyName = "cDate";
            complainDataGridView.Columns[6].DataPropertyName = "complain";
            

        }

        private void complainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteComplainIdTextBox.Text = complainDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ComplainInfo ob=new ComplainInfo();
            if (deleteComplainIdTextBox.Text == "")
            {
                ob.cId = 0;
            }

            else
            {
                ob.cId = Convert.ToInt32(deleteComplainIdTextBox.Text);

            }

            ComplainChek obj=new ComplainChek();
            obj.deleteComplainCheck(ob);

            ComplainDataAccess dataAccess = new ComplainDataAccess();
            List<ComplainInfo> complains = dataAccess.viewComplain();
            complainDataGridView.AutoGenerateColumns = false;
            complainDataGridView.DataSource = complains;
        }

        private void complainDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteComplainIdTextBox.Text = complainDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void ComplainUI_Load(object sender, EventArgs e)
        {

        }

        private void cAllotIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cAllotIdTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only numbers.");
                cAllotIdTextBox.Text.Remove(cAllotIdTextBox.TextLength - 1);
                cAllotIdTextBox.Clear();
            }
        }
    }
}
