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
	/// Summary description for Luu_Tru_Hop_Dong_Mua.
	/// </summary>
	public class Luu_Tru_Hop_Dong_Mua : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtTongGia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNguoiNhap;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbSoHDong;
		private System.Windows.Forms.Button btLuuHopDong;
		private System.Windows.Forms.ComboBox cmMaKHang;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btXemNoiDung;
		private System.Windows.Forms.TextBox txtDiaChiHD;
		private System.Windows.Forms.TextBox txtNgayThanhLy;
		private System.Windows.Forms.TextBox txtNgayHetHang;
		private System.Windows.Forms.TextBox txtNgayKy;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btDong;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid_HDMua;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Luu_Tru_Hop_Dong_Mua()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Luu_Tru_Hop_Dong_Mua));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtTongGia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNguoiNhap = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSoHDong = new System.Windows.Forms.ComboBox();
			this.btLuuHopDong = new System.Windows.Forms.Button();
			this.cmMaKHang = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btXemNoiDung = new System.Windows.Forms.Button();
			this.txtDiaChiHD = new System.Windows.Forms.TextBox();
			this.txtNgayThanhLy = new System.Windows.Forms.TextBox();
			this.txtNgayHetHang = new System.Windows.Forms.TextBox();
			this.txtNgayKy = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btDong = new System.Windows.Forms.Button();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btDau = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGrid_HDMua = new System.Windows.Forms.DataGrid();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_HDMua)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtTongGia);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtNguoiNhap);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cmbSoHDong);
			this.panel1.Controls.Add(this.btLuuHopDong);
			this.panel1.Controls.Add(this.cmMaKHang);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.btXemNoiDung);
			this.panel1.Controls.Add(this.txtDiaChiHD);
			this.panel1.Controls.Add(this.txtNgayThanhLy);
			this.panel1.Controls.Add(this.txtNgayHetHang);
			this.panel1.Controls.Add(this.txtNgayKy);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button5);
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(648, 176);
			this.panel1.TabIndex = 25;
			// 
			// txtTongGia
			// 
			this.txtTongGia.Location = new System.Drawing.Point(112, 112);
			this.txtTongGia.Name = "txtTongGia";
			this.txtTongGia.ReadOnly = true;
			this.txtTongGia.Size = new System.Drawing.Size(168, 20);
			this.txtTongGia.TabIndex = 25;
			this.txtTongGia.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 23);
			this.label1.TabIndex = 26;
			this.label1.Text = "Trị Giá Hợp Đồng:";
			// 
			// txtNguoiNhap
			// 
			this.txtNguoiNhap.Location = new System.Drawing.Point(112, 80);
			this.txtNguoiNhap.Name = "txtNguoiNhap";
			this.txtNguoiNhap.Size = new System.Drawing.Size(168, 20);
			this.txtNguoiNhap.TabIndex = 4;
			this.txtNguoiNhap.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Người Ký:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(376, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Ngày Ký:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Số Hợp Đồng";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã Khách Hàng";
			// 
			// cmbSoHDong
			// 
			this.cmbSoHDong.Location = new System.Drawing.Point(112, 16);
			this.cmbSoHDong.Name = "cmbSoHDong";
			this.cmbSoHDong.Size = new System.Drawing.Size(168, 21);
			this.cmbSoHDong.TabIndex = 1;
			// 
			// btLuuHopDong
			// 
			this.btLuuHopDong.BackColor = System.Drawing.Color.Thistle;
			this.btLuuHopDong.Location = new System.Drawing.Point(336, 144);
			this.btLuuHopDong.Name = "btLuuHopDong";
			this.btLuuHopDong.Size = new System.Drawing.Size(88, 23);
			this.btLuuHopDong.TabIndex = 8;
			this.btLuuHopDong.Text = "&Lưu Hợp Đồng";
			this.btLuuHopDong.Click += new System.EventHandler(this.btLuuHopDong_Click);
			// 
			// cmMaKHang
			// 
			this.cmMaKHang.Location = new System.Drawing.Point(112, 48);
			this.cmMaKHang.Name = "cmMaKHang";
			this.cmMaKHang.Size = new System.Drawing.Size(168, 21);
			this.cmMaKHang.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(376, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Ngày Thanh Lý:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(376, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Ngày Hết Hạng:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(376, 112);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "Nội Dung:";
			// 
			// btXemNoiDung
			// 
			this.btXemNoiDung.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXemNoiDung.Location = new System.Drawing.Point(464, 144);
			this.btXemNoiDung.Name = "btXemNoiDung";
			this.btXemNoiDung.Size = new System.Drawing.Size(120, 23);
			this.btXemNoiDung.TabIndex = 12;
			this.btXemNoiDung.Text = "Nội Dung Hợp Đồng";
			this.btXemNoiDung.Click += new System.EventHandler(this.btXemNoiDung_Click);
			// 
			// txtDiaChiHD
			// 
			this.txtDiaChiHD.Location = new System.Drawing.Point(464, 112);
			this.txtDiaChiHD.Name = "txtDiaChiHD";
			this.txtDiaChiHD.Size = new System.Drawing.Size(168, 20);
			this.txtDiaChiHD.TabIndex = 4;
			this.txtDiaChiHD.Text = "";
			// 
			// txtNgayThanhLy
			// 
			this.txtNgayThanhLy.Location = new System.Drawing.Point(464, 80);
			this.txtNgayThanhLy.Name = "txtNgayThanhLy";
			this.txtNgayThanhLy.Size = new System.Drawing.Size(168, 20);
			this.txtNgayThanhLy.TabIndex = 4;
			this.txtNgayThanhLy.Text = "";
			// 
			// txtNgayHetHang
			// 
			this.txtNgayHetHang.Location = new System.Drawing.Point(464, 48);
			this.txtNgayHetHang.Name = "txtNgayHetHang";
			this.txtNgayHetHang.Size = new System.Drawing.Size(168, 20);
			this.txtNgayHetHang.TabIndex = 4;
			this.txtNgayHetHang.Text = "";
			// 
			// txtNgayKy
			// 
			this.txtNgayKy.Location = new System.Drawing.Point(464, 16);
			this.txtNgayKy.Name = "txtNgayKy";
			this.txtNgayKy.Size = new System.Drawing.Size(168, 20);
			this.txtNgayKy.TabIndex = 4;
			this.txtNgayKy.Text = "";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button2.Location = new System.Drawing.Point(152, 144);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 23);
			this.button2.TabIndex = 29;
			this.button2.Text = "<";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button3.Location = new System.Drawing.Point(200, 144);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(32, 23);
			this.button3.TabIndex = 28;
			this.button3.Text = ">";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button4.Location = new System.Drawing.Point(248, 144);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(32, 23);
			this.button4.TabIndex = 27;
			this.button4.Text = ">>|";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button5.Location = new System.Drawing.Point(104, 144);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(32, 23);
			this.button5.TabIndex = 26;
			this.button5.Text = "|<<";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(256, 32);
			this.label9.TabIndex = 26;
			this.label9.Text = "Lưu Trữ Hợp Đồng Mua:";
			// 
			// btDong
			// 
			this.btDong.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDong.Location = new System.Drawing.Point(288, 224);
			this.btDong.Name = "btDong";
			this.btDong.TabIndex = 29;
			this.btDong.Text = "&Đóng";
			this.btDong.Click += new System.EventHandler(this.btDong_Click);
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(56, 224);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 32;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(104, 224);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 31;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(152, 224);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 30;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(8, 224);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 27;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button1.Location = new System.Drawing.Point(200, 224);
			this.button1.Name = "button1";
			this.button1.TabIndex = 28;
			this.button1.Text = "&Xóa";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGrid_HDMua
			// 
			this.dataGrid_HDMua.DataMember = "";
			this.dataGrid_HDMua.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGrid_HDMua.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_HDMua.Location = new System.Drawing.Point(0, 142);
			this.dataGrid_HDMua.Name = "dataGrid_HDMua";
			this.dataGrid_HDMua.Size = new System.Drawing.Size(688, 208);
			this.dataGrid_HDMua.TabIndex = 33;
			// 
			// Luu_Tru_Hop_Dong_Mua
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 350);
			this.Controls.Add(this.dataGrid_HDMua);
			this.Controls.Add(this.btDong);
			this.Controls.Add(this.btLui);
			this.Controls.Add(this.btToi);
			this.Controls.Add(this.btCuoi);
			this.Controls.Add(this.btDau);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Luu_Tru_Hop_Dong_Mua";
			this.Text = "Luu_Tru_Hop_Dong_Mua";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Luu_Tru_Hop_Dong_Mua_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_HDMua)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		connet ket_noi = new connet();
		DataTable dtLuuHopDongMua = new DataTable();
		DataTable dtLuuHDMua  = new DataTable();
		private void btXemNoiDung_Click(object sender, System.EventArgs e)
		{
			if(KiemTra.kiemtraRong(txtDiaChiHD,"Địa chỉ hợp đồng"))
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
		public void GhiVaoDB()
		{
			Getinfor();
			if(KiemTra.kiemtraRong_ComBo(cmbSoHDong,"Mã hợp đồng "))
			{
				string str="select * from LuuTruHopDongMua  where SoHopDongMua='"+cmbSoHDong.Text+"'" ;
				if(KiemTra.kiemtraRong(txtNguoiNhap,"Người Ký "))
				{						
					if(KiemTra.kiemtra_DaTonTai(cmbSoHDong,"Số hợp đồng ",str))
					{									
						if(Sqlcommand(1,ket_noi.LSoHD,ket_noi.LMaKH,ket_noi.LTongCong, ket_noi.LNguoiKy, ket_noi.LNgayKy, ket_noi.LNgayHH, ket_noi.LNgayThanhLy, ket_noi.LNoiDung)!=0)
						{						
							MessageBox.Show("Đã Lưu Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}			
									
					}	
				}
			}
			Load_FormLuuHDMua();
		}
		public void Getinfor()
		{
			ket_noi.LSoHD=cmbSoHDong.Text;
			ket_noi.LMaKH=cmMaKHang.Text;
			ket_noi.LNguoiKy=txtNguoiNhap.Text;
			ket_noi.LTongCong=txtTongGia.Text;
			ket_noi.LNgayHH=txtNgayHetHang.Text;
			ket_noi.LNgayKy=txtNgayKy.Text;
			ket_noi.LNgayThanhLy=txtNgayThanhLy.Text;
			ket_noi.LNoiDung=txtDiaChiHD.Text;
		}
		private int Sqlcommand(int mode,string SHDB, string MaKH, string Tong, string NguoiKy, string NgayKy, string NgayHet, string NgayThanhL, string NoiDung)
		{
			int i=0;
			try
			{						
				SqlCommand sqlcmd = new SqlCommand("Stor_LuuTruHopDongMua", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;				
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@SoHD",SqlDbType.NVarChar).Value= SHDB;
				sqlcmd.Parameters.Add("@MaKH",SqlDbType.NVarChar).Value=MaKH;
				sqlcmd.Parameters.Add("@TongCong",SqlDbType.NVarChar).Value=Tong;
				sqlcmd.Parameters.Add("@NguoiKy",SqlDbType.NVarChar).Value=NguoiKy;				
				sqlcmd.Parameters.Add("@NgayKy",SqlDbType.NVarChar).Value=NgayKy;	
				sqlcmd.Parameters.Add("@NgayHHang",SqlDbType.NVarChar).Value=NgayHet;	
				sqlcmd.Parameters.Add("@NgayTLy",SqlDbType.NVarChar).Value=NgayThanhL;	
				sqlcmd.Parameters.Add("@NoiDung",SqlDbType.NVarChar).Value=NoiDung;
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}
		CheckError KiemTra = new CheckError();
		public void Load_FormLuuHDMua()
		{
			string strLuuHDMua="select * from LuuTruHopDongMua";
			dtLuuHDMua=ket_noi.getDataTable(strLuuHDMua);
			dataGrid_HDMua.DataSource=dtLuuHDMua;
		}
		public void Load_LuuHDMua()
		{
			string sqlLuuHopDongMua="select * from VIEWLuuHDMua";
			dtLuuHopDongMua = ket_noi.getDataTable(sqlLuuHopDongMua);

			cmbSoHDong.DataSource=dtLuuHopDongMua;
			cmbSoHDong.DisplayMember="SoHD";
			cmbSoHDong.ValueMember="SoHD";

			cmMaKHang.DataSource=dtLuuHopDongMua;
			cmMaKHang.DisplayMember="MaNCU";
			cmMaKHang.ValueMember="MaNCU";

			txtNgayKy.DataBindings.Clear();
			txtNgayKy.DataBindings.Add("Text",dtLuuHopDongMua,"NgayKy");

			txtNgayHetHang.DataBindings.Clear();
			txtNgayHetHang.DataBindings.Add("Text",dtLuuHopDongMua,"NgayHetHang");

			txtNgayThanhLy.DataBindings.Clear();
			txtNgayThanhLy.DataBindings.Add("Text",dtLuuHopDongMua,"NgayThanhLy");

			txtNguoiNhap.DataBindings.Clear();
			txtNguoiNhap.DataBindings.Add("Text",dtLuuHopDongMua,"NguoiKy");

			txtTongGia.DataBindings.Clear();
			txtTongGia.DataBindings.Add("Text",dtLuuHopDongMua,"TongCong");

			txtDiaChiHD.DataBindings.Clear();
			txtDiaChiHD.DataBindings.Add("Text",dtLuuHopDongMua,"NoiDung");
		}
		
		private void Luu_Tru_Hop_Dong_Mua_Load(object sender, System.EventArgs e)
		{
			Load_FormLuuHDMua();
			Load_LuuHDMua();
		}

		private void btLuuHopDong_Click(object sender, System.EventArgs e)
		{
			GhiVaoDB();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				try
				{
					if(Sqlcommand(-1,ket_noi.LSoHD,ket_noi.LMaKH,ket_noi.LTongCong, ket_noi.LNguoiKy, ket_noi.LNgayKy, ket_noi.LNgayHH, ket_noi.LNgayThanhLy, ket_noi.LNoiDung)!=0)
					{		
						MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Load_FormLuuHDMua();
					}
				}
				catch
				{
					MessageBox.Show("Bạn không được xóa hợp đồng này!!!! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void btDong_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		public void FirstRecord()
		{
			this.BindingContext[dtLuuHopDongMua].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtLuuHopDongMua].Position = dtLuuHopDongMua.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtLuuHopDongMua].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtLuuHopDongMua].Position -= 1;			
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			FirstRecord();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			PreviousRecord();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			NextRecord();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			LastRecord();
		}
		public void FirstRecordOut()
		{
			this.BindingContext[dtLuuHDMua].Position = 0;			
		}
		public void LastRecordOut()
		{
			this.BindingContext[dtLuuHDMua].Position = dtLuuHDMua.Rows.Count - 1;
	
		}
		public void NextRecordOut()
		{
			this.BindingContext[dtLuuHDMua].Position += 1;			
		}
		public void PreviousRecordOut()
		{
			this.BindingContext[dtLuuHDMua].Position -= 1;			
		}

		private void btDau_Click(object sender, System.EventArgs e)
		{
			FirstRecordOut();
		}

		private void btLui_Click(object sender, System.EventArgs e)
		{
			PreviousRecordOut();
		}

		private void btToi_Click(object sender, System.EventArgs e)
		{
			NextRecordOut();
		}

		private void btCuoi_Click(object sender, System.EventArgs e)
		{
			LastRecordOut();
		}
	}
}
