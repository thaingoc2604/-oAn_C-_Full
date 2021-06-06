namespace GUI_Tier
{
    partial class frm2_GiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2_GiaoDienChinh));
            this.lblTT = new System.Windows.Forms.Label();
            this.chuchayChinh = new System.Windows.Forms.Timer(this.components);
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radThiSinh = new System.Windows.Forms.RadioButton();
            this.radNhanVien = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picQuanLyTaiKhoan = new System.Windows.Forms.PictureBox();
            this.picQuanLyCauHoi = new System.Windows.Forms.PictureBox();
            this.pic_ThiTracNghiem = new System.Windows.Forms.PictureBox();
            this.pic_XemDiem = new System.Windows.Forms.PictureBox();
            this.pic_DangNhapLai = new System.Windows.Forms.PictureBox();
            this.pic_Thoat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuanLyTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuanLyCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ThiTracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_XemDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangNhapLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTT
            // 
            this.lblTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTT.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.ForeColor = System.Drawing.Color.Brown;
            this.lblTT.Location = new System.Drawing.Point(0, 0);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(806, 53);
            this.lblTT.TabIndex = 3;
            this.lblTT.Text = "chương trình thi trắc nghiêm môn tiếng anh";
            this.lblTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chuchayChinh
            // 
            this.chuchayChinh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::GUI_Tier.Properties.Resources.Windows_Close_Program2;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // radThiSinh
            // 
            this.radThiSinh.AutoSize = true;
            this.radThiSinh.ForeColor = System.Drawing.Color.Blue;
            this.radThiSinh.Location = new System.Drawing.Point(113, 22);
            this.radThiSinh.Name = "radThiSinh";
            this.radThiSinh.Size = new System.Drawing.Size(82, 20);
            this.radThiSinh.TabIndex = 14;
            this.radThiSinh.Text = "Thí Sinh";
            this.radThiSinh.UseVisualStyleBackColor = true;
            // 
            // radNhanVien
            // 
            this.radNhanVien.AutoSize = true;
            this.radNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.radNhanVien.Location = new System.Drawing.Point(10, 22);
            this.radNhanVien.Name = "radNhanVien";
            this.radNhanVien.Size = new System.Drawing.Size(97, 20);
            this.radNhanVien.TabIndex = 13;
            this.radNhanVien.Text = "Nhân Viên";
            this.radNhanVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radThiSinh);
            this.groupBox1.Controls.Add(this.radNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(332, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 59);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, "BẠN PHẢI CHỌN 1 TRONG 2 LOẠI TÀI KHOẢN ĐỂ QUẢN LÝ");
            // 
            // picQuanLyTaiKhoan
            // 
            this.picQuanLyTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("picQuanLyTaiKhoan.Image")));
            this.picQuanLyTaiKhoan.Location = new System.Drawing.Point(332, 230);
            this.picQuanLyTaiKhoan.Name = "picQuanLyTaiKhoan";
            this.picQuanLyTaiKhoan.Size = new System.Drawing.Size(134, 123);
            this.picQuanLyTaiKhoan.TabIndex = 17;
            this.picQuanLyTaiKhoan.TabStop = false;
            this.toolTip1.SetToolTip(this.picQuanLyTaiKhoan, "Quản Lý Tài Khoản");
            this.picQuanLyTaiKhoan.Click += new System.EventHandler(this.picQuanLyTaiKhoan_Click);
            // 
            // picQuanLyCauHoi
            // 
            this.picQuanLyCauHoi.Image = ((System.Drawing.Image)(resources.GetObject("picQuanLyCauHoi.Image")));
            this.picQuanLyCauHoi.Location = new System.Drawing.Point(562, 230);
            this.picQuanLyCauHoi.Name = "picQuanLyCauHoi";
            this.picQuanLyCauHoi.Size = new System.Drawing.Size(125, 123);
            this.picQuanLyCauHoi.TabIndex = 18;
            this.picQuanLyCauHoi.TabStop = false;
            this.toolTip1.SetToolTip(this.picQuanLyCauHoi, "Quản Lý Câu Hỏi");
            this.picQuanLyCauHoi.Click += new System.EventHandler(this.picQuanLyCauHoi_Click);
            // 
            // pic_ThiTracNghiem
            // 
            this.pic_ThiTracNghiem.Image = ((System.Drawing.Image)(resources.GetObject("pic_ThiTracNghiem.Image")));
            this.pic_ThiTracNghiem.Location = new System.Drawing.Point(94, 219);
            this.pic_ThiTracNghiem.Name = "pic_ThiTracNghiem";
            this.pic_ThiTracNghiem.Size = new System.Drawing.Size(134, 123);
            this.pic_ThiTracNghiem.TabIndex = 19;
            this.pic_ThiTracNghiem.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_ThiTracNghiem, "Nhấn Vào Đây Để Thi Trắc Nghiệm");
            this.pic_ThiTracNghiem.Click += new System.EventHandler(this.pic_ThiTracNghiem_Click);
            // 
            // pic_XemDiem
            // 
            this.pic_XemDiem.Image = ((System.Drawing.Image)(resources.GetObject("pic_XemDiem.Image")));
            this.pic_XemDiem.Location = new System.Drawing.Point(94, 387);
            this.pic_XemDiem.Name = "pic_XemDiem";
            this.pic_XemDiem.Size = new System.Drawing.Size(134, 123);
            this.pic_XemDiem.TabIndex = 20;
            this.pic_XemDiem.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_XemDiem, "Nhấn Vào Đây Để Xem Điểm ");
            this.pic_XemDiem.Click += new System.EventHandler(this.pic_XemDiem_Click);
            // 
            // pic_DangNhapLai
            // 
            this.pic_DangNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("pic_DangNhapLai.Image")));
            this.pic_DangNhapLai.Location = new System.Drawing.Point(332, 398);
            this.pic_DangNhapLai.Name = "pic_DangNhapLai";
            this.pic_DangNhapLai.Size = new System.Drawing.Size(134, 123);
            this.pic_DangNhapLai.TabIndex = 21;
            this.pic_DangNhapLai.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_DangNhapLai, "Nhấn Vào Đây Để Đăng Nhập Lại");
            this.pic_DangNhapLai.Click += new System.EventHandler(this.pic_DangNhapLai_Click);
            // 
            // pic_Thoat
            // 
            this.pic_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("pic_Thoat.Image")));
            this.pic_Thoat.Location = new System.Drawing.Point(562, 398);
            this.pic_Thoat.Name = "pic_Thoat";
            this.pic_Thoat.Size = new System.Drawing.Size(125, 123);
            this.pic_Thoat.TabIndex = 21;
            this.pic_Thoat.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_Thoat, "Nhấn Vào Đây Để Thoát");
            this.pic_Thoat.Click += new System.EventHandler(this.pic_Thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(180, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(474, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thi Trắc Nghiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quản Lý Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quản Lý Câu Hỏi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Đăng Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đăng Nhập Lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Xem Điểm";
            // 
            // frm2_GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 604);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Thoat);
            this.Controls.Add(this.pic_DangNhapLai);
            this.Controls.Add(this.pic_XemDiem);
            this.Controls.Add(this.pic_ThiTracNghiem);
            this.Controls.Add(this.picQuanLyCauHoi);
            this.Controls.Add(this.picQuanLyTaiKhoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTT);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm2_GiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIAO DIỆN CHÍNH";
            this.Load += new System.EventHandler(this.frm2_GiaoDienChinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuanLyTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuanLyCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ThiTracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_XemDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DangNhapLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Timer chuchayChinh;
        private System.Windows.Forms.RadioButton radThiSinh;
        private System.Windows.Forms.RadioButton radNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picQuanLyTaiKhoan;
        private System.Windows.Forms.PictureBox picQuanLyCauHoi;
        private System.Windows.Forms.PictureBox pic_ThiTracNghiem;
        private System.Windows.Forms.PictureBox pic_XemDiem;
        private System.Windows.Forms.PictureBox pic_DangNhapLai;
        private System.Windows.Forms.PictureBox pic_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}