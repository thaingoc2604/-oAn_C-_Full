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
    public partial class frmNhanxet : DevComponents.DotNetBar.Office2007Form
    {
        public frmNhanxet()
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
            String varSelect = "Select * from NHANXET";//Lệnh SQL
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
            txtmanx.DataBindings.Clear();
            txtmanx.DataBindings.Add("Text", dgdoanvien.DataSource, "MANX");
            txtmadv.DataBindings.Clear();
            txtmadv.DataBindings.Add("Text", dgdoanvien.DataSource, "MADV");
            txtnh.DataBindings.Clear();
            txtnh.DataBindings.Add("Text", dgdoanvien.DataSource, "NAMHOC");
            txtud.DataBindings.Clear();
            txtud.DataBindings.Add("Text", dgdoanvien.DataSource, "UUDIEM");
            txtkhuyetdiem.DataBindings.Clear();
            txtkhuyetdiem.DataBindings.Add("Text", dgdoanvien.DataSource, "KHUYETDIEM");
            txtkhenthuong.DataBindings.Clear();
            txtkhenthuong.DataBindings.Add("Text", dgdoanvien.DataSource, "KHENTHUONG");

            txtxeploai.DataBindings.Clear();
            txtxeploai.DataBindings.Add("Text", dgdoanvien.DataSource, "XEPLOAI");

        }
        private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;

            objCommand.CommandText = "Insert into NHANXET values(?,?,?,?,?,?,?)";
            objCommand.Parameters.Add("@MANX", OleDbType.VarChar).Value = txtmanx.Text;
            objCommand.Parameters.Add("@MADV", OleDbType.VarChar).Value = txtmadv.Text;
            objCommand.Parameters.Add("@UUDIEM", OleDbType.VarChar).Value = txtud.Text;
            objCommand.Parameters.Add("@KHUYETDIEM", OleDbType.VarChar).Value = txtkhuyetdiem.Text;
            objCommand.Parameters.Add("@XEPLOAI", OleDbType.VarChar).Value = txtxeploai.Text;
            objCommand.Parameters.Add("@KHENTHUONG", OleDbType.VarChar).Value = txtkhenthuong.Text;
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
            OleDbCommand objcommand = new OleDbCommand("Select * from NHANXET", objConnect);
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
            OleDbCommand objcommand = new OleDbCommand("Select * from NHANXET", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        private void frmNhanxet_Load(object sender, EventArgs e)
        {
            AdvancedCursors av = new AdvancedCursors();
            this.Cursor = AdvancedCursors.Create(@".\articuno.ani");
           
            selectdl();
            
        }
        
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Close();
        }
        public long tang()
        {
            long i;
            long s = 0;
            for (i = 0; i < dgdoanvien.RowCount; i++)
            {
                s = i + 1;
            }
            return s;
        }
        private void btnlamoi_Click(object sender, EventArgs e)
        {
            txtmanx.Focus();
            txtxeploai.Text = "Tốt";
            
            txtkhenthuong.Text = "Được khen thưởng";
            txtmadv.Text = "";
            txtmanx.Text = "NX0" ;
            txtnh.Text = DateTime.Now.Year.ToString();
            txtud.Text = "";
            txtkhuyetdiem.Text = "";
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
            objcommand.CommandText = "Delete From NHANXET Where MANX = ?";
            objcommand.Parameters.Add("MANX", OleDbType.VarChar).Value = txtmanx.Text;
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
                txtxeploai.Text = "";
                txtkhenthuong.Text = "";
                txtmadv.Text = "";
                txtmanx.Text = "";
                txtnh.Text = "";
                txtud.Text = "";
                txtkhuyetdiem.Text = "";
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa đoàn viên này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();

                    txtxeploai.Text = "";

                    txtkhenthuong.Text = "";
                    txtmadv.Text = "";
                    txtmanx.Text = "";
                    txtnh.Text = "";
                    txtud.Text = "";
                    txtkhuyetdiem.Text = "";
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
        public bool so()
        {
            int k = int.Parse(txtnh.Text);
            if (k >= 2010 && k <= 2050)
                return true;
            else
                return false;
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
            OleDbCommand cmd = new OleDbCommand("Select MADV from NHANXET", kn);
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
            selectdl2();
            try
            {
                if (txtmanx.Text == "")
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show("Mã Nhận xét không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmanx.Focus();
                }

                else
                    if (txtmadv.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmadv.Focus();
                    }
                    else
                        if (txtkhenthuong.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Khen thưởng không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtkhenthuong.Focus();
                        }
                        else
                            if (txtnh.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Năm học không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtnh.Focus();
                            }

                            else
                                if (txtxeploai.Text == "")
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Xếp loại không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtxeploai.Focus();
                                }
                                else
                                    if (txtkhenthuong.Text == "Được khen thưởng" && (txtxeploai.Text == "Trung bình" || txtxeploai.Text == "Trung bình khá" || txtxeploai.Text == "Yếu"))
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Không hợp lý xếp loại như vậy không thể được khen thưởng được !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtkhenthuong.Focus();
                                    }
                                    else
                                        if ((txtkhuyetdiem.Text != "" && txtkhenthuong.Text != "Được khen thưởng"))
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Không hợp lý có khuyết điểm nên không thể được khen thưởng được !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtkhenthuong.Focus();
                                        }
                                else
                                    if (so() == false)
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Năm học phải là năm bắt đầu từ năm 2010 hoặc bé hơn 2050 !!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    else
                                        if (kiemtratontai())
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Mã đoàn viên này đã tồn tại ", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtnh.Focus();
                                        }
                                        else
                                        {

                                            subInsertCommandHasParameter();
                                            selectdl();
                                            MessageBoxEx.Show("Đã lưu vào CSDL thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
               
            }
           catch (Exception)
            {
                MessageBoxEx.Show("Mã nhận xét này đã tồn tại!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
                    if (txtmanx.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Mã Nhận xét không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmanx.Focus();
                    }

                    else
                        if (txtmadv.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmadv.Focus();
                        }
                        else
                            if (txtkhenthuong.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Khen thưởng không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtkhenthuong.Focus();
                            }
                            else
                                if (txtnh.Text == "")
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Năm học không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtnh.Focus();
                                }

                                else
                                    if (txtxeploai.Text == "")
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Xếp loại không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtxeploai.Focus();
                                    }
                                    else
                                        if ( txtkhenthuong.Text == "Được khen thưởng" && (txtxeploai.Text == "Trung bình" || txtxeploai.Text == "Trung bình khá" || txtxeploai.Text == "Yếu"))
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Không hợp lý xếp loại như vậy không thể được khen thưởng được !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtkhenthuong.Focus();
                                        }
                                        else
                                            if ((txtkhuyetdiem.Text != "" && txtkhenthuong.Text == "Được khen thưởng"))
                                            {
                                                btnthem.Enabled = true;
                                                MessageBoxEx.Show("Không hợp lý có khuyết điểm nên không thể được khen thưởng được !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtkhenthuong.Focus();
                                            }
                                    else
                                        if (so() == false)
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Năm học phải là năm bắt đầu từ năm 2010 hoặc bé hơn 2050 !!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        //else
                                        //    if (kiemtratontai())
                                        //    {
                                        //        btnthem.Enabled = true;
                                        //        MessageBoxEx.Show("Mã đoàn viên này đã tồn tại ", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        //        txtnh.Focus();
                                        //    }

                                            else
                                            {

                                                string sql = "";
                                                sql = "UPDATE NHANXET SET  MADV ='" + txtmadv.Text + "', UUDIEM ='" + txtud.Text + "',KHUYETDIEM ='" + txtkhuyetdiem.Text + "',XEPLOAI ='" + txtxeploai.Text + "',KHENTHUONG ='" + txtkhenthuong.Text + "',NAMHOC ='" + txtnh.Text + "' WHERE MANX ='" + txtmanx.Text + "'";
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
                DialogResult show = MessageBoxEx.Show("Lỗi không xác định!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBoxEx.Show("Không được nhập ký tự là chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNhanxet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (thoat == DialogResult.No);
        }

        private void xóaĐoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                txtxeploai.Text = "";
                txtkhenthuong.Text = "";
                txtmadv.Text = "";
                txtmanx.Text = "";
                txtnh.Text = "";
                txtud.Text = "";
                txtkhuyetdiem.Text = "";
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa đoàn viên này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();

                    txtxeploai.Text = "";

                    txtkhenthuong.Text = "";
                    txtmadv.Text = "";
                    txtmanx.Text = "";
                    txtnh.Text = "";
                    txtud.Text = "";
                    txtkhuyetdiem.Text = "";
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

        private void txtkhuyetdiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

        private void txtud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }
        public void GetFirstValue(string value)
        {
            txtmadv.Text = value;
        }

       

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmChonMadvandNamhoc first = new frmChonMadvandNamhoc();
            first.passData = new frmChonMadvandNamhoc.PassData(GetFirstValue);
            
            first.Show(); 
        }  
  
    }
}