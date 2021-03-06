using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class DanTocControl
    {
        DanTocData m_DanTocData = new DanTocData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_DanTocData.LayDsDanToc();
            cmb.DisplayMember = "TenDanToc";
            cmb.ValueMember = "MaDanToc";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnDanToc(DataGridViewComboBoxColumn cmbColumnDanToc)
        {
            cmbColumnDanToc.DataSource = m_DanTocData.LayDsDanToc();
            cmbColumnDanToc.DisplayMember = "TenDanToc";
            cmbColumnDanToc.ValueMember = "MaDanToc";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_DanTocData.LayDsDanToc();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaDanToc, TextBox txtTenDanToc)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_DanTocData.LayDsDanToc();
            bS.DataSource = tbl;

            txtMaDanToc.DataBindings.Clear();
            txtMaDanToc.DataBindings.Add("Text", bS, "MaDanToc");
            txtTenDanToc.DataBindings.Clear();
            txtTenDanToc.DataBindings.Add("Text", bS, "TenDanToc");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_DanTocData.ThemDongMoi();
        }

        public void ThemDanToc(DataRow m_Row)
        {
            m_DanTocData.ThemDanToc(m_Row);
        }

        public bool LuuDanToc()
        {
            return m_DanTocData.LuuDanToc();
        }
    }


}


