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
    public partial class frmSuaThongTinSinhVien : DevComponents.DotNetBar.Office2007Form
    {
        readonly string masv;
        readonly string lop_id;
        public frmSuaThongTinSinhVien(string Lop_ID,string MaSV)
        {
            InitializeComponent();
            masv = MaSV;
            lop_id = Lop_ID;
            txtMaSV.Text = masv;
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        string hinhanh;
        private void frmSuaThongTinSinhVien_Load(object sender, EventArgs e)
        {                       
             HienThiThongTin();
        }

        private void HienThiThongTin()
        {            
            var layAnh_masv = from SinhVien in db.SinhViens
                              where SinhVien.SinhVien_ID == masv
                              select new { SinhVien.HinhAnh };
            foreach (var anh in layAnh_masv)
            {
                hinhanh = anh.HinhAnh;
            }
            cbTenLop.DataSource = db.Lops;
            cbTenLop.DisplayMember = "TenLop";
            cbTenLop.ValueMember = "Lop_ID";
            var student = from SinhVien in db.SinhViens
                          from Lop in db.Lops
                          where SinhVien.SinhVien_ID == masv
                          && Lop.TenLop==lop_id
                          select new 
                          {
                              SinhVien.TenSinhVien,
                              SinhVien.GioiTinh,
                              SinhVien.NgaySinh,
                              SinhVien.NoiSinh,
                              SinhVien.NoiOHienTai,
                              SinhVien.KhoaHoc,
                              SinhVien.LyLich,
                              SinhVien.ID_Lop,
                              SinhVien.HinhAnh,
                              Lop.TenLop
                          };
            foreach (var item in student)
            {
                this.txtTenSV.Text = item.TenSinhVien;
                int sex=item.GioiTinh;
                if (sex == 0)
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
                this.datetimeNhapNgaySinh.Text = item.NgaySinh.ToString();
                this.txtNoiSinh.Text = item.NoiSinh;
                this.txtNoiOHienTai.Text = item.NoiOHienTai;
                this.txtKhoaHoc.Text = item.KhoaHoc;
                this.cbTenLop.Text = item.TenLop;
                this.cbTenLop.Tag = item.ID_Lop;
                this.txtLyLich.Text = item.LyLich;
                string hinhanh = item.HinhAnh;
                this.picboxChonAnh.Image = new Bitmap(Application.StartupPath + @"\HinhAnh\" + hinhanh);                
                picboxChonAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SuaThongTinSinhVien()
        {
            try
            {
                
                int sex;                
                string TenSV = txtTenSV.Text.Trim();
                DateTime NgaySinh = Convert.ToDateTime(datetimeNhapNgaySinh.MaxDate.ToLongTimeString());
                string NoiSinh = txtNoiSinh.Text.Trim();
                string NoiOHienTai = txtNoiOHienTai.Text.Trim();
                string KhoaHoc = txtKhoaHoc.Text.Trim();
                string MLop = cbTenLop.Tag.ToString();
                string LyLich = txtLyLich.Text.Trim();                                
                if (rbNam.Checked == true)
                    sex = 0;
                else 
                    sex = 1;
                SinhVien sv = db.SinhViens.Single(c=>c.SinhVien_ID==masv);                
                sv.TenSinhVien = TenSV;
                sv.GioiTinh = Convert.ToByte(sex.ToString());
                sv.NgaySinh = NgaySinh;
                sv.NoiSinh = NoiSinh;
                sv.NoiOHienTai = NoiOHienTai;
                sv.KhoaHoc = KhoaHoc;
                sv.LyLich = LyLich;
                sv.ID_Lop = MLop;
                sv.HinhAnh = hinhanh;
                DialogResult dl = MessageBox.Show(" Bạn đã sửa Thành Công !!!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dl==DialogResult.Yes)
                {
                     db.SubmitChanges();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = " Image files (*.BMP,*.JPG,*.JPEG)|*.bmp;*.jpg;*.jpeg";
            dl.InitialDirectory = Application.StartupPath + @"~/HinhAnh";
            if (dl.ShowDialog() == DialogResult.OK)
            {
                hinhanh = dl.FileName.Substring(dl.FileName.LastIndexOf("\\") + 1, dl.FileName.Length - dl.FileName.LastIndexOf("\\") - 1);
                picboxChonAnh.Image = new Bitmap(String.Format(@"{0}\HinhAnh\{1}", Application.StartupPath, hinhanh));
                picboxChonAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTinSinhVien();
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenLop.SelectedIndex != -1)
            {
                string MaLop = cbTenLop.SelectedValue.ToString();
                var maLop = from Lop in db.Lops where Lop.Lop_ID == MaLop select Lop;
                foreach (var item in maLop)
                {
                    cbTenLop.Tag = item.Lop_ID;
                }
            }
        }

        private void btnSuaKetQuaHocTap_Click(object sender, EventArgs e)
        {
            frmSuaKetQuaHocTapSinhVien f = new frmSuaKetQuaHocTapSinhVien(masv,txtTenSV.Text);
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaThongTinSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}