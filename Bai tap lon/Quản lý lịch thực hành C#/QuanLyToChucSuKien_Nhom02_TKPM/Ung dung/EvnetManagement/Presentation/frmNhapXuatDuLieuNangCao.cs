using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EventManager.Utilities;
using System.Data.SqlClient;
using System.Data;
using EventManager.Enums;
using EventManager.Business;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using System.Text;

namespace EventManager.Presentation
{
    public partial class frmNhapXuatDuLieuNangCao : XtraForm
    {
        public frmNhapXuatDuLieuNangCao()
        {
            InitializeComponent();
        }
        string tenBang = "";

        private void frmNhapXuatDuLieuNangCao_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTables();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
        
        /// <summary>
        /// Loads list of user tables from the SQL database, and fills
        ///a ListBox control with tatble names
        /// </summary>
        private void LoadTables()
        {
            try
            {
                // Conncets to database, and selects the table names.
                SqlConnection cn = new SqlConnection(EventManager.Properties.Settings.Default.ConnectString);
                SqlDataAdapter da = new SqlDataAdapter("select name from dbo.sysobjects where xtype = 'U' and name <> 'dtproperties' order by name", cn);
                DataTable dt = new DataTable();

                // Fills the list to an DataTable.
                da.Fill(dt);

                // Clears the ListBox
                this.lsvTables.Items.Clear();

                // Fills the table names to the ListBox.
                // Notifies user if there is no user table in the database yet.
                if (dt.Rows.Count == 0)
                {
                    MsgboxUtil.Exclamation("Không tồn tại bất kỳ bảng nào trong CSDL: " + EventManager.Properties.Settings.Default.DatabaseName);
                    this.lsvTables.Items.Add("< Không tồn tại bảng nào >");
                    this.btnExportToExcel.Enabled = false;
                }
                else
                {
                    this.btnExportToExcel.Enabled = true;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString() != "sysdiagrams")
                            this.lsvTables.Items.Add(new ListViewItem(dt.Rows[i][0].ToString()) { ImageIndex = 0 });
                    }
                    this.lsvTables.Items[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lsvTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //bang chi tiet chuong trinh
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.ChiTietCT.ToString())
                {
                    tenBang = "ChiTietCT";
                    gridControl1.DataSource = (new HopDongBUS()).LayDuLieu();
                    return;
                }
                //bang chuong trinh
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.ChuongTrinh.ToString())
                {
                    tenBang = "ChuongTrinh";
                    gridControl1.DataSource = (new ChuongTrinhBUS()).LayDuLieu();
                    return;
                }
                //bang ke hoach chi tra
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.KeHoachChiTra.ToString())
                {
                    tenBang = "KeHoachChiTra";
                    gridControl1.DataSource = (new KeHoachChiTraBUS()).LayDuLieu();
                    return;
                }
                //bang khach hang
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.KhachHang.ToString())
                {
                    tenBang = "KhachHang";
                    gridControl1.DataSource = (new KhachHangBUS()).LayDuLieu();
                    return;
                }
                //bang nguoi dung
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.NguoiDung.ToString())
                {
                    tenBang = "NguoiDung";
                    gridControl1.DataSource = (new NguoiDungBUS()).LayDuLieu();
                    return;
                }
                //bang nhan vien
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.NhanVien.ToString())
                {
                    tenBang = "NhanVien";
                    gridControl1.DataSource = (new NhanVienBUS()).LayDuLieu();
                    return;
                }
                //bang Phí phat
                if (lsvTables.Items[GetSelectedItemIndex()].Text == TableNames.PhiPhat.ToString())
                {
                    tenBang = "PhiPhat";
                    gridControl1.DataSource = (new PhiPhatBUS()).LayDuLieu();
                    return; 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetSelectedItemIndex()
        {
            for (int i = 0; i < lsvTables.Items.Count; i++)
            {
                if (lsvTables.Items[i].Selected) { return i; }
            }
            return 0;
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable source = ((GridControl)sender).DataSource as DataTable;
                gridView1.Columns.Clear();
                foreach (DataColumn clo in source.Columns)
                {
                    GridColumn x = new GridColumn()
                    {
                        FieldName = clo.ColumnName,
                        Caption = clo.ColumnName,
                        Visible = true
                    };
                    gridView1.Columns.Add(x);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel 2007-2010 (*.xlsx)|*.xlsx|All file (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    XlsxExportOptions tuyChinh = new XlsxExportOptions()
                    {
                        SheetName = tenBang,
                        ShowGridLines = true, 
                        ExportMode = XlsxExportMode.SingleFile, 
                        TextExportMode= TextExportMode.Value
                    };

                    gridControl1.ExportToXlsx(save.FileName, tuyChinh);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "CSV file (*.csv)|*.csv|All file (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    CsvExportOptions tuyChinh = new CsvExportOptions()
                    {
                        TextExportMode = TextExportMode.Value,
                        Encoding = Encoding.UTF8,
                        Separator = "#",
                    };

                    gridControl1.ExportToCsv(save.FileName, tuyChinh);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel 2007-2010 (*.xlsx)|*.xlsx|All file (*.*)|*.*";
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (tenBang == "KhachHang")
                    {
                        (new KhachHangBUS()).NhapTuExcel(open.FileName);
                    }
                    this.lsvTables.Items[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}