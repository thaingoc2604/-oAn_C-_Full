namespace QuanLyNhaSach.Report
{
    partial class frmReportPhieuXuatSach
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
            this.pnChonSach = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.PhieuXuatRpt1 = new QuanLyNhaSach.Report.PhieuXuatRpt();
            this.pnChonSach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChonSach
            // 
            this.pnChonSach.Controls.Add(this.lb1);
            this.pnChonSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChonSach.Location = new System.Drawing.Point(0, 0);
            this.pnChonSach.Name = "pnChonSach";
            this.pnChonSach.Size = new System.Drawing.Size(792, 67);
            this.pnChonSach.TabIndex = 9;
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Blue;
            this.lb1.Location = new System.Drawing.Point(241, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(355, 42);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "PHIẾU XUẤT SÁCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 506);
            this.panel1.TabIndex = 10;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.PhieuXuatRpt1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(792, 506);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmReportPhieuXuatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnChonSach);
            this.Name = "frmReportPhieuXuatSach";
            this.Text = "frmReportPhieuXuatSach";
            this.pnChonSach.ResumeLayout(false);
            this.pnChonSach.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChonSach;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private PhieuXuatRpt PhieuXuatRpt1;
    }
}