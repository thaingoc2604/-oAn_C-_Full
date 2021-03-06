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
    public class DMTaiKhoanCtrl
    {
        DMTaiKhoanData m_DMTaiKhoanData = new DMTaiKhoanData();

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_DMTaiKhoanData.LayDMTaiKhoan();
            cbx.DisplayMember = "TenTaiKhoan";
            cbx.ValueMember = "SoHieuTaiKhoan";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_DMTaiKhoanData.LayDMTaiKhoan();
            cmbColumn.DisplayMember = "TenTaiKhoan";
            cmbColumn.ValueMember = "SoHieuTaiKhoan";
            cmbColumn.DataPropertyName = "SoHieuTaiKhoan";
            cmbColumn.HeaderText = "Tên tài khoản";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_DMTaiKhoanData.LayDMTaiKhoan();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi (DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtSoHieuTaiKhoan,
                            TextBoxX txtTenTaiKhoan,
                            TextBoxX txtTinhChatSoDu
                           )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_DMTaiKhoanData.LayDMTaiKhoan();

            txtSoHieuTaiKhoan.DataBindings.Clear();
            txtSoHieuTaiKhoan.DataBindings.Add("Text", bS, "SoHieuTaiKhoan");

            txtTenTaiKhoan.DataBindings.Clear();
            txtTenTaiKhoan.DataBindings.Add("Text", bS, "TenTaiKhoan");

            txtTinhChatSoDu.DataBindings.Clear();
            txtTinhChatSoDu.DataBindings.Add("Text", bS, "txtTinhChatSoDu");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_DMTaiKhoanData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_DMTaiKhoanData.ThemDMTaiKhoan(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuDMTaiKhoan()
        {
            return m_DMTaiKhoanData.LuuDMTaiKhoan();
        }
        #endregion 
    }
}
