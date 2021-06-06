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
    public partial class frmBan : Form
    {
        SqlConnection conn = new SqlConnection(Program.ConnectionString);
        clsCommonUI objCommonUI = new clsCommonUI();
        SqlDataAdapter adapter;
        DataTable tblTable = new DataTable();
        //int _changes = 0;
        int _newrecord = 0;
        //string strErrorMgs = "";


        public frmBan()
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

            adapter = new SqlDataAdapter("SELECT * FROM ban", conn);
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(adapter);
            tblTable.Clear();
            adapter.Fill(tblTable);
            dgvBan.AutoGenerateColumns = false;
            dgvBan.Columns["MaBan"].DataPropertyName = "MaBan";
            dgvBan.Columns["Ten"].DataPropertyName = "Ten";
            dgvBan.Columns["KhuVuc"].DataPropertyName = "KhuVuc";
            dgvBan.DataSource = tblTable;
            //adapter.AcceptChangesDuringUpdate = true;
        }

        private void dgvBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBan.Text = dgvBan.Rows[e.RowIndex].Cells["MaBan"].Value.ToString();
            txtMaBan_old.Text = dgvBan.Rows[e.RowIndex].Cells["MaBan"].Value.ToString();
            txtTenBan.Text = dgvBan.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            txtKhuvuc.Text = dgvBan.Rows[e.RowIndex].Cells["KhuVuc"].Value.ToString();
            this.enableInput();
            _newrecord = 0;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            //Check key
            if (this.validateInput() == false)
                return;

            SqlCommand objCommand;
            int isDuplicate;
            if (txtMaBan_old.Text != txtMaBan.Text )
                isDuplicate = objCommonUI.isDuplicate(txtMaBan.Text, "MaBan", "Ban");
            else
                isDuplicate = 0;

            if ((_newrecord == 0))
            { //Update
                if (isDuplicate != 1)
                { //Chua ton tai ma ban 
                    objCommand = new SqlCommand("UPDATE ban SET MaBan = '" + txtMaBan.Text + "',Ten = '" + txtTenBan.Text + "',KhuVuc = '" + txtKhuvuc.Text + "' WHERE MaBan = '" + txtMaBan_old.Text + "'");
                    objCommand.Connection = conn;
                    try
                    {
                        conn.Open();
                        objCommand.ExecuteNonQuery();
                        //txtCurrentIndex.Text = dgvBan.CurrentRow.Index.ToString();
                        this.bindData();
                        //dgvBan.Rows[Convert.ToInt32(txtCurrentIndex.Text)].Selected = true;


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
                    MessageBox.Show("Số bàn đã tồn tại, không thể cập nhật được");
                }

            }
            else { //Truong hop Add new
                if (isDuplicate != 1)//Chua ton tai ma ban
                {
                    objCommand = new SqlCommand("INSERT INTO ban VALUES('" + txtMaBan.Text + "','" + txtTenBan.Text + "','" + txtKhuvuc.Text + "')");
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
                    MessageBox.Show("Số bàn đã tồn tại, không thể cập nhật được");
                }
            }



        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            this.clearInput();
            _newrecord = 1;
            this.enableInput();
            txtMaBan.Focus();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu cần xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Delete data...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            SqlCommand objCommand;
            objCommand = new SqlCommand("DELETE FROM ban WHERE maban = '" + txtMaBan.Text + "'");
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
            txtMaBan.Enabled = false;
            txtTenBan.Enabled = false;
            txtKhuvuc.Enabled = false;
        }

        private void enableInput()
        {
            txtMaBan.Enabled = true;
            txtTenBan.Enabled = true;
            txtKhuvuc.Enabled = true;
        }
        private bool validateInput() {
            if (txtMaBan.Text == "") {
                MessageBox.Show("Số bàn không được để trống");
                txtMaBan.Focus();
                return false;
            }
            return true;
        }
        private void clearInput() {
            txtMaBan.Text = "";
            txtMaBan_old.Text = "";
            txtTenBan.Text = "";
            txtKhuvuc.Text = "";
        }




    }
}