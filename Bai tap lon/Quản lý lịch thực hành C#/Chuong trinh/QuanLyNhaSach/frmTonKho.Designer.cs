namespace QuanLyNhaSach
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTTPC = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTKTC = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnThaoTac = new System.Windows.Forms.Panel();
            this.gbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnlPhieuChi = new System.Windows.Forms.Panel();
            this.gbThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.txtTonDK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDGBQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongXuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtTonCK = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDMLS = new System.Windows.Forms.Panel();
            this.lbDMLS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbTTPC.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnThaoTac.SuspendLayout();
            this.gbThaoTac.SuspendLayout();
            this.pnlPhieuChi.SuspendLayout();
            this.gbThongTinKhachHang.SuspendLayout();
            this.pnDMLS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(10, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(731, 208);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASACH";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "THANG";
            this.Column2.HeaderText = "Tháng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NAM";
            this.Column7.HeaderText = "Năm";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DONGIABQ";
            this.Column6.HeaderText = "Đơn giá BQ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TONGNHAP";
            this.Column8.HeaderText = "Tổng nhập";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TONGXUAT";
            this.Column5.HeaderText = "Tổng xuất";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TONDAUKY";
            this.Column3.HeaderText = "Tồn đầu kỳ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TONCUOIKY";
            this.Column4.HeaderText = "Tồn cuối kỳ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // gbTTPC
            // 
            this.gbTTPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbTTPC.Controls.Add(this.dataGridView1);
            this.gbTTPC.Location = new System.Drawing.Point(20, 5);
            this.gbTTPC.Name = "gbTTPC";
            this.gbTTPC.Size = new System.Drawing.Size(750, 240);
            this.gbTTPC.TabIndex = 7;
            this.gbTTPC.TabStop = false;
            this.gbTTPC.Text = "Thông tin tồn kho";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã PC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã NCC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(285, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(175, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTKTC
            // 
            this.btnTKTC.ForeColor = System.Drawing.Color.Blue;
            this.btnTKTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKTC.Location = new System.Drawing.Point(25, 20);
            this.btnTKTC.Name = "btnTKTC";
            this.btnTKTC.Size = new System.Drawing.Size(120, 30);
            this.btnTKTC.TabIndex = 11;
            this.btnTKTC.Text = "Tìm kiếm - Tra cứu";
            this.btnTKTC.UseVisualStyleBackColor = true;
            this.btnTKTC.Click += new System.EventHandler(this.btnTKTC_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbTTPC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 280);
            this.panel3.TabIndex = 27;
            // 
            // pnThaoTac
            // 
            this.pnThaoTac.Controls.Add(this.gbThaoTac);
            this.pnThaoTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThaoTac.Location = new System.Drawing.Point(0, 233);
            this.pnThaoTac.Name = "pnThaoTac";
            this.pnThaoTac.Size = new System.Drawing.Size(792, 75);
            this.pnThaoTac.TabIndex = 26;
            // 
            // gbThaoTac
            // 
            this.gbThaoTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbThaoTac.Controls.Add(this.btnLuu);
            this.gbThaoTac.Controls.Add(this.bntThoat);
            this.gbThaoTac.Controls.Add(this.btnSua);
            this.gbThaoTac.Controls.Add(this.btnXoa);
            this.gbThaoTac.Controls.Add(this.btnThem);
            this.gbThaoTac.Controls.Add(this.btnTKTC);
            this.gbThaoTac.Location = new System.Drawing.Point(20, 0);
            this.gbThaoTac.Name = "gbThaoTac";
            this.gbThaoTac.Size = new System.Drawing.Size(750, 65);
            this.gbThaoTac.TabIndex = 0;
            this.gbThaoTac.TabStop = false;
            this.gbThaoTac.Text = "Thao Tác";
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(505, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 30);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.ForeColor = System.Drawing.Color.Blue;
            this.bntThoat.Location = new System.Drawing.Point(615, 20);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(80, 30);
            this.bntThoat.TabIndex = 15;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(395, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnlPhieuChi
            // 
            this.pnlPhieuChi.Controls.Add(this.gbThongTinKhachHang);
            this.pnlPhieuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhieuChi.Location = new System.Drawing.Point(0, 67);
            this.pnlPhieuChi.Name = "pnlPhieuChi";
            this.pnlPhieuChi.Size = new System.Drawing.Size(792, 166);
            this.pnlPhieuChi.TabIndex = 25;
            // 
            // gbThongTinKhachHang
            // 
            this.gbThongTinKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbThongTinKhachHang.Controls.Add(this.txtTonDK);
            this.gbThongTinKhachHang.Controls.Add(this.label8);
            this.gbThongTinKhachHang.Controls.Add(this.txtDGBQ);
            this.gbThongTinKhachHang.Controls.Add(this.label5);
            this.gbThongTinKhachHang.Controls.Add(this.txtTongXuat);
            this.gbThongTinKhachHang.Controls.Add(this.label3);
            this.gbThongTinKhachHang.Controls.Add(this.txtTongNhap);
            this.gbThongTinKhachHang.Controls.Add(this.label1);
            this.gbThongTinKhachHang.Controls.Add(this.txtNam);
            this.gbThongTinKhachHang.Controls.Add(this.txtTonCK);
            this.gbThongTinKhachHang.Controls.Add(this.txtMaSach);
            this.gbThongTinKhachHang.Controls.Add(this.txtThang);
            this.gbThongTinKhachHang.Controls.Add(this.label7);
            this.gbThongTinKhachHang.Controls.Add(this.label6);
            this.gbThongTinKhachHang.Controls.Add(this.label4);
            this.gbThongTinKhachHang.Controls.Add(this.label2);
            this.gbThongTinKhachHang.Location = new System.Drawing.Point(20, 15);
            this.gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            this.gbThongTinKhachHang.Size = new System.Drawing.Size(750, 140);
            this.gbThongTinKhachHang.TabIndex = 4;
            this.gbThongTinKhachHang.TabStop = false;
            this.gbThongTinKhachHang.Text = "Thông tin tồn kho";
            // 
            // txtTonDK
            // 
            this.txtTonDK.Location = new System.Drawing.Point(490, 80);
            this.txtTonDK.Name = "txtTonDK";
            this.txtTonDK.Size = new System.Drawing.Size(200, 20);
            this.txtTonDK.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(420, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tồn đầu kỳ";
            // 
            // txtDGBQ
            // 
            this.txtDGBQ.Location = new System.Drawing.Point(130, 81);
            this.txtDGBQ.Name = "txtDGBQ";
            this.txtDGBQ.Size = new System.Drawing.Size(190, 20);
            this.txtDGBQ.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(55, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Đơn giá BQ";
            // 
            // txtTongXuat
            // 
            this.txtTongXuat.Location = new System.Drawing.Point(490, 55);
            this.txtTongXuat.Name = "txtTongXuat";
            this.txtTongXuat.Size = new System.Drawing.Size(200, 20);
            this.txtTongXuat.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(420, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tổng xuất";
            // 
            // txtTongNhap
            // 
            this.txtTongNhap.Location = new System.Drawing.Point(490, 30);
            this.txtTongNhap.Name = "txtTongNhap";
            this.txtTongNhap.Size = new System.Drawing.Size(200, 20);
            this.txtTongNhap.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(420, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng nhập";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(270, 55);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(50, 20);
            this.txtNam.TabIndex = 12;
            // 
            // txtTonCK
            // 
            this.txtTonCK.Location = new System.Drawing.Point(490, 105);
            this.txtTonCK.Name = "txtTonCK";
            this.txtTonCK.Size = new System.Drawing.Size(200, 20);
            this.txtTonCK.TabIndex = 11;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(130, 30);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(190, 20);
            this.txtMaSach.TabIndex = 9;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(130, 55);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(50, 20);
            this.txtThang.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(215, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(420, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tồn cuối kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(55, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LYDOCHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lý do chi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYLAP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TONGSOTIEN";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // pnDMLS
            // 
            this.pnDMLS.Controls.Add(this.lbDMLS);
            this.pnDMLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDMLS.Location = new System.Drawing.Point(0, 0);
            this.pnDMLS.Name = "pnDMLS";
            this.pnDMLS.Size = new System.Drawing.Size(792, 67);
            this.pnDMLS.TabIndex = 24;
            // 
            // lbDMLS
            // 
            this.lbDMLS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDMLS.AutoSize = true;
            this.lbDMLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDMLS.ForeColor = System.Drawing.Color.Blue;
            this.lbDMLS.Location = new System.Drawing.Point(295, 10);
            this.lbDMLS.Name = "lbDMLS";
            this.lbDMLS.Size = new System.Drawing.Size(188, 42);
            this.lbDMLS.TabIndex = 0;
            this.lbDMLS.Text = "TỒN KHO";
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnThaoTac);
            this.Controls.Add(this.pnlPhieuChi);
            this.Controls.Add(this.pnDMLS);
            this.Name = "frmTonKho";
            this.TabText = "TON KHO";
            this.Text = "TON KHO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbTTPC.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnThaoTac.ResumeLayout(false);
            this.gbThaoTac.ResumeLayout(false);
            this.pnlPhieuChi.ResumeLayout(false);
            this.gbThongTinKhachHang.ResumeLayout(false);
            this.gbThongTinKhachHang.PerformLayout();
            this.pnDMLS.ResumeLayout(false);
            this.pnDMLS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbTTPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTKTC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnThaoTac;
        private System.Windows.Forms.GroupBox gbThaoTac;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel pnlPhieuChi;
        private System.Windows.Forms.GroupBox gbThongTinKhachHang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtTonCK;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel pnDMLS;
        private System.Windows.Forms.Label lbDMLS;
        private System.Windows.Forms.TextBox txtTonDK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDGBQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}