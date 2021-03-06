using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace QLBDDemo
{
    
    public partial class frmLogin : Form
    {
       // private SqlCommand coma;
        //private SqlConnection conn;
        //private SqlDataAdapter da;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int intLoginAttempts;

        //hiện form các dịch vụ
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Instantiate a custom Users class

            Users objUser = new Users();
            GenericPrincipal GenPrincipal;
            string strName = txtUserName.Text;
            string strPassword = txtPassword.Text;


            //thực hiện kiểm tra tài khoản và đăng nhập hệ thống
                if (objUser.IsLogin(strName, strPassword))
                {
                    GenPrincipal = objUser.GetLogin(strName, strPassword);
                    Thread.CurrentPrincipal = GenPrincipal;

                    // Display the Users Name (Windows or Generic)

                    
                    // Show Main Form

                    frmCacDichVu CacDichVu = new frmCacDichVu();

                    CacDichVu.Show();

                    // Hide the Login Form

                    this.Hide();
                }
                else
                {
                    // Increment login attempts
                    intLoginAttempts += 1;
                    // After the 3 attempts quit the application
                    if (intLoginAttempts >= 3)
                    {

                        MessageBox.Show("Bạn đã đăng nhập sai! ", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                    }
                    else
                    {

                        MessageBox.Show("Tên người sử dụng không tồn tại.  Hãy kiểm tra lại thông tin", this.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

            }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
          // /* string name = txtTaiKhoan.Text;
          //  string pass = txtMatKhau.Text;
          //  string Trunggian;
          //  string strSQL;
          //  DataSet ds = new DataSet();
          //Trunggian = "Data Source=dang-129ed804d7\\sqlexpress;Initial Catalog=QLBD;Integrated Security=True";


          //  try
          //  {
          //      conn = new SqlConnection(Trunggian);
          //      conn.Open();
          //  }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show(" Lỗi kết nối đến Cơ Sở Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          //      MessageBox.Show(ex.Message);
          //      MessageBox.Show(ex.StackTrace);

          //  }
          //  strSQL = "Select MANV,MATKHAU from NHANVIEN";
          //  try
          //  {
          //      //thực thi phat bieu Sql truy cap du liau
          //      coma = new SqlCommand(strSQL, conn);
          //  }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show("Lỗi truy cập đến cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          //      MessageBox.Show(ex.Message);
          //      MessageBox.Show(ex.StackTrace);
          //  }
          //  try
          //  {
          //      //đọc dữ lieu từ Sql Server và điền chúng vào đối tương Dataset
          //      da = new SqlDataAdapter(coma);
          //      da.Fill(ds, "DANGNHAP");
          //  }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show("Có vấn đề khi tạo dữ liệu", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          //      MessageBox.Show(ex.Message);
          //      MessageBox.Show(ex.StackTrace);

          //  }
          //  if (ds.Tables["DANGNHAP"].Rows.Count == 0)
          //  {
          //      MessageBox.Show("Không có dữ liệu trong cơ sở dữ liệu");
          //      conn.Close();
          //  }
          //  Boolean check = false;
          //  for (int i = 0; i < ds.Tables["DANGNHAP"].Rows.Count; i++)
          //  {
          //      if (ds.Tables["DANGNHAP"].Rows[i]["MANV"].ToString() == name && ds.Tables["MANV"].Rows[i]["MATKHAU"].ToString() == pass)
          //      {
                    
          //          check = true;

          //          i = ds.Tables["DANGNHAP"].Rows.Count;
          //      }
          //  }
          //  if (check == false)
          //  {
          //      MessageBox.Show("Bạn Nhập Sai Tên Tài Khoản hoặc Pass", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
          //  else
          //  {*/

          //      frmCacDichVu frmcacDichVu = new frmCacDichVu();
          //      frmcacDichVu.Show();
          //      this.Hide();
          //      //frmQuanLyBuuGui frmBuuGui = new frmQuanLyBuuGui();
          //      //frmBuuGui.Show();
          //  //}
        }
    }
