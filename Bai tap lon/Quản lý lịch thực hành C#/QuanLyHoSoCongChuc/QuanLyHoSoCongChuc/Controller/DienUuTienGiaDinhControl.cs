using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class DienUuTienGiaDinhControl
    {
        DienUuTienGiaDinhData m_DienUuTienGiaDinhData = new DienUuTienGiaDinhData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_DienUuTienGiaDinhData.LayDsDienUuTienGiaDinh();
            cmb.DisplayMember = "TenDienUuTienGiaDinh";
            cmb.ValueMember = "MaDienUuTienGiaDinh";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnDienUuTienGiaDinh(DataGridViewComboBoxColumn cmbColumnDienUuTienGiaDinh)
        {
            cmbColumnDienUuTienGiaDinh.DataSource = m_DienUuTienGiaDinhData.LayDsDienUuTienGiaDinh();
            cmbColumnDienUuTienGiaDinh.DisplayMember = "TenDienUuTienGiaDinh";
            cmbColumnDienUuTienGiaDinh.ValueMember = "MaDienUuTienGiaDinh";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_DienUuTienGiaDinhData.LayDsDienUuTienGiaDinh();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaDienUuTienGiaDinh, TextBox txtTenDienUuTienGiaDinh)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_DienUuTienGiaDinhData.LayDsDienUuTienGiaDinh();
            bS.DataSource = tbl;

            txtMaDienUuTienGiaDinh.DataBindings.Clear();
            txtMaDienUuTienGiaDinh.DataBindings.Add("Text", bS, "MaDienUuTienGiaDinh");
            txtTenDienUuTienGiaDinh.DataBindings.Clear();
            txtTenDienUuTienGiaDinh.DataBindings.Add("Text", bS, "TenDienUuTienGiaDinh");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_DienUuTienGiaDinhData.ThemDongMoi();
        }

        public void ThemDienUuTienGiaDinh(DataRow m_Row)
        {
            m_DienUuTienGiaDinhData.ThemDienUuTienGiaDinh(m_Row);
        }

        public bool LuuDienUuTienGiaDinh()
        {
            return m_DienUuTienGiaDinhData.LuuDienUuTienGiaDinh();
        }
    }


}


