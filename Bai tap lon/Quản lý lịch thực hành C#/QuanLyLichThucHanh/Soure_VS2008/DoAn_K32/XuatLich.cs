using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DTO;
using BussinessLayer;
using DataAccess;
using System.Windows.Forms;

namespace DoAn_K32
{
    public partial class XuatLich : Form
    {
        public XuatLich()
        {
            InitializeComponent();
        }

        private void XuatLich_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //cbbTuan.DataSource = LichBus.LayTuan_Lich();
            //cbbTuan.DisplayMember = "Tuan";
            //cbbLop.DataSource = LopBus.GetAll_Lop();
            //cbbLop.DisplayMember = "TenLop";
            //cbbLop.ValueMember = "MaLop";
            //txtMaLopp.DataBindings.Add("text", cbbLop.DataSource, "MaLop");
            //txtMaGVV.DataBindings.Add("text", cbbGiaoVien.DataSource, "MaGV");
            //txtMaMHH.DataBindings.Add("text", cbbMonHoc.DataSource, "MaMH");
            //txtTiett.DataBindings.Add("text", cbbTiet.DataSource, "MaTG");
            //txtPhongg.DataBindings.Add("text", cbbPhong.DataSource, "MaPHG");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
