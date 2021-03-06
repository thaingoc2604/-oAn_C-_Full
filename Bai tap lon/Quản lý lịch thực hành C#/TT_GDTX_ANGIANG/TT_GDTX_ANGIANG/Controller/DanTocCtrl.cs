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
    public class DanTocCtrl
    {
        #region data_DanToc
        private DanTocData m_dataDanToc;
        public DanTocData data_DanToc
        {
            get { return m_dataDanToc; }
            set { m_dataDanToc = value; }
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

        #region HienThi_dsDanToc()        
        public void HienThi_dsDanToc(ListView listView)
        {
            if (data_DanToc == null)
            {
                data_DanToc = new DanTocData();
            }
            Table = data_DanToc.lay_dsDanToc();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                DanTocInfo info = new DanTocInfo();

                info.MaDanToc = row["MADT"].ToString();
                info.TenDanToc = row["TENDT"].ToString();
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();
                item.Text = info.MaDanToc;
                item.SubItems.Add(info.TenDanToc);
                //item.Text = info.TenDanToc;
                //item.SubItems.Add(info.GhiChu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaDanToc, TextBox txtTenDanToc, TextBox txtGhiChu, DanTocInfo info)
        {
            txtMaDanToc.Text = info.MaDanToc;
            txtTenDanToc.Text = info.TenDanToc;
            txtGhiChu.Text = info.GhiChu;
        }
        #endregion

        #region Add()
        public bool Add(DanTocInfo info)
        {
            DataRow row = Table.NewRow();
            row["MADT"] = info.MaDanToc;
            row["TENDT"] = info.TenDanToc;
            row["GHICHU"] = info.GhiChu;

            Table.Rows.Add(row);
            if (this.data_DanToc.Update())
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
        public void Update(DanTocInfo info, int index)
        {
            //this.Table.Rows[index]["MADT"] = info.MaDanToc;
            this.Table.Rows[index]["TENDT"] = info.TenDanToc;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;

            this.data_DanToc.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_DanToc.Update();
        }
        #endregion

        #region Create()       
        public void Create(TextBox txtMaDT)
        {   
            Table = data_DanToc.lay_dsDanToc();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaDT.Text = "DT1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("DT", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaDT.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (data_DanToc == null)
            {
                data_DanToc = new DanTocData();
            }
            this.Table = this.data_DanToc.lay_dsDanToc();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENDT";
            cmb.ValueMember = "MADT";
        }
        #endregion

        #region GetDanToc()
        public DanTocInfo GetDanToc(string maDT)
        {
            if (this.data_DanToc == null)
            {
                this.data_DanToc = new DanTocData();
            }
            return this.data_DanToc.GetDanToc(maDT);
        }
        #endregion       

        #region XoaDanToc

        public void XoaDanToc(string maDT)
        {
            if (data_DanToc == null)
            {
                data_DanToc = new DanTocData();
            }
            //Table = data_DanToc.lay_dsNhanVienThuocDanToc(maDT);
            Table = data_DanToc.lay_dsNhanVienThuocDanToc(maDT);
            if (Table.Rows.Count != 0)
            {
                MessageBoxEx.Show("Đã có Nhân Viên thuộc Dân Tộc này nên không thể xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                data_DanToc.XoaDanToc(maDT);
        }
        #endregion
        
    }
}
