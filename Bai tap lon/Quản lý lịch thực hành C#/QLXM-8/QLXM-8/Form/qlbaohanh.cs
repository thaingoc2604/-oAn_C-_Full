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
    public partial class qlbaohanh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlbaohanh()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
        private DataTable objDataTable1;
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
            objcommand.CommandText = "Select * From Bao_Hanh ORDER BY STT";
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
            txt_mabh.DataBindings.Clear();
            txt_mabh.DataBindings.Add("Text", Grid1.DataSource, "MaBH"); //1
            txt_sokhung.DataBindings.Clear();
            txt_sokhung.DataBindings.Add("Text", Grid1.DataSource, "SoKhung"); //2
            txt_somay.DataBindings.Clear();
            txt_somay.DataBindings.Add("Text", Grid1.DataSource, "SoMay"); //3
            txt_stt.DataBindings.Clear();
            txt_stt.DataBindings.Add("Text", Grid1.DataSource, "STT"); //4
            cmb_makh.DataBindings.Clear();
            cmb_makh.DataBindings.Add("Text", Grid1.DataSource, "MaKH"); //5
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Bao_Hanh", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaBH"] = txt_mabh.Text;
            objRow["MaKH"] = cmb_makh.Text;
            objRow["SoKhung"] = txt_sokhung.Text;
            objRow["SoMay"] = txt_somay.Text;
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Bao_Hanh values(@STT,@MaBH,@MaKH,@SoKhung,@SoMay)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaBH", OleDbType.VarChar, 30, "MaBH");
            objCommand.Parameters.Add("@MaKH", OleDbType.VarChar, 30, "MaKH");
            objCommand.Parameters.Add("@SoKhung", OleDbType.VarChar, 30, "SoKhung");
            objCommand.Parameters.Add("@SoMay", OleDbType.VarChar, 30, "SoMay");
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Bao_Hanh", objConnect);
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
            objCommand.CommandText = "Update Bao_Hanh " +
                                     "Set MaBH=@MaBH, MaKH=@MaKH, SoKhung=@SoKhung, SoMay=@SoMay " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaBH", OleDbType.VarChar).Value = txt_mabh.Text;
            objCommand.Parameters.Add("@MaKH", OleDbType.VarChar).Value = cmb_makh.Text;
            objCommand.Parameters.Add("@SoKhung", OleDbType.VarChar).Value = txt_sokhung.Text;
            objCommand.Parameters.Add("@SoMay", OleDbType.VarChar).Value = txt_somay.Text;
            objCommand.Parameters.Add("@STT", OleDbType.Integer).Value = Convert.ToInt32(txt_stt.Text);
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            // Đóng kết nối
            huyketnoidata();
        }
        #endregion
        #region "Load CSDL Combobox1"
        private void LoadCSDLcombobox1()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand1 = new OleDbCommand();
            objcommand1.Connection = objConnect;
            objcommand1.CommandType = CommandType.Text;
            objcommand1.CommandText = "Select MaKH,SoKhung,SoMay From Hoa_Don_Ban_Xe ORDER BY MaKH";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = objcommand1;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable1 = new DataTable("abcdf");
            objAdapter1.Fill(objDataTable1);
            // Load dữ liệu vào Combobox
            cmb_makh.DataSource = objDataTable1;
            cmb_makh.DisplayMember = "MaKH";
            cmb_makh.ValueMember = "SoKhung";
            // Hủy kết nối
            huyketnoidata();

        }
        #endregion

        private void qlbaohanh_Load(object sender, EventArgs e)
        {
            hiendulieu();
            bindingdata();
            LoadCSDLcombobox1();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 100;
            Grid1.Columns["MaBH"].Width = 110;
            Grid1.Columns["MaKH"].Width = 110;
            Grid1.Columns["SoKhung"].Width = 150;
            Grid1.Columns["SoMay"].Width = 150;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "Số Thứ Tự";
            Grid1.Columns[1].HeaderText = "Mã Bảo Hành";
            Grid1.Columns[2].HeaderText = "Mã Khách Hàng";
            Grid1.Columns[3].HeaderText = "Số Khung";
            Grid1.Columns[4].HeaderText = "Số Máy";
            #endregion
        }

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cmb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_sokhung.Text = cmb_makh.SelectedValue.ToString();
            txt_somay.DataBindings.Clear();
            txt_somay.DataBindings.Add("Text", cmb_makh.DataSource, "SoMay");
        }

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_somay.Text = "";
            txt_sokhung.Text = "";
            txt_mabh.Text = "";
            txt_stt.Text = "";
            cmb_makh.Text = "";
        }

    }
}
