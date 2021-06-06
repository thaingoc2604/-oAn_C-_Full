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
    public partial class tkkhach : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public tkkhach()
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
            objcommand.CommandText = "Select * From Khach_Hang Where MaKH LIKE '%"+ txt_makh.Text +"%' ORDER BY STT";
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
            objcommand.CommandText = "Select * From Khach_Hang Where (HoTenKH LIKE '%" + txt_hoten.Text.ToString().Trim() + "%' AND DiaChiKH LIKE '%" + txt_diachi.Text.ToString().Trim() + "%')  ORDER BY STT";
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

        private void cmd_timma_Click(object sender, EventArgs e)
        {
            hiendulieu_timkiem_ma();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 40;
            Grid1.Columns["MaKH"].Width = 110;
            Grid1.Columns["HoTenKH"].Width = 130;
            Grid1.Columns["DiaChiKH"].Width = 130;
            Grid1.Columns["SDT"].Width = 120;
            Grid1.Columns["SoCMT"].Width = 120;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Khách Hàng";
            Grid1.Columns[2].HeaderText = "Họ và Tên";
            Grid1.Columns[3].HeaderText = "Địa Chỉ";
            Grid1.Columns[4].HeaderText = "Số Điện Thoại";
            Grid1.Columns[5].HeaderText = "Số CMT";
            #endregion
            
        }

        private void cmd_tim_ten_diachi_Click(object sender, EventArgs e)
        {
            hiendulieu_timkiem_ten_diachi();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 40;
            Grid1.Columns["MaKH"].Width = 110;
            Grid1.Columns["HoTenKH"].Width = 130;
            Grid1.Columns["DiaChiKH"].Width = 130;
            Grid1.Columns["SDT"].Width = 120;
            Grid1.Columns["SoCMT"].Width = 120;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Khách Hàng";
            Grid1.Columns[2].HeaderText = "Họ và Tên";
            Grid1.Columns[3].HeaderText = "Địa Chỉ";
            Grid1.Columns[4].HeaderText = "Số Điện Thoại";
            Grid1.Columns[5].HeaderText = "Số CMT";
            #endregion
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
