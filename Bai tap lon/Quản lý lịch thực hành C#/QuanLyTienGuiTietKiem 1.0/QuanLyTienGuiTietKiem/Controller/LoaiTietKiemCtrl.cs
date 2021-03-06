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
    public class LoaiTietKiemCtrl
    {
        LoaiTietKiemData m_LoaiTietKiemData = new LoaiTietKiemData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_LoaiTietKiemData.LayLoaiTietKiem();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenLoaiTietKiem";
            cbx.ValueMember = "MaLoaiTietKiem";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiTietKiemData.LayLoaiTietKiem();
            cmbColumn.DisplayMember = "TenLoaiTietKiem";
            cmbColumn.ValueMember = "MaLoaiTietKiem";
            cmbColumn.DataPropertyName = "MaLoaiTietKiem";
            cmbColumn.HeaderText = "Tên loại tiết kiệm";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_LoaiTietKiemData.LayLoaiTietKiem();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi (DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaLoaiTietKiem,
                            TextBoxX txtTenLoaiTietKiem,
                            TextBoxX txtKyHan,
                            TextBoxX txtDangHuyDong,
                            CheckBoxX cbHuyDong,
                            ComboBoxEx cmbLoaiTien,
                            ComboBoxEx cmbKyTinhLai,
                            ComboBoxEx cmbSoHieuTaiKhoan)
                         
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_LoaiTietKiemData.LayLoaiTietKiem();

            DataTable dT = m_LoaiTietKiemData.LayLoaiTietKiem();
            bool loaitietkiem = Convert.ToBoolean(dT.Rows[0]["DangHuyDong"]);

            if (loaitietkiem)
                cbHuyDong.Checked = true;
            else
                cbHuyDong.Checked = true;

            txtMaLoaiTietKiem.DataBindings.Clear();
            txtMaLoaiTietKiem.DataBindings.Add("Text", bS, "MaLoaiTietKiem");

            txtTenLoaiTietKiem.DataBindings.Clear();
            txtTenLoaiTietKiem.DataBindings.Add("Text", bS, "TenLoaiTietKiem");

            txtKyHan.DataBindings.Clear();
            txtKyHan.DataBindings.Add("Text", bS, "KyHan");

            txtDangHuyDong.DataBindings.Clear();
            txtDangHuyDong.DataBindings.Add("Text", bS, "DangHuyDong");

            cmbLoaiTien.DataBindings.Clear();
            cmbLoaiTien.DataBindings.Add("SelectedValue", bS, "MaLoaiTien");

            cmbKyTinhLai.DataBindings.Clear();
            cmbKyTinhLai.DataBindings.Add("SelectedValue", bS, "MaKyTinhLai");

            cmbSoHieuTaiKhoan.DataBindings.Clear();
            cmbSoHieuTaiKhoan.DataBindings.Add("SelectedValue", bS, "SoHieuTaiKhoan");

        
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_LoaiTietKiemData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_LoaiTietKiemData.ThemLoaiTietKiem(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuLoaiTietKiem()
        {
            return m_LoaiTietKiemData.LuuLoaiTietKiem();
        }
        public void LuuLoaiTietKiem(String maloaitk, String tenloaitk, int kyhan, bool danghuydong, String maloaitien, String makytinhlai, String sohieutaikhoan)
        {
            m_LoaiTietKiemData.LuuLoaiTietKiem(maloaitk, tenloaitk, kyhan, danghuydong, maloaitien, makytinhlai, sohieutaikhoan);
        }
        #endregion 

        public LoaiTietKiemInfo LayLoaiTK(String idMaLoaiTK)
        {
            LoaiTietKiemData ltk = new LoaiTietKiemData();
            DataTable tbl = ltk.LayLoaiTietKiem(idMaLoaiTK);
            LoaiTietKiemInfo tk = null;
            LoaiTietKiemCtrl ctrlltk = new LoaiTietKiemCtrl();
            DMTaiKhoanCtrl ctrldmtk = new DMTaiKhoanCtrl();
            if (tbl.Rows.Count > 0)
            {
                tk = new LoaiTietKiemInfo();
                tk.MaLoaiTietKiem = Convert.ToString(tbl.Rows[0]["MaLoaiTietKiem"]);
                tk.TenLoaiTietKiem = Convert.ToString(tbl.Rows[0]["TenLoaiTietKiem"]);
                tk.KyHan = Convert.ToInt32(tbl.Rows[0]["KyHan"]);
                tk.DangHuuDong = Convert.ToBoolean(tbl.Rows[0]["DangHuyDong"]);
            }
            return tk;
        }
        #region Tim kiem
        public void TimKiemTheoMa(String m_MaNV)
        {
            m_LoaiTietKiemData.TimKiemTheoMa(m_MaNV);
        }

        public void TiemKiemTheoTen(String m_HoTen)
        {
            m_LoaiTietKiemData.TimKiemTheoTen(m_HoTen);
        }
        #endregion
    }
}
