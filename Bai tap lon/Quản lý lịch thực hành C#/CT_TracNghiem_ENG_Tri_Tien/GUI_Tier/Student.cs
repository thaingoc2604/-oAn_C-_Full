using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bus_Tier;
namespace GUI_Tier
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        User_Bus us;
        DeThi_Bus dethi;
        public static String made;
        public void Load_Form()
        {
            HienThiMaDe();
            us = new User_Bus(DangNhap.TenDangNhap, DangNhap.MatKhau);
            MemoryStream str = new MemoryStream(us.Ret_Pic());
            picHinhAnhSV.Image = Image.FromStream(str);
            DataTable dt = us.Get_ThongTin_User().Tables["tb_user"] ;
            DataRow dr = dt.Rows[0];
            lblHoTen.Text = dr["Ho"].ToString() + " " + dr["Ten"].ToString();
            lblDiaChi.Text = dr["DiaChi"].ToString();
            dtpNgaySinh.Value = DateTime.Parse(dr["ngaysinh"].ToString());
        }
        private void HienThiMaDe()
        {
            dethi = new DeThi_Bus();
            DataTable dt = new DataTable();
            dt = dethi.HienThi_MaDe_All().Tables["tb_dethi"];
            foreach (DataRow dr_cbo in dt.Rows)
            {
                cboChonDe.Items.Add(dr_cbo["made"].ToString());
            }
        }
        private void Student_Load(object sender, EventArgs e)
        {
            Load_Form();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DoiMatKhau doimk = new DoiMatKhau();
            doimk.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BangDiem diem = new BangDiem();
            diem.ShowDialog();
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            if (cboChonDe.Text == "")
            {
                MessageBox.Show("Chọn đề thi!");
                return;
            }
            else
            {
                made = cboChonDe.Text;
                this.DialogResult = DialogResult.OK;
            }
        }      
    }
}
