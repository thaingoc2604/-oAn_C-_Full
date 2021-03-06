using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace qlks
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		public System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnQuanLy;
		private System.Windows.Forms.MenuItem mnCauHinh;
		public System.Windows.Forms.MenuItem mnQLKhachHang;
		public System.Windows.Forms.MenuItem mnLoaiPhong;
		public System.Windows.Forms.MenuItem mnThietBi;
		private System.Windows.Forms.MenuItem mnTB;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnExit;
		private System.Windows.Forms.MenuItem mnPhong;
		private System.Windows.Forms.MenuItem mnHoSoNV;
		private System.Windows.Forms.MenuItem mnCaNhan;
		public System.Windows.Forms.MenuItem mnTBTrangTB;
		private System.Windows.Forms.MenuItem menuItem7;
		// User variables
		public static string msNV = "", tenNV="";
		private System.Windows.Forms.MenuItem mnTimKiem;
		private System.Windows.Forms.MenuItem mnTG;
		private System.Windows.Forms.StatusBar stBar;
		private System.Windows.Forms.StatusBarPanel NhanVien;
		private System.Windows.Forms.StatusBarPanel Date;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnSapXep;
		private System.Windows.Forms.MenuItem mnCascade;
		private System.Windows.Forms.MenuItem mnTileV;
		private System.Windows.Forms.MenuItem mnTileH;
		public System.Windows.Forms.MenuItem mnSDDichVu;
		private System.Windows.Forms.MenuItem mnThanhToan;
		private System.Windows.Forms.MenuItem mnSearchPhong;
		private System.Windows.Forms.MenuItem mnSearchKH;
		private System.Windows.Forms.MenuItem mnAbout;

		public System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new frmMain());			
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnQuanLy = new System.Windows.Forms.MenuItem();
			this.mnQLKhachHang = new System.Windows.Forms.MenuItem();
			this.mnSDDichVu = new System.Windows.Forms.MenuItem();
			this.mnThanhToan = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnExit = new System.Windows.Forms.MenuItem();
			this.mnTimKiem = new System.Windows.Forms.MenuItem();
			this.mnSearchPhong = new System.Windows.Forms.MenuItem();
			this.mnSearchKH = new System.Windows.Forms.MenuItem();
			this.mnCauHinh = new System.Windows.Forms.MenuItem();
			this.mnTB = new System.Windows.Forms.MenuItem();
			this.mnPhong = new System.Windows.Forms.MenuItem();
			this.mnLoaiPhong = new System.Windows.Forms.MenuItem();
			this.mnThietBi = new System.Windows.Forms.MenuItem();
			this.mnTBTrangTB = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.mnHoSoNV = new System.Windows.Forms.MenuItem();
			this.mnTG = new System.Windows.Forms.MenuItem();
			this.mnSapXep = new System.Windows.Forms.MenuItem();
			this.mnCascade = new System.Windows.Forms.MenuItem();
			this.mnTileV = new System.Windows.Forms.MenuItem();
			this.mnTileH = new System.Windows.Forms.MenuItem();
			this.mnCaNhan = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.mnAbout = new System.Windows.Forms.MenuItem();
			this.stBar = new System.Windows.Forms.StatusBar();
			this.NhanVien = new System.Windows.Forms.StatusBarPanel();
			this.Date = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.NhanVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnQuanLy,
																					  this.mnTimKiem,
																					  this.mnCauHinh,
																					  this.mnTG});
			// 
			// mnQuanLy
			// 
			this.mnQuanLy.Index = 0;
			this.mnQuanLy.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnQLKhachHang,
																					 this.mnSDDichVu,
																					 this.mnThanhToan,
																					 this.menuItem3,
																					 this.mnExit});
			this.mnQuanLy.Text = "Quản Lý";
			// 
			// mnQLKhachHang
			// 
			this.mnQLKhachHang.Index = 0;
			this.mnQLKhachHang.Text = "Khách hàng đặt phòng";
			this.mnQLKhachHang.Click += new System.EventHandler(this.mnQLKhachHang_Click);
			// 
			// mnSDDichVu
			// 
			this.mnSDDichVu.Index = 1;
			this.mnSDDichVu.Text = "Sử dụng dịch vụ";
			this.mnSDDichVu.Click += new System.EventHandler(this.mnQLPhong_Click);
			// 
			// mnThanhToan
			// 
			this.mnThanhToan.Index = 2;
			this.mnThanhToan.Text = "Thanh toán phòng";
			this.mnThanhToan.Click += new System.EventHandler(this.mnThanhToan_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 3;
			this.menuItem3.Text = "-";
			// 
			// mnExit
			// 
			this.mnExit.Index = 4;
			this.mnExit.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
			this.mnExit.Text = "Thoát";
			this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
			// 
			// mnTimKiem
			// 
			this.mnTimKiem.Index = 1;
			this.mnTimKiem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnSearchPhong,
																					  this.mnSearchKH});
			this.mnTimKiem.Text = "Tìm kiếm";
			// 
			// mnSearchPhong
			// 
			this.mnSearchPhong.Index = 0;
			this.mnSearchPhong.Text = "Phòng";
			this.mnSearchPhong.Click += new System.EventHandler(this.mnSearchPhong_Click);
			// 
			// mnSearchKH
			// 
			this.mnSearchKH.Index = 1;
			this.mnSearchKH.Text = "Khách hàng";
			this.mnSearchKH.Click += new System.EventHandler(this.mnSearchKH_Click);
			// 
			// mnCauHinh
			// 
			this.mnCauHinh.Index = 2;
			this.mnCauHinh.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnTB,
																					  this.menuItem5,
																					  this.mnHoSoNV});
			this.mnCauHinh.Text = "Cấu hình";
			// 
			// mnTB
			// 
			this.mnTB.Index = 0;
			this.mnTB.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				 this.mnPhong,
																				 this.mnLoaiPhong,
																				 this.mnThietBi,
																				 this.mnTBTrangTB});
			this.mnTB.Text = "Trang bị";
			// 
			// mnPhong
			// 
			this.mnPhong.Index = 0;
			this.mnPhong.Text = "Phòng";
			this.mnPhong.Click += new System.EventHandler(this.mnPhong_Click);
			// 
			// mnLoaiPhong
			// 
			this.mnLoaiPhong.Index = 1;
			this.mnLoaiPhong.Text = "Loại phòng";
			this.mnLoaiPhong.Click += new System.EventHandler(this.mnLoaiPhong_Click);
			// 
			// mnThietBi
			// 
			this.mnThietBi.Index = 2;
			this.mnThietBi.Text = "Nhập trang thiết bị";
			this.mnThietBi.Click += new System.EventHandler(this.mnThietBi_Click);
			// 
			// mnTBTrangTB
			// 
			this.mnTBTrangTB.Index = 3;
			this.mnTBTrangTB.Text = "Trang bị trang thiết bị cho phòng";
			this.mnTBTrangTB.Click += new System.EventHandler(this.mnTBTrangTB_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// mnHoSoNV
			// 
			this.mnHoSoNV.Index = 2;
			this.mnHoSoNV.Text = "Hồ sơ nhân viên";
			this.mnHoSoNV.Click += new System.EventHandler(this.mnHoSoNV_Click);
			// 
			// mnTG
			// 
			this.mnTG.Index = 3;
			this.mnTG.MdiList = true;
			this.mnTG.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				 this.mnSapXep,
																				 this.mnCaNhan,
																				 this.menuItem1,
																				 this.menuItem7,
																				 this.mnAbout});
			this.mnTG.Text = "Trợ giúp";
			// 
			// mnSapXep
			// 
			this.mnSapXep.Index = 0;
			this.mnSapXep.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnCascade,
																					 this.mnTileV,
																					 this.mnTileH});
			this.mnSapXep.Text = "Sắp xếp";
			// 
			// mnCascade
			// 
			this.mnCascade.Index = 0;
			this.mnCascade.Text = "Cascade";
			this.mnCascade.Click += new System.EventHandler(this.mnCascade_Click);
			// 
			// mnTileV
			// 
			this.mnTileV.Index = 1;
			this.mnTileV.Text = "TileVertical";
			this.mnTileV.Click += new System.EventHandler(this.mnTileV_Click);
			// 
			// mnTileH
			// 
			this.mnTileH.Index = 2;
			this.mnTileH.Text = "TileHorizontal";
			this.mnTileH.Click += new System.EventHandler(this.mnTileH_Click);
			// 
			// mnCaNhan
			// 
			this.mnCaNhan.Index = 1;
			this.mnCaNhan.Text = "Thay đổi mật khẩu";
			this.mnCaNhan.Click += new System.EventHandler(this.mnCaNhan_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "Hướng dẫn sử dụng chương trình";
			// 
			// mnAbout
			// 
			this.mnAbout.Index = 4;
			this.mnAbout.Text = "Thông tin tác giả";
			this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click);
			// 
			// stBar
			// 
			this.stBar.Location = new System.Drawing.Point(0, 317);
			this.stBar.Name = "stBar";
			this.stBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.NhanVien,
																					 this.Date});
			this.stBar.ShowPanels = true;
			this.stBar.Size = new System.Drawing.Size(488, 24);
			this.stBar.TabIndex = 1;
			this.stBar.Text = "TTTTTTTTT";
			// 
			// NhanVien
			// 
			this.NhanVien.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.NhanVien.MinWidth = 200;
			this.NhanVien.Text = "Nhân viên:";
			this.NhanVien.Width = 200;
			// 
			// Date
			// 
			this.Date.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Date.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.Date.MinWidth = 200;
			this.Date.Text = "Date";
			this.Date.Width = 272;
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(488, 341);
			this.Controls.Add(this.stBar);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "frmMain";
			this.Text = "Quản Lý Khách Sạn";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.NhanVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Date)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private void frmMain_Load(object sender, System.EventArgs e)
		{
			if (msNV=="")
			{
				frmLogin f = new frmLogin();
				//f.MdiParent = this;
				f.Show ();
				this.Hide();
			}
		}

		private void mnPhong_Click(object sender, System.EventArgs e)
		{
			frmPhong f = new frmPhong();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnThietBi_Click(object sender, System.EventArgs e)
		{
			frmThietBi f = new frmThietBi();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnHoSoNV_Click(object sender, System.EventArgs e)
		{
			frmNV f = new frmNV();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnLoaiPhong_Click(object sender, System.EventArgs e)
		{
			frmLoaiPhong f = new frmLoaiPhong();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnTBTrangTB_Click(object sender, System.EventArgs e)
		{
			frmTBTrangTB f = new frmTBTrangTB();
			f.MdiParent = this;
			f.Show ();
		}

		private void mnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		public void enableFormMain(string masoNV)
		{
			msNV = masoNV;
			DataTable dtNV= new DataTable();
			dtNV=SqlHelper.ExecuteQuery(
				"select top 1 MSNV from NHANVIEN order by MSNV",
				CommandType.Text);
			if (dtNV.Rows[0]["MSNV"].ToString()!=msNV)
				mnCauHinh.Visible=false;
			dtNV=SqlHelper.ExecuteQuery(
				"select HOTENNV from NHANVIEN where MSNV='"+msNV+"'",
				CommandType.Text);
			tenNV=dtNV.Rows[0]["HOTENNV"].ToString();
			stBar.Panels[0].Text="Nhân viên : " + tenNV;
			stBar.Panels[1].Text="Hôm nay : " + DateTime.Now.ToShortDateString();
		}

		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}

		private void mnQLKhachHang_Click(object sender, System.EventArgs e)
		{
			frmKH f = new frmKH();
			f.MdiParent=this;
			f.Show();
		}

		private void mnQLPhong_Click(object sender, System.EventArgs e)
		{
			frmSDDichVu f = new frmSDDichVu();
			f.MdiParent=this;
			f.Show();
		}

		private void mnCascade_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi( MdiLayout.Cascade );
		}

		private void mnTileH_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi( MdiLayout.TileHorizontal );
		}

		private void mnTileV_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi( MdiLayout.TileVertical );
		}

		private void mnThanhToan_Click(object sender, System.EventArgs e)
		{
			frmTraPhong f = new frmTraPhong();
			f.MdiParent=this;
			f.Show();
		}

		private void mnSearchKH_Click(object sender, System.EventArgs e)
		{
			frmSearchKH f = new frmSearchKH();
			f.MdiParent=this;
			f.Show();
		}

		private void mnSearchPhong_Click(object sender, System.EventArgs e)
		{
			frmSearchPhong f = new frmSearchPhong();
			f.MdiParent=this;
			f.Show();
		}

		private void mnCaNhan_Click(object sender, System.EventArgs e)
		{
			frmChangeProfile f = new frmChangeProfile();
			f.MdiParent=this;
			f.Show();
		}

		private void mnAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Project 2 - Chương trình quản lý khách sạn.\r\nHọc viên: Trần Minh Trí - Lớp: LTV26.","Thông tin tác giả");
		}

	}
}
