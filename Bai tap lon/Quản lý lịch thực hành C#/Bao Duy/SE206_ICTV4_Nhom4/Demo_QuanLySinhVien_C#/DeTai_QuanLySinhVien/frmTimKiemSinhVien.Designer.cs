namespace DeTai_QuanLySinhVien
{
    partial class frmTimKiemSinhVien
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
            this.pnTimKiemSinhVien = new DevComponents.DotNetBar.PanelEx();
            this.gpKetQuaTimKiem = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.lsvKetQua = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpNhapThongTinCanTim = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbTimKiemTheo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbitenMaSV = new DevComponents.Editors.ComboItem();
            this.cbitemTenSV = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtNhaptuKhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnTimKiemSinhVien.SuspendLayout();
            this.gpKetQuaTimKiem.SuspendLayout();
            this.gpNhapThongTinCanTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTimKiemSinhVien
            // 
            this.pnTimKiemSinhVien.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnTimKiemSinhVien.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnTimKiemSinhVien.Controls.Add(this.gpKetQuaTimKiem);
            this.pnTimKiemSinhVien.Controls.Add(this.gpNhapThongTinCanTim);
            this.pnTimKiemSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTimKiemSinhVien.Location = new System.Drawing.Point(0, 0);
            this.pnTimKiemSinhVien.Name = "pnTimKiemSinhVien";
            this.pnTimKiemSinhVien.Size = new System.Drawing.Size(668, 411);
            this.pnTimKiemSinhVien.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnTimKiemSinhVien.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnTimKiemSinhVien.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnTimKiemSinhVien.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnTimKiemSinhVien.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnTimKiemSinhVien.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnTimKiemSinhVien.Style.GradientAngle = 90;
            this.pnTimKiemSinhVien.TabIndex = 0;
            // 
            // gpKetQuaTimKiem
            // 
            this.gpKetQuaTimKiem.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpKetQuaTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpKetQuaTimKiem.Controls.Add(this.btnThoat);
            this.gpKetQuaTimKiem.Controls.Add(this.lsvKetQua);
            this.gpKetQuaTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpKetQuaTimKiem.Location = new System.Drawing.Point(0, 133);
            this.gpKetQuaTimKiem.Name = "gpKetQuaTimKiem";
            this.gpKetQuaTimKiem.Size = new System.Drawing.Size(668, 278);
            // 
            // 
            // 
            this.gpKetQuaTimKiem.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpKetQuaTimKiem.Style.BackColorGradientAngle = 90;
            this.gpKetQuaTimKiem.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpKetQuaTimKiem.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpKetQuaTimKiem.Style.BorderBottomWidth = 1;
            this.gpKetQuaTimKiem.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpKetQuaTimKiem.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpKetQuaTimKiem.Style.BorderLeftWidth = 1;
            this.gpKetQuaTimKiem.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpKetQuaTimKiem.Style.BorderRightWidth = 1;
            this.gpKetQuaTimKiem.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpKetQuaTimKiem.Style.BorderTopWidth = 1;
            this.gpKetQuaTimKiem.Style.Class = "";
            this.gpKetQuaTimKiem.Style.CornerDiameter = 4;
            this.gpKetQuaTimKiem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpKetQuaTimKiem.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpKetQuaTimKiem.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpKetQuaTimKiem.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpKetQuaTimKiem.StyleMouseDown.Class = "";
            this.gpKetQuaTimKiem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpKetQuaTimKiem.StyleMouseOver.Class = "";
            this.gpKetQuaTimKiem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpKetQuaTimKiem.TabIndex = 1;
            this.gpKetQuaTimKiem.Text = "Kết Quả Tìm Kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::DeTai_QuanLySinhVien.Properties.Resources.exit;
            this.btnThoat.Location = new System.Drawing.Point(511, 193);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 46);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lsvKetQua
            // 
            // 
            // 
            // 
            this.lsvKetQua.Border.Class = "ListViewBorder";
            this.lsvKetQua.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsvKetQua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colTenLop,
            this.colTenKhoa});
            this.lsvKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsvKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvKetQua.FullRowSelect = true;
            this.lsvKetQua.GridLines = true;
            this.lsvKetQua.Location = new System.Drawing.Point(0, 0);
            this.lsvKetQua.Name = "lsvKetQua";
            this.lsvKetQua.Size = new System.Drawing.Size(662, 181);
            this.lsvKetQua.TabIndex = 0;
            this.lsvKetQua.UseCompatibleStateImageBehavior = false;
            this.lsvKetQua.View = System.Windows.Forms.View.Details;
            this.lsvKetQua.SelectedIndexChanged += new System.EventHandler(this.lsvKetQua_SelectedIndexChanged);
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã Sinh Viên";
            this.colMaSV.Width = 139;
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên Sinh Viên";
            this.colTenSV.Width = 205;
            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Tên Lớp";
            this.colTenLop.Width = 168;
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.Text = "Tên Khoa";
            this.colTenKhoa.Width = 194;
            // 
            // gpNhapThongTinCanTim
            // 
            this.gpNhapThongTinCanTim.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpNhapThongTinCanTim.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpNhapThongTinCanTim.Controls.Add(this.cbTimKiemTheo);
            this.gpNhapThongTinCanTim.Controls.Add(this.labelX2);
            this.gpNhapThongTinCanTim.Controls.Add(this.btnTimKiem);
            this.gpNhapThongTinCanTim.Controls.Add(this.txtNhaptuKhoa);
            this.gpNhapThongTinCanTim.Controls.Add(this.labelX1);
            this.gpNhapThongTinCanTim.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpNhapThongTinCanTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpNhapThongTinCanTim.Location = new System.Drawing.Point(0, 0);
            this.gpNhapThongTinCanTim.Name = "gpNhapThongTinCanTim";
            this.gpNhapThongTinCanTim.Size = new System.Drawing.Size(668, 133);
            // 
            // 
            // 
            this.gpNhapThongTinCanTim.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpNhapThongTinCanTim.Style.BackColorGradientAngle = 90;
            this.gpNhapThongTinCanTim.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpNhapThongTinCanTim.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNhapThongTinCanTim.Style.BorderBottomWidth = 1;
            this.gpNhapThongTinCanTim.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpNhapThongTinCanTim.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNhapThongTinCanTim.Style.BorderLeftWidth = 1;
            this.gpNhapThongTinCanTim.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNhapThongTinCanTim.Style.BorderRightWidth = 1;
            this.gpNhapThongTinCanTim.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpNhapThongTinCanTim.Style.BorderTopWidth = 1;
            this.gpNhapThongTinCanTim.Style.Class = "";
            this.gpNhapThongTinCanTim.Style.CornerDiameter = 4;
            this.gpNhapThongTinCanTim.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpNhapThongTinCanTim.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpNhapThongTinCanTim.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpNhapThongTinCanTim.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpNhapThongTinCanTim.StyleMouseDown.Class = "";
            this.gpNhapThongTinCanTim.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpNhapThongTinCanTim.StyleMouseOver.Class = "";
            this.gpNhapThongTinCanTim.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpNhapThongTinCanTim.TabIndex = 0;
            this.gpNhapThongTinCanTim.Text = "Nhập Thông Tin Cần Tìm";
            // 
            // cbTimKiemTheo
            // 
            this.cbTimKiemTheo.DisplayMember = "Text";
            this.cbTimKiemTheo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTimKiemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimKiemTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTheo.FormattingEnabled = true;
            this.cbTimKiemTheo.ItemHeight = 20;
            this.cbTimKiemTheo.Items.AddRange(new object[] {
            this.cbitenMaSV,
            this.cbitemTenSV});
            this.cbTimKiemTheo.Location = new System.Drawing.Point(211, 61);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(172, 26);
            this.cbTimKiemTheo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTimKiemTheo.TabIndex = 1;
            this.cbTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.cbTimKiemTheo_SelectedIndexChanged);
            // 
            // cbitenMaSV
            // 
            this.cbitenMaSV.Text = "Mã Sinh Viên";
            // 
            // cbitemTenSV
            // 
            this.cbitemTenSV.Text = "Tên Sinh Viên";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(43, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(162, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tìm Kiếm Theo :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::DeTai_QuanLySinhVien.Properties.Resources.old_edit_find;
            this.btnTimKiem.Location = new System.Drawing.Point(422, 37);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 50);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtNhaptuKhoa
            // 
            // 
            // 
            // 
            this.txtNhaptuKhoa.Border.Class = "TextBoxBorder";
            this.txtNhaptuKhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNhaptuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaptuKhoa.Location = new System.Drawing.Point(211, 15);
            this.txtNhaptuKhoa.Name = "txtNhaptuKhoa";
            this.txtNhaptuKhoa.Size = new System.Drawing.Size(172, 26);
            this.txtNhaptuKhoa.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(43, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(162, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nhập từ khóa cần tìm :";
            // 
            // frmTimKiemSinhVien
            // 
            this.AcceptButton = this.btnTimKiem;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(668, 411);
            this.Controls.Add(this.pnTimKiemSinhVien);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiemSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemSinhVien_Load);
            this.pnTimKiemSinhVien.ResumeLayout(false);
            this.gpKetQuaTimKiem.ResumeLayout(false);
            this.gpNhapThongTinCanTim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnTimKiemSinhVien;
        private DevComponents.DotNetBar.Controls.GroupPanel gpNhapThongTinCanTim;
        private DevComponents.DotNetBar.Controls.GroupPanel gpKetQuaTimKiem;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNhaptuKhoa;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTimKiemTheo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.Controls.ListViewEx lsvKetQua;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private System.Windows.Forms.ColumnHeader colTenKhoa;
        private DevComponents.Editors.ComboItem cbitenMaSV;
        private DevComponents.Editors.ComboItem cbitemTenSV;
    }
}