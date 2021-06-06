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
    public partial class frmThemKetQuaHocTapSinhVien : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemKetQuaHocTapSinhVien(string MaSV, string TenSV)
        {
            InitializeComponent();
            txtMaSV.Text = MaSV;
            txtTenSV.Text = TenSV;
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmThemKetQuaHocTapSinhVien_Load(object sender, EventArgs e)
        {
            cbMonHoc.DataSource = db.MonHocs;
            cbMonHoc.DisplayMember = "TenMonHoc";
            cbMonHoc.ValueMember = "MonHoc_ID";
            cbMonHoc.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKetQuaHocTap();
        }

        private void ThemKetQuaHocTap()
        {
            if (cbMonHoc.SelectedIndex == -1 || txtLanThi.Text.Trim() == "" || txtDiemThi.Text.Trim() == "" || txtDiemTKet.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin kết quả học tập !!","Thông Báo!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    string monHoc_ID = cbMonHoc.Tag.ToString();
                    string maSV = txtMaSV.Text.Trim();
                    string tenSV = txtTenSV.Text.Trim();
                    string lanThi = txtLanThi.Text.Trim();
                    string diemThi = txtDiemThi.Text.Trim();
                    string diemTongKet = txtDiemTKet.Text.Trim();
                    KetQua kq = new KetQua();
                    kq.ID_MonHoc = monHoc_ID;
                    kq.ID_SinhVien = maSV;
                    kq.LanThi = Convert.ToInt32(lanThi);
                    kq.DiemThi = float.Parse(diemThi);
                    kq.DiemTongKet = float.Parse(diemTongKet);
                    db.KetQuas.InsertOnSubmit(kq);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Thành Công !!!");
                }
                catch (Exception jx)
                {

                    throw new Exception(jx.Message);
                }
            }
            
        }
        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMonHoc.SelectedIndex!=-1)
            {
                string maMH = cbMonHoc.SelectedValue.ToString();
                var MH = from MonHoc in db.MonHocs where MonHoc.MonHoc_ID == maMH select MonHoc;
                foreach(var item in MH)
                {
                    cbMonHoc.Tag = item.MonHoc_ID;
                }
            }
        }

        private void gpThemKetQuaHocTap_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}