using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;


namespace GUI_Tier
{
    public partial class frm2_GiaoDienChinh : Form 
    {

        B_ThiSinh B_TS = new B_ThiSinh();

        public string LayMaNV_GDC = "";
        public static string s = "                                                    ";
        public static string manhanvien;

        public frm2_GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTT.Text = s;
            string tam = s[0].ToString();
            s = s.Substring(1, s.Length - 1) + tam;          
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void picQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (frm1_DN.chon == "Thí Sinh" || frm1_DN.chucvu.Trim() == "Nhân Viên")
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập !!");
            }
            else
            {
                if (radNhanVien.Checked == false && radThiSinh.Checked == false)
                {
                    MessageBox.Show("Bạn Chưa Chọn Loại Tài Khoản Nào \n \n Vui Lòng Chọn 1 Trong 2 Tài Khoản Ở Trên !! \n\n Xin Cảm Ơn");
                }
                else
                {
                    if (radNhanVien.Checked == true)
                    {
                        frm8_QuanLyTaiKhoan_NhanVien nv = new frm8_QuanLyTaiKhoan_NhanVien();
                        nv.Show();
                        this.Hide();
                    }
                    else
                    {
                        frm9_QuanLyThiSinh ts = new frm9_QuanLyThiSinh();
                        ts.Show();
                        this.Hide();
                    }
                }

            }
        }

        private void picQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            if (frm1_DN.chon == "Thí Sinh" || frm1_DN.chucvu.Trim() == "Nhân Viên")
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập !!");
            }
            else
            {
                frm6_QuanLyCauHoi frmcauhoi = new frm6_QuanLyCauHoi();
                frmcauhoi.laymanhanvien_QLCH = LayMaNV_GDC;
                frmcauhoi.Show();
                this.Hide();
            }
        }

        private void pic_ThiTracNghiem_Click(object sender, EventArgs e)
        {
            frm3_ThiTracNghiem frm = new frm3_ThiTracNghiem();
            frm.Show();
            this.Hide();
        }

        private void pic_XemDiem_Click(object sender, EventArgs e)
        {
            if (frm1_DN.chon == "Thí Sinh")
            {
                frm5_KetQuaThi frm = new frm5_KetQuaThi();
                frm.Show();
                this.Hide();
            }
            else
            {
                if (MessageBox.Show("Bạn có Muốn In Bảng Điểm Các Thí Sinh Không ??", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmINBANGDIEM f = new frmINBANGDIEM();
                    f.Show();
                }
            }
        }

        private void pic_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Đã Chắc Chắn Muốn Thoát ??", "Thông Báo !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pic_DangNhapLai_Click(object sender, EventArgs e)
        {
            frm1_DN dn = new frm1_DN();
            dn.Show();
            this.Hide();
        }

        private void frm2_GiaoDienChinh_Load(object sender, EventArgs e)
        {
            manhanvien = frm1_DN.manhanvien;
        }
        
    }
}
