namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmInDanhSachSoCuaNgay
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InPhieuLuuTienGuiInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.cmbNgayGiaoDich = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ReportViewerDanhSachSoCuaNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuLuuTienGuiInfoBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InPhieuLuuTienGuiInfoBindingSource
            // 
            this.InPhieuLuuTienGuiInfoBindingSource.DataSource = typeof(QuanLyTienGuiTietKiem.Bussiness.InPhieuLuuTienGuiInfo);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.cmbNgayGiaoDich);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(651, 100);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Chọn dữ liệu cần truy xuất";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(41, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Chọn ngày giao dịch";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(388, 29);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbNgayGiaoDich
            // 
            this.cmbNgayGiaoDich.DisplayMember = "Text";
            this.cmbNgayGiaoDich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNgayGiaoDich.FormattingEnabled = true;
            this.cmbNgayGiaoDich.ItemHeight = 14;
            this.cmbNgayGiaoDich.Location = new System.Drawing.Point(168, 32);
            this.cmbNgayGiaoDich.Name = "cmbNgayGiaoDich";
            this.cmbNgayGiaoDich.Size = new System.Drawing.Size(183, 20);
            this.cmbNgayGiaoDich.TabIndex = 0;
            // 
            // ReportViewerDanhSachSoCuaNgay
            // 
            this.ReportViewerDanhSachSoCuaNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QuanLyTienGuiTietKiem_Bussiness_InPhieuLuuTienGuiInfo";
            reportDataSource1.Value = this.InPhieuLuuTienGuiInfoBindingSource;
            this.ReportViewerDanhSachSoCuaNgay.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerDanhSachSoCuaNgay.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptDanhSachSoCuaNgay.rdlc";
            this.ReportViewerDanhSachSoCuaNgay.Location = new System.Drawing.Point(0, 100);
            this.ReportViewerDanhSachSoCuaNgay.Name = "ReportViewerDanhSachSoCuaNgay";
            this.ReportViewerDanhSachSoCuaNgay.Size = new System.Drawing.Size(651, 409);
            this.ReportViewerDanhSachSoCuaNgay.TabIndex = 1;
            // 
            // frmInDanhSachSoCuaNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 509);
            this.Controls.Add(this.ReportViewerDanhSachSoCuaNgay);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInDanhSachSoCuaNgay";
            this.ShowInTaskbar = false;
            this.Text = "IN DANH SÁCH SỔ CỦA NGÀY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInDanhSachSoCuaNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuLuuTienGuiInfoBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerDanhSachSoCuaNgay;
        private System.Windows.Forms.BindingSource InPhieuLuuTienGuiInfoBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNgayGiaoDich;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnThoat;
    }
}