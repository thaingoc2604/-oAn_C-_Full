namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmDSHocSinh_Lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSHocSinh_Lop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReport = new System.Windows.Forms.Button();
            this.cmbChonNam = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKhoiLop = new System.Windows.Forms.ComboBox();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDSLopHoc = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgàySinh = new System.Windows.Forms.ColumnHeader();
            this.colNoiSinh = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 66);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.btReport);
            this.groupBox1.Controls.Add(this.cmbChonNam);
            this.groupBox1.Controls.Add(this.cmbLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbKhoiLop);
            this.groupBox1.Controls.Add(this.lbNamHoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(599, 19);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(75, 23);
            this.btReport.TabIndex = 4;
            this.btReport.Text = "Report";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // cmbChonNam
            // 
            this.cmbChonNam.FormattingEnabled = true;
            this.cmbChonNam.Location = new System.Drawing.Point(61, 19);
            this.cmbChonNam.Name = "cmbChonNam";
            this.cmbChonNam.Size = new System.Drawing.Size(121, 21);
            this.cmbChonNam.TabIndex = 1;
            this.cmbChonNam.SelectedIndexChanged += new System.EventHandler(this.cmbChonNam_SelectedIndexChanged);
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(448, 19);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 3;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lớp:";
            // 
            // cmbKhoiLop
            // 
            this.cmbKhoiLop.FormattingEnabled = true;
            this.cmbKhoiLop.Location = new System.Drawing.Point(261, 19);
            this.cmbKhoiLop.Name = "cmbKhoiLop";
            this.cmbKhoiLop.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoiLop.TabIndex = 2;
            this.cmbKhoiLop.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLop_SelectedIndexChanged);
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.Location = new System.Drawing.Point(8, 22);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(55, 13);
            this.lbNamHoc.TabIndex = 4;
            this.lbNamHoc.Text = "Năm Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khối Lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 508);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.lvDSLopHoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1090, 508);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học sinh";
            // 
            // lvDSLopHoc
            // 
            this.lvDSLopHoc.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lvDSLopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgàySinh,
            this.colNoiSinh,
            this.colDiaChi});
            this.lvDSLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSLopHoc.FullRowSelect = true;
            this.lvDSLopHoc.Location = new System.Drawing.Point(3, 16);
            this.lvDSLopHoc.Name = "lvDSLopHoc";
            this.lvDSLopHoc.Size = new System.Drawing.Size(1084, 489);
            this.lvDSLopHoc.TabIndex = 1;
            this.lvDSLopHoc.UseCompatibleStateImageBehavior = false;
            this.lvDSLopHoc.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "Mã học sinh";
            this.colSTT.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 157;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            // 
            // colNgàySinh
            // 
            this.colNgàySinh.Text = "Ngày sinh";
            this.colNgàySinh.Width = 93;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.Text = "Nơi sinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            // 
            // frmDSHocSinh_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDSHocSinh_Lop";
            this.Text = "Danh sách học sinh theo lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSHocSinh_Lop_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbChonNam;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoiLop;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDSLopHoc;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.ColumnHeader colNgàySinh;
        private System.Windows.Forms.ColumnHeader colNoiSinh;
        private System.Windows.Forms.ColumnHeader colDiaChi;
    }
}