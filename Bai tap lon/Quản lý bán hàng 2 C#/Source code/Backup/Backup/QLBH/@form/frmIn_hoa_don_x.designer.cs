namespace QLBH._forms
{
    partial class frmIn_hoa_don_x
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid_in_hd = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_ngay_lap = new System.Windows.Forms.TextBox();
            this.txt_mkh = new System.Windows.Forms.TextBox();
            this.txt_kh = new System.Windows.Forms.TextBox();
            this.txt_mnv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nhvien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tong_tien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.com_so_hd = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_in_hd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.grid_in_hd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 328);
            this.panel3.TabIndex = 14;
            // 
            // grid_in_hd
            // 
            this.grid_in_hd.AllowUserToAddRows = false;
            this.grid_in_hd.AllowUserToDeleteRows = false;
            this.grid_in_hd.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid_in_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_in_hd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_in_hd.Location = new System.Drawing.Point(0, 0);
            this.grid_in_hd.Name = "grid_in_hd";
            this.grid_in_hd.ReadOnly = true;
            this.grid_in_hd.Size = new System.Drawing.Size(941, 328);
            this.grid_in_hd.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QLBH.Properties.Resources.title_form;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 44);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "In hóa đơn xuất";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.txt_ngay_lap);
            this.panel4.Controls.Add(this.txt_mkh);
            this.panel4.Controls.Add(this.txt_kh);
            this.panel4.Controls.Add(this.txt_mnv);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_nhvien);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_tong_tien);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_print);
            this.panel4.Controls.Add(this.com_so_hd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 91);
            this.panel4.TabIndex = 15;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txt_ngay_lap
            // 
            this.txt_ngay_lap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ngay_lap.Location = new System.Drawing.Point(81, 59);
            this.txt_ngay_lap.Name = "txt_ngay_lap";
            this.txt_ngay_lap.ReadOnly = true;
            this.txt_ngay_lap.Size = new System.Drawing.Size(174, 20);
            this.txt_ngay_lap.TabIndex = 5;
            // 
            // txt_mkh
            // 
            this.txt_mkh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mkh.Location = new System.Drawing.Point(305, 33);
            this.txt_mkh.Name = "txt_mkh";
            this.txt_mkh.ReadOnly = true;
            this.txt_mkh.Size = new System.Drawing.Size(121, 20);
            this.txt_mkh.TabIndex = 5;
            // 
            // txt_kh
            // 
            this.txt_kh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_kh.Location = new System.Drawing.Point(441, 33);
            this.txt_kh.Name = "txt_kh";
            this.txt_kh.ReadOnly = true;
            this.txt_kh.Size = new System.Drawing.Size(197, 20);
            this.txt_kh.TabIndex = 5;
            // 
            // txt_mnv
            // 
            this.txt_mnv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mnv.Location = new System.Drawing.Point(305, 7);
            this.txt_mnv.Name = "txt_mnv";
            this.txt_mnv.ReadOnly = true;
            this.txt_mnv.Size = new System.Drawing.Size(121, 20);
            this.txt_mnv.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày lập";
            // 
            // txt_nhvien
            // 
            this.txt_nhvien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nhvien.Location = new System.Drawing.Point(441, 7);
            this.txt_nhvien.Name = "txt_nhvien";
            this.txt_nhvien.ReadOnly = true;
            this.txt_nhvien.Size = new System.Drawing.Size(197, 20);
            this.txt_nhvien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhân viên lập";
            // 
            // txt_tong_tien
            // 
            this.txt_tong_tien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tong_tien.Location = new System.Drawing.Point(81, 33);
            this.txt_tong_tien.Name = "txt_tong_tien";
            this.txt_tong_tien.ReadOnly = true;
            this.txt_tong_tien.Size = new System.Drawing.Size(121, 20);
            this.txt_tong_tien.TabIndex = 3;
            this.txt_tong_tien.TextChanged += new System.EventHandler(this.txt_tong_tien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số hóa đơn";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_print.Location = new System.Drawing.Point(727, 17);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(90, 36);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "In ngay";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // com_so_hd
            // 
            this.com_so_hd.FormattingEnabled = true;
            this.com_so_hd.Location = new System.Drawing.Point(81, 6);
            this.com_so_hd.Name = "com_so_hd";
            this.com_so_hd.Size = new System.Drawing.Size(121, 21);
            this.com_so_hd.TabIndex = 0;
            this.com_so_hd.SelectedIndexChanged += new System.EventHandler(this.com_so_hd_SelectedIndexChanged);
            // 
            // frmIn_hoa_don_x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 469);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmIn_hoa_don_x";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn xuất";
            this.Load += new System.EventHandler(this.frmLoai_hang_Load_1);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_in_hd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ComboBox com_so_hd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_in_hd;
        private System.Windows.Forms.TextBox txt_tong_tien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mkh;
        private System.Windows.Forms.TextBox txt_kh;
        private System.Windows.Forms.TextBox txt_mnv;
        private System.Windows.Forms.TextBox txt_nhvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ngay_lap;
        private System.Windows.Forms.Label label6;
    }
}