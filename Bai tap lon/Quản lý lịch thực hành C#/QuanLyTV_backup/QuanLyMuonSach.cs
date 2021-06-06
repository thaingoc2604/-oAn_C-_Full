using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Win32;

namespace QuanLyTV
{
    public partial class QuanLyMuonSach : Form
    {
        public DataTable DS_NhanVien;
        public DataTable SoSachChoMuon;
        public DataTable DocGiaVaNgayMuon;
        public DataTable TableMuonTraSach;
        string masach = "";
        string flag = "";
        AccessHelper help = new AccessHelper();
        Form1 helpfrm1 = new Form1();
        fromDocGia docgia = new fromDocGia();
        public DataTable DocGia;
        Options frmoption = new Options();
        fromDocGia frmdocgia = new fromDocGia();

        public QuanLyMuonSach()
        {
            InitializeComponent();
            txtTimDocGia.Enabled = false;
            txtTimSoPHieu.Enabled = false;
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
        int Kiemtramadocgia()
        {
            DocGia = TimDocGia();
            if (DocGia.Rows.Count == 0)
            {
                MessageBox.Show("Không có độc giả này ! Vui Lòng đăng kí lại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return 0;
            }
            return 1;
        }


        int KiemTraDaMuonSachChua()
        { 
            TableMuonTraSach = Doc_DS_MuonSach();
            string a=txtMaDocGia.Text.Trim().ToString();
            string TruyVan = "Select TuoiMax,TuoiMin,ChoPhepMuon from ThamSo";
            frmdocgia.TTuoi = help.TaoTable(TruyVan);
            int chomuon = Int16.Parse(frmdocgia.TTuoi.Rows[0][2].ToString());
            int dem = 0;
            for (int i = 0; i < TableMuonTraSach.Rows.Count; i++)
            {
                if (string.Equals(a, TableMuonTraSach.Rows[i][1].ToString()) == true)
                {
                    dem++;
                }
            }
            if (dem == chomuon)
            {
                MessageBox.Show("Độc Giả này đã mượn quá quy định của thư viện");
                return 0;
            }
            else return 1;


        }



        int Kiemtramasach()
        {

            DataTable TSoLuongSach;
            TSoLuongSach = SoLuongSach();

            if (TSoLuongSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có mã sách này trong thư viện");
                return 0;
            }
            if (Int16.Parse(TSoLuongSach.Rows[0][1].ToString()) == 1)
            {
                MessageBox.Show("Xin lỗi ! Sách chỉ còn 1 cuốn nên không thể cho mượn");

                return 0;
            }
            return 1;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
                return;
            }
            if (txtMaPhieuMuon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu mượn");
                return;
            }
            if (txtMaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã sách");
                return;
            }
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
                return;
            }
            
            string NgayMuon = help.XuLiNgay(dateNgayMuon.Value.ToString());
            
                    
            
            if (Kiemtramasach() == 1 && Kiemtramadocgia()==1 && KiemTraDaMuonSachChua() ==1 )
            {                
                if (flag == "")
                {
                    String SqlInsert = "";
                    SqlInsert = "INSERT INTO TableMuonTraSach VALUES ('" + txtMaPhieuMuon.Text.Trim() +
                                                                 "','" + txtMaDocGia.Text.Trim() +
                                                                 "','" + txtMaNhanVien.Text.Trim() +
                                                                 "','" + txtMaSach.Text.Trim() +
                                                                 "','" + NgayMuon.ToString() +
                                                                 "','"+txtNgayTra.Text.ToString() + "')";
                    help.ExecuteNonQuery(SqlInsert);
                    String SqlUpdate = "";
                    SqlUpdate = "Update TableSach Set SoLuong=SoLuong-1 WHERE masach='" + txtMaSach.Text.Trim() + "';";
                    help.ExecuteNonQuery(SqlUpdate);

                }
                else
                {
                    string SqlUpdate;
                    SqlUpdate = "UPDATE TableMuonTraSach SET madocgia='"+txtMaDocGia.Text.Trim()+
                                             "',manhanvien='"+txtMaNhanVien.Text.Trim() +
                                             "',masach='"+txtMaSach.Text.Trim()+
                                             "',NgayMuon='"+dateNgayMuon.Value.ToString()+
                                             "',NgayTra='"+txtNgayTra.Text.ToString()+
                                             "' WHERE masophieumuon='"+flag+"';";
                    help.ExecuteNonQuery(SqlUpdate);
                    flag = "";
                }
                TableMuonTraSach = Doc_DS_MuonSach();
                Load_DS_MuonSach_ListView(TableMuonTraSach);
            }
            else 
            {
            
                return ;
            }

        }
        DataTable SoLuongSach()
        { 
        
                string connectionString;
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
                help.connection = new OleDbConnection(connectionString);
                help.adapter = new OleDbDataAdapter("SELECT masach,SoLuong From TableSach where masach='"+txtMaSach.Text.Trim()+"'", help.connection);
                 

                help.dataset = new DataSet();
                help.adapter.Fill(help.dataset);
                return help.dataset.Tables[0];
        }
        public DataTable Doc_DS_MuonSach()
        {
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter("SELECT m.masophieumuon,m.madocgia,d.HoTen as HoTenDocGia  ,s.masach,s.TenSach,m.manhanvien ,s.NXB  ,m.NgayMuon,m.NgayTra FROM TableMuonTraSach m,TableNhanVien n,TableSach s,TableDocGia d where m.madocgia = d.madocgia and m.manhanvien = n.manhanvien and m.masach = s.masach ", help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);
            return help.dataset.Tables[0];

        }
        private void Load_DS_MuonSach_ListView(DataTable TableMuonTraSach)
        {
            ListViewItem item;
            listviewMuonSach.Items.Clear();
            for (int i = 0; i < TableMuonTraSach.Rows.Count; i++)
            {

                item = listviewMuonSach.Items.Add(TableMuonTraSach.Rows[i][0].ToString());
                for (int j = 1; j < TableMuonTraSach.Columns.Count; j++)
                    item.SubItems.Add(TableMuonTraSach.Rows[i][j].ToString());
                    
            }

            
        }
        
        
        
