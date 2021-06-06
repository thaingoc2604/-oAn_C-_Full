using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using System.Threading;
namespace DeTai_QuanLySinhVien
{
    public partial class frmDanhSachMonHoc : DevComponents.DotNetBar.Office2007Form
    {
        string MonHoc_Id;
        string TenMonHoc;
        int SoTinChi;
        string GiangVien;
        public frmDanhSachMonHoc()
        {
            InitializeComponent();
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void gpDSMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhSachMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                HienThiDanhSachMonHocs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void HienThiDanhSachMonHocs()
        {
            lsvDSMonHoc.Items.Clear();
            var DSMonHoc = from MonHoc in db.MonHocs select MonHoc;
            foreach (var item in DSMonHoc)
            {
                ListViewItem li = lsvDSMonHoc.Items.Add(item.MonHoc_ID);
                li.SubItems.Add(item.TenMonHoc);
                li.SubItems.Add(item.SoTrinh.ToString());
                li.SubItems.Add(item.GiangVien);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //frmThemMonHoc f = new frmThemMonHoc();
            //f.Show();
            if (txtMaMH.Text.Trim() == "" || txtTenMH.Text.Trim() == "" || txtSoTinChi.Text.Trim() == "" || txtGiangVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Chưa nhập đủ thông tin khoa !", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                ThemMonHocs();
            }
        }
        public bool ktMaMH()
        {
            var kt = from MonHoc in db.MonHocs
                     where MonHoc.MonHoc_ID == txtMaMH.Text.Trim()
                     select MonHoc;
            foreach (var item in kt)
            {
                return true;
            }
            return false;
        }
        private void ThemMonHocs()
        {
            if (ktMaMH())
            {
                MessageBox.Show(" Mã Môn Học bị trùng !!");
                txtMaMH.Text = "";
                txtTenMH.Text = "";
                txtSoTinChi.Text = "";
                txtGiangVien.Text = "";
                txtTenMH.Focus();
                txtMaMH.ReadOnly = false;
            }
            else
            {
                MonHoc themMH = new MonHoc();
                themMH.MonHoc_ID = txtMaMH.Text.Trim();
                themMH.TenMonHoc = txtTenMH.Text.Trim();
                themMH.SoTrinh = Convert.ToInt32(txtSoTinChi.Text.Trim());
                themMH.GiangVien = txtGiangVien.Text.Trim();
                db.MonHocs.InsertOnSubmit(themMH);
                DialogResult dl = MessageBox.Show("Bạn đã thêm lớp thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    HienThiDanhSachMonHocs();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvDSMonHoc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn thông tin môn học từ danh sách môn học !! ");
            }
            else
            {
                var editMH = db.MonHocs.Single(c => c.MonHoc_ID == MonHoc_Id);
                editMH.TenMonHoc = txtTenMH.Text.Trim();
                editMH.SoTrinh = Convert.ToInt32(txtSoTinChi.Text.Trim());
                editMH.GiangVien = txtGiangVien.Text.Trim();
                DialogResult dl = MessageBox.Show("Bạn đã Sửa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    HienThiDanhSachMonHocs();
                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtSoTinChi.Text = "";
                    txtGiangVien.Text = "";
                }   
            }
        }

        private void lsvDSMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaMH.ReadOnly = true;
            if (lsvDSMonHoc.SelectedItems.Count > 0)
            {
                ListViewItem li = lsvDSMonHoc.SelectedItems[0];
                MonHoc_Id = li.SubItems[0].Text.Trim();
                TenMonHoc = li.SubItems[1].Text.Trim();
                SoTinChi = Convert.ToInt32(li.SubItems[2].Text.Trim());
                GiangVien = li.SubItems[3].Text.Trim();
                var laylenTexbox = from MonHoc in db.MonHocs
                                   where MonHoc.MonHoc_ID == MonHoc_Id
                                   && MonHoc.TenMonHoc == TenMonHoc
                                   && MonHoc.SoTrinh == SoTinChi
                                   && MonHoc.GiangVien==GiangVien
                                   select MonHoc;
                foreach (var item in laylenTexbox)
                {
                    txtMaMH.Text = item.MonHoc_ID;
                    txtTenMH.Text = item.TenMonHoc;
                    txtSoTinChi.Text = item.SoTrinh.ToString();
                    txtGiangVien.Text = item.GiangVien;
                }

            }
        }

        private void frmDanhSachMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
            if (lsvDSMonHoc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn thông tin môn học từ danh sách môn học !! ");
            }
            else
            {
                var del = db.MonHocs.Single(c => c.MonHoc_ID == MonHoc_Id);
                db.MonHocs.DeleteOnSubmit(del);
                DialogResult dl = MessageBox.Show("Bạn đã xóa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    HienThiDanhSachMonHocs();
                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtSoTinChi.Text = "";
                    txtGiangVien.Text = "";
                    txtMaMH.ReadOnly = false;
                    txtTenMH.Focus();
                }
            }
        }

        private void txtSoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;

                MessageBox.Show("Chỉ nhận số nguyên dương ! ");

            }
        }
    }
}