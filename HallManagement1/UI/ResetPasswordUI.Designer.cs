namespace HallManagement1.UI
{
    partial class ResetPasswordUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordUI));
            this.resetNameLabel = new System.Windows.Forms.Label();
            this.resetNewPasswordLabel = new System.Windows.Forms.Label();
            this.resetPasswordNameTextBox = new System.Windows.Forms.TextBox();
            this.resetNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginPageButton = new System.Windows.Forms.Button();
            this.resetOldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnLoginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetNameLabel
            // 
            this.resetNameLabel.AutoSize = true;
            this.resetNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetNameLabel.Location = new System.Drawing.Point(99, 92);
            this.resetNameLabel.Name = "resetNameLabel";
            this.resetNameLabel.Size = new System.Drawing.Size(60, 23);
            this.resetNameLabel.TabIndex = 0;
            this.resetNameLabel.Text = "Name:";
            // 
            // resetNewPasswordLabel
            // 
            this.resetNewPasswordLabel.AutoSize = true;
            this.resetNewPasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetNewPasswordLabel.Location = new System.Drawing.Point(41, 203);
            this.resetNewPasswordLabel.Name = "resetNewPasswordLabel";
            this.resetNewPasswordLabel.Size = new System.Drawing.Size(127, 23);
            this.resetNewPasswordLabel.TabIndex = 1;
            this.resetNewPasswordLabel.Text = "New Password:";
            // 
            // resetPasswordNameTextBox
            // 
            this.resetPasswordNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordNameTextBox.Location = new System.Drawing.Point(197, 89);
            this.resetPasswordNameTextBox.Name = "resetPasswordNameTextBox";
            this.resetPasswordNameTextBox.Size = new System.Drawing.Size(237, 26);
            this.resetPasswordNameTextBox.TabIndex = 2;
            // 
            // resetNewPasswordTextBox
            // 
            this.resetNewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetNewPasswordTextBox.Location = new System.Drawing.Point(197, 203);
            this.resetNewPasswordTextBox.Name = "resetNewPasswordTextBox";
            this.resetNewPasswordTextBox.Size = new System.Drawing.Size(237, 26);
            this.resetNewPasswordTextBox.TabIndex = 3;
            this.resetNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(356, 285);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(78, 39);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginPageButton);
            this.groupBox1.Controls.Add(this.resetOldPasswordTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resetPasswordNameTextBox);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.resetNameLabel);
            this.groupBox1.Controls.Add(this.resetNewPasswordTextBox);
            this.groupBox1.Controls.Add(this.resetNewPasswordLabel);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 351);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset Password";
            // 
            // loginPageButton
            // 
            this.loginPageButton.BackColor = System.Drawing.Color.SeaGreen;
            this.loginPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPageButton.Location = new System.Drawing.Point(197, 285);
            this.loginPageButton.Name = "loginPageButton";
            this.loginPageButton.Size = new System.Drawing.Size(78, 39);
            this.loginPageButton.TabIndex = 7;
            this.loginPageButton.Text = "Login page";
            this.returnLoginToolTip.SetToolTip(this.loginPageButton, "click to return login page");
            this.loginPageButton.UseVisualStyleBackColor = false;
            this.loginPageButton.Click += new System.EventHandler(this.loginPageButton_Click);
            // 
            // resetOldPasswordTextBox
            // 
            this.resetOldPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetOldPasswordTextBox.Location = new System.Drawing.Point(197, 146);
            this.resetOldPasswordTextBox.Name = "resetOldPasswordTextBox";
            this.resetOldPasswordTextBox.Size = new System.Drawing.Size(237, 26);
            this.resetOldPasswordTextBox.TabIndex = 6;
            this.resetOldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old Password:";
            // 
            // ResetPasswordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(687, 414);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "ResetPasswordUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label resetNameLabel;
        private System.Windows.Forms.Label resetNewPasswordLabel;
        private System.Windows.Forms.TextBox resetPasswordNameTextBox;
        private System.Windows.Forms.TextBox resetNewPasswordTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resetOldPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginPageButton;
        private System.Windows.Forms.ToolTip returnLoginToolTip;
    }
}