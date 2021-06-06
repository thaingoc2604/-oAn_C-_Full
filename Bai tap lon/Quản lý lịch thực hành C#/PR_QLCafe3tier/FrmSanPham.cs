using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ms = Microsoft.Office.Interop.Excel;
using TangXuLy;

namespace PR_QLCafe3tier
{
    public partial class FrmSanPham : DevComponents.DotNetBar.Office2007Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }

        clsXuLySanPham objSp = new clsXuLySanPham();
        DataSet dsSP = new DataSet();
        DataTable tblThongTinSP = new DataTable();
        int mvitri;
        #region"Form Load"

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            dsSP = objSp.GetSanPham("SanPham");
            mvitri = 0;
            tblThongTinSP = objSp.GetThongTinSP();
            //Bước gán data bằng cách create new method for name Gandata
            Gandata(tblThongTinSP, mvitri);
        }

        void Gandata(DataTable tbl, int vitri)
        {
            DataRow drw;
            drw = tbl.Rows[vitri];
            txtMaSP1.Text = drw["MaSP"].ToString();
            txtTenSP1.Text = drw["TenSP"].ToString();
            txtDG1.Text = drw["DonGia"].ToString();            
            txtDVT1.Text = drw["DonViTinh"].ToString();

            txtMaSP.Text = drw["MaSP"].ToString();
            txtTenSP.Text = drw["TenSP"].ToString();
            txtDonGia.Text = drw["DonGia"].ToString();
            txtDonViTinh.Text = drw["DonViTinh"].ToString();

            lblStatus.Text = "Vi Tri" + Convert.ToString(vitri + 1) + "/" + tblThongTinSP.Rows.Count.ToString();
            lvwSanPham.Items.Clear();

            foreach (DataRow drwsp in tbl.Rows)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = drwsp["MaSP"].ToString();
                lvwItem.SubItems.Add(drwsp["TenSP"].ToString());
                lvwItem.SubItems.Add(drwsp["DonGia"].ToString());
                lvwItem.SubItems.Add(drwsp["DonViTinh"].ToString());
                lvwItem.Tag = drwsp["MaSP"].ToString();
                lvwSanPham.Items.Add(lvwItem);
            }



        }

        #endregion

        #region"Sự Kiện Formclosing"
        private void FrmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DlgHoi = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Sản Phẩm ?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSP1.Text = "";
            txtTenSP1.Text = "";
            txtDG1.Text = "";
            txtDVT1.Text = "";
            txtMaSP1.Focus();
            txtMaSP1.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSP1.Enabled = false;
            txtTenSP1.Focus();
            btnLuu.Enabled = true;
            btnLuu.Text = "Lưu Sửa";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaSP1.Enabled = true;
            if (lvwSanPham.SelectedItems.Count > 0)
            {
                DialogResult hoi;
                string strMa;
                strMa = lvwSanPham.SelectedItems[0].Tag.ToString(); ;
                hoi = MessageBox.Show("Bạn có chắc xóa [" + strMa + "]", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    foreach (DataRow drw in dsSP.Tables["SanPham"].Rows)
                    {
                        if (drw["MaSP"].ToString() == strMa)
                        {
                            drw.Delete(); 
                        }

                    }
                    if (dsSP.HasChanges())
                    {
                        objSp.CapNhatSanPham(dsSP, "SanPham");
                        DataTable tblThongTinSP = objSp.GetThongTinSP();
                        Gandata(tblThongTinSP, mvitri);

                    }
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataRow drw;
            drw = dsSP.Tables["SanPham"].NewRow();            
            drw["MaSP"] = txtMaSP1.Text;
            drw["TenSP"] = txtTenSP1.Text;
            drw["DonGia"] = txtDG1.Text;
            drw["DonViTinh"] = txtDVT1.Text;
            dsSP.Tables["SanPham"].Rows.Add(drw);
            if (dsSP.HasChanges())
            {
               
                objSp.CapNhatSanPham(dsSP, "SanPham");
                DataTable tblThongTinSP = objSp.GetThongTinSP();
                Gandata(tblThongTinSP, mvitri);
                //MessageBox.Show("Thêm Thành Công");
                btnLuu.Enabled = false;

            }
        }

        private void lvwSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSanPham.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
            }
        }

        #endregion

        #region"Các Button Duyệt"

        private void btnFirst_Click(object sender, EventArgs e)
        {
            mvitri = 0;
            Gandata(tblThongTinSP, mvitri);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            mvitri -= 1;
            if (mvitri < 0)
                mvitri = tblThongTinSP.Rows.Count - 1;
            Gandata(tblThongTinSP, mvitri);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mvitri += 1;
            if (mvitri > tblThongTinSP.Rows.Count - 1)
                mvitri = 0;
            Gandata(tblThongTinSP, mvitri);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            mvitri = tblThongTinSP.Rows.Count - 1;
            Gandata(tblThongTinSP, mvitri);
        }

        #endregion


        #region " Binding dữ liệu"
        private void bindingdata()
        {
            txtMaSP1.DataBindings.Clear();
            txtMaSP1.DataBindings.Add("Text", lvwSanPham.DataBindings, "MaSP");
            txtTenSP1.DataBindings.Clear();
            txtTenSP1.DataBindings.Add("Text", lvwSanPham.DataBindings, "TenSP");
            txtDG1.DataBindings.Clear();
            txtDG1.DataBindings.Add("Text", lvwSanPham.DataBindings, "DonGia");
            txtDVT1.DataBindings.Clear();
            txtDVT1.DataBindings.Add("Text", lvwSanPham.DataBindings, "DonViTinh");


        }


        #endregion


        //#region"Xuất ra file Excel"
        ///// <summary>
        ///// Ghi ra file Excel
        ///// </summary>
        ///// <param name="dgr"></param>
        //public static void Export2Excel(ListViewItem lvw)
        //{
        //    System.Globalization.CultureInfo old = System.Threading.Thread.CurrentThread.CurrentCulture;
        //    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        //    ms.ApplicationClass exa = new ms.ApplicationClass();
        //    ms.Workbook wb = exa.Application.Workbooks.Add(ms.XlSheetType.xlWorksheet);
        //    ms.Worksheet ws = (ms.Worksheet)exa.ActiveSheet;
        //    exa.Visible = true;
        //    for (int i = 0; i < lvw.Columns.Count; ++i)
        //    {
        //        ws.Cells[1, i + 1] = lvw.Columns[i].Text;
        //    }
        //    ms.Range ran = ws.get_Range("a1", "z1");
        //    ran.Font.Bold = true;
        //    ran.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Navy);

        //    for (int i = 0; i < lvw.SelectedItems.Count; ++i)
        //    {
        //        for (int j = 0; j < lvw.Columns.Count; ++j)
        //        {
        //             ws.Cells[i + 2, j + 1] = lvw;
        //        }
        //    }
        //    ws.Columns.AutoFit();
        //    System.Threading.Thread.CurrentThread.CurrentCulture = old;
        //}

        //private void btnXuatExcelSP1_Click(object sender, EventArgs e)
        //{
        //    Export2Excel(lvwSanPham);
        //}


        //#endregion





    }
}