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
    public partial class frmVipham : DevComponents.DotNetBar.Office2007Form
    {
        public frmVipham()
        {
            InitializeComponent();
            
        }
   
        private void frmVipham_Load(object sender, EventArgs e)
        {
            AdvancedCursors av = new AdvancedCursors();
            this.Cursor = AdvancedCursors.Create(@".\butterfree.ani");
           
            selectdl();
            
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
            //Lệnh SQL
            OleDbCommand objCommand = new OleDbCommand("Select * from VIPHAM", objConnect);
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
           
            txtmadv.DataBindings.Clear();
            txtmadv.DataBindings.Add("Text", dgdoanvien.DataSource, "MADV");
            txtmakl.DataBindings.Clear();
            txtmakl.DataBindings.Add("Text", dgdoanvien.DataSource, "MAKL");
            txtnh.DataBindings.Clear();
            txtnh.DataBindings.Add("Text", dgdoanvien.DataSource, "NAMHOC");
            txtsobb.DataBindings.Clear();
            txtsobb.DataBindings.Add("Text", dgdoanvien.DataSource, "SOBIENBAN");
            dtngayvp.DataBindings.Clear();
            dtngayvp.DataBindings.Add("Text", dgdoanvien.DataSource, "NGAYVP");

        }
        private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand { Connection = objConnect, CommandType = CommandType.Text, CommandText = "Insert into VIPHAM values(?,?,?,?,?)" };
            objCommand.Parameters.Add("@SOBIENBAN", OleDbType.VarChar).Value = txtsobb.Text;
            objCommand.Parameters.Add("@MADV", OleDbType.VarChar).Value = txtmadv.Text;           
            objCommand.Parameters.Add("@MAKL", OleDbType.VarChar).Value = txtmakl.Text;         
            objCommand.Parameters.Add("@NGAYVP", OleDbType.Date).Value = dtngayvp.Text;
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
            using (OleDbCommand objcommand = new OleDbCommand("Select * from VIPHAM", objConnect))
            {
                OleDbDataReader objReader = objcommand.ExecuteReader();
                objDataTable = new DataTable();
                objDataTable.Load(objReader);
            }
        }
        public void selectdl2()
        {
            dgdoanvien.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
           
            //Load bảng điểm
            subCreateConnect();
            using (OleDbCommand objcommand = new OleDbCommand("Select * from VIPHAM", objConnect))
            {
                OleDbDataReader objReader = objcommand.ExecuteReader();
                objDataTable = new DataTable();
                objDataTable.Load(objReader);
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Close();
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
           
            string madv = txtmadv.Text;
            string makl = txtmakl.Text;
            OleDbConnection kn = conn();
            OleDbCommand cmd = new OleDbCommand("Select MADV,MAKL from VIPHAM", kn);
            kn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (madv == dr.GetString(0))
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
                if (txtsobb.Text == "")
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show("Số biên bản không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsobb.Focus();
                }


                else
                    if (txtmadv.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmadv.Focus();
                    }
                    else
                        if (txtmakl.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Mã kỷ luật không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmakl.Focus();
                        }

                        else
                            if (txtnh.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Năm học không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtnh.Focus();
                            }
                            else
                                if (dtngayvp.Text == "")
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Ngày vi phạm không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    dtngayvp.Focus();
                                }
                            else
                                if (txtnh.Text.Trim().Length > 4 || txtnh.Text.Trim().Length < 3)
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Năm học phải là năm có 4 chữ số!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtnh.Focus();
                                }
                                else
                                    if (so() == false)
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Năm học phải là năm phải bắt đầu từ năm 2010 và phải bé hơn năm 2050!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtnh.Focus();
                                    }
                                    else
                                        if (kiemtratontai())
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Mã đoàn viên và mã kỷ luật này đã tồn tại!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
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
               MessageBoxEx.Show("Mã hình thức kỷ luật bị trùng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        private void btnlamoi_Click(object sender, EventArgs e)
        {
            txtmadv.Focus();
            txtsobb.Text = "BB0";
            txtnh.Text = DateTime.Now.Year.ToString();                
            txtmadv.Text = "";
            txtmakl.Text = "";
            dtngayvp.Text = "";
            selectdl2();
           
        }
        private void subDeleteCommandHasParameter()
        {
            //Tạo kết nối
            subCreateConnect();
            //Tạo command
            OleDbCommand objcommand = new OleDbCommand { Connection = objConnect, CommandType = CommandType.Text, CommandText = "Delete From VIPHAM Where SOBIENBAN = ?" };
            objcommand.Parameters.Add("SOBIENBAN", OleDbType.VarChar).Value = txtsobb.Text;
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
                    txtsobb.Text = "";
                    txtnh.Text = "";
                    txtmadv.Text = "";
                    txtmakl.Text = "";
                    dtngayvp.Text = "";
                    MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa " + txtsobb.Text + " này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (XOA == DialogResult.Yes)
                    {

                        subDeleteCommandHasParameter();
                        txtsobb.Text = "";
                        txtnh.Text = "";
                        txtmadv.Text = "";
                        txtmakl.Text = "";
                        dtngayvp.Text = "";
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
                MessageBoxEx.Show("Không thể xóa "+txtmadv.Text+" này được .Nếu muốn xóa thì hãy xóa "+txtmadv.Text+" trong Quản lý Hình thức kỷ luật trước tiên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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


            OleDbCommand objCommand = new OleDbCommand { Connection = objConnect, CommandType = CommandType.Text };
                subCreateConnect();

                if (demgiatri() > 0)
                {
                    if (txtsobb.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Số biên bản không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtsobb.Focus();
                    }


                    else
                        if (txtmadv.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Mã đoàn viên không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmadv.Focus();
                        }
                        else
                            if (txtmakl.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Mã kỷ luật không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtmakl.Focus();
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
                                        MessageBoxEx.Show("Năm học phải là năm có 4 chữ số!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtnh.Focus();
                                    }
                                    else
                                        if (so() == false)
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show("Năm học phải là năm phải bắt đầu từ năm 2010 và phải bé hơn năm 2050!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtnh.Focus();
                                        }
                                        
                                        else
                                        {
                                            string sql = "";
                                            sql = String.Format("UPDATE VIPHAM SET  MADV ='{0}', MAKL ='{1}',NGAYVP ='{2}',NAMHOC ='{3}' WHERE SOBIENBAN ='{4}'", txtmadv.Text, txtmakl.Text, dtngayvp.Text, txtnh.Text, txtsobb.Text);
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

        private void txtnienkhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBoxEx.Show("Không được nhập ký tự là chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVipham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (thoat == DialogResult.No);
        }

        private void xóaĐoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demgiatri()==0)
            {
                txtsobb.Text = "";
                txtnh.Text = "";
               
                txtmadv.Text = "";
                txtmakl.Text = "";
                dtngayvp.Text = "";
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Có phải bạn muốn xóa "+txtsobb.Text+" này ra khỏi danh sách đúng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    txtsobb.Text = "";
                    txtnh.Text = "";                  
                    txtmadv.Text = "";
                    txtmakl.Text = "";
                    dtngayvp.Text = "";
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
        public void GetFirstValue(string madv)
        {
            txtmakl.Text = madv;
        }

       
        public void GetFirstValue2(string sobb)
        {
            txtmadv.Text = sobb;
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            frmChon3VP first = new frmChon3VP();
            first.passData = new frmChon3VP.PassData(GetFirstValue);            
            first.passData2 = new frmChon3VP.PassData(GetFirstValue2);
            first.Show(); 
        }
    }
}