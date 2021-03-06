namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmInPhieuThu
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
            this.InPhieuThuInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbMaSo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTruyXuat = new DevComponents.DotNetBar.ButtonX();
            this.ReportViewerInPhieuThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuThuInfoBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InPhieuThuInfoBindingSource
            // 
            this.InPhieuThuInfoBindingSource.DataSource = typeof(QuanLyTienGuiTietKiem.Bussiness.InPhieuThuInfo);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(84, 44);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã sổ tiết kiệm:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.cmbMaSo);
            this.groupPanel1.Controls.Add(this.btnTruyXuat);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(825, 110);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Khung nhập liệu";
            // 
            // cmbMaSo
            // 
            this.cmbMaSo.DisplayMember = "Text";
            this.cmbMaSo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaSo.FormattingEnabled = true;
            this.cmbMaSo.ItemHeight = 14;
            this.cmbMaSo.Location = new System.Drawing.Point(168, 44);
            this.cmbMaSo.Name = "cmbMaSo";
            this.cmbMaSo.Size = new System.Drawing.Size(150, 20);
            this.cmbMaSo.TabIndex = 2;
            // 
            // btnTruyXuat
            // 
            this.btnTruyXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruyXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruyXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyXuat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Search;
            this.btnTruyXuat.Location = new System.Drawing.Point(380, 38);
            this.btnTruyXuat.Name = "btnTruyXuat";
            this.btnTruyXuat.Size = new System.Drawing.Size(83, 26);
            this.btnTruyXuat.TabIndex = 1;
            this.btnTruyXuat.Text = "Truy xuất";
            this.btnTruyXuat.Click += new System.EventHandler(this.btnTruyXuat_Click);
            // 
            // ReportViewerInPhieuThu
            // 
            this.ReportViewerInPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QuanLyTienGuiTietKiem_Bussiness_InPhieuThuInfo";
            reportDataSource1.Value = this.InPhieuThuInfoBindingSource;
            this.ReportViewerInPhieuThu.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerInPhieuThu.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptInPhieuThu.rdlc";
            this.ReportViewerInPhieuThu.Location = new System.Drawing.Point(0, 110);
            this.ReportViewerInPhieuThu.Name = "ReportViewerInPhieuThu";
            this.ReportViewerInPhieuThu.Size = new System.Drawing.Size(825, 375);
            this.ReportViewerInPhieuThu.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(483, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 26);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmInPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 485);
            this.Controls.Add(this.ReportViewerInPhieuThu);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInPhieuThu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN PHIEU THU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInPhieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuThuInfoBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnTruyXuat;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerInPhieuThu;
        private System.Windows.Forms.BindingSource InPhieuThuInfoBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaSo;
        private DevComponents.DotNetBar.ButtonX btnThoat;
    }
}