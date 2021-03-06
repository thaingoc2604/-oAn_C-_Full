namespace ManagementSASI
{
    partial class frmSettingMoney
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
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cboNumberStudy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueInfo = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTheoryMoney = new DevExpress.XtraEditors.TextEdit();
            this.txtMoneyRatesName = new DevExpress.XtraEditors.TextEdit();
            this.txtPracticeMoney = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grcSettingMoney = new DevExpress.XtraGrid.GridControl();
            this.grvSettingMoney = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNumberStudy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheoryMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneyRatesName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPracticeMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcSettingMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSettingMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(96, 96);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Làm mới";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(177, 96);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(341, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.cboNumberStudy);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.lueInfo);
            this.groupControl3.Controls.Add(this.txtTheoryMoney);
            this.groupControl3.Controls.Add(this.txtMoneyRatesName);
            this.groupControl3.Controls.Add(this.txtPracticeMoney);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(512, 90);
            this.groupControl3.TabIndex = 15;
            this.groupControl3.Text = "Thông tin bắt buộc";
            // 
            // cboNumberStudy
            // 
            this.cboNumberStudy.Location = new System.Drawing.Point(263, 60);
            this.cboNumberStudy.Name = "cboNumberStudy";
            this.cboNumberStudy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNumberStudy.Size = new System.Drawing.Size(42, 20);
            this.cboNumberStudy.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(189, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Số lần học (*)";
            // 
            // lueInfo
            // 
            this.lueInfo.Location = new System.Drawing.Point(95, 31);
            this.lueInfo.Name = "lueInfo";
            this.lueInfo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInfo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InfoName", "Thông tin", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainType", "Loại đào tạo", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainingType", "Loại hình đào tạo", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LearningType", "Loại học", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lueInfo.Properties.NullText = "";
            this.lueInfo.Properties.PopupWidth = 350;
            this.lueInfo.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueInfo.Size = new System.Drawing.Size(211, 20);
            this.lueInfo.TabIndex = 4;
            this.lueInfo.TextChanged += new System.EventHandler(this.lueInfo_TextChanged);
            // 
            // txtTheoryMoney
            // 
            this.txtTheoryMoney.Location = new System.Drawing.Point(410, 59);
            this.txtTheoryMoney.Name = "txtTheoryMoney";
            this.txtTheoryMoney.Size = new System.Drawing.Size(94, 20);
            this.txtTheoryMoney.TabIndex = 1;
            // 
            // txtMoneyRatesName
            // 
            this.txtMoneyRatesName.Location = new System.Drawing.Point(95, 60);
            this.txtMoneyRatesName.Name = "txtMoneyRatesName";
            this.txtMoneyRatesName.Size = new System.Drawing.Size(88, 20);
            this.txtMoneyRatesName.TabIndex = 0;
            // 
            // txtPracticeMoney
            // 
            this.txtPracticeMoney.Location = new System.Drawing.Point(410, 31);
            this.txtPracticeMoney.Name = "txtPracticeMoney";
            this.txtPracticeMoney.Size = new System.Drawing.Size(94, 20);
            this.txtPracticeMoney.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(312, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tiền lý thuyết (*)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Thông tin (*)";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 63);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Phân hệ tiền (*)";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(312, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tiền thực hành (*)";
            // 
            // grcSettingMoney
            // 
            this.grcSettingMoney.Location = new System.Drawing.Point(0, 125);
            this.grcSettingMoney.MainView = this.grvSettingMoney;
            this.grcSettingMoney.Name = "grcSettingMoney";
            this.grcSettingMoney.Size = new System.Drawing.Size(506, 200);
            this.grcSettingMoney.TabIndex = 16;
            this.grcSettingMoney.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSettingMoney});
            this.grcSettingMoney.Click += new System.EventHandler(this.grcSettingMoney_Click);
            // 
            // grvSettingMoney
            // 
            this.grvSettingMoney.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grvSettingMoney.GridControl = this.grcSettingMoney;
            this.grvSettingMoney.Name = "grvSettingMoney";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên loại tiền";
            this.gridColumn1.FieldName = "MoneyRatesName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thông tin";
            this.gridColumn2.FieldName = "InfoName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lần học";
            this.gridColumn3.FieldName = "NumberStudy";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tiền lý thuyết";
            this.gridColumn4.FieldName = "TheoryMoney";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tiền thực hành";
            this.gridColumn5.FieldName = "PracticeMoney";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // frmSettingMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 326);
            this.Controls.Add(this.grcSettingMoney);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmSettingMoney";
            this.Text = "CẤU HÌNH TIỀN";
            this.Load += new System.EventHandler(this.frmSettingMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNumberStudy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheoryMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneyRatesName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPracticeMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcSettingMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSettingMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtTheoryMoney;
        private DevExpress.XtraEditors.TextEdit txtPracticeMoney;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lueInfo;
        private DevExpress.XtraGrid.GridControl grcSettingMoney;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSettingMoney;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit txtMoneyRatesName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboNumberStudy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}