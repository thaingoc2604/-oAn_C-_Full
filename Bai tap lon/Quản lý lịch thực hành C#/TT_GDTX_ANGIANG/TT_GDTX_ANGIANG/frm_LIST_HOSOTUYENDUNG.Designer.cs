namespace TT_GDTX_ANGIANG
{
    partial class frm_LIST_HOSOTUYENDUNG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LIST_HOSOTUYENDUNG));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewExTonGiao = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ThemMoi_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Thoat_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LamTuoi_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ChonUngCuVien_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewExTonGiao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 257);
            this.panel2.TabIndex = 5;
            // 
            // listViewExTonGiao
            // 
            // 
            // 
            // 
            this.listViewExTonGiao.Border.Class = "ListViewBorder";
            this.listViewExTonGiao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewExTonGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExTonGiao.FullRowSelect = true;
            this.listViewExTonGiao.GridLines = true;
            this.listViewExTonGiao.Location = new System.Drawing.Point(0, 0);
            this.listViewExTonGiao.MultiSelect = false;
            this.listViewExTonGiao.Name = "listViewExTonGiao";
            this.listViewExTonGiao.Size = new System.Drawing.Size(586, 257);
            this.listViewExTonGiao.TabIndex = 3;
            this.listViewExTonGiao.UseCompatibleStateImageBehavior = false;
            this.listViewExTonGiao.View = System.Windows.Forms.View.Details;
            this.listViewExTonGiao.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listViewExTonGiao.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Hồ Sơ";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ Tên";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới Tính";
            this.columnHeader4.Width = 97;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemMoi_toolStripButton,
            this.Thoat_toolStripButton,
            this.LamTuoi_toolStripButton,
            this.ChonUngCuVien_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 106);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 25);
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
            this.ThemMoi_toolStripButton.Click += new System.EventHandler(this.ThemMoi_toolStripButton_Click);
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
            this.LamTuoi_toolStripButton.Click += new System.EventHandler(this.LamTuoi_toolStripButton_Click);
            // 
            // ChonUngCuVien_toolStripButton
            // 
            this.ChonUngCuVien_toolStripButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ChonUngCuVien_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ChonUngCuVien_toolStripButton.Image")));
            this.ChonUngCuVien_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChonUngCuVien_toolStripButton.Name = "ChonUngCuVien_toolStripButton";
            this.ChonUngCuVien_toolStripButton.Size = new System.Drawing.Size(96, 22);
            this.ChonUngCuVien_toolStripButton.Text = "Tuyển Dụng";
            this.ChonUngCuVien_toolStripButton.Click += new System.EventHandler(this.ChonUngCuVien_toolStripButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỒ SƠ TUYỂN DỤNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 106);
            this.panel1.TabIndex = 3;
            // 
            // frm_LIST_HOSOTUYENDUNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LIST_HOSOTUYENDUNG";
            this.Text = "Danh Sách Hồ Sơ Tuyển Dụng";
            this.Load += new System.EventHandler(this.frm_LIST_HOSOTUYENDUNG_Load);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ThemMoi_toolStripButton;
        private System.Windows.Forms.ToolStripButton LamTuoi_toolStripButton;
        private System.Windows.Forms.ToolStripButton ChonUngCuVien_toolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewExTonGiao;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton Thoat_toolStripButton;
    }
}