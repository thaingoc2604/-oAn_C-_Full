using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KetNoiDL;
using System.Data.OleDb;

namespace KhachSan
{
    public partial class TTKhachHang : Form
    {
        public TTKhachHang()
        {
            InitializeComponent();
        }

        TTKetNoi TT = new TTKetNoi();
        int vitri = 0;

        private void TTKhachHang_Load(object sender, EventArgs e)
        {
            int dem = 1;
            OleDbDataReader dr = TT.getDataReader("KhachHang");
            while (dr.Read())
            {
                ListViewItem i = new ListViewItem();
                i.Text = dr["MaKH"].ToString();
                i.SubItems.Add(dr["TenKH"].ToString());
                i.SubItems.Add(dr["SoCMND"].ToString());
                i.SubItems.Add(dr["SoDT"].ToString());
                i.SubItems.Add(dr["DiaChi"].ToString());
                i.Tag = dem.ToString();
                dem++;
                listView1.Items.Add(i);
            }

            if (listView1.Items.Count > 0)
            {
                txtMaKH.Text = listView1.Items[0].SubItems[0].Text;
                txtTenKH.Text = listView1.Items[0].SubItems[1].Text;
                txtCMND.Text = listView1.Items[0].SubItems[2].Text;
                txtSoDT.Text = listView1.Items[0].SubItems[3].Text;
                txtDChi.Text = listView1.Items[0].SubItems[4].Text;

                lblVT.Text = "1/"+listView1.Items.Count;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.SelectedItems)
            { 
                txtMaKH.Text = i.SubItems[0].Text;
                txtTenKH.Text = i.SubItems[1].Text;
                txtCMND.Text = i.SubItems[2].Text;
                txtSoDT.Text = i.SubItems[3].Text;
                txtDChi.Text = i.SubItems[4].Text;

                lblVT.Text = i.Tag + "/" + listView1.Items.Count;
            }
        }

        public void HienTT(int d)
        {
            txtMaKH.Text = listView1.Items[d].SubItems[0].Text;
            txtTenKH.Text = listView1.Items[d].SubItems[1].Text;
            txtCMND.Text = listView1.Items[d].SubItems[2].Text;
            txtSoDT.Text = listView1.Items[d].SubItems[3].Text;
            txtDChi.Text = listView1.Items[d].SubItems[4].Text;

            lblVT.Text = (d + 1) + "/" + listView1.Items.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vitri < listView1.Items.Count - 1)
            {
                vitri++;
                HienTT(vitri);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (vitri > 0)
            {
                vitri--;
                HienTT(vitri);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vitri = 0;
            HienTT(vitri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vitri = listView1.Items.Count - 1;
            HienTT(vitri);
        }

        
    }
}