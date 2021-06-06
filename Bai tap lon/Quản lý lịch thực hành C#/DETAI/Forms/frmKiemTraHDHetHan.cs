using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmKiemTraHDHetHan : Form
    {
        //khai báo biến toàn cục
        clschitiethopdong chopdong = new clschitiethopdong();
        static public string dk = "";

        public frmKiemTraHDHetHan()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbothangkt.Items.Add(i);
            }
            for (int i = 2008; i <= 2100; i++)
            {
                cbonamkt.Items.Add(i);
            }
        }

        private void cbonamkt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdxem_Click(object sender, EventArgs e)
        {
            
            if (cbothangkt.Text == "" || cbonamkt.Text == "")
                MessageBox.Show("Bạn phải chọn tháng và năm.", "Thông báo");
            else 
            {
                if(cbothangkt.Text.Trim()=="12")
                {
                    dk = " ngaykt <='12/31/" + int.Parse(cbonamkt.Text.Trim()) + "'";
                    dgv_NV_HopDong.DataSource = chopdong.layNV_HDhethan(dk);
                }
                else
                {
                    dk = " ngaykt <='" + (int.Parse(cbothangkt.Text.Trim()) + 1) + "/1/" + int.Parse(cbonamkt.Text.Trim()) + "'";
                    dgv_NV_HopDong.DataSource = chopdong.layNV_HDhethan(dk);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dk != "")
            {
                frmrptNV_HDhethan f = new frmrptNV_HDhethan();
                f.MdiParent = this.ParentForm;
                f.Show();
            }
            else
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
           
        }

        private void frmKiemTraHDHetHan_Load(object sender, EventArgs e)
        {

        }
    }
}