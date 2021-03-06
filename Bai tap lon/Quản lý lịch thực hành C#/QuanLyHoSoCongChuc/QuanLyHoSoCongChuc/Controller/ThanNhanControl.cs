using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class ThanNhanControl
    {
      
        ThanNhanData m_ThanNhanData = new ThanNhanData();
        NhanVienData m_NhanVienData = new NhanVienData();
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
        ChucVuControl m_ChucVuCtrl = new ChucVuControl();
        QuanHeControl m_QuanHeCtrl = new QuanHeControl();
        public void HienThiComBoBox( ComboBox cmbChucVu, ComboBox cmbQuanHe)
        {
            m_ChucVuCtrl.HienThiComboBox(cmbChucVu);
            m_QuanHeCtrl.HienThiComboBox(cmbQuanHe);
        }
        public void HienThiComboBoxThanNhan(ComboBox cmbMaNhanVien, ComboBox cmbQuanHe)
        {
            m_NhanVienCtrl.HienThiComboBox(cmbMaNhanVien);
            m_QuanHeCtrl.HienThiComboBox(cmbQuanHe);
        }
        public void HienThiThanNhan(DataGridView dGV, BindingNavigator bN, MaskedTextBox txtMaThanNhan, TextBox txtTenThanNhan, ComboBox cmbTenNhanVien, ComboBox cmbTenQuanHe, MaskedTextBox txtNamSinh, TextBox txtDiaChi, TextBox txtNgheNghiep, TextBox txtNuocDinhCu, TextBox txtQuocTich, TextBox txtNamDinhCu)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_ThanNhanData.LayDanhsachThanNhan();
            bS.DataSource = tbl;

            txtMaThanNhan.DataBindings.Clear();
            txtMaThanNhan.DataBindings.Add("Text", bS, "MaThanNhan");
            txtTenThanNhan.DataBindings.Clear();
            txtTenThanNhan.DataBindings.Add("Text", bS, "TenThanNhan");
            cmbTenNhanVien.DataBindings.Clear();
            cmbTenNhanVien.DataBindings.Add("SelectedValue", bS, "MaNhanVien");
            cmbTenQuanHe.DataBindings.Clear();
            cmbTenQuanHe.DataBindings.Add("SelectedValue", bS, "MaQuanHe");
            txtNamSinh.DataBindings.Clear();
            txtNamSinh.DataBindings.Add("Text", bS, "NamSinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");
            txtNgheNghiep.DataBindings.Clear();
            txtNgheNghiep.DataBindings.Add("Text", bS, "NgheNghiep");
            txtNuocDinhCu.DataBindings.Clear();
            txtNuocDinhCu.DataBindings.Add("Text", bS, "NuocDinhCu");
            txtQuocTich.DataBindings.Clear();
            txtQuocTich.DataBindings.Add("Text", bS, "QuocTich");
            txtNamDinhCu.DataBindings.Clear();
            txtNamDinhCu.DataBindings.Add("Text", bS, "NamDinhCu");
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_ThanNhanData.ThemDongMoi();
        }

        public void ThemThanNhan(DataRow m_Row)
        {
            m_ThanNhanData.ThemThanNhan(m_Row);
        }

        public bool LuuThanNhan()
        {
            return m_ThanNhanData.LuuThanNhan();
        }



        public void HienThiListViewNhanVien(ListView lvNhanVien)
        {
            lvNhanVien.Items.Clear();
            DataTable table = m_NhanVienData.LayDanhSachNhanVien();

            int n = 0;
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MaNhanVien"].ToString());
                item.SubItems.Add(row["HoTenNhanVien"].ToString());
                item.SubItems.Add(row["MaChucVu"].ToString());
                
                lvNhanVien.Items.Add(item);
            }
        }

        public void HienThiListViewThanNhan(ListView lvThanNhan, string txtMaNV)
        {
            lvThanNhan.Items.Clear();
            DataTable table = m_ThanNhanData.LayTTThanNhan();
            int n = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row[2].ToString() == txtMaNV)
                {
                    ListViewItem item = new ListViewItem();
                    n++;
                    item.Text = n.ToString();
                    item.SubItems.Add(row["MaQuanHe"].ToString());
                    item.SubItems.Add(row["TenQuanHe"].ToString());
                    item.SubItems.Add(txtMaNV);
                    item.SubItems.Add(row["TenThanNhan"].ToString());
                    item.SubItems.Add(row["DiaChi"].ToString());
                    item.SubItems.Add(row["NgheNghiep"].ToString());
                    item.SubItems.Add(row["NuocDinhCu"].ToString());
                    item.SubItems.Add(row["QuocTich"].ToString());
                    item.SubItems.Add(row["NamDinhCu"].ToString());
                    lvThanNhan.Items.Add(item);
                }
            }
        }      
    }


}


