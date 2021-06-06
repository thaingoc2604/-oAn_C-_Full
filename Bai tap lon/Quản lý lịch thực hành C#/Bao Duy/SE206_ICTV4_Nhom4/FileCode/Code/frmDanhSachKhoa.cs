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
    public partial class frmDanhSachKhoa : DevComponents.DotNetBar.Office2007Form
    {
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        public frmDanhSachKhoa()
        {
            InitializeComponent();
        }
        string maKhoa;
        string tenKhoa;
        private void frmDanhSachKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                HienThiDanhSachKhoa();
            }
            catch (Exception vs)
            {
                MessageBox.Show(" Chưa có  CSDL "+vs.Message);
            }           
        }

        private void HienThiDanhSachKhoa()
        {
            lsvDanhSachCacKhoa.Items.Clear();
            var DSKhoa = from Khoa in db.Khoas select new { Khoa_ID = Khoa.Khoa_ID, TenKhoa = Khoa.TenKhoa };
            foreach (var ds in DSKhoa)
            {
                ListViewItem li = lsvDanhSachCacKhoa.Items.Add(ds.Khoa_ID);
                li.SubItems.Add(ds.TenKhoa);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //frmThemKhoa f = new frmThemKhoa();
            //f.Show();      
            if (txtMaKhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Chưa nhập đủ thông tin khoa !", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }
            else
            {
                ThemKhoa();                
            }
        }
        public bool kt()
        {
            var ktmaKhoa = from Khoa
                           in db.Khoas
                           where Khoa.Khoa_ID == txtMaKhoa.Text.Trim()                           
                           select Khoa;
            foreach (var item in ktmaKhoa)
            {
                return true;
            }
            return false;
        }
        private void ThemKhoa()
        {
            
            try
            {
                if (kt())
                {
                    MessageBox.Show("Mã Khoa bị trùng");
                    txtMaKhoa.Text = "";
                    txtTenKhoa.Text = "";
                    txtMaKhoa.ReadOnly = false;
                    txtMaKhoa.Focus();
                }
                else
                {
                    Khoa themKhoa = new Khoa();
                    themKhoa.Khoa_ID = txtMaKhoa.Text.Trim();
                    themKhoa.TenKhoa = txtTenKhoa.Text.Trim();
                    db.Khoas.InsertOnSubmit(themKhoa);
                    DialogResult dl = MessageBox.Show("Bạn đã thêm khoa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        HienThiDanhSachKhoa();
                        txtMaKhoa.Text = "";
                        txtTenKhoa.Text = "";
                        txtMaKhoa.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachCacKhoa.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn thông tin cần xóa từ danh sách khoa !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                var del = db.Khoas.Single(c => c.Khoa_ID == maKhoa);
                db.Khoas.DeleteOnSubmit(del);
                DialogResult dl = MessageBox.Show("Bạn đã xóa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    HienThiDanhSachKhoa();
                    txtMaKhoa.Text = "";
                    txtTenKhoa.Text = "";
                    txtMaKhoa.Focus();
                    txtMaKhoa.ReadOnly = false;
                }
            }
        }

        private void lsvDanhSachCacKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKhoa.ReadOnly = true;
            if (lsvDanhSachCacKhoa.SelectedItems.Count>0)
            {
                ListViewItem li = lsvDanhSachCacKhoa.SelectedItems[0];
                maKhoa = li.SubItems[0].Text.Trim();
                tenKhoa = li.SubItems[1].Text.Trim();
                var hienthilentexBox = from Khoa in db.Khoas
                                       where Khoa.Khoa_ID == maKhoa
                                       select Khoa;
                foreach (var item in hienthilentexBox)
                {
                    txtMaKhoa.Text = item.Khoa_ID;
                    txtTenKhoa.Text = item.TenKhoa;
                }
            }
        }

        private void frmDanhSachKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachCacKhoa.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn thông tin cần xóa từ danh sách khoa !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                //frmSuaThongTinKhoa f = new frmSuaThongTinKhoa(maKhoa,tenKhoa);
                //f.Show();
                SuaThongTinKhoas();
            }
        }
        private void SuaThongTinKhoas()
        {
            var editKhoa = db.Khoas.Single(c => c.Khoa_ID == maKhoa);
            editKhoa.TenKhoa = txtTenKhoa.Text.Trim();
            DialogResult dl = MessageBox.Show("Bạn đã Sửa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                db.SubmitChanges();
                HienThiDanhSachKhoa();
                txtMaKhoa.Text = "";
                txtTenKhoa.Text = "";
            }
        }
        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            
        }     

    }
}