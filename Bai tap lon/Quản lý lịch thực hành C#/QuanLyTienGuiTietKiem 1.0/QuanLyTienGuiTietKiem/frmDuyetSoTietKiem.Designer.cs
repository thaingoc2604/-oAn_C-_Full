namespace QuanLyTienGuiTietKiem
{
    partial class frmDuyetSoTietKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuyetSoTietKiem));
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.LVHanMoi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaSoTKDuyet = new System.Windows.Forms.ColumnHeader();
            this.colTenKhachHang = new System.Windows.Forms.ColumnHeader();
            this.colTenLTK = new System.Windows.Forms.ColumnHeader();
            this.colSoTienDuyet = new System.Windows.Forms.ColumnHeader();
            this.colLoaiTienDuyet = new System.Windows.Forms.ColumnHeader();
            this.LVHanCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaSoTietKiem = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colTenLoaiTietKiem = new System.Windows.Forms.ColumnHeader();
            this.colSoDu = new System.Windows.Forms.ColumnHeader();
            this.colLoaiTien = new System.Windows.Forms.ColumnHeader();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnDuyet = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaDuyet = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblNgayGiaoDich = new DevComponents.DotNetBar.LabelX();
            this.cmbNgayGiaoDich = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.DongDuyet;
            this.btnThoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThoat.Location = new System.Drawing.Point(5, 343);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 52);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // LVHanMoi
            // 
            // 
            // 
            // 
            this.LVHanMoi.Border.Class = "ListViewBorder";
            this.LVHanMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSoTKDuyet,
            this.colTenKhachHang,
            this.colTenLTK,
            this.colSoTienDuyet,
            this.colLoaiTienDuyet});
            this.LVHanMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVHanMoi.FullRowSelect = true;
            this.LVHanMoi.Location = new System.Drawing.Point(0, 0);
            this.LVHanMoi.Name = "LVHanMoi";
            this.LVHanMoi.Size = new System.Drawing.Size(460, 493);
            this.LVHanMoi.TabIndex = 2;
            this.LVHanMoi.UseCompatibleStateImageBehavior = false;
            this.LVHanMoi.View = System.Windows.Forms.View.Details;
            // 
            // colMaSoTKDuyet
            // 
            this.colMaSoTKDuyet.Text = "Mã sổ tiết kiệm";
            this.colMaSoTKDuyet.Width = 105;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Text = "Tên khách hàng";
            this.colTenKhachHang.Width = 104;
            // 
            // colTenLTK
            // 
            this.colTenLTK.Text = "Tên loại tiết kiệm";
            this.colTenLTK.Width = 163;
            // 
            // colSoTienDuyet
            // 
            this.colSoTienDuyet.Text = "Số tiền";
            // 
            // colLoaiTienDuyet
            // 
            this.colLoaiTienDuyet.Text = "Loại tiền";
            // 
            // LVHanCu
            // 
            // 
            // 
            // 
            this.LVHanCu.Border.Class = "ListViewBorder";
            this.LVHanCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSoTietKiem,
            this.colHoTen,
            this.colTenLoaiTietKiem,
            this.colSoDu,
            this.colLoaiTien});
            this.LVHanCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVHanCu.FullRowSelect = true;
            this.LVHanCu.Location = new System.Drawing.Point(0, 0);
            this.LVHanCu.Name = "LVHanCu";
            this.LVHanCu.Size = new System.Drawing.Size(475, 393);
            this.LVHanCu.TabIndex = 2;
            this.LVHanCu.UseCompatibleStateImageBehavior = false;
            this.LVHanCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaSoTietKiem
            // 
            this.colMaSoTietKiem.Text = "Mã sổ tiết kiệm";
            this.colMaSoTietKiem.Width = 93;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Tên khách hàng";
            this.colHoTen.Width = 101;
            // 
            // colTenLoaiTietKiem
            // 
            this.colTenLoaiTietKiem.Text = "Tên loại tiết kiệm";
            this.colTenLoaiTietKiem.Width = 125;
            // 
            // colSoDu
            // 
            this.colSoDu.Text = "Số Du";
            this.colSoDu.Width = 95;
            // 
            // colLoaiTien
            // 
            this.colLoaiTien.Text = "Loại tiền";
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnDuyet);
            this.groupPanel3.Controls.Add(this.btnThoat);
            this.groupPanel3.Controls.Add(this.btnXoaDuyet);
            this.groupPanel3.Controls.Add(this.btnLuu);
            this.groupPanel3.Location = new System.Drawing.Point(5, 15);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(80, 475);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 3;
            this.groupPanel3.Click += new System.EventHandler(this.groupPanel3_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDuyet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDuyet.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Duyet;
            this.btnDuyet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDuyet.Location = new System.Drawing.Point(5, 129);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(68, 69);
            this.btnDuyet.TabIndex = 0;
            this.btnDuyet.Text = "<div align=\"center\">Duyệt<br /> <font size=\'-1\'>lãi nhập vốn</font></div>";
            this.btnDuyet.Tooltip = "Duyệt chuyển kỳ han sổ";
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnXoaDuyet
            // 
            this.btnXoaDuyet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaDuyet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaDuyet.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.XoaDuyet;
            this.btnXoaDuyet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoaDuyet.Location = new System.Drawing.Point(6, 206);
            this.btnXoaDuyet.Name = "btnXoaDuyet";
            this.btnXoaDuyet.Size = new System.Drawing.Size(68, 52);
            this.btnXoaDuyet.TabIndex = 0;
            this.btnXoaDuyet.Text = "Xóa duyệt";
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.LuuDuyetSo;
            this.btnLuu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLuu.Location = new System.Drawing.Point(6, 274);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 52);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Tooltip = "Lưu duyệt chuyển kỳ hạn";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 493);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LVHanCu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 393);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 100);
            this.panel2.TabIndex = 4;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblNgayGiaoDich);
            this.groupPanel1.Controls.Add(this.cmbNgayGiaoDich);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(475, 100);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "Chọn ngày giao dịch";
            // 
            // lblNgayGiaoDich
            // 
            this.lblNgayGiaoDich.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayGiaoDich.ForeColor = System.Drawing.Color.Red;
            this.lblNgayGiaoDich.Location = new System.Drawing.Point(175, 3);
            this.lblNgayGiaoDich.Name = "lblNgayGiaoDich";
            this.lblNgayGiaoDich.Size = new System.Drawing.Size(186, 23);
            this.lblNgayGiaoDich.TabIndex = 2;
            // 
            // cmbNgayGiaoDich
            // 
            this.cmbNgayGiaoDich.DisplayMember = "Text";
            this.cmbNgayGiaoDich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNgayGiaoDich.FormattingEnabled = true;
            this.cmbNgayGiaoDich.ItemHeight = 14;
            this.cmbNgayGiaoDich.Location = new System.Drawing.Point(175, 32);
            this.cmbNgayGiaoDich.Name = "cmbNgayGiaoDich";
            this.cmbNgayGiaoDich.Size = new System.Drawing.Size(163, 20);
            this.cmbNgayGiaoDich.TabIndex = 1;
            this.cmbNgayGiaoDich.SelectedIndexChanged += new System.EventHandler(this.cmbNgayGiaoDich_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(69, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Ngày giao dịch";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LVHanMoi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(566, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 493);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupPanel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(475, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 493);
            this.panel5.TabIndex = 6;
            // 
            // frmDuyetSoTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 493);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDuyetSoTietKiem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUYỆT SỔ TIẾT KIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDuyetSoTietKiem_Load);
            this.groupPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnXoaDuyet;
        private DevComponents.DotNetBar.ButtonX btnDuyet;
        private DevComponents.DotNetBar.Controls.ListViewEx LVHanMoi;
        private DevComponents.DotNetBar.Controls.ListViewEx LVHanCu;
        private System.Windows.Forms.ColumnHeader colMaSoTietKiem;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colTenLoaiTietKiem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.ColumnHeader colSoDu;
        private System.Windows.Forms.ColumnHeader colLoaiTien;
        private System.Windows.Forms.ColumnHeader colMaSoTKDuyet;
        private System.Windows.Forms.ColumnHeader colTenKhachHang;
        private System.Windows.Forms.ColumnHeader colTenLTK;
        private System.Windows.Forms.ColumnHeader colSoTienDuyet;
        private System.Windows.Forms.ColumnHeader colLoaiTienDuyet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX lblNgayGiaoDich;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNgayGiaoDich;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}