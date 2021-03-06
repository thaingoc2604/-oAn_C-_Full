using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class HinhThucTuyenDungControl
    {
        HinhThucTuyenDungData m_HinhThucTuyenDungData = new HinhThucTuyenDungData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_HinhThucTuyenDungData.LayDsHinhThucTuyenDung();
            cmb.DisplayMember = "TenHinhThucTuyenDung";
            cmb.ValueMember = "MaHinhThucTuyenDung";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnHinhThucTuyenDung(DataGridViewComboBoxColumn cmbColumnHinhThucTuyenDung)
        {
            cmbColumnHinhThucTuyenDung.DataSource = m_HinhThucTuyenDungData.LayDsHinhThucTuyenDung();
            cmbColumnHinhThucTuyenDung.DisplayMember = "TenHinhThucTuyenDung";
            cmbColumnHinhThucTuyenDung.ValueMember = "MaHinhThucTuyenDung";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_HinhThucTuyenDungData.LayDsHinhThucTuyenDung();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaHinhThucTuyenDung, TextBox txtTenHinhThucTuyenDung)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_HinhThucTuyenDungData.LayDsHinhThucTuyenDung();
            bS.DataSource = tbl;

            txtMaHinhThucTuyenDung.DataBindings.Clear();
            txtMaHinhThucTuyenDung.DataBindings.Add("Text", bS, "MaHinhThucTuyenDung");
            txtTenHinhThucTuyenDung.DataBindings.Clear();
            txtTenHinhThucTuyenDung.DataBindings.Add("Text", bS, "TenHinhThucTuyenDung");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_HinhThucTuyenDungData.ThemDongMoi();
        }

        public void ThemHinhThucTuyenDung(DataRow m_Row)
        {
            m_HinhThucTuyenDungData.ThemHinhThucTuyenDung(m_Row);
        }

        public bool LuuHinhThucTuyenDung()
        {
            return m_HinhThucTuyenDungData.LuuHinhThucTuyenDung();
        }
    }


}


