namespace ManagementSASI
{
    partial class frmSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubject));
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.mmoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtSubjectName = new DevExpress.XtraEditors.TextEdit();
            this.txtSubjectCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gctSubject = new DevExpress.XtraGrid.GridControl();
            this.gvSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(146, 104);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(69, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(69, 104);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Làm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.mmoDescription);
            this.groupControl1.Controls.Add(this.txtSubjectName);
            this.groupControl1.Controls.Add(this.txtSubjectCode);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 87);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin về hệ đào tạo ( phím tắt F3: thêm, F4: sửa, F5: xóa, F6: tạo mới )";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(256, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ghi chú :";
            // 
            // mmoDescription
            // 
            this.mmoDescription.Location = new System.Drawing.Point(301, 33);
            this.mmoDescription.Name = "mmoDescription";
            this.mmoDescription.Size = new System.Drawing.Size(195, 45);
            this.mmoDescription.TabIndex = 5;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(62, 59);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(186, 20);
            this.txtSubjectName.TabIndex = 1;
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(61, 33);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(187, 20);
            this.txtSubjectCode.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên môn :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã môn :";
            // 
            // gctSubject
            // 
            this.gctSubject.Location = new System.Drawing.Point(8, 136);
            this.gctSubject.MainView = this.gvSubject;
            this.gctSubject.Name = "gctSubject";
            this.gctSubject.Size = new System.Drawing.Size(504, 232);
            this.gctSubject.TabIndex = 6;
            this.gctSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSubject});
            // 
            // gvSubject
            // 
            this.gvSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4});
            this.gvSubject.GridControl = this.gctSubject;
            this.gvSubject.GroupPanelText = "Cột gom nhóm";
            this.gvSubject.Name = "gvSubject";
            this.gvSubject.OptionsSelection.MultiSelect = true;
            this.gvSubject.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvSubject.OptionsView.ShowAutoFilterRow = true;
            this.gvSubject.OptionsView.ShowDetailButtons = false;
            this.gvSubject.Click += new System.EventHandler(this.gvSubject_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã môn";
            this.gridColumn1.FieldName = "SubjectCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên môn";
            this.gridColumn2.FieldName = "SubjectName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 191;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ghi chú";
            this.gridColumn4.FieldName = "Description";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 310;
            // 
            // frmSubject
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 378);
            this.Controls.Add(this.gctSubject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Blue";
            this.MaximizeBox = false;
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÔN HỌC";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSubject_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSubject_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSubjectName;
        private DevExpress.XtraEditors.TextEdit txtSubjectCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gctSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit mmoDescription;

    }
}