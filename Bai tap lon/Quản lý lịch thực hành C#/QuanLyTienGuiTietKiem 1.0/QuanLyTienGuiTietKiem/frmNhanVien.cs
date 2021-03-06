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
    public partial class frmNhanVien : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        PhongGiaoDichCtrl m_PhongGiaoDihCtrl = new PhongGiaoDichCtrl();
        NhomNguoiDungCtrl m_NguoiDungCtrl = new NhomNguoiDungCtrl();
        public frmNhanVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            m_PhongGiaoDihCtrl.HienThiComboBox(cmbPhongGiaoDich);
            m_PhongGiaoDihCtrl.HienThiDataGridViewComboBoxColumn(colMaPhongGD);
            m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien, txtMaNV, txtHoTen, dtNgaySinh, txtDiaChi, txtSoDienThoai, cmbPhongGiaoDich);
        }
        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            m_PhongGiaoDihCtrl.HienThiComboBox(cmbPhongGiaoDich);
            m_PhongGiaoDihCtrl.HienThiDataGridViewComboBoxColumn(colMaPhongGD);
            m_NhanVienCtrl.HienThi(DGVNhanVien, BindingNavigatorNhanVien, txtMaNV, txtHoTen, dtNgaySinh, txtDiaChi, txtSoDienThoai, cmbPhongGiaoDich);
        }
               
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.RowCount == 0)
                BindingNavigatorNhanVien.Enabled = true;
            DataRow m_Row = m_NhanVienCtrl.ThemDongMoi();
            m_Row["MaNV"] = "NV" + m_QuyDinh.LaySTT(DGVNhanVien.Rows.Count + 1);
            m_Row["HoTen"] = "";
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_Row["MaPhongGiaoDich"] = "";
            
            m_NhanVienCtrl.ThemMoi(m_Row);
            BindingNavigatorNhanVien.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVNhanVien.Rows)
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
            try
            {
                if (KiemTraTruocKhiLuu("colMaNV") == true&&
                    KiemTraTruocKhiLuu("colHoTen") == true &&
                    KiemTraTruocKhiLuu("colDiaChi") == true &&
                    KiemTraTruocKhiLuu("colDienThoai") == true&&
                    KiemTraTruocKhiLuu("colNgaySinh") == true&&
                    KiemTraTruocKhiLuu("colMaPhongGD") == true)
                    bindingNavigatorPositionItem.Focus();
                m_NhanVienCtrl.LuuNhanVien();
            }
            catch
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorNhanVien.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhongGiaoDich();
        }

        #region Tim Kiem nhan vien

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemNhanVien();
            }
        }

        void TimKiemNhanVien()
        {
            try
            {
                if (cbMaNV.Checked == true)
                {
                    m_NhanVienCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else if (cbHoTen.Checked == true)
                {
                    m_NhanVienCtrl.TiemKiemTheoTen(txtTimKiem.Text);
                }
                else
                {
                    m_PhongGiaoDihCtrl.TiemKiemTheoTenPhongGD(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemNhanVien();
            }
        }

        #endregion

       


   }
}