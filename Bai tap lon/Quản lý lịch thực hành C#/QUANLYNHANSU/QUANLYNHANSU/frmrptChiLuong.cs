using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QUANLYNHANSU.GetData;

namespace QUANLYNHANSU
{
    public partial class frmrptChiLuong : Office2007Form
    {
        public frmrptChiLuong()
        {
            InitializeComponent();
        }
        clsLayBangChiLuong chiluong = new clsLayBangChiLuong();
        clsLayPhongBan phongban = new clsLayPhongBan();
        rptBangLuong report = new rptBangLuong();
        DataTable dtChiLuong = new DataTable();

        private void bntXuat_Click(object sender, EventArgs e)
        {
            string thang = cmbThang.SelectedItem.ToString();
            string nam = cmbNam.SelectedItem.ToString();
            thang = thang[6].ToString() + thang[7].ToString();
            nam = nam[4].ToString() + nam[5].ToString() + nam[6].ToString() + nam[7].ToString();

            if (cmbPhongBan.SelectedValue != null)
                dtChiLuong = chiluong.LayBangChiLuongTheoThangNamPhongBanTheoTenNV(Convert.ToInt32(thang), Convert.ToInt32(nam), cmbPhongBan.SelectedValue.ToString());
            if (dtChiLuong.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chấm công tháng năm này!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                crystalReportViewer1.ReportSource = null;
            }
            else
            {
                report.SetDataSource(dtChiLuong);
                crystalReportViewer1.ReportSource = report;

                progressBarX1.Show();

                for (int i = 0; i < 100; i++)
                {
                    progressBarX1.Text = i.ToString() + "%";
                    System.Threading.Thread.Sleep(15);
                    progressBarX1.Value = i;
                }

                crystalReportViewer1.Zoom(85);
                progressBarX1.Hide();
            }
        }

        private void frmrptChiLuong_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                cmbThang.Items.Add("Tháng 0" + i);
            }
            for (int i = 10; i < 13; i++)
            {
                cmbThang.Items.Add("Tháng " + i);
            }
            cmbThang.SelectedIndex = 0;
            for (int i = 1900; i < 2301; i++)
            {
                cmbNam.Items.Add("Năm " + i);
            }
            cmbNam.SelectedIndex = 109;

            cmbPhongBan.DataSource = phongban.LayPhongBan();
            cmbPhongBan.DisplayMember = "tenphong";
            cmbPhongBan.ValueMember = "maphong";
            //cmbPhongBan.Items.Add("Tất cả");

            progressBarX1.Hide();
        }
    }
}