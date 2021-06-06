namespace DeTai_QuanLySinhVien
{
    partial class frmDanhSachLop
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
            this.pnDanhSachLop = new DevComponents.DotNetBar.PanelEx();
            this.gpHienThi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtTenLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.lsvDanhSachLop = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpChonthongTin = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnHienThiDSLop = new DevComponents.DotNetBar.ButtonX();
            this.lblDanhSachKhoa = new DevComponents.DotNetBar.LabelX();
            this.cbDanhSachKhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.pnDanhSachLop.SuspendLayout();
            this.gpHienThi.SuspendLayout();
            this.gpChonthongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhSachLop
            // 
            this.pnDanhSachLop.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnDanhSachLop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnDanhSachLop.Controls.Add(this.gpHienThi);
            this.pnDanhSachLop.Controls.Add(this.gpChonthongTin);
            this.pnDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.pnDanhSachLop.Name = "pnDanhSachLop";
            this.pnDanhSachLop.Size = new System.Drawing.Size(858, 505);
            this.pnDanhSachLop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnDanhSachLop.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnDanhSachLop.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnDanhSachLop.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnDanhSachLop.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnDanhSachLop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnDanhSachLop.Style.GradientAngle = 90;
            this.pnDanhSachLop.TabIndex = 0;
            this.pnDanhSachLop.Click += new System.EventHandler(this.pnDanhSachLop_Click);
            // 
            // gpHienThi
            // 
            this.gpHienThi.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpHienThi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpHienThi.Controls.Add(this.txtTenLop);
            this.gpHienThi.Controls.Add(this.txtMaLop);
            this.gpHienThi.Controls.Add(this.labelX2);
            this.gpHienThi.Controls.Add(this.labelX1);
            this.gpHienThi.Controls.Add(this.btnThoat);
            this.gpHienThi.Controls.Add(this.btnSua);
            this.gpHienThi.Controls.Add(this.btnXoa);
            this.gpHienThi.Controls.Add(this.btnThem);
            this.gpHienThi.Controls.Add(this.lsvDanhSachLop);
            this.gpHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpHienThi.Location = new System.Drawing.Point(0, 100);
            this.gpHienThi.Name = "gpHienThi";
            this.gpHienThi.Size = new System.Drawing.Size(858, 405);
            // 
            // 
            // 
            this.gpHienThi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpHienThi.Style.BackColorGradientAngle = 90;
            this.gpHienThi.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpHienThi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpHienThi.Style.BorderBottomWidth = 1;
            this.gpHienThi.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpHienThi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpHienThi.Style.BorderLeftWidth = 1;
            this.gpHienThi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpHienThi.Style.BorderRightWidth = 1;
            this.gpHienThi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpHienThi.Style.BorderTopWidth = 1;
            this.gpHienThi.Style.Class = "";
            this.gpHienThi.Style.CornerDiameter = 4;
            this.gpHienThi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpHienThi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpHienThi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpHienThi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpHienThi.StyleMouseDown.Class = "";
            this.gpHienThi.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpHienThi.StyleMouseOver.Class = "";
            this.gpHienThi.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpHienThi.TabIndex = 1;
            this.gpHienThi.Text = "Hiển Thị Danh Sách Lớp";
            // 
            // txtTenLop
            // 
            // 
            // 
            // 
            this.txtTenLop.Border.Class = "TextBoxBorder";
            this.txtTenLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(344, 275);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(235, 26);
            this.txtTenLop.TabIndex = 8;
            // 
            // txtMaLop
            // 
            // 
            // 
            // 
            this.txtMaLop.Border.Class = "TextBoxBorder";
            this.txtMaLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(344, 233);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(235, 26);
            this.txtMaLop.TabIndex = 7;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(226, 278);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Tên Lớp :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(226, 233);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Mã Lớp :";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThoat.Image = global::DeTai_QuanLySinhVien.Properties.Resources.exit;
            this.btnThoat.Location = new System.Drawing.Point(580, 313);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 53);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSua.Image = global::DeTai_QuanLySinhVien.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(415, 313);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 53);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoa.Image = global::DeTai_QuanLySinhVien.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(266, 313);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 53);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThem.Image = global::DeTai_QuanLySinhVien.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(120, 313);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 53);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lsvDanhSachLop
            // 
            this.lsvDanhSachLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.lsvDanhSachLop.Border.Class = "ListViewBorder";
            this.lsvDanhSachLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsvDanhSachLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLop,
            this.colTenLop});
            this.lsvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsvDanhSachLop.FullRowSelect = true;
            this.lsvDanhSachLop.GridLines = true;
            this.lsvDanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.lsvDanhSachLop.Name = "lsvDanhSachLop";
            this.lsvDanhSachLop.Size = new System.Drawing.Size(852, 217);
            this.lsvDanhSachLop.TabIndex = 0;
            this.lsvDanhSachLop.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachLop.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachLop.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachLop_SelectedIndexChanged);
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã Lớp";
            this.colMaLop.Width = 185;
            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Tên Lớp";
            this.colTenLop.Width = 706;
            // 
            // gpChonthongTin
            // 
            this.gpChonthongTin.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpChonthongTin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpChonthongTin.Controls.Add(this.btnHienThiDSLop);
            this.gpChonthongTin.Controls.Add(this.lblDanhSachKhoa);
            this.gpChonthongTin.Controls.Add(this.cbDanhSachKhoa);
            this.gpChonthongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpChonthongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpChonthongTin.Location = new System.Drawing.Point(0, 0);
            this.gpChonthongTin.Name = "gpChonthongTin";
            this.gpChonthongTin.Size = new System.Drawing.Size(858, 100);
            // 
            // 
            // 
            this.gpChonthongTin.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpChonthongTin.Style.BackColorGradientAngle = 90;
            this.gpChonthongTin.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpChonthongTin.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpChonthongTin.Style.BorderBottomWidth = 1;
            this.gpChonthongTin.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpChonthongTin.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpChonthongTin.Style.BorderLeftWidth = 1;
            this.gpChonthongTin.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpChonthongTin.Style.BorderRightWidth = 1;
            this.gpChonthongTin.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpChonthongTin.Style.BorderTopWidth = 1;
            this.gpChonthongTin.Style.Class = "";
            this.gpChonthongTin.Style.CornerDiameter = 4;
            this.gpChonthongTin.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpChonthongTin.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpChonthongTin.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpChonthongTin.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpChonthongTin.StyleMouseDown.Class = "";
            this.gpChonthongTin.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpChonthongTin.StyleMouseOver.Class = "";
            this.gpChonthongTin.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpChonthongTin.TabIndex = 0;
            this.gpChonthongTin.Text = "Chọn Thông Tin";
            // 
            // btnHienThiDSLop
            // 
            this.btnHienThiDSLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThiDSLop.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnHienThiDSLop.Location = new System.Drawing.Point(660, 15);
            this.btnHienThiDSLop.Name = "btnHienThiDSLop";
            this.btnHienThiDSLop.Size = new System.Drawing.Size(175, 33);
            this.btnHienThiDSLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHienThiDSLop.TabIndex = 2;
            this.btnHienThiDSLop.Text = "Danh Sách Lớp";
            this.btnHienThiDSLop.Click += new System.EventHandler(this.btnHienThiDSLop_Click);
            // 
            // lblDanhSachKhoa
            // 
            // 
            // 
            // 
            this.lblDanhSachKhoa.BackgroundStyle.Class = "";
            this.lblDanhSachKhoa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDanhSachKhoa.Location = new System.Drawing.Point(106, 15);
            this.lblDanhSachKhoa.Name = "lblDanhSachKhoa";
            this.lblDanhSachKhoa.Size = new System.Drawing.Size(247, 34);
            this.lblDanhSachKhoa.TabIndex = 1;
            this.lblDanhSachKhoa.Text = "Danh Sách Các Khoa :";
            // 
            // cbDanhSachKhoa
            // 
            this.cbDanhSachKhoa.DisplayMember = "Text";
            this.cbDanhSachKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDanhSachKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDanhSachKhoa.FormattingEnabled = true;
            this.cbDanhSachKhoa.ItemHeight = 29;
            this.cbDanhSachKhoa.Location = new System.Drawing.Point(368, 14);
            this.cbDanhSachKhoa.Name = "cbDanhSachKhoa";
            this.cbDanhSachKhoa.Size = new System.Drawing.Size(286, 35);
            this.cbDanhSachKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDanhSachKhoa.TabIndex = 0;
            this.cbDanhSachKhoa.SelectedIndexChanged += new System.EventHandler(this.cbDanhSachKhoa_SelectedIndexChanged);
            // 
            // frmDanhSachLop
            // 
            this.ClientSize = new System.Drawing.Size(858, 505);
            this.Controls.Add(this.pnDanhSachLop);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachLop_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSachLop_Load);
            this.pnDanhSachLop.ResumeLayout(false);
            this.gpHienThi.ResumeLayout(false);
            this.gpChonthongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnDanhSachLop;
        private DevComponents.DotNetBar.Controls.GroupPanel gpHienThi;
        private DevComponents.DotNetBar.Controls.GroupPanel gpChonthongTin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbDanhSachKhoa;
        private DevComponents.DotNetBar.LabelX lblDanhSachKhoa;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.ListViewEx lsvDanhSachLop;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private DevComponents.DotNetBar.ButtonX btnHienThiDSLop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLop;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}