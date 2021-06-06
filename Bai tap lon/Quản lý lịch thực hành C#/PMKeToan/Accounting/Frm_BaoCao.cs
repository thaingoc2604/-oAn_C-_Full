using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Janus.Windows.UI.CommandBars;

using BUS;
using DTO;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using DevComponents.DotNetBar;


namespace Accounting
{
    public partial class Frm_BaoCao : Office2007Form
    {
        TKThuChi_BUS tk_bus;
        SODu_BUS _sd_BUS;
        DataSet _ds;
        XtraReport _rp;
        TKThuChi_DTO _tk_DTO;

        HeThong_BUS _th_BUS;

        DateTime _tuthang;

        DateTime _denthang;

        public Frm_BaoCao()
        {
            InitializeComponent();

            _tk_DTO = new TKThuChi_DTO();

            tk_bus = new TKThuChi_BUS();


            _th_BUS = new HeThong_BUS();
            _sd_BUS = new SODu_BUS();

            _ds = new DataSet();

           
        }



        private void Frm_BaoCao_Load(object sender, EventArgs e)
        {
            //if (DateTime.Now.Month < 10)
            //    mtxtTuThang.Text = "0" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            //else
            //    mtxtTuThang.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

        }

       

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReport11_InitReport(object sender, EventArgs e)
        {

        }

        private void uiCommandBar1_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {

        }

        void LoadReportFromFile(XtraReport report, string filePath)
        {
            if (File.Exists(filePath))
            {
                report.LoadLayout(filePath);
            }
            else
            {
                MessageBoxEx.Show("Không tìm thấy Report!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bttBaoCao_Click(object sender, EventArgs e)
        {
            _tuthang = DateTime.Parse(mtxtTuThang.Text);

            _denthang = DateTime.Parse(mtxtDenthang.Text);

            DateTime ngaythang_SoDu = new DateTime(_tuthang.Year, _tuthang.Month, _tuthang.Day);
            //MessageBox.Show(ngaythang_SoDu.ToString());
            //MessageBox.Show(ngaythang_SoDu.AddDays(-1).ToString());
            Int64 sodukytruoc = _sd_BUS.get_So_Du_Theo_Ngay(ngaythang_SoDu.AddDays(-1));
            //String.Format("{0:0,0}", sodukytruoc)
            //MessageBox.Show(sodukytruoc.ToString());

            _rp = new XtraReport(mtxtTuThang.Text, mtxtDenthang.Text, String.Format("{0:0,0}", sodukytruoc), 2, _th_BUS.LayTenCty(), _th_BUS.LayTenCtyChuQuan());


            string filepath = Application.StartupPath + "/Repo/BaoCaoThang.repx";

            LoadReportFromFile(_rp, filepath);


            if (_ds.Tables.Count >= 1)
            {
                _ds.Tables.RemoveAt(0);

            }

            DataTable tb_TongHop = tk_bus.GetDSTK_ThuChi_TheoGiaiDoan(DateTime.Parse(mtxtTuThang.Text), DateTime.Parse(mtxtDenthang.Text));


            _ds.Tables.Add(tb_TongHop);

            _rp.DataSource = _ds.Tables[0];

            Frm_PrintDialog frm_printdlg = new Frm_PrintDialog(_rp);


            frm_printdlg.ShowDialog();
        }

        private void Frm_BaoCao_Activated(object sender, EventArgs e)
        {
            mtxtTuThang.Focus();
        }

        private void mtxtThang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                mtxtDenthang.Focus();
            }
        }

        private void mtxtDenthang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                bttBaoCao.Focus();
            }
        } 

    }
}