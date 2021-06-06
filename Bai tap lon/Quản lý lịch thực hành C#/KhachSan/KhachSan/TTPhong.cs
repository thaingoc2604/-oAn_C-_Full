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
    public partial class TTPhong : Form
    {
        public TTPhong()
        {
            InitializeComponent();
        }

        TTKetNoi t = new TTKetNoi();
        DataView dv = new DataView();

        private void TTPhong_Load(object sender, EventArgs e)
        {
            Load_LoaiPhong();
            dataGridView1.Enabled = false;
        }

        public void Load_LoaiPhong()
        {
            OleDbDataReader read = t.getDataReader("HangPhong");
            lvwLoaiPhong.Items.Clear();
            while (read.Read())
            {
                ListViewItem i = new ListViewItem();
                i.Text = read["LoaiPhong"].ToString();
                i.SubItems.Add(read["DonGia"].ToString());
                lvwLoaiPhong.Items.Add(i);                
            }
        }


        private void lvwLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhong();

        }


        public void LoadPhong()
        {
            lvwPhong.Items.Clear();

            foreach (ListViewItem lis in lvwLoaiPhong.SelectedItems)
            {
                OleDbDataReader r = t.getDataReader("Phong");
                while (r.Read())
                {                    
                    if (r["LoaiPhong"].ToString().Equals(lis.Text))
                    {
                        ListViewItem i = new ListViewItem();
                        i.Text = r["MaPhong"].ToString();
                        i.SubItems.Add(r["LoaiPhong"].ToString());
                        i.SubItems.Add(r["SoNguoi"].ToString());
                        i.SubItems.Add((bool)r["TinhTrang"] == true ? "Trống" : "Đầy"); ;
                        lvwPhong.Items.Add(i);
                    }                    
                }
            }
            if (radioButton1.Checked)
            {
                foreach (ListViewItem i in lvwPhong.Items)
                {
                    if(i.SubItems[3].Text.Equals("Đầy"))                   
                        lvwPhong.Items.Remove(i);
                }
            }

            if (radioButton2.Checked)
            {
                foreach (ListViewItem i in lvwPhong.Items)
                {
                    if (i.SubItems[3].Text.Equals("Trống"))
                        lvwPhong.Items.Remove(i);
                }
            }
            dataGridView1.DataSource = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void lvwPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvwPhong.SelectedItems)
            {
                dv = t.getChiTietPhong(i.Text);
                dataGridView1.DataSource = dv;
            }
        }

        private void chọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvwLoaiPhong.Items)
            {
                i.Selected = true;
            }
        }
   }
}