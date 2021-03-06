using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class NgachCongChucControl
    {
        NgachCongChucData m_NgachCongChucData = new NgachCongChucData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_NgachCongChucData.LayDsNgachCongChuc();
            cmb.DisplayMember = "TenNgachCongChuc";
            cmb.ValueMember = "MaNgachCongChuc";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnNgachCongChuc(DataGridViewComboBoxColumn cmbColumnNgachCongChuc)
        {
            cmbColumnNgachCongChuc.DataSource = m_NgachCongChucData.LayDsNgachCongChuc();
            cmbColumnNgachCongChuc.DisplayMember = "TenNgachCongChuc";
            cmbColumnNgachCongChuc.ValueMember = "MaNgachCongChuc";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_NgachCongChucData.LayDsNgachCongChuc();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaNgachCongChuc, TextBox txtTenNgachCongChuc)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_NgachCongChucData.LayDsNgachCongChuc();
            bS.DataSource = tbl;

            txtMaNgachCongChuc.DataBindings.Clear();
            txtMaNgachCongChuc.DataBindings.Add("Text", bS, "MaNgachCongChuc");
            txtTenNgachCongChuc.DataBindings.Clear();
            txtTenNgachCongChuc.DataBindings.Add("Text", bS, "TenNgachCongChuc");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_NgachCongChucData.ThemDongMoi();
        }

        public void ThemNgachCongChuc(DataRow m_Row)
        {
            m_NgachCongChucData.ThemNgachCongChuc(m_Row);
        }

        public bool LuuNgachCongChuc()
        {
            return m_NgachCongChucData.LuuNgachCongChuc();
        }
    }


}


