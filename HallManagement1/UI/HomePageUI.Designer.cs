namespace HallManagement1.UI
{
    partial class HomePageUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveupdatedeleteAndViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allotmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAllotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allotedStudentsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllotmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newComplainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.ReturnLoginPageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.applicantToolStripMenuItem,
            this.roomEntryToolStripMenuItem,
            this.allotmentToolStripMenuItem,
            this.complainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1318, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.resetAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.accountToolStripMenuItem.Text = " Account";
            this.accountToolStripMenuItem.ToolTipText = "click to view submenu";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // resetAccountToolStripMenuItem
            // 
            this.resetAccountToolStripMenuItem.Name = "resetAccountToolStripMenuItem";
            this.resetAccountToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.resetAccountToolStripMenuItem.Text = "Reset Account ";
            this.resetAccountToolStripMenuItem.Click += new System.EventHandler(this.resetAccountToolStripMenuItem_Click);
            // 
            // applicantToolStripMenuItem
            // 
            this.applicantToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.applicantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateDeleteToolStripMenuItem});
            this.applicantToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicantToolStripMenuItem.Name = "applicantToolStripMenuItem";
            this.applicantToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.applicantToolStripMenuItem.Text = "Applicant";
            this.applicantToolStripMenuItem.ToolTipText = "click to view submenu";
            this.applicantToolStripMenuItem.Click += new System.EventHandler(this.applicantToolStripMenuItem_Click);
            // 
            // addUpdateDeleteToolStripMenuItem
            // 
            this.addUpdateDeleteToolStripMenuItem.Name = "addUpdateDeleteToolStripMenuItem";
            this.addUpdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.addUpdateDeleteToolStripMenuItem.Text = "Add/Update/Delete and view";
            this.addUpdateDeleteToolStripMenuItem.Click += new System.EventHandler(this.addUpdateDeleteToolStripMenuItem_Click);
            // 
            // roomEntryToolStripMenuItem
            // 
            this.roomEntryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.roomEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveupdatedeleteAndViewToolStripMenuItem});
            this.roomEntryToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomEntryToolStripMenuItem.Name = "roomEntryToolStripMenuItem";
            this.roomEntryToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.roomEntryToolStripMenuItem.Text = "   Room  ";
            this.roomEntryToolStripMenuItem.ToolTipText = "enter new room information";
            this.roomEntryToolStripMenuItem.Click += new System.EventHandler(this.roomEntryToolStripMenuItem_Click);
            // 
            // saveupdatedeleteAndViewToolStripMenuItem
            // 
            this.saveupdatedeleteAndViewToolStripMenuItem.Name = "saveupdatedeleteAndViewToolStripMenuItem";
            this.saveupdatedeleteAndViewToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.saveupdatedeleteAndViewToolStripMenuItem.Text = "add/update/delete and view";
            this.saveupdatedeleteAndViewToolStripMenuItem.Click += new System.EventHandler(this.saveupdatedeleteAndViewToolStripMenuItem_Click);
            // 
            // allotmentToolStripMenuItem
            // 
            this.allotmentToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.allotmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAllotToolStripMenuItem,
            this.allotedStudentsDetailsToolStripMenuItem,
            this.deleteAllotmentToolStripMenuItem});
            this.allotmentToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allotmentToolStripMenuItem.Name = "allotmentToolStripMenuItem";
            this.allotmentToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.allotmentToolStripMenuItem.Text = "Allotment";
            // 
            // newAllotToolStripMenuItem
            // 
            this.newAllotToolStripMenuItem.Name = "newAllotToolStripMenuItem";
            this.newAllotToolStripMenuItem.Size = new System.Drawing.Size(357, 28);
            this.newAllotToolStripMenuItem.Text = "New allot";
            this.newAllotToolStripMenuItem.Click += new System.EventHandler(this.newAllotToolStripMenuItem_Click);
            // 
            // allotedStudentsDetailsToolStripMenuItem
            // 
            this.allotedStudentsDetailsToolStripMenuItem.Name = "allotedStudentsDetailsToolStripMenuItem";
            this.allotedStudentsDetailsToolStripMenuItem.Size = new System.Drawing.Size(357, 28);
            this.allotedStudentsDetailsToolStripMenuItem.Text = "View / search Alloted students info";
            this.allotedStudentsDetailsToolStripMenuItem.Click += new System.EventHandler(this.allotedStudentsDetailsToolStripMenuItem_Click);
            // 
            // deleteAllotmentToolStripMenuItem
            // 
            this.deleteAllotmentToolStripMenuItem.Name = "deleteAllotmentToolStripMenuItem";
            this.deleteAllotmentToolStripMenuItem.Size = new System.Drawing.Size(357, 28);
            this.deleteAllotmentToolStripMenuItem.Text = "Delete Allotment";
            this.deleteAllotmentToolStripMenuItem.Click += new System.EventHandler(this.deleteAllotmentToolStripMenuItem_Click);
            // 
            // complainToolStripMenuItem
            // 
            this.complainToolStripMenuItem.BackColor = System.Drawing.Color.SeaGreen;
            this.complainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newComplainToolStripMenuItem});
            this.complainToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainToolStripMenuItem.Name = "complainToolStripMenuItem";
            this.complainToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.complainToolStripMenuItem.Text = " Complain ";
            // 
            // newComplainToolStripMenuItem
            // 
            this.newComplainToolStripMenuItem.Name = "newComplainToolStripMenuItem";
            this.newComplainToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.newComplainToolStripMenuItem.Text = "Add / View and Delete";
            this.newComplainToolStripMenuItem.Click += new System.EventHandler(this.newComplainToolStripMenuItem_Click);
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backToLoginButton.Location = new System.Drawing.Point(12, 668);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(84, 44);
            this.backToLoginButton.TabIndex = 2;
            this.backToLoginButton.Text = "Lock Application";
            this.ReturnLoginPageToolTip.SetToolTip(this.backToLoginButton, "hit to back Login page");
            this.backToLoginButton.UseVisualStyleBackColor = false;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // HomePageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1318, 733);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePageUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePageUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateDeleteToolStripMenuItem;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.ToolTip ReturnLoginPageToolTip;
        private System.Windows.Forms.ToolStripMenuItem roomEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveupdatedeleteAndViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allotmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAllotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allotedStudentsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllotmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newComplainToolStripMenuItem;
    }
}