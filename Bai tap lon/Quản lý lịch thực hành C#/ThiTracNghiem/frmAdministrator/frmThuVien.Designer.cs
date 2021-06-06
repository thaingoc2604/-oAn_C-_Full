namespace frmAdministrator
{
    partial class frmThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuVien));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReconnect = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnTaoDeThi = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.etsm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.etsm_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnin = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SaddleBrown;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(879, 379);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung";
            this.columnHeader2.Width = 284;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đáp án";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đáp án đúng";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mức độ";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tín chỉ";
            this.columnHeader6.Width = 136;
            // 
            // btnReconnect
            // 
            this.btnReconnect.Location = new System.Drawing.Point(11, 398);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(132, 27);
            this.btnReconnect.TabIndex = 16;
            this.btnReconnect.Text = "&Reconnect to Database";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            this.btnReconnect.MouseLeave += new System.EventHandler(this.btnReconnect_MouseLeave);
            this.btnReconnect.MouseHover += new System.EventHandler(this.btnReconnect_MouseHover);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Enabled = false;
            this.btnZoomOut.Location = new System.Drawing.Point(768, 398);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(59, 26);
            this.btnZoomOut.TabIndex = 14;
            this.btnZoomOut.Text = "&Zoom -";
            this.btnZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            this.btnZoomOut.MouseLeave += new System.EventHandler(this.btnZoomOut_MouseLeave);
            this.btnZoomOut.MouseHover += new System.EventHandler(this.btnZoomOut_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 398);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 27);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm &kiếm nâng cao";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(832, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 26);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Thoát ";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.ImageKey = "(none)";
            this.btnAdd.Location = new System.Drawing.Point(608, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 26);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "T&hêm câu hỏi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(703, 398);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(59, 26);
            this.btnZoomIn.TabIndex = 13;
            this.btnZoomIn.Text = "Z&oom +";
            this.btnZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            this.btnZoomIn.MouseLeave += new System.EventHandler(this.btnZoomIn_MouseLeave);
            this.btnZoomIn.MouseHover += new System.EventHandler(this.btnZoomIn_MouseHover);
            // 
            // btnTaoDeThi
            // 
            this.btnTaoDeThi.Enabled = false;
            this.btnTaoDeThi.Location = new System.Drawing.Point(271, 398);
            this.btnTaoDeThi.Name = "btnTaoDeThi";
            this.btnTaoDeThi.Size = new System.Drawing.Size(152, 27);
            this.btnTaoDeThi.TabIndex = 17;
            this.btnTaoDeThi.Text = "Thê&m những câu được chọn";
            this.btnTaoDeThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoDeThi.UseVisualStyleBackColor = true;
            this.btnTaoDeThi.Click += new System.EventHandler(this.btnTaoDeThi_Click);
            this.btnTaoDeThi.MouseLeave += new System.EventHandler(this.btnTaoDeThi_MouseLeave);
            this.btnTaoDeThi.MouseHover += new System.EventHandler(this.btnTaoDeThi_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etsm_Edit,
            this.toolStripSeparator1,
            this.etsm_Remove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 54);
            // 
            // etsm_Edit
            // 
            this.etsm_Edit.Name = "etsm_Edit";
            this.etsm_Edit.Size = new System.Drawing.Size(166, 22);
            this.etsm_Edit.Text = "&Xem + Chỉnh Sửa";
            this.etsm_Edit.Click += new System.EventHandler(this.etsm_Edit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // etsm_Remove
            // 
            this.etsm_Remove.Name = "etsm_Remove";
            this.etsm_Remove.Size = new System.Drawing.Size(166, 22);
            this.etsm_Remove.Text = "&Xóa Câu Hỏi Này";
            this.etsm_Remove.Click += new System.EventHandler(this.etsm_Remove_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(479, 399);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(123, 26);
            this.btnin.TabIndex = 18;
            this.btnin.Text = "In ngân hàng câu hỏi";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // frmThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(894, 432);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnReconnect);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnTaoDeThi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư Viện | Administrator";
            this.Load += new System.EventHandler(this.frmThuVien_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnTaoDeThi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etsm_Edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem etsm_Remove;
        private System.Windows.Forms.Button btnin;
    }
}