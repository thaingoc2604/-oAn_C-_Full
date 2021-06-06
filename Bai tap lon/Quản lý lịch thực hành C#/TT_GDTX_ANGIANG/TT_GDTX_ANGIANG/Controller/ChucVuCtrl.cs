using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;


namespace TT_GDTX_ANGIANG.Controller
{
    public class ChucVuCtrl
    {
        #region data_ChucVu
        private ChucVuData m_dataChucVu;
        public ChucVuData data_ChucVu
        {
            get { return m_dataChucVu; }
            set { m_dataChucVu = value; }
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

        #region HienThi_dsChucVu()
        public void HienThi_dsChucVu(ListView listView)
        {
            if (data_ChucVu == null)
            {
                data_ChucVu = new ChucVuData();
            }
            Table = data_ChucVu.lay_dsChucVu();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                ChucVuInfo info = new ChucVuInfo();

                info.MaChucVu = row["MACV"].ToString();
                info.TenChucVu = row["TENCV"].ToString();
                info.HeSoChucVu = float.Parse(row["HESOCV"].ToString());
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();
                //item.Text = info.MaChucVu;
                //item.SubItems.Add(info.TenChucVu);
                item.Text = info.TenChucVu;
                item.SubItems.Add(info.HeSoChucVu.ToString());
                item.SubItems.Add(info.GhiChu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaCV)
        {
            Table = data_ChucVu.lay_dsChucVu();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaCV.Text = "CV1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("CV", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaCV.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaCV, TextBox txtTenCV, TextBox txtHeSoChucVu, TextBox txtGhiChu, ChucVuInfo info)
        {
            txtMaCV.Text = info.MaChucVu;
            txtTenCV.Text = info.TenChucVu;
            txtHeSoChucVu.Text = info.HeSoChucVu.ToString();
            txtGhiChu.Text = info.GhiChu;
        }
        #endregion
                
        #region Add()
        public bool Add(ChucVuInfo info)
        {
            DataRow row = Table.NewRow();
            row["MACV"] = info.MaChucVu;
            row["TENCV"] = info.TenChucVu;
            row["HESOCV"] = info.HeSoChucVu;
            row["GHICHU"] = info.GhiChu;

            Table.Rows.Add(row);
            if (this.data_ChucVu.Update())
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


        #region Delete()
        public bool Delete(int index)
        {
            //this.Table.Rows[index].Delete();
            this.Table.Rows[index].Delete();

            return this.data_ChucVu.Update();
        }
        #endregion

        #region Update()
        public void Update(ChucVuInfo info, int index)
        {
            //this.Table.Rows[index]["MAPH"] = info.MaPhong;
            this.Table.Rows[index]["TENCV"] = info.TenChucVu;
            this.Table.Rows[index]["HESOCV"] = info.HeSoChucVu;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;

            this.data_ChucVu.Update();
        }
        #endregion

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (this.data_ChucVu == null)
            {
                data_ChucVu = new ChucVuData();
            }
            this.Table = this.data_ChucVu.lay_dsChucVu();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
        }
        #endregion


        #region GetChucVu()
        public ChucVuInfo GetChucVu(string maCV)
        {
            if (this.data_ChucVu == null)
            {
                this.data_ChucVu = new ChucVuData();
            }
            return this.data_ChucVu.GetChucVu(maCV);
        }
        #endregion       
    }
}
