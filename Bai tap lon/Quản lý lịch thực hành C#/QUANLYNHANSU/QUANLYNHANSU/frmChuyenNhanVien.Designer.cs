namespace QUANLYNHANSU
{
    partial class frmChuyenNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenNhanVien));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtgChuyenNV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbcolNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbcolSQD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.calNgayChuyen = new GenericDataGridView.GenericDataGridView.CalendarColumn();
            this.cmbcolTrongHayNgoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbcolPBMoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bnChuyenNV = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bntThem = new System.Windows.Forms.ToolStripButton();
            this.bntLuu = new System.Windows.Forms.ToolStripButton();
            this.bntXoa = new System.Windows.Forms.ToolStripButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbNV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbSQD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dteNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbtrongNgoai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.txtDonViDen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cmbPB = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtghiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChuyenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnChuyenNV)).BeginInit();
            this.bnChuyenNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dtgChuyenNV);
            this.groupPanel1.Controls.Add(this.bnChuyenNV);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 178);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(782, 329);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Danh sách chuyển nhân viên";
            // 
            // dtgChuyenNV
            // 
            this.dtgChuyenNV.AllowUserToAddRows = false;
            this.dtgChuyenNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChuyenNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbcolNV,
            this.cmbcolSQD,
            this.calNgayChuyen,
            this.cmbcolTrongHayNgoai,
            this.cmbcolPBMoi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChuyenNV.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgChuyenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgChuyenNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgChuyenNV.Location = new System.Drawing.Point(0, 25);
            this.dtgChuyenNV.Name = "dtgChuyenNV";
            this.dtgChuyenNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChuyenNV.Size = new System.Drawing.Size(776, 283);
            this.dtgChuyenNV.TabIndex = 1;
            this.dtgChuyenNV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChuyenNV_CellEndEdit);
            // 
            // cmbcolNV
            // 
            this.cmbcolNV.HeaderText = "Nhân viên";
            this.cmbcolNV.Name = "cmbcolNV";
            // 
            // cmbcolSQD
            // 
            this.cmbcolSQD.HeaderText = "Sổ QĐ";
            this.cmbcolSQD.Name = "cmbcolSQD";
            // 
            // calNgayChuyen
            // 
            this.calNgayChuyen.DataPropertyName = "ngaychuyen";
            this.calNgayChuyen.HeaderText = "Ngày chuyển";
            this.calNgayChuyen.Name = "calNgayChuyen";
            // 
            // cmbcolTrongHayNgoai
            // 
            this.cmbcolTrongHayNgoai.DataPropertyName = "tronghayngoai";
            this.cmbcolTrongHayNgoai.HeaderText = "Trong/Ngoài";
            this.cmbcolTrongHayNgoai.Items.AddRange(new object[] {
            "Trong",
            "Ngoài"});
            this.cmbcolTrongHayNgoai.Name = "cmbcolTrongHayNgoai";
            // 
            // cmbcolPBMoi
            // 
            this.cmbcolPBMoi.HeaderText = "Phòng đến";
            this.cmbcolPBMoi.Name = "cmbcolPBMoi";
            // 
            // bnChuyenNV
            // 
            this.bnChuyenNV.AddNewItem = null;
            this.bnChuyenNV.CountItem = this.bindingNavigatorCountItem;
            this.bnChuyenNV.DeleteItem = null;
            this.bnChuyenNV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bntThem,
            this.bntLuu,
            this.bntXoa});
            this.bnChuyenNV.Location = new System.Drawing.Point(0, 0);
            this.bnChuyenNV.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnChuyenNV.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnChuyenNV.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnChuyenNV.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnChuyenNV.Name = "bnChuyenNV";
            this.bnChuyenNV.PositionItem = this.bindingNavigatorPositionItem;
            this.bnChuyenNV.Size = new System.Drawing.Size(776, 25);
            this.bnChuyenNV.TabIndex = 0;
            this.bnChuyenNV.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bntThem
            // 
            this.bntThem.Image = ((System.Drawing.Image)(resources.GetObject("bntThem.Image")));
            this.bntThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(53, 22);
            this.bntThem.Text = "Thêm";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.Image = ((System.Drawing.Image)(resources.GetObject("bntLuu.Image")));
            this.bntLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(45, 22);
            this.bntLuu.Text = "Lưu";
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Image = ((System.Drawing.Image)(resources.GetObject("bntXoa.Image")));
            this.bntXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(45, 22);
            this.bntXoa.Text = "Xóa";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(74, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(99, 18);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Mã chuyển NV";
            // 
            // txtMa
            // 
            // 
            // 
            // 
            this.txtMa.Border.Class = "TextBoxBorder";
            this.txtMa.Location = new System.Drawing.Point(179, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(121, 20);
            this.txtMa.TabIndex = 2;
            // 
            // cmbNV
            // 
            this.cmbNV.DisplayMember = "Text";
            this.cmbNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.ItemHeight = 14;
            this.cmbNV.Location = new System.Drawing.Point(179, 67);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(121, 20);
            this.cmbNV.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(74, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 18);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Tên nhân viên";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(74, 108);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 18);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Sổ quyết định";
            // 
            // cmbSQD
            // 
            this.cmbSQD.DisplayMember = "Text";
            this.cmbSQD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSQD.FormattingEnabled = true;
            this.cmbSQD.ItemHeight = 14;
            this.cmbSQD.Location = new System.Drawing.Point(179, 106);
            this.cmbSQD.Name = "cmbSQD";
            this.cmbSQD.Size = new System.Drawing.Size(121, 20);
            this.cmbSQD.TabIndex = 5;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(74, 144);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(99, 18);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Ngày chuyển";
            // 
            // dteNgayChuyen
            // 
            this.dteNgayChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteNgayChuyen.Location = new System.Drawing.Point(179, 144);
            this.dteNgayChuyen.Name = "dteNgayChuyen";
            this.dteNgayChuyen.Size = new System.Drawing.Size(121, 20);
            this.dteNgayChuyen.TabIndex = 8;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(414, 29);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(139, 18);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "Trong hay ngoài ngân hàng";
            // 
            // cmbtrongNgoai
            // 
            this.cmbtrongNgoai.DisplayMember = "Text";
            this.cmbtrongNgoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtrongNgoai.FormattingEnabled = true;
            this.cmbtrongNgoai.ItemHeight = 14;
            this.cmbtrongNgoai.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbtrongNgoai.Location = new System.Drawing.Point(570, 30);
            this.cmbtrongNgoai.Name = "cmbtrongNgoai";
            this.cmbtrongNgoai.Size = new System.Drawing.Size(121, 20);
            this.cmbtrongNgoai.TabIndex = 9;
            this.cmbtrongNgoai.SelectedIndexChanged += new System.EventHandler(this.cmbtrongNgoai_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Trong";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Ngoài";
            // 
            // txtDonViDen
            // 
            // 
            // 
            // 
            this.txtDonViDen.Border.Class = "TextBoxBorder";
            this.txtDonViDen.Location = new System.Drawing.Point(570, 69);
            this.txtDonViDen.Name = "txtDonViDen";
            this.txtDonViDen.Size = new System.Drawing.Size(121, 20);
            this.txtDonViDen.TabIndex = 12;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(472, 67);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(81, 18);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "Đơn vị đến";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(435, 106);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(118, 18);
            this.labelX7.TabIndex = 14;
            this.labelX7.Text = "Chuyển đến phòng ban";
            // 
            // cmbPB
            // 
            this.cmbPB.DisplayMember = "Text";
            this.cmbPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPB.FormattingEnabled = true;
            this.cmbPB.ItemHeight = 14;
            this.cmbPB.Location = new System.Drawing.Point(570, 104);
            this.cmbPB.Name = "cmbPB";
            this.cmbPB.Size = new System.Drawing.Size(121, 20);
            this.cmbPB.TabIndex = 13;
            // 
            // txtghiChu
            // 
            // 
            // 
            // 
            this.txtghiChu.Border.Class = "TextBoxBorder";
            this.txtghiChu.Location = new System.Drawing.Point(570, 136);
            this.txtghiChu.Multiline = true;
            this.txtghiChu.Name = "txtghiChu";
            this.txtghiChu.Size = new System.Drawing.Size(121, 36);
            this.txtghiChu.TabIndex = 16;
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(509, 144);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(44, 18);
            this.labelX8.TabIndex = 15;
            this.labelX8.Text = "Ghi chú";
            // 
            // frmChuyenNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 507);
            this.Controls.Add(this.txtghiChu);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cmbPB);
            this.Controls.Add(this.txtDonViDen);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.cmbtrongNgoai);
            this.Controls.Add(this.dteNgayChuyen);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cmbSQD);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbNV);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmChuyenNhanVien";
            this.Text = "frmChuyenNhanVien";
            this.Load += new System.EventHandler(this.frmChuyenNhanVien_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChuyenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnChuyenNV)).EndInit();
            this.bnChuyenNV.ResumeLayout(false);
            this.bnChuyenNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgChuyenNV;
        private System.Windows.Forms.BindingNavigator bnChuyenNV;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNV;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSQD;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DateTimePicker dteNgayChuyen;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbtrongNgoai;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonViDen;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtghiChu;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbcolNV;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbcolSQD;
        private GenericDataGridView.GenericDataGridView.CalendarColumn calNgayChuyen;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbcolTrongHayNgoai;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbcolPBMoi;
        private System.Windows.Forms.ToolStripButton bntThem;
        private System.Windows.Forms.ToolStripButton bntLuu;
        private System.Windows.Forms.ToolStripButton bntXoa;
    }
}