using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AnTCafe
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn;
        clsCommonUI objCommonUI = new clsCommonUI();
        SqlDataAdapter adapter;
        DataTable tblTable = new DataTable();
        int _changes = 0;
        int _newrecord = 0;

        public frmNhanVien()
        {

            InitializeComponent();
            string con_str = Program.ConnectionString;
            conn = new SqlConnection(con_str);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.bindData();
            this.disableInput();

        }

        public void bindData() {

            adapter = new SqlDataAdapter("SELECT * FROM nhanvien", conn);
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(adapter);
            tblTable.Clear();
            adapter.Fill(tblTable);
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.Columns["MaNV"].DataPropertyName = "MaNV";
            dgvNhanVien.Columns["MatKhau"].DataPropertyName = "MatKhau";
            dgvNhanVien.Columns["TenNV"].DataPropertyName = "TenNV";
            dgvNhanVien.Columns["NgaySinh"].DataPropertyName = "NgaySinh";
            dgvNhanVien.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dgvNhanVien.Columns["DienThoai"].DataPropertyName = "DienThoai";
            dgvNhanVien.Columns["laAdmin"].DataPropertyName = "laAdmin";
            dgvNhanVien.DataSource = tblTable;
            //adapter.AcceptChangesDuringUpdate = true;
        
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtMaNV_old.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            txtNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            dtmNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString());
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            chkAdmin.Checked =  Convert.ToBoolean(dgvNhanVien.Rows[e.RowIndex].Cells["laAdmin"].Value);
            this.enableInput();
            _newrecord = 0;
        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.clearInput();
            _newrecord = 1;
            this.enableInput();
            txtMaNV.Focus();
        }


        private void btnLuulai_Click(object sender, EventArgs e)
        {

            //Check key
            if (this.validateInput() == false)
                return;

            SqlCommand objCommand;
            string strField = "";
            string strValues = "";

            int isDuplicate;
            if (txtMaNV_old.Text != txtMaNV.Text)
                isDuplicate = objCommonUI.isDuplicate(txtMaNV.Text, "MaNV", "NhanVien");
            else
                isDuplicate = 0;

            if ((_newrecord == 0))
            { //Update
                if (isDuplicate != 1)
                { //Chua ton tai ma ban 
                    objCommand = new SqlCommand("UPDATE NhanVien SET " +
                                                                        "MaNV = '" + txtMaNV.Text + 
                                                                        "',TenNV = '" + txtTenNV.Text +
                                                                        "',MatKhau = '" + txtMatKhau.Text +
                                                                        "',NgaySinh = '" + dtmNgaySinh.Value.Date.ToString() +
                                                                        "',DiaChi = '" + txtDiaChi.Text +
                                                                        "',DienThoai = '" + txtDienThoai.Text +
                                                                        "',laAdmin = '" + chkAdmin.Checked +
                                                                        "' WHERE MaNV = '" + txtMaNV_old.Text + "'");
                    objCommand.Connection = conn;
                    try
                    {
                        conn.Open();
                        objCommand.ExecuteNonQuery();
                        this.bindData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Có lỗi khi cập nhật dữ liệu" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        _newrecord = 0;
                        this.clearInput();
                        this.disableInput();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, không thể cập nhật được");
                }

            }
            else
            { //Truong hop Add new
                if (isDuplicate != 1)//Chua ton tai khoa
                {
                    strField += "MaNV,";
                    strValues += "'" + txtMaNV.Text + "'";
                    strField += "TenNV,";
                    strValues += ",'" + txtTenNV.Text + "'";
                        strField += "NgaySinh,";
                        strValues += ",'" + dtmNgaySinh.Value.Date.ToString() + "'";

                    strField += "DiaChi,";
                    strValues += ",'" + txtDiaChi.Text + "'";
                    strField += "DienThoai,";
                    strValues += ",'" + txtDienThoai.Text + "'";
                    strField += "laAdmin,";
                    strValues += ",'" + chkAdmin.Checked + "'";
                    strField += "MatKhau";
                    strValues += ",'" + txtMatKhau.Text + "'";


                        
                    objCommand = new SqlCommand("INSERT INTO NhanVien("+ strField +") VALUES("+ strValues+")");

                                                                                
                    objCommand.Connection = conn;
                    try
                    {
                        conn.Open();
                        objCommand.ExecuteNonQuery();
                        this.bindData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Có lỗi khi cập nhật dữ liệu " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        _newrecord = 0;
                        this.clearInput();
                        this.disableInput();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, không thể cập nhật được");
                }
            }

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") {
                MessageBox.Show("Chọn dữ liệu cần xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Delete data...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            SqlCommand objCommand;
            objCommand = new SqlCommand("DELETE FROM NhanVien WHERE MaNV = '" + txtMaNV.Text + "'");
            objCommand.Connection = conn;
            try
            {
                conn.Open();
                objCommand.ExecuteNonQuery();
                this.bindData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không xóa được dữ liệu " + ex.Message);
            }
            finally
            {
                conn.Close();
                this.clearInput();
                this.disableInput();
            }



        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }


        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (_changes ==1) 
                    if (MessageBox.Show("Dữ liệu đã có sự thay đổi.\nBạn có muốn lưu lại không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        btnLuulai_Click(sender, e);

        }


        private void disableInput()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtMatKhau.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            chkAdmin.Enabled = false;
        }

        private void enableInput()
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtMatKhau.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            chkAdmin.Enabled = true;
        }

        private bool validateInput()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
                txtMaNV.Focus();
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                txtMatKhau.Focus();
                return false;
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Họ tên không được để trống");
                txtTenNV.Focus();
                return false;
            }
            return true;
        }

        private void clearInput()
        {
            txtMaNV.Text = "";
            txtMaNV_old.Text = "";
            txtTenNV.Text = "";
            txtMatKhau.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            chkAdmin.Checked = false;
        }







    }
}