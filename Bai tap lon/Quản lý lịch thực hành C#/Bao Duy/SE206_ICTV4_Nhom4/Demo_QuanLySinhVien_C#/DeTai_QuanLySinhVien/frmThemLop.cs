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
    public partial class frmThemLop : DevComponents.DotNetBar.Office2007Form
    {
        string makhoa;
        public frmThemLop(string MaKhoa)
        {
            InitializeComponent();
            makhoa = MaKhoa;
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmThemLop_FormClosing(object sender, FormClosingEventArgs e)
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
            try
            {
                if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn Chưa nhập đủ thông tin lớp !", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    ThemLop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Lớp Bị Trùng "+ex.Message);
            }
            
        }

        private void ThemLop()
        {
            Lop themlop = new Lop();
            themlop.Lop_ID = txtMaLop.Text.Trim();
            themlop.TenLop = txtTenLop.Text.Trim();
            themlop.ID_Khoa = makhoa;
            db.Lops.InsertOnSubmit(themlop);
            DialogResult dl = MessageBox.Show("Bạn đã thêm Lớp thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                db.SubmitChanges();
            }
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string MaLop = txtMaLop.Text.Trim();
                var sv = from Lop in db.Lops where Lop.Lop_ID == MaLop select Lop;
                foreach (var malop in sv)
                {
                    MessageBox.Show("Mã Sinh viên bị trùng, mời bạn nhập lại");
                    txtMaLop.Text = "";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}