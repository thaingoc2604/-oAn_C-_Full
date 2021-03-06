using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLIKH.Controller;
using DevComponents.DotNetBar;
using System.Collections;

namespace QUANLIKH.GiaoDien
{
    public partial class frmNhanVien : Office2007Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        ChucVuControl chucvuctrl = new ChucVuControl();
        NhanVienControl NhanVienctrl = new NhanVienControl();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MaPhai");
            tb.Columns.Add("TenPhai");
            object[] t1 ={ 0, "Nam" };
            object[] t2 ={ 1, "Nữ" };

            if (tb.Rows.Count < 3)
            {

                tb.Rows.Add(t1);
                tb.Rows.Add(t2);
            }

            cmbPhai.DataSource = tb;
            cmbPhai.DisplayMember = "TenPhai";
            cmbPhai.ValueMember = "MaPhai";
            NhanVienctrl.HienThi(dataGridViewX1, bn, txtMaNVQL, txtHovaTen, dtNgaySinh, cmbPhai, txtCMND, txtDiaChi, txtDienThoai, txtFax, txtTaiKhoan, txtNganHang, cmbChucVu);
            chucvuctrl.HienThiLenComboBox(cmbChucVu);

        }

        private void Luu_Click(object sender, EventArgs e)
        {
            NhanVienctrl.CapNhat();    
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không ?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dataGridViewX1.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dataGridViewX1.Rows.Remove(row);
                }

            }
        }

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dòng này không ?", "XOA DONG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dataGridViewX1.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dataGridViewX1.Rows.Remove(row);
                }

            }
            else e.Cancel = true;
        }

        
        
    }
}