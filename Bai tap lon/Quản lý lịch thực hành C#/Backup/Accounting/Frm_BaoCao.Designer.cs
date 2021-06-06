namespace Accounting
{
    partial class Frm_BaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BaoCao));
            this.bttBaoCao = new System.Windows.Forms.Button();
            this.mtxtTuThang = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtDenthang = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttBaoCao
            // 
            this.bttBaoCao.Location = new System.Drawing.Point(112, 68);
            this.bttBaoCao.Name = "bttBaoCao";
            this.bttBaoCao.Size = new System.Drawing.Size(75, 23);
            this.bttBaoCao.TabIndex = 42;
            this.bttBaoCao.Text = "OK";
            this.bttBaoCao.UseVisualStyleBackColor = true;
            this.bttBaoCao.Click += new System.EventHandler(this.bttBaoCao_Click);
            // 
            // mtxtTuThang
            // 
            // 
            // 
            // 
            this.mtxtTuThang.BackgroundStyle.Class = "TextBoxBorder";
            this.mtxtTuThang.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtTuThang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtTuThang.Location = new System.Drawing.Point(50, 21);
            this.mtxtTuThang.Mask = "00/00/0000";
            this.mtxtTuThang.Name = "mtxtTuThang";
            this.mtxtTuThang.Size = new System.Drawing.Size(78, 20);
            this.mtxtTuThang.TabIndex = 41;
            this.mtxtTuThang.Text = "";
            this.mtxtTuThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtTuThang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtTuThang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtThang_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtDenthang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtTuThang);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 52);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // mtxtDenthang
            // 
            // 
            // 
            // 
            this.mtxtDenthang.BackgroundStyle.Class = "TextBoxBorder";
            this.mtxtDenthang.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtDenthang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtDenthang.Location = new System.Drawing.Point(198, 21);
            this.mtxtDenthang.Mask = "00/00/0000";
            this.mtxtDenthang.Name = "mtxtDenthang";
            this.mtxtDenthang.Size = new System.Drawing.Size(78, 20);
            this.mtxtDenthang.TabIndex = 43;
            this.mtxtDenthang.Text = "";
            this.mtxtDenthang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtDenthang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtDenthang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtDenthang_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Đến ngày";
            // 
            // Frm_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(291, 95);
            this.Controls.Add(this.bttBaoCao);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 117);
            this.Name = "Frm_BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo theo ngày";
            this.Activated += new System.EventHandler(this.Frm_BaoCao_Activated);
            this.Load += new System.EventHandler(this.Frm_BaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttBaoCao;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mtxtTuThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mtxtDenthang;




    }
}