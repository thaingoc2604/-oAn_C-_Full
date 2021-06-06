namespace frmAdministrator
{
    partial class frmTaoDeThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoDeThi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cms_listview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_removeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnin = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLuaTay = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cms_listview.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnin);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đề thi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(454, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm câu hỏi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuaTay);
            this.groupBox3.Controls.Add(this.btnImport);
            this.groupBox3.Location = new System.Drawing.Point(554, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 68);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm câu hỏi từ thư viện";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 400);
            this.tabControl1.TabIndex = 16;
            // 
            // cms_listview
            // 
            this.cms_listview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_edit,
            this.toolStripSeparator1,
            this.tsm_remove,
            this.tsm_removeAll});
            this.cms_listview.Name = "cms_listview";
            this.cms_listview.Size = new System.Drawing.Size(166, 76);
            this.cms_listview.Opening += new System.ComponentModel.CancelEventHandler(this.cms_listview_Opening);
            // 
            // tsm_edit
            // 
            this.tsm_edit.ForeColor = System.Drawing.Color.Blue;
            this.tsm_edit.Name = "tsm_edit";
            this.tsm_edit.Size = new System.Drawing.Size(165, 22);
            this.tsm_edit.Text = "Xem + &Chỉnh sửa";
            this.tsm_edit.Click += new System.EventHandler(this.tsm_edit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // tsm_remove
            // 
            this.tsm_remove.ForeColor = System.Drawing.Color.Red;
            this.tsm_remove.Name = "tsm_remove";
            this.tsm_remove.Size = new System.Drawing.Size(165, 22);
            this.tsm_remove.Text = "&Xóa";
            this.tsm_remove.Click += new System.EventHandler(this.tsm_remove_Click);
            // 
            // tsm_removeAll
            // 
            this.tsm_removeAll.ForeColor = System.Drawing.Color.Red;
            this.tsm_removeAll.Name = "tsm_removeAll";
            this.tsm_removeAll.Size = new System.Drawing.Size(165, 22);
            this.tsm_removeAll.Text = "Xóa tất &cả";
            this.tsm_removeAll.Click += new System.EventHandler(this.tsm_removeAll_Click);
            // 
            // btnin
            // 
            this.btnin.BackgroundImage = global::frmAdministrator.Properties.Resources.note_print2;
            this.btnin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnin.Location = new System.Drawing.Point(6, 14);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(69, 48);
            this.btnin.TabIndex = 12;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(148, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(69, 48);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            this.btnOpen.MouseLeave += new System.EventHandler(this.btnOpen_MouseLeave_1);
            this.btnOpen.MouseHover += new System.EventHandler(this.btnOpen_MouseHover_1);
            // 
            // btnTest
            // 
            this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTest.Location = new System.Drawing.Point(361, 14);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(69, 48);
            this.btnTest.TabIndex = 10;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            this.btnTest.MouseHover += new System.EventHandler(this.btnTest_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(219, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(290, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 48);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.AllowDrop = true;
            this.btnNew.AutoEllipsis = true;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Location = new System.Drawing.Point(77, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 48);
            this.btnNew.TabIndex = 2;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // btnLuaTay
            // 
            this.btnLuaTay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuaTay.BackgroundImage")));
            this.btnLuaTay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuaTay.Location = new System.Drawing.Point(88, 14);
            this.btnLuaTay.Name = "btnLuaTay";
            this.btnLuaTay.Size = new System.Drawing.Size(69, 48);
            this.btnLuaTay.TabIndex = 6;
            this.btnLuaTay.UseVisualStyleBackColor = true;
            this.btnLuaTay.Click += new System.EventHandler(this.btnLuaTay_Click);
            this.btnLuaTay.MouseLeave += new System.EventHandler(this.btnLuaTay_MouseLeave);
            this.btnLuaTay.MouseHover += new System.EventHandler(this.btnLuaTay_MouseHover);
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.Location = new System.Drawing.Point(11, 14);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(69, 48);
            this.btnImport.TabIndex = 5;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            this.btnImport.MouseLeave += new System.EventHandler(this.btnImport_MouseLeave);
            this.btnImport.MouseHover += new System.EventHandler(this.btnImport_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::frmAdministrator.Properties.Resources.addquestion;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(12, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 48);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // frmTaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(739, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Đề Thi | Administrator";
            this.Load += new System.EventHandler(this.frmTaoDeThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.cms_listview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuaTay;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip cms_listview;
        private System.Windows.Forms.ToolStripMenuItem tsm_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsm_remove;
        private System.Windows.Forms.ToolStripMenuItem tsm_removeAll;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnin;
    }
}