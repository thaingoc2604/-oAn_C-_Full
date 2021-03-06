using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBDDemo
{
    public partial class frmQuanLyBuuGui : Form
    {
        /// <summary>
        /// khai bao bien de ket noi voi co so du lieu
        /// </summary>
        /// 
        private SqlConnection conn;
        private SqlCommand commnd, commndBuG, commndNguoiG, commndNguoiN,commd1;
        private SqlDataAdapter da, da1;
        private DataSet ds = new DataSet();
        private DataSet ds1 = new DataSet();
        private String connString = "server = (local)\\SQLEXPRESS; database = QLBD; Integrated Security = true";
        //private int CuocPhi;
        private DataTable dt = new DataTable();
        private DataTable dt1 = new DataTable();


        public frmQuanLyBuuGui()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {

            try
            {
                //khoi tao doi tuong sqlconnectin =new SqlConnection(connectionString)
                //cung cap chuoi ket noi den co so du lieu thong qua thuoc tinh "connectinstring"
                //truyen chuoi ket noi c0o so du lieu


                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                //truyen phat bieu Sql vao doi  tuong SqlConnection 
                //Cu phap :sqlcommand =new SqlCommand(string commandText,Sqlconnection sqlconnection)
                commnd = new SqlCommand("SELECT     DICHVU.LOAIDV, BUUGUI.MABUUGUI, BUUGUI.DONVITINH, BUUGUI.CUOC, DICHVUTHEM.LOAI_DVTHEM, BUUGUI.MANGUOINHAN,NGUOINHAN.HOTEN_NN, NGUOIGUI.DIACHI, BUUGUI.MANGUOIGUI, NGUOIGUI.HOTEN_NG, NGUOIGUI.DIACHI  FROM  BUUGUI LEFT OUTER JOIN    DICHVU ON DICHVU.MADV = BUUGUI.MADV LEFT OUTER JOIN      DICHVUTHEM ON BUUGUI.MA_DVTHEM = DICHVUTHEM.MA_DVTHEM LEFT OUTER JOIN    NGUOIGUI ON BUUGUI.MANGUOIGUI = NGUOIGUI.MANGUOIGUI LEFT OUTER JOIN   NGUOINHAN ON BUUGUI.MANGUOINHAN = NGUOINHAN.MANGUOINHAN", conn);
                //khai bao va hkoi tao doi tuong   SqlDataAdapter
                //doc du lieu tu nguon SqlServer va dien du liau vao doi tuong DataSet,DataTable
                //
                da = new SqlDataAdapter(commnd);
                DataSet ds = new DataSet();
                //dien du lieu vao DataSet 
                //cu phap:sqlDataAdapter.Fill(DataSetName)
                da.Fill(ds, "BuuGui");
                //Dua du lieu tu nguon :tu bang "BuuGui"vua dat ten ra DataGridView
                dGVBangThongTin.DataSource = ds.Tables["BuuGui"].DefaultView;
                //dong ket noi
                conn.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }


        }


        private void btnCuocPhi_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyBuuGui_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            hiendulieuNG();

            hiendulieuNguoiN();
            hiendulieubuugui();
        }
        private void SetNull()
        {
            cmbLoaiDichVu.Text = "";
            cmbDichVuThem.Text = "";
            txtMaBuuGui.Text = "";
            txtDonViTinh.Text = "";
            txtCuocPhi.Text = "";
            txtMaNguoiGui.Text = "";
            txtHoTenNguoiGui.Text = "";
            txtDiaChiNguoiGui.Text = "";
            txtMaNguoiNhan.Text = "";
            txtHoTenNguoiNhan.Text = "";
            txtDiaChiNguoiNhan.Text = "";

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void gBxNguoiGui_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiemBuuGui_Click(object sender, EventArgs e)
        {//txtTimkiemmabuugui
            string TimkienMaBuuGui = txtTimkiemmabuugui.Text;
            string TimkiemMaNguoiGui = txtTKMaNgouiGui.Text;
            string timkiemMaNguoiNhan = txtTKMaNguoiNhan.Text;
            //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
            conn = new SqlConnection(connString);
            conn.Open();
            commnd = new SqlCommand("SELECT     DICHVU.LOAIDV, BUUGUI.MABUUGUI, BUUGUI.DONVITINH, BUUGUI.CUOC, DICHVUTHEM.LOAI_DVTHEM, BUUGUI.MANGUOINHAN,     NGUOINHAN.HOTEN_NN, NGUOIGUI.DIACHI, BUUGUI.MANGUOIGUI, NGUOIGUI.HOTEN_NG, NGUOIGUI.DIACHI AS DIACHINN FROM         BUUGUI LEFT OUTER JOIN      DICHVU ON DICHVU.MADV = BUUGUI.MADV LEFT OUTER JOIN         DICHVUTHEM ON BUUGUI.MA_DVTHEM = DICHVUTHEM.MA_DVTHEM LEFT OUTER JOIN     NGUOIGUI ON BUUGUI.MANGUOIGUI = NGUOIGUI.MANGUOIGUI LEFT OUTER JOIN             NGUOINHAN ON BUUGUI.MANGUOINHAN = NGUOINHAN.MANGUOINHAN WHERE     (BUUGUI.MANGUOINHAN LIKE '" + TimkienMaBuuGui + "') OR (BUUGUI.MABUUGUI LIKE '" + TimkiemMaNguoiGui + "') OR   (BUUGUI.MANGUOIGUI LIKE '" + TimkiemMaNguoiGui + "')", conn);
            da = new SqlDataAdapter(commnd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TK");
            dGVBangThongTin.DataSource = ds.Tables["TK"].DefaultView;
            conn.Close();
            if (dGVBangThongTin.CurrentRow != null)
            {/*
                string LoaiDichVu=cmbLoaiDichVu.Text;
                string MaBuuGui=txtMaBuuGui.Text;
                string Donvitinh=txtDonViTinh.Text;
                string Dichvuthem=cmbDichVuThem.Text;
                string cuocphi=txtCuocPhi.Text;*/
                cmbLoaiDichVu.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[0].Value.ToString();
                txtMaBuuGui.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[1].Value.ToString();
                txtDonViTinh.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[2].Value.ToString();
                cmbDichVuThem.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[3].Value.ToString();
                txtCuocPhi.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[4].Value.ToString();

                txtMaNguoiGui.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[5].Value.ToString();

                txtHoTenNguoiGui.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[6].Value.ToString();

                txtDiaChiNguoiGui.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[7].Value.ToString();
                txtMaNguoiNhan.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[8].Value.ToString();

                txtHoTenNguoiNhan.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[9].Value.ToString();

                txtDiaChiNguoiNhan.Text = dGVBangThongTin.Rows[dGVBangThongTin.CurrentRow.Index].Cells[10].Value.ToString();

            }

        }
        //NguoiGui
        private void ClearNguoiGui()
        {
            txtMaNguoiG.Text = "";
            txtTenNguoiG.Text = "";
            txtDiaChiNguoiG.Text = "";
            txtDienThoaiNguoiG.Text = "";
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ClearNguoiGui();
        }
        private void hiendulieuNG()
        {
            try
            {

                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                commnd = new SqlCommand("SELECT * FROM NGUOIGUI", conn);
                da = new SqlDataAdapter(commnd);
                DataSet ds = new DataSet();
                da.Fill(ds, "NguoiGui");
                daGvThongTinNG.DataSource = ds.Tables["NguoiGui"];

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }


        }
        /* private void btnSelect_Click(object sender, EventArgs e)
         {
             if (daGvThongTinNG.CurrentRow != null)
             {
                 txtMaNguoiG.Text = daGvThongTinNG.Rows[daGvThongTinNG.CurrentRow.Index].Cells[0].Value.ToString();
               txtTenNguoiG.Text = daGvThongTinNG.Rows[daGvThongTinNG.CurrentRow.Index].Cells[1].Value.ToString();
                 txtDiaChiNguoiG.Text = daGvThongTinNG.Rows[daGvThongTinNG.CurrentRow.Index].Cells[2].Value.ToString();
                 txtDienThoaiNguoiG.Text = daGvThongTinNG.Rows[daGvThongTinNG.CurrentRow.Index].Cells[3].Value.ToString();
             }
        
         }*/
        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaG = txtMaNguoiG.Text;
            string hotenNG = txtTenNguoiG.Text;
            string DiachNg = txtDiaChiNguoiG.Text;
            string Tel = txtDienThoaiNguoiG.Text;

            try
            {
                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);

                //mo ket noi co so du lieu
                conn.Open();
                string sqlcommnd = "Update NGUOIGUI SET HOTEN_NG='" + hotenNG + "',DIACHI='" + DiachNg + "',TEL=" + Tel + " WHERE MANGUOIGUI='" + MaG + "'";
                //thuc thu phat bieu  SqL,thu tuc noi tai cua SQl server ,ten bang du lieu va tra ve mau tin thuc
                //215(1)
                commnd = new SqlCommand(sqlcommnd, conn);
                commnd.ExecuteNonQuery();
                hiendulieuNG();
                conn.Close();


            }
            catch (Exception excep)
            {
                MessageBox.Show("Lỗi do không tồn tại Mã Người Gửi.Yêu Cầu Nhập lại ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);

            }

            
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNG = txtMaNguoiG.Text;
            try
            {
                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();

                string Sqlcomm = "DELETE FROM BUUGUI WHERE     (MANGUOIGUI = '" + MaNG + "')";
                string sqlcom = "DELETE FROM NGUOIGUI WHERE     (MANGUOIGUI = '" + MaNG + "')";
                commndBuG = new SqlCommand(Sqlcomm, conn);
                commndNguoiG = new SqlCommand(sqlcom, conn);

                commndBuG.ExecuteNonQuery();
                commndNguoiG.ExecuteNonQuery();
                hiendulieuNG();
                conn.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }


        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaNG = txtMaNguoiG.Text;
            string hotenNG = txtTenNguoiG.Text;
            string DiachNg = txtDiaChiNguoiG.Text;
            string Tel = txtDienThoaiNguoiG.Text;
            try
            {
                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                string sqlcommd = "INSERT INTO NGUOIGUI(MANGUOIGUI, HOTEN_NG, DIACHI, TEL) VALUES     ('" + MaNG + "', '" + hotenNG + " ', '" + DiachNg + "', '" + Tel + " ')";
                commnd = new SqlCommand(sqlcommd, conn);
                commnd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
            hiendulieuNG();

        }
        //bang nguoi nhan

        private void hiendulieuNguoiN()
        {
            try
            {
                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                commnd = new SqlCommand("SELECT * FROM NGUOINHAN", conn);
                da = new SqlDataAdapter(commnd);
                DataSet ds = new DataSet();
                da.Fill(ds, "NguoiNhan");
                daaGVNGuoiN.DataSource = ds.Tables["Nguoinhan"];
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show(exc.StackTrace);
            }
        }

        private void ReSetNullNN()
        {
            txtMaNguoiN.Text = "";
            txtTenNGuoiN.Text = "";
            txtDiaChiNguoiN.Text = "";
            txtTelNguoiN.Text = "";

        }


        private void btnCapNhatNguoiN_Click(object sender, EventArgs e)
        {
            ReSetNullNN();

        }

        private void btnSuaNGuoiN_Click(object sender, EventArgs e)
        {
            string MaNN = txtMaNguoiN.Text;
            string hotenNN = txtTenNGuoiN.Text;
            string diachiNN = txtDiaChiNguoiN.Text;
            int tel = Convert.ToInt32(txtTelNguoiN.Text);

            try
            {
                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);

                conn.Open();
                string sqlcommnd = "Update NGUOINHAN SET HOTEN_NN='" + hotenNN + "',DIACHI='" + diachiNN + "',TEL=" + tel + " WHERE MANGUOINHAN='" + MaNN + "'";

                commnd = new SqlCommand(sqlcommnd, conn);
                commnd.ExecuteNonQuery();
                hiendulieuNguoiN();
                conn.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);


            }
        }

        private void btnxoaNguoiN_Click(object sender, EventArgs e)
        {
            string MaNN = txtMaNguoiN.Text;
            try
            {
                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                commndBuG = new SqlCommand("DELETE FROM BUUGUI WHERE     (MANGUOINHAN= '" + MaNN + "')", conn);
                commndNguoiN = new SqlCommand("DELETE FROM NGUOINHAN WHERE     (MANGUOINHAN = '" + MaNN + "')", conn);
                commndBuG.ExecuteNonQuery();
                commndNguoiN.ExecuteNonQuery();
                hiendulieuNguoiN();
                conn.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }




        }

        private void btnLuNuoiN_Click(object sender, EventArgs e)
        {
            string MaNN = txtMaNguoiN.Text;
            string hotenNN = txtTenNGuoiN.Text;
            string diachiNN = txtDiaChiNguoiN.Text;
            string Tel = txtTelNguoiN.Text;

            try
            {
                //conn = new SqlConnection("Data Source=dang\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                //mo ket noi co so du lieu
                conn.Open();
                //thuc thu phat bieu  SqL,thu tuc noi tai cua SQl server ,ten bang du lieu va tra ve so mau tin thuc
                //215(1)
                string sqlcommd = "INSERT INTO  NGUOINHAN                  (MANGUOINHAN, HOTEN_NN, DIACHI, TEL) VALUES     ('" + MaNN + "', '" + hotenNN + " ', '" + diachiNN + "', '" + Tel + " ')";
                commnd = new SqlCommand(sqlcommd, conn);
                commnd.ExecuteNonQuery();
               /* commnd = new SqlCommand("INSERT INTO NGUOINHAN                     (MANGUOINHAN, HOTEN_NN, DIACHI, TEL) VALUES     ('"+MaNN+"', '"+hotenNN+"', '"+diachiNN+"', '"+Tel+"')", conn);
                //commnd = new SqlCommand("INSERT INTO NGUOINHAN(MANGUOINHAN, HOTEN_NN, DIACHI, TEL) VALUES     ('" + MaNN + "', '" + hotenNN + " ', '" + diachiNN + "', '" + Tel + " '", conn);
                commnd.ExecuteNonQuery();*/
                hiendulieuNguoiN();
                conn.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }
        //phần Bang Bưu  gửi
        private void hiendulieubuugui()
        {
            try
            {
                //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                commnd = new SqlCommand("SELECT     * FROM         BUUGUI", conn);
                da = new SqlDataAdapter(commnd);
                DataSet ds = new DataSet();
                da.Fill(ds, "BUUGUI");
                daGVBuuGui.DataSource = ds.Tables["BUUGUI"];
            
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }
        private void ResetNullBg()
        {
            cmbTenDichVuBuuG.Text = "";
            txtMaBG.Text = "";
            txtSoLuongBG.Text = "";
            txtDonViTinhBg.Text = "";
            txtCuocBuuG.Text = "";
            cbmLoaiDVThemG.Text="";
            txtMaNGG.Text = "";
            txtMaNGN.Text="";


        }
        private void btnCapNhaTBG_Click(object sender, EventArgs e)
        {
            ResetNullBg();
        }
        private void lienket()
        {
            string LOAIddv = cmbTenDichVuBuuG.Text;
            string mabg = txtMaBG.Text;
            string SLBG = txtSoLuongBG.Text;
            string DVTBG = txtDonViTinh.Text;
            string CBG = txtCuocBuuG.Text;
            string LOAIDVT = cbmLoaiDVThemG.Text;
            string MaGG = txtMaNGG.Text;
            string MaNG = txtMaNGN.Text;
            //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QuanLyTienLuong;Integrated Security=True");
            conn = new SqlConnection(connString);
            conn.Open();
            //commnd = new SqlCommand("SELECT     DICHVU.MADV, DICHVUTHEM.MA_DVTHEM FROM         BUUGUI LEFT OUTER JOIN  DICHVU ON BUUGUI.MADV = DICHVU.MADV LEFT OUTER JOIN   DICHVUTHEM ON BUUGUI.MA_DVTHEM = DICHVUTHEM.MA_DVTHEM WHERE LOAIDV='" + LOAIddv + "',LOAI_DVTHEM='" + LOAIDVT + "'", conn);
            commnd = new SqlCommand("SELECT     DICHVU.MADV, DICHVUTHEM.MA_DVTHEM FROM      where   DICHVU.LOAIDV='" + LOAIddv + "' DICHVUTHEM.LOAI_DVTHEM='" + LOAIDVT + "'", conn);
            
            da = new SqlDataAdapter(commnd);
            DataSet ds = new DataSet();

            da.Fill(ds, "mdv_them");
            dt = ds.Tables["mdv_them"];
            string Madv = dt.Rows[0]["MADV"].ToString();
            string MaDVTHEM = dt.Rows[0]["MA_DVTHEM"].ToString();
            conn.Close();
           
        }

        private void btnSuaBG_Click(object sender, EventArgs e)
        {
            //lienket();
            string LOAIddv = cmbTenDichVuBuuG.Text;
            string mabg = txtMaBG.Text;
            string SLBG = txtSoLuongBG.Text;
            string DVTBG = txtDonViTinh.Text;
            string CBG = txtCuocBuuG.Text;
            string LOAIDVT = cbmLoaiDVThemG.Text;
            string MaGG = txtMaNGG.Text;
            string MaNG = txtMaNGN.Text;
            //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QuanLyTienLuong;Integrated Security=True");
            conn = new SqlConnection(connString);
            conn.Open();
            //commnd = new SqlCommand("SELECT     DICHVU.MADV, DICHVUTHEM.MA_DVTHEM FROM         BUUGUI LEFT OUTER JOIN  DICHVU ON BUUGUI.MADV = DICHVU.MADV LEFT OUTER JOIN   DICHVUTHEM ON BUUGUI.MA_DVTHEM = DICHVUTHEM.MA_DVTHEM WHERE LOAIDV='" + LOAIddv + "',LOAI_DVTHEM='" + LOAIDVT + "'", conn);
            commnd = new SqlCommand("SELECT     DICHVU.MADV FROM DICHVU    WHERE   DICHVU.LOAIDV='" + LOAIddv + "' ", conn);
            
            da = new SqlDataAdapter(commnd);
            DataSet ds = new DataSet();

            da.Fill(ds, "mdv");
            dt = ds.Tables["mdv"];
            string Madv = dt.Rows[0]["MADV"].ToString();
            commd1 = new SqlCommand("SELECT DICHVUTHEM.MA_DVTHEM FROM DICHVUTHEM WHERE  DICHVUTHEM.LOAI_DVTHEM='" + LOAIDVT + "'", conn);
            DataSet ds1 = new DataSet();
            da1 = new SqlDataAdapter(commd1);
            da1.Fill(ds1, "mdv_them");
            dt1 = ds1.Tables["mdv_them"];
            string MaDVTHEM = dt1.Rows[0]["MA_DVTHEM"].ToString();
           
            //
           /* string LOAIddv = cmbTenDichVuBuuG.Text;
            string mabg = txtMaBG.Text;
            string SLBG = txtSoLuongBG.Text;
            string DVTBG = txtDonViTinh.Text;
            string CBG = txtCuocBuuG.Text;
            string LOAIDVT = cbmLoaiDVThemG.Text;
            string MaGG = txtMaNGG.Text;
            string MaNG = txtMaNGN.Text;
            */
            try
            {
                //conn = new SqlConnection("Data Source=dang\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                commnd = new SqlCommand(" UPDATE    BUUGUI SET   MADV= '" + Madv + "', SANLUONG = '" + SLBG + "', DONVITINH = '" + DVTBG + "', CUOC = '" + CBG + "',MA_DVTHEM = '" + MaDVTHEM + "', MANGUOIGUI = '" + MaGG + "',  MANGUOINHAN = '" + MaNG + "' WHERE     (MABUUGUI = '" + mabg + "')", conn);
                commnd.ExecuteNonQuery();
                hiendulieubuugui();
                conn.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        

        private void btnXoaBG_Click_1(object sender, EventArgs e)
        {
            string LOAIddv = cmbTenDichVuBuuG.Text;
          
            string mabg = txtMaBG.Text;
            string SLBG = txtSoLuongBG.Text;
            string DVTBG = txtDonViTinh.Text;
            string CBG = txtCuocBuuG.Text;
            string LOAIDVT = cbmLoaiDVThemG.Text;
          
            string MaGG = txtMaNGG.Text;
            string MaNG = txtMaNGN.Text;
            //lienket();
            try
            {
                //conn = new SqlConnection("Data Source=dang\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                conn.Open();
                
                commndNguoiG = new SqlCommand("DELETE FROM NGUOIGUI WHERE     (MABUUGUI = '" + mabg + "')", conn);
                commndNguoiN = new SqlCommand("DELETE FROM NGUOINHAN WHERE     (MABUUGUI = '" + mabg + "')", conn);
                commndBuG = new SqlCommand("DELETE FROM BUUGUI WHERE     (MABUUGUI = '" + mabg + "')", conn);
             
                commndNguoiG.ExecuteNonQuery();
                commndNguoiN.ExecuteNonQuery();
                commndBuG.ExecuteNonQuery();
                hiendulieubuugui();
                conn.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }

        }

        private void btnLuBG_Click(object sender, EventArgs e)
        {
            //lienket();
            string LOAIddv = cmbTenDichVuBuuG.Text;
            string mabg = txtMaBG.Text;
            string SLBG = txtSoLuongBG.Text;
            string DVTBG = txtDonViTinh.Text;
            string CBG = txtCuocBuuG.Text;
            string LOAIDVT = cbmLoaiDVThemG.Text;
            string MaGG = txtMaNGG.Text;
            string MaNG = txtMaNGN.Text;
            //conn = new SqlConnection("Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QuanLyTienLuong;Integrated Security=True");
            conn = new SqlConnection(connString);
            conn.Open();
            //commnd = new SqlCommand("SELECT     DICHVU.MADV, DICHVUTHEM.MA_DVTHEM FROM         BUUGUI LEFT OUTER JOIN  DICHVU ON BUUGUI.MADV = DICHVU.MADV LEFT OUTER JOIN   DICHVUTHEM ON BUUGUI.MA_DVTHEM = DICHVUTHEM.MA_DVTHEM WHERE LOAIDV='" + LOAIddv + "',LOAI_DVTHEM='" + LOAIDVT + "'", conn);
            commnd = new SqlCommand("SELECT     DICHVU.MADV FROM DICHVU    WHERE   DICHVU.LOAIDV='" + LOAIddv + "' ", conn);

            da = new SqlDataAdapter(commnd);
            DataSet ds = new DataSet();

            da.Fill(ds, "mdv");
            dt = ds.Tables["mdv"];
            string Madv = dt.Rows[0]["MADV"].ToString();
            commd1 = new SqlCommand("SELECT DICHVUTHEM.MA_DVTHEM FROM DICHVUTHEM WHERE  DICHVUTHEM.LOAI_DVTHEM='" + LOAIDVT + "'", conn);
            DataSet ds1 = new DataSet();
            da1 = new SqlDataAdapter(commd1);
            da1.Fill(ds1, "mdv_them");
            dt1 = ds1.Tables["mdv_them"];
            string MaDVTHEM = dt1.Rows[0]["MA_DVTHEM"].ToString();
            //
            try
            {
                //conn = new SqlConnection("Data Source=dang\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                conn = new SqlConnection(connString);
                //mo ket noi co so du lieu
                conn.Open();
                //thuc thu phat bieu  SqL,thu tuc noi tai cua SQl server ,ten bang du lieu va tra ve so mau tin thuc
                //215(1)
                commnd = new SqlCommand("INSERT INTO BUUGUI(MABUUGUI, MADV, SANLUONG, DONVITINH, CUOC, MA_DVTHEM, MANGUOIGUI, MANGUOINHAN) VALUES     ('" + mabg + "', '" + Madv + " ', '" + SLBG + "', '" + DVTBG + " ','" + CBG + "','" + MaDVTHEM + "','" + MaGG + "','" + MaNG + "')" , conn);
                commnd.ExecuteNonQuery();
                hiendulieubuugui();
                conn.Close();
            } 
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }

        }

      

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimkiemmabuugui_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}