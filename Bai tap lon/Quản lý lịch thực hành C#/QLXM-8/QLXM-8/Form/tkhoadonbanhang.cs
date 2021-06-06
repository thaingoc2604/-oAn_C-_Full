using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLXM_8
{
    public partial class tkhoadonbanhang : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public tkhoadonbanhang()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
        //  private DataTable objDataTable1;
        #endregion
        #region "Tạo và hủy kết nối với database"
        private void ketnoidata()
        {
            String chuoikn = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                            "Data Source =" + Application.StartupPath + @"\qlxm.mdb;";
            objConnect = new OleDbConnection(chuoikn);
            objConnect.Open(); // Mở kết nối
        }
        private void huyketnoidata()
        {
            objConnect.Close(); // Đóng kết nối
            objConnect.Dispose(); // Giải phóng tài nguyên
            objConnect = null; // Hủy đối tượng
        }
        #endregion
        #region "Tìm kiếm dữ liệu dữ liệu"
        private void hiendulieu_timkiem_ma() // Tìm kiếm dữ liệu theo mã
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Hoa_Don_Ban_Xe Where MaHD LIKE '%" + txt_mahd.Text + "%' ORDER BY STT";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter = new OleDbDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            Grid1.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối
            huyketnoidata();
        }
        private void hiendulieu_timkiem_makh() // Tìm kiếm dữ liệu theo mã
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Hoa_Don_Ban_Xe Where MaKH LIKE '%" + txt_makh.Text + "%' ORDER BY STT";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter = new OleDbDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            Grid1.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối
            huyketnoidata();
        }
        private void hiendulieu_timkiem_ten_diachi() // Tìm kiếm dữ liệu theo tên và địa chỉ
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Hoa_Don_Ban_Xe Where (MaKH LIKE '%" + txt_makh.Text.ToString().Trim() + "%' AND NgayLap LIKE '%" + dateTimeInput1.Value.ToShortDateString() + "%')  ORDER BY STT";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter = new OleDbDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            Grid1.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối
            huyketnoidata();
        }
        #endregion

        private void buttonX1_Click(object sender, EventArgs e)
        {
            hiendulieu_timkiem_ma();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 30;
            Grid1.Columns["MaHD"].Width = 50;
            Grid1.Columns["MaKH"].Width = 50;
            Grid1.Columns["MaNX"].Width = 80;
            Grid1.Columns["MaNV"].Width = 50;
            Grid1.Columns["SoKhung"].Width = 50;
            Grid1.Columns["SoMay"].Width = 50;
            Grid1.Columns["MauXe"].Width = 50;
            Grid1.Columns["DonGia"].Width = 80;
            Grid1.Columns["SoLuong"].Width = 40;
            Grid1.Columns["TongTien"].Width = 80;
            Grid1.Columns["NgayLap"].Width = 100;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Hóa Đơn";
            Grid1.Columns[2].HeaderText = "Mã KH";
            Grid1.Columns[3].HeaderText = "Mã Nhóm Xe";
            Grid1.Columns[4].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[5].HeaderText = "Số Khung";
            Grid1.Columns[6].HeaderText = "Số Máy";
            Grid1.Columns[7].HeaderText = "Màu Xe";
            Grid1.Columns[8].HeaderText = "Đơn Giá";
            Grid1.Columns[9].HeaderText = "Số Lượng";
            Grid1.Columns[10].HeaderText = "Tổng Tiền";
            Grid1.Columns[11].HeaderText = "Ngày Lập";
            #endregion
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dateTimeInput1.Value) == "01/01/0001 12:00:00 SA")
            {
                hiendulieu_timkiem_makh();
            }
            else
            {
                hiendulieu_timkiem_ten_diachi();
            }
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 30;
            Grid1.Columns["MaHD"].Width = 50;
            Grid1.Columns["MaKH"].Width = 50;
            Grid1.Columns["MaNX"].Width = 80;
            Grid1.Columns["MaNV"].Width = 50;
            Grid1.Columns["SoKhung"].Width = 50;
            Grid1.Columns["SoMay"].Width = 50;
            Grid1.Columns["MauXe"].Width = 50;
            Grid1.Columns["DonGia"].Width = 80;
            Grid1.Columns["SoLuong"].Width = 40;
            Grid1.Columns["TongTien"].Width = 80;
            Grid1.Columns["NgayLap"].Width = 100;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Hóa Đơn";
            Grid1.Columns[2].HeaderText = "Mã KH";
            Grid1.Columns[3].HeaderText = "Mã Nhóm Xe";
            Grid1.Columns[4].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[5].HeaderText = "Số Khung";
            Grid1.Columns[6].HeaderText = "Số Máy";
            Grid1.Columns[7].HeaderText = "Màu Xe";
            Grid1.Columns[8].HeaderText = "Đơn Giá";
            Grid1.Columns[9].HeaderText = "Số Lượng";
            Grid1.Columns[10].HeaderText = "Tổng Tiền";
            Grid1.Columns[11].HeaderText = "Ngày Lập";
            #endregion
        }
    }
}
