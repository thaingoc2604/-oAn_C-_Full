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
    public partial class frm_LIST_HOSOTUYENDUNG : DevComponents.DotNetBar.Office2007Form
    {
        public frm_LIST_HOSOTUYENDUNG()
        {
            InitializeComponent();
        }

        #region Property

        private string m_MAHS;
        public string LayMaHoSo
        {
            get { return m_MAHS; }
            set { m_MAHS = value; }
        }
        private string m_Enable;
        public string An_Hien
        {
            get { return m_Enable; }
            set { m_Enable = value; }
        }

        #endregion


        #region PhanQuyen_Xem
        public void PhanQuyen_Xem_An()
        {
            this.ThemMoi_toolStripButton.Enabled = false;
            this.ChonUngCuVien_toolStripButton.Enabled = false;
        }
        public void PhanQuyen_Xem_Hien()
        {
            this.ThemMoi_toolStripButton.Enabled = true;
            this.ChonUngCuVien_toolStripButton.Enabled = true;
        }
        #endregion        

        #region ctrlHoSo
        private HoSoTuyenDungCtrl m_ctrlHoSo;
        public HoSoTuyenDungCtrl ctrlHoSo
        {
            get { return m_ctrlHoSo; }
            set { m_ctrlHoSo = value; }
        }
        #endregion

        #region ReLoad        
       
        public void ReLoad()
        {
            if (ctrlHoSo == null)
                ctrlHoSo = new HoSoTuyenDungCtrl();
            ctrlHoSo.HienThi_dsHoSo_KetQuaTuyenDung(listViewExTonGiao, 0);
        }
        #endregion

        #region frm_LIST_HOSOTUYENDUNG_Load        
       
        private void frm_LIST_HOSOTUYENDUNG_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }
            this.ReLoad();
        }
        #endregion

        #region ThemMoi_toolStripButton_Click
        frm_HOSOTUYENDUNG hoso = null;
        private void ThemMoi_toolStripButton_Click(object sender, EventArgs e)
        {
            if (hoso == null || hoso.IsDisposed)
                hoso = new frm_HOSOTUYENDUNG();
            hoso.MdiParent = this.MdiParent;
            hoso.WindowState = FormWindowState.Maximized;
            hoso.Open = "Open";
            hoso.An_Hien = this.An_Hien;
            hoso.Show();
        }
        #endregion


        #region LamTuoi_toolStripButton_Click        
       
        private void LamTuoi_toolStripButton_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Loading");
            this.ReLoad();
        }
        #endregion


        #region Thoat_toolStripButton_Click        
        
        private void Thoat_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region listView1_SelectedIndexChanged        
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listViewExTonGiao.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                this.LayMaHoSo = item.SubItems[0].Text;
            }
        }
        #endregion

        #region listView1_DoubleClick

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            this.ShowDetail();
            this.ReLoad();
        }
        #endregion

        #region ChonUngCuVien_toolStripButton_Click

        private void ChonUngCuVien_toolStripButton_Click(object sender, EventArgs e)
        {
            if (this.listViewExTonGiao.Items.Count > 0)
            {
                if (MessageBoxEx.Show("Bạn có thực sự Chọn ứng cử viên này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ctrlHoSo == null)
                        ctrlHoSo = new HoSoTuyenDungCtrl();
                    ctrlHoSo.Update_UngCuVien(this.LayMaHoSo, 1);                    
                    this.ShowDetailKetQuaTuyenDung();
                }
                this.ReLoad();
            }
        }
        #endregion

        #region ShowDetail        
       
        frm_HOSOTUYENDUNG f_hoso = null;
        private void ShowDetail()
        {
            if (f_hoso == null || f_hoso.IsDisposed)
                f_hoso = new frm_HOSOTUYENDUNG();
            f_hoso.MdiParent = this.MdiParent;
            f_hoso.WindowState = FormWindowState.Maximized;
            IEnumerator ie = listViewExTonGiao.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem li = (ListViewItem)ie.Current;
                //frm_HOSOTUYENDUNG f_hoso = new frm_HOSOTUYENDUNG();
                HoSoTuyenDungInfo info = new HoSoTuyenDungInfo();
                info = (HoSoTuyenDungInfo)li.Tag;

                f_hoso.SelectedIndex = this.listViewExTonGiao.Items.IndexOf(li);
                f_hoso.HoSoSelected = info;
                f_hoso.An_Hien = this.An_Hien;
                f_hoso.Show();
            }
        }
        #endregion

        #region ShowDetailKetQuaTuyenDung()
        private void ShowDetailKetQuaTuyenDung()
        {
            IEnumerator ie = listViewExTonGiao.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem li = (ListViewItem)ie.Current;
                frm_KETQUATUYENDUNG f_ketqua = new frm_KETQUATUYENDUNG();
                HoSoTuyenDungInfo info = new HoSoTuyenDungInfo();
                info = (HoSoTuyenDungInfo)li.Tag;

                f_ketqua.LayHoSo = this.LayMaHoSo;
                f_ketqua.MdiParent = this.MdiParent;
                f_ketqua.WindowState = FormWindowState.Maximized;
                f_ketqua.HoSoSelected = info;
                f_ketqua.An_Hien = this.An_Hien;
                f_ketqua.Show();
            }
        }
        #endregion
    }
}