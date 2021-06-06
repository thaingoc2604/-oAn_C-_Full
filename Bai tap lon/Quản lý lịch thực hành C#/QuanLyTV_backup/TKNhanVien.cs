using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace QuanLyTV
{
    public partial class TKNhanVien : Form
    {
        fromNhanVien frmNhanVien = new fromNhanVien();
        AccessHelper help = new AccessHelper();
        public TKNhanVien()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }

        private void TKNhanVien_Load(object sender, EventArgs e)
        {
            string TruyVan = "Select manhanvien,HoTen,ChucVu from TableNhanVien";
            frmNhanVien.TableNhanVien = help.TaoTable(TruyVan);
            label1.Text = "Tổng số nhân viên : " + frmNhanVien.TableNhanVien.Rows.Count.ToString();
            label2.Text = "Người Đăng Nhập : " + AccessHelper.TenNhanVienDangNhap.ToString();
            ListViewItem item;
            listNhanVien.Items.Clear();

            for (int i = 0; i < frmNhanVien.TableNhanVien.Rows.Count; i++)
            {

                item = listNhanVien.Items.Add(frmNhanVien.TableNhanVien.Rows[i][0].ToString());
                for (int j = 1; j < frmNhanVien.TableNhanVien.Columns.Count; j++)
                    item.SubItems.Add(frmNhanVien.TableNhanVien.Rows[i][j].ToString());
            }
            Form1.DaMo[8] = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }

        private void TKNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[8] = 0;
        }

       
    }
}
