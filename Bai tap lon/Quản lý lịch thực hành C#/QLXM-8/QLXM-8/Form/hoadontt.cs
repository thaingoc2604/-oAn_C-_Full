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
    public partial class hoadontt : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public hoadontt()
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
            objcommand.CommandText = "Select * From Hoa_Don_Thanh_Toan ORDER BY STT";
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Hoa_Don_Thanh_Toan", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaTT"] = txt_matt.Text;
            objRow["MaNCC"] = cmb_ncc.Text;
            objRow["TongTien"] =Convert.ToInt32(txt_tongtien.Text);
            objRow["NgayLap"] = Convert.ToDateTime(txt_ngaylap.Text);
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Hoa_Don_Thanh_Toan values(@STT,@MaTT,@MaNCC,@TongTien,@NgayLap)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaTT", OleDbType.VarChar, 30, "MaTT");
            objCommand.Parameters.Add("@MaNCC", OleDbType.VarChar, 30, "MaNCC");
            objCommand.Parameters.Add("@TongTien", OleDbType.Integer, 30, "TongTien");
            objCommand.Parameters.Add("@NgayLap", OleDbType.DBDate, 30, "NgayLap");
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
            txt_matt.DataBindings.Clear();
            txt_matt.DataBindings.Add("Text", Grid1.DataSource, "MaTT");
            txt_ngaylap.DataBindings.Clear();
            txt_ngaylap.DataBindings.Add("Text", Grid1.DataSource, "NgayLap");
            txt_tongtien.DataBindings.Clear();
            txt_tongtien.DataBindings.Add("Text", Grid1.DataSource, "TongTien");
            cmb_ncc.DataBindings.Clear();
            cmb_ncc.DataBindings.Add("Text", Grid1.DataSource, "MaNCC");
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
            objcommand1.CommandText = "Select MaNCC From Nha_Cung_Cap ORDER BY MaNCC";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = objcommand1;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable1 = new DataTable("abcdf");
            objAdapter1.Fill(objDataTable1);
            // Load dữ liệu vào Combobox
            cmb_ncc.DataSource = objDataTable1;
            cmb_ncc.DisplayMember = "MaNCC";
            cmb_ncc.ValueMember = "MaNCC";
            // Hủy kết nối
            huyketnoidata();


        }
        #endregion
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Hoa_Don_Thanh_Toan", objConnect);
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
            objCommand.CommandText = "Update Hoa_Don_Thanh_Toan " +
                                     "Set MaTT=@MaTT, MaNCC=@MaNCC, TongTien=@TongTien, NgayLap=@NgayLap " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaTT", OleDbType.VarChar).Value = txt_matt.Text;
            objCommand.Parameters.Add("@MaNCC", OleDbType.VarChar).Value = cmb_ncc.Text;
            objCommand.Parameters.Add("@TongTien", OleDbType.Integer).Value = Convert.ToInt32(txt_tongtien.Text);
            objCommand.Parameters.Add("@NgayLap", OleDbType.DBDate).Value = Convert.ToDateTime(txt_ngaylap.Text);
            objCommand.Parameters.Add("@STT", OleDbType.Integer).Value = Convert.ToInt32(txt_stt.Text);
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            // ĐÓng kết nối
            huyketnoidata();
        }
        #endregion

        private void hoadontt_Load(object sender, EventArgs e)
        {
            hiendulieu();
            bindingdata();
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
            LoadCSDLcombobox1();

        }

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

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_matt.Text = "";
            txt_ngaylap.Text = "";
            txt_stt.Text = "";
            txt_tongtien.Text = "";
            cmb_ncc.Text = "";
        }

        
    }
}
