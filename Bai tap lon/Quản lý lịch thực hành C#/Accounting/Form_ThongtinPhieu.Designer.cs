﻿namespace Accounting
{
    partial class Form_ThongtinPhieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThongtinPhieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTimeNgaylap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaDG_Combo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.ChuSoTienLBL = new System.Windows.Forms.TextBox();
            this.numSotien = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttLapPhieu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTimeNgaylap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSotien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bttLapPhieu);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 354);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Hủy ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtID.Location = new System.Drawing.Point(238, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 18;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Phiếu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDienGiai);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DTimeNgaylap);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaDG_Combo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ChuSoTienLBL);
            this.groupBox1.Controls.Add(this.numSotien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 240);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Phiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nội Dung diễn giải";
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDienGiai.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienGiai.Location = new System.Drawing.Point(120, 94);
            this.txtDienGiai.Multiline = true;
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.ReadOnly = true;
            this.txtDienGiai.Size = new System.Drawing.Size(328, 72);
            this.txtDienGiai.TabIndex = 14;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(121, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(328, 24);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Validated += new System.EventHandler(this.txtHoTen_Validated);
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên người";
            // 
            // DTimeNgaylap
            // 
            // 
            // 
            // 
            this.DTimeNgaylap.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTimeNgaylap.ButtonDropDown.Visible = true;
            this.DTimeNgaylap.Location = new System.Drawing.Point(120, 209);
            // 
            // 
            // 
            this.DTimeNgaylap.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.DTimeNgaylap.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTimeNgaylap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTimeNgaylap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTimeNgaylap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTimeNgaylap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTimeNgaylap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTimeNgaylap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTimeNgaylap.MonthCalendar.DisplayMonth = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.DTimeNgaylap.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.DTimeNgaylap.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.DTimeNgaylap.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DTimeNgaylap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTimeNgaylap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTimeNgaylap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTimeNgaylap.MonthCalendar.TodayButtonVisible = true;
            this.DTimeNgaylap.Name = "DTimeNgaylap";
            this.DTimeNgaylap.Size = new System.Drawing.Size(96, 20);
            this.DTimeNgaylap.TabIndex = 13;
            this.DTimeNgaylap.WatermarkColor = System.Drawing.SystemColors.ControlLightLight;
            this.DTimeNgaylap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DTimeNgaylap_KeyDown);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(121, 44);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(328, 24);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày lập phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // MaDG_Combo
            // 
            this.MaDG_Combo.AutoCompleteCustomSource.AddRange(new string[] {
            "ABC"});
            this.MaDG_Combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MaDG_Combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MaDG_Combo.DisplayMember = "diengiai";
            this.MaDG_Combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MaDG_Combo.Font = new System.Drawing.Font(".VnTimeH", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDG_Combo.FormattingEnabled = true;
            this.MaDG_Combo.ItemHeight = 17;
            this.MaDG_Combo.Location = new System.Drawing.Point(120, 69);
            this.MaDG_Combo.Name = "MaDG_Combo";
            this.MaDG_Combo.Size = new System.Drawing.Size(329, 23);
            this.MaDG_Combo.TabIndex = 11;
            this.MaDG_Combo.Tag = "";
            this.MaDG_Combo.ValueMember = "madg";
            this.MaDG_Combo.Leave += new System.EventHandler(this.MaDG_Combo_Leave);
            this.MaDG_Combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaDG_Combo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lý do";
            // 
            // ChuSoTienLBL
            // 
            this.ChuSoTienLBL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChuSoTienLBL.Location = new System.Drawing.Point(121, 188);
            this.ChuSoTienLBL.Name = "ChuSoTienLBL";
            this.ChuSoTienLBL.ReadOnly = true;
            this.ChuSoTienLBL.Size = new System.Drawing.Size(415, 20);
            this.ChuSoTienLBL.TabIndex = 10;
            // 
            // numSotien
            // 
            this.numSotien.Location = new System.Drawing.Point(121, 167);
            this.numSotien.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numSotien.Name = "numSotien";
            this.numSotien.Size = new System.Drawing.Size(120, 20);
            this.numSotien.TabIndex = 7;
            this.numSotien.Tag = "";
            this.numSotien.ThousandsSeparator = true;
            this.numSotien.Validated += new System.EventHandler(this.numSotien_Validated_1);
            this.numSotien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSotien_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số tiền bằng chữ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tiền";
            // 
            // bttLapPhieu
            // 
            this.bttLapPhieu.Location = new System.Drawing.Point(174, 310);
            this.bttLapPhieu.Name = "bttLapPhieu";
            this.bttLapPhieu.Size = new System.Drawing.Size(75, 23);
            this.bttLapPhieu.TabIndex = 14;
            this.bttLapPhieu.Text = "Cập nhật";
            this.bttLapPhieu.UseVisualStyleBackColor = true;
            this.bttLapPhieu.Click += new System.EventHandler(this.bttLapPhieu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_ThongtinPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(571, 347);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(579, 326);
            this.Name = "Form_ThongtinPhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin phiếu";
            this.Activated += new System.EventHandler(this.Form_ThongtinPhieu_Activated);
            this.Load += new System.EventHandler(this.Form_ThongtinPhieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTimeNgaylap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSotien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTimeNgaylap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx MaDG_Combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChuSoTienLBL;
        private System.Windows.Forms.NumericUpDown numSotien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttLapPhieu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.Button button2;
    }
}