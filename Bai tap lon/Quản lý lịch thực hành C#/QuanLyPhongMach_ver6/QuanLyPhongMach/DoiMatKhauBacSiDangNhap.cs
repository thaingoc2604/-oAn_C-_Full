using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyPhongMach
{
    public partial class frmDoiThongTinCaNhan : Form
    {
        public BacSiDTO bacsi = new BacSiDTO();
        public frmDoiThongTinCaNhan()
        {
            InitializeComponent();
        }
        
        private void frmDoiMatKhauBacSiDangNhap_Load(object sender, EventArgs e)
        {
            this.tbTenBS.Text = bacsi.TenBacSi;
            this.textBox1.Text = bacsi.DiaChi;
            this.textBox2.Text = bacsi.SoDienThoai.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
            if (this.tbmatkhauCu.Text != string.Empty && this.tbMatkhauMoi.Text != string.Empty)
            {                
                if (this.tbmatkhauCu.Text == bacsi.PassWord)
                {                    
                    BacSiBUS.ChangePassWord(bacsi,this.tbMatkhauMoi.Text);
                    this.label4.Visible = true;
                }
                else
                    MessageBox.Show("Mật khẩu không đúng");
            }
            else
                MessageBox.Show("Thông tin chưa đầy đủ");
        }

        private void btThayDoiThongTin_Click(object sender, EventArgs e)
        {            
            bacsi.DiaChi = this.textBox1.Text;
            bacsi.SoDienThoai = float.Parse(this.textBox2.Text);

            BacSiBUS.UpdateBacSi(bacsi);
            this.label7.Visible = true;
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (this.textBox2.TextLength < 7 || this.textBox2.TextLength > 11)
            {
                MessageBox.Show("Số điện thoại không đúng!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
        }
    }
}
