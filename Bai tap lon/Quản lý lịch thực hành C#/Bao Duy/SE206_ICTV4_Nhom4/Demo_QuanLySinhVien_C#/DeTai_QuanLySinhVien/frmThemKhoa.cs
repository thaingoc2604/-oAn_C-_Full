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
    public partial class frmThemKhoa : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemKhoa()
        {
            InitializeComponent();
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "" || txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Chưa nhập đủ thông tin khoa !"," Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
            else
            {
                ThemKhoa();
            }
        }

        private void ThemKhoa()
        {
            Khoa themKhoa = new Khoa();
            themKhoa.Khoa_ID = txtMaKhoa.Text.Trim();
            themKhoa.TenKhoa = txtTenKhoa.Text.Trim();
            db.Khoas.InsertOnSubmit(themKhoa);
            DialogResult dl = MessageBox.Show("Bạn đã thêm khoa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                db.SubmitChanges();
            }
        }

        private void frmThemKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình không ?", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemKhoa_Load(object sender, EventArgs e)
        {

        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string MaKhoa = txtMaKhoa.Text.Trim();
                var sv = from Khoa in db.Khoas where Khoa.Khoa_ID == MaKhoa select Khoa;
                foreach (var malop in sv)
                {
                    MessageBox.Show("Mã Sinh viên bị trùng, mời bạn nhập lại");
                    txtMaKhoa.Text = "";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}