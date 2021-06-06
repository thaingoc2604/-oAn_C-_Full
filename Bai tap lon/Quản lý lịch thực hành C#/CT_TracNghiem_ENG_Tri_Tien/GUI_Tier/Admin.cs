using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tier
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void mnuHienThi_CauHoi_Click(object sender, EventArgs e)
        {
            Teacher frm = new Teacher();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            Report_Center re = new Report_Center();
            re.MdiParent = this;
            re.Show();
        }

        private void mnuBangDiem_Click(object sender, EventArgs e)
        {
            BangDiem bangdiem = new BangDiem(1);
            bangdiem.MdiParent = this;
            bangdiem.Show();
        }

        private void mnuQuanLy_ThemSV_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy(1);
            dk.MdiParent = this;
            dk.Show();
        }

        private void mnu_QuanLy_SuaThongTin_Click(object sender, EventArgs e)
        {
            SuaThongTin sua = new SuaThongTin();
            sua.MdiParent = this;
            sua.Show();
        }
    }
}
