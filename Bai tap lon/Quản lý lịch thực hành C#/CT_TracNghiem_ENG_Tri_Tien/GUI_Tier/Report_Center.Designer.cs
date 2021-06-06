namespace GUI_Tier
{
    partial class Report_Center
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
            this.btnInDiemSV = new System.Windows.Forms.Button();
            this.btnInDiemTatCa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenDangNhap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnInDiemSV
            // 
            this.btnInDiemSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInDiemSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDiemSV.ForeColor = System.Drawing.Color.Blue;
            this.btnInDiemSV.Location = new System.Drawing.Point(122, 72);
            this.btnInDiemSV.Name = "btnInDiemSV";
            this.btnInDiemSV.Size = new System.Drawing.Size(136, 46);
            this.btnInDiemSV.TabIndex = 1;
            this.btnInDiemSV.Text = "In Điểm SV";
            this.btnInDiemSV.UseVisualStyleBackColor = false;
            this.btnInDiemSV.Click += new System.EventHandler(this.btnInDiemSV_Click);
            // 
            // btnInDiemTatCa
            // 
            this.btnInDiemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInDiemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDiemTatCa.ForeColor = System.Drawing.Color.Blue;
            this.btnInDiemTatCa.Location = new System.Drawing.Point(264, 72);
            this.btnInDiemTatCa.Name = "btnInDiemTatCa";
            this.btnInDiemTatCa.Size = new System.Drawing.Size(152, 46);
            this.btnInDiemTatCa.TabIndex = 2;
            this.btnInDiemTatCa.Text = "In Điểm Tất Cả";
            this.btnInDiemTatCa.UseVisualStyleBackColor = false;
            this.btnInDiemTatCa.Click += new System.EventHandler(this.btnInDiemTatCa_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // cboTenDangNhap
            // 
            this.cboTenDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenDangNhap.FormattingEnabled = true;
            this.cboTenDangNhap.Location = new System.Drawing.Point(253, 15);
            this.cboTenDangNhap.Name = "cboTenDangNhap";
            this.cboTenDangNhap.Size = new System.Drawing.Size(190, 37);
            this.cboTenDangNhap.TabIndex = 0;
            // 
            // Report_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(504, 147);
            this.Controls.Add(this.cboTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInDiemTatCa);
            this.Controls.Add(this.btnInDiemSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report_Center";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Center";
            this.Load += new System.EventHandler(this.Report_Center_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInDiemSV;
        private System.Windows.Forms.Button btnInDiemTatCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTenDangNhap;
    }
}