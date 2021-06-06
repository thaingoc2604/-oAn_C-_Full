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
    public partial class FrmNCC : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNCC()
        {
            InitializeComponent();
        }
        clsXuLyNCC objNCC = new clsXuLyNCC();
        DataSet dsNCC = new DataSet();
        DataTable tblThongTinNCC = new DataTable();
        int mvitri;
        #region"Form Load"


        private void FrmNCC_Load(object sender, EventArgs e)
        {
            dsNCC = objNCC.GetNCC("NhaCungCap");
            mvitri = 0;
            tblThongTinNCC = objNCC.GetThongTinNCC("NhaCungCap");
            Gandata(tblThongTinNCC, mvitri);
        }

        void Gandata(DataTable tbl, int vitri)
        {
            DataRow drw;
            drw = tbl.Rows[vitri];
            txtMaNCC1.Text = drw["MaNCC"].ToString();
            txtTenNCC1.Text = drw["TenNCC"].ToString();
            txtDC1.Text = drw["DiaChi"].ToString();
            txtSDT1.Text = drw["SoDT"].ToString();

            txtMaNCC.Text = drw["MaNCC"].ToString();
            txtTenNCC.Text = drw["TenNCC"].ToString();
            txtDC.Text = drw["DiaChi"].ToString();
            txtSDT.Text = drw["SoDT"].ToString();

            lblStatus.Text = "Vi Tri" + Convert.ToString(vitri + 1) + "/" + tblThongTinNCC.Rows.Count.ToString();
            lvwNCC.Items.Clear();

            foreach (DataRow drwNCC in tbl.Rows)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = drwNCC["MaNCC"].ToString();
                lvwItem.SubItems.Add(drwNCC["TenNCC"].ToString());
                lvwItem.SubItems.Add(drwNCC["DiaChi"].ToString());
                lvwItem.SubItems.Add(drwNCC["SoDT"].ToString());

                lvwItem.Tag = drwNCC["MaNCC"].ToString();
                lvwNCC.Items.Add(lvwItem);
            }



        }

        #endregion

        #region"Các Button Duyệt"


        private void btnFirst_Click(object sender, EventArgs e)
        {
            mvitri = 0;
            Gandata(tblThongTinNCC, mvitri);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            mvitri -= 1;
            if (mvitri < 0)
                mvitri = tblThongTinNCC.Rows.Count - 1;
            Gandata(tblThongTinNCC, mvitri);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mvitri += 1;
            if (mvitri > tblThongTinNCC.Rows.Count - 1)
                mvitri = 0;
            Gandata(tblThongTinNCC, mvitri);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            mvitri = tblThongTinNCC.Rows.Count - 1;
            Gandata(tblThongTinNCC, mvitri);
        }


        #endregion

        #region"Sự Kiện Formclosing"

        private void FrmNCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DlgHoi = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form NCC ?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
            txtMaNCC1.Text = "";
            txtTenNCC1.Text = "";
            txtDC1.Text = "";
            txtSDT1.Text = "";
            txtMaNCC1.Focus();
            txtMaNCC1.Enabled = true;
            btnLUU.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNCC1.Enabled = false;
            txtTenNCC1.Focus();
            btnLUU.Enabled = true;
            btnLUU.Text = "Lưu Sửa";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNCC1.Enabled = true;
            if (lvwNCC.SelectedItems.Count > 0)
            {
                DialogResult hoi;
                string strMa;
                strMa = lvwNCC.SelectedItems[0].Tag.ToString(); ;
                hoi = MessageBox.Show("Bạn có chắc xóa [" + strMa + "]", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    foreach (DataRow drw in dsNCC.Tables["NhaCungCap"].Rows)
                    {
                        if (drw["MaNCC"].ToString() == strMa)
                        {
                            drw.Delete();
                        }

                    }
                    if (dsNCC.HasChanges())
                    {
                        objNCC.CapNhatNhaCungCap(dsNCC, "NhaCungCap");
                        DataTable tblThongTinncc = objNCC.GetThongTinNCC("NhaCungCap");
                        Gandata(tblThongTinncc, mvitri);

                    }
                }
            }
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            DataRow drw;
            drw = dsNCC.Tables["NhaCungCap"].NewRow();
            drw["MaNCC"] = txtMaNCC1.Text;
            drw["TenNCC"] = txtTenNCC1.Text;
            drw["DiaChi"] = txtDC1.Text;
            drw["SoDT"] = txtSDT1.Text;
            dsNCC.Tables["NhaCungCap"].Rows.Add(drw);
            if (dsNCC.HasChanges())
            {

                objNCC.CapNhatNhaCungCap(dsNCC, "NhaCungCap");
                DataTable tblThongtinncc = objNCC.GetThongTinNCC("NhaCungCap");
                Gandata(tblThongtinncc, mvitri);
                //MessageBox.Show("Thêm Thành Công");
                btnLUU.Enabled = false;

            }
        }

        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwNCC.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
            }
        }
    

        #endregion
      
    }
}