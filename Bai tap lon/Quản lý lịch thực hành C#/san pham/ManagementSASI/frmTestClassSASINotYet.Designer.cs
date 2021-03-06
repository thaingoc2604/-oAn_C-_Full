namespace ManagementSASI
{
    partial class frmTestClassSASINotYet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestClassSASINotYet));
            this.gctSASIClass = new DevExpress.XtraGrid.GridControl();
            this.gvSASIClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.txtSASIClassName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gctSASIClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSASIClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSASIClassName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gctSASIClass
            // 
            this.gctSASIClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gctSASIClass.Location = new System.Drawing.Point(0, 38);
            this.gctSASIClass.MainView = this.gvSASIClass;
            this.gctSASIClass.Name = "gctSASIClass";
            this.gctSASIClass.Size = new System.Drawing.Size(646, 422);
            this.gctSASIClass.TabIndex = 10;
            this.gctSASIClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSASIClass});
            this.gctSASIClass.Click += new System.EventHandler(this.gctSASIClass_Click);
            // 
            // gvSASIClass
            // 
            this.gvSASIClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn1});
            this.gvSASIClass.GridControl = this.gctSASIClass;
            this.gvSASIClass.GroupPanelText = "Cột gom nhóm";
            this.gvSASIClass.Name = "gvSASIClass";
            this.gvSASIClass.OptionsSelection.MultiSelect = true;
            this.gvSASIClass.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvSASIClass.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSASIClass_FocusedRowChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp";
            this.gridColumn2.FieldName = "SASIClassName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 170;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tổng tiền";
            this.gridColumn4.FieldName = "Total";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số sinh viên";
            this.gridColumn1.FieldName = "NumberStudent";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 9);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Xem";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtSASIClassName
            // 
            this.txtSASIClassName.Enabled = false;
            this.txtSASIClassName.Location = new System.Drawing.Point(186, 10);
            this.txtSASIClassName.Name = "txtSASIClassName";
            this.txtSASIClassName.Properties.LookAndFeel.SkinName = "Blue";
            this.txtSASIClassName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtSASIClassName.Size = new System.Drawing.Size(175, 20);
            this.txtSASIClassName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(93, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên lớp học lại (*)";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmTestClassSASINotYet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(646, 460);
            this.Controls.Add(this.txtSASIClassName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gctSASIClass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTestClassSASINotYet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ LỚP CHƯA ĐỦ SINH VIÊN";
            this.Load += new System.EventHandler(this.TestClassSASINotYet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctSASIClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSASIClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSASIClassName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctSASIClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSASIClass;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private DevExpress.XtraEditors.TextEdit txtSASIClassName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}