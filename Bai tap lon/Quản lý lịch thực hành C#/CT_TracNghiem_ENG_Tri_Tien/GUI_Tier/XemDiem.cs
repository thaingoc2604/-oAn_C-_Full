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
    public partial class XemDiem : Form
    {
        public XemDiem()
        {
            InitializeComponent();
        }
        KetQua_Bus kq;
        private void XemDiem_Load(object sender, EventArgs e)
        {
            lblSoDiem.Text = "Điểm của bạn là: " + LamBai_Thi.Diem;
            LamBai_Thi.vitri = 0;
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            kq = new KetQua_Bus(DangNhap.TenDangNhap, LamBai_Thi.ho, LamBai_Thi.ten, Student.made.Trim().ToString(),LamBai_Thi.Diem, DateTime.Now);
            if (kq.Luu_KetQua() > 0)
                MessageBox.Show("Đã lưu lại kết quả");
        }
    }
}
