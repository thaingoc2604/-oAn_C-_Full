namespace QuanLyNhaSach
{
    partial class frmPhieuChi
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
            System.Windows.Forms.ColumnHeader NgayLap;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuChi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDMLS = new System.Windows.Forms.Label();
            this.pnDMLS = new System.Windows.Forms.Panel();
            this.pnlPhieuChi = new System.Windows.Forms.Panel();
            this.gbThongTinPhieuChi = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.dateTimePickerPC = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnThaoTac = new System.Windows.Forms.Panel();
            this.gbTTINPC = new System.Windows.Forms.GroupBox();
            this.livCTPC = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.MaPC = new System.Windows.Forms.ColumnHeader();
            this.LyDo = new System.Windows.Forms.ColumnHeader();
            this.TongTien = new System.Windows.Forms.ColumnHeader();
            this.gbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTKTC = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbCTPC = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NgayLap = new System.Windows.Forms.ColumnHeader();
            this.pnDMLS.SuspendLayout();
            this.pnlPhieuChi.SuspendLayout();
            this.gbThongTinPhieuChi.SuspendLayout();
            this.pnThaoTac.SuspendLayout();
            this.gbTTINPC.SuspendLayout();
            this.gbThaoTac.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbCTPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NgayLap
            // 
            NgayLap.Text = "Ngày lập";
            NgayLap.Width = 115;
            // 
            // lbDMLS
            // 
            this.lbDMLS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDMLS.AutoSize = true;
            this.lbDMLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDMLS.ForeColor = System.Drawing.Color.Blue;
            this.lbDMLS.Location = new System.Drawing.Point(295, 10);
            this.lbDMLS.Name = "lbDMLS";
            this.lbDMLS.Size = new System.Drawing.Size(204, 42);
            this.lbDMLS.TabIndex = 0;
            this.lbDMLS.Text = "PHIẾU CHI";
            // 
            // pnDMLS
            // 
            this.pnDMLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnDMLS.Controls.Add(this.lbDMLS);
            this.pnDMLS.Location = new System.Drawing.Point(0, 0);
            this.pnDMLS.Name = "pnDMLS";
            this.pnDMLS.Size = new System.Drawing.Size(792, 67);
            this.pnDMLS.TabIndex = 1;
            // 
            // pnlPhieuChi
            // 
            this.pnlPhieuChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPhieuChi.Controls.Add(this.gbThongTinPhieuChi);
            this.pnlPhieuChi.Location = new System.Drawing.Point(0, 67);
            this.pnlPhieuChi.Name = "pnlPhieuChi";
            this.pnlPhieuChi.Size = new System.Drawing.Size(792, 166);
            this.pnlPhieuChi.TabIndex = 13;
            // 
            // gbThongTinPhieuChi
            // 
            this.gbThongTinPhieuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbThongTinPhieuChi.Controls.Add(this.txtTongTien);
            this.gbThongTinPhieuChi.Controls.Add(this.txtLyDo);
            this.gbThongTinPhieuChi.Controls.Add(this.dateTimePickerPC);
            this.gbThongTinPhieuChi.Controls.Add(this.label1);
            this.gbThongTinPhieuChi.Controls.Add(this.txtMaNCC);
            this.gbThongTinPhieuChi.Controls.Add(this.txtMaNV);
            this.gbThongTinPhieuChi.Controls.Add(this.txtMaPC);
            this.gbThongTinPhieuChi.Controls.Add(this.label8);
            this.gbThongTinPhieuChi.Controls.Add(this.label7);
            this.gbThongTinPhieuChi.Controls.Add(this.label6);
            this.gbThongTinPhieuChi.Controls.Add(this.label4);
            this.gbThongTinPhieuChi.Controls.Add(this.label2);
            this.gbThongTinPhieuChi.ForeColor = System.Drawing.Color.Blue;
            this.gbThongTinPhieuChi.Location = new System.Drawing.Point(20, 15);
            this.gbThongTinPhieuChi.Name = "gbThongTinPhieuChi";
            this.gbThongTinPhieuChi.Size = new System.Drawing.Size(750, 140);
            this.gbThongTinPhieuChi.TabIndex = 4;
            this.gbThongTinPhieuChi.TabStop = false;
            this.gbThongTinPhieuChi.Text = "Thông tin phiếu chi";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(490, 106);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(200, 20);
            this.txtTongTien.TabIndex = 19;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(490, 30);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(200, 70);
            this.txtLyDo.TabIndex = 18;
            // 
            // dateTimePickerPC
            // 
            this.dateTimePickerPC.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerPC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPC.Location = new System.Drawing.Point(130, 105);
            this.dateTimePickerPC.Name = "dateTimePickerPC";
            this.dateTimePickerPC.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerPC.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(55, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày lập";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(130, 80);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(190, 20);
            this.txtMaNCC.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(130, 55);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(190, 20);
            this.txtMaNV.TabIndex = 9;
            // 
            // txtMaPC
            // 
            this.txtMaPC.Location = new System.Drawing.Point(130, 30);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(190, 20);
            this.txtMaPC.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(420, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Lý do chi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(55, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã NCC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(420, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(55, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV";
            // 
            // pnThaoTac
            // 
            this.pnThaoTac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnThaoTac.Controls.Add(this.gbTTINPC);
            this.pnThaoTac.Controls.Add(this.gbThaoTac);
            this.pnThaoTac.Location = new System.Drawing.Point(0, 233);
            this.pnThaoTac.Name = "pnThaoTac";
            this.pnThaoTac.Size = new System.Drawing.Size(792, 153);
            this.pnThaoTac.TabIndex = 27;
            // 
            // gbTTINPC
            // 
            this.gbTTINPC.Controls.Add(this.livCTPC);
            this.gbTTINPC.ForeColor = System.Drawing.Color.Blue;
            this.gbTTINPC.Location = new System.Drawing.Point(20, 0);
            this.gbTTINPC.Name = "gbTTINPC";
            this.gbTTINPC.Size = new System.Drawing.Size(523, 148);
            this.gbTTINPC.TabIndex = 1;
            this.gbTTINPC.TabStop = false;
            this.gbTTINPC.Text = "Thông tin phiếu chi";
            // 
            // livCTPC
            // 
            this.livCTPC.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.livCTPC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaPC,
            NgayLap,
            this.LyDo,
            this.TongTien});
            this.livCTPC.ForeColor = System.Drawing.Color.Blue;
            this.livCTPC.GridLines = true;
            this.livCTPC.HoverSelection = true;
            this.livCTPC.Location = new System.Drawing.Point(10, 19);
            this.livCTPC.Name = "livCTPC";
            this.livCTPC.Size = new System.Drawing.Size(507, 120);
            this.livCTPC.TabIndex = 0;
            this.livCTPC.UseCompatibleStateImageBehavior = false;
            this.livCTPC.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // MaPC
            // 
            this.MaPC.Text = "Mã phiếu chi";
            this.MaPC.Width = 101;
            // 
            // LyDo
            // 
            this.LyDo.Text = "Lý do";
            this.LyDo.Width = 112;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Tổng tiền";
            this.TongTien.Width = 95;
            // 
            // gbThaoTac
            // 
            this.gbThaoTac.Controls.Add(this.btnLuu);
            this.gbThaoTac.Controls.Add(this.bntThoat);
            this.gbThaoTac.Controls.Add(this.btnSua);
            this.gbThaoTac.Controls.Add(this.btnXoa);
            this.gbThaoTac.Controls.Add(this.btnThem);
            this.gbThaoTac.Controls.Add(this.btnTKTC);
            this.gbThaoTac.Location = new System.Drawing.Point(549, 0);
            this.gbThaoTac.Name = "gbThaoTac";
            this.gbThaoTac.Size = new System.Drawing.Size(221, 148);
            this.gbThaoTac.TabIndex = 0;
            this.gbThaoTac.TabStop = false;
            this.gbThaoTac.Text = "Thao Tác";
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(114, 64);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 30);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.ForeColor = System.Drawing.Color.Blue;
            this.bntThoat.Location = new System.Drawing.Point(114, 112);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(80, 30);
            this.bntThoat.TabIndex = 21;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(18, 112);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(18, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(18, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTKTC
            // 
            this.btnTKTC.ForeColor = System.Drawing.Color.Blue;
            this.btnTKTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKTC.Location = new System.Drawing.Point(114, 16);
            this.btnTKTC.Name = "btnTKTC";
            this.btnTKTC.Size = new System.Drawing.Size(80, 30);
            this.btnTKTC.TabIndex = 17;
            this.btnTKTC.Text = "Tìm kiếm ";
            this.btnTKTC.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.gbCTPC);
            this.panel3.Location = new System.Drawing.Point(0, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 167);
            this.panel3.TabIndex = 28;
            // 
            // gbCTPC
            // 
            this.gbCTPC.Controls.Add(this.dataGridView1);
            this.gbCTPC.ForeColor = System.Drawing.Color.Blue;
            this.gbCTPC.Location = new System.Drawing.Point(20, 5);
            this.gbCTPC.Name = "gbCTPC";
            this.gbCTPC.Size = new System.Drawing.Size(750, 154);
            this.gbCTPC.TabIndex = 7;
            this.gbCTPC.TabStop = false;
            this.gbCTPC.Text = "Chi tiết phiếu chi";
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(10, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(731, 132);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã PC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã NCC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYLAP";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LYDOCHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lý do chi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TONGSOTIEN";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPC";
            this.Column1.HeaderText = "Mã PC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MANV";
            this.Column2.HeaderText = "Mã NV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MANCC";
            this.Column7.HeaderText = "Mã NCC";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGAYLAP";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "Ngày lập";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "LYDOCHI";
            this.Column8.HeaderText = "Lý do chi";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TONGSOTIEN";
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnThaoTac);
            this.Controls.Add(this.pnlPhieuChi);
            this.Controls.Add(this.pnDMLS);
            this.Name = "frmPhieuChi";
            this.TabText = "PHIEU CHI";
            this.Text = "PHIEU CHI";
            this.pnDMLS.ResumeLayout(false);
            this.pnDMLS.PerformLayout();
            this.pnlPhieuChi.ResumeLayout(false);
            this.gbThongTinPhieuChi.ResumeLayout(false);
            this.gbThongTinPhieuChi.PerformLayout();
            this.pnThaoTac.ResumeLayout(false);
            this.gbTTINPC.ResumeLayout(false);
            this.gbThaoTac.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbCTPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbDMLS;
        private System.Windows.Forms.Panel pnDMLS;
        private System.Windows.Forms.Panel pnlPhieuChi;
        private System.Windows.Forms.GroupBox gbThongTinPhieuChi;
        private System.Windows.Forms.DateTimePicker dateTimePickerPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaPC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnThaoTac;
        private System.Windows.Forms.GroupBox gbTTINPC;
        private System.Windows.Forms.ListView livCTPC;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaPC;
        private System.Windows.Forms.ColumnHeader LyDo;
        private System.Windows.Forms.ColumnHeader TongTien;
        private System.Windows.Forms.GroupBox gbThaoTac;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTKTC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbCTPC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}