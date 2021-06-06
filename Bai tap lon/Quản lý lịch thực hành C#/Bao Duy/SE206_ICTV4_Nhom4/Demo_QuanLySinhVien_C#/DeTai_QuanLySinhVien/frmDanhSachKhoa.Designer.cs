namespace DeTai_QuanLySinhVien
{
    partial class frmDanhSachKhoa
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
            this.gpDSSKhoa = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.lsvDanhSachCacKhoa = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnDDSV = new DevComponents.DotNetBar.PanelEx();
            this.txtTenKhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaKhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.gpDSSKhoa.SuspendLayout();
            this.pnDDSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDSSKhoa
            // 
            this.gpDSSKhoa.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpDSSKhoa.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpDSSKhoa.Controls.Add(this.txtTenKhoa);
            this.gpDSSKhoa.Controls.Add(this.txtMaKhoa);
            this.gpDSSKhoa.Controls.Add(this.labelX2);
            this.gpDSSKhoa.Controls.Add(this.labelX1);
            this.gpDSSKhoa.Controls.Add(this.btnThoat);
            this.gpDSSKhoa.Controls.Add(this.btnSua);
            this.gpDSSKhoa.Controls.Add(this.btnXoa);
            this.gpDSSKhoa.Controls.Add(this.btnThem);
            this.gpDSSKhoa.Controls.Add(this.lsvDanhSachCacKhoa);
            this.gpDSSKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDSSKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDSSKhoa.Location = new System.Drawing.Point(0, 0);
            this.gpDSSKhoa.Name = "gpDSSKhoa";
            this.gpDSSKhoa.Size = new System.Drawing.Size(706, 471);
            // 
            // 
            // 
            this.gpDSSKhoa.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpDSSKhoa.Style.BackColorGradientAngle = 90;
            this.gpDSSKhoa.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpDSSKhoa.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDSSKhoa.Style.BorderBottomWidth = 1;
            this.gpDSSKhoa.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpDSSKhoa.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDSSKhoa.Style.BorderLeftWidth = 1;
            this.gpDSSKhoa.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDSSKhoa.Style.BorderRightWidth = 1;
            this.gpDSSKhoa.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpDSSKhoa.Style.BorderTopWidth = 1;
            this.gpDSSKhoa.Style.Class = "";
            this.gpDSSKhoa.Style.CornerDiameter = 4;
            this.gpDSSKhoa.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpDSSKhoa.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpDSSKhoa.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpDSSKhoa.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpDSSKhoa.StyleMouseDown.Class = "";
            this.gpDSSKhoa.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpDSSKhoa.StyleMouseOver.Class = "";
            this.gpDSSKhoa.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpDSSKhoa.TabIndex = 1;
            this.gpDSSKhoa.Text = "DANH SÁCH CÁC KHOA";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThoat.Image = global::DeTai_QuanLySinhVien.Properties.Resources.exit;
            this.btnThoat.Location = new System.Drawing.Point(525, 375);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 51);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSua.Image = global::DeTai_QuanLySinhVien.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(373, 375);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 51);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoa.Image = global::DeTai_QuanLySinhVien.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(224, 375);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 51);
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
            this.btnThem.Location = new System.Drawing.Point(75, 375);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 51);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lsvDanhSachCacKhoa
            // 
            this.lsvDanhSachCacKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.lsvDanhSachCacKhoa.Border.Class = "ListViewBorder";
            this.lsvDanhSachCacKhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsvDanhSachCacKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaKhoa,
            this.colTenKhoa});
            this.lsvDanhSachCacKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsvDanhSachCacKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSachCacKhoa.FullRowSelect = true;
            this.lsvDanhSachCacKhoa.GridLines = true;
            this.lsvDanhSachCacKhoa.Location = new System.Drawing.Point(0, 0);
            this.lsvDanhSachCacKhoa.Name = "lsvDanhSachCacKhoa";
            this.lsvDanhSachCacKhoa.Size = new System.Drawing.Size(700, 241);
            this.lsvDanhSachCacKhoa.TabIndex = 0;
            this.lsvDanhSachCacKhoa.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachCacKhoa.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachCacKhoa.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachCacKhoa_SelectedIndexChanged);
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.Text = "Mã Khoa";
            this.colMaKhoa.Width = 162;
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.Text = "Tên Khoa";
            this.colTenKhoa.Width = 688;
            // 
            // pnDDSV
            // 
            this.pnDDSV.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnDDSV.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnDDSV.Controls.Add(this.gpDSSKhoa);
            this.pnDDSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDDSV.Location = new System.Drawing.Point(0, 0);
            this.pnDDSV.Name = "pnDDSV";
            this.pnDDSV.Size = new System.Drawing.Size(706, 471);
            this.pnDDSV.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnDDSV.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnDDSV.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnDDSV.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnDDSV.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnDDSV.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnDDSV.Style.GradientAngle = 90;
            this.pnDDSV.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            // 
            // 
            // 
            this.txtTenKhoa.Border.Class = "TextBoxBorder";
            this.txtTenKhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Location = new System.Drawing.Point(260, 322);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(247, 26);
            this.txtTenKhoa.TabIndex = 7;
            // 
            // txtMaKhoa
            // 
            // 
            // 
            // 
            this.txtMaKhoa.Border.Class = "TextBoxBorder";
            this.txtMaKhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(260, 270);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(247, 26);
            this.txtMaKhoa.TabIndex = 6;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(142, 325);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(183, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Tên Khoa :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(142, 270);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(183, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Mã Khoa :";
            // 
            // frmDanhSachKhoa
            // 
            this.ClientSize = new System.Drawing.Size(706, 471);
            this.Controls.Add(this.pnDDSV);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhSachKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachKhoa_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSachKhoa_Load);
            this.gpDSSKhoa.ResumeLayout(false);
            this.pnDDSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpDSSKhoa;
        private DevComponents.DotNetBar.PanelEx pnDDSV;
        private DevComponents.DotNetBar.Controls.ListViewEx lsvDanhSachCacKhoa;
        private System.Windows.Forms.ColumnHeader colMaKhoa;
        private System.Windows.Forms.ColumnHeader colTenKhoa;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenKhoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKhoa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;


    }
}