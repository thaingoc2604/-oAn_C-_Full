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
	public class Thong_Ke_Khach_Hang_Only : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.DataGrid dtGrid_KHang;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtSoDT;
		private System.Windows.Forms.TextBox txtTenKHang;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btXemNoiDung;
		private System.Windows.Forms.TextBox txtDiaChiHD;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Thong_Ke_Khach_Hang_Only()
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
			this.btThem = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btXemNoiDung = new System.Windows.Forms.Button();
			this.txtDiaChiHD = new System.Windows.Forms.TextBox();
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
			this.dtGrid_KHang.Location = new System.Drawing.Point(0, 207);
			this.dtGrid_KHang.Name = "dtGrid_KHang";
			this.dtGrid_KHang.Size = new System.Drawing.Size(704, 304);
			this.dtGrid_KHang.TabIndex = 45;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(376, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 47;
			this.label4.Text = "&Ghi Chú:";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(376, 48);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtGhiChu.Size = new System.Drawing.Size(328, 96);
			this.txtGhiChu.TabIndex = 6;
			this.txtGhiChu.Text = "";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(104, 144);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(160, 20);
			this.txtMail.TabIndex = 5;
			this.txtMail.Text = "";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(104, 176);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(160, 20);
			this.txtDiaChi.TabIndex = 7;
			this.txtDiaChi.Text = "";
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(104, 112);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(160, 20);
			this.txtSoDT.TabIndex = 4;
			this.txtSoDT.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 112);
			this.label8.Name = "label8";
			this.label8.TabIndex = 35;
			this.label8.Text = "Số Điện thoại:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 34;
			this.label7.Text = "Địa Chỉ:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 144);
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
			this.txtTenKHang.Location = new System.Drawing.Point(104, 80);
			this.txtTenKHang.Name = "txtTenKHang";
			this.txtTenKHang.Size = new System.Drawing.Size(160, 20);
			this.txtTenKHang.TabIndex = 3;
			this.txtTenKHang.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 80);
			this.label1.Name = "label1";
			this.label1.TabIndex = 26;
			this.label1.Text = "Họ Tên:";
			// 
			// btThem
			// 
			this.btThem.Location = new System.Drawing.Point(280, 48);
			this.btThem.Name = "btThem";
			this.btThem.Size = new System.Drawing.Size(72, 23);
			this.btThem.TabIndex = 8;
			this.btThem.Text = "&Tìm";
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btHuy
			// 
			this.btHuy.Location = new System.Drawing.Point(280, 88);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 10;
			this.btHuy.Text = "&Đóng";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(104, 48);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(160, 20);
			this.txtMaKH.TabIndex = 3;
			this.txtMaKH.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(320, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 51;
			this.label5.Text = "Nội Dung:";
			// 
			// btXemNoiDung
			// 
			this.btXemNoiDung.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXemNoiDung.Location = new System.Drawing.Point(376, 184);
			this.btXemNoiDung.Name = "btXemNoiDung";
			this.btXemNoiDung.Size = new System.Drawing.Size(120, 23);
			this.btXemNoiDung.TabIndex = 50;
			this.btXemNoiDung.Text = "Nội Dung Hợp Đồng";
			this.btXemNoiDung.Click += new System.EventHandler(this.btXemNoiDung_Click);
			// 
			// txtDiaChiHD
			// 
			this.txtDiaChiHD.Location = new System.Drawing.Point(376, 152);
			this.txtDiaChiHD.Name = "txtDiaChiHD";
			this.txtDiaChiHD.ReadOnly = true;
			this.txtDiaChiHD.Size = new System.Drawing.Size(328, 20);
			this.txtDiaChiHD.TabIndex = 48;
			this.txtDiaChiHD.Text = "";
			// 
			// Thong_Ke_Khach_Hang_Only
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(653, 275);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btXemNoiDung);
			this.Controls.Add(this.txtDiaChiHD);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtGhiChu);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.txtSoDT);
			this.Controls.Add(this.txtTenKHang);
			this.Controls.Add(this.dtGrid_KHang);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btThem);
			this.Controls.Add(this.btHuy);
			this.Controls.Add(this.txtMaKH);
			this.Controls.Add(this.label3);
			this.Name = "Thong_Ke_Khach_Hang_Only";
			this.Text = "Thong_Ke_Khach_Hang_Only";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Thong_Ke_Khach_Hang_Only_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtGrid_KHang)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btThem_Click(object sender, System.EventArgs e)
		{
			if(KiemTra.kiemtraRong(txtMaKH,"Mã khách hàng "))
			{
				btThem.Enabled=false;
				Load_Data_TKeKhachHang();
			}
		}

		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtKhacHang = new DataTable();				
		KhachOnly khOnly = new KhachOnly();
		public void Load_Data_TKeKhachHang()
		{
		
			string sqlKhachHang="SELECT * FROM VIEWKhachHangOnly where MaKH='"+txtMaKH.Text+"'";//where  kh.MaKhachHang='"+txtMaKH.Text+"'" ;
			dtKhacHang = ket_noi.getDataTable(sqlKhachHang);
		
			dtGrid_KHang.DataSource=dtKhacHang;//Dịnh vào Combo Box để đựa ra Text Box

			txtMaKH.DataBindings.Clear();
			txtMaKH.DataBindings.Add("Text",dtKhacHang,"MaKH");
		
			txtTenKHang.DataBindings.Clear();
			txtTenKHang.DataBindings.Add("Text",dtKhacHang,"HoTen");

			txtSoDT.DataBindings.Clear();
			txtSoDT.DataBindings.Add("Text",dtKhacHang,"DT");

			txtDiaChi.DataBindings.Clear();
			txtDiaChi.DataBindings.Add("Text",dtKhacHang,"DiaChi");

			txtMail.DataBindings.Clear();
			txtMail.DataBindings.Add("Text",dtKhacHang,"Mail");

			txtGhiChu.DataBindings.Clear();
			txtGhiChu.DataBindings.Add("Text",dtKhacHang,"GhiChu");	
			txtDiaChiHD.DataBindings.Clear();
			txtDiaChiHD.DataBindings.Add("Text",dtKhacHang,"HopDong");	
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			 this.Close();
		}

		private void Thong_Ke_Khach_Hang_Only_Load(object sender, System.EventArgs e)
		{			
		
		}
		CheckError KiemTra = new CheckError();
		private void btXemNoiDung_Click(object sender, System.EventArgs e)
		{
			if(KiemTra.kiemtraRong(txtDiaChiHD,"Bạn chưa có hợp đồng"))
			{
				try
				{
					System.Diagnostics.Process a = new System.Diagnostics.Process();
					a.StartInfo.FileName=@""+txtDiaChiHD.Text+"";
					a.StartInfo.Verb="Open";
					a.Start();
				}
				catch
				{
					MessageBox.Show("Hợp đồng không có ở địa chỉ này!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);									
				}
			}
		}		
	}
}
