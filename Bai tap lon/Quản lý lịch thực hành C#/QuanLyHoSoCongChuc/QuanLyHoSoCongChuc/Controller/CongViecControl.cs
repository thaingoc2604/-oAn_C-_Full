using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class CongViecControl
    {
        CongViecData m_CongViecData = new CongViecData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_CongViecData.LayDsCongViec();
            cmb.DisplayMember = "TenCongViec";
            cmb.ValueMember = "MaCongViec";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnCongViec(DataGridViewComboBoxColumn cmbColumnCongViec)
        {
            cmbColumnCongViec.DataSource = m_CongViecData.LayDsCongViec();
            cmbColumnCongViec.DisplayMember = "TenCongViec";
            cmbColumnCongViec.ValueMember = "MaCongViec";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_CongViecData.LayDsCongViec();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaCongViec, TextBox txtTenCongViec)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_CongViecData.LayDsCongViec();
            bS.DataSource = tbl;

            txtMaCongViec.DataBindings.Clear();
            txtMaCongViec.DataBindings.Add("Text", bS, "MaCongViec");
            txtTenCongViec.DataBindings.Clear();
            txtTenCongViec.DataBindings.Add("Text", bS, "TenCongViec");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_CongViecData.ThemDongMoi();
        }

        public void ThemCongViec(DataRow m_Row)
        {
            m_CongViecData.ThemCongViec(m_Row);
        }

        public bool LuuCongViec()
        {
            return m_CongViecData.LuuCongViec();
        }
    }


}


