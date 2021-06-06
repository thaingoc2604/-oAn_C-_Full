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
    public partial class qlhdbh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlhdbh()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
        private OleDbConnection objConnect;
        private DataTable objDataTable;
        private DataTable objDataTable1;
       // private DataTable objDataTable2;
        private DataTable objDataTable3;
        private DataTable objDataTable4;

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
            objcommand.CommandText = "Select * From Hoa_Don_Ban_Xe ORDER BY STT";
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
            txt_somay.DataBindings.Clear();
            txt_somay.DataBindings.Add("Text", Grid1.DataSource, "SoMay"); //2
            txt_soluong.DataBindings.Clear();
            txt_soluong.DataBindings.Add("Text", Grid1.DataSource, "SoLuong"); //3
            txt_ngaylap.DataBindings.Clear();
            txt_ngaylap.DataBindings.Add("Text", Grid1.DataSource, "NgayLap"); //4
            txt_mauxe.DataBindings.Clear();
            txt_mauxe.DataBindings.Add("Text", Grid1.DataSource, "MauXe"); //5
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", Grid1.DataSource, "DonGia"); //6
            txt_tongtien.DataBindings.Clear();
            txt_tongtien.DataBindings.Add("Text", Grid1.DataSource, "TongTien"); //7
            cmb_sokhung.DataBindings.Clear();
            cmb_sokhung.DataBindings.Add("Text", Grid1.DataSource, "SoKhung"); //8
            txt_mahoadon.DataBindings.Clear();
            txt_mahoadon.DataBindings.Add("Text", Grid1.DataSource, "MaHD"); //9
            txt_manhomxe.DataBindings.Clear();
            txt_manhomxe.DataBindings.Add("Text", Grid1.DataSource, "MaNX"); //10
            cmb_maNV.DataBindings.Clear();
            cmb_maNV.DataBindings.Add("Text", Grid1.DataSource, "MaNV"); //11
            cmb_makh.DataBindings.Clear();
            cmb_makh.DataBindings.Add("Text", Grid1.DataSource, "MaKH"); //12
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Hoa_Don_Ban_Xe", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaHD"] = txt_mahoadon.Text;
            objRow["MaKH"] = cmb_makh.Text;
            objRow["MaNX"] = txt_manhomxe.Text;
            objRow["MaNV"] = cmb_maNV.Text;
            objRow["SoKhung"] = cmb_sokhung.Text;
            objRow["SoMay"] = txt_somay.Text;
            objRow["MauXe"] = txt_mauxe.Text;
            objRow["DonGia"] =Convert.ToInt32(txt_dongia.Text);
            objRow["SoLuong"] =Convert.ToInt32(txt_soluong.Text);
            objRow["TongTien"] =Convert.ToInt32(txt_tongtien.Text);
            objRow["NgayLap"] =Convert.ToDateTime(txt_ngaylap.Text);           
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Hoa_Don_Ban_Xe values(@STT,@MaHD,@MaKH,@MaNX,@MaNV,@SoKhung,@SoMay,@MauXe,@DonGia,@SoLuong,@TongTien,@NgayLap)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaHD", OleDbType.VarChar, 30, "MaHD");
            objCommand.Parameters.Add("@MaKH", OleDbType.VarChar, 30, "MaKH");
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar, 30, "MaNX");
            objCommand.Parameters.Add("@MaNV", OleDbType.VarChar, 30, "MaNV");
            objCommand.Parameters.Add("@SoKhung", OleDbType.VarChar, 30, "SoKhung");
            objCommand.Parameters.Add("@SoMay", OleDbType.VarChar, 30, "SoMay");
            objCommand.Parameters.Add("@MauXe", OleDbType.VarChar, 30, "MauXe");
            objCommand.Parameters.Add("@DonGia", OleDbType.Integer, 30, "DonGia");
            objCommand.Parameters.Add("@SoLuong", OleDbType.Integer, 30, "SoLuong");
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
        #region "Delete dữ liệu"
        private void deletedata()
        {
            //Tạo kết nối
            ketnoidata();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Hoa_Don_Ban_Xe", objConnect);
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
            objCommand.CommandText = "Update Hoa_Don_Ban_Xe " +
                                     "Set MaHD=@MaHD, MaKH=@MaKH, MaNX=@MaNX, MaNV=@MaNV, SoKhung=@SoKhung, SoMay=@SoMay, MauXe=@MauXe, DonGia=@DonGia, SoLuong=@SoLuong, TongTien=@TongTien, NgayLap=@NgayLap " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaHD", OleDbType.VarChar).Value = txt_mahoadon.Text;
            objCommand.Parameters.Add("@MaKH", OleDbType.VarChar).Value = cmb_makh.Text;
            objCommand.Parameters.Add("@MaNX", OleDbType.VarChar).Value = txt_manhomxe.Text;
            objCommand.Parameters.Add("@MaNV", OleDbType.VarChar).Value = cmb_maNV.Text;
            objCommand.Parameters.Add("@SoKhung", OleDbType.VarChar).Value = cmb_sokhung.Text;
            objCommand.Parameters.Add("@SoMay", OleDbType.VarChar).Value = txt_somay.Text;
            objCommand.Parameters.Add("@MauXe", OleDbType.VarChar).Value = txt_mauxe.Text;
            objCommand.Parameters.Add("@DonGia", OleDbType.Integer).Value =Convert.ToInt32(txt_dongia.Text);
            objCommand.Parameters.Add("@SoLuong", OleDbType.Integer).Value =Convert.ToInt32(txt_soluong.Text);
            objCommand.Parameters.Add("@TongTien", OleDbType.Integer).Value = Convert.ToInt32(txt_tongtien.Text);
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
            objcommand1.CommandText = "Select MaKH From Khach_Hang ORDER BY MaKH";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = objcommand1;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable1 = new DataTable("abcdf");
            objAdapter1.Fill(objDataTable1);
            // Load dữ liệu vào Combobox
            cmb_makh.DataSource = objDataTable1;
            cmb_makh.DisplayMember = "MaKH";
            cmb_makh.ValueMember = "MaKH";
            // Hủy kết nối
            huyketnoidata();

        }
        #endregion
        #region "Load CSDL Combobox2"
    /*    private void LoadCSDLcombobox2()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand2 = new OleDbCommand();
            objcommand2.Connection = objConnect;
            objcommand2.CommandType = CommandType.Text;
            objcommand2.CommandText = "Select MaNX,DonGia From Nhom_Xe ORDER BY MaNX";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter2 = new OleDbDataAdapter();
            objAdapter2.SelectCommand = objcommand2;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable2 = new DataTable("abcdfg");
            objAdapter2.Fill(objDataTable2);
            // Load dữ liệu vào Combobox
            cmb_maNX.DataSource = objDataTable2;
            cmb_maNX.DisplayMember = "MaNX";
            cmb_maNX.ValueMember = "DonGia";
            // HỦy kết nối
            huyketnoidata();


        } */
        #endregion
        #region "Load CSDL Combobox3"
        private void LoadCSDLcombobox3()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand3 = new OleDbCommand();
            objcommand3.Connection = objConnect;
            objcommand3.CommandType = CommandType.Text;
            objcommand3.CommandText = "Select * From Xe ORDER BY SoKhung";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter3 = new OleDbDataAdapter();
            objAdapter3.SelectCommand = objcommand3;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable3 = new DataTable("abcdfg");
            objAdapter3.Fill(objDataTable3);
            // Load dữ liệu vào Combobox
            cmb_sokhung.DataSource = objDataTable3;
            cmb_sokhung.DisplayMember = "SoKhung";
            cmb_sokhung.ValueMember = "SoMay";
            // HỦy kết nối
            huyketnoidata();


        }
        #endregion
        #region "Load CSDL Combobox4"
        private void LoadCSDLcombobox4()
        {
            ketnoidata(); // Tạo kết nối file Access
            // Tạo Command
            OleDbCommand objcommand4 = new OleDbCommand();
            objcommand4.Connection = objConnect;
            objcommand4.CommandType = CommandType.Text;
            objcommand4.CommandText = "Select MaNV From Nhan_Vien ORDER BY MaNV";
            //Tạo đối tượng Adapter
            OleDbDataAdapter objAdapter4 = new OleDbDataAdapter();
            objAdapter4.SelectCommand = objcommand4;
            // Tạo DataTable nhận dữ liệu trả về
            objDataTable4 = new DataTable("abcdfg");
            objAdapter4.Fill(objDataTable4);
            // Load dữ liệu vào Combobox
            cmb_maNV.DataSource = objDataTable4;
            cmb_maNV.DisplayMember = "MaNV";
            cmb_maNV.ValueMember = "MaNV";
            // HỦy kết nối
            huyketnoidata();


        }
        #endregion



        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_nhaplai_Click(object sender, EventArgs e)
        {
            txt_dongia.Text = "";
            txt_mauxe.Text = "";
            txt_ngaylap.Text = "";
            txt_soluong.Text = "";
            txt_somay.Text = "";
            txt_stt.Text = "";
            txt_tongtien.Text = "";
            cmb_makh.Text = "";
            cmb_maNV.Text = "";
            txt_manhomxe.Text = "";
            txt_mahoadon.Text = "";
            cmb_sokhung.Text = "";
        }

        private void qlhdbh_Load(object sender, EventArgs e)
        {
            hiendulieu();
            LoadCSDLcombobox1();
            LoadCSDLcombobox3();
            LoadCSDLcombobox4();
            bindingdata();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 30;
            Grid1.Columns["MaHD"].Width = 50;
            Grid1.Columns["MaKH"].Width = 50;
            Grid1.Columns["MaNX"].Width = 80;
            Grid1.Columns["MaNV"].Width = 50;
            Grid1.Columns["SoKhung"].Width = 50;
            Grid1.Columns["SoMay"].Width = 50;
            Grid1.Columns["MauXe"].Width = 50;
            Grid1.Columns["DonGia"].Width = 80;
            Grid1.Columns["SoLuong"].Width = 40;
            Grid1.Columns["TongTien"].Width = 80;
            Grid1.Columns["NgayLap"].Width = 100;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã Hóa Đơn";
            Grid1.Columns[2].HeaderText = "Mã KH";
            Grid1.Columns[3].HeaderText = "Mã Nhóm Xe";
            Grid1.Columns[4].HeaderText = "Mã Nhân Viên";
            Grid1.Columns[5].HeaderText = "Số Khung";
            Grid1.Columns[6].HeaderText = "Số Máy";
            Grid1.Columns[7].HeaderText = "Màu Xe";
            Grid1.Columns[8].HeaderText = "Đơn Giá";
            Grid1.Columns[9].HeaderText = "Số Lượng";
            Grid1.Columns[10].HeaderText = "Tổng Tiền";
            Grid1.Columns[11].HeaderText = "Ngày Lập";
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

        private void cmb_sokhung_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_somay.Text = cmb_sokhung.SelectedValue.ToString();
            txt_manhomxe.DataBindings.Clear();
            txt_manhomxe.DataBindings.Add("Text", cmb_sokhung.DataSource, "MaNX");
        }

     /*   private void cmb_maNX_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_dongia.Text = cmb_maNX.SelectedValue.ToString();
        } */
        }

    }
