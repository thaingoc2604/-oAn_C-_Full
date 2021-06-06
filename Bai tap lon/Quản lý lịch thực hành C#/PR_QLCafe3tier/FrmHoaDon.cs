using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TangXuLy;

namespace PR_QLCafe3tier
{
    public partial class FrmHoaDon : DevComponents.DotNetBar.Office2007Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        clsXuLyHD objHD = new clsXuLyHD();
        DataSet dsHD = new DataSet();
        DataTable tblThongTinHD = new DataTable();
        int mvitri;
        #region"Form Load"

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            dsHD = objHD.GetHoaDon("NhanVien");
            mvitri = 0;
            tblThongTinHD = objHD.GetThongTinHD();
            Gandata(tblThongTinHD, mvitri);
        }


        void Gandata(DataTable tbl, int vitri)
        {
            DataRow drw;
            drw = tbl.Rows[vitri];
            txtMaHD1.Text = drw["MaHD"].ToString();
            txtMaNV1.Text = drw["MaNV"].ToString();
            dtpNLHD1.Text = drw["NgayLHD"].ToString();


            txtMaHD.Text = drw["MaHD"].ToString();
            txtMaNV.Text = drw["MaNV"].ToString();
            dtpNLHD.Text = drw["NgayLHD"].ToString();


            lblStatus.Text = "Vi Tri" + Convert.ToString(vitri + 1) + "/" + tblThongTinHD.Rows.Count.ToString();
            lvwHoaDon.Items.Clear();

            foreach (DataRow drwHD in tbl.Rows)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = drwHD["MaHD"].ToString();
                lvwItem.SubItems.Add(drwHD["MaNV"].ToString());
                lvwItem.SubItems.Add(drwHD["NgayLHD"].ToString());
                

                lvwItem.Tag = drwHD["MaHD"].ToString();
                lvwHoaDon.Items.Add(lvwItem);
            }



        }

        #endregion

        #region"Các Button Duyệt"


        private void btnFirst_Click(object sender, EventArgs e)
        {
            mvitri = 0;
            Gandata(tblThongTinHD, mvitri);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            mvitri -= 1;
            if (mvitri < 0)
                mvitri = tblThongTinHD.Rows.Count - 1;
            Gandata(tblThongTinHD, mvitri);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mvitri += 1;
            if (mvitri > tblThongTinHD.Rows.Count - 1)
                mvitri = 0;
            Gandata(tblThongTinHD, mvitri);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            mvitri = tblThongTinHD.Rows.Count - 1;
            Gandata(tblThongTinHD, mvitri);
        }

        #endregion


        #region"Sự Kiện Formclosing"

        private void FrmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DlgHoi = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Hóa Đơn?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DlgHoi == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region"Thêm - Xóa - Sửa"

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtMaHD1.Text = "";
            txtMaNV1.Text = "";

            txtMaHD1.Focus();
            txtMaHD1.Enabled = true;
            btnLUU.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaHD1.Enabled = false;
            txtMaNV1.Focus();
            btnLUU.Enabled = true;
            btnLUU.Text = "Lưu Sửa";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaHD1.Enabled = true;
            if (lvwHoaDon.SelectedItems.Count > 0)
            {
                DialogResult hoi;
                string strMa;
                strMa = lvwHoaDon.SelectedItems[0].Tag.ToString(); ;
                hoi = MessageBox.Show("Bạn có chắc xóa [" + strMa + "]", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    foreach (DataRow drw in dsHD.Tables["HoaDon"].Rows)
                    {
                        if (drw["MaHD"].ToString() == strMa)
                        {
                            drw.Delete();
                        }

                    }
                    if (dsHD.HasChanges())
                    {
                        objHD.CapNhatHoaDon(dsHD, "HoaDon");
                        DataTable tblThongTinhd = objHD.GetThongTinHD();
                        Gandata(tblThongTinhd, mvitri);

                    }
                }

            }
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            DataRow drw;
            drw = dsHD.Tables["HoaDon"].NewRow();
            drw["MaHD"] = txtMaHD1.Text;
            drw["MaNV"] = txtMaNV1.Text;
            drw["NgayLHD"] = dtpNLHD1.Text;

            dsHD.Tables["HoaDon"].Rows.Add(drw);
            if (dsHD.HasChanges())
            {

                objHD.CapNhatHoaDon(dsHD, "HoaDon");
                DataTable tblThongtinhd = objHD.GetThongTinHD();
                Gandata(tblThongtinhd, mvitri);
                //MessageBox.Show("Thêm Thành Công");
                btnLUU.Enabled = false;
            }
        }
        #endregion



    }
}