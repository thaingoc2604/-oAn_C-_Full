﻿namespace QLSV_GiaoDien
{
    partial class uc_User
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblMatkhaumoi = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTacvu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdXoa = new System.Windows.Forms.RadioButton();
            this.rdDoiMatkhau = new System.Windows.Forms.RadioButton();
            this.rdTaoUser = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTenTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.lblMatkhaumoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.lblTacvu);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.dgvUser);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí tài khoản";
         
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(227, 440);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(198, 20);
            this.txtNewPass.TabIndex = 8;
            this.txtNewPass.Visible = false;
            // 
            // lblMatkhaumoi
            // 
            this.lblMatkhaumoi.AutoSize = true;
            this.lblMatkhaumoi.Location = new System.Drawing.Point(109, 443);
            this.lblMatkhaumoi.Name = "lblMatkhaumoi";
            this.lblMatkhaumoi.Size = new System.Drawing.Size(102, 13);
            this.lblMatkhaumoi.TabIndex = 14;
            this.lblMatkhaumoi.Text = "Nhập mật khẩu mới:";
            this.lblMatkhaumoi.Visible = false;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(477, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 43);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(572, 370);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 44);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTacvu
            // 
            this.lblTacvu.AutoSize = true;
            this.lblTacvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacvu.ForeColor = System.Drawing.Color.Maroon;
            this.lblTacvu.Location = new System.Drawing.Point(250, 333);
            this.lblTacvu.Name = "lblTacvu";
            this.lblTacvu.Size = new System.Drawing.Size(51, 20);
            this.lblTacvu.TabIndex = 11;
            this.lblTacvu.Text = "label4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdXoa);
            this.groupBox3.Controls.Add(this.rdDoiMatkhau);
            this.groupBox3.Controls.Add(this.rdTaoUser);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(81, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(521, 53);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn tác vụ";
            // 
            // rdXoa
            // 
            this.rdXoa.AutoSize = true;
            this.rdXoa.Location = new System.Drawing.Point(399, 22);
            this.rdXoa.Name = "rdXoa";
            this.rdXoa.Size = new System.Drawing.Size(69, 17);
            this.rdXoa.TabIndex = 5;
            this.rdXoa.Text = "Xóa User";
            this.rdXoa.UseVisualStyleBackColor = true;
            this.rdXoa.CheckedChanged += new System.EventHandler(this.rdXoa_CheckedChanged);
            // 
            // rdDoiMatkhau
            // 
            this.rdDoiMatkhau.AutoSize = true;
            this.rdDoiMatkhau.Location = new System.Drawing.Point(217, 22);
            this.rdDoiMatkhau.Name = "rdDoiMatkhau";
            this.rdDoiMatkhau.Size = new System.Drawing.Size(88, 17);
            this.rdDoiMatkhau.TabIndex = 4;
            this.rdDoiMatkhau.Text = "Đổi mật khẩu";
            this.rdDoiMatkhau.UseVisualStyleBackColor = true;
            this.rdDoiMatkhau.CheckedChanged += new System.EventHandler(this.rdDoiMatkhau_CheckedChanged);
            // 
            // rdTaoUser
            // 
            this.rdTaoUser.AutoSize = true;
            this.rdTaoUser.Checked = true;
            this.rdTaoUser.Location = new System.Drawing.Point(42, 22);
            this.rdTaoUser.Name = "rdTaoUser";
            this.rdTaoUser.Size = new System.Drawing.Size(69, 17);
            this.rdTaoUser.TabIndex = 3;
            this.rdTaoUser.TabStop = true;
            this.rdTaoUser.Text = "Tạo User";
            this.rdTaoUser.UseVisualStyleBackColor = true;
            this.rdTaoUser.CheckedChanged += new System.EventHandler(this.rdTaoUser_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(572, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 43);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(477, 370);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtTenTimKiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(23, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm User";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(549, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(457, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(69, 41);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTenTimKiem
            // 
            this.txtTenTimKiem.Location = new System.Drawing.Point(135, 28);
            this.txtTenTimKiem.Name = "txtTenTimKiem";
            this.txtTenTimKiem.Size = new System.Drawing.Size(290, 20);
            this.txtTenTimKiem.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên người dùng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(227, 406);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(198, 20);
            this.txtPass.TabIndex = 7;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(233, 571);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(75, 23);
            this.d.TabIndex = 4;
            this.d.Text = "Thêm";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(109, 409);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password});
            this.dgvUser.Location = new System.Drawing.Point(23, 112);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(643, 129);
            this.dgvUser.TabIndex = 2;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 300;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Pass";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 300;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(227, 373);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(198, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // uc_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_User";
            this.Size = new System.Drawing.Size(690, 520);
            this.Load += new System.EventHandler(this.uc_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdTaoUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdXoa;
        private System.Windows.Forms.RadioButton rdDoiMatkhau;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTacvu;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblMatkhaumoi;
        private System.Windows.Forms.Button btnRefresh;
    }
}
