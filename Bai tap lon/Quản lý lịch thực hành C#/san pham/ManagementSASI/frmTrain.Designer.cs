namespace ManagementSASI
{
    partial class frmTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrain));
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.medDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtTrainName = new DevExpress.XtraEditors.TextEdit();
            this.txtTrainCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTrainID = new DevExpress.XtraEditors.LabelControl();
            this.grcTrain = new DevExpress.XtraGrid.GridControl();
            this.grvTrain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrainName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrainCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AllowGrayed = true;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueUnchecked = true;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueUnchecked = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.medDescription);
            this.groupControl1.Controls.Add(this.txtTrainName);
            this.groupControl1.Controls.Add(this.txtTrainCode);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblTrainID);
            this.groupControl1.Location = new System.Drawing.Point(8, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 93);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin về hệ đào tạo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(264, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Ghi chú ";
            // 
            // medDescription
            // 
            this.medDescription.Location = new System.Drawing.Point(312, 36);
            this.medDescription.Name = "medDescription";
            this.medDescription.Size = new System.Drawing.Size(184, 44);
            this.medDescription.TabIndex = 2;
            // 
            // txtTrainName
            // 
            this.txtTrainName.Location = new System.Drawing.Point(87, 63);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(169, 20);
            this.txtTrainName.TabIndex = 1;
            this.txtTrainName.TextChanged += new System.EventHandler(this.txtTrainName_TextChanged);
            // 
            // txtTrainCode
            // 
            this.txtTrainCode.Location = new System.Drawing.Point(87, 35);
            this.txtTrainCode.Name = "txtTrainCode";
            this.txtTrainCode.Size = new System.Drawing.Size(169, 20);
            this.txtTrainCode.TabIndex = 0;
            this.txtTrainCode.TextChanged += new System.EventHandler(this.txtTrainID_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên hệ đào tạo";
            // 
            // lblTrainID
            // 
            this.lblTrainID.Location = new System.Drawing.Point(8, 39);
            this.lblTrainID.Name = "lblTrainID";
            this.lblTrainID.Size = new System.Drawing.Size(69, 13);
            this.lblTrainID.TabIndex = 4;
            this.lblTrainID.Text = "Mã hệ đào tạo";
            // 
            // grcTrain
            // 
            this.grcTrain.Location = new System.Drawing.Point(8, 144);
            this.grcTrain.MainView = this.grvTrain;
            this.grcTrain.Name = "grcTrain";
            this.grcTrain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcTrain.Size = new System.Drawing.Size(504, 224);
            this.grcTrain.TabIndex = 5;
            this.grcTrain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTrain});
            this.grcTrain.Click += new System.EventHandler(this.grcTrain_Click);
            // 
            // grvTrain
            // 
            this.grvTrain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grvTrain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvTrain.GridControl = this.grcTrain;
            this.grvTrain.GroupPanelText = "Chọn cột để gom nhóm";
            this.grvTrain.IndicatorWidth = 60;
            this.grvTrain.Name = "grvTrain";
            this.grvTrain.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grvTrain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvTrain.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvTrain.OptionsSelection.MultiSelect = true;
            this.grvTrain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.grvTrain.OptionsView.ShowAutoFilterRow = true;
            this.grvTrain.ViewCaption = "thu xem sao";
            this.grvTrain.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvTrain_CustomDrawRowIndicator);
            this.grvTrain.ShowFilterPopupListBox += new DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventHandler(this.grvTrain_ShowFilterPopupListBox);
            this.grvTrain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvTrain_KeyDown);
            this.grvTrain.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.grvTrain_CustomDrawColumnHeader);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã hệ đào tạo  ";
            this.gridColumn1.FieldName = "TrainCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên hệ đào tạo  ";
            this.gridColumn2.FieldName = "TrainName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 250;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ghi chú";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 250;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(256, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(94, 112);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Làm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 378);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grcTrain);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blue";
            this.MaximizeBox = false;
            this.Name = "frmTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ ĐÀO TẠO";
            this.Load += new System.EventHandler(this.frmTrain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrainName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrainCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTrainCode;
        private DevExpress.XtraEditors.LabelControl lblTrainID;
        private DevExpress.XtraEditors.MemoEdit medDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grcTrain;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTrain;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.TextEdit txtTrainName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}