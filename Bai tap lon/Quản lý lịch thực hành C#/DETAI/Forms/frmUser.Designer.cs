namespace DETAI
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.cmdluu = new System.Windows.Forms.Button();
            this.cmdthem = new System.Windows.Forms.Button();
            this.cmdCapnhat = new System.Windows.Forms.Button();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbogroup = new System.Windows.Forms.ComboBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.cmdthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.grpbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.Pass,
            this.Group});
            this.dgvUser.Location = new System.Drawing.Point(5, 106);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(294, 123);
            this.dgvUser.TabIndex = 3;
            // 
            // username
            // 
            this.username.DataPropertyName = "id";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.Width = 80;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "pass";
            dataGridViewCellStyle1.NullValue = null;
            this.Pass.DefaultCellStyle = dataGridViewCellStyle1;
            this.Pass.HeaderText = "Pass";
            this.Pass.Name = "Pass";
            // 
            // Group
            // 
            this.Group.DataPropertyName = "nhom";
            this.Group.HeaderText = "Nhóm";
            this.Group.Name = "Group";
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.cmdthoat);
            this.grpbox.Controls.Add(this.cmdluu);
            this.grpbox.Controls.Add(this.cmdthem);
            this.grpbox.Controls.Add(this.cmdCapnhat);
            this.grpbox.Controls.Add(this.cmdxoa);
            this.grpbox.Location = new System.Drawing.Point(305, 5);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(84, 224);
            this.grpbox.TabIndex = 24;
            this.grpbox.TabStop = false;
            // 
            // cmdluu
            // 
            this.cmdluu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdluu.Image = ((System.Drawing.Image)(resources.GetObject("cmdluu.Image")));
            this.cmdluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdluu.Location = new System.Drawing.Point(7, 141);
            this.cmdluu.Name = "cmdluu";
            this.cmdluu.Size = new System.Drawing.Size(73, 30);
            this.cmdluu.TabIndex = 4;
            this.cmdluu.Text = "Lưu";
            this.cmdluu.UseVisualStyleBackColor = true;
            this.cmdluu.Click += new System.EventHandler(this.cmdluu_Click);
            // 
            // cmdthem
            // 
            this.cmdthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthem.Image = ((System.Drawing.Image)(resources.GetObject("cmdthem.Image")));
            this.cmdthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthem.Location = new System.Drawing.Point(6, 9);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(73, 30);
            this.cmdthem.TabIndex = 13;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            this.cmdthem.Click += new System.EventHandler(this.cmdthem_Click);
            // 
            // cmdCapnhat
            // 
            this.cmdCapnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("cmdCapnhat.Image")));
            this.cmdCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCapnhat.Location = new System.Drawing.Point(7, 53);
            this.cmdCapnhat.Name = "cmdCapnhat";
            this.cmdCapnhat.Size = new System.Drawing.Size(73, 30);
            this.cmdCapnhat.TabIndex = 10;
            this.cmdCapnhat.Text = "Sửa";
            this.cmdCapnhat.UseVisualStyleBackColor = true;
            this.cmdCapnhat.Click += new System.EventHandler(this.cmdCapnhat_Click);
            // 
            // cmdxoa
            // 
            this.cmdxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxoa.Image = ((System.Drawing.Image)(resources.GetObject("cmdxoa.Image")));
            this.cmdxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxoa.Location = new System.Drawing.Point(7, 97);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(73, 30);
            this.cmdxoa.TabIndex = 12;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbogroup);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 95);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhóm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Người dùng :";
            // 
            // cbogroup
            // 
            this.cbogroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbogroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogroup.FormattingEnabled = true;
            this.cbogroup.Location = new System.Drawing.Point(133, 66);
            this.cbogroup.Name = "cbogroup";
            this.cbogroup.Size = new System.Drawing.Size(121, 21);
            this.cbogroup.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpassword.Location = new System.Drawing.Point(133, 40);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(121, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtusername.Location = new System.Drawing.Point(133, 14);
            this.txtusername.MaxLength = 50;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 20);
            this.txtusername.TabIndex = 1;
            // 
            // cmdthoat
            // 
            this.cmdthoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdthoat.Image")));
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(5, 185);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(73, 30);
            this.cmdthoat.TabIndex = 20;
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(395, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cập nhật User";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.grpbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Button cmdluu;
        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.Button cmdCapnhat;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbogroup;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button cmdthoat;
    }
}