﻿namespace DETAI
{
    partial class frmDMChuyenMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMChuyenMon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttenCM = new System.Windows.Forms.TextBox();
            this.txtmaCM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_DMchuyenmon = new System.Windows.Forms.DataGridView();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.cmdluu = new System.Windows.Forms.Button();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.cmdthem = new System.Windows.Forms.Button();
            this.cmdcapnhat = new System.Windows.Forms.Button();
            this.MaChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMchuyenmon)).BeginInit();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.txttenCM);
            this.panel1.Controls.Add(this.txtmaCM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgv_DMchuyenmon);
            this.panel1.Location = new System.Drawing.Point(8, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 237);
            this.panel1.TabIndex = 3;
            // 
            // txttenCM
            // 
            this.txttenCM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttenCM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenCM.Location = new System.Drawing.Point(54, 41);
            this.txttenCM.MaxLength = 50;
            this.txttenCM.Name = "txttenCM";
            this.txttenCM.ReadOnly = true;
            this.txttenCM.Size = new System.Drawing.Size(209, 22);
            this.txttenCM.TabIndex = 18;
            this.txttenCM.Tag = "";
            // 
            // txtmaCM
            // 
            this.txtmaCM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtmaCM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaCM.Location = new System.Drawing.Point(54, 10);
            this.txtmaCM.MaxLength = 8;
            this.txtmaCM.Name = "txtmaCM";
            this.txtmaCM.ReadOnly = true;
            this.txtmaCM.Size = new System.Drawing.Size(108, 22);
            this.txtmaCM.TabIndex = 16;
            this.txtmaCM.Tag = "";
            this.txtmaCM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaCM_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã :";
            // 
            // dgv_DMchuyenmon
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgv_DMchuyenmon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DMchuyenmon.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DMchuyenmon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DMchuyenmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DMchuyenmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenMon,
            this.TenChuyenMon});
            this.dgv_DMchuyenmon.Location = new System.Drawing.Point(9, 76);
            this.dgv_DMchuyenmon.Name = "dgv_DMchuyenmon";
            this.dgv_DMchuyenmon.ReadOnly = true;
            this.dgv_DMchuyenmon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_DMchuyenmon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DMchuyenmon.Size = new System.Drawing.Size(286, 150);
            this.dgv_DMchuyenmon.TabIndex = 1;
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.cmdxoa);
            this.grpbox.Controls.Add(this.cmdluu);
            this.grpbox.Controls.Add(this.cmdthoat);
            this.grpbox.Controls.Add(this.cmdthem);
            this.grpbox.Controls.Add(this.cmdcapnhat);
            this.grpbox.Location = new System.Drawing.Point(315, 8);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(86, 243);
            this.grpbox.TabIndex = 16;
            this.grpbox.TabStop = false;
            // 
            // cmdxoa
            // 
            this.cmdxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxoa.Image = ((System.Drawing.Image)(resources.GetObject("cmdxoa.Image")));
            this.cmdxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxoa.Location = new System.Drawing.Point(7, 106);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(73, 30);
            this.cmdxoa.TabIndex = 19;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // cmdluu
            // 
            this.cmdluu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdluu.Image = ((System.Drawing.Image)(resources.GetObject("cmdluu.Image")));
            this.cmdluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdluu.Location = new System.Drawing.Point(7, 150);
            this.cmdluu.Name = "cmdluu";
            this.cmdluu.Size = new System.Drawing.Size(73, 30);
            this.cmdluu.TabIndex = 18;
            this.cmdluu.Text = "Lưu";
            this.cmdluu.UseVisualStyleBackColor = true;
            this.cmdluu.Click += new System.EventHandler(this.cmdluu_Click);
            // 
            // cmdthoat
            // 
            this.cmdthoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdthoat.Image")));
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(7, 194);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(73, 30);
            this.cmdthoat.TabIndex = 17;
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // cmdthem
            // 
            this.cmdthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthem.Image = ((System.Drawing.Image)(resources.GetObject("cmdthem.Image")));
            this.cmdthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthem.Location = new System.Drawing.Point(7, 18);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(73, 30);
            this.cmdthem.TabIndex = 16;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            this.cmdthem.Click += new System.EventHandler(this.cmdthem_Click);
            // 
            // cmdcapnhat
            // 
            this.cmdcapnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcapnhat.Image = ((System.Drawing.Image)(resources.GetObject("cmdcapnhat.Image")));
            this.cmdcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdcapnhat.Location = new System.Drawing.Point(7, 62);
            this.cmdcapnhat.Name = "cmdcapnhat";
            this.cmdcapnhat.Size = new System.Drawing.Size(73, 30);
            this.cmdcapnhat.TabIndex = 15;
            this.cmdcapnhat.Text = "Sửa";
            this.cmdcapnhat.UseVisualStyleBackColor = true;
            this.cmdcapnhat.Click += new System.EventHandler(this.cmdcapnhat_Click);
            // 
            // MaChuyenMon
            // 
            this.MaChuyenMon.DataPropertyName = "MaChuyenMon";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.MaChuyenMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaChuyenMon.Frozen = true;
            this.MaChuyenMon.HeaderText = "Mã";
            this.MaChuyenMon.Name = "MaChuyenMon";
            this.MaChuyenMon.ReadOnly = true;
            this.MaChuyenMon.Width = 60;
            // 
            // TenChuyenMon
            // 
            this.TenChuyenMon.DataPropertyName = "TenChuyenMon";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.TenChuyenMon.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenChuyenMon.HeaderText = "Tên chuyên môn";
            this.TenChuyenMon.Name = "TenChuyenMon";
            this.TenChuyenMon.ReadOnly = true;
            this.TenChuyenMon.Width = 180;
            // 
            // frmDMChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(409, 259);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDMChuyenMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh Mục Chuyên Môn";
            this.Load += new System.EventHandler(this.frmDMChuyenMon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMchuyenmon)).EndInit();
            this.grpbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DMchuyenmon;
        private System.Windows.Forms.TextBox txttenCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaCM;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.Button cmdluu;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.Button cmdcapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuyenMon;
    }
}