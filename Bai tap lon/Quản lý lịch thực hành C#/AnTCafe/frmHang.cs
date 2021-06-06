using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;


namespace AnTCafe
{
    public partial class frmHang : Form
    {
        SqlConnection conn;
        clsCommonUI objCommonUI = new clsCommonUI();
        SqlDataAdapter adapter;
        DataTable tblTable = new DataTable();
        //int _changes = 0;
        int _newrecord = 0;
        //string strErrorMgs = "";


        public frmHang()
        {
            InitializeComponent();
            string con_str = Program.ConnectionString; 
            conn = new SqlConnection(con_str);

        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            this.bindData();
            this.disableInput();

        }

        public void bindData()
        {

            adapter = new SqlDataAdapter("SELECT * FROM Hang", conn);
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(adapter);
            tblTable.Clear();
            adapter.Fill(tblTable);
            dgvHang.AutoGenerateColumns = false;
            dgvHang.Columns["MaHang"].DataPropertyName = "MaHang";
            dgvHang.Columns["TenHang"].DataPropertyName = "TenHang";
            dgvHang.Columns["GhiChu"].DataPropertyName = "GhiChu";
            dgvHang.Columns["PhimTat"].DataPropertyName = "PhimTat";
            dgvHang.DataSource = tblTable;
            //adapter.AcceptChangesDuringUpdate = true;
        }

        private void dgvBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvHang.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
            txtMaHang_old.Text = dgvHang.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dgvHang.Rows[e.RowIndex].Cells["TenHang"].Value.ToString();
            txtGhiChu.Text = dgvHang.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            txtPhimtat.Text = dgvHang.Rows[e.RowIndex].Cells["PhimTat"].Value.ToString();
            this.enableInput();
            _newrecord = 0;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            //Check input
            if (this.validateInput() == false) 
                return;
            SqlCommand objCommand;
            int isDuplicate;
            if (txtMaHang_old.Text != txtMaHang.Text )
                isDuplicate = objCommonUI.isDuplicate(txtMaHang.Text, "MaHang", "Hang");
            else
                isDuplicate = 0;

            if ((_newrecord == 0))
            { //Update
                if (isDuplicate != 1)
                { //Chua ton tai ma ban 
                    objCommand = new SqlCommand("UPDATE Hang SET MaHang = '" + txtMaHang.Text + "',TenHang = '" + txtTenHang.Text + "',GhiChu = '" + txtGhiChu.Text + "',PhimTat = '" + txtPhimtat.Text + "' WHERE MaHang = '" + txtMaHang_old.Text + "'");
                    objCommand.Connection = conn;
                    try
                    {
                        conn.Open();
                        objCommand.ExecuteNonQuery();
                        txtCurrentIndex.Text = dgvHang.CurrentRow.Index.ToString();
                        this.bindData();
                        dgvHang.Rows[Convert.ToInt32(txtCurrentIndex.Text)].Selected = true;


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
                    MessageBox.Show("Mã này đã tồn tại, không thể cập nhật được");
                }

            }
            else { //Truong hop Add new
                if (isDuplicate != 1)//Chua ton tai ma ban
                {
                    objCommand = new SqlCommand("INSERT INTO Hang VALUES('" + txtMaHang.Text + "','" + txtTenHang.Text + "','" + txtGhiChu.Text + "','" + txtPhimtat.Text + "')");
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
                else {
                    MessageBox.Show("Mã này đã tồn tại, không thể cập nhật được");
                }
            }



        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            this.clearInput();
            _newrecord = 1;
            this.enableInput();
            txtMaHang.Focus();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu cần xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Delete data...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            SqlCommand objCommand;
            objCommand = new SqlCommand("DELETE FROM Hang WHERE MaHang = '" + txtMaHang.Text + "'");
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

        private void disableInput() {
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtGhiChu.Enabled = false;
            txtPhimtat.Enabled = false;
        }

        private void enableInput()
        {
            txtMaHang.Enabled = true;
            txtTenHang.Enabled = true;
            txtGhiChu.Enabled = true;
            txtPhimtat.Enabled = true;
        }
        private bool validateInput() {
            if (txtMaHang.Text == "") {
                MessageBox.Show("Mã không được để trống");
                txtMaHang.Focus();
                return false;
            }
            return true;
        }
        private void clearInput() {
            txtMaHang.Text = "";
            txtMaHang_old.Text = "";
            txtTenHang.Text = "";
            txtGhiChu.Text = "";
            txtPhimtat.Text = "";
        }


    }
}