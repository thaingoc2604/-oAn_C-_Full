using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmQuanLyDonVi : DockContent
    {
        public FrmQuanLyDonVi()
        {
            InitializeComponent();
        }

        DonViControl m_DonViConTrol = new DonViControl();
        private void FrmDonVi_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_DonViConTrol.HienThiTreeView(tvPhongBan);

        }
        private void dataGridViewDSNhanVien_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridViewDSNhanVien.Rows.Count; i++)
            {
                dataGridViewDSNhanVien.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }

        private void tvPhongBan_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && ((string)e.Node.Tag) != "")
            {
                m_DonViConTrol.HienDSDonVi(dataGridViewDSNhanVien, (string)e.Node.Tag);

            }
        }

        private void dataGridViewDSNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5))
            {

                m_DonViConTrol.HienThiDataGridView(dataGridViewDSNhanVien);

            }
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            FrmDonVi frm = new FrmDonVi();
            frm.Show(DockPanel);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}