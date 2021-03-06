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
    public class NgoaiNguCtrl
    {
        #region data_NgoaiNgu
        private NgoaiNguData m_dataNgoaiNgu;
        public NgoaiNguData data_NgoaiNgu
        {
            get { return m_dataNgoaiNgu; }
            set { m_dataNgoaiNgu = value; }
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

        #region HienThi_dsNgoaiNgu()
        public void HienThi_dsNgoaiNgu(ListView listView)
        {
            if (data_NgoaiNgu == null)
            {
                data_NgoaiNgu = new NgoaiNguData();
            }
            Table = data_NgoaiNgu.lay_dsNgoaiNgu();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                NgoaiNguInfo info = new NgoaiNguInfo();

                info.MaNgoaiNgu = row["MANN"].ToString();
                info.TenNgoaiNgu = row["TENNN"].ToString();
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();
                item.Text = info.MaNgoaiNgu;
                item.SubItems.Add(info.TenNgoaiNgu);
                item.SubItems.Add(info.GhiChu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaNN, TextBox txtTenNN, TextBox txtGhiChu, NgoaiNguInfo info)
        {
            txtMaNN.Text = info.MaNgoaiNgu;
            txtTenNN.Text = info.TenNgoaiNgu;
            txtGhiChu.Text = info.GhiChu;
        }
        #endregion

        #region Add()
        public bool Add(NgoaiNguInfo info)
        {
            DataRow row = Table.NewRow();
            row["MANN"] = info.MaNgoaiNgu;
            row["TENNN"] = info.TenNgoaiNgu;
            row["GHICHU"] = info.GhiChu;

            Table.Rows.Add(row);
            if (this.data_NgoaiNgu.Update())
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
        public void Update(NgoaiNguInfo info, int index)
        {
            // this.Table.Rows[index]["MAHV"] = info.MaHocVan;
            this.Table.Rows[index]["TENNN"] = info.TenNgoaiNgu;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;

            this.data_NgoaiNgu.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {

            this.Table.Rows[index].Delete();

            return this.data_NgoaiNgu.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaNN)
        {
            Table = data_NgoaiNgu.lay_dsNgoaiNgu();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaNN.Text = "NN1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("NN", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaNN.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (data_NgoaiNgu == null)
            {
                data_NgoaiNgu = new NgoaiNguData();
            }
            this.Table = this.data_NgoaiNgu.lay_dsNgoaiNgu();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENNN";
            cmb.ValueMember = "MANN";
        }
        #endregion

        #region GetNgoaiNgu()
        public NgoaiNguInfo GetNgoaiNgu(string maNN)
        {
            if (this.data_NgoaiNgu == null)
            {
                this.data_NgoaiNgu = new NgoaiNguData();
            }
            return this.data_NgoaiNgu.GetNgoaiNgu(maNN);
        }
        #endregion       

        #region XoaNgoaiNgu

        public void XoaNgoaiNgu(string maNN)
        {
            if (data_NgoaiNgu == null)
            {
                data_NgoaiNgu = new NgoaiNguData();
            }
            Table = data_NgoaiNgu.lay_dsNhanVienThuocNgoaiNgu(maNN);
            if (Table.Rows.Count != 0)
            {
                MessageBoxEx.Show("Đã có Nhân Viên thuộc Ngoại Ngữ này nên không thể xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                data_NgoaiNgu.XoaNgoaiNgu(maNN);
        }
        #endregion
    }
}
