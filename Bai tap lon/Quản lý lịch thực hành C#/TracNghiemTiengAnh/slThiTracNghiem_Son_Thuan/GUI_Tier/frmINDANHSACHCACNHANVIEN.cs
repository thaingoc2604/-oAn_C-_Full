using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Business_Tier;

namespace GUI_Tier
{
    public partial class frmINDANHSACHCACNHANVIEN : Form
    {
        public frmINDANHSACHCACNHANVIEN()
        {
            InitializeComponent();
        }
        DataTable dt_nhanvie = new DataTable();
        B_NhanVien nv = new B_NhanVien();

        private void frmINDANHSACHCACNHANVIEN_Load(object sender, EventArgs e)
        {
            dt_nhanvie=nv.GetAll_NhanVien_B();
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.SetDataSource(dt_nhanvie);
            crv_DanhSachNhanVien.ReportSource=ds;
        }
    }
}
