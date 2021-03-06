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
    public partial class frmDoanphi : DevComponents.DotNetBar.Office2007Form
    {
        
        public frmDoanphi()
        {
            InitializeComponent();
            
                                
                
        }

        public OleDbConnection conn()
        {
            return new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                        "Data Source =" + Application.StartupPath + @"\quanlydoanvien.mdb;" +
                        "Jet OLEDB:Database Password =000000;" +
                        "User ID = admin");
        }
        private void frmDoanphi_Load(object sender, EventArgs e)
        {
            AdvancedCursors av = new AdvancedCursors();
            this.Cursor = AdvancedCursors.Create(@".\anml_frm_turkey_01.ani");
            selectdl();
            txtmadp.Enabled = false;
            txtsotien.Enabled = false;
            btnlamoi.Enabled = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnchon.Enabled = false;
            txthientai.Enabled = false;
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
            String varSelect = "Select * from DOANPHI";//Lệnh SQL
            OleDbCommand objCommand = new OleDbCommand(varSelect, objConnect);
            //Tạo DataReader nhận dữ liệu trả về
            OleDbDataReader objReader = objCommand.ExecuteReader();
            //Tạo đối tượng DataTable và Load DataReader vào
            objDataTable = new DataTable("abc");
            objDataTable.Load(objReader);
            //Gán dữ liệu vào Datagrid
            dgdp.DataSource = objDataTable;
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
            txtmadp.DataBindings.Clear();
            txtmadp.DataBindings.Add("Text", dgdp.DataSource, "MADP");
            txthientai.DataBindings.Clear();
            txthientai.DataBindings.Add("Text", dgdp.DataSource, "HIENTAI");
            txtmadv.DataBindings.Clear();
            txtmadv.DataBindings.Add("Text", dgdp.DataSource, "MADV");
            txtnh.DataBindings.Clear();
            txtnh.DataBindings.Add("Text", dgdp.DataSource, "NAMHOC");
            txtsotien.DataBindings.Clear();
            txtsotien.DataBindings.Add("Text", dgdp.DataSource, "SOTIEN");
            
           

        }
        private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Insert into DOANPHI values(?,?,?,?,?)";
            objCommand.Parameters.Add("@MADP", OleDbType.VarChar).Value = txtmadp.Text;
            objCommand.Parameters.Add("@MADV", OleDbType.VarChar).Value = txtmadv.Text;                    
            objCommand.Parameters.Add("@SOTIEN", OleDbType.Numeric).Value = txtsotien.Text;
            objCommand.Parameters.Add("@HIENTAI", OleDbType.VarChar).Value = txthientai.Text;
            objCommand.Parameters.Add("@NAMHOC", OleDbType.VarChar).Value = txtnh.Text;
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            subDestroyConnect();
        }
        public void selectdl()
        {
            dgdp.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from DOANPHI", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            
        }
        public bool ktdp()
        {
            int i = int.Parse(txtsotien.Text);
            if (i == 0 || i >= 10000)
                return true;
            else
                return false;
        }
        public bool KTNH()
        {
            int k = int.Parse(txtnh.Text);
            if (k >= 2010 && k <= 2050)
                return true;
            else
                return false;
        }
       private bool kiemtratrung()
        {
            bool tatkt = false;
            string cmnd = txtmadv.Text;
            OleDbConnection kn = conn();
            OleDbCommand cmd = new OleDbCommand("Select MADV from DOANPHI", kn);
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
                if (txtmadp.Text == "")
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show("Mã đoàn phí không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmadp.Focus();
                }
                
                else
                    if (txtmadv.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Bạn chưa chọn mã đoàn viên!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmadv.Focus();
                    }
                    else
                        if (txtnh.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Bạn chưa chon năm học !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtnh.Focus();
                        }
                        
                            else
                                if (KTNH()==false)
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Năm học phải là năm bắt đầu từ năm 2010 hoặc bé hơn 2050 !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtnh.Focus();
                                }
                           
                                else
                                    if (txtsotien.Text=="")
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Số tiền không được rỗng!", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtsotien.Focus();
                                    }
                                   
                                else
                                    if (ktdp()==false)
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show(" Số tiền vừa nhập không đúng so với qui định(Phải bé hơn 100 nghìn hoặc lớn hơn 10 nghìn!)", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                   
                                        else
                                            if (txthientai.Text == "Đã đóng" && txtsotien.Text =="0")
                                            {
                                                btnthem.Enabled = true;
                                                MessageBoxEx.Show(" Không hợp lý! Vì đã đóng đoàn phí rồi(Số tiền không thể bằng 0 được)", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtsotien.Focus(); ;
                                            }
                                            else
                                                if (txthientai.Text == "Chưa đóng" && txtsotien.Text != "0")
                                                {
                                                    btnthem.Enabled = true;
                                                    MessageBoxEx.Show(" Không hợp lý! Vì chưa đóng đoàn phí nên(Số tiền phải bằng 0)", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txtsotien.Focus(); 
                                                }
                                    else
                                        if (kiemtratrung())
                                        {
                                            MessageBoxEx.Show("Mã đoàn viên này đã tồn tại!Vui lòng chọn mã khác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtmadv.Focus();
                                        }

                                        else
                                        {
                                            btnthem.Enabled = false;
                                            subInsertCommandHasParameter();
                                            selectdl2();
                                            MessageBoxEx.Show("Đã lưu đoàn phí " + txtmadp.Text + " vào CSDL thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
            }
            catch (Exception)
           {
               btnthem.Enabled = true;
               MessageBoxEx.Show("Mã đoàn này đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
           }
        }
        public void selectdl2()
        {
            dgdp.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            //subBindingData();
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from DOANPHI", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        private void txtsotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBoxEx.Show("Không được nhập ký tự là chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnh_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //selectdl();
            txtsotien.Enabled = true;
            txtmadp.ReadOnly = true;
            btnthem.Enabled = false;
            try
            {
                if (demgiatri() == 0)
                {
                    btnthem.Enabled = false;
                    MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng  này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtmadp.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show("Mã đoàn phí không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmadp.Focus();
                    }

                    else
                        if (txtmadv.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show("Mã đoàn viên không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmadv.Focus();
                        }
                        else
                            if (txtnh.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show("Bạn chưa chon năm học !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtnh.Focus();
                            }

                            else
                                if (KTNH() == false)
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show("Năm học phải là năm bắt đầu từ năm 2010 hoặc bé hơn 2050 !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtnh.Focus();
                                }

                                else
                                    if (txtsotien.Text == "")
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show("Số tiền không được rỗng!", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtsotien.Focus();
                                    }

                                    else
                                        if (ktdp() == false)
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show(" Số tiền vừa nhập không đúng so với qui định(Phải bé hơn 100 nghìn hoặc lớn hơn 10 nghìn!)", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }

                                        else
                                            if (txthientai.Text == "Đã đóng" && txtsotien.Text == "0")
                                            {
                                                btnthem.Enabled = true;
                                                MessageBoxEx.Show(" Không hợp lý! Vì đã đóng đoàn phí rồi(Số tiền không thể bằng 0 được)", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtsotien.Focus(); ;
                                            }
                                            else
                                                if (txthientai.Text == "Chưa đóng" && txtsotien.Text != "0")
                                                {
                                                    btnthem.Enabled = true;
                                                    MessageBoxEx.Show(" Không hợp lý! Vì chưa đóng đoàn phí nên(Số tiền phải bằng 0)", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txtsotien.Focus();
                                                }
                                                
                                                        else
                                                        if (ktdp() == false)
                                                        {

                                                            MessageBoxEx.Show(" Số tiền vừa nhập không đúng so với qui định(Phải bé hơn 100 nghìn hoặc lớn hơn 10 nghìn)!", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            txtsotien.Focus();
                                                        }
                                                        else
                                                        {
                                                            OleDbCommand objCommand = new OleDbCommand();
                                                            objCommand.Connection = objConnect;
                                                            objCommand.CommandType = CommandType.Text;
                                                            subCreateConnect();
                                                            string sql = "";
                                                            sql = "UPDATE DOANPHI SET SOTIEN ='" + txtsotien.Text + "', HIENTAI ='" + txthientai.Text + "' WHERE MADP='" + txtmadp.Text + "'";
                                                            objCommand.CommandText = sql;
                                                            objCommand.ExecuteNonQuery();
                                                            objConnect.Close();
                                                            MessageBoxEx.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                        selectdl();
                }
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lỗi không xác định!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void subDeleteCommandHasParameter()
        {
            //Tạo kết nối
            subCreateConnect();
            //Tạo command
            OleDbCommand objcommand = new OleDbCommand();
            objcommand.Connection = objConnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Delete From DOANPHI Where MADP = ?";
            objcommand.Parameters.Add("MADP", OleDbType.VarChar).Value = txtmadp.Text;
            objcommand.ExecuteNonQuery();
            //Hủy đối tượng
            objcommand.Dispose(); objcommand = null;
            subDestroyConnect();

        }
        public void rong()
        {
            txtmadp.Text = "";
            txtmadv.Text = "";
            txtsotien.Text = "";
            txtnh.Text = "";
        }
        public int demgiatri()
        {
            int i;
            for (i = 0; i < dgdp.RowCount - 1; i++)
            {
                i.ToString();
            }
            return i;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                rong();
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Bạn có chắt là xóa mã đoàn phí "+txtmadp.Text+" ra khỏi danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    rong();
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
        public long tang()
        {
            long i;
            long s = 0;
            for (i = 0; i < dgdp.RowCount; i++)
            {
                s = i + 1;
            }
            return s;
        }
        private void btnlamoi_Click(object sender, EventArgs e)
        {
            txthientai.Text = "Đã đóng";
            txtsotien.Enabled = true;
            txtmadp.Enabled = true;
            txtmadv.Text = "";
            txtsotien.Text = "";
            txtnh.Text = DateTime.Now.Year.ToString();
            txtmadp.Text = "DP";
            txtsotien.Text = "";
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            txtmadp.Focus();
            selectdl2();
            btnchon.Enabled = true;
        }

        private void frmDoanphi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (thoat == DialogResult.No);
                
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                rong();
                MessageBoxEx.Show("Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show("Bạn có chắt là xóa đoàn viên này ra khỏi danh sách đoàn phí?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    rong();
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
        
      
        private void buttonX1_Click(object sender, EventArgs e)
        {            
            
        }
       
       
        private void txtmadv_KeyDown(object sender, KeyEventArgs e)
        {
                 
            
        }
        
        private void txtnh_KeyDown(object sender, KeyEventArgs e)
        {
          
         
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            frmchonmadv first = new frmchonmadv();
            first.passData = new frmchonmadv.PassData(GetFirstValue);
           
            first.Show(); 


        }
        public void GetFirstValue(string value)
        {
            txtmadv.Text = value;
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btnlamoi.Enabled = true;
            btnthem.Enabled = true;
            txtmadp.Enabled = true;
            txtmadp.Enabled = true;
            txthientai.Enabled = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = true;
            btnthem.Enabled = false;
            txtsotien.Enabled = true;
            btnlamtuoi.Enabled = false;
            txtsotien.Enabled = true;
            
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

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgdp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = chitiet(txtmadv.Text);
               
                if (txtsotien.Text == "0")
                {
                    labelX3.Text = "Đoàn viên này chưa đóng đoàn phí!(@~@)";
                }
                    else
                    if (txtsotien.Text == "")
                    {
                        labelX3.Text = "Không xác định được đoàn viên nào(@~@)";
                    }
                    else
                        labelX3.Text = "Đoàn viên này đã đóng đoàn phí!(@~@)";
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lỗi không xác định!");
            }
        }

        private void dgdp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlamtuoi_Click(object sender, EventArgs e)
        {
            selectdl();
        }
    }
}