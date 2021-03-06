using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class frmXoaKetQuaHocTap : Form
    {
        string MaSV;
        string TenSV;
        public frmXoaKetQuaHocTap(string masv,string tensv)
        {
            MaSV = masv;
            TenSV = tensv;
            InitializeComponent();
        }

        private void frmXoaKetQuaHocTap_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM MonHoc  order by MonHoc_ID ";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            for (int i = 0; i < td.Rows.Count; i++)
            {
                this.cbxMonHoc.Items.Add(td.Rows[i][1]);
            }
            this.txtMaSV.Text = MaSV;
            this.txtTenSV.Text = TenSV;
            con.Close();
        }

        private void cbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string TenMonHoc;
            TenMonHoc = cbxMonHoc.SelectedItem.ToString();
            cmd.CommandText = "select* from MonHoc where TenMonHoc='" + TenMonHoc + "'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            string MaMonHoc = td.Rows[0][0].ToString();
            cmd.CommandText = "SELECT LanThi,DiemThi,DiemTongKet FROM KetQua WHERE ID_MonHoc='" + MaMonHoc + "' AND ID_SinhVien='" + MaSV + "'";
            SqlDataReader rd1;
            rd1 = cmd.ExecuteReader();
            DataTable td1 = new DataTable();
            td1.Load(rd1);
            this.txtLanThi.Text = td1.Rows[0][0].ToString();
            this.txtDiemThi.Text = td1.Rows[0][1].ToString();
            this.txtTongKet.Text = td1.Rows[0][2].ToString();
            con.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string TenMonHoc = cbxMonHoc.SelectedItem.ToString();
            cmd.CommandText = "select * from MonHoc where TenMonHoc='" + TenMonHoc + "'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            string MaMonHoc = td.Rows[0][0].ToString();
            cmd.CommandText="DELETE KetQua WHERE ID_MonHoc='" + MaMonHoc + "' AND ID_SinhVien='" + MaSV + "'";
            DialogResult result;
            result = MessageBox.Show("BẠN CÓ MUỐN XÓA THÔNG TIN KẾT QUẢ HỌC TẬP KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO");
            }
            con.Close();
            Close();
            frmXoaKetQuaHocTap frm = new frmXoaKetQuaHocTap(MaSV,TenSV);
            frm.Show();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
