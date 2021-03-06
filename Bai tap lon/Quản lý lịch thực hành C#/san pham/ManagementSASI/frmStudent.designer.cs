namespace ManagementSASI
{
    partial class frmStudent
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
            this.btnClear = new DevExpress.XtraEditors.GroupControl();
            this.btnAddExcel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentCode = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.grcStudent = new DevExpress.XtraGrid.GridControl();
            this.grvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            this.btnClear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Controls.Add(this.btnAddExcel);
            this.btnClear.Controls.Add(this.labelControl3);
            this.btnClear.Controls.Add(this.labelControl2);
            this.btnClear.Controls.Add(this.labelControl1);
            this.btnClear.Controls.Add(this.dtpBirthDay);
            this.btnClear.Controls.Add(this.txtStudentName);
            this.btnClear.Controls.Add(this.txtStudentCode);
            this.btnClear.Controls.Add(this.btnEdit);
            this.btnClear.Controls.Add(this.btnAdd);
            this.btnClear.Controls.Add(this.simpleButton2);
            this.btnClear.Controls.Add(this.btnDelete);
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(508, 96);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Thông tin sinh viên";
            // 
            // btnAddExcel
            // 
            this.btnAddExcel.Location = new System.Drawing.Point(153, 63);
            this.btnAddExcel.Name = "btnAddExcel";
            this.btnAddExcel.Size = new System.Drawing.Size(75, 23);
            this.btnAddExcel.TabIndex = 4;
            this.btnAddExcel.Text = "Nhập Excel";
            this.btnAddExcel.Click += new System.EventHandler(this.btnAddExcel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(357, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Ngày sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(152, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên sinh viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã sinh viên";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(414, 33);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(83, 21);
            this.dtpBirthDay.TabIndex = 2;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(223, 33);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(128, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(72, 33);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(74, 20);
            this.txtStudentCode.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(316, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(71, 63);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Mới";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grcStudent
            // 
            this.grcStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcStudent.Location = new System.Drawing.Point(0, 96);
            this.grcStudent.MainView = this.grvStudent;
            this.grcStudent.Name = "grcStudent";
            this.grcStudent.Size = new System.Drawing.Size(508, 238);
            this.grcStudent.TabIndex = 1;
            this.grcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvStudent});
            this.grcStudent.Click += new System.EventHandler(this.grcStudent_Click);
            // 
            // grvStudent
            // 
            this.grvStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grvStudent.GridControl = this.grcStudent;
            this.grvStudent.Name = "grvStudent";
            this.grvStudent.OptionsSelection.MultiSelect = true;
            this.grvStudent.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã sinh viên";
            this.gridColumn1.FieldName = "Mã_sinh_viên";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sinh viên";
            this.gridColumn2.FieldName = "Tên_sinh_viên";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày sinh";
            this.gridColumn3.FieldName = "Ngày_sinh";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 334);
            this.Controls.Add(this.grcStudent);
            this.Controls.Add(this.btnClear);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SINH VIÊN";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            this.btnClear.ResumeLayout(false);
            this.btnClear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl btnClear;
        private DevExpress.XtraGrid.GridControl grcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView grvStudent;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private DevExpress.XtraEditors.TextEdit txtStudentName;
        private DevExpress.XtraEditors.TextEdit txtStudentCode;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAddExcel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}