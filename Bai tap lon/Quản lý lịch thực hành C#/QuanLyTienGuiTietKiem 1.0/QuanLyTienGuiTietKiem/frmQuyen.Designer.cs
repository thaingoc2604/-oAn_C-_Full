namespace QuanLyTienGuiTietKiem
{
    partial class frmQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BindingNavigatorQuyen = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.DGVQuyen = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnclose = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorQuyen)).BeginInit();
            this.BindingNavigatorQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BindingNavigatorQuyen
            // 
            this.BindingNavigatorQuyen.AddNewItem = null;
            this.BindingNavigatorQuyen.AutoSize = false;
            this.BindingNavigatorQuyen.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorQuyen.DeleteItem = null;
            this.BindingNavigatorQuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCloseItem});
            this.BindingNavigatorQuyen.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorQuyen.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorQuyen.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorQuyen.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorQuyen.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorQuyen.Name = "BindingNavigatorQuyen";
            this.BindingNavigatorQuyen.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorQuyen.Size = new System.Drawing.Size(383, 38);
            this.BindingNavigatorQuyen.TabIndex = 0;
            this.BindingNavigatorQuyen.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 35);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(37, 35);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 35);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.save;
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 35);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCloseItem
            // 
            this.bindingNavigatorCloseItem.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Exit;
            this.bindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCloseItem.Name = "bindingNavigatorCloseItem";
            this.bindingNavigatorCloseItem.Size = new System.Drawing.Size(39, 35);
            this.bindingNavigatorCloseItem.Text = "Thoát";
            this.bindingNavigatorCloseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCloseItem.Click += new System.EventHandler(this.bindingNavigatorCloseItem_Click);
            // 
            // DGVQuyen
            // 
            this.DGVQuyen.AllowUserToAddRows = false;
            this.DGVQuyen.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DGVQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaQuyen,
            this.colTenQuyen});
            this.ContextMenuBar.SetContextMenuEx(this.DGVQuyen, this.btnMenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVQuyen.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVQuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVQuyen.Location = new System.Drawing.Point(0, 38);
            this.DGVQuyen.Name = "DGVQuyen";
            this.DGVQuyen.Size = new System.Drawing.Size(383, 281);
            this.DGVQuyen.TabIndex = 1;
            // 
            // colMaQuyen
            // 
            this.colMaQuyen.DataPropertyName = "MaQuyen";
            this.colMaQuyen.HeaderText = "Mã quyền";
            this.colMaQuyen.Name = "colMaQuyen";
            this.colMaQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTenQuyen
            // 
            this.colTenQuyen.DataPropertyName = "TenQuyen";
            this.colTenQuyen.HeaderText = "Tên quyền ND";
            this.colTenQuyen.Name = "colTenQuyen";
            this.colTenQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenQuyen.Width = 150;
            // 
            // ContextMenuBar
            // 
            this.ContextMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ContextMenuBar.Location = new System.Drawing.Point(134, 135);
            this.ContextMenuBar.Name = "ContextMenuBar";
            this.ContextMenuBar.Size = new System.Drawing.Size(72, 25);
            this.ContextMenuBar.Stretch = true;
            this.ContextMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.ContextMenuBar.TabIndex = 2;
            this.ContextMenuBar.TabStop = false;
            this.ContextMenuBar.Text = "\\";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.ImagePaddingHorizontal = 8;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSave,
            this.btnAdd,
            this.btnDelete,
            this.btnclose});
            this.btnMenu.Text = "Menu";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.save;
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu lại";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Add;
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnAdd.Text = "Thêm quyền người dùng";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Delete;
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa quyền người dùng";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::QuanLyTienGuiTietKiem.Properties.Resources.Exit;
            this.btnclose.ImagePaddingHorizontal = 8;
            this.btnclose.Name = "btnclose";
            this.btnclose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnclose.Text = "Đóng cửa sổ lại";
            this.btnclose.Click += new System.EventHandler(this.bindingNavigatorCloseItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaQuyen";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã quyền";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenQuyenND";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên quyền ND";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // frmQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 319);
            this.ContextMenuBar.SetContextMenuEx(this, this.btnMenu);
            this.Controls.Add(this.ContextMenuBar);
            this.Controls.Add(this.DGVQuyen);
            this.Controls.Add(this.BindingNavigatorQuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuyen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUYỀN NGƯỜI DÙNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorQuyen)).EndInit();
            this.BindingNavigatorQuyen.ResumeLayout(false);
            this.BindingNavigatorQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator BindingNavigatorQuyen;
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
        private DevComponents.DotNetBar.Controls.DataGridViewX DGVQuyen;
        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnclose;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCloseItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenQuyen;



    }
}