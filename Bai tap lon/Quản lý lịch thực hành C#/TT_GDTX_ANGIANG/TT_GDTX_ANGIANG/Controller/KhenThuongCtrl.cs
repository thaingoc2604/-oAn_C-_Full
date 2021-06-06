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
    public class KhenThuongCtrl
    {
        #region data_KhenThuong
        private KhenThuongData m_data_KhenThuong;
        public KhenThuongData data_KhenThuong
        {
            get { return m_data_KhenThuong; }
            set { m_data_KhenThuong = value; }
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

        #region HienThi_dsKhenThuong()
        public void HienThi_dsKhenThuong(ListView listView,string manv )
        {
            if (data_KhenThuong == null)
            {
                data_KhenThuong = new KhenThuongData();
            }
            Table = data_KhenThuong.lay_dsKhenThuong(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                KhenThuongInfo info = new KhenThuongInfo();


                info.MaQuaTrinhKhenThuong = row["MAQTKT"].ToString();
                info.MaNhanVien=row["MANHANVIEN"].ToString();

                SoQuyetDinhCtrl ctrl = new SoQuyetDinhCtrl();
                info.SoQuyetDinh = ctrl.GetSoQuyetDinh(row["SOQUYETDINH"].ToString());

                info.NgayQuyetDinh = (DateTime)row["NGAYQUYETDINH"];
                info.CoQuanKhenThuong = row["COQUANKT"].ToString();
                info.HinhThuc = row["HINHTHUC"].ToString();
                info.LyDo = row["LYDO"].ToString();
                info.NguoiKy = row["NGUOIKY"].ToString();
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();

                item.Text = info.MaQuaTrinhKhenThuong;
                item.SubItems.Add(info.SoQuyetDinh.MaSoQuyetDinh);
                item.SubItems.Add(info.NgayQuyetDinh.ToShortDateString());
                item.SubItems.Add(info.CoQuanKhenThuong);
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
        public void HienThiInfo(TextBox txtMaTS, ComboBox cmBoSoQD, DateTimePicker dtNgayQD, TextBox txtCoQuanKT, TextBox txtHinhThuc, TextBox txtLyDo, TextBox txtNguoiKy, TextBox txtGhiChu, KhenThuongInfo info)
        {

            txtMaTS.Text = info.MaQuaTrinhKhenThuong;
            cmBoSoQD.Text = info.SoQuyetDinh.MaSoQuyetDinh;
            dtNgayQD.Text = info.NgayQuyetDinh.ToShortDateString();
            txtCoQuanKT.Text = info.CoQuanKhenThuong;
            txtHinhThuc.Text = info.HinhThuc;
            txtLyDo.Text = info.LyDo;
            txtNguoiKy.Text = info.NguoiKy;
            txtGhiChu.Text = info.GhiChu;

        }
        #endregion

        #region Add()
        public bool Add(KhenThuongInfo info)
        {
            DataRow row = Table.NewRow();

            row["MAQTKT"] = info.MaQuaTrinhKhenThuong;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["SOQUYETDINH"] = info.SoQuyetDinh.MaSoQuyetDinh;
            row["NGAYQUYETDINH"] = info.NgayQuyetDinh;
            row["COQUANKT"] = info.CoQuanKhenThuong;
            row["HINHTHUC"] = info.HinhThuc;
            row["LYDO"] = info.LyDo;
            row["NGUOIKY"] = info.NguoiKy;
            row["GHICHU"] = info.GhiChu;


            Table.Rows.Add(row);
            if (this.data_KhenThuong.Update())
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

        #region CapNhatQTKhenThuong()
        public void CapNhatQTKhenThuong(KhenThuongInfo info, int index)
        {
            ////this.Table.Rows[index]["MAQT"] = info.MaQuocTich;

            this.Table.Rows[index]["SOQUYETDINH"] = info.SoQuyetDinh.MaSoQuyetDinh;
            this.Table.Rows[index]["NGAYQUYETDINH"] = info.NgayQuyetDinh;
            this.Table.Rows[index]["COQUANKT"] = info.CoQuanKhenThuong;
            this.Table.Rows[index]["HINHTHUC"] = info.HinhThuc;
            this.Table.Rows[index]["LYDO"] = info.LyDo;
            this.Table.Rows[index]["NGUOIKY"] = info.NguoiKy;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;


            this.data_KhenThuong.CapNhatQTKhenThuong(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_KhenThuong.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_KhenThuong.lay_dsKhenThuong();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QTKT1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QTKT", t.ToString());
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

        #region Xoa_QuaTrinhKhenThuongNV

        public void Xoa_QuaTrinhKhenThuongNV(String MaNV)
        {
            if (data_KhenThuong == null)
                data_KhenThuong = new KhenThuongData();
            data_KhenThuong.Xoa_QuaTrinhKhenThuongNV(MaNV);
        }
        #endregion

        #region Xoa_QuaTrinhKhenThuong

        public void Xoa_QuaTrinhKhenThuong(String MaNV)
        {
            if (data_KhenThuong == null)
                data_KhenThuong = new KhenThuongData();
            data_KhenThuong.Xoa_QuaTrinhKhenThuong(MaNV);
        }
        #endregion

        
    }
}
