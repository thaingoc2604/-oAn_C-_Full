namespace EventManager.Presentation
{
    partial class frmThemChuongTrinh
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
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenCT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCT = new DevExpress.XtraEditors.TextEdit();
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKH = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.EnterMoveNextControl = true;
            this.txtMoTa.Location = new System.Drawing.Point(268, 96);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Properties.MaxLength = 100;
            this.txtMoTa.Size = new System.Drawing.Size(733, 24);
            this.txtMoTa.TabIndex = 56;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(144, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 18);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Mô tả:";
            // 
            // txtTenCT
            // 
            this.txtTenCT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenCT.EnterMoveNextControl = true;
            this.txtTenCT.Location = new System.Drawing.Point(268, 58);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenCT.Properties.Appearance.Options.UseFont = true;
            this.txtTenCT.Properties.MaxLength = 50;
            this.txtTenCT.Size = new System.Drawing.Size(498, 24);
            this.txtTenCT.TabIndex = 55;
            // 
            // txtMaCT
            // 
            this.txtMaCT.EnterMoveNextControl = true;
            this.txtMaCT.Location = new System.Drawing.Point(268, 20);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaCT.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaCT.Properties.Appearance.Options.UseFont = true;
            this.txtMaCT.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaCT.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaCT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaCT.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaCT.Properties.MaxLength = 5;
            this.txtMaCT.Properties.ReadOnly = true;
            this.txtMaCT.Size = new System.Drawing.Size(127, 24);
            this.txtMaCT.TabIndex = 60;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTenKH.Location = new System.Drawing.Point(144, 61);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 18);
            this.lblTenKH.TabIndex = 61;
            this.lblTenKH.Text = "Tên chương trình:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMaKH.Location = new System.Drawing.Point(144, 23);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(111, 18);
            this.lblMaKH.TabIndex = 62;
            this.lblMaKH.Text = "Mã chương trình:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::EventManager.Properties.Resources.cancel__1_;
            this.btnHuy.Location = new System.Drawing.Point(426, 131);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 43);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::EventManager.Properties.Resources.Save__1_;
            this.btnLuu.Location = new System.Drawing.Point(268, 131);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 43);
            this.btnLuu.TabIndex = 57;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::EventManager.Properties.Resources.services;
            this.reflectionImage1.Location = new System.Drawing.Point(-4, -26);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 263);
            this.reflectionImage1.TabIndex = 59;
            // 
            // frmThemChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 190);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTenCT);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.reflectionImage1);
            this.Name = "frmThemChuongTrinh";
            this.Text = "frmThemChuongTrinh";
            this.Load += new System.EventHandler(this.frmThemChuongTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenCT;
        private DevExpress.XtraEditors.TextEdit txtMaCT;
        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl lblMaKH;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
    }
}