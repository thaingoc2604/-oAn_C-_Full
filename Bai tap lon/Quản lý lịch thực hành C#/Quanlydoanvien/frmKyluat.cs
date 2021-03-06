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
    public partial class frmKyluat : DevComponents.DotNetBar.Office2007Form
    {
        public frmKyluat()
        {
            InitializeComponent();
            
        }
        
        private OleDbConnection objConnect;
        private DataTable objDataTable;       
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
            String varSelect = "Select * from KYLUAT";//Lệnh SQL
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
            txtmakl.DataBindings.Clear();
            txtmakl.DataBindings.Add("Text", dgdoanvien.DataSource, "MAKL");
            txtmadv.DataBindings.Clear();
            txtmadv.DataBindings.Add("Text", dgdoanvien.DataSource, "MADV");
            txthtvp.DataBindings.Clear();
            txthtvp.DataBindings.Add("Text", dgdoanvien.DataSource, "HTVP");
            txtnh.DataBindings.Clear();
            txtnh.DataBindings.Add("Text", dgdoanvien.DataSource, "NAMHOC");

        }
        private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;

            objCommand.CommandText = "Insert into KYLUAT values(?,?,?,?)";
            objCommand.Parameters.Add("@MAKL", OleDbType.VarChar).Value = txtmakl.Text;
            objCommand.Parameters.Add("@MADV", OleDbType.VarChar).Value = txtmadv.Text;
            objCommand.Parameters.Add("@HTVP", OleDbType.VarChar).Value = txthtvp.Text;
            objCommand.Parameters.Add("@NAMHOC", OleDbType.VarChar).Value = txtnh.Text;
            
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
            OleDbCommand objcommand = new OleDbCommand("Select * from KYLUAT", objConnect);
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
            OleDbCommand objcommand = new OleDbCommand("Select * from KYLUAT", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        private void frmKyluat_Load(object sender, EventArgs e)
        {
            AdvancedCursors av = new AdvancedCursors();
            this.Cursor = AdvancedCursors.Create(@".\3dc_3043.ani");            
            selectdl();
            
        }
        public void disable()
        {
            
            txthtvp.Enabled = false;
            txtmakl.Enabled = false;
            
            
        }
        public void enable()
        {
            
            txthtvp.Enabled = true;           
            txtmakl.Enabled = true;
            
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Close();
        }
      
        private void subDeleteCommandHasParameter()
        {
            //Tạo kết nối
            subCreateConnect();
            //Tạo command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Delete From KYLUAT Where MAKL = ?";
            objcommand.Parameters.Add("MAKL", OleDbType.VarChar).Value = txtmakl.Text;
            objcommand.ExecuteNonQuery();
            //Hủy đối tượng
            objcommand.Dispose(); objcommand = null;
            subDestroyConnect();

        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (demgiatri() == 0)
                {
                    txtmakl.Text = "";
                    txthtvp.Text = "";
                    txtmadv.Text = "";
                    txtnh.Text = "";
                    MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa Record này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (XOA == DialogResult.Yes)
                    {

                        subDeleteCommandHasParameter();
                        txtmakl.Text = "";
                        txthtvp.Text = "";
                        txtmadv.Text = "";
                        txtnh.Text = "";
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
            catch (Exception)
            {
                MessageBoxEx.Show("Không thể xóa "+txtmadv.Text+" này được .Nếu muốn xóa thì hãy xóa "+txtmadv.Text+" trong Quản lý vi phạm trước tiên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnlamoi_Click(object sender, EventArgs e)
        {
            selectdl2();
            enable();
            txtmakl.Text = "KL0";           
            txthtvp.Text = "";
            txtmadv.Text = "";
            txtnh.Text = DateTime.Now.Year.ToString();
            txtmakl.Focus();
            btnthem.Enabled = true;
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
            OleDbCommand cmd = new OleDbCommand("Select MADV from KYLUAT", kn);
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
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
            if (txtmakl.Text == "")
            {
                btnthem.Enabled = true;
                MessageBoxEx.Show("Mã kỷ luật không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakl.Focus();
            }

            else
                if (txtmadv.Text == "")
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmadv.Focus();
                }
        else
            if (txthtvp.Text == "")
            {
                btnthem.Enabled = true;
                MessageBoxEx.Show("Hình thức vi phạm không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthtvp.Focus();
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
              if (so() == false)
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show("Năm học phải là năm bắt đầu từ năm 2010 hoặc bé hơn 2050 !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnh.Focus();
                }
              else
                  if (kiemtratontai())
                  {
                      btnthem.Enabled = true;
                      MessageBoxEx.Show("Mã đoàn viên này đã tồn tại !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      txtnh.Focus();
                  }

            else
            {
                btnthem.Enabled = false;
                subInsertCommandHasParameter();
                selectdl();
                MessageBoxEx.Show("Đã lưu "+txtmakl.Text+" vào CSDL thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lỗi không xác định!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool so()
        {
            int k = int.Parse(txtnh.Text);
            if (k >= 2010 && k <= 2050)
                return true;
            else
                return false;
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
        private void btnsua_Click(object sender, EventArgs e)
        {
            enable();
            try
            {
                OleDbCommand objCommand = new OleDbCommand();
                objCommand.Connection = objConnect;
                objCommand.CommandType = CommandType.Text;
                subCreateConnect();

                if (demgiatri() > 0)
                {
                    if (txtmakl.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Mã kỷ luật không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmakl.Focus();
                    }

                    else
                        if (txtmadv.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmadv.Focus();
                        }
                        else
                            if (txthtvp.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Hình thức vi phạm không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txthtvp.Focus();
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
                                        if (so() == false)
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Năm học phải là năm bắt đầu từ năm 2010 hoặc bé hơn 2050 !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtnh.Focus();
                                        }
                                        
                                            else
                                            {
                                                string sql = "";
                                                sql = "UPDATE KYLUAT SET  MADV ='" + txtmadv.Text + "', HTVP ='" + txthtvp.Text + "',NAMHOC ='" + txtnh.Text + "'WHERE MAKL='" + txtmakl.Text + "'";
                                                objCommand.CommandText = sql;
                                                objCommand.ExecuteNonQuery();
                                                objConnect.Close();
                                                MessageBoxEx.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            }
                                            else
                                            {
                                                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng này!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmKyluat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (thoat == DialogResult.No);
        }

        private void xóaĐoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                txtmakl.Text = "";
                txthtvp.Text = "";
                txtmadv.Text = "";
                txtnh.Text = "";
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa Record này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    txtmakl.Text = "";
                    txthtvp.Text = "";
                    txtmadv.Text = "";
                    txtnh.Text = "";
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
        public void GetFirstValue(string value)
        {
            txtmadv.Text = value;
        }

       
        private void txthtvp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            frmchonmadv first = new frmchonmadv();
            first.passData = new frmchonmadv.PassData(GetFirstValue);           
            first.Show(); 
        }
        public DataTable combo(string s, OleDbParameter[] sp)
        {
            OleDbConnection varChuoiConnect = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                        "Data Source =" + Application.StartupPath + @"\quanlydoanvien.mdb;" +
                        "Jet OLEDB:Database Password =000000;" +
                        "User ID = admin");
            DataTable dt = new DataTable();
            try
            {
                varChuoiConnect.Open();
                OleDbCommand cm = new OleDbCommand();
                cm.Connection = varChuoiConnect;
                cm.CommandType = CommandType.Text;
                cm.CommandText = s;
                foreach (OleDbParameter s1 in sp)
                {
                    cm.Parameters.Add(s1);
                }
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cm;

                da.Fill(dt);
                varChuoiConnect.Close();
                return dt;
            }
            catch (Exception exp)
            {
                MessageBoxEx.Show(exp.Message);
                return dt;
            }
        }
        // hien thi chi tiết đoàn viên theo từng Mã đoàn viên
        public DataTable chitiet(string s1)
        {
            DataTable dt = new DataTable();
            string sql = "select * from DOANVIEN where MADV=@MADV";
            OleDbParameter[] sp = new OleDbParameter[1];
            sp[0] = new OleDbParameter("@MADV", s1);
            return dt = combo(sql, sp);
        }

        private void dgdoanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = chitiet(txtmadv.Text);
               
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lỗi không xác định!");
            }
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            frmKyluat th = new frmKyluat();
            try
            {

                frmInKL kl = new frmInKL();
                kl.Show();

            }
            catch (Exception)
            {
                MessageBoxEx.Show("Không thể bật chức năng này vì bạn chưa cài đặt ReportViewer!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}