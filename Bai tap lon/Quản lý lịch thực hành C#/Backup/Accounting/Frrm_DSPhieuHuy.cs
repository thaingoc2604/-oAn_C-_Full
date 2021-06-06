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
    public partial class Frrm_DSPhieuHuy : Office2007Form
    {
        TKThuChi_BUS tk_bus;

        static int count = 0;

        public Frrm_DSPhieuHuy()
        {
            InitializeComponent();

            tk_bus = new TKThuChi_BUS();
        }

        private void Frrm_DSPhieuHuy_Load(object sender, EventArgs e)
        {
            TKThuChiGrid.DataSource = tk_bus.GetDSTK_PhieuDaHuy();

        }

        private void Frrm_DSPhieuHuy_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TKThuChiGrid_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void TKThuChiGrid_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(count.ToString());
        }

        private void TKThuChiGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            int fla = 0;

            if (e.KeyChar.ToString() == "")
            {
                DataTable table = TKThuChiGrid.DataSource as DataTable;
                for (int i = 0; i < TKThuChiGrid.RowCount; i++)
                {
                    Janus.Windows.GridEX.GridEXRow RowEx = TKThuChiGrid.GetRow(i);

                    if ((bool)RowEx.Cells["Chon"].Value == true)
                    {
                        fla = 1;

                        TKThuChi_DTO _tk_DTO = new TKThuChi_DTO();

                        _tk_DTO.Maso = int.Parse(RowEx.Cells["stt"].Value.ToString());
                        if (tk_bus.Khoi_Phuc_Phieu(_tk_DTO) == 1)
                        {
                            MessageBoxEx.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        RowEx.Delete();
                    }
                }

                if (fla == 0)
                {
                    MessageBoxEx.Show("Chưa chọn phiếu cần khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}