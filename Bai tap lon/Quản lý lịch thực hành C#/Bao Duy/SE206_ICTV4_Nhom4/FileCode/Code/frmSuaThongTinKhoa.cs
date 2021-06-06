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
    public partial class frmSuaThongTinKhoa : DevComponents.DotNetBar.Office2007Form
    {
        string makhoa;
        string tenkhoa;
        public frmSuaThongTinKhoa(string Khoa_id,string TenKhoa)
        {
            InitializeComponent();
            makhoa = Khoa_id;
            tenkhoa = TenKhoa;
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmSuaThongTinKhoa_Load(object sender, EventArgs e)
        {
            txtMaKhoa.Text = makhoa;
            txtTenKhoa.Text = tenkhoa;
        }

        private void frmSuaThongTinKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
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
                SuaThongTinKhoas();
        }

        private void SuaThongTinKhoas()
        {
            var editKhoa = db.Khoas.Single(c => c.Khoa_ID == makhoa);
            editKhoa.TenKhoa = txtTenKhoa.Text.Trim();
            DialogResult dl = MessageBox.Show("Bạn đã Sửa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                db.SubmitChanges();
            }
        }
    }
}