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
	/// Summary description for Phieu_Chi_Hop_Dong_Ban.
	/// </summary>
	public class Phieu_Chi_Hop_Dong_Mua : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DateTimePicker cmTime_NgayNop;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNguoiNop;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTienCon;
		private System.Windows.Forms.DataGrid dataGrid_PhieuChi;
		private System.Windows.Forms.ComboBox cmbSoHDMua;
		private System.Windows.Forms.ComboBox cmSoPhieuChi;
		private System.Windows.Forms.Button btThemPhieuChi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTienTongLanChi;
		private System.Windows.Forms.TextBox txtTienHopDong;
		private System.Windows.Forms.TextBox txtTienNop;
		private System.Windows.Forms.DataGrid dataGrid_TienDaNop;
		private System.Windows.Forms.TextBox txtSoHopDongMua;
		private System.Windows.Forms.ComboBox cmHDongTienDaNop;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Phieu_Chi_Hop_Dong_Mua()
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
			this.cmTime_NgayNop = new System.Windows.Forms.DateTimePicker();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.btDau = new System.Windows.Forms.Button();
			this.btThemPhieuChi = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSoHDMua = new System.Windows.Forms.ComboBox();
			this.cmSoPhieuChi = new System.Windows.Forms.ComboBox();
			this.txtTienNop = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNguoiNop = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTienCon = new System.Windows.Forms.TextBox();
			this.dataGrid_PhieuChi = new System.Windows.Forms.DataGrid();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTienTongLanChi = new System.Windows.Forms.TextBox();
			this.txtTienHopDong = new System.Windows.Forms.TextBox();
			this.dataGrid_TienDaNop = new System.Windows.Forms.DataGrid();
			this.txtSoHopDongMua = new System.Windows.Forms.TextBox();
			this.cmHDongTienDaNop = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_PhieuChi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TienDaNop)).BeginInit();
			this.SuspendLayout();
			// 
			// cmTime_NgayNop
			// 
			this.cmTime_NgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmTime_NgayNop.Location = new System.Drawing.Point(480, 48);
			this.cmTime_NgayNop.Name = "cmTime_NgayNop";
			this.cmTime_NgayNop.Size = new System.Drawing.Size(168, 20);
			this.cmTime_NgayNop.TabIndex = 4;
			// 
			// btLui
			// 
			this.btLui.Location = new System.Drawing.Point(112, 176);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 92;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.Location = new System.Drawing.Point(160, 176);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 91;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.Location = new System.Drawing.Point(208, 176);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 90;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btXoa
			// 
			this.btXoa.Location = new System.Drawing.Point(312, 176);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 7;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.Location = new System.Drawing.Point(400, 176);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 8;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.Location = new System.Drawing.Point(488, 176);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 10;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.Location = new System.Drawing.Point(576, 176);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 11;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// btDau
			// 
			this.btDau.Location = new System.Drawing.Point(64, 176);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 85;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// btThemPhieuChi
			// 
			this.btThemPhieuChi.Location = new System.Drawing.Point(288, 80);
			this.btThemPhieuChi.Name = "btThemPhieuChi";
			this.btThemPhieuChi.TabIndex = 6;
			this.btThemPhieuChi.Text = "&Thêm";
			this.btThemPhieuChi.Click += new System.EventHandler(this.btThemPhieuChi_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 75;
			this.label3.Text = "Số Phiếu Chi:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 73;
			this.label2.Text = "Số Hợp Đồng Mua:";
			// 
			// cmbSoHDMua
			// 
			this.cmbSoHDMua.Location = new System.Drawing.Point(192, 48);
			this.cmbSoHDMua.Name = "cmbSoHDMua";
			this.cmbSoHDMua.Size = new System.Drawing.Size(88, 21);
			this.cmbSoHDMua.TabIndex = 1;
			// 
			// cmSoPhieuChi
			// 
			this.cmSoPhieuChi.Location = new System.Drawing.Point(112, 80);
			this.cmSoPhieuChi.Name = "cmSoPhieuChi";
			this.cmSoPhieuChi.Size = new System.Drawing.Size(168, 21);
			this.cmSoPhieuChi.TabIndex = 2;
			// 
			// txtTienNop
			// 
			this.txtTienNop.Location = new System.Drawing.Point(112, 112);
			this.txtTienNop.Name = "txtTienNop";
			this.txtTienNop.Size = new System.Drawing.Size(168, 20);
			this.txtTienNop.TabIndex = 3;
			this.txtTienNop.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 23);
			this.label9.TabIndex = 76;
			this.label9.Text = "Số Tiền Nộp:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 32);
			this.label1.TabIndex = 74;
			this.label1.Text = "Phiếu Chi Của Hợp Đồng Mua";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(376, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 77;
			this.label4.Text = "Ngày Trả:";
			// 
			// txtNguoiNop
			// 
			this.txtNguoiNop.Location = new System.Drawing.Point(480, 80);
			this.txtNguoiNop.Name = "txtNguoiNop";
			this.txtNguoiNop.Size = new System.Drawing.Size(168, 20);
			this.txtNguoiNop.TabIndex = 5;
			this.txtNguoiNop.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(376, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 23);
			this.label5.TabIndex = 79;
			this.label5.Text = "Người Người Chi:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(376, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 78;
			this.label6.Text = "Tiền Còn Lại:";
			// 
			// txtTienCon
			// 
			this.txtTienCon.Location = new System.Drawing.Point(480, 144);
			this.txtTienCon.Name = "txtTienCon";
			this.txtTienCon.ReadOnly = true;
			this.txtTienCon.Size = new System.Drawing.Size(168, 20);
			this.txtTienCon.TabIndex = 52;
			this.txtTienCon.Text = "";
			// 
			// dataGrid_PhieuChi
			// 
			this.dataGrid_PhieuChi.CaptionText = "Thống Kê Hợp Đồng Mua";
			this.dataGrid_PhieuChi.DataMember = "";
			this.dataGrid_PhieuChi.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_PhieuChi.Location = new System.Drawing.Point(0, 208);
			this.dataGrid_PhieuChi.Name = "dataGrid_PhieuChi";
			this.dataGrid_PhieuChi.Size = new System.Drawing.Size(528, 256);
			this.dataGrid_PhieuChi.TabIndex = 93;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 23);
			this.label7.TabIndex = 76;
			this.label7.Text = "Trị Giá Hợp Đồng";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(376, 112);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 76;
			this.label8.Text = "Số Tiền Đã Nộp:";
			// 
			// txtTienTongLanChi
			// 
			this.txtTienTongLanChi.Location = new System.Drawing.Point(480, 112);
			this.txtTienTongLanChi.Name = "txtTienTongLanChi";
			this.txtTienTongLanChi.Size = new System.Drawing.Size(80, 20);
			this.txtTienTongLanChi.TabIndex = 51;
			this.txtTienTongLanChi.Text = "";
			// 
			// txtTienHopDong
			// 
			this.txtTienHopDong.Location = new System.Drawing.Point(112, 144);
			this.txtTienHopDong.Name = "txtTienHopDong";
			this.txtTienHopDong.ReadOnly = true;
			this.txtTienHopDong.Size = new System.Drawing.Size(168, 20);
			this.txtTienHopDong.TabIndex = 94;
			this.txtTienHopDong.Text = "";
			// 
			// dataGrid_TienDaNop
			// 
			this.dataGrid_TienDaNop.CaptionText = "Tiền Đã Nộp Của Hợp Đồng Mua";
			this.dataGrid_TienDaNop.DataMember = "";
			this.dataGrid_TienDaNop.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_TienDaNop.Location = new System.Drawing.Point(528, 208);
			this.dataGrid_TienDaNop.Name = "dataGrid_TienDaNop";
			this.dataGrid_TienDaNop.Size = new System.Drawing.Size(232, 256);
			this.dataGrid_TienDaNop.TabIndex = 95;
			// 
			// txtSoHopDongMua
			// 
			this.txtSoHopDongMua.Location = new System.Drawing.Point(112, 48);
			this.txtSoHopDongMua.Name = "txtSoHopDongMua";
			this.txtSoHopDongMua.ReadOnly = true;
			this.txtSoHopDongMua.Size = new System.Drawing.Size(72, 20);
			this.txtSoHopDongMua.TabIndex = 3;
			this.txtSoHopDongMua.Text = "";
			// 
			// cmHDongTienDaNop
			// 
			this.cmHDongTienDaNop.Location = new System.Drawing.Point(568, 112);
			this.cmHDongTienDaNop.Name = "cmHDongTienDaNop";
			this.cmHDongTienDaNop.Size = new System.Drawing.Size(80, 21);
			this.cmHDongTienDaNop.TabIndex = 1;
			// 
			// Phieu_Chi_Hop_Dong_Mua
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 334);
			this.Controls.Add(this.dataGrid_TienDaNop);
			this.Controls.Add(this.txtTienHopDong);
			this.Controls.Add(this.txtTienNop);
			this.Controls.Add(this.txtNguoiNop);
			this.Controls.Add(this.txtTienCon);
			this.Controls.Add(this.txtTienTongLanChi);
			this.Controls.Add(this.dataGrid_PhieuChi);
			this.Controls.Add(this.cmTime_NgayNop);
			this.Controls.Add(this.btLui);
			this.Controls.Add(this.btToi);
			this.Controls.Add(this.btCuoi);
			this.Controls.Add(this.btXoa);
			this.Controls.Add(this.btSua);
			this.Controls.Add(this.btLuu);
			this.Controls.Add(this.btHuy);
			this.Controls.Add(this.btDau);
			this.Controls.Add(this.btThemPhieuChi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbSoHDMua);
			this.Controls.Add(this.cmSoPhieuChi);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtSoHopDongMua);
			this.Controls.Add(this.cmHDongTienDaNop);
			this.Name = "Phieu_Chi_Hop_Dong_Mua";
			this.Text = "Phieu_Chi_Hop_Dong_Mua";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Phieu_Chi_Hop_Dong_Mua_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_PhieuChi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_TienDaNop)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtPhieuChi = new DataTable();
