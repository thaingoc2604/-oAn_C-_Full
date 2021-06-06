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
    public partial class qlkh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlkh()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
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
            objcommand.CommandText = "Select * From Khach_Hang ORDER BY STT";
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
            txt_stt.DataBindings.Clear();
            txt_stt.DataBindings.Add("Text", Grid1.DataSource, "STT");
            txt_kh.DataBindings.Clear();
            txt_kh.DataBindings.Add("Text", Grid1.DataSource, "MaKH");
            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", Grid1.DataSource, "HotenKH");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", Grid1.DataSource, "DiaChiKH");
            txt_dienthoai.DataBindings.Clear();
            txt_dienthoai.DataBindings.Add("Text", Grid1.DataSource, "SDT");
            txt_cmt.DataBindings.Clear();
            txt_cmt.DataBindings.Add("Text", Grid1.DataSource, "SoCMT");
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Khach_Hang",objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaKH"] = txt_kh.Text;
            objRow["HoTenKH"] = txt_hoten.Text;
            objRow["DiaChiKH"] = txt_diachi.Text;
            objRow["SDT"] = Convert.ToInt32(txt_dienthoai.Text);
            objRow["SoCMT"] = Convert.ToInt32(txt_cmt.Text);
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Khach_Hang values(@STT,@MaKH,@HoTenKH,@DiaChiKH,@SDT,@SoCMT)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaKH", OleDbType.VarChar, 30,"MaKH");
            objCommand.Parameters.Add("@HoTenKH", OleDbType.VarChar,30,"HoTenKH");
            objCommand.Parameters.Add("@DiaChiKH", OleDbType.VarChar,30,"DiaChiKH");
            objCommand.Parameters.Add("@SDT", OleDbType.Integer,30,"SDT");
            objCommand.Parameters.Add("@SoCMT", OleDbType.Integer,30,"SoCMT");
            // Insert dữ liệu vào nguồn
            objAdapter.InsertCommand = objCommand;
            objAdapter.Update(objDataTable);
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
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
            objCommand.CommandText = "Update Khach_Hang " +
                                     "Set MaKH=@MaKH, HoTenKH=@HoTenKH, DiaChiKh=@DiaChiKH, SDT=@SDT, SoCMT=@SCMT " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaKH", OleDbType.VarChar).Value = txt_kh.Text;
            objCommand.Parameters.Add("@HoTenKH", OleDbType.VarChar).Value = txt_hoten.Text;
            objCommand.Parameters.Add("@DiaChiKH", OleDbType.VarChar).Value = txt_diachi.Text;
            objCommand.Parameters.Add("@SDT", OleDbType.Integer).Value = Convert.ToInt32(txt_dienthoai.Text);
            objCommand.Parameters.Add("@SoCMT", OleDbType.Integer).Value =Convert.ToInt32(txt_cmt.Text);
            objCommand.Parameters.Add("@STT", OleDbType.Integer).Value = Convert.ToInt32(txt_stt.Text);
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
        }
        #endregion
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Khach_Hang", objConnect);
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
        private void qlkh_Load(object sender, EventArgs e)
        {
            hiendulieu();
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
            bindingdata();
        }

        private void cmd_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                InsertByAdapter();
                hiendulieu();
                
            }
            catch(OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);
            }
        }

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_stt.Text = "";
            txt_cmt.Text = "";
            txt_dienthoai.Text = "";
            txt_hoten.Text = "";
            txt_kh.Text = "";
            txt_diachi.Text = "";
        }

        private void cmd_update_Click(object sender, EventArgs e)
        {
            update_dulieu();
            hiendulieu();
            bindingdata();
       
        }

        private void cmd_xoa_Click(object sender, EventArgs e)
        {
            deletedata();
            hiendulieu();
            bindingdata();
        }

    }
}
