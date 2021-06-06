using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.Controller;

namespace TT_GDTX_ANGIANG
{
    public partial class frm_LIST_HOSONHANVIEN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_LIST_HOSONHANVIEN()
        {
            InitializeComponent();
        }

        #region PhanQuyen_Xem
        public void PhanQuyen_Xem_An()
        {

        }
        public void PhanQuyen_Xem_Hien()
        {


        }
        #endregion

        #region Property

        private string m_MANV;
        public string LayMaNhanVien
        {
            get { return m_MANV; }
            set { m_MANV = value; }
        }
        private string m_Enable;
        public string An_Hien
        {
            get { return m_Enable; }
            set { m_Enable = value; }
        }

        #endregion

        #region SelectedIndex
        /// <summary>
        /// Vi tri dong da chon
        /// </summary>
        private int m_SelectedIndex;
        public int SelectedIndex
        {
            get { return m_SelectedIndex; }
            set { m_SelectedIndex = value; }
        }
        #endregion

        #region ctrlNhanVien
        private NhanVienCtrl m_ctrlNhanVien;
        public NhanVienCtrl ctrlNhanVien
        {
            get { return m_ctrlNhanVien; }
            set { m_ctrlNhanVien = value; }
        }
        #endregion  

        private void frm_LIST_TINHLUONGNHANVIEN_Load(object sender, EventArgs e)
        {

            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }

            this.LoadForm();
        }
        #region LoadForm()
        public void LoadForm()
        {

            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            ctrlNhanVien.HienThi_dsTinhLuongNhanVien(listView, 1);
            this.Refresh();

            if (this.listView.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listView.Items[this.SelectedIndex].Selected = true;
                ctrlNhanVien.HienThiInfo(this.picHinhAnh, (NhanVienInfo)this.listView.Items[this.SelectedIndex].Tag);


            }
        }
        #endregion

        private void listViewExDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView.Items.Count > 0)
            {
                IEnumerator ie = this.listView.SelectedItems.GetEnumerator();
                if (ie.MoveNext())
                {
                    this.listView.Items[this.SelectedIndex].ImageIndex = -1;
                    this.listView.Items[this.SelectedIndex].BackColor = Color.White;
                    this.listView.Items[this.SelectedIndex].ForeColor = Color.Black;

                    ListViewItem item = (ListViewItem)ie.Current;
                    item.ImageIndex = 0;
                    item.BackColor = Color.FromArgb(100, 150, 255);
                    item.ForeColor = Color.White;

                    this.SelectedIndex = this.listView.Items.IndexOf(item);
                    ctrlNhanVien.HienThiInfo(this.picHinhAnh, (NhanVienInfo)item.Tag);
                }
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            this.ShowDetail();
        }
        #region ShowDetail()
        private void ShowDetail()
        {
            IEnumerator ie = listView.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                
               
            }
        }
        #endregion

        private void LamTuoi_toolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading");
            this.LoadForm();
        }
    }
}