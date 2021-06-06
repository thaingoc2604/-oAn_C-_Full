namespace DETAI
{
    partial class frmchonbcnv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchonbcnv));
            this.tabbcchung = new System.Windows.Forms.TabControl();
            this.tabbcluong = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboto = new System.Windows.Forms.ComboBox();
            this.cbophong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdin = new System.Windows.Forms.Button();
            this.tabbcchung.SuspendLayout();
            this.tabbcluong.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabbcchung
            // 
            this.tabbcchung.Controls.Add(this.tabbcluong);
            this.tabbcchung.Location = new System.Drawing.Point(3, 5);
            this.tabbcchung.Name = "tabbcchung";
            this.tabbcchung.SelectedIndex = 0;
            this.tabbcchung.Size = new System.Drawing.Size(254, 148);
            this.tabbcchung.TabIndex = 2;
            // 
            // tabbcluong
            // 
            this.tabbcluong.Controls.Add(this.panel2);
            this.tabbcluong.Location = new System.Drawing.Point(4, 22);
            this.tabbcluong.Name = "tabbcluong";
            this.tabbcluong.Padding = new System.Windows.Forms.Padding(3);
            this.tabbcluong.Size = new System.Drawing.Size(246, 122);
            this.tabbcluong.TabIndex = 0;
            this.tabbcluong.Text = "Danh Sách NV";
            this.tabbcluong.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.cboto);
            this.panel2.Controls.Add(this.cbophong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmdin);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 112);
            this.panel2.TabIndex = 5;
            // 
            // cboto
            // 
            this.cboto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboto.FormattingEnabled = true;
            this.cboto.Location = new System.Drawing.Point(67, 46);
            this.cboto.Name = "cboto";
            this.cboto.Size = new System.Drawing.Size(158, 21);
            this.cboto.TabIndex = 36;
            // 
            // cbophong
            // 
            this.cbophong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbophong.FormattingEnabled = true;
            this.cbophong.Location = new System.Drawing.Point(67, 18);
            this.cbophong.Name = "cbophong";
            this.cbophong.Size = new System.Drawing.Size(158, 21);
            this.cbophong.TabIndex = 35;
            this.cbophong.SelectedIndexChanged += new System.EventHandler(this.cbophong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tổ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phòng :";
            // 
            // cmdin
            // 
            this.cmdin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdin.Image = ((System.Drawing.Image)(resources.GetObject("cmdin.Image")));
            this.cmdin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdin.Location = new System.Drawing.Point(73, 73);
            this.cmdin.Name = "cmdin";
            this.cmdin.Size = new System.Drawing.Size(93, 30);
            this.cmdin.TabIndex = 8;
            this.cmdin.Tag = "";
            this.cmdin.Text = "In";
            this.cmdin.UseVisualStyleBackColor = false;
            this.cmdin.Click += new System.EventHandler(this.cmdin_Click);
            // 
            // frmchonbcnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(260, 158);
            this.Controls.Add(this.tabbcchung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmchonbcnv";
            this.Text = "Báo cáo nhân sự";
            this.Load += new System.EventHandler(this.frmchonbcnv_Load);
            this.tabbcchung.ResumeLayout(false);
            this.tabbcluong.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabbcchung;
        private System.Windows.Forms.TabPage tabbcluong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboto;
        private System.Windows.Forms.ComboBox cbophong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdin;
    }
}