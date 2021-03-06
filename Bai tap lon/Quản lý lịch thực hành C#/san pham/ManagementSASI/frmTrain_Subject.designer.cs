namespace ManagementSASI
{
    partial class frmTrain_Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrain_Subject));
            this.lueTrain = new DevExpress.XtraEditors.LookUpEdit();
            this.lueSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spinLT = new DevExpress.XtraEditors.SpinEdit();
            this.spinTH = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSectionPractice = new DevExpress.XtraEditors.TextEdit();
            this.txtSectionTheory = new DevExpress.XtraEditors.TextEdit();
            this.lueSettingSubjectSplit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gctTrainSubject = new DevExpress.XtraGrid.GridControl();
            this.gvTrainSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionPractice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionTheory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSettingSubjectSplit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTrainSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrainSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // lueTrain
            // 
            this.lueTrain.Location = new System.Drawing.Point(92, 33);
            this.lueTrain.Name = "lueTrain";
            this.lueTrain.Properties.AutoSearchColumnIndex = 1;
            this.lueTrain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTrain.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainCode", "Mã hệ ", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainName", "Tên hệ", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Mô tả", 250)});
            this.lueTrain.Properties.DisplayMember = "TrainName";
            this.lueTrain.Properties.NullText = "";
            this.lueTrain.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueTrain.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTrain.Properties.ValueMember = "TrainCode";
            this.lueTrain.Size = new System.Drawing.Size(224, 20);
            this.lueTrain.TabIndex = 0;
            this.lueTrain.TextChanged += new System.EventHandler(this.lueTrain_TextChanged);
            // 
            // lueSubject
            // 
            this.lueSubject.Location = new System.Drawing.Point(449, 33);
            this.lueSubject.Name = "lueSubject";
            this.lueSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã môn", 10),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên môn", 40)});
            this.lueSubject.Properties.DisplayMember = "SubjectName";
            this.lueSubject.Properties.NullText = "";
            this.lueSubject.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueSubject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSubject.Properties.ValueMember = "SubjectCode";
            this.lueSubject.Size = new System.Drawing.Size(306, 20);
            this.lueSubject.TabIndex = 1;
            this.lueSubject.TextChanged += new System.EventHandler(this.lueSubject_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Hệ đào tạo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(321, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Môn học:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Số lý thuyết:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(162, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Số thực hành:";
            // 
            // spinLT
            // 
            this.spinLT.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinLT.Location = new System.Drawing.Point(92, 59);
            this.spinLT.Name = "spinLT";
            this.spinLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinLT.Size = new System.Drawing.Size(63, 20);
            this.spinLT.TabIndex = 2;
            this.spinLT.EditValueChanged += new System.EventHandler(this.spinLT_EditValueChanged);
            this.spinLT.ValueChanged += new System.EventHandler(this.spinLT_ValueChanged);
            // 
            // spinTH
            // 
            this.spinTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTH.Location = new System.Drawing.Point(245, 59);
            this.spinTH.Name = "spinTH";
            this.spinTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTH.Size = new System.Drawing.Size(71, 20);
            this.spinTH.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSectionPractice);
            this.groupControl1.Controls.Add(this.txtSectionTheory);
            this.groupControl1.Controls.Add(this.lueSettingSubjectSplit);
            this.groupControl1.Controls.Add(this.lueTrain);
            this.groupControl1.Controls.Add(this.spinTH);
            this.groupControl1.Controls.Add(this.lueSubject);
            this.groupControl1.Controls.Add(this.spinLT);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(8, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(762, 117);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin hệ đào tạo - môn học  ( phím tắt F3: thêm, F4: sửa, F5: xóa, F6: tạo mớ" +
                "i )";
            // 
            // txtSectionPractice
            // 
            this.txtSectionPractice.Location = new System.Drawing.Point(245, 85);
            this.txtSectionPractice.Name = "txtSectionPractice";
            this.txtSectionPractice.Properties.ReadOnly = true;
            this.txtSectionPractice.Size = new System.Drawing.Size(71, 20);
            this.txtSectionPractice.TabIndex = 6;
            this.txtSectionPractice.EditValueChanged += new System.EventHandler(this.txtHoursNumber_EditValueChanged);
            // 
            // txtSectionTheory
            // 
            this.txtSectionTheory.Location = new System.Drawing.Point(93, 85);
            this.txtSectionTheory.Name = "txtSectionTheory";
            this.txtSectionTheory.Properties.ReadOnly = true;
            this.txtSectionTheory.Size = new System.Drawing.Size(63, 20);
            this.txtSectionTheory.TabIndex = 5;
            // 
            // lueSettingSubjectSplit
            // 
            this.lueSettingSubjectSplit.Location = new System.Drawing.Point(449, 62);
            this.lueSettingSubjectSplit.Name = "lueSettingSubjectSplit";
            this.lueSettingSubjectSplit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSettingSubjectSplit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectSplitName", "Tên mức", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainingType", "Loại hình đào tạo", 60),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TheoryNumber", "Số tiết lý thuyết", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SectionNumber", "Số giờ thực hành", 50)});
            this.lueSettingSubjectSplit.Properties.DisplayMember = "SubjectSplitName";
            this.lueSettingSubjectSplit.Properties.NullText = "";
            this.lueSettingSubjectSplit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueSettingSubjectSplit.Properties.ValueMember = "SubjectSplitName";
            this.lueSettingSubjectSplit.Size = new System.Drawing.Size(306, 20);
            this.lueSettingSubjectSplit.TabIndex = 4;
            this.lueSettingSubjectSplit.EditValueChanged += new System.EventHandler(this.lueSettingSubjectSplit_EditValueChanged);
            this.lueSettingSubjectSplit.TextChanged += new System.EventHandler(this.lueTrain_TextChanged);
            this.lueSettingSubjectSplit.Click += new System.EventHandler(this.lueSettingSubjectSplit_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(162, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Tổng số tiết TH:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(321, 65);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Mức chia số tiết cho môn:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Tổng số tiết LT:";
            // 
            // gctTrainSubject
            // 
            this.gctTrainSubject.Location = new System.Drawing.Point(7, 164);
            this.gctTrainSubject.MainView = this.gvTrainSubject;
            this.gctTrainSubject.Name = "gctTrainSubject";
            this.gctTrainSubject.Size = new System.Drawing.Size(763, 332);
            this.gctTrainSubject.TabIndex = 5;
            this.gctTrainSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTrainSubject});
            this.gctTrainSubject.Click += new System.EventHandler(this.gctTrainSubject_Click);
            // 
            // gvTrainSubject
            // 
            this.gvTrainSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvTrainSubject.GridControl = this.gctTrainSubject;
            this.gvTrainSubject.GroupPanelText = "Cột gom nhóm";
            this.gvTrainSubject.Name = "gvTrainSubject";
            this.gvTrainSubject.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gvTrainSubject.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTrainSubject.OptionsSelection.MultiSelect = true;
            this.gvTrainSubject.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvTrainSubject.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Hệ đào tạo ";
            this.gridColumn1.FieldName = "TrainName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 77;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Môn học";
            this.gridColumn2.FieldName = "SubjectName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 153;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tín chỉ LT";
            this.gridColumn3.FieldName = "TheoryNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 74;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tín chỉ TH";
            this.gridColumn4.FieldName = "PracticeNumber";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 80;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên mức chia tiết";
            this.gridColumn5.FieldName = "SubjectSplitName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 115;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số tiết LT";
            this.gridColumn6.FieldName = "SectionTheory";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 115;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số tiết TH";
            this.gridColumn7.FieldName = "SectionPractice";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 128;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(100, 131);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(180, 131);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(72, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(258, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(336, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmTrain_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gctTrainSubject);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTrain_Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÔN HỌC THEO HỆ ĐÀO TẠO";
            this.Load += new System.EventHandler(this.frmTrain_Subject_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrain_Subject_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lueTrain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionPractice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionTheory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSettingSubjectSplit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTrainSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrainSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueTrain;
        private DevExpress.XtraEditors.LookUpEdit lueSubject;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinLT;
        private DevExpress.XtraEditors.SpinEdit spinTH;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gctTrainSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrainSubject;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.TextEdit txtSectionPractice;
        private DevExpress.XtraEditors.TextEdit txtSectionTheory;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lueSettingSubjectSplit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}