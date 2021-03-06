using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class LoaiNghiBaoHiemXaHoiControl
    {
        LoaiNghiBaoHiemXaHoiData m_LoaiNghiBaoHiemXaHoiData = new LoaiNghiBaoHiemXaHoiData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_LoaiNghiBaoHiemXaHoiData.LayDanhSachLoaiNghiBaoHiemXaHoi();
            cmb.DisplayMember = "TenLoaiNghiBaoHiemXaHoi";
            cmb.ValueMember = "MaLoaiNghiBaoHiemXaHoi";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnLoaiNghiBaoHiemXaHoi(DataGridViewComboBoxColumn cmbColumnLoaiNghiBaoHiemXaHoi)
        {
            cmbColumnLoaiNghiBaoHiemXaHoi.DataSource = m_LoaiNghiBaoHiemXaHoiData.LayDanhSachLoaiNghiBaoHiemXaHoi();
            cmbColumnLoaiNghiBaoHiemXaHoi.DisplayMember = "TenLoaiNghiBaoHiemXaHoi";
            cmbColumnLoaiNghiBaoHiemXaHoi.ValueMember = "MaLoaiNghiBaoHiemXaHoi";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_LoaiNghiBaoHiemXaHoiData.LayDanhSachLoaiNghiBaoHiemXaHoi();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaLoaiNghiBaoHiemXaHoi, TextBox txtTenLoaiNghiBaoHiemXaHoi)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_LoaiNghiBaoHiemXaHoiData.LayDanhSachLoaiNghiBaoHiemXaHoi();
            bS.DataSource = tbl;

            txtMaLoaiNghiBaoHiemXaHoi.DataBindings.Clear();
            txtMaLoaiNghiBaoHiemXaHoi.DataBindings.Add("Text", bS, "MaLoaiNghiBaoHiemXaHoi");
            txtTenLoaiNghiBaoHiemXaHoi.DataBindings.Clear();
            txtTenLoaiNghiBaoHiemXaHoi.DataBindings.Add("Text", bS, "TenLoaiNghiBaoHiemXaHoi");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_LoaiNghiBaoHiemXaHoiData.ThemDongMoi();
        }

        public void ThemLoaiNghiBaoHiemXaHoi(DataRow m_Row)
        {
            //m_ChucVuData.ThemChucVu(m_Row);
            m_LoaiNghiBaoHiemXaHoiData.ThemLoaiNghiBaoHiemXaHoi(m_Row);
        }

        public bool LuuLoaiNghiBaoHiemXaHoi()
        {
            return m_LoaiNghiBaoHiemXaHoiData.LuuLoaiNghiBaoHiemXaHoi();

        }
    }


}


