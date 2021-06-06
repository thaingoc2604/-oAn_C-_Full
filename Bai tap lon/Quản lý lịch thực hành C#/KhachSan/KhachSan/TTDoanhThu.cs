using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using KetNoiDL;

namespace KhachSan
{
    public partial class TTDoanhThu : Form
    {
        public TTDoanhThu()
        {
            InitializeComponent();
        }

        TTKetNoi tt = new TTKetNoi();
        DataView dv = new DataView();

        public void Load_List()
        {
            listView1.Items.Clear();
            dv = tt.getDataView("DoanhThu");
            foreach (DataRow dr in dv.Table.Rows)
            {
                ListViewItem i = new ListViewItem();
                i.Text = dr["MaPhong"].ToString();
                i.SubItems.Add(dr["LoaiPhong"].ToString());
                i.SubItems.Add(dr["MaKH"].ToString());
                i.SubItems.Add(Convert.ToDateTime(dr["NgayThue"]).ToShortDateString());
                if (dr["NgayTra"].ToString() != "")
                    i.SubItems.Add(Convert.ToDateTime(dr["NgayTra"]).ToShortDateString());
                else
                    i.SubItems.Add("");
                i.SubItems.Add(dr["SoNgayThue"].ToString());
                i.SubItems.Add(dr["DonGia"].ToString());
                i.SubItems.Add(dr["ThanhTien"].ToString());

                if (i.SubItems[5].Text != "")
                    listView1.Items.Add(i);
            }
        }

        public void Tong()
        {
            double t = 0;
            foreach (ListViewItem i in listView1.Items)
            {
                double n = Convert.ToDouble(i.SubItems[7].Text);
                t += n;                
            }
            txtTong.Text = t.ToString();
        }

        private void TTDoanhThu_Load(object sender, EventArgs e)
        {

            Load_List();
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 50; i--)
            {
                cmbNam.Items.Add(i);
            }

            Tong();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_List();
            foreach (ListViewItem i in listView1.Items)
            {
                if (Convert.ToDateTime(i.SubItems[4].Text).Year.ToString() != cmbNam.Text)
                    i.Remove();
            }

            if (cmbThang.Text != "")
            {
                foreach (ListViewItem i in listView1.Items)
                {
                    if (Convert.ToDateTime(i.SubItems[4].Text).Month.ToString() != cmbThang.Text)
                        i.Remove();
                }
            }

            Tong();
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_List();
            foreach (ListViewItem i in listView1.Items)
            {
                if (Convert.ToDateTime(i.SubItems[4].Text).Month.ToString() != cmbThang.Text)
                    i.Remove();
            }
            if (cmbNam.Text != "")
            {
                foreach (ListViewItem i in listView1.Items)
                {
                    if (Convert.ToDateTime(i.SubItems[4].Text).Year.ToString() != cmbNam.Text)
                        i.Remove();
                }
            }
            Tong();
        }

       
        
    }
}