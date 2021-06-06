using System;
using System.IO;
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
	public class Thong_ke_Hang_Hoa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGrid dtGrid_HangHoa;
		private System.Windows.Forms.ComboBox cmMaHang;
		private System.Windows.Forms.TextBox txtTenHang;
		private System.Windows.Forms.TextBox txtTinhNang;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.ComboBox cmMaLoaiHang;
		private System.Windows.Forms.TextBox txtTonToiThieu;
		private System.Windows.Forms.Button btThemMaHang;
		private System.Windows.Forms.Button btXemGia;
		private System.Windows.Forms.TextBox txtMaLoaiHang;
		private System.Windows.Forms.TextBox txtTonThuc;
		private System.Windows.Forms.DataGrid dataGridTonThuc;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Thong_ke_Hang_Hoa()
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
			this.dtGrid_HangHoa = new System.Windows.Forms.DataGrid();
			this.cmMaHang = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.btDau = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.txtTenHang = new System.Windows.Forms.TextBox();
			this.btThemMaHang = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTinhNang = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.cmMaLoaiHang = new System.Windows.Forms.ComboBox();
			this.txtTonToiThieu = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btXemGia = new System.Windows.Forms.Button();
			this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
			this.txtTonThuc = new System.Windows.Forms.TextBox();
			this.dataGridTonThuc = new System.Windows.Forms.DataGrid();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtGrid_HangHoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTonThuc)).BeginInit();
			this.SuspendLayout();
			// 
			// dtGrid_HangHoa
			// 
			this.dtGrid_HangHoa.DataMember = "";
			this.dtGrid_HangHoa.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtGrid_HangHoa.Location = new System.Drawing.Point(0, 232);
			this.dtGrid_HangHoa.Name = "dtGrid_HangHoa";
			this.dtGrid_HangHoa.Size = new System.Drawing.Size(600, 232);
			this.dtGrid_HangHoa.TabIndex = 78;
			// 
			// cmMaHang
			// 
			this.cmMaHang.ItemHeight = 13;
			this.cmMaHang.Location = new System.Drawing.Point(88, 80);
			this.cmMaHang.Name = "cmMaHang";
			this.cmMaHang.Size = new System.Drawing.Size(160, 21);
			this.cmMaHang.TabIndex = 2;
			this.cmMaHang.Click += new System.EventHandler(this.cmMaHang_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 68;
			this.label3.Text = "Tên Hàng:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 32);
			this.label2.TabIndex = 66;
			this.label2.Text = "Hàng Hóa";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 63;
			this.label1.Text = "Mã Lọai Hàng:";
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(152, 168);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 62;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(200, 168);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 61;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(248, 168);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 60;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Location = new System.Drawing.Point(24, 200);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 12;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(112, 200);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 13;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(200, 200);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 14;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(288, 200);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 15;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(104, 168);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 53;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 67;
			this.label5.Text = "Mã Hàng:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button2.Location = new System.Drawing.Point(256, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "&Thêm";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtTenHang
			// 
			this.txtTenHang.Location = new System.Drawing.Point(88, 108);
			this.txtTenHang.Name = "txtTenHang";
			this.txtTenHang.Size = new System.Drawing.Size(160, 20);
			this.txtTenHang.TabIndex = 3;
			this.txtTenHang.Text = "";
			// 
			// btThemMaHang
			// 
			this.btThemMaHang.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btThemMaHang.Location = new System.Drawing.Point(256, 80);
			this.btThemMaHang.Name = "btThemMaHang";
			this.btThemMaHang.Size = new System.Drawing.Size(72, 23);
			this.btThemMaHang.TabIndex = 10;
			this.btThemMaHang.Text = "&Thêm";
			this.btThemMaHang.Click += new System.EventHandler(this.btThemMaHang_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(376, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 85;
			this.label7.Text = "Tính Năng:";
			// 
			// txtTinhNang
			// 
			this.txtTinhNang.Location = new System.Drawing.Point(376, 40);
			this.txtTinhNang.Multiline = true;
			this.txtTinhNang.Name = "txtTinhNang";
			this.txtTinhNang.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTinhNang.Size = new System.Drawing.Size(408, 152);
			this.txtTinhNang.TabIndex = 8;
			this.txtTinhNang.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 72;
			this.label4.Text = "Số Lượng Tồn:";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(88, 136);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(104, 20);
			this.txtSoLuong.TabIndex = 4;
			this.txtSoLuong.Text = "";
			// 
			// cmMaLoaiHang
			// 
			this.cmMaLoaiHang.ItemHeight = 13;
			this.cmMaLoaiHang.Location = new System.Drawing.Point(168, 48);
			this.cmMaLoaiHang.Name = "cmMaLoaiHang";
			this.cmMaLoaiHang.Size = new System.Drawing.Size(80, 21);
			this.cmMaLoaiHang.TabIndex = 1;
			// 
			// txtTonToiThieu
			// 
			this.txtTonToiThieu.Location = new System.Drawing.Point(320, 136);
			this.txtTonToiThieu.Name = "txtTonToiThieu";
			this.txtTonToiThieu.Size = new System.Drawing.Size(48, 20);
			this.txtTonToiThieu.TabIndex = 5;
			this.txtTonToiThieu.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(208, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 23);
			this.label6.TabIndex = 72;
			this.label6.Text = "Lượng Tồn Tối Thiểu:";
			// 
			// btXemGia
			// 
			this.btXemGia.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXemGia.Location = new System.Drawing.Point(376, 200);
			this.btXemGia.Name = "btXemGia";
			this.btXemGia.Size = new System.Drawing.Size(112, 23);
			this.btXemGia.TabIndex = 11;
			this.btXemGia.Text = "&Xem Giá Hàng";
			this.btXemGia.Click += new System.EventHandler(this.btXemGia_Click);
			// 
			// txtMaLoaiHang
			// 
			this.txtMaLoaiHang.Location = new System.Drawing.Point(88, 48);
			this.txtMaLoaiHang.Name = "txtMaLoaiHang";
			this.txtMaLoaiHang.Size = new System.Drawing.Size(72, 20);
			this.txtMaLoaiHang.TabIndex = 1;
			this.txtMaLoaiHang.Text = "";
			// 
			// txtTonThuc
			// 
			this.txtTonThuc.Location = new System.Drawing.Point(88, 136);
			this.txtTonThuc.Name = "txtTonThuc";
			this.txtTonThuc.Size = new System.Drawing.Size(104, 20);
			this.txtTonThuc.TabIndex = 4;
			this.txtTonThuc.Text = "";
			// 
			// dataGridTonThuc
			// 
			this.dataGridTonThuc.DataMember = "";
			this.dataGridTonThuc.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTonThuc.Location = new System.Drawing.Point(600, 232);
			this.dataGridTonThuc.Name = "dataGridTonThuc";
			this.dataGridTonThuc.Size = new System.Drawing.Size(192, 232);
			this.dataGridTonThuc.TabIndex = 87;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button1.Location = new System.Drawing.Point(504, 200);
			this.button1.Name = "button1";
			this.button1.TabIndex = 15;
			this.button1.Text = "Xem &Hình";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Thong_ke_Hang_Hoa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 310);
			this.Controls.Add(this.txtTonThuc);
			this.Controls.Add(this.txtTinhNang);
			this.Controls.Add(this.txtTenHang);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtTonToiThieu);
			this.Controls.Add(this.txtMaLoaiHang);
			this.Controls.Add(this.dataGridTonThuc);
			this.Controls.Add(this.btXemGia);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btThemMaHang);
			this.Controls.Add(this.dtGrid_HangHoa);
			this.Controls.Add(this.cmMaHang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btLui);
			this.Controls.Add(this.btToi);
			this.Controls.Add(this.btCuoi);
			this.Controls.Add(this.btXoa);
			this.Controls.Add(this.btSua);
			this.Controls.Add(this.btLuu);
			this.Controls.Add(this.btHuy);
			this.Controls.Add(this.btDau);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmMaLoaiHang);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Name = "Thong_ke_Hang_Hoa";
			this.Text = "Thong_Ke_Hang_Hoa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Thong_ke_Hang_Hoa_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtGrid_HangHoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTonThuc)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Loai_Hang_Hoa loaiHang = new Loai_Hang_Hoa();
