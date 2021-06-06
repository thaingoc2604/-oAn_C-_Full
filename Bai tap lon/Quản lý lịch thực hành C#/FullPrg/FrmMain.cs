using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;

using System.Diagnostics;



namespace FullPrg
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        // true chay
        // false dong
        // an hien cac mn
        public void enablekhach()
        {
            giấyHẹnToolStripMenuItem.Enabled = true;
            hàngToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
        }
        public void enablebanhang()
        {
            mnBH.Enabled = true;
            mntimkiem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
        }
        public void enablenhaphang()
        {
            mnnh.Enabled = true;
            mntimkiem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
        }
        public void disablebanhang()
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = false;

            mnBH.Enabled = false;
        }
        public void disablenhaphang()
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = false;
            mnnh.Enabled = false;
            //đăngNhậpToolStripMenuItem.Enabled = false;
            //đăngXuấtToolStripMenuItem.Enabled = true;

        }
        public void enablebaocao()
        {
            mnbaocao.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;

        }
        public void disabletimkiem()
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = false;
            mntimkiem.Enabled = false;
        }

        public void enabletimkiem()
        {
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
            mntimkiem.Enabled = true;
        }
        public void disablebaocao()
        {
            mnbaocao.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = false;
        }


        public void enablefull()
        {
            quảnLýNgườiDùngToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
            mnbaocao.Enabled = true;
            mnHT.Enabled = true;
            mnnh.Enabled = true;
            mntimkiem.Enabled = true;
            mnBH.Enabled = true;
          //  mnHT.Enabled = true;

        }
        public void disfull()
        {
           // mnHT.Enabled = false;
            mnBH.Enabled = false;
            mnnh.Enabled = false;
            mntimkiem.Enabled = false;
            mnbaocao.Enabled = false;
            //mntacgia.Enabled = false; 
            quảnLýNgườiDùngToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = false;


        }
        public void dangxuatdong()
        {
            disfull();
            đăngXuấtToolStripMenuItem.Enabled =false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngKíToolStripMenuItem.Enabled = true;
            quảnLýNgườiDùngToolStripMenuItem.Enabled = false;
            sửaMậtKhẩuToolStripMenuItem.Enabled = false;

        }
        public void dangxuathien()
        {
            đăngXuấtToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngKíToolStripMenuItem.Enabled = false;
            quảnLýNgườiDùngToolStripMenuItem.Enabled = false;
            sửaMậtKhẩuToolStripMenuItem.Enabled = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            disfull();
            dangxuatdong();

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmlog = new FrmLogin();
            frmlog.MdiParent = this;
            frmlog.Show();

        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReg frmreg = new FrmReg();
            frmreg.MdiParent = this;
            frmreg.Show();

        }

        private void sửaMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRePass frmrepass = new FrmRePass();
            frmrepass.MdiParent = this;
            frmrepass.Show();

        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            frm.MdiParent = this;
            frm.Show();


        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBUY frm = new FrmBUY();
            frm.MdiParent = this;
            frm.Show();

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHang frmnhap = new FrmHang();
            frmnhap.MdiParent = this;
            frmnhap.Show();

        }

        private void tìmKiếmThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFind tim = new FrmFind();
            tim.MdiParent = this;
            tim.Show();


        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepost frmbaocao = new FrmRepost();
            frmbaocao.MdiParent = this;
            frmbaocao.Show();

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtacgia frmtg = new frmtacgia();
            frmtg.MdiParent = this;
            frmtg.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disfull();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepost frmbaocao = new FrmRepost();
            frmbaocao.MdiParent = this;
            frmbaocao.Show();

        }

        private void hươngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\Help.chm";
                p.Start();
            }
            catch
            {
                MessageBox.Show("Mở file Help.chm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsoft so = new frmsoft();
            so.MdiParent = this;
            so.Show();

         

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void khácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\Help.pdf";
                p.Start();
            }
            catch
            {
                MessageBox.Show("Mở file Help.pdf thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
