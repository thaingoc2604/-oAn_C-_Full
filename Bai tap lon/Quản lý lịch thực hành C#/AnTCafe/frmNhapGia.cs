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
    public partial class frmNhapGia : Form
    {
        SqlConnection conn = new SqlConnection(Program.ConnectionString);
        clsCommonUI objCommonUI = new clsCommonUI();
        SqlDataAdapter adapter;
        SqlDataAdapter adapter_Gia;
        DataTable tblTable = new DataTable();
        DataTable tblTable_Gia = new DataTable();
        int _changes = 0;
        //int _newrecord = 0;
        //string strErrorMgs = "";


        public frmNhapGia()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            this.bindData();

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

        private void bindGiaNhap(string strMaHang)
        {
            DataTable tblLoaiKH = new DataTable();
            SqlCommand objCommand = new SqlCommand();
            objCommand.Connection = conn;
            SqlDataAdapter adapter_LoaiKhachHang;


            //Check 
            adapter_LoaiKhachHang = new SqlDataAdapter("SELECT * FROM LoaiKhachHang", conn);
            adapter_LoaiKhachHang.Fill(tblLoaiKH);
            if(conn.State==ConnectionState.Closed)
            conn.Open();
            foreach (DataRow dr in tblLoaiKH.Rows) {
                objCommand.CommandText = "SELECT * FROM GiaBan WHERE MaHang ='" + strMaHang + "' AND LoaiKH = '"+ dr["LoaiKH"]+"'";
                
                string strTemp = (string)objCommand.ExecuteScalar();
                
                //Insert neu chua co
                if ((strTemp == null) || (strTemp == "")) {
                    objCommand.CommandText = "INSERT INTO GiaBan(MaHang,LoaiKH) VALUES ('" + strMaHang + "','"+ dr["LoaiKH"] +"')";
                    objCommand.ExecuteNonQuery();
                }
            }
            conn.Close();

            

            //bind data
            adapter_Gia = new SqlDataAdapter("SELECT * FROM LoaiKhachHang L, GiaBan G WHERE L.LoaiKH = G.LoaiKH AND MaHang = '"+ strMaHang +"'", conn);
            SqlCommandBuilder builder;
            builder = new SqlCommandBuilder(adapter);
            tblTable_Gia.Clear();
            adapter_Gia.Fill(tblTable_Gia);
            dgvGiaBan.AutoGenerateColumns = false;
            dgvGiaBan.Columns["MaHang_"].DataPropertyName = "MaHang";
            dgvGiaBan.Columns["LoaiKH"].DataPropertyName = "G.LoaiKH";
            dgvGiaBan.Columns["Ten"].DataPropertyName = "Ten";
            dgvGiaBan.Columns["GiaBan"].DataPropertyName = "GiaBan";
            dgvGiaBan.DataSource = tblTable_Gia;
        
        }

        private void dgvBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_changes == 1)
                btnLuuLai_Click(sender,e);

            string strMaHang = dgvHang.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
            this.bindGiaNhap(strMaHang);


        }


        private bool validateInput() {
            return true;
        }

        private void dgvGiaBan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string strValue;
            strValue = dgvGiaBan.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString();
            int intValue;
            if (!int.TryParse(strValue,out intValue)) {
                MessageBox.Show("Dữ liệu phải là số");
                dgvGiaBan.Rows[e.RowIndex].Cells["GiaBan"].Value = intValue;
            }
            _changes = 1;

        }

        private void dgvGiaBan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Dữ liệu không hợp lệ!");

        }





        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            //Check input
            SqlCommand objCommand = new SqlCommand();
            objCommand.Connection = conn;
            string strUpdate;

            DataGridViewRowCollection rows = dgvGiaBan.Rows;
            conn.Open();
            foreach (DataGridViewRow dgr in rows)
            {
                strUpdate = "UPDATE GiaBan SET GiaBan = " + dgr.Cells["GiaBan"].Value.ToString();
                strUpdate += " WHERE MaHang = '" + dgr.Cells["MaHang_"].Value.ToString() + "'";
                strUpdate += " AND LoaiKH = '" + dgr.Cells["LoaiKH"].Value.ToString() + "'";

                objCommand.CommandText = strUpdate;
                objCommand.ExecuteNonQuery();
            }
            conn.Close();
            _changes = 0;

        }

        private void frmNhapGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_changes == 1)
                btnLuuLai_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}