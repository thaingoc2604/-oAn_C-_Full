namespace frmAdministrator
{
    partial class frmLamBai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbCauHoi = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTraLoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMucDo = new System.Windows.Forms.Label();
            this.lbCauHoiSo = new System.Windows.Forms.Label();
            this.lbLinhVuc = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.tbB = new System.Windows.Forms.TextBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.tbA = new System.Windows.Forms.TextBox();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSai = new System.Windows.Forms.Label();
            this.lbDung = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.rtbCauHoi);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 369);
            this.panel1.TabIndex = 0;
            // 
            // rtbCauHoi
            // 
            this.rtbCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rtbCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCauHoi.Location = new System.Drawing.Point(269, 35);
            this.rtbCauHoi.Name = "rtbCauHoi";
            this.rtbCauHoi.Size = new System.Drawing.Size(481, 121);
            this.rtbCauHoi.TabIndex = 23;
            this.rtbCauHoi.Text = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnTraLoi);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Location = new System.Drawing.Point(26, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 63);
            this.panel3.TabIndex = 21;
            // 
            // btnTraLoi
            // 
            this.btnTraLoi.Location = new System.Drawing.Point(113, 12);
            this.btnTraLoi.Name = "btnTraLoi";
            this.btnTraLoi.Size = new System.Drawing.Size(101, 35);
            this.btnTraLoi.TabIndex = 7;
            this.btnTraLoi.Text = "&Trả lời";
            this.btnTraLoi.UseVisualStyleBackColor = true;
            this.btnTraLoi.Click += new System.EventHandler(this.btnTraLoi_Click);
            this.btnTraLoi.MouseLeave += new System.EventHandler(this.btnTraLoi_MouseLeave);
            this.btnTraLoi.MouseHover += new System.EventHandler(this.btnTraLoi_MouseHover);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(10, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 35);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            this.btnThoat.MouseHover += new System.EventHandler(this.btnThoat_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbMucDo);
            this.panel2.Controls.Add(this.lbCauHoiSo);
            this.panel2.Controls.Add(this.lbLinhVuc);
            this.panel2.Location = new System.Drawing.Point(26, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 93);
            this.panel2.TabIndex = 20;
            // 
            // lbMucDo
            // 
            this.lbMucDo.AutoSize = true;
            this.lbMucDo.BackColor = System.Drawing.Color.Transparent;
            this.lbMucDo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMucDo.ForeColor = System.Drawing.Color.Coral;
            this.lbMucDo.Location = new System.Drawing.Point(9, 34);
            this.lbMucDo.Name = "lbMucDo";
            this.lbMucDo.Size = new System.Drawing.Size(98, 19);
            this.lbMucDo.TabIndex = 4;
            this.lbMucDo.Text = "Mức độ  : 0";
            // 
            // lbCauHoiSo
            // 
            this.lbCauHoiSo.AutoSize = true;
            this.lbCauHoiSo.BackColor = System.Drawing.Color.Transparent;
            this.lbCauHoiSo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoiSo.ForeColor = System.Drawing.Color.Coral;
            this.lbCauHoiSo.Location = new System.Drawing.Point(9, 11);
            this.lbCauHoiSo.Name = "lbCauHoiSo";
            this.lbCauHoiSo.Size = new System.Drawing.Size(124, 19);
            this.lbCauHoiSo.TabIndex = 3;
            this.lbCauHoiSo.Text = "Câu hỏi số  : 0";
            // 
            // lbLinhVuc
            // 
            this.lbLinhVuc.AutoSize = true;
            this.lbLinhVuc.BackColor = System.Drawing.Color.Transparent;
            this.lbLinhVuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinhVuc.ForeColor = System.Drawing.Color.Coral;
            this.lbLinhVuc.Location = new System.Drawing.Point(9, 57);
            this.lbLinhVuc.Name = "lbLinhVuc";
            this.lbLinhVuc.Size = new System.Drawing.Size(94, 19);
            this.lbLinhVuc.TabIndex = 5;
            this.lbLinhVuc.Text = "Tín chỉ  : 0";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tbD);
            this.panel4.Controls.Add(this.tbC);
            this.panel4.Controls.Add(this.rbA);
            this.panel4.Controls.Add(this.tbB);
            this.panel4.Controls.Add(this.rbB);
            this.panel4.Controls.Add(this.tbA);
            this.panel4.Controls.Add(this.rbC);
            this.panel4.Controls.Add(this.rbD);
            this.panel4.Location = new System.Drawing.Point(269, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 191);
            this.panel4.TabIndex = 22;
            // 
            // tbD
            // 
            this.tbD.BackColor = System.Drawing.Color.White;
            this.tbD.Location = new System.Drawing.Point(51, 120);
            this.tbD.Name = "tbD";
            this.tbD.ReadOnly = true;
            this.tbD.Size = new System.Drawing.Size(413, 20);
            this.tbD.TabIndex = 11;
            // 
            // tbC
            // 
            this.tbC.BackColor = System.Drawing.Color.White;
            this.tbC.Location = new System.Drawing.Point(51, 84);
            this.tbC.Name = "tbC";
            this.tbC.ReadOnly = true;
            this.tbC.Size = new System.Drawing.Size(413, 20);
            this.tbC.TabIndex = 10;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(6, 15);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(38, 17);
            this.rbA.TabIndex = 1;
            this.rbA.TabStop = true;
            this.rbA.Text = "A :";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.White;
            this.tbB.Location = new System.Drawing.Point(51, 50);
            this.tbB.Name = "tbB";
            this.tbB.ReadOnly = true;
            this.tbB.Size = new System.Drawing.Size(413, 20);
            this.tbB.TabIndex = 9;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(6, 54);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(38, 17);
            this.rbB.TabIndex = 2;
            this.rbB.TabStop = true;
            this.rbB.Text = "B :";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.Color.White;
            this.tbA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbA.Location = new System.Drawing.Point(51, 14);
            this.tbA.Name = "tbA";
            this.tbA.ReadOnly = true;
            this.tbA.Size = new System.Drawing.Size(413, 21);
            this.tbA.TabIndex = 8;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(6, 85);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(38, 17);
            this.rbC.TabIndex = 3;
            this.rbC.TabStop = true;
            this.rbC.Text = "C :";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(6, 121);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(39, 17);
            this.rbD.TabIndex = 4;
            this.rbD.TabStop = true;
            this.rbD.Text = "D :";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbCount);
            this.panel5.Controls.Add(this.lbTime);
            this.panel5.Controls.Add(this.lbSai);
            this.panel5.Controls.Add(this.lbDung);
            this.panel5.Location = new System.Drawing.Point(26, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 121);
            this.panel5.TabIndex = 19;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.BackColor = System.Drawing.Color.Transparent;
            this.lbCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ForeColor = System.Drawing.Color.Coral;
            this.lbCount.Location = new System.Drawing.Point(9, 34);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(167, 19);
            this.lbCount.TabIndex = 3;
            this.lbCount.Text = "Tổng số câu hỏi  : 0";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Coral;
            this.lbTime.Location = new System.Drawing.Point(9, 8);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(174, 19);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Thời gian còn lại  : 0";
            // 
            // lbSai
            // 
            this.lbSai.AutoSize = true;
            this.lbSai.BackColor = System.Drawing.Color.Transparent;
            this.lbSai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSai.ForeColor = System.Drawing.Color.Coral;
            this.lbSai.Location = new System.Drawing.Point(9, 87);
            this.lbSai.Name = "lbSai";
            this.lbSai.Size = new System.Drawing.Size(121, 19);
            this.lbSai.TabIndex = 5;
            this.lbSai.Text = "Số câu sai  : 0";
            // 
            // lbDung
            // 
            this.lbDung.AutoSize = true;
            this.lbDung.BackColor = System.Drawing.Color.Transparent;
            this.lbDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDung.ForeColor = System.Drawing.Color.Coral;
            this.lbDung.Location = new System.Drawing.Point(9, 62);
            this.lbDung.Name = "lbDung";
            this.lbDung.Size = new System.Drawing.Size(133, 19);
            this.lbDung.TabIndex = 4;
            this.lbDung.Text = "Số câu đúng : 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 369);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLamBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm Bài | User";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLamBai_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbCauHoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTraLoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMucDo;
        private System.Windows.Forms.Label lbCauHoiSo;
        private System.Windows.Forms.Label lbLinhVuc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSai;
        private System.Windows.Forms.Label lbDung;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbCount;

    }
}