namespace HallManagement1.UI
{
    partial class CreateAccountUI
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
            this.createAnotherAccountnameLabel = new System.Windows.Forms.Label();
            this.createAnotherAccountPasswordLabel = new System.Windows.Forms.Label();
            this.createAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.createAccountPasswordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAnotherAccountnameLabel
            // 
            this.createAnotherAccountnameLabel.AutoSize = true;
            this.createAnotherAccountnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAnotherAccountnameLabel.Location = new System.Drawing.Point(99, 79);
            this.createAnotherAccountnameLabel.Name = "createAnotherAccountnameLabel";
            this.createAnotherAccountnameLabel.Size = new System.Drawing.Size(60, 23);
            this.createAnotherAccountnameLabel.TabIndex = 0;
            this.createAnotherAccountnameLabel.Text = "Name:";
            this.createAnotherAccountnameLabel.Click += new System.EventHandler(this.createAnotherAccountnameLabel_Click);
            // 
            // createAnotherAccountPasswordLabel
            // 
            this.createAnotherAccountPasswordLabel.AutoSize = true;
            this.createAnotherAccountPasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAnotherAccountPasswordLabel.Location = new System.Drawing.Point(72, 146);
            this.createAnotherAccountPasswordLabel.Name = "createAnotherAccountPasswordLabel";
            this.createAnotherAccountPasswordLabel.Size = new System.Drawing.Size(87, 23);
            this.createAnotherAccountPasswordLabel.TabIndex = 1;
            this.createAnotherAccountPasswordLabel.Text = "Password:";
            this.createAnotherAccountPasswordLabel.Click += new System.EventHandler(this.createAnotherAccountPasswordLabel_Click);
            // 
            // createAccountNameTextBox
            // 
            this.createAccountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountNameTextBox.Location = new System.Drawing.Point(192, 78);
            this.createAccountNameTextBox.Name = "createAccountNameTextBox";
            this.createAccountNameTextBox.Size = new System.Drawing.Size(247, 26);
            this.createAccountNameTextBox.TabIndex = 2;
            // 
            // createAccountPasswordTextBox
            // 
            this.createAccountPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountPasswordTextBox.Location = new System.Drawing.Point(192, 145);
            this.createAccountPasswordTextBox.Name = "createAccountPasswordTextBox";
            this.createAccountPasswordTextBox.Size = new System.Drawing.Size(247, 26);
            this.createAccountPasswordTextBox.TabIndex = 3;
            this.createAccountPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.createAccountPasswordTextBox);
            this.groupBox1.Controls.Add(this.createAccountNameTextBox);
            this.groupBox1.Controls.Add(this.createAnotherAccountnameLabel);
            this.groupBox1.Controls.Add(this.createAnotherAccountPasswordLabel);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(88, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 357);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new account";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Location = new System.Drawing.Point(192, 279);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createButton.Location = new System.Drawing.Point(360, 279);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(79, 40);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CreateAccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(687, 414);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Name = "CreateAccountUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccountUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label createAnotherAccountnameLabel;
        private System.Windows.Forms.Label createAnotherAccountPasswordLabel;
        protected System.Windows.Forms.TextBox createAccountNameTextBox;
        protected System.Windows.Forms.TextBox createAccountPasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button exitButton;
    }
}