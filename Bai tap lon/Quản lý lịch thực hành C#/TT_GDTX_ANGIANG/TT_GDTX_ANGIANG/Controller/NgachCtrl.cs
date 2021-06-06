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
    public class NgachCtrl
    {
        #region data_Ngach
        private NgachData m_data_Ngach;
        public NgachData data_Ngach
        {
            get { return m_data_Ngach; }
            set { m_data_Ngach = value; }
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

        #region HienThi_dsNgach()
        public void HienThi_dsNgach(ListView listView)
        {
            if (data_Ngach == null)
            {
                data_Ngach = new NgachData();
            }
            Table = data_Ngach.lay_dsNgach();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                NgachInfo info = new NgachInfo();

                info.MaNgach = row["MANGACH"].ToString();
                info.TenNgach = row["TENNGACH"].ToString();
                

                ListViewItem item = new ListViewItem();
                item.Text = info.MaNgach;
                item.SubItems.Add(info.TenNgach);               
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaNN, TextBox txtTenNN, NgachInfo info)
        {
            txtMaNN.Text = info.MaNgach;
            txtTenNN.Text = info.TenNgach;
           
        }
        #endregion

        #region Add()
        public bool Add(NgachInfo info)
        {
            DataRow row = Table.NewRow();
            row["MANGACH"] = info.MaNgach;
            row["TENNGACH"] = info.TenNgach;
           

            Table.Rows.Add(row);
            if (this.data_Ngach.Update())
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
        public void Update(NgachInfo info, int index)
        {
            // this.Table.Rows[index]["MAHV"] = info.MaHocVan;
            this.Table.Rows[index]["TENNGACH"] = info.TenNgach;
           

            this.data_Ngach.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {

            this.Table.Rows[index].Delete();

            return this.data_Ngach.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaNN)
        {
            Table = data_Ngach.lay_dsNgach();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaNN.Text = "NG1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("NG", t.ToString());
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
            if (data_Ngach == null)
            {
                data_Ngach = new NgachData();
            }
            this.Table = this.data_Ngach.lay_dsNgach();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENNGACH";
            cmb.ValueMember = "MANGACH";
        }
        #endregion

        #region GetNgach()
        public NgachInfo GetNgach(string maNgach)
        {
            if (this.data_Ngach == null)
            {
                this.data_Ngach = new NgachData();
            }
            return this.data_Ngach.GetNgach(maNgach);
        }
        #endregion     
    }
}
