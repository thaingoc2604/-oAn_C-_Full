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
	/// Summary description for Chi_Tiet_Hop_Dong_Cung_Ung.
	/// </summary>
	public class Chi_Tiet_Hop_Dong_Cung_Ung : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtTriGia;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.ComboBox cmbSoHDong;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.ComboBox cmbMaHang;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtHeSo;
		private System.Windows.Forms.TextBox txtTongGia;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid_CT_HD_C_Ung;
		private System.Windows.Forms.TextBox txtSoHopDongMua;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Chi_Tiet_Hop_Dong_Cung_Ung()
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
			this.txtTriGia = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
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
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtHeSo = new System.Windows.Forms.TextBox();
			this.txtTongGia = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.txtSoHopDongMua = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid_CT_HD_C_Ung = new System.Windows.Forms.DataGrid();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_CT_HD_C_Ung)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtTriGia);
			this.panel1.Controls.Add(this.label6);
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
			this.panel1.Controls.Add(this.txtSoLuong);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtHeSo);
			this.panel1.Controls.Add(this.txtTongGia);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btClear);
			this.panel1.Controls.Add(this.txtSoHopDongMua);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 136);
			this.panel1.TabIndex = 27;
			// 
			// txtTriGia
			// 
			this.txtTriGia.Location = new System.Drawing.Point(456, 8);
			this.txtTriGia.Name = "txtTriGia";
			this.txtTriGia.Size = new System.Drawing.Size(168, 20);
			this.txtTriGia.TabIndex = 4;
			this.txtTriGia.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(384, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Trị Giá:";
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
			this.btDau.Location = new System.Drawing.Point(80, 104);
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
			this.btLui.Location = new System.Drawing.Point(128, 104);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 16;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.Location = new System.Drawing.Point(176, 104);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 15;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.Location = new System.Drawing.Point(224, 104);
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
			this.btXoa.Location = new System.Drawing.Point(288, 104);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 9;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.Location = new System.Drawing.Point(376, 104);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 10;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.Location = new System.Drawing.Point(464, 104);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 11;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.Location = new System.Drawing.Point(552, 104);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 12;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// cmbMaHang
			// 
			this.cmbMaHang.Location = new System.Drawing.Point(112, 40);
			this.cmbMaHang.Name = "cmbMaHang";
			this.cmbMaHang.Size = new System.Drawing.Size(168, 21);
			this.cmbMaHang.TabIndex = 2;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(112, 72);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(168, 20);
			this.txtSoLuong.TabIndex = 3;
			this.txtSoLuong.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "Số Lượng:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(384, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 22;
			this.label4.Text = "Hệ Số Giảm:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(384, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Tổng Giá:";
			// 
			// txtHeSo
			// 
			this.txtHeSo.Location = new System.Drawing.Point(456, 40);
			this.txtHeSo.Name = "txtHeSo";
			this.txtHeSo.Size = new System.Drawing.Size(168, 20);
			this.txtHeSo.TabIndex = 5;
			this.txtHeSo.Text = "";
			// 
			// txtTongGia
			// 
			this.txtTongGia.Location = new System.Drawing.Point(456, 72);
			this.txtTongGia.Name = "txtTongGia";
			this.txtTongGia.ReadOnly = true;
			this.txtTongGia.Size = new System.Drawing.Size(168, 20);
			this.txtTongGia.TabIndex = 6;
			this.txtTongGia.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(464, 104);
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
			this.btClear.Location = new System.Drawing.Point(288, 72);
			this.btClear.Name = "btClear";
			this.btClear.TabIndex = 8;
			this.btClear.Text = "&Clear";
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// txtSoHopDongMua
			// 
			this.txtSoHopDongMua.Location = new System.Drawing.Point(112, 8);
			this.txtSoHopDongMua.Name = "txtSoHopDongMua";
			this.txtSoHopDongMua.Size = new System.Drawing.Size(80, 20);
			this.txtSoHopDongMua.TabIndex = 3;
			this.txtSoHopDongMua.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Số Hợp Đồng Mua:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 23);
			this.label1.TabIndex = 26;
			this.label1.Text = "Chi Tiết Hợp Đồng Mua";
			// 
			// dataGrid_CT_HD_C_Ung
			// 
			this.dataGrid_CT_HD_C_Ung.DataMember = "";
			this.dataGrid_CT_HD_C_Ung.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGrid_CT_HD_C_Ung.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_CT_HD_C_Ung.Location = new System.Drawing.Point(0, 22);
			this.dataGrid_CT_HD_C_Ung.Name = "dataGrid_CT_HD_C_Ung";
			this.dataGrid_CT_HD_C_Ung.Size = new System.Drawing.Size(720, 288);
			this.dataGrid_CT_HD_C_Ung.TabIndex = 28;
			// 
			// Chi_Tiet_Hop_Dong_Cung_Ung
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 310);
			this.Controls.Add(this.dataGrid_CT_HD_C_Ung);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Chi_Tiet_Hop_Dong_Cung_Ung";
			this.Text = "Chi_Tiet_Hop_Dong_Cung_Ung";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Chi_Tiet_Hop_Dong_Cung_Ung_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_CT_HD_C_Ung)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		connet ket_noi = new connet();
		DataTable dtC_T_HD_CungUng = new DataTable();
		DataTable dtHang = new DataTable();
		DataTable dtSoHDongCUng = new DataTable();
		public int n=0;
		public void Load_Data_ChiTiet_HopDongCungUng()
		{		
			string sqlChiTietHopDongCungUng="select * from CT_HD_CungUng";
			dtC_T_HD_CungUng = ket_noi.getDataTable(sqlChiTietHopDongCungUng);
			
			string SqlHang ="select MaHang from HangHoa";
			dtHang = ket_noi.getDataTable(SqlHang);

			string SqlHDongCUng ="select SoHopDongCungUng from HopDongCungUng";
			dtSoHDongCUng = ket_noi.getDataTable(SqlHDongCUng);

			dataGrid_CT_HD_C_Ung.DataSource=dtC_T_HD_CungUng;//Dịnh vào Combo Box để đựa ra Text Box

			cmbSoHDong.DataSource=dtSoHDongCUng;
			cmbSoHDong.DisplayMember="SoHopDongCungUng";
			cmbSoHDong.ValueMember="SoHopDongCungUng";

			cmbMaHang.DataSource=dtHang;
			cmbMaHang.DisplayMember="MaHang";
			cmbMaHang.ValueMember="MaHang";

			txtSoHopDongMua.DataBindings.Clear();
			txtSoHopDongMua.DataBindings.Add("Text",dtC_T_HD_CungUng,"SoHopDongCungUng");

			txtSoLuong.DataBindings.Clear();
			txtSoLuong.DataBindings.Add("Text",dtC_T_HD_CungUng,"SoLuong");

			txtTriGia.DataBindings.Clear();
			txtTriGia.DataBindings.Add("Text",dtC_T_HD_CungUng,"TriGia");

			txtHeSo.DataBindings.Clear();
			txtHeSo.DataBindings.Add("Text",dtC_T_HD_CungUng,"HeSoGiam");

			txtTongGia.DataBindings.Clear();
			txtTongGia.DataBindings.Add("Text",dtC_T_HD_CungUng,"TongCong");
		}
		public void TongGia()
		{
			if(KiemTra.KiemTraSoNguyen(txtSoLuong))
			{
				if(KiemTra.KiemTraSoNguyen(txtTriGia))
				{
					if(KiemTra.KiemTraHeSoNguyen(txtHeSo))
					{
						if(txtSoLuong.Text!="" && txtHeSo.Text!="" && txtTriGia.Text!="")
						{
							try
							{
								txtTongGia.Text = Convert.ToString((float.Parse(txtSoLuong.Text)*float.Parse(txtTriGia.Text)-(float.Parse(txtHeSo.Text)*(float.Parse(txtSoLuong.Text)*float.Parse(txtTriGia.Text)))));
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
		public void MoPhim()
		{			
			cmbSoHDong.Enabled=false;
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
			cmbSoHDong.Enabled=true;
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
		public void Clear_FrChiTietHopDongCungUng()
		{
			txtTriGia.Clear();
			txtHeSo.Clear();
			txtSoLuong.Clear();
			txtTongGia.Clear();			
		}
		//Thêm Xóa Sửa
		public void Getinfor()
		{	
			ket_noi.CTBSoHD = cmbSoHDong.Text;
			ket_noi.CTBMaHang = cmbMaHang.Text;		
			ket_noi.CTBSoLuong = txtSoLuong.Text;	
			ket_noi.CTBHeSo = txtHeSo.Text;	
			ket_noi.CTBTriGia = txtTriGia.Text;		
			ket_noi.CTBTong = txtTongGia.Text;												
		}
		private int Sqlcommand(int mode,string SHDB,string MHang, string Luong, string Tien, string heSO, string Tong)
		{
			int i=0;
			try
			{						
				SqlCommand sqlcmd = new SqlCommand("Stor_ChiTietHopDongCungUng", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@SoHD",SqlDbType.NVarChar).Value= SHDB;
				sqlcmd.Parameters.Add("@MHang",SqlDbType.NVarChar).Value= MHang;
				sqlcmd.Parameters.Add("@SLuong",SqlDbType.NVarChar).Value=Luong;
				sqlcmd.Parameters.Add("@Tien",SqlDbType.NVarChar).Value=Tien;
				sqlcmd.Parameters.Add("@HeSo",SqlDbType.NVarChar).Value=heSO;
				sqlcmd.Parameters.Add("@TongGia",SqlDbType.NVarChar).Value=Tong;				
				
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
				if(KiemTra.kiemtraRong_ComBo(cmbSoHDong,"Số hợp đồng "))
				{
					if(KiemTra.kiemtraRong_ComBo(cmbMaHang,"Mã hợp đồng "))
					{
						string str="select * from CT_HD_CungUng  where SoHopDongCungUng='"+cmbSoHDong.Text+"'" ;
						if(KiemTra.kiemtraRong(txtTongGia,"Tổng giá "))
						{
							if(KiemTra.kiemtraRong(txtSoLuong,"Số lượng "))
							{								
								if(KiemTra.kiemtraHeSo(txtHeSo,"Hệ số 0.0 "))
								{
									if(KiemTra.kiemtraSo(txtTriGia,"Giá tiền "))
									{
										if(KiemTra.kiemtraSo(txtSoLuong,"Số lượng "))
										{
											if(Sqlcommand(1,ket_noi.CTBSoHD,ket_noi.CTBMaHang,ket_noi.CTBSoLuong,ket_noi.CTBTriGia, ket_noi.CTBHeSo, ket_noi.CTBTong)!=0)
											{						
												MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
											}			
											
												
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
				if(KiemTra.kiemtraRong(txtTongGia,"Tổng giá "))
				{
					if(KiemTra.kiemtraRong(txtSoLuong,"Số lượng "))
					{
						if(KiemTra.kiemtraHeSo(txtHeSo,"Hệ số 0.0 "))
						{
							if(KiemTra.kiemtraSo(txtTriGia,"Giá tiền "))
							{
								if(KiemTra.kiemtraSo(txtSoLuong,"Số lượng "))
								{
									
									if(Sqlcommand(0,ket_noi.CTBSoHD,ket_noi.CTBMaHang,ket_noi.CTBSoLuong,ket_noi.CTBTriGia, ket_noi.CTBHeSo, ket_noi.CTBTong)!=0)
									{
										MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
									
								}
							}
						}
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
				if(Sqlcommand(-1,ket_noi.CTBSoHD,ket_noi.CTBMaHang,ket_noi.CTBSoLuong,ket_noi.CTBTriGia, ket_noi.CTBHeSo, ket_noi.CTBTong)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_ChiTiet_HopDongCungUng();
				}
			}
		}

		private void btThem_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			Clear_FrChiTietHopDongCungUng();
			txtSoHopDongMua.Enabled=false;
			Active_Text();			
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
			cmbMaHang.Enabled=false;
			cmbSoHDong.Enabled=false;
			txtSoHopDongMua.Enabled=false;		
			Active_Text();
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			Load_Data_ChiTiet_HopDongCungUng();
			MoPhim();
			cmbMaHang.Enabled=true;
//			cmbSoHDong.Enabled=true;
			txtSoHopDongMua.Enabled=true;
		}

		private void btClear_Click(object sender, System.EventArgs e)
		{
			Clear_FrChiTietHopDongCungUng();
		}
		public void FirstRecord()
		{
			this.BindingContext[dtC_T_HD_CungUng].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtC_T_HD_CungUng].Position = dtC_T_HD_CungUng.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtC_T_HD_CungUng].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtC_T_HD_CungUng].Position -= 1;			
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

		public void Active_Text()//object sender, System.EventArgs e)
		{
			this.txtTriGia.TextChanged += new System.EventHandler(this.txtTriGia_TextChanged);
			this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
			this.txtHeSo.TextChanged += new System.EventHandler(this.txtHeSo_TextChanged);
		}

		private void txtTriGia_TextChanged(object sender, System.EventArgs e)
		{	
				TongGia();			
		}

		private void txtSoLuong_TextChanged(object sender, System.EventArgs e)
		{			
				TongGia();			
		}

		private void txtHeSo_TextChanged(object sender, System.EventArgs e)
		{
				TongGia();			
		}

		private void Chi_Tiet_Hop_Dong_Cung_Ung_Load(object sender, System.EventArgs e)
		{
//						txtSoHopDongMua.Enabled=false;
		}
	}
}
