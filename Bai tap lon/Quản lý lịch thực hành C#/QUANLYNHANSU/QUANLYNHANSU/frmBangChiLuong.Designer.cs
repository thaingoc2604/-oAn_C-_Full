namespace QUANLYNHANSU
{
    partial class frmBangChiLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangChiLuong));
            this.bntChiLuong = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.cmbThang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.cmbNam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtgBangChiLuong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbcolTenNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bnBangChiLuong = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbPhong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reflectionLabel3 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBangChiLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBangChiLuong)).BeginInit();
            this.bnBangChiLuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntChiLuong
            // 
            this.bntChiLuong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntChiLuong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntChiLuong.Location = new System.Drawing.Point(687, 20);
            this.bntChiLuong.Name = "bntChiLuong";
            this.bntChiLuong.Size = new System.Drawing.Size(75, 23);
            this.bntChiLuong.TabIndex = 15;
            this.bntChiLuong.Text = "Chi lương";
            this.bntChiLuong.Click += new System.EventHandler(this.bntChiLuong_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Location = new System.Drawing.Point(75, 23);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(63, 20);
            this.reflectionLabel1.TabIndex = 11;
            this.reflectionLabel1.Text = "Chọn tháng";
            // 
            // cmbThang
            // 
            this.cmbThang.DisplayMember = "Text";
            this.cmbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.ItemHeight = 14;
            this.cmbThang.Location = new System.Drawing.Point(144, 23);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(75, 20);
            this.cmbThang.TabIndex = 12;
            // 
            // reflectionLabel2
            // 
            this.reflectionLabel2.Location = new System.Drawing.Point(264, 23);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(63, 20);
            this.reflectionLabel2.TabIndex = 13;
            this.reflectionLabel2.Text = "Chọn năm";
            // 
            // cmbNam
            // 
            this.cmbNam.DisplayMember = "Text";
            this.cmbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.ItemHeight = 14;
            this.cmbNam.Location = new System.Drawing.Point(333, 23);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(93, 20);
            this.cmbNam.TabIndex = 14;
            // 
            // dtgBangChiLuong
            // 
            this.dtgBangChiLuong.AllowUserToAddRows = false;
            this.dtgBangChiLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBangChiLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbcolTenNV});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBangChiLuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBangChiLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgBangChiLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgBangChiLuong.Location = new System.Drawing.Point(0, 103);
            this.dtgBangChiLuong.Name = "dtgBangChiLuong";
            this.dtgBangChiLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBangChiLuong.Size = new System.Drawing.Size(833, 412);
            this.dtgBangChiLuong.TabIndex = 17;
            this.dtgBangChiLuong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgBangChiLuong_CellFormatting);
            this.dtgBangChiLuong.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBangChiLuong_CellEndEdit);
            // 
            // cmbcolTenNV
            // 
            this.cmbcolTenNV.HeaderText = "Nhân viên";
            this.cmbcolTenNV.Name = "cmbcolTenNV";
            this.cmbcolTenNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbcolTenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bnBangChiLuong
            // 
            this.bnBangChiLuong.AddNewItem = null;
            this.bnBangChiLuong.CountItem = this.bindingNavigatorCountItem;
            this.bnBangChiLuong.DeleteItem = null;
            this.bnBangChiLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnBangChiLuong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnBangChiLuong.Location = new System.Drawing.Point(0, 78);
            this.bnBangChiLuong.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnBangChiLuong.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnBangChiLuong.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnBangChiLuong.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnBangChiLuong.Name = "bnBangChiLuong";
            this.bnBangChiLuong.PositionItem = this.bindingNavigatorPositionItem;
            this.bnBangChiLuong.Size = new System.Drawing.Size(833, 25);
            this.bnBangChiLuong.TabIndex = 18;
            this.bnBangChiLuong.Text = "bindingNavigator1";
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
            // cmbPhong
            // 
            this.cmbPhong.DisplayMember = "Text";
            this.cmbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.ItemHeight = 14;
            this.cmbPhong.Location = new System.Drawing.Point(525, 23);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(93, 20);
            this.cmbPhong.TabIndex = 20;
            // 
            // reflectionLabel3
            // 
            this.reflectionLabel3.Location = new System.Drawing.Point(456, 23);
            this.reflectionLabel3.Name = "reflectionLabel3";
            this.reflectionLabel3.Size = new System.Drawing.Size(63, 20);
            this.reflectionLabel3.TabIndex = 19;
            this.reflectionLabel3.Text = "Chọn phòng";
            // 
            // frmBangChiLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 515);
            this.Controls.Add(this.cmbPhong);
            this.Controls.Add(this.reflectionLabel3);
            this.Controls.Add(this.bnBangChiLuong);
            this.Controls.Add(this.dtgBangChiLuong);
            this.Controls.Add(this.bntChiLuong);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.reflectionLabel2);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.reflectionLabel1);
            this.Name = "frmBangChiLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bảng Chi Lương Nhân Viên";
            this.Activated += new System.EventHandler(this.frmBangChiLuong_Activated);
            this.Load += new System.EventHandler(this.frmBangChiLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBangChiLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBangChiLuong)).EndInit();
            this.bnBangChiLuong.ResumeLayout(false);
            this.bnBangChiLuong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bntChiLuong;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbThang;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNam;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public DevComponents.DotNetBar.Controls.DataGridViewX dtgBangChiLuong;
        public System.Windows.Forms.BindingNavigator bnBangChiLuong;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbcolTenNV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhong;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel3;

    }
}