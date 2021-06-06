namespace GUI_Tier
{
    partial class Teacher_BoDe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_BoDe));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaDe = new System.Windows.Forms.ComboBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXoaCacItemBoDe = new System.Windows.Forms.Button();
            this.btnXoaDe = new System.Windows.Forms.Button();
            this.btnTaoDe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lvwDe_CauHoi = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwToanBoCauHoi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSangPhai = new System.Windows.Forms.Button();
            this.btnSangTrai = new System.Windows.Forms.Button();
            this.lblSoCauHoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(481, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Danh sách câu hỏi bộ đề:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Danh sách các câu hỏi :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboMaDe);
            this.groupBox1.Controls.Add(this.btnTroVe);
            this.groupBox1.Controls.Add(this.btnXoaCacItemBoDe);
            this.groupBox1.Controls.Add(this.btnXoaDe);
            this.groupBox1.Controls.Add(this.btnTaoDe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(203, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đề";
            // 
            // cboMaDe
            // 
            this.cboMaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaDe.ForeColor = System.Drawing.Color.Red;
            this.cboMaDe.FormattingEnabled = true;
            this.cboMaDe.Location = new System.Drawing.Point(6, 52);
            this.cboMaDe.Name = "cboMaDe";
            this.cboMaDe.Size = new System.Drawing.Size(157, 45);
            this.cboMaDe.TabIndex = 15;
            this.cboMaDe.SelectedIndexChanged += new System.EventHandler(this.cboMaDe_SelectedIndexChanged);
            this.cboMaDe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboMaDe_KeyDown);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTroVe.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.Image")));
            this.btnTroVe.Location = new System.Drawing.Point(416, 32);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 65);
            this.btnTroVe.TabIndex = 4;
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnXoaCacItemBoDe
            // 
            this.btnXoaCacItemBoDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCacItemBoDe.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoaCacItemBoDe.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCacItemBoDe.Image")));
            this.btnXoaCacItemBoDe.Location = new System.Drawing.Point(329, 32);
            this.btnXoaCacItemBoDe.Name = "btnXoaCacItemBoDe";
            this.btnXoaCacItemBoDe.Size = new System.Drawing.Size(81, 65);
            this.btnXoaCacItemBoDe.TabIndex = 4;
            this.btnXoaCacItemBoDe.UseVisualStyleBackColor = true;
            this.btnXoaCacItemBoDe.Click += new System.EventHandler(this.btnXoaCacItemBoDe_Click);
            // 
            // btnXoaDe
            // 
            this.btnXoaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDe.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoaDe.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDe.Image")));
            this.btnXoaDe.Location = new System.Drawing.Point(248, 32);
            this.btnXoaDe.Name = "btnXoaDe";
            this.btnXoaDe.Size = new System.Drawing.Size(75, 65);
            this.btnXoaDe.TabIndex = 4;
            this.btnXoaDe.UseVisualStyleBackColor = true;
            this.btnXoaDe.Click += new System.EventHandler(this.btnXoaDe_Click);
            // 
            // btnTaoDe
            // 
            this.btnTaoDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDe.ForeColor = System.Drawing.Color.Green;
            this.btnTaoDe.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoDe.Image")));
            this.btnTaoDe.Location = new System.Drawing.Point(167, 32);
            this.btnTaoDe.Name = "btnTaoDe";
            this.btnTaoDe.Size = new System.Drawing.Size(75, 65);
            this.btnTaoDe.TabIndex = 4;
            this.btnTaoDe.UseVisualStyleBackColor = true;
            this.btnTaoDe.Click += new System.EventHandler(this.btnTaoDe_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã đề :";
            // 
            // lvwDe_CauHoi
            // 
            this.lvwDe_CauHoi.BackColor = System.Drawing.Color.White;
            this.lvwDe_CauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwDe_CauHoi.ForeColor = System.Drawing.Color.Black;
            this.lvwDe_CauHoi.FullRowSelect = true;
            this.lvwDe_CauHoi.GridLines = true;
            this.lvwDe_CauHoi.Location = new System.Drawing.Point(484, 159);
            this.lvwDe_CauHoi.Name = "lvwDe_CauHoi";
            this.lvwDe_CauHoi.Size = new System.Drawing.Size(362, 319);
            this.lvwDe_CauHoi.TabIndex = 7;
            this.lvwDe_CauHoi.UseCompatibleStateImageBehavior = false;
            this.lvwDe_CauHoi.View = System.Windows.Forms.View.Details;
            this.lvwDe_CauHoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwDe_CauHoi_KeyDown);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã câu hỏi";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nội dung câu hỏi";
            this.columnHeader6.Width = 306;
            // 
            // lvwToanBoCauHoi
            // 
            this.lvwToanBoCauHoi.BackColor = System.Drawing.Color.White;
            this.lvwToanBoCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwToanBoCauHoi.ForeColor = System.Drawing.Color.Black;
            this.lvwToanBoCauHoi.FullRowSelect = true;
            this.lvwToanBoCauHoi.GridLines = true;
            this.lvwToanBoCauHoi.Location = new System.Drawing.Point(12, 159);
            this.lvwToanBoCauHoi.Name = "lvwToanBoCauHoi";
            this.lvwToanBoCauHoi.Size = new System.Drawing.Size(362, 319);
            this.lvwToanBoCauHoi.TabIndex = 8;
            this.lvwToanBoCauHoi.UseCompatibleStateImageBehavior = false;
            this.lvwToanBoCauHoi.View = System.Windows.Forms.View.Details;
            this.lvwToanBoCauHoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwToanBoCauHoi_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã câu hỏi";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung câu hỏi";
            this.columnHeader2.Width = 306;
            // 
            // btnSangPhai
            // 
            this.btnSangPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSangPhai.Image = ((System.Drawing.Image)(resources.GetObject("btnSangPhai.Image")));
            this.btnSangPhai.Location = new System.Drawing.Point(392, 253);
            this.btnSangPhai.Name = "btnSangPhai";
            this.btnSangPhai.Size = new System.Drawing.Size(75, 64);
            this.btnSangPhai.TabIndex = 12;
            this.btnSangPhai.UseVisualStyleBackColor = true;
            this.btnSangPhai.Click += new System.EventHandler(this.btnSangPhai_Click);
            // 
            // btnSangTrai
            // 
            this.btnSangTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSangTrai.Image = ((System.Drawing.Image)(resources.GetObject("btnSangTrai.Image")));
            this.btnSangTrai.Location = new System.Drawing.Point(392, 317);
            this.btnSangTrai.Name = "btnSangTrai";
            this.btnSangTrai.Size = new System.Drawing.Size(75, 64);
            this.btnSangTrai.TabIndex = 12;
            this.btnSangTrai.UseVisualStyleBackColor = true;
            this.btnSangTrai.Click += new System.EventHandler(this.btnSangTrai_Click);
            // 
            // lblSoCauHoi
            // 
            this.lblSoCauHoi.AutoSize = true;
            this.lblSoCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauHoi.ForeColor = System.Drawing.Color.Red;
            this.lblSoCauHoi.Location = new System.Drawing.Point(609, 135);
            this.lblSoCauHoi.Name = "lblSoCauHoi";
            this.lblSoCauHoi.Size = new System.Drawing.Size(0, 20);
            this.lblSoCauHoi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(615, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "23.png");
            this.imageList1.Images.SetKeyName(1, "28.png");
            this.imageList1.Images.SetKeyName(2, "38.png");
            this.imageList1.Images.SetKeyName(3, "112.png");
            this.imageList1.Images.SetKeyName(4, "118.png");
            this.imageList1.Images.SetKeyName(5, "Back.png");
            // 
            // Teacher_BoDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(851, 486);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSoCauHoi);
            this.Controls.Add(this.btnSangTrai);
            this.Controls.Add(this.btnSangPhai);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwDe_CauHoi);
            this.Controls.Add(this.lvwToanBoCauHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teacher_BoDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo viên - Soạn đề";
            this.Load += new System.EventHandler(this.Teacher_BoDe_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoDe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvwDe_CauHoi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvwToanBoCauHoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnSangPhai;
        private System.Windows.Forms.Button btnSangTrai;
        private System.Windows.Forms.Label lblSoCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaDe;
        private System.Windows.Forms.Button btnXoaDe;
        private System.Windows.Forms.Button btnXoaCacItemBoDe;
        private System.Windows.Forms.ImageList imageList1;
    }
}