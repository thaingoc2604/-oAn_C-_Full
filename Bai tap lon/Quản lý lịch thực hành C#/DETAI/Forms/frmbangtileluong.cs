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
    public partial class frmbangtileluong : Form
    {
        //khai báo biến toàn cục
        clsTiLeLuong ctileluong = new clsTiLeLuong();
        clsdmpb cPhong = new clsdmpb();
        clsDMTo cTo = new clsDMTo();
        int k = 0;
        public frmbangtileluong()
        {
            InitializeComponent();
            ctileluong.laydl();
            for (int i = 1; i <= 12; i++)
            {
                cbothang.Items.Add(i);
            }
            for (int i = 2008; i <= 2100; i++)
            {
                cbonam.Items.Add(i);
            }
            cboPhong.DataSource = cPhong.taocombo();
            cboPhong.DisplayMember = "tbl_PhongBan.TenPhong";
            cboPhong.ValueMember = "tbl_PhongBan.MaPhong";

            dgv_TiLeLuong.DataSource = ctileluong.ds;
            dgv_TiLeLuong.DataMember = "TiLeLuong";            
        }
        

        private void frmbangtileluong_Load(object sender, EventArgs e)
        {
            setcmd(true);
            setcontrol(false);
            HienThiDL(dgv_TiLeLuong.Rows[0]);
        }
        //set bộ nút 
        private void setcmd(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdluu.Enabled = !b;
            cmdthoat.Enabled = b;
            cmdthem.Enabled = b;
            cmdxoa.Enabled = b;
        }
        // set control
        private void setcontrol(bool b)
        {
            foreach (Control c in pnlthongtin.Controls)
            {
                if (c.Name.Contains("txt")==true  ||c.Name.Contains("cbo")==true )
                c.Enabled = b;
            }
        }
        //
        private void HienThiDL(DataGridViewRow dgvrow)
        {

            if (dgv_TiLeLuong.CurrentRow!=null)
            {
                DataGridViewRow dr = dgvrow;

                cbothang.Text = dr.Cells["thang"].Value.ToString();
                cbonam.Text = dr.Cells["nam"].Value.ToString();
                cboPhong.Text = dr.Cells["tenphong"].Value.ToString();
                cboto.Text = dr.Cells["tento"].Value.ToString();
                txttll.Text = dr.Cells["tileluong"].Value.ToString();
                txtsongaycong.Text = dr.Cells["songaycong"].Value.ToString();
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboto.DataSource = cTo.taocombo(cboPhong.SelectedValue.ToString());
            cboto.DisplayMember = "DanhMucTo.TenTo";
            cboto.ValueMember = "DanhMucTo.MaTo";
            cboto.Text = "";
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            setcmd(false);
            setcontrol(true);
            txttll.Text = "";
            txtsongaycong.Text = "";
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_TiLeLuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để cập nhật", "Thông Báo");
                return;
            }
            else
            {

                setcmd(false);
                txttll.Enabled = true;
                txtsongaycong.Enabled = true;
                txttll.Focus();
                k = 2;
            }
        }

        private void dgv_TiLeLuong_Click(object sender, EventArgs e)
        {
            HienThiDL(dgv_TiLeLuong.CurrentRow);
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_TiLeLuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn dòng để xóa", "Thông Báo");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn xóa??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    ctileluong.xoa(dgv_TiLeLuong.CurrentRow.Cells["id"].Value.ToString());
                    ctileluong.laydl();
                }
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu lai không?","Thông báo",MessageBoxButtons.YesNo );
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                    if (cboto.SelectedItem != null)
                    {
                        ctileluong.them(int.Parse(cbothang.Text.Trim()),
                                        int.Parse(cbonam.Text.Trim()),
                                        cboPhong.SelectedValue.ToString().Trim(),
                                        cboto.SelectedValue.ToString().Trim(),
                                        txttll.Text != "" ? double.Parse(txttll.Text.Trim()) : 1,
                                        txtsongaycong.Text != "" ? int.Parse(txtsongaycong.Text.Trim()) : 26);
                    }
                    else
                    {
                        ctileluong.them(int.Parse(cbothang.Text.Trim()),
                                        int.Parse(cbonam.Text.Trim()),
                                        cboPhong.SelectedValue.ToString().Trim(),
                                        txttll.Text != "" ? double.Parse(txttll.Text.Trim()) : 1,
                                        txtsongaycong.Text != "" ? int.Parse(txtsongaycong.Text.Trim()) : 26);
                    }
                else
                    if (k == 2)
                    {
                        ctileluong.sua(dgv_TiLeLuong.CurrentRow.Cells["id"].Value.ToString(),
                            txttll.Text != "" ? double.Parse(txttll.Text.Trim()) : 1,
                            txtsongaycong.Text != "" ? int.Parse(txtsongaycong.Text.Trim()) : 26);
                    }
            }
            k = 0;
            setcontrol(false);
            setcmd(true);
            ctileluong.laydl();   
        }

        
    }
}