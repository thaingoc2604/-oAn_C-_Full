namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmPhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanLop));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbNamHocCu = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvDSLopCu = new System.Windows.Forms.ListView();
            this.colMaHocSinh = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colNoiSinh = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbLopCu = new System.Windows.Forms.ComboBox();
            this.lbLopCu = new System.Windows.Forms.Label();
            this.cmbKhoiLopCu = new System.Windows.Forms.ComboBox();
            this.lbKhoiLopCu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btXoaHet = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btThemTatCa = new System.Windows.Forms.Button();
            this.gbNamHocMoi = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvDSLopMoi = new System.Windows.Forms.ListView();
            this.colMaHocSinhMoi = new System.Windows.Forms.ColumnHeader();
            this.colHoTenMoi = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinhMoi = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinhMoi = new System.Windows.Forms.ColumnHeader();
            this.colNoiSinhMoi = new System.Windows.Forms.ColumnHeader();
            this.colDiaChiMoi = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbLopMoi = new System.Windows.Forms.ComboBox();
            this.lbLopMoi = new System.Windows.Forms.Label();
            this.cmbKhoiLopMoi = new System.Windows.Forms.ComboBox();
            this.lbKhoiLopMoi = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbNamHocCu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbNamHocMoi.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbNamHocCu);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbNamHocMoi);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 736);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbNamHocCu
            // 
            this.gbNamHocCu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gbNamHocCu.Controls.Add(this.panel1);
            this.gbNamHocCu.Controls.Add(this.panel5);
            this.gbNamHocCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNamHocCu.Location = new System.Drawing.Point(0, 0);
            this.gbNamHocCu.Name = "gbNamHocCu";
            this.gbNamHocCu.Size = new System.Drawing.Size(509, 736);
            this.gbNamHocCu.TabIndex = 2;
            this.gbNamHocCu.TabStop = false;
            this.gbNamHocCu.Text = "Thông tin cũ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvDSLopCu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 625);
            this.panel1.TabIndex = 1;
            // 
            // lvDSLopCu
            // 
            this.lvDSLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colNoiSinh,
            this.colDiaChi});
            this.lvDSLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSLopCu.FullRowSelect = true;
            this.lvDSLopCu.GridLines = true;
            this.lvDSLopCu.Location = new System.Drawing.Point(0, 0);
            this.lvDSLopCu.Name = "lvDSLopCu";
            this.lvDSLopCu.Size = new System.Drawing.Size(503, 625);
            this.lvDSLopCu.TabIndex = 1;
            this.lvDSLopCu.UseCompatibleStateImageBehavior = false;
            this.lvDSLopCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.Text = "Mã Học Sinh";
            this.colMaHocSinh.Width = 81;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Học Tên";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới Tính";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày Sinh";
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.Text = "Nơi Sinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa Chỉ";
            this.colDiaChi.Width = 79;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbLopCu);
            this.panel5.Controls.Add(this.lbLopCu);
            this.panel5.Controls.Add(this.cmbKhoiLopCu);
            this.panel5.Controls.Add(this.lbKhoiLopCu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(503, 92);
            this.panel5.TabIndex = 0;
            // 
            // cmbLopCu
            // 
            this.cmbLopCu.FormattingEnabled = true;
            this.cmbLopCu.Location = new System.Drawing.Point(162, 49);
            this.cmbLopCu.Name = "cmbLopCu";
            this.cmbLopCu.Size = new System.Drawing.Size(146, 21);
            this.cmbLopCu.TabIndex = 2;
            this.cmbLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbLopCu_SelectedIndexChanged);
            // 
            // lbLopCu
            // 
            this.lbLopCu.AutoSize = true;
            this.lbLopCu.Location = new System.Drawing.Point(103, 52);
            this.lbLopCu.Name = "lbLopCu";
            this.lbLopCu.Size = new System.Drawing.Size(28, 13);
            this.lbLopCu.TabIndex = 13;
            this.lbLopCu.Text = "Lớp:";
            // 
            // cmbKhoiLopCu
            // 
            this.cmbKhoiLopCu.FormattingEnabled = true;
            this.cmbKhoiLopCu.Location = new System.Drawing.Point(162, 22);
            this.cmbKhoiLopCu.Name = "cmbKhoiLopCu";
            this.cmbKhoiLopCu.Size = new System.Drawing.Size(103, 21);
            this.cmbKhoiLopCu.TabIndex = 1;
            this.cmbKhoiLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopCu_SelectedIndexChanged);
            // 
            // lbKhoiLopCu
            // 
            this.lbKhoiLopCu.AutoSize = true;
            this.lbKhoiLopCu.Location = new System.Drawing.Point(103, 25);
            this.lbKhoiLopCu.Name = "lbKhoiLopCu";
            this.lbKhoiLopCu.Size = new System.Drawing.Size(48, 13);
            this.lbKhoiLopCu.TabIndex = 12;
            this.lbKhoiLopCu.Text = "Khối lớp:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btBoQua);
            this.panel2.Controls.Add(this.btXoaHet);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.btThemTatCa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(509, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 736);
            this.panel2.TabIndex = 1;
            // 
            // btThoat
            // 
            this.btThoat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btThoat.Location = new System.Drawing.Point(6, 472);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(65, 35);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBoQua.Location = new System.Drawing.Point(6, 390);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(65, 35);
            this.btBoQua.TabIndex = 9;
            this.btBoQua.Text = "Bỏ qua";
            this.btBoQua.UseVisualStyleBackColor = true;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btXoaHet
            // 
            this.btXoaHet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btXoaHet.Location = new System.Drawing.Point(6, 349);
            this.btXoaHet.Name = "btXoaHet";
            this.btXoaHet.Size = new System.Drawing.Size(65, 35);
            this.btXoaHet.TabIndex = 8;
            this.btXoaHet.Text = "Xóa hết";
            this.btXoaHet.UseVisualStyleBackColor = true;
            this.btXoaHet.Click += new System.EventHandler(this.btXoaHet_Click);
            // 
            // btLuu
            // 
            this.btLuu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btLuu.Location = new System.Drawing.Point(6, 431);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(65, 35);
            this.btLuu.TabIndex = 10;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btXoa.Location = new System.Drawing.Point(6, 308);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(65, 35);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btThem.Location = new System.Drawing.Point(6, 267);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(65, 35);
            this.btThem.TabIndex = 6;
            this.btThem.Text = ">";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThemTatCa
            // 
            this.btThemTatCa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btThemTatCa.Location = new System.Drawing.Point(6, 226);
            this.btThemTatCa.Name = "btThemTatCa";
            this.btThemTatCa.Size = new System.Drawing.Size(65, 35);
            this.btThemTatCa.TabIndex = 5;
            this.btThemTatCa.Text = ">>";
            this.btThemTatCa.UseVisualStyleBackColor = true;
            this.btThemTatCa.Click += new System.EventHandler(this.btThemTatCa_Click);
            // 
            // gbNamHocMoi
            // 
            this.gbNamHocMoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gbNamHocMoi.Controls.Add(this.panel4);
            this.gbNamHocMoi.Controls.Add(this.panel3);
            this.gbNamHocMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNamHocMoi.Location = new System.Drawing.Point(0, 0);
            this.gbNamHocMoi.Name = "gbNamHocMoi";
            this.gbNamHocMoi.Size = new System.Drawing.Size(520, 736);
            this.gbNamHocMoi.TabIndex = 0;
            this.gbNamHocMoi.TabStop = false;
            this.gbNamHocMoi.Text = "Thông tin mới";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvDSLopMoi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 625);
            this.panel4.TabIndex = 1;
            // 
            // lvDSLopMoi
            // 
            this.lvDSLopMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHocSinhMoi,
            this.colHoTenMoi,
            this.colGioiTinhMoi,
            this.colNgaySinhMoi,
            this.colNoiSinhMoi,
            this.colDiaChiMoi});
            this.lvDSLopMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSLopMoi.FullRowSelect = true;
            this.lvDSLopMoi.GridLines = true;
            this.lvDSLopMoi.Location = new System.Drawing.Point(0, 0);
            this.lvDSLopMoi.Name = "lvDSLopMoi";
            this.lvDSLopMoi.Size = new System.Drawing.Size(514, 625);
            this.lvDSLopMoi.TabIndex = 1;
            this.lvDSLopMoi.UseCompatibleStateImageBehavior = false;
            this.lvDSLopMoi.View = System.Windows.Forms.View.Details;
            // 
            // colMaHocSinhMoi
            // 
            this.colMaHocSinhMoi.Text = "Mã Học Sinh";
            this.colMaHocSinhMoi.Width = 81;
            // 
            // colHoTenMoi
            // 
            this.colHoTenMoi.Text = "Học Tên";
            // 
            // colGioiTinhMoi
            // 
            this.colGioiTinhMoi.Text = "Giới Tính";
            // 
            // colNgaySinhMoi
            // 
            this.colNgaySinhMoi.Text = "Ngày Sinh";
            // 
            // colNoiSinhMoi
            // 
            this.colNoiSinhMoi.Text = "Nơi Sinh";
            // 
            // colDiaChiMoi
            // 
            this.colDiaChiMoi.Text = "Địa Chỉ";
            this.colDiaChiMoi.Width = 81;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbLopMoi);
            this.panel3.Controls.Add(this.lbLopMoi);
            this.panel3.Controls.Add(this.cmbKhoiLopMoi);
            this.panel3.Controls.Add(this.lbKhoiLopMoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 92);
            this.panel3.TabIndex = 0;
            // 
            // cmbLopMoi
            // 
            this.cmbLopMoi.FormattingEnabled = true;
            this.cmbLopMoi.Location = new System.Drawing.Point(163, 49);
            this.cmbLopMoi.Name = "cmbLopMoi";
            this.cmbLopMoi.Size = new System.Drawing.Size(146, 21);
            this.cmbLopMoi.TabIndex = 4;
            this.cmbLopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbLopMoi_SelectedIndexChanged);
            // 
            // lbLopMoi
            // 
            this.lbLopMoi.AutoSize = true;
            this.lbLopMoi.Location = new System.Drawing.Point(104, 52);
            this.lbLopMoi.Name = "lbLopMoi";
            this.lbLopMoi.Size = new System.Drawing.Size(28, 13);
            this.lbLopMoi.TabIndex = 4;
            this.lbLopMoi.Text = "Lớp:";
            // 
            // cmbKhoiLopMoi
            // 
            this.cmbKhoiLopMoi.FormattingEnabled = true;
            this.cmbKhoiLopMoi.Location = new System.Drawing.Point(163, 22);
            this.cmbKhoiLopMoi.Name = "cmbKhoiLopMoi";
            this.cmbKhoiLopMoi.Size = new System.Drawing.Size(103, 21);
            this.cmbKhoiLopMoi.TabIndex = 3;
            this.cmbKhoiLopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopMoi_SelectedIndexChanged);
            // 
            // lbKhoiLopMoi
            // 
            this.lbKhoiLopMoi.AutoSize = true;
            this.lbKhoiLopMoi.Location = new System.Drawing.Point(104, 25);
            this.lbKhoiLopMoi.Name = "lbKhoiLopMoi";
            this.lbKhoiLopMoi.Size = new System.Drawing.Size(48, 13);
            this.lbKhoiLopMoi.TabIndex = 3;
            this.lbKhoiLopMoi.Text = "Khối lớp:";
            // 
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 736);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhanLop";
            this.Text = "Phan lop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbNamHocCu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbNamHocMoi.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbNamHocMoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvDSLopMoi;
        private System.Windows.Forms.ColumnHeader colMaHocSinhMoi;
        private System.Windows.Forms.ColumnHeader colHoTenMoi;
        private System.Windows.Forms.ColumnHeader colGioiTinhMoi;
        private System.Windows.Forms.ColumnHeader colNgaySinhMoi;
        private System.Windows.Forms.ColumnHeader colNoiSinhMoi;
        private System.Windows.Forms.ColumnHeader colDiaChiMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThemTatCa;
        private System.Windows.Forms.GroupBox gbNamHocCu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvDSLopCu;
        private System.Windows.Forms.ColumnHeader colMaHocSinh;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colNoiSinh;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbLopCu;
        private System.Windows.Forms.Label lbLopCu;
        private System.Windows.Forms.ComboBox cmbKhoiLopCu;
        private System.Windows.Forms.Label lbKhoiLopCu;
        private System.Windows.Forms.ComboBox cmbLopMoi;
        private System.Windows.Forms.Label lbLopMoi;
        private System.Windows.Forms.ComboBox cmbKhoiLopMoi;
        private System.Windows.Forms.Label lbKhoiLopMoi;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btXoaHet;

    }
}