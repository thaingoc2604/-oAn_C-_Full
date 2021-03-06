using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBDDemo
{
    public partial class frmQuanlythucuoc : Form
    {
        private SqlConnection conn2;
        private SqlCommand commnd2,commnd3,commnd4;
        private SqlDataAdapter da2;
        private DataSet ds2 = new DataSet();
        private String connString = "server = (local)\\SQLEXPRESS; database = QLBD; Integrated Security = true";

        private DataTable dt2 = new DataTable();
        public frmQuanlythucuoc()
        {
            InitializeComponent();
        }

        private void HienThiDuLieu1()
        {

            try
            {
              
                conn2 = new SqlConnection(connString);
                conn2.Open();
                
                commnd2 = new SqlCommand("SELECT KHACHHANG.TEL,KHACHHANG.HOTEN,KHACHHANG.DIACHI,DANGHOATDONG.CUOCTHANG,DANGHOATDONG.TIENDICHVU,DANGHOATDONG.TIENTHUE_VAT,DANGHOATDONG.TONGCUOCTHU,DANGHOATDONG.NGAYNOP from KHACHHANG inner join DANGHOATDONG ON KHACHHANG.TEL=DANGHOATDONG.TEL", conn2);
                
                da2 = new SqlDataAdapter(commnd2);
                DataSet ds2 = new DataSet();
                //dien du lieu vao DataSet 
                //cu phap:sqlDataAdapter.Fill(DataSetName)
                da2.Fill(ds2);
                //Dua du lieu tu nguon :tu bang "BuuGui"vua dat ten ra DataGridView
                dvDangHoatDong.DataSource = ds2.Tables[0];
                //dong ket noi
                conn2.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }


        }
        private void HienThiDuLieu2()
        {

            try
            {

                conn2 = new SqlConnection(connString);
                conn2.Open();

                commnd2 = new SqlCommand("SELECT KHACHHANG.TEL,KHACHHANG.HOTEN,KHACHHANG.DIACHI,BIKHOA.THANGNO,BIKHOA.TIENDICHVU,BIKHOA.TIENTHUE_VAT,BIKHOA.TONGCUOCTHU,BIKHOA.PHIPHAT,BIKHOA.TONGCONG,BIKHOA.TRANGTHAI,BIKHOA.NGAYNOP from KHACHHANG inner join BIKHOA ON KHACHHANG.TEL=BIKHOA.TEL", conn2);

                da2 = new SqlDataAdapter(commnd2);
                DataSet ds2 = new DataSet();
                //dien du lieu vao DataSet 
                //cu phap:sqlDataAdapter.Fill(DataSetName)
                da2.Fill(ds2);
                //Dua du lieu tu nguon :tu bang "BuuGui"vua dat ten ra DataGridView
                dvBiKhoa.DataSource = ds2.Tables[0];
                //dong ket noi
                conn2.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }


        }
        private void HienThiDuLieu3()
        {

            try
            {

                conn2 = new SqlConnection(connString);
                conn2.Open();

                commnd2 = new SqlCommand("SELECT KHACHHANG.TEL,KHACHHANG.HOTEN,KHACHHANG.DIACHI,TAMNGUNG.THANGNGUNGSD,TAMNGUNG.PHIKHOIPHUC,TAMNGUNG.TRANGTHAI,TAMNGUNG.NGAYNOP from KHACHHANG inner join TAMNGUNG ON KHACHHANG.TEL=TAMNGUNG.TEL", conn2);

                da2 = new SqlDataAdapter(commnd2);
                DataSet ds2 = new DataSet();
                //dien du lieu vao DataSet 
                //cu phap:sqlDataAdapter.Fill(DataSetName)
                da2.Fill(ds2);
                //Dua du lieu tu nguon :tu bang "BuuGui"vua dat ten ra DataGridView
                dvTamNgung.DataSource = ds2.Tables[0];
                //dong ket noi
                conn2.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }
        private void HienThiDuLieu0()
        {

            try
            {

                conn2 = new SqlConnection(connString);
                conn2.Open();

                commnd2 = new SqlCommand("SELECT KHACHHANG.TEL,KHACHHANG.HOTEN,KHACHHANG.DIACHI from KHACHHANG", conn2);

                da2 = new SqlDataAdapter(commnd2);
                DataSet ds2 = new DataSet();
                //dien du lieu vao DataSet 
                //cu phap:sqlDataAdapter.Fill(DataSetName)
                da2.Fill(ds2);
                //Dua du lieu tu nguon :tu bang "BuuGui"vua dat ten ra DataGridView
                dvDanhsachthuebao.DataSource = ds2.Tables[0];
                //dong ket noi
                conn2.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }
        private void clear1()
        {
            cboTel.Text = null;
            txtNgayNop.Text = null;
            txtTienDichVu.Text = null;
            txtThue.Text = null;
            txtTongCuoc.Text = null;
        }
      /*  private void Get_tel()
        {
           if (conn2.State == ConnectionState.Open)
           {
              conn2.Close();
           }
            try
            {
                conn2.Open();
                DataSet ds2 = new DataSet("KHACHHANG");
                SqlDataAdapter da2 = new SqlDataAdapter("Select * from KHACHHANG ", conn2);
                da2.Fill(ds2);
                cboTel.DataSource = ds2.Tables[0];
                cboTel.ValueMember = "TEL";
                cboTel.DisplayMember = "TEL";
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        } */

        private void Quanlythucuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBDDataSet4.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter1.Fill(this.qLBDDataSet4.KHACHHANG);
            // TODO: This line of code loads data into the 'qLBDDataSet3.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter.Fill(this.qLBDDataSet3.KHACHHANG);
            // TODO: This line of code loads data into the 'qLBDDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter1.Fill(this.qLBDDataSet1.KHACHHANG);
            // TODO: This line of code loads data into the 'qLBDDataSet.KHACHHANG' table. You can move, or remove it, as needed.
           // this.kHACHHANGTableAdapter.Fill(this.qLBDDataSet.KHACHHANG);
           // Get_tel();
            HienThiDuLieu1();
            HienThiDuLieu2();
            HienThiDuLieu3();
            lblNgayNop2.Visible = false;
            txtNgayNop2.Visible = false;
            lblNgayNop3.Visible = false;
            txtNgayNop3.Visible = false;
        }

        private void rdoDaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            lblNgayNop2.Visible = true;
            txtNgayNop2.Visible = true; 
        }

        private void rdoChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            lblNgayNop2.Visible = false;
            txtNgayNop2.Visible = false;
        }

        private void rdoDaThanhToan2_CheckedChanged(object sender, EventArgs e)
        {
            lblNgayNop3.Visible = true;
            txtNgayNop3.Visible = true;
        }

        private void rdoChuaThanhToan2_CheckedChanged(object sender, EventArgs e)
        {
            lblNgayNop3.Visible = false;
            txtNgayNop3.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear1();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Tel = cboTel.Text;
            
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=QLBD;Integrated Security=True");
                conn2.Open();
                string Sqlcom3 = "DELETE FROM DANGHOATDONG WHERE     (TEL = '" + Tel + "')";
             //  string sqlcom4 = "INSERT INTO BIKHOA (TEL,THANGNO,TIENDICHVU,TIENTHUE_VAT,TONGCUOCTHU,PHIPHAT,TONGCONG,TRANGTHAI,NGAYNOP) VALUES ('" + Tel + "','" + xaucong + "', '" + txtTienDichVu2.Text + "','" + txtThueVAT2.Text + "','" + txtTongThu.Text + "','" + txtPhiPhat.Text + "','" + txtTongCong.Text + "', '" + kiemtra2 + "','" + kiemtra + "')";
                commnd3 = new SqlCommand(Sqlcom3, conn2);
             //   commnd4 = new SqlCommand(sqlcom4, conn2);

                commnd3.ExecuteNonQuery();
                //commnd4.ExecuteNonQuery();

                HienThiDuLieu1();
                conn2.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string Tel = cboTel.Text;
            string Thang = cboCuocThang.Text;
            string Nam = cboNam.Text;
            string Tiendichvu = txtTienDichVu.Text;
            string Tienthue = txtThue.Text;
            string Tongthu = txtTongCuoc.Text;
            string Ngaynop= txtNgayNop.Text;
            string ghep_xau = Thang + '/' + Nam;

            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                //mo ket noi co so du lieu
                conn2.Open();
                //thuc thu phat bieu  SqL,thu tuc noi tai cua SQl server ,ten bang du lieu va tra ve so mau tin thuc
                //215(1)
                // Loi  o day, chua chinh !
                commnd3 = new SqlCommand("INSERT INTO DANGHOATDONG (TEL,CUOCTHANG,TIENDICHVU,TIENTHUE_VAT,TONGCUOCTHU,NGAYNOP) VALUES  ('" + Tel + "', '" + ghep_xau + "', '" + Tiendichvu + "', '" + Tienthue + " ','" + Tongthu + "','" + Ngaynop + "')", conn2);
                commnd3.ExecuteNonQuery();
                HienThiDuLieu1();
                conn2.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        private void btnThoat0_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem0_Click(object sender, EventArgs e)
        {
            cboTel0.Text = null;
            txtHoTen0.Text = null;
            txtDiaChi0.Text = null;

        }

        private void btnSua0_Click(object sender, EventArgs e)
        {
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");


                conn2.Open();
              // string sqlcommnd0="SELECT TEL From KHACHHANG WHERE TEL='"+ cboTel0.Text +"'";
               // if(sqlcommnd0 != cboTel0.Text)   MessageBox.Show("Khong ton tai so dien thoai nay");
               // else
               // {
                string sqlcommnd = "Update KHACHHANG SET HOTEN='" + txtHoTen0.Text + "',DIACHI='" + txtDiaChi0.Text + "' WHERE TEL='" + cboTel0.Text + "'";

                commnd3= new SqlCommand(sqlcommnd, conn2);
                commnd3.ExecuteNonQuery();
                HienThiDuLieu0();
                conn2.Close();
               // }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show("Lỗi do không tồn tại Số điện thoại.Yêu Cầu Nhập lại ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);


            }
        }

        private void btnXoa0_Click(object sender, EventArgs e)
        {
            string Tel = cboTel.Text;
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=QLBD;Integrated Security=True");
                conn2.Open();
                string sqlcom4 = "DELETE FROM KHACHHANG    WHERE     (TEL = '" + Tel + "')";
                commnd4 = new SqlCommand(sqlcom4, conn2);
                commnd4.ExecuteNonQuery();

                HienThiDuLieu0();
                conn2.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show("Lỗi do không tồn tại Số điện thoại.Yêu Cầu Nhập lại ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        private void btnLuu0_Click(object sender, EventArgs e)
        {
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                //mo ket noi co so du lieu
                conn2.Open();
                //thuc thu phat bieu  SqL,thu tuc noi tai cua SQl server ,ten bang du lieu va tra ve so mau tin thuc
                //215(1)
                commnd3 = new SqlCommand("INSERT INTO KHACHHANG (TEL,HOTEN,DIACHI) VALUES ('" + cboTel0.Text + "', '" + txtHoTen0.Text + "', '" + txtDiaChi0.Text + "')", conn2);
                commnd3.ExecuteNonQuery();
                HienThiDuLieu0();
                conn2.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Lỗi do không tồn tại Số điện thoại.Yêu Cầu Nhập lại ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {

        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            string Tel = cboTel2.Text;
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=QLBD;Integrated Security=True");
                conn2.Open();
                string Sqlcom3 = "DELETE FROM BIKHOA WHERE     (TEL = '" + Tel + "')";
                string sqlcom4 = "INSERT INTO DANGHOATDONG (TEL,CUOCTHANG,TIENDICHVU,TIENTHUE_VAT,TONGCUOCTHU,NGAYNOP) VALUES  ('" + Tel + "', '" + "" + "', '" + "" + "', '" + "" + "','" + "" + "','" + "" + "')";
                commnd4 = new SqlCommand(sqlcom4, conn2);
                commnd3 = new SqlCommand(Sqlcom3, conn2);
                

                commnd3.ExecuteNonQuery();
                commnd4.ExecuteNonQuery();
                 
                HienThiDuLieu2();
                HienThiDuLieu1();
                conn2.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            string kiemtra = txtNgayNop.Text;
            if (rdoChuaThanhToan.Checked == true) kiemtra = null;
            string kiemtra2;
            if (rdoChuaThanhToan.Checked == true) kiemtra2 = "Chua thanh toan";
            else kiemtra2 = "Da thanh toan";
            string xaucong = cboThangNo.Text + '/' + cboNam2.Text;
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                //mo ket noi co so du lieu
                conn2.Open();
                //thuc thu phat bieu  SqL,thu tuc noi tai cua SQl server ,ten bang du lieu va tra ve so mau tin thuc
                //215(1
                commnd3 = new SqlCommand("INSERT INTO BIKHOA (TEL,THANGNO,TIENDICHVU,TIENTHUE_VAT,TONGCUOCTHU,PHIPHAT,TONGCONG,TRANGTHAI,NGAYNOP) VALUES ('" + cboTel2.Text + "','" + xaucong + "', '" + txtTienDichVu2.Text + "','" + txtThueVAT2.Text + "','" + txtTongThu.Text + "','" + txtPhiPhat.Text + "','" + txtTongCong.Text + "', '" + kiemtra2 + "','" + kiemtra + "')", conn2);
                commnd3.ExecuteNonQuery();
                HienThiDuLieu2();
                conn2.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Lỗi do không tồn tại Số điện thoại.Yêu Cầu Nhập lại ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        private void btnThem3_Click(object sender, EventArgs e)
        {
            cboTel3.Text = null;
            txtPhiKhoiPhuc.Text = null;
            txtNgayNop3.Text = null;
    
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
             string kiemtra = txtNgayNop3.Text;
            if (rdoChuaThanhToan2.Checked == true) kiemtra = null;
            string kiemtra2;
            if (rdoChuaThanhToan2.Checked == true) kiemtra2 = "Chua thanh toan";
            else kiemtra2 = "Da thanh toan";
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");


                conn2.Open();
                // string sqlcommnd0="SELECT TEL From KHACHHANG WHERE TEL='"+ cboTel0.Text +"'";
                // if(sqlcommnd0 != cboTel0.Text)   MessageBox.Show("Khong ton tai so dien thoai nay");
                // else
                // {
                string sqlcommnd = "Update TAMNGUNG SET THANGNGUNGSD='" + txtThangNgung.Text + "',PHIKHOIPHUC='" + txtPhiKhoiPhuc.Text + "',TRANGTHAI='" + kiemtra2 + "'  ,NGAYNOP='" + kiemtra + "' WHERE TEL='" + cboTel3.Text + "'";

                commnd3 = new SqlCommand(sqlcommnd, conn2);
                commnd3.ExecuteNonQuery();
                HienThiDuLieu3();
                conn2.Close();
                // }

            }
            catch (Exception excep)
            {
                MessageBox.Show("Lỗi do không tồn tại Số điện thoại.Yêu Cầu Nhập lại ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);


            }
        }

        private void btnLuu3_Click(object sender, EventArgs e)
        {
            string kiemtra = txtNgayNop3.Text;
            if (rdoChuaThanhToan2.Checked==true) kiemtra=null;
            string kiemtra2;
            if (rdoChuaThanhToan2.Checked == true) kiemtra2 = "Chua thanh toan";
            else kiemtra2 = "Da thanh toan";
            try
            {
                conn2 = new SqlConnection("Data Source=(local)\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True");
                //mo ket noi co so du lieu
                conn2.Open();
                //thuc thu phat bieu  SqL,thu tuc noi tai cua SQl server ,ten bang du lieu va tra ve so mau tin thuc
                //215(1
                commnd3 = new SqlCommand("INSERT INTO TAMNGUNG (TEL,THANGNGUNGSD,PHIKHOIPHUC,TRANGTHAI,NGAYNOP) VALUES ('" + cboTel3.Text + "','" + txtThangNgung.Text + "', '" + txtPhiKhoiPhuc.Text + "', '" + kiemtra2 + "','" + kiemtra + "')", conn2);
                commnd3.ExecuteNonQuery();
                HienThiDuLieu3();
                conn2.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Lỗi do không tồn tại Số điện thoại.Yêu Cầu Nhập lại ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

    }
}