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
    public partial class frmQuanLyHangXuat : Form
    {

        clsCommonUI objCommonUI = new clsCommonUI();
        DataTable tblTable = new DataTable();
        clsBPhieuXuat objPhieuXuat = new clsBPhieuXuat();


        public frmQuanLyHangXuat()
        {
            InitializeComponent();
            string con_str = ConfigurationManager.ConnectionStrings["AnTCafe.Properties.Settings.AnTCafeConnectionString"].ConnectionString;
            objPhieuXuat.ConnectionString = con_str;
            objPhieuXuat.Initialize();

        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            this.bindData();

        }

        private void frmQuanLyHangXuat_Activated(object sender, EventArgs e)
        {
            this.bindData();
        }

        public void bindData()
        {

            tblTable.Clear();
            tblTable = objPhieuXuat.SELECT_BY_TIME(dtmDateBegin.Value, dtmDateEnd.Value);
            dgvPhieuXuat.AutoGenerateColumns = false;
            dgvPhieuXuat.Columns["SoPhieuXuat"].DataPropertyName = "SoPhieuXuat";
            dgvPhieuXuat.Columns["NgayXuat"].DataPropertyName = "NgayXuat";
            dgvPhieuXuat.Columns["TenNV"].DataPropertyName = "TenNV";
            dgvPhieuXuat.Columns["ThanhTien"].DataPropertyName = "ThanhTien";
            dgvPhieuXuat.Columns["GhiChu"].DataPropertyName = "GhiChu";
            dgvPhieuXuat.DataSource = tblTable;            
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
            DataGridViewSelectedRowCollection drc = dgvPhieuXuat.SelectedRows;
            foreach (DataGridViewRow dr in drc) {
                objPhieuXuat.SoPhieuXuat = dr.Cells["SoPhieuXuat"].Value.ToString();
                objPhieuXuat.DELETE_PHIEUXuat();
                if (objPhieuXuat.ErrorMsg != "")
                    MessageBox.Show(objPhieuXuat.ErrorMsg);
                else
                    this.bindData();
            }
            

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strSoPhieuXuat="";
            DataGridViewSelectedRowCollection drc = dgvPhieuXuat.SelectedRows;
            foreach (DataGridViewRow dr in drc)
            {
                strSoPhieuXuat = dr.Cells["SoPhieuXuat"].Value.ToString();
            }

            frmXuatHang fXuatHang = new frmXuatHang();
            fXuatHang.SoPhieuXuat = strSoPhieuXuat;
            //fXuatHang.MdiParent = this.MdiParent;
            fXuatHang.ShowDialog();
            this.OnDeactivate(e);
            this.OnLostFocus(e);



        }



    }
}