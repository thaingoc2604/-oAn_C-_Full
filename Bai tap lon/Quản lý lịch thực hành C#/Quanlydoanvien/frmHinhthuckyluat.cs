using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace Quanlydoanvien
{
    public partial class frmHinhthuckyluat : DevComponents.DotNetBar.Office2007Form
    {
        public frmHinhthuckyluat()
        {
            InitializeComponent();
           
        }
        

        private OleDbConnection objConnect;
        private DataTable objDataTable;
        private enum varMode : int { AddMode, EditMode, DeleteMode }


        private void subCreateConnect()
        {
            try
            {
                String varChuoiConnect = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                            "Data Source =" + Application.StartupPath + @"\quanlydoanvien.mdb;" +
                            "Jet OLEDB:Database Password =000000;" +
                            "User ID = admin";
                objConnect = new OleDbConnection(varChuoiConnect);
                objConnect.Open();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Không thể kết nối tới CSDL. Xin kiểm tra lại kết nối!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void subDestroyConnect()
        {
            objConnect.Close(); //Đóng kết nối
            objConnect.Dispose();//Giải phóng tài nguyên
            objConnect = null; //Hủy đối tượng
        }
        private void subSelectBySQLTructiepQuaDataReader()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Truy vấn dữ liệu
            String varSelect = "Select * from HINHTHUCKYLUAT";//Lệnh SQL
            OleDbCommand objCommand = new OleDbCommand(varSelect, objConnect);
            //Tạo DataReader nhận dữ liệu trả về
            OleDbDataReader objReader = objCommand.ExecuteReader();
            //Tạo đối tượng DataTable và Load DataReader vào
            objDataTable = new DataTable("abc");
            objDataTable.Load(objReader);
            //Gán dữ liệu vào Datagrid
            dgdoanvien.DataSource = objDataTable;
            //Hủy các đối tượng
            objCommand.Dispose();
            objCommand = null;
            objReader.Close();
            objReader.Dispose();
            objReader = null;
            objDataTable.Dispose();
            objDataTable = null;
            subDestroyConnect();
        }
        private void subBindingData()
        {
            txtmahtkl.DataBindings.Clear();
            txtmahtkl.DataBindings.Add("Text", dgdoanvien.DataSource, "MAHTKL");
            txtmadv.DataBindings.Clear();
            txtmadv.DataBindings.Add("Text", dgdoanvien.DataSource, "MADV");
            txthtkl.DataBindings.Clear();
            txthtkl.DataBindings.Add("Text", dgdoanvien.DataSource, "HTKL");
            txtnh.DataBindings.Clear();
            txtnh.DataBindings.Add("Text", dgdoanvien.DataSource, "NAMHOC");
            txtsobb.DataBindings.Clear();
            txtsobb.DataBindings.Add("Text", dgdoanvien.DataSource, "SOBIENBAN");

        }
        private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;

            objCommand.CommandText = "Insert into HINHTHUCKYLUAT values(?,?,?,?,?)";
            objCommand.Parameters.Add("@MAHKL", OleDbType.VarChar).Value = txtmahtkl.Text;
            objCommand.Parameters.Add("@MADV", OleDbType.VarChar).Value = txtmadv.Text;
            objCommand.Parameters.Add("@HTKL", OleDbType.VarChar).Value = txthtkl.Text;
            objCommand.Parameters.Add("@NAMHOC", OleDbType.VarChar).Value = txtnh.Text;
            objCommand.Parameters.Add("@SOBIENBAN", OleDbType.VarChar).Value = txtsobb.Text;
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            subDestroyConnect();
        }
        public void selectdl()
        {
            dgdoanvien.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from HINHTHUCKYLUAT", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        public void selectdl2()
        {
            dgdoanvien.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from HINHTHUCKYLUAT", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        private void frmHinhthuckyluat_Load(object sender, EventArgs e)
        {
            AdvancedCursors av = new AdvancedCursors();
            this.Cursor = AdvancedCursors.Create(@".\aerodactyl.ani");
            
            selectdl();
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Close();
        }
        public bool KTNH()
        {
            int k = int.Parse(txtnh.Text);
            if (k >= 2010 && k <= 2050)
                return true;
            else
                return false;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            selectdl2();
            try
            {
                if (txtmahtkl.Text == "")
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show("Mã hình thức kỷ luật không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmahtkl.Focus();
                }

                else
                    if (txtmadv.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmadv.Focus();
                    }
                    else
                        if (txthtkl.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Hình thức kỷ luật không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txthtkl.Focus();
                        }
                        else
                            if (txtsobb.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Số biên bản không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtsobb.Focus();
                            }

                            else
                                if (txtnh.Text == "")
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Năm học không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtnh.Focus();
                                }
                                else
                                    if (txtnh.Text.Trim().Length > 4 || txtnh.Text.Trim().Length < 3)
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Năm học không được lớn hơn 4 ký tự !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtnh.Focus();
                                    }
                                    else
                                        if (KTNH() == false)
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Năm học phải lớn hơn hoặc bằng năm 2010 và phải bé hơn hoăc bằng 2050 !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtnh.Focus();
                                        }
                                        else
                                            if (kiemtratontai())
                                            {
                                                btnthem.Enabled = true;
                                                MessageBoxEx.Show("Mã đoàn viên này đã tồn tại!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtmadv.Focus();
                                            }
                                            else
                                            {

                                                subInsertCommandHasParameter();
                                               
                                                MessageBoxEx.Show("Đã lưu vào CSDL thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            } 
                selectdl2();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Mã hình thức kỷ luật bị trùng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool so()
        {
            int i = Int32.Parse(txtnh.Text);
            if (i >= 2010)
                return true;
            else
            return false;
        }
       
        private void btnlamoi_Click(object sender, EventArgs e)
        {
            txtmadv.Focus();
            txtsobb.Text = "";
            txtnh.Text = DateTime.Now.Year.ToString();
            txtmahtkl.Text = "HTKL0";            
            txtmadv.Text = "";
            txthtkl.Text = "";
            selectdl2();
            
        }
        private void subDeleteCommandHasParameter()
        {
            //Tạo kết nối
            subCreateConnect();
            //Tạo command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Delete From HINHTHUCKYLUAT Where MAHTKL = ?";
            objcommand.Parameters.Add("MAHTKL", OleDbType.VarChar).Value = txtmahtkl.Text;
            objcommand.ExecuteNonQuery();
            //Hủy đối tượng
            objcommand.Dispose(); objcommand = null;
            subDestroyConnect();

        }
        public int demgiatri()
        {
            int i;
            for (i = 0; i < dgdoanvien.RowCount - 1; i++)
            {
                i.ToString();
            }
            return i;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                txtsobb.Text = "";
                txtnh.Text = "";
                txtmahtkl.Text = "";
                txtmadv.Text = "";
                txthtkl.Text = "";
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa Record này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    txtsobb.Text = "";
                    txtnh.Text = "";
                    txtmahtkl.Text = "";                    
                    txtmadv.Text = "";
                    txthtkl.Text = "";
                    selectdl();

                    MessageBoxEx.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Bạn đã không xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            selectdl();
        }
        public OleDbConnection conn()
        {
            return new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                        "Data Source =" + Application.StartupPath + @"\quanlydoanvien.mdb;" +
                        "Jet OLEDB:Database Password =000000;" +
                        "User ID = admin");
        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string cmnd = txtmadv.Text;
            OleDbConnection kn = conn();
            OleDbCommand cmd = new OleDbCommand("Select MADV from HINHTHUCKYLUAT", kn);
            kn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (cmnd == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            kn.Close();
            return tatkt;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            try
            {
                OleDbCommand objCommand = new OleDbCommand();
                objCommand.Connection = objConnect;
                objCommand.CommandType = CommandType.Text;
                subCreateConnect();

                if (demgiatri() > 0)
                {
                    if (txtmahtkl.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Mã hình thức kỷ luật không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmahtkl.Focus();
                    }

                    else
                        if (txtmadv.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmadv.Focus();
                        }
                        else
                            if (txthtkl.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Hình thức kỷ luật không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txthtkl.Focus();
                            }
                            else
                                if (txtsobb.Text == "")
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Số biên bản không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtsobb.Focus();
                                }

                                else
                                    if (txtnh.Text == "")
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Năm học không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtnh.Focus();
                                    }
                                    else
                                        if (txtnh.Text.Trim().Length > 4 || txtnh.Text.Trim().Length < 3)
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Năm học không được lớn hơn 4 ký tự !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtnh.Focus();
                                        }
                                        else
                                            if (KTNH() == false)
                                            {
                                                btnthem.Enabled = true;
                                                MessageBoxEx.Show("Năm học phải lớn hơn hoặc bằng năm 2010 và phải bé hơn hoăc bằng 2050 !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtnh.Focus();
                                            }
                                          
                                            else
                                            {
                                                string sql = "";
                                                sql = "UPDATE HINHTHUCKYLUAT SET  HTKL = '" + txthtkl.Text + "', MADV ='" + txtmadv.Text + "',NAMHOC ='" + txtnh.Text + "',SOBIENBAN ='" + txtsobb.Text + "' WHERE MAHTKL='" + txtmahtkl.Text + "'";
                                                objCommand.CommandText = sql;
                                                objCommand.ExecuteNonQuery();
                                                objConnect.Close();
                                                MessageBoxEx.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            }
                                            else
                                            {
                                                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng này!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            selectdl();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lỗi không xác định!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtnienkhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBoxEx.Show("Không được nhập ký tự là chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsobb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBoxEx.Show(" Không được nhập ký tự là chữ số!", " Lỗi! ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmHinhthuckyluat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (thoat == DialogResult.No);
        }

        private void xóaĐoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                txtsobb.Text = "";
                txtnh.Text = "";
                txtmahtkl.Text = "";
                txtmadv.Text = "";
                txthtkl.Text = "";
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa Record này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    txtsobb.Text = "";
                    txtnh.Text = "";
                    txtmahtkl.Text = "";
                    txtmadv.Text = "";
                    txthtkl.Text = "";
                    selectdl();

                    MessageBoxEx.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show("Bạn đã không xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            selectdl();
        }

        private void txthtkl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }
        public void GetFirstValue(string madv)
        {
            txtsobb.Text = madv;
        }

       
        public void GetFirstValue2(string sobb)
        {
            txtnh.Text = sobb;
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            frmChon3 first = new frmChon3();
            first.passData = new frmChon3.PassData(GetFirstValue);
            first.passData2 = new frmChon3.PassData(GetFirstValue2);
            
            first.Show(); 
        }
    }
}