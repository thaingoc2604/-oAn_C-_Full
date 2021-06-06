namespace Thibanglai_UI
{
    partial class frmdangnhap
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
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_dn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_pa = new System.Windows.Forms.TextBox();
            this.textBox_dn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_thisinh = new System.Windows.Forms.RadioButton();
            this.radioButton_quanli = new System.Windows.Forms.RadioButton();
            this.button_dk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_thoat
            // 
            this.button_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.Location = new System.Drawing.Point(395, 284);
            this.button_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(105, 29);
            this.button_thoat.TabIndex = 22;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_dn
            // 
            this.button_dn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dn.Location = new System.Drawing.Point(274, 284);
            this.button_dn.Margin = new System.Windows.Forms.Padding(4);
            this.button_dn.Name = "button_dn";
            this.button_dn.Size = new System.Drawing.Size(113, 29);
            this.button_dn.TabIndex = 21;
            this.button_dn.Text = "Đăng nhập";
            this.button_dn.UseVisualStyleBackColor = true;
            this.button_dn.Click += new System.EventHandler(this.button_dn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox_pa);
            this.groupBox1.Controls.Add(this.textBox_dn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 152);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thí sinh";
            // 
            // textBox_pa
            // 
            this.textBox_pa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pa.Location = new System.Drawing.Point(171, 108);
            this.textBox_pa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pa.Name = "textBox_pa";
            this.textBox_pa.PasswordChar = '*';
            this.textBox_pa.Size = new System.Drawing.Size(282, 25);
            this.textBox_pa.TabIndex = 1;
            // 
            // textBox_dn
            // 
            this.textBox_dn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dn.Location = new System.Drawing.Point(171, 48);
            this.textBox_dn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dn.Name = "textBox_dn";
            this.textBox_dn.Size = new System.Drawing.Size(282, 25);
            this.textBox_dn.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thí sinh:";
            // 
            // radioButton_thisinh
            // 
            this.radioButton_thisinh.AutoSize = true;
            this.radioButton_thisinh.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_thisinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_thisinh.Location = new System.Drawing.Point(15, 38);
            this.radioButton_thisinh.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_thisinh.Name = "radioButton_thisinh";
            this.radioButton_thisinh.Size = new System.Drawing.Size(181, 21);
            this.radioButton_thisinh.TabIndex = 23;
            this.radioButton_thisinh.TabStop = true;
            this.radioButton_thisinh.Text = "Đăng nhập thi trắc nghiệm";
            this.radioButton_thisinh.UseVisualStyleBackColor = false;
            this.radioButton_thisinh.CheckedChanged += new System.EventHandler(this.radioButton_thisinh_CheckedChanged);
            // 
            // radioButton_quanli
            // 
            this.radioButton_quanli.AutoSize = true;
            this.radioButton_quanli.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_quanli.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_quanli.Location = new System.Drawing.Point(321, 38);
            this.radioButton_quanli.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_quanli.Name = "radioButton_quanli";
            this.radioButton_quanli.Size = new System.Drawing.Size(175, 21);
            this.radioButton_quanli.TabIndex = 24;
            this.radioButton_quanli.TabStop = true;
            this.radioButton_quanli.Text = "Đăng nhập quyền quản lý";
            this.radioButton_quanli.UseVisualStyleBackColor = false;
            this.radioButton_quanli.CheckedChanged += new System.EventHandler(this.radioButton_quanli_CheckedChanged);
            // 
            // button_dk
            // 
            this.button_dk.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dk.Location = new System.Drawing.Point(157, 284);
            this.button_dk.Margin = new System.Windows.Forms.Padding(4);
            this.button_dk.Name = "button_dk";
            this.button_dk.Size = new System.Drawing.Size(109, 29);
            this.button_dk.TabIndex = 20;
            this.button_dk.Text = "Đăng kí";
            this.button_dk.UseVisualStyleBackColor = true;
            this.button_dk.Click += new System.EventHandler(this.button_dk_Click);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Thibanglai_UI.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(516, 330);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_dn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton_thisinh);
            this.Controls.Add(this.radioButton_quanli);
            this.Controls.Add(this.button_dk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_dn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pa;
        private System.Windows.Forms.TextBox textBox_dn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_thisinh;
        private System.Windows.Forms.RadioButton radioButton_quanli;
        private System.Windows.Forms.Button button_dk;
    }
}