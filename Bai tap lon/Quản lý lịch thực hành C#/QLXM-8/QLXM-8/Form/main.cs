using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLXM_8
{
    public partial class main :DevComponents.DotNetBar.Office2007RibbonForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int chuchay = 10;
        /* private void timer1_Tick(object sender, EventArgs e)
        {
            labelX1.Left += chuchay;
            if (labelX1.Left >= this.Width - labelX1.Width || labelX1.Left <= 0)
                chuchay = -chuchay;
        } */
        // Kiểm tra sự tồn tại của form trước khi gọi 
        Boolean KiemTraTonTai(string Frmname)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }
        // End Kiểm tra sự tồn tại của form.

        private void btn_about_Click(object sender, EventArgs e)
        {

            if(KiemTraTonTai("about") == false)
            {
            about frmabout = new about();
            frmabout.MdiParent = this;
            labelX1.Visible = false;
            frmabout.Show();
            }
        }

        private void btnql_kh_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlkh") == false)
            {
                qlkh frmqlkh = new qlkh();
                frmqlkh.MdiParent = this;
                labelX1.Visible = false;
                frmqlkh.Show();
            }
        }

        private void btnql_ncc_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlncc") == false)
            {
                qlncc frmqlncc = new qlncc();
                frmqlncc.MdiParent = this;
                labelX1.Visible = false;
                frmqlncc.Show();
            }
        }

        private void btnql_xe_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlxe") == false)
            {
                qlxe frmqlxe = new qlxe();
                frmqlxe.MdiParent = this;
                labelX1.Visible = false;
                frmqlxe.Show();
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("hoadontt") == false)
            {
                hoadontt frmhoadontt = new hoadontt();
                frmhoadontt.MdiParent = this;
                labelX1.Visible = false;
                frmhoadontt.Show();
            }
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlhdbh") == false)
            {
                qlhdbh frmqlhdbh = new qlhdbh();
                frmqlhdbh.MdiParent = this;
                labelX1.Visible = false;
                frmqlhdbh.Show();
            }
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlnhomxe") == false)
            {
                qlnhomxe frmqlnhomxe = new qlnhomxe();
                frmqlnhomxe.MdiParent = this;
                labelX1.Visible = false;
                frmqlnhomxe.Show();
            }
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlphieunhap") == false)
            {
                qlphieunhap frmqlphieunhap = new qlphieunhap();
                frmqlphieunhap.MdiParent = this;
                labelX1.Visible = false;
                frmqlphieunhap.Show();
            }
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlbaohanh") == false)
            {
                qlbaohanh frmbaohanh = new qlbaohanh();
                frmbaohanh.MdiParent = this;
                labelX1.Visible = false;
                frmbaohanh.Show();
            }
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("qlnhanvien") == false)
            {
                qlnhanvien frmqlnhanvien = new qlnhanvien();
                frmqlnhanvien.MdiParent = this;
                labelX1.Visible = false;
                frmqlnhanvien.Show();
            }
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkkhach") == false)
            {
                tkkhach frmtimkiemkhach = new tkkhach();
                frmtimkiemkhach.MdiParent = this;
                labelX1.Visible = false;
                frmtimkiemkhach.Show();
            }
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkncc") == false)
            {
                tkncc frmtkncc = new tkncc();
                frmtkncc.MdiParent = this;
                labelX1.Visible = false;
                frmtkncc.Show();
            }
        }

        private void buttonItem15_Click_1(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkhoadontt") == false)
            {
                tkhoadontt frmtkhdtt = new tkhoadontt();
                frmtkhdtt.MdiParent = this;
                labelX1.Visible = false;
                frmtkhdtt.Show();
            }
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkhoadonbanhang") == false)
            {
                tkhoadonbanhang frmtkhdbanhang = new tkhoadonbanhang();
                frmtkhdbanhang.MdiParent = this;
                labelX1.Visible = false;
                frmtkhdbanhang.Show();
            }
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tkphieunhap") == false)
            {
                tkphieunhap frmtkphieunhap = new tkphieunhap();
                frmtkphieunhap.MdiParent = this;
                labelX1.Visible = false;
                frmtkphieunhap.Show();
            }
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("tknhanvien") == false)
            {
                tknhanvien frmtknhanvien = new tknhanvien();
                frmtknhanvien.MdiParent = this;
                labelX1.Visible = false;
                frmtknhanvien.Show();
            }
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("RPKhachhang") == false)
            {
                RPKhachhang frmrpkhachhang = new RPKhachhang();
                frmrpkhachhang.MdiParent = this;
                labelX1.Visible = false;
                frmrpkhachhang.Show();
            }
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("RPBanhang") == false)
            {
                RPBanhang frmrpbanhang = new RPBanhang();
                frmrpbanhang.MdiParent = this;
                labelX1.Visible = false;
                frmrpbanhang.Show();
            }
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("RPNhaphang") == false)
            {
                RPNhaphang nhaphangrp = new RPNhaphang();
                nhaphangrp.MdiParent = this;
                labelX1.Visible = false;
                nhaphangrp.Show();
            }
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {

        }

    }
}
