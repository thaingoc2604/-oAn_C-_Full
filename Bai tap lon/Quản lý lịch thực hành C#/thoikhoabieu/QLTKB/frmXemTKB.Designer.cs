namespace QLTKB
{
    partial class frmXemTKB
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btntk = new System.Windows.Forms.Button();
            this.msds = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btntk);
            this.panel2.Controls.Add(this.txtdn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txttn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 48);
            this.panel2.TabIndex = 6;
            // 
            // txttn
            // 
            this.txttn.CustomFormat = "MM/dd/yyyy";
            this.txttn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txttn.Location = new System.Drawing.Point(175, 12);
            this.txttn.Name = "txttn";
            this.txttn.Size = new System.Drawing.Size(200, 27);
            this.txttn.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Xem Từ Ngày";
            // 
            // txtdn
            // 
            this.txtdn.CustomFormat = "MM/dd/yyyy";
            this.txtdn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdn.Location = new System.Drawing.Point(492, 12);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(200, 27);
            this.txtdn.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đến Ngày";
            // 
            // btntk
            // 
            this.btntk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btntk.Location = new System.Drawing.Point(706, 0);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 48);
            this.btntk.TabIndex = 15;
            this.btntk.Text = "Xem";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // msds
            // 
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.Location = new System.Drawing.Point(0, 48);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(781, 335);
            this.msds.TabIndex = 9;
            // 
            // frmXemTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 383);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXemTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Thời Khóa Biểu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.DateTimePicker txtdn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView msds;
    }
}