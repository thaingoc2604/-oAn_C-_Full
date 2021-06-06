using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;


namespace QuanLyPhongMach
{
    public partial class frmThemDonThuoc : Form
    {
        public frmThemDonThuoc()
        {
            InitializeComponent();
        }

        private void frmThemDonThuoc_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BenhNhanThuongBUS.SelectAllBenhNhanThuong();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BenhNhanNamGiuong_DaXepChoBUS.SelectAllBenhNhanNamGiuong_DaXepCho();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BenhNhanThuongBUS.SelectAllBenhNhanThuong();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.lbsttBN.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.label2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                this.lbsttBN.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.label2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }

            this.lbthanhcong.Visible = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbtenthuoc.Text != string.Empty && tbtienthuoc.Text != string.Empty)
            {
                if (radioButton1.Checked == true)
                {
                    try
                    {
                        DonThuoc_BenhNhanThuongDTO donthuoc = new DonThuoc_BenhNhanThuongDTO();

                        donthuoc.TenThuoc = tbtenthuoc.Text;
                        donthuoc.TienThuoc = donthuoc.TongTienThuoc(int.Parse(this.tbtienthuoc.Text));
                        donthuoc.NgayCapThuoc = dateTimePicker1.Value;

                        DonThuocBUS.InsertDonThuoc_DonThuocBenhNhanThuong(donthuoc, int.Parse(this.lbsttBN.Text));

                        this.lbthanhcong.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        this.tbtenthuoc.Text = string.Empty;
                        this.tbtienthuoc.Text = string.Empty;
                    }
                }
                else // bệnh nhân nằm giường đã xếp chỗ
                {
                    try
                    {
                        //DonThuocDTO donthuoc = new DonThuocDTO();
                        DonThuoc_BenhNhanNamGiuong_DaXepChoDTO donthuoc = new DonThuoc_BenhNhanNamGiuong_DaXepChoDTO();
                        donthuoc.TenThuoc = tbtenthuoc.Text;
                        int tienthuoc = int.Parse(tbtienthuoc.Text);
                        donthuoc.TienThuoc = donthuoc.TongTienThuoc(tienthuoc);
                        donthuoc.NgayCapThuoc = dateTimePicker1.Value;

                        DonThuocBUS.InsertDonThuoc_DonThuocBenhNhanNamGiuong_DaXepCho(donthuoc,int.Parse(this.lbsttBN.Text));                        

                        this.lbthanhcong.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        this.tbtenthuoc.Text = string.Empty;
                        this.tbtienthuoc.Text = string.Empty;                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu chưa đầy đủ");
            }
        }

        private void tbtienthuoc_Validating(object sender, CancelEventArgs e)
        {
            if (this.tbtienthuoc.Text.Length > 7)
            {
                MessageBox.Show("Tiền không vượt qua hàng triệu VNĐ");
                this.tbtienthuoc.Text = string.Empty;
            }
        }
    }
}
