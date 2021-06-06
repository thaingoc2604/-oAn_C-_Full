namespace Thibanglai_UI
{
    partial class frmxoanv
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
            this.button_xoa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_dt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_dc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_hoten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(533, 169);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(117, 26);
            this.button_xoa.TabIndex = 45;
            this.button_xoa.Text = "Xóa nhân viên";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(332, 114);
            this.label9.TabIndex = 44;
            this.label9.Text = "Lưu ý:  Nếu nhân viên bị xóa thì :\r\n\r\n          - Thông tin của nhân viên sẽ bị x" +
                "óa.\r\n          - Tài khoản đăng nhập của nhân viên sẽ bị xóa.\r\n          \r\n\r\n";
            // 
            // textBox_dt
            // 
            this.textBox_dt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dt.Location = new System.Drawing.Point(109, 83);
            this.textBox_dt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dt.Name = "textBox_dt";
            this.textBox_dt.Size = new System.Drawing.Size(199, 26);
            this.textBox_dt.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Điện thoại:";
            // 
            // textBox_dc
            // 
            this.textBox_dc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dc.Location = new System.Drawing.Point(419, 49);
            this.textBox_dc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dc.Name = "textBox_dc";
            this.textBox_dc.Size = new System.Drawing.Size(231, 26);
            this.textBox_dc.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Địa chỉ:";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ma.Location = new System.Drawing.Point(109, 49);
            this.textBox_ma.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(199, 26);
            this.textBox_ma.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã nhân viên:";
            // 
            // textBox_cv
            // 
            this.textBox_cv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cv.Location = new System.Drawing.Point(514, 15);
            this.textBox_cv.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cv.Name = "textBox_cv";
            this.textBox_cv.Size = new System.Drawing.Size(136, 26);
            this.textBox_cv.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Chức vụ:";
            // 
            // comboBox_hoten
            // 
            this.comboBox_hoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_hoten.FormattingEnabled = true;
            this.comboBox_hoten.Location = new System.Drawing.Point(109, 14);
            this.comboBox_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_hoten.Name = "comboBox_hoten";
            this.comboBox_hoten.Size = new System.Drawing.Size(306, 27);
            this.comboBox_hoten.TabIndex = 35;
            this.comboBox_hoten.SelectedIndexChanged += new System.EventHandler(this.comboBox_hoten_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên nhân viên:";
            // 
            // frmxoanv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thibanglai_UI.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(662, 211);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_dt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_dc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_hoten);
            this.Controls.Add(this.label1);
            this.Name = "frmxoanv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa nhân viên";
            this.Load += new System.EventHandler(this.frmxoanv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_dt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_dc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_hoten;
        private System.Windows.Forms.Label label1;
    }
}