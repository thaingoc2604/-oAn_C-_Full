using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;
namespace QuanLyTienGuiTietKiem.Controller
{
    public class NhanVienCtrl
    {
        NhanVienData m_NhanVienData = new NhanVienData();
        NhanVienInfo m_NhanVienInfo = new NhanVienInfo();
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_NhanVienData.LayNhanVien();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "HoTen";

            cbx.ValueMember = "MaNV";

           
        }

        public static IList<NhanVienInfo> LayDsNhanVien()
        {
            IList<NhanVienInfo> ds = new List<NhanVienInfo>();

            NhanVienData data = new NhanVienData();
            DataTable tbl = data.LayDSNhanVien();

            IList<NhanVienInfo> NhanVien = new List<NhanVienInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                NhanVienInfo NV = new NhanVienInfo();

                PhongGiaoDichInfo m_PGD = new PhongGiaoDichInfo();
                m_PGD.TenPhongGD = Convert.ToString(row["TenPhong"]);

                NV.MaNV = Convert.ToString(row["MaNV"]);
                NV.HoTen = Convert.ToString(row["HoTen"]);
                NV.DiaChi = Convert.ToString(row["DiaChi"]);
                NV.DienThoai = Convert.ToString(row["DienThoai"]);
                NV.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);

                NV.MaPhongGD = m_PGD;

                NhanVien.Add(NV);
            }
            return NhanVien;
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NhanVienData.LayNhanVien();
            cmbColumn.DisplayMember = "HoTen";
            cmbColumn.ValueMember = "MaNV";
            cmbColumn.DataPropertyName = "MaNV";
            cmbColumn.HeaderText = "Tên nhân viên";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_NhanVienData.LayNhanVien();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaNV,
                            TextBoxX txtHoTen,
                            DateTimeInput dtNgaySinh,
                            TextBoxX txtDiaChi,
                            TextBoxX txtSoDienThoai,
                            ComboBoxEx cmbPhongGiaoDich)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhanVienData.LayNhanVien();

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bS, "MaNV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bS, "HoTen");

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            cmbPhongGiaoDich.DataBindings.Clear();
            cmbPhongGiaoDich.DataBindings.Add("SelectedValue", bS, "MaPhongGiaoDich");


            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_NhanVienData.ThemNhanVien(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuNhanVien()
        {
            return m_NhanVienData.LuuNhanVien();
        }
        #endregion

        #region tim kiem
        public void TimKiemTheoMa(String m_MaNV)
        {
            m_NhanVienData.TimKiemTheoMa(m_MaNV);
        }

        public void TiemKiemTheoTen(String m_HoTen)
        {
            m_NhanVienData.TimKiemTheoTen(m_HoTen);
        }
        #endregion
            
    }
}