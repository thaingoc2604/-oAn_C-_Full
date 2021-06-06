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
    public partial class fromNhanVien : Form
    {
        public DataTable TableNhanVien;

        string flag1 = "";
        AccessHelper help = new AccessHelper();
        Form1 helpfrm1 = new Form1();
        public fromNhanVien()
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
        public DataTable Doc_DS_NhanVien()
        {
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter("SELECT manhanvien,HoTen,DiaChi,GioiTinh,Password FROM TableNhanVien", help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);
            return help.dataset.Tables[0];

        }
        fromDocGia frmdocgia = new fromDocGia();
        private int KiemTraTuoi()
        {

            string TruyVan = "Select TuoiMax,TuoiMin from ThamSo";
            frmdocgia.TTuoi = help.TaoTable(TruyVan);
            int tuoi = Int16.Parse(DateTime.Now.Year.ToString()) - Int16.Parse(dateNgaySinh.Value.Year.ToString());
            int TuoiMax = Int16.Parse(frmdocgia.TTuoi.Rows[0][0].ToString());
            int TuoiMin = Int16.Parse(frmdocgia.TTuoi.Rows[0][1].ToString());
            if (tuoi <= TuoiMax && tuoi >= TuoiMin)
            {

                return 1;

            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm sinh chính xác!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }

        }

        private void Load_DS_NhanVien_ListView(DataTable TableNhanVien)
        {
            ListViewItem item;
            lsviewNV.Items.Clear();
            for (int i = 0; i < TableNhanVien.Rows.Count; i++)
            {
                
                item = lsviewNV.Items.Add(TableNhanVien.Rows[i][0].ToString());
                for (int j = 1; j < TableNhanVien.Columns.Count; j++)
                    item.SubItems.Add(TableNhanVien.Rows[i][j].ToString());
            }
        }

        private void fromNhanVien_Load(object sender, EventArgs e)
        {
            string TruyVan = "SELECT manhanvien,HoTen,DiaChi,GioiTinh,Password FROM TableNhanVien";
            TableNhanVien = help.TaoTable(TruyVan);
            
            Load_DS_NhanVien_ListView(TableNhanVien);
            TipHuongDan.AutoPopDelay = 5000;
            TipHuongDan.InitialDelay = 1000;
            TipHuongDan.ReshowDelay = 500;
            TipHuongDan.ToolTipIcon = ToolTipIcon.Info;
            
            //Gan chuoi huong dan cho tung textbox
            TipHuongDan.SetToolTip(this.txtChucVu, "Nhập rõ chức vụ của nhân viên này");
            TipHuongDan.SetToolTip(this.txtCMND, "Nhập vào số Chứng Minh Nhân Dân");
            TipHuongDan.SetToolTip(this.txtDiaChi, "Nhập vào địa chỉ nhà đang cư trú");
            TipHuongDan.SetToolTip(this.txtDienThoai, "Nhập vào số điện thoại nhà hay di động đang dùng");
            TipHuongDan.SetToolTip(this.txtHoKhau, "Nhập vào hộ khẩu thường trú");
            TipHuongDan.SetToolTip(this.txtMaNhanVien, "Nhập vào mã nhân viên sẽ được gán\n cho người này");
            TipHuongDan.SetToolTip(this.txtMatKhau, "Nhập vào mật khẩu sẽ dùng để đăng nhập \n (Dùng khi Login vào chương trình");


            Form1.DaMo[1] = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
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
            if (txtHoKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Hộ Khẩu Thường trú");
                return;
            }
            if (txtCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số CMND");
                return;
            }

            if (txtChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập chức vụ");
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            if (KiemTraTuoi() == 1)
            {
                string NgaySinh = help.XuLiNgay(dateNgaySinh.Value.ToString());
                string NgayVaoLam = help.XuLiNgay(dateNgayVaoLam.Value.ToString());

                String GioiTinh = checkGioiTinh.Checked == true ? "Nu" : "Nam";
                if (flag1 == "")
                {
                    String SqlInsert = "";
                    SqlInsert = "INSERT INTO TableNhanVien VALUES ('" + txtMaNhanVien.Text.Trim() +
                                                                 "','" + txtHoten.Text.Trim() +
                                                                 "','" + txtDiaChi.Text.Trim() +
                                                                 "','" + txtCMND.Text.Trim() +
                                                                 "','" + txtHoKhau.Text.Trim() +
                                                                 "','" + NgaySinh +
                                                                 "','" + txtEmail.Text.Trim() +
                                                                 "','" + txtChucVu.Text.Trim() +
                                                                 "','" + txtDienThoai.Text.Trim() +
                                                                 "','" + GioiTinh +
                                                                 "','" + txtMatKhau.Text.Trim() +
                                                                 "','" + NgayVaoLam + "')";
                    help.ExecuteNonQuery(SqlInsert);
                }
                else
                {
                    String sqlUpdate = "";
                    sqlUpdate = "UPDATE TableNhanVien SET HoTen='" + txtHoten.Text.Trim() +
                                            "',DiaChi='" + txtDiaChi.Text.Trim() +
                                            "',CMND='" + txtCMND.Text.Trim() +
                                            "',HKTT='" + txtHoKhau.Text.Trim() +
                                            "',NgaySinh='" + NgaySinh.Trim() +
                                            "',Email='" + txtEmail.Text.Trim() +
                                            "',ChucVu='" + txtChucVu.Text.Trim() +
                                            "',DienThoai='" + txtDienThoai.Text.Trim() +
                                            "',GioiTinh='" + GioiTinh.Trim() +
                                            "',Password='" + txtMatKhau.Text.Trim() +
                                            "',NgayVaoLam='" + NgayVaoLam.Trim() +
                                            "' WHERE manhanvien='" + flag1 + "';";

                    help.ExecuteNonQuery(sqlUpdate);
                    flag1 = "";
                }
                string TruyVan = "SELECT manhanvien,HoTen,DiaChi,GioiTinh,Password FROM TableNhanVien";
                TableNhanVien = help.TaoTable(TruyVan);
               
                Load_DS_NhanVien_ListView(TableNhanVien);
            }


        }
        public void LayMaNhanVien()
        {
            string TruyVan = "SELECT manhanvien,HoTen,DiaChi,GioiTinh,Password FROM TableNhanVien";
            TableNhanVien = help.TaoTable(TruyVan);
            Load_DS_NhanVien_ListView(TableNhanVien);
        }

        private void lsviewNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChiTietNhanVien helpchitiet = new ChiTietNhanVien();
            int i = lsviewNV.FocusedItem.Index;
            if (i < 0)
                return;
            flag1 = lsviewNV.Items[i].Text; //chuyen madocgia vao flag de tien hanh Update neu co thay doi;
            string manhanvien = lsviewNV.Items[i].Text;
            /*
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quanlythuvien.mdb";
            help.connection = new OleDbConnection(connectionString);
            help.adapter = new OleDbDataAdapter("SELECT * FROM TableNhanVien Where manhanvien='"+manhanvien+"'", help.connection);
            help.dataset = new DataSet();
            help.adapter.Fill(help.dataset);
            */
            string TruyVan = "SELECT * FROM TableNhanVien Where manhanvien='" + manhanvien + "'";

            helpchitiet.TableNhanVienChiTiet = help.TaoTable(TruyVan);

            txtMaNhanVien.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][0].ToString();
            txtHoten.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][1].ToString();
            txtDiaChi.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][2].ToString();
            txtCMND.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][3].ToString();
            txtHoKhau.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][4].ToString();
            dateNgaySinh.Value = DateTime.Parse(helpchitiet.TableNhanVienChiTiet.Rows[0][5].ToString());
            txtEmail.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][6].ToString();
            txtChucVu.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][7].ToString();     
            txtDienThoai.Text = '0' + helpchitiet.TableNhanVienChiTiet.Rows[0][8].ToString();
            if (helpchitiet.TableNhanVienChiTiet.Rows[0][9].ToString().ToLower() == " nu")
                checkGioiTinh.Checked = true;
            else checkGioiTinh.Checked = false;
            txtMatKhau.Text = helpchitiet.TableNhanVienChiTiet.Rows[0][10].ToString();
           dateNgayVaoLam.Value = DateTime.Parse(helpchitiet.TableNhanVienChiTiet.Rows[0][11].ToString());
        }

        private void lsviewNV_DoubleClick(object sender, EventArgs e)
        {
           
                ChiTietNhanVien helpchitiet = new ChiTietNhanVien();
                int i = lsviewNV.FocusedItem.Index;
                string manhanvien = lsviewNV.Items[i].Text;
               
            /*string connectionString;
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quanlythuvien.mdb";
                help.connection = new OleDbConnection(connectionString);
                help.adapter = new OleDbDataAdapter("SELECT * FROM TableNhanVien Where manhanvien='"+manhanvien+"'", help.connection);
                help.dataset = new DataSet();
                help.adapter.Fill(help.dataset);*/

                
                string TruyVan = "SELECT * FROM TableNhanVien Where manhanvien='" + manhanvien + "'";

                helpchitiet.TableNhanVienChiTiet = help.TaoTable(TruyVan);

                helpchitiet.ShowDialog();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChucVu.Text = txtDiaChi.Text = txtDienThoai.Text = txtEmail.Text = txtHoKhau.Text = txtHoten.Text = txtMaNhanVien.Text = txtMatKhau.Text = " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string SqlDelete;
            SqlDelete = "DELETE FROM TableNhanVien WHERE manhanvien='"+flag1+"'";
            help.ExecuteNonQuery(SqlDelete);
            string TruyVan = "SELECT manhanvien,HoTen,DiaChi,GioiTinh,Password FROM TableNhanVien";
            TableNhanVien = help.TaoTable(TruyVan);
            
            Load_DS_NhanVien_ListView(TableNhanVien);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lsviewNV_DoubleClick(sender, e);
        }

        private void dateNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void fromNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DaMo[1] = 0;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            flag1 = "";
        }

       

       









        
    }
}