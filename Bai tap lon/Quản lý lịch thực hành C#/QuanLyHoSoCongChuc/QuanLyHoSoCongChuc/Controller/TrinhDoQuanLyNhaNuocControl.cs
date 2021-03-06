using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TrinhDoQuanLyNhaNuocControl
    {
        TrinhDoQuanLyNhaNuocData m_TrinhDoQuanLyNhaNuocData = new TrinhDoQuanLyNhaNuocData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TrinhDoQuanLyNhaNuocData.LayDsTrinhDoQuanLyNhaNuoc();
            cmb.DisplayMember = "TenTrinhDoQuanLyNhaNuoc";
            cmb.ValueMember = "MaTrinhDoQuanLyNhaNuoc";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTrinhDoQuanLyNhaNuoc(DataGridViewComboBoxColumn cmbColumnTrinhDoQuanLyNhaNuoc)
        {
            cmbColumnTrinhDoQuanLyNhaNuoc.DataSource = m_TrinhDoQuanLyNhaNuocData.LayDsTrinhDoQuanLyNhaNuoc();
            cmbColumnTrinhDoQuanLyNhaNuoc.DisplayMember = "TenTrinhDoQuanLyNhaNuoc";
            cmbColumnTrinhDoQuanLyNhaNuoc.ValueMember = "MaTrinhDoQuanLyNhaNuoc";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoQuanLyNhaNuocData.LayDsTrinhDoQuanLyNhaNuoc();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTrinhDoQuanLyNhaNuoc, TextBox txtTenTrinhDoQuanLyNhaNuoc)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoQuanLyNhaNuocData.LayDsTrinhDoQuanLyNhaNuoc();
            bS.DataSource = tbl;

            txtMaTrinhDoQuanLyNhaNuoc.DataBindings.Clear();
            txtMaTrinhDoQuanLyNhaNuoc.DataBindings.Add("Text", bS, "MaTrinhDoQuanLyNhaNuoc");
            txtTenTrinhDoQuanLyNhaNuoc.DataBindings.Clear();
            txtTenTrinhDoQuanLyNhaNuoc.DataBindings.Add("Text", bS, "TenTrinhDoQuanLyNhaNuoc");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TrinhDoQuanLyNhaNuocData.ThemDongMoi();
        }

        public void ThemTrinhDoQuanLyNhaNuoc(DataRow m_Row)
        {
            m_TrinhDoQuanLyNhaNuocData.ThemTrinhDoQuanLyNhaNuoc(m_Row);
        }

        public bool LuuTrinhDoQuanLyNhaNuoc()
        {
            return m_TrinhDoQuanLyNhaNuocData.LuuTrinhDoQuanLyNhaNuoc();
        }
    }


}


