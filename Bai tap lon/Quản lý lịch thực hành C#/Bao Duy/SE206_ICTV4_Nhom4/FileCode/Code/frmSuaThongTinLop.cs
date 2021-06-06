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
    public partial class frmSuaThongTinLop : DevComponents.DotNetBar.Office2007Form
    {
        string malop;
        string tenlop;
        public frmSuaThongTinLop(string Lop_id,string TenLop)
        {
            InitializeComponent();
            malop = Lop_id;
            tenlop = TenLop;
        }
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        private void frmSuaThongTinLop_FormClosing(object sender, FormClosingEventArgs e)
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
            var editLop = db.Lops.Single(c => c.Lop_ID == malop);
            editLop.TenLop = txtTenlop.Text.Trim();
            DialogResult dl = MessageBox.Show("Bạn đã Sửa thành công !!", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                db.SubmitChanges();
            }
        }

        private void frmSuaThongTinLop_Load(object sender, EventArgs e)
        {
            txtMaLop.Text = malop;
            txtTenlop.Text = tenlop;
        }
    }
}