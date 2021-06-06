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
    public class QuaTrinhBoiDuongCtrl
    {
        #region data_QuaTrinhBoiDuong
        private QuaTrinhBoiDuongData m_dataQuaTrinhBoiDuong;
        public QuaTrinhBoiDuongData data_QuaTrinhBoiDuong
        {
            get { return m_dataQuaTrinhBoiDuong; }
            set { m_dataQuaTrinhBoiDuong = value; }
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

        #region HienThi_dsQuaTrinhBoiDuong()
        public void HienThi_dsQuaTrinhBoiDuong(ListView listView, string manv)
        {
            if (data_QuaTrinhBoiDuong == null)
            {
                data_QuaTrinhBoiDuong = new QuaTrinhBoiDuongData();
            }
            Table = data_QuaTrinhBoiDuong.lay_dsQuaTrinhBoiDuong(manv);
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                QuaTrinhBoiDuongInfo info = new QuaTrinhBoiDuongInfo();

               
                info.MaQTBD = row["MAQTBD"].ToString();
                info.MaNhanVien=row["MANHANVIEN"].ToString();
                info.NgayBatDau = (DateTime)row["NGAYBD"];
                info.NgayKetThuc = (DateTime)row["NGAYKT"];
                info.NoiBoiDUong= row["NOIBD"].ToString();
                info.NoiDungBoiDUong= row["NOIDUNGBD"].ToString();
                
                ListViewItem item = new ListViewItem();

                item.Text = info.MaQTBD;
                item.SubItems.Add(info.NgayBatDau.ToShortDateString());
                item.SubItems.Add(info.NgayKetThuc.ToShortDateString());
                item.SubItems.Add(info.NoiBoiDUong);
                item.SubItems.Add(info.NoiDungBoiDUong);                
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaQTBD, DateTimePicker dtngayBD, DateTimePicker dtngayKT, TextBox txtNoiBoiDuong, TextBox txtNoiDungBoiDuong, QuaTrinhBoiDuongInfo info)
        {
                      
            txtMaQTBD.Text = info.MaQTBD;
            dtngayBD.Text = info.NgayBatDau.ToShortDateString();
            dtngayKT.Text = info.NgayKetThuc.ToShortDateString();
            txtNoiBoiDuong.Text = info.NoiBoiDUong;
            txtNoiDungBoiDuong.Text = info.NoiDungBoiDUong;

        }
        #endregion

        #region Add()
        public bool Add(QuaTrinhBoiDuongInfo info)
        {
            DataRow row = Table.NewRow();
            row["MAQTBD"] = info.MaQTBD;
            row["MANHANVIEN"] = info.MaNhanVien;
            row["NGAYBD"] = info.NgayBatDau;
            row["NGAYKT"] = info.NgayKetThuc;
            row["NOIBD"] = info.NoiBoiDUong;
            row["NOIDUNGBD"] = info.NoiDungBoiDUong;            

            Table.Rows.Add(row);
            if (this.data_QuaTrinhBoiDuong.Update())
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

        #region CapNhatQuaTrinhBoiDuong()
        public void CapNhatQuaTrinhBoiDuong(QuaTrinhBoiDuongInfo info, int index)
        {
           
            this.Table.Rows[index]["NGAYBD"] = info.NgayBatDau;
            this.Table.Rows[index]["NGAYKT"] = info.NgayKetThuc;
            this.Table.Rows[index]["NOIBD"] = info.NoiBoiDUong;
            this.Table.Rows[index]["NOIDUNGBD"] = info.NoiDungBoiDUong;


            this.data_QuaTrinhBoiDuong.CapNhatQuaTrinhBoiDuong(info);
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_QuaTrinhBoiDuong.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaQT)
        {
            Table = data_QuaTrinhBoiDuong.lay_dsQuaTrinhBoiDuong();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaQT.Text = "QTBD1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("QTBD", t.ToString());
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

        #region Xoa_QuaTrinhBoiDuong        
      
        public void Xoa_QuaTrinhBoiDuong(String MaQTBD)
        {
            if (data_QuaTrinhBoiDuong == null)
                data_QuaTrinhBoiDuong = new QuaTrinhBoiDuongData();
            data_QuaTrinhBoiDuong.Xoa_QuaTrinhBoiDuong(MaQTBD);
        }
        #endregion

        #region Xoa_QuaTrinhBoiDuongNV

        public void Xoa_QuaTrinhBoiDuongNV(String MaNV)
        {
            if (data_QuaTrinhBoiDuong == null)
                data_QuaTrinhBoiDuong = new QuaTrinhBoiDuongData();
            data_QuaTrinhBoiDuong.Xoa_QuaTrinhBoiDuongNV(MaNV);
        }
        #endregion


    }
}
