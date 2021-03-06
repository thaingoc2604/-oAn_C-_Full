using System.Windows.Forms;
namespace QLBDDemo
{
    partial class frmCacDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCacDichVu));
            this.btnCuocGoi = new System.Windows.Forms.Button();
            this.btnBuuGui = new System.Windows.Forms.Button();
            this.mnuChinh = new System.Windows.Forms.MenuStrip();
            this.mnuHoSoCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatKhoiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhapTaiKhoanKhac = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatKhoiChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCacDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuocGoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuuGui = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVienThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeVaTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.sbarCacDichVu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnThucuoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.mnuChinh.SuspendLayout();
            this.sbarCacDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCuocGoi
            // 
            this.btnCuocGoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnCuocGoi.Location = new System.Drawing.Point(11, 79);
            this.btnCuocGoi.Name = "btnCuocGoi";
            this.btnCuocGoi.Size = new System.Drawing.Size(228, 81);
            this.btnCuocGoi.TabIndex = 0;
            this.btnCuocGoi.Text = "Cuộc gọi";
            this.btnCuocGoi.UseVisualStyleBackColor = false;
            this.btnCuocGoi.Click += new System.EventHandler(this.btnCuocGoi_Click);
            // 
            // btnBuuGui
            // 
            this.btnBuuGui.Location = new System.Drawing.Point(11, 244);
            this.btnBuuGui.Name = "btnBuuGui";
            this.btnBuuGui.Size = new System.Drawing.Size(228, 81);
            this.btnBuuGui.TabIndex = 1;
            this.btnBuuGui.Text = "Bưu gửi";
            this.btnBuuGui.UseVisualStyleBackColor = true;
            this.btnBuuGui.Click += new System.EventHandler(this.btnBuuGui_Click);
            // 
            // mnuChinh
            // 
            this.mnuChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoSoCaNhan,
            this.mnuCacDichVu,
            this.mnuTroGiup});
            this.mnuChinh.Location = new System.Drawing.Point(0, 0);
            this.mnuChinh.Name = "mnuChinh";
            this.mnuChinh.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuChinh.Size = new System.Drawing.Size(757, 24);
            this.mnuChinh.TabIndex = 2;
            this.mnuChinh.Text = "menuStrip1";
            // 
            // mnuHoSoCaNhan
            // 
            this.mnuHoSoCaNhan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoatKhoiTaiKhoan,
            this.mnuDangNhapTaiKhoanKhac,
            this.mnuTaoTaiKhoan,
            this.mnuThoatKhoiChuongTrinh});
            this.mnuHoSoCaNhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHoSoCaNhan.Name = "mnuHoSoCaNhan";
            this.mnuHoSoCaNhan.Size = new System.Drawing.Size(97, 20);
            this.mnuHoSoCaNhan.Text = "&Hồ sơ cá nhân";
            this.mnuHoSoCaNhan.Visible = false;
            // 
            // mnuThoatKhoiTaiKhoan
            // 
            this.mnuThoatKhoiTaiKhoan.Name = "mnuThoatKhoiTaiKhoan";
            this.mnuThoatKhoiTaiKhoan.Size = new System.Drawing.Size(187, 22);
            this.mnuThoatKhoiTaiKhoan.Text = "&Thoát khỏi tài khoản";
            this.mnuThoatKhoiTaiKhoan.MouseHover += new System.EventHandler(this.mnuThoatKhoiTaiKhoan_MouseHover);
            this.mnuThoatKhoiTaiKhoan.MouseLeave += new System.EventHandler(this.mnuThoatKhoiTaiKhoan_MouseLeave);
            this.mnuThoatKhoiTaiKhoan.Click += new System.EventHandler(this.HandleSelect);
            // 
            // mnuDangNhapTaiKhoanKhac
            // 
            this.mnuDangNhapTaiKhoanKhac.Name = "mnuDangNhapTaiKhoanKhac";
            this.mnuDangNhapTaiKhoanKhac.Size = new System.Drawing.Size(187, 22);
            this.mnuDangNhapTaiKhoanKhac.Text = "&Đăng nhập tài khoản";
            this.mnuDangNhapTaiKhoanKhac.MouseHover += new System.EventHandler(this.mnuDangNhapTaiKhoanKhac_MouseHover);
            this.mnuDangNhapTaiKhoanKhac.MouseLeave += new System.EventHandler(this.mnuDangNhapTaiKhoanKhac_MouseLeave);
            // 
            // mnuTaoTaiKhoan
            // 
            this.mnuTaoTaiKhoan.Name = "mnuTaoTaiKhoan";
            this.mnuTaoTaiKhoan.Size = new System.Drawing.Size(187, 22);
            this.mnuTaoTaiKhoan.Text = "T&ạo tài khoản";
            this.mnuTaoTaiKhoan.MouseHover += new System.EventHandler(this.mnuTaoTaiKhoan_MouseHover);
            this.mnuTaoTaiKhoan.MouseLeave += new System.EventHandler(this.mnuTaoTaiKhoan_MouseLeave);
            // 
            // mnuThoatKhoiChuongTrinh
            // 
            this.mnuThoatKhoiChuongTrinh.Name = "mnuThoatKhoiChuongTrinh";
            this.mnuThoatKhoiChuongTrinh.Size = new System.Drawing.Size(187, 22);
            this.mnuThoatKhoiChuongTrinh.Text = "T&hoát ";
            this.mnuThoatKhoiChuongTrinh.MouseHover += new System.EventHandler(this.mnuThoatKhoiChuongTrinh_MouseHover);
            this.mnuThoatKhoiChuongTrinh.MouseLeave += new System.EventHandler(this.mnuThoatKhoiChuongTrinh_MouseLeave);
            this.mnuThoatKhoiChuongTrinh.Click += new System.EventHandler(this.mnuThoatKhoiChuongTrinh_Click);
            // 
            // mnuCacDichVu
            // 
            this.mnuCacDichVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCuocGoi,
            this.mnuBuuGui,
            this.mnuVienThong,
            this.mnuThongKeVaTimKiem});
            this.mnuCacDichVu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCacDichVu.Name = "mnuCacDichVu";
            this.mnuCacDichVu.Size = new System.Drawing.Size(88, 20);
            this.mnuCacDichVu.Text = "&Các Dịch Vụ";
            // 
            // mnuCuocGoi
            // 
            this.mnuCuocGoi.Name = "mnuCuocGoi";
            this.mnuCuocGoi.Size = new System.Drawing.Size(199, 22);
            this.mnuCuocGoi.Text = "C&uộc gọi";
            this.mnuCuocGoi.MouseHover += new System.EventHandler(this.mnuCuocGoi_MouseHover);
            this.mnuCuocGoi.MouseLeave += new System.EventHandler(this.mnuCuocGoi_MouseLeave);
            this.mnuCuocGoi.Click += new System.EventHandler(this.mnuCuocGoi_Click);
            // 
            // mnuBuuGui
            // 
            this.mnuBuuGui.Name = "mnuBuuGui";
            this.mnuBuuGui.Size = new System.Drawing.Size(199, 22);
            this.mnuBuuGui.Text = "Bưu &gửi";
            this.mnuBuuGui.MouseHover += new System.EventHandler(this.mnuBuuGui_MouseHover);
            this.mnuBuuGui.MouseLeave += new System.EventHandler(this.mnuBuuGui_MouseLeave);
            this.mnuBuuGui.Click += new System.EventHandler(this.mnuBuuGui_Click);
            // 
            // mnuVienThong
            // 
            this.mnuVienThong.Name = "mnuVienThong";
            this.mnuVienThong.Size = new System.Drawing.Size(199, 22);
            this.mnuVienThong.Text = "&Viễn thông";
            this.mnuVienThong.MouseHover += new System.EventHandler(this.mnuVienThong_MouseHover);
            this.mnuVienThong.MouseLeave += new System.EventHandler(this.mnuVienThong_MouseLeave);
            // 
            // mnuThongKeVaTimKiem
            // 
            this.mnuThongKeVaTimKiem.Name = "mnuThongKeVaTimKiem";
            this.mnuThongKeVaTimKiem.Size = new System.Drawing.Size(199, 22);
            this.mnuThongKeVaTimKiem.Text = "&Thống kê và tìm kiếm";
            this.mnuThongKeVaTimKiem.MouseHover += new System.EventHandler(this.mnuThongKeVaTimKiem_MouseHover);
            this.mnuThongKeVaTimKiem.MouseLeave += new System.EventHandler(this.mnuThongKeVaTimKiem_MouseLeave);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuGioiThieu});
            this.mnuTroGiup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(69, 20);
            this.mnuTroGiup.Text = "&Trợ Giúp";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(138, 22);
            this.mnuHuongDan.Text = "&Hướng dẫn";
            this.mnuHuongDan.MouseHover += new System.EventHandler(this.mnuHuongDan_MouseHover);
            this.mnuHuongDan.MouseLeave += new System.EventHandler(this.mnuHuongDan_MouseLeave);
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(138, 22);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.MouseHover += new System.EventHandler(this.mnuGioiThieu_MouseHover);
            this.mnuGioiThieu.MouseLeave += new System.EventHandler(this.mnuGioiThieu_MouseLeave);
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // sbarCacDichVu
            // 
            this.sbarCacDichVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sbarCacDichVu.Location = new System.Drawing.Point(0, 557);
            this.sbarCacDichVu.Name = "sbarCacDichVu";
            this.sbarCacDichVu.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.sbarCacDichVu.Size = new System.Drawing.Size(757, 22);
            this.sbarCacDichVu.TabIndex = 3;
            this.sbarCacDichVu.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // btnThucuoc
            // 
            this.btnThucuoc.Location = new System.Drawing.Point(11, 409);
            this.btnThucuoc.Name = "btnThucuoc";
            this.btnThucuoc.Size = new System.Drawing.Size(228, 81);
            this.btnThucuoc.TabIndex = 4;
            this.btnThucuoc.Text = "Thu cước";
            this.btnThucuoc.UseVisualStyleBackColor = true;
            this.btnThucuoc.Click += new System.EventHandler(this.btnThucuoc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.Location = new System.Drawing.Point(586, 244);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 81);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmCacDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(757, 579);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucuoc);
            this.Controls.Add(this.sbarCacDichVu);
            this.Controls.Add(this.btnBuuGui);
            this.Controls.Add(this.btnCuocGoi);
            this.Controls.Add(this.mnuChinh);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuChinh;
            this.MaximizeBox = false;
            this.Name = "frmCacDichVu";
            this.Text = "CÁC DỊCH VỤ";
            this.mnuChinh.ResumeLayout(false);
            this.mnuChinh.PerformLayout();
            this.sbarCacDichVu.ResumeLayout(false);
            this.sbarCacDichVu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCuocGoi;
        private System.Windows.Forms.Button btnBuuGui;
        private System.Windows.Forms.MenuStrip mnuChinh;
        private System.Windows.Forms.ToolStripMenuItem mnuCacDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuCuocGoi;
        private System.Windows.Forms.ToolStripMenuItem mnuBuuGui;
        private System.Windows.Forms.ToolStripMenuItem mnuVienThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeVaTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;


        //tạo ra các sender trên stasbar

        private void HandleSelect(object sender, System.EventArgs e)
        {
            string strText;

            if (sender == mnuThoatKhoiTaiKhoan)
            {

                strText = "Thoát khỏi tài khoản hiện tại";
                

            }
            else if (sender == mnuDangNhapTaiKhoanKhac)
            {

                strText = "Đăng nhập với một tài khoản khác";
                //MessageBox.Show("OK");
            }
            else if (sender == mnuTaoTaiKhoan)
            {

                strText = "Tạo một tài khoản mới";

            }
            else if (sender == mnuThoatKhoiChuongTrinh)
            {

                strText = "Thoát khỏi chương trình";

            }
            else if (sender == mnuCuocGoi)
            {

                strText = "Chức năng quản lí các cuộc gọi điện thoại";

            }
            else if (sender == mnuBuuGui)
            {

                strText = "Thực hiện chức năng quản lí bưu gửi";

            }
            else if (sender == mnuVienThong)
            {

                strText = "Thực hiện chức năng quản lí viễn thông";
                
            }
            else if (sender == mnuThongKeVaTimKiem)
            {

                strText = "Thực hiện chức năng Thống kê và tìm kiếm";

            }
            else if (sender == mnuHuongDan)
            {

                strText = "Hướng dẫn sử dụng chương trình";
            }
            else if (sender == mnuGioiThieu)
            {

                strText = "giới thiệu về nhóm thực hiện chương trình";
            }
            else
            {
                strText = string.Empty;

            }

            WriteToStatusBar(strText);

        }


        private void ClearStatus(object sender, System.EventArgs e)
        {
            // Once you click a menu item, clear the status bar.

            ClearStatusBar();

        }

        public void ClearStatusBar()
        {
            toolStripStatusLabel1.Text = string.Empty;
            //sbarCacDichVu.Text = string.Empty;
            //sbarEdit.Text = string.Empty;

        }
        

        public void WriteToStatusBar(string Text)
        {
            // Make this procedure public so that the child form(s)

            // can call it, as well.
            toolStripStatusLabel1.Text = Text;
            //sbarCacDichVu.Text = Text;
            //sbarEdit.Text = Text;

        }

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip sbarCacDichVu;
        private Button btnThucuoc;
        private Button btnThoat;
        private ToolStripMenuItem mnuHoSoCaNhan;
        private ToolStripMenuItem mnuThoatKhoiTaiKhoan;
        private ToolStripMenuItem mnuDangNhapTaiKhoanKhac;
        private ToolStripMenuItem mnuTaoTaiKhoan;
        private ToolStripMenuItem mnuThoatKhoiChuongTrinh;
    }
}