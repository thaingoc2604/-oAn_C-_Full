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
    public class ViTri_TuyenDungCtrl
    {
        #region data_VTTD
        private ViTri_TuyenDungData m_dataVTTD;
        public ViTri_TuyenDungData data_VTTD
        {
            get { return m_dataVTTD; }
            set { m_dataVTTD = value; }
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

        #region HienThi_dsVTTuyenDung()
        public void HienThi_dsVTTuyenDung(ListView listView)
        {
            if (data_VTTD == null)
            {
                data_VTTD = new ViTri_TuyenDungData(); 
            }
            Table = data_VTTD.lay_dsVTTuyenDung();
            IEnumerator ie = Table.Rows.GetEnumerator();
            listView.Items.Clear();

            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;
                ViTri_TuyenDungInfo info = new ViTri_TuyenDungInfo();

                info.MaVTTD = row["MAVTTD"].ToString();
                info.TenVTTD = row["TENVTTD"].ToString();
                info.TenTat = row["TENTAT"].ToString();
                info.GhiChu = row["GHICHU"].ToString();

                ListViewItem item = new ListViewItem();
                item.Text = info.MaVTTD;
                item.SubItems.Add(info.TenVTTD);
                item.SubItems.Add(info.TenTat);
                item.SubItems.Add(info.GhiChu);
                item.Tag = info;

                listView.Items.Add(item);
            }
        }
        #endregion

        #region HienThiInfo()
        public void HienThiInfo(TextBox txtMaVTTD, TextBox txtTenVTTD, TextBox txtTenTat, TextBox txtGhiChu, ViTri_TuyenDungInfo info)
        {
            txtMaVTTD.Text = info.MaVTTD;
            txtTenVTTD.Text = info.TenVTTD;
            txtTenTat.Text = info.TenTat;
            txtGhiChu.Text = info.GhiChu;
        }
        #endregion

        #region Add()
        public bool Add(ViTri_TuyenDungInfo info)
        {
            DataRow row = Table.NewRow();
            row["MAVTTD"] = info.MaVTTD;
            row["TENVTTD"] = info.TenVTTD;
            row["TENTAT"] = info.TenTat;
            row["GHICHU"] = info.GhiChu;

            Table.Rows.Add(row);
            if (this.data_VTTD.Update())
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
        public void Update(ViTri_TuyenDungInfo info, int index)
        {
            //this.Table.Rows[index]["MAVTTD"] = info.MaVTTD;
            this.Table.Rows[index]["TENVTTD"] = info.TenVTTD;
            this.Table.Rows[index]["TENTAT"] = info.TenTat;
            this.Table.Rows[index]["GHICHU"] = info.GhiChu;

            this.data_VTTD.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {
            this.Table.Rows[index].Delete();

            return this.data_VTTD.Update();
        }
        #endregion

        #region Create()
        public void Create(TextBox txtMaVTTD)
        {
            Table = data_VTTD.lay_dsVTTuyenDung();
            bool b = true;
            int i = 0;
            int t = 1;
            if (Table.Rows.Count == 0)
            {
                txtMaVTTD.Text = "VT1";
                return;
            }
            while (b)
            {
                string s1 = string.Concat("VT", t.ToString());
                if (Table.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (Table.Rows.Count - 1))
                {
                    txtMaVTTD.Text = s1;
                    b = false;
                }
                i++;
            }
        }
        #endregion

        #region HienThiComboBox()
        public void HienThiComboBox(ComboBox cmb)
        {
            if (data_VTTD == null)
            {
                data_VTTD = new ViTri_TuyenDungData();
            }
            this.Table = this.data_VTTD.lay_dsVTTuyenDung();
            cmb.DataSource = this.Table;
            cmb.DisplayMember = "TENVTTD";
            cmb.ValueMember = "MAVTTD";
        }
        #endregion

        #region GetViTriTuyen()
        public ViTri_TuyenDungInfo GetViTriTuyen(string maVTTD)
        {
            if (this.data_VTTD == null)
            {
                this.data_VTTD = new ViTri_TuyenDungData();
            }
            return this.data_VTTD.GetViTriTuyen(maVTTD);
        }
        #endregion

        #region XoaViTriTuyenDung

        public void XoaViTriTuyenDung(string maVTTD)
        {
            if (data_VTTD == null)
            {
                data_VTTD = new ViTri_TuyenDungData();
            }
            Table = data_VTTD.lay_dsHoSoThuocViTriTuyenDung(maVTTD);
            if (Table.Rows.Count != 0)
            {
                MessageBoxEx.Show("Đã có Nhân Viên thuộc Vị Trí Tuyển Dụng này nên không thể xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                data_VTTD.XoaViTriTuyenDung(maVTTD);
        }
        #endregion
    }
}