        private void QuanLyMuonSach_Load(object sender, EventArgs e)
        {
            TableMuonTraSach = Doc_DS_MuonSach();
            Load_DS_MuonSach_ListView(TableMuonTraSach);
            lalNgayGio.Text = "Hôm Nay Ngày " + DateTime.Now.Day.ToString() + ", tháng " + DateTime.Now.Month.ToString() + ", năm " + DateTime.Now.Year.ToString();

            labelGio.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString() + " giây";
            txtMaNhanVien.Text = AccessHelper.MaNhanVienDangNhap.ToString();

            string TruyVan = "Select TuoiMax,TuoiMin,ChoPhepMuon from ThamSo";
            frmdocgia.TTuoi = help.TaoTable(TruyVan);

            string TruyVan1 = "Select NgayTra from TableMuonTraSach";
            DocGiaVaNgayMuon = help.TaoTable(TruyVan1);
            
            int NgayToiDa = Int16.Parse(frmdocgia.TTuoi.Rows[0][0].ToString());

            
           
            int dem = 0;
            
            
            string ngayhientai = DateTime.Now.ToShortDateString().ToString();
            for (int i = 0; i < DocGiaVaNgayMuon.Rows.Count; i++)
            {
                if(DateTime.Parse(ngayhientai) > DateTime.Parse(help.XuLiNgay(DocGiaVaNgayMuon.Rows[i][0].ToString())))
                {
                    dem++;
                    ListViewItem item;
                    item = listQuaHan.Items.Add(TableMuonTraSach.Rows[i][0].ToString());
                    item.SubItems.Add(TableMuonTraSach.Rows[i][1].ToString());
                    item.SubItems.Add(TableMuonTraSach.Rows[i][8].ToString());

                }
            }
           
                
            label2.Text = "Hiện tại có "+ dem.ToString() + " phiếu mượn đã quá hạn";
            txtNgayTra.Enabled = false;
            txtNgayTra.Text = dateNgayMuon.Value.AddDays(double.Parse(frmdocgia.TTuoi.Rows[0][2].ToString())).ToShortDateString().ToString();

            string TruyVan2 = "Select manhanvien,HoTen from TableNhanVien";
            DS_NhanVien = help.TaoTable(TruyVan2);
            for (int i = 0; i < DS_NhanVien.Rows.Count; i++)
                comboMaNhanVien.Items.Add(DS_NhanVien.Rows[i][0].ToString());

            Form1.DaMo[4] = 1;

        }


