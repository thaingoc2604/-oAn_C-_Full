namespace QLBDDemo
{
    partial class frmQuanLiCuocGoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiCuocGoi));
            this.gboQuanLiCuocGoi = new System.Windows.Forms.GroupBox();
            this.txtTtCuocGoi = new System.Windows.Forms.TextBox();
            this.lblSttCuocGoi = new System.Windows.Forms.Label();
            this.lblDong = new System.Windows.Forms.Label();
            this.lblGiay = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.txtHienThiSoGiay = new System.Windows.Forms.TextBox();
            this.btnThoatQuanLiCuocGoi = new System.Windows.Forms.Button();
            this.btnLuuDuLieu = new System.Windows.Forms.Button();
            this.btnCuocGoiMoi = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongThoiGian = new System.Windows.Forms.TextBox();
            this.lblTongThoiGian = new System.Windows.Forms.Label();
            this.txtThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.lblThoiGianKetThuc = new System.Windows.Forms.Label();
            this.txtThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.lblThoiGianBatDau = new System.Windows.Forms.Label();
            this.txtTyGia = new System.Windows.Forms.TextBox();
            this.lblTyGiaUSD = new System.Windows.Forms.Label();
            this.txtSoCanGoi = new System.Windows.Forms.TextBox();
            this.lblSoCanGoi = new System.Windows.Forms.Label();
            this.cboLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerChaySoGiay = new System.Windows.Forms.Timer(this.components);
            this.timerQuanLiCuocGoi = new System.Windows.Forms.Timer(this.components);
            this.gboQuanLiCuocGoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboQuanLiCuocGoi
            // 
            this.gboQuanLiCuocGoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gboQuanLiCuocGoi.BackgroundImage")));
            this.gboQuanLiCuocGoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gboQuanLiCuocGoi.Controls.Add(this.txtTtCuocGoi);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblSttCuocGoi);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblDong);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblGiay);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblThoiGian);
            this.gboQuanLiCuocGoi.Controls.Add(this.txtHienThiSoGiay);
            this.gboQuanLiCuocGoi.Controls.Add(this.btnThoatQuanLiCuocGoi);
            this.gboQuanLiCuocGoi.Controls.Add(this.btnLuuDuLieu);
            this.gboQuanLiCuocGoi.Controls.Add(this.btnCuocGoiMoi);
            this.gboQuanLiCuocGoi.Controls.Add(this.btnBatDau);
            this.gboQuanLiCuocGoi.Controls.Add(this.txtTongTien);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblTongTien);
            this.gboQuanLiCuocGoi.Controls.Add(this.txtTongThoiGian);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblTongThoiGian);
            this.gboQuanLiCuocGoi.Controls.Add(this.txtThoiGianKetThuc);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblThoiGianKetThuc);
            this.gboQuanLiCuocGoi.Controls.Add(this.txtThoiGianBatDau);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblThoiGianBatDau);
            this.gboQuanLiCuocGoi.Controls.Add(this.txtTyGia);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblTyGiaUSD);
            this.gboQuanLiCuocGoi.Controls.Add(this.txtSoCanGoi);
            this.gboQuanLiCuocGoi.Controls.Add(this.lblSoCanGoi);
            this.gboQuanLiCuocGoi.Controls.Add(this.cboLoaiDichVu);
            this.gboQuanLiCuocGoi.Controls.Add(this.label1);
            this.gboQuanLiCuocGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboQuanLiCuocGoi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gboQuanLiCuocGoi.Location = new System.Drawing.Point(35, 25);
            this.gboQuanLiCuocGoi.Name = "gboQuanLiCuocGoi";
            this.gboQuanLiCuocGoi.Size = new System.Drawing.Size(678, 471);
            this.gboQuanLiCuocGoi.TabIndex = 0;
            this.gboQuanLiCuocGoi.TabStop = false;
            this.gboQuanLiCuocGoi.Text = "Thông tin cuộc gọi";
            this.gboQuanLiCuocGoi.Enter += new System.EventHandler(this.gboQuanLiCuocGoi_Enter);
            // 
            // txtTtCuocGoi
            // 
            this.txtTtCuocGoi.Location = new System.Drawing.Point(559, 142);
            this.txtTtCuocGoi.Name = "txtTtCuocGoi";
            this.txtTtCuocGoi.Size = new System.Drawing.Size(76, 26);
            this.txtTtCuocGoi.TabIndex = 22;
            // 
            // lblSttCuocGoi
            // 
            this.lblSttCuocGoi.AutoSize = true;
            this.lblSttCuocGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSttCuocGoi.Location = new System.Drawing.Point(439, 149);
            this.lblSttCuocGoi.Name = "lblSttCuocGoi";
            this.lblSttCuocGoi.Size = new System.Drawing.Size(113, 16);
            this.lblSttCuocGoi.TabIndex = 21;
            this.lblSttCuocGoi.Text = "Thứ tự cuộc gọi";
            // 
            // lblDong
            // 
            this.lblDong.AutoSize = true;
            this.lblDong.Location = new System.Drawing.Point(598, 272);
            this.lblDong.Name = "lblDong";
            this.lblDong.Size = new System.Drawing.Size(52, 20);
            this.lblDong.TabIndex = 20;
            this.lblDong.Text = "Đồng";
            // 
            // lblGiay
            // 
            this.lblGiay.AutoSize = true;
            this.lblGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiay.Location = new System.Drawing.Point(598, 209);
            this.lblGiay.Name = "lblGiay";
            this.lblGiay.Size = new System.Drawing.Size(40, 16);
            this.lblGiay.TabIndex = 19;
            this.lblGiay.Text = "Giây";
            this.lblGiay.Visible = false;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(439, 209);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(73, 16);
            this.lblThoiGian.TabIndex = 18;
            this.lblThoiGian.Text = "Thời gian";
            this.lblThoiGian.Visible = false;
            // 
            // txtHienThiSoGiay
            // 
            this.txtHienThiSoGiay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtHienThiSoGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienThiSoGiay.ForeColor = System.Drawing.Color.Red;
            this.txtHienThiSoGiay.Location = new System.Drawing.Point(527, 203);
            this.txtHienThiSoGiay.Name = "txtHienThiSoGiay";
            this.txtHienThiSoGiay.ReadOnly = true;
            this.txtHienThiSoGiay.Size = new System.Drawing.Size(65, 29);
            this.txtHienThiSoGiay.TabIndex = 17;
            this.txtHienThiSoGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHienThiSoGiay.Visible = false;
            // 
            // btnThoatQuanLiCuocGoi
            // 
            this.btnThoatQuanLiCuocGoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatQuanLiCuocGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatQuanLiCuocGoi.Location = new System.Drawing.Point(519, 329);
            this.btnThoatQuanLiCuocGoi.Name = "btnThoatQuanLiCuocGoi";
            this.btnThoatQuanLiCuocGoi.Size = new System.Drawing.Size(116, 39);
            this.btnThoatQuanLiCuocGoi.TabIndex = 13;
            this.btnThoatQuanLiCuocGoi.Text = "Thoát";
            this.btnThoatQuanLiCuocGoi.UseVisualStyleBackColor = true;
            this.btnThoatQuanLiCuocGoi.Click += new System.EventHandler(this.btnThoatQuanLiCuocGoi_Click);
            // 
            // btnLuuDuLieu
            // 
            this.btnLuuDuLieu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLuuDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDuLieu.Location = new System.Drawing.Point(359, 329);
            this.btnLuuDuLieu.Name = "btnLuuDuLieu";
            this.btnLuuDuLieu.Size = new System.Drawing.Size(116, 39);
            this.btnLuuDuLieu.TabIndex = 12;
            this.btnLuuDuLieu.Text = "Lưu dữ liệu";
            this.btnLuuDuLieu.UseVisualStyleBackColor = true;
            this.btnLuuDuLieu.Click += new System.EventHandler(this.btnLuuDuLieu_Click);
            // 
            // btnCuocGoiMoi
            // 
            this.btnCuocGoiMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuocGoiMoi.Location = new System.Drawing.Point(36, 329);
            this.btnCuocGoiMoi.Name = "btnCuocGoiMoi";
            this.btnCuocGoiMoi.Size = new System.Drawing.Size(116, 39);
            this.btnCuocGoiMoi.TabIndex = 11;
            this.btnCuocGoiMoi.Text = "Cuộc gọi mới";
            this.btnCuocGoiMoi.UseVisualStyleBackColor = true;
            this.btnCuocGoiMoi.Click += new System.EventHandler(this.btnCuocGoiMoi_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(198, 328);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(116, 39);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "Bắt Đầu Gọi";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(499, 266);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(93, 26);
            this.txtTongTien.TabIndex = 10;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(420, 269);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(73, 16);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtTongThoiGian
            // 
            this.txtTongThoiGian.Location = new System.Drawing.Point(187, 263);
            this.txtTongThoiGian.Name = "txtTongThoiGian";
            this.txtTongThoiGian.ReadOnly = true;
            this.txtTongThoiGian.Size = new System.Drawing.Size(150, 26);
            this.txtTongThoiGian.TabIndex = 9;
            // 
            // lblTongThoiGian
            // 
            this.lblTongThoiGian.AutoSize = true;
            this.lblTongThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThoiGian.Location = new System.Drawing.Point(33, 265);
            this.lblTongThoiGian.Name = "lblTongThoiGian";
            this.lblTongThoiGian.Size = new System.Drawing.Size(107, 16);
            this.lblTongThoiGian.TabIndex = 8;
            this.lblTongThoiGian.Text = "Tổng thời gian";
            // 
            // txtThoiGianKetThuc
            // 
            this.txtThoiGianKetThuc.Location = new System.Drawing.Point(187, 203);
            this.txtThoiGianKetThuc.Name = "txtThoiGianKetThuc";
            this.txtThoiGianKetThuc.ReadOnly = true;
            this.txtThoiGianKetThuc.Size = new System.Drawing.Size(150, 26);
            this.txtThoiGianKetThuc.TabIndex = 1;
            // 
            // lblThoiGianKetThuc
            // 
            this.lblThoiGianKetThuc.AutoSize = true;
            this.lblThoiGianKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianKetThuc.Location = new System.Drawing.Point(33, 209);
            this.lblThoiGianKetThuc.Name = "lblThoiGianKetThuc";
            this.lblThoiGianKetThuc.Size = new System.Drawing.Size(130, 16);
            this.lblThoiGianKetThuc.TabIndex = 7;
            this.lblThoiGianKetThuc.Text = "Thời gian kết thúc";
            // 
            // txtThoiGianBatDau
            // 
            this.txtThoiGianBatDau.Location = new System.Drawing.Point(187, 149);
            this.txtThoiGianBatDau.Name = "txtThoiGianBatDau";
            this.txtThoiGianBatDau.ReadOnly = true;
            this.txtThoiGianBatDau.Size = new System.Drawing.Size(150, 26);
            this.txtThoiGianBatDau.TabIndex = 6;
            // 
            // lblThoiGianBatDau
            // 
            this.lblThoiGianBatDau.AutoSize = true;
            this.lblThoiGianBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianBatDau.Location = new System.Drawing.Point(33, 148);
            this.lblThoiGianBatDau.Name = "lblThoiGianBatDau";
            this.lblThoiGianBatDau.Size = new System.Drawing.Size(129, 16);
            this.lblThoiGianBatDau.TabIndex = 5;
            this.lblThoiGianBatDau.Text = "Thời gian bắt đầu";
            // 
            // txtTyGia
            // 
            this.txtTyGia.Location = new System.Drawing.Point(530, 42);
            this.txtTyGia.Name = "txtTyGia";
            this.txtTyGia.Size = new System.Drawing.Size(105, 26);
            this.txtTyGia.TabIndex = 4;
            this.txtTyGia.Visible = false;
            // 
            // lblTyGiaUSD
            // 
            this.lblTyGiaUSD.AutoSize = true;
            this.lblTyGiaUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyGiaUSD.Location = new System.Drawing.Point(439, 45);
            this.lblTyGiaUSD.Name = "lblTyGiaUSD";
            this.lblTyGiaUSD.Size = new System.Drawing.Size(88, 16);
            this.lblTyGiaUSD.TabIndex = 1;
            this.lblTyGiaUSD.Text = "Tỷ giá USD";
            this.lblTyGiaUSD.Visible = false;
            // 
            // txtSoCanGoi
            // 
            this.txtSoCanGoi.Location = new System.Drawing.Point(187, 96);
            this.txtSoCanGoi.Name = "txtSoCanGoi";
            this.txtSoCanGoi.Size = new System.Drawing.Size(150, 26);
            this.txtSoCanGoi.TabIndex = 3;
            // 
            // lblSoCanGoi
            // 
            this.lblSoCanGoi.AutoSize = true;
            this.lblSoCanGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCanGoi.Location = new System.Drawing.Point(33, 95);
            this.lblSoCanGoi.Name = "lblSoCanGoi";
            this.lblSoCanGoi.Size = new System.Drawing.Size(82, 16);
            this.lblSoCanGoi.TabIndex = 2;
            this.lblSoCanGoi.Text = "Số cần gọi";
            // 
            // cboLoaiDichVu
            // 
            this.cboLoaiDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiDichVu.FormattingEnabled = true;
            this.cboLoaiDichVu.Items.AddRange(new object[] {
            "Điện thoại nội hạt",
            "Điện thoại nội tỉnh",
            "Điện thoại liên tỉnh",
            "Điện thoại di động",
            "Điện thoại quốc tế"});
            this.cboLoaiDichVu.Location = new System.Drawing.Point(187, 38);
            this.cboLoaiDichVu.Name = "cboLoaiDichVu";
            this.cboLoaiDichVu.Size = new System.Drawing.Size(150, 24);
            this.cboLoaiDichVu.TabIndex = 1;
            this.cboLoaiDichVu.SelectedIndexChanged += new System.EventHandler(this.cboLoaiDichVu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại dịch vụ ";
            // 
            // timerChaySoGiay
            // 
            this.timerChaySoGiay.Interval = 1000;
            this.timerChaySoGiay.Tick += new System.EventHandler(this.timerChaySoGiay_Tick);
            // 
            // frmQuanLiCuocGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 542);
            this.ControlBox = false;
            this.Controls.Add(this.gboQuanLiCuocGoi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLiCuocGoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CUỘC GỌI";
            this.Load += new System.EventHandler(this.frmQuanLiCuocGoi_Load);
            this.gboQuanLiCuocGoi.ResumeLayout(false);
            this.gboQuanLiCuocGoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboQuanLiCuocGoi;
        private System.Windows.Forms.ComboBox cboLoaiDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoCanGoi;
        private System.Windows.Forms.Label lblSoCanGoi;
        private System.Windows.Forms.Label lblThoiGianBatDau;
        private System.Windows.Forms.TextBox txtTyGia;
        private System.Windows.Forms.Label lblTyGiaUSD;
        private System.Windows.Forms.TextBox txtThoiGianKetThuc;
        private System.Windows.Forms.Label lblThoiGianKetThuc;
        private System.Windows.Forms.TextBox txtThoiGianBatDau;
        private System.Windows.Forms.TextBox txtTongThoiGian;
        private System.Windows.Forms.Label lblTongThoiGian;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThoatQuanLiCuocGoi;
        private System.Windows.Forms.Button btnLuuDuLieu;
        private System.Windows.Forms.Button btnCuocGoiMoi;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label lblGiay;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.TextBox txtHienThiSoGiay;
        private System.Windows.Forms.Timer timerChaySoGiay;
        private System.Windows.Forms.Timer timerQuanLiCuocGoi;
        private System.Windows.Forms.Label lblDong;
        private System.Windows.Forms.Label lblSttCuocGoi;
        private System.Windows.Forms.TextBox txtTtCuocGoi;
    }
}