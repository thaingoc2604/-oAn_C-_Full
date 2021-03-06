namespace ManagementSASI
{
    partial class frmSASIClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSASIClass));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnInfor = new DevExpress.XtraEditors.SimpleButton();
            this.lueInfor = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboSemester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboShoolYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnTeacher = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpStarDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lueTeacher = new DevExpress.XtraEditors.LookUpEdit();
            this.mmoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tedSASIClassName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gctSASIClass = new DevExpress.XtraGrid.GridControl();
            this.gvSASIClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueInfor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedSASIClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSASIClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSASIClass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnInfor);
            this.groupControl1.Controls.Add(this.lueInfor);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.cboSemester);
            this.groupControl1.Controls.Add(this.cboShoolYear);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btnTeacher);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.dtpEndDate);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.dtpStarDate);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.lueTeacher);
            this.groupControl1.Controls.Add(this.mmoDescription);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tedSASIClassName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(929, 125);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phân lớp";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnInfor
            // 
            this.btnInfor.Image = global::ManagementSASI.Properties.Resources.Button_Add_icon;
            this.btnInfor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnInfor.Location = new System.Drawing.Point(200, 69);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(12, 12);
            this.btnInfor.TabIndex = 21;
            this.btnInfor.Text = "...";
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // lueInfor
            // 
            this.lueInfor.Location = new System.Drawing.Point(100, 65);
            this.lueInfor.Name = "lueInfor";
            this.lueInfor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInfor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InfoName", "Tên thông tin đào tạo", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LearningType", "Kiểu học", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainType", "Loại hệ", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainingType", "Loại đào tạo", 80)});
            this.lueInfor.Properties.DisplayMember = "InfoName";
            this.lueInfor.Properties.LookAndFeel.SkinName = "Blue";
            this.lueInfor.Properties.NullText = "";
            this.lueInfor.Properties.PopupWidth = 500;
            this.lueInfor.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueInfor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueInfor.Properties.ValueMember = "InfoID";
            this.lueInfor.Size = new System.Drawing.Size(137, 20);
            this.lueInfor.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Thông tin (*)";
            // 
            // cboSemester
            // 
            this.cboSemester.EditValue = "3";
            this.cboSemester.Location = new System.Drawing.Point(308, 65);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSemester.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSemester.Size = new System.Drawing.Size(73, 20);
            this.cboSemester.TabIndex = 6;
            this.cboSemester.TextChanged += new System.EventHandler(this.cboSemester_TextChanged);
            // 
            // cboShoolYear
            // 
            this.cboShoolYear.Location = new System.Drawing.Point(308, 38);
            this.cboShoolYear.Name = "cboShoolYear";
            this.cboShoolYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboShoolYear.Properties.Items.AddRange(new object[] {
            "2010-2011",
            "2011-2012",
            "2012-2013"});
            this.cboShoolYear.Size = new System.Drawing.Size(73, 20);
            this.cboShoolYear.TabIndex = 5;
            this.cboShoolYear.TextChanged += new System.EventHandler(this.cboShoolYear_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(243, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Năm học (*)";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(243, 69);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Học kì (*)";
            // 
            // btnTeacher
            // 
            this.btnTeacher.Image = global::ManagementSASI.Properties.Resources.Button_Add_icon;
            this.btnTeacher.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTeacher.Location = new System.Drawing.Point(700, 42);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(12, 12);
            this.btnTeacher.TabIndex = 15;
            this.btnTeacher.Text = "...";
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(336, 92);
            this.btnDelete.LookAndFeel.SkinName = "Blue";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(650, 65);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(84, 21);
            this.dtpEndDate.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(257, 92);
            this.btnUpdate.LookAndFeel.SkinName = "Blue";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Phân lớp";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpStarDate
            // 
            this.dtpStarDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStarDate.Location = new System.Drawing.Point(469, 65);
            this.dtpStarDate.Name = "dtpStarDate";
            this.dtpStarDate.Size = new System.Drawing.Size(85, 21);
            this.dtpStarDate.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(181, 92);
            this.btnInsert.LookAndFeel.SkinName = "Blue";
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kết thúc học (*)";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(100, 92);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bắt đầu học (*)";
            // 
            // lueTeacher
            // 
            this.lueTeacher.Location = new System.Drawing.Point(469, 38);
            this.lueTeacher.Name = "lueTeacher";
            this.lueTeacher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTeacher.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TeacherCode", "Mã GV", 10),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TeacherName", "Tên GV", 30)});
            this.lueTeacher.Properties.DisplayMember = "TeacherName";
            this.lueTeacher.Properties.LookAndFeel.SkinName = "Blue";
            this.lueTeacher.Properties.NullText = "";
            this.lueTeacher.Properties.PopupWidth = 200;
            this.lueTeacher.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueTeacher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTeacher.Properties.ValueMember = "TeacherCode";
            this.lueTeacher.Size = new System.Drawing.Size(265, 20);
            this.lueTeacher.TabIndex = 4;
            this.lueTeacher.TextChanged += new System.EventHandler(this.lueTeacher_TextChanged);
            // 
            // mmoDescription
            // 
            this.mmoDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mmoDescription.Location = new System.Drawing.Point(781, 38);
            this.mmoDescription.Name = "mmoDescription";
            this.mmoDescription.Properties.LookAndFeel.SkinName = "Blue";
            this.mmoDescription.Size = new System.Drawing.Size(143, 47);
            this.mmoDescription.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(740, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Ghi chú";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(387, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Giáo viên dạy ";
            // 
            // tedSASIClassName
            // 
            this.tedSASIClassName.Location = new System.Drawing.Point(100, 38);
            this.tedSASIClassName.Name = "tedSASIClassName";
            this.tedSASIClassName.Properties.LookAndFeel.SkinName = "Blue";
            this.tedSASIClassName.Size = new System.Drawing.Size(137, 20);
            this.tedSASIClassName.TabIndex = 1;
            this.tedSASIClassName.TextChanged += new System.EventHandler(this.tedSASIClassName_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Tên lớp học lại (*)";
            // 
            // gctSASIClass
            // 
            this.gctSASIClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctSASIClass.Location = new System.Drawing.Point(0, 125);
            this.gctSASIClass.MainView = this.gvSASIClass;
            this.gctSASIClass.Name = "gctSASIClass";
            this.gctSASIClass.Size = new System.Drawing.Size(929, 512);
            this.gctSASIClass.TabIndex = 1;
            this.gctSASIClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSASIClass});
            this.gctSASIClass.Click += new System.EventHandler(this.gctSASIClass_Click);
            // 
            // gvSASIClass
            // 
            this.gvSASIClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn9,
            this.gridColumn5,
            this.gridColumn10,
            this.gridColumn1});
            this.gvSASIClass.GridControl = this.gctSASIClass;
            this.gvSASIClass.GroupPanelText = "Cột gom nhóm";
            this.gvSASIClass.Name = "gvSASIClass";
            this.gvSASIClass.OptionsSelection.MultiSelect = true;
            this.gvSASIClass.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvSASIClass.OptionsView.ShowAutoFilterRow = true;
            this.gvSASIClass.OptionsView.ShowDetailButtons = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Tên thông tin";
            this.gridColumn11.FieldName = "InfoName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.ToolTip = "Tên thông tin đào tạo";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp";
            this.gridColumn2.FieldName = "SASIClassName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 119;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên giáo viên";
            this.gridColumn3.FieldName = "TeacherName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 125;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Năm học";
            this.gridColumn7.FieldName = "ShoolYear";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 70;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Học kì ";
            this.gridColumn8.FieldName = "Semester";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 49;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày bắt đầu học ";
            this.gridColumn4.FieldName = "StartDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 81;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày kết thúc học";
            this.gridColumn6.FieldName = "EndDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 76;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Trạng thái";
            this.gridColumn9.FieldName = "Status";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            this.gridColumn9.Width = 80;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ghi chú";
            this.gridColumn5.FieldName = "Description";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 9;
            this.gridColumn5.Width = 73;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ngày mở lớp HL,CT";
            this.gridColumn10.FieldName = "DateSASIClass";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            this.gridColumn10.Width = 120;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ML";
            this.gridColumn1.FieldName = "SASIClassID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // frmSASIClass
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(929, 637);
            this.Controls.Add(this.gctSASIClass);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSASIClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỚP HỌC LẠI";
            this.Load += new System.EventHandler(this.frmSASIClass_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSASIClass_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueInfor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedSASIClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSASIClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSASIClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tedSASIClassName;
        private DevExpress.XtraEditors.MemoEdit mmoDescription;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStarDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lueTeacher;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gctSASIClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSASIClass;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnTeacher;
        private DevExpress.XtraEditors.ComboBoxEdit cboSemester;
        private DevExpress.XtraEditors.ComboBoxEdit cboShoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.SimpleButton btnInfor;
        private DevExpress.XtraEditors.LookUpEdit lueInfor;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}