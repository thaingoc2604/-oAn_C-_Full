namespace GUI_Tier
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMauKhauMoi = new System.Windows.Forms.TextBox();
            this.picHuy = new System.Windows.Forms.PictureBox();
            this.picDongY = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDongY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(28, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "English Test";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đổi mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMauKhauMoi
            // 
            this.txtMauKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauKhauMoi.Location = new System.Drawing.Point(159, 87);
            this.txtMauKhauMoi.MaxLength = 32;
            this.txtMauKhauMoi.Name = "txtMauKhauMoi";
            this.txtMauKhauMoi.Size = new System.Drawing.Size(227, 26);
            this.txtMauKhauMoi.TabIndex = 0;
            this.txtMauKhauMoi.UseSystemPasswordChar = true;
            this.txtMauKhauMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauCu_KeyDown);
            // 
            // picHuy
            // 
            this.picHuy.BackColor = System.Drawing.Color.Transparent;
            this.picHuy.Image = ((System.Drawing.Image)(resources.GetObject("picHuy.Image")));
            this.picHuy.Location = new System.Drawing.Point(356, 168);
            this.picHuy.Name = "picHuy";
            this.picHuy.Size = new System.Drawing.Size(30, 28);
            this.picHuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHuy.TabIndex = 5;
            this.picHuy.TabStop = false;
            this.picHuy.Click += new System.EventHandler(this.picHuy_Click);
            // 
            // picDongY
            // 
            this.picDongY.BackColor = System.Drawing.Color.Transparent;
            this.picDongY.Image = ((System.Drawing.Image)(resources.GetObject("picDongY.Image")));
            this.picDongY.Location = new System.Drawing.Point(307, 168);
            this.picDongY.Name = "picDongY";
            this.picDongY.Size = new System.Drawing.Size(30, 28);
            this.picDongY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDongY.TabIndex = 4;
            this.picDongY.TabStop = false;
            this.picDongY.Click += new System.EventHandler(this.picDongY_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(50, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xác Nhận :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhan.Location = new System.Drawing.Point(159, 125);
            this.txtXacNhan.MaxLength = 32;
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(227, 26);
            this.txtXacNhan.TabIndex = 1;
            this.txtXacNhan.UseSystemPasswordChar = true;
            this.txtXacNhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauCu_KeyDown);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(17, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu cũ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(159, 48);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(227, 26);
            this.txtMatKhauCu.TabIndex = 0;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.txtMatKhauCu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauCu_KeyDown);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(424, 208);
            this.ControlBox = false;
            this.Controls.Add(this.picHuy);
            this.Controls.Add(this.picDongY);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtMauKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu cá nhân";
            ((System.ComponentModel.ISupportInitialize)(this.picHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDongY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMauKhauMoi;
        private System.Windows.Forms.PictureBox picHuy;
        private System.Windows.Forms.PictureBox picDongY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatKhauCu;
    }
}