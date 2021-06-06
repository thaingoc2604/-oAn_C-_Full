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
    public partial class frmDMTo : Form
    {
        //khai báo biến toàn cục
        clsDMTo c = new clsDMTo();
        clsdmpb cPhong = new clsdmpb();
        int k = 0;
        public frmDMTo()
        {
            InitializeComponent();
            c.laydldmto();            
            cbomaphong.DataSource =cPhong.taocombo ();
            cbomaphong.DisplayMember = "tbl_PhongBan.TenPhong";
            cbomaphong.ValueMember = "tbl_PhongBan.MaPhong";
            txtmato.DataBindings.Add("text", c.ds, "phongto.MaTo");
            txttento.DataBindings.Add("text", c.ds, "phongto.TenTo");
            cbomaphong.DataBindings.Add("text", c.ds, "phongto.tenPhong");
            dgv_DMTO.DataSource = c.ds;
            dgv_DMTO.DataMember = "phongto";
            
        }
        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }
        public void settextbox(bool b)
        {
            txtmato.ReadOnly = b;
            txttento.ReadOnly = b;
            cbomaphong.Enabled = !b;
        }

        private void frmDMTo_Load(object sender, EventArgs e)
        {
            settextbox(true);
            setbutton(true);
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            settextbox(false);
            setbutton(false);
            txtmato.Focus();
            txtmato.Text = "";
            txttento.Text = "";
            
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMTO.SelectedRows.Count == 0)
                MessageBox.Show("Ban can chon dong de cap nhat", "Thong bao");
            else
            {
                settextbox(false);
                txttento.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMTO.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để xóa", "Thông Báo");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_danhmucto", txtmato.Text.Trim(), "mato",3);
                    c.laydldmto();
                    
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
                    if (txtmato.Text == "" || txttento.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {
                        c.them("tbl_DanhMucTo", txtmato.Text.Trim(),
                            cbomaphong.SelectedValue.ToString().Trim(),
                            txttento.Text.Trim());

                    }
                }
                else if (k == 2)
                {
                    if (txtmato.Text == "" || txttento.Text == "")
                    {
                        MessageBox.Show(this, "bạn phải nhập đầy đủ thông tin vào", "Thông báo");
                        return;
                    }
                    else
                    {
                        c.suato("tbl_DanhMucTo", txtmato.Text.Trim(),
                            cbomaphong.SelectedValue.ToString().Trim(), txttento.Text.Trim(),
                            "mato", "maphong", "tento");
                    }
                }
            }
            c.laydldmto();
            settextbox(true);
            setbutton(true);
            k = 0;
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}