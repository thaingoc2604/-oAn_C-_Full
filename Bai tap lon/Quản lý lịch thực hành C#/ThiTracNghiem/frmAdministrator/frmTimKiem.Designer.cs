namespace frmAdministrator
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMucdo = new System.Windows.Forms.ComboBox();
            this.cbTinChi = new System.Windows.Forms.ComboBox();
            this.tbNoidung = new System.Windows.Forms.TextBox();
            this.cbDapandung = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cbMucdo);
            this.groupBox1.Controls.Add(this.cbTinChi);
            this.groupBox1.Controls.Add(this.tbNoidung);
            this.groupBox1.Controls.Add(this.cbDapandung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm tùy chọn";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(243, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(333, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // cbMucdo
            // 
            this.cbMucdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMucdo.FormattingEnabled = true;
            this.cbMucdo.Location = new System.Drawing.Point(101, 47);
            this.cbMucdo.Name = "cbMucdo";
            this.cbMucdo.Size = new System.Drawing.Size(289, 21);
            this.cbMucdo.TabIndex = 3;
            // 
            // cbTinChi
            // 
            this.cbTinChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinChi.FormattingEnabled = true;
            this.cbTinChi.Location = new System.Drawing.Point(101, 101);
            this.cbTinChi.MaxDropDownItems = 20;
            this.cbTinChi.Name = "cbTinChi";
            this.cbTinChi.Size = new System.Drawing.Size(289, 21);
            this.cbTinChi.TabIndex = 5;
            // 
            // tbNoidung
            // 
            this.tbNoidung.Location = new System.Drawing.Point(101, 20);
            this.tbNoidung.MaxLength = 40;
            this.tbNoidung.Name = "tbNoidung";
            this.tbNoidung.Size = new System.Drawing.Size(289, 20);
            this.tbNoidung.TabIndex = 0;
            // 
            // cbDapandung
            // 
            this.cbDapandung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDapandung.FormattingEnabled = true;
            this.cbDapandung.Location = new System.Drawing.Point(101, 74);
            this.cbDapandung.Name = "cbDapandung";
            this.cbDapandung.Size = new System.Drawing.Size(289, 21);
            this.cbDapandung.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mức độ\r\n\r\nĐáp án đúng\r\n\r\nTín chỉ";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(420, 180);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm | Addministrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiem_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbMucdo;
        private System.Windows.Forms.ComboBox cbTinChi;
        private System.Windows.Forms.TextBox tbNoidung;
        private System.Windows.Forms.ComboBox cbDapandung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}