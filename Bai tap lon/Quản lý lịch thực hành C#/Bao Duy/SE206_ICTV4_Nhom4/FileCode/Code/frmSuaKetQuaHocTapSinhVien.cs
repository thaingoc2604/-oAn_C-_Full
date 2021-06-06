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
    public partial class frmSuaKetQuaHocTapSinhVien : DevComponents.DotNetBar.Office2007Form
    {
        readonly string masv;
        readonly string tensv;
        public frmSuaKetQuaHocTapSinhVien(string MaSV,string TenSV)
        {
            InitializeComponent();
            masv = MaSV;
            tensv = TenSV;
            txtMaSV.Text = MaSV;
            txtTenSV.Text = TenSV;
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void gpSuaKetQuaHocTap_Click(object sender, EventArgs e)
        {

        }
        private void frmSuaKetQuaHocTapSinhVien_Load(object sender, EventArgs e)
        {
            cbMonHoc.DataSource = db.MonHocs;
            cbMonHoc.DisplayMember = "TenMonHoc";
            cbMonHoc.ValueMember = "MonHoc_ID";
            cbMonHoc.SelectedIndex = -1;                  
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbMonHoc.SelectedIndex !=-1)
            {
                string maMH = cbMonHoc.SelectedValue.ToString();
                var MH = from MonHoc in db.MonHocs                         
                         where MonHoc.MonHoc_ID == maMH                        
                         select new { 
                             MonHoc.MonHoc_ID                            
                         };
                foreach (var item in MH)
                {
                    cbMonHoc.Tag = item.MonHoc_ID;                    
                }
               HienThiLenTextBox();  
            }
        }     
        private void HienThiLenTextBox()
        {
            var mh = from KetQua in db.KetQuas
                     from SinhVien in db.SinhViens
                     where KetQua.ID_MonHoc == cbMonHoc.SelectedValue.ToString()
                     && SinhVien.SinhVien_ID==masv
                     && KetQua.ID_SinhVien==masv
                     select new
                     {
                         DiemThi=KetQua.DiemThi,
                         LanThi=KetQua.LanThi,
                         DiemTongKet=KetQua.DiemTongKet,
                         ID_MonHoc=KetQua.ID_MonHoc
                     };
            foreach(var item in mh)
            {
                txtLanThi.Text = item.LanThi.ToString();
                txtDiemThi.Text = item.DiemThi.ToString();
                txtDiemTKet.Text = item.DiemTongKet.ToString();                
            }            
        }
        private void SuaKetQuaHocTap()
        {
            try
            {                
                string maSV = txtMaSV.Text;
                string tenSV = txtTenSV.Text.Trim();
                string lanThi = txtLanThi.Text.Trim();
                string diemThi = txtDiemThi.Text.Trim();
                string diemTongKet = txtDiemTKet.Text.Trim();
                var kq = db.KetQuas.Single(c=>c.ID_SinhVien==maSV);
                //kq.ID_MonHoc = cbMonHoc.SelectedValue.ToString();               
                //kq.LanThi = Convert.ToInt32(lanThi);
                kq.DiemThi =float.Parse(diemThi);
                kq.DiemTongKet = float.Parse(diemTongKet);
                DialogResult dl = MessageBox.Show("Bạn đã Sửa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    db.SubmitChanges();
                }
            }
            catch (Exception jx)
            {

                MessageBox.Show(jx.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(cbMonHoc.SelectedIndex==-1)
            {
                MessageBox.Show("Bạn chưa chọn môn để sửa điểm"," Thông Báo !!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
            else
            {
                SuaKetQuaHocTap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaKetQuaHocTapSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if(dl==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}