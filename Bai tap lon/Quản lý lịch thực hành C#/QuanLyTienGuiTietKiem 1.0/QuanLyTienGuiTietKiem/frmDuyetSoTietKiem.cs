using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem
{
    public partial class frmDuyetSoTietKiem : Office2007Form
    {
        NgayGiaoDichCtrl m_NgayGiaoDichCtrl = new NgayGiaoDichCtrl();
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        public frmDuyetSoTietKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDuyetSoTietKiem_Load(object sender, EventArgs e)
        {
            m_SoTietKiemCtrl.HienThiComboBoxTheoNgay(cmbNgayGiaoDich);
            cmbNgayGiaoDich.SelectedValueChanged +=new EventHandler(cmbNgayGiaoDich_SelectedValueChanged);
        }

        void cmbNgayGiaoDich_SelectedValueChanged(object sender, EventArgs e)
        {
           
                m_SoTietKiemCtrl.HienThiDSTheoNgayDH(Convert.ToDateTime(cmbNgayGiaoDich.Text), LVHanCu);

          
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            IEnumerator ie = LVHanCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
                ListViewItem newitem = new ListViewItem();

                bool state = false;
                foreach (ListViewItem item in LVHanMoi.Items)
                {
                    if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                    {
                        MessageBoxEx.Show("Sổ tiết kiệm " + item.SubItems[1].Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }
                newitem.SubItems.Add(olditem.SubItems[1].Text);
                newitem.SubItems.Add(olditem.SubItems[2].Text);
                newitem.SubItems.Add(olditem.SubItems[3].Text);
                newitem.SubItems.Add(olditem.SubItems[4].Text); 
                newitem.Tag = olditem.Tag;

                LVHanMoi.Items.Add(newitem);
                LVHanMoi.Items[LVHanMoi.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;

                LVHanCu.Items.Remove(olditem);

            Cont:
                if (state == true)
                    break;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbNgayGiaoDich.SelectedValue != null)
            {
                m_SoTietKiemCtrl.LuuNhapVon(Convert.ToDateTime(cmbNgayGiaoDich.Text));
                MessageBoxEx.Show("Đã duyệt nhập vốn!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void cmbNgayGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}