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
    public class QuaTrinhCongTacNuocNgoaiCtrl
    {
        #region data_QuaTrinhCongTacNuocNgoai
        private QuaTrinhCongTacNuocNgoaiData m_data_QuaTrinhCongTacNuocNgoai;
        public QuaTrinhCongTacNuocNgoaiData data_QuaTrinhCongTacNuocNgoai
        {
            get { return m_data_QuaTrinhCongTacNuocNgoai; }
            set { m_data_QuaTrinhCongTacNuocNgoai = value; }
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

        #region HienThi_dsQuaTrinhCongTacNuocNgoai()
        public void HienThi_dsQuaTrinhCongTacNuocNgoai(ListView listView, string manv)
        {
            if (data_QuaTrinhCongTacNuocNgoai == null)
            {
                data_QuaTrinhCongTacNuocNgoai = new QuaTrinhCongTacNuocNgoaiData();
            }
            Table = data_QuaTrinhCongTacNuocNgoai.lay_dsQuaTrinhCongTacNuocNgoai(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                QuaTrinhCongTacNuocNgoaiInfo info = new QuaTrinhCongTacNuocNgoaiInfo();


                info.MaQuaTrinhCongTacNuocNgoai = row["MAQTCTNN"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.TuNgay = (DateTime)row["NGAYBD"];
                info.DenNgay = (DateTime)row["NGAYKT"];
                info.NuocCongTac = row["NUOCCONGTAC"].ToString();
                info.TenCoQuan = row["TENCOQUAN"].ToString();
                info.MucDich = row["MUCDICH"].ToString();


                ListViewItem item = new ListViewItem();

                item.Text = info.MaQuaTrinhCongTacNuocNgoai;
                item.SubItems.Add(info.TuNgay.ToShortDateString());
                item.SubItems.Add(info.DenNgay.ToShortDateString());
                item.SubItems.Add(info.NuocCongTac);
                item.SubItems.Add(info.TenCoQuan);
                item.SubItems.Add(info.MucDich);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaQTCTNN,  TextBox txtNuocCongTac, TextBox txtTenCoQuan, TextBox txtMucDich,DateTimePicker dtTuNgay, DateTimePicker dtDenNgay, QuaTrinhCongTacNuocNgoaiInfo info)
        {

            txtMaQTCTNN.Text = info.MaQuaTrinhCongTacNuocNgoai;
            dtTuNgay.Text = info.TuNgay.ToShortDateString();
            dtDenNgay.Text = info.DenNgay.ToShortDateString();
            txtNuocCongTac.Text = info.NuocCongTac;
            txtTenCoQuan.Text = info.TenCoQuan;
            txtMucDich.Text = info.MucDich;

        }
        #endregion

        #region Add()
        public bool Add(QuaTrinhCongTacNuocNgoaiInfo info)
        {
            DataRow row = Table.NewRow();

            row["MAQTCTNN"] = info.MaQuaTrinhCongTacNuocNgoai;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["NGAYBD"] = info.TuNgay;
            row["NGAYKT"] = info.DenNgay;
            row["NUOCCONGTAC"] = info.NuocCongTac;
            row["TENCOQUAN"] = info.TenCoQuan;
            row["MUCDICH"] = info.MucDich;


            Table.Rows.Add(row);
            if (this.data_QuaTrinhCongTacNuocNgoai.Update())
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

        #region CapNhatQuaTrinhCongTacNuocNgoai()
        public void CapNhatQuaTrinhCongTacNuocNgoai(QuaTrinhCongTacNuocNgoaiInfo info, int index)
        {
            

            this.Table.Rows[index]["NGAYBD"] = info.TuNgay;
            this.Table.Rows[index]["NGAYKT"] = info.DenNgay;
            this.Table.Rows[index]["NUOCCONGTAC"] = info.NuocCongTac;
            this.Table.Rows[index]["TENCOQUAN"] = info.TenCoQuan;
            this.Table.Rows[index]["MUCDICH"] = info.MucDich;


            this.data_QuaTrinhCongTacNuocNgoai.CapNhatQuaTrinhCongTacNuocNgoai(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_QuaTrinhCongTacNuocNgoai.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_QuaTrinhCongTacNuocNgoai.lay_dsQuaTrinhCongTacNuocNgoai();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "CTNN1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("CTNN", t.ToString());
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

        #region Xoa_QuaTrinhCongTacNuocNgoai

        public void Xoa_QuaTrinhCongTacNuocNgoai(String MaQTCTNN)
        {
            if (data_QuaTrinhCongTacNuocNgoai == null)
                data_QuaTrinhCongTacNuocNgoai = new QuaTrinhCongTacNuocNgoaiData();
            data_QuaTrinhCongTacNuocNgoai.Xoa_QuaTrinhCongTacNuocNgoai(MaQTCTNN);
        }
        #endregion

        #region Xoa_QuaTrinhCongTacNuocNgoai_NhanVien

        public void Xoa_QuaTrinhCongTacNuocNgoai_NhanVien(String MaNV)
        {
            if (data_QuaTrinhCongTacNuocNgoai == null)
                data_QuaTrinhCongTacNuocNgoai = new QuaTrinhCongTacNuocNgoaiData();
            data_QuaTrinhCongTacNuocNgoai.Xoa_QuaTrinhCongTacNuocNgoai_NhanVien(MaNV);
        }
        #endregion
    }
}
