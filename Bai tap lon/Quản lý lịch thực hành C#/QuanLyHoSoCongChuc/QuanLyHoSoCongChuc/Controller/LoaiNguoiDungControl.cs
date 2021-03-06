using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;


namespace Giaodien_QLHSCC.Controller
{
    public class LoaiNguoiDungCtrl
    {
        LoaiNguoiDungData m_LoaiNguoiDungData = new LoaiNguoiDungData();

        public void HienThiComboBox(ComboBox comboBox)
        {
            DataTable m_DT = m_LoaiNguoiDungData.LayDSLoaiNguoiDung();
            comboBox.DataSource = m_DT;
            comboBox.DisplayMember = "TENQUYEN";
            comboBox.ValueMember = "MAQUYEN";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {

            DataTable m_DT = m_LoaiNguoiDungData.LayDSLoaiNguoiDung();

            cmbColumn.DataSource = m_DT;
            cmbColumn.DisplayMember = "TENQUYEN";
            cmbColumn.ValueMember = "MAQUYEN";
            cmbColumn.DataPropertyName = "MAQUYEN";
            cmbColumn.HeaderText = "Loại người dùng";

            return cmbColumn;
        }
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LoaiNguoiDungData.LayDSLoaiNguoiDung();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiNguoiDungData.ThemDongMoi();
        }

        public void ThemLoaiNguoiDung(DataRow m_Row)
        {
            m_LoaiNguoiDungData.ThemLoaiNguoiDung(m_Row);
        }

        public bool LuuLoaiNguoiDung()
        {
            return m_LoaiNguoiDungData.LuuLoaiNguoiDung();
        }
    }
}
