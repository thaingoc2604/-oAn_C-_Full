namespace TT_GDTX_ANGIANG
{
    partial class frm_LIST_NHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LIST_NHANVIEN));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMANV = new System.Windows.Forms.ColumnHeader();
            this.colHOTEN = new System.Windows.Forms.ColumnHeader();
            this.colNGAYSINH = new System.Windows.Forms.ColumnHeader();
            this.colGIOITINH = new System.Windows.Forms.ColumnHeader();
            this.colCMND = new System.Windows.Forms.ColumnHeader();
            this.colDIENTHOAI = new System.Windows.Forms.ColumnHeader();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ThemMoi_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Thoat_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LamTuoi_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 174);
            this.panel2.TabIndex = 5;
            // 
            // listView
            // 
            // 
            // 
            // 
            this.listView.Border.Class = "ListViewBorder";
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMANV,
            this.colHOTEN,
            this.colNGAYSINH,
            this.colGIOITINH,
            this.colCMND,
            this.colDIENTHOAI});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(756, 174);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listViewExDanToc_SelectedIndexChanged);
            // 
            // colMANV
            // 
            this.colMANV.Text = "MANV";
            this.colMANV.Width = 57;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Text = "Họ và Tên";
            this.colHOTEN.Width = 200;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Text = "Ngày Sinh";
            this.colNGAYSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNGAYSINH.Width = 130;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.Text = "Giới Tính";
            this.colGIOITINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGIOITINH.Width = 80;
            // 
            // colCMND
            // 
            this.colCMND.Text = "Số CMND";
            this.colCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCMND.Width = 150;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.Text = "Điện Thoại";
            this.colDIENTHOAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDIENTHOAI.Width = 150;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NhanVien.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(0, 32);
            this.lbl_NhanVien.TabIndex = 3;
            this.lbl_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemMoi_toolStripButton,
            this.Thoat_toolStripButton,
            this.LamTuoi_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 152);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ThemMoi_toolStripButton
            // 
            this.ThemMoi_toolStripButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ThemMoi_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ThemMoi_toolStripButton.Image")));
            this.ThemMoi_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThemMoi_toolStripButton.Name = "ThemMoi_toolStripButton";
            this.ThemMoi_toolStripButton.Size = new System.Drawing.Size(86, 22);
            this.ThemMoi_toolStripButton.Text = "Thêm mới";
            this.ThemMoi_toolStripButton.Click += new System.EventHandler(this.ThemMoi_toolStripButton_Click_1);
            // 
            // Thoat_toolStripButton
            // 
            this.Thoat_toolStripButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Thoat_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Thoat_toolStripButton.Image")));
            this.Thoat_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Thoat_toolStripButton.Name = "Thoat_toolStripButton";
            this.Thoat_toolStripButton.Size = new System.Drawing.Size(61, 22);
            this.Thoat_toolStripButton.Text = "Thoát";
            this.Thoat_toolStripButton.Click += new System.EventHandler(this.Thoat_toolStripButton_Click);
            // 
            // LamTuoi_toolStripButton
            // 
            this.LamTuoi_toolStripButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LamTuoi_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LamTuoi_toolStripButton.Image")));
            this.LamTuoi_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LamTuoi_toolStripButton.Name = "LamTuoi_toolStripButton";
            this.LamTuoi_toolStripButton.Size = new System.Drawing.Size(80, 22);
            this.LamTuoi_toolStripButton.Text = "Cập Nhật";
            this.LamTuoi_toolStripButton.DoubleClick += new System.EventHandler(this.LamTuoi_toolStripButton_Click);
            this.LamTuoi_toolStripButton.Click += new System.EventHandler(this.LamTuoi_toolStripButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 152);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picHinhAnh);
            this.panel1.Controls.Add(this.lbl_NhanVien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 152);
            this.panel1.TabIndex = 3;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picHinhAnh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picHinhAnh.Location = new System.Drawing.Point(617, 12);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(113, 137);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 68;
            this.picHinhAnh.TabStop = false;
            // 
            // frm_LIST_NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LIST_NHANVIEN";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.frm_LIST_NHANVIEN_Load);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_NhanVien;
        //private DevComponents.DotNetBar.LabelX lbl_NhanVien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ThemMoi_toolStripButton;
        private System.Windows.Forms.ToolStripButton LamTuoi_toolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton Thoat_toolStripButton;
        private System.Windows.Forms.ColumnHeader colMANV;
        private System.Windows.Forms.ColumnHeader colHOTEN;
        private System.Windows.Forms.ColumnHeader colNGAYSINH;
        private System.Windows.Forms.ColumnHeader colGIOITINH;
        private System.Windows.Forms.ColumnHeader colCMND;
        private System.Windows.Forms.ColumnHeader colDIENTHOAI;
        public DevComponents.DotNetBar.Controls.ListViewEx listView;
        private System.Windows.Forms.PictureBox picHinhAnh;
    }
}