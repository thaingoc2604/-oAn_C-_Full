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
    public partial class frmThemMonHoc : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemMonHoc()
        {
            InitializeComponent();
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmThemMonHoc_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Trim() == "" || txtTenMH.Text.Trim() == ""||txtSoTinChi.Text.Trim()==""||txtGiangVien.Text.Trim()=="")
            {
                MessageBox.Show("Bạn Chưa nhập đủ thông tin khoa !", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                ThemMonHocs();
            }
        }

        private void ThemMonHocs()
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
            }
        }

        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}