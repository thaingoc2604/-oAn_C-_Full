using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MDS.BussinessRule;

namespace AnTCafe
{
    public partial class frmNhapHang : Form
    {

        clsCommonUI objCommonUI = new clsCommonUI();
        DataTable tblTable = new DataTable();
        string strSoPhieuNhap = "";
        clsBPhieuNhap objPhieuNhap = new clsBPhieuNhap();
        clsBPhieuNhapCtiet objPhieuNhapCTiet = new clsBPhieuNhapCtiet();
        clsBHang objHang = new clsBHang();
        clsBNhanVien objNhanVien = new clsBNhanVien();

        DataTable tblHang = new DataTable();
        DataTable tblNhanVien = new DataTable();
        DataTable tblPhieuNhapCtiet = new DataTable();
        DataTable tblPhieuNhap = new DataTable();
        DataTable tblPhieuNhapCTiet = new DataTable();
        DataTable tblTmp = new DataTable();

        public string SoPhieuNhap
        {
            get { return strSoPhieuNhap; }
            set { strSoPhieuNhap = value; }
        }


        public frmNhapHang()
        {
            InitializeComponent();
            
            //init bussiness object
            string con_str = ConfigurationManager.ConnectionStrings["AnTCafe.Properties.Settings.AnTCafeConnectionString"].ConnectionString;
            objPhieuNhap.ConnectionString = con_str;
            objPhieuNhap.Initialize();
            objPhieuNhapCTiet.ConnectionString = con_str;
            objPhieuNhapCTiet.Initialize();
            objHang.ConnectionString = con_str;
            objHang.Initialize();
            objNhanVien.ConnectionString = con_str;
            objNhanVien.Initialize();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            this.bindPhieuNhap();
            this.bindHang();
            //this.disableInput();

        }
        private void bindPhieuNhap() {

            //Truong hop addnew
            if (SoPhieuNhap == "")
            {
                txtSoPhieuNhap.Text = objPhieuNhap.GET_NEXT_ID();
                this.bindNhanVien("");
            }
            else {//Truong hop edit
                tblPhieuNhap.Clear();
                objPhieuNhap.SoPhieuNhap = SoPhieuNhap;
                tblPhieuNhap = objPhieuNhap.SELECT_BY_ID();

                txtSoPhieuNhap.Text = tblPhieuNhap.Rows[0]["SoPhieuNhap"].ToString();
                cboNgayNhap.Value = (DateTime)tblPhieuNhap.Rows[0]["NgayNhap"];
                txtGhiChu.Text = tblPhieuNhap.Rows[0]["GhiChu"].ToString();
                this.bindNhanVien(tblPhieuNhap.Rows[0]["MaNV"].ToString());
            }
            this.bindPhieuNhapCtiet();

        }
        private void bindNhanVien(string defaultSelectedValue) {
            tblNhanVien.Clear();
            tblNhanVien = objNhanVien.SELECT_ALL("MaNV", true);
            cboMaNV.DataSource = tblNhanVien;
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.DisplayMember = "TenNV";
            int i = 0;
            if (defaultSelectedValue != "")
                foreach (DataRow dr in tblNhanVien.Rows)
                {
                    if (defaultSelectedValue == dr["MaNV"].ToString())
                        cboMaNV.SelectedIndex = i;
                    i += 1;
                }
        }

        private void bindHang() {
            tblHang.Clear();
            tblHang = objHang.SELECT_ALL();
            DataRow blank_row = tblHang.NewRow();
            blank_row["MaHang"] = "";
            blank_row["TenHang"] = "";
            tblHang.Rows.InsertAt(blank_row, 0);
            cboTenHang.DataSource = tblHang;
            cboTenHang.ValueMember = "MaHang";
            cboTenHang.DisplayMember = "TenHang";
        }


