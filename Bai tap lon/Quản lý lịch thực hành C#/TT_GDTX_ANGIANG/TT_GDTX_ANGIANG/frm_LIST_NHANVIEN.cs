using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Collections;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.Controller;

namespace TT_GDTX_ANGIANG
{
    public partial class frm_LIST_NHANVIEN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_LIST_NHANVIEN()
        {
            InitializeComponent();
        }


        #region PhanQuyen_Xem
        public void PhanQuyen_Xem_An()
        {
            this.ThemMoi_toolStripButton.Enabled = false;
           
        }
        public void PhanQuyen_Xem_Hien()
        {
            this.ThemMoi_toolStripButton.Enabled = true;
            
        }
        #endregion

        #region Property
        private string m_MAPH;
        public string Lay_MaPhong
        {
            get { return m_MAPH; }
            set { m_MAPH = value; }
        }
        private string m_MADV;
        public string Lay_MaDonVi
        {
            get { return m_MADV; }
            set { m_MADV = value; }
        }
        private string m_Ten;
        public string Lay_Ten
        {
            get { return m_Ten; }
            set { m_Ten = value; }
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

        #region LoadForm()
        public void LoadForm()
        {
            this.Lay_MaPhong = this.Tag.ToString();

            if (ctrlNhanVien == null)
                ctrlNhanVien = new NhanVienCtrl();
            ctrlNhanVien.HienThi_dsNhanVien(this.listView, Lay_MaPhong, 1);
            this.lbl_NhanVien.Text =  this.Lay_Ten;
            this.Refresh();

            if (this.listView.Items.Count > 0)
            {
                this.SelectedIndex = 0;
                this.listView.Items[this.SelectedIndex].Selected = true;
                ctrlNhanVien.HienThiInfo(this.picHinhAnh, (NhanVienInfo)this.listView.Items[this.SelectedIndex].Tag);

               
            }
        }
       #endregion

        #region frm_LIST_NHANVIEN_Load        
       
        private void frm_LIST_NHANVIEN_Load(object sender, EventArgs e)
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
        #endregion     

        #region ShowDetail()
        private void ShowDetail()
        {
            IEnumerator ie = listView.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem li = (ListViewItem)ie.Current;
                frm_NHANVIEN1 frm_nhanvien = new frm_NHANVIEN1();
                NhanVienInfo info = new NhanVienInfo();
                info = (NhanVienInfo)li.Tag;
                frm_nhanvien.NhanVienSelected = info;

                //frm_nhanvien.SelectedIndex = this.listView1.Items.IndexOf(li);
                frm_nhanvien.MaNhanVien = li.SubItems[0].Text;
                frm_nhanvien.MdiParent = this.MdiParent;
                frm_nhanvien.WindowState = FormWindowState.Maximized;
                frm_nhanvien.An_Hien = this.An_Hien;
                frm_nhanvien.Show();
            }
        }
        #endregion

        #region  listView_DoubleClick        
       
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            this.ShowDetail();
        }
        #endregion

        #region LamTuoi_toolStripButton_Click

        private void LamTuoi_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            MessageBoxEx.Show("loading");
            this.LoadForm();
        }
        #endregion
        #region LamTuoi_toolStripButton_doubleClick

        private void LamTuoi_toolStripButton_doubleClick(object sender, EventArgs e)
        {
            this.Refresh();
            
        }
        #endregion

        #region ThemMoiNhanVien_toolStripButton_Click_1        
        frm_NHANVIEN1 nv = null;
        private void ThemMoi_toolStripButton_Click_1(object sender, EventArgs e)
        {
          
            if (nv == null || nv.IsDisposed)
                nv = new frm_NHANVIEN1();
            nv.MdiParent = this.MdiParent;
            nv.WindowState = FormWindowState.Maximized;
            nv.Open = "Open";
            nv.An_Hien = this.An_Hien;
            nv.Show();
        }
        #endregion

        #region listViewExDanToc_SelectedIndexChanged        
       
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

        #endregion

        #region Thoat_toolStripButton_Click        
      
        private void Thoat_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}