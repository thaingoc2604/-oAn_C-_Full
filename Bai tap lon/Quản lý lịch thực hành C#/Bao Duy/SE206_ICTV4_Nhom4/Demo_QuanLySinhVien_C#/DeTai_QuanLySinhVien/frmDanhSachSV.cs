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
    public partial class frmDanhSachSV : DevComponents.DotNetBar.Office2007Form
    {
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        //private string ls = String.Empty;
        string masv;
        string lop_id;
        public frmDanhSachSV()
        {
            InitializeComponent();            
        }   
        private void frmDanhSachSV_Load(object sender, EventArgs e)
        {            
            
            cbDSKhoa.DataSource = db.Khoas;
            cbDSKhoa.DisplayMember = "TenKhoa";
            cbDSKhoa.ValueMember = "Khoa_ID";
            cbDSKhoa.SelectedIndex = -1;
        }
        private void cbDSKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbDSLop.Items.Clear();
            if (cbDSKhoa.SelectedIndex >= 0)
            {
                string MaKhoa = cbDSKhoa.SelectedValue.ToString();
                var tenLop = from Lop in db.Lops
                             where Lop.ID_Khoa == MaKhoa
                             select new { TenLop = Lop.TenLop, Lop_ID = Lop.Lop_ID };
                foreach (var item in tenLop)
                {
                    cbDSLop.Items.Add(item.TenLop);
                }
            }
        }

        private void cbDSLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbDSLop.SelectedIndex != -1)
            {
                string malop = cbDSLop.SelectedItem.ToString();
                var tenLop = from Lop in db.Lops
                             where Lop.TenLop == malop
                             select new { TenLop = Lop.TenLop, Lop_ID = Lop.Lop_ID };
                foreach (var item in tenLop)
                {
                    cbDSLop.Tag = item.Lop_ID;
                }
            }
        }

        private void btnDSSinhVien_Click_1(object sender, EventArgs e)
        {
            HienThiDSLenListviewDanhSach();
        }

        private void HienThiDSLenListviewDanhSach()
        {
            lsDanhSachSinhVien.Items.Clear();
            if (cbDSKhoa.SelectedIndex == -1 || cbDSLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn thông tin từ danh sách Khoa và danh sách lớp","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    string maLop = cbDSLop.Tag.ToString();
                    var HienThiDS = from SinhVien in db.SinhViens
                                    from Lop in db.Lops
                                    from Khoa in db.Khoas
                                    where SinhVien.ID_Lop == maLop && Lop.Lop_ID == SinhVien.ID_Lop && Khoa.Khoa_ID == Lop.ID_Khoa
                                    select new
                                    {
                                        SinhVien_ID = SinhVien.SinhVien_ID,
                                        TenSinhVien = SinhVien.TenSinhVien,
                                        GioiTinh = SinhVien.GioiTinh,
                                        NgaySinh = SinhVien.NgaySinh,
                                        NoiSinh = SinhVien.NoiSinh,
                                        NoiOHienTai = SinhVien.NoiOHienTai,
                                        KhoaHoc = SinhVien.KhoaHoc,
                                        LyLich = SinhVien.LyLich,
                                        ID_Lop = Lop.TenLop,
                                        TenKhoa = Khoa.TenKhoa
                                    };
                    foreach (var DSSV in HienThiDS)
                    {
                        ListViewItem li = lsDanhSachSinhVien.Items.Add(DSSV.SinhVien_ID);
                        li.SubItems.Add(DSSV.TenSinhVien);
                        if (DSSV.GioiTinh == 0)
                            li.SubItems.Add("Nam");
                        else
                            li.SubItems.Add("Nữ");
                        li.SubItems.Add(DSSV.NgaySinh.ToShortDateString());
                        li.SubItems.Add(DSSV.NoiSinh);
                        li.SubItems.Add(DSSV.NoiOHienTai);
                        li.SubItems.Add(DSSV.KhoaHoc);
                        li.SubItems.Add(DSSV.TenKhoa);
                        li.SubItems.Add(DSSV.ID_Lop);
                        li.SubItems.Add(DSSV.LyLich);
                    }
                }
                catch (Exception js)
                {
                    
                    MessageBox.Show(js.Message);
                }
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSinhVien f = new frmThemSinhVien();            
            f.Show();
        }

        private void lsDanhSachSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsDanhSachSinhVien.SelectedItems.Count>0)
            {
               ListViewItem li=lsDanhSachSinhVien.SelectedItems[0];
               masv = li.SubItems[0].Text;
               lop_id = li.SubItems[8].Text;               
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lsDanhSachSinhVien.SelectedItems.Count==0)
            {
                MessageBox.Show("Bạn cần chọn thông tin sinh viên cần sửa từ danh sách sinh viên!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                frmSuaThongTinSinhVien frm = new frmSuaThongTinSinhVien(lop_id,masv);
                frm.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsDanhSachSinhVien.SelectedItems.Count==0)
            {
                MessageBox.Show("Bạn cần chọn thông tin sinh viên cần xóa từ danh sách sinh viên!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                var delSinhVien = db.SinhViens.Where(c => c.SinhVien_ID == masv);
                var delKetQua = db.KetQuas.Where(c => c.ID_SinhVien == masv);
                db.KetQuas.DeleteAllOnSubmit(delKetQua);
                db.SinhViens.DeleteAllOnSubmit(delSinhVien);
                DialogResult result = MessageBox.Show("BẠN CÓ MUỐN XÓA THÔNG TIN SINH VIÊN KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO");
                    HienThiDSLenListviewDanhSach();
                }                
            }
            
        }

        private void frmDanhSachSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gpDanhSachSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void gpKhoaLop_Click(object sender, EventArgs e)
        {

        }               
        }
}