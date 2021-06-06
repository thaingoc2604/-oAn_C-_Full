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
    public partial class TKDocGia : Form
    {

        fromDocGia frmdocgia= new fromDocGia();
        AccessHelper help = new AccessHelper();
        public TKDocGia()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
            
        }

        private void TKDocGia_Load(object sender, EventArgs e)
        {
            string TruyVan = "Select madocgia,HoTen,DiaChi,DienThoai from TableDocGia";
            frmdocgia.TableDocGia = help.TaoTable(TruyVan);
            label1.Text = "Tổng số độc giả : " + frmdocgia.TableDocGia.Rows.Count.ToString();
            label2.Text = "Người Đăng Nhập : " + AccessHelper.TenNhanVienDangNhap.ToString();
             ListViewItem item;
            listDocGia.Items.Clear();

            for (int i = 0; i < frmdocgia.TableDocGia.Rows.Count; i++)
            {

                item = listDocGia.Items.Add(frmdocgia.TableDocGia.Rows[i][0].ToString());
                for (int j = 1; j < frmdocgia.TableDocGia.Columns.Count; j++)
                    item.SubItems.Add(frmdocgia.TableDocGia.Rows[i][j].ToString());
            }
            Form1.DaMo[7] = 1;
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }

        private void TKDocGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[7] = 0;
        }


    }
}
