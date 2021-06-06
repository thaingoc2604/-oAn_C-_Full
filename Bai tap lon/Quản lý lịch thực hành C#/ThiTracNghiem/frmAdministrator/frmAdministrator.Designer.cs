namespace frmAdministrator
{
    partial class frmAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrator));
            this.btnTacGia = new System.Windows.Forms.Button();
            this.btnTaoDe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThuVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTacGia
            // 
            this.btnTacGia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTacGia.BackgroundImage")));
            this.btnTacGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTacGia.Location = new System.Drawing.Point(377, 12);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(120, 90);
            this.btnTacGia.TabIndex = 0;
            this.btnTacGia.UseVisualStyleBackColor = true;
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            this.btnTacGia.MouseLeave += new System.EventHandler(this.btnTacGia_MouseLeave);
            this.btnTacGia.MouseHover += new System.EventHandler(this.btnTacGia_MouseHover);
            // 
            // btnTaoDe
            // 
            this.btnTaoDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoDe.BackgroundImage")));
            this.btnTaoDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaoDe.Location = new System.Drawing.Point(207, 9);
            this.btnTaoDe.Name = "btnTaoDe";
            this.btnTaoDe.Size = new System.Drawing.Size(120, 90);
            this.btnTaoDe.TabIndex = 0;
            this.btnTaoDe.UseVisualStyleBackColor = true;
            this.btnTaoDe.Click += new System.EventHandler(this.btnTaoDe_Click);
            this.btnTaoDe.MouseLeave += new System.EventHandler(this.btnTaoDe_MouseLeave);
            this.btnTaoDe.MouseHover += new System.EventHandler(this.btnTaoDe_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(452, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 63);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(37, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 63);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThuVien
            // 
            this.btnThuVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThuVien.BackgroundImage")));
            this.btnThuVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThuVien.Location = new System.Drawing.Point(31, 9);
            this.btnThuVien.Name = "btnThuVien";
            this.btnThuVien.Size = new System.Drawing.Size(120, 90);
            this.btnThuVien.TabIndex = 0;
            this.btnThuVien.UseVisualStyleBackColor = true;
            this.btnThuVien.Click += new System.EventHandler(this.btnThuVien_Click);
            this.btnThuVien.MouseLeave += new System.EventHandler(this.btnThuVien_MouseLeave);
            this.btnThuVien.MouseHover += new System.EventHandler(this.btnThuVien_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThuVien);
            this.panel1.Controls.Add(this.btnTaoDe);
            this.panel1.Controls.Add(this.btnTacGia);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 109);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(190, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 107);
            this.label1.TabIndex = 1;
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 265);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question | Administrator";
            this.Load += new System.EventHandler(this.frmAdministrator_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThuVien;
        private System.Windows.Forms.Button btnTacGia;
        private System.Windows.Forms.Button btnTaoDe;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

