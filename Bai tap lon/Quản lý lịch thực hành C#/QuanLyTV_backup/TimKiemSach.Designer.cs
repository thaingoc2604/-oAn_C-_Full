namespace QuanLyTV
{
    partial class TimKiemSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemSach));
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.listTenSach = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richViTri = new System.Windows.Forms.RichTextBox();
            this.listview = new System.Windows.Forms.ListView();
            this.columnHeader45 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader46 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader47 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader48 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGio = new System.Windows.Forms.Label();
            this.lalNgayGio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(13, 28);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(111, 20);
            this.txtTenSach.TabIndex = 0;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            this.txtTenSach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenSach_KeyUp);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(130, 25);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(40, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // listTenSach
            // 
            this.listTenSach.FormattingEnabled = true;
            this.listTenSach.Location = new System.Drawing.Point(12, 57);
            this.listTenSach.Name = "listTenSach";
            this.listTenSach.Size = new System.Drawing.Size(158, 342);
            this.listTenSach.TabIndex = 1;
            this.listTenSach.SelectedIndexChanged += new System.EventHandler(this.listTenSach_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richViTri);
            this.groupBox1.Controls.Add(this.listview);
            this.groupBox1.Location = new System.Drawing.Point(176, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 311);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin ";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(231, 145);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Sửa ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Vị trí hiện tại của quyển sách này (không tương đối)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // richViTri
            // 
            this.richViTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richViTri.Location = new System.Drawing.Point(9, 187);
            this.richViTri.Name = "richViTri";
            this.richViTri.ReadOnly = true;
            this.richViTri.Size = new System.Drawing.Size(300, 118);
            this.richViTri.TabIndex = 23;
            this.richViTri.Text = "";
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.listview.FullRowSelect = true;
            this.listview.Location = new System.Drawing.Point(6, 39);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(300, 100);
            this.listview.TabIndex = 22;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "Mã Sách";
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "Tên Sách";
            this.columnHeader46.Width = 59;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "Tác Giả";
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "Số Lượng";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nhà Xuất Bản";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Thể Loại";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Năm xuất Bản";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(416, 425);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cập Nhật Lại Danh Sách ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGio
            // 
            this.labelGio.AutoSize = true;
            this.labelGio.Location = new System.Drawing.Point(364, 386);
            this.labelGio.Name = "labelGio";
            this.labelGio.Size = new System.Drawing.Size(35, 13);
            this.labelGio.TabIndex = 28;
            this.labelGio.Text = "label2";
            // 
            // lalNgayGio
            // 
            this.lalNgayGio.AutoSize = true;
            this.lalNgayGio.Location = new System.Drawing.Point(176, 386);
            this.lalNgayGio.Name = "lalNgayGio";
            this.lalNgayGio.Size = new System.Drawing.Size(35, 13);
            this.lalNgayGio.TabIndex = 27;
            this.lalNgayGio.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 459);
            this.Controls.Add(this.labelGio);
            this.Controls.Add(this.lalNgayGio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.listTenSach);
            this.Controls.Add(this.txtTenSach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 497);
            this.MinimumSize = new System.Drawing.Size(510, 497);
            this.Name = "TimKiemSach";
            this.Text = "Tìm Sách Trong Thư Viện";
            this.Load += new System.EventHandler(this.TimKiemSach_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimKiemSach_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TimKiemSach_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListBox listTenSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richViTri;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGio;
        private System.Windows.Forms.Label lalNgayGio;
        private System.Windows.Forms.Timer timer1;
    }
}