﻿namespace GUI_Tier
{
    partial class frm1_DN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1_DN));
            this.radNhanVien = new System.Windows.Forms.RadioButton();
            this.radThiSinh = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.picDN = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTT = new System.Windows.Forms.Label();
            this.chuchayDN = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).BeginInit();
            this.SuspendLayout();
            // 
            // radNhanVien
            // 
            this.radNhanVien.AutoSize = true;
            this.radNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhanVien.Location = new System.Drawing.Point(269, 31);
            this.radNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.radNhanVien.Name = "radNhanVien";
            this.radNhanVien.Size = new System.Drawing.Size(101, 24);
            this.radNhanVien.TabIndex = 1;
            this.radNhanVien.Text = "Nhân Viên";
            this.radNhanVien.UseVisualStyleBackColor = true;
            this.radNhanVien.CheckedChanged += new System.EventHandler(this.radNhanVien_CheckedChanged);
            // 
            // radThiSinh
            // 
            this.radThiSinh.AutoSize = true;
            this.radThiSinh.Checked = true;
            this.radThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThiSinh.Location = new System.Drawing.Point(133, 31);
            this.radThiSinh.Margin = new System.Windows.Forms.Padding(4);
            this.radThiSinh.Name = "radThiSinh";
            this.radThiSinh.Size = new System.Drawing.Size(84, 24);
            this.radThiSinh.TabIndex = 0;
            this.radThiSinh.TabStop = true;
            this.radThiSinh.Text = "Thí Sinh";
            this.radThiSinh.UseVisualStyleBackColor = true;
            this.radThiSinh.CheckedChanged += new System.EventHandler(this.radThiSinh_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radNhanVien);
            this.groupBox2.Controls.Add(this.radThiSinh);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 69);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chọn quyền";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Gold;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(510, 220);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(149, 38);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.toolTip1.SetToolTip(this.btnDangKy, "Nhấn Vào Đây Để Tạo Tài Khoản Thi");
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTin.Controls.Add(this.txtMatKhau);
            this.grpThongTin.Controls.Add(this.txtDangNhap);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.Location = new System.Drawing.Point(45, 168);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTin.Size = new System.Drawing.Size(434, 203);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "thông tin đăng nhập của thí sinh";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Coral;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(175, 142);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(241, 26);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BackColor = System.Drawing.Color.Coral;
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtDangNhap.Location = new System.Drawing.Point(175, 82);
            this.txtDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(241, 26);
            this.txtDangNhap.TabIndex = 0;
            this.txtDangNhap.UseWaitCursor = true;
            this.txtDangNhap.Click += new System.EventHandler(this.txtDangNhap_Click);
            this.txtDangNhap.TextChanged += new System.EventHandler(this.txtDangNhap_TextChanged);
            this.txtDangNhap.Leave += new System.EventHandler(this.txtDangNhap_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Gold;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(510, 273);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(149, 38);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.toolTip1.SetToolTip(this.btnDoiMatKhau, "Nhấn Vào Đây Để Đổi Tài Mật Khẩu Của Bạn");
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Gold;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(510, 323);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btnThoat, "Nhấn Vào Đây Để Thoát Chương Trình");
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Gold;
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(510, 168);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(149, 38);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "     Đăng nhập";
            this.toolTip1.SetToolTip(this.btnDangNhap, "Nhấn Vào Đây Để Đăng Nhập");
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(617, 7);
            this.label3.TabIndex = 30;
            // 
            // picDN
            // 
            this.picDN.BackColor = System.Drawing.Color.Transparent;
            this.picDN.Image = ((System.Drawing.Image)(resources.GetObject("picDN.Image")));
            this.picDN.Location = new System.Drawing.Point(489, 62);
            this.picDN.Name = "picDN";
            this.picDN.Size = new System.Drawing.Size(100, 74);
            this.picDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDN.TabIndex = 31;
            this.picDN.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 382);
            this.progressBar1.Maximum = 2100;
            this.progressBar1.Minimum = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(614, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 32;
            this.progressBar1.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTT
            // 
            this.lblTT.BackColor = System.Drawing.Color.Transparent;
            this.lblTT.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTT.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.ForeColor = System.Drawing.Color.Blue;
            this.lblTT.Location = new System.Drawing.Point(0, 0);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(709, 37);
            this.lblTT.TabIndex = 33;
            this.lblTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTT.Click += new System.EventHandler(this.lblTT_Click);
            // 
            // chuchayDN
            // 
            this.chuchayDN.Enabled = true;
            this.chuchayDN.Tick += new System.EventHandler(this.chuchayDN_Tick);
            // 
            // frm1_DN
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(709, 452);
            this.ControlBox = false;
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm1_DN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm1_DN";
            this.Load += new System.EventHandler(this.frm1_DN_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        public System.Windows.Forms.RadioButton radNhanVien;
        public System.Windows.Forms.RadioButton radThiSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picDN;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Timer chuchayDN;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.TextBox txtMatKhau;
        protected System.Windows.Forms.TextBox txtDangNhap;
    }
}