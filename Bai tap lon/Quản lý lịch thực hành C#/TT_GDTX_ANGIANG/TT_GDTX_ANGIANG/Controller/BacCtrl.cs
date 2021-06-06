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
    public class BacCtrl
    {
        #region data_Bac
        private BacData m_data_Bac;
        public BacData data_Bac
        {
            get { return m_data_Bac; }
            set { m_data_Bac = value; }
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

        #region HienThi_dsBac()
        public void HienThi_dsBac(ListView listView)
        {
            if (data_Bac == null)
            {
                data_Bac = new BacData();
            }
            Table = data_Bac.lay_dsBac();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                BacInfo info = new BacInfo();

                info.MaBac = row["MABAC"].ToString();
                info.TenBac = row["TENBAC"].ToString();  
              

                ListViewItem item = new ListViewItem();
                
                item.Text = info.TenBac.ToString();
                item.Tag = info;   
               

                listView.Items.Add(item);
            }
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaCV)
        {
            Table = data_Bac.lay_dsBac();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaCV.Text = "B1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("B", t.ToString());
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
        public void HienThiInfo(TextBox txtmaBac, TextBox txtTenBac, BacInfo info)
        {
            txtmaBac.Text = info.MaBac;           
            txtTenBac.Text = info.TenBac;
           
        }
        #endregion

        #region Add()
        public bool Add(BacInfo info)
        {
            DataRow row = Table.NewRow();
            row["MABAC"] = info.MaBac;
            row["TENBAC"] = info.TenBac;
          

            Table.Rows.Add(row);
            if (this.data_Bac.Update())
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

            return this.data_Bac.Update();
        }
        #endregion

        #region Update()
        public void Update(BacInfo info, int index)
        {
            //this.Table.Rows[index]["MAPH"] = info.MaPhong;
            this.Table.Rows[index]["TENbAC"] = info.TenBac;
            

            this.data_Bac.Update();
        }
        #endregion

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (this.data_Bac == null)
            {
                data_Bac = new BacData();
            }
            this.Table = this.data_Bac.lay_dsBac();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENBAC";
            cmb.ValueMember = "MABAC";
        }
        #endregion

        #region GetBac()
        public BacInfo GetBac(string maBac)
        {
            if (this.data_Bac == null)
            {
                this.data_Bac = new BacData();
            }
            return this.data_Bac.GetBac(maBac);
        }
        #endregion       
    }
}