//			loaiHang.MdiParent = this;
			loaiHang.Load_Data_Loai_Hang();
			loaiHang.TatPhim();
			loaiHang.ShowDialog();					
		}
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtMatHang = new DataTable();
		DataTable dtMaLoaiHang = new DataTable();
		DataTable dtGiaBan = new DataTable();
		DataTable dtTonHienTai = new DataTable();
		public int n=0;

//		public void Quyen_Khach_TrenBangHang()
//		{
//			btXemGia.Enabled=false;
//		}
//		public void Load_GiaBan()
//		{
//			string SqlGiaBan="select Sum((GiaMua+5)+((GiaMua+5)*Thue)/100) as GiaThue from GiaHang Group by MaHang, NgayCapNhat";
//			dtGiaBan = ket_noi.getDataTable(SqlGiaBan);
//			txtGiaBan.DataBindings.Clear();
//			txtGiaBan.DataBindings.Add("Text",dtGiaBan,"GiaThue");
//		}

		public void Load_Data_TKeMatHang()
		{		//
			try
			{
			string sqlMatHang="select * from HangHoa";
			dtMatHang = ket_noi.getDataTable(sqlMatHang);
			string SqlMaHang = "select MaLoaiHang from LoaiHang";
			dtMaLoaiHang = ket_noi.getDataTable(SqlMaHang);

				string SqlTonHienTai="select MaHang, Min(SoLuongTon)As TonHienTai from C_T_H_Dong_Ban Group by MaHang";
				dtTonHienTai = ket_noi.getDataTable(SqlTonHienTai);
				dataGridTonThuc.DataSource=dtTonHienTai;

				txtTonThuc.DataBindings.Clear();
				txtTonThuc.DataBindings.Add("Text",dtTonHienTai,"TonHienTai");


			dtGrid_HangHoa.DataSource=dtMatHang;//Dịnh vào Combo Box để đựa ra Text Box

			cmMaHang.DataSource=dtMatHang;
			cmMaHang.DisplayMember="MaHang";
			cmMaHang.ValueMember="MaHang";

			cmMaLoaiHang.DataSource=dtMaLoaiHang;
			cmMaLoaiHang.DisplayMember="MaLoaiHang";
			cmMaLoaiHang.ValueMember="MaLoaiHang";

				txtMaLoaiHang.DataBindings.Clear();
				txtMaLoaiHang.DataBindings.Add("Text",dtMatHang,"MaLoai");

			txtTenHang.DataBindings.Clear();
			txtTenHang.DataBindings.Add("Text",dtMatHang,"TenHang");

//			txtGiaBan.DataBindings.Clear();
//			txtGiaBan.DataBindings.Add("Text",dtMatHang,"GiaBan");

			txtSoLuong.DataBindings.Clear();
			txtSoLuong.DataBindings.Add("Text",dtMatHang,"SoLuong");

			txtTonToiThieu.DataBindings.Clear();
			txtTonToiThieu.DataBindings.Add("Text",dtMatHang,"Ton");

			txtTinhNang.DataBindings.Clear();
			txtTinhNang.DataBindings.Add("Text",dtMatHang,"MoTaHang");	
		}
		catch(Exception e)
	{MessageBox.Show(e.ToString());}
//			Load_GiaBan();
		}
		public void MoPhim()
		{
			button2.Enabled=true;

			txtMaLoaiHang.Enabled=true;
			cmMaLoaiHang.Enabled=false;
			cmMaHang.Enabled=true;

			btThemMaHang.Enabled=true;
			btXemGia.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;			
			btLuu.Enabled=false;
			btHuy.Enabled=false;
			
			txtTonToiThieu.ReadOnly=true;
			txtTonThuc.BringToFront();
		}
		public void TatPhim()	
		{
			button2.Enabled=false;

			txtMaLoaiHang.Enabled=false;
			cmMaLoaiHang.Enabled=true;
			cmMaHang.Enabled=true;

			btThemMaHang.Enabled=false;
			btXemGia.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
			
			txtTonToiThieu.ReadOnly=false;
			txtTonThuc.SendToBack();
		}
		public void Clear_FrHang()
		{
			txtTenHang.Clear();			
			txtSoLuong.Clear();
			txtTinhNang.Clear();
			txtTonToiThieu.Clear();	
//			txtGiaBan.Clear();
		}

		private void btThemMaHang_Click(object sender, System.EventArgs e)
		{
			n=1;
			Load_Data_TKeMatHang();
			TatPhim();
			cmMaHang.Enabled=true;
			Clear_FrHang();
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();	
			cmMaHang.Enabled=false;
			cmMaLoaiHang.Enabled=false;
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			Load_Data_TKeMatHang();
//			cmMaHang.Enabled=true;
//			cmMaLoaiHang.Enabled=true;
		}
		public void Getinfor()
		{	
			ket_noi.MaHH = cmMaHang.Text;
			ket_noi.LoaiHH = cmMaLoaiHang.Text;				
			ket_noi.TenHangHH= txtTenHang.Text;			
			ket_noi.SoLuongHH = txtSoLuong.Text;	
			ket_noi.TonHH = txtTonToiThieu.Text;	
			ket_noi.MoTaHH = txtTinhNang.Text;				
		}
		private int Sqlcommand(int mode,string maHH, string maNhomHH, string HoTen, string GiaBan, string SoLuong, string Ton, string Ghichu, string hinh, string TenHinh)
		{
			int i=0;
			try
			{
				SqlCommand sqlcmd = new SqlCommand("Stor_MatHang", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@MaHang",SqlDbType.NVarChar).Value= maHH;
				sqlcmd.Parameters.Add("@MaLoai",SqlDbType.NVarChar).Value=maNhomHH;
				sqlcmd.Parameters.Add("@Ten",SqlDbType.NVarChar).Value=HoTen;
//				sqlcmd.Parameters.Add("@Gia",SqlDbType.NVarChar).Value=Gia;
//				sqlcmd.Parameters.Add("@GiaBan",SqlDbType.NVarChar).Value=GiaBan;
				sqlcmd.Parameters.Add("@Soluong",SqlDbType.NVarChar).Value=SoLuong;
				sqlcmd.Parameters.Add("@Tkho",SqlDbType.NVarChar).Value=Ton;
				sqlcmd.Parameters.Add("@MoTa",SqlDbType.NVarChar).Value=Ghichu;
//				sqlcmd.Parameters.Add("@hinh",SqlDbType.NVarChar).Value=hinh;
//				sqlcmd.Parameters.Add("@TenHinh",SqlDbType.NVarChar).Value=TenHinh;
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			Getinfor();
			if(n==1)
			{
				if(KiemTra.kiemtraRong_ComBo(cmMaHang,"Mã Hàng"))
				{
					string str="select * from HangHoa  where MaLoai='"+cmMaHang.Text+"'" ;
					if(KiemTra.kiemtraRong(txtTenHang,"Tên Hàng "))
					{
						if(KiemTra.kiemtraRong(txtSoLuong,"Số lượng "))
						{
							if(KiemTra.kiemtraRong(txtTonToiThieu,"Số lượng tồn tối thiểu "))
							{															
									if(KiemTra.kiemtra_DaTonTai(cmMaHang,"Mã Hàng ",str))
									{
										if(KiemTra.kiemtraSo(txtSoLuong,"Số lượng "))
										{
											if(KiemTra.kiemtraSo(txtTonToiThieu,"Số lượng tồn tối thiểu "))
											{												
//												if(KiemTra.kiemtraSo(txtGiaBan,"Giá bán "))
//												{
																			
													if(Sqlcommand(1,ket_noi.MaHH,ket_noi.LoaiHH,ket_noi.TenHangHH,ket_noi.GiaBanHH, ket_noi.SoLuongHH, ket_noi.TonHH, ket_noi.MoTaHH, ket_noi.HinhHH, ket_noi.TenHinhHH)!=0)
													{						
														MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
													}			
														
//												}							
											}
									}
								}
							}
						}		
					}
				}
			}
			else
				if(n==2)
			{		
				if(KiemTra.kiemtraSo(txtSoLuong,"Số lượng "))
				{
					if(KiemTra.kiemtraSo(txtTonToiThieu,"Số lượng tồn tối thiểu "))
					{												
//						if(KiemTra.kiemtraSo(txtGiaBan,"Giá bán "))
//						{
							if(Sqlcommand(0,ket_noi.MaHH,ket_noi.LoaiHH,ket_noi.TenHangHH,ket_noi.GiaBanHH, ket_noi.SoLuongHH, ket_noi.TonHH, ket_noi.MoTaHH, ket_noi.HinhHH, ket_noi.TenHinhHH)!=0)
							{
								MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
//						}
					}
				}
			}
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.MaHH,ket_noi.LoaiHH,ket_noi.TenHangHH,ket_noi.GiaBanHH, ket_noi.SoLuongHH, ket_noi.TonHH, ket_noi.MoTaHH, ket_noi.HinhHH, ket_noi.TenHinhHH)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_TKeMatHang();
				}
			}
		}

		public void FirstRecord()
		{
			this.BindingContext[dtMatHang].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtMatHang].Position = dtMatHang.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtMatHang].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtMatHang].Position -= 1;			
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

		private void btXemGia_Click(object sender, System.EventArgs e)
		{
			Form_Gia Gia = new Form_Gia();
			Gia.Load_Data_GiaHang();
			Gia.MoPhim();
			Gia.ShowDialog();
		}
/// <summary>
/// /////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>


		private void cmMaHang_Click(object sender, System.EventArgs e)
		{
			
		}
		//Load Hình
		private DataSet ds = new DataSet("QuanLyMuaBan");


		

		private void Thong_ke_Hang_Hoa_Load(object sender, System.EventArgs e)
		{
			cmMaLoaiHang.Enabled=false;
			MoPhim();
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			HinhAnh ha = new HinhAnh();			
			ha.ShowDialog();
		}
	}
}
