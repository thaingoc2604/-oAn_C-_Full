namespace QUANLIKH.GiaoDien
{
    partial class frmHopDongDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDongDaiLy));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtSoHopDong = new System.Windows.Forms.TextBox();
            this.dtNgayThanhLy = new System.Windows.Forms.DateTimePicker();
            this.dtNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.txtTenHopDong = new System.Windows.Forms.TextBox();
            this.cmbMaDaiLy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.Luu = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCalendarColumn1 = new QUANLIKH.Librarý.DataGridViewCalendarColumn();
            this.dataGridViewCalendarColumn2 = new QUANLIKH.Librarý.DataGridViewCalendarColumn();
            this.dataGridViewCalendarColumn3 = new QUANLIKH.Librarý.DataGridViewCalendarColumn();
            this.SOHOPDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADAILY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHOPDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKY = new QUANLIKH.Librarý.DataGridViewCalendarColumn();
            this.NGAYHETHAN = new QUANLIKH.Librarý.DataGridViewCalendarColumn();
            this.NGAYTHANHLY = new QUANLIKH.Librarý.DataGridViewCalendarColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonX1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoHopDong);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayThanhLy);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayHetHan);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKy);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenHopDong);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMaDaiLy);
            this.splitContainer1.Panel1.Controls.Add(this.labelX6);
            this.splitContainer1.Panel1.Controls.Add(this.labelX5);
            this.splitContainer1.Panel1.Controls.Add(this.labelX4);
            this.splitContainer1.Panel1.Controls.Add(this.labelX3);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Panel2.Controls.Add(this.bn);
            this.splitContainer1.Size = new System.Drawing.Size(818, 483);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.ForeColor = System.Drawing.Color.Crimson;
            this.buttonX1.Location = new System.Drawing.Point(264, 213);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(130, 23);
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Thông Tin Đại Lý";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.Location = new System.Drawing.Point(358, 75);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.Size = new System.Drawing.Size(117, 20);
            this.txtSoHopDong.TabIndex = 1;
            // 
            // dtNgayThanhLy
            // 
            this.dtNgayThanhLy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThanhLy.Location = new System.Drawing.Point(568, 213);
            this.dtNgayThanhLy.Name = "dtNgayThanhLy";
            this.dtNgayThanhLy.Size = new System.Drawing.Size(122, 20);
            this.dtNgayThanhLy.TabIndex = 6;
            // 
            // dtNgayHetHan
            // 
            this.dtNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHetHan.Location = new System.Drawing.Point(568, 166);
            this.dtNgayHetHan.Name = "dtNgayHetHan";
            this.dtNgayHetHan.Size = new System.Drawing.Size(122, 20);
            this.dtNgayHetHan.TabIndex = 5;
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKy.Location = new System.Drawing.Point(568, 119);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(122, 20);
            this.dtNgayKy.TabIndex = 4;
            // 
            // txtTenHopDong
            // 
            this.txtTenHopDong.Location = new System.Drawing.Point(213, 122);
            this.txtTenHopDong.Name = "txtTenHopDong";
            this.txtTenHopDong.Size = new System.Drawing.Size(197, 20);
            this.txtTenHopDong.TabIndex = 2;
            // 
            // cmbMaDaiLy
            // 
            this.cmbMaDaiLy.DisplayMember = "Text";
            this.cmbMaDaiLy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaDaiLy.FormattingEnabled = true;
            this.cmbMaDaiLy.ItemHeight = 14;
            this.cmbMaDaiLy.Location = new System.Drawing.Point(213, 166);
            this.cmbMaDaiLy.Name = "cmbMaDaiLy";
            this.cmbMaDaiLy.Size = new System.Drawing.Size(197, 20);
            this.cmbMaDaiLy.TabIndex = 3;
            // 
            // labelX6
            // 
            this.labelX6.ForeColor = System.Drawing.Color.Blue;
            this.labelX6.Location = new System.Drawing.Point(483, 210);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "Ngày Thanh Lý";
            // 
            // labelX5
            // 
            this.labelX5.ForeColor = System.Drawing.Color.Blue;
            this.labelX5.Location = new System.Drawing.Point(483, 167);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "Ngày Hết Hạn";
            // 
            // labelX4
            // 
            this.labelX4.ForeColor = System.Drawing.Color.Blue;
            this.labelX4.Location = new System.Drawing.Point(483, 119);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Ngày Ký";
            // 
            // labelX3
            // 
            this.labelX3.ForeColor = System.Drawing.Color.Blue;
            this.labelX3.Location = new System.Drawing.Point(121, 119);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Tên Hợp Đồng";
            // 
            // labelX2
            // 
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(121, 167);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tên Đại Lý";
            // 
            // labelX1
            // 
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(264, 75);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Số Hợp Đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỢP ĐỒNG ĐẠI LÝ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOHOPDONG,
            this.MADAILY,
            this.TENHOPDONG,
            this.NGAYKY,
            this.NGAYHETHAN,
            this.NGAYTHANHLY});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 52);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(818, 183);
            this.dgv.TabIndex = 7;
            this.dgv.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_UserDeletingRow);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // bn
            // 
            this.bn.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = null;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.Luu});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(818, 52);
            this.bn.TabIndex = 6;
            this.bn.Text = "bindingNavigatorKhachHang";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Blue;
            this.bindingNavigatorAddNewItem.Image = global::QUANLIKH.Properties.Resources.themmoi32x321;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(37, 49);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 49);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 52);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 49);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Blue;
            this.bindingNavigatorDeleteItem.Image = global::QUANLIKH.Properties.Resources._53;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 49);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // Luu
            // 
            this.Luu.ForeColor = System.Drawing.Color.Blue;
            this.Luu.Image = global::QUANLIKH.Properties.Resources.Save;
            this.Luu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(36, 49);
            this.Luu.Text = "Lưu";
            this.Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SOHOPDONG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Hợp Đồng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MADAILY";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Đại Lý";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENHOPDONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Hợp Đồng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewCalendarColumn1
            // 
            this.dataGridViewCalendarColumn1.DataPropertyName = "NGAYKY";
            this.dataGridViewCalendarColumn1.HeaderText = "Ngày Ký";
            this.dataGridViewCalendarColumn1.Name = "dataGridViewCalendarColumn1";
            this.dataGridViewCalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewCalendarColumn2
            // 
            this.dataGridViewCalendarColumn2.DataPropertyName = "NGAYHETHAN";
            this.dataGridViewCalendarColumn2.HeaderText = "Ngày Hết Hạn";
            this.dataGridViewCalendarColumn2.Name = "dataGridViewCalendarColumn2";
            this.dataGridViewCalendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCalendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewCalendarColumn3
            // 
            this.dataGridViewCalendarColumn3.DataPropertyName = "NGAYTHANHLY";
            this.dataGridViewCalendarColumn3.HeaderText = "Ngày Thanh Lý";
            this.dataGridViewCalendarColumn3.Name = "dataGridViewCalendarColumn3";
            this.dataGridViewCalendarColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCalendarColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCalendarColumn3.Width = 130;
            // 
            // SOHOPDONG
            // 
            this.SOHOPDONG.DataPropertyName = "SOHOPDONG";
            this.SOHOPDONG.HeaderText = "Số Hợp Đồng";
            this.SOHOPDONG.Name = "SOHOPDONG";
            this.SOHOPDONG.Width = 130;
            // 
            // MADAILY
            // 
            this.MADAILY.DataPropertyName = "MADAILY";
            this.MADAILY.HeaderText = "Mã Đại Lý";
            this.MADAILY.Name = "MADAILY";
            // 
            // TENHOPDONG
            // 
            this.TENHOPDONG.DataPropertyName = "TENHOPDONG";
            this.TENHOPDONG.HeaderText = "Tên Hợp Đồng";
            this.TENHOPDONG.Name = "TENHOPDONG";
            this.TENHOPDONG.Width = 120;
            // 
            // NGAYKY
            // 
            this.NGAYKY.DataPropertyName = "NGAYKY";
            this.NGAYKY.HeaderText = "Ngày Ký";
            this.NGAYKY.Name = "NGAYKY";
            this.NGAYKY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NGAYKY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NGAYHETHAN
            // 
            this.NGAYHETHAN.DataPropertyName = "NGAYHETHAN";
            this.NGAYHETHAN.HeaderText = "Ngày Hết Hạn";
            this.NGAYHETHAN.Name = "NGAYHETHAN";
            this.NGAYHETHAN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NGAYHETHAN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NGAYTHANHLY
            // 
            this.NGAYTHANHLY.DataPropertyName = "NGAYTHANHLY";
            this.NGAYTHANHLY.HeaderText = "Ngày Thanh Lý";
            this.NGAYTHANHLY.Name = "NGAYTHANHLY";
            this.NGAYTHANHLY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NGAYTHANHLY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NGAYTHANHLY.Width = 130;
            // 
            // frmHopDongDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 483);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHopDongDaiLy";
            this.Text = "frmHopDongDaiLy";
            this.Load += new System.EventHandler(this.frmHopDongDaiLy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private System.Windows.Forms.TextBox txtTenHopDong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaDaiLy;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker dtNgayThanhLy;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton Luu;
        private System.Windows.Forms.TextBox txtSoHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private QUANLIKH.Librarý.DataGridViewCalendarColumn dataGridViewCalendarColumn1;
        private QUANLIKH.Librarý.DataGridViewCalendarColumn dataGridViewCalendarColumn2;
        private QUANLIKH.Librarý.DataGridViewCalendarColumn dataGridViewCalendarColumn3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOHOPDONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADAILY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHOPDONG;
        private QUANLIKH.Librarý.DataGridViewCalendarColumn NGAYKY;
        private QUANLIKH.Librarý.DataGridViewCalendarColumn NGAYHETHAN;
        private QUANLIKH.Librarý.DataGridViewCalendarColumn NGAYTHANHLY;
    }
}