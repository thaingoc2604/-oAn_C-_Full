using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MDS.BussinessRule;


namespace AnTCafe
{
    public partial class frmThongKeBanHang : Form
    {
        string strSQL = "";
        clsCommonUI objCommonUI = new clsCommonUI();
        clsBNhanVien objNhanVien = new clsBNhanVien();
        clsBBan objBan = new clsBBan();

        DataTable tblTable = new DataTable();
        DataTable tblNhanVien = new DataTable();
        DataTable tblBan = new DataTable();

        public frmThongKeBanHang()
        {
            InitializeComponent();
            string con_str = ConfigurationManager.ConnectionStrings["AnTCafe.Properties.Settings.AnTCafeConnectionString"].ConnectionString;
            objNhanVien.ConnectionString = con_str;
            objNhanVien.Initialize();
            objBan.ConnectionString = con_str;
            objBan.Initialize();


            this.bindBan();
            this.bindNhanVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            strSQL = "SELECT Hang.MaHang, Hang.TenHang, (Sum(PhieuXuatCtiet.Soluong) + Sum(PhieuXuatCtiet.TraLai)) AS TongSoLuong, Sum(PhieuXuatCtiet.SoLuong*PhieuXuatCtiet.DonGia) AS TongDonGia";
            strSQL +=" FROM PhieuXuat RIGHT JOIN (Hang LEFT JOIN PhieuXuatCtiet ON Hang.MaHang = PhieuXuatCtiet.MaHang) ON PhieuXuat.SoPhieuXuat = PhieuXuatCtiet.SoPhieuXuat";
            strSQL += " WHERE Hang.MaHang like  '%" + txtMaHang.Text + "%' AND TenHang like '%" + txtTenHang.Text + "%' ";
            if(cboBan.SelectedValue.ToString() != "")
                strSQL += " AND PhieuXuat.MaBan = '"+ cboBan.SelectedValue.ToString() +"'";
            if (cboNhanVien.SelectedValue.ToString() != "")
                strSQL += " AND PhieuXuat.MaNV = '" + cboNhanVien.SelectedValue.ToString() + "'";
            strSQL += " AND (PhieuXuat.NgayXuat between #" + txtTuNgay.Value.Date.ToShortDateString() + "# AND #" + txtDenNgay.Value.Date.ToShortDateString() + "#) ";
            strSQL +=" GROUP BY Hang.MaHang, Hang.TenHang";
            strSQL += " ORDER BY Hang.MaHang";
            tblTable.Clear();
            tblTable = objCommonUI.getDataFromSQL(strSQL);
            dgvHangTon.AutoGenerateColumns = false;
            dgvHangTon.Columns["MaHang"].DataPropertyName = "MaHang";
            dgvHangTon.Columns["TenHang"].DataPropertyName = "TenHang";
            dgvHangTon.Columns["TongSoLuong"].DataPropertyName = "TongSoLuong";
            dgvHangTon.Columns["TongDonGia"].DataPropertyName = "TongDonGia";
            dgvHangTon.DataSource = tblTable;

            DataGridViewRowCollection drc = dgvHangTon.Rows;
            int intTongCong = 0;
            foreach (DataGridViewRow dr in drc) {
                intTongCong += Convert.ToInt32(dr.Cells["TongDonGia"].Value);
            }
            txtTongCong.Text = intTongCong.ToString();

        }

        private void bindBan()
        {
            tblBan.Clear();
            tblBan = objBan.SELECT_ALL();
            DataRow blank_row = tblBan.NewRow();
            blank_row["MaBan"] = "";
            blank_row["Ten"] = "";
            tblBan.Rows.InsertAt(blank_row, 0);
            cboBan.DataSource = tblBan;
            cboBan.ValueMember = "MaBan";
            cboBan.DisplayMember = "Ten";
        }
        private void bindNhanVien()
        {
            tblNhanVien.Clear();
            tblNhanVien = objNhanVien.SELECT_ALL();
            DataRow blank_row = tblNhanVien.NewRow();
            blank_row["MaNV"] = "";
            blank_row["TenNV"] = "";
            tblNhanVien.Rows.InsertAt(blank_row, 0);
            cboNhanVien.DataSource = tblNhanVien;
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DisplayMember = "TenNV";
        }

    }
}