using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmLoaiTietKiem : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        LoaiTietKiemCtrl m_LoaiTietKiemCtrl = new LoaiTietKiemCtrl();
        DMLoaiTienCtrl m_DMLoaiTienCtrl = new DMLoaiTienCtrl();
        DMKyLaiTKCtrl m_DMKyLaiTietKiemCtrl = new DMKyLaiTKCtrl();
        DMTaiKhoanCtrl m_DMTaiKhoanCtrl = new DMTaiKhoanCtrl();


        public frmLoaiTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }


        private void frmLoaiTietKiem_Load(object sender, EventArgs e)
        {
            m_DMKyLaiTietKiemCtrl.HienThiComboBox(cmbMaKyTinhLai);
            m_DMLoaiTienCtrl.HienThiComboBox(cmbMaLoaiTien);
            m_DMTaiKhoanCtrl.HienThiComboBox(cmbSoHieuTaiKhoan);

            m_DMTaiKhoanCtrl.HienThiDataGridViewComboBoxColumn(colSoHieuTaiKhoan);
            m_DMLoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colMaLoaiTien);
            m_DMKyLaiTietKiemCtrl.HienThiDataGridViewComboBoxColumn(colMaKyTinhLai);

            m_LoaiTietKiemCtrl.HienThi(DGVLoaiTietKiem, BindingNavigatorLoaiTietKiem, txMaLoaiTietKiem, txtTenLoaiTietKiem, txtKyHan, txtDangHuyDong, cbHuyDong, cmbMaLoaiTien, cmbMaKyTinhLai, cmbSoHieuTaiKhoan);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";

            m_DMKyLaiTietKiemCtrl.HienThiComboBox(cmbMaKyTinhLai);
            m_DMLoaiTienCtrl.HienThiComboBox(cmbMaLoaiTien);
            m_DMTaiKhoanCtrl.HienThiComboBox(cmbSoHieuTaiKhoan);

            m_DMTaiKhoanCtrl.HienThiDataGridViewComboBoxColumn(colSoHieuTaiKhoan);
            m_DMLoaiTienCtrl.HienThiDataGridViewComboBoxColumn(colMaLoaiTien);
            m_DMKyLaiTietKiemCtrl.HienThiDataGridViewComboBoxColumn(colMaKyTinhLai);

            m_LoaiTietKiemCtrl.HienThi(DGVLoaiTietKiem, BindingNavigatorLoaiTietKiem, txMaLoaiTietKiem, txtTenLoaiTietKiem, txtKyHan, txtDangHuyDong, cbHuyDong, cmbMaLoaiTien, cmbMaKyTinhLai, cmbSoHieuTaiKhoan);
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVLoaiTietKiem.RowCount == 0)
                BindingNavigatorLoaiTietKiem.Enabled = true;
            DataRow m_Row = m_LoaiTietKiemCtrl.ThemDongMoi();
            m_Row["MaLoaiTietKiem"] = "";
            m_Row["TenLoaiTietKiem"] = "";
            m_Row["KyHan"] = 0;
            m_Row["DangHuyDong"] = false;
            m_Row["MaLoaiTien"] = "";
            m_Row["MaKyTinhLai"] = "";
            m_Row["SoHieuTaiKhoan"] = "";
            
            m_LoaiTietKiemCtrl.ThemMoi(m_Row);
            BindingNavigatorLoaiTietKiem.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVLoaiTietKiem.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            if (KiemTraTruocKhiLuu("colMaKyTinhLai") == true &&
                KiemTraTruocKhiLuu("colMaLoaiTien") == true &&
                KiemTraTruocKhiLuu("colMaLoaiTietKiem") == true &&
                KiemTraTruocKhiLuu("colTenLoaiTietKiem") == true &&
                KiemTraTruocKhiLuu("colSoHieuTaiKhoan") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiTietKiemCtrl.LuuLoaiTietKiem();
            }

            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVLoaiTietKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorLoaiTietKiem.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVLoaiTietKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtDangHuyDong.Text == "True")

                cbHuyDong.Checked = true;
        }
                     


        #region Tim Kiem

        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemLoaiTietKiem();
            }
        }

        void TimKiemLoaiTietKiem()
        {
            try
            {
                if (cbMaTK.Checked == true)
                {
                    m_LoaiTietKiemCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else
                {
                    m_LoaiTietKiemCtrl.TiemKiemTheoTen(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemLoaiTietKiem();
            }
        }

        #endregion

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    m_LoaiTietKiemCtrl.LuuLoaiTietKiem(txMaLoaiTietKiem.Text, txtTenLoaiTietKiem.Text, txtKyHan.Visible,txtDangHuyDong.
        //}

        private void buttonSave_Click(object sender, EventArgs e)
        {

            LoaiTietKiemCtrl ctrl = new LoaiTietKiemCtrl();
            if (ctrl.LayLoaiTK(txMaLoaiTietKiem.Text) != null)
            {
                MessageBox.Show("Mã loai tiet kiem này đã tồn tại !", "Ma Loai Tiet Kiem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               bool danghuydong = false;
                if (cbHuyDong.Checked == true)
                    danghuydong = true;
                m_LoaiTietKiemCtrl.LuuLoaiTietKiem(txMaLoaiTietKiem.Text, txtTenLoaiTietKiem.Text, Convert.ToInt32(txtKyHan.Text), danghuydong, cmbMaLoaiTien.SelectedValue.ToString(), cmbMaKyTinhLai.SelectedValue.ToString(), cmbSoHieuTaiKhoan.SelectedValue.ToString());
                m_LoaiTietKiemCtrl.HienThi(DGVLoaiTietKiem, BindingNavigatorLoaiTietKiem, txMaLoaiTietKiem, txtTenLoaiTietKiem, txtKyHan, txtDangHuyDong, cbHuyDong, cmbMaLoaiTien, cmbMaKyTinhLai, cmbSoHieuTaiKhoan);
        }
    }
}