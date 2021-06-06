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
    public partial class frmTraCuuDanhSachBenhNhanDaDieuTri : Form
    {
        public BacSiDTO bacsi = new BacSiDTO(); 
        public frmTraCuuDanhSachBenhNhanDaDieuTri()
        {
            InitializeComponent();
        }

        private void frmTraCuuDanhSachBenhNhanDaDieuTri_Load(object sender, EventArgs e)
        {
            this.dgvDanhSachBenhNhan.DataSource = BenhNhanBUS.SelectAllBenhNhanByBacSiDieuTri(this.bacsi.sttBS);
        }

        private void btXuatEcel_Click(object sender, EventArgs e)
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

            int rows = dgvDanhSachBenhNhan.Rows.Count;
            int columns = dgvDanhSachBenhNhan.Columns.Count;
            //Ghi dữ liệu
            for (int i = 0; i <= rows - 1; i++) // duyệt các dòng trong datagrid
            {
                for (int j = 0; j <= columns - 1; j++) // duyệt các cột của mỗi dòng
                {
                    COMExcel.Range r = (COMExcel.Range)exSheet.Cells[i + 1, j + 1];

                    r.Value2 = dgvDanhSachBenhNhan.Rows[i].Cells[j].Value.ToString();
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[j].Value.ToString());

                    r.Columns.AutoFit(); // tự động giãn cột
                }
            }

            // Hiển thị chương trình excel
            exApp.Visible = true;

            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
