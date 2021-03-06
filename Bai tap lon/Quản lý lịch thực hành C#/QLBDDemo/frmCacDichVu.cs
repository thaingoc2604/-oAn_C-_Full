using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBDDemo
{
    public partial class frmCacDichVu : Form
    {
        public frmCacDichVu()
        {
            InitializeComponent();
        }

        private void btnCuocGoi_Click(object sender, EventArgs e)
        {
            frmQuanLiCuocGoi frmquanLiCuocGoi = new frmQuanLiCuocGoi();
            frmquanLiCuocGoi.Show();
        }

        private void btnBuuGui_Click(object sender, EventArgs e)
        {
            frmQuanLyBuuGui frmbuuGui = new frmQuanLyBuuGui();
            frmbuuGui.Show();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            TacGia tacGia = new TacGia();
            tacGia.Show();
        }

        private void mnuCuocGoi_Click(object sender, EventArgs e)
        {
            frmQuanLiCuocGoi quanLiCuocGoi = new frmQuanLiCuocGoi();
            quanLiCuocGoi.Show();
        }

        private void mnuBuuGui_Click(object sender, EventArgs e)
        {
            frmQuanLyBuuGui quanLiBuuGui = new frmQuanLyBuuGui();
            quanLiBuuGui.Show();
        }

        private void mnuThoatKhoiTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Thoát khỏi tài khoản hiện tại";
        }

        private void mnuThoatKhoiTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuDangNhapTaiKhoanKhac_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Đăng nhập với tài khoản khác";
        }

        private void mnuDangNhapTaiKhoanKhac_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuTaoTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tạo tài khoản mới";
        }

        private void mnuTaoTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuThoatKhoiChuongTrinh_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Thoát khỏi chương trình";
        }

        private void mnuThoatKhoiChuongTrinh_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuCuocGoi_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Chức năng quản lí cuộc gọi";
        }

        private void mnuCuocGoi_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuBuuGui_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Chức năng quản lí bưu gửi";
        }

        private void mnuBuuGui_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuVienThong_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Chức năng quản lí viễn thông";
        }

        private void mnuVienThong_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuThongKeVaTimKiem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Chức năng thống kê và tìm kiếm";
        }

        private void mnuThongKeVaTimKiem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuHuongDan_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hướng dẫn sử dụng chương trình";
        }

        private void mnuHuongDan_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuGioiThieu_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Giới thiệu về các thành viên";
        }

        private void mnuGioiThieu_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void mnuThoatKhoiChuongTrinh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThucuoc_Click(object sender, EventArgs e)
        {
            frmQuanlythucuoc Quanlythucuoc = new frmQuanlythucuoc();
            Quanlythucuoc.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       
    }
}