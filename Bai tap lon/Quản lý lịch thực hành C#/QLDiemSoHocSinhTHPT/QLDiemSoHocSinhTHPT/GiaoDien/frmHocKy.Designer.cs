namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmHocKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocKy));
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btBoQua = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btThoat = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.itBoQua = new System.Windows.Forms.ToolStripMenuItem();
            this.itLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.colMaHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.btThemMoi = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnDS = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnDS)).BeginInit();
            this.bnDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // btBoQua
            // 
            this.btBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btBoQua.Image")));
            this.btBoQua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(56, 41);
            this.btBoQua.Text = "  Bỏ qua  ";
            this.btBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // btLuu
            // 
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(53, 41);
            this.btLuu.Text = "    Lưu    ";
            this.btLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(51, 41);
            this.btThoat.Text = "  Thoát  ";
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itThemMoi,
            this.itBoQua,
            this.itLuu,
            this.toolStripSeparator3,
            this.itXoa,
            this.toolStripSeparator4,
            this.itThoat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 126);
            // 
            // itThemMoi
            // 
            this.itThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("itThemMoi.Image")));
            this.itThemMoi.Name = "itThemMoi";
            this.itThemMoi.Size = new System.Drawing.Size(130, 22);
            this.itThemMoi.Text = "Thêm Mới";
            this.itThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // itBoQua
            // 
            this.itBoQua.Image = ((System.Drawing.Image)(resources.GetObject("itBoQua.Image")));
            this.itBoQua.Name = "itBoQua";
            this.itBoQua.Size = new System.Drawing.Size(130, 22);
            this.itBoQua.Text = "Bỏ Qua";
            this.itBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // itLuu
            // 
            this.itLuu.Image = ((System.Drawing.Image)(resources.GetObject("itLuu.Image")));
            this.itLuu.Name = "itLuu";
            this.itLuu.Size = new System.Drawing.Size(130, 22);
            this.itLuu.Text = "Lưu";
            this.itLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // itXoa
            // 
            this.itXoa.Image = ((System.Drawing.Image)(resources.GetObject("itXoa.Image")));
            this.itXoa.Name = "itXoa";
            this.itXoa.Size = new System.Drawing.Size(130, 22);
            this.itXoa.Text = "Xóa";
            this.itXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // itThoat
            // 
            this.itThoat.Image = ((System.Drawing.Image)(resources.GetObject("itThoat.Image")));
            this.itThoat.Name = "itThoat";
            this.itThoat.Size = new System.Drawing.Size(130, 22);
            this.itThoat.Text = "Thoát";
            this.itThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocKy,
            this.colTenHocKy,
            this.colHeSo});
            this.dgvDS.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(0, 44);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.Size = new System.Drawing.Size(1076, 550);
            this.dgvDS.TabIndex = 1;
            this.dgvDS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellValueChanged);
            // 
            // colMaHocKy
            // 
            this.colMaHocKy.DataPropertyName = "MaHocKy";
            this.colMaHocKy.HeaderText = "Mã học kỳ";
            this.colMaHocKy.Name = "colMaHocKy";
            // 
            // colTenHocKy
            // 
            this.colTenHocKy.DataPropertyName = "TenHocKy";
            this.colTenHocKy.HeaderText = "Tên học kỳ";
            this.colTenHocKy.Name = "colTenHocKy";
            // 
            // colHeSo
            // 
            this.colHeSo.DataPropertyName = "HeSo";
            this.colHeSo.HeaderText = "Hệ số";
            this.colHeSo.Name = "colHeSo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 41);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btXoa.Name = "btXoa";
            this.btXoa.RightToLeftAutoMirrorImage = true;
            this.btXoa.Size = new System.Drawing.Size(53, 41);
            this.btXoa.Text = "    Xóa    ";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // btThemMoi
            // 
            this.btThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btThemMoi.Image")));
            this.btThemMoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.RightToLeftAutoMirrorImage = true;
            this.btThemMoi.Size = new System.Drawing.Size(56, 41);
            this.btThemMoi.Text = "Thêm mới";
            this.btThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDS);
            this.panel1.Controls.Add(this.bnDS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 594);
            this.panel1.TabIndex = 2;
            // 
            // bnDS
            // 
            this.bnDS.AddNewItem = null;
            this.bnDS.CountItem = this.bindingNavigatorCountItem;
            this.bnDS.DeleteItem = null;
            this.bnDS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btThemMoi,
            this.btBoQua,
            this.btLuu,
            this.toolStripSeparator1,
            this.btXoa,
            this.toolStripSeparator2,
            this.btThoat});
            this.bnDS.Location = new System.Drawing.Point(0, 0);
            this.bnDS.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnDS.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnDS.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnDS.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnDS.Name = "bnDS";
            this.bnDS.PositionItem = this.bindingNavigatorPositionItem;
            this.bnDS.Size = new System.Drawing.Size(1076, 44);
            this.bnDS.TabIndex = 0;
            this.bnDS.Text = "bnDS";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaDanToc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã dân tộc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDanToc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên dân tộc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HeSo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hệ số";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 594);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHocKy";
            this.Text = "Hoc ky";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmHocKy_Shown);
            this.Load += new System.EventHandler(this.frmHocKy_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnDS)).EndInit();
            this.bnDS.ResumeLayout(false);
            this.bnDS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btBoQua;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btThoat;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itThemMoi;
        private System.Windows.Forms.ToolStripMenuItem itBoQua;
        private System.Windows.Forms.ToolStripMenuItem itLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itThoat;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeSo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton btThemMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bnDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}