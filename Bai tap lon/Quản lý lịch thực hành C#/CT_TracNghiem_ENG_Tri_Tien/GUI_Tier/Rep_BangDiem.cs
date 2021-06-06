using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bus_Tier;
using System.IO;
namespace GUI_Tier
{
    public partial class Rep_BangDiem : Form
    {
        public Rep_BangDiem(String tendangnhap)
        {
            InitializeComponent();
            Print_1SinhVien(tendangnhap);
        }
        KetQua_Bus kq;
        Report_Bus re;
        private void Print_1SinhVien(String tendangnhap)
        {
            re = new Report_Bus();
            Rep_BangDiem_Rep rep = new Rep_BangDiem_Rep();
            rep.SetDataSource(re.Show_ThongTin_Report(tendangnhap).Tables["tb_user"]);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
