using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTKB
{
    public partial class frmXemTKB : Form
    {
        public frmXemTKB()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();

        private void btntk_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblTKB where Ngay BETWEEN '" + txttn.Text + "' and  '" + txtdn.Text + "'";
            msds.DataSource = cn.taobang(sql);
            khoitaoluoi();
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Ngày";
            msds.Columns[0].Width = 150;
            msds.Columns[0].Frozen = true;

            msds.Columns[1].HeaderText = "Giáo Viên";
            msds.Columns[1].Width = 150;

            msds.Columns[2].HeaderText = "Lớp";
            msds.Columns[2].Width = 150;

            msds.Columns[3].HeaderText = "Môn Học";
            msds.Columns[3].Width = 150;

            msds.Columns[4].HeaderText = "Phòng Học";
            msds.Columns[4].Width = 150;

            msds.Columns[5].HeaderText = "Buổi";
            msds.Columns[5].Width = 150;
        }
    }
}
