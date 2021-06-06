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
	/// Summary description for Thong_Ke_Hop_Dong_Mua.
	/// </summary>
	public class Thong_Ke_Hop_Dong_Mua : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker cmNgayKy;
		private System.Windows.Forms.TextBox txtNguoiNhap;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.ComboBox cmbSoHDong;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btThemHopDong;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker cmNgayHetHang;
		private System.Windows.Forms.DateTimePicker cmNgayThanhLy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid_HopDong_Mua;
		private System.Windows.Forms.ComboBox cmMaNhaCUng;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btXemNoiDung;
		private System.Windows.Forms.TextBox txtDiaChiHD;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txtMaNhaCungUng;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Thong_Ke_Hop_Dong_Mua()
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
			this.label8 = new System.Windows.Forms.Label();
			this.btXemNoiDung = new System.Windows.Forms.Button();
			this.txtDiaChiHD = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
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
			this.cmMaNhaCUng = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmNgayHetHang = new System.Windows.Forms.DateTimePicker();
			this.cmNgayThanhLy = new System.Windows.Forms.DateTimePicker();
			this.txtMaNhaCungUng = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid_HopDong_Mua = new System.Windows.Forms.DataGrid();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_HopDong_Mua)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.btXemNoiDung);
			this.panel1.Controls.Add(this.txtDiaChiHD);
			this.panel1.Controls.Add(this.button1);
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
			this.panel1.Controls.Add(this.cmMaNhaCUng);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.cmNgayHetHang);
			this.panel1.Controls.Add(this.cmNgayThanhLy);
			this.panel1.Controls.Add(this.txtMaNhaCungUng);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(640, 168);
			this.panel1.TabIndex = 25;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(360, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 26;
			this.label8.Text = "Nội Dung:";
			// 
			// btXemNoiDung
			// 
			this.btXemNoiDung.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXemNoiDung.Location = new System.Drawing.Point(416, 136);
			this.btXemNoiDung.Name = "btXemNoiDung";
			this.btXemNoiDung.Size = new System.Drawing.Size(120, 23);
			this.btXemNoiDung.TabIndex = 25;
			this.btXemNoiDung.Text = "Nội Dung Hợp Đồng";
			this.btXemNoiDung.Click += new System.EventHandler(this.btXemNoiDung_Click);
			// 
			// txtDiaChiHD
			// 
			this.txtDiaChiHD.Location = new System.Drawing.Point(416, 104);
			this.txtDiaChiHD.Name = "txtDiaChiHD";
			this.txtDiaChiHD.Size = new System.Drawing.Size(216, 20);
			this.txtDiaChiHD.TabIndex = 23;
			this.txtDiaChiHD.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button1.Location = new System.Drawing.Point(560, 136);
			this.button1.Name = "button1";
			this.button1.TabIndex = 24;
			this.button1.Text = "&Browse";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.label2.Text = "Mã Nhà Cung Ứng:";
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
			this.btXoa.Location = new System.Drawing.Point(16, 136);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 9;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(104, 136);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 10;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(192, 136);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 11;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(280, 136);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 12;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// cmMaNhaCUng
			// 
			this.cmMaNhaCUng.Location = new System.Drawing.Point(200, 40);
			this.cmMaNhaCUng.Name = "cmMaNhaCUng";
			this.cmMaNhaCUng.Size = new System.Drawing.Size(80, 21);
			this.cmMaNhaCUng.TabIndex = 2;
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
			// txtMaNhaCungUng
			// 
			this.txtMaNhaCungUng.Location = new System.Drawing.Point(112, 40);
			this.txtMaNhaCungUng.Name = "txtMaNhaCungUng";
			this.txtMaNhaCungUng.Size = new System.Drawing.Size(80, 20);
			this.txtMaNhaCungUng.TabIndex = 4;
			this.txtMaNhaCungUng.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 23);
			this.label1.TabIndex = 24;
			this.label1.Text = "Thống Kê Hợp Đồng Mua";
			// 
			// dataGrid_HopDong_Mua
			// 
			this.dataGrid_HopDong_Mua.DataMember = "";
			this.dataGrid_HopDong_Mua.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGrid_HopDong_Mua.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_HopDong_Mua.Location = new System.Drawing.Point(0, 78);
			this.dataGrid_HopDong_Mua.Name = "dataGrid_HopDong_Mua";
			this.dataGrid_HopDong_Mua.Size = new System.Drawing.Size(712, 256);
			this.dataGrid_HopDong_Mua.TabIndex = 26;
			// 
			// Thong_Ke_Hop_Dong_Mua
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(712, 334);
			this.Controls.Add(this.dataGrid_HopDong_Mua);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Thong_Ke_Hop_Dong_Mua";
			this.Text = "Thong_Ke_Hop_Dong_Mua";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_HopDong_Mua)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtHDCungUng = new DataTable();
		DataTable dtNhaCungUng = new DataTable();
		public int n=0;
		public void Load_Data_TKeHopDongMua()
		{
		
			string sqlHDCUng="select * from HopDongCungUng";
			dtHDCungUng = ket_noi.getDataTable(sqlHDCUng);
			string SqlNhaCUng ="select MaNhaCungUng from NhaCungUng";
			dtNhaCungUng = ket_noi.getDataTable(SqlNhaCUng);

			dataGrid_HopDong_Mua.DataSource=dtHDCungUng;//Dịnh vào Combo Box để đựa ra Text Box

			cmbSoHDong.DataSource=dtHDCungUng;
			cmbSoHDong.DisplayMember="SoHopDongCungUng";
			cmbSoHDong.ValueMember="SoHopDongCungUng";

			cmMaNhaCUng.DataSource=dtNhaCungUng;
			cmMaNhaCUng.DisplayMember="MaNhaCungUng";
			cmMaNhaCUng.ValueMember="MaNhaCungUng";

//			txtTriGiaHDongMua.DataBindings.Clear(); NoiDungHDM
//			txtTriGiaHDongMua.DataBindings.Add("Text",dtHDCungUng,"GiaTriHopDongMua");

			txtMaNhaCungUng.DataBindings.Clear();
			txtMaNhaCungUng.DataBindings.Add("Text",dtNhaCungUng,"MaNhaCungUng");

			txtNguoiNhap.DataBindings.Clear();
			txtNguoiNhap.DataBindings.Add("Text",dtHDCungUng,"NguoiNhap");

			txtDiaChiHD.DataBindings.Clear();
			txtDiaChiHD.DataBindings.Add("Text",dtHDCungUng,"NoiDungHDM");

			cmNgayKy.DataBindings.Clear();
			cmNgayKy.DataBindings.Add("Text",dtHDCungUng,"NgayKy");

			cmNgayHetHang.DataBindings.Clear();
			cmNgayHetHang.DataBindings.Add("Text",dtHDCungUng,"NgayhetHang");

			cmNgayThanhLy.DataBindings.Clear();
			cmNgayThanhLy.DataBindings.Add("Text",dtHDCungUng,"NgayThanhLy");
		}
		public void MoPhim()
		{			
			btDau.Enabled=true;
			btLui.Enabled=true;
			btToi.Enabled=true;
			btCuoi.Enabled=true;
			btThemHopDong.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;			
			btLuu.Enabled=false;
			btHuy.Enabled=false;
			cmMaNhaCUng.Enabled=false;
//			txtMaNhaCungUng.Enabled=false;
		}
		public void TatPhim()	
		{			
			btDau.Enabled=false;
			btLui.Enabled=false;
			btToi.Enabled=false;
			btCuoi.Enabled=false;
			btThemHopDong.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
			cmMaNhaCUng.Enabled=true;
			txtMaNhaCungUng.Enabled=false;
		}
		public void Clear_FrHopDongBan()
		{			
			txtNguoiNhap.Clear();
			txtDiaChiHD.Clear();
//			cmNgayHetHang.Text="";
//			cmNgayKy.Text="";
//			cmNgayThanhLy.Text="";
		}
		//Thêm Xóa Sửa
		public void Getinfor()
		{			
			ket_noi.HBSo = cmbSoHDong.Text;	
			ket_noi.HBMaKHang = cmMaNhaCUng.Text;		
//			ket_noi.HBGia = txtTriGiaHDongMua.Text;
			ket_noi.HBNguoiNhap = txtNguoiNhap.Text;			
			ket_noi.HBNgayKy = cmNgayKy.Text;	
			ket_noi.HBNgayHetHang = cmNgayHetHang.Text;				
			ket_noi.HBNgayThanhLy = cmNgayThanhLy.Text;				
			ket_noi.HBNoiDung = txtDiaChiHD.Text;		
		}
		private int Sqlcommand(int mode,string SHDB, string MaNhaCu, string NgNhap, string NgayKy, string NgayHet, string NgayThanhL, string NoiDung)
		{
			int i=0;
			try
			{						
				SqlCommand sqlcmd = new SqlCommand("Stor_HopDongMua", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@SoHD",SqlDbType.NVarChar).Value= SHDB;
				sqlcmd.Parameters.Add("@MaNhaCU",SqlDbType.NVarChar).Value=MaNhaCu;
//				sqlcmd.Parameters.Add("@Tien",SqlDbType.NVarChar).Value=STien;
				sqlcmd.Parameters.Add("@NNhap",SqlDbType.NVarChar).Value=NgNhap;
				sqlcmd.Parameters.Add("@NgayKy",SqlDbType.NVarChar).Value=NgayKy;				
				sqlcmd.Parameters.Add("@NgayHet",SqlDbType.NVarChar).Value=NgayHet;	
				sqlcmd.Parameters.Add("@NgayThanhL",SqlDbType.NVarChar).Value=NgayThanhL;	
				sqlcmd.Parameters.Add("@NDHDM",SqlDbType.NVarChar).Value=NoiDung;	
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
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			cmbSoHDong.Enabled=true;
//			cmMaNhaCUng.Enabled=false;
			txtMaNhaCungUng.Enabled=true;
			Load_Data_TKeHopDongMua();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.HBSo,ket_noi.HBMaKHang, ket_noi.HBNguoiNhap, ket_noi.HBNgayKy, ket_noi.HBNgayHetHang, ket_noi.HBNgayThanhLy,ket_noi.HBNoiDung)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_TKeHopDongMua();
				}
			}
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
			cmbSoHDong.Enabled=false;
			cmMaNhaCUng.Enabled=false;
			txtMaNhaCungUng.Enabled=false;
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			Getinfor();
			if(KiemTra.kiemtraRong_ComBo(cmbSoHDong,"Mã Nhóm"))
			{
				string str="select * from HopDongCungUng  where SoHopDongCungUng='"+cmbSoHDong.Text+"'" ;
			
						if(KiemTra.kiemtraRong(txtNguoiNhap,"Người nhập "))
						{
							if(KiemTra.kiemtra_DaTonTai(cmbSoHDong,"Số hợp đồng ",str))
							{							
								if(n==1)
								{
									if(Sqlcommand(1,ket_noi.HBSo,ket_noi.HBMaKHang,ket_noi.HBNguoiNhap, ket_noi.HBNgayKy, ket_noi.HBNgayHetHang, ket_noi.HBNgayThanhLy,ket_noi.HBNoiDung)!=0)
									{						
										MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}			
								}
								else
									if(n==2)
								{				
									if(Sqlcommand(0,ket_noi.HBSo,ket_noi.HBMaKHang,ket_noi.HBNguoiNhap, ket_noi.HBNgayKy, ket_noi.HBNgayHetHang, ket_noi.HBNgayThanhLy,ket_noi.HBNoiDung)!=0)
									{
										MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
							}
							
				}
			}
			
//			Load_Data_TKeHopDongMua();
		}
		public void FirstRecord()
		{
			this.BindingContext[dtHDCungUng].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtHDCungUng].Position = dtHDCungUng.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtHDCungUng].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtHDCungUng].Position -= 1;			
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
