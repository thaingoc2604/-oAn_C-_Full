﻿namespace DETAI
{
    partial class frmKiemTraHDHetHan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKiemTraHDHetHan));
            this.cbonamkt = new System.Windows.Forms.ComboBox();
            this.cbothangkt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_NV_HopDong = new System.Windows.Forms.DataGridView();
            this.sohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdxem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_HopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbonamkt
            // 
            this.cbonamkt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbonamkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonamkt.FormattingEnabled = true;
            this.cbonamkt.Location = new System.Drawing.Point(246, 7);
            this.cbonamkt.Name = "cbonamkt";
            this.cbonamkt.Size = new System.Drawing.Size(57, 21);
            this.cbonamkt.TabIndex = 36;
            this.cbonamkt.SelectedIndexChanged += new System.EventHandler(this.cbonamkt_SelectedIndexChanged);
            // 
            // cbothangkt
            // 
            this.cbothangkt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbothangkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbothangkt.FormattingEnabled = true;
            this.cbothangkt.Location = new System.Drawing.Point(139, 7);
            this.cbothangkt.Name = "cbothangkt";
            this.cbothangkt.Size = new System.Drawing.Size(46, 21);
            this.cbothangkt.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Năm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tháng :";
            // 
            // dgv_NV_HopDong
            // 
            this.dgv_NV_HopDong.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_NV_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV_HopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sohd,
            this.manv,
            this.ho,
            this.ten,
            this.ngaykt,
            this.phong,
            this.To});
            this.dgv_NV_HopDong.Location = new System.Drawing.Point(9, 34);
            this.dgv_NV_HopDong.Name = "dgv_NV_HopDong";
            this.dgv_NV_HopDong.ReadOnly = true;
            this.dgv_NV_HopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NV_HopDong.Size = new System.Drawing.Size(369, 159);
            this.dgv_NV_HopDong.TabIndex = 37;
            // 
            // sohd
            // 
            this.sohd.DataPropertyName = "sohd";
            this.sohd.HeaderText = "Số HĐ";
            this.sohd.Name = "sohd";
            this.sohd.ReadOnly = true;
            this.sohd.Visible = false;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // ho
            // 
            this.ho.DataPropertyName = "ho";
            this.ho.HeaderText = "Họ";
            this.ho.Name = "ho";
            this.ho.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // ngaykt
            // 
            this.ngaykt.DataPropertyName = "ngaykt";
            this.ngaykt.HeaderText = "Ngày KT";
            this.ngaykt.Name = "ngaykt";
            this.ngaykt.ReadOnly = true;
            // 
            // phong
            // 
            this.phong.DataPropertyName = "tenphong";
            this.phong.HeaderText = "Phòng";
            this.phong.Name = "phong";
            this.phong.ReadOnly = true;
            // 
            // To
            // 
            this.To.DataPropertyName = "tento";
            this.To.HeaderText = "Tổ";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // cmdxem
            // 
            this.cmdxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxem.Image = ((System.Drawing.Image)(resources.GetObject("cmdxem.Image")));
            this.cmdxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxem.Location = new System.Drawing.Point(117, 199);
            this.cmdxem.Name = "cmdxem";
            this.cmdxem.Size = new System.Drawing.Size(73, 30);
            this.cmdxem.TabIndex = 38;
            this.cmdxem.Text = "Xem";
            this.cmdxem.UseVisualStyleBackColor = true;
            this.cmdxem.Click += new System.EventHandler(this.cmdxem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(196, 199);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(73, 30);
            this.btnIn.TabIndex = 39;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmKiemTraHDHetHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(387, 236);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cmdxem);
            this.Controls.Add(this.dgv_NV_HopDong);
            this.Controls.Add(this.cbonamkt);
            this.Controls.Add(this.cbothangkt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKiemTraHDHetHan";
            this.Text = "Kiểm tra hợp đồng hết hạn";
            this.Load += new System.EventHandler(this.frmKiemTraHDHetHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_HopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbonamkt;
        private System.Windows.Forms.ComboBox cbothangkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_NV_HopDong;
        private System.Windows.Forms.Button cmdxem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykt;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.Button btnIn;
    }
}