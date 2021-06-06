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
    public partial class qlnhanvien : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlnhanvien()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
       // private DataTable objDataTable1;
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
        #region "Select dữ liệu"
        private void hiendulieu()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From Nhan_Vien ORDER BY STT";
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
        #region " Binding dữ liệu"
        private void bindingdata()
        {
            txt_chuyenmon.DataBindings.Clear();
            txt_chuyenmon.DataBindings.Add("Text", Grid1.DataSource, "ChuyenMon"); //1
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", Grid1.DataSource, "DiaChi"); //2
            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", Grid1.DataSource, "HoTenNV"); //3
            txt_manv.DataBindings.Clear();
            txt_manv.DataBindings.Add("Text", Grid1.DataSource, "MaNV"); //4
            txt_mucluong.DataBindings.Clear();
            txt_mucluong.DataBindings.Add("Text", Grid1.DataSource, "Luong"); //5
            txt_soCMT.DataBindings.Clear();
            txt_soCMT.DataBindings.Add("Text", Grid1.DataSource, "SoCMT"); //6
            txt_stt.DataBindings.Clear();
            txt_stt.DataBindings.Add("Text", Grid1.DataSource, "STT"); //7
        }
        #endregion
        #region "Insert dữ liệu bằng adapter"
        private void InsertByAdapter()
        {
            // Tạo kết nối CSDL
            ketnoidata();
            // Nạp dữ liệu vào DataTable
            objDataTable = new DataTable("cde");
            // Tạo đối tượng Adapter và Fill vào DataTable
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Nhan_Vien", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaNV"] = txt_manv.Text;
            objRow["HoTenNV"] = txt_hoten.Text;
            objRow["SoCMT"] = Convert.ToInt32(txt_soCMT.Text);
            objRow["DiaChi"] = txt_diachi.Text;
            objRow["ChuyenMon"] = txt_chuyenmon.Text;
            objRow["Luong"] = Convert.ToInt32(txt_mucluong.Text);
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Nhan_Vien values(@STT,@MaNV,@HoTenNV,@SoCMT,@DiaChi,@ChuyenMon,@Luong)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaNV", OleDbType.VarChar, 30, "MaNV");
            objCommand.Parameters.Add("@HoTenNV", OleDbType.VarChar, 30, "HoTenNV");
            objCommand.Parameters.Add("@SoCMT", OleDbType.Integer, 30, "SoCMT");
            objCommand.Parameters.Add("@DiaChi", OleDbType.VarChar, 30, "DiaChi");
            objCommand.Parameters.Add("@ChuyenMon", OleDbType.VarChar, 30, "ChuyenMon");
            objCommand.Parameters.Add("@Luong", OleDbType.Integer, 30, "Luong");
            // Insert dữ liệu vào nguồn
            objAdapter.InsertCommand = objCommand;
            objAdapter.Update(objDataTable);
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            huyketnoidata();
        }
        #endregion
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Nhan_Vien", objConnect);
            objDataTable = new DataTable();
            objAdapter.Fill(objDataTable);
            //Xây dựng commandBuilder
            new OleDbCommandBuilder(objAdapter);
            //Delete Record cần delete trong datatable
            DataRow[] objRow = objDataTable.Select("STT=" + Convert.ToInt32(txt_stt.Text));
            objRow[0].Delete();
            //Delete dữ liệu nguồn
            objAdapter.Update(objDataTable);
            //Hủy đối tượng
            objAdapter.Dispose(); objAdapter = null;
            objDataTable.Dispose(); objDataTable = null;
            huyketnoidata();
        }
        #endregion
        #region "Update dữ liệu"
        // Update dữ liệu trực tiếp có tham số
        // Tạo kết nối với file access
        private void update_dulieu()
        {
            // Tạo kết nối Access
            ketnoidata();
            // Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update Nhan_Vien " +
                                     "Set MaNV=@MaNV, HoTenNV=@HoTenNV, SoCMT=@SoCMT, DiaChi=@DiaChi, ChuyenMon=@ChuyenMon, Luong=@Luong " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaNV", OleDbType.VarChar).Value = txt_manv.Text;
            objCommand.Parameters.Add("@HoTenNV", OleDbType.VarChar).Value = txt_hoten.Text;
            objCommand.Parameters.Add("@SoCMT", OleDbType.Integer).Value = Convert.ToInt32(txt_soCMT.Text);
            objCommand.Parameters.Add("@DiaChi", OleDbType.VarChar).Value = txt_diachi.Text;
            objCommand.Parameters.Add("@ChuyenMon", OleDbType.VarChar).Value = txt_chuyenmon.Text;
            objCommand.Parameters.Add("@Luong", OleDbType.Integer).Value = Convert.ToInt32(txt_mucluong.Text);
            objCommand.Parameters.Add("@STT", OleDbType.Integer).Value = Convert.ToInt32(txt_stt.Text);
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            // Đóng kết nối
            huyketnoidata();
        }
        #endregion

        private void qlnhanvien_Load(object sender, EventArgs e)
        {
            hiendulieu();
            bindingdata();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 50;
            Grid1.Columns["MaNV"].Width = 60;
            Grid1.Columns["HoTenNV"].Width = 150;
            Grid1.Columns["SoCMT"].Width = 100;
            Grid1.Columns["DiaChi"].Width = 100;
            Grid1.Columns["ChuyenMon"].Width = 100;
            Grid1.Columns["Luong"].Width = 100;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "Số Thứ Tự";
            Grid1.Columns[1].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[2].HeaderText = "Họ và Tên";
            Grid1.Columns[3].HeaderText = "Số CMT";
            Grid1.Columns[4].HeaderText = "Địa Chỉ";
            Grid1.Columns[5].HeaderText = "Chuyên Môn";
            Grid1.Columns[6].HeaderText = "Lương";
            #endregion
        }

        private void cmd_them_Click(object sender, EventArgs e)
        {
            InsertByAdapter();
            hiendulieu();
            bindingdata();
        }

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_xoa_Click(object sender, EventArgs e)
        {
            deletedata();
            hiendulieu();
            bindingdata();
        }

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_chuyenmon.Text = "";
            txt_diachi.Text = "";
            txt_hoten.Text = "";
            txt_manv.Text = "";
            txt_mucluong.Text = "";
            txt_soCMT.Text = "";
            txt_stt.Text = "";
        }

        private void cmd_sua_Click(object sender, EventArgs e)
        {
            update_dulieu();
            hiendulieu();
            bindingdata();
        }
    }
}
