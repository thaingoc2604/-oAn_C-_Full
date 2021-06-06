using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace QuayThuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin call = new frmlogin();
            call.MdiParent = this;
            call.Show();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKi call1 = new frmDangKi();
            call1.MdiParent = this;
            call1.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//
                //;
        }

        private void danhMụcThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThuoc callthuoc = new FrmThuoc();
            callthuoc.MdiParent = this;
            callthuoc.Show();

        }

        private void thôngTinKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhach callkhach = new FrmKhach();
            callkhach.MdiParent = this;
            callkhach.Show();

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBan callban = new FrmBan();
            callban.MdiParent = this;
            callban.Show();

        }

        private void bảnKêĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBan callban = new FrmBan();
            callban.MdiParent = this;
            callban.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThuoc callthuoc = new FrmThuoc();
            callthuoc.MdiParent = this;
            callthuoc.Show();

        }

        private void doanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDoanhThu calldoanhthu = new FrmDoanhThu();
            calldoanhthu.MdiParent = this;
            calldoanhthu.Show();

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHuongDan callhuongdan = new FrmHuongDan();
            callhuongdan.MdiParent = this;
            callhuongdan.Show();

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTacGia calltacgia = new FrmTacGia();
            calltacgia.MdiParent = this;
            calltacgia.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
