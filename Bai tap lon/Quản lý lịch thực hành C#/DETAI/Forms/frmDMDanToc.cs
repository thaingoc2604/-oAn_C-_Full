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
    public partial class frmDMDanToc : Form
    {
        //khai báo biến toàn cục
        clsDMDanToc  c = new clsDMDanToc();
        int k = 0;
        public frmDMDanToc()
        {
            
            InitializeComponent();
            c.laydl("tbl_DMDanToc");
            //lấy dữ liệu ra textbox
            txtmadantoc.DataBindings.Add("text",c.ds , "tbl_DMDanToc.MaDT");
            txttendantoc.DataBindings.Add("text",c.ds, "tbl_DMDanToc.TenDT");
            dgv_DMDanToc.DataSource = c.ds;
            dgv_DMDanToc.DataMember = "tbl_DMDanToc";
            

        }
        //set bộ nút
        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }

        private void frmDMDanToc_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void txtmadantoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");       
            }       
        }
        private void cmdthem_Click_1(object sender, EventArgs e)
        {
            txtmadantoc.Text = "";
            txttendantoc.Text = "";
            txtmadantoc.ReadOnly = false;
            txttendantoc.ReadOnly = false;
            txtmadantoc.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCapnhat_Click_1(object sender, EventArgs e)
        {
            if (dgv_DMDanToc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để cập nhật", "Thông Báo");
                return;
            }
            else
            {
                txttendantoc.ReadOnly = false;
                txttendantoc.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdxoa_Click_1(object sender, EventArgs e)
        {
            if (dgv_DMDanToc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để xóa", "Thông Báo");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {

                    c.xoa("tbl_DMDanToc", int.Parse(txtmadantoc.Text.Trim()), "MaDT");
                    c.laydl("tbl_DMDanToc");

                }
            }
        }
        private void cmdluu_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu không??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                {
                    if (txtmadantoc.Text == "" || txttendantoc.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {
                        c.them("tbl_DMDanToc", int.Parse(txtmadantoc.Text.Trim()), txttendantoc.Text.Trim());
                        c.laydl("tbl_DMDanToc");
                        txtmadantoc.ReadOnly = true;
                        txttendantoc.ReadOnly = true;
                        k = 0;
                        setbutton(true); 
                    }
                }
                else if (k == 2)
                    if (txtmadantoc.Text == "" || txttendantoc.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {
                        c.sua("tbl_DMDanToc", int.Parse(txtmadantoc.Text.Trim()), txttendantoc.Text.Trim(), "MaDT", "TenDT");
                    } 
            }
            c.laydl("tbl_DMDanToc");
            txtmadantoc.ReadOnly = true;
            txttendantoc.ReadOnly = true;
            setbutton(true);
            k = 0;
        }
    }
}