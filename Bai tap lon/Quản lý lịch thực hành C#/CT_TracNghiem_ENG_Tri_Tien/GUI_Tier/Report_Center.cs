using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bus_Tier;
namespace GUI_Tier
{
    public partial class Report_Center : Form
    {
        public Report_Center()
        {
            InitializeComponent();
        }
        User_Bus us;
        KetQua_Bus kq;
        private void btnInDiemSV_Click(object sender, EventArgs e)
        {
            if (cboTenDangNhap.Text != "")
            {
                Rep_BangDiem rep = new Rep_BangDiem(cboTenDangNhap.Text);
                rep.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Tên Đăng Nhập của Thí Sinh");
            }
        }

        private void Report_Center_Load(object sender, EventArgs e)
        {
            us = new User_Bus();
            cboTenDangNhap.DataSource = us.Get_All_User();
            cboTenDangNhap.DisplayMember = "id";
            cboTenDangNhap.ValueMember = "id";
        }

        private void btnInDiemTatCa_Click(object sender, EventArgs e)
        {
            Report_All_SinhVien_Form re = new Report_All_SinhVien_Form();
            re.ShowDialog();
        }

    }
}
