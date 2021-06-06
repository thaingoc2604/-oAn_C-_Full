namespace DeTai_QuanLySinhVien
{
    partial class frmBaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KetQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySinhVienDataSet = new DeTai_QuanLySinhVien.QuanLySinhVienDataSet();
            this.SinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnBaoCao = new DevComponents.DotNetBar.PanelEx();
            this.gpHienThi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KetQuaTableAdapter = new DeTai_QuanLySinhVien.QuanLySinhVienDataSetTableAdapters.KetQuaTableAdapter();
            this.SinhVienTableAdapter = new DeTai_QuanLySinhVien.QuanLySinhVienDataSetTableAdapters.SinhVienTableAdapter();
            this.quanLySinhVienDataSet1 = new DeTai_QuanLySinhVien.QuanLySinhVienDataSet();
            this.quanLySinhVienDataSet2 = new DeTai_QuanLySinhVien.QuanLySinhVienDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).BeginInit();
            this.pnBaoCao.SuspendLayout();
            this.gpHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // KetQuaBindingSource
            // 
            this.KetQuaBindingSource.DataMember = "KetQua";
            this.KetQuaBindingSource.DataSource = this.QuanLySinhVienDataSet;
            // 
            // QuanLySinhVienDataSet
            // 
            this.QuanLySinhVienDataSet.DataSetName = "QuanLySinhVienDataSet";
            this.QuanLySinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SinhVienBindingSource
            // 
            this.SinhVienBindingSource.DataMember = "SinhVien";
            this.SinhVienBindingSource.DataSource = this.QuanLySinhVienDataSet;
            // 
            // pnBaoCao
            // 
            this.pnBaoCao.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnBaoCao.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnBaoCao.Controls.Add(this.gpHienThi);
            this.pnBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBaoCao.Location = new System.Drawing.Point(0, 0);
            this.pnBaoCao.Name = "pnBaoCao";
            this.pnBaoCao.Size = new System.Drawing.Size(945, 512);
            this.pnBaoCao.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnBaoCao.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnBaoCao.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnBaoCao.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnBaoCao.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnBaoCao.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnBaoCao.Style.GradientAngle = 90;
            this.pnBaoCao.TabIndex = 0;
            // 
            // gpHienThi
            // 
            this.gpHienThi.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpHienThi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpHienThi.Controls.Add(this.reportViewer1);
            this.gpHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpHienThi.Location = new System.Drawing.Point(0, 0);
            this.gpHienThi.Name = "gpHienThi";
            this.gpHienThi.Size = new System.Drawing.Size(945, 512);
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
            this.gpHienThi.Text = "Hiển Thị Kết Quả";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "KetQuaSV";
            reportDataSource1.Value = this.KetQuaBindingSource;
            reportDataSource2.Name = "DSSinhVien";
            reportDataSource2.Value = this.SinhVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DeTai_QuanLySinhVien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(939, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // KetQuaTableAdapter
            // 
            this.KetQuaTableAdapter.ClearBeforeFill = true;
            // 
            // SinhVienTableAdapter
            // 
            this.SinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // quanLySinhVienDataSet1
            // 
            this.quanLySinhVienDataSet1.DataSetName = "QuanLySinhVienDataSet";
            this.quanLySinhVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLySinhVienDataSet2
            // 
            this.quanLySinhVienDataSet2.DataSetName = "QuanLySinhVienDataSet";
            this.quanLySinhVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(945, 512);
            this.Controls.Add(this.pnBaoCao);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).EndInit();
            this.pnBaoCao.ResumeLayout(false);
            this.gpHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnBaoCao;
        private DevComponents.DotNetBar.Controls.GroupPanel gpHienThi;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KetQuaBindingSource;
        private QuanLySinhVienDataSet QuanLySinhVienDataSet;
        private System.Windows.Forms.BindingSource SinhVienBindingSource;
        private QuanLySinhVienDataSetTableAdapters.KetQuaTableAdapter KetQuaTableAdapter;
        private QuanLySinhVienDataSetTableAdapters.SinhVienTableAdapter SinhVienTableAdapter;
        private QuanLySinhVienDataSet quanLySinhVienDataSet1;
        private QuanLySinhVienDataSet quanLySinhVienDataSet2;
    }
}