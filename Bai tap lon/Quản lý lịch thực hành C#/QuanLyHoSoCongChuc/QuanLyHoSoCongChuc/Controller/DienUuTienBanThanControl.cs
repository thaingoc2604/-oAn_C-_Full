using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class DienUuTienBanThanControl
    {
        DienUuTienBanThanData m_DienUuTienBanThanData = new DienUuTienBanThanData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_DienUuTienBanThanData.LayDsDienUuTienBanThan();
            cmb.DisplayMember = "TenDienUuTienBanThan";
            cmb.ValueMember = "MaDienUuTienBanThan";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnDienUuTienBanThan(DataGridViewComboBoxColumn cmbColumnDienUuTienBanThan)
        {
            cmbColumnDienUuTienBanThan.DataSource = m_DienUuTienBanThanData.LayDsDienUuTienBanThan();
            cmbColumnDienUuTienBanThan.DisplayMember = "TenDienUuTienBanThan";
            cmbColumnDienUuTienBanThan.ValueMember = "MaDienUuTienBanThan";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_DienUuTienBanThanData.LayDsDienUuTienBanThan();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaDienUuTienBanThan, TextBox txtTenDienUuTienBanThan)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_DienUuTienBanThanData.LayDsDienUuTienBanThan();
            bS.DataSource = tbl;

            txtMaDienUuTienBanThan.DataBindings.Clear();
            txtMaDienUuTienBanThan.DataBindings.Add("Text", bS, "MaDienUuTienBanThan");
            txtTenDienUuTienBanThan.DataBindings.Clear();
            txtTenDienUuTienBanThan.DataBindings.Add("Text", bS, "TenDienUuTienBanThan");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_DienUuTienBanThanData.ThemDongMoi();
        }

        public void ThemDienUuTienBanThan(DataRow m_Row)
        {
            m_DienUuTienBanThanData.ThemDienUuTienBanThan(m_Row);
        }

        public bool LuuDienUuTienBanThan()
        {
            return m_DienUuTienBanThanData.LuuDienUuTienBanThan();
        }
    }


}


