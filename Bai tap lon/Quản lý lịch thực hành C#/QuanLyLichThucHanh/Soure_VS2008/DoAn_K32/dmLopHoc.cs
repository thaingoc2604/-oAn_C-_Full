using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using DTO;
using BussinessLayer;
namespace DoAn_K32
{
    public partial class dmLopHoc : DevExpress.XtraEditors.XtraUserControl
    {
       // DataTable tb1 = new DataTable();
        public dmLopHoc()
        {
            InitializeComponent();
            //tb1.Columns.Add("MaLop", typeof(string));
            //tb1.Columns.Add("TenLop", typeof(string));
            //tb1.Columns.Add("TongSo", typeof(int));
        }

        private void dmLopHoc_Load(object sender, EventArgs e)
        {
            //DanhSachLop(LopBus.GetAll_Lop());
            //gvLop.DataSource = LopBus.GetAll_Lop();
            //AddNewRow();
            LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            gvLop.DataSource = LopBus.LoadLop();
            DataGridViewComboBoxColumn objCol = CreateComboboxColumn("STTSV", "STTSV",LopBus.LoadLop(), "STT");
            DataTable tb = new DataTable();
        }
        internal static DataGridViewComboBoxColumn CreateComboboxColumn(String ColumnName, String HeaderText, DataTable pTable, String ColumnNameDisplay)
        {
            DataGridViewComboBoxColumn objColumn = new DataGridViewComboBoxColumn();
            objColumn.Name = ColumnName;
            objColumn.HeaderText = HeaderText;
            objColumn.DataPropertyName = ColumnName;
            objColumn.DropDownWidth = 160;
            objColumn.Width = 100;
            objColumn.MaxDropDownItems = 10;
            objColumn.FlatStyle = FlatStyle.Standard;
            objColumn.DataSource = pTable;
            objColumn.DisplayMember = ColumnNameDisplay;
            return objColumn;
        }
        //private void AddNewRow()
        //{
        //    tb1.Rows.Add();
        //    gvLop.DataSource = LopBus.GetAll_Lop();
        //}
        //int dex;
        //public void DanhSachLop(List<Lop_Info> ds)
        //{
        //   // gvLop.Rows.Clear();
        //    dex = 0;
        //    foreach (Lop_Info lop in ds)
        //    {
        //        Add_Gridview(lop, dex++);
        //    }


        //}
        //public void Add_Gridview(Lop_Info lop, int dex)
        //{
        //    gvLop.Rows[i].Add(dex, lop.MaLop, lop.TenLop, lop.TongSo);
        //    grvLopp.Rows.Add(dex, lop.MaLop, lop.TenLop, lop.TongSo);
        //}
        private void grvLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void lopBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gvLop_Click(object sender, EventArgs e)
        {

        }

        private void txtTenLop_Paint(object sender, PaintEventArgs e)
        {

        }
       // int dex;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Lop_Info lop = new Lop_Info(txtMa.Text,txtTenLop.Text, Convert.ToInt32(txtTongSo.Text));
            if (LopBus.ThemLop(lop))
            {
                MessageBox.Show("Them Thanh Cong");
            }
            else
            {
                MessageBox.Show("Ma Da Trung");
            }
        }
        public void DanhSachLop(List<Lop_Info> ds)
        {
            //grvLop.Rows.Clear();
            //dex = 0;
            //foreach (Lop_Info lop in ds)
            //{
            //    Add_Gridview(lop, dex++);
            //}


        }
        public void Add_Gridview(Lop_Info lop, int dex)
        {
           // grvLop.Rows.Add(dex, lop.MaLop, lop.TenLop, lop.TongSo);
            //grvLopp.Rows.Add(dex, lop.MaLop, lop.TenLop, lop.TongSo);
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            gvLop.DataSource = LopBus.TimLopMa(this.txtTim.Text);
            DataGridViewComboBoxColumn objCol = CreateComboboxColumn("STTSV", "STTSV", LopBus.LoadLop(), "STT");
            DataTable tb = new DataTable();
        }

        private void gvLop_Click_1(object sender, EventArgs e)
        {

        }
    }
}
