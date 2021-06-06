namespace ThiTracNghiem_THDC
{
    partial class frmThiThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnDuongDan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblThoiGianConLai = new System.Windows.Forms.Label();
            this.lblDapAnD = new System.Windows.Forms.Label();
            this.lblDapAnC = new System.Windows.Forms.Label();
            this.lblDapAnB = new System.Windows.Forms.Label();
            this.lblDapAnA = new System.Windows.Forms.Label();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnCauTiep = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblCauDung = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXemDapAn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtDuongDan);
            this.groupBox1.Controls.Add(this.btnDuongDan);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(9, 23);
            this.txtDuongDan.Multiline = true;
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(279, 26);
            this.txtDuongDan.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtDuongDan, "Bài thi nằm trong folder Test cùa thư mục bin");
            this.txtDuongDan.TextChanged += new System.EventHandler(this.txtDuongDan_TextChanged);
            // 
            // btnDuongDan
            // 
            this.btnDuongDan.Location = new System.Drawing.Point(306, 17);
            this.btnDuongDan.Name = "btnDuongDan";
            this.btnDuongDan.Size = new System.Drawing.Size(118, 36);
            this.btnDuongDan.TabIndex = 5;
            this.btnDuongDan.Text = "Chọn bài luyện";
            this.btnDuongDan.UseVisualStyleBackColor = true;
            this.btnDuongDan.Click += new System.EventHandler(this.btnDuongDan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblThoiGianConLai);
            this.groupBox2.Controls.Add(this.lblDapAnD);
            this.groupBox2.Controls.Add(this.lblDapAnC);
            this.groupBox2.Controls.Add(this.lblDapAnB);
            this.groupBox2.Controls.Add(this.lblDapAnA);
            this.groupBox2.Controls.Add(this.radB);
            this.groupBox2.Controls.Add(this.radC);
            this.groupBox2.Controls.Add(this.radD);
            this.groupBox2.Controls.Add(this.radA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblCauHoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 405);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lblThoiGianConLai
            // 
            this.lblThoiGianConLai.AutoSize = true;
            this.lblThoiGianConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianConLai.Location = new System.Drawing.Point(313, 20);
            this.lblThoiGianConLai.Name = "lblThoiGianConLai";
            this.lblThoiGianConLai.Size = new System.Drawing.Size(159, 20);
            this.lblThoiGianConLai.TabIndex = 11;
            this.lblThoiGianConLai.Text = "Thời gian còn lại    ";
            // 
            // lblDapAnD
            // 
            this.lblDapAnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDapAnD.Location = new System.Drawing.Point(80, 364);
            this.lblDapAnD.Name = "lblDapAnD";
            this.lblDapAnD.Size = new System.Drawing.Size(609, 25);
            this.lblDapAnD.TabIndex = 13;
            // 
            // lblDapAnC
            // 
            this.lblDapAnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDapAnC.Location = new System.Drawing.Point(80, 314);
            this.lblDapAnC.Name = "lblDapAnC";
            this.lblDapAnC.Size = new System.Drawing.Size(609, 25);
            this.lblDapAnC.TabIndex = 12;
            // 
            // lblDapAnB
            // 
            this.lblDapAnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDapAnB.Location = new System.Drawing.Point(80, 264);
            this.lblDapAnB.Name = "lblDapAnB";
            this.lblDapAnB.Size = new System.Drawing.Size(609, 25);
            this.lblDapAnB.TabIndex = 11;
            // 
            // lblDapAnA
            // 
            this.lblDapAnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDapAnA.Location = new System.Drawing.Point(80, 212);
            this.lblDapAnA.Name = "lblDapAnA";
            this.lblDapAnA.Size = new System.Drawing.Size(609, 25);
            this.lblDapAnA.TabIndex = 10;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radB.Location = new System.Drawing.Point(26, 267);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(41, 28);
            this.radB.TabIndex = 9;
            this.radB.TabStop = true;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            this.radB.CheckedChanged += new System.EventHandler(this.radB_CheckedChanged);
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radC.Location = new System.Drawing.Point(26, 317);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(42, 28);
            this.radC.TabIndex = 8;
            this.radC.TabStop = true;
            this.radC.Text = "C";
            this.radC.UseVisualStyleBackColor = true;
            this.radC.CheckedChanged += new System.EventHandler(this.radC_CheckedChanged);
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radD.Location = new System.Drawing.Point(26, 367);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(42, 28);
            this.radD.TabIndex = 7;
            this.radD.TabStop = true;
            this.radD.Text = "D";
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.radD_CheckedChanged);
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radA.Location = new System.Drawing.Point(26, 215);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(42, 28);
            this.radA.TabIndex = 6;
            this.radA.TabStop = true;
            this.radA.Text = "A";
            this.radA.UseVisualStyleBackColor = true;
            this.radA.CheckedChanged += new System.EventHandler(this.radA_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đáp án :";
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCauHoi.Location = new System.Drawing.Point(9, 57);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(692, 107);
            this.lblCauHoi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Câu hỏi :";
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBatDau.Location = new System.Drawing.Point(492, 3);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(107, 43);
            this.btnBatDau.TabIndex = 7;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKetThuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKetThuc.Location = new System.Drawing.Point(623, 3);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(99, 43);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCauTruoc.Location = new System.Drawing.Point(26, 90);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(108, 45);
            this.btnCauTruoc.TabIndex = 9;
            this.btnCauTruoc.Text = "Câu trước";
            this.btnCauTruoc.UseVisualStyleBackColor = false;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnCauTiep
            // 
            this.btnCauTiep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCauTiep.Location = new System.Drawing.Point(176, 90);
            this.btnCauTiep.Name = "btnCauTiep";
            this.btnCauTiep.Size = new System.Drawing.Size(108, 45);
            this.btnCauTiep.TabIndex = 10;
            this.btnCauTiep.Text = "Câu kế tiếp";
            this.btnCauTiep.UseVisualStyleBackColor = false;
            this.btnCauTiep.Click += new System.EventHandler(this.btnCauTiep_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDanhGia);
            this.groupBox4.Controls.Add(this.lblDiem);
            this.groupBox4.Controls.Add(this.lblCauDung);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(558, 67);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xem kết quả ";
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGia.Location = new System.Drawing.Point(410, 32);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(142, 18);
            this.lblDanhGia.TabIndex = 7;
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(254, 32);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(54, 18);
            this.lblDiem.TabIndex = 6;
            // 
            // lblCauDung
            // 
            this.lblCauDung.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCauDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauDung.Location = new System.Drawing.Point(116, 32);
            this.lblCauDung.Name = "lblCauDung";
            this.lblCauDung.Size = new System.Drawing.Size(54, 18);
            this.lblCauDung.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(330, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Đánh giá :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(197, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Điểm :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số câu đúng :";
            // 
            // btnXemDapAn
            // 
            this.btnXemDapAn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXemDapAn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXemDapAn.ForeColor = System.Drawing.Color.Maroon;
            this.btnXemDapAn.Location = new System.Drawing.Point(587, 79);
            this.btnXemDapAn.Name = "btnXemDapAn";
            this.btnXemDapAn.Size = new System.Drawing.Size(117, 35);
            this.btnXemDapAn.TabIndex = 13;
            this.btnXemDapAn.Text = "Xem đáp án";
            this.btnXemDapAn.UseVisualStyleBackColor = false;
            this.btnXemDapAn.Click += new System.EventHandler(this.btnXemDapAn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.Location = new System.Drawing.Point(599, 588);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 35);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnKetThuc;
            this.ClientSize = new System.Drawing.Size(734, 628);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemDapAn);
            this.Controls.Add(this.btnCauTiep);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmThiThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThiThu";
            this.Load += new System.EventHandler(this.frmThiThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDapAnA;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Label lblDapAnD;
        private System.Windows.Forms.Label lblDapAnC;
        private System.Windows.Forms.Label lblDapAnB;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauTiep;
        private System.Windows.Forms.Label lblThoiGianConLai;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDanhGia;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblCauDung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXemDapAn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Button btnDuongDan;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}