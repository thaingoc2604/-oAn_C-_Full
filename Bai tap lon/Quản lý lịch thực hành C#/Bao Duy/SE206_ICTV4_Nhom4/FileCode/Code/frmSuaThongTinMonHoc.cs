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
    public partial class frmSuaThongTinMonHoc : DevComponents.DotNetBar.Office2007Form
    {
        string mamh;
        string tenmh;
        int sotinchi;
        string tenGV;
        public frmSuaThongTinMonHoc(string MaMH,string TenMH,int SoTinChi,string TenGV)
        {
            InitializeComponent();
            mamh = MaMH;
            tenmh = TenMH;
            sotinchi = SoTinChi;
            tenGV = TenGV;
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmSuaThongTinMonHoc_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnSua_Click(object sender, EventArgs e)
        {           
            var editMH = db.MonHocs.Single(c => c.MonHoc_ID == mamh);
            editMH.TenMonHoc = txtTenMH.Text.Trim();
            editMH.SoTrinh =Convert.ToInt32(txtSoTinChi.Text.Trim());
            editMH.GiangVien = txtGiangVien.Text.Trim();
            DialogResult dl = MessageBox.Show("Bạn đã Sửa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                db.SubmitChanges();
            }            
        }

        private void frmSuaThongTinMonHoc_Load(object sender, EventArgs e)
        {
            txtMaMH.Text = mamh;
            txtTenMH.Text = tenmh;
            txtSoTinChi.Text = sotinchi.ToString().Trim();
            txtGiangVien.Text = tenGV;
        }
    }
}