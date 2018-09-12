namespace HallManagement1.UI
{
    partial class AllotmentInfoUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewButton = new System.Windows.Forms.Button();
            this.searchByAllotIdButton = new System.Windows.Forms.Button();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.searchByRollButton = new System.Windows.Forms.Button();
            this.allotSearchByAllotIdTextBox = new System.Windows.Forms.TextBox();
            this.allotSearchByNameTextBox = new System.Windows.Forms.TextBox();
            this.allotSearchByRollTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllotedStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllotedStudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(1203, 227);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(83, 41);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "view";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // searchByAllotIdButton
            // 
            this.searchByAllotIdButton.BackColor = System.Drawing.Color.Teal;
            this.searchByAllotIdButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByAllotIdButton.Location = new System.Drawing.Point(369, 25);
            this.searchByAllotIdButton.Name = "searchByAllotIdButton";
            this.searchByAllotIdButton.Size = new System.Drawing.Size(92, 42);
            this.searchByAllotIdButton.TabIndex = 1;
            this.searchByAllotIdButton.Text = "By allotID";
            this.searchByAllotIdButton.UseVisualStyleBackColor = false;
            this.searchByAllotIdButton.Click += new System.EventHandler(this.searchByAllotIdButton_Click);
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.BackColor = System.Drawing.Color.SeaGreen;
            this.searchByNameButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameButton.Location = new System.Drawing.Point(369, 98);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(92, 42);
            this.searchByNameButton.TabIndex = 2;
            this.searchByNameButton.Text = " By Name";
            this.searchByNameButton.UseVisualStyleBackColor = false;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // searchByRollButton
            // 
            this.searchByRollButton.BackColor = System.Drawing.Color.Tan;
            this.searchByRollButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByRollButton.Location = new System.Drawing.Point(369, 169);
            this.searchByRollButton.Name = "searchByRollButton";
            this.searchByRollButton.Size = new System.Drawing.Size(92, 42);
            this.searchByRollButton.TabIndex = 3;
            this.searchByRollButton.Text = "By Roll";
            this.searchByRollButton.UseVisualStyleBackColor = false;
            this.searchByRollButton.Click += new System.EventHandler(this.searchByRollButton_Click);
            // 
            // allotSearchByAllotIdTextBox
            // 
            this.allotSearchByAllotIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allotSearchByAllotIdTextBox.Location = new System.Drawing.Point(60, 35);
            this.allotSearchByAllotIdTextBox.Name = "allotSearchByAllotIdTextBox";
            this.allotSearchByAllotIdTextBox.Size = new System.Drawing.Size(251, 26);
            this.allotSearchByAllotIdTextBox.TabIndex = 4;
            this.allotSearchByAllotIdTextBox.TextChanged += new System.EventHandler(this.allotSearchByAllotIdTextBox_TextChanged);
            // 
            // allotSearchByNameTextBox
            // 
            this.allotSearchByNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allotSearchByNameTextBox.Location = new System.Drawing.Point(60, 106);
            this.allotSearchByNameTextBox.Name = "allotSearchByNameTextBox";
            this.allotSearchByNameTextBox.Size = new System.Drawing.Size(251, 26);
            this.allotSearchByNameTextBox.TabIndex = 5;
            // 
            // allotSearchByRollTextBox
            // 
            this.allotSearchByRollTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allotSearchByRollTextBox.Location = new System.Drawing.Point(60, 177);
            this.allotSearchByRollTextBox.Name = "allotSearchByRollTextBox";
            this.allotSearchByRollTextBox.Size = new System.Drawing.Size(251, 26);
            this.allotSearchByRollTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchByNameButton);
            this.groupBox1.Controls.Add(this.allotSearchByRollTextBox);
            this.groupBox1.Controls.Add(this.searchByAllotIdButton);
            this.groupBox1.Controls.Add(this.allotSearchByNameTextBox);
            this.groupBox1.Controls.Add(this.searchByRollButton);
            this.groupBox1.Controls.Add(this.allotSearchByAllotIdTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(363, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 233);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AllotedStudentDataGridView
            // 
            this.AllotedStudentDataGridView.AllowDrop = true;
            this.AllotedStudentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllotedStudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AllotedStudentDataGridView.ColumnHeadersHeight = 50;
            this.AllotedStudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column13,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column14,
            this.Column15});
            this.AllotedStudentDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllotedStudentDataGridView.Location = new System.Drawing.Point(58, 63);
            this.AllotedStudentDataGridView.Name = "AllotedStudentDataGridView";
            this.AllotedStudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllotedStudentDataGridView.Size = new System.Drawing.Size(1125, 359);
            this.AllotedStudentDataGridView.TabIndex = 8;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Student  ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column13
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column13.Frozen = true;
            this.Column13.HeaderText = " Allot  ID";
            this.Column13.Name = "Column13";
            this.Column13.Width = 70;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Father\'s Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mother\'s Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Mobile No.";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.HeaderText = "Department";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column9.HeaderText = "Roll";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column10.HeaderText = "CGPA";
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column11.HeaderText = "Session";
            this.Column11.Name = "Column11";
            this.Column11.Width = 80;
            // 
            // Column12
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column12.HeaderText = "Blood Group";
            this.Column12.Name = "Column12";
            this.Column12.Width = 70;
            // 
            // Column14
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column14.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column14.HeaderText = "Room No";
            this.Column14.Name = "Column14";
            this.Column14.Width = 80;
            // 
            // Column15
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column15.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column15.HeaderText = "In-Date";
            this.Column15.Name = "Column15";
            this.Column15.Width = 90;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(469, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(229, 27);
            this.label.TabIndex = 9;
            this.label.Text = "Students Info ( alloted )";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Firebrick;
            this.closeButton.Location = new System.Drawing.Point(1184, 636);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(73, 35);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AllotmentInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AllotedStudentDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.viewButton);
            this.Name = "AllotmentInfoUI";
            this.Text = "AllotmentInfoUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllotmentInfoUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllotedStudentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button searchByAllotIdButton;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Button searchByRollButton;
        private System.Windows.Forms.TextBox allotSearchByAllotIdTextBox;
        private System.Windows.Forms.TextBox allotSearchByNameTextBox;
        private System.Windows.Forms.TextBox allotSearchByRollTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AllotedStudentDataGridView;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}