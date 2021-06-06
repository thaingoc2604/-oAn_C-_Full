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
	/// Summary description for Amin.
	/// </summary>
	public class Administrator : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtPassConf;
		private System.Windows.Forms.TextBox txtTenN_Dung;
		private System.Windows.Forms.ComboBox cmChucDanh;
		private System.Windows.Forms.RadioButton raAdmin;
		private System.Windows.Forms.RadioButton raNguoiDung;
		private System.Windows.Forms.RadioButton raNguoiXem;
		private System.Windows.Forms.ComboBox cmTenDangNhap;
		private System.Windows.Forms.ComboBox cmQuyen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btSua;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Administrator()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.btOK = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtPassConf = new System.Windows.Forms.TextBox();
			this.txtTenN_Dung = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cmChucDanh = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btThem = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.raAdmin = new System.Windows.Forms.RadioButton();
			this.raNguoiDung = new System.Windows.Forms.RadioButton();
			this.raNguoiXem = new System.Windows.Forms.RadioButton();
			this.cmTenDangNhap = new System.Windows.Forms.ComboBox();
			this.cmQuyen = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btSua = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(232, 240);
			this.btOK.Name = "btOK";
			this.btOK.TabIndex = 7;
			this.btOK.Text = "&OK";
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(240, 32);
			this.label2.TabIndex = 16;
			this.label2.Text = "Quản Trị Chương Trình";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(144, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Password:";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(240, 176);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '|';
			this.txtPass.Size = new System.Drawing.Size(160, 20);
			this.txtPass.TabIndex = 5;
			this.txtPass.Text = "";
			// 
			// txtPassConf
			// 
			this.txtPassConf.Location = new System.Drawing.Point(240, 208);
			this.txtPassConf.Name = "txtPassConf";
			this.txtPassConf.PasswordChar = '|';
			this.txtPassConf.Size = new System.Drawing.Size(160, 20);
			this.txtPassConf.TabIndex = 6;
			this.txtPassConf.Text = "";
			// 
			// txtTenN_Dung
			// 
			this.txtTenN_Dung.Location = new System.Drawing.Point(240, 112);
			this.txtTenN_Dung.Name = "txtTenN_Dung";
			this.txtTenN_Dung.Size = new System.Drawing.Size(160, 20);
			this.txtTenN_Dung.TabIndex = 3;
			this.txtTenN_Dung.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(328, 240);
			this.button2.Name = "button2";
			this.button2.TabIndex = 8;
			this.button2.Text = "&Cancel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(144, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Confirm Password:";
			// 
			// cmChucDanh
			// 
			this.cmChucDanh.Location = new System.Drawing.Point(240, 80);
			this.cmChucDanh.Name = "cmChucDanh";
			this.cmChucDanh.Size = new System.Drawing.Size(160, 21);
			this.cmChucDanh.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Chức Danh:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(144, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Tên Người Dùng:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(144, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Tên Đăng Nhập:";
			// 
			// btThem
			// 
			this.btThem.Location = new System.Drawing.Point(408, 48);
			this.btThem.Name = "btThem";
			this.btThem.TabIndex = 9;
			this.btThem.Text = "&Thêm";
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btXoa
			// 
			this.btXoa.Location = new System.Drawing.Point(408, 88);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 10;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(408, 168);
			this.btClear.Name = "btClear";
			this.btClear.TabIndex = 12;
			this.btClear.Text = "&Clear";
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.raAdmin);
			this.groupBox1.Controls.Add(this.raNguoiDung);
			this.groupBox1.Controls.Add(this.raNguoiXem);
			this.groupBox1.Location = new System.Drawing.Point(8, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 144);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Groups Control";
			// 
			// raAdmin
			// 
			this.raAdmin.ForeColor = System.Drawing.SystemColors.InfoText;
			this.raAdmin.Location = new System.Drawing.Point(8, 24);
			this.raAdmin.Name = "raAdmin";
			this.raAdmin.TabIndex = 13;
			this.raAdmin.Text = "Administrator";
			// 
			// raNguoiDung
			// 
			this.raNguoiDung.ForeColor = System.Drawing.SystemColors.Desktop;
			this.raNguoiDung.Location = new System.Drawing.Point(8, 64);
			this.raNguoiDung.Name = "raNguoiDung";
			this.raNguoiDung.TabIndex = 14;
			this.raNguoiDung.Text = "Người Dùng";
			// 
			// raNguoiXem
			// 
			this.raNguoiXem.Location = new System.Drawing.Point(8, 104);
			this.raNguoiXem.Name = "raNguoiXem";
			this.raNguoiXem.TabIndex = 15;
			this.raNguoiXem.Text = "Người Xem";
			// 
			// cmTenDangNhap
			// 
			this.cmTenDangNhap.Location = new System.Drawing.Point(240, 144);
			this.cmTenDangNhap.Name = "cmTenDangNhap";
			this.cmTenDangNhap.Size = new System.Drawing.Size(160, 21);
			this.cmTenDangNhap.TabIndex = 4;
			// 
			// cmQuyen
			// 
			this.cmQuyen.Items.AddRange(new object[] {
														 "Admin",
														 "User",
														 "Khach"});
			this.cmQuyen.Location = new System.Drawing.Point(240, 48);
			this.cmQuyen.Name = "cmQuyen";
			this.cmQuyen.Size = new System.Drawing.Size(160, 21);
			this.cmQuyen.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(144, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Quyền Sử Dụng:";
			// 
			// btSua
			// 
			this.btSua.Location = new System.Drawing.Point(408, 128);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 11;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// Administrator
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(490, 272);
			this.Controls.Add(this.btSua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btThem);
			this.Controls.Add(this.btXoa);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.cmChucDanh);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtPassConf);
			this.Controls.Add(this.txtTenN_Dung);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmTenDangNhap);
			this.Controls.Add(this.cmQuyen);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Administrator";
			this.Text = "Quan_Tri_Chuong_Trinh";
			this.Load += new System.EventHandler(this.Administrator_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		connet ket_noi = new connet();
		CheckError RBuoc = new CheckError();
//		DataTable dtDangNhap = new DataTable();
		public int n=0;

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		public void Load_form_QuanTri()
		{
			try
			{
				string strDangNhap="select * from DANGNHAP";
				DataSet dsDangNhap = new DataSet();
				dsDangNhap = ket_noi.getDataset(strDangNhap);

				cmTenDangNhap.DataSource=dsDangNhap.Tables[0];
				cmTenDangNhap.DisplayMember="UserName";
				cmTenDangNhap.ValueMember="UserName";

				cmChucDanh.DataSource=dsDangNhap.Tables[0];
				cmChucDanh.DisplayMember="ChucDanh";
				cmChucDanh.ValueMember="ChucDanh";

				txtTenN_Dung.DataBindings.Clear();
				txtTenN_Dung.DataBindings.Add("Text",dsDangNhap.Tables[0],"HoTen");

//				txtPass.DataBindings.Clear();
//				txtPass.DataBindings.Add("Text",dsDangNhap.Tables[0],"Passwords");
				
				raAdmin.DataBindings.Clear();
				raAdmin.DataBindings.Add("Checked",dsDangNhap.Tables[0],"Admin");

				raNguoiDung.DataBindings.Clear();
				raNguoiDung.DataBindings.Add("Checked",dsDangNhap.Tables[0],"NV");

				raNguoiXem.DataBindings.Clear();
				raNguoiXem.DataBindings.Add("Checked",dsDangNhap.Tables[0],"Khach");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,ex.Source);
			}
		}
		public void getInfor()
		{
//			try

			ket_noi.QTPass=txtPass.Text;
			ket_noi.QTChucDanh=cmChucDanh.Text;
			ket_noi.QTHoTen=txtTenN_Dung.Text;
			ket_noi.QTUser=cmTenDangNhap.Text;
			ket_noi.QTPower=cmQuyen.Text;

			ket_noi.QTAdmin=raAdmin.Checked;
			ket_noi.QTNV=raNguoiDung.Checked;
			ket_noi.QTKhach=raNguoiXem.Checked;
		}

		public int sqlCommand(int mode,string UserName,string Pass,string Quyen,bool admin,bool NV,bool Khach,string ChucDanh,string HoTen )
		{			
			int i=0;
			try
			{			
				SqlCommand comm=new SqlCommand("Stor_DangNhap",ket_noi.getConnection);
				comm.CommandType=CommandType.StoredProcedure;
				comm.Parameters.Add("@mode",SqlDbType.Int).Value=mode;
				comm.Parameters.Add("@UsName",SqlDbType.Char).Value=UserName;
				comm.Parameters.Add("@pass",SqlDbType.NVarChar).Value=Pass;
				comm.Parameters.Add("@Quyen",SqlDbType.Char).Value=Quyen;
				comm.Parameters.Add("@Admin",SqlDbType.Bit).Value=admin;
				comm.Parameters.Add("@NV",SqlDbType.Bit).Value=NV;
				comm.Parameters.Add("@Khach",SqlDbType.Bit).Value=Khach;
				comm.Parameters.Add("@ChucDanh",SqlDbType.Char).Value=ChucDanh;
				comm.Parameters.Add("@HoTen",SqlDbType.Char).Value=HoTen;

				i=comm.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,ex.Source);
			}
			return i;
		}

		private void Administrator_Load(object sender, System.EventArgs e)
		{
			Load_form_QuanTri();
			TatPhim();
		}

		private void btThem_Click(object sender, System.EventArgs e)
		{
			n=1;
			MoPhim();	
			Clear_Text();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				getInfor();
				if(sqlCommand(-1,ket_noi.QTUser,ket_noi.QTPass,ket_noi.QTPower,ket_noi.QTAdmin,ket_noi.QTNV,ket_noi.QTKhach,ket_noi.QTChucDanh,ket_noi.QTHoTen)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_form_QuanTri();
				}
			}
		}

		public void TatPhim()
		{
			btOK.Enabled = false;
			button2.Enabled = false;
			btThem.Enabled = true;
			btXoa.Enabled = true;
			btSua.Enabled = true;
			txtPassConf.Enabled=false;
			txtPass.Enabled=false;
		}
		public void MoPhim()
		{
			btOK.Enabled = true;
			button2.Enabled = true;
			btThem.Enabled = false;
			btXoa.Enabled = false;
			btSua.Enabled = false;
			txtPassConf.Enabled=true;
			txtPass.Enabled=true;
		
		}
		public void Clear_Text()
		{
			cmChucDanh.Text="";
			cmTenDangNhap.Text="";
			txtPass.Clear();
			txtPassConf.Clear();			
			txtTenN_Dung.Clear();	
		}

		private void btClear_Click(object sender, System.EventArgs e)
		{
			Clear_Text();
		}

		private bool KiemTra_ConfigPass(string loi)
		{
			bool check=true;
			if(txtPass.Text.Trim() != txtPassConf.Text.Trim())
			{
				MessageBox.Show("Bạn nhập"+loi,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				check=false;
			}
			return check;
		}

		private void btOK_Click(object sender, System.EventArgs e)
		{
			getInfor();
			if(n==1)
			{
				string str="select * from DANGNHAP where UserName='"+cmTenDangNhap.Text+"'";				
				if(RBuoc.ktRong(cmTenDangNhap,"Tên đăng nhập"))
				{
					if(RBuoc.kiemtra_DaTonTai(cmTenDangNhap,"Tên đăng nhập",str))
					{
						if(RBuoc.kiemtraRong(txtTenN_Dung,"Tên người dùng"))
						{
							if(RBuoc.kiemtraRong(txtPass,"Mật khẩu"))
							{
								if(KiemTra_ConfigPass(" PassWord Sai!"))
								{
									if(sqlCommand(1,ket_noi.QTUser,ket_noi.QTPass,ket_noi.QTPower,ket_noi.QTAdmin,ket_noi.QTNV,ket_noi.QTKhach,ket_noi.QTChucDanh,ket_noi.QTHoTen)!=0)
									{						
										MessageBox.Show("Đã lưu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
									}
								}
							}								   
						}
					}
				}	
			}
			else
			{
				if(n==2)
				{
					string str="select * from DANGNHAP where UserName='"+cmTenDangNhap.Text+"'";					
					if(RBuoc.ktRong(cmTenDangNhap,"Tên đăng nhập"))
					{	if(RBuoc.kiemtraRong(txtTenN_Dung,"Tên người dùng"))
							{
								if(RBuoc.kiemtraRong(txtPass,"Mật khẩu"))
								{
									if(KiemTra_ConfigPass(" PassWord Sai!"))
									{
										if(sqlCommand(0,ket_noi.QTUser,ket_noi.QTPass,ket_noi.QTPower,ket_noi.QTAdmin,ket_noi.QTNV,ket_noi.QTKhach,ket_noi.QTChucDanh,ket_noi.QTHoTen)!=0)
										{						
											MessageBox.Show("Đã lưu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
										}
									}
								}								   
							}
					}	
				}
			}
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			MoPhim();
		}
	}
}
