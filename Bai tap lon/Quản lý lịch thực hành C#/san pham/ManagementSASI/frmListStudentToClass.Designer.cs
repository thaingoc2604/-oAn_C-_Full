namespace ManagementSASI
{
    partial class frmListStudentToClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListStudentToClass));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboQuarter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rdbQuater = new System.Windows.Forms.RadioButton();
            this.rdbYear = new System.Windows.Forms.RadioButton();
            this.cboSemester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboShoolYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboQuarter);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.rdbQuater);
            this.panelControl1.Controls.Add(this.rdbYear);
            this.panelControl1.Controls.Add(this.cboSemester);
            this.panelControl1.Controls.Add(this.cboShoolYear);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1020, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // cboQuarter
            // 
            this.cboQuarter.Location = new System.Drawing.Point(461, 13);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuarter.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboQuarter.Size = new System.Drawing.Size(44, 20);
            this.cboQuarter.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(432, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Quý ";
            // 
            // rdbQuater
            // 
            this.rdbQuater.AutoSize = true;
            this.rdbQuater.Location = new System.Drawing.Point(76, 16);
            this.rdbQuater.Name = "rdbQuater";
            this.rdbQuater.Size = new System.Drawing.Size(70, 17);
            this.rdbQuater.TabIndex = 30;
            this.rdbQuater.Text = "Theo quý";
            this.rdbQuater.UseVisualStyleBackColor = true;
            this.rdbQuater.Click += new System.EventHandler(this.rdbQuater_Click);
            // 
            // rdbYear
            // 
            this.rdbYear.AutoSize = true;
            this.rdbYear.Checked = true;
            this.rdbYear.Location = new System.Drawing.Point(12, 16);
            this.rdbYear.Name = "rdbYear";
            this.rdbYear.Size = new System.Drawing.Size(59, 17);
            this.rdbYear.TabIndex = 29;
            this.rdbYear.TabStop = true;
            this.rdbYear.Text = "Theo kì";
            this.rdbYear.UseVisualStyleBackColor = true;
            this.rdbYear.Click += new System.EventHandler(this.rdbYear_Click);
            // 
            // cboSemester
            // 
            this.cboSemester.EditValue = "3";
            this.cboSemester.Location = new System.Drawing.Point(351, 14);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSemester.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSemester.Size = new System.Drawing.Size(73, 20);
            this.cboSemester.TabIndex = 1;
            // 
            // cboShoolYear
            // 
            this.cboShoolYear.Location = new System.Drawing.Point(221, 14);
            this.cboShoolYear.Name = "cboShoolYear";
            this.cboShoolYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboShoolYear.Size = new System.Drawing.Size(73, 20);
            this.cboShoolYear.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(156, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Năm học (*)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(300, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Học kì (*)";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(511, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.crystalReportViewer1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1020, 493);
            this.panelControl2.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1016, 489);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frmListStudentToClass
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1020, 540);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListStudentToClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỔNG HỢP THANH TOÁN TIỀN CỦA SINH VIÊN THEO LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListStudentToClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboSemester;
        private DevExpress.XtraEditors.ComboBoxEdit cboShoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton rdbQuater;
        private System.Windows.Forms.RadioButton rdbYear;
        private DevExpress.XtraEditors.ComboBoxEdit cboQuarter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}