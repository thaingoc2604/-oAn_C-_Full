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
    public partial class qlncc : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public qlncc()
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
            objcommand.CommandText = "Select * From Nha_Cung_Cap ORDER BY STT";
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
            txt_ncc.DataBindings.Clear();
            txt_ncc.DataBindings.Add("Text", Grid1.DataSource, "MaNCC");
            txt_tenncc.DataBindings.Clear();
            txt_tenncc.DataBindings.Add("Text", Grid1.DataSource, "TenNCC");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", Grid1.DataSource, "DiaChi");
            txt_dienthoai.DataBindings.Clear();
            txt_dienthoai.DataBindings.Add("Text", Grid1.DataSource, "SDT");
            txt_email.DataBindings.Clear();
            txt_email.DataBindings.Add("Text", Grid1.DataSource, "Email");
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Nha_Cung_Cap", objConnect);
            objAdapter.Fill(objDataTable);
            //Insert dữ liệu vào DataTable
            DataRow objRow = objDataTable.NewRow();
            objRow["STT"] = Convert.ToInt32(txt_stt.Text);
            objRow["MaNCC"] = txt_ncc.Text;
            objRow["TenNCC"] = txt_tenncc.Text;
            objRow["DiaChi"] = txt_diachi.Text;
            objRow["SDT"] = Convert.ToInt32(txt_dienthoai.Text);
            objRow["Email"] = txt_email.Text;
            objDataTable.Rows.Add(objRow);
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into Nha_Cung_Cap values(@STT,@MaNCC,@TenNCC,@DiaChi,@SDT,@Email)";
            objCommand.Parameters.Add("@STT", OleDbType.Integer, 30, "STT");
            objCommand.Parameters.Add("@MaNCC", OleDbType.VarChar, 30, "MaNCC");
            objCommand.Parameters.Add("@TenNCC", OleDbType.VarChar, 30, "TenNCC");
            objCommand.Parameters.Add("@DiaChi", OleDbType.VarChar, 30, "DiaChi");
            objCommand.Parameters.Add("@SDT", OleDbType.Integer, 30, "SDT");
            objCommand.Parameters.Add("@Email", OleDbType.VarChar, 30, "Email");
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
            objCommand.CommandText = "Update Nha_Cung_Cap " +
                                     "Set MaNCC=@MaNCC, TenNCC=@TenNCC, DiaChi=@DiaChi, SDT=@SDT, Email=@Email " +
                                     "Where STT=@STT";
            //objCommand.CommandText = "Update DanhsachSV Set Name=?,Address=?,Phone=?,Email=? Where STT=?";                
            objCommand.Parameters.Add("@MaNCC", OleDbType.VarChar).Value = txt_ncc.Text;
            objCommand.Parameters.Add("@TenNCC", OleDbType.VarChar).Value = txt_tenncc.Text;
            objCommand.Parameters.Add("@DiaChi", OleDbType.VarChar).Value = txt_diachi.Text;
            objCommand.Parameters.Add("@SDT", OleDbType.Integer).Value = Convert.ToInt32(txt_dienthoai.Text);
            objCommand.Parameters.Add("@Email", OleDbType.VarChar).Value = txt_email.Text;
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
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Nha_Cung_Cap", objConnect);
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

        private void qlncc_Load(object sender, EventArgs e)
        {
            hiendulieu();
            #region "Thay đổi độ rộng cột"
            Grid1.Columns["STT"].Width = 40;
            Grid1.Columns["MaNCC"].Width = 110;
            Grid1.Columns["TenNCC"].Width = 130;
            Grid1.Columns["DiaChi"].Width = 130;
            Grid1.Columns["SDT"].Width = 120;
            Grid1.Columns["Email"].Width = 120;
            #endregion
            #region "Thay đổi tiêu đề cột"
            Grid1.Columns[0].HeaderText = "STT";
            Grid1.Columns[1].HeaderText = "Mã NCC";
            Grid1.Columns[2].HeaderText = "Tên NCC";
            Grid1.Columns[3].HeaderText = "Địa Chỉ";
            Grid1.Columns[4].HeaderText = "Số Điện Thoại";
            Grid1.Columns[5].HeaderText = "Email";
            #endregion
            bindingdata();
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
            txt_diachi.Text = "";
            txt_dienthoai.Text = "";
            txt_email.Text = "";
            txt_ncc.Text = "";
            txt_stt.Text = "";
            txt_tenncc.Text = "";
        }
    }
}
