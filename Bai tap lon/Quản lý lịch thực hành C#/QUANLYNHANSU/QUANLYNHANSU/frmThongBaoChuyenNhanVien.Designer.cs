namespace QUANLYNHANSU
{
    partial class frmThongBaoChuyenNhanVien
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbPhongBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbChucVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bntChuyen = new DevComponents.DotNetBar.ButtonX();
            this.bntKhong = new DevComponents.DotNetBar.ButtonX();
            this.cmbSQD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(42, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(341, 33);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "***Bạn muốn chuyển ứng viên này vào phòng ban nào và chức vụ gì";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(95, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(82, 24);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Phòng ban";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(95, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(82, 24);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Tổ làm việc";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(95, 107);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(82, 24);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Chức vụ";
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.DisplayMember = "Text";
            this.cmbPhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.ItemHeight = 14;
            this.cmbPhongBan.Location = new System.Drawing.Point(197, 51);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(121, 20);
            this.cmbPhongBan.TabIndex = 4;
            this.cmbPhongBan.SelectedIndexChanged += new System.EventHandler(this.cmbPhongBan_SelectedIndexChanged);
            // 
            // cmbTo
            // 
            this.cmbTo.DisplayMember = "Text";
            this.cmbTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.ItemHeight = 14;
            this.cmbTo.Location = new System.Drawing.Point(197, 81);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(121, 20);
            this.cmbTo.TabIndex = 5;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.DisplayMember = "Text";
            this.cmbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.ItemHeight = 14;
            this.cmbChucVu.Location = new System.Drawing.Point(197, 111);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(121, 20);
            this.cmbChucVu.TabIndex = 6;
            // 
            // bntChuyen
            // 
            this.bntChuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntChuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntChuyen.Location = new System.Drawing.Point(81, 183);
            this.bntChuyen.Name = "bntChuyen";
            this.bntChuyen.Size = new System.Drawing.Size(62, 24);
            this.bntChuyen.TabIndex = 7;
            this.bntChuyen.Text = "Chuyển";
            this.bntChuyen.Click += new System.EventHandler(this.bntChuyen_Click);
            // 
            // bntKhong
            // 
            this.bntKhong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntKhong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntKhong.Location = new System.Drawing.Point(291, 183);
            this.bntKhong.Name = "bntKhong";
            this.bntKhong.Size = new System.Drawing.Size(62, 24);
            this.bntKhong.TabIndex = 8;
            this.bntKhong.Text = "Không";
            this.bntKhong.Click += new System.EventHandler(this.bntKhong_Click);
            // 
            // cmbSQD
            // 
            this.cmbSQD.DisplayMember = "Text";
            this.cmbSQD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSQD.FormattingEnabled = true;
            this.cmbSQD.ItemHeight = 14;
            this.cmbSQD.Location = new System.Drawing.Point(197, 141);
            this.cmbSQD.Name = "cmbSQD";
            this.cmbSQD.Size = new System.Drawing.Size(121, 20);
            this.cmbSQD.TabIndex = 10;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(95, 137);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(82, 24);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Sổ quyết định";
            // 
            // frmThongBaoChuyenNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 237);
            this.Controls.Add(this.cmbSQD);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.bntKhong);
            this.Controls.Add(this.bntChuyen);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbPhongBan);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmThongBaoChuyenNhanVien";
            this.Text = "frmThongBaoChuyenNhanVien";
            this.Load += new System.EventHandler(this.frmThongBaoChuyenNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhongBan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbChucVu;
        private DevComponents.DotNetBar.ButtonX bntChuyen;
        private DevComponents.DotNetBar.ButtonX bntKhong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSQD;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}