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
    public partial class qlnhomxe : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlnhomxe()
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
            objcommand.CommandText = "Select * From Nhom_Xe ORDER BY STT";
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
        #region "Insert dữ liệu bằng adapter"
        private void InsertByAdapter()
        {
            // Tạo kết nối CSDL
            ketnoidata();
            // Nạp dữ liệu vào DataTable
            objDataTable = new DataTable("cde");
            // Tạo đối tượng Adapter và Fill vào DataTable
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Nhom_Xe", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaNX"] = txt_manx.Text;
            objRow["HangSX"] = txt_hangsx.Text;
            objRow["DonGia"] = Convert.ToInt32(txt_dongia.Text);
            objRow["SoLuong"] = Convert.ToInt32(txt_soluong.Text);
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Nhom_Xe values(@STT,@MaNX,@HangSX,@DonGia,@SoLuong)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar, 30, "MaNX");
            objCommand.Parameters.Add("@HangSX", OleDbType.VarChar, 30, "HangSX");
            objCommand.Parameters.Add("@DonGia", OleDbType.Integer, 30, "DonGia");
            objCommand.Parameters.Add("@SoLuong", OleDbType.Integer, 30, "SoLuong");
            // Insert dữ liệu vào nguồn
            objAdapter.InsertCommand = objCommand;
            objAdapter.Update(objDataTable);
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            huyketnoidata();
        }
        #endregion
        #region " Binding dữ liệu"
        private void bindingdata()
        {
            txt_stt.DataBindings.Clear();
            txt_stt.DataBindings.Add("Text", Grid1.DataSource, "STT");
            txt_soluong.DataBindings.Clear();
            txt_soluong.DataBindings.Add("Text", Grid1.DataSource, "SoLuong");
            txt_manx.DataBindings.Clear();
            txt_manx.DataBindings.Add("Text", Grid1.DataSource, "MaNX");
            txt_hangsx.DataBindings.Clear();
            txt_hangsx.DataBindings.Add("Text", Grid1.DataSource, "HangSX");
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", Grid1.DataSource, "DonGia");
        }
        #endregion
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Nhom_Xe", objConnect);
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
            objCommand.CommandText = "Update Nhom_Xe " +
                                     "Set MaNX=@MaNX, HangSX=@HangSX, DonGia=@DonGia, SoLuong=@SoLuong " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar).Value = txt_manx.Text;
            objCommand.Parameters.Add("@HangSX", OleDbType.VarChar).Value = txt_hangsx.Text;
            objCommand.Parameters.Add("@DonGia", OleDbType.Integer).Value = Convert.ToInt32(txt_dongia.Text);
            objCommand.Parameters.Add("@SoLuong", OleDbType.Integer).Value = Convert.ToInt32(txt_soluong.Text);
            objCommand.Parameters.Add("@STT", OleDbType.Integer).Value = Convert.ToInt32(txt_stt.Text);
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            //Đóng kết nối
            huyketnoidata();
        }
        #endregion

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_nhaplai_Click_1(object sender, EventArgs e)
        {
            txt_dongia.Text = "";
            txt_hangsx.Text = "";
            txt_manx.Text = "";
            txt_soluong.Text = "";
            txt_stt.Text = "";
        }

        private void qlnhomxe_Load(object sender, EventArgs e)
        {
            hiendulieu();
            bindingdata();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 50;
            Grid1.Columns["MaNX"].Width = 150;
            Grid1.Columns["HangSX"].Width = 140;
            Grid1.Columns["DonGia"].Width = 135;
            Grid1.Columns["SoLuong"].Width = 105;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Nhóm Xe";
            Grid1.Columns[2].HeaderText = "Hãng Sản Xuất";
            Grid1.Columns[3].HeaderText = "Đơn Giá";
            Grid1.Columns[4].HeaderText = "Số Lượng";
            #endregion
        }

        private void cmd_them_Click(object sender, EventArgs e)
        {
            InsertByAdapter();
            hiendulieu();
            bindingdata();
        }

        private void cmd_xoa_Click(object sender, EventArgs e)
        {
            deletedata();
            hiendulieu();
            bindingdata();
        }

        private void cmd_sua_Click(object sender, EventArgs e)
        {
            update_dulieu();
            hiendulieu();
            bindingdata();
        }

    }
}
