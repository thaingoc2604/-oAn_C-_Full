namespace qlkaraoke
{
    partial class fLeaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLeaveForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fLeaveFormDTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.fLeaveFormDTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.fLeaveFormTxtFullName = new System.Windows.Forms.TextBox();
            this.fLeaveFormTxtReason = new System.Windows.Forms.TextBox();
            this.fLeaveFormTxtMoreDes = new System.Windows.Forms.TextBox();
            this.fLeaveFormBtnSend = new System.Windows.Forms.Button();
            this.fLeaveFormBtnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fLeaveFormCBoxReceiver = new System.Windows.Forms.ComboBox();
            this.fLeaveFormBtnClose = new System.Windows.Forms.Button();
            this.employeeTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter();
            this.leaveformTableAdapter1 = new qlkaraoke.DataSet1TableAdapters.LeaveformTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Form date";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "LEAVE FORM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::qlkaraoke.Properties.Resources.karaoke2;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::qlkaraoke.Properties.Resources.karaoke3;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Full name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "More Description";
            // 
            // fLeaveFormDTimeFrom
            // 
            this.fLeaveFormDTimeFrom.CustomFormat = "dd/MM/yyyy";
            this.fLeaveFormDTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fLeaveFormDTimeFrom.Location = new System.Drawing.Point(97, 60);
            this.fLeaveFormDTimeFrom.Name = "fLeaveFormDTimeFrom";
            this.fLeaveFormDTimeFrom.Size = new System.Drawing.Size(173, 20);
            this.fLeaveFormDTimeFrom.TabIndex = 24;
            // 
            // fLeaveFormDTimeTo
            // 
            this.fLeaveFormDTimeTo.CustomFormat = "dd/MM/yyyy";
            this.fLeaveFormDTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fLeaveFormDTimeTo.Location = new System.Drawing.Point(342, 60);
            this.fLeaveFormDTimeTo.Name = "fLeaveFormDTimeTo";
            this.fLeaveFormDTimeTo.Size = new System.Drawing.Size(173, 20);
            this.fLeaveFormDTimeTo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(290, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "To date";
            // 
            // fLeaveFormTxtFullName
            // 
            this.fLeaveFormTxtFullName.Location = new System.Drawing.Point(97, 90);
            this.fLeaveFormTxtFullName.Name = "fLeaveFormTxtFullName";
            this.fLeaveFormTxtFullName.Size = new System.Drawing.Size(173, 20);
            this.fLeaveFormTxtFullName.TabIndex = 27;
            // 
            // fLeaveFormTxtReason
            // 
            this.fLeaveFormTxtReason.Location = new System.Drawing.Point(97, 118);
            this.fLeaveFormTxtReason.Multiline = true;
            this.fLeaveFormTxtReason.Name = "fLeaveFormTxtReason";
            this.fLeaveFormTxtReason.Size = new System.Drawing.Size(418, 48);
            this.fLeaveFormTxtReason.TabIndex = 28;
            // 
            // fLeaveFormTxtMoreDes
            // 
            this.fLeaveFormTxtMoreDes.Location = new System.Drawing.Point(97, 177);
            this.fLeaveFormTxtMoreDes.Multiline = true;
            this.fLeaveFormTxtMoreDes.Name = "fLeaveFormTxtMoreDes";
            this.fLeaveFormTxtMoreDes.Size = new System.Drawing.Size(418, 74);
            this.fLeaveFormTxtMoreDes.TabIndex = 29;
            // 
            // fLeaveFormBtnSend
            // 
            this.fLeaveFormBtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLeaveFormBtnSend.Location = new System.Drawing.Point(128, 261);
            this.fLeaveFormBtnSend.Name = "fLeaveFormBtnSend";
            this.fLeaveFormBtnSend.Size = new System.Drawing.Size(87, 39);
            this.fLeaveFormBtnSend.TabIndex = 33;
            this.fLeaveFormBtnSend.Text = "Send";
            this.fLeaveFormBtnSend.UseVisualStyleBackColor = true;
            this.fLeaveFormBtnSend.MouseLeave += new System.EventHandler(this.fLeaveFormBtnSend_MouseLeave);
            this.fLeaveFormBtnSend.Click += new System.EventHandler(this.fLeaveFormBtnSend_Click);
            this.fLeaveFormBtnSend.MouseEnter += new System.EventHandler(this.fLeaveFormBtnSend_MouseEnter);
            // 
            // fLeaveFormBtnReset
            // 
            this.fLeaveFormBtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLeaveFormBtnReset.Location = new System.Drawing.Point(221, 261);
            this.fLeaveFormBtnReset.Name = "fLeaveFormBtnReset";
            this.fLeaveFormBtnReset.Size = new System.Drawing.Size(87, 39);
            this.fLeaveFormBtnReset.TabIndex = 34;
            this.fLeaveFormBtnReset.Text = "Reset";
            this.fLeaveFormBtnReset.UseVisualStyleBackColor = true;
            this.fLeaveFormBtnReset.MouseLeave += new System.EventHandler(this.fLeaveFormBtnReset_MouseLeave);
            this.fLeaveFormBtnReset.Click += new System.EventHandler(this.fLeaveFormBtnReset_Click);
            this.fLeaveFormBtnReset.MouseEnter += new System.EventHandler(this.fLeaveFormBtnReset_MouseEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(290, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Receiver";
            // 
            // fLeaveFormCBoxReceiver
            // 
            this.fLeaveFormCBoxReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fLeaveFormCBoxReceiver.FormattingEnabled = true;
            this.fLeaveFormCBoxReceiver.Location = new System.Drawing.Point(342, 89);
            this.fLeaveFormCBoxReceiver.Name = "fLeaveFormCBoxReceiver";
            this.fLeaveFormCBoxReceiver.Size = new System.Drawing.Size(173, 21);
            this.fLeaveFormCBoxReceiver.TabIndex = 36;
            // 
            // fLeaveFormBtnClose
            // 
            this.fLeaveFormBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLeaveFormBtnClose.Location = new System.Drawing.Point(314, 261);
            this.fLeaveFormBtnClose.Name = "fLeaveFormBtnClose";
            this.fLeaveFormBtnClose.Size = new System.Drawing.Size(87, 39);
            this.fLeaveFormBtnClose.TabIndex = 37;
            this.fLeaveFormBtnClose.Text = "Close";
            this.fLeaveFormBtnClose.UseVisualStyleBackColor = true;
            this.fLeaveFormBtnClose.MouseLeave += new System.EventHandler(this.fLeaveFormBtnClose_MouseLeave);
            this.fLeaveFormBtnClose.Click += new System.EventHandler(this.fLeaveFormBtnClose_Click);
            this.fLeaveFormBtnClose.MouseEnter += new System.EventHandler(this.fLeaveFormBtnClose_MouseEnter);
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // leaveformTableAdapter1
            // 
            this.leaveformTableAdapter1.ClearBeforeFill = true;
            // 
            // fLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qlkaraoke.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(528, 311);
            this.Controls.Add(this.fLeaveFormBtnClose);
            this.Controls.Add(this.fLeaveFormCBoxReceiver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fLeaveFormBtnReset);
            this.Controls.Add(this.fLeaveFormBtnSend);
            this.Controls.Add(this.fLeaveFormTxtMoreDes);
            this.Controls.Add(this.fLeaveFormTxtReason);
            this.Controls.Add(this.fLeaveFormTxtFullName);
            this.Controls.Add(this.fLeaveFormDTimeTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fLeaveFormDTimeFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fLeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL KARAOKE - Leave Form";
            this.Load += new System.EventHandler(this.fLeaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fLeaveFormDTimeFrom;
        private System.Windows.Forms.DateTimePicker fLeaveFormDTimeTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fLeaveFormTxtFullName;
        private System.Windows.Forms.TextBox fLeaveFormTxtReason;
        private System.Windows.Forms.TextBox fLeaveFormTxtMoreDes;
        private System.Windows.Forms.Button fLeaveFormBtnSend;
        private System.Windows.Forms.Button fLeaveFormBtnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fLeaveFormCBoxReceiver;
        private System.Windows.Forms.Button fLeaveFormBtnClose;
        private qlkaraoke.DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private qlkaraoke.DataSet1TableAdapters.LeaveformTableAdapter leaveformTableAdapter1;
    }
}