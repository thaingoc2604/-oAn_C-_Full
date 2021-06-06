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
    public partial class frmXuatHang : Form
    {

        clsCommonUI objCommonUI = new clsCommonUI();
        DataTable tblTable = new DataTable();
        string strSoPhieuXuat = "";
        private string strLoaiKH;
        private string strMaBan;
        int intThanhToan = 0;
        clsBPhieuXuat objPhieuXuat = new clsBPhieuXuat();
        clsBPhieuXuatCtiet objPhieuXuatCTiet = new clsBPhieuXuatCtiet();
        clsBHang objHang = new clsBHang();
        clsBNhanVien objNhanVien = new clsBNhanVien();
        clsBGiaBan objGiaBan = new clsBGiaBan();
        clsCommonUI objCommon = new clsCommonUI();

        DataTable tblHang = new DataTable();
        DataTable tblNhanVien = new DataTable();
        DataTable tblPhieuXuatCtiet = new DataTable();
        DataTable tblPhieuXuat = new DataTable();
        DataTable tblPhieuXuatCTiet = new DataTable();
        DataTable tblTmp = new DataTable();
        DataTable tblGiaBan = new DataTable();


        public delegate void PassData();
        public PassData passData;


        public string SoPhieuXuat
        {
            get { return strSoPhieuXuat; }
            set { strSoPhieuXuat = value; }
        }
        public string LoaiKH
        {
            get { return strLoaiKH; }
            set { strLoaiKH = value; }
        }
        public string MaBan
        {
            get { return strMaBan; }
            set { strMaBan = value; }
        }

        public frmXuatHang()
        {
            InitializeComponent();
            
            //init bussiness object
            string con_str = ConfigurationManager.ConnectionStrings["AnTCafe.Properties.Settings.AnTCafeConnectionString"].ConnectionString;
            objPhieuXuat.ConnectionString = con_str;
            objPhieuXuat.Initialize();
            objPhieuXuatCTiet.ConnectionString = con_str;
            objPhieuXuatCTiet.Initialize();
            objHang.ConnectionString = con_str;
            objHang.Initialize();
            objNhanVien.ConnectionString = con_str;
            objNhanVien.Initialize();
            objGiaBan.ConnectionString = con_str;
            objGiaBan.Initialize();

        }



        private void frmXuatHang_Activated(object sender, EventArgs e)
        {
            if (SoPhieuXuat == "")
                txtMaHang.Focus();
            else
                txtTienTra.Focus();
            
        }

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            this.bindPhieuXuat();
        }

        private void bindPhieuXuat() {

            //Truong hop addnew
            if (SoPhieuXuat == "")
            {
                txtSoPhieuXuat.Text = objPhieuXuat.GET_NEXT_ID();
                this.bindNhanVien(frmMain.staticMaNV);
                lblLoaiKH.Text = LoaiKH;
                lblSoBan.Text = MaBan;
                
            }
            else {//Truong hop edit
                tblPhieuXuat.Clear();
                objPhieuXuat.SoPhieuXuat = SoPhieuXuat;
                tblPhieuXuat = objPhieuXuat.SELECT_BY_ID();
                txtSoPhieuXuat.Text = tblPhieuXuat.Rows[0]["SoPhieuXuat"].ToString();
                cboNgayXuat.Value = (DateTime)tblPhieuXuat.Rows[0]["NgayXuat"];
                txtGhiChu.Text = tblPhieuXuat.Rows[0]["GhiChu"].ToString();
                this.bindNhanVien(tblPhieuXuat.Rows[0]["MaNV"].ToString());
                lblSoBan.Text = tblPhieuXuat.Rows[0]["TenBan"].ToString();
                this.MaBan = tblPhieuXuat.Rows[0]["MaBan"].ToString();
                lblLoaiKH.Text = tblPhieuXuat.Rows[0]["TenLoaiKH"].ToString();
                this.LoaiKH = tblPhieuXuat.Rows[0]["LoaiKH"].ToString();
                
            }
            this.bindPhieuXuatCtiet();

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
        private void bindPhieuXuatCtiet()
        {
            objPhieuXuatCTiet.SoPhieuXuat = txtSoPhieuXuat.Text;
            txtTongTien.Text = objPhieuXuatCTiet.TINH_TONG_TIEN().ToString();
            tblPhieuXuatCtiet.Clear();
            tblPhieuXuatCtiet = objPhieuXuatCTiet.SELECT_BY_SOPHIEUXUAT();
            dgvPhieuXuatCtiet.AutoGenerateColumns = false;
            dgvPhieuXuatCtiet.Columns["MaHang"].DataPropertyName = "MaHang";
            dgvPhieuXuatCtiet.Columns["TenHang"].DataPropertyName = "TenHang";
            dgvPhieuXuatCtiet.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvPhieuXuatCtiet.Columns["GiaXuat"].DataPropertyName = "DonGia";
            dgvPhieuXuatCtiet.Columns["ThanhTien"].DataPropertyName = "ThanhTien";
            dgvPhieuXuatCtiet.Columns["SoPhieuXuat"].DataPropertyName = "SoPhieuXuat";
            dgvPhieuXuatCtiet.DataSource = tblPhieuXuatCtiet;
        }

//
        private void dgvPhieuXuatCtiet_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvPhieuXuatCtiet.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
            txtSoLuong.Text = dgvPhieuXuatCtiet.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtGiaXuat.Text = dgvPhieuXuatCtiet.Rows[e.RowIndex].Cells["GiaXuat"].Value.ToString();
        }

        private bool validateInput()
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Mã không được để trống");
                txtMaHang.Focus();
                return false;
            }
            else {
                if (objCommon.isDuplicate(txtMaHang.Text, "MaHang", "Hang") != 1)
                {
                    MessageBox.Show("Mã hàng không tồn tại");
                    txtMaHang.Focus();
                    return false;
                }
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng");
                txtSoLuong.Focus();
                return false;
            }
            else {
                if (!objCommonUI.isNumberic(txtSoLuong.Text))
                {
                    MessageBox.Show("Số lượng phải là số");
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();
                    return false;
                }
            }
            return true;
        }

        private void cboNgayXuat_ValueChanged(object sender, EventArgs e)
        {
            if (cboNgayXuat.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày bán không được lớn hơn ngày hiện tại");
                cboNgayXuat.Value = DateTime.Now;
            }
            
        }

        private void txtTienTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                if (!objCommonUI.isNumberic(txtTienTra.Text))
                {
                    MessageBox.Show("Phải nhập số");
                    txtTienTra.Text = "0";
                    txtTienTra.Focus();
                }
                else
                {
                    txtTraLai.Text = Convert.ToString(Convert.ToInt32(txtTienTra.Text) - Convert.ToInt32(txtTongTien.Text));
                    txtTraLai.Focus();
                }
            }
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                objGiaBan.MaHang = txtMaHang.Text;
                objGiaBan.LoaiKH = LoaiKH;
                tblGiaBan = objGiaBan.SELECT_GIABAN_BY_2ID();
                if (tblGiaBan.Rows.Count > 0)
                    txtGiaXuat.Text = tblGiaBan.Rows[0]["GiaBan"].ToString();
                else
                    txtGiaXuat.Text = "0";
                txtSoLuong.Focus();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                LuuDuLieu();
            }
        }

        private void txtTraLai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                this.ThanhToan();

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
            objPhieuXuatCTiet.MaHang = txtMaHang.Text;
            objPhieuXuatCTiet.SoPhieuXuat = txtSoPhieuXuat.Text;
            objPhieuXuatCTiet.DELETE_PHIEUXUATCTIET();
            if (objPhieuXuatCTiet.ErrorMsg != "")
                MessageBox.Show(objPhieuXuatCTiet.ErrorMsg);
            else
                this.bindPhieuXuatCtiet();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
        private void CloseForm() {
            if (passData != null)
            {
                passData();
            }

            this.Close();        
        }

        /////// Cac ham chuc nang
        private void PHIEUXUAT_ACT(string ActionName)
        {
            objPhieuXuat.SoPhieuXuat = txtSoPhieuXuat.Text;
            objPhieuXuat.NgayXuat = cboNgayXuat.Value;
            objPhieuXuat.MaNV = cboMaNV.SelectedValue.ToString();
            objPhieuXuat.MaBan = this.MaBan;
            if (!objCommonUI.isNumberic(txtTienTra.Text)) txtTienTra.Text = "0";
            objPhieuXuat.TienTra = Convert.ToInt32(txtTienTra.Text);
            if (!objCommonUI.isNumberic(txtTraLai.Text)) txtTraLai.Text = "0";
            objPhieuXuat.TienDu = Convert.ToInt32(txtTraLai.Text);
            objPhieuXuat.LoaiKH = this.LoaiKH;
            objPhieuXuat.GhiChu = txtGhiChu.Text;
            objPhieuXuat.ThanhToan = intThanhToan;

            if (ActionName == "update")
                objPhieuXuat.UPDATE_PHIEUXuat();
            if (ActionName == "addnew")
                objPhieuXuat.INSERT_PHIEUXUAT();
            if (objPhieuXuat.ErrorMsg != "")
                MessageBox.Show(objPhieuXuat.ErrorMsg);
        }

        private void PHIEUXUATCTIET_ACT(string ActionName)
        {
            objPhieuXuatCTiet.SoPhieuXuat = txtSoPhieuXuat.Text;
            objPhieuXuatCTiet.MaHang = txtMaHang.Text;
            objPhieuXuatCTiet.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            objPhieuXuatCTiet.DonGia = Convert.ToInt32(txtGiaXuat.Text);
            objPhieuXuatCTiet.TraLai = chkTraLai.Checked;
            if (ActionName == "update")
                objPhieuXuatCTiet.UPDATE_PHIEUXUATCTIET();
            if (ActionName == "addnew")
                objPhieuXuatCTiet.INSERT_PHIEUXUATCTIET();
            if (objPhieuXuat.ErrorMsg != "")

                if (objPhieuXuatCTiet.ErrorMsg != "")
                    MessageBox.Show(objPhieuXuatCTiet.ErrorMsg);
        }
        
        ////
        private void ThanhToan()
        {
            //Update PhieuXuat
            intThanhToan = 1;
            this.PHIEUXUAT_ACT("update");

            if (MessageBox.Show("Bạn có in phiếu thanh toán không ?", "In phiếu thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRViewer objCRViewer = new CRViewer();
                objCRViewer.TenReport = "PHIEUTHU";
                objCRViewer.CRQuery = "SELECT TenHang,SoLuong,DonGia,(SoLuong*DonGia) as ThanhTien FROM PhieuXuatCTiet P,Hang H WHERE P.MaHang = H.MaHang AND SoPhieuXuat = '" + txtSoPhieuXuat.Text + "'";
                objCRViewer.ShowDialog();
            }
            this.CloseForm();
        }

        //
        private void LuuDuLieu()
        {
            //Check input
            if (!this.validateInput())
                return;
            // Kiem tra phieu Xuat neu chua co thi insert vao bang phieu Xuat truoc
            tblPhieuXuat.Clear();
            objPhieuXuat.SoPhieuXuat = txtSoPhieuXuat.Text;
            tblPhieuXuat = objPhieuXuat.SELECT_BY_ID();
            if (tblPhieuXuat.Rows.Count == 0)
            {
                this.PHIEUXUAT_ACT("addnew");
                //Insert vao phieu Xuat chi tiet
                this.PHIEUXUATCTIET_ACT("addnew");
            }
            else
            {
                //Neu co roi thi update phieu Xuat
                this.PHIEUXUAT_ACT("update");
                //Kiem tra PNCN neu chua co thi Insert vao phieu Xuat chi tiet
                objPhieuXuatCTiet.SoPhieuXuat = txtSoPhieuXuat.Text;
                objPhieuXuatCTiet.MaHang = txtMaHang.Text;
                tblPhieuXuatCTiet.Clear();
                tblPhieuXuatCTiet = objPhieuXuatCTiet.SELECT_BY_2ID();
                if (tblPhieuXuatCTiet.Rows.Count == 0) //Chua co 
                {
                    this.PHIEUXUATCTIET_ACT("addnew");
                }
                else
                {
                    //Hoac Update phieu Xuat chi tiet
                    this.PHIEUXUATCTIET_ACT("update");
                }
            }
            this.bindPhieuXuatCtiet();
            txtSoLuong.Text = "";
            txtMaHang.Focus();
        }

    }
}