namespace QuanLyNhaSach
{
    partial class frmThongKeBaoCao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.KhachHangRpt1 = new QuanLyNhaSach.Report.KhachHangRpt();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.NhaCungCapRpt1 = new QuanLyNhaSach.Report.NhaCungCapRpt();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.NhanVienRpt1 = new QuanLyNhaSach.Report.NhanVienRpt();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.PhieuThuRpt1 = new QuanLyNhaSach.Report.PhieuThuRpt();
            this.crystalReportViewer5 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.PhieuChiRpt1 = new QuanLyNhaSach.Report.PhieuChiRpt();
            this.crystalReportViewer6 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.PhieuDatSachRpt1 = new QuanLyNhaSach.Report.PhieuDatSachRpt();
            this.crystalReportViewer7 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer8 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.PhieuXuatRpt1 = new QuanLyNhaSach.Report.PhieuXuatRpt();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.crystalReportViewer1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Blue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NHÂN VIÊN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.NhanVienRpt1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(774, 537);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.crystalReportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "KHÁCH HÀNG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.DisplayGroupTree = false;
            this.crystalReportViewer2.DisplayStatusBar = false;
            this.crystalReportViewer2.DisplayToolbar = false;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.KhachHangRpt1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(774, 537);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.crystalReportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(784, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NHÀ CUNG CẤP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = 0;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.DisplayGroupTree = false;
            this.crystalReportViewer3.DisplayStatusBar = false;
            this.crystalReportViewer3.DisplayToolbar = false;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = this.NhaCungCapRpt1;
            this.crystalReportViewer3.Size = new System.Drawing.Size(774, 537);
            this.crystalReportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.crystalReportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(784, 547);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PHIẾU THU";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage5.Controls.Add(this.crystalReportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(784, 547);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "PHIẾU CHI";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.crystalReportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(784, 547);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "PHIẾU ĐẶT SÁCH";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.crystalReportViewer7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(784, 547);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "PHIẾU NHẬP SÁCH";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.crystalReportViewer8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(784, 547);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "PHIẾU XUẤT SÁCH";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = 0;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.DisplayGroupTree = false;
            this.crystalReportViewer4.DisplayStatusBar = false;
            this.crystalReportViewer4.DisplayToolbar = false;
            this.crystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer4.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.ReportSource = this.PhieuThuRpt1;
            this.crystalReportViewer4.Size = new System.Drawing.Size(774, 537);
            this.crystalReportViewer4.TabIndex = 0;
            // 
            // crystalReportViewer5
            // 
            this.crystalReportViewer5.ActiveViewIndex = 0;
            this.crystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer5.DisplayGroupTree = false;
            this.crystalReportViewer5.DisplayStatusBar = false;
            this.crystalReportViewer5.DisplayToolbar = false;
            this.crystalReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer5.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer5.Name = "crystalReportViewer5";
            this.crystalReportViewer5.ReportSource = this.PhieuChiRpt1;
            this.crystalReportViewer5.Size = new System.Drawing.Size(774, 537);
            this.crystalReportViewer5.TabIndex = 0;
            // 
            // crystalReportViewer6
            // 
            this.crystalReportViewer6.ActiveViewIndex = 0;
            this.crystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer6.DisplayGroupTree = false;
            this.crystalReportViewer6.DisplayStatusBar = false;
            this.crystalReportViewer6.DisplayToolbar = false;
            this.crystalReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer6.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer6.Name = "crystalReportViewer6";
            this.crystalReportViewer6.ReportSource = this.PhieuDatSachRpt1;
            this.crystalReportViewer6.Size = new System.Drawing.Size(778, 541);
            this.crystalReportViewer6.TabIndex = 0;
            // 
            // crystalReportViewer7
            // 
            this.crystalReportViewer7.ActiveViewIndex = -1;
            this.crystalReportViewer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer7.DisplayGroupTree = false;
            this.crystalReportViewer7.DisplayStatusBar = false;
            this.crystalReportViewer7.DisplayToolbar = false;
            this.crystalReportViewer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer7.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer7.Name = "crystalReportViewer7";
            this.crystalReportViewer7.SelectionFormula = "";
            this.crystalReportViewer7.Size = new System.Drawing.Size(778, 541);
            this.crystalReportViewer7.TabIndex = 0;
            this.crystalReportViewer7.ViewTimeSelectionFormula = "";
            // 
            // crystalReportViewer8
            // 
            this.crystalReportViewer8.ActiveViewIndex = 0;
            this.crystalReportViewer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer8.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer8.Name = "crystalReportViewer8";
            this.crystalReportViewer8.ReportSource = this.PhieuXuatRpt1;
            this.crystalReportViewer8.Size = new System.Drawing.Size(778, 541);
            this.crystalReportViewer8.TabIndex = 0;
            // 
            // frmThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmThongKeBaoCao";
            this.TabText = "THONG KE BAO CAO";
            this.Text = "THONG KE BAO CAO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
       
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private QuanLyNhaSach.Report.KhachHangRpt KhachHangRpt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private QuanLyNhaSach.Report.NhaCungCapRpt NhaCungCapRpt1;
        private QuanLyNhaSach.Report.NhanVienRpt NhanVienRpt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private QuanLyNhaSach.Report.PhieuThuRpt PhieuThuRpt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer5;
        private QuanLyNhaSach.Report.PhieuChiRpt PhieuChiRpt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer6;
        private QuanLyNhaSach.Report.PhieuDatSachRpt PhieuDatSachRpt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer8;
        private QuanLyNhaSach.Report.PhieuXuatRpt PhieuXuatRpt1;
    }
}