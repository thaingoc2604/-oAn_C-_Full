namespace DETAI
{
    partial class frmDMChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMChucVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphucap = new System.Windows.Forms.TextBox();
            this.txttenchucvu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmachucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_DMChucVu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.cmdluu = new System.Windows.Forms.Button();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.cmdcapnhat = new System.Windows.Forms.Button();
            this.cmdthem = new System.Windows.Forms.Button();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMChucVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtphucap);
            this.panel1.Controls.Add(this.txttenchucvu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmachucvu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgv_DMChucVu);
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 277);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phụ Cấp";
            // 
            // txtphucap
            // 
            this.txtphucap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtphucap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphucap.Location = new System.Drawing.Point(151, 74);
            this.txtphucap.MaxLength = 8;
            this.txtphucap.Name = "txtphucap";
            this.txtphucap.ReadOnly = true;
            this.txtphucap.Size = new System.Drawing.Size(108, 22);
            this.txtphucap.TabIndex = 19;
            this.txtphucap.Tag = "";
            this.txtphucap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphucap_KeyPress);
            // 
            // txttenchucvu
            // 
            this.txttenchucvu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttenchucvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenchucvu.Location = new System.Drawing.Point(151, 42);
            this.txttenchucvu.MaxLength = 50;
            this.txttenchucvu.Name = "txttenchucvu";
            this.txttenchucvu.ReadOnly = true;
            this.txttenchucvu.Size = new System.Drawing.Size(199, 22);
            this.txttenchucvu.TabIndex = 17;
            this.txttenchucvu.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // txtmachucvu
            // 
            this.txtmachucvu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtmachucvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmachucvu.Location = new System.Drawing.Point(151, 11);
            this.txtmachucvu.MaxLength = 5;
            this.txtmachucvu.Name = "txtmachucvu";
            this.txtmachucvu.ReadOnly = true;
            this.txtmachucvu.Size = new System.Drawing.Size(108, 22);
            this.txtmachucvu.TabIndex = 15;
            this.txtmachucvu.Tag = "";
            this.txtmachucvu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmachucvu_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã Chức Vụ";
            // 
            // dgv_DMChucVu
            // 
            this.dgv_DMChucVu.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DMChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DMChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DMChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.TenChucVu,
            this.PhuCap});
            this.dgv_DMChucVu.Location = new System.Drawing.Point(12, 106);
            this.dgv_DMChucVu.Name = "dgv_DMChucVu";
            this.dgv_DMChucVu.ReadOnly = true;
            this.dgv_DMChucVu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_DMChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DMChucVu.Size = new System.Drawing.Size(375, 160);
            this.dgv_DMChucVu.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdthoat);
            this.groupBox1.Controls.Add(this.cmdluu);
            this.groupBox1.Controls.Add(this.cmdxoa);
            this.groupBox1.Controls.Add(this.cmdcapnhat);
            this.groupBox1.Controls.Add(this.cmdthem);
            this.groupBox1.Location = new System.Drawing.Point(411, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 283);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // cmdthoat
            // 
            this.cmdthoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdthoat.Image")));
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(5, 214);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(73, 30);
            this.cmdthoat.TabIndex = 19;
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click_1);
            // 
            // cmdluu
            // 
            this.cmdluu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdluu.Image = ((System.Drawing.Image)(resources.GetObject("cmdluu.Image")));
            this.cmdluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdluu.Location = new System.Drawing.Point(5, 170);
            this.cmdluu.Name = "cmdluu";
            this.cmdluu.Size = new System.Drawing.Size(73, 30);
            this.cmdluu.TabIndex = 18;
            this.cmdluu.Text = "Lưu";
            this.cmdluu.UseVisualStyleBackColor = true;
            this.cmdluu.Click += new System.EventHandler(this.cmdluu_Click);
            // 
            // cmdxoa
            // 
            this.cmdxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxoa.Image = ((System.Drawing.Image)(resources.GetObject("cmdxoa.Image")));
            this.cmdxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxoa.Location = new System.Drawing.Point(5, 126);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(73, 30);
            this.cmdxoa.TabIndex = 17;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // cmdcapnhat
            // 
            this.cmdcapnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcapnhat.Image = ((System.Drawing.Image)(resources.GetObject("cmdcapnhat.Image")));
            this.cmdcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdcapnhat.Location = new System.Drawing.Point(5, 82);
            this.cmdcapnhat.Name = "cmdcapnhat";
            this.cmdcapnhat.Size = new System.Drawing.Size(73, 30);
            this.cmdcapnhat.TabIndex = 16;
            this.cmdcapnhat.Text = "Sửa";
            this.cmdcapnhat.UseVisualStyleBackColor = true;
            this.cmdcapnhat.Click += new System.EventHandler(this.cmdcapnhat_Click);
            // 
            // cmdthem
            // 
            this.cmdthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthem.Image = ((System.Drawing.Image)(resources.GetObject("cmdthem.Image")));
            this.cmdthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthem.Location = new System.Drawing.Point(5, 38);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(73, 30);
            this.cmdthem.TabIndex = 15;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            this.cmdthem.Click += new System.EventHandler(this.cmdthem_Click);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.MaChucVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaChucVu.Frozen = true;
            this.MaChucVu.HeaderText = "Mã";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            this.MaChucVu.Width = 60;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.TenChucVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenChucVu.HeaderText = "Tên chức vụ";
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.ReadOnly = true;
            this.TenChucVu.Width = 170;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.PhuCap.DefaultCellStyle = dataGridViewCellStyle4;
            this.PhuCap.HeaderText = "Phụ cấp";
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            // 
            // frmDMChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(498, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDMChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh Mục Chức Vụ";
            this.Load += new System.EventHandler(this.frmDMChucVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMChucVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DMChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphucap;
        private System.Windows.Forms.TextBox txttenchucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmachucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Button cmdluu;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.Button cmdcapnhat;
        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;

    }
}