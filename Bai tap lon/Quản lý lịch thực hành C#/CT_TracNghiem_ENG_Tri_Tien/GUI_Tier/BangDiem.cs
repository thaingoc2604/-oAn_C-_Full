using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Bus_Tier;

namespace GUI_Tier
{
    public partial class BangDiem : Form
    {
        public BangDiem()
        {
            InitializeComponent();
        }
        KetQua_Bus kq;
        public BangDiem(int n)
        {
            InitializeComponent();
            cboView.Visible = false;
            lvwDiemThi.Location=new Point(6,12);
            this.Size = new Size(477, 470);
        }
        String sapxep = "desc";
        private void Show_All_KQ(String tencot)
        {
            lvwDiemThi.Items.Clear();
            kq = new KetQua_Bus();
            DataView dv= kq.Show_All_KQ();
            if (sapxep == "desc")
            {
                sapxep = "asc";
                dv.Sort = tencot + " " + sapxep;
            }
            else
            {
                sapxep = "desc";
                dv.Sort = tencot + " " + sapxep; ;
            }
            foreach (DataRowView drv in dv)
            {
                ListViewItem li = lvwDiemThi.Items.Add(drv["Ho"].ToString() + " " + drv["Ten"].ToString());
                li.SubItems.Add(drv["MaDe"].ToString());
                li.SubItems.Add(drv["Diem"].ToString());
                li.SubItems.Add(drv["NgayThi"].ToString());
            }
        }
        private void Show_All_KQ_By_ID()
        {
            lvwDiemThi.Items.Clear();
            kq = new KetQua_Bus(DangNhap.TenDangNhap);
            DataView dv= kq.Show_All_KQ_By_ID();
            foreach (DataRowView drv in dv)
            {
                ListViewItem li = lvwDiemThi.Items.Add(drv["Ho"].ToString() + " " + drv["Ten"].ToString());
                li.SubItems.Add(drv["MaDe"].ToString());
                li.SubItems.Add(drv["Diem"].ToString());
                li.SubItems.Add(drv["NgayThi"].ToString());
            }
        }
        private void BangDiem_Load(object sender, EventArgs e)
        {
            Show_All_KQ("Diem");
        }

        private void lvwDiemThi_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                Show_All_KQ("Ten");
            }
            if (e.Column == 1)
            {
                Show_All_KQ("MaDe");
            }
            if (e.Column == 2)
            {
                Show_All_KQ("Diem");
            }
            if (e.Column == 3)
            {
                Show_All_KQ("NgayThi");
            }
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboView.SelectedIndex == 0)
            {
                Show_All_KQ("Diem");
            }
            else
            {
                Show_All_KQ_By_ID();
            }
        }
        
    }
}
