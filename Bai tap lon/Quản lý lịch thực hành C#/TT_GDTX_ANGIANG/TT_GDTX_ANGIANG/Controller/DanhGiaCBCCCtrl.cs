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
    public class DanhGiaCBCCCtrl
    {
        #region data_DanhGiaCBCC
        private DanhGiaCBCCData m_data_DanhGiaCBCC;
        public DanhGiaCBCCData data_DanhGiaCBCC
        {
            get { return m_data_DanhGiaCBCC; }
            set { m_data_DanhGiaCBCC = value; }
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

        #region HienThi_dsDanhGiaCBCC()
        public void HienThi_dsDanhGiaCBCC(ListView listView, string manv)
        {
            if (data_DanhGiaCBCC == null)
            {
                data_DanhGiaCBCC = new DanhGiaCBCCData();
            }
            Table = data_DanhGiaCBCC.lay_dsDanhGiaCBCC(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                DanhGiaCBCCInfo info = new DanhGiaCBCCInfo();


                info.MaDanhGiaCBCC = row["MADG"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.DotDanhGia = row["DOTDG"].ToString();
                info.NgayDanhGia = (DateTime)row["NGAYDG"];
                info.XepLoaiSucKhoe = row["XEPLOAISUCKHOE"].ToString();
                info.XepLoaiDaoDuc = row["XEPLOAIDAODUC"].ToString();
                info.XepLoaiTDChuyenMon = row["XEPLOAITDCHUYENMON"].ToString();
                info.XepLoaiChung = row["XEPLOAICHUNG"].ToString();
                info.NhanXet = row["NHANXET"].ToString();

                ListViewItem item = new ListViewItem();

                item.Text = info.MaDanhGiaCBCC;
                item.SubItems.Add(info.DotDanhGia);
                item.SubItems.Add(info.NgayDanhGia.ToShortDateString());
                item.SubItems.Add(info.XepLoaiSucKhoe);
                item.SubItems.Add(info.XepLoaiDaoDuc);
                item.SubItems.Add(info.XepLoaiTDChuyenMon);
                item.SubItems.Add(info.XepLoaiChung);
                item.SubItems.Add(info.NhanXet);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaTS, TextBox txtDotDanhGia, DateTimePicker dtNgayDanhGia, ComboBox cboSucKhoe, ComboBox cboDaoDuc, ComboBox  cboTrinhDoChuyenMon, ComboBox cboXepLoaiChung, TextBox txtNhanXet, DanhGiaCBCCInfo info)
        {

            txtMaTS.Text = info.MaDanhGiaCBCC;
            txtDotDanhGia.Text = info.DotDanhGia;
            dtNgayDanhGia.Text = info.NgayDanhGia.ToShortDateString();
            cboSucKhoe.Text = info.XepLoaiSucKhoe;
            cboDaoDuc.Text = info.XepLoaiDaoDuc;
            cboTrinhDoChuyenMon.Text = info.XepLoaiTDChuyenMon;
            cboXepLoaiChung.Text = info.XepLoaiChung;
            txtNhanXet.Text = info.NhanXet;

        }
        #endregion

        #region Add()
        public bool Add(DanhGiaCBCCInfo info)
        {
            DataRow row = Table.NewRow();

            row["MADG"] = info.MaDanhGiaCBCC;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["DOTDG"] = info.DotDanhGia;
            row["NGAYDG"] = info.NgayDanhGia;
            row["XEPLOAISUCKHOE"] = info.XepLoaiSucKhoe;
            row["XEPLOAIDAODUC"] = info.XepLoaiDaoDuc;
            row["XEPLOAITDCHUYENMON"] = info.XepLoaiTDChuyenMon;
            row["XEPLOAICHUNG"] = info.XepLoaiChung;
            row["NHANXET"] = info.NhanXet;


            Table.Rows.Add(row);
            if (this.data_DanhGiaCBCC.Update())
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

        #region CapNhatDanhGiaCanBoCongChuc()
        public void CapNhatDanhGiaCanBoCongChuc(DanhGiaCBCCInfo info, int index)
        {
            

            this.Table.Rows[index]["DOTDG"] = info.DotDanhGia;
            this.Table.Rows[index]["NGAYDG"] = info.NgayDanhGia;
            this.Table.Rows[index]["XEPLOAISUCKHOE"] = info.XepLoaiSucKhoe;
            this.Table.Rows[index]["XEPLOAIDAODUC"] = info.XepLoaiDaoDuc;
            this.Table.Rows[index]["XEPLOAITDCHUYENMON"] = info.XepLoaiTDChuyenMon;
            this.Table.Rows[index]["XEPLOAICHUNG"] = info.XepLoaiChung;
            this.Table.Rows[index]["NHANXET"] = info.NhanXet;


            this.data_DanhGiaCBCC.CapNhatDanhGiaCanBoCongChuc(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_DanhGiaCBCC.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_DanhGiaCBCC.lay_dsDanhGiaCBCC();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "DG1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("DG", t.ToString());
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

        #region Xoa_DanhGia_CBCC

        public void Xoa_DanhGia_CBCC(String MaDG)
        {
            if (data_DanhGiaCBCC == null)
                data_DanhGiaCBCC = new DanhGiaCBCCData();
            data_DanhGiaCBCC.Xoa_DanhGia_CBCC(MaDG);
        }
        #endregion

        #region Xoa_DanhGia_CBCC_NhanVien

        public void Xoa_DanhGia_CBCC_NhanVien(String MaNV)
        {
            if (data_DanhGiaCBCC == null)
                data_DanhGiaCBCC = new DanhGiaCBCCData();
            data_DanhGiaCBCC.Xoa_DanhGia_CBCC_NhanVien(MaNV);
        }
        #endregion
    }
}
