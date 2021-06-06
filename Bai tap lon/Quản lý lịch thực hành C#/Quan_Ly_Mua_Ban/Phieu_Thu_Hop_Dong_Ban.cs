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
	/// Summary description for Phieu_Thu_Hop_Dong_Ban.
	/// </summary>
	public class Phieu_Thu_Hop_Dong_Ban : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Button btThemPhieuThu;
		private System.Windows.Forms.ComboBox cmbSoHDBan;
		private System.Windows.Forms.ComboBox cmSoPhieuThu;
		private System.Windows.Forms.DataGrid dataGrid_PhieuThu;
		private System.Windows.Forms.TextBox txtNguoiNop;
		private System.Windows.Forms.TextBox txtTienCon;
		private System.Windows.Forms.DateTimePicker cmTime_NgayNop;
		private System.Windows.Forms.TextBox txtSoHopDongBan;
		private System.Windows.Forms.TextBox txtTienHopDong;
		private System.Windows.Forms.TextBox txtTienTongLanThu;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTienNop;
		private System.Windows.Forms.DataGrid dataGridTienDaThu;
		private System.Windows.Forms.ComboBox cmSoHDofPhieuThu;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Phieu_Thu_Hop_Dong_Ban()
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
			this.btThemPhieuThu = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSoHDBan = new System.Windows.Forms.ComboBox();
			this.cmSoPhieuThu = new System.Windows.Forms.ComboBox();
			this.txtTienNop = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid_PhieuThu = new System.Windows.Forms.DataGrid();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNguoiNop = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTienCon = new System.Windows.Forms.TextBox();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.btDau = new System.Windows.Forms.Button();
			this.cmTime_NgayNop = new System.Windows.Forms.DateTimePicker();
			this.txtSoHopDongBan = new System.Windows.Forms.TextBox();
			this.txtTienHopDong = new System.Windows.Forms.TextBox();
			this.txtTienTongLanThu = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridTienDaThu = new System.Windows.Forms.DataGrid();
			this.cmSoHDofPhieuThu = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_PhieuThu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTienDaThu)).BeginInit();
			this.SuspendLayout();
			// 
			// btThemPhieuThu
			// 
			this.btThemPhieuThu.Location = new System.Drawing.Point(288, 80);
			this.btThemPhieuThu.Name = "btThemPhieuThu";
			this.btThemPhieuThu.TabIndex = 7;
			this.btThemPhieuThu.Text = "&Thêm";
			this.btThemPhieuThu.Click += new System.EventHandler(this.btThemPhieuThu_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 56;
			this.label3.Text = "Số Phiếu Thu:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 55;
			this.label2.Text = "Số Hợp Đồng Bán:";
			// 
			// cmbSoHDBan
			// 
			this.cmbSoHDBan.Location = new System.Drawing.Point(200, 48);
			this.cmbSoHDBan.Name = "cmbSoHDBan";
			this.cmbSoHDBan.Size = new System.Drawing.Size(80, 21);
			this.cmbSoHDBan.TabIndex = 1;
			// 
			// cmSoPhieuThu
			// 
			this.cmSoPhieuThu.Location = new System.Drawing.Point(112, 80);
			this.cmSoPhieuThu.Name = "cmSoPhieuThu";
			this.cmSoPhieuThu.Size = new System.Drawing.Size(168, 21);
			this.cmSoPhieuThu.TabIndex = 2;
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
			this.label9.TabIndex = 58;
			this.label9.Text = "Số Tiền Thu:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 32);
			this.label1.TabIndex = 56;
			this.label1.Text = "Phiếu Thu Của Hợp Đồng Bán:";
			// 
			// dataGrid_PhieuThu
			// 
			this.dataGrid_PhieuThu.DataMember = "";
			this.dataGrid_PhieuThu.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_PhieuThu.Location = new System.Drawing.Point(0, 208);
			this.dataGrid_PhieuThu.Name = "dataGrid_PhieuThu";
			this.dataGrid_PhieuThu.Size = new System.Drawing.Size(584, 264);
			this.dataGrid_PhieuThu.TabIndex = 61;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(376, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 58;
			this.label4.Text = "Ngày Nộp:";
			// 
			// txtNguoiNop
			// 
			this.txtNguoiNop.Location = new System.Drawing.Point(464, 80);
			this.txtNguoiNop.Name = "txtNguoiNop";
			this.txtNguoiNop.Size = new System.Drawing.Size(168, 20);
			this.txtNguoiNop.TabIndex = 5;
			this.txtNguoiNop.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(376, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 58;
			this.label5.Text = "Người Nộp:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(376, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 58;
			this.label6.Text = "Tiền Còn Lại:";
			// 
			// txtTienCon
			// 
			this.txtTienCon.Location = new System.Drawing.Point(464, 144);
			this.txtTienCon.Name = "txtTienCon";
			this.txtTienCon.ReadOnly = true;
			this.txtTienCon.Size = new System.Drawing.Size(168, 20);
			this.txtTienCon.TabIndex = 6;
			this.txtTienCon.Text = "";
			// 
			// btLui
			// 
			this.btLui.Location = new System.Drawing.Point(152, 176);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 69;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.Location = new System.Drawing.Point(200, 176);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 68;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.Location = new System.Drawing.Point(248, 176);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 67;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btXoa
			// 
			this.btXoa.Location = new System.Drawing.Point(296, 176);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 8;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.Location = new System.Drawing.Point(384, 176);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 9;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.Location = new System.Drawing.Point(472, 176);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 10;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.Location = new System.Drawing.Point(560, 176);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 11;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// btDau
			// 
			this.btDau.Location = new System.Drawing.Point(104, 176);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 62;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click_1);
			// 
			// cmTime_NgayNop
			// 
			this.cmTime_NgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmTime_NgayNop.Location = new System.Drawing.Point(464, 48);
			this.cmTime_NgayNop.Name = "cmTime_NgayNop";
			this.cmTime_NgayNop.Size = new System.Drawing.Size(168, 20);
			this.cmTime_NgayNop.TabIndex = 4;
			// 
			// txtSoHopDongBan
			// 
			this.txtSoHopDongBan.Location = new System.Drawing.Point(112, 48);
			this.txtSoHopDongBan.Name = "txtSoHopDongBan";
			this.txtSoHopDongBan.ReadOnly = true;
			this.txtSoHopDongBan.Size = new System.Drawing.Size(80, 20);
			this.txtSoHopDongBan.TabIndex = 3;
			this.txtSoHopDongBan.Text = "";
			// 
			// txtTienHopDong
			// 
			this.txtTienHopDong.Location = new System.Drawing.Point(112, 144);
			this.txtTienHopDong.Name = "txtTienHopDong";
			this.txtTienHopDong.ReadOnly = true;
			this.txtTienHopDong.Size = new System.Drawing.Size(168, 20);
			this.txtTienHopDong.TabIndex = 98;
			this.txtTienHopDong.Text = "";
			// 
			// txtTienTongLanThu
			// 
			this.txtTienTongLanThu.Location = new System.Drawing.Point(464, 112);
			this.txtTienTongLanThu.Name = "txtTienTongLanThu";
			this.txtTienTongLanThu.Size = new System.Drawing.Size(80, 20);
			this.txtTienTongLanThu.TabIndex = 95;
			this.txtTienTongLanThu.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 23);
			this.label7.TabIndex = 97;
			this.label7.Text = "Trị Giá Hợp Đồng";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(376, 112);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 96;
			this.label8.Text = "Số Tiền Đã Thu:";
			// 
			// dataGridTienDaThu
			// 
			this.dataGridTienDaThu.DataMember = "";
			this.dataGridTienDaThu.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTienDaThu.Location = new System.Drawing.Point(576, 208);
			this.dataGridTienDaThu.Name = "dataGridTienDaThu";
			this.dataGridTienDaThu.Size = new System.Drawing.Size(232, 264);
			this.dataGridTienDaThu.TabIndex = 99;
			// 
			// cmSoHDofPhieuThu
			// 
			this.cmSoHDofPhieuThu.Location = new System.Drawing.Point(552, 112);
			this.cmSoHDofPhieuThu.Name = "cmSoHDofPhieuThu";
			this.cmSoHDofPhieuThu.Size = new System.Drawing.Size(80, 21);
			this.cmSoHDofPhieuThu.TabIndex = 1;
			// 
			// Phieu_Thu_Hop_Dong_Ban
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(712, 334);
			this.Controls.Add(this.dataGridTienDaThu);
			this.Controls.Add(this.txtTienHopDong);
			this.Controls.Add(this.txtTienTongLanThu);
			this.Controls.Add(this.txtTienNop);
			this.Controls.Add(this.txtNguoiNop);
			this.Controls.Add(this.txtTienCon);
			this.Controls.Add(this.txtSoHopDongBan);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmTime_NgayNop);
			this.Controls.Add(this.btLui);
			this.Controls.Add(this.btToi);
			this.Controls.Add(this.btCuoi);
			this.Controls.Add(this.btXoa);
			this.Controls.Add(this.btSua);
			this.Controls.Add(this.btLuu);
			this.Controls.Add(this.btHuy);
			this.Controls.Add(this.btDau);
			this.Controls.Add(this.dataGrid_PhieuThu);
			this.Controls.Add(this.btThemPhieuThu);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbSoHDBan);
			this.Controls.Add(this.cmSoPhieuThu);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmSoHDofPhieuThu);
			this.Name = "Phieu_Thu_Hop_Dong_Ban";
			this.Text = "Phieu_Thu_Hop_Dong_Ban";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Phieu_Thu_Hop_Dong_Ban_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_PhieuThu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTienDaThu)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtPhieuTHu = new DataTable();
		DataTable dtCTHDongBan = new DataTable();
		DataTable dtTienDaThu = new DataTable();
		public int n=0;
		public void Load_TienDaThu()
		{
			string sqlTienThu="select SoHopDongBan, Sum(SoTien) as TienDaThu from PhieuThu Group By SoHopDongBan";
			dtTienDaThu = ket_noi.getDataTable(sqlTienThu);

			dataGridTienDaThu.DataSource=dtTienDaThu;

			txtTienTongLanThu.DataBindings.Clear();
			txtTienTongLanThu.DataBindings.Add("Text",dtTienDaThu,"TienDaThu");
			cmSoHDofPhieuThu.DataSource=dtTienDaThu;
			cmSoHDofPhieuThu.DisplayMember="SoHopDongBan";
			cmSoHDofPhieuThu.ValueMember="SoHopDongBan";
		}
		public void Load_Data_PhieuThu()
		{
		
			string sqlPhieuThu="select * from PhieuThu";
			dtPhieuTHu = ket_noi.getDataTable(sqlPhieuThu);
			string sqlSoHopDongTriGia = "select SoHopDongBan, sum(TongCong) as TriGiaHopDong  from C_T_H_Dong_Ban group by SoHopDongBan";
			dtCTHDongBan = ket_noi.getDataTable(sqlSoHopDongTriGia);

			dataGrid_PhieuThu.DataSource=dtPhieuTHu;//Dịnh vào Combo Box để đựa ra Text Box

			cmbSoHDBan.DataSource=dtCTHDongBan;
			cmbSoHDBan.DisplayMember="SoHopDongBan";
			cmbSoHDBan.ValueMember="SoHopDongBan";

			txtTienHopDong.DataBindings.Clear();
			txtTienHopDong.DataBindings.Add("Text",dtCTHDongBan,"TriGiaHopDong");

			cmSoPhieuThu.DataSource=dtPhieuTHu;
			cmSoPhieuThu.DisplayMember="SoPhieu";
			cmSoPhieuThu.ValueMember="SoPhieu";

//			txtTienTongLanThu.DataBindings.Clear();
//			txtTienTongLanThu.DataBindings.Add("Text",dtPhieuTHu,"SoLuong");

//			txtTienNop.DataBindings.Clear();
//			txtTienNop.DataBindings.Add("Text",dtPhieuTHu,"SoTien");

			cmTime_NgayNop.DataBindings.Clear();
			cmTime_NgayNop.DataBindings.Add("Text",dtPhieuTHu,"NgayNop");

			txtNguoiNop.DataBindings.Clear();
			txtNguoiNop.DataBindings.Add("Text",dtPhieuTHu,"NguoiNop");

			txtTienCon.DataBindings.Clear();
			txtTienCon.DataBindings.Add("Text",dtPhieuTHu,"TienCon");	

			txtSoHopDongBan.DataBindings.Clear();
			txtSoHopDongBan.DataBindings.Add("Text",dtPhieuTHu,"SoHopDongBan");
		}
		public void MoPhim()
		{
//			btHDong_Ban.Enabled=true;
//			btDau.Enabled=true;
//			btLui.Enabled=true;
//			btToi.Enabled=true;
//			btCuoi.Enabled=true;
			txtSoHopDongBan.Enabled=true;
			btThemPhieuThu.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;	
			btLuu.Enabled=false;
			btHuy.Enabled=false;
		}
		public void TatPhim()	
		{
//			btHDong_Ban.Enabled=false;
//			btDau.Enabled=false;
//			btLui.Enabled=false;
//			btToi.Enabled=false;
//			btCuoi.Enabled=false;
			txtSoHopDongBan.Enabled=false;
			btThemPhieuThu.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
		}
		public void Clear_FrPhieuThu()
		{
			txtTienNop.Clear();
			txtNguoiNop.Clear();
//			txtTienCon.Clear();
		}
		public void TienConLai()
		{
			if(txtTienNop.Text!="")
			{
				if(KiemTra.KiemTraSoNguyen(txtTienNop))
				{	
					if(KiemTra.KiemTraSoRong(txtTienTongLanThu))
					{
						txtTienCon.Text = Convert.ToString((float.Parse(txtTienHopDong.Text))-(float.Parse(txtTienNop.Text))-(float.Parse(txtTienTongLanThu.Text)));
					}
				}
			}
		}
		
		
		//Thêm Xóa Sửa
		public void Getinfor()
		{	
			ket_noi.PTSoPhieu = cmSoPhieuThu.Text;	
			ket_noi.PTSoHopDongBan = cmbSoHDBan.Text;					
			ket_noi.PTTien = txtTienNop.Text;
//			ket_noi.PTTienDaNop = txtTienTongLanThu.Text;
			ket_noi.PTNgayNop = cmTime_NgayNop.Text;			
			ket_noi.PTNguoiNop = txtNguoiNop.Text;	
			ket_noi.PTTCon = txtTienCon.Text;				
		}
		private int Sqlcommand(int mode,string SP, string SoHDB, string STien, string NgayNop, string NguoiNop, string TienCon)
		{
			int i=0;
			try
			{
				SqlCommand sqlcmd = new SqlCommand("Stor_PhieuThu", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@SoP",SqlDbType.NVarChar).Value= SP;
				sqlcmd.Parameters.Add("@SoHDB",SqlDbType.NVarChar).Value=SoHDB;				
				sqlcmd.Parameters.Add("@Tien",SqlDbType.NVarChar).Value=STien;
//				sqlcmd.Parameters.Add("@TienDaNop",SqlDbType.NVarChar).Value=STienDaNop;
				sqlcmd.Parameters.Add("@NgayNop",SqlDbType.NVarChar).Value=NgayNop;
				sqlcmd.Parameters.Add("@NNop",SqlDbType.NVarChar).Value=NguoiNop;				
				sqlcmd.Parameters.Add("@TCon",SqlDbType.NVarChar).Value=TienCon;	
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}


		private void btThemPhieuThu_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			Clear_FrPhieuThu();
			cmbSoHDBan.Enabled=true;
			cmSoPhieuThu.Enabled=true;	
			txtSoHopDongBan.Enabled=false;
			
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
			cmbSoHDBan.Enabled=false;
			cmSoPhieuThu.Enabled=false;	
			txtSoHopDongBan.Enabled=false;
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			Load_Data_PhieuThu();
			Load_TienDaThu();
			cmbSoHDBan.Enabled=true;
			cmSoPhieuThu.Enabled=true;	
			txtSoHopDongBan.Enabled=true;
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			TienConLai();
			Getinfor();
			if(n==1)
			{
				if(KiemTra.kiemtraRong_ComBo(cmSoPhieuThu,"Số phiếu thu "))
				{
					string str="select * from PhieuThu  where SoPhieu='"+cmSoPhieuThu.Text+"'" ;
			
					if(KiemTra.kiemtraRong(txtTienNop,"Số tiền "))
					{
						if(KiemTra.kiemtra_DaTonTai(cmSoPhieuThu,"Số phiếu thu ",str))
						{								
							if(KiemTra.kiemtraRong(txtNguoiNop,"Người Nộp "))//Người chi
							{
								if(Sqlcommand(1,ket_noi.PTSoPhieu,ket_noi.PTSoHopDongBan,ket_noi.PTTien,ket_noi.PTNgayNop, ket_noi.PTNguoiNop, ket_noi.PTTCon)!=0)
								{						
									MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}	
						}
					}
				}
			}
			else
				if(n==2)
			{	TienConLai();
				if(KiemTra.kiemtraRong(txtTienNop,"Số tiền "))
				{
					if(Sqlcommand(0,ket_noi.PTSoPhieu,ket_noi.PTSoHopDongBan,ket_noi.PTTien,ket_noi.PTNgayNop, ket_noi.PTNguoiNop, ket_noi.PTTCon)!=0)
					{						
						MessageBox.Show("Da cap nhat!!!!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				if(Sqlcommand(-1,ket_noi.PTSoPhieu,ket_noi.PTSoHopDongBan,ket_noi.PTTien,ket_noi.PTNgayNop, ket_noi.PTNguoiNop, ket_noi.PTTCon)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_PhieuThu();
					Load_TienDaThu();
				}
			}
		}
		public void FirstRecord()
		{
			this.BindingContext[dtPhieuTHu].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtPhieuTHu].Position = dtPhieuTHu.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtPhieuTHu].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtPhieuTHu].Position -= 1;			
		}

		private void btDau_Click(object sender, System.EventArgs e)
		{
			FirstRecord();
		}

		private void btDau_Click_1(object sender, System.EventArgs e)
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

		private void Phieu_Thu_Hop_Dong_Ban_Load(object sender, System.EventArgs e)
		{
			Load_TienDaThu();			
		}
	}
}
