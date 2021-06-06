namespace DeTai_QuanLySinhVien
{
    partial class frmDanhSachNguoiDung
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
            this.pnDanhSachNguoiDung = new DevComponents.DotNetBar.PanelEx();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.gpDanhSachNguoiDung = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lsDanhSachNguoiDung = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colTenDangNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMatKhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuyenHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtQuyenHan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnDanhSachNguoiDung.SuspendLayout();
            this.gpDanhSachNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhSachNguoiDung
            // 
            this.pnDanhSachNguoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnDanhSachNguoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnDanhSachNguoiDung.Controls.Add(this.gpDanhSachNguoiDung);
            this.pnDanhSachNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhSachNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.pnDanhSachNguoiDung.Name = "pnDanhSachNguoiDung";
            this.pnDanhSachNguoiDung.Size = new System.Drawing.Size(651, 429);
            this.pnDanhSachNguoiDung.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnDanhSachNguoiDung.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnDanhSachNguoiDung.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnDanhSachNguoiDung.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnDanhSachNguoiDung.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnDanhSachNguoiDung.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnDanhSachNguoiDung.Style.GradientAngle = 90;
            this.pnDanhSachNguoiDung.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(86, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 37);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(214, 342);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 37);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(328, 342);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 37);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(447, 342);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 37);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gpDanhSachNguoiDung
            // 
            this.gpDanhSachNguoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDanhSachNguoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDanhSachNguoiDung.Controls.Add(this.txtQuyenHan);
            this.gpDanhSachNguoiDung.Controls.Add(this.labelX3);
            this.gpDanhSachNguoiDung.Controls.Add(this.txtMatKhau);
            this.gpDanhSachNguoiDung.Controls.Add(this.labelX2);
            this.gpDanhSachNguoiDung.Controls.Add(this.txtTenDangNhap);
            this.gpDanhSachNguoiDung.Controls.Add(this.labelX1);
            this.gpDanhSachNguoiDung.Controls.Add(this.lsDanhSachNguoiDung);
            this.gpDanhSachNguoiDung.Controls.Add(this.btnThem);
            this.gpDanhSachNguoiDung.Controls.Add(this.btnThoat);
            this.gpDanhSachNguoiDung.Controls.Add(this.btnSua);
            this.gpDanhSachNguoiDung.Controls.Add(this.btnXoa);
            this.gpDanhSachNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDanhSachNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDanhSachNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.gpDanhSachNguoiDung.Name = "gpDanhSachNguoiDung";
            this.gpDanhSachNguoiDung.Size = new System.Drawing.Size(651, 429);
            // 
            // 
            // 
            this.gpDanhSachNguoiDung.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpDanhSachNguoiDung.Style.BackColorGradientAngle = 90;
            this.gpDanhSachNguoiDung.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpDanhSachNguoiDung.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSachNguoiDung.Style.BorderBottomWidth = 1;
            this.gpDanhSachNguoiDung.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpDanhSachNguoiDung.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSachNguoiDung.Style.BorderLeftWidth = 1;
            this.gpDanhSachNguoiDung.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSachNguoiDung.Style.BorderRightWidth = 1;
            this.gpDanhSachNguoiDung.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDanhSachNguoiDung.Style.BorderTopWidth = 1;
            this.gpDanhSachNguoiDung.Style.Class = "";
            this.gpDanhSachNguoiDung.Style.CornerDiameter = 4;
            this.gpDanhSachNguoiDung.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpDanhSachNguoiDung.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpDanhSachNguoiDung.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpDanhSachNguoiDung.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpDanhSachNguoiDung.StyleMouseDown.Class = "";
            this.gpDanhSachNguoiDung.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpDanhSachNguoiDung.StyleMouseOver.Class = "";
            this.gpDanhSachNguoiDung.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpDanhSachNguoiDung.TabIndex = 4;
            this.gpDanhSachNguoiDung.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // lsDanhSachNguoiDung
            // 
            this.lsDanhSachNguoiDung.Activation = System.Windows.Forms.ItemActivation.OneClick;
            // 
            // 
            // 
            this.lsDanhSachNguoiDung.Border.Class = "ListViewBorder";
            this.lsDanhSachNguoiDung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsDanhSachNguoiDung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenDangNhap,
            this.colMatKhau,
            this.colQuyenHan});
            this.lsDanhSachNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsDanhSachNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsDanhSachNguoiDung.GridLines = true;
            this.lsDanhSachNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.lsDanhSachNguoiDung.Name = "lsDanhSachNguoiDung";
            this.lsDanhSachNguoiDung.Size = new System.Drawing.Size(645, 211);
            this.lsDanhSachNguoiDung.TabIndex = 4;
            this.lsDanhSachNguoiDung.UseCompatibleStateImageBehavior = false;
            this.lsDanhSachNguoiDung.View = System.Windows.Forms.View.Details;
            this.lsDanhSachNguoiDung.SelectedIndexChanged += new System.EventHandler(this.lsDanhSachNguoiDung_SelectedIndexChanged);
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.Text = "Tên Đăng Nhập";
            this.colTenDangNhap.Width = 239;
            // 
            // colMatKhau
            // 
            this.colMatKhau.Text = "Mật Khẩu";
            this.colMatKhau.Width = 202;
            // 
            // colQuyenHan
            // 
            this.colQuyenHan.Text = "Quyền Hạn";
            this.colQuyenHan.Width = 366;
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(239, 267);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(197, 26);
            this.txtMatKhau.TabIndex = 14;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(86, 267);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Mật Khẩu :";
            // 
            // txtTenDangNhap
            // 
            // 
            // 
            // 
            this.txtTenDangNhap.Border.Class = "TextBoxBorder";
            this.txtTenDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(239, 232);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(197, 26);
            this.txtTenDangNhap.TabIndex = 13;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(86, 234);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(115, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "Tên Đăng Nhập :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(86, 302);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(115, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Quyền Hạn";
            // 
            // txtQuyenHan
            // 
            // 
            // 
            // 
            this.txtQuyenHan.Border.Class = "TextBoxBorder";
            this.txtQuyenHan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyenHan.Location = new System.Drawing.Point(239, 299);
            this.txtQuyenHan.Name = "txtQuyenHan";
            this.txtQuyenHan.Size = new System.Drawing.Size(197, 26);
            this.txtQuyenHan.TabIndex = 18;
            // 
            // frmDanhSachNguoiDung
            // 
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(651, 429);
            this.Controls.Add(this.pnDanhSachNguoiDung);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhSachNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Người Dùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachNguoiDung_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSachNguoiDung_Load);
            this.pnDanhSachNguoiDung.ResumeLayout(false);
            this.gpDanhSachNguoiDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnDanhSachNguoiDung;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.GroupPanel gpDanhSachNguoiDung;
        private DevComponents.DotNetBar.Controls.ListViewEx lsDanhSachNguoiDung;
        private System.Windows.Forms.ColumnHeader colTenDangNhap;
        private System.Windows.Forms.ColumnHeader colMatKhau;
        private System.Windows.Forms.ColumnHeader colQuyenHan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQuyenHan;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDangNhap;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}