//		DataTable dtHDongMua = new DataTable();
//		DataTable dtTienCon = new DataTable();
//		DataTable dtTongTien = new DataTable();
		DataTable dtTienDaNop = new DataTable();
		DataTable dtTriGiaHopDong = new DataTable();

		public int n=0;
		
		public void Load_TriGiaHopDong()
		{
			Getinfor();
			string SqlGiaTriHopDong="select SoHopDongCungUng, sum(TongCong)as TriGiaHopDong from CT_HD_CungUng group by SoHopDongCungUng";// where SoHopDongCungUng='"+cmbSoHDMua+"'";// where SoHopDongCungUng='"+cmbSoHDMua+"'";
			dtTriGiaHopDong=ket_noi.getDataTable(SqlGiaTriHopDong);

			cmbSoHDMua.DataSource=dtTriGiaHopDong;
			cmbSoHDMua.DisplayMember="SoHopDongCungUng";
			cmbSoHDMua.ValueMember="SoHopDongCungUng";

			txtTienHopDong.DataBindings.Clear();
			txtTienHopDong.DataBindings.Add("Text",dtTriGiaHopDong,"TriGiaHopDong");			
		}
		

		public void Load_TienDaNop()
		{
			string sqlTienTienDaNop="select SoHopDongCungUng, Sum(SoTien) as TongTienDaNop from PhieuChi GROUP BY SoHopDongCungUng";
			dtTienDaNop = ket_noi.getDataTable(sqlTienTienDaNop);

			dataGrid_TienDaNop.DataSource=dtTienDaNop;

			txtTienTongLanChi.DataBindings.Clear();
			txtTienTongLanChi.DataBindings.Add("Text",dtTienDaNop,"TongTienDaNop");
			cmHDongTienDaNop.DataSource=dtTienDaNop;
			cmHDongTienDaNop.DisplayMember="SoHopDongCungUng";
			cmHDongTienDaNop.ValueMember="SoHopDongCungUng";
		}

		public void Load_Data_Phieu_Chi()
		{
		
			string sqlPhieuChi="select * from PhieuChi";
			dtPhieuChi = ket_noi.getDataTable(sqlPhieuChi);

//			string sqlTienCon="select TongCong from CT_HD_CungUng where SoHopDongCungUng='"+cmbSoHDMua.Text+"'";
//			dtTienCon = ket_noi.getDataTable(sqlTienCon);

			dataGrid_PhieuChi.DataSource=dtPhieuChi;//Dịnh vào Combo Box để đựa ra Text Box

			cmSoPhieuChi.DataSource=dtPhieuChi;
			cmSoPhieuChi.DisplayMember="SoPhieu";
			cmSoPhieuChi.ValueMember="SoPhieu";

			txtSoHopDongMua.DataBindings.Clear();
			txtSoHopDongMua.DataBindings.Add("Text",dtPhieuChi,"SoHopDongCungUng");

			txtTienCon.DataBindings.Clear();
			txtTienCon.DataBindings.Add("Text",dtPhieuChi,"TienCon");
//
			cmTime_NgayNop.DataBindings.Clear();
			cmTime_NgayNop.DataBindings.Add("Text",dtPhieuChi,"NgayChi");

			txtNguoiNop.DataBindings.Clear();
			txtNguoiNop.DataBindings.Add("Text",dtPhieuChi,"NguoiChi");
			
		}
		public void MoPhim()
		{
//			btHDong_Ban.Enabled=true;
			btDau.Enabled=true;
			btLui.Enabled=true;
			btToi.Enabled=true;
			btCuoi.Enabled=true;
			btThemPhieuChi.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;	
			btLuu.Enabled=false;
			btHuy.Enabled=false;
		}
		public void TatPhim()	
		{
//			btHDong_Ban.Enabled=false;
			btDau.Enabled=false;
			btLui.Enabled=false;
			btToi.Enabled=false;
			btCuoi.Enabled=false;
			btThemPhieuChi.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
		}
		public void Clear_FrPhieuChi()
		{
			txtTienNop.Clear();
			txtNguoiNop.Clear();
			txtTienCon.Clear();
		}
		//Thêm Xóa Sửa
		public void Getinfor()
		{	
			ket_noi.PTSoPhieu = cmSoPhieuChi.Text;	
			ket_noi.PTSoHopDongBan = cmbSoHDMua.Text;					
			ket_noi.PTTien = txtTienNop.Text;
			ket_noi.PTNgayNop = cmTime_NgayNop.Text;			
			ket_noi.PTNguoiNop = txtNguoiNop.Text;	
			ket_noi.PTTCon = txtTienCon.Text;				
		}
		private int Sqlcommand(int mode,string SP, string SoHDB, string STien, string NgayChi, string NguoiChi, string TienCon)
		{
			int i=0;
			try
			{
				SqlCommand sqlcmd = new SqlCommand("Stor_PhieuChi", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@SoP",SqlDbType.NVarChar).Value= SP;
				sqlcmd.Parameters.Add("@SoHDB",SqlDbType.NVarChar).Value=SoHDB;				
				sqlcmd.Parameters.Add("@Tien",SqlDbType.NVarChar).Value=STien;
				sqlcmd.Parameters.Add("@NgayChi",SqlDbType.NVarChar).Value=NgayChi;
				sqlcmd.Parameters.Add("@NChi",SqlDbType.NVarChar).Value=NguoiChi;				
				sqlcmd.Parameters.Add("@TCon",SqlDbType.NVarChar).Value=TienCon;	
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}

		public void FirstRecord()
		{
			this.BindingContext[dtPhieuChi].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtPhieuChi].Position = dtPhieuChi.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtPhieuChi].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtPhieuChi].Position -= 1;			
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

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
//				string str="select * from PhieuChi  where SoPhieu='"+cmSoPhieuChi.Text+"'" ;
				if(KiemTra.kiemtraRong_ComBo(cmSoPhieuChi,"Số phiếu "))
				{
					if(Sqlcommand(-1,ket_noi.PTSoPhieu,ket_noi.PTSoHopDongBan,ket_noi.PTTien,ket_noi.PTNgayNop, ket_noi.PTNguoiNop, ket_noi.PTTCon)!=0)
					{		
						MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Load_Data_Phieu_Chi();
						Load_TienDaNop();
					}
				}
			}
		}
			CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			TienConLan1();
			Getinfor();
			
			if(n==1)
			{
				if(KiemTra.kiemtraRong_ComBo(cmSoPhieuChi,"Số phiếu chi "))
				{
//					string str="select * from PhieuChi  where SoPhieu='"+cmSoPhieuChi.Text+"'" ;
			
					if(KiemTra.kiemtraRong(txtNguoiNop,"Người chi "))//Người chi
					{
						
						if(KiemTra.kiemtraSo(txtTienNop,"Tiền "))
						{		
							
							if(Sqlcommand(1,ket_noi.PTSoPhieu,ket_noi.PTSoHopDongBan,ket_noi.PTTien,ket_noi.PTNgayNop, ket_noi.PTNguoiNop, ket_noi.PTTCon)!=0)
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
				if(KiemTra.kiemtraRong(txtNguoiNop,"Người chi "))//Người chi
				{						
					if(KiemTra.kiemtraSo(txtTienNop,"Tiền "))
					{						
						if(Sqlcommand(0,ket_noi.PTSoPhieu,ket_noi.PTSoHopDongBan,ket_noi.PTTien,ket_noi.PTNgayNop, ket_noi.PTNguoiNop, ket_noi.PTTCon)!=0)
						{					
							MessageBox.Show("Da cap nhat!!!!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
			

		}

		private void btThemPhieuChi_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			Clear_FrPhieuChi();
			
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
			cmbSoHDMua.Enabled=false;
			cmSoPhieuChi.Enabled=false;
			
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			Load_Data_Phieu_Chi();
			MoPhim();			
			Load_TienDaNop();
			cmbSoHDMua.Enabled=true;
			cmSoPhieuChi.Enabled=true;
		}

		private void btHDong_Ban_Click(object sender, System.EventArgs e)
		{

		}

		private void Phieu_Chi_Hop_Dong_Mua_Load(object sender, System.EventArgs e)
		{
			Load_Data_Phieu_Chi();			
			Load_TienDaNop();
			Load_TriGiaHopDong();
		}

		public void TienConLan1()
		{
			if(txtTienNop.Text!="")
			{
				if(KiemTra.KiemTraSoNguyen(txtTienNop))
				{				
					txtTienCon.Text = Convert.ToString((float.Parse(txtTienHopDong.Text))-(float.Parse(txtTienNop.Text))-(float.Parse(txtTienTongLanChi.Text)));
				}
			}
		}

		
	}
}
