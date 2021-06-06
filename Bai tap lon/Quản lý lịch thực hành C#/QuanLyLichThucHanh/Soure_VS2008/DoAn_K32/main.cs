using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DoAn_K32
{
    public partial class main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Giáo Viên"))
            {

                TabPage tab1 = new TabPage();
                tab1.Text = "Giáo Viên";
                dmGiaoVien lophoc = new dmGiaoVien();
                lophoc.Dock = DockStyle.Fill;
                xtraTabControl1.TabPages.Add("Giáo Viên");
                xtraTabControl1.Enabled = true;
                xtraTabControl1.Visible = true;
                lophoc.Parent = xtraTabControl1.TabPages[xtraTabControl1.TabPages.Count - 1];

                xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
            } 
           //XtraUserControl1 gv = new XtraUserControl1();
            //showControl(gv);
        }
        public void showControl(Control obj)
        {
           // panelControl1.Controls.Clear();
           // obj.Dock = DockStyle.Fill;
           //panelControl1.Controls.Add(obj);
        }
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //dsLop mh = new dsLop();
            //showControl(mh);
            //dmLopHoc Lop = new dmLopHoc();
            //showControl(Lop);
            if (!checkOpenTabs("Lớp Học"))
            {
             
                TabPage tab1 = new TabPage();
                tab1.Text = "Lớp Học";
                dmLopHoc lophoc = new dmLopHoc();
                lophoc.Dock = DockStyle.Fill;
                xtraTabControl1.TabPages.Add("Lớp Học");
                xtraTabControl1.Enabled = true;
                xtraTabControl1.Visible = true;
                lophoc.Parent = xtraTabControl1.TabPages[xtraTabControl1.TabPages.Count - 1];

                xtraTabControl1.SelectedTabPageIndex =xtraTabControl1.TabPages.Count - 1;
            } 
        }
        private bool checkOpenTabs(string name)
        {
            for (int i = 0; i <xtraTabControl1.TabPages.Count ; i++)
            {
                //if (tabControl.TabPages[i].Text == name)
                if (xtraTabControl1.TabPages[i].Text == name)
                {
                    xtraTabControl1.SelectedTabPageIndex = i;
                    return true;

                }
            }
            return false;
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnLich_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Lịch"))
            {

                TabPage tab1 = new TabPage();
                tab1.Text = "Lịch";
                dmLich lophoc = new dmLich();
                lophoc.Dock = DockStyle.Fill;
                xtraTabControl1.TabPages.Add("Lịch");
                xtraTabControl1.Enabled = true;
                xtraTabControl1.Visible = true;
                lophoc.Parent = xtraTabControl1.TabPages[xtraTabControl1.TabPages.Count - 1];

                xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
            } 
        }

        private void btnXemLich_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!checkOpenTabs("Xem Lịch"))
            {

                TabPage tab1 = new TabPage();
                tab1.Text = "Xem Lịch";
                dmXemLich lophoc = new dmXemLich();
                lophoc.Dock = DockStyle.Fill;
                xtraTabControl1.TabPages.Add("Xem Lịch");
                xtraTabControl1.Enabled = true;
                xtraTabControl1.Visible = true;
                lophoc.Parent = xtraTabControl1.TabPages[xtraTabControl1.TabPages.Count - 1];

                xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
            } 
        }
    }
}