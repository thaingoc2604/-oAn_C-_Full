using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using System.IO;
namespace DeTai_QuanLySinhVien
{
    public partial class frmThemSinhVien : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemSinhVien()
        {
            InitializeComponent();
        }
        string hinhanh="";
        private void gpThemSinhVien_Click(object sender, EventArgs e)
        {

        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            cbTenLop.DataSource = db.Lops;
            cbTenLop.DisplayMember = "TenLop";
            cbTenLop.ValueMember = "Lop_ID";
            cbTenLop.SelectedIndex = -1;
        }              
        private void btnImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang hoàn thiện");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            if(txtMaSV.Text.Trim()==""||txtTenSV.Text.Trim()==""||txtNoiSinh.Text.Trim()==""||txtNoiOHienTai.Text.Trim()==""||txtLyLich.Text.Trim()==""||cbTenLop.SelectedIndex==-1||datetimeNhapNgaySinh.Text==""||txtKhoaHoc.Text==""||(rbNam.Checked==false&&rbNu.Checked==false))
            {
                MessageBox.Show("Bạn cần phải điền đầy đủ thông tin sinh viên để thêm một sinh viên mới !!", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                ThemSinhVien();               
            }
        }

        private void ThemSinhVien()
        {            
            try
            {                 
                int sex;                  
                string MaSV = txtMaSV.Text.Trim();
                string TenSV = txtTenSV.Text.Trim();
                DateTime NgaySinh = Convert.ToDateTime(datetimeNhapNgaySinh.MaxDate.ToLongTimeString());
                string NoiSinh = txtNoiSinh.Text.Trim();
                string NoiOHienTai = txtNoiOHienTai.Text.Trim();
                string KhoaHoc = txtKhoaHoc.Text.Trim();
                string MLop = cbTenLop.Tag.ToString();
                string LyLich = txtLyLich.Text.Trim();
                //string HinhAnh = null;
                if (rbNam.Checked == true)
                    sex = 0;
                else
                    sex = 1;
                SinhVien sv = new SinhVien();
                sv.SinhVien_ID = MaSV;
                sv.TenSinhVien = TenSV;
                sv.GioiTinh = Convert.ToByte(sex.ToString());
                sv.NgaySinh = NgaySinh;
                sv.NoiSinh = NoiSinh;
                sv.NoiOHienTai = NoiOHienTai;
                sv.KhoaHoc = KhoaHoc;
                sv.LyLich = LyLich;
                sv.ID_Lop = MLop;
                ////sv.HinhAnh = null;
                db.SinhViens.InsertOnSubmit(sv);
                DialogResult result = MessageBox.Show("BẠN CÓ MUỐN THÊM THÔNG TIN SINH VIÊN KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.SubmitChanges();
                    MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO");                    
                }     
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTenLop.SelectedIndex != -1)
            {
                string MaLop = cbTenLop.SelectedValue.ToString();
                var maLop = from Lop in db.Lops where Lop.Lop_ID==MaLop select Lop;
                foreach(var item in maLop)
                {
                    cbTenLop.Tag = item.Lop_ID;
                }
            }
        }

        private void picboxChonAnh_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string MaSV = txtMaSV.Text.Trim();
                var sv=from SinhVien in db.SinhViens where SinhVien.SinhVien_ID==MaSV select SinhVien;
                foreach(var masv in sv)
                {                    
                        MessageBox.Show("Mã Sinh viên bị trùng, mời bạn nhập lại");
                        txtMaSV.Text = "";
                }               
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
        }

        private void btnThemKetQuaHocTap_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtTenSV.Text.Trim() == "" || txtNoiSinh.Text.Trim() == "" || txtNoiOHienTai.Text.Trim() == "" || txtLyLich.Text.Trim() == "" || cbTenLop.SelectedIndex == -1 || datetimeNhapNgaySinh.Text == "" || txtKhoaHoc.Text == "" || rbNam.Checked == false && rbNu.Checked == false || hinhanh == "")
            {
                MessageBox.Show("Bạn Chưa nhập đủ thông tin về một sinh viên !","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
            else
            {
            frmThemKetQuaHocTapSinhVien f = new frmThemKetQuaHocTapSinhVien(txtMaSV.Text, txtTenSV.Text);
            f.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;             
            }
        }
    }
}