namespace Accounting
{
    partial class Frm_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Config));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTenMayChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenCSDL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtDVChuQuan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtTenCty = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenCty);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.txtDVChuQuan);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.txtTenMayChu);
            this.groupBox1.Controls.Add(this.txtTenCSDL);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Location = new System.Drawing.Point(119, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 157);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hệ thống";
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Location = new System.Drawing.Point(129, 86);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(112, 20);
            this.txtMatKhau.TabIndex = 31;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // txtTenDangNhap
            // 
            // 
            // 
            // 
            this.txtTenDangNhap.Border.Class = "TextBoxBorder";
            this.txtTenDangNhap.Location = new System.Drawing.Point(129, 65);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(112, 20);
            this.txtTenDangNhap.TabIndex = 29;
            this.txtTenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenDangNhap_KeyDown);
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(17, 65);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(79, 14);
            this.labelX4.TabIndex = 30;
            this.labelX4.Text = "Tên đăng nhập";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(18, 85);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(79, 20);
            this.labelX5.TabIndex = 33;
            this.labelX5.Text = "Mật khẩu";
            // 
            // txtTenMayChu
            // 
            // 
            // 
            // 
            this.txtTenMayChu.Border.Class = "TextBoxBorder";
            this.txtTenMayChu.Location = new System.Drawing.Point(129, 44);
            this.txtTenMayChu.Name = "txtTenMayChu";
            this.txtTenMayChu.Size = new System.Drawing.Size(112, 20);
            this.txtTenMayChu.TabIndex = 26;
            this.txtTenMayChu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenMayChu_KeyDown);
            // 
            // txtTenCSDL
            // 
            // 
            // 
            // 
            this.txtTenCSDL.Border.Class = "TextBoxBorder";
            this.txtTenCSDL.Location = new System.Drawing.Point(129, 23);
            this.txtTenCSDL.Name = "txtTenCSDL";
            this.txtTenCSDL.Size = new System.Drawing.Size(112, 20);
            this.txtTenCSDL.TabIndex = 24;
            this.txtTenCSDL.Text = "DataACC";
            this.txtTenCSDL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenCSDL_KeyDown);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(17, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "Tên CSDL";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(18, 44);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(79, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Tên máy chủ";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(26, 49);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 27;
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(307, 172);
            this.buttonX1.MaximumSize = new System.Drawing.Size(66, 22);
            this.buttonX1.MinimumSize = new System.Drawing.Size(66, 22);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(66, 22);
            this.buttonX1.TabIndex = 40;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(225, 172);
            this.buttonX3.MaximumSize = new System.Drawing.Size(66, 22);
            this.buttonX3.MinimumSize = new System.Drawing.Size(66, 22);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(66, 22);
            this.buttonX3.TabIndex = 39;
            this.buttonX3.Text = "Cập nhật";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // labelX7
            // 
            this.labelX7.ForeColor = System.Drawing.Color.Red;
            this.labelX7.Location = new System.Drawing.Point(1, 173);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(189, 20);
            this.labelX7.TabIndex = 43;
            // 
            // txtDVChuQuan
            // 
            // 
            // 
            // 
            this.txtDVChuQuan.Border.Class = "TextBoxBorder";
            this.txtDVChuQuan.Location = new System.Drawing.Point(129, 107);
            this.txtDVChuQuan.Name = "txtDVChuQuan";
            this.txtDVChuQuan.Size = new System.Drawing.Size(112, 20);
            this.txtDVChuQuan.TabIndex = 34;
            this.txtDVChuQuan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDVChuQuan_KeyDown);
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(18, 106);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(92, 20);
            this.labelX6.TabIndex = 35;
            this.labelX6.Text = "Đơn vị chủ quản";
            // 
            // txtTenCty
            // 
            // 
            // 
            // 
            this.txtTenCty.Border.Class = "TextBoxBorder";
            this.txtTenCty.Location = new System.Drawing.Point(129, 128);
            this.txtTenCty.Name = "txtTenCty";
            this.txtTenCty.Size = new System.Drawing.Size(112, 20);
            this.txtTenCty.TabIndex = 36;
            this.txtTenCty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenCty_KeyDown);
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(18, 127);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(79, 20);
            this.labelX8.TabIndex = 37;
            this.labelX8.Text = "Tên công ty";
            // 
            // Frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 202);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonX3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 231);
            this.Name = "Frm_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình hệ thống";
            this.Activated += new System.EventHandler(this.Frm_Config_Activated);
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenMayChu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenCSDL;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDangNhap;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenCty;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDVChuQuan;
        private DevComponents.DotNetBar.LabelX labelX6;
    }
}