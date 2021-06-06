namespace qlkaraoke
{
    partial class fReportBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReportBill));
            this.BillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new qlkaraoke.DataSet1();
            this.RoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PromotionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BillsTableAdapter = new qlkaraoke.DataSet1TableAdapters.BillsTableAdapter();
            this.RoomTableAdapter = new qlkaraoke.DataSet1TableAdapters.RoomTableAdapter();
            this.PromotionTableAdapter = new qlkaraoke.DataSet1TableAdapters.PromotionTableAdapter();
            this.View_BillTableAdapter = new qlkaraoke.DataSet1TableAdapters.View_BillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromotionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_BillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BillsBindingSource
            // 
            this.BillsBindingSource.DataMember = "Bills";
            this.BillsBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RoomBindingSource
            // 
            this.RoomBindingSource.DataMember = "Room";
            this.RoomBindingSource.DataSource = this.DataSet1;
            // 
            // PromotionBindingSource
            // 
            this.PromotionBindingSource.DataMember = "Promotion";
            this.PromotionBindingSource.DataSource = this.DataSet1;
            // 
            // View_BillBindingSource
            // 
            this.View_BillBindingSource.DataMember = "View_Bill";
            this.View_BillBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1_Bills";
            reportDataSource1.Value = this.BillsBindingSource;
            reportDataSource2.Name = "DataSet1_Room";
            reportDataSource2.Value = this.RoomBindingSource;
            reportDataSource3.Name = "DataSet1_Promotion";
            reportDataSource3.Value = this.PromotionBindingSource;
            reportDataSource4.Name = "DataSet1_View_Bill";
            reportDataSource4.Value = this.View_BillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "qlkaraoke.rReportBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(572, 371);
            this.reportViewer1.TabIndex = 9;
            // 
            // BillsTableAdapter
            // 
            this.BillsTableAdapter.ClearBeforeFill = true;
            // 
            // RoomTableAdapter
            // 
            this.RoomTableAdapter.ClearBeforeFill = true;
            // 
            // PromotionTableAdapter
            // 
            this.PromotionTableAdapter.ClearBeforeFill = true;
            // 
            // View_BillTableAdapter
            // 
            this.View_BillTableAdapter.ClearBeforeFill = true;
            // 
            // fReportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(572, 371);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReportBill";
            this.Text = "Report Bill";
            this.Load += new System.EventHandler(this.fReportBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromotionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_BillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BillsBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource RoomBindingSource;
        private System.Windows.Forms.BindingSource PromotionBindingSource;
        private System.Windows.Forms.BindingSource View_BillBindingSource;
        private qlkaraoke.DataSet1TableAdapters.BillsTableAdapter BillsTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.RoomTableAdapter RoomTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.PromotionTableAdapter PromotionTableAdapter;
        private qlkaraoke.DataSet1TableAdapters.View_BillTableAdapter View_BillTableAdapter;
    }
}