        private void listviewMuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listviewMuonSach.FocusedItem.Index;
            if (i < 0)
                return;
            flag = listviewMuonSach.Items[i].Text;
            masach = listviewMuonSach.Items[i].SubItems[3].Text;
            txtMaPhieuMuon.Text = listviewMuonSach.Items[i].Text;
            txtMaDocGia.Text = listviewMuonSach.Items[i].SubItems[1].Text;
            txtMaSach.Text = listviewMuonSach.Items[i].SubItems[3].Text;
            txtTenSach.Text = listviewMuonSach.Items[i].SubItems[4].Text;
            txtMaNhanVien.Text = listviewMuonSach.Items[i].SubItems[5].Text;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string SqlDelete;
            SqlDelete = "DELETE FROM TableMuonTraSach WHERE masophieumuon='"+flag+"'";
            help.ExecuteNonQuery(SqlDelete);
            String SqlUpdate = "";
            SqlUpdate = "Update TableSach Set SoLuong=SoLuong+1 WHERE masach='"+txtMaSach.Text.Trim()+"';";
            help.ExecuteNonQuery(SqlUpdate);
            TableMuonTraSach = Doc_DS_MuonSach();
            Load_DS_MuonSach_ListView(TableMuonTraSach);
        }

        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            
        }

        public  DataTable TimDocGia()
        {

            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter("SELECT madocgia,HoTen From TableDocGia where madocgia='" + txtMaDocGia.Text.Trim() + "'", help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);
            return help.dataset.Tables[0];
        }
        public DataTable TimvaDoc(string a)
        {
            
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter(a, help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);
            return help.dataset.Tables[0];
        }
     
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            string TruyVan = "Select TuoiMax,TuoiMin,ChoPhepMuon from ThamSo";
            frmdocgia.TTuoi = help.TaoTable(TruyVan);
            int chomuon = Int16.Parse(frmdocgia.TTuoi.Rows[0][2].ToString());
            ListViewItem item;
            listTimThay.Items.Clear();
            int dem = 0;
            if (flagTimDocGia == 1)
            {
                string docgia = txtTimDocGia.Text.Trim().ToString();
                for (int i = 0; i < TableMuonTraSach.Rows.Count; i++)
                {
                    if (string.Equals(docgia, TableMuonTraSach.Rows[i][1].ToString().Trim()) == true)
                    {

                        item = listTimThay.Items.Add(TableMuonTraSach.Rows[i][0].ToString());
                        for (int k = 1; k < TableMuonTraSach.Columns.Count; k++)
                            item.SubItems.Add(TableMuonTraSach.Rows[i][k].ToString());
                        dem++;
                        if (dem == chomuon) return;

                    }

                }
            
            }
            if (flatTimSoPhieu == 1)
            {
                string a = "Select masophieumuon,madocgia From TableMuonTraSach";
                DataTable MuonSach = TimvaDoc(a);

                for (int i = 0; i < TableMuonTraSach.Rows.Count; i++)
                {
                    if (string.Equals(txtTimSoPHieu.Text.Trim().ToString(), TableMuonTraSach.Rows[i][0].ToString()) == true)
                    {
                       
                       
                        item = listTimThay.Items.Add(TableMuonTraSach.Rows[i][0].ToString());
                        for (int k = 1; k < TableMuonTraSach.Columns.Count; k++)
                            item.SubItems.Add(TableMuonTraSach.Rows[i][k].ToString());
                    }

                }
                
            }

        }
        public int flagTimDocGia = 0;
        public int flatTimSoPhieu = 0;
        private void rTxtMaSophieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rTxtMaSophieu.Checked == true)
            {
                txtTimSoPHieu.Enabled = true;
                flatTimSoPhieu = 1;
            }
            else
            {
                txtTimSoPHieu.Enabled = false;
                flatTimSoPhieu = 0;
            }
        }
        private void rtxtmadocgia_CheckedChanged(object sender, EventArgs e)
        {
            if (rtxtmadocgia.Checked == true)
            {
                txtTimDocGia.Enabled = true;
                flagTimDocGia = 1;
            }
            else
            {
                txtTimDocGia.Enabled = false;
                flagTimDocGia = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelGio.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString() + " giây";
        }
        private void QuanLyMuonSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[4] =0;
        }
        private void txtTimDocGia_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTimDocGia_KeyUp(object sender, KeyEventArgs e)
        {
            
            e.Handled = true;
            switch (e.KeyCode)
            { 
                case Keys.Enter:
                    button1_Click(sender, e);
                    break;
            }
        }
        private void txtTimSoPHieu_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    button1_Click(sender, e);
                    break;
            }
        }
        private void dateNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void QuanLyMuonSach_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnThem_Click(sender, e);
                    break;
            }
        }
        private void btnQuaHan_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) comboMaNhanVien.Visible = true;
            else comboMaNhanVien.Visible = false;
            if (comboBox1.SelectedIndex == 1) datetimeNgayMuon.Visible = true;
            else datetimeNgayMuon.Visible = false;
            if (comboBox1.SelectedIndex == 2)
            {
                
                listviewMuonSach.Items.Clear();
                TableMuonTraSach = Doc_DS_MuonSach();
                Load_DS_MuonSach_ListView(TableMuonTraSach);
            }
        }
        private void comboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manhanvien = comboMaNhanVien.SelectedItem.ToString();
            string TruyVan = "SELECT m.masophieumuon,m.madocgia,d.HoTen as HoTenDocGia  ,s.masach,s.TenSach,m.manhanvien ,s.NXB  ,m.NgayMuon,m.NgayTra FROM TableMuonTraSach m,TableNhanVien n,TableSach s,TableDocGia d where m.madocgia = d.madocgia and m.manhanvien = n.manhanvien and m.masach = s.masach and m.manhanvien='" + manhanvien.Trim().ToLower().ToString() + "'";
            TableMuonTraSach = help.TaoTable(TruyVan);
            Load_DS_MuonSach_ListView(TableMuonTraSach);
        }
        private void datetimeNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            string ngaymuonsach = help.XuLiNgay(datetimeNgayMuon.Value.ToShortDateString().ToString());
            listviewMuonSach.Items.Clear();
            for (int i = 0; i < TableMuonTraSach.Rows.Count; i++)
            {
                if (string.Equals(ngaymuonsach,help.XuLiNgay(TableMuonTraSach.Rows[i][7].ToString())))
                {
                    ListViewItem item;
                    
                    item = listviewMuonSach.Items.Add(TableMuonTraSach.Rows[i][0].ToString());
                    for (int k = 1; k < TableMuonTraSach.Columns.Count; k++)
                        item.SubItems.Add(TableMuonTraSach.Rows[i][k].ToString());
                }
            }
        }

        private void listviewMuonSach_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnThem_Click(sender, e);
                    break;
                case Keys.Delete:
                    btnXoa_Click(sender, e);
                    break;

            }

        }
    }
}
