using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TrinhDoNgoaiNguControl
    {
        TrinhDoNgoaiNguData m_TrinhDoNgoaiNguData = new TrinhDoNgoaiNguData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TrinhDoNgoaiNguData.LayDsTrinhDoNgoaiNgu();
            cmb.DisplayMember = "TenTrinhDoNgoaiNgu";
            cmb.ValueMember = "MaTrinhDoNgoaiNgu";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTrinhDoNgoaiNgu(DataGridViewComboBoxColumn cmbColumnTrinhDoNgoaiNgu)
        {
            cmbColumnTrinhDoNgoaiNgu.DataSource = m_TrinhDoNgoaiNguData.LayDsTrinhDoNgoaiNgu();
            cmbColumnTrinhDoNgoaiNgu.DisplayMember = "TenTrinhDoNgoaiNgu";
            cmbColumnTrinhDoNgoaiNgu.ValueMember = "MaTrinhDoNgoaiNgu";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoNgoaiNguData.LayDsTrinhDoNgoaiNgu();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTrinhDoNgoaiNgu, TextBox txtTenTrinhDoNgoaiNgu)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoNgoaiNguData.LayDsTrinhDoNgoaiNgu();
            bS.DataSource = tbl;

            txtMaTrinhDoNgoaiNgu.DataBindings.Clear();
            txtMaTrinhDoNgoaiNgu.DataBindings.Add("Text", bS, "MaTrinhDoNgoaiNgu");
            txtTenTrinhDoNgoaiNgu.DataBindings.Clear();
            txtTenTrinhDoNgoaiNgu.DataBindings.Add("Text", bS, "TenTrinhDoNgoaiNgu");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TrinhDoNgoaiNguData.ThemDongMoi();
        }

        public void ThemTrinhDoNgoaiNgu(DataRow m_Row)
        {
            m_TrinhDoNgoaiNguData.ThemTrinhDoNgoaiNgu(m_Row);
        }

        public bool LuuTrinhDoNgoaiNgu()
        {
            return m_TrinhDoNgoaiNguData.LuuTrinhDoNgoaiNgu();
        }
    }


}


