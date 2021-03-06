namespace ManagementSASI
{
    partial class frmSASIClassEnd
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
            this.grvSASIClassEnd = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvSASIClassEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvSASIClassEnd
            // 
            this.grvSASIClassEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvSASIClassEnd.Location = new System.Drawing.Point(0, 0);
            this.grvSASIClassEnd.MainView = this.gridView1;
            this.grvSASIClassEnd.Name = "grvSASIClassEnd";
            this.grvSASIClassEnd.Size = new System.Drawing.Size(809, 466);
            this.grvSASIClassEnd.TabIndex = 0;
            this.grvSASIClassEnd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.grvSASIClassEnd;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên lớp HL+CT";
            this.gridColumn1.FieldName = "SASIClassName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên giáo viên";
            this.gridColumn2.FieldName = "TeacherName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Học kì";
            this.gridColumn3.FieldName = "Semester";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Năm học";
            this.gridColumn4.FieldName = "ShoolYear";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày bắt đầu";
            this.gridColumn7.FieldName = "StartDate";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày kết thúc";
            this.gridColumn5.FieldName = "EndDate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày đăng kí lớp";
            this.gridColumn6.FieldName = "DateSASIClass";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // frmSASIClassEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(809, 466);
            this.Controls.Add(this.grvSASIClassEnd);
            this.MaximizeBox = false;
            this.Name = "frmSASIClassEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỚP HỌC LẠI CẢI THIỆN ĐÃ KẾT THÚC";
            this.Load += new System.EventHandler(this.frmSASIClassEnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvSASIClassEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grvSASIClassEnd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}