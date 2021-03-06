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
    public class TaiKhoanCtrl
    {
        TaiKhoanData m_TaiKhoanData = new TaiKhoanData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = new DataTable();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "NgayCapNhat";
            cbx.DisplayMember = "SoHieuTaiKhoan";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_TaiKhoanData.LayTaiKhoan();
            cmbColumn.DisplayMember = "NgayCapNhat";
            cmbColumn.DisplayMember = "SoHieuTaiKhoan";
            cmbColumn.DataPropertyName = "SoHieuTaiKhoan";
            cmbColumn.HeaderText = "Ngay cap nhat";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_TaiKhoanData.LayTaiKhoan();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            DateTimeInput dtNgayCapNhat,
                            TextBoxX txtSoDuDauNgay,
                            TextBoxX txtSoPhatSinhNo,
                            TextBoxX txtSoPhatSinhCo,
                            ComboBoxEx cmbSoHieuTaiKhoan)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_TaiKhoanData.LayTaiKhoan();

            txtSoDuDauNgay.DataBindings.Clear();
            txtSoDuDauNgay.DataBindings.Add("Text", bS, "SoDuDauNgay");

            txtSoPhatSinhNo.DataBindings.Clear();
            txtSoPhatSinhNo.DataBindings.Add("Text", bS, "SoPhatSinhNo");

            txtSoPhatSinhCo.DataBindings.Clear();
            txtSoPhatSinhCo.DataBindings.Add("Text", bS, "SoPhatSinhCo");

            dtNgayCapNhat.DataBindings.Clear();
            dtNgayCapNhat.DataBindings.Add("Value", bS, "NgayCapNhat");

            cmbSoHieuTaiKhoan.DataBindings.Clear();
            cmbSoHieuTaiKhoan.DataBindings.Add("SelectedValue", bS, "SoHieuTaiKhoan");


            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_TaiKhoanData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_TaiKhoanData.ThemTaiKhoan(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuTaiKhoan()
        {
            return m_TaiKhoanData.LuuTaiKhoan();
        }
        #endregion 
    }
}
