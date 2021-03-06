namespace ManagementSASI
{
    partial class frmStatisticsStudents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbQuater = new System.Windows.Forms.RadioButton();
            this.rdbSchollYear = new System.Windows.Forms.RadioButton();
            this.cboSemester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboShoolYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboQuarter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbQuater);
            this.panel1.Controls.Add(this.rdbSchollYear);
            this.panel1.Controls.Add(this.cboSemester);
            this.panel1.Controls.Add(this.cboShoolYear);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.cboQuarter);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 51);
            this.panel1.TabIndex = 0;
            // 
            // rdbQuater
            // 
            this.rdbQuater.AutoSize = true;
            this.rdbQuater.Location = new System.Drawing.Point(76, 20);
            this.rdbQuater.Name = "rdbQuater";
            this.rdbQuater.Size = new System.Drawing.Size(70, 17);
            this.rdbQuater.TabIndex = 47;
            this.rdbQuater.Text = "Theo quý";
            this.rdbQuater.UseVisualStyleBackColor = true;
            // 
            // rdbSchollYear
            // 
            this.rdbSchollYear.AutoSize = true;
            this.rdbSchollYear.Checked = true;
            this.rdbSchollYear.Location = new System.Drawing.Point(12, 20);
            this.rdbSchollYear.Name = "rdbSchollYear";
            this.rdbSchollYear.Size = new System.Drawing.Size(59, 17);
            this.rdbSchollYear.TabIndex = 46;
            this.rdbSchollYear.TabStop = true;
            this.rdbSchollYear.Text = "Theo kì";
            this.rdbSchollYear.UseVisualStyleBackColor = true;
            // 
            // cboSemester
            // 
            this.cboSemester.Location = new System.Drawing.Point(336, 18);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSemester.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSemester.Size = new System.Drawing.Size(44, 20);
            this.cboSemester.TabIndex = 43;
            // 
            // cboShoolYear
            // 
            this.cboShoolYear.Location = new System.Drawing.Point(201, 18);
            this.cboShoolYear.Name = "cboShoolYear";
            this.cboShoolYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboShoolYear.Size = new System.Drawing.Size(92, 20);
            this.cboShoolYear.TabIndex = 42;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(154, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Năm học";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(299, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Học kì ";
            // 
            // cboQuarter
            // 
            this.cboQuarter.Enabled = false;
            this.cboQuarter.Location = new System.Drawing.Point(424, 18);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuarter.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboQuarter.Size = new System.Drawing.Size(44, 20);
            this.cboQuarter.TabIndex = 40;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(395, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Quý ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(478, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 23);
            this.btnPrint.TabIndex = 39;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 51);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1014, 490);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frmStatisticsStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 541);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmStatisticsStudents";
            this.Text = "frmStatisticsStudents";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton rdbQuater;
        private System.Windows.Forms.RadioButton rdbSchollYear;
        private DevExpress.XtraEditors.ComboBoxEdit cboSemester;
        private DevExpress.XtraEditors.ComboBoxEdit cboShoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboQuarter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}