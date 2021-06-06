namespace Accounting
{
    partial class Form_UserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstDsNgDung = new System.Windows.Forms.ListBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtHoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNhom = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bttThem = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bttUpDate = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 218);
            this.panel1.TabIndex = 0;
            // 
            // lstDsNgDung
            // 
            this.lstDsNgDung.FormattingEnabled = true;
            this.lstDsNgDung.Location = new System.Drawing.Point(10, 18);
            this.lstDsNgDung.Name = "lstDsNgDung";
            this.lstDsNgDung.Size = new System.Drawing.Size(120, 160);
            this.lstDsNgDung.TabIndex = 0;
            this.lstDsNgDung.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDsNgDung_MouseDoubleClick);
            this.lstDsNgDung.SelectedIndexChanged += new System.EventHandler(this.lstDsNgDung_SelectedIndexChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(459, 230);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(60, 22);
            this.buttonX1.TabIndex = 27;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // 
            // 
            this.txtHoten.Border.Class = "TextBoxBorder";
            this.txtHoten.Location = new System.Drawing.Point(168, 23);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(168, 20);
            this.txtHoten.TabIndex = 29;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(78, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 20);
            this.labelX1.TabIndex = 30;
            this.labelX1.Text = "Họ tên";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.txtTenDangNhap.Border.Class = "TextBoxBorder";
            this.txtTenDangNhap.Location = new System.Drawing.Point(168, 43);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(168, 20);
            this.txtTenDangNhap.TabIndex = 31;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(76, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(79, 18);
            this.labelX3.TabIndex = 33;
            this.labelX3.Text = "Tên đăng nhập";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.txtMatkhau.Border.Class = "TextBoxBorder";
            this.txtMatkhau.Location = new System.Drawing.Point(168, 63);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.ReadOnly = true;
            this.txtMatkhau.Size = new System.Drawing.Size(168, 20);
            this.txtMatkhau.TabIndex = 34;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(76, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(79, 20);
            this.labelX4.TabIndex = 36;
            this.labelX4.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttUpDate);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.cboNhom);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Location = new System.Drawing.Point(152, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 115);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cboNhom
            // 
            this.cboNhom.FormattingEnabled = true;
            this.cboNhom.Location = new System.Drawing.Point(168, 83);
            this.cboNhom.Name = "cboNhom";
            this.cboNhom.Size = new System.Drawing.Size(60, 21);
            this.cboNhom.TabIndex = 41;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(76, 84);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(79, 20);
            this.labelX2.TabIndex = 42;
            this.labelX2.Text = "Nhóm truy cập";
            // 
            // bttThem
            // 
            this.bttThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(393, 230);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(60, 22);
            this.bttThem.TabIndex = 28;
            this.bttThem.Text = "Thêm";
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDsNgDung);
            this.groupBox2.Location = new System.Drawing.Point(5, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 191);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Người dùng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bttUpDate
            // 
            this.bttUpDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttUpDate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bttUpDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconAlignment(this.bttUpDate, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.bttUpDate.Image = ((System.Drawing.Image)(resources.GetObject("bttUpDate.Image")));
            this.bttUpDate.Location = new System.Drawing.Point(234, 86);
            this.bttUpDate.Name = "bttUpDate";
            this.bttUpDate.Size = new System.Drawing.Size(32, 16);
            this.bttUpDate.TabIndex = 43;
            this.bttUpDate.Tooltip = "Cập nhật nhóm";
            this.bttUpDate.Click += new System.EventHandler(this.bttUpDate_Click);
            // 
            // Form_UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.buttonX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 296);
            this.Name = "Form_UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách người dùng";
            this.Load += new System.EventHandler(this.Form_UserList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstDsNgDung;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatkhau;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDangNhap;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNhom;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX bttThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.ButtonX bttUpDate;
    }
}