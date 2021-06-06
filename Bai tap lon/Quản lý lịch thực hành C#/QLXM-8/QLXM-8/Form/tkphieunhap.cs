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
    public partial class tkphieunhap : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public tkphieunhap()
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
        private void hiendulieu_timkiem_maPN() // Tìm kiếm dữ liệu theo mã
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Phieu_Nhap Where MaPN LIKE '%" + txt_maphieunhap.Text + "%' ORDER BY STT";
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
        private void hiendulieu_timkiem_maNV_maNCC() // Tìm kiếm dữ liệu theo mã
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Phieu_Nhap Where (MaNV LIKE '%" + txt_manhanvien.Text + "%' AND MaNCC LIKE '%" + txt_manhacungcap.Text + "%') ORDER BY STT";
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
            objcommand.CommandText = "Select * From Phieu_Nhap Where (MaNCC LIKE '%" + txt_manhacungcap.Text.ToString().Trim() + "%' AND MaNV LIKE '%"+ txt_manhanvien.Text + "%' AND NgayLap LIKE '%" + dateTimeInput1.Value.ToShortDateString() + "%')  ORDER BY STT";
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
            hiendulieu_timkiem_maPN();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 30;
            Grid1.Columns["MaPN"].Width = 60;
            Grid1.Columns["MaNV"].Width = 60;
            Grid1.Columns["MaNCC"].Width = 80;
            Grid1.Columns["MaNX"].Width = 80;
            Grid1.Columns["DonGia"].Width = 100;
            Grid1.Columns["SoLuong"].Width = 50;
            Grid1.Columns["ThanhTien"].Width = 100;
            Grid1.Columns["NgayLap"].Width = 100;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Phiếu Nhâp";
            Grid1.Columns[2].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[3].HeaderText = "Mã Nhà CC";
            Grid1.Columns[4].HeaderText = "Mã Nhóm Xe";
            Grid1.Columns[5].HeaderText = "Đơn Giá";
            Grid1.Columns[6].HeaderText = "Số Lượng";
            Grid1.Columns[7].HeaderText = "Thành Tiền";
            Grid1.Columns[8].HeaderText = "Ngày Lập";
            #endregion
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dateTimeInput1.Value) == "01/01/0001 12:00:00 SA")
            {
                hiendulieu_timkiem_maNV_maNCC();
            }
            else 
            {
                hiendulieu_timkiem_ten_diachi();
            }
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 30;
            Grid1.Columns["MaPN"].Width = 60;
            Grid1.Columns["MaNV"].Width = 60;
            Grid1.Columns["MaNCC"].Width = 80;
            Grid1.Columns["MaNX"].Width = 80;
            Grid1.Columns["DonGia"].Width = 100;
            Grid1.Columns["SoLuong"].Width = 50;
            Grid1.Columns["ThanhTien"].Width = 100;
            Grid1.Columns["NgayLap"].Width = 100;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Phiếu Nhâp";
            Grid1.Columns[2].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[3].HeaderText = "Mã Nhà CC";
            Grid1.Columns[4].HeaderText = "Mã Nhóm Xe";
            Grid1.Columns[5].HeaderText = "Đơn Giá";
            Grid1.Columns[6].HeaderText = "Số Lượng";
            Grid1.Columns[7].HeaderText = "Thành Tiền";
            Grid1.Columns[8].HeaderText = "Ngày Lập";
            #endregion
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
