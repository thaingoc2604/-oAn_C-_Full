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
    public class QuaTrinhCongTacCtrl
    {
        #region data_QuaTrinhCongTac
        private QuaTrinhCongTacData m_dataQuaTrinhCongTac;
        public QuaTrinhCongTacData data_QuaTrinhCongTac
        {
            get { return m_dataQuaTrinhCongTac; }
            set { m_dataQuaTrinhCongTac = value; }
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

        #region HienThi_dsQuaTrinhCongTac()
        public void HienThi_dsQuaTrinhCongTac(ListView listView, string manv)
        {
            if (data_QuaTrinhCongTac == null)
            {
                data_QuaTrinhCongTac = new QuaTrinhCongTacData();
            }
            Table = data_QuaTrinhCongTac.lay_dsQuaTrinhCongTac(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                QuaTrinhCongTacInfo info = new QuaTrinhCongTacInfo();

               
                info.MaQuaTrinhCongTac = row["MAQTCT"].ToString();
                info.MaNhanVien = row["MANHANVIEN"].ToString();
                info.TuNgay = (DateTime)row["NGAYBD"];
                info.DenNgay = (DateTime)row["NGAYKT"];
                info.NoiCongTac = row["NOICT"].ToString();
                info.ChucDanh = row["CHUCDANH"].ToString();
                info.ChucVuCaoNhat = row["CHUCVUCAONHAT"].ToString();
               

                ListViewItem item = new ListViewItem();
                
                item.Text = info.MaQuaTrinhCongTac;
                item.SubItems.Add(info.TuNgay.ToShortDateString());
                item.SubItems.Add(info.DenNgay.ToShortDateString());
                item.SubItems.Add(info.NoiCongTac);
                item.SubItems.Add(info.ChucDanh);
                item.SubItems.Add(info.ChucVuCaoNhat);                
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaQTCT, DateTimePicker dtTuNgay, DateTimePicker dtDenNgay, TextBox txtNoiCongTac, TextBox txtChucDanh, TextBox txtChucVuCaoNhat, QuaTrinhCongTacInfo info)
        {
           
            txtMaQTCT.Text = info.MaQuaTrinhCongTac;
            dtTuNgay.Text = info.TuNgay.ToShortDateString();
            dtDenNgay .Text = info.DenNgay.ToShortDateString();
            txtNoiCongTac.Text = info.NoiCongTac;
            txtChucDanh.Text = info.ChucDanh;
            txtChucVuCaoNhat.Text = info.ChucVuCaoNhat;
           
        }
        #endregion

        #region Add()
        public bool Add(QuaTrinhCongTacInfo info)
        {
            DataRow row = Table.NewRow();
           
            row["MAQTCT"] = info.MaQuaTrinhCongTac;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["NGAYBD"] = info.TuNgay;
            row["NGAYKT"] = info.DenNgay;
            row["NOICT"] = info.NoiCongTac;
            row["CHUCDANH"] = info.ChucDanh;
            row["CHUCVUCAONHAT"] = info.ChucVuCaoNhat;
           

            Table.Rows.Add(row);
            if (this.data_QuaTrinhCongTac.Update())
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

        #region CapNhatQTCongTac()
        public void CapNhatQTCongTac(QuaTrinhCongTacInfo info, int index)
        {
            
           
            this.Table.Rows[index]["NGAYBD"] = info.TuNgay;
            this.Table.Rows[index]["NGAYKT"] = info.DenNgay;
            this.Table.Rows[index]["NOICT"] = info.NoiCongTac;
            this.Table.Rows[index]["CHUCDANH"] = info.ChucDanh;
            this.Table.Rows[index]["CHUCVUCAONHAT"] = info.ChucVuCaoNhat;
           

            this.data_QuaTrinhCongTac.CapNhatQTCongTac(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_QuaTrinhCongTac.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_QuaTrinhCongTac.lay_dsQuaTrinhCongTac();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QTCT1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QTCT", t.ToString());
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

        #region Xoa_QuaTrinhCongTac

        public void Xoa_QuaTrinhCongTac(String MaQTCT)
        {
            if (data_QuaTrinhCongTac == null)
                data_QuaTrinhCongTac = new QuaTrinhCongTacData();
            data_QuaTrinhCongTac.Xoa_QuaTrinhCongTac(MaQTCT);
        }
        #endregion

        #region Xoa_QuaTrinhCongTacNV

        public void Xoa_QuaTrinhCongTacNV(String MaNV)
        {
            if (data_QuaTrinhCongTac == null)
                data_QuaTrinhCongTac = new QuaTrinhCongTacData();
            data_QuaTrinhCongTac.Xoa_QuaTrinhCongTacNV(MaNV);
        }
        #endregion
    }
}
