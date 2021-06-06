namespace Accounting
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtMaKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtmaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CauHinhHeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(188, 97);
            this.buttonX3.MaximumSize = new System.Drawing.Size(66, 22);
            this.buttonX3.MinimumSize = new System.Drawing.Size(66, 22);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(66, 22);
            this.buttonX3.TabIndex = 35;
            this.buttonX3.Text = "Đăng nhập";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(17, 52);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(79, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Mật Khẩu";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(26, 49);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 23);
            this.labelX2.TabIndex = 27;
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtMaKhau
            // 
            // 
            // 
            // 
            this.txtMaKhau.Border.Class = "TextBoxBorder";
            this.txtMaKhau.Location = new System.Drawing.Point(102, 52);
            this.txtMaKhau.Name = "txtMaKhau";
            this.txtMaKhau.PasswordChar = '*';
            this.txtMaKhau.Size = new System.Drawing.Size(113, 20);
            this.txtMaKhau.TabIndex = 26;
            this.txtMaKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKhau_KeyDown);
            this.txtMaKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhau_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(17, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "Mã Nhân Viên";
            // 
            // txtmaNV
            // 
            // 
            // 
            // 
            this.txtmaNV.Border.Class = "TextBoxBorder";
            this.txtmaNV.Location = new System.Drawing.Point(103, 23);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(112, 20);
            this.txtmaNV.TabIndex = 24;
            this.txtmaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmaNV_KeyDown);
            this.txtmaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaNV_KeyPress);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(260, 97);
            this.buttonX1.MaximumSize = new System.Drawing.Size(66, 22);
            this.buttonX1.MinimumSize = new System.Drawing.Size(66, 22);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(66, 22);
            this.buttonX1.TabIndex = 36;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKhau);
            this.groupBox1.Controls.Add(this.txtmaNV);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Location = new System.Drawing.Point(70, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 83);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CauHinhHeThongToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 26);
            // 
            // CauHinhHeThongToolStripMenuItem
            // 
            this.CauHinhHeThongToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CauHinhHeThongToolStripMenuItem.Image")));
            this.CauHinhHeThongToolStripMenuItem.Name = "CauHinhHeThongToolStripMenuItem";
            this.CauHinhHeThongToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CauHinhHeThongToolStripMenuItem.Text = "Cấu hình hệ thống";
            this.CauHinhHeThongToolStripMenuItem.Click += new System.EventHandler(this.CauHinhHeThongToolStripMenuItem_Click);
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 129);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonX3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 161);
            this.MinimumSize = new System.Drawing.Size(335, 161);
            this.Name = "Frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vào hệ thống";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Frm_DangNhap_MouseClick);
            this.Activated += new System.EventHandler(this.Frm_DangNhap_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKhau;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmaNV;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CauHinhHeThongToolStripMenuItem;
    }
}