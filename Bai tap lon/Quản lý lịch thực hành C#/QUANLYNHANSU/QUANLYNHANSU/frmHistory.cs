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
    public partial class frmHistory : Office2007Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }
        clsLayHistory his = new clsLayHistory();
        DataTable dtHis = new DataTable();

        public void Them(string ngaythem, string noidung)
        {
            string malichsu = "LS";

            string masothutu;

            string thang = DateTime.Now.Month.ToString();
            if (thang.Length == 1)
                thang = "0" + thang;

            string nam = DateTime.Now.Year.ToString();
            string nam02 = nam[2].ToString() + nam[3].ToString();

            string thangnam = thang + nam02;

            int phantu = 0;
            dtHis = his.LayHistory();

            foreach (DataRow dr in dtHis.Rows)
            {
                string ma = dr["stt"].ToString();
                string mathangnam = ma[2].ToString() + ma[3].ToString() + ma[4].ToString() + ma[5].ToString();
                string mathutu = ma[6].ToString() + ma[7].ToString() + ma[8].ToString() + ma[9].ToString();

                if (thangnam == mathangnam)
                {
                    int stt = Convert.ToInt32(mathutu);
                    if (stt > phantu)
                        phantu = stt;
                }
            }
            if (phantu != 0)
            {
                phantu++;

                if (phantu.ToString().Length == 1)
                    masothutu = "000" + phantu.ToString();
                else if (phantu.ToString().Length == 2)
                    masothutu = "00" + phantu.ToString();
                else if (phantu.ToString().Length == 3)
                    masothutu = "0" + phantu.ToString();
                else
                    masothutu = phantu.ToString();

                malichsu = malichsu + thangnam + masothutu;
            }
            else
            {
                malichsu = malichsu + thangnam + "0001";
            }
            his.Them(malichsu, ngaythem, noidung);
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = his.LayHistory();
            dtgHistory.DataSource = bs;
            bindingNavigator1.BindingSource = bs;

            dtgHistory.Columns["stt"].Visible = false;
            dtgHistory.Columns["ngaythaotac"].Width = 250;
            dtgHistory.Columns["ngaythaotac"].HeaderText = "Ngày giờ thao tác";
            dtgHistory.Columns["noidung"].Width = 540;
            dtgHistory.Columns["noidung"].HeaderText = "Nội dung thao tác";
        }

        private void frmHistory_Activated(object sender, EventArgs e)
        {
            frmHistory_Load(sender, e);
        }

        private void dtgHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.ForeColor = Color.Olive;
            style1.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.ForeColor = Color.MediumBlue;
            style2.BackColor = Color.Pink;
            for (int i = dtgHistory.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    dtgHistory.Rows[i].DefaultCellStyle = style1;
                else
                    dtgHistory.Rows[i].DefaultCellStyle = style2;
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] malichsu = new string[1000];

            for (int i = 0; i < dtgHistory.SelectedRows.Count; i++)
            {
                malichsu[i] = dtgHistory["stt", dtgHistory.SelectedRows[i].Index].Value.ToString();
            }

            for (int i = 0; i < malichsu.Length; i++)
            {
                if (malichsu[i] != null)
                    his.Xoa(malichsu[i]);
                else
                    break;
            }
            frmHistory_Load(sender, e);
        }

        private void xóaHếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            his.XoaHet();
            frmHistory_Load(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            xóaToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            xóaHếtToolStripMenuItem_Click(sender, e);
        }
    }
}