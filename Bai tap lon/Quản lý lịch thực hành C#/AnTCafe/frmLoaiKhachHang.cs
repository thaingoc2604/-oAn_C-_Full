using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace AnTCafe
{
    public partial class frmLoaiKhachHang : Form
    {
        SqlConnection conn = new SqlConnection(Program.ConnectionString);
        clsCommonUI objCommonUI = new clsCommonUI();
        SqlDataAdapter adapter;
        DataTable tblTable = new DataTable();
        //int _changes = 0;
        int _newrecord = 0;
        //string strErrorMgs = "";


        public frmLoaiKhachHang()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            this.bindData();
            this.disableInput();

        }

        public void bindData()
        {

            adapter = new SqlDataAdapter("SELECT * FROM LoaiKhachHang", conn);
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(adapter);
            tblTable.Clear();
            adapter.Fill(tblTable);
            dgvLoaiKH.AutoGenerateColumns = false;
            dgvLoaiKH.Columns["Ma"].DataPropertyName = "LoaiKH";
            dgvLoaiKH.Columns["Ten"].DataPropertyName = "Ten";
            dgvLoaiKH.Columns["GhiChu"].DataPropertyName = "GhiChu";
            dgvLoaiKH.DataSource = tblTable;
            //adapter.AcceptChangesDuringUpdate = true;
        }

        private void dgvBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiKH.Text = dgvLoaiKH.Rows[e.RowIndex].Cells["Ma"].Value.ToString();
            txtMaLoaiKH_old.Text = dgvLoaiKH.Rows[e.RowIndex].Cells["Ma"].Value.ToString();
            txtTen.Text = dgvLoaiKH.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            txtGhiChu.Text = dgvLoaiKH.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
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
            if (txtMaLoaiKH_old.Text != txtMaLoaiKH.Text )
                isDuplicate = objCommonUI.isDuplicate(txtMaLoaiKH.Text, "LoaiKH", "LoaiKhachHang");
            else
                isDuplicate = 0;

            if ((_newrecord == 0))
            { //Update
                if (isDuplicate != 1)
                { //Chua ton tai ma ban 
                    objCommand = new SqlCommand("UPDATE LoaiKhachHang SET LoaiKH = '" + txtMaLoaiKH.Text + "',Ten = '" + txtTen.Text + "',GhiChu = '" + txtGhiChu.Text + "' WHERE LoaiKH = '" + txtMaLoaiKH_old.Text + "'");
                    objCommand.Connection = conn;
                    try
                    {
                        conn.Open();
                        objCommand.ExecuteNonQuery();
                        txtCurrentIndex.Text = dgvLoaiKH.CurrentRow.Index.ToString();
                        this.bindData();
                        dgvLoaiKH.Rows[Convert.ToInt32(txtCurrentIndex.Text)].Selected = true;


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
                    objCommand = new SqlCommand("INSERT INTO LoaiKhachHang VALUES('" + txtMaLoaiKH.Text + "','" + txtTen.Text + "','" + txtGhiChu.Text + "')");
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
            txtMaLoaiKH.Focus();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiKH.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu cần xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Delete data...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            SqlCommand objCommand;
            objCommand = new SqlCommand("DELETE FROM LoaiKhachHang WHERE LoaiKH = '" + txtMaLoaiKH.Text + "'");
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
            txtMaLoaiKH.Enabled = false;
            txtTen.Enabled = false;
            txtGhiChu.Enabled = false;
        }

        private void enableInput()
        {
            txtMaLoaiKH.Enabled = true;
            txtTen.Enabled = true;
            txtGhiChu.Enabled = true;
        }
        private bool validateInput() {
            if (txtMaLoaiKH.Text == "") {
                MessageBox.Show("Mã không được để trống");
                txtMaLoaiKH.Focus();
                return false;
            }
            return true;
        }
        private void clearInput() {
            txtMaLoaiKH.Text = "";
            txtMaLoaiKH_old.Text = "";
            txtTen.Text = "";
            txtGhiChu.Text = "";
        }


    }
}