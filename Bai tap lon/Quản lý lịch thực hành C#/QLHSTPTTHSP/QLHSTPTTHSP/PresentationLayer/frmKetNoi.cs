using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;

namespace QLHSTPTTHSP.PresentationLayer
{
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();                       
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            this.comboBoxTenServer.Items.AddRange(new string[] { "localhost", "127.0.0.1" });
            this.comboBoxTenServer.SelectedIndex = -1;
            this.checkBoxMacDinh.Checked = true;
            this.ChoPhep(false);
        }

        private void buttonXKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            string queryString = "";
            MySqlConnection mySqlConnection = null;
            MySqlCommand mySqlCommand = null;
            MySqlDataReader mySqlDataReader = null;// Đối tượng được dùng để đọc CSDL

            if (this.KiemTra())
            {
                this.comboBoxExDatabase.Items.Clear();                
                connectionString = "Server=" + this.comboBoxTenServer.Text + ";Username=" + this.textBoxXUsername.Text + ";Password=" + this.textBoxXPassword.Text + ";Database=mysql";
                queryString = "SHOW DATABASES;";// Liệt kê danh sách CSDL
                mySqlConnection = new MySqlConnection(connectionString);
                mySqlCommand = new MySqlCommand(queryString, mySqlConnection);
                try
                {
                    mySqlConnection.Open();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        this.comboBoxExDatabase.Items.Add(mySqlDataReader.GetString(0));
                    }
                    MessageBoxEx.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (MySqlException ex)
                {
                    //2 lỗi kết nối thường gặp
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBoxEx.Show("Không thể kết nối đến server. Vui lòng liên hệ người quản trị!", "Lỗi kết nối đến MySQL Server", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            break;
                        case 1045:
                            MessageBoxEx.Show("Tên người dùng hoặc mật khẩu không hợp lệ. Vui lòng thử lại lần nữa!", "Lỗi đăng nhập đến MySQL Server", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            break;
                        default:
                            MessageBoxEx.Show(ex.Message + " (Vui lòng xem lại các thông số kết nối)", "Lỗi kết nối đến MySQL Server", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            break;
                    }                   
                }
                finally
                {
                    if (mySqlDataReader != null)
                        if (!mySqlDataReader.IsClosed)
                            mySqlDataReader.Close();
                    if (mySqlConnection != null)
                    {
                        if (mySqlConnection.State == ConnectionState.Open)
                            mySqlConnection.Close();
                        mySqlConnection.Dispose();
                    }
                }
            }
        }

        private void buttonXDongY_Click(object sender, EventArgs e)
        {
            if (this.checkBoxMacDinh.CheckState == CheckState.Checked)
            {
                if (QLHSTPTTHSP.Initiation.DataServices.OpenConnection(true))
                {
                    MessageBoxEx.Show("Chúc mừng! Bạn đã đăng nhập thành công vào MySQL Server!", "Kết nối thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                if (this.comboBoxExDatabase.SelectedIndex >= 0)
                {
                    if (QLHSTPTTHSP.Initiation.XuLyChung.GhiFileXML("KetNoi.xml", this.comboBoxTenServer.Text, this.textBoxXUsername.Text, this.textBoxXPassword.Text, this.comboBoxExDatabase.Text))
                        if (QLHSTPTTHSP.Initiation.DataServices.OpenConnection(false))
                        {
                            MessageBoxEx.Show("Chúc mừng! Bạn đã đăng nhập thành công vào MySQL Server!", "Kết nối thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            this.Dispose();
                        }
                }
                else
                {
                    MessageBoxEx.Show("Bạn chưa chọn Cơ sơ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
        }

        private void buttonXBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Kiểm tra dữ liệu nhập vào textbox
        /// </summary>
        /// <returns></returns>
        private bool KiemTra()
        {
            if (this.comboBoxTenServer.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa chọn tên server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            if (this.textBoxXUsername.Text == "")
            {
                MessageBoxEx.Show("Bạn chưa điền tên đăng nhập hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBoxXUsername.Focus();
                return false;
            }
            
            return true;
        }

        private void checkBoxMacDinh_CheckedChanged(object sender, EventArgs e)
        {
            this.ChoPhep(!this.checkBoxMacDinh.Checked);
        }
        private void ChoPhep(bool choPhep)
        {
            this.comboBoxTenServer.Enabled = choPhep;
            this.textBoxXUsername.Enabled = choPhep;
            this.textBoxXPassword.Enabled = choPhep;
            this.buttonXKiemTraKetNoi.Enabled = choPhep;
            this.comboBoxExDatabase.Enabled = choPhep;                    
        }
    }
}