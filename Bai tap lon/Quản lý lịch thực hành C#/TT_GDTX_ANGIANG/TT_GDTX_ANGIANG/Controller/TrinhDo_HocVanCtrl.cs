using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;

namespace TT_GDTX_ANGIANG.Controller
{
    public class TrinhDo_HocVanCtrl
    {
        #region data_TDHocVan
        private TrinhDo_HocVanData m_dataTDHocVan;
        public TrinhDo_HocVanData data_TDHocVan
        {
            get { return m_dataTDHocVan; }
            set { m_dataTDHocVan = value; }
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

        #region HienThi_dsTDHocVan()
        public void HienThi_dsTDHocVan(ListView listView)
        {
            if (data_TDHocVan == null)
            {
                data_TDHocVan = new TrinhDo_HocVanData();
            }
            Table = data_TDHocVan.lay_dsTDHocVan();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                TrinhDo_HocVanInfo info = new TrinhDo_HocVanInfo();

                info.MaHocVan = row["MATDHV"].ToString();
                info.TenHocVan = row["TENTDHV"].ToString();
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();
                item.Text = info.MaHocVan;
                item.SubItems.Add(info.TenHocVan);
                item.SubItems.Add(info.GhiChu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaHV, TextBox txtTenHV, TextBox txtGhiChu, TrinhDo_HocVanInfo info)
        {
            txtMaHV.Text = info.MaHocVan;
            txtTenHV.Text = info.TenHocVan;
            txtGhiChu.Text = info.GhiChu;
        }
        #endregion

        #region Add()
        public bool Add(TrinhDo_HocVanInfo info)
        {
            DataRow row = Table.NewRow();
            row["MATDHV"] = info.MaHocVan;
            row["TENTDHV"] = info.TenHocVan;
            row["GHICHU"] = info.GhiChu;

            Table.Rows.Add(row);
            if (this.data_TDHocVan.Update())
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
        public void Update(TrinhDo_HocVanInfo info, int index)
        {
           // this.Table.Rows[index]["MAHV"] = info.MaHocVan;
            this.Table.Rows[index]["TENTDHV"] = info.TenHocVan;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;

            this.data_TDHocVan.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
           
            this.Table.Rows[index].Delete();

            return this.data_TDHocVan.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaHV)
        {
            Table = data_TDHocVan.lay_dsTDHocVan();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaHV.Text = "HV1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("HV", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaHV.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (data_TDHocVan == null)
            {
                data_TDHocVan = new TrinhDo_HocVanData();
            }
            this.Table = this.data_TDHocVan.lay_dsTDHocVan();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENTDHV";
            cmb.ValueMember = "MATDHV";
        }
        #endregion

        #region GetTrinhDoHocVan()
        public TrinhDo_HocVanInfo GetTrinhDoHocVan(string maTDHV)
        {
            if (this.data_TDHocVan == null)
            {
                this.data_TDHocVan = new TrinhDo_HocVanData();
            }
            return this.data_TDHocVan.GetTrinhDoHocVan(maTDHV);
        }
        #endregion       

        #region XoaTrinhDoHocVan

        public void XoaTrinhDoHocVan(string maTDHV)
        {
            if (data_TDHocVan == null)
            {
                data_TDHocVan = new TrinhDo_HocVanData();
            }
            Table = data_TDHocVan.lay_dsNhanVienThuocTrinhDoHocVan(maTDHV);
            if (Table.Rows.Count != 0)
            {
                MessageBoxEx.Show("Đã có Nhân Viên thuộc Trình Độ Học Vấn này nên không thể xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                data_TDHocVan.XoaTrinhDoHocVan(maTDHV);
        }
        #endregion
    }
}
