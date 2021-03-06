using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TinhTrangHonNhanControl
    {
        TinhTrangHonNhanData m_TinhTrangHonNhanData = new TinhTrangHonNhanData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TinhTrangHonNhanData.LayDanhSachTinhTrangHonNhan();
            cmb.DisplayMember = "TenTinhTrangHonNhan";
            cmb.ValueMember = "MaTinhTrangHonNhan";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTinhTrangHonNhan(DataGridViewComboBoxColumn cmbColumnTinhTrangHonNhan)
        {
            cmbColumnTinhTrangHonNhan.DataSource = m_TinhTrangHonNhanData.LayDanhSachTinhTrangHonNhan();
            cmbColumnTinhTrangHonNhan.DisplayMember = "TenTinhTrangHonNhan";
            cmbColumnTinhTrangHonNhan.ValueMember = "MaTinhTrangHonNhan";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TinhTrangHonNhanData.LayDanhSachTinhTrangHonNhan();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTinhTrangHonNhan, TextBox txtTenTinhTrangHonNhan)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TinhTrangHonNhanData.LayDanhSachTinhTrangHonNhan();
            bS.DataSource = tbl;

            txtMaTinhTrangHonNhan.DataBindings.Clear();
            txtMaTinhTrangHonNhan.DataBindings.Add("Text", bS, "MaTinhTrangHonNhan");
            txtTenTinhTrangHonNhan.DataBindings.Clear();
            txtTenTinhTrangHonNhan.DataBindings.Add("Text", bS, "TenTinhTrangHonNhan");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TinhTrangHonNhanData.ThemDongMoi();
        }

        public void ThemTinhTrangHonNhan(DataRow m_Row)
        {
            m_TinhTrangHonNhanData.ThemTinhTrangHonNhan(m_Row);
        }

        public bool LuuTinhTrangHonNhan()
        {
            return m_TinhTrangHonNhanData.LuuTinhTrangHonNhan();
        }
    }


}


