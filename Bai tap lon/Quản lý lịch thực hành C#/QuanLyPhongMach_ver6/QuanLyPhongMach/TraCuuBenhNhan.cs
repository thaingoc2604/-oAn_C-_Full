using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using DTO;
using BUS;

namespace QuanLyPhongMach
{
    public partial class frmTraCuuBenhNhan : Form
    {
        public BenhNhanDTO _benhnhan = new BenhNhanDTO();

        public frmTraCuuBenhNhan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BenhNhanBUS.SelectAllBenhNhan();
            this.btCapNhat.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BenhNhanBUS.SelectBenhNhanByHoTen(this.tbTenBenhNhan.Text);
        }

        private void frmTraCuuBenhNhan_Load(object sender, EventArgs e)
        {
            this.comboBox1.DisplayMember = "TenBacSi";
            this.comboBox1.ValueMember = "sttBS";
            this.comboBox1.DataSource = BacSiBUS.SelectAllBacSi();            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked == true)
                this.dataGridView2.DataSource = BenhNhanBUS.SelectAllBenhNhanByBacSiDieuTri(int.Parse(this.comboBox1.SelectedValue.ToString()));
            //else if (radioButton1.Checked == true)
            //    this.dataGridView2.DataSource = BenhNhanBUS.SelectAllBenhNhanByBacSiAndGioiTinh(int.Parse(this.comboBox1.SelectedValue.ToString()), "Nam");
            //else
            //    this.dataGridView2.DataSource = BenhNhanBUS.SelectAllBenhNhanByBacSiAndGioiTinh(int.Parse(this.comboBox1.SelectedValue.ToString()), "Nữ");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //this.dataGridView2.DataSource = BenhNhanBUS.SelectAllBenhNhanByBacSiAndGioiTinh(int.Parse(this.comboBox1.SelectedValue.ToString()), "Nam");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excell
            COMExcel.Application exApp = new COMExcel.Application();

            // Thêm file temp xls
            COMExcel.Workbook exBook = exApp.Workbooks.Add(
                      COMExcel.XlWBATemplate.xlWBATWorksheet);

            // Lấy sheet 1.
            COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];

            exSheet.Activate();
            exSheet.Name = "Danh Sách Bệnh Nhân";

            int rows = dataGridView1.Rows.Count;
            int columns = dataGridView1.Columns.Count;
            //Ghi dữ liệu
            for (int i = 0; i <= rows-1; i++) // duyệt các dòng trong datagrid
            {
                for (int j = 0; j <= columns - 1; j++) // duyệt các cột của mỗi dòng
                {
                    COMExcel.Range r = (COMExcel.Range)exSheet.Cells[i + 1, j + 1];

                    r.Value2 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[j].Value.ToString());

                    r.Columns.AutoFit(); // tự động giãn cột
                }
            }

            // Hiển thị chương trình excel
            exApp.Visible = true;

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excell
            COMExcel.Application exApp = new COMExcel.Application();

            // Thêm file temp xls
            COMExcel.Workbook exBook = exApp.Workbooks.Add(
                      COMExcel.XlWBATemplate.xlWBATWorksheet);

            // Lấy sheet 1.
            COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];

            exSheet.Activate();
            exSheet.Name = "Danh Sách Bệnh Nhân";

            int rows = dataGridView2.Rows.Count;
            int columns = dataGridView2.Columns.Count;
            //Ghi dữ liệu
            for (int i = 0; i <= rows-1; i++) // duyệt các dòng trong datagrid
            {
                for (int j = 0; j <= columns - 1; j++) // duyệt các cột của mỗi dòng
                {
                    COMExcel.Range r = (COMExcel.Range)exSheet.Cells[i + 1, j + 1];

                    r.Value2 = dataGridView2.Rows[i].Cells[j].Value.ToString();               

                    r.Columns.AutoFit(); // tự động giãn cột
                }
            }

            // Hiển thị chương trình excel
            exApp.Visible = true;

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            _benhnhan.STTBN = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _benhnhan.Hoten = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            _benhnhan.DiaChi = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            _benhnhan.CMND = int.Parse(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            _benhnhan.BacSiPhuTrach = int.Parse(this.dataGridView1.CurrentRow.Cells[5].Value.ToString());
            _benhnhan.GioiTinh = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTinBenhNhan frmCapNhat = new frmCapNhatThongTinBenhNhan();
            frmCapNhat.benhnhan = _benhnhan;
            frmCapNhat.ShowDialog();
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    this.dataGridView2.DataSource = BenhNhanBUS.SelectAllBenhNhanByBacSiAndGioiTinh(int.Parse(this.comboBox1.SelectedValue.ToString()), "Nam");
        //}
       
    }
}
