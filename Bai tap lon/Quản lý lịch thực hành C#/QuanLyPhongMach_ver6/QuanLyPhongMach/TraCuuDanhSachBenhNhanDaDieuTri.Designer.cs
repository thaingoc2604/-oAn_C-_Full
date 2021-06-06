namespace QuanLyPhongMach
{
    partial class frmTraCuuDanhSachBenhNhanDaDieuTri
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
            this.btXuatEcel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btXuatEcel
            // 
            this.btXuatEcel.Location = new System.Drawing.Point(548, 262);
            this.btXuatEcel.Name = "btXuatEcel";
            this.btXuatEcel.Size = new System.Drawing.Size(168, 23);
            this.btXuatEcel.TabIndex = 14;
            this.btXuatEcel.Text = "Xuất Ra File Execl";
            this.btXuatEcel.UseVisualStyleBackColor = true;
            this.btXuatEcel.Click += new System.EventHandler(this.btXuatEcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachBenhNhan);
            this.groupBox2.Location = new System.Drawing.Point(5, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 171);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hiển thị :";
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AllowUserToResizeColumns = false;
            this.dgvDanhSachBenhNhan.AllowUserToResizeRows = false;
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(6, 29);
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.ReadOnly = true;
            this.dgvDanhSachBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(819, 136);
            this.dgvDanhSachBenhNhan.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(92, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(671, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Danh Sách Bênh Nhân Đã Điều Trị";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(722, 262);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(114, 23);
            this.btThoat.TabIndex = 15;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmTraCuuDanhSachBenhNhanDaDieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 302);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXuatEcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Name = "frmTraCuuDanhSachBenhNhanDaDieuTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmTraCuuDanhSachBenhNhanDaDieuTri_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXuatEcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachBenhNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThoat;
    }
}