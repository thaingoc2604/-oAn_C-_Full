namespace Accounting
{
    partial class Frm_ImportChungTuThuChi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImportChungTuThuChi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngaythang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEUTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEUCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENGIAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIENTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIENCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAIPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngaythang,
            this.MAPHIEUTHU,
            this.MAPHIEUCHI,
            this.DIENGIAI,
            this.SOTIENTHU,
            this.SOTIENCHI,
            this.SOTON,
            this.MALOAIPHIEU});
            this.dataGridView1.Location = new System.Drawing.Point(2, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 305);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPath.Location = new System.Drawing.Point(14, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(237, 24);
            this.txtPath.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(258, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 71);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Sè Liªu";
            // 
            // ngaythang
            // 
            this.ngaythang.DataPropertyName = "Ngaythang";
            this.ngaythang.HeaderText = "Ngày Tháng";
            this.ngaythang.Name = "ngaythang";
            // 
            // MAPHIEUTHU
            // 
            this.MAPHIEUTHU.DataPropertyName = "MaPhieuThu";
            this.MAPHIEUTHU.HeaderText = "Mã P.Thu";
            this.MAPHIEUTHU.Name = "MAPHIEUTHU";
            // 
            // MAPHIEUCHI
            // 
            this.MAPHIEUCHI.DataPropertyName = "MAPHIEUCHI";
            this.MAPHIEUCHI.HeaderText = "Mã P.Chi";
            this.MAPHIEUCHI.Name = "MAPHIEUCHI";
            // 
            // DIENGIAI
            // 
            this.DIENGIAI.DataPropertyName = "DIENGIAI";
            dataGridViewCellStyle1.Font = new System.Drawing.Font(".VnTime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIENGIAI.DefaultCellStyle = dataGridViewCellStyle1;
            this.DIENGIAI.HeaderText = "Diễn giải";
            this.DIENGIAI.Name = "DIENGIAI";
            this.DIENGIAI.Width = 400;
            // 
            // SOTIENTHU
            // 
            this.SOTIENTHU.DataPropertyName = "SOTIENTHU";
            this.SOTIENTHU.HeaderText = "Số tiền thu";
            this.SOTIENTHU.Name = "SOTIENTHU";
            // 
            // SOTIENCHI
            // 
            this.SOTIENCHI.DataPropertyName = "SOTIENCHI";
            this.SOTIENCHI.HeaderText = "Số Tiền Chi";
            this.SOTIENCHI.Name = "SOTIENCHI";
            // 
            // SOTON
            // 
            this.SOTON.DataPropertyName = "SOTON";
            this.SOTON.HeaderText = "Số Tồn";
            this.SOTON.Name = "SOTON";
            // 
            // MALOAIPHIEU
            // 
            this.MALOAIPHIEU.DataPropertyName = "MALOAIPHIEU";
            this.MALOAIPHIEU.HeaderText = "Mã Loại Phiếu";
            this.MALOAIPHIEU.Name = "MALOAIPHIEU";
            this.MALOAIPHIEU.Visible = false;
            // 
            // FrmImportChungTuThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(949, 443);
            this.MinimumSize = new System.Drawing.Size(949, 443);
            this.Name = "FrmImportChungTuThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENGIAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIENTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIENCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIPHIEU;
    }
}