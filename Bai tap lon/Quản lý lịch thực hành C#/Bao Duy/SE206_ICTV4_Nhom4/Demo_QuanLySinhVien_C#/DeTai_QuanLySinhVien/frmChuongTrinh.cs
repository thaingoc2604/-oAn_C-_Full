using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeTai_QuanLySinhVien
{
    public partial class frmChuongTrinh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        

        public frmChuongTrinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableMenu();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDanhSachSV));
            if (frm != null)
            frm.Activate();
            else
            {
            frmDanhSachSV f = new frmDanhSachSV();
                        f.MdiParent = this;                       
                        f.Show();
            }  
        }
        private void btnKhoa_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDanhSachKhoa));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDanhSachKhoa f = new frmDanhSachKhoa();
                f.MdiParent = this;               
                f.Show();
            }
        }
        private void btnLop_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDanhSachLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDanhSachLop f = new frmDanhSachLop();
                f.MdiParent = this;                
                f.Show();
            }
        }

        private void bntMonHoc_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDanhSachMonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDanhSachMonHoc f = new frmDanhSachMonHoc();               
                f.MdiParent = this;               
                f.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmTimKiemSinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTimKiemSinhVien f = new frmTimKiemSinhVien();
                f.MdiParent = this;                
                f.Show();
            }
        }

        private void rbitemBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmBaoCao));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBaoCao f = new frmBaoCao();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void EnableMenu()
        {
            ribbarThongTin.Enabled = true;
            ribbarBaoCao.Enabled = true;
            ribbarTimKiem.Enabled = true;
            ribbarTroGiup.Enabled = true;
        }
        public void DisableMenu()
        {
            ribbarThongTin.Enabled = false;
            ribbarBaoCao.Enabled = false;
            ribbarTimKiem.Enabled = false;
            ribbarTroGiup.Enabled = false;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DisableMenu();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            frmDangNhapAdmin f = new frmDangNhapAdmin();
            f.MdiParent = this;
            f.Show();
        }

        private void frmChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmTroGiup));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTroGiup f = new frmTroGiup();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
