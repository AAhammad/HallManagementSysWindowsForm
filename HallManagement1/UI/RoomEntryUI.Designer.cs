namespace HallManagement1.UI
{
    partial class RoomEntryUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.blockNoLabel = new System.Windows.Forms.Label();
            this.floorNoLabel = new System.Windows.Forms.Label();
            this.availableSeatLabel = new System.Windows.Forms.Label();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.blockNoTextBox = new System.Windows.Forms.TextBox();
            this.floorNoTextBox = new System.Windows.Forms.TextBox();
            this.availableSeatTextBox = new System.Windows.Forms.TextBox();
            this.roomEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.entryButton = new System.Windows.Forms.Button();
            this.roomEntryDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDetailsLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteRoomTextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.roomDataGridviewToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.roomEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomEntryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLabel.Location = new System.Drawing.Point(100, 101);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(71, 19);
            this.roomNoLabel.TabIndex = 1;
            this.roomNoLabel.Text = "Room No:";
            // 
            // blockNoLabel
            // 
            this.blockNoLabel.AutoSize = true;
            this.blockNoLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockNoLabel.Location = new System.Drawing.Point(100, 175);
            this.blockNoLabel.Name = "blockNoLabel";
            this.blockNoLabel.Size = new System.Drawing.Size(72, 19);
            this.blockNoLabel.TabIndex = 2;
            this.blockNoLabel.Text = "Block No:";
            // 
            // floorNoLabel
            // 
            this.floorNoLabel.AutoSize = true;
            this.floorNoLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorNoLabel.Location = new System.Drawing.Point(91, 252);
            this.floorNoLabel.Name = "floorNoLabel";
            this.floorNoLabel.Size = new System.Drawing.Size(71, 19);
            this.floorNoLabel.TabIndex = 3;
            this.floorNoLabel.Text = "Floor No:";
            // 
            // availableSeatLabel
            // 
            this.availableSeatLabel.AutoSize = true;
            this.availableSeatLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableSeatLabel.Location = new System.Drawing.Point(64, 322);
            this.availableSeatLabel.Name = "availableSeatLabel";
            this.availableSeatLabel.Size = new System.Drawing.Size(107, 19);
            this.availableSeatLabel.TabIndex = 4;
            this.availableSeatLabel.Text = "Available Seat:";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoTextBox.Location = new System.Drawing.Point(192, 97);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(232, 26);
            this.roomNoTextBox.TabIndex = 5;
            this.roomNoTextBox.TextChanged += new System.EventHandler(this.roomNoTextBox_TextChanged);
            // 
            // blockNoTextBox
            // 
            this.blockNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockNoTextBox.Location = new System.Drawing.Point(192, 168);
            this.blockNoTextBox.Name = "blockNoTextBox";
            this.blockNoTextBox.Size = new System.Drawing.Size(232, 26);
            this.blockNoTextBox.TabIndex = 6;
            // 
            // floorNoTextBox
            // 
            this.floorNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorNoTextBox.Location = new System.Drawing.Point(192, 245);
            this.floorNoTextBox.Name = "floorNoTextBox";
            this.floorNoTextBox.Size = new System.Drawing.Size(232, 26);
            this.floorNoTextBox.TabIndex = 7;
            this.floorNoTextBox.TextChanged += new System.EventHandler(this.floorNoTextBox_TextChanged);
            // 
            // availableSeatTextBox
            // 
            this.availableSeatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableSeatTextBox.Location = new System.Drawing.Point(192, 322);
            this.availableSeatTextBox.Name = "availableSeatTextBox";
            this.availableSeatTextBox.Size = new System.Drawing.Size(232, 26);
            this.availableSeatTextBox.TabIndex = 8;
            this.availableSeatTextBox.TextChanged += new System.EventHandler(this.availableSeatTextBox_TextChanged);
            // 
            // roomEntryGroupBox
            // 
            this.roomEntryGroupBox.Controls.Add(this.searchButton);
            this.roomEntryGroupBox.Controls.Add(this.clearAllButton);
            this.roomEntryGroupBox.Controls.Add(this.updateButton);
            this.roomEntryGroupBox.Controls.Add(this.entryButton);
            this.roomEntryGroupBox.Controls.Add(this.roomNoLabel);
            this.roomEntryGroupBox.Controls.Add(this.availableSeatTextBox);
            this.roomEntryGroupBox.Controls.Add(this.blockNoLabel);
            this.roomEntryGroupBox.Controls.Add(this.floorNoTextBox);
            this.roomEntryGroupBox.Controls.Add(this.floorNoLabel);
            this.roomEntryGroupBox.Controls.Add(this.blockNoTextBox);
            this.roomEntryGroupBox.Controls.Add(this.availableSeatLabel);
            this.roomEntryGroupBox.Controls.Add(this.roomNoTextBox);
            this.roomEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomEntryGroupBox.Location = new System.Drawing.Point(48, 65);
            this.roomEntryGroupBox.Name = "roomEntryGroupBox";
            this.roomEntryGroupBox.Size = new System.Drawing.Size(539, 510);
            this.roomEntryGroupBox.TabIndex = 9;
            this.roomEntryGroupBox.TabStop = false;
            this.roomEntryGroupBox.Text = "Room Entry";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(442, 88);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 39);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.Location = new System.Drawing.Point(85, 422);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(77, 38);
            this.clearAllButton.TabIndex = 11;
            this.clearAllButton.Text = "clear";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RosyBrown;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(214, 422);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(77, 38);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // entryButton
            // 
            this.entryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.entryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryButton.Location = new System.Drawing.Point(347, 422);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(77, 38);
            this.entryButton.TabIndex = 9;
            this.entryButton.Text = "entry";
            this.entryButton.UseVisualStyleBackColor = false;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // roomEntryDataGridView
            // 
            this.roomEntryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomEntryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomEntryDataGridView.ColumnHeadersHeight = 40;
            this.roomEntryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.roomEntryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roomEntryDataGridView.Location = new System.Drawing.Point(625, 77);
            this.roomEntryDataGridView.Name = "roomEntryDataGridView";
            this.roomEntryDataGridView.ReadOnly = true;
            this.roomEntryDataGridView.RowHeadersWidth = 50;
            this.roomEntryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomEntryDataGridView.Size = new System.Drawing.Size(641, 423);
            this.roomEntryDataGridView.TabIndex = 10;
            this.roomDataGridviewToolTip.SetToolTip(this.roomEntryDataGridView, "Double click on the row to  show  informations within textboxs and comboboxs  (  " +
        "<----  )");
            this.toolTip1.SetToolTip(this.roomEntryDataGridView, "Double click on the row to  show  informations within textboxs and comboboxs  (  " +
        "<----  )");
            this.roomEntryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomEntryDataGridView_CellClick);
            this.roomEntryDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.roomEntryDataGridView_ColumnHeaderMouseClick);
            this.roomEntryDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.roomEntryDataGridView_RowHeaderMouseClick);
            this.roomEntryDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.roomEntryDataGridView_MouseDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "      Room No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "       Block ";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "      Floor No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "  Available Seat";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // roomDetailsLabel
            // 
            this.roomDetailsLabel.AutoSize = true;
            this.roomDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDetailsLabel.ForeColor = System.Drawing.Color.Maroon;
            this.roomDetailsLabel.Location = new System.Drawing.Point(864, 24);
            this.roomDetailsLabel.Name = "roomDetailsLabel";
            this.roomDetailsLabel.Size = new System.Drawing.Size(133, 24);
            this.roomDetailsLabel.TabIndex = 11;
            this.roomDetailsLabel.Text = "Room Details";
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.Black;
            this.viewButton.Location = new System.Drawing.Point(981, 528);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(82, 38);
            this.viewButton.TabIndex = 12;
            this.viewButton.Text = "Veiw";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(841, 528);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 38);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Firebrick;
            this.closeButton.Location = new System.Drawing.Point(1193, 646);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(73, 35);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteRoomTextBox
            // 
            this.deleteRoomTextBox.Location = new System.Drawing.Point(709, 41);
            this.deleteRoomTextBox.Name = "deleteRoomTextBox";
            this.deleteRoomTextBox.ReadOnly = true;
            this.deleteRoomTextBox.Size = new System.Drawing.Size(74, 20);
            this.deleteRoomTextBox.TabIndex = 15;
            this.deleteRoomTextBox.Visible = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.SeaGreen;
            this.RefreshButton.Location = new System.Drawing.Point(1193, 33);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(73, 35);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Visible = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // RoomEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.deleteRoomTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.roomDetailsLabel);
            this.Controls.Add(this.roomEntryDataGridView);
            this.Controls.Add(this.roomEntryGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Name = "RoomEntryUI";
            this.Text = "RoomEntryUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RoomEntryUI_Load);
            this.roomEntryGroupBox.ResumeLayout(false);
            this.roomEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomEntryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.Label blockNoLabel;
        private System.Windows.Forms.Label floorNoLabel;
        private System.Windows.Forms.Label availableSeatLabel;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.TextBox blockNoTextBox;
        private System.Windows.Forms.TextBox floorNoTextBox;
        private System.Windows.Forms.TextBox availableSeatTextBox;
        private System.Windows.Forms.GroupBox roomEntryGroupBox;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.DataGridView roomEntryDataGridView;
        private System.Windows.Forms.Label roomDetailsLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.TextBox deleteRoomTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolTip roomDataGridviewToolTip;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}