namespace AnTCafe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMLoaiKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDMHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapGia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHangBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtHàngQuaSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKeBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKeHangTrongKho = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuNghiepVu,
            this.mnuThongKe});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(799, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSNhanvien,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.mnuHeThong.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDSNhanvien
            // 
            this.mnuDSNhanvien.Name = "mnuDSNhanvien";
            this.mnuDSNhanvien.Size = new System.Drawing.Size(184, 22);
            this.mnuDSNhanvien.Text = "Danh sách nhân viên";
            this.mnuDSNhanvien.Click += new System.EventHandler(this.mnuDSNhanvien_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "&Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMBan,
            this.mnuDMLoaiKhach,
            this.toolStripSeparator7,
            this.mnuDMHang});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuDMBan
            // 
            this.mnuDMBan.Name = "mnuDMBan";
            this.mnuDMBan.Size = new System.Drawing.Size(186, 22);
            this.mnuDMBan.Text = "Danh mục bàn";
            this.mnuDMBan.Click += new System.EventHandler(this.mnuDMBan_Click);
            // 
            // mnuDMLoaiKhach
            // 
            this.mnuDMLoaiKhach.Name = "mnuDMLoaiKhach";
            this.mnuDMLoaiKhach.Size = new System.Drawing.Size(186, 22);
            this.mnuDMLoaiKhach.Text = "Danh mục loại khách";
            this.mnuDMLoaiKhach.Click += new System.EventHandler(this.mnuDMLoaiKhach_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuDMHang
            // 
            this.mnuDMHang.Name = "mnuDMHang";
            this.mnuDMHang.Size = new System.Drawing.Size(186, 22);
            this.mnuDMHang.Text = "Danh mục hàng";
            this.mnuDMHang.Click += new System.EventHandler(this.mnuDMHang_Click);
            // 
            // mnuNghiepVu
            // 
            this.mnuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapGia,
            this.toolStripSeparator1,
            this.mnuNhapHang,
            this.mnuQuanLyPhieuNhap,
            this.toolStripSeparator9,
            this.mnuHangBan,
            this.mnuBanHang,
            this.đặtHàngQuaSMSToolStripMenuItem});
            this.mnuNghiepVu.Name = "mnuNghiepVu";
            this.mnuNghiepVu.Size = new System.Drawing.Size(74, 20);
            this.mnuNghiepVu.Text = "&Nghiệp vụ";
            // 
            // mnuNhapGia
            // 
            this.mnuNhapGia.Name = "mnuNhapGia";
            this.mnuNhapGia.Size = new System.Drawing.Size(178, 22);
            this.mnuNhapGia.Text = "Cật nhật giá bán";
            this.mnuNhapGia.Click += new System.EventHandler(this.mnuNhapGia_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // mnuNhapHang
            // 
            this.mnuNhapHang.Name = "mnuNhapHang";
            this.mnuNhapHang.Size = new System.Drawing.Size(178, 22);
            this.mnuNhapHang.Text = "Nhập hàng";
            this.mnuNhapHang.Click += new System.EventHandler(this.mnuNhapHang_Click);
            // 
            // mnuQuanLyPhieuNhap
            // 
            this.mnuQuanLyPhieuNhap.Name = "mnuQuanLyPhieuNhap";
            this.mnuQuanLyPhieuNhap.Size = new System.Drawing.Size(178, 22);
            this.mnuQuanLyPhieuNhap.Text = "Quản lý phiếu nhập";
            this.mnuQuanLyPhieuNhap.Click += new System.EventHandler(this.mnuQuanLyPhieuNhap_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(175, 6);
            // 
            // mnuHangBan
            // 
            this.mnuHangBan.Name = "mnuHangBan";
            this.mnuHangBan.Size = new System.Drawing.Size(178, 22);
            this.mnuHangBan.Text = "Quản lý hàng bán";
            this.mnuHangBan.Click += new System.EventHandler(this.mnuHangBan_Click);
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(178, 22);
            this.mnuBanHang.Text = "Bán hàng";
            this.mnuBanHang.Click += new System.EventHandler(this.mnuBanHang_Click);
            // 
            // đặtHàngQuaSMSToolStripMenuItem
            // 
            this.đặtHàngQuaSMSToolStripMenuItem.Name = "đặtHàngQuaSMSToolStripMenuItem";
            this.đặtHàngQuaSMSToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.đặtHàngQuaSMSToolStripMenuItem.Text = "Đặt hàng qua SMS";
            this.đặtHàngQuaSMSToolStripMenuItem.Click += new System.EventHandler(this.đặtHàngQuaSMSToolStripMenuItem_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTKeBanHang,
            this.mnuTKeHangTrongKho});
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(69, 20);
            this.mnuThongKe.Text = "&Thống kê";
            // 
            // mnuTKeBanHang
            // 
            this.mnuTKeBanHang.Name = "mnuTKeBanHang";
            this.mnuTKeBanHang.Size = new System.Drawing.Size(209, 22);
            this.mnuTKeBanHang.Text = "&Thống kê bán hàng";
            this.mnuTKeBanHang.Click += new System.EventHandler(this.mnuTKeBanHang_Click);
            // 
            // mnuTKeHangTrongKho
            // 
            this.mnuTKeHangTrongKho.Name = "mnuTKeHangTrongKho";
            this.mnuTKeHangTrongKho.Size = new System.Drawing.Size(209, 22);
            this.mnuTKeHangTrongKho.Text = "Thống kê hàng trong kho";
            this.mnuTKeHangTrongKho.Click += new System.EventHandler(this.mnuTKeHangTrongKho_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(799, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 466);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(799, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(292, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Người sử dụng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(116, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên đăng nhập:\r\n";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Blue;
            this.lblMaNV.Location = new System.Drawing.Point(213, 51);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(11, 14);
            this.lblMaNV.TabIndex = 20;
            this.lblMaNV.Text = "-";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Blue;
            this.lblTenNV.Location = new System.Drawing.Point(390, 51);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(11, 14);
            this.lblTenNV.TabIndex = 19;
            this.lblTenNV.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AnTCafe.Properties.Resources.nenct;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý fastCafeManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuTKeBanHang;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuDMBan;
        private System.Windows.Forms.ToolStripMenuItem mnuDMLoaiKhach;
        private System.Windows.Forms.ToolStripMenuItem mnuDMHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTKeHangTrongKho;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHangBan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDSNhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.ToolStripMenuItem đặtHàngQuaSMSToolStripMenuItem;
    }
}



