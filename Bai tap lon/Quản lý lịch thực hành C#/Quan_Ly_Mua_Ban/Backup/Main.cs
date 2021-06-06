using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Quan_Ly_Mua_Ban
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		public System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.StatusBarPanel sttusQuyen;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.ToolBarButton LogOff;
		private System.Windows.Forms.ToolBarButton KhachHang;
		private System.Windows.Forms.ToolBarButton NhaCungUng;
		private System.Windows.Forms.ToolBarButton HangHoa;
		private System.Windows.Forms.ToolBarButton HopDongBan;
		private System.Windows.Forms.ToolBarButton HopDongMua;
		private System.Windows.Forms.ToolBarButton CTHopDongBan;
		private System.Windows.Forms.ToolBarButton CTHopDongMua;
		private System.Windows.Forms.ToolBarButton PhieuThu;
		private System.Windows.Forms.ToolBarButton PhieuChi;
		private System.Windows.Forms.ToolBarButton LuuTruHDBan;
		private System.Windows.Forms.ToolBarButton LuuTruHDMua;
		private System.Windows.Forms.ToolBarButton Help;
		private System.Windows.Forms.ToolBarButton tim;
		private System.Windows.Forms.ToolBarButton Lienhe;
		private System.Windows.Forms.MenuItem menuItem37;
		private System.Windows.Forms.MenuItem menuItem38;
		public System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem39;
		private System.ComponentModel.IContainer components;

		public MainForm()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.sttusQuyen = new System.Windows.Forms.StatusBarPanel();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem37 = new System.Windows.Forms.MenuItem();
			this.menuItem38 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem31 = new System.Windows.Forms.MenuItem();
			this.menuItem32 = new System.Windows.Forms.MenuItem();
			this.menuItem33 = new System.Windows.Forms.MenuItem();
			this.menuItem34 = new System.Windows.Forms.MenuItem();
			this.menuItem35 = new System.Windows.Forms.MenuItem();
			this.menuItem36 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.LogOff = new System.Windows.Forms.ToolBarButton();
			this.KhachHang = new System.Windows.Forms.ToolBarButton();
			this.NhaCungUng = new System.Windows.Forms.ToolBarButton();
			this.HangHoa = new System.Windows.Forms.ToolBarButton();
			this.HopDongBan = new System.Windows.Forms.ToolBarButton();
			this.HopDongMua = new System.Windows.Forms.ToolBarButton();
			this.CTHopDongBan = new System.Windows.Forms.ToolBarButton();
			this.CTHopDongMua = new System.Windows.Forms.ToolBarButton();
			this.PhieuThu = new System.Windows.Forms.ToolBarButton();
			this.PhieuChi = new System.Windows.Forms.ToolBarButton();
			this.LuuTruHDBan = new System.Windows.Forms.ToolBarButton();
			this.LuuTruHDMua = new System.Windows.Forms.ToolBarButton();
			this.Help = new System.Windows.Forms.ToolBarButton();
			this.tim = new System.Windows.Forms.ToolBarButton();
			this.Lienhe = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem39 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sttusQuyen)).BeginInit();
			this.SuspendLayout();
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 138);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2,
																						  this.sttusQuyen});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(608, 22);
			this.statusBar1.TabIndex = 1;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.Text = "Ready";
			this.statusBarPanel1.Width = 362;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.Width = 130;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3,
																					  this.menuItem8,
																					  this.menuItem10,
																					  this.menuItem12,
																					  this.menuItem24,
																					  this.menuItem29,
																					  this.menuItem5});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem28,
																					  this.menuItem2});
			this.menuItem1.Text = "&Files";
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 0;
			this.menuItem28.Text = "&Log Out";
			this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "&Exit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem37,
																					  this.menuItem38});
			this.menuItem3.Text = "&Khách Hàng";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "&Thống Kê Khách Hàng";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "&Tìm Kiếm";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem37
			// 
			this.menuItem37.Index = 3;
			this.menuItem37.Text = "-";
			// 
			// menuItem38
			// 
			this.menuItem38.Index = 4;
			this.menuItem38.Text = "&Khách Hàng";
			this.menuItem38.Click += new System.EventHandler(this.menuItem38_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem9});
			this.menuItem8.Text = "&Nhà Cung Ứng";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "&Thống Kê Nhà Cung Ứng";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem11,
																					   this.menuItem39});
			this.menuItem10.Text = "&Hàng Hóa";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "&Thống Kê Hàng Hóa";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 4;
			this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem13,
																					   this.menuItem18,
																					   this.menuItem14,
																					   this.menuItem26,
																					   this.menuItem15,
																					   this.menuItem16,
																					   this.menuItem19,
																					   this.menuItem17,
																					   this.menuItem27});
			this.menuItem12.Text = "&Hợp Đồng";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 0;
			this.menuItem13.Text = "Hợp Đồng &Bán";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 1;
			this.menuItem18.Text = "Chi Tiết Hợp Đồng &Bán";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 2;
			this.menuItem14.Text = "Phiếu &Thu";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 3;
			this.menuItem26.Text = "&Lưu Trữ Hợp Đồng Bán";
			this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 4;
			this.menuItem15.Text = "-";
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 5;
			this.menuItem16.Text = "Hợp Đồng &Mua";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 6;
			this.menuItem19.Text = "Chi Tiết Hợp Đồng &Mua";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 7;
			this.menuItem17.Text = "Phiếu &Chi";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 8;
			this.menuItem27.Text = "&Lưu Trữ Hợp Đồng Mua";
			this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 5;
			this.menuItem24.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem25});
			this.menuItem24.Text = "&Administrator";
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 0;
			this.menuItem25.Text = "&Quản Trị Chương Trình";
			this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 6;
			this.menuItem29.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem30,
																					   this.menuItem31,
																					   this.menuItem32,
																					   this.menuItem33,
																					   this.menuItem34,
																					   this.menuItem35,
																					   this.menuItem36});
			this.menuItem29.Text = "&Báo Cáo";
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 0;
			this.menuItem30.Text = "&Hàng Hóa";
			this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
			// 
			// menuItem31
			// 
			this.menuItem31.Index = 1;
			this.menuItem31.Text = "-";
			// 
			// menuItem32
			// 
			this.menuItem32.Index = 2;
			this.menuItem32.Text = "Chi Tiết Hợp Đồng &Bán";
			this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
			// 
			// menuItem33
			// 
			this.menuItem33.Index = 3;
			this.menuItem33.Text = "Phiếu Thu";
			this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
			// 
			// menuItem34
			// 
			this.menuItem34.Index = 4;
			this.menuItem34.Text = "-";
			// 
			// menuItem35
			// 
			this.menuItem35.Index = 5;
			this.menuItem35.Text = "Chi Tiết Hợp Đồng &Mua";
			this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
			// 
			// menuItem36
			// 
			this.menuItem36.Index = 6;
			this.menuItem36.Text = "Phiếu &Chi";
			this.menuItem36.Click += new System.EventHandler(this.menuItem36_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 7;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem20,
																					  this.menuItem21,
																					  this.menuItem23,
																					  this.menuItem22});
			this.menuItem5.Text = "&Help";
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 0;
			this.menuItem20.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.menuItem20.Text = "Hướng Dẫn Sủ Dụng Chương &Trình";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 1;
			this.menuItem21.Text = "&Liên Hệ Với Chúng Tôi";
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 2;
			this.menuItem23.Text = "-";
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 3;
			this.menuItem22.Text = "&About Program";
			this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.LogOff,
																						this.KhachHang,
																						this.NhaCungUng,
																						this.HangHoa,
																						this.HopDongBan,
																						this.HopDongMua,
																						this.CTHopDongBan,
																						this.CTHopDongMua,
																						this.PhieuThu,
																						this.PhieuChi,
																						this.LuuTruHDBan,
																						this.LuuTruHDMua,
																						this.Help,
																						this.tim,
																						this.Lienhe});
			this.toolBar1.ContextMenu = this.contextMenu1;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(608, 28);
			this.toolBar1.TabIndex = 3;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// LogOff
			// 
			this.LogOff.ImageIndex = 5;
			this.LogOff.ToolTipText = "Log Off";
			// 
			// KhachHang
			// 
			this.KhachHang.ImageIndex = 13;
			this.KhachHang.ToolTipText = "Khách hàng";
			// 
			// NhaCungUng
			// 
			this.NhaCungUng.ImageIndex = 19;
			this.NhaCungUng.ToolTipText = "Nhà cung ứng";
			// 
			// HangHoa
			// 
			this.HangHoa.ImageIndex = 16;
			this.HangHoa.ToolTipText = "Hàng hóa";
			// 
			// HopDongBan
			// 
			this.HopDongBan.ImageIndex = 7;
			this.HopDongBan.ToolTipText = "Hợp đồng bán";
			// 
			// HopDongMua
			// 
			this.HopDongMua.ImageIndex = 8;
			this.HopDongMua.ToolTipText = "Hợp đồng mua";
			// 
			// CTHopDongBan
			// 
			this.CTHopDongBan.ImageIndex = 22;
			this.CTHopDongBan.ToolTipText = "Chi tiết hợp đồng bán";
			// 
			// CTHopDongMua
			// 
			this.CTHopDongMua.ImageIndex = 21;
			this.CTHopDongMua.ToolTipText = "Chi tiết hợp đồng mua";
			// 
			// PhieuThu
			// 
			this.PhieuThu.ImageIndex = 18;
			this.PhieuThu.ToolTipText = "Phiếu thu";
			// 
			// PhieuChi
			// 
			this.PhieuChi.ImageIndex = 23;
			this.PhieuChi.ToolTipText = "Phiếu chi";
			// 
			// LuuTruHDBan
			// 
			this.LuuTruHDBan.ImageIndex = 3;
			this.LuuTruHDBan.ToolTipText = "Lưu trữ hợp đồng bán";
			// 
			// LuuTruHDMua
			// 
			this.LuuTruHDMua.ImageIndex = 1;
			this.LuuTruHDMua.ToolTipText = "Lưu trữ hợp đồng mua";
			// 
			// Help
			// 
			this.Help.ImageIndex = 4;
			this.Help.ToolTipText = "Help";
			// 
			// tim
			// 
			this.tim.ImageIndex = 6;
			this.tim.ToolTipText = "Tìm kiếm";
			// 
			// Lienhe
			// 
			this.Lienhe.ImageIndex = 14;
			this.Lienhe.ToolTipText = "Liên hệ với chúng tôi";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// menuItem39
			// 
			this.menuItem39.Index = 1;
			this.menuItem39.Text = "-";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(608, 160);
			this.ContextMenu = this.contextMenu1;
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(this.statusBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chuong Trinh Quan Ly Ban Hang";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Closed += new System.EventHandler(this.MainForm_Closed);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sttusQuyen)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Log_on());				
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
			DisplayIcon dplay = new DisplayIcon();
			dplay.DongIcon();
		}
		public void CopyMenu()
		{
			// Copy the View menu into ctxtMenuView
			foreach (MenuItem mi in menuItem3.MenuItems)
			{
				contextMenu1.MenuItems.Add
					(mi.Index, mi.CloneMenu());
			}
			foreach (MenuItem mi in menuItem12.MenuItems)
			{
				contextMenu1.MenuItems.Add
					(mi.Index, mi.CloneMenu());
			}
			foreach (MenuItem mi in menuItem8.MenuItems)
			{
				contextMenu1.MenuItems.Add
					(mi.Index, mi.CloneMenu());
			}
			foreach (MenuItem mi in menuItem10.MenuItems)
			{
				contextMenu1.MenuItems.Add
					(mi.Index, mi.CloneMenu());
			}
		}
		public void QuyenUser()
		{
			menuItem25.Enabled=false;
//			Thong_ke_Hang_Hoa hanghoa = new Thong_ke_Hang_Hoa();
//			hanghoa.Quyen_Khach_TrenBangHang();
		}
		public void QuyenKhach()
		{
			menuItem8.Enabled=false;
			menuItem12.Enabled=false;
			menuItem16.Enabled=false;
			menuItem17.Enabled=false;
			menuItem19.Enabled=false;
			menuItem25.Enabled=false;
			menuItem26.Enabled=false;
			menuItem27.Enabled=false;
			menuItem29.Enabled=false;
			menuItem7.Enabled=false;
			menuItem4.Enabled=false;
			toolBar1.Enabled=false;
			contextMenu1.Dispose();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			CopyMenu();
//			KiemTraQuyen();
			statusBar1.Panels[1].Text = DateTime.Now.ToLongDateString();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Thong_ke_K_Hang tkeKH = new Thong_ke_K_Hang();
			
			tkeKH.MdiParent = this;
			
			tkeKH.Show();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Tim_Kiem tkiem = new Tim_Kiem();
			tkiem.MdiParent = this;
			tkiem.Show();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			Nha_Cung_Ung tkeNhaCungUng = new Nha_Cung_Ung();
			tkeNhaCungUng.MdiParent = this;
			tkeNhaCungUng.Load_Data_TKeNhaCungUng();
			tkeNhaCungUng.MoPhim();
			tkeNhaCungUng.Show();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			Thong_ke_Hang_Hoa HangHoa = new Thong_ke_Hang_Hoa();
			HangHoa.MdiParent=this;
			HangHoa.Load_Data_TKeMatHang();
			
			HangHoa.Show();

		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			Phieu_Thu_Hop_Dong_Ban PhieuThu = new Phieu_Thu_Hop_Dong_Ban();
			PhieuThu.Load_Data_PhieuThu();
			PhieuThu.MoPhim();
			PhieuThu.MdiParent=this;
			PhieuThu.Show();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			Thong_Ke_Hop_Dong_Ban HopDongBan = new Thong_Ke_Hop_Dong_Ban();
			HopDongBan.Load_Data_TKeHopDongBan();
			HopDongBan.MoPhim();
			HopDongBan.MdiParent=this;
			HopDongBan.Show();
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			Chi_Tiet_Don_Hang CT_HDBan = new Chi_Tiet_Don_Hang();
			CT_HDBan.Load_Data_ChiTiet_HopDongBan();
			CT_HDBan.MoPhim();
			CT_HDBan.MdiParent=this;
			CT_HDBan.Show();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
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

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			frmAbout abo = new frmAbout();
//			abo.MdiParent=this;
			abo.ShowDialog();
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			Chi_Tiet_Hop_Dong_Cung_Ung CTHDCungUng = new Chi_Tiet_Hop_Dong_Cung_Ung();			
			CTHDCungUng.MdiParent=this;
			CTHDCungUng.Show();
			CTHDCungUng.Load_Data_ChiTiet_HopDongCungUng();
			CTHDCungUng.MoPhim();
			
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			Administrator admin = new Administrator();
			admin.ShowDialog();
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			Thong_Ke_Hop_Dong_Mua hopDongMua = new Thong_Ke_Hop_Dong_Mua();
			hopDongMua.MdiParent=this;
			hopDongMua.Show();
			hopDongMua.MoPhim();
			hopDongMua.Load_Data_TKeHopDongMua();
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			Phieu_Chi_Hop_Dong_Mua PhieuChi = new Phieu_Chi_Hop_Dong_Mua();
			PhieuChi.Load_Data_Phieu_Chi();
			PhieuChi.MoPhim();
			PhieuChi.MdiParent=this;
			PhieuChi.Show();
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			Log_on logon = new Log_on();
			logon.Show();
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			BaoCaoHangHoa bcHHoa = new BaoCaoHangHoa();
			bcHHoa.MdiParent=this;
			bcHHoa.Show();
		
		}

		private void menuItem32_Click(object sender, System.EventArgs e)
		{
			BaoCaoChiTietHopDong bcChiTHD = new BaoCaoChiTietHopDong();
			bcChiTHD.MdiParent=this;
			bcChiTHD.Show();
		}

		private void menuItem33_Click(object sender, System.EventArgs e)
		{
			BaoCaoPhieuThu bcPhieuthu = new BaoCaoPhieuThu();
			bcPhieuthu.MdiParent=this;
			bcPhieuthu.Show();
		}

		private void menuItem35_Click(object sender, System.EventArgs e)
		{
			BaoCaoChiTietHopDongMua bchdmua = new BaoCaoChiTietHopDongMua();
			bchdmua.MdiParent=this;
			bchdmua.Show();
		}

		private void menuItem36_Click(object sender, System.EventArgs e)
		{
			BaoCaoPhieuChi bcChi = new BaoCaoPhieuChi();
			bcChi.MdiParent=this;
			bcChi.Show();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(e.Button.ImageIndex)
			{
				case 5: 
					menuItem28_Click(sender,e);
					break;
				case 13:
					menuItem4_Click(sender,e);
					break;
				case 19:
					menuItem9_Click(sender,e);
					break;
				case 16:
					menuItem11_Click(sender,e);
					break;
				case 7:
					menuItem13_Click(sender,e);
					break;
				case 8:
					menuItem16_Click(sender,e);
					break;
				case 22:
					menuItem18_Click(sender,e);
					break;
				case 21:
					menuItem19_Click(sender,e);
					break;
				case 18:
					menuItem14_Click(sender,e);
					break;
				case 23:
					menuItem17_Click(sender,e);
					break;
				case 4:
					menuItem20_Click(sender,e);
					break;
				case 6:
					menuItem7_Click(sender,e);
					break;
				case 14:
					menuItem22_Click(sender,e);
					break;
				case 3:
					menuItem26_Click(sender,e);
					break;
				case 1:
					menuItem27_Click(sender,e);
					break;
			}
		}

		private void menuItem38_Click(object sender, System.EventArgs e)
		{
			Thong_Ke_Khach_Hang_Only khOnly = new Thong_Ke_Khach_Hang_Only();
			khOnly.MdiParent=this;
			khOnly.Show();
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			Luu_Tru_Hop_Dong_Ban LuHDB =new Luu_Tru_Hop_Dong_Ban();
			LuHDB.MdiParent=this;
			LuHDB.Show();
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
			Luu_Tru_Hop_Dong_Mua LuuHDM = new Luu_Tru_Hop_Dong_Mua();
			LuuHDM.MdiParent=this;
			LuuHDM.Show();
		}	
	}
}
