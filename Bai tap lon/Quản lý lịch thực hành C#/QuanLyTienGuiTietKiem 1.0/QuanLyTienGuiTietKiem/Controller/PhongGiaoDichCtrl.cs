using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QuanLyTienGuiTietKiem.DataLayer;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class PhongGiaoDichCtrl
    {
        PhongGiaoDichData m_PhongGiaoDichData = new PhongGiaoDichData();

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_PhongGiaoDichData.LayPhongGiaoDich();
            cbx.DisplayMember = "TenPhong";
            cbx.ValueMember = "MaPhongGiaoDich";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_PhongGiaoDichData.LayPhongGiaoDich();
            cmbColumn.DisplayMember = "TenPhong";
            cmbColumn.ValueMember = "MaPhongGiaoDich";
            cmbColumn.DataPropertyName = "MaPhongGiaoDich";
            cmbColumn.HeaderText = "Tên phòng GD";
        }
        #endregion

        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_PhongGiaoDichData.LayPhongGiaoDich();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        #region Them moi 
        public DataRow ThemDongMoi()
        {
            return m_PhongGiaoDichData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_PhongGiaoDichData.ThemPhongGiaoDich(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuPhongGiaoDich()
        {
            return m_PhongGiaoDichData.LuuPhongGiaoDich();
        }
        #endregion 

        #region Tim kiem phong giao dich
        public void TiemKiemTheoTenPhongGD(String m_TenPGD)
        {
            m_PhongGiaoDichData.TimKiemTheoTenPhongGD(m_TenPGD);
        }

        public void TiemKiemTheoMaPhongGD(String m_MaPGD)
        {
            m_PhongGiaoDichData.TimKiemTheoMaPhongGD(m_MaPGD);
        }

        #endregion 
    }
}
