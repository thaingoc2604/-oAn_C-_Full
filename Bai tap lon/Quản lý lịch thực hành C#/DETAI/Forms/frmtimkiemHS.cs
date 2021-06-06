using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DETAI
{
    public partial class frmtimkiemHS : Form
    {
        //khai báo biến toàn cục
        clstimkiemhs c = new clstimkiemhs();
        clsdmchucvu ccv = new clsdmchucvu();
        clsdmtongiao ctg = new clsdmtongiao();
        clsDMDanToc cdt = new clsDMDanToc();
        clsDMTo cto = new clsDMTo();
        static public string dk;
        public frmtimkiemHS()
        {
            InitializeComponent();
            dgv_NV.DataSource = c.laydl();
            dgv_NV.DataMember = "TC_NV";
            cbocv.DataSource = ccv.taocombo();
            cbocv.DisplayMember = "DMChucVu.TenChucVu";
            cbocv.ValueMember = "DMChucVu.MaChucVu";
            cbotg.DataSource = ctg.taocombo();
            cbotg.DisplayMember = "DMTonGiao.TenTG";
            cbotg.ValueMember = "DMTonGiao.MaTG";
            cbodt.DataSource = cdt.taocombo();
            cbodt.DisplayMember = "DMDanToc.TenDT";
            cbodt.ValueMember = "DMDanToc.MaDT";
            cbophai.Items.AddRange (new string []{"Nữ","Nam"});
            cbohonnhan.Items.AddRange(new string[] { "Độc Thân", "Có Gia Đình", "Đã Kết Hôn" });
            cbodau.Items.AddRange(new string[] {"<","<=","=",">",">=" });
            cbodautuoi.Items.AddRange(new string[] { "<", "<=", "=", ">", ">=" });           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdtim_Click(object sender, EventArgs e)
        {
            dk = "";
            if (txtho.Text != "")
            {
                dk = dk + " ho like N'" + txtho.Text.Trim() + "%'";
            }
            if (txtten.Text != "")
            {
                dk = dk + " and ten like N'" + txtten.Text.Trim() + "%'";
            }
            if (txtthangsinh.Text != "")
            {
                dk = dk + " and thangsinh = " + int.Parse(txtthangsinh.Text.Trim());
            }
            if (txttuoi.Text != "")
            {
                dk = dk + " and tuoi " +cbodautuoi.Text.Trim() + int.Parse(txttuoi.Text.Trim());
            }
            if (cbodt.SelectedItem  != null)
            {
                dk = dk + " and madt = " + int.Parse(cbodt.SelectedValue.ToString());
            }
            if (cbotg.SelectedItem != null)
            {
                dk = dk + " and matg = " + int.Parse(cbotg.SelectedValue.ToString());
            }
            if (cbophai.SelectedItem != null)
            {
                dk = dk + " and phai like N'" + cbophai.Text.Trim() + "%'";
            }
            if (cbocv.SelectedItem != null)
            {
                dk = dk + " and machucvu  = " + int.Parse(cbocv.SelectedValue.ToString());
            }
            if (txtnam.Text != "" )
            {
                dk = dk + " and thamnien " + cbodau.Text.Trim() + " " + int.Parse(txtnam.Text.Trim());
            }
            if (cbohonnhan.SelectedItem != null)
            {
                dk = dk + " and tinhtranghonnhan like N'" + cbohonnhan.Text.Trim() + "%'";
            }
            if (dk == "")
            {
                dgv_NV.DataSource = c.laydl();
                dgv_NV.DataMember = "TC_NV";
            }
            else
            {
                if (dk.Substring(0, 4) == " and")
                    dk = dk.Substring(5);
                dgv_NV.DataSource = c.laydl(dk);
                dgv_NV.DataMember = "TC_NV";
            }

        }

        private void txtthangsinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }
        private void txttuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }
        private void frmtimkiemHS_Load(object sender, EventArgs e)
        {
            dk = "";
        }

        
       
    }
}