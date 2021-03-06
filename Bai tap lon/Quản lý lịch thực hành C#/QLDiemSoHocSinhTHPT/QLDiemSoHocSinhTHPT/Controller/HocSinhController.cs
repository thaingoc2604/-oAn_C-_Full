using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class HocSinhController
    {
        #region Data
        private HocSinhData m_Data;

        public HocSinhData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public HocSinhController()
        {
            this.Data = new HocSinhData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="txtMaHocSinh"></param>
        /// <param name="txtHoTen"></param>
        /// <param name="dpNgaySinh"></param>
        /// <param name="cbxGioiTinh"></param>
        /// <param name="txtNoiSinh"></param>
        /// <param name="txtDiaChi"></param>
        /// <param name="cmbDanToc"></param>
        /// <param name="cmbTonGiao"></param>
        /// <param name="txtHoTenCha"></param>
        /// <param name="cmbNNghiepCha"></param>
        /// <param name="txtHoTenMe"></param>
        /// <param name="cmbNNghiepMe"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, TextBox txtMaHocSinh, TextBox txtHoTen, DateTimePicker dpNgaySinh, CheckBox cbxGioiTinh, TextBox txtNoiSinh, TextBox txtDiaChi, ComboBox cmbDanToc, ComboBox cmbTonGiao, TextBox txtHoTenCha, ComboBox cmbNNghiepCha, TextBox txtHoTenMe, ComboBox cmbNNghiepMe)
        {
            if (this.Data == null)
            {
                this.Data = new HocSinhData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
            txtMaHocSinh.DataBindings.Add("Text", bs, "MaHocSinh");
            txtHoTen.DataBindings.Add("Text", bs, "HoTen");
            dpNgaySinh.DataBindings.Add("Text", bs, "NgaySinh");
            cbxGioiTinh.DataBindings.Add("Checked", bs, "GioiTinh");
            txtNoiSinh.DataBindings.Add("Text", bs, "NoiSinh");
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");
            cmbDanToc.DataBindings.Add("SelectedValue", bs, "MaDanToc");
            cmbTonGiao.DataBindings.Add("SelectedValue", bs, "MaTonGiao");
            txtHoTenCha.DataBindings.Add("Text", bs, "HoTenCha");
            cmbNNghiepCha.DataBindings.Add("SelectedValue", bs, "MaNNghiepCha");
            txtHoTenMe.DataBindings.Add("Text", bs, "HoTenMe");
            cmbNNghiepMe.DataBindings.Add("SelectedValue", bs, "MaNNghiepMe");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvDS"></param>
        public void HienThiDS(ListView lvDS)
        {
            if (this.Data == null)
            {
                this.Data = new HocSinhData();
            }
            DataTable table = this.Data.LayDS();

            IEnumerator ie = table.Rows.GetEnumerator();
            lvDS.Items.Clear();
            while (ie.MoveNext())
            {
                DataRow row = (DataRow)ie.Current;

                HocSinhInfo info = new HocSinhInfo();
                info.MaHocSinh = row["MaHocSinh"].ToString();
                info.HoTen = row["HoTen"].ToString();
                info.GioiTinh = bool.Parse(row["GioiTinh"].ToString());
                info.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                info.NoiSinh = row["NoiSinh"].ToString();
                info.DiaChi = row["DiaChi"].ToString();
                info.DanToc = new DanTocInfo();
                info.TonGiao = new TonGiaoInfo();
                info.HoTenCha = row["HoTenMe"].ToString();
                info.NgheNghiepCha = new NgheNghiepInfo();
                info.HoTenMe = row["HoTenMe"].ToString();
                info.NgheNghiepMe = new NgheNghiepInfo();

                ListViewItem item = new ListViewItem();
                item.Text = info.MaHocSinh;
                item.SubItems.Add(info.HoTen);
                if (info.GioiTinh == true)
                {
                    item.SubItems.Add("Nam");
                }
                else
                {
                    item.SubItems.Add("Nữ");
                }
                item.SubItems.Add(info.NgaySinh.ToShortDateString());
                item.SubItems.Add(info.NoiSinh);
                item.SubItems.Add(info.DiaChi);
                item.Tag = info;

                lvDS.Items.Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new HocSinhData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "HoTen";
            col.ValueMember = "MaHocSinh";
            col.DataPropertyName = "MaHocSinh";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiCombobox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new HocSinhData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "HoTen";
            cmb.ValueMember = "MaHocSinh";
            cmb.SelectedValue = "MaHocSinh";
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="bn"></param>
        /// <param name="tenhs"></param>
        public void TimTenHocSinh(DataGridView dg, BindingNavigator bn, String tenhs)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new HocSinhData().TimTenHocSinh(tenhs);
            bs.DataSource = tbl;
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new HocSinhData();
            }
            return Convert.ToString(this.Data.LayMaCuoi());
        }

        public HocSinhInfo LayTuMa(string maHocSinh)
        {
            if (this.Data == null)
            {
                this.Data = new HocSinhData();
            }
            DataTable table = this.Data.LayTuMa(maHocSinh);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                HocSinhInfo info = new HocSinhInfo();
                info.MaHocSinh = row["MaHocSinh"].ToString();
                info.HoTen = row["HoTen"].ToString();
                info.GioiTinh = bool.Parse(row["GioiTinh"].ToString());
                info.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                info.NoiSinh = row["NoiSinh"].ToString();
                info.DiaChi = row["DiaChi"].ToString();
                info.DanToc = new DanTocInfo();
                info.TonGiao = new TonGiaoInfo();
                info.HoTenCha = row["HoTenMe"].ToString();
                info.NgheNghiepCha = new NgheNghiepInfo();
                info.HoTenMe = row["HoTenMe"].ToString();
                info.NgheNghiepMe = new NgheNghiepInfo();
                return info;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Update()
        {
            return this.Data.Update();
        }
    }
}
