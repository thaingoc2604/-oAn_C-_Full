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
    public partial class frmDanhSachNguoiDung : DevComponents.DotNetBar.Office2007Form
    {
        string tenDangNhap;
        string matKhau;
        string quyenHan;
        public frmDanhSachNguoiDung()
        {
            InitializeComponent();

        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                LoadQuanLyNguoiDung();
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }
            
        }

        private void LoadQuanLyNguoiDung()
        {
            lsDanhSachNguoiDung.Items.Clear();
            var dsNguoi = from QuanLyNguoiDung in db.QuanLyNguoiDungs                         
                          select QuanLyNguoiDung;
            foreach (var item in dsNguoi)
            {
                ListViewItem li = lsDanhSachNguoiDung.Items.Add(item.TenDangNhap);
                li.SubItems.Add(item.MatKhau);
                li.SubItems.Add(item.QuyenHan);
            }
        }

        private void lsDanhSachNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
            if (lsDanhSachNguoiDung.SelectedItems.Count > 0)
            {
                
                ListViewItem li = lsDanhSachNguoiDung.SelectedItems[0];
                tenDangNhap = li.Text;
                matKhau = li.SubItems[1].Text;
                quyenHan = li.SubItems[2].Text;
                var hienthiTexbox = from QuanLyNguoiDung in db.QuanLyNguoiDungs
                                    where QuanLyNguoiDung.TenDangNhap == tenDangNhap
                                    && QuanLyNguoiDung.MatKhau == matKhau
                                    && QuanLyNguoiDung.QuyenHan == quyenHan
                                    select QuanLyNguoiDung;
                foreach (var item in hienthiTexbox)
                {
                    txtTenDangNhap.Text = item.TenDangNhap;
                    txtMatKhau.Text = item.MatKhau;
                    txtQuyenHan.Text = item.QuyenHan;
                }
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "" || txtQuyenHan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần phải điền đầy đủ thông tin sinh viên để thêm một sinh viên mới !!", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                ThemNguoiDung();
            }
           
        }

        private void ThemNguoiDung()
        {
            try
            {
                QuanLyNguoiDung ql = new QuanLyNguoiDung();
                ql.TenDangNhap = txtTenDangNhap.Text.Trim();
                ql.MatKhau = txtMatKhau.Text.Trim();
                ql.QuyenHan = txtQuyenHan.Text.Trim();
                db.QuanLyNguoiDungs.InsertOnSubmit(ql);
                DialogResult result = MessageBox.Show("BẠN CÓ MUỐN THÊM THÔNG TIN NGƯỜI DÙNG KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO");
                    LoadQuanLyNguoiDung();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Tên này đã có người dùng!!"+ex.Message);
                            
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsDanhSachNguoiDung.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn cần chọn thông tin sinh viên cần sửa từ danh sách sinh viên!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                SuaNguoiDung();
            }
           
        }
        private void SuaNguoiDung()
        {
            var suaNguoiDung = db.QuanLyNguoiDungs.Single(c=>c.TenDangNhap==tenDangNhap);            
            suaNguoiDung.QuyenHan = txtQuyenHan.Text;
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN NGƯỜI DÙNG KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.SubmitChanges();
                MessageBox.Show("SỬA THÀNH CÔNG", "THÔNG BÁO");
                LoadQuanLyNguoiDung();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsDanhSachNguoiDung.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn cần chọn thông tin sinh viên cần sửa từ danh sách sinh viên!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                XoaNguoiDung();
            }
        }
        private void XoaNguoiDung()
        {
            var xoaNguoiDung = db.QuanLyNguoiDungs.Single(c => c.TenDangNhap == tenDangNhap);
            db.QuanLyNguoiDungs.DeleteOnSubmit(xoaNguoiDung);
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN XÓA THÔNG TIN NGƯỜI DÙNG KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.SubmitChanges();
                MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO");
                LoadQuanLyNguoiDung();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhSachNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}