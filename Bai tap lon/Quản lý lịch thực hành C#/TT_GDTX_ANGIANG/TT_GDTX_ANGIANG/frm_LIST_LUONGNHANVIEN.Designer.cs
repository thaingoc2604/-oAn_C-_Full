namespace TT_GDTX_ANGIANG
{
    partial class frm_LIST_LUONGNHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LIST_LUONGNHANVIEN));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Thoat_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LamTuoi_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.listViewExLuong = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Thoat_toolStripButton,
            this.LamTuoi_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(896, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            // listViewExLuong
            // 
            // 
            // 
            // 
            this.listViewExLuong.Border.Class = "ListViewBorder";
            this.listViewExLuong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader5});
            this.listViewExLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewExLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listViewExLuong.FullRowSelect = true;
            this.listViewExLuong.GridLines = true;
            this.listViewExLuong.Location = new System.Drawing.Point(0, 25);
            this.listViewExLuong.Name = "listViewExLuong";
            this.listViewExLuong.Size = new System.Drawing.Size(896, 299);
            this.listViewExLuong.TabIndex = 6;
            this.listViewExLuong.UseCompatibleStateImageBehavior = false;
            this.listViewExLuong.View = System.Windows.Forms.View.Details;
            this.listViewExLuong.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listViewExLuong.SelectedIndexChanged += new System.EventHandler(this.listViewExLuong_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Họ Tên";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 2;
            this.columnHeader6.Text = "Lương";
            this.columnHeader6.Width = 77;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 3;
            this.columnHeader7.Text = "Trừ 6%";
            this.columnHeader7.Width = 67;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 4;
            this.columnHeader8.Text = "Lương Còn Lại";
            this.columnHeader8.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 5;
            this.columnHeader9.Text = "30%";
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 6;
            this.columnHeader10.Text = "20%";
            // 
            // columnHeader11
            // 
            this.columnHeader11.DisplayIndex = 7;
            this.columnHeader11.Text = "Đảng phí";
            this.columnHeader11.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 8;
            this.columnHeader5.Text = "Thực lãnh";
            this.columnHeader5.Width = 75;
            // 
            // frm_LIST_LUONGNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 324);
            this.Controls.Add(this.listViewExLuong);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frm_LIST_LUONGNHANVIEN";
            this.Text = "frm_LIST_LUONGNHANVIEN";
            this.Load += new System.EventHandler(this.frm_LIST_LUONGNHANVIEN_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Thoat_toolStripButton;
        private System.Windows.Forms.ToolStripButton LamTuoi_toolStripButton;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewExLuong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}