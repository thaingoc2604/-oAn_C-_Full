namespace ManagementSASI
{
    partial class frmRestore
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
            this.txtPart = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectpart = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(10, 32);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(264, 20);
            this.txtPart.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(8, 72);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSelectpart
            // 
            this.btnSelectpart.Location = new System.Drawing.Point(284, 31);
            this.btnSelectpart.Name = "btnSelectpart";
            this.btnSelectpart.Size = new System.Drawing.Size(72, 23);
            this.btnSelectpart.TabIndex = 1;
            this.btnSelectpart.Text = "Chọn ";
            this.btnSelectpart.Click += new System.EventHandler(this.btnSelectpart_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtPart);
            this.groupControl1.Controls.Add(this.btnSelectpart);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 64);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn ổ để phục hồi dữ liệu";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(192, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Huỷ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 104);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Name = "frmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHỤC HỒI";
            ((System.ComponentModel.ISupportInitialize)(this.txtPart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPart;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnSelectpart;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}