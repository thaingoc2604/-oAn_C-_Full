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
    public class QuaTrinhHoatDongXaHoiCtrl
    {
        #region data_QTHoatDongXaHoi
        private QuaTrinhHoatDongXaHoiData m_data_QTHoatDongXaHoi;
        public QuaTrinhHoatDongXaHoiData data_QTHoatDongXaHoi
        {
            get { return m_data_QTHoatDongXaHoi; }
            set { m_data_QTHoatDongXaHoi = value; }
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

        #region HienThi_dsQTHoatDongXaHoi()
        public void HienThi_dsQTHoatDongXaHoi(ListView listView,string manv)
        {
            if (data_QTHoatDongXaHoi == null)
            {
                data_QTHoatDongXaHoi = new QuaTrinhHoatDongXaHoiData();
            }
            Table = data_QTHoatDongXaHoi.lay_dsQuaTrinhHoatDongXaHoi(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                QuaTrinhHoatDongXaHoiInfo info = new QuaTrinhHoatDongXaHoiInfo();


                info.MaQTHoatDongXaHoi = row["MAQTHDXH"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.TuNgay = (DateTime)row["NGAYBD"];
                info.DenNgay = (DateTime)row["NGAYKT"];
                info.NoiDung = row["NOIDUNG"].ToString();


                ListViewItem item = new ListViewItem();

                item.Text = info.MaQTHoatDongXaHoi;
                item.SubItems.Add(info.TuNgay.ToShortDateString());
                item.SubItems.Add(info.DenNgay.ToShortDateString());
                item.SubItems.Add(info.NoiDung);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtLSBT, DateTimePicker dtTuNgay, DateTimePicker dtDenNgay, TextBox txtNoiDung, QuaTrinhHoatDongXaHoiInfo info)
        {

            txtLSBT.Text = info.MaQTHoatDongXaHoi;
            dtTuNgay.Text = info.TuNgay.ToShortDateString();
            dtDenNgay.Text = info.DenNgay.ToShortDateString();
            txtNoiDung.Text = info.NoiDung;

        }
        #endregion

        #region Add()
        public bool Add(QuaTrinhHoatDongXaHoiInfo info)
        {
            DataRow row = Table.NewRow();

            row["MAQTHDXH"] = info.MaQTHoatDongXaHoi;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["NGAYBD"] = info.TuNgay;
            row["NGAYKT"] = info.DenNgay;
            row["NOIDUNG"] = info.NoiDung;


            Table.Rows.Add(row);
            if (this.data_QTHoatDongXaHoi.Update())
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

        #region CapNhatQTHoatDongXaHoi()
        public void CapNhatQTHoatDongXaHoi(QuaTrinhHoatDongXaHoiInfo info, int index)
        {
            ////this.Table.Rows[index]["MAQT"] = info.MaQuocTich;

            this.Table.Rows[index]["NGAYBD"] = info.TuNgay;
            this.Table.Rows[index]["NGAYKT"] = info.DenNgay;
            this.Table.Rows[index]["NOIDUNG"] = info.NoiDung;


            this.data_QTHoatDongXaHoi.CapNhatQTHoatDongXaHoi(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_QTHoatDongXaHoi.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_QTHoatDongXaHoi.lay_dsQuaTrinhHoatDongXaHoi();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "HDXH1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("HDXH", t.ToString());
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

        #region Xoa_QuaTrinhHoatDongXaHoi

        public void Xoa_QuaTrinhHoatDongXaHoi(String MaQTHDXH)
        {
            if (data_QTHoatDongXaHoi == null)
                data_QTHoatDongXaHoi = new QuaTrinhHoatDongXaHoiData();
            data_QTHoatDongXaHoi.Xoa_QuaTrinhHoatDongXaHoi(MaQTHDXH);
        }
        #endregion

        #region Xoa_QuaTrinhHoatDongXaHoi_NhanVien

        public void Xoa_QuaTrinhHoatDongXaHoi_NhanVien(String MaNV)
        {
            if (data_QTHoatDongXaHoi == null)
                data_QTHoatDongXaHoi = new QuaTrinhHoatDongXaHoiData();
            data_QTHoatDongXaHoi.Xoa_QuaTrinhHoatDongXaHoi_NhanVien(MaNV);
        }
        #endregion
    }
}
