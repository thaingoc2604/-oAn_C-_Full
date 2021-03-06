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
    public class DMLoaiTienCtrl
    {
        DMLoaiTienData m_DMLoaiTienData = new DMLoaiTienData();

       

        #region Hien thi

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_DMLoaiTienData.LayDMLoaiTien();
            cbx.DisplayMember = "LoaiTien";
            cbx.ValueMember = "MaLoaiTien";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_DMLoaiTienData.LayDMLoaiTien();
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

            bs.DataSource = m_DMLoaiTienData.LayDMLoaiTien();
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
            bS.DataSource = m_DMLoaiTienData.LayDMLoaiTien();

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
            return m_DMLoaiTienData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_DMLoaiTienData.ThemDMLoaiTien(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuDMLoaiTien()
        {
            return m_DMLoaiTienData.LuuDMLoaiTien();
        }
        #endregion 
    }
}
