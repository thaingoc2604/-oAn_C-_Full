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
    public partial class qlxe : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlxe()
        {
            InitializeComponent();
        }

        private void qlxe_Load(object sender, EventArgs e)
        {
            hiendulieu();
            bindingdata();
            LoadCSDLcombobox();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 40;
            Grid1.Columns["MaNX"].Width = 110;
            Grid1.Columns["SoKhung"].Width = 130;
            Grid1.Columns["SoMay"].Width = 130;
            Grid1.Columns["mausac"].Width = 130;
            Grid1.Columns["dongia"].Width = 120;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Nhóm Xe";
            Grid1.Columns[2].HeaderText = "Số Khung";
            Grid1.Columns[3].HeaderText = "Số Máy";
            Grid1.Columns[4].HeaderText = "Màu Sắc";
            Grid1.Columns[5].HeaderText = "Đơn Giá";
            #endregion

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
            objcommand.CommandText = "Select * From Xe ORDER BY STT";
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Xe", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaNX"] = cmb_nx.Text;
            objRow["SoKhung"] = txt_sokhung.Text;
            objRow["SoMay"] = txt_somay.Text;
            objRow["mausac"] = txt_mausac.Text;
            objRow["dongia"] = Convert.ToInt32(txt_dongia.Text);
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Xe values(@STT,@MaNX,@SoKhung,@SoMay,@mausac,@dongia)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar, 30, "MaNX");
            objCommand.Parameters.Add("@SoKhung", OleDbType.VarChar, 30, "SoKhung");
            objCommand.Parameters.Add("@SoMay", OleDbType.VarChar, 30, "SoMay");
            objCommand.Parameters.Add("@mausac", OleDbType.VarChar, 30, "mausac");
            objCommand.Parameters.Add("@dongia", OleDbType.Integer, 30, "dongia");
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
            objCommand.CommandText = "Update Xe " +
                                     "Set MaNX=@MaNX, SoKhung=@SoKhung, SoMay=@SoMay, mausac=@mausac, dongia=@dongia " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar).Value = cmb_nx.Text;
            objCommand.Parameters.Add("@SoKhung", OleDbType.VarChar).Value = txt_sokhung.Text;
            objCommand.Parameters.Add("@SoMay", OleDbType.VarChar).Value = txt_somay.Text;
            objCommand.Parameters.Add("@mausac", OleDbType.VarChar).Value = txt_mausac.Text;
            objCommand.Parameters.Add("@dongia", OleDbType.Integer).Value = Convert.ToInt32(txt_dongia.Text);
            objCommand.Parameters.Add("@STT", OleDbType.Integer).Value = Convert.ToInt32(txt_stt.Text);
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            // Đóng kết nối
            huyketnoidata();
        }
        #endregion
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Xe", objConnect);
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
        #region " Binding dữ liệu"
        private void bindingdata()
        {
            txt_stt.DataBindings.Clear();
            txt_stt.DataBindings.Add("Text", Grid1.DataSource, "STT");
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", Grid1.DataSource, "dongia");
            txt_mausac.DataBindings.Clear();
            txt_mausac.DataBindings.Add("Text", Grid1.DataSource, "mausac");
            txt_sokhung.DataBindings.Clear();
            txt_sokhung.DataBindings.Add("Text", Grid1.DataSource, "SoKhung");
            txt_somay.DataBindings.Clear();
            txt_somay.DataBindings.Add("Text", Grid1.DataSource, "SoMay");
            cmb_nx.DataBindings.Clear();
            cmb_nx.DataBindings.Add("Text", Grid1.DataSource, "MaNX");
        }
        #endregion
        #region "Load CSDL Combobox"
        private void LoadCSDLcombobox()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand1 = new OleDbCommand();
            objcommand1.Connection = objConnect;
            objcommand1.CommandType = CommandType.Text;
            objcommand1.CommandText = "Select MaNX From Nhom_Xe ORDER BY MaNX";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = objcommand1;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable1 = new DataTable("abcdfg");
            objAdapter1.Fill(objDataTable1);
            // Load dữ liệu vào Combobox
            cmb_nx.DataSource = objDataTable1;
            cmb_nx.DisplayMember = "MaNX";
            cmb_nx.ValueMember = "MaNX";
            // Đóng kết nối
            huyketnoidata();


        }
        #endregion


        private void cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                InsertByAdapter();
                hiendulieu();
                bindingdata();

            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);
            }
        }

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_sua_Click(object sender, EventArgs e)
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

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_dongia.Text = "";
            txt_mausac.Text = "";
            txt_sokhung.Text = "";
            txt_somay.Text = "";
            txt_stt.Text = "";
            cmb_nx.Text = "";
        }

       

    }
}
