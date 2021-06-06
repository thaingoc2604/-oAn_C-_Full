using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
namespace DeTai_QuanLySinhVien
{
    public partial class frmDangNhapAdmin : DevComponents.DotNetBar.Office2007Form
    {
        string tenDangNhap;
        string matKhau;
        string quyenHan;
        public frmDangNhapAdmin()
        {
            InitializeComponent();
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tenDangNhap = txtTenDangNhap.Text.Trim();
            matKhau = txtMatKhau.Text.Trim();
            quyenHan = txtQuyenHan.Text;
            if (DangNhapAdmin(tenDangNhap, matKhau, quyenHan) == true)
            {
                MessageBox.Show("Xin Chào Admin", "Đăng Nhập Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmDanhSachNguoiDung f = new frmDanhSachNguoiDung();                            
                f.Show();
            }
            else
                MessageBox.Show("Thông Tin Đăng Nhập Không Đúng.Vui Lòng Kiểm Tra Lại", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool DangNhapAdmin(string TenDangNhap, string MatKhau,string QuyenHan)
        {
            var ktDangNhap = from QuanLyNguoiDung in db.QuanLyNguoiDungs
                             where QuanLyNguoiDung.TenDangNhap == TenDangNhap
                             && QuanLyNguoiDung.MatKhau == MatKhau
                             && QuanLyNguoiDung.QuyenHan == QuyenHan
                             select QuanLyNguoiDung;
            foreach (var kt in ktDangNhap)
            {
                return true;
            }
            return false;
        }

        private void frmDangNhapAdmin_Load(object sender, EventArgs e)
        {
                        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhapAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}