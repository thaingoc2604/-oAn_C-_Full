using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            label3.Text = "";
            label6.Text = "";
            ricNumber.Minimum = 1;
        }
        fromDocGia frmdocgia = new fromDocGia();
        Form1 frm1 = new Form1();
        private void btnSet_Click(object sender, EventArgs e)
        {
            if ( (Int16.Parse(txtTuoiMax.Text.ToString()) != Int16.Parse(frmdocgia.TTuoi.Rows[0][0].ToString())) ||( Int16.Parse(txtTuoiMin.Text.ToString()) != Int16.Parse(frmdocgia.TTuoi.Rows[0][1].ToString())))
            {
               
                    string TruyVan = "Update ThamSo Set TuoiMin='" + txtTuoiMin.Text.Trim() + "',TuoiMax='" + txtTuoiMax.Text.Trim() + "'";
                    help.ExecuteNonQuery(TruyVan);
                    label3.Text = "Cập nhật hoàn tất!";
               
            }
            else label3.Text = "Chưa thay đổi giá trị!";

            
        }
        private void btnXacNhan2_Click(object sender, EventArgs e)
        {
            if (Int16.Parse(ricNumber.Text.ToString()) != Int16.Parse(frmdocgia.TTuoi.Rows[0][2].ToString()))
            {
                string update = "Update ThamSo Set ChoPhepMuon='" + ricNumber.Text.ToString() + "'";
                help.ExecuteNonQuery(update);
                label6.Text = "Cập nhật hoàn tất!";
            }
            else label6.Text = "Chưa thay đổi giá trị!";
        }
        private void btnXAcnahn2_Click(object sender, EventArgs e)
        {
            if (Int16.Parse(ricnumberCHOMUONNGAY.Text.ToString()) != Int16.Parse(frmdocgia.TTuoi.Rows[0][3].ToString()))
            {
                string update = "Update ThamSo Set NgayToiDa='" + ricnumberCHOMUONNGAY.Text.ToString() + "'";
                help.ExecuteNonQuery(update);
                label6.Text = "Cập nhật hoàn tất!";
            }
            else label6.Text = "Chưa thay đổi giá trị!";
        }


        AccessHelper help = new AccessHelper();




        private void Options_Load(object sender, EventArgs e)
        {
            LoadTable();
            Form1.DaMo[3] = 1;
        }
        public void LoadTable()
        {
            string TruyVan = "Select TuoiMax,TuoiMin,ChoPhepMuon,NgayToiDa from ThamSo";
            frmdocgia.TTuoi = help.TaoTable(TruyVan);
            txtTuoiMax.Text = frmdocgia.TTuoi.Rows[0][0].ToString();
            txtTuoiMin.Text = frmdocgia.TTuoi.Rows[0][1].ToString();
            ricNumber.Text = frmdocgia.TTuoi.Rows[0][2].ToString();
            ricnumberCHOMUONNGAY.Text = frmdocgia.TTuoi.Rows[0][3].ToString();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[3] = 0;
        }

        
       

        
    }
}
