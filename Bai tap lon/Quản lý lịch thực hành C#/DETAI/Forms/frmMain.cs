using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace DETAI
{
    public partial class frmMain : Form
    {
        //khai báo biến toàn cục
        public static frmMain me;
        public mysql libsql;
        public frmMain()
        {
            me = this;
            InitializeComponent();
            
            libsql = new mysql(frmcauhinh.server,frmcauhinh.data,
                "U0", "123");
            this.menuStrip1.Visible = false;
            frmlogin  lg = new frmlogin();
            lg.MdiParent = this;
            lg.Show();
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

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMDanToc"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMDanToc));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMDanToc f = new frmDMDanToc();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMChucVu"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMChucVu));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMChucVu f = new frmDMChucVu();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhMụcChuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMChuyenMon"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMChuyenMon));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMChuyenMon f = new frmDMChuyenMon();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhMụcNgoạiNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMNgoaiNgu"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMNgoaiNgu));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMNgoaiNgu f = new frmDMNgoaiNgu();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMHieuQua"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMHieuQua));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMHieuQua f = new frmDMHieuQua();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhMụcLoạiHĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMLoaiHD"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMLoaiHD));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMLoaiHD f = new frmDMLoaiHD();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhMụcTônGiáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMTonGiao"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMTonGiao));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMTonGiao f = new frmDMTonGiao();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhMụcTrìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMTrinhDo"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMTrinhDo));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMTrinhDo f = new frmDMTrinhDo();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhMụcPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMPhongBan"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMPhongBan));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMPhongBan f = new frmDMPhongBan();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
            
        }

        private void danhMụcTổToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMTo"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMTo));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMTo f = new frmDMTo();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void hồSơCNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmNhanvien"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmNhanvien));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmNhanvien f = new frmNhanvien();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private string ChuoiTruyCapForm(string ten)
        {
            return "Select * from tbl_user_form U inner join " +
                "tbl_DMform F on U.IDform=F.ID where U.username='" + libsql.GetUser() + "' and  F.tenform='" + ten + "' and U.rights=1";
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmPhanQuyen));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPhanQuyen f = new frmPhanQuyen();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void dieudongNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDoiMatKhau));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tạoNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmUser));
            if (frm != null)
                frm.Activate();
            else
            {
                frmUser f = new frmUser();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void hồSơĐiềuĐộngKThưởngKLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmNhanvien"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmQTDieuDong));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmQTDieuDong f = new frmQTDieuDong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
             else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void danhmuchieuquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void bảngChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmkiemtrabangluong"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmkiemtrabaocao));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmkiemtrabaocao f = new frmkiemtrabaocao();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void danhmuchieuquaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMHieuQua"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMHieuQua));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMHieuQua f = new frmDMHieuQua();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void bangtieleluongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmbangtileluong"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmbangtileluong));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmbangtileluong f = new frmbangtileluong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!","Thông Báo");
                sc.Close();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinVềSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGTSP f = new frmGTSP();
            f.MdiParent = this;
            f.Show();
        }

        private void hoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmKiemTraHDHetHan"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmKiemTraHDHetHan));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmKiemTraHDHetHan f = new frmKiemTraHDHetHan();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();
        }

        private void báoCáoLươngthángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmchonbcluong"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmchonbcluong));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmchonbcluong f = new frmchonbcluong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();           
        }

        private void báoCáoNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.libsql.getCon();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmchonbcnv"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmchonbcnv));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmchonbcnv f = new frmchonbcnv();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập!!!", "Thông Báo");
            sc.Close();           
            
        }

        private void hướngDẫnSửDụngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\tro giup\\help.chm");
        }       
    }
}