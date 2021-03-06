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
    public class TrinhDo_TinHocCtrl
    {
        #region data_TrinhDoTinHoc
        private TrinhDo_TinHocData m_dataTrinhDoTinHoc;
        public TrinhDo_TinHocData data_TrinhDoTinHoc
        {
            get { return m_dataTrinhDoTinHoc; }
            set { m_dataTrinhDoTinHoc = value; }
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

        #region HienThi_dsTrinhDoTinHoc()
        public void HienThi_dsTrinhDoTinHoc(ListView listView)
        {
            if (data_TrinhDoTinHoc == null)
            {
                data_TrinhDoTinHoc = new TrinhDo_TinHocData();
            }
            Table = data_TrinhDoTinHoc.lay_dsTrinhDoTinHoc();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                TrinhDo_TinHocInfo info = new TrinhDo_TinHocInfo();

                info.MaTrinhDoTinHoc = row["MATDTH"].ToString();
                info.TenTrinhDoTinHoc = row["TENTDTH"].ToString();

                ListViewItem item = new ListViewItem();
                item.Text = info.MaTrinhDoTinHoc;
                item.SubItems.Add(info.TenTrinhDoTinHoc);

                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaTDTH, TextBox txtTenTDTH, TrinhDo_TinHocInfo info)
        {
            txtMaTDTH.Text = info.MaTrinhDoTinHoc;
            txtTenTDTH.Text = info.TenTrinhDoTinHoc;

        }
        #endregion

        #region Add()
        public bool Add(TrinhDo_TinHocInfo info)
        {
            DataRow row = Table.NewRow();
            row["MATDTH"] = info.MaTrinhDoTinHoc;
            row["TENTDTH"] = info.TenTrinhDoTinHoc;


            Table.Rows.Add(row);
            if (this.data_TrinhDoTinHoc.Update())
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
        public void Update(TrinhDo_TinHocInfo info, int index)
        {
            //this.Table.Rows[index]["MADT"] = info.MaDanToc;
            this.Table.Rows[index]["TENTDTH"] = info.TenTrinhDoTinHoc;

            this.data_TrinhDoTinHoc.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_TrinhDoTinHoc.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaTDTH)
        {
            Table = data_TrinhDoTinHoc.lay_dsTrinhDoTinHoc();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaTDTH.Text = "TDTH1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("TDTH", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaTDTH.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (data_TrinhDoTinHoc == null)
            {
                data_TrinhDoTinHoc = new TrinhDo_TinHocData();
            }
            this.Table = this.data_TrinhDoTinHoc.lay_dsTrinhDoTinHoc();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENTDTH";
            cmb.ValueMember = "MATDTH";
        }
        #endregion

        #region GetTrinhDoTinHoc()
        public TrinhDo_TinHocInfo GetTrinhDoTinHoc(string maTDTH)
        {
            if (this.data_TrinhDoTinHoc == null)
            {
                this.data_TrinhDoTinHoc = new TrinhDo_TinHocData();
            }
            return this.data_TrinhDoTinHoc.GetTrinhDoTinHoc(maTDTH);
        }
        #endregion       

        #region XoaTrinhDoTinHoc

        public void XoaTrinhDoTinHoc(string maTDTH)
        {
            if (data_TrinhDoTinHoc == null)
            {
                data_TrinhDoTinHoc = new TrinhDo_TinHocData();
            }
            Table = data_TrinhDoTinHoc.lay_dsNhanVienThuocTrinhDoTinHoc(maTDTH);
            if (Table.Rows.Count != 0)
            {
                MessageBoxEx.Show("Đã có Nhân Viên thuộc Trình Độ Tin Học này nên không thể xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                data_TrinhDoTinHoc.XoaTrinhDoTinHoc(maTDTH);
        }
        #endregion
    }
}
