namespace ManagementSASI
{
    partial class frmListStudentMoneySI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListStudentMoneySI));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
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
            this.dataSet11 = new ManagementSASI.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdbQuater);
            this.groupControl1.Controls.Add(this.rdbSchollYear);
            this.groupControl1.Controls.Add(this.cboSemester);
            this.groupControl1.Controls.Add(this.cboShoolYear);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cboQuarter);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(972, 67);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin tổng hợp sinh viên học cải thiện";
            // 
            // rdbQuater
            // 
            this.rdbQuater.AutoSize = true;
            this.rdbQuater.Location = new System.Drawing.Point(73, 36);
            this.rdbQuater.Name = "rdbQuater";
            this.rdbQuater.Size = new System.Drawing.Size(70, 17);
            this.rdbQuater.TabIndex = 38;
            this.rdbQuater.Text = "Theo quý";
            this.rdbQuater.UseVisualStyleBackColor = true;
            this.rdbQuater.Click += new System.EventHandler(this.rdbQuater_Click);
            // 
            // rdbSchollYear
            // 
            this.rdbSchollYear.AutoSize = true;
            this.rdbSchollYear.Checked = true;
            this.rdbSchollYear.Location = new System.Drawing.Point(9, 36);
            this.rdbSchollYear.Name = "rdbSchollYear";
            this.rdbSchollYear.Size = new System.Drawing.Size(59, 17);
            this.rdbSchollYear.TabIndex = 37;
            this.rdbSchollYear.TabStop = true;
            this.rdbSchollYear.Text = "Theo kì";
            this.rdbSchollYear.UseVisualStyleBackColor = true;
            this.rdbSchollYear.Click += new System.EventHandler(this.rdbSchollYear_Click);
            // 
            // cboSemester
            // 
            this.cboSemester.Location = new System.Drawing.Point(333, 35);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSemester.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSemester.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSemester.Size = new System.Drawing.Size(44, 20);
            this.cboSemester.TabIndex = 34;
            // 
            // cboShoolYear
            // 
            this.cboShoolYear.Location = new System.Drawing.Point(198, 35);
            this.cboShoolYear.Name = "cboShoolYear";
            this.cboShoolYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboShoolYear.Size = new System.Drawing.Size(92, 20);
            this.cboShoolYear.TabIndex = 33;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(151, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "Năm học";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(296, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Học kì ";
            // 
            // cboQuarter
            // 
            this.cboQuarter.Location = new System.Drawing.Point(421, 35);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuarter.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboQuarter.Size = new System.Drawing.Size(44, 20);
            this.cboQuarter.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(392, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Quý ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(475, 34);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 67);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(972, 450);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmListStudentMoneySI
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(972, 517);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blue";
            this.MaximizeBox = false;
            this.Name = "frmListStudentMoneySI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH NỘP TIỀN HỌC CẢI THIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListStudentMoneySI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboShoolYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuarter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DataSet1 dataSet11;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DevExpress.XtraEditors.ComboBoxEdit cboQuarter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboSemester;
        private DevExpress.XtraEditors.ComboBoxEdit cboShoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RadioButton rdbQuater;
        private System.Windows.Forms.RadioButton rdbSchollYear;
    }
}