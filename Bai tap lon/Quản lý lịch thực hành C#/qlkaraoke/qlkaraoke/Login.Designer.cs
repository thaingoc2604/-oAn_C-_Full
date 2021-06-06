namespace qlkaraoke
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fLoginTxtUserName = new System.Windows.Forms.TextBox();
            this.fLoginTxtPassword = new System.Windows.Forms.TextBox();
            this.fLoginLbAlert = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fLoginBtnClose = new System.Windows.Forms.Button();
            this.fLoginBtnLogin = new System.Windows.Forms.Button();
            this.employeeTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // fLoginTxtUserName
            // 
            this.fLoginTxtUserName.Location = new System.Drawing.Point(143, 67);
            this.fLoginTxtUserName.Name = "fLoginTxtUserName";
            this.fLoginTxtUserName.Size = new System.Drawing.Size(157, 20);
            this.fLoginTxtUserName.TabIndex = 2;
            // 
            // fLoginTxtPassword
            // 
            this.fLoginTxtPassword.Location = new System.Drawing.Point(143, 98);
            this.fLoginTxtPassword.Name = "fLoginTxtPassword";
            this.fLoginTxtPassword.PasswordChar = '^';
            this.fLoginTxtPassword.Size = new System.Drawing.Size(157, 20);
            this.fLoginTxtPassword.TabIndex = 3;
            // 
            // fLoginLbAlert
            // 
            this.fLoginLbAlert.BackColor = System.Drawing.Color.Transparent;
            this.fLoginLbAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLoginLbAlert.ForeColor = System.Drawing.Color.Red;
            this.fLoginLbAlert.Location = new System.Drawing.Point(69, 121);
            this.fLoginLbAlert.Name = "fLoginLbAlert";
            this.fLoginLbAlert.Size = new System.Drawing.Size(313, 19);
            this.fLoginLbAlert.TabIndex = 6;
            this.fLoginLbAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "LOGIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::qlkaraoke.Properties.Resources.karaoke2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::qlkaraoke.Properties.Resources.karaoke3;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // fLoginBtnClose
            // 
            this.fLoginBtnClose.BackgroundImage = global::qlkaraoke.Properties.Resources.btn11;
            this.fLoginBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLoginBtnClose.Location = new System.Drawing.Point(195, 146);
            this.fLoginBtnClose.Name = "fLoginBtnClose";
            this.fLoginBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fLoginBtnClose.TabIndex = 5;
            this.fLoginBtnClose.Text = "Exit";
            this.fLoginBtnClose.UseVisualStyleBackColor = true;
            this.fLoginBtnClose.MouseLeave += new System.EventHandler(this.fLoginBtnClose_MouseLeave);
            this.fLoginBtnClose.Click += new System.EventHandler(this.fLoginBtnClose_Click_1);
            this.fLoginBtnClose.MouseEnter += new System.EventHandler(this.fLoginBtnClose_MouseEnter);
            // 
            // fLoginBtnLogin
            // 
            this.fLoginBtnLogin.BackgroundImage = global::qlkaraoke.Properties.Resources.btn1;
            this.fLoginBtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLoginBtnLogin.Location = new System.Drawing.Point(102, 146);
            this.fLoginBtnLogin.Name = "fLoginBtnLogin";
            this.fLoginBtnLogin.Size = new System.Drawing.Size(87, 39);
            this.fLoginBtnLogin.TabIndex = 4;
            this.fLoginBtnLogin.Text = "Login";
            this.fLoginBtnLogin.UseVisualStyleBackColor = true;
            this.fLoginBtnLogin.MouseLeave += new System.EventHandler(this.fLoginBtnLogin_MouseLeave);
            this.fLoginBtnLogin.Click += new System.EventHandler(this.fLoginBtnLogin_Click);
            this.fLoginBtnLogin.MouseEnter += new System.EventHandler(this.fLoginBtnLogin_MouseEnter);
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // fLogin
            // 
            this.AcceptButton = this.fLoginBtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(394, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fLoginLbAlert);
            this.Controls.Add(this.fLoginBtnClose);
            this.Controls.Add(this.fLoginBtnLogin);
            this.Controls.Add(this.fLoginTxtPassword);
            this.Controls.Add(this.fLoginTxtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL KARAOKE - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fLoginTxtUserName;
        private System.Windows.Forms.TextBox fLoginTxtPassword;
        private System.Windows.Forms.Button fLoginBtnLogin;
        private System.Windows.Forms.Button fLoginBtnClose;
        private System.Windows.Forms.Label fLoginLbAlert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
    }
}

