using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace AnTCafe
{
    public partial class frmThongKeHangTon : Form
    {
        string strSQL = "";
        clsCommonUI objCommonUI = new clsCommonUI();
        DataTable tblTable = new DataTable();
        public frmThongKeHangTon()
        {
            InitializeComponent();
        }

        private string buildingSQL() {
            strSQL = "";
            strSQL = "SELECT Hang.MaHang, Hang.TenHang, (select IIf(Sum([PhieuNhapCtiet].[Soluong]) Is Null,0,Sum([PhieuNhapCtiet].[Soluong])) from PhieuNhapCTiet where PhieuNhapCTiet.MaHang = Hang.MaHang ) as N, (select IIf(Sum([PhieuXuatCtiet].[Soluong]) Is Null,0,Sum([PhieuXuatCtiet].[Soluong])) from PhieuXuatCTiet where PhieuXuatCTiet.MaHang = Hang.MaHang ) as X, N-X as Ton " +
            " FROM Hang " +
            " WHERE Hang.MaHang Like '%" + txtMaHang.Text + "%' AND TenHang like '%" + txtTenHang.Text + "%' " +
            " ORDER BY Hang.MaHang ";
            if (txtSoLuong.Text != "")
                strSQL = "select * from (SELECT Hang.MaHang, Hang.TenHang, (select IIf(Sum([PhieuNhapCtiet].[Soluong]) Is Null,0,Sum([PhieuNhapCtiet].[Soluong])) from PhieuNhapCTiet where PhieuNhapCTiet.MaHang = Hang.MaHang ) as N, (select IIf(Sum([PhieuXuatCtiet].[Soluong]) Is Null,0,Sum([PhieuXuatCtiet].[Soluong])) from PhieuXuatCTiet where PhieuXuatCTiet.MaHang = Hang.MaHang ) as X, N-X as Ton" +
                         " FROM Hang "+
                         " WHERE Hang.MaHang Like '%" + txtMaHang.Text + "%' AND TenHang like '%" + txtTenHang.Text + "%' " +
                         " ORDER BY Hang.MaHang)"+
                         " where Ton <=" + txtSoLuong.Text;
                    
            return strSQL;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str;
            str = buildingSQL();
            tblTable.Clear();
            tblTable = objCommonUI.getDataFromSQL(str);
            dgvHangTon.AutoGenerateColumns = false;
            dgvHangTon.Columns["MaHang"].DataPropertyName = "MaHang";
            dgvHangTon.Columns["TenHang"].DataPropertyName = "TenHang";
            dgvHangTon.Columns["SoLuong"].DataPropertyName = "Ton";
            dgvHangTon.DataSource = tblTable;

        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
                if (!objCommonUI.isNumberic(txtSoLuong.Text))
                {
                    MessageBox.Show("Số lượng phải là số");
                    txtSoLuong.Focus();
                }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            CRViewer objCRViewer = new CRViewer();
            objCRViewer.TenReport = "THONGKEHANGTON";
            string str;
            str = buildingSQL();
            objCRViewer.CRQuery = str;
            objCRViewer.ShowDialog();

        }
    }
}