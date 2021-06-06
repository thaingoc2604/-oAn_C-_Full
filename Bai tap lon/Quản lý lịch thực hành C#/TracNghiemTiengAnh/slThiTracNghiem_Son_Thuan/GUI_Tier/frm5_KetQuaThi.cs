﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;
namespace GUI_Tier
{
    public partial class frm5_KetQuaThi : Form
    {
        
        public frm5_KetQuaThi()
        {
            InitializeComponent();
        }
        B_KetQua kq = new B_KetQua();
        B_ThiSinh B_TS = new B_ThiSinh();
        B_MonThi B_MT = new B_MonThi();
        private void frm5_KetQuaThi_Load(object sender, EventArgs e)
        {
           xemdiemcuanguoithi(frm1_DN.mathisinh);

           

        }
        private void xemdiemcuanguoithi(string mathisinh)
        {
            try
            {

                // string mamonthi;
                //--điểm này xem theo từng thí sinh
                DataTable dt_xemdiem = new B_KetQua().XemDiem_B(mathisinh);

                //----họ tên
                lblHoten.Text = frm1_DN.TenThiSinhDiThi;

                //------môn thi
                //-----------------lấy ra mã môn dưa vào mã thí sinh
                //mamonthi = dt_xemdiem.Rows[0]["mamon"].ToString();
                //------------------lấy ra môn thi dựa vào mã môn đã có
                DataTable dt_monthi = new B_MonThi().GetMonThi_Theo_MaMon_B(dt_xemdiem.Rows[0]["mamon"].ToString());
                lblMonThi.Text = dt_monthi.Rows[0]["tenmon"].ToString();
                //----diểm thi
                lblDiem.Text = dt_xemdiem.Rows[0]["diem"].ToString();
                //----ngày thi
                dtpic.Text = dt_xemdiem.Rows[0]["ngaythi"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn Chưa Có Điểm Để Xem !!","Thông Báo !!");
            }
            
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text.Equals("Xem Điểm Tất Cả Thí Sinh Khác"))
            {
                this.Size = new System.Drawing.Size(498, 525);
                this.Location = new Point(this.Location.X, this.Location.Y - 40);
                btnxem.Text = "ĐÓNG CỬA SỔ";

                lvwDiem.Items.Clear();
                DataTable dt_diemtatca = kq.XemDiem_All_B();
                foreach (DataRow r in dt_diemtatca.Rows)
                {
                    //=-lấy tên thí sinh dựa vào mã thí sinh trong bảng này
                    //string mathisinh = r["mathisinh"].ToString();


                   // DataTable dt_thisinh = B_TS.LayThiSinh_TheoMaTS_b(mathisinh);
                    ListViewItem li = lvwDiem.Items.Add(r["tenthisinh"].ToString());
                    //----====lấy tên môn theo mã môn trong bảng này
                    string mamon = r["mamon"].ToString();
                    DataTable dt_mon = B_MT.GetMonThi_Theo_MaMon_B(mamon);
                    li.SubItems.Add(dt_mon.Rows[0]["tenmon"].ToString());
                    //--------diểm
                    li.SubItems.Add(r["diem"].ToString());
                    //--------ngày thi
                    li.SubItems.Add(r["ngaythi"].ToString());

                }
            }
            else
            {
                this.Size = new System.Drawing.Size(498, 324);
                this.Location = new Point(this.Location.X, this.Location.Y + 40);
                btnxem.Text = "Xem Điểm Tất Cả Thí Sinh Khác";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmINBANGDIEM f = new frmINBANGDIEM();
            f.Show();
        }

        private void pic_TroVe_Click(object sender, EventArgs e)
        {
            frm2_GiaoDienChinh frm = new frm2_GiaoDienChinh();
            frm.Show();
            this.Hide();
        }

        private void pic_IN_Click(object sender, EventArgs e)
        {
            frmINBANGDIEM f = new frmINBANGDIEM();
            f.Show();
        }

    }
}
