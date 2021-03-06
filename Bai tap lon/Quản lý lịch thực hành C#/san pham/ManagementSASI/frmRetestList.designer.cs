namespace ManagementSASI
{
    partial class frmRetestList
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.cboSemester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboSchoolYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.crvRetestList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSchoolYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnOK);
            this.groupControl1.Controls.Add(this.cboSemester);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cboSchoolYear);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(879, 73);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin thống kê";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(382, 33);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 22);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Thống kê";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboSemester
            // 
            this.cboSemester.EditValue = "3";
            this.cboSemester.Location = new System.Drawing.Point(259, 35);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSemester.Size = new System.Drawing.Size(106, 20);
            this.cboSemester.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(221, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Học kì:";
            // 
            // cboSchoolYear
            // 
            this.cboSchoolYear.Location = new System.Drawing.Point(109, 35);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSchoolYear.Size = new System.Drawing.Size(106, 20);
            this.cboSchoolYear.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Năm học:";
            // 
            // crvRetestList
            // 
            this.crvRetestList.ActiveViewIndex = -1;
            this.crvRetestList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRetestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRetestList.Location = new System.Drawing.Point(0, 73);
            this.crvRetestList.Name = "crvRetestList";
            this.crvRetestList.SelectionFormula = "";
            this.crvRetestList.Size = new System.Drawing.Size(879, 413);
            this.crvRetestList.TabIndex = 1;
            this.crvRetestList.ViewTimeSelectionFormula = "";
            // 
            // frmRetestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(879, 486);
            this.Controls.Add(this.crvRetestList);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmRetestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH NỘP TIỀN THI L2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRetestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSchoolYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboSchoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRetestList;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.ComboBoxEdit cboSemester;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}