using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class TimKiemSach : Form
    {
        
        //Co cach nao de mang nay luu tru it hon khong???
        public string[] TuaSach = new string[400000];
        public string MaSach;
        public TimKiemSach()
        {
            InitializeComponent();
            label1.Text = "";
            if (AccessHelper.TruyCap == 1)
            {
                btnEdit.Enabled = true;
            }
            else btnEdit.Enabled = false;
        }
        AccessHelper accesshelp = new AccessHelper();
        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            LuuTruSach helpsach = new LuuTruSach();
            
            //helpsach.LuuTruSach_Load(sender,e);

            string TruyVan = "SELECT masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan FROM TableSach";
            helpsach.TableSach = accesshelp.TaoTable(TruyVan);
            
            
            for (int i = 0; i < helpsach.TableSach.Rows.Count; i++)
            {
                listTenSach.Items.Add(helpsach.TableSach.Rows[i][1].ToString());
               
            }
            for (int j = 0; j <listTenSach.Items.Count; j++)
            {
                TuaSach[j] = listTenSach.Items[j].ToString();//co the se su dung thuat toan sap xep Quick sort va ap dung tim kiem nhi phan
            }


            lalNgayGio.Text = "Hôm Nay Ngày " + DateTime.Now.Day.ToString() + ", tháng " + DateTime.Now.Month.ToString() + ", năm " + DateTime.Now.Year.ToString();

            labelGio.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString() + " giây";
            
            Form1.DaMo[5] = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            listTenSach.Items.Clear();
            TimKiemSach_Load(sender, e);
        }
        private void listTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listTenSach.SelectedIndex;
            if (i < 0) return;
            txtTenSach.Text = listTenSach.Items[i].ToString();
        }
        public string TenSach;
        private void btnTim_Click(object sender, EventArgs e)
        {
            string ViTri;
            string a = txtTenSach.Text.ToString();
            a = a.ToLower();
            int n = 0 ;
            for(int i=0;i<listTenSach.Items.Count;i++)
            {
                if (string.Equals(a, listTenSach.Items[i].ToString().ToLower()))
                {

                    listTenSach.SelectedIndex = i;
                    TenSach = a;
                    LoadSach();
                    ViTri = helpaccess.XuLiMaSach(help.TableSach.Rows[i][0].ToString());
                    richViTri.Text = ViTri;
                    label1.ForeColor = Color.RoyalBlue;
                    label1.Text = "Tìm Thấy Tựa Sách Trong Thư Viện !!! ";
                    n = 1;
                    MaSach = help.TableSach.Rows[i][0].ToString();

                }
                              
                    

            }
            if (n == 0)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Không tìm thấy tựa sách này";
                listview.Items.Clear();
                richViTri.Text = "";

            }
            
            
        }
        LuuTruSach help = new LuuTruSach();
        AccessHelper helpaccess = new AccessHelper();
        void LoadSach()
        {

            ListViewItem item;
            listview.Items.Clear();
           help.TableSach = help.Doc_DS_Sach();
            for (int i = 0; i < help.TableSach.Rows.Count; i++)
            {
                if (helpaccess.SoSanhTenSach(help.TableSach.Rows[i][1].ToString(),TenSach) == 1)
                {
                    item = listview.Items.Add(help.TableSach.Rows[i][0].ToString());
                    for (int j = 1; j < help.TableSach.Columns.Count; j++)
                        item.SubItems.Add(help.TableSach.Rows[i][j].ToString());
                }
            }
        }

        private void TimKiemSach_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtTenSach_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnTim_Click(sender, e);
                    break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (AccessHelper.TruyCap == 0)
            {
                Form1.DaMo[5] = 0;
                Application.Exit();

            }
            else
            {
                Form1.DaMo[5] = 0;
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            int j = -1;
            LuuTruSach helpluutru = new LuuTruSach();
            helpluutru.TableSach = helpluutru.Doc_DS_Sach();
            for (int i = 0; i < helpluutru.TableSach.Rows.Count; i++)
            {
                if (string.Equals(helpluutru.TableSach.Rows[i][0].ToString(), MaSach)) 
                {
                    j = i;
                    
                    
                   

                }


            }
            if (j != -1)
            {
                
                helpluutru.Show();

                helpluutru.flag = helpluutru.listview.Items[0].Text;
                if (j < 0) return;

                helpluutru.txtMaSach.Text = helpluutru.listview.Items[j].Text;
                helpluutru.txtTuaSach.Text = helpluutru.listview.Items[j].SubItems[1].Text;
                helpluutru.txtTacGia.Text = helpluutru.listview.Items[j].SubItems[2].Text;
                helpluutru.txtSoLuong.Text = helpluutru.listview.Items[j].SubItems[3].Text;
                helpluutru.txtNXB.Text = helpluutru.listview.Items[j].SubItems[4].Text;
                helpluutru.comboTheLoai.Text = helpluutru.listview.Items[j].SubItems[5].Text;
                helpluutru.txtNamXB.Text = helpluutru.listview.Items[j].SubItems[6].Text;
            }
            


        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelGio.Text = DateTime.Now.Hour.ToString() + " h: " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString() + " giây";
        }

        private void TimKiemSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[5] = 0;
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            //listTenSach.SelectedIndex = listTenSach.FindString(txtTenSach.Text); 
        }

       

      


    }
}