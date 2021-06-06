namespace QLTKB
{
    partial class frmGiaoVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbcm = new System.Windows.Forms.ComboBox();
            this.cbgt = new System.Windows.Forms.ComboBox();
            this.txtns = new System.Windows.Forms.DateTimePicker();
            this.lbten = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.msds = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 32);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC GIÁO VIÊN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbcm);
            this.panel2.Controls.Add(this.cbgt);
            this.panel2.Controls.Add(this.txtns);
            this.panel2.Controls.Add(this.lbten);
            this.panel2.Controls.Add(this.txtdc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtten);
            this.panel2.Controls.Add(this.txtma);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 120);
            this.panel2.TabIndex = 6;
            // 
            // cbcm
            // 
            this.cbcm.FormattingEnabled = true;
            this.cbcm.Location = new System.Drawing.Point(550, 72);
            this.cbcm.Name = "cbcm";
            this.cbcm.Size = new System.Drawing.Size(59, 27);
            this.cbcm.TabIndex = 14;
            this.cbcm.SelectedIndexChanged += new System.EventHandler(this.cbcm_SelectedIndexChanged);
            // 
            // cbgt
            // 
            this.cbgt.FormattingEnabled = true;
            this.cbgt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgt.Location = new System.Drawing.Point(550, 37);
            this.cbgt.Name = "cbgt";
            this.cbgt.Size = new System.Drawing.Size(200, 27);
            this.cbgt.TabIndex = 13;
            // 
            // txtns
            // 
            this.txtns.CustomFormat = "MM/dd/yyyy";
            this.txtns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtns.Location = new System.Drawing.Point(550, 3);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(200, 27);
            this.txtns.TabIndex = 12;
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(615, 75);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(27, 19);
            this.lbten.TabIndex = 11;
            this.lbten.Text = "---";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(261, 72);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(175, 27);
            this.txtdc.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chuyên Môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã GV";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(261, 39);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(175, 27);
            this.txtten.TabIndex = 1;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(261, 6);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(175, 27);
            this.txtma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnxoa);
            this.panel3.Controls.Add(this.btnsua);
            this.panel3.Controls.Add(this.btnluu);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 44);
            this.panel3.TabIndex = 7;
            // 
            // btnxoa
            // 
            this.btnxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnxoa.Image = global::QLTKB.Properties.Resources._3Xoa;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(310, 0);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 44);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsua.Image = global::QLTKB.Properties.Resources._2Sua;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(211, 0);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(99, 44);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnluu.Image = global::QLTKB.Properties.Resources._5Luu;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(116, 0);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(95, 44);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnthem.Image = global::QLTKB.Properties.Resources._1Them;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(0, 0);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(116, 44);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm Mới";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // msds
            // 
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.Location = new System.Drawing.Point(0, 196);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(906, 353);
            this.msds.TabIndex = 8;
            this.msds.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellDoubleClick);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 549);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo Viên";
            this.Load += new System.EventHandler(this.fr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbgt;
        private System.Windows.Forms.DateTimePicker txtns;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.ComboBox cbcm;
    }
}