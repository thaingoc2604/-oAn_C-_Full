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
    public class DMLoaiGiaoDichCtrl
    {
        DMLoaiGiaoDichData m_DMLoaiGiaoDichData = new DMLoaiGiaoDichData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_DMLoaiGiaoDichData.LayDMLoaiGiaoDich();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenGiaoDich";
            cbx.ValueMember = "MaLoaiGIaoDich";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_DMLoaiGiaoDichData.LayDMLoaiGiaoDich();
            cmbColumn.DisplayMember = "LoaiTien";
            cmbColumn.ValueMember = "MaLoaiTien";
            cmbColumn.DataPropertyName = "MaLoaiTien";
            cmbColumn.HeaderText = "Loai tien";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_DMLoaiGiaoDichData.LayDMLoaiGiaoDich();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi (DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaLoaiTien,
                            TextBoxX txtLoaiTien,
                            TextBoxX txtSoLuong
                           )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_DMLoaiGiaoDichData.LayDMLoaiGiaoDich();

            txtMaLoaiTien.DataBindings.Clear();
            txtMaLoaiTien.DataBindings.Add("Text", bS, "MaLoaiTien");

            txtLoaiTien.DataBindings.Clear();
            txtLoaiTien.DataBindings.Add("Text", bS, "LoaiTien");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", bS, "SoLuong");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_DMLoaiGiaoDichData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_DMLoaiGiaoDichData.ThemDMLoaiGiaoDich(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuDMLoaiGiaoDich()
        {
            return m_DMLoaiGiaoDichData.LuuDMLoaiGiaoDich();
        }
        #endregion 
    }
}
