using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TrinhDoChuyenMonControl
    {
        TrinhDoChuyenMonData m_TrinhDoChuyenMonData = new TrinhDoChuyenMonData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TrinhDoChuyenMonData.LayDsTrinhDoChuyenMon();
            cmb.DisplayMember = "TenTrinhDoChuyenMon";
            cmb.ValueMember = "MaTrinhDoChuyenMon";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTrinhDoChuyenMon(DataGridViewComboBoxColumn cmbColumnTrinhDoChuyenMon)
        {
            cmbColumnTrinhDoChuyenMon.DataSource = m_TrinhDoChuyenMonData.LayDsTrinhDoChuyenMon();
            cmbColumnTrinhDoChuyenMon.DisplayMember = "TenTrinhDoChuyenMon";
            cmbColumnTrinhDoChuyenMon.ValueMember = "MaTrinhDoChuyenMon";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoChuyenMonData.LayDsTrinhDoChuyenMon();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTrinhDoChuyenMon, TextBox txtTenTrinhDoChuyenMon)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoChuyenMonData.LayDsTrinhDoChuyenMon();
            bS.DataSource = tbl;

            txtMaTrinhDoChuyenMon.DataBindings.Clear();
            txtMaTrinhDoChuyenMon.DataBindings.Add("Text", bS, "MaTrinhDoChuyenMon");
            txtTenTrinhDoChuyenMon.DataBindings.Clear();
            txtTenTrinhDoChuyenMon.DataBindings.Add("Text", bS, "TenTrinhDoChuyenMon");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TrinhDoChuyenMonData.ThemDongMoi();
        }

        public void ThemTrinhDoChuyenMon(DataRow m_Row)
        {
            m_TrinhDoChuyenMonData.ThemTrinhDoChuyenMon(m_Row);
        }

        public bool LuuTrinhDoChuyenMon()
        {
            return m_TrinhDoChuyenMonData.LuuTrinhDoChuyenMon();
        }
    }


}