        private void bindPhieuNhapCtiet()
        {
            
            objPhieuNhapCTiet.SoPhieuNhap = txtSoPhieuNhap.Text;
            tblPhieuNhapCtiet.Clear();
            tblPhieuNhapCtiet = objPhieuNhapCTiet.SELECT_BY_SOPHIEUNHAP();
            dgvPhieuNhapCtiet.AutoGenerateColumns = false;

            dgvPhieuNhapCtiet.Columns["MaHang"].DataPropertyName = "MaHang";
            dgvPhieuNhapCtiet.Columns["TenHang"].DataPropertyName = "TenHang";
            dgvPhieuNhapCtiet.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvPhieuNhapCtiet.Columns["GiaNhap"].DataPropertyName = "GiaNhap";
            dgvPhieuNhapCtiet.Columns["SoPhieuNhap"].DataPropertyName = "SoPhieuNhap";

            dgvPhieuNhapCtiet.DataSource = tblPhieuNhapCtiet;
        }


        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHang.Text = cboTenHang.SelectedValue.ToString();
            objPhieuNhapCTiet.SoPhieuNhap = txtSoPhieuNhap.Text;
            objPhieuNhapCTiet.MaHang = txtMaHang.Text;
            tblTmp.Clear();
            tblTmp = objPhieuNhapCTiet.SELECT_BY_2ID();
            if (tblTmp.Rows.Count > 0)
            {
                txtSoLuong.Text = tblTmp.Rows[0]["SoLuong"].ToString();
                txtGiaNhap.Text = tblTmp.Rows[0]["GiaNhap"].ToString();
            }
            else {
                txtSoLuong.Text = "0";
                txtGiaNhap.Text = "0";
            
            }


        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (txtMaHang.Text!= "")
                foreach (DataRow dr in tblHang.Rows) {
                    if (txtMaHang.Text == dr["MaHang"].ToString())
                        cboTenHang.SelectedIndex = i;
                    i += 1;
                }
                //cboTenHang.SelectedIndex = txtMaHang.Text;
        }
//
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.clearInput();
            //_newrecord = 1;
            this.enableInput();
            txtMaHang.Focus();

        }


        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            //Check input
            if (!this.validateInput())
                return;
            // Kiem tra phieu nhap neu chua co thi insert vao bang phieu nhap truoc
            tblPhieuNhap.Clear();
            objPhieuNhap.SoPhieuNhap = txtSoPhieuNhap.Text;
            tblPhieuNhap = objPhieuNhap.SELECT_BY_ID();
            if ((tblPhieuNhap == null) || (tblPhieuNhap.Rows.Count == 0))
            {
                objPhieuNhap.NgayNhap = cboNgayNhap.Value;
                objPhieuNhap.MaNV = cboMaNV.SelectedValue.ToString();
                objPhieuNhap.GhiChu = txtGhiChu.Text;
                objPhieuNhap.INSERT_PHIEUNHAP();
                if (objPhieuNhap.ErrorMsg != "")
                    MessageBox.Show(objPhieuNhap.ErrorMsg);
                //Insert vao phieu nhap chi tiet
                objPhieuNhapCTiet.SoPhieuNhap = txtSoPhieuNhap.Text;
                objPhieuNhapCTiet.MaHang = txtMaHang.Text;
                objPhieuNhapCTiet.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                objPhieuNhapCTiet.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
                objPhieuNhapCTiet.INSERT_PHIEUNHAPCTIET();
                if (objPhieuNhapCTiet.ErrorMsg != "")
                    MessageBox.Show(objPhieuNhapCTiet.ErrorMsg);


            }
            else {
                //Neu co roi thi update phieu nhap
                objPhieuNhap.NgayNhap = cboNgayNhap.Value;
                objPhieuNhap.MaNV = cboMaNV.SelectedValue.ToString();
                objPhieuNhap.GhiChu = txtGhiChu.Text;
                objPhieuNhap.UPDATE_PHIEUNHAP();
                if (objPhieuNhap.ErrorMsg != "")
                    MessageBox.Show(objPhieuNhap.ErrorMsg);

                //Kiem tra PNCN neu chua co thi Insert vao phieu nhap chi tiet
                objPhieuNhapCTiet.SoPhieuNhap = txtSoPhieuNhap.Text;
                objPhieuNhapCTiet.MaHang = txtMaHang.Text;
                
                tblPhieuNhapCTiet.Clear();
                tblPhieuNhapCTiet = objPhieuNhapCTiet.SELECT_BY_2ID();

                if ((tblPhieuNhapCTiet == null) || (tblPhieuNhapCTiet.Rows.Count == 0)) //Chua co 
                {
                    objPhieuNhapCTiet.SoPhieuNhap = txtSoPhieuNhap.Text;
                    objPhieuNhapCTiet.MaHang = txtMaHang.Text;
                    objPhieuNhapCTiet.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    objPhieuNhapCTiet.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
                    objPhieuNhapCTiet.INSERT_PHIEUNHAPCTIET();
                    if (objPhieuNhapCTiet.ErrorMsg != "")
                        MessageBox.Show(objPhieuNhapCTiet.ErrorMsg);

                }
                else 
                {
                    //Hoac Update phieu nhap chi tiet
                    objPhieuNhapCTiet.SoPhieuNhap = txtSoPhieuNhap.Text;
                    objPhieuNhapCTiet.MaHang = txtMaHang.Text;
                    objPhieuNhapCTiet.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    objPhieuNhapCTiet.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
                    objPhieuNhapCTiet.UPDATE_PHIEUNHAPCTIET();
                    if (objPhieuNhapCTiet.ErrorMsg != "")
                        MessageBox.Show(objPhieuNhapCTiet.ErrorMsg);

                }
            }

            //this.clearInput();
            //this.disableInput();
            this.bindPhieuNhapCtiet();
                
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
            objPhieuNhapCTiet.MaHang = txtMaHang.Text;
            objPhieuNhapCTiet.SoPhieuNhap = txtSoPhieuNhap.Text;
            objPhieuNhapCTiet.DELETE_PHIEUNHAPCTIET();
            if (objPhieuNhapCTiet.ErrorMsg != "")
                MessageBox.Show(objPhieuNhapCTiet.ErrorMsg);
            else
                this.bindPhieuNhapCtiet();


        }

        private void dgvPhieuNhapCtiet_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvPhieuNhapCtiet.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
            txtSoLuong.Text = dgvPhieuNhapCtiet.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtGiaNhap.Text = dgvPhieuNhapCtiet.Rows[e.RowIndex].Cells["GiaNhap"].Value.ToString();
            this.enableInput();
            //_newrecord = 0;

        }


        private void disableInput()
        {
            txtMaHang.Enabled = false;
            cboTenHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaNhap.Enabled = false;
        }

        private void enableInput()
        {
            txtMaHang.Enabled = true;
            cboTenHang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaNhap.Enabled = true;

        }

        private bool validateInput()
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Mã không được để trống");
                txtMaHang.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }


            return true;
        }

        private void clearInput()
        {
            txtMaHang.Text = "";
            cboTenHang.Text = "";
            txtSoLuong.Text = "1";
            txtGiaNhap.Text = "0";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cboNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            if (cboNgayNhap.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện tại");
                cboNgayNhap.Value = DateTime.Now;
            }   
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (!objCommonUI.isNumberic(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng phải là số");
                txtSoLuong.Text = "1";
                txtSoLuong.Focus();
            }
        }

        private void txtGiaNhap_Leave(object sender, EventArgs e)
        {
            if (!objCommonUI.isNumberic(txtGiaNhap.Text))
            {
                MessageBox.Show("Giá nhập phải là số");
                txtGiaNhap.Text = "0";
                txtGiaNhap.Focus();
            }

        }


        private void frmNhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
///

        }







    }
}