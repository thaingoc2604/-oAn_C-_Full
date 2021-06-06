using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;
using TT_GDTX_ANGIANG.Controller;

namespace TT_GDTX_ANGIANG.Controller
{
    public class BoPhanCtrl
    {
        #region data_BoPhan
        private BoPhanData m_data_BoPhan;
        public BoPhanData data_BoPhan
        {
            get { return m_data_BoPhan; }
            set { m_data_BoPhan = value; }
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

        #region HienThi_dsBoPhan()
        public void HienThi_dsBoPhan(ListView listView)
        {
            if (data_BoPhan == null)
            {
                data_BoPhan = new BoPhanData();
            }
            Table = data_BoPhan.lay_dsBoPhan();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                BoPhanInfo info = new BoPhanInfo();

                info.MaBoPhan = row["MABP"].ToString();
                info.TenBoPhan = row["TENBP"].ToString();

                PhongBanCtrl ctrl = new PhongBanCtrl();
                info.TenPhongBan = ctrl.GetPhongBan(row["PHONGBAN"].ToString());

                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();
                //item.Text = info.MaBoPhan;
                item.Text = info.TenBoPhan;
                //item.SubItems.Add(info.TenBoPhan);                 
                item.SubItems.Add(info.TenPhongBan.TenPhong);
                item.SubItems.Add(info.GhiChu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaBP, TextBox txtTenBP, ComboBox txtTenPB, TextBox txtGhiChu, BoPhanInfo info)
        {
            txtMaBP.Text = info.MaBoPhan;
            txtTenBP.Text = info.TenBoPhan;
            txtTenPB.Text = info.TenPhongBan.TenPhong;
            txtGhiChu.Text = info.GhiChu;
        }
        #endregion

        #region Add()
        public bool Add(BoPhanInfo info)
        {
            if (data_BoPhan == null)
            {
                data_BoPhan = new BoPhanData();
            }
            Table = data_BoPhan.lay_dsBoPhan();
            DataRow row = Table.NewRow();
            row["MABP"] = info.MaBoPhan;
            row["TENBP"] = info.TenBoPhan;
            row["PHONGBAN"] = info.TenPhongBan.MaPhong;
            row["GHICHU"] = info.GhiChu;

            Table.Rows.Add(row);
            if (this.data_BoPhan.Update())
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

        #region Update()
        public void Update(BoPhanInfo info, int index)
        {
            if (data_BoPhan == null)
            {
                data_BoPhan = new BoPhanData();
            }
            Table = data_BoPhan.lay_dsBoPhan();

            this.Table.Rows[index]["TENBP"] = info.TenBoPhan;
            this.Table.Rows[index]["PHONGBAN"] = info.TenPhongBan.MaPhong;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;

            this.data_BoPhan.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_BoPhan.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaDV)
        {
            if (data_BoPhan == null)
            {
                data_BoPhan = new BoPhanData();
            }
            Table = data_BoPhan.lay_dsBoPhan();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaDV.Text = "BP1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("BP", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaDV.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region GetBoPhan()
        public BoPhanInfo GetBoPhan(string maBP)
        {
            if (this.data_BoPhan == null)
            {
                this.data_BoPhan = new BoPhanData();
            }
            return this.data_BoPhan.GetBoPhan(maBP);
        }
        #endregion

        #region KiemTra_PhongBan
        public bool KiemTra_PhongBan(String maphong)
        {
            if (data_BoPhan == null)
                data_BoPhan = new BoPhanData();
            Table = data_BoPhan.KiemTra_Phong(maphong);
            if (Table.Rows.Count != 0)
            {
                return true; //Ton tai
            }
            else
            {
                return false; //Khong ton tai
            }
        }
        #endregion


    }
}