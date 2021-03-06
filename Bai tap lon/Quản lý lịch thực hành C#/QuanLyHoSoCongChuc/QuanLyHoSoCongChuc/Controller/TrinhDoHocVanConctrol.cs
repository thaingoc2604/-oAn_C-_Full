using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TrinhDoHocVanControl
    {
        TrinhDoHocVanData m_TrinhDoHocVanData = new TrinhDoHocVanData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TrinhDoHocVanData.LayDsTrinhDoHocVan();
            cmb.DisplayMember = "TenTrinhDoHocVan";
            cmb.ValueMember = "MaTrinhDoHocVan";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTrinhDoHocVan(DataGridViewComboBoxColumn cmbColumnTrinhDoHocVan)
        {
            cmbColumnTrinhDoHocVan.DataSource = m_TrinhDoHocVanData.LayDsTrinhDoHocVan();
            cmbColumnTrinhDoHocVan.DisplayMember = "TenTrinhDoHocVan";
            cmbColumnTrinhDoHocVan.ValueMember = "MaTrinhDoHocVan";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoHocVanData.LayDsTrinhDoHocVan();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTrinhDoHocVan, TextBox txtTenTrinhDoHocVan)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoHocVanData.LayDsTrinhDoHocVan();
            bS.DataSource = tbl;

            txtMaTrinhDoHocVan.DataBindings.Clear();
            txtMaTrinhDoHocVan.DataBindings.Add("Text", bS, "MaTrinhDoHocVan");
            txtTenTrinhDoHocVan.DataBindings.Clear();
            txtTenTrinhDoHocVan.DataBindings.Add("Text", bS, "TenTrinhDoHocVan");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TrinhDoHocVanData.ThemDongMoi();
        }

        public void ThemTrinhDoHocVan(DataRow m_Row)
        {
            m_TrinhDoHocVanData.ThemTrinhDoHocVan(m_Row);
        }

        public bool LuuTrinhDoHocVan()
        {
            return m_TrinhDoHocVanData.LuuTrinhDoHocVan();
        }
    }


}


