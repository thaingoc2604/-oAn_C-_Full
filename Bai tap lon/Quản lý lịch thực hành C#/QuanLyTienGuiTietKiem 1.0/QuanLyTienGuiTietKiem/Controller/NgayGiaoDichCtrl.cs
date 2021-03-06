using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class NgayGiaoDichCtrl
    {
        NgayGiaoDichData m_NgayGiaoDichData = new NgayGiaoDichData();

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_NgayGiaoDichData.LayNgayGiaoDich();
            cbx.DisplayMember = "NgayGiaoDich";
            cbx.ValueMember = "NgayGiaoDich";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NgayGiaoDichData.LayNgayGiaoDich();
            cmbColumn.DisplayMember = "NgayGiaoDich";
            cmbColumn.ValueMember = "NgayGiaoDich";
            cmbColumn.DataPropertyName = "NgayGiaoDich";
            cmbColumn.HeaderText = "Ngày giao dịch";
        }
        #endregion

        public void LaySoTheoNgay(String NgayGiaoDich)
        {
            m_NgayGiaoDichData.LayNgayGiaoDichTheoNgay(NgayGiaoDich);
        }

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NgayGiaoDichData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_NgayGiaoDichData.ThemNgayGiaoDich(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuNgayGiaoDich()
        {
            return m_NgayGiaoDichData.LuuNgayGiaoDich();
        }

        public void LuuNgayGD(DateTime NgayGiaoDich, bool NgatGiaoDich)
        {
            m_NgayGiaoDichData.LuuNgayGD(NgayGiaoDich, NgatGiaoDich);
        }
        #endregion 
    }
}
