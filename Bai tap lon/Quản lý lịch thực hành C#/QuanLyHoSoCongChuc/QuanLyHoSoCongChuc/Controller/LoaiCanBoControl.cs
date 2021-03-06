using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class LoaiCanBoControl
    {
        LoaiCanBoData m_LoaiCanBoData = new LoaiCanBoData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_LoaiCanBoData.LayDsLoaiCanBo();
            cmb.DisplayMember = "TenLoaiCanBo";
            cmb.ValueMember = "MaLoaiCanBo";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnLoaiCanBo(DataGridViewComboBoxColumn cmbColumnLoaiCanBo)
        {
            cmbColumnLoaiCanBo.DataSource = m_LoaiCanBoData.LayDsLoaiCanBo();
            cmbColumnLoaiCanBo.DisplayMember = "TenLoaiCanBo";
            cmbColumnLoaiCanBo.ValueMember = "MaLoaiCanBo";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_LoaiCanBoData.LayDsLoaiCanBo();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaLoaiCanBo, TextBox txtTenLoaiCanBo)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_LoaiCanBoData.LayDsLoaiCanBo();
            bS.DataSource = tbl;

            txtMaLoaiCanBo.DataBindings.Clear();
            txtMaLoaiCanBo.DataBindings.Add("Text", bS, "MaLoaiCanBo");
            txtTenLoaiCanBo.DataBindings.Clear();
            txtTenLoaiCanBo.DataBindings.Add("Text", bS, "TenLoaiCanBo");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_LoaiCanBoData.ThemDongMoi();
        }

        public void ThemLoaiCanBo(DataRow m_Row)
        {
            m_LoaiCanBoData.ThemLoaiCanBo(m_Row);
        }

        public bool LuuLoaiCanBo()
        {
            return m_LoaiCanBoData.LuuLoaiCanBo();
        }
    }


}


