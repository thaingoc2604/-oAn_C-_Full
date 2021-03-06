using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Controller
{
    public class PhatSinhTietKiemCtrl
    {
        PhatSinhTietKiemData m_PhatSinhTietKiemData = new PhatSinhTietKiemData();
        QuyDinh m_QuyDinh = new QuyDinh();


        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = new DataTable();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "DaDuyet";
            cbx.ValueMember = "SoButToan";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_PhatSinhTietKiemData.LayPhatSinhTietKiem();
            cmbColumn.DisplayMember = "DaDuyet";
            cmbColumn.ValueMember = "SoButToan";
            cmbColumn.DataPropertyName = "SoButToan";
            cmbColumn.HeaderText = "Số bút toán";
        }
        #endregion

        #region Hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_PhatSinhTietKiemData.LayPhatSinhTietKiem();

            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public String LayPSTKTheoButToan()
        {
            String SoButToan = "";    
            PhatSinhTietKiemData data = new PhatSinhTietKiemData();
            DataTable tbl = data.LayPhatSinhTietKiem();
            foreach (DataRow row in tbl.Rows)
            {
                String chuoi = row["SoButToan"].ToString();
                string so = chuoi.Substring(2, 6);
                int MaSo = Convert.ToInt32(so);
                SoButToan = "BT" + (m_QuyDinh.LaySTT(MaSo + 1)); 
            }
            return SoButToan;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaSoTK,
                            TextBoxX txtSoButToan,
                            DateTimeInput dtNgayGiaoDich,
                            TextBoxX txtDaDuyet,
                            CheckBoxX cbDaDuyet,
                            CheckBoxX cbChuaDuyet,
                            
                            ComboBoxEx cmbLoaiGiaoDich,
                            ComboBoxEx cmbNhanVien,
                            ComboBoxEx cmbQuayGD,
                            ComboBoxEx cmbPhongGiaoDich)

                            
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_PhatSinhTietKiemData.LayPhatSinhTietKiem();

            DataTable dT = m_PhatSinhTietKiemData.LayPhatSinhTietKiem();
            bool duyet = Convert.ToBoolean(dT.Rows[0]["DaDuyet"]);

            if (duyet)
                cbDaDuyet.Checked = true;
            else
                cbChuaDuyet.Checked = true;

            txtMaSoTK.DataBindings.Clear();
            txtMaSoTK.DataBindings.Add("Text", bS, "MaSoTietKiem");

            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bS, "SoButToan");

            dtNgayGiaoDich.DataBindings.Clear();
            dtNgayGiaoDich.DataBindings.Add("Value", bS, "NgayGiaoDich");

            txtDaDuyet.DataBindings.Clear();
            txtDaDuyet.DataBindings.Add("Text", bS, "DaDuyet");

            //cmbLoaiGiaoDich.DataBindings.Clear();
            //cmbLoaiGiaoDich.DataBindings.Add("SelectedValue", bS, "MaLoaiGiaoDich");

            //cmbLoaiGiaoDich.DataBindings.Clear();
            //cmbLoaiGiaoDich.DataBindings.Add("SelectedValue", bS, "MaLoaiGiaoDich");

            cmbNhanVien.DataBindings.Clear();
            cmbNhanVien.DataBindings.Add("SelectedValue", bS, "MaNV");

            cmbPhongGiaoDich.DataBindings.Clear();
            cmbPhongGiaoDich.DataBindings.Add("SelectedValue", bS, "MaPhongGiaoDich");

            cmbQuayGD.DataBindings.Clear();
            cmbQuayGD.DataBindings.Add("SelectedValue", bS, "MaQuayGiaoDich");



            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_PhatSinhTietKiemData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_PhatSinhTietKiemData.ThemPhatSinhTietKiem(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuPhatSinhTietKiem()
        {
            return m_PhatSinhTietKiemData.LuuPhatSinhTietKiem();
        }

        public void LuuPSTK(String SoButToan, DateTime NgayGiaoDich, Boolean DaDuyet, String MaSoTietKiem, String LoaiGiaoDich, String MaQuayGD, String MaPhongGD, String MaNV)
        {
            m_PhatSinhTietKiemData.LuuPSTK(SoButToan, NgayGiaoDich, DaDuyet, MaSoTietKiem, LoaiGiaoDich, MaQuayGD, MaPhongGD, MaNV);
        }
        #endregion 

        #region Xoa
        public void XoaPSTK(String SoButToan, DateTime NgayGiaoDich, Boolean DaDuyet, String MaSoTietKiem, String LoaiGiaoDich, String MaQuayGD, String MaPhongGD, String MaNV)
        {
            m_PhatSinhTietKiemData.XoaPSTK(SoButToan, NgayGiaoDich, DaDuyet, MaSoTietKiem, LoaiGiaoDich, MaQuayGD, MaPhongGD, MaNV);
        }
        #endregion 

        #region Tim kiem
        public void TimKiemTheoMa(String m_MaPS)
        {
            m_PhatSinhTietKiemData.LayMaPS(m_MaPS);
        }

        public void TimKiemTheoTen(String m_TenPS)
        {
            m_PhatSinhTietKiemData.LayTenPS(m_TenPS);
        }

        #endregion
    }
}
