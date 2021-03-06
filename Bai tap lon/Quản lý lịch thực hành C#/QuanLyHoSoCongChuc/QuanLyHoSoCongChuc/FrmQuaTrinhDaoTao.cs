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
    public partial class FrmQuaTrinhDaoTao : DockContent
    {
        public FrmQuaTrinhDaoTao()
        {
            InitializeComponent();
        }
        QuaTrinhDaoTaoControl m_QTDTControl = new QuaTrinhDaoTaoControl();
        NhanVienControl m_NhanVienControl = new NhanVienControl();
        private void FrmQuaTrinhDaoTao_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_QTDTControl.HienThiTreeView(treeViewNhanVien);
         

        }
        private void dataGridViewDSQTDT_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridViewDSQTDT.Rows.Count; i++)
            {
                dataGridViewDSQTDT.Rows[i].Cells["STT"].Value = Convert.ToString(i + 1);
            }
        }
        private void treeViewNhanVien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null && ((string)e.Node.Tag) != "")
            {
                m_QTDTControl.HienDSDT(dataGridViewDSQTDT, (string)e.Node.Tag);
              
            }
        }

        private void ChucNang_Click(object sender, EventArgs e)
        {
            ChucNangQTDT frm = new ChucNangQTDT();
            frm.Show(DockPanel);

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}