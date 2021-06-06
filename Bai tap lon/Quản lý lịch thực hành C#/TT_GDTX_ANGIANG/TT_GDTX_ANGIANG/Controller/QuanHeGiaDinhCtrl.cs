using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace TT_GDTX_ANGIANG.Controller
{
    public class QuanHeGiaDinhCtrl
    {
        #region data_QuanHeGiaDinh
        private QuanHeGiaDinhData m_data_QuanHeGiaDinh;
        public QuanHeGiaDinhData data_QuanHeGiaDinh
        {
            get { return m_data_QuanHeGiaDinh; }
            set { m_data_QuanHeGiaDinh = value; }
        }
        #endregion

        #region Table
        private DataTable m_Table;
        public DataTable Table
        {
            get { return m_Table; }
            set { m_Table = value; }
        }

        #endregion

        #region HienThi_dsQuanHeGiaDinh()
        public void HienThi_dsQuanHeGiaDinh(ListView listView, string manv)
        {
            if (data_QuanHeGiaDinh == null)
            {
                data_QuanHeGiaDinh = new QuanHeGiaDinhData();
            }
            Table = data_QuanHeGiaDinh.lay_dsQHGiaDinh(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                QuanHeGiaDinhInfo info = new QuanHeGiaDinhInfo();

                
                info.MaQuanHeGiaDinh = row["MAQHGD"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.MoiQuanHe = row["MOIQH"].ToString();
                info.HoTen = row["HOTEN"].ToString();
                info.NamSinh = (DateTime)row["NAMSINH"];
                info.QueQuan = row["QUEQUAN"].ToString();
                info.NoiOHienNay = row["NOIOHIENNAY"].ToString();
                info.NgheNghiep = row["NGHENGHIEP"].ToString();
                info.DonViCongTac = row["DONVICONGTAC"].ToString();
                info.ChucVu = row["CHUCVU"].ToString();

                ListViewItem item = new ListViewItem();
                
                item.Text = info.MaQuanHeGiaDinh;
                item.SubItems.Add(info.MoiQuanHe);
                item.SubItems.Add(info.HoTen);
                item.SubItems.Add(info.NamSinh.ToShortDateString());
                item.SubItems.Add(info.QueQuan);
                item.SubItems.Add(info.NoiOHienNay);
                item.SubItems.Add(info.NgheNghiep);
                item.SubItems.Add(info.DonViCongTac);
                item.SubItems.Add(info.ChucVu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaQHGD, TextBox txtMoiQuanHe,TextBox txtHoTen, DateTimePicker dtNamSinh, TextBox txtQueQuan, TextBox txtNoiOHienNay, TextBox txtNgheNghiep, TextBox txtDVCongTac,TextBox txtChucVu, QuanHeGiaDinhInfo info)
        {
           
            txtMaQHGD.Text = info.MaQuanHeGiaDinh;
            txtMoiQuanHe.Text = info.MoiQuanHe;
            txtHoTen.Text = info.HoTen;
            dtNamSinh.Text = info.NamSinh.ToShortDateString();
            txtQueQuan.Text = info.QueQuan;
            txtNoiOHienNay.Text = info.NoiOHienNay;
            txtNgheNghiep.Text = info.NgheNghiep;
            txtDVCongTac.Text = info.DonViCongTac;
            txtChucVu.Text = info.ChucVu;

        }
        #endregion

        #region Add()
        public bool Add(QuanHeGiaDinhInfo info)
        {
            DataRow row = Table.NewRow();           
            row["MAQHGD"] = info.MaQuanHeGiaDinh;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["MOIQH"] = info.MoiQuanHe;
            row["HOTEN"] = info.HoTen;
            row["NAMSINH"] = info.NamSinh;
            row["QUEQUAN"] = info.QueQuan;
            row["NOIOHIENNAY"] = info.NoiOHienNay;
            row["NGHENGHIEP"] = info.NgheNghiep;
            row["DONVICONGTAC"] = info.DonViCongTac;
            row["CHUCVU"] = info.ChucVu;


            Table.Rows.Add(row);
            if (this.data_QuanHeGiaDinh.Update())
            {
                return true;
            }
            else
            {
                Table.Rows.Remove(row);
                return false;
            }
        }
        #endregion

        #region CapNhatQuanHeGiaDinh()
        public void CapNhatQHGiaDinh(QuanHeGiaDinhInfo info, int index)
        {

            this.Table.Rows[index]["MOIQH"] = info.MoiQuanHe;
            this.Table.Rows[index]["NAMSINH"] = info.NamSinh;
            this.Table.Rows[index]["HOTEN"] = info.HoTen;
            this.Table.Rows[index]["QUEQUAN"] = info.QueQuan;
            this.Table.Rows[index]["NOIOHIENNAY"] = info.NoiOHienNay;
            this.Table.Rows[index]["NGHENGHIEP"] = info.NgheNghiep;
            this.Table.Rows[index]["DONVICONGTAC"] = info.DonViCongTac;
            this.Table.Rows[index]["CHUCVU"] = info.ChucVu;


            this.data_QuanHeGiaDinh.CapNhatQHGiaDinh(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            
            this.Table.Rows[index].Delete();

            return this.data_QuanHeGiaDinh.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_QuanHeGiaDinh.lay_dsQuanHeGiaDinh();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QHGD1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QHGD", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaQT.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region Xoa_QuanHeGiaDinh

        public void Xoa_QuanHeGiaDinh(String MaQHGD)
        {
            if (data_QuanHeGiaDinh == null)
                data_QuanHeGiaDinh = new QuanHeGiaDinhData();
            data_QuanHeGiaDinh.Xoa_QuanHeGiaDinh(MaQHGD);
        }
        #endregion

        #region Xoa_QuanHeGiaDinh_NhanVien

        public void Xoa_QuanHeGiaDinh_NhanVien(String MaNV)
        {
            if (data_QuanHeGiaDinh == null)
                data_QuanHeGiaDinh = new QuanHeGiaDinhData();
            data_QuanHeGiaDinh.Xoa_QuanHeGiaDinh_NhanVien(MaNV);
        }
        #endregion
    }
}
