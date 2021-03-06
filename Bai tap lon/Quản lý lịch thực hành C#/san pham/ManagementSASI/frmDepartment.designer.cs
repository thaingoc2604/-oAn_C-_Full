namespace ManagementSASI
{
    partial class frmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grcDepartment = new DevExpress.XtraEditors.GroupControl();
            this.txtDepartmentCode = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.medDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gctDepartment = new DevExpress.XtraGrid.GridControl();
            this.gvDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DepartmentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDepartment)).BeginInit();
            this.grcDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueUnchecked = true;
            // 
            // grcDepartment
            // 
            this.grcDepartment.Controls.Add(this.txtDepartmentCode);
            this.grcDepartment.Controls.Add(this.txtPhoneNumber);
            this.grcDepartment.Controls.Add(this.medDescription);
            this.grcDepartment.Controls.Add(this.labelControl4);
            this.grcDepartment.Controls.Add(this.labelControl3);
            this.grcDepartment.Controls.Add(this.txtDepartmentName);
            this.grcDepartment.Controls.Add(this.labelControl2);
            this.grcDepartment.Controls.Add(this.labelControl1);
            this.grcDepartment.Location = new System.Drawing.Point(8, 11);
            this.grcDepartment.Name = "grcDepartment";
            this.grcDepartment.Size = new System.Drawing.Size(504, 93);
            this.grcDepartment.TabIndex = 0;
            this.grcDepartment.Text = "Thông tin khoa";
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.Location = new System.Drawing.Point(76, 35);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(83, 20);
            this.txtDepartmentCode.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(232, 33);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.MaxLength = 12;
            this.txtPhoneNumber.Size = new System.Drawing.Size(88, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // medDescription
            // 
            this.medDescription.Location = new System.Drawing.Point(368, 33);
            this.medDescription.Name = "medDescription";
            this.medDescription.Size = new System.Drawing.Size(128, 48);
            this.medDescription.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(324, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ghi chú:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(165, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Số điện thoại:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(76, 63);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(244, 20);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tên khoa (*)";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mã khoa (*)";
            // 
            // gctDepartment
            // 
            this.gctDepartment.Location = new System.Drawing.Point(8, 144);
            this.gctDepartment.LookAndFeel.SkinName = "Blue";
            this.gctDepartment.MainView = this.gvDepartment;
            this.gctDepartment.Name = "gctDepartment";
            this.gctDepartment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gctDepartment.Size = new System.Drawing.Size(504, 224);
            this.gctDepartment.TabIndex = 5;
            this.gctDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepartment});
            this.gctDepartment.Click += new System.EventHandler(this.gctDepartment_Click);
            // 
            // gvDepartment
            // 
            this.gvDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DepartmentCode,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvDepartment.GridControl = this.gctDepartment;
            this.gvDepartment.GroupPanelText = "Cột gom nhóm";
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gvDepartment.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvDepartment.OptionsSelection.MultiSelect = true;
            this.gvDepartment.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvDepartment.OptionsView.ShowAutoFilterRow = true;
            this.gvDepartment.OptionsView.ShowDetailButtons = false;
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.Caption = "Mã khoa";
            this.DepartmentCode.FieldName = "DepartmentCode";
            this.DepartmentCode.Name = "DepartmentCode";
            this.DepartmentCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.DepartmentCode.OptionsColumn.ReadOnly = true;
            this.DepartmentCode.Visible = true;
            this.DepartmentCode.VisibleIndex = 0;
            this.DepartmentCode.Width = 136;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khoa";
            this.gridColumn2.FieldName = "DepartmentName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 262;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số điện thoại";
            this.gridColumn3.FieldName = "PhoneNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 114;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mô tả";
            this.gridColumn4.FieldName = "Description";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 185;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(82, 112);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(73, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Làm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(161, 112);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(69, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(236, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 378);
            this.Controls.Add(this.gctDepartment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grcDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blue";
            this.MaximizeBox = false;
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHOA";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDepartment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDepartment)).EndInit();
            this.grcDepartment.ResumeLayout(false);
            this.grcDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDepartmentName;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraGrid.GridControl gctDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn DepartmentCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.MemoEdit medDescription;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDepartmentCode;
    }
}