namespace ManagementSASI
{
    partial class frmTrainingInformation
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
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.grcTrainingInformation = new DevExpress.XtraGrid.GridControl();
            this.grvTrainingInformation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupTrainInfo = new DevExpress.XtraEditors.GroupControl();
            this.tedInfoName = new DevExpress.XtraEditors.TextEdit();
            this.cboLearningType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboTrainType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboTrainingType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcTrainingInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrainingInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTrainInfo)).BeginInit();
            this.groupTrainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedInfoName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLearningType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainingType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(247, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(166, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(85, 97);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Làm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grcTrainingInformation
            // 
            this.grcTrainingInformation.Location = new System.Drawing.Point(6, 127);
            this.grcTrainingInformation.MainView = this.grvTrainingInformation;
            this.grcTrainingInformation.Name = "grcTrainingInformation";
            this.grcTrainingInformation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcTrainingInformation.Size = new System.Drawing.Size(625, 306);
            this.grcTrainingInformation.TabIndex = 5;
            this.grcTrainingInformation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTrainingInformation});
            // 
            // grvTrainingInformation
            // 
            this.grvTrainingInformation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.grvTrainingInformation.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grvTrainingInformation.GridControl = this.grcTrainingInformation;
            this.grvTrainingInformation.GroupPanelText = "Chọn cột để gom nhóm";
            this.grvTrainingInformation.IndicatorWidth = 60;
            this.grvTrainingInformation.Name = "grvTrainingInformation";
            this.grvTrainingInformation.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grvTrainingInformation.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvTrainingInformation.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvTrainingInformation.OptionsSelection.MultiSelect = true;
            this.grvTrainingInformation.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.grvTrainingInformation.OptionsView.ShowAutoFilterRow = true;
            this.grvTrainingInformation.ViewCaption = "thu xem sao";
            this.grvTrainingInformation.Click += new System.EventHandler(this.grvTrainingInformation_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên thông tin";
            this.gridColumn5.FieldName = "InfoName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 88;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại hệ đào tạo";
            this.gridColumn2.FieldName = "TrainType";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 137;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại hình đào tạo";
            this.gridColumn3.FieldName = "TrainingType";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại học";
            this.gridColumn4.FieldName = "LearningType";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 50;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueUnchecked = true;
            // 
            // groupTrainInfo
            // 
            this.groupTrainInfo.Controls.Add(this.tedInfoName);
            this.groupTrainInfo.Controls.Add(this.cboLearningType);
            this.groupTrainInfo.Controls.Add(this.cboTrainType);
            this.groupTrainInfo.Controls.Add(this.cboTrainingType);
            this.groupTrainInfo.Controls.Add(this.labelControl3);
            this.groupTrainInfo.Controls.Add(this.labelControl1);
            this.groupTrainInfo.Controls.Add(this.lbTen);
            this.groupTrainInfo.Controls.Add(this.labelControl2);
            this.groupTrainInfo.Location = new System.Drawing.Point(6, 9);
            this.groupTrainInfo.Name = "groupTrainInfo";
            this.groupTrainInfo.Size = new System.Drawing.Size(625, 81);
            this.groupTrainInfo.TabIndex = 0;
            this.groupTrainInfo.Text = "Thông tin đào tạo ( phím tắt F3: thêm, F4: sửa, F5: xóa, F6: tạo mới )";
            this.groupTrainInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.groupTrainInfo_Paint);
            // 
            // tedInfoName
            // 
            this.tedInfoName.Location = new System.Drawing.Point(89, 27);
            this.tedInfoName.Name = "tedInfoName";
            this.tedInfoName.Size = new System.Drawing.Size(195, 20);
            this.tedInfoName.TabIndex = 0;
            // 
            // cboLearningType
            // 
            this.cboLearningType.Location = new System.Drawing.Point(387, 53);
            this.cboLearningType.Name = "cboLearningType";
            this.cboLearningType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLearningType.Properties.Items.AddRange(new object[] {
            "Cải thiện",
            "Học lại",
            "Học lại, cải thiện",
            "Thi lại giữa học phần",
            "Thi lại kết thúc học phần"});
            this.cboLearningType.Properties.Sorted = true;
            this.cboLearningType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLearningType.Size = new System.Drawing.Size(233, 20);
            this.cboLearningType.TabIndex = 3;
            // 
            // cboTrainType
            // 
            this.cboTrainType.Location = new System.Drawing.Point(88, 51);
            this.cboTrainType.Name = "cboTrainType";
            this.cboTrainType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrainType.Properties.Items.AddRange(new object[] {
            "Đại học - Cao đẳng",
            "Trung cấp"});
            this.cboTrainType.Properties.Sorted = true;
            this.cboTrainType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTrainType.Size = new System.Drawing.Size(196, 20);
            this.cboTrainType.TabIndex = 1;
            // 
            // cboTrainingType
            // 
            this.cboTrainingType.Location = new System.Drawing.Point(387, 27);
            this.cboTrainingType.Name = "cboTrainingType";
            this.cboTrainingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrainingType.Properties.Items.AddRange(new object[] {
            "Niên chế",
            "Tín chỉ"});
            this.cboTrainingType.Properties.Sorted = true;
            this.cboTrainingType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTrainingType.Size = new System.Drawing.Size(233, 20);
            this.cboTrainingType.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(294, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Loại học:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(294, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Loại hình đào tạo:";
            // 
            // lbTen
            // 
            this.lbTen.Location = new System.Drawing.Point(5, 30);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(68, 13);
            this.lbTen.TabIndex = 4;
            this.lbTen.Text = "Tên thông tin:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Loại hệ đào tạo:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(328, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmTrainingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(637, 440);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grcTrainingInformation);
            this.Controls.Add(this.groupTrainInfo);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Lilian";
            this.MaximizeBox = false;
            this.Name = "frmTrainingInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN ĐÀO TẠO";
            this.Load += new System.EventHandler(this.frmTrainingInformation_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrainingInformation_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrainingInformation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grcTrainingInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrainingInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTrainInfo)).EndInit();
            this.groupTrainInfo.ResumeLayout(false);
            this.groupTrainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedInfoName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLearningType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainingType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl grcTrainingInformation;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTrainingInformation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.GroupControl groupTrainInfo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboTrainingType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboLearningType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.ComboBoxEdit cboTrainType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit tedInfoName;
        private DevExpress.XtraEditors.LabelControl lbTen;
    }
}