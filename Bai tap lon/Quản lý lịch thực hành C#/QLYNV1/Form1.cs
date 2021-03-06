using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLYNV1
{
    public partial class Form1 : Form
    {
        clsDuLieu dl = new clsDuLieu();
        OleDbDataAdapter daNV;
        OleDbCommandBuilder cmdBD_NV;
        DataSet dsNV = new DataSet();
        DataTable tblNV = new DataTable();
        int ThemSuaTim = 0, ThuTuXem = 0;
        string strMaNVCu = "";
        
        public Form1()
        {
            InitializeComponent();
        }
        private void MoDKThemNhanVien(bool Mo)
        {
            grpThongTinNhanvien.Enabled = Mo;
            grpThem1.Enabled = Mo;
            btnThemMoi1.Enabled = !Mo;
        }
        private void MoDKSuaNhanVien(bool Mo)
        {
            txtMaNhanVien1_Sua.ReadOnly = !Mo;
            txtHoTenNhanVien1_Sua.ReadOnly = !Mo;
            txtDienThoai1_Sua.ReadOnly = !Mo;
            txtDiaChi1_Sua.ReadOnly = !Mo;
            cboChucVu1_Sua.Enabled = Mo;
            cboPhai1_Sua.Enabled = Mo;
            cboPhongBan1_Sua.Enabled = Mo;
            cboLoaiHopDong1_Sua.Enabled = Mo;
            dpkNgaySinh1_Sua.Enabled = Mo;
            dpkNgayVaoLam1_Sua.Enabled = Mo;
            grpSua1.Enabled = Mo;
            btnSua1.Enabled = !Mo;
            btnXoa1.Enabled = !Mo;
        }
        private void XoaND1()
        {
            txtMaNhanVien1.Clear();
            txtHoTen1.Clear();
            txtDiaChi1.Clear();
            txtDienThoai1.Clear();
            cboPhai1.SelectedIndex = 0;
            //cboLoaiHopDong1.SelectedIndex = 0;
            //cboChucVu1.SelectedIndex = 0;
            //cboPhongBan1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dl.KetNoi();
            cboPhai1.SelectedIndex = 0;
            cboLoaiHopDong1.DataSource = dl.GetDataSet("LOAINHANVIEN").Tables["LOAINHANVIEN"];
            cboLoaiHopDong1.DisplayMember = "TENLOAI";
            cboLoaiHopDong1.ValueMember = "MALOAI";
            cboChucVu1.DataSource = dl.GetDataSet("CHUCVU").Tables[0];
            cboChucVu1.DisplayMember = "TENCV";
            cboChucVu1.ValueMember = "MACV";
            cboPhongBan1.DataSource = dl.GetDataSet("PHONGBAN").Tables[0];
            cboPhongBan1.DisplayMember = "TENPB";
            cboPhongBan1.ValueMember = "MAPB";

            cboPhai1_Sua.SelectedIndex = 0;
            cboLoaiHopDong1_Sua.DataSource = dl.GetDataSet("LOAINHANVIEN").Tables["LOAINHANVIEN"];
            cboLoaiHopDong1_Sua.DisplayMember = "TENLOAI";
            cboLoaiHopDong1_Sua.ValueMember = "MALOAI";
            cboChucVu1_Sua.DataSource = dl.GetDataSet("CHUCVU").Tables[0];
            cboChucVu1_Sua.DisplayMember = "TENCV";
            cboChucVu1_Sua.ValueMember = "MACV";
            cboPhongBan1_Sua.DataSource = dl.GetDataSet("PHONGBAN").Tables[0];
            cboPhongBan1_Sua.DisplayMember = "TENPB";
            cboPhongBan1_Sua.ValueMember = "MAPB";


            cboPhongBanTim.DataSource = dl.GetDataSet("PHONGBAN").Tables[0];
            cboPhongBanTim.DisplayMember = "TENPB";
            cboPhongBanTim.ValueMember = "MAPB";
            cboPhongBanTim.SelectedIndex = -1;
            cboPhanLoaiNhanVienTim.DataSource = dl.GetDataSet("LOAINHANVIEN").Tables[0];
            cboPhanLoaiNhanVienTim.DisplayMember = "TENLOAI";
            cboPhanLoaiNhanVienTim.ValueMember = "MALOAI";
            cboPhanLoaiNhanVienTim.SelectedIndex = -1;
            

            dsNV = dl.GetDataSet(ref daNV, ref cmdBD_NV, "NHANVIEN");
            tblNV = dsNV.Tables["NHANVIEN"];
            dgridNhanVien1.DataSource = tblNV;
            tabControl1.SelectedIndex = 0;
            MoDKThemNhanVien(false);
            MoDKSuaNhanVien(false);



        }

        private void btnThemMoi1_Click(object sender, EventArgs e)
        {
            XoaND1();
            MoDKThemNhanVien(true);
            txtMaNhanVien1.Focus();
        }

        private void btnKhongThem1_Click(object sender, EventArgs e)
        {
            XoaND1();
            MoDKThemNhanVien(false);
            btnThemMoi1.Focus();
        }
        private bool KTThongTinThemNV()
        {
            if (txtMaNhanVien1.Text.Trim() == "" || txtMaNhanVien1.TextLength == 0 || txtHoTen1.Text.Trim() == "" || txtHoTen1.TextLength == 0 || txtDiaChi1.Text.Trim() == "" || txtDiaChi1.TextLength == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool KTThongTinNhanVienSua()
        {
            foreach (Control tb in tabSua_Xoa.Controls)
                if (tb is TextBox && (tb.Text.Trim() == "" || tb.Text.Length == 0))
                    if (tb.Name != "txtDienThoai1")
                        return true;
            return false;
        }

        private void btnLuuThem1_Click(object sender, EventArgs e)
        {
            if (KTThongTinThemNV() == false)
            {
                MessageBox.Show("Thông tin chua đầy đủ ,xin kiểm tra lại");
                txtMaNhanVien1.Focus();
                return;
            }
            DataRow Dong = dl.KTMaSo(tblNV, "MANV", txtMaNhanVien1.Text);
            if (Dong != null)
            {
                MessageBox.Show("Mã số nhân viên này đã có , xin cho mã số khác");
                txtMaNhanVien1.Focus(); return;
            }
            DataRow DongMoi;
            DongMoi = tblNV.NewRow();
            DongMoi["MANV"] = txtMaNhanVien1.Text;
            DongMoi["HOTENNV"] = txtHoTen1.Text;
            DongMoi["NGAYSINH"] = dpkNgaySinh1.Text;
            DongMoi["DIENTHOAI"] = txtDienThoai1.Text;
            DongMoi["DIACHI"] = txtDiaChi1.Text;
            DongMoi["NGAYVAOLAM"] = dpkNgayVaoLam1.Text;
            DongMoi["PHAI"] = cboPhai1.Text == "Nam" ? 1 : 0;
            DongMoi["MALOAI"] = cboLoaiHopDong1.SelectedValue.ToString();
            DongMoi["MACV"] = cboChucVu1.SelectedValue.ToString();
            DongMoi["MAPB"] = cboPhongBan1.SelectedValue.ToString();
            tblNV.Rows.Add(DongMoi);
            daNV.Update(tblNV);
            dgridNhanVien1.Refresh();
            dgridNhanVien1.CurrentCell = dgridNhanVien1[0, tblNV.Rows.Count - 1];
            MoDKThemNhanVien(false);
            btnThemMoi1.Focus();

        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            MoDKSuaNhanVien(true);
            txtMaNhanVien1.Focus();

        }

        private void btnKhongSua1_Click(object sender, EventArgs e)
        {
            MoDKSuaNhanVien(false);
            btnSua1.Focus();
        }

        private void btnLuuSua1_Click(object sender, EventArgs e)
        {
            if (KTThongTinNhanVienSua() == true)
            {
                MessageBox.Show("Thông tin chưa đầy đủ, xin kiêm tra lại");
                txtMaNhanVien1_Sua.Focus();
                txtMaNhanVien1_Sua.SelectAll();
                return;
            }
            DataRow Dong = dl.KTMaSo(tblNV, "MANV", txtMaNhanVien1_Sua.Text);
            if (Dong == null)
            {
                DataRow DongMoi;
                DongMoi = tblNV.NewRow();
                DongMoi["MANV"] = txtMaNhanVien1.Text;
                DongMoi["HOTENNV"] = txtHoTen1.Text;
                DongMoi["NGAYSINH"] = dpkNgaySinh1.Text;
                DongMoi["DIENTHOAI"] = txtDienThoai1.Text;
                DongMoi["DIACHI"] = txtDiaChi1.Text;
                DongMoi["NGAYVAOLAM"] = dpkNgayVaoLam1.Text;
                DongMoi["PHAI"] = cboPhai1.Text == "Nam" ? 1 : 0;
                DongMoi["MALOAI"] = cboLoaiHopDong1.SelectedValue.ToString();
                DongMoi["MACV"] = cboChucVu1.SelectedValue.ToString();
                DongMoi["MAPB"] = cboPhongBan1.SelectedValue.ToString();
               // tblNV.Rows.Add(DongMoi);
                daNV.Update(tblNV);
                dgridNhanVien1.Refresh();
                dgridNhanVien1.CurrentCell = dgridNhanVien1[0, tblNV.Rows.Count - 1];
                MoDKSuaNhanVien(false);
                btnSua1.Focus();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemSuaTim = tabControl1.SelectedIndex;
            dgridNhanVien1.Focus();
        }

        private void dgridNhanVien1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ThemSuaTim == 1)
            {
                if(dgridNhanVien1.CurrentRow!=null)
                    txtMaNhanVien1_Sua.Text = dgridNhanVien1.CurrentRow.Cells["MANV"].Value.ToString();
                    txtHoTenNhanVien1_Sua.Text = dgridNhanVien1.CurrentRow.Cells["HOTEN"].Value.ToString();
                    dpkNgayVaoLam1_Sua.Text = dgridNhanVien1.CurrentRow.Cells["NGAYVAOLAM"].Value.ToString();
                    dpkNgaySinh1_Sua.Text = dgridNhanVien1.CurrentRow.Cells["NGAYSINH"].Value.ToString();
                    txtDiaChi1_Sua.Text = dgridNhanVien1.CurrentRow.Cells["DIACHI"].Value.ToString();
                    txtDienThoai1_Sua.Text = dgridNhanVien1.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
                    cboPhai1_Sua.Text = (bool)dgridNhanVien1.CurrentRow.Cells["PHAI"].Value == true ? "Nam" : "Nữ";
                    cboChucVu1_Sua.SelectedValue = dgridNhanVien1.CurrentRow.Cells["CHUCVU"].Value.ToString();
                    cboLoaiHopDong1_Sua.SelectedValue = dgridNhanVien1.CurrentRow.Cells["LOAIHD"].Value.ToString();
                    cboPhongBan1_Sua.SelectedValue = dgridNhanVien1.CurrentRow.Cells["PHONGBAN"].Value.ToString();
                    strMaNVCu = txtMaNhanVien1_Sua.Text;

            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            int VT;
            string strMaXoa = txtMaNhanVien1_Sua.Text;
            DialogResult TL;
            TL = MessageBox.Show("Bạn có muốn xoa nhân viên có mã số " + strMaXoa + " không ?", "Cảnh báo xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TL == DialogResult.Yes)
            {
                VT = dgridNhanVien1.CurrentRow.Index;
                dgridNhanVien1.Rows.RemoveAt(VT);
                daNV.Update(tblNV);
                
            }
        }

        private void radTimTatCaNhanVien1_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTatCaNhanVien1.Checked == true)
            {
                txtManhanVienTim.Enabled = false;
                cboPhanLoaiNhanVienTim.Enabled = false;
                cboPhongBanTim.Enabled = false;
                grpDKTim1.Enabled = false;
                ThuTuXem = 0;
            }
        }

        private void radTimTheoPhongBan1_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoPhongBan1.Checked == true)
            {
                txtManhanVienTim.Enabled = false;
                cboPhongBanTim.Enabled = true;
                cboPhanLoaiNhanVienTim.Enabled = false;
                grpDKTim1.Enabled = false;
                ThuTuXem = 1;
            }
        }

        private void radTimTheoMaNhanVien1_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoMaNhanVien1.Checked == true)
            {
                txtManhanVienTim.Enabled = true;
                cboPhanLoaiNhanVienTim.Enabled = false;
                cboPhongBanTim.Enabled = false;
                grpDKTim1.Enabled = false;
                ThuTuXem = 2;
                txtManhanVienTim.Focus();
            }
        }

        private void radTimTheoPhanLoaiNhanVien1_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoPhanLoaiNhanVien1.Checked == true)
            {
                txtManhanVienTim.Enabled = false;
                cboPhongBanTim.Enabled = false;
                cboPhanLoaiNhanVienTim.Enabled = true;
                grpDKTim1.Enabled = false;
                ThuTuXem = 3;
            }
        }

        private void radTimTheoDieuKien1_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimTheoDieuKien1.Checked == true)
            {
                txtManhanVienTim.Enabled = false;
                cboPhanLoaiNhanVienTim.Enabled = false;
                cboPhongBanTim.Enabled = false;
                grpDKTim1.Enabled = true;
                ThuTuXem = 4;
            }
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            DataTable tblNVTim = new DataTable();
            string strDieuKien = "";
            if (radTimTatCaNhanVien1.Checked == true)
            {
                tblNV = dl.LayTTNVTheoDK(strDieuKien).Tables[0];
            }
             if (radTimTheoPhongBan1.Checked == true)
                {
                    if (cboPhongBanTim.Text != "")
                    {
                        if (strDieuKien == "")
                        {
                            strDieuKien = "MaPB='" + cboPhongBanTim.SelectedValue + "'";
                        }

                        else
                        {
                            strDieuKien += " Or MaPB ='" + cboPhongBanTim.SelectedValue + "'";
                        }
                    }
                
                }
                if (radTimTheoMaNhanVien1.Checked == true)
                {
                    strDieuKien = "MaNV='" + txtManhanVienTim.Text + "'";
                }

                if (radTimTheoPhanLoaiNhanVien1.Checked == true)
                {
                    if (cboPhanLoaiNhanVienTim.Text != "")
                    {
                        if (strDieuKien == "")
                        {
                            strDieuKien = "MaLoai='" + cboPhanLoaiNhanVienTim.SelectedValue + "'";
                        }
                        else
                        {
                            strDieuKien += " Or MaLoai='" + cboPhanLoaiNhanVienTim.SelectedValue + "'";
                        }
                    }
                }
                if (radTimTheoDieuKien1.Checked == true)
                {
                    if (txtHoTenTim1.TextLength > 0)
                    {
                        strDieuKien = "HOTENNV='" + txtHoTenTim1.Text + "'";
                    }
                    if (txtDiaChiTim1.TextLength > 0)
                    {
                        if (strDieuKien == "")
                        {
                            strDieuKien = " DIACHI='" + txtDiaChiTim1.Text + "'";
                        }
                        else
                        {
                            strDieuKien += " Or DIACHI='" + txtDiaChiTim1.Text + "'";
                        }
                    }
                    if (txtDienThoaiTim1.TextLength > 0)
                    {
                        if (strDieuKien == "")
                        {
                            strDieuKien = "DIENTHOAI='" + txtDienThoaiTim1.Text + "'";
                        }
                        strDieuKien += " Or DIENTHOAI='" + txtDienThoaiTim1.Text + "'";
                    }
                    else
                    {
                        if (strDieuKien == "")
                        {
                            strDieuKien = "DIENTHOAI is null";
                        }
                        else
                        {
                            strDieuKien += " Or DIENTHOAI is null";
                        }
                    }

                }
                if (strDieuKien != "")
                {
                    strDieuKien = " Where " + strDieuKien;
                }
            
            tblNVTim = dl.LayTTNVTheoDK(strDieuKien).Tables[0];
            dgridNhanVien1.DataSource = tblNVTim;
            txtDiaChiTim1.Clear();
            txtHoTenTim1.Clear();
            txtManhanVienTim.Clear();
            txtDienThoaiTim1.Text = "1";
        }
    }
}