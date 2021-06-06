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
	/// Summary description for Thong_ke_K_Hang.
	/// </summary>
	public class Thong_ke_K_Hang : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGrid dtGrid_KHang;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtSoDT;
		private System.Windows.Forms.TextBox txtTenKHang;
		private System.Windows.Forms.ComboBox cmMaNhom_KHang;
		private System.Windows.Forms.ComboBox cmMaKhachHang;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Thong_ke_K_Hang()
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
			this.label2 = new System.Windows.Forms.Label();
			this.dtGrid_KHang = new System.Windows.Forms.DataGrid();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenKHang = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btThem = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.btDau = new System.Windows.Forms.Button();
			this.cmMaNhom_KHang = new System.Windows.Forms.ComboBox();
			this.cmMaKhachHang = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtGrid_KHang)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 32);
			this.label2.TabIndex = 29;
			this.label2.Text = "Khách Hàng";
			// 
			// dtGrid_KHang
			// 
			this.dtGrid_KHang.DataMember = "";
			this.dtGrid_KHang.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dtGrid_KHang.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtGrid_KHang.Location = new System.Drawing.Point(0, 231);
			this.dtGrid_KHang.Name = "dtGrid_KHang";
			this.dtGrid_KHang.Size = new System.Drawing.Size(720, 224);
			this.dtGrid_KHang.TabIndex = 45;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(392, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 47;
			this.label4.Text = "&Ghi Chú:";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(392, 48);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtGhiChu.Size = new System.Drawing.Size(328, 120);
			this.txtGhiChu.TabIndex = 6;
			this.txtGhiChu.Text = "";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(120, 176);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(160, 20);
			this.txtMail.TabIndex = 5;
			this.txtMail.Text = "";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(392, 176);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(328, 20);
			this.txtDiaChi.TabIndex = 7;
			this.txtDiaChi.Text = "";
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(120, 144);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(160, 20);
			this.txtSoDT.TabIndex = 4;
			this.txtSoDT.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 144);
			this.label8.Name = "label8";
			this.label8.TabIndex = 35;
			this.label8.Text = "Số Điện thoại:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(344, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 34;
			this.label7.Text = "Địa Chỉ:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 33;
			this.label6.Text = "Mail:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.TabIndex = 30;
			this.label3.Text = "Mã Khách Hàng:";
			// 
			// txtTenKHang
			// 
			this.txtTenKHang.Location = new System.Drawing.Point(120, 112);
			this.txtTenKHang.Name = "txtTenKHang";
			this.txtTenKHang.Size = new System.Drawing.Size(160, 20);
			this.txtTenKHang.TabIndex = 3;
			this.txtTenKHang.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 112);
			this.label1.Name = "label1";
			this.label1.TabIndex = 26;
			this.label1.Text = "Họ Tên:";
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(72, 208);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 25;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(120, 208);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 24;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(168, 208);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 23;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btThem
			// 
			this.btThem.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btThem.Location = new System.Drawing.Point(288, 48);
			this.btThem.Name = "btThem";
			this.btThem.Size = new System.Drawing.Size(72, 23);
			this.btThem.TabIndex = 8;
			this.btThem.Text = "&Thêm";
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Location = new System.Drawing.Point(240, 208);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 11;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(328, 208);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 20;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(416, 208);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 9;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(504, 208);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 10;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(24, 208);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 17;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// cmMaNhom_KHang
			// 
			this.cmMaNhom_KHang.ItemHeight = 13;
			this.cmMaNhom_KHang.Location = new System.Drawing.Point(120, 80);
			this.cmMaNhom_KHang.Name = "cmMaNhom_KHang";
			this.cmMaNhom_KHang.Size = new System.Drawing.Size(160, 21);
			this.cmMaNhom_KHang.TabIndex = 40;
			// 
			// cmMaKhachHang
			// 
			this.cmMaKhachHang.ItemHeight = 13;
			this.cmMaKhachHang.Location = new System.Drawing.Point(120, 48);
			this.cmMaKhachHang.Name = "cmMaKhachHang";
			this.cmMaKhachHang.Size = new System.Drawing.Size(160, 21);
			this.cmMaKhachHang.TabIndex = 40;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "Mã Nhóm:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button2.Location = new System.Drawing.Point(288, 80);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "&Thêm";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Thong_ke_K_Hang
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(639, 250);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtGhiChu);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.txtSoDT);
			this.Controls.Add(this.txtTenKHang);
			this.Controls.Add(this.dtGrid_KHang);
			this.Controls.Add(this.cmMaNhom_KHang);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btLui);
			this.Controls.Add(this.btToi);
			this.Controls.Add(this.btCuoi);
			this.Controls.Add(this.btThem);
			this.Controls.Add(this.btXoa);
			this.Controls.Add(this.btSua);
			this.Controls.Add(this.btLuu);
			this.Controls.Add(this.btHuy);
			this.Controls.Add(this.btDau);
			this.Controls.Add(this.cmMaKhachHang);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Name = "Thong_ke_K_Hang";
			this.Text = "Thong_ke_Khach_Hang";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Thong_ke_K_Hang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtGrid_KHang)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion



		/// <summary>
		/// //////////////////////////////////////////
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void btThem_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			Clear_FrKHang();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Khach_Hang_Nhom nhomKH = new Khach_Hang_Nhom();
			try
			{
				nhomKH.Load_Data_NhomKH();
				
				nhomKH.TatPhim();
			}
			catch//(Exception)
			{
				MessageBox.Show(this,"Không kết nối được với SQL Server","Error!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				Application.Exit();
			}
			nhomKH.ShowDialog();
			nhomKH.TatPhim();
		}

		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtKhacHang = new DataTable();
		DataTable dtNhomKH = new DataTable();
		public int n=0;
		public void Load_Data_TKeKhachHang()
		{
		
			string sqlKhachHang="select * from KhachHang";
			dtKhacHang = ket_noi.getDataTable(sqlKhachHang);
			string sqlNhomKH = "select MaNhomKH from NhomKhachHang";
			dtNhomKH = ket_noi.getDataTable(sqlNhomKH);

			dtGrid_KHang.DataSource=dtKhacHang;//Dịnh vào Combo Box để đựa ra Text Box

			cmMaKhachHang.DataSource=dtKhacHang;
			cmMaKhachHang.DisplayMember="MaKhachHang";
			cmMaKhachHang.ValueMember="MaKhachHang";

			cmMaNhom_KHang.DataSource=dtNhomKH;
			cmMaNhom_KHang.DisplayMember="MaNhomKH";
			cmMaNhom_KHang.ValueMember="MaNhomKH";

			txtTenKHang.DataBindings.Clear();
			txtTenKHang.DataBindings.Add("Text",dtKhacHang,"HoTenKhachHang");

			txtSoDT.DataBindings.Clear();
			txtSoDT.DataBindings.Add("Text",dtKhacHang,"SoDT");

			txtDiaChi.DataBindings.Clear();
			txtDiaChi.DataBindings.Add("Text",dtKhacHang,"DiaChi");

			txtMail.DataBindings.Clear();
			txtMail.DataBindings.Add("Text",dtKhacHang,"E_Mail");

			txtGhiChu.DataBindings.Clear();
			txtGhiChu.DataBindings.Add("Text",dtKhacHang,"GhiChu");	
			MoPhim();
		}
		public void MoPhim()
		{
			button2.Enabled=true;
			btDau.Enabled=true;
			btLui.Enabled=true;
			btToi.Enabled=true;
			btCuoi.Enabled=true;
			btThem.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;
			
			btLuu.Enabled=false;
			btHuy.Enabled=false;
		}
		public void TatPhim()	
		{
			button2.Enabled=false;
			btDau.Enabled=false;
			btLui.Enabled=false;
			btToi.Enabled=false;
			btCuoi.Enabled=false;
			btThem.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;
			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
		}
		public void Clear_FrKHang()
		{
			txtDiaChi.Clear();
			txtGhiChu.Clear();
			txtMail.Clear();
			txtSoDT.Clear();
			txtTenKHang.Clear();
		}

		//Thêm Xóa Sửa
		public void Getinfor()
		{			
			ket_noi.MaKhachHang = cmMaKhachHang.Text;		
			ket_noi.MaNhomKhachHang = cmMaNhom_KHang.Text;
			ket_noi.HoTenKhachHang = txtTenKHang.Text;			
			ket_noi.DiaChi = txtDiaChi.Text;	
			ket_noi.SDT = txtSoDT.Text;	
			ket_noi.EMail = txtMail.Text;	
			ket_noi.GhiCh = txtGhiChu.Text;	
		}
		private int Sqlcommand(int mode,string maKHang, string maNhomKHang, string HoTen, string Dia_Chi, string DThoai, string Email, string Ghichu)
		{
			int i=0;
			try
			{		
				SqlCommand sqlcmd = new SqlCommand("Stor_KhachHang", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@MaKH",SqlDbType.NVarChar).Value= maKHang;
				sqlcmd.Parameters.Add("@MaNhom",SqlDbType.NVarChar).Value=maNhomKHang;
				sqlcmd.Parameters.Add("@HoTen",SqlDbType.NVarChar).Value=HoTen;
				sqlcmd.Parameters.Add("@D_Chi",SqlDbType.NVarChar).Value=Dia_Chi;
				sqlcmd.Parameters.Add("@DT",SqlDbType.NVarChar).Value=DThoai;
				sqlcmd.Parameters.Add("@mail",SqlDbType.NVarChar).Value=Email;
				sqlcmd.Parameters.Add("@GChu",SqlDbType.NVarChar).Value=Ghichu;
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
//				MessageBox.Show(e.ToString());
				MessageBox.Show(this,"Lỗi do ràng bộc hoặc bạn nhập sai!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return i;
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			Load_Data_TKeKhachHang();
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			Getinfor();
			
			if(KiemTra.kiemtraRong_ComBo(cmMaKhachHang,"Mã Khách Hàng "))
			{
				string str="select * from KhachHang  where MaKhachHang='"+cmMaKhachHang.Text+"'" ;
				string strNhom="select * from NhomKhachHang  where MaNhomKH='"+cmMaNhom_KHang.Text+"'" ;
				if(KiemTra.kiemtraRong(txtTenKHang,"Tên Khách Hàng "))
				{
					if(KiemTra.kiemtra_DaTonTai(cmMaKhachHang,"Mã Khác hàng ",str))
						{
						if(KiemTra.kiemtraTTai(cmMaNhom_KHang,"Mã Nhóm Khác hàng ",strNhom))
						{
							if(KiemTra.kiemtraSo(txtSoDT,"Số điện thoại "))
							{
								if(n==1)
								{
									if(Sqlcommand(1,ket_noi.MaKhachHang,ket_noi.MaNhomKhachHang,ket_noi.HoTenKhachHang,ket_noi.DiaChi, ket_noi.SDT, ket_noi.EMail, ket_noi.GhiCh)!=0)
									{						
										MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}			
								}
								else
									if(n==2)
								{				
									if(Sqlcommand(0,ket_noi.MaKhachHang,ket_noi.MaNhomKhachHang,ket_noi.HoTenKhachHang,ket_noi.DiaChi, ket_noi.SDT, ket_noi.EMail, ket_noi.GhiCh)!=0)
									{
										MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
							}
						}
					}		
				}
			}
			
//			Load_Data_TKeKhachHang();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.MaKhachHang,ket_noi.MaNhomKhachHang,ket_noi.HoTenKhachHang,ket_noi.DiaChi, ket_noi.SDT, ket_noi.EMail, ket_noi.GhiCh) !=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_TKeKhachHang();
				}
			}
		}
		public void FirstRecord()
		{
			this.BindingContext[dtKhacHang].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtKhacHang].Position = dtKhacHang.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtKhacHang].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtKhacHang].Position -= 1;			
		}

		private void btDau_Click(object sender, System.EventArgs e)
		{
			FirstRecord();
		}

		private void btLui_Click(object sender, System.EventArgs e)
		{
			PreviousRecord();
		}

		private void btToi_Click(object sender, System.EventArgs e)
		{
			NextRecord();
		}

		private void btCuoi_Click(object sender, System.EventArgs e)
		{
			LastRecord();
		}

		private void btTim_Click(object sender, System.EventArgs e)
		{
			
		}

		private void Thong_ke_K_Hang_Load(object sender, System.EventArgs e)
		{
			Load_Data_TKeKhachHang();
			MoPhim();
			MainForm mf = new MainForm();
			mf.CopyMenu();
		}

	}
}
