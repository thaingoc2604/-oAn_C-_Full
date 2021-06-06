using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace QuanLyTV
{
    public partial class TKDangMuonSach : Form
    {
        AccessHelper help = new AccessHelper();
        public DataTable TKMuon;

        public TKDangMuonSach()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }

        private void TKDangMuonSach_Load(object sender, EventArgs e)
        {
            string TruyVan = "select m.masophieumuon,m.madocgia,d.HoTen,s.TenSach,n.HoTen from TableDocGia d,TableNhanVien n,TableSach s,TableMuonTraSach m where m.madocgia = d.madocgia and m.manhanvien = n.manhanvien and m.masach = s.masach ";
            TKMuon = help.TaoTable(TruyVan);
            ListViewItem item;
            listMuonSach.Items.Clear();
            label1.Text = "Tổng số phiếu : " + TKMuon.Rows.Count.ToString();
            label2.Text = "Người Đăng Nhập : " + AccessHelper.TenNhanVienDangNhap.ToString();
            for (int i = 0; i < TKMuon.Rows.Count; i++)
            {

                item = listMuonSach.Items.Add(TKMuon.Rows[i][0].ToString());
                for (int j = 1; j < TKMuon.Columns.Count; j++)
                    item.SubItems.Add(TKMuon.Rows[i][j].ToString());
            }
            Form1.DaMo[6] = 1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }

        private void TKDangMuonSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[6] = 0;
        }
    }
}
