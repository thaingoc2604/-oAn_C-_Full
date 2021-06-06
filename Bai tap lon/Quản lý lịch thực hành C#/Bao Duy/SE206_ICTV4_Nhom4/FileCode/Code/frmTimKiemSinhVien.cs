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
    public partial class frmTimKiemSinhVien : DevComponents.DotNetBar.Office2007Form
    {
        string masv;
        string lop_id;        
        public frmTimKiemSinhVien()
        {
            InitializeComponent();
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void cbTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTimKiemSinhVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTimKiemSinhVien_Load(object sender, EventArgs e)
        {
            cbTimKiemTheo.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhaptuKhoa.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Nhập từ nội dung cần tìm ");
                }
                else
                {
                    HienThiKetQuaTim();
                }
            }
            catch (Exception ks)
            {
                
                MessageBox.Show(ks.Message);
            }
           

        }
        public bool kiemTraMaSV()
        {
            var MaSV=from SinhVien in db.SinhViens
                     where SinhVien.SinhVien_ID==txtNhaptuKhoa.Text.Trim()
                     select SinhVien;
        foreach (var item in MaSV)
	        {
		        return false;
	        }
            return true;
        }        
        private void HienThiKetQuaTim()
        {
            if (cbTimKiemTheo.SelectedIndex == 0)
            {
                if(kiemTraMaSV())
                {
                    MessageBox.Show("Không Tìm Thấy");
                    lsvKetQua.Items.Clear();
                }
                else
                {
                lsvKetQua.Items.Clear();
                var theoMaSV = from SinhVien in db.SinhViens
                               from Lop in db.Lops
                               from Khoa in db.Khoas
                               where SinhVien.SinhVien_ID == txtNhaptuKhoa.Text.Trim()
                               && SinhVien.ID_Lop == Lop.Lop_ID
                               && Lop.ID_Khoa == Khoa.Khoa_ID
                               select new
                               {
                                   SinhVien.SinhVien_ID,
                                   SinhVien.TenSinhVien,
                                   Lop.TenLop,
                                   Khoa.TenKhoa
                               };
                foreach (var item in theoMaSV)
                {
                    ListViewItem li = lsvKetQua.Items.Add(item.SinhVien_ID);
                    li.SubItems.Add(item.TenSinhVien);
                    li.SubItems.Add(item.TenLop);
                    li.SubItems.Add(item.TenKhoa);
                }
                }
            }
            if (cbTimKiemTheo.SelectedIndex == 1)
            {
                    lsvKetQua.Items.Clear();
                    var theoMaSV = from SinhVien in db.SinhViens
                                   from Lop in db.Lops
                                   from Khoa in db.Khoas
                                   where SinhVien.TenSinhVien.StartsWith(txtNhaptuKhoa.Text)
                                   && SinhVien.ID_Lop == Lop.Lop_ID
                                   && Lop.ID_Khoa == Khoa.Khoa_ID
                                   select new
                                   {
                                       SinhVien.SinhVien_ID,
                                       SinhVien.TenSinhVien,
                                       Lop.TenLop,
                                       Khoa.TenKhoa
                                   };
                    foreach (var item in theoMaSV)
                    {
                        ListViewItem li = lsvKetQua.Items.Add(item.SinhVien_ID);
                        li.SubItems.Add(item.TenSinhVien);
                        li.SubItems.Add(item.TenLop);
                        li.SubItems.Add(item.TenKhoa);
                    }
            }
        }

        private void lsvKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKetQua.SelectedItems.Count > 0)
            {
                ListViewItem li = lsvKetQua.SelectedItems[0];
                masv = li.SubItems[0].Text;
                var idLop = from SinhVien in db.SinhViens
                            where SinhVien.SinhVien_ID == masv
                            select SinhVien;
                foreach (var item in idLop)
                {
                    lop_id = item.ID_Lop;
                }                
            }
           
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (lsvKetQua.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn cần chọn thông tin sinh viên cần sửa từ danh sách sinh viên!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                frmSuaThongTinSinhVien frm = new frmSuaThongTinSinhVien(lop_id, masv);
                frm.Show();
            }
        }
    }
}