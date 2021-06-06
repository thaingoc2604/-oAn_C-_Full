using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Quan_Ly_Mua_Ban
{
	/// <summary>
	/// Summary description for Log_on.
	/// </summary>
	public class Log_on : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUser;
		public System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Log_on()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			DisplayIcon Display = new DisplayIcon();
			Display.Start();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Log_on));
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(480, 32);
			this.label3.TabIndex = 8;
			this.label3.Text = "Chương trình quản lý mua bán hàng hóa.";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtUser);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt);
			this.groupBox1.Location = new System.Drawing.Point(8, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 112);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin đăng nhập";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 88);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(344, 80);
			this.button3.Name = "button3";
			this.button3.TabIndex = 5;
			this.button3.Text = "Giúp đở";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(248, 80);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "Hủy bỏ";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(248, 48);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '|';
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "";
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(144, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Mật Khẩu:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(248, 16);
			this.txtUser.Name = "txtUser";
			this.txtUser.TabIndex = 1;
			this.txtUser.Text = "";
			this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(144, 80);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "Ðăng nhập";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tên Ðăng Nhập:";
			// 
			// txt
			// 
			this.txt.Location = new System.Drawing.Point(360, 16);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(48, 20);
			this.txt.TabIndex = 1;
			this.txt.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 40);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ðăng Nhập Hệ Thống";
			// 
			// Log_on
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 198);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Log_on";
			this.ShowInTaskbar = false;
			this.Text = "Log_in";
			this.Load += new System.EventHandler(this.Log_on_Load);
			this.Closed += new System.EventHandler(this.Log_on_Closed);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		connet ket_noi = new connet();
		DataTable dtDangNhap = new DataTable();
		private SqlDataAdapter dap;
//		ConnectSQL mgrCon = new ConnectSQL();
//        public int quyen=0;

		public void KTQUYEN()
		{
			string sqlQuyen= "Select Quyen from DangNhap where (Passwords='"+txtPassword.Text+"' and UserName='"+txtUser.Text+"')";
			dap=new SqlDataAdapter(sqlQuyen,ket_noi.getConnection);
			DataSet ds=new DataSet();
			dap.Fill(ds,"DangNhap");
			dtDangNhap=ds.Tables[0];
			
			txt.DataBindings.Clear();
			txt.DataBindings.Add("Text",dtDangNhap,"Quyen");
			string quyenDN=txt.Text.Trim();
			
			if(quyenDN.Equals("Admin")==true)
			{
				MessageBox.Show("Bạn đăng nhập quyền Admin!!","Thong Tin Dang Nhap",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Hide();
				MainForm admin=new MainForm();
				admin.Show();
			}
			else
			{
				if(quyenDN.Equals("User")==true)
				{
					MessageBox.Show("Bạn đang đăng nhập quyền Người Dùng!!!","Thong Tin Dang Nhap",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Hide();
					MainForm User=new MainForm();					
					User.Show();	
					User.QuyenUser();					
				}
				else
				{
					if(quyenDN.Equals("Khach")==true)
					{

						MessageBox.Show("Bạn đăng nhập quyền Khách Hàng","Thông tin đăng nhập",MessageBoxButtons.OK,MessageBoxIcon.Information);
						
						this.Hide();
						KhachOnly khach = new KhachOnly();
						khach.Show();

					}
					else
						MessageBox.Show("User này không có quyền đăng nhập!!","Thông tin đăng nhập",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			
			
//			con.Close();
		}
		public bool checkexistTen(string sql,TextBox txt, string ms)
		{
//			con.Open();
			bool f=true;
			dap=new SqlDataAdapter(sql,ket_noi.getConnection);
			DataSet ds=new DataSet();
			dap.Fill(ds,"DangNhap");
			dtDangNhap=ds.Tables[0];
			if(dtDangNhap.Rows.Count==0)
			{
				f=false;
				MessageBox.Show(ms,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txt.Text="";
				txt.Focus();
			}
//			con.Close();
			
			return f;
		}

		public bool checkexistMK(string sql,TextBox txt, string ms)
		{
//			con.Open();
			bool f=true;
			dap=new SqlDataAdapter(sql,ket_noi.getConnection);
			DataSet ds=new DataSet();
			dap.Fill(ds,"DANGNHAP");
			dtDangNhap=ds.Tables[0];
			if(dtDangNhap.Rows.Count==0)
			{
				f=false;
				MessageBox.Show(ms,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtPassword.Text="";
				txtPassword.Focus();
			}
//			con.Close();
			return f;
		}
		private bool checknulltb(TextBox txt, string ms)
		{
			bool f = true;
			if((txt.Text.Length == 0) || (txt.Text.Trim()==""))
			{
				f = false;
				MessageBox.Show(ms, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt.Text="";
				txt.Focus();
			}
			return f;
		}
		public void Login()
		{
			string sqlTen="Select UserName from DangNhap where UserName='"+txtUser.Text+"'";
			string sqlMK= "Select Passwords from DangNhap where (PassWords='"+txtPassword.Text+"' and UserName='"+txtUser.Text+"')";
			if(checknulltb(txtUser, "Tên đăng nhập không được rỗng !"))
			{
				if(checknulltb(txtPassword,"Mật khẩu không được rỗng !"))				
				{
					if(checkexistTen(sqlTen,txtUser,"Tên đăng nhập này không tồn tại. Bạn phải đăng nhập lại !"))
					{
						if(checkexistMK(sqlMK,txtUser,"Bạn đánh sai mật khẩu !"))
						{
							
							KTQUYEN();
						}
					}
				}
			}
			//			if (Quan_Ly_Mua_Ban.connet()==false)
			//				return;
			//			this.Hide();			
			//			MainForm Mfrom = new MainForm();
			//			Mfrom.Show();
//						frmAbout frabout = new frmAbout();
//						frabout.ShowDialog();
		}
		
		private void button1_Click(object sender, System.EventArgs e)
		{
			Login();
		}

		private void Thoat()
		{
			DialogResult result= MessageBox.Show("Bạn muốn thóat khỏi chương trình?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			if(Convert.ToString(result)=="Yes")
			{
				Application.Exit();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Thoat();
		}

		private void txtUser_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar==13)
				txtPassword.Focus();
		}

		private void txtPassword_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar==13)
				Login();
		}

		private void Log_on_Load(object sender, System.EventArgs e)
		{

			ket_noi.TestConnection();
			txt.Hide();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process a = new System.Diagnostics.Process();
				a.StartInfo.FileName=@"C:\help.chm";
				a.StartInfo.Verb="Open";
				//			a.StartInfo.Arguments=@" "+txtDiaChiHD.Text+" ";
				a.Start();
			}
			catch
			{
				MessageBox.Show("Files help không có ở địa chỉ này!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);									
			}
		}

		private void Log_on_Closed(object sender, System.EventArgs e)
		{
			DisplayIcon dplay = new DisplayIcon();
			dplay.DongIcon();
		}

	}
}
