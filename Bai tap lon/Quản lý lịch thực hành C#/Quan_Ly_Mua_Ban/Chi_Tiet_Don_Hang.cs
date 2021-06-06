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
	/// Summary description for Chi_Tiet_Don_Hang.
	/// </summary>
	public class Chi_Tiet_Don_Hang : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.ComboBox cmbSoHDong;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTriGia;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.TextBox txtHeSo;
		private System.Windows.Forms.DataGrid dataGrid_ChiTietHopDongBan;
		private System.Windows.Forms.TextBox txtTongGia;
		private System.Windows.Forms.ComboBox cmbMaHang;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSoLuongTon;
		private System.Windows.Forms.TextBox txtSoLuongMua;
		private System.Windows.Forms.TextBox txtSoHopDongBan;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMaHang;
		private System.Windows.Forms.TextBox txtSLNguyenThuy;
		private System.Windows.Forms.DataGrid dataGridTonHienTai;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Chi_Tiet_Don_Hang()
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
			this.txtSLNguyenThuy = new System.Windows.Forms.TextBox();
			this.txtTriGia = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btDau = new System.Windows.Forms.Button();
			this.cmbSoHDong = new System.Windows.Forms.ComboBox();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btThem = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.cmbMaHang = new System.Windows.Forms.ComboBox();
			this.txtSoLuongTon = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtHeSo = new System.Windows.Forms.TextBox();
			this.txtTongGia = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSoLuongMua = new System.Windows.Forms.TextBox();
			this.txtSoHopDongBan = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMaHang = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid_ChiTietHopDongBan = new System.Windows.Forms.DataGrid();
			this.dataGridTonHienTai = new System.Windows.Forms.DataGrid();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_ChiTietHopDongBan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTonHienTai)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtSLNguyenThuy);
			this.panel1.Controls.Add(this.txtTriGia);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btDau);
			this.panel1.Controls.Add(this.cmbSoHDong);
			this.panel1.Controls.Add(this.btLui);
			this.panel1.Controls.Add(this.btToi);
			this.panel1.Controls.Add(this.btCuoi);
			this.panel1.Controls.Add(this.btThem);
			this.panel1.Controls.Add(this.btXoa);
			this.panel1.Controls.Add(this.btSua);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.btHuy);
			this.panel1.Controls.Add(this.cmbMaHang);
			this.panel1.Controls.Add(this.txtSoLuongTon);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtHeSo);
			this.panel1.Controls.Add(this.txtTongGia);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btClear);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtSoLuongMua);
			this.panel1.Controls.Add(this.txtSoHopDongBan);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtMaHang);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 168);
			this.panel1.TabIndex = 25;
			// 
			// txtSLNguyenThuy
			// 
			this.txtSLNguyenThuy.Location = new System.Drawing.Point(296, 104);
			this.txtSLNguyenThuy.Name = "txtSLNguyenThuy";
			this.txtSLNguyenThuy.Size = new System.Drawing.Size(64, 20);
			this.txtSLNguyenThuy.TabIndex = 3;
			this.txtSLNguyenThuy.Text = "";
			// 
			// txtTriGia
			// 
			this.txtTriGia.Location = new System.Drawing.Point(488, 8);
			this.txtTriGia.Name = "txtTriGia";
			this.txtTriGia.Size = new System.Drawing.Size(168, 20);
			this.txtTriGia.TabIndex = 4;
			this.txtTriGia.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(416, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Trị Giá:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Số Hợp Đồng Bán:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã Hàng:";
			// 
			// btDau
			// 
			this.btDau.Location = new System.Drawing.Point(56, 136);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 3;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// cmbSoHDong
			// 
			this.cmbSoHDong.Location = new System.Drawing.Point(200, 8);
			this.cmbSoHDong.Name = "cmbSoHDong";
			this.cmbSoHDong.Size = new System.Drawing.Size(80, 21);
			this.cmbSoHDong.TabIndex = 1;
			// 
			// btLui
			// 
			this.btLui.Location = new System.Drawing.Point(104, 136);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 16;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.Location = new System.Drawing.Point(152, 136);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 15;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.Location = new System.Drawing.Point(200, 136);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 14;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btThem
			// 
			this.btThem.Location = new System.Drawing.Point(288, 8);
			this.btThem.Name = "btThem";
			this.btThem.TabIndex = 7;
			this.btThem.Text = "&Thêm";
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btXoa
			// 
			this.btXoa.Location = new System.Drawing.Point(288, 136);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 9;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.Location = new System.Drawing.Point(376, 136);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 10;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.Location = new System.Drawing.Point(464, 136);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 11;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.Location = new System.Drawing.Point(552, 136);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 12;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// cmbMaHang
			// 
			this.cmbMaHang.Location = new System.Drawing.Point(200, 40);
			this.cmbMaHang.Name = "cmbMaHang";
			this.cmbMaHang.Size = new System.Drawing.Size(80, 21);
			this.cmbMaHang.TabIndex = 2;
			// 
			// txtSoLuongTon
			// 
			this.txtSoLuongTon.Location = new System.Drawing.Point(112, 72);
			this.txtSoLuongTon.Name = "txtSoLuongTon";
			this.txtSoLuongTon.Size = new System.Drawing.Size(168, 20);
			this.txtSoLuongTon.TabIndex = 3;
			this.txtSoLuongTon.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "Số Lượng Tồn:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(416, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 22;
			this.label4.Text = "Hệ Số Giảm:";
			// 
			// txtHeSo
			// 
			this.txtHeSo.Location = new System.Drawing.Point(488, 40);
			this.txtHeSo.Name = "txtHeSo";
			this.txtHeSo.Size = new System.Drawing.Size(168, 20);
			this.txtHeSo.TabIndex = 5;
			this.txtHeSo.Text = "";
			// 
			// txtTongGia
			// 
			this.txtTongGia.Location = new System.Drawing.Point(488, 72);
			this.txtTongGia.Name = "txtTongGia";
			this.txtTongGia.ReadOnly = true;
			this.txtTongGia.Size = new System.Drawing.Size(168, 20);
			this.txtTongGia.TabIndex = 6;
			this.txtTongGia.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(464, 136);
			this.button1.Name = "button1";
			this.button1.TabIndex = 10;
			this.button1.Text = "&Lưu";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(288, 8);
			this.button2.Name = "button2";
			this.button2.TabIndex = 13;
			this.button2.Text = "&Thêm";
			// 
			// btClear
			// 
			this.btClear.BackColor = System.Drawing.Color.Crimson;
			this.btClear.Location = new System.Drawing.Point(288, 72);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(88, 23);
			this.btClear.TabIndex = 8;
			this.btClear.Text = "Lấy Số Lượng";
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Số Lượng:";
			// 
			// txtSoLuongMua
			// 
			this.txtSoLuongMua.Location = new System.Drawing.Point(112, 104);
			this.txtSoLuongMua.Name = "txtSoLuongMua";
			this.txtSoLuongMua.Size = new System.Drawing.Size(168, 20);
			this.txtSoLuongMua.TabIndex = 3;
			this.txtSoLuongMua.Text = "";
			// 
			// txtSoHopDongBan
			// 
			this.txtSoHopDongBan.Location = new System.Drawing.Point(112, 8);
			this.txtSoHopDongBan.Name = "txtSoHopDongBan";
			this.txtSoHopDongBan.Size = new System.Drawing.Size(80, 20);
			this.txtSoHopDongBan.TabIndex = 3;
			this.txtSoHopDongBan.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(392, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 23);
			this.label8.TabIndex = 24;
			this.label8.Text = "Trị Giá Hợp Đồng:";
			// 
			// txtMaHang
			// 
			this.txtMaHang.Location = new System.Drawing.Point(112, 40);
			this.txtMaHang.Name = "txtMaHang";
			this.txtMaHang.Size = new System.Drawing.Size(80, 20);
			this.txtMaHang.TabIndex = 3;
			this.txtMaHang.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 23);
			this.label1.TabIndex = 24;
			this.label1.Text = "Chi Tiết Hợp Đồng Bán:";
			// 
			// dataGrid_ChiTietHopDongBan
			// 
			this.dataGrid_ChiTietHopDongBan.CaptionText = "Chi tiết hợp đồng bán";
			this.dataGrid_ChiTietHopDongBan.DataMember = "";
			this.dataGrid_ChiTietHopDongBan.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_ChiTietHopDongBan.Location = new System.Drawing.Point(0, 216);
			this.dataGrid_ChiTietHopDongBan.Name = "dataGrid_ChiTietHopDongBan";
			this.dataGrid_ChiTietHopDongBan.Size = new System.Drawing.Size(560, 248);
			this.dataGrid_ChiTietHopDongBan.TabIndex = 26;
			// 
			// dataGridTonHienTai
			// 
			this.dataGridTonHienTai.CaptionText = "Trị giá hợp đồng";
			this.dataGridTonHienTai.DataMember = "";
			this.dataGridTonHienTai.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTonHienTai.Location = new System.Drawing.Point(552, 216);
			this.dataGridTonHienTai.Name = "dataGridTonHienTai";
			this.dataGridTonHienTai.Size = new System.Drawing.Size(216, 248);
			this.dataGridTonHienTai.TabIndex = 27;
			// 
			// Chi_Tiet_Don_Hang
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 334);
			this.Controls.Add(this.dataGridTonHienTai);
			this.Controls.Add(this.dataGrid_ChiTietHopDongBan);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Chi_Tiet_Don_Hang";
			this.Text = "Chi_Tiet_Don_Hang";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Chi_Tiet_Don_Hang_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_ChiTietHopDongBan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTonHienTai)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtC_T_HD_Ban = new DataTable();
		DataTable dtHang = new DataTable();
		DataTable dtSoHDong = new DataTable();
		DataTable dtTonHienTai = new DataTable();
		DataTable dtKiemTraLuongTon = new DataTable();
		public int n=0;
		public void Load_Data_ChiTiet_HopDongBan()
		{
			try
			{
				string sqlChiTietHopDongBan="select * from VIEWChiTietHDBan";
				dtC_T_HD_Ban = ket_noi.getDataTable(sqlChiTietHopDongBan);
			
				string SqlHang ="select MaHang, SoLuong from HangHoa";
				dtHang = ket_noi.getDataTable(SqlHang);

				string SqlSoHDong ="select SoHopDongBan from HopDongBan";
				dtSoHDong = ket_noi.getDataTable(SqlSoHDong);

				string SqlTonHienTai="select MaHang, Min(SoLuongTon)As TonHienTai from C_T_H_Dong_Ban Group by MaHang";
				dtTonHienTai = ket_noi.getDataTable(SqlTonHienTai);
				dataGridTonHienTai.DataSource=dtTonHienTai;
				txtMaHang.DataBindings.Clear();
				txtMaHang.DataBindings.Add("Text",dtTonHienTai,"MaHang");
				txtSoLuongTon.DataBindings.Clear();
				txtSoLuongTon.DataBindings.Add("Text",dtTonHienTai,"TonHienTai");

				dataGrid_ChiTietHopDongBan.DataSource=dtC_T_HD_Ban;//Dịnh vào Combo Box để đựa ra Text Box

				cmbSoHDong.DataSource=dtSoHDong;
				cmbSoHDong.DisplayMember="SoHopDongBan";
				cmbSoHDong.ValueMember="SoHopDongBan";

				txtSoHopDongBan.DataBindings.Clear();
				txtSoHopDongBan.DataBindings.Add("Text",dtC_T_HD_Ban,"SoHD");

				cmbMaHang.DataSource=dtHang;
				cmbMaHang.DisplayMember="MaHang";
				cmbMaHang.ValueMember="MaHang";
				txtSLNguyenThuy.DataBindings.Clear();
				txtSLNguyenThuy.DataBindings.Add("Text",dtHang,"SoLuong");

				txtSoLuongMua.DataBindings.Clear();
				txtTriGia.DataBindings.Clear();
				txtHeSo.DataBindings.Clear();
				txtTongGia.DataBindings.Clear();
				

				txtSoLuongMua.DataBindings.Add("Text",dtC_T_HD_Ban,"SoLuongBan");
				txtTriGia.DataBindings.Add("Text",dtC_T_HD_Ban,"Gia");
				txtHeSo.DataBindings.Add("Text",dtC_T_HD_Ban,"HeSo");
				txtTongGia.DataBindings.Add("Text",dtC_T_HD_Ban,"TongTien");
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}
		public void KiemTraHangTon()
		{			
			if(KiemTra.kiemtraRong(txtSoLuongMua," Số lương"))
			{
				if(KiemTra.KiemTraSoRong(txtSoLuongTon))
				{
					if(float.Parse(txtSoLuongTon.Text)<=float.Parse(txtSoLuongMua.Text))
					{		
						//				txtSoLuongTon.Text=Convert.ToString(float.Parse(txtSLNguyenThuy.Text)-float.Parse(txtSoLuongMua.Text));
						txtSoLuongMua.Text=Convert.ToString(float.Parse(txtSoLuongTon.Text));
						MessageBox.Show(this,"Lưu ý: Hàng tồn chỉ còn: "+txtSoLuongTon.Text+". Xin quí khách vui lòng quay lại sau! Thank","Waring",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}	
				}
			}
		}
		public void TongGia()
		{
			
			if(KiemTra.kiemtraRong_ComBo(cmbSoHDong,"Số hợp đồng "))
			{
//				string str="select * from C_T_H_Dong_Ban  where SoHopDongBan='"+cmbSoHDong.Text+"'" ;
				if(KiemTra.kiemtraRong_ComBo(cmbMaHang,"Mã hàng "))
				{
					if(KiemTra.kiemtraSo(txtTriGia,"Trị giá "))
					{	
						if(KiemTra.KiemTraHeSoRong(txtHeSo))
						{							
							if(txtSoLuongMua.Text!="" && txtHeSo.Text!="" && txtTriGia.Text!="")
							{
								
								try
								{
									txtTongGia.Text = Convert.ToString((float.Parse(txtSoLuongMua.Text)*float.Parse(txtTriGia.Text)-(float.Parse(txtHeSo.Text)*(float.Parse(txtSoLuongMua.Text)*float.Parse(txtTriGia.Text)))));
								}
								catch
								{
									MessageBox.Show("Số lương, Trị giá, Hệ số là số: 0.0!!!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
								
							}
						}
					}
				}
			}						
		}
		public void MoPhim()
		{			
			btThem.Enabled=true;
			txtSoHopDongBan.Enabled=true;
			cmbSoHDong.Enabled=true;
			txtMaHang.Enabled=true;
			cmbMaHang.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;			
			btLuu.Enabled=false;
			btHuy.Enabled=false;
		}
		public void TatPhim()	
		{			
			txtSoHopDongBan.Enabled=false;
//			cmbSoHDong.Enabled=false;
			txtMaHang.Enabled=false;
//			cmbMaHang.Enabled=true;
			btThem.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
		}
		public void Clear_FrChiTietHopDongBan()
		{
			txtTriGia.Clear();
			txtHeSo.Clear();
			txtSoLuongMua.Clear();
			txtTongGia.Clear();			
		}
		//Thêm Xóa Sửa
		public void Getinfor()
		{	
			ket_noi.CTBSoHD = cmbSoHDong.Text;
			ket_noi.CTBMaHang = cmbMaHang.Text;	
			ket_noi.CTBLuongTon= txtSoLuongTon.Text;
			ket_noi.CTBSoLuong = txtSoLuongMua.Text;	
			ket_noi.CTBTriGia = txtTriGia.Text;		
			ket_noi.CTBHeSo = txtHeSo.Text;	
			ket_noi.CTBTong = txtTongGia.Text;												
		}
		private int Sqlcommand(int mode, string SHDB, string MHang, string Luong, string LuongHienTai, string Tien, string heSO, string Tong)
		{
			int i=0;
			try
			{						
				SqlCommand sqlcmd = new SqlCommand("Stor_ChiTietHopDongBan", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@SoHD",SqlDbType.NVarChar).Value= SHDB;
				sqlcmd.Parameters.Add("@MHang",SqlDbType.NVarChar).Value= MHang;
				sqlcmd.Parameters.Add("@SLuong",SqlDbType.NVarChar).Value=Luong;
				sqlcmd.Parameters.Add("@LuongHienTai",SqlDbType.NVarChar).Value=LuongHienTai;
				sqlcmd.Parameters.Add("@Tien",SqlDbType.NVarChar).Value=Tien;
				sqlcmd.Parameters.Add("@HeSo",SqlDbType.Float).Value=heSO;
				sqlcmd.Parameters.Add("@TongGia",SqlDbType.NVarChar).Value=Tong;			
				
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.CTBSoHD,ket_noi.CTBMaHang,ket_noi.CTBSoLuong, ket_noi.CTBLuongTon,ket_noi.CTBTriGia, ket_noi.CTBHeSo, ket_noi.CTBTong)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_ChiTiet_HopDongBan();
				}
			}
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			try
			{
				KiemTraHangTon();
				txtSoLuongTon.Text=Convert.ToString(float.Parse(txtSoLuongTon.Text)-float.Parse(txtSoLuongMua.Text));
			
				TongGia();
				Getinfor();
				if(n==1)
				{
					if(KiemTra.kiemtraRong_ComBo(cmbSoHDong,"Số hợp đồng "))
					{
						//					string str="select * from C_T_H_Dong_Ban  where SoHopDongBan='"+cmbSoHDong.Text+"'" ;
						if(KiemTra.kiemtraRong_ComBo(cmbMaHang,"Mã hàng "))
						{
							if(KiemTra.kiemtraSo(txtTriGia,"Trị giá "))
							{	
								if(KiemTra.KiemTraHeSoRong(txtHeSo))
								{									
									if(Sqlcommand(1,ket_noi.CTBSoHD,ket_noi.CTBMaHang,ket_noi.CTBSoLuong, ket_noi.CTBLuongTon,ket_noi.CTBTriGia, ket_noi.CTBHeSo, ket_noi.CTBTong)!=0)
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
				{			
					TongGia();
					if(KiemTra.kiemtraSo(txtTriGia,"Trị giá "))
					{	
						if(KiemTra.KiemTraHeSoRong(txtHeSo))
						{							
							if(Sqlcommand(0,ket_noi.CTBSoHD,ket_noi.CTBMaHang,ket_noi.CTBSoLuong, ket_noi.CTBLuongTon,ket_noi.CTBTriGia, ket_noi.CTBHeSo, ket_noi.CTBTong)!=0)
							{
								MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}				
				}	
			}
			catch
			{
				Getinfor();
			}
			
//			Load_Data_ChiTiet_HopDongBan();
		}

		private void btThem_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			cmbMaHang.Enabled=true;
			cmbSoHDong.Enabled=true;
			Clear_FrChiTietHopDongBan();			
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			cmbMaHang.Enabled=false;
			cmbSoHDong.Enabled=false;
			n=2;			
			TatPhim();
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			Load_Data_ChiTiet_HopDongBan();
//			txtSLNguyenThuy.BringToFront();
		}
		public void FirstRecord()
		{
			this.BindingContext[dtC_T_HD_Ban].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtC_T_HD_Ban].Position = dtC_T_HD_Ban.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtC_T_HD_Ban].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtC_T_HD_Ban].Position -= 1;			
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

		private void btClear_Click(object sender, System.EventArgs e)
		{
			DialogResult TBLaySL = new DialogResult();
			TBLaySL=MessageBox.Show("Bạn lấy số lượng thì bạn phải bảo đảm sự đúng đắng của chương trình!","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(TBLaySL==DialogResult.OK)
			{
				txtSoLuongTon.Clear();
				txtSoLuongTon.Text=Convert.ToString(float.Parse(txtSLNguyenThuy.Text));
			}
		}

		private void Chi_Tiet_Don_Hang_Load(object sender, System.EventArgs e)
		{
			
		}
	}
}
