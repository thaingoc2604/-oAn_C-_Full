namespace DETAI
{
    partial class frmtracuutrinhdo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbodmnn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbodmtd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbodmcm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdtim = new System.Windows.Forms.Button();
            this.cmdxemchitiet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbodmnn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbodmtd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbodmcm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // cbodmnn
            // 
            this.cbodmnn.FormattingEnabled = true;
            this.cbodmnn.Location = new System.Drawing.Point(188, 50);
            this.cbodmnn.Name = "cbodmnn";
            this.cbodmnn.Size = new System.Drawing.Size(140, 21);
            this.cbodmnn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngoại ngữ :";
            // 
            // cbodmtd
            // 
            this.cbodmtd.FormattingEnabled = true;
            this.cbodmtd.Location = new System.Drawing.Point(290, 23);
            this.cbodmtd.Name = "cbodmtd";
            this.cbodmtd.Size = new System.Drawing.Size(140, 21);
            this.cbodmtd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trình độ :";
            // 
            // cbodmcm
            // 
            this.cbodmcm.FormattingEnabled = true;
            this.cbodmcm.Location = new System.Drawing.Point(85, 23);
            this.cbodmcm.Name = "cbodmcm";
            this.cbodmcm.Size = new System.Drawing.Size(140, 21);
            this.cbodmcm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyên Môn :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 147);
            this.dataGridView1.TabIndex = 1;
            // 
            // cmdtim
            // 
            this.cmdtim.Location = new System.Drawing.Point(184, 122);
            this.cmdtim.Name = "cmdtim";
            this.cmdtim.Size = new System.Drawing.Size(91, 24);
            this.cmdtim.TabIndex = 5;
            this.cmdtim.Text = "Tìm kiếm";
            this.cmdtim.UseVisualStyleBackColor = true;
            // 
            // cmdxemchitiet
            // 
            this.cmdxemchitiet.Location = new System.Drawing.Point(184, 305);
            this.cmdxemchitiet.Name = "cmdxemchitiet";
            this.cmdxemchitiet.Size = new System.Drawing.Size(91, 24);
            this.cmdxemchitiet.TabIndex = 4;
            this.cmdxemchitiet.Text = "Xem Chi Tiết";
            this.cmdxemchitiet.UseVisualStyleBackColor = true;
            // 
            // frmtracuutrinhdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 335);
            this.Controls.Add(this.cmdtim);
            this.Controls.Add(this.cmdxemchitiet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtracuutrinhdo";
            this.Text = "frmtracuutrinhdo";
            this.Load += new System.EventHandler(this.frmtracuutrinhdo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbodmnn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbodmtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbodmcm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdtim;
        private System.Windows.Forms.Button cmdxemchitiet;
    }
}