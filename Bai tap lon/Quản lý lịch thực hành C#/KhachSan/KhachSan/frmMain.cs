using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool KTFormCon(string s)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(s))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (KTFormCon("TTPhong") == false)
            {
                TTPhong t = new TTPhong();
                t.MdiParent = this;
                t.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTFormCon("TTKhachHang") == false)
            {
                TTKhachHang t = new TTKhachHang();
                t.MdiParent = this;
                t.Show();
            }
        }

        

        private void chiTiếtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTFormCon("QuanLyKhachHang") == false)
            {
                QuanLyKhachHang t = new QuanLyKhachHang();
                t.MdiParent = this;
                t.Show();
            }
        }

        private void phòngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void doanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTFormCon("TTDoanhThu") == false)
            {
                TTDoanhThu t = new TTDoanhThu();
                t.MdiParent = this;
                t.Show();
            }
        }

        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult w = MessageBox.Show("Bạn Có Chắc Muốn Thoát?", "Thông Báo",MessageBoxButtons.YesNo);

            if (w == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đặtTrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTFormCon("DatTraPhong") == false)
            {
                DatTraPhong t = new DatTraPhong();
                t.MdiParent = this;
                t.Show();
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTFormCon("TimKiem") == false)
            {
                TimKiem t = new TimKiem();
                t.MdiParent = this;
                t.Show();
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap d = new DangNhap();
            DialogResult dia = d.ShowDialog();
            if (dia == DialogResult.Yes)
            {
                quảnLýToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quảnLýToolStripMenuItem.Enabled = false;
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KTFormCon("QuanLyPhongvaTB") == false)
            {
                QuanLyPhongvaTB t = new QuanLyPhongvaTB();
                t.MdiParent = this;
                t.Show();
            }
        }
                
    }
}