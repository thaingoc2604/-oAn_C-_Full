namespace ManagementSASI
{
    partial class frmClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClass));
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.speClassID = new DevExpress.XtraEditors.SpinEdit();
            this.txtClassID = new DevExpress.XtraEditors.TextEdit();
            this.btnDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrain = new DevExpress.XtraEditors.SimpleButton();
            this.mmoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbeStartYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbeEndYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTrain = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tedClassName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctClass = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speClassID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStartYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEndYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(88, 92);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(334, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(252, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(170, 92);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.speClassID);
            this.groupControl1.Controls.Add(this.txtClassID);
            this.groupControl1.Controls.Add(this.btnDepartment);
            this.groupControl1.Controls.Add(this.btnTrain);
            this.groupControl1.Controls.Add(this.mmoDescription);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.cbeStartYear);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cbeEndYear);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lueDepartment);
            this.groupControl1.Controls.Add(this.lueTrain);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tedClassName);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(754, 128);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin bắt buộc  ( phím tắt F3: thêm, F4: sửa, F5: xóa, F6: tạo mới )";
            // 
            // speClassID
            // 
            this.speClassID.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speClassID.Location = new System.Drawing.Point(510, 32);
            this.speClassID.Name = "speClassID";
            this.speClassID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speClassID.Properties.MaxLength = 1;
            this.speClassID.Properties.MaxValue = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.speClassID.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speClassID.Size = new System.Drawing.Size(45, 20);
            this.speClassID.TabIndex = 17;
            this.speClassID.EditValueChanged += new System.EventHandler(this.speClassID_EditValueChanged);
            // 
            // txtClassID
            // 
            this.txtClassID.Enabled = false;
            this.txtClassID.Location = new System.Drawing.Point(437, 32);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Properties.MaxLength = 6;
            this.txtClassID.Size = new System.Drawing.Size(72, 20);
            this.txtClassID.TabIndex = 16;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Image = global::ManagementSASI.Properties.Resources.Button_Add_icon;
            this.btnDepartment.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDepartment.Location = new System.Drawing.Point(204, 65);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(12, 12);
            this.btnDepartment.TabIndex = 15;
            this.btnDepartment.Text = "...";
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Image = global::ManagementSASI.Properties.Resources.Button_Add_icon;
            this.btnTrain.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTrain.Location = new System.Drawing.Point(204, 35);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(12, 12);
            this.btnTrain.TabIndex = 14;
            this.btnTrain.Text = "...";
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // mmoDescription
            // 
            this.mmoDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mmoDescription.Location = new System.Drawing.Point(606, 32);
            this.mmoDescription.Name = "mmoDescription";
            this.mmoDescription.Size = new System.Drawing.Size(139, 46);
            this.mmoDescription.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(561, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Ghi chú";
            // 
            // cbeStartYear
            // 
            this.cbeStartYear.Location = new System.Drawing.Point(316, 32);
            this.cbeStartYear.Name = "cbeStartYear";
            this.cbeStartYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeStartYear.Properties.MaxLength = 4;
            this.cbeStartYear.Properties.NullText = "----";
            this.cbeStartYear.Properties.Sorted = true;
            this.cbeStartYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeStartYear.Size = new System.Drawing.Size(56, 20);
            this.cbeStartYear.TabIndex = 4;
            this.cbeStartYear.SelectedIndexChanged += new System.EventHandler(this.cbeStartYear_SelectedIndexChanged);
            this.cbeStartYear.TextChanged += new System.EventHandler(this.cbeStartYear_TextChanged);
            this.cbeStartYear.Click += new System.EventHandler(this.cbeStartYear_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(245, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Năm bắt đầu";
            // 
            // cbeEndYear
            // 
            this.cbeEndYear.Location = new System.Drawing.Point(316, 61);
            this.cbeEndYear.Name = "cbeEndYear";
            this.cbeEndYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeEndYear.Properties.MaxLength = 4;
            this.cbeEndYear.Properties.NullText = "----";
            this.cbeEndYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeEndYear.Size = new System.Drawing.Size(56, 20);
            this.cbeEndYear.TabIndex = 5;
            this.cbeEndYear.SelectedIndexChanged += new System.EventHandler(this.cbeEndYear_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(245, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Năm kết thúc";
            // 
            // lueDepartment
            // 
            this.lueDepartment.Location = new System.Drawing.Point(88, 61);
            this.lueDepartment.Name = "lueDepartment";
            this.lueDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.lueDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentCode", "Mã khoa", 40),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Tên khoa", 200)});
            this.lueDepartment.Properties.DisplayMember = "DepartmentName";
            this.lueDepartment.Properties.NullText = "";
            this.lueDepartment.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDepartment.Properties.ValueMember = "DepartmentCode";
            this.lueDepartment.Size = new System.Drawing.Size(149, 20);
            this.lueDepartment.TabIndex = 3;
            this.lueDepartment.EditValueChanged += new System.EventHandler(this.lueDepartment_EditValueChanged);
            this.lueDepartment.TextChanged += new System.EventHandler(this.lueDepartment_TextChanged);
            this.lueDepartment.Click += new System.EventHandler(this.lueDepartment_Click);
            // 
            // lueTrain
            // 
            this.lueTrain.Location = new System.Drawing.Point(88, 32);
            this.lueTrain.Name = "lueTrain";
            this.lueTrain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.lueTrain.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainCode", "Mã hệ", 40),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainName", "Tên hệ", 40),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Ghi chú", 200)});
            this.lueTrain.Properties.DisplayMember = "TrainName";
            this.lueTrain.Properties.NullText = "";
            this.lueTrain.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueTrain.Properties.ValueMember = "TrainCode";
            this.lueTrain.Size = new System.Drawing.Size(149, 20);
            this.lueTrain.TabIndex = 2;
            this.lueTrain.EditValueChanged += new System.EventHandler(this.lueTrain_EditValueChanged);
            this.lueTrain.TextChanged += new System.EventHandler(this.lueTrain_TextChanged);
            this.lueTrain.Click += new System.EventHandler(this.lueTrain_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(11, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Khoa (*)";
            // 
            // tedClassName
            // 
            this.tedClassName.Location = new System.Drawing.Point(437, 61);
            this.tedClassName.Name = "tedClassName";
            this.tedClassName.Size = new System.Drawing.Size(118, 20);
            this.tedClassName.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Location = new System.Drawing.Point(381, 64);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 13);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Tên lớp (*)";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(381, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Mã lớp (*)";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(11, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Hệ đào tạo (*)";
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataMember = "Trains";
            // 
            // gvClass
            // 
            this.gvClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8});
            this.gvClass.GridControl = this.gctClass;
            this.gvClass.GroupPanelText = "Chọn cột gom nhóm";
            this.gvClass.Name = "gvClass";
            this.gvClass.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gvClass.OptionsSelection.MultiSelect = true;
            this.gvClass.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvClass.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã lớp";
            this.gridColumn1.FieldName = "ClassCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp";
            this.gridColumn2.FieldName = "ClassName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 66;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hệ đào tạo";
            this.gridColumn3.FieldName = "TrainName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 124;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Khoa";
            this.gridColumn4.FieldName = "DepartmentName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 133;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Năm bắt đầu";
            this.gridColumn5.FieldName = "StartYear";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 82;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Năm kết thúc";
            this.gridColumn6.FieldName = "EndYear";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 81;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ghi chú";
            this.gridColumn8.FieldName = "Description";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 181;
            // 
            // gctClass
            // 
            this.gctClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctClass.Location = new System.Drawing.Point(0, 128);
            this.gctClass.MainView = this.gvClass;
            this.gctClass.Name = "gctClass";
            this.gctClass.Size = new System.Drawing.Size(754, 488);
            this.gctClass.TabIndex = 5;
            this.gctClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClass});
            this.gctClass.Click += new System.EventHandler(this.gctClass_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 616);
            this.Controls.Add(this.gctClass);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Blue";
            this.MaximizeBox = false;
            this.Name = "frmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỚP HỌC";
            this.Load += new System.EventHandler(this.frmClass_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClass_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClass_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speClassID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStartYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEndYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tedClassName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.LookUpEdit lueDepartment;
        private DevExpress.XtraEditors.LookUpEdit lueTrain;
        private DevExpress.XtraEditors.LabelControl labelControl10;
     //   private ManagementSASIDataSet managementSASIDataSet;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private DevExpress.XtraEditors.MemoEdit mmoDescription;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbeStartYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbeEndYear;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnDepartment;
        private DevExpress.XtraEditors.SimpleButton btnTrain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClass;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.GridControl gctClass;
        private DevExpress.XtraEditors.TextEdit txtClassID;
        private DevExpress.XtraEditors.SpinEdit speClassID;
      //  private ManagementSASI.ManagementSASIDataSetTableAdapters.TrainsTableAdapter trainsTableAdapter;

    }
}