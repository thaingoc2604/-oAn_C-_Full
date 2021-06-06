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
    public class KyLuatCtrl
    {
        #region data_KyLuat
        private KyLuatData m_data_KyLuat;
        public KyLuatData data_KyLuat
        {
            get { return m_data_KyLuat; }
            set { m_data_KyLuat = value; }
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

        #region HienThi_dsKyLuat()
        public void HienThi_dsKyLuat(ListView listView, string manv)
        {
            if (data_KyLuat == null)
            {
                data_KyLuat = new KyLuatData();
            }
            Table = data_KyLuat.lay_dsKyLuat(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                KyLuatInfo info = new KyLuatInfo();


                info.MaQuaTrinhKyLuat = row["MAQTKL"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();

                SoQuyetDinhCtrl ctrl = new SoQuyetDinhCtrl();
                info.SoQuyetDinh = ctrl.GetSoQuyetDinh(row["SOQUYETDINH"].ToString());

                info.NgayQuyetDinh = (DateTime)row["NGAYKL"];
                info.CoQuanKyLuat = row["COQUANKL"].ToString();
                info.HinhThuc = row["HINHTHUCKL"].ToString();
                info.LyDo = row["LYDOKL"].ToString();
                info.NguoiKy = row["NGUOIKY"].ToString();
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();

                item.Text = info.MaQuaTrinhKyLuat;
                item.SubItems.Add(info.SoQuyetDinh.MaSoQuyetDinh);
                item.SubItems.Add(info.NgayQuyetDinh.ToShortDateString());
                item.SubItems.Add(info.CoQuanKyLuat);
                item.SubItems.Add(info.HinhThuc);
                item.SubItems.Add(info.LyDo);
                item.SubItems.Add(info.NguoiKy);
                item.SubItems.Add(info.GhiChu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaTS, ComboBox cmBoSoQD, DateTimePicker dtNgayQD, TextBox txtCoQuanKT, TextBox txtHinhThuc, TextBox txtLyDo, TextBox txtNguoiKy, TextBox txtGhiChu, KyLuatInfo info)
        {

            txtMaTS.Text = info.MaQuaTrinhKyLuat;
            cmBoSoQD.Text = info.SoQuyetDinh.MaSoQuyetDinh;
            dtNgayQD.Text = info.NgayQuyetDinh.ToShortDateString();
            txtCoQuanKT.Text = info.CoQuanKyLuat;
            txtHinhThuc.Text = info.HinhThuc;
            txtLyDo.Text = info.LyDo;
            txtNguoiKy.Text = info.NguoiKy;
            txtGhiChu.Text = info.GhiChu;

        }
        #endregion

        #region Add()
        public bool Add(KyLuatInfo info)
        {
            DataRow row = Table.NewRow();

            row["MAQTKL"] = info.MaQuaTrinhKyLuat;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["SOQUYETDINH"] = info.SoQuyetDinh.MaSoQuyetDinh;
            row["NGAYKL"] = info.NgayQuyetDinh;
            row["COQUANKL"] = info.CoQuanKyLuat;
            row["HINHTHUCKL"] = info.HinhThuc;
            row["LYDOKL"] = info.LyDo;
            row["NGUOIKY"] = info.NguoiKy;
            row["GHICHU"] = info.GhiChu;


            Table.Rows.Add(row);
            if (this.data_KyLuat.Update())
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

        #region CapNhatQTKyLuat()
        public void CapNhatQTKyLuat(KyLuatInfo info, int index)
        {
           

            this.Table.Rows[index]["SOQUYETDINH"] = info.SoQuyetDinh.MaSoQuyetDinh;
            this.Table.Rows[index]["NGAYKL"] = info.NgayQuyetDinh;
            this.Table.Rows[index]["COQUANKL"] = info.CoQuanKyLuat;
            this.Table.Rows[index]["HINHTHUCKL"] = info.HinhThuc;
            this.Table.Rows[index]["LYDOKL"] = info.LyDo;
            this.Table.Rows[index]["NGUOIKY"] = info.NguoiKy;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;


            this.data_KyLuat.CapNhatQTKyLuat(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_KyLuat.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_KyLuat.lay_dsKyLuat();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QTKL1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QTKL", t.ToString());
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

        #region Xoa_KyLuat

        public void Xoa_KyLuat(String maKL)
        {
            if (data_KyLuat == null)
                data_KyLuat = new KyLuatData();
            data_KyLuat.Xoa_KyLuat(maKL);
        }
        #endregion

        #region Xoa_KyLuat_NhanVien

        public void Xoa_KyLuat_NhanVien(String maNV)
        {
            if (data_KyLuat == null)
                data_KyLuat = new KyLuatData();
            data_KyLuat.Xoa_KyLuat_NhanVien(maNV);
        }
        #endregion

       
    }
}
