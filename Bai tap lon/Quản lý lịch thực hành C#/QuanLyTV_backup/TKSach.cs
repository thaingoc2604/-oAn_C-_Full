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
    public partial class TKSach : Form
    {
        public TKSach()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }
        AccessHelper help = new AccessHelper();
        LuuTruSach frmSach = new LuuTruSach();

        private void TKSach_Load(object sender, EventArgs e)
        {
            int tongso = 0;
            string TruyVan = "Select masach,TenSach,SoLuong from TableSach";
           frmSach.TableSach = help.TaoTable(TruyVan);
           label1.Text = "Tổng số sách : " + frmSach.TableSach.Rows.Count.ToString();
           label2.Text = "Người Đăng Nhập : " + AccessHelper.TenNhanVienDangNhap.ToString();
           for (int i = 0; i < frmSach.TableSach.Rows.Count; i++)
           {
               tongso += Int16.Parse(frmSach.TableSach.Rows[i][2].ToString());
                
           }
           label4.Text = "Số Lượng Sách hiện có : " + tongso.ToString();
            ListViewItem item;
            listSach.Items.Clear();

            for (int i = 0; i < frmSach.TableSach.Rows.Count; i++)
            {

                item = listSach.Items.Add(frmSach.TableSach.Rows[i][0].ToString());
                for (int j = 1; j < frmSach.TableSach.Columns.Count; j++)
                    item.SubItems.Add(frmSach.TableSach.Rows[i][j].ToString());
            }

            Form1.DaMo[9] = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " m: " + DateTime.Now.Second.ToString() + " s";
        }

        private void TKSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[9] = 0;
        }

    }
}
