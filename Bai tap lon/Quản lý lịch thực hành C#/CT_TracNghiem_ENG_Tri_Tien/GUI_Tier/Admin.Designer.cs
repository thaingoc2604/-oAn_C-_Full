namespace GUI_Tier
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHienThi_CauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienThi_QuanLyThiSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy_ThemSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QuanLy_SuaThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBangDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHienThi_CauHoi,
            this.mnuHienThi_QuanLyThiSinh,
            this.mnuBangDiem,
            this.mnuReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHienThi_CauHoi
            // 
            this.mnuHienThi_CauHoi.Name = "mnuHienThi_CauHoi";
            this.mnuHienThi_CauHoi.Size = new System.Drawing.Size(109, 20);
            this.mnuHienThi_CauHoi.Text = "Quản Lý Câu Hỏi";
            this.mnuHienThi_CauHoi.Click += new System.EventHandler(this.mnuHienThi_CauHoi_Click);
            // 
            // mnuHienThi_QuanLyThiSinh
            // 
            this.mnuHienThi_QuanLyThiSinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy_ThemSV,
            this.mnu_QuanLy_SuaThongTin});
            this.mnuHienThi_QuanLyThiSinh.Name = "mnuHienThi_QuanLyThiSinh";
            this.mnuHienThi_QuanLyThiSinh.Size = new System.Drawing.Size(115, 20);
            this.mnuHienThi_QuanLyThiSinh.Text = "Quản Lý Sinh Viên";
            // 
            // mnuQuanLy_ThemSV
            // 
            this.mnuQuanLy_ThemSV.Name = "mnuQuanLy_ThemSV";
            this.mnuQuanLy_ThemSV.Size = new System.Drawing.Size(152, 22);
            this.mnuQuanLy_ThemSV.Text = "Thêm User";
            this.mnuQuanLy_ThemSV.Click += new System.EventHandler(this.mnuQuanLy_ThemSV_Click);
            // 
            // mnu_QuanLy_SuaThongTin
            // 
            this.mnu_QuanLy_SuaThongTin.Name = "mnu_QuanLy_SuaThongTin";
            this.mnu_QuanLy_SuaThongTin.Size = new System.Drawing.Size(152, 22);
            this.mnu_QuanLy_SuaThongTin.Text = "Sửa - Xóa User";
            this.mnu_QuanLy_SuaThongTin.Click += new System.EventHandler(this.mnu_QuanLy_SuaThongTin_Click);
            // 
            // mnuBangDiem
            // 
            this.mnuBangDiem.Name = "mnuBangDiem";
            this.mnuBangDiem.Size = new System.Drawing.Size(77, 20);
            this.mnuBangDiem.Text = "Bảng Điểm";
            this.mnuBangDiem.Click += new System.EventHandler(this.mnuBangDiem_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(54, 20);
            this.mnuReport.Text = "Report";
            this.mnuReport.Click += new System.EventHandler(this.mnuReport_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 672);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trung tâm quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHienThi_CauHoi;
        private System.Windows.Forms.ToolStripMenuItem mnuHienThi_QuanLyThiSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy_ThemSV;
        private System.Windows.Forms.ToolStripMenuItem mnu_QuanLy_SuaThongTin;
        private System.Windows.Forms.ToolStripMenuItem mnuBangDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
    }
}