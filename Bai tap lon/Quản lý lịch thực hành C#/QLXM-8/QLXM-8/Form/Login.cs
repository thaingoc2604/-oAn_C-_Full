using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLXM_8
{
    public partial class Login : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Login()
        {
            InitializeComponent();
        }
        #region "Biến cục bộ trong form"
       public OleDbConnection objConnect;
        private DataTable objDataTable;
        private DataTable objDataTable1;

        #endregion
        #region "Tạo và hủy kết nối với database"
        private void ketnoidata()
        {
            String chuoikn = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                            "Data Source =" + Application.StartupPath + @"\qlxm.mdb;";
            objConnect = new OleDbConnection(chuoikn);
            objConnect.Open(); // Mở kết nối
        }
        private void huyketnoidata()
        {
            objConnect.Close(); // Đóng kết nối
            objConnect.Dispose(); // Giải phóng tài nguyên
            objConnect = null; // Hủy đối tượng
        }
        #endregion
        public bool CheckLogin(string name, string pass)
        {
            String chuoikn = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                            "Data Source =" + Application.StartupPath + @"\qlxm.mdb;";
            objConnect = new OleDbConnection(chuoikn);
            // Tạo Command
            OleDbCommand cmd = new OleDbCommand("select * from Dang_Nhap where UserName='" + name + "' and PassWord='" + pass + "'", objConnect);
            objConnect.Open(); // Mở kết nối
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                objConnect.Close();
                return true;
            }
            objConnect.Close();
            return false;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txt_user.Text, txt_pass.Text))
            {
                main frmmain = new main();
                frmmain.Show();
               
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
