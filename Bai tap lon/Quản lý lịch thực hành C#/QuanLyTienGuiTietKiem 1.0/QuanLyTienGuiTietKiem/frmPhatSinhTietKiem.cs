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
    public partial class frmPhatSinhTietKiem : Office2007Form
    {
        QuyDinh m_QuyDinh = new QuyDinh();
        PhatSinhTietKiemCtrl m_PhatSinhTietKiemCtrl = new PhatSinhTietKiemCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        PhongGiaoDichCtrl m_PhongGiaoDichCtrl = new PhongGiaoDichCtrl();
        QuayGiaoDichCtrl m_QuayGiaoDichCtrl = new QuayGiaoDichCtrl();
        DMLoaiGiaoDichCtrl m_DMLoaiGiaoDichCtrl = new DMLoaiGiaoDichCtrl();

        public frmPhatSinhTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }



        private void frmPhatSinhTietKiem_Load(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThiComboBox(cmbNhanVien);
            m_DMLoaiGiaoDichCtrl.HienThiComboBox(cmMaLoaiGiaoDich);
            m_QuayGiaoDichCtrl.HienThiComboBox(cmbMaQuayGiaoDich);
            m_PhongGiaoDichCtrl.HienThiComboBox(cmbMaPhongGiaoDich);

            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colMaNV);
            //m_DMLoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colMaloaiGiaoDich);
            m_QuayGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colMaQuayGiaoDich);
            m_PhongGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colMaPhongGiaoDich);

            m_PhatSinhTietKiemCtrl.HienThi(DGVPhatSinhTietKiem, BindingNavigatorPhatSinhTietKiem, txMaSoTietKiem, txtSoButToan, dtNgayGiaoDich, txtDaDuyet, cbDaDuyet, cbChuaDuyet, cmMaLoaiGiaoDich, cmbNhanVien, cmbMaQuayGiaoDich, cmbMaPhongGiaoDich);// , 

        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";

            m_NhanVienCtrl.HienThiComboBox(cmbNhanVien);
            m_DMLoaiGiaoDichCtrl.HienThiComboBox(cmMaLoaiGiaoDich);
            m_QuayGiaoDichCtrl.HienThiComboBox(cmbMaQuayGiaoDich);
            m_PhongGiaoDichCtrl.HienThiComboBox(cmbMaPhongGiaoDich);

            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colMaNV);
            //m_DMLoaiGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colMaloaiGiaoDich);
            m_QuayGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colMaQuayGiaoDich);
            m_PhongGiaoDichCtrl.HienThiDataGridViewComboBoxColumn(colMaPhongGiaoDich);

            m_PhatSinhTietKiemCtrl.HienThi(DGVPhatSinhTietKiem, BindingNavigatorPhatSinhTietKiem, txMaSoTietKiem, txtSoButToan, dtNgayGiaoDich, txtDaDuyet, cbDaDuyet, cbChuaDuyet, cmMaLoaiGiaoDich, cmbNhanVien, cmbMaQuayGiaoDich, cmbMaPhongGiaoDich);// , 
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (DGVPhatSinhTietKiem.RowCount == 0)
                BindingNavigatorPhatSinhTietKiem.Enabled = true;
            DataRow m_Row = m_PhatSinhTietKiemCtrl.ThemDongMoi();
            m_Row["MaSoTietKiem"] = "";
            m_Row["SoButToan"] = "";
            m_Row["DaDuyet"] = false;
            m_Row["NgayGiaoDich"] = DateTime.Today;
            m_Row["MaLoaiGiaoDich"] = "";
            m_Row["MaPhongGiaoDich"] = "";
            m_Row["MaQuayGiaoDich"] = "";
            m_Row["MaNV"] = "";
            m_PhatSinhTietKiemCtrl.ThemMoi(m_Row);
            BindingNavigatorPhatSinhTietKiem.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in DGVPhatSinhTietKiem.Rows)
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
           
            if (KiemTraTruocKhiLuu("colMaloaiGiaoDich") == true &&
                KiemTraTruocKhiLuu("colMaNV") == true &&
                KiemTraTruocKhiLuu("colMaPhongGiaoDich") == true &&
                KiemTraTruocKhiLuu("colMaQuayGiaoDich") == true &&
                KiemTraTruocKhiLuu("colMaSoTietKiem") == true&&
                KiemTraTruocKhiLuu("colNgayGiaoDich") == true&&
                KiemTraTruocKhiLuu("colSoButToan") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_PhatSinhTietKiemCtrl.LuuPhatSinhTietKiem();
            }

            else
            {
                MessageBoxEx.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DGVPhatSinhTietKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BindingNavigatorPhatSinhTietKiem.BindingSource.RemoveCurrent();
                }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVPhatSinhTietKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtDaDuyet.Text == "True")
            {
                cbDaDuyet.Checked = true;
                cbChuaDuyet.Checked = false;
            }
            else
            {
                cbChuaDuyet.Checked = true;
                cbDaDuyet.Checked = false;
            }
        }

      

        


        #region Tim Kiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemPhatSinhTietKiem();
            }
        }

        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemPhatSinhTietKiem();
            }
        }


        void TimKiemPhatSinhTietKiem()
        {
            try
            {
                if (cbMaTK.Checked == true)
                {
                    m_PhatSinhTietKiemCtrl.TimKiemTheoMa(txtTimKiem.Text);
                }
                else
                {
                    m_PhatSinhTietKiemCtrl.TimKiemTheoTen(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBoxEx.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}