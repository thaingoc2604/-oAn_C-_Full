namespace AnTCafe
{
    partial class frmNhapGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhimTat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuuLai = new System.Windows.Forms.Button();
            this.txtCurrentIndex = new System.Windows.Forms.TextBox();
            this.dgvGiaBan = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AllowUserToResizeColumns = false;
            this.dgvHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHang.ColumnHeadersHeight = 25;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.GhiChu,
            this.PhimTat});
            this.dgvHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHang.Location = new System.Drawing.Point(12, 12);
            this.dgvHang.MultiSelect = false;
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.ReadOnly = true;
            this.dgvHang.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(355, 279);
            this.dgvHang.TabIndex = 1;
            this.dgvHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_RowEnter);
            // 
            // MaHang
            // 
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Width = 250;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Visible = false;
            this.GhiChu.Width = 150;
            // 
            // PhimTat
            // 
            this.PhimTat.HeaderText = "Phím tắt";
            this.PhimTat.Name = "PhimTat";
            this.PhimTat.ReadOnly = true;
            this.PhimTat.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(391, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Location = new System.Drawing.Point(292, 309);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(75, 23);
            this.btnLuuLai.TabIndex = 3;
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.UseVisualStyleBackColor = true;
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // txtCurrentIndex
            // 
            this.txtCurrentIndex.Location = new System.Drawing.Point(12, 312);
            this.txtCurrentIndex.Name = "txtCurrentIndex";
            this.txtCurrentIndex.Size = new System.Drawing.Size(78, 20);
            this.txtCurrentIndex.TabIndex = 3;
            this.txtCurrentIndex.Text = "0";
            this.txtCurrentIndex.Visible = false;
            // 
            // dgvGiaBan
            // 
            this.dgvGiaBan.AllowUserToAddRows = false;
            this.dgvGiaBan.AllowUserToDeleteRows = false;
            this.dgvGiaBan.AllowUserToResizeColumns = false;
            this.dgvGiaBan.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGiaBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGiaBan.ColumnHeadersHeight = 25;
            this.dgvGiaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiaBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.GiaBan,
            this.MaHang_,
            this.LoaiKH});
            this.dgvGiaBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvGiaBan.Location = new System.Drawing.Point(364, 12);
            this.dgvGiaBan.MultiSelect = false;
            this.dgvGiaBan.Name = "dgvGiaBan";
            this.dgvGiaBan.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGiaBan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGiaBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaBan.Size = new System.Drawing.Size(104, 279);
            this.dgvGiaBan.TabIndex = 2;
            this.dgvGiaBan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaBan_CellValueChanged);
            this.dgvGiaBan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvGiaBan_DataError);
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Loại khách hàng";
            this.Ten.Name = "Ten";
            this.Ten.Visible = false;
            this.Ten.Width = 180;
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // MaHang_
            // 
            this.MaHang_.HeaderText = "Ma Hang";
            this.MaHang_.Name = "MaHang_";
            this.MaHang_.Visible = false;
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Loai KH";
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.Visible = false;
            // 
            // frmNhapGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.dgvGiaBan);
            this.Controls.Add(this.txtCurrentIndex);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.btnLuuLai);
            this.Name = "frmNhapGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật giá bán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapGia_FormClosing);
            this.Load += new System.EventHandler(this.frmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.TextBox txtCurrentIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhimTat;
        private System.Windows.Forms.DataGridView dgvGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang_;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
    }
}