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
	/// Summary description for Thong_Ke_Hop_Dong_Ban.
	/// </summary>
	public class Thong_Ke_Hop_Dong_Ban : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNguoiNhap;
		private System.Windows.Forms.ComboBox cmbSoHDong;
		private System.Windows.Forms.ComboBox cmMaKHang;
		private System.Windows.Forms.DataGrid dataGrid_TkeHopDongBan;
		private System.Windows.Forms.DateTimePicker cmNgayHetHang;
		private System.Windows.Forms.DateTimePicker cmNgayThanhLy;
		private System.Windows.Forms.Button btThemHopDong;
		private System.Windows.Forms.DateTimePicker cmNgayKy;
		private System.Windows.Forms.TextBox txtKhachHang;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btXemNoiDung;
		private System.Windows.Forms.TextBox txtDiaChiHD;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Thong_Ke_Hop_Dong_Ban()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmNgayKy = new System.Windows.Forms.DateTimePicker();
			this.txtNguoiNhap = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btDau = new System.Windows.Forms.Button();
			this.cmbSoHDong = new System.Windows.Forms.ComboBox();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btThemHopDong = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.cmMaKHang = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmNgayHetHang = new System.Windows.Forms.DateTimePicker();
			this.cmNgayThanhLy = new System.Windows.Forms.DateTimePicker();
			this.txtKhachHang = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btXemNoiDung = new System.Windows.Forms.Button();
			this.txtDiaChiHD = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid_TkeHopDongBan = new System.Windows.Forms.DataGrid();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TkeHopDongBan)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmNgayKy);
			this.panel1.Controls.Add(this.txtNguoiNhap);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btDau);
			this.panel1.Controls.Add(this.cmbSoHDong);
			this.panel1.Controls.Add(this.btLui);
			this.panel1.Controls.Add(this.btToi);
			this.panel1.Controls.Add(this.btCuoi);
			this.panel1.Controls.Add(this.btThemHopDong);
			this.panel1.Controls.Add(this.btXoa);
			this.panel1.Controls.Add(this.btSua);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.btHuy);
			this.panel1.Controls.Add(this.cmMaKHang);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.cmNgayHetHang);
			this.panel1.Controls.Add(this.cmNgayThanhLy);
			this.panel1.Controls.Add(this.txtKhachHang);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.btXemNoiDung);
			this.panel1.Controls.Add(this.txtDiaChiHD);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(648, 168);
			this.panel1.TabIndex = 23;
			// 
			// cmNgayKy
			// 
			this.cmNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmNgayKy.Location = new System.Drawing.Point(464, 8);
			this.cmNgayKy.Name = "cmNgayKy";
			this.cmNgayKy.Size = new System.Drawing.Size(168, 20);
			this.cmNgayKy.TabIndex = 5;
			this.cmNgayKy.Value = new System.DateTime(2006, 6, 25, 17, 32, 7, 409);
			// 
			// txtNguoiNhap
			// 
			this.txtNguoiNhap.Location = new System.Drawing.Point(112, 72);
			this.txtNguoiNhap.Name = "txtNguoiNhap";
			this.txtNguoiNhap.Size = new System.Drawing.Size(168, 20);
			this.txtNguoiNhap.TabIndex = 4;
			this.txtNguoiNhap.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Người Nhập:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(376, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Ngày Ký:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Số Hợp Đồng";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã Khách Hàng";
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(96, 104);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 3;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// cmbSoHDong
			// 
			this.cmbSoHDong.Location = new System.Drawing.Point(112, 8);
			this.cmbSoHDong.Name = "cmbSoHDong";
			this.cmbSoHDong.Size = new System.Drawing.Size(168, 21);
			this.cmbSoHDong.TabIndex = 1;
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(144, 104);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 16;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(192, 104);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 15;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(240, 104);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 14;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btThemHopDong
			// 
			this.btThemHopDong.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btThemHopDong.Location = new System.Drawing.Point(288, 8);
			this.btThemHopDong.Name = "btThemHopDong";
			this.btThemHopDong.TabIndex = 8;
			this.btThemHopDong.Text = "&Thêm";
			this.btThemHopDong.Click += new System.EventHandler(this.btThemHopDong_Click);
			// 
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Location = new System.Drawing.Point(8, 136);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 9;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(96, 136);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 10;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(184, 136);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 11;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(272, 136);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 12;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// cmMaKHang
			// 
			this.cmMaKHang.Location = new System.Drawing.Point(192, 40);
			this.cmMaKHang.Name = "cmMaKHang";
			this.cmMaKHang.Size = new System.Drawing.Size(88, 21);
			this.cmMaKHang.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(376, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Ngày Thanh Lý:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(376, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Ngày Hết Hạng:";
			// 
			// cmNgayHetHang
			// 
			this.cmNgayHetHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmNgayHetHang.Location = new System.Drawing.Point(464, 40);
			this.cmNgayHetHang.Name = "cmNgayHetHang";
			this.cmNgayHetHang.Size = new System.Drawing.Size(168, 20);
			this.cmNgayHetHang.TabIndex = 6;
			// 
			// cmNgayThanhLy
			// 
			this.cmNgayThanhLy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmNgayThanhLy.Location = new System.Drawing.Point(464, 72);
			this.cmNgayThanhLy.Name = "cmNgayThanhLy";
			this.cmNgayThanhLy.Size = new System.Drawing.Size(168, 20);
			this.cmNgayThanhLy.TabIndex = 7;
			// 
			// txtKhachHang
			// 
			this.txtKhachHang.Location = new System.Drawing.Point(112, 40);
			this.txtKhachHang.Name = "txtKhachHang";
			this.txtKhachHang.Size = new System.Drawing.Size(72, 20);
			this.txtKhachHang.TabIndex = 3;
			this.txtKhachHang.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(360, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "Nội Dung:";
			// 
			// btXemNoiDung
			// 
			this.btXemNoiDung.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXemNoiDung.Location = new System.Drawing.Point(416, 136);
			this.btXemNoiDung.Name = "btXemNoiDung";
			this.btXemNoiDung.Size = new System.Drawing.Size(120, 23);
			this.btXemNoiDung.TabIndex = 12;
			this.btXemNoiDung.Text = "Nội Dung Hợp Đồng";
			this.btXemNoiDung.Click += new System.EventHandler(this.btXemNoiDung_Click);
			// 
			// txtDiaChiHD
			// 
			this.txtDiaChiHD.Location = new System.Drawing.Point(416, 104);
			this.txtDiaChiHD.Name = "txtDiaChiHD";
			this.txtDiaChiHD.Size = new System.Drawing.Size(216, 20);
			this.txtDiaChiHD.TabIndex = 4;
			this.txtDiaChiHD.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button1.Location = new System.Drawing.Point(560, 136);
			this.button1.Name = "button1";
			this.button1.TabIndex = 12;
			this.button1.Text = "&Browse";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 23);
			this.label1.TabIndex = 22;
			this.label1.Text = "Thống Kê Hợp Đồng Bán:";
			// 
			// dataGrid_TkeHopDongBan
			// 
			this.dataGrid_TkeHopDongBan.DataMember = "";
			this.dataGrid_TkeHopDongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGrid_TkeHopDongBan.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_TkeHopDongBan.Location = new System.Drawing.Point(0, 78);
			this.dataGrid_TkeHopDongBan.Name = "dataGrid_TkeHopDongBan";
			this.dataGrid_TkeHopDongBan.Size = new System.Drawing.Size(720, 248);
			this.dataGrid_TkeHopDongBan.TabIndex = 24;
			// 
			// Thong_Ke_Hop_Dong_Ban
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 326);
			this.Controls.Add(this.dataGrid_TkeHopDongBan);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Thong_Ke_Hop_Dong_Ban";
			this.Text = "Thong_Ke_Hop_Dong_Ban";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TkeHopDongBan)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtHopDongBan = new DataTable();
		DataTable dtKhachHang = new DataTable();
		public int n=0;
		public void Load_Data_TKeHopDongBan()
		{		
			string sqlHopDongBan="select * from HopDongBan";
			dtHopDongBan = ket_noi.getDataTable(sqlHopDongBan);
			string SqlKhachHang ="select MaKhachHang from KhachHang";
			dtKhachHang = ket_noi.getDataTable(SqlKhachHang);

			dataGrid_TkeHopDongBan.DataSource=dtHopDongBan;//Dịnh vào Combo Box để đựa ra Text Box

			cmbSoHDong.DataSource=dtHopDongBan;
			cmbSoHDong.DisplayMember="SoHopDongBan";
			cmbSoHDong.ValueMember="SoHopDongBan";

			cmMaKHang.DataSource=dtKhachHang;
			cmMaKHang.DisplayMember="MaKhachHang";
			cmMaKHang.ValueMember="MaKhachHang";

			txtNguoiNhap.DataBindings.Clear();
			txtNguoiNhap.DataBindings.Add("Text",dtHopDongBan,"NguoiNhap");

			txtKhachHang.DataBindings.Clear();
			txtKhachHang.DataBindings.Add("Text",dtHopDongBan,"MaKhachHang");

			txtDiaChiHD.DataBindings.Clear();
			txtDiaChiHD.DataBindings.Add("Text",dtHopDongBan,"NoiDungHD");

			cmNgayKy.DataBindings.Clear();
			cmNgayKy.DataBindings.Add("Text",dtHopDongBan,"NgayKy");

			cmNgayHetHang.DataBindings.Clear();
			cmNgayHetHang.DataBindings.Add("Text",dtHopDongBan,"NgayhetHang");

			cmNgayThanhLy.DataBindings.Clear();
			cmNgayThanhLy.DataBindings.Add("Text",dtHopDongBan,"NgayThanhLy");	
			
//			MoPhim();
		}
		public void MoPhim()
		{			
//			btDau.Enabled=true;
//			btLui.Enabled=true;
//			btToi.Enabled=true;
//			btCuoi.Enabled=true;
			btThemHopDong.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;			
			btLuu.Enabled=false;
			btHuy.Enabled=false;
			cmMaKHang.Enabled=false;
		}
		public void TatPhim()	
		{			
//			btDau.Enabled=false;
//			btLui.Enabled=false;
//			btToi.Enabled=false;
//			btCuoi.Enabled=false;
			btThemHopDong.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
		}
		public void Clear_FrHopDongBan()
		{
			
			txtNguoiNhap.Clear();
//			cmNgayHetHang.Text="";
//			cmNgayKy.Text="";
//			cmNgayThanhLy.Text="";
		}
		//Thêm Xóa Sửa
		public void Getinfor()
		{			
			ket_noi.HBSo = cmbSoHDong.Text;	
			ket_noi.HBMaKHang = cmMaKHang.Text;		
//			ket_noi.HBGia = txtTriGiaHDong.Text;
			ket_noi.HBNguoiNhap = txtNguoiNhap.Text;			
			ket_noi.HBNgayKy = cmNgayKy.Text;	
			ket_noi.HBNgayHetHang = cmNgayHetHang.Text;				
			ket_noi.HBNgayThanhLy = cmNgayThanhLy.Text;	
			ket_noi.HBNoiDung = txtDiaChiHD.Text;
			ket_noi.HBmaKH = txtKhachHang.Text;
		}
		private int Sqlcommand(int mode,string SHDB, string MaKH, string NgNhap, string NgayKy, string NgayHet, string NgayThanhL, string NoiDung)
		{
			int i=0;
			try
			{						
				SqlCommand sqlcmd = new SqlCommand("Stor_HopDongBan", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@SoHD",SqlDbType.NVarChar).Value= SHDB;
				sqlcmd.Parameters.Add("@MaKH",SqlDbType.NVarChar).Value=MaKH;
				sqlcmd.Parameters.Add("@NNhap",SqlDbType.NVarChar).Value=NgNhap;
				sqlcmd.Parameters.Add("@NgayKy",SqlDbType.NVarChar).Value=NgayKy;				
				sqlcmd.Parameters.Add("@NgayHet",SqlDbType.NVarChar).Value=NgayHet;	
				sqlcmd.Parameters.Add("@NgayThanhL",SqlDbType.NVarChar).Value=NgayThanhL;	
				sqlcmd.Parameters.Add("@noidung",SqlDbType.NVarChar).Value=NoiDung;
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}
		private void btThemHopDong_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			Clear_FrHopDongBan();
			txtKhachHang.Enabled=false;
			cmMaKHang.Enabled=true; 
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.HBSo,ket_noi.HBMaKHang,ket_noi.HBNguoiNhap, ket_noi.HBNgayKy, ket_noi.HBNgayHetHang, ket_noi.HBNgayThanhLy, ket_noi.HBNoiDung)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_TKeHopDongBan();
				}
			}
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
			cmbSoHDong.Enabled=false;
			cmMaKHang.Enabled=false;
			txtKhachHang.Enabled=false;
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			Getinfor();
			if(n==1)
			{
				if(KiemTra.kiemtraRong_ComBo(cmbSoHDong,"Mã hợp đồng "))
				{
					string str="select * from HopDongBan  where SoHopDongBan='"+cmbSoHDong.Text+"'" ;
					if(KiemTra.kiemtraRong(txtNguoiNhap,"Người nhập "))
					{						
						if(KiemTra.kiemtra_DaTonTai(cmbSoHDong,"Số hợp đồng ",str))
						{									
							if(Sqlcommand(1,ket_noi.HBSo,ket_noi.HBMaKHang,ket_noi.HBNguoiNhap, ket_noi.HBNgayKy, ket_noi.HBNgayHetHang, ket_noi.HBNgayThanhLy, ket_noi.HBNoiDung)!=0)
							{						
								MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}			
									
						}	
					}
				}
			}
			else
				if(n==2)
			{			
			
				if(KiemTra.kiemtraRong(txtNguoiNhap,"Người nhập "))
				{
					if(Sqlcommand(0,ket_noi.HBSo,ket_noi.HBMaKHang,ket_noi.HBNguoiNhap, ket_noi.HBNgayKy, ket_noi.HBNgayHetHang, ket_noi.HBNgayThanhLy, ket_noi.HBNoiDung)!=0)
					{
						MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{			
			Load_Data_TKeHopDongBan();
			MoPhim();
			cmbSoHDong.Enabled=true;
			cmMaKHang.Enabled=false;
			txtKhachHang.Enabled=true;
		}
		public void FirstRecord()
		{
			this.BindingContext[dtHopDongBan].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtHopDongBan].Position = dtHopDongBan.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtHopDongBan].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtHopDongBan].Position -= 1;			
		}

		private void btToi_Click(object sender, System.EventArgs e)
		{
			NextRecord();
		}

		private void btDau_Click(object sender, System.EventArgs e)
		{
			FirstRecord();
		}

		private void btLui_Click(object sender, System.EventArgs e)
		{
			PreviousRecord();
		}

		private void btCuoi_Click(object sender, System.EventArgs e)
		{
			LastRecord();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
//			openFileDialog1.InitialDirectory = "C:/";
			openFileDialog1.Filter = "All Files|*.*|Doc|*.doc";
			openFileDialog1.FilterIndex = 2;

			// When the user clicks the Open button (DialogResult.OK is the only option;
			// there is not DialogResult.Open), display the image centered in the 
			// PictureBox and display the full path of the image.

			if (openFileDialog1.ShowDialog() == DialogResult.OK )
			{				
				txtDiaChiHD.Text = openFileDialog1.FileName;
			}
		}

		private void btXemNoiDung_Click(object sender, System.EventArgs e)
		{
			if(KiemTra.kiemtraRong(txtDiaChiHD,"Địa chỉ hợp đồng"))
			{
				try
				{
					System.Diagnostics.Process a = new System.Diagnostics.Process();
					a.StartInfo.FileName=@""+txtDiaChiHD.Text+"";
					a.StartInfo.Verb="Open";
					//			a.StartInfo.Arguments=@" "+txtDiaChiHD.Text+" ";
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
