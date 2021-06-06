using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using System.Security.Cryptography;
using BUS;
using DTO;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using DevComponents.DotNetBar;
using DevExpress.XtraPrinting;

namespace Accounting
{
    public partial class Frm_PrintDialog : Office2007Form
    {
        XtraReport _rp;
        public Frm_PrintDialog(XtraReport rp)
        {
            InitializeComponent();

            _rp = rp;
        }

        private void Frm_PrintDialog_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData.Equals(Keys.Control | Keys.D))
            {
                _rp.ShowDesigner();
            }

            return base.ProcessDialogKey(keyData);
        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            if (radiobttInRaManhinh.Checked == true)
            {
                // Get the report's printing system.
                PrintingSystem ps = _rp.PrintingSystem;

                // Hide the Watermark toolbar button, and also the Watermark menu item.
                ps.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);

                // Show the ExportXls toolbar button.
                ps.SetCommandVisibility(PrintingSystemCommand.ExportFile, CommandVisibility.None);

                ps.SetCommandVisibility(PrintingSystemCommand.SendFile, CommandVisibility.None);


                // Make the "Export to Csv" and "Export to Txt" commands visible
                // only in the window's menu.
                ps.SetCommandVisibility(new PrintingSystemCommand[] { PrintingSystemCommand.ExportCsv, PrintingSystemCommand.ExportTxt }, CommandVisibility.Menu);

                // Show the report's preview.
                _rp.ShowPreview();
            }

            if (radioBttInRaMayIn.Checked == true)
            {
                try
                {
                    _rp.Print();
                }
                catch (Exception loi)
                {
                    MessageBoxEx.Show("Lệnh in bị lỗi do chưa kết nối với máy in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BttCLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttPrintSetup_Click(object sender, EventArgs e)
        {
            _rp.PrintDialog();
        }

        private void Frm_PrintDialog_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Frm_PrintDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

       
    }
}