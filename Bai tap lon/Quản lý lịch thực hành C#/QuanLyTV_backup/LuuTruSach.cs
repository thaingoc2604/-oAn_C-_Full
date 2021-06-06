using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace QuanLyTV
{
    public partial class LuuTruSach : Form
    {
       
        public DataTable TableSach;
        AccessHelper help = new AccessHelper();
        public string flag = "";
        public LuuTruSach()
        {
            InitializeComponent();
            RemoveXButton(this.Handle);
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int GetSystemMenu(IntPtr hwnd, int bRevert);
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int RemoveMenu(int hMenu, int nPosition, int wFlags);
        public const int SC_CLOSE = 61536;
        public const int MF_BYCOMMAND = 0;

        int RemoveXButton(IntPtr iHWND)
        {
            int iSysMenu;
            iSysMenu = GetSystemMenu(iHWND, 0);
            return RemoveMenu(iSysMenu, SC_CLOSE, MF_BYCOMMAND);
        }
       public void LuuTruSach_Load(object sender, EventArgs e)
        {
           string TruyVan = "SELECT masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan FROM TableSach";
           TableSach = help.TaoTable(TruyVan);
           
            Load_DS_Sach_ListView(TableSach);
            Form1.DaMo[2] = 1;
            AccessHelper.luutrusach = 1;
        }
        private void comboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTheLoai.SelectedIndex == 0) txtMaSach.Text = "KT-";
            if (comboTheLoai.SelectedIndex == 1) txtMaSach.Text = "PL-";
            if (comboTheLoai.SelectedIndex == 2) txtMaSach.Text = "KH-";
            if (comboTheLoai.SelectedIndex == 3) txtMaSach.Text = "MT-";
            if (comboTheLoai.SelectedIndex == 4) txtMaSach.Text = "AR-";
            if (comboTheLoai.SelectedIndex == 5) txtMaSach.Text = "XH-";
            if (comboTheLoai.SelectedIndex == 6) txtMaSach.Text = "TN-";
            if (comboTheLoai.SelectedIndex == 7) txtMaSach.Text = "LS-";
            if (comboTheLoai.SelectedIndex == 8) txtMaSach.Text = "VH-";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim().Length == 3)
            {
                MessageBox.Show("Vui lòng nhập mã sách có dạng XX-YY-ZZ \n XX-Đã có sẵn \n YY-Số của tủ chứa \n ZZ-Số của ngăn chứa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (comboTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại");
                return;
            }
            if (txtTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên tác giả");
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng ");
                return;
            }
            if (txtNamXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản");
                return;
            }
           
           
            if (flag == "")
            {
                String SqlInsert = "";
                SqlInsert = "INSERT INTO TableSach VALUES ('"+txtMaSach.Text.Trim()+
                                                             "','" +txtTuaSach.Text.Trim()+
                                                             "','" +txtTacGia.Text.Trim()+
                                                             "','" +txtSoLuong.Text.Trim()+
                                                             "','" +txtNXB.Text.Trim() +
                                                             "','" +comboTheLoai.Text.Trim()+
                                                             "','" +txtNamXB.Text.Trim()+"')";
                help.ExecuteNonQuery(SqlInsert);

            }
            else
            {
                string SqlUpdate;
                SqlUpdate = "UPDATE TableSach SET TenSach='" + txtTuaSach.Text.Trim()+
                                        "',TacGia='" + txtTacGia.Text.Trim() +
                                       "',SoLuong=" + txtSoLuong.Text.Trim() +
                                       ",NXB='" + txtNXB.Text.Trim() +
                                        "',TheLoai='" + comboTheLoai.Text.Trim() +                                                                            
                                        "',NamXB=" + txtNamXB.Text.Trim() +
                                        " WHERE masach='"+flag+"';";

                help.ExecuteNonQuery(SqlUpdate);
                flag = "";




            }
            TableSach = Doc_DS_Sach();

            Load_DS_Sach_ListView(TableSach);

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listview.Items.Clear();
            TableSach = Doc_DS_Sach();

            Load_DS_Sach_ListView(TableSach);

        }
        public DataTable Doc_DS_Sach()
        {
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter("SELECT masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan FROM TableSach", help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);
            return help.dataset.Tables[0];

        }
              

        private void Load_DS_Sach_ListView(DataTable TableSach)
        {
            ListViewItem item;

            listview.Items.Clear();

            for (int i = 0; i < TableSach.Rows.Count; i++)
            {

                item = listview.Items.Add(TableSach.Rows[i][0].ToString());
                for (int j = 1; j < TableSach.Columns.Count; j++)
                    item.SubItems.Add(TableSach.Rows[i][j].ToString());
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (comboHienThiTheLoai.SelectedIndex == 0) TimSachKT1();
            if (comboHienThiTheLoai.SelectedIndex == 1) TimSachPL1();
            if (comboHienThiTheLoai.SelectedIndex == 2) TimSachKH1();
            if (comboHienThiTheLoai.SelectedIndex == 3) TimSachMT1();
            if (comboHienThiTheLoai.SelectedIndex == 4) TimSachAR1();
            if (comboHienThiTheLoai.SelectedIndex == 5) TimSachXH1();
            if (comboHienThiTheLoai.SelectedIndex == 6) TimSachTN1();
            if (comboHienThiTheLoai.SelectedIndex == 7) TimSachLS1();
            if (comboHienThiTheLoai.SelectedIndex == 8) TimSachVH1();
            if (comboHienThiTheLoai.SelectedIndex == 9) TatCa();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string SqlDelete;
            SqlDelete = "DELETE FROM TableSach WHERE masach='" + flag + "'";
            help.ExecuteNonQuery(SqlDelete);
           
            TableSach = Doc_DS_Sach();
            
            Load_DS_Sach_ListView(TableSach);
        }

        private void listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listview.FocusedItem.Index;
            flag = listview.Items[i].Text.Trim();
            if (i < 0)  return;

            txtMaSach.Text = listview.Items[i].Text;
            txtTuaSach.Text = listview.Items[i].SubItems[1].Text;
            txtTacGia.Text = listview.Items[i].SubItems[2].Text;
            txtSoLuong.Text = listview.Items[i].SubItems[3].Text;
            txtNXB.Text = listview.Items[i].SubItems[4].Text;
            comboTheLoai.Text = listview.Items[i].SubItems[5].Text;
            txtNamXB.Text = listview.Items[i].SubItems[6].Text;





        }
        void LoadSachTheoTheLoai(string TL)
        {
            ListViewItem item;
            listview.Items.Clear();
            for (int i = 0; i < TableSach.Rows.Count; i++)
            {
                if (help.SoSanhMaSach(TableSach.Rows[i][0].ToString(), TL) == 1)
                {
                    item = listview.Items.Add(TableSach.Rows[i][0].ToString());
                    for (int j = 1; j < TableSach.Columns.Count; j++)
                        item.SubItems.Add(TableSach.Rows[i][j].ToString());
                }
            }
        }
        void TimSachKT1()
        {
            string TL = "KT";
            LoadSachTheoTheLoai(TL);

           
        }
       
        void TimSachPL1()
        { 
             string TL="PL";
             LoadSachTheoTheLoai(TL);

            
        }
        void TimSachKH1()
        {
            string TL = "KH";
            LoadSachTheoTheLoai(TL);

            
        }
        void TimSachMT1()
        {
            string TL = "MT";
            LoadSachTheoTheLoai(TL);

           
        }
        void TimSachAR1()
        {
            string TL = "AR";
            LoadSachTheoTheLoai(TL);

        }
        void TimSachXH1()
        {
            string TL = "XH";
            LoadSachTheoTheLoai(TL);

            
        }
        void TimSachTN1()
        {
            string TL = "TN";
            LoadSachTheoTheLoai(TL);

            
        }
        void TimSachLS1()
        {
            string TL = "LS";
            LoadSachTheoTheLoai(TL);

            
        }
        void TimSachVH1()
        {
            string TL = "VH";
            LoadSachTheoTheLoai(TL);

        }
        void TatCa()
        {
            
            ListViewItem item;
            listview.Items.Clear();
            for (int i = 0; i < TableSach.Rows.Count; i++)
            {
                
                    item = listview.Items.Add(TableSach.Rows[i][0].ToString());
                    for (int j = 1; j < TableSach.Columns.Count; j++)
                        item.SubItems.Add(TableSach.Rows[i][j].ToString());
                
            }

        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboHienThiTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHienThiTheLoai.SelectedIndex == 0) TimSachKT1();
            if (comboHienThiTheLoai.SelectedIndex == 1) TimSachPL1();
            if (comboHienThiTheLoai.SelectedIndex == 2) TimSachKH1();
            if (comboHienThiTheLoai.SelectedIndex == 3) TimSachMT1();
            if (comboHienThiTheLoai.SelectedIndex == 4) TimSachAR1();
            if (comboHienThiTheLoai.SelectedIndex == 5) TimSachXH1();
            if (comboHienThiTheLoai.SelectedIndex == 6) TimSachTN1();
            if (comboHienThiTheLoai.SelectedIndex == 7) TimSachLS1();
            if (comboHienThiTheLoai.SelectedIndex == 8) TimSachVH1();
            if (comboHienThiTheLoai.SelectedIndex == 9) TatCa();

        }

        private void LuuTruSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[2] = 0;
            AccessHelper.luutrusach = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccessHelper.TruyCap == 0)
            {
                Form1.DaMo[2] = 0;
                Application.Exit();
            }
            else this.Close();
        }

        

      





    }
}