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
    public partial class frmDMChucVu : Form
    {
        //khai báo biến toàn cục
        clsdmchucvu c = new clsdmchucvu();
        int k = 0;

        public frmDMChucVu()
        {
            InitializeComponent();
            c.laydl("tbl_DMCHUCVU");
            txtmachucvu.DataBindings.Add("text", c.ds, "tbl_DMChucvu.MaChucVu");
            txttenchucvu.DataBindings.Add("text",c.ds, "tbl_DMChucvu.TenChucVu");
            txtphucap.DataBindings.Add("text", c.ds, "tbl_DMChucvu.PhuCap");
            dgv_DMChucVu.DataSource = c.ds;
            dgv_DMChucVu.DataMember = "tbl_DMChucVu";
        }
        
        public void setbutton(bool b)
        {
            cmdcapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }
        public void settextbox(bool b)
        {
            txtmachucvu.ReadOnly = b;
            txttenchucvu.ReadOnly = b;
            txtphucap.ReadOnly = b;
        }
        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmachucvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Bạn phải nhập số", "Thông Báo");
                return;
            }
        }

        private void txtphucap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Bạn phải nhập số", "Thông Báo");
            }
        }

        private void frmDMChucVu_Load(object sender, EventArgs e)
        {
            settextbox(true);
            setbutton(true);
        }

        private void cmdthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            settextbox(false);
            setbutton(false);
            txtmachucvu.Focus();
            txtmachucvu.Text = "";
            txttenchucvu.Text = "";
            txtphucap.Text = "0";
            k = 1;
        }

        private void cmdcapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMChucVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để cập nhật", "Thông Báo");
                return;
            }
            else
            {
                txttenchucvu.ReadOnly=  false;
                txtphucap.ReadOnly = false;
                txttenchucvu.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMChucVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để xóa", "Thông Báo");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_DMChucvu", int.Parse(txtmachucvu.Text.Trim()), "machucvu");
                    c.laydl("tbl_DMCHUCVU");
                    
                }
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu không??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                {
                    if (txtmachucvu.Text == "" || txttenchucvu.Text == ""||txtphucap.Text =="")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {
                        c.them("tbl_DMCHUCVU", int.Parse(txtmachucvu.Text.Trim()), 
                            txttenchucvu.Text.Trim(),
                            txtphucap.Text!=""?int.Parse(txtphucap.Text.Trim()):0);
                        c.laydl("tbl_DMCHUCVU");
                        k = 0;
                        setbutton(true);
                        settextbox(true);
                    }
                }
                else if (k == 2)
                {
                    if (txtmachucvu.Text == "" || txttenchucvu.Text == "" || txtphucap.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                        c.sua("tbl_DMCHUCVU", int.Parse(txtmachucvu.Text.Trim()),
                            txttenchucvu.Text.Trim(),
                            txtphucap.Text != "" ? int.Parse(txtphucap.Text.Trim()) : 0, "machucvu", "tenchucvu", "phucap");
                }
            }
            c.laydl("tbl_DMCHUCVU");
            settextbox(true);
            setbutton(true);
            k = 0;
        }
    }        
}
