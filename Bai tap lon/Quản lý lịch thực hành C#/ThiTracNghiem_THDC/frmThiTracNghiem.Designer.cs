namespace ThiTracNghiem_THDC
{
    partial class frmThiTracNghiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThiTracNghiem));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblThoiGianconLai = new System.Windows.Forms.Label();
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
            this.ThoiGianThi = new System.Windows.Forms.Timer(this.components);
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnCauTiep = new System.Windows.Forms.Button();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblCauDung = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblThoiGianconLai);
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
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 405);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Thời gian làm bài :";
            // 
            // lblThoiGianconLai
            // 
            this.lblThoiGianconLai.AutoSize = true;
            this.lblThoiGianconLai.Location = new System.Drawing.Point(323, 20);
            this.lblThoiGianconLai.Name = "lblThoiGianconLai";
            this.lblThoiGianconLai.Size = new System.Drawing.Size(155, 18);
            this.lblThoiGianconLai.TabIndex = 11;
            this.lblThoiGianconLai.Text = "Thời gian còn lại 32:00";
            // 
            // lblDapAnD
            // 
            this.lblDapAnD.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDapAnD.Location = new System.Drawing.Point(80, 364);
            this.lblDapAnD.Name = "lblDapAnD";
            this.lblDapAnD.Size = new System.Drawing.Size(569, 25);
            this.lblDapAnD.TabIndex = 13;
            this.lblDapAnD.Text = "Disk Cleanup";
            // 
            // lblDapAnC
            // 
            this.lblDapAnC.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDapAnC.Location = new System.Drawing.Point(80, 314);
            this.lblDapAnC.Name = "lblDapAnC";
            this.lblDapAnC.Size = new System.Drawing.Size(569, 25);
            this.lblDapAnC.TabIndex = 12;
            this.lblDapAnC.Text = "Disk Defragment";
            // 
            // lblDapAnB
            // 
            this.lblDapAnB.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDapAnB.Location = new System.Drawing.Point(80, 264);
            this.lblDapAnB.Name = "lblDapAnB";
            this.lblDapAnB.Size = new System.Drawing.Size(569, 25);
            this.lblDapAnB.TabIndex = 11;
            this.lblDapAnB.Text = "Disk Management";
            // 
            // lblDapAnA
            // 
            this.lblDapAnA.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDapAnA.Location = new System.Drawing.Point(80, 212);
            this.lblDapAnA.Name = "lblDapAnA";
            this.lblDapAnA.Size = new System.Drawing.Size(569, 25);
            this.lblDapAnA.TabIndex = 10;
            this.lblDapAnA.Text = "Device Manager";
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radB.ForeColor = System.Drawing.Color.MediumBlue;
            this.radB.Location = new System.Drawing.Point(26, 267);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(41, 28);
            this.radB.TabIndex = 9;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            this.radB.CheckedChanged += new System.EventHandler(this.radB_CheckedChanged);
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radC.Checked = true;
            this.radC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC.ForeColor = System.Drawing.Color.MediumBlue;
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
            this.radD.ForeColor = System.Drawing.Color.MediumBlue;
            this.radD.Location = new System.Drawing.Point(26, 367);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(42, 28);
            this.radD.TabIndex = 7;
            this.radD.Text = "D";
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.radD_CheckedChanged);
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radA.ForeColor = System.Drawing.Color.MediumBlue;
            this.radA.Location = new System.Drawing.Point(26, 215);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(42, 28);
            this.radA.TabIndex = 6;
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
            this.lblCauHoi.BackColor = System.Drawing.SystemColors.Window;
            this.lblCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCauHoi.Location = new System.Drawing.Point(9, 57);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(655, 107);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Câu 1: Trong hệ điều hành Windows XP có thể tiến hành phân chia đĩa cứng bằng tiệ" +
                "n ích nào sau đây?";
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
            // ThoiGianThi
            // 
            this.ThoiGianThi.Enabled = true;
            this.ThoiGianThi.Interval = 1000;
            this.ThoiGianThi.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKetThuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKetThuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKetThuc.Location = new System.Drawing.Point(458, 13);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(106, 46);
            this.btnKetThuc.TabIndex = 12;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBatDau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBatDau.Location = new System.Drawing.Point(328, 14);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(114, 46);
            this.btnBatDau.TabIndex = 11;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnCauTiep
            // 
            this.btnCauTiep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCauTiep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauTiep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCauTiep.Location = new System.Drawing.Point(164, 14);
            this.btnCauTiep.Name = "btnCauTiep";
            this.btnCauTiep.Size = new System.Drawing.Size(144, 45);
            this.btnCauTiep.TabIndex = 14;
            this.btnCauTiep.Text = "Câu kế tiếp >";
            this.btnCauTiep.UseVisualStyleBackColor = false;
            this.btnCauTiep.Click += new System.EventHandler(this.btnCauTiep_Click);
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCauTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauTruoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCauTruoc.Location = new System.Drawing.Point(5, 14);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(139, 46);
            this.btnCauTruoc.TabIndex = 13;
            this.btnCauTruoc.Text = "< Câu trước";
            this.btnCauTruoc.UseVisualStyleBackColor = false;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
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
            this.groupBox4.Location = new System.Drawing.Point(12, 488);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(670, 65);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xem kết quả ";
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDanhGia.Location = new System.Drawing.Point(478, 32);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(171, 22);
            this.lblDanhGia.TabIndex = 7;
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDiem.Location = new System.Drawing.Point(297, 32);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(64, 22);
            this.lblDiem.TabIndex = 6;
            // 
            // lblCauDung
            // 
            this.lblCauDung.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCauDung.Location = new System.Drawing.Point(119, 32);
            this.lblCauDung.Name = "lblCauDung";
            this.lblCauDung.Size = new System.Drawing.Size(75, 20);
            this.lblCauDung.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Đánh giá :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Điểm :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Câu đúng  :";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThoat.Location = new System.Drawing.Point(576, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 46);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnKetThuc;
            this.ClientSize = new System.Drawing.Size(694, 557);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.btnCauTiep);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmThiTracNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThiTracNghiem";
            this.Load += new System.EventHandler(this.frmThiTracNghiem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblThoiGianconLai;
        private System.Windows.Forms.Label lblDapAnD;
        private System.Windows.Forms.Label lblDapAnC;
        private System.Windows.Forms.Label lblDapAnB;
        private System.Windows.Forms.Label lblDapAnA;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer ThoiGianThi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnCauTiep;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDanhGia;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblCauDung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThoat;
    }
}