using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TrinhDoTinHocControl
    {
        TrinhDoTinHocData m_TrinhDoTinHocData = new TrinhDoTinHocData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TrinhDoTinHocData.LayDsTrinhDoTinHoc();
            cmb.DisplayMember = "TenTrinhDoTinHoc";
            cmb.ValueMember = "MaTrinhDoTinHoc";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTrinhDoTinHoc(DataGridViewComboBoxColumn cmbColumnTrinhDoTinHoc)
        {
            cmbColumnTrinhDoTinHoc.DataSource = m_TrinhDoTinHocData.LayDsTrinhDoTinHoc();
            cmbColumnTrinhDoTinHoc.DisplayMember = "TenTrinhDoTinHoc";
            cmbColumnTrinhDoTinHoc.ValueMember = "MaTrinhDoTinHoc";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoTinHocData.LayDsTrinhDoTinHoc();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTrinhDoTinHoc, TextBox txtTenTrinhDoTinHoc)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoTinHocData.LayDsTrinhDoTinHoc();
            bS.DataSource = tbl;

            txtMaTrinhDoTinHoc.DataBindings.Clear();
            txtMaTrinhDoTinHoc.DataBindings.Add("Text", bS, "MaTrinhDoTinHoc");
            txtTenTrinhDoTinHoc.DataBindings.Clear();
            txtTenTrinhDoTinHoc.DataBindings.Add("Text", bS, "TenTrinhDoTinHoc");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TrinhDoTinHocData.ThemDongMoi();
        }

        public void ThemTrinhDoTinHoc(DataRow m_Row)
        {
            m_TrinhDoTinHocData.ThemTrinhDoTinHoc(m_Row);
        }

        public bool LuuTrinhDoTinHoc()
        {
            return m_TrinhDoTinHocData.LuuTrinhDoTinHoc();
        }
    }


}


