using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class ChiTietPhatSinhGDCtrl
    {
        ChiTietPhatSinhGDData m_ChiTietPhatSinhGDData = new ChiTietPhatSinhGDData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_ChiTietPhatSinhGDData.LayChiTietPhatSinhGD();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "SoHieuTaiKhoanNo";
            cbx.ValueMember = "SoButToan";
        }

        public void HienThiComboBoxNo_Co(ComboBox cbx)
        {
            DataTable m_DT = m_ChiTietPhatSinhGDData.LayChiTietPhatSinhGD();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "SoHieuTaiKhoanCo";
            cbx.ValueMember = "SoHieuTaiKhoanNo";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_ChiTietPhatSinhGDData.LayChiTietPhatSinhGD();
            cmbColumn.DisplayMember = "TenChiTietPhatSinhGD";
            cmbColumn.ValueMember = "MaTietKiem";
            cmbColumn.DataPropertyName = "MaTietKiem";
            cmbColumn.HeaderText = "Tên Phát Sinh Tiết Kiệm";
        }
        #endregion

        #region Hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_ChiTietPhatSinhGDData.LayChiTietPhatSinhGD();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtSoGiaoDich,
                            TextBoxX txtSoButToan,
                            ComboBoxEx cmbSoHieuCo,
                            ComboBoxEx cmbSoHieuNo,
                            TextBoxX txtSoTien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_ChiTietPhatSinhGDData.LayChiTietPhatSinhGD();

            txtSoGiaoDich.DataBindings.Clear();
            txtSoGiaoDich.DataBindings.Add("Text", bS, "SoGiaoDich");

            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bS, "SoButToan");

            cmbSoHieuCo.DataBindings.Clear();
            cmbSoHieuCo.DataBindings.Add("SelectedValue", bS, "SoHieuTaiKhoanCo");

            cmbSoHieuNo.DataBindings.Clear();
            cmbSoHieuNo.DataBindings.Add("SelectedValue", bS, "SoHieuTaiKhoanNo");

            txtSoTien.DataBindings.Clear();
            txtSoTien.DataBindings.Add("Text", bS, "SoTien");


            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_ChiTietPhatSinhGDData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_ChiTietPhatSinhGDData.ThemChiTietPhatSinhGD(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuChiTietPhatSinhGD()
        {
            return m_ChiTietPhatSinhGDData.LuuChiTietPhatSinhGD();
        }

        public void LuuChiTietPSGD(String SoGiaoDich, String SoButToan, DateTime NgayGiaoDich, String SoHieuTaiKhoanNo, String SoHieuTaiKhoanCo, float SoTien)
        {
            m_ChiTietPhatSinhGDData.LuuChiTietPSGD(SoGiaoDich, SoButToan, NgayGiaoDich, SoHieuTaiKhoanNo, SoHieuTaiKhoanCo, SoTien);
        }
        #endregion 

        #region Xoa
        public void XoaChiTietPSGD(String SoGiaoDich, String SoButToan, DateTime NgayGiaoDich, String SoHieuTaiKhoanNo, String SoHieuTaiKhoanCo, float SoTien)
        {
            m_ChiTietPhatSinhGDData.XoaChiTietPSGD(SoGiaoDich, SoButToan, NgayGiaoDich, SoHieuTaiKhoanNo, SoHieuTaiKhoanCo, SoTien);
        }
        #endregion 
        #region tim kiem

        public void TimSoButToan(String m_ButToan)
        {
            m_ChiTietPhatSinhGDData.LayDSSoButToan(m_ButToan);
        }

        public void TimSoGiaoDich(String m_Gd)
        {
            m_ChiTietPhatSinhGDData.LayDSSoGD(m_Gd);
        }
        #endregion
    }
}
