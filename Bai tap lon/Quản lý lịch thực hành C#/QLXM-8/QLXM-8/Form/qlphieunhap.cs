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
    public partial class qlphieunhap : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlphieunhap()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
        private DataTable objDataTable1;
        private DataTable objDataTable2;
        private DataTable objDataTable3;

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
            objcommand.CommandText = "Select * From Phieu_Nhap ORDER BY STT";
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
            txt_stt.DataBindings.Add("Text", Grid1.DataSource, "STT"); //1
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", Grid1.DataSource, "DonGia"); //2
            txt_maphieunhap.DataBindings.Clear();
            txt_maphieunhap.DataBindings.Add("Text", Grid1.DataSource, "MaPN"); //3
            txt_ngaylap.DataBindings.Clear();
            txt_ngaylap.DataBindings.Add("Text", Grid1.DataSource, "NgayLap"); //4
            txt_soluong.DataBindings.Clear();
            txt_soluong.DataBindings.Add("Text", Grid1.DataSource, "SoLuong"); //5
            txt_thanhtien.DataBindings.Clear();
            txt_thanhtien.DataBindings.Add("Text", Grid1.DataSource, "ThanhTien"); //6
            cmb_maNCC.DataBindings.Clear();
            cmb_maNCC.DataBindings.Add("Text", Grid1.DataSource, "MaNCC"); //7
            cmb_maNV.DataBindings.Clear();
            cmb_maNV.DataBindings.Add("Text", Grid1.DataSource, "MaNV"); //8
            cmb_maNX.DataBindings.Clear();
            cmb_maNX.DataBindings.Add("Text", Grid1.DataSource, "MaNX"); //9
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Phieu_Nhap", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaPN"] = txt_maphieunhap.Text;
            objRow["MaNV"] = cmb_maNV.Text;
            objRow["MaNCC"] = cmb_maNCC.Text;
            objRow["MaNX"] = cmb_maNX.Text;
            objRow["DonGia"] =Convert.ToInt32(txt_dongia.Text);
            objRow["SoLuong"] =Convert.ToInt32(txt_soluong.Text);
            objRow["ThanhTien"] = Convert.ToInt32(txt_thanhtien.Text);
            objRow["NgayLap"] = Convert.ToDateTime(txt_ngaylap.Text);
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Phieu_Nhap values(@STT,@MaPN,@MaNV,@MaNCC,@MaNX,@DonGia,@SoLuong,@ThanhTien,@NgayLap)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaPN", OleDbType.VarChar, 30, "MaPN");
            objCommand.Parameters.Add("@MaNV", OleDbType.VarChar, 30, "MaNV");
            objCommand.Parameters.Add("@MaNCC", OleDbType.VarChar, 30, "MaNCC");
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar, 30, "MaNX");
            objCommand.Parameters.Add("@DonGia", OleDbType.Integer, 30, "DonGia");
            objCommand.Parameters.Add("@SoLuong", OleDbType.Integer, 30, "SoLuong");
            objCommand.Parameters.Add("@ThanhTien", OleDbType.Integer, 30, "ThanhTien");
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
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Phieu_Nhap", objConnect);
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
            objCommand.CommandText = "Update Phieu_Nhap " +
                                     "Set MaPN=@MaPN, MaNV=@MaNV, MaNCC=@MaNCC, MaNX=@MaNX, DonGia=@DonGia, SoLuong=@SoLuong, ThanhTien=@ThanhTien, NgayLap=@NgayLap " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaPN", OleDbType.VarChar).Value = txt_maphieunhap.Text;
            objCommand.Parameters.Add("@MaNV", OleDbType.VarChar).Value = cmb_maNV.Text;
            objCommand.Parameters.Add("@MaNCC", OleDbType.VarChar).Value = cmb_maNCC.Text;
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar).Value = cmb_maNX.Text;
            objCommand.Parameters.Add("@DonGia", OleDbType.VarChar).Value = txt_dongia.Text;
            objCommand.Parameters.Add("@SoLuong", OleDbType.Integer).Value = txt_soluong.Text;
            objCommand.Parameters.Add("@ThanhTien", OleDbType.Integer).Value = txt_thanhtien.Text;
            objCommand.Parameters.Add("@NgayLap", OleDbType.DBDate).Value = Convert.ToDateTime(txt_ngaylap.Text);
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
            objcommand1.CommandText = "Select MaNV From Nhan_Vien ORDER BY MaNV";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = objcommand1;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable1 = new DataTable("abcdf");
            objAdapter1.Fill(objDataTable1);
            // Load dữ liệu vào Combobox
            cmb_maNV.DataSource = objDataTable1;
            cmb_maNV.DisplayMember = "MaNV";
            cmb_maNV.ValueMember = "MaNV";
            // Hủy kết nối
            huyketnoidata();

        }
        #endregion
        #region "Load CSDL Combobox2"
        private void LoadCSDLcombobox2()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand2 = new OleDbCommand();
            objcommand2.Connection = objConnect;
            objcommand2.CommandType = CommandType.Text;
            objcommand2.CommandText = "Select MaNX From Nhom_Xe ORDER BY MaNX";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter2 = new OleDbDataAdapter();
            objAdapter2.SelectCommand = objcommand2;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable2 = new DataTable("abcdfg");
            objAdapter2.Fill(objDataTable2);
            // Load dữ liệu vào Combobox
            cmb_maNX.DataSource = objDataTable2;
            cmb_maNX.DisplayMember = "MaNX";
            cmb_maNX.ValueMember = "MaNX";
            // HỦy kết nối
            huyketnoidata();


        }
        #endregion
        #region "Load CSDL Combobox3"
        private void LoadCSDLcombobox3()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand3 = new OleDbCommand();
            objcommand3.Connection = objConnect;
            objcommand3.CommandType = CommandType.Text;
            objcommand3.CommandText = "Select MaNCC From Nha_Cung_Cap ORDER BY MaNCC";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter3 = new OleDbDataAdapter();
            objAdapter3.SelectCommand = objcommand3;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable3 = new DataTable("abcdfg");
            objAdapter3.Fill(objDataTable3);
            // Load dữ liệu vào Combobox
            cmb_maNCC.DataSource = objDataTable3;
            cmb_maNCC.DisplayMember = "MaNCC";
            cmb_maNCC.ValueMember = "MaNCC";
            // HỦy kết nối
            huyketnoidata();


        }
        #endregion

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qlphieunhap_Load(object sender, EventArgs e)
        {
            hiendulieu();
            bindingdata();
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
            LoadCSDLcombobox1();
            LoadCSDLcombobox2();
            LoadCSDLcombobox3();
        }

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_thanhtien.Text = "";
            txt_stt.Text = "";
            txt_soluong.Text = "";
            txt_ngaylap.Text = "";
            txt_maphieunhap.Text = "";
            txt_dongia.Text = "";
            cmb_maNX.Text = "";
            cmb_maNV.Text = "";
            cmb_maNCC.Text = "";
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
