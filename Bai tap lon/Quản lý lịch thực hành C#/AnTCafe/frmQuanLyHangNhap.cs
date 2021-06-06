using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MDS.BussinessRule;

namespace AnTCafe
{
    public partial class frmQuanLyHangNhap : Form
    {

        clsCommonUI objCommonUI = new clsCommonUI();
        DataTable tblTable = new DataTable();
        clsBPhieuNhap objPhieuNhap = new clsBPhieuNhap();


        public frmQuanLyHangNhap()
        {
            InitializeComponent();
            string con_str = ConfigurationManager.ConnectionStrings["AnTCafe.Properties.Settings.AnTCafeConnectionString"].ConnectionString;
            objPhieuNhap.ConnectionString = con_str;
            objPhieuNhap.Initialize();

        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            //this.bindData();

        }

        private void frmQuanLyHangNhap_Activated(object sender, EventArgs e)
        {
            this.bindData();
        }

        public void bindData()
        {

            tblTable.Clear();
            tblTable = objPhieuNhap.SELECT_BY_TIME(dtmDateBegin.Value, dtmDateEnd.Value);
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvPhieuNhap.Columns["SoPhieuNhap"].DataPropertyName = "SoPhieuNhap";
            dgvPhieuNhap.Columns["NgayNhap"].DataPropertyName = "NgayNhap";
            dgvPhieuNhap.Columns["TenNV"].DataPropertyName = "TenNV";
            dgvPhieuNhap.Columns["GhiChu"].DataPropertyName = "GhiChu";
            dgvPhieuNhap.DataSource = tblTable;            
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.bindData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Delete data...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            DataGridViewSelectedRowCollection drc = dgvPhieuNhap.SelectedRows;
            foreach (DataGridViewRow dr in drc) {
                objPhieuNhap.SoPhieuNhap = dr.Cells["SoPhieuNhap"].Value.ToString();
                objPhieuNhap.DELETE_PHIEUNHAP();
                if (objPhieuNhap.ErrorMsg != "")
                    MessageBox.Show(objPhieuNhap.ErrorMsg);
                else
                    this.bindData();
            }
            

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strSoPhieuNhap="";
            DataGridViewSelectedRowCollection drc = dgvPhieuNhap.SelectedRows;
            foreach (DataGridViewRow dr in drc)
            {
                strSoPhieuNhap = dr.Cells["SoPhieuNhap"].Value.ToString();
            }

            frmNhapHang fNhapHang = new frmNhapHang();
            fNhapHang.SoPhieuNhap = strSoPhieuNhap;
            //fNhapHang.MdiParent = this.MdiParent;
            fNhapHang.ShowDialog();
            this.OnDeactivate(e);
            this.OnLostFocus(e);



        }



    }
}