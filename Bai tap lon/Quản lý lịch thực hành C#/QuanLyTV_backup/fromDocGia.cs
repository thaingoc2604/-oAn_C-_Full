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
    public partial class fromDocGia : Form
    {
        public DataTable TableDocGia;
        public DataTable TTuoi;
        string flag = "";
        AccessHelper help = new AccessHelper();
        Form1 helpfrm1 = new Form1();
        public fromDocGia()
        {
            InitializeComponent();
            label12.Text = "";
            
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
        public DataTable Doc_DS_DocGia() 
        {
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
           
            help.adapter = new OleDbDataAdapter("SELECT madocgia,HoTen,DiaChi,GioiTinh,manhanvien FROM TableDocGia", help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);
            return help.dataset.Tables[0];
            

            
        }
        private int KiemTraTuoi()
        {
            
            string TruyVan = "Select TuoiMax,TuoiMin from ThamSo";
            TTuoi = help.TaoTable(TruyVan);
            int tuoi = Int16.Parse(DateTime.Now.Year.ToString()) - Int16.Parse(dateNgaySinh.Value.Year.ToString()) ;
            int TuoiMax = Int16.Parse(TTuoi.Rows[0][0].ToString());
            int TuoiMin = Int16.Parse(TTuoi.Rows[0][1].ToString());
            if (tuoi <= TuoiMax && tuoi >= TuoiMin)
            {

                return 1;

            }
            else
            {
                MessageBox.Show("Người này chưa đủ tuổi làm thẻ!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }

        }
        private void Load_DS_DocGia_ListView(DataTable TableDocGia)
        {
            ListViewItem item;
            lsviewDG.Items.Clear();
            
            for (int i = 0; i < TableDocGia.Rows.Count; i++)
            {
                
                item = lsviewDG.Items.Add(TableDocGia.Rows[i][0].ToString());
                for (int j = 1; j < TableDocGia.Columns.Count; j++)
                    item.SubItems.Add(TableDocGia.Rows[i][j].ToString());
            }
        }

        private void fromDocGia_Load(object sender, EventArgs e)
        {
            //TaoMaNhanVien();

            string TruyVan = "SELECT madocgia,HoTen,DiaChi,GioiTinh,manhanvien FROM TableDocGia";
            TableDocGia = help.TaoTable(TruyVan);
           
            Load_DS_DocGia_ListView(TableDocGia);

            txtMaNhanVien.Text = AccessHelper.MaNhanVienDangNhap.ToString();
            Form1.DaMo[0] = 1;
        }
        //void TaoMaNhanVien()
        //{
        //    fromNhanVien helpnhanvien = new fromNhanVien();



        //    helpnhanvien.LayMaNhanVien();


        //    for (int i = 0; i < helpnhanvien.TableNhanVien.Rows.Count; i++)
        //    {
        //        comboMaNhanVien.Items.Add(helpnhanvien.TableNhanVien.Rows[i][0].ToString());
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
                return;
            }
            if (txtHoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Họ và tên");
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            if (txtCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số CMND");
      
            }
            if (txtHoKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Hộ Khẩu Thường trú");
                return;
            }
            if (txtDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đơn vị");
                return;
            }
           
            if (KiemTraTuoi() == 1)
            {
                string GioiTinh = checkGioiTinh.Checked == true ? "Nu" : "Nam";
                string NgaySinh = help.XuLiNgay(dateNgaySinh.Value.ToString());
                string NgayLapThe = help.XuLiNgay(dateNgayLapThe.Value.ToString());
                txtEmail.Text = "Không có";
                txtDienThoai.Text = "000000";
                


                if (flag == "")
                {
                    String SqlInsert = "";
                    SqlInsert = "INSERT INTO TableDocGia VALUES ('" + txtMaDocGia.Text.Trim() +
                                                                 "','" + txtHoten.Text.Trim() +
                                                                 "','" + txtDiaChi.Text.Trim() +
                                                                 "','" + txtCMND.Text.Trim() +
                                                                 "','" + txtHoKhau.Text.Trim() +
                                                                 "','" + txtDonVi.Text.Trim() +
                                                                 "','" + NgaySinh +
                                                                 "','" + txtEmail.Text.Trim() +
                                                                 "','" + txtDienThoai.Text.Trim() +
                                                                 "','" + GioiTinh +
                                                                 "','" + txtMaNhanVien.Text.Trim() +
                                                                 "','" + NgayLapThe + "')";
                    help.ExecuteNonQuery(SqlInsert);
                    label12.Text = "Đã thêm mới thành công!!";

                }
                else
                {
                    string SqlUpdate;
                    SqlUpdate = "UPDATE TableDocGia SET HoTen='" + txtHoten.Text.Trim() +
                                            "',DiaChi='" + txtDiaChi.Text.Trim() +
                                            "',CMND='" + txtCMND.Text.Trim() +
                                            "',HKTT='" + txtHoKhau.Text.Trim() +
                                            "',DonViCongTac='" + txtDonVi.Text.Trim() +
                                            "',NgaySinh='" + NgaySinh +
                                            "',Email='" + txtEmail.Text.Trim() +
                                            "',DienThoai='" + txtDienThoai.Text.Trim() +
                                            "',GioiTinh='" + GioiTinh +
                                            "',manhanvien='" + txtMaNhanVien.Text.Trim() +
                                            "',Ngaylapthe='" + NgayLapThe +
                                            "' WHERE madocgia='" + flag + "';";

                    help.ExecuteNonQuery(SqlUpdate);
                    flag = "";
                    label12.Text = "Đã cập nhật thành công!!";




                }
                string TruyVan = "SELECT madocgia,HoTen,DiaChi,GioiTinh,manhanvien FROM TableDocGia";
                TableDocGia = help.TaoTable(TruyVan);

                Load_DS_DocGia_ListView(TableDocGia);
            }
        }

        private void lsviewDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChiTietDocGia helpchitiet = new ChiTietDocGia();
            int i = lsviewDG.FocusedItem.Index;
            if (i < 0)
                return;
           
            flag = lsviewDG.Items[i].Text; //chuyen madocgia vao flag de tien hanh Update neu co thay doi;
 



            string madocgia = lsviewDG.Items[i].Text;

            /*
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter("SELECT * FROM TableDocGia Where madocgia='" + madocgia + "'", help.connection);
            help.dataset = new DataSet();
            
            help.adapter.Fill(help.dataset);
            */
            string TruyVan = "SELECT * FROM TableDocGia Where madocgia='" + madocgia + "'";
            helpchitiet.TableDocGiaChiTiet = help.TaoTable(TruyVan);


            txtMaDocGia.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][0].ToString();
            txtHoten.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][1].ToString();
            txtDiaChi.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][2].ToString();
            txtCMND.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][3].ToString();
            txtHoKhau.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][4].ToString();
            txtDonVi.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][5].ToString();

           dateNgaySinh.Value = DateTime.Parse(helpchitiet.TableDocGiaChiTiet.Rows[0][6].ToString());

            txtEmail.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][7].ToString();
            txtDienThoai.Text = '0' + helpchitiet.TableDocGiaChiTiet.Rows[0][8].ToString();

            if (helpchitiet.TableDocGiaChiTiet.Rows[0][9].ToString().ToLower() == "nu")
                checkGioiTinh.Checked = true;
            else checkGioiTinh.Checked = false;

            txtMaNhanVien.Text = helpchitiet.TableDocGiaChiTiet.Rows[0][10].ToString();

            dateNgayLapThe.Value = DateTime.Parse(helpchitiet.TableDocGiaChiTiet.Rows[0][11].ToString());
                 
           

        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            flag = "";
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string SqlDelete;
            SqlDelete = "DELETE FROM TableDocGia WHERE madocgia='" +flag+"'";
            help.ExecuteNonQuery(SqlDelete);            
            
            TableDocGia = Doc_DS_DocGia();
           
            Load_DS_DocGia_ListView(TableDocGia);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void lsviewDG_DoubleClick(object sender, EventArgs e)
        {
            
            ChiTietDocGia helpchitiet = new ChiTietDocGia();
            int i = lsviewDG.FocusedItem.Index;            
            string madocgia = lsviewDG.Items[i].Text;
            
            /*string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter("SELECT * FROM TableDocGia Where madocgia='" + madocgia + "'", help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);*/
            string TruyVan ="SELECT * FROM TableDocGia Where madocgia='" + madocgia + "'";
            helpchitiet.TableDocGiaChiTiet = help.TaoTable(TruyVan);
            helpchitiet.ShowDialog();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtDienThoai.Text = txtDonVi.Text = txtEmail.Text = txtHoKhau.Text=txtHoten.Text = txtMaDocGia.Text =  " ";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lsviewDG_DoubleClick(sender, e);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void fromDocGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[0] = 0;
        }

        private void rcheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rcheckAll.Checked == true)
            {
                string TruyVan = "SELECT madocgia,HoTen,DiaChi,GioiTinh,manhanvien FROM TableDocGia";
                TableDocGia = help.TaoTable(TruyVan);

                Load_DS_DocGia_ListView(TableDocGia);
            }
        }

        private void rcheckDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rcheckDate.Checked == true) datetimeNgayLapThe.Visible = true;
            else datetimeNgayLapThe.Visible = false;
        }

        private void datetimeNgayLapThe_ValueChanged(object sender, EventArgs e)
        {
            string ngaylapthe = help.XuLiNgay(datetimeNgayLapThe.Value.ToShortDateString().ToString());
            lsviewDG.Items.Clear();
            string TruyVan = "SELECT NgayLapThe FROM TableDocGia";
            DataTable TableNgayLapThe = help.TaoTable(TruyVan);


            for (int i = 0; i < TableNgayLapThe.Rows.Count; i++)
            {
                if (string.Equals(ngaylapthe, help.XuLiNgay(TableNgayLapThe.Rows[i][0].ToString())))
                {
                    ListViewItem item;

                    item = lsviewDG.Items.Add(TableDocGia.Rows[i][0].ToString());
                    for (int k = 1; k < TableDocGia.Columns.Count; k++)
                        item.SubItems.Add(TableDocGia.Rows[i][k].ToString());
                }
            }
        }

      


        

       





    }
    
}