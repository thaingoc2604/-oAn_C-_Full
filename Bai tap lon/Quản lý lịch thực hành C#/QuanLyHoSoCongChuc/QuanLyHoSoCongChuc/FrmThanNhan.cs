using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmThanNhan : DockContent
    {
        ThanNhanControl m_thannhanCtrl = new ThanNhanControl();
        ThanNhanInfo ThanNhan = new ThanNhanInfo();
        ThanNhanData tnData = new ThanNhanData();

        public FrmThanNhan()
        {
            InitializeComponent();
        }

        private void FrmThanNhan_Load(object sender, EventArgs e)
        {
            m_thannhanCtrl.HienThiComBoBox(cmbChucVu, cmbQuanHe);
            m_thannhanCtrl.HienThiListViewNhanVien(listViewNhanVien);
        }

        public void HienThiThanNhan(string maNv)
        {
            m_thannhanCtrl.HienThiListViewThanNhan(listViewThanNhan, maNv);
        }

        private void listViewNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listViewNhanVien.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                //HIEN THI THONG TIN NHAN VIEN
                txtMaNV.Text = item.SubItems[1].Text;
                txtTenNhanVien.Text = item.SubItems[2].Text;
                cmbChucVu.SelectedValue = item.SubItems[3].Text;
                m_thannhanCtrl.HienThiListViewThanNhan(listViewThanNhan, txtMaNV.Text.ToString());
            }
        }

        private void listViewThanNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listViewThanNhan.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                //HIEN THI THONG TIN THAN NHAN
                cmbQuanHe.SelectedValue = item.SubItems[1].Text;
                txtTenThanNhan.Text = item.SubItems[4].Text;
                txtDiaChi.Text = item.SubItems[5].Text;
                txtNgheNghiep.Text = item.SubItems[6].Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            FrmChucNangThanNhan frm = new FrmChucNangThanNhan();
            frm.Show(DockPanel);
        }       
     
    }
}