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
    public partial class FrmNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        clsXuLyNhanVien objNV = new clsXuLyNhanVien();
        DataSet dsNV = new DataSet();
        DataTable tblThongTinNV = new DataTable();
        int mvitri;
        #region"Form Load"


        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dsNV = objNV.GetNhanVien("NhanVien");
            mvitri = 0;
            tblThongTinNV = objNV.GetThongTinNV();
            Gandata(tblThongTinNV, mvitri);
        }

        void Gandata(DataTable tbl, int vitri)
        {
            DataRow drw;
            drw = tbl.Rows[vitri];
            txtMaNV1.Text = drw["MaNV"].ToString();
            txtMaPN1.Text = drw["MaPN"].ToString();
            txtTenNV1.Text = drw["TenNV"].ToString();
            if (cboPhai1.SelectedIndex == 0)
                drw["Phai"] = true;
            else
                drw["Phai"] = false;
            txtChucVu1.Text = drw["ChucVu"].ToString();
            txtDiaChi1.Text = drw["DiaChi"].ToString();
            txtDienThoai1.Text = drw["DienThoai"].ToString();

            txtMaNV.Text = drw["MaNV"].ToString();
            txtMaPN.Text = drw["MaPN"].ToString();
            txtTenNV.Text = drw["TenNV"].ToString();
            if (cboPhai.SelectedIndex == 0)
                drw["Phai"] = true;
            else
                drw["Phai"] = false;
            txtChucVu.Text = drw["ChucVu"].ToString();
            txtDiaChi.Text = drw["DiaChi"].ToString();
            txtDienThoai.Text = drw["DienThoai"].ToString();

            lblStatus.Text = "Vi Tri" + Convert.ToString(vitri + 1) + "/" + tblThongTinNV.Rows.Count.ToString();
            lvwNhanVien.Items.Clear();

            foreach (DataRow drwNV in tbl.Rows)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = drwNV["MaNV"].ToString();
                lvwItem.SubItems.Add(drwNV["MaPN"].ToString());
                lvwItem.SubItems.Add(drwNV["TenNV"].ToString());
                lvwItem.SubItems.Add(drwNV["Phai"].ToString());
                lvwItem.SubItems.Add(drwNV["ChucVu"].ToString());
                lvwItem.SubItems.Add(drwNV["DiaChi"].ToString());
                lvwItem.SubItems.Add(drwNV["DienThoai"].ToString());

                lvwItem.Tag = drwNV["MaNV"].ToString();
                lvwNhanVien.Items.Add(lvwItem);
            }



        }

        #endregion

        #region"Các Button Duyệt"

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            mvitri = 0;
            Gandata(tblThongTinNV, mvitri);
        }

        private void btnPre_Click_1(object sender, EventArgs e)
        {
            mvitri -= 1;
            if (mvitri < 0)
                mvitri = tblThongTinNV.Rows.Count - 1;
            Gandata(tblThongTinNV, mvitri);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            mvitri += 1;
            if (mvitri > tblThongTinNV.Rows.Count - 1)
                mvitri = 0;
            Gandata(tblThongTinNV, mvitri);
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            mvitri = tblThongTinNV.Rows.Count - 1;
            Gandata(tblThongTinNV, mvitri);
        }



        #endregion

        #region"Sự Kiện Formclosing"

        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DlgHoi = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Nhân Viên ?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DlgHoi == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region"Thêm - Xóa - Sửa"

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaNV1.Text = "";
            txtTenNV1.Text = "";
            txtMaPN1.Text = "";
            txtChucVu1.Text = "";
            txtDiaChi1.Text = "";
            txtDienThoai1.Text = "";
            txtMaPN1.Focus();
            txtMaNV1.Enabled = true;
            btnLUU.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            txtMaNV1.Enabled = false;
            txtTenNV1.Focus();
            btnLUU.Enabled = true;
            btnLUU.Text = "Lưu Sửa";
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtMaNV1.Enabled = true;
            if (lvwNhanVien.SelectedItems.Count > 0)
            {
                DialogResult hoi;
                string strMa;
                strMa = lvwNhanVien.SelectedItems[0].Tag.ToString(); ;
                hoi = MessageBox.Show("Bạn có chắc xóa [" + strMa + "]", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    foreach (DataRow drw in dsNV.Tables["NhanVien"].Rows)
                    {
                        if (drw["MaNV"].ToString() == strMa)
                        {
                            drw.Delete();
                        }

                    }
                    if (dsNV.HasChanges())
                    {
                        objNV.CapNhatNhanVien(dsNV, "NhanVien");
                        DataTable tblThongTinNV = objNV.GetThongTinNV();
                        Gandata(tblThongTinNV, mvitri);

                    }
                }

            }
        }

        private void btnLUU_Click_1(object sender, EventArgs e)
        {
            DataRow drw;
            drw = dsNV.Tables["NhanVien"].NewRow();
            drw["MaNV"] = txtMaNV1.Text;
            drw["MaPN"] = txtMaPN1.Text;
            drw["TenNV"] = txtTenNV1.Text;
            if (cboPhai1.SelectedIndex == 0)
                drw["Phai"] = "True";
            else
                drw["Phai"] = "False";
            drw["ChucVu"] = txtChucVu1.Text;
            drw["DiaChi"] = txtDiaChi1.Text;
            drw["DienThoai"] = txtDienThoai1.Text;
            dsNV.Tables["NhanVien"].Rows.Add(drw);
            if (dsNV.HasChanges())
            {

                objNV.CapNhatNhanVien(dsNV, "NhanVien");
                DataTable tblThongtinNV = objNV.GetThongTinNV();
                Gandata(tblThongtinNV, mvitri);
                //MessageBox.Show("Thêm Thành Công");
                btnLUU.Enabled = false;

            }
        }

        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwNhanVien.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
            }
        }
   

        #endregion

 

    }
}