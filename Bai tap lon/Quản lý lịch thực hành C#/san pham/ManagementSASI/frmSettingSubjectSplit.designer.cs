namespace ManagementSASI
{
    partial class frmSettingSubjectSplit
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tedSecsionNC = new DevExpress.XtraEditors.TextEdit();
            this.tedTheoryNC = new DevExpress.XtraEditors.TextEdit();
            this.tedSecsionTC = new DevExpress.XtraEditors.TextEdit();
            this.tedTheoryTC = new DevExpress.XtraEditors.TextEdit();
            this.lblTraining2 = new DevExpress.XtraEditors.LabelControl();
            this.lblName2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTraning1 = new DevExpress.XtraEditors.LabelControl();
            this.lblName1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedSecsionNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTheoryNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedSecsionTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTheoryTC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Số tiết:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Số giờ:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tedSecsionNC);
            this.groupControl1.Controls.Add(this.tedTheoryNC);
            this.groupControl1.Controls.Add(this.tedSecsionTC);
            this.groupControl1.Controls.Add(this.tedTheoryTC);
            this.groupControl1.Controls.Add(this.lblTraining2);
            this.groupControl1.Controls.Add(this.lblName2);
            this.groupControl1.Controls.Add(this.lblTraning1);
            this.groupControl1.Controls.Add(this.lblName1);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(465, 104);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin ( phím tắt F2: chọn check, F3 : hủy check, f4: lưu )";
            // 
            // tedSecsionNC
            // 
            this.tedSecsionNC.EditValue = "15";
            this.tedSecsionNC.Location = new System.Drawing.Point(262, 72);
            this.tedSecsionNC.Name = "tedSecsionNC";
            this.tedSecsionNC.Properties.MaxLength = 2;
            this.tedSecsionNC.Size = new System.Drawing.Size(54, 20);
            this.tedSecsionNC.TabIndex = 3;
            // 
            // tedTheoryNC
            // 
            this.tedTheoryNC.EditValue = "5";
            this.tedTheoryNC.Location = new System.Drawing.Point(262, 44);
            this.tedTheoryNC.Name = "tedTheoryNC";
            this.tedTheoryNC.Properties.MaxLength = 2;
            this.tedTheoryNC.Size = new System.Drawing.Size(54, 20);
            this.tedTheoryNC.TabIndex = 2;
            // 
            // tedSecsionTC
            // 
            this.tedSecsionTC.EditValue = "20";
            this.tedSecsionTC.Location = new System.Drawing.Point(52, 72);
            this.tedSecsionTC.Name = "tedSecsionTC";
            this.tedSecsionTC.Properties.MaxLength = 2;
            this.tedSecsionTC.Size = new System.Drawing.Size(54, 20);
            this.tedSecsionTC.TabIndex = 1;
            this.tedSecsionTC.EditValueChanged += new System.EventHandler(this.tedHoursTC_EditValueChanged);
            // 
            // tedTheoryTC
            // 
            this.tedTheoryTC.EditValue = "8";
            this.tedTheoryTC.Location = new System.Drawing.Point(52, 44);
            this.tedTheoryTC.Name = "tedTheoryTC";
            this.tedTheoryTC.Properties.MaxLength = 2;
            this.tedTheoryTC.Size = new System.Drawing.Size(54, 20);
            this.tedTheoryTC.TabIndex = 0;
            // 
            // lblTraining2
            // 
            this.lblTraining2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraining2.Appearance.Options.UseFont = true;
            this.lblTraining2.Location = new System.Drawing.Point(311, 23);
            this.lblTraining2.Name = "lblTraining2";
            this.lblTraining2.Size = new System.Drawing.Size(51, 14);
            this.lblTraining2.TabIndex = 7;
            this.lblTraining2.Text = "Niên chế";
            // 
            // lblName2
            // 
            this.lblName2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Appearance.Options.UseFont = true;
            this.lblName2.Location = new System.Drawing.Point(262, 23);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(38, 14);
            this.lblName2.TabIndex = 6;
            this.lblName2.Text = "Mức 2";
            // 
            // lblTraning1
            // 
            this.lblTraning1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraning1.Appearance.Options.UseFont = true;
            this.lblTraning1.Location = new System.Drawing.Point(100, 23);
            this.lblTraning1.Name = "lblTraning1";
            this.lblTraning1.Size = new System.Drawing.Size(39, 14);
            this.lblTraning1.TabIndex = 5;
            this.lblTraning1.Text = "Tín chỉ";
            // 
            // lblName1
            // 
            this.lblName1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Appearance.Options.UseFont = true;
            this.lblName1.Location = new System.Drawing.Point(51, 23);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(38, 14);
            this.lblName1.TabIndex = 4;
            this.lblName1.Text = "Mức 1";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(322, 76);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(133, 13);
            this.labelControl11.TabIndex = 9;
            this.labelControl11.Text = "/ đơn vị học trình thực hành";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(109, 76);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(87, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "/ tín chỉ thực hành";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(322, 48);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(124, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "/đơn vị học trình lý thuyết";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(109, 48);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(81, 13);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "/ tín chỉ lý thuyết";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(216, 48);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 13);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Số tiết:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(216, 76);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Số giờ:";
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Location = new System.Drawing.Point(286, 115);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(90, 17);
            this.rbEdit.TabIndex = 1;
            this.rbEdit.Text = "Sửa thông tin";
            this.rbEdit.UseVisualStyleBackColor = true;
            this.rbEdit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(382, 112);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmSettingSubjectSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(465, 142);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.rbEdit);
            this.MaximizeBox = false;
            this.Name = "frmSettingSubjectSplit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MỨC CHIA SỐ TIẾT VÀ SỐ GIỜ CHO LOẠI HÌNH ĐÀO TẠO";
            this.Load += new System.EventHandler(this.frmSettingSubjectSplit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSettingSubjectSplit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedSecsionNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTheoryNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedSecsionTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTheoryTC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tedSecsionNC;
        private DevExpress.XtraEditors.TextEdit tedTheoryNC;
        private DevExpress.XtraEditors.TextEdit tedSecsionTC;
        private DevExpress.XtraEditors.TextEdit tedTheoryTC;
        private DevExpress.XtraEditors.LabelControl lblTraining2;
        private DevExpress.XtraEditors.LabelControl lblName2;
        private DevExpress.XtraEditors.LabelControl lblTraning1;
        private DevExpress.XtraEditors.LabelControl lblName1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.RadioButton rbEdit;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}