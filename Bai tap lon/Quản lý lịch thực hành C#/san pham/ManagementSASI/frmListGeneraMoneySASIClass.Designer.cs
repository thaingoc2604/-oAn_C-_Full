namespace ManagementSASI
{
    partial class frmListGeneraMoneySASIClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListGeneraMoneySASIClass));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdbQuater = new System.Windows.Forms.RadioButton();
            this.rdbSchollYear = new System.Windows.Forms.RadioButton();
            this.cboQuarter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboSemester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboShoolYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdbQuater);
            this.groupControl1.Controls.Add(this.rdbSchollYear);
            this.groupControl1.Controls.Add(this.cboQuarter);
            this.groupControl1.Controls.Add(this.cboSemester);
            this.groupControl1.Controls.Add(this.cboShoolYear);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1020, 59);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin tổng hợp sinh viên học lại học cải thiện theo lớp";
            // 
            // rdbQuater
            // 
            this.rdbQuater.AutoSize = true;
            this.rdbQuater.Location = new System.Drawing.Point(76, 32);
            this.rdbQuater.Name = "rdbQuater";
            this.rdbQuater.Size = new System.Drawing.Size(70, 17);
            this.rdbQuater.TabIndex = 28;
            this.rdbQuater.Text = "Theo quý";
            this.rdbQuater.UseVisualStyleBackColor = true;
            this.rdbQuater.Click += new System.EventHandler(this.rdbQuater_Click);
            this.rdbQuater.CheckedChanged += new System.EventHandler(this.rdbQuater_CheckedChanged);
            // 
            // rdbSchollYear
            // 
            this.rdbSchollYear.AutoSize = true;
            this.rdbSchollYear.Checked = true;
            this.rdbSchollYear.Location = new System.Drawing.Point(12, 32);
            this.rdbSchollYear.Name = "rdbSchollYear";
            this.rdbSchollYear.Size = new System.Drawing.Size(59, 17);
            this.rdbSchollYear.TabIndex = 27;
            this.rdbSchollYear.TabStop = true;
            this.rdbSchollYear.Text = "Theo kì";
            this.rdbSchollYear.UseVisualStyleBackColor = true;
            this.rdbSchollYear.Click += new System.EventHandler(this.rdbSchollYear_Click);
            this.rdbSchollYear.CheckedChanged += new System.EventHandler(this.rdbSchollYear_CheckedChanged);
            // 
            // cboQuarter
            // 
            this.cboQuarter.Enabled = false;
            this.cboQuarter.Location = new System.Drawing.Point(413, 30);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuarter.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboQuarter.Size = new System.Drawing.Size(44, 20);
            this.cboQuarter.TabIndex = 1;
            // 
            // cboSemester
            // 
            this.cboSemester.Location = new System.Drawing.Point(334, 30);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSemester.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSemester.Size = new System.Drawing.Size(44, 20);
            this.cboSemester.TabIndex = 1;
            // 
            // cboShoolYear
            // 
            this.cboShoolYear.Location = new System.Drawing.Point(199, 30);
            this.cboShoolYear.Name = "cboShoolYear";
            this.cboShoolYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboShoolYear.Size = new System.Drawing.Size(92, 20);
            this.cboShoolYear.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(152, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Năm học";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(384, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Quý ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(297, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Học kì ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(463, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(55, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 59);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1020, 451);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frmListGeneraMoneySASIClass
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1020, 510);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListGeneraMoneySASIClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BẢNG TỔNG HỢP SINH VIÊN HỌC LẠI HỌC CẢI THIỆN THEO LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListGeneraMoneySASIClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cboSemester;
        private DevExpress.XtraEditors.ComboBoxEdit cboShoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton rdbQuater;
        private System.Windows.Forms.RadioButton rdbSchollYear;
        private DevExpress.XtraEditors.ComboBoxEdit cboQuarter;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}