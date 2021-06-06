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
    public partial class tkhoadontt : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public tkhoadontt()
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
            objcommand.CommandText = "Select * From Hoa_Don_Thanh_Toan Where MaTT LIKE '%" + txt_matt.Text + "%' ORDER BY STT";
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
        private void hiendulieu_timkiem_mancc() // Tìm kiếm dữ liệu theo mã
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Hoa_Don_Thanh_Toan Where MaNCC LIKE '%" + txt_mancc.Text + "%' ORDER BY STT";
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
            objcommand.CommandText = "Select * From Hoa_Don_Thanh_Toan Where (MaNCC LIKE '%" + txt_mancc.Text.ToString().Trim() + "%' AND NgayLap LIKE '%" + datime_input1.Value.ToShortDateString() + "%')  ORDER BY STT";
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(datime_input1.Value) == "01/01/0001 12:00:00 SA")
            {
                hiendulieu_timkiem_mancc();
            }
            else
            {
                hiendulieu_timkiem_ten_diachi();
            }
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 60;
            Grid1.Columns["MaTT"].Width = 150;
            Grid1.Columns["MaNCC"].Width = 150;
            Grid1.Columns["TongTien"].Width = 140;
            Grid1.Columns["NgayLap"].Width = 140;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Thanh Toán";
            Grid1.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
            Grid1.Columns[3].HeaderText = "Tổng Tiền";
            Grid1.Columns[4].HeaderText = "Ngày Lập";
            #endregion
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            hiendulieu_timkiem_ma();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 60;
            Grid1.Columns["MaTT"].Width = 150;
            Grid1.Columns["MaNCC"].Width = 150;
            Grid1.Columns["TongTien"].Width = 140;
            Grid1.Columns["NgayLap"].Width = 140;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Thanh Toán";
            Grid1.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
            Grid1.Columns[3].HeaderText = "Tổng Tiền";
            Grid1.Columns[4].HeaderText = "Ngày Lập";
            #endregion
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
