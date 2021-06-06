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
    public class ThaiSanCtrl
    {
        #region data_ThaiSan
        private ThaiSanData m_data_ThaiSan;
        public ThaiSanData data_ThaiSan
        {
            get { return m_data_ThaiSan; }
            set { m_data_ThaiSan = value; }
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

        #region HienThi_dsThaiSan()
        public void HienThi_dsThaiSan(ListView listView,string manv)
        {
            if (data_ThaiSan == null)
            {
                data_ThaiSan = new ThaiSanData();
            }
            Table = data_ThaiSan.lay_dsQuaTrinhThaiSan(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                ThaiSanInfo info = new ThaiSanInfo();

                
                info.MaQuaTrinhThaiSan = row["MAQTTS"].ToString();

                SoQuyetDinhCtrl ctrl = new SoQuyetDinhCtrl();
                info.SoQuyetDinh = ctrl.GetSoQuyetDinh(row["SOQUYETDINH"].ToString());
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.NgayQuyetDinh =(DateTime) row["NGAYQUYETDINH"];
                info.SinhConThuMay = int.Parse(row["SINHCONTHU"].ToString());
                info.NgayBatDau = (DateTime)row["NGAYBD"];
                info.NgayKetThuc = (DateTime)row["NGAYKT"];
                info.NguoiKy = row["NGUOIKY"].ToString();
                info.NoiDung = row["NOIDUNG"].ToString();

                ListViewItem item = new ListViewItem();
               
                item.Text = info.MaQuaTrinhThaiSan;
                item.SubItems.Add(info.SoQuyetDinh.MaSoQuyetDinh);
                item.SubItems.Add(info.NgayQuyetDinh.ToShortDateString());
                item.SubItems.Add(info.SinhConThuMay.ToString());
                item.SubItems.Add(info.NgayBatDau.ToShortDateString());
                item.SubItems.Add(info.NgayKetThuc.ToShortDateString());
                item.SubItems.Add(info.NguoiKy);
                item.SubItems.Add(info.NoiDung);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaTS, ComboBox txtSoQD, DateTimePicker dtNgayQD, TextBox  txtSinhCon, DateTimePicker dtNgayBD, DateTimePicker dtNgayKT, TextBox txtNguoiKy, TextBox txtNoiDung, ThaiSanInfo info)
        {
            
            txtMaTS.Text = info.MaQuaTrinhThaiSan;
            txtSoQD.Text = info.SoQuyetDinh.MaSoQuyetDinh;
            dtNgayQD.Text = info.NgayQuyetDinh.ToShortDateString();
            txtSinhCon.Text = info.SinhConThuMay.ToString();
            dtNgayBD.Text = info.NgayBatDau.ToShortDateString();
            dtNgayKT.Text = info.NgayKetThuc.ToShortDateString();
            txtNguoiKy.Text = info.NguoiKy;
            txtNoiDung.Text = info.NoiDung;

        }
        #endregion

        #region Add()
        public bool Add(ThaiSanInfo info)
        {
            DataRow row = Table.NewRow();
            row["MANHANVIEN"] = info.MaNhanVien;
            row["MAQTTS"] = info.MaQuaTrinhThaiSan;
            row["SOQUYETDINH"] = info.SoQuyetDinh.MaSoQuyetDinh;
            row["NGAYQUYETDINH"] = info.NgayQuyetDinh;
            row["SINHCONTHU"] = info.SinhConThuMay;
            row["NGAYBD"] = info.NgayBatDau;
            row["NGAYKT"] = info.NgayKetThuc;
            row["NGUOIKY"] = info.NguoiKy;
            row["NOIDUNG"] = info.NoiDung;


            Table.Rows.Add(row);
            if (this.data_ThaiSan.Update())
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

        #region CapNhatQTThaiSan()
        public void CapNhatQTThaiSan(ThaiSanInfo info, int index)
        {
            ////this.Table.Rows[index]["MAQT"] = info.MaQuocTich;
           
            this.Table.Rows[index]["SOQUYETDINH"] = info.SoQuyetDinh.MaSoQuyetDinh;
            this.Table.Rows[index]["NGAYQUYETDINH"] = info.NgayQuyetDinh;
            this.Table.Rows[index]["SINHCONTHU"] = info.SinhConThuMay;
            this.Table.Rows[index]["NGAYBD"] = info.NgayBatDau;
            this.Table.Rows[index]["NGAYKT"] = info.NgayKetThuc;
            this.Table.Rows[index]["NGUOIKY"] = info.NguoiKy;
            this.Table.Rows[index]["NOIDUNG"] = info.NoiDung;


            this.data_ThaiSan.CapNhatQTThaiSan(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_ThaiSan.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_ThaiSan.lay_dsThaiSan();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QTTS1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QTTS", t.ToString());
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

        #region Xoa_ThaiSan

        public void Xoa_ThaiSan(String MaTS)
        {
            if (data_ThaiSan == null)
                data_ThaiSan = new ThaiSanData();
            data_ThaiSan.Xoa_ThaiSan(MaTS);
        }
        #endregion

        #region Xoa_ThaiSan_NhanVien

        public void Xoa_ThaiSan_NhanVien(String MaNV)
        {
            if (data_ThaiSan == null)
                data_ThaiSan = new ThaiSanData();
            data_ThaiSan.Xoa_ThaiSan_NhanVien(MaNV);
        }
        #endregion
    }
}
