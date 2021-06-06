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
	/// Summary description for Thong_ke_K_Hang.
	/// </summary>
	public class Nha_Cung_Ung : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSanPhamCungCap;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.TextBox txtSoDT;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.ComboBox cmMaNhom_CungUng;
		private System.Windows.Forms.Button btThemNhaCUng;
		private System.Windows.Forms.DataGrid dataGrid_CungUng;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.ComboBox cmbMa;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Nha_Cung_Ung()
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
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSanPhamCungCap = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btDau = new System.Windows.Forms.Button();
			this.cmbMa = new System.Windows.Forms.ComboBox();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btThemNhaCUng = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.cmMaNhom_CungUng = new System.Windows.Forms.ComboBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid_CungUng = new System.Windows.Forms.DataGrid();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_CungUng)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtSanPhamCungCap);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtGhiChu);
			this.panel1.Controls.Add(this.txtSoDT);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtMail);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtDiaChi);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btDau);
			this.panel1.Controls.Add(this.cmbMa);
			this.panel1.Controls.Add(this.btLui);
			this.panel1.Controls.Add(this.btToi);
			this.panel1.Controls.Add(this.btCuoi);
			this.panel1.Controls.Add(this.btThemNhaCUng);
			this.panel1.Controls.Add(this.btXoa);
			this.panel1.Controls.Add(this.btSua);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.btHuy);
			this.panel1.Controls.Add(this.cmMaNhom_CungUng);
			this.panel1.Controls.Add(this.txtTen);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(768, 200);
			this.panel1.TabIndex = 21;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.button1.Location = new System.Drawing.Point(288, 40);
			this.button1.Name = "button1";
			this.button1.TabIndex = 10;
			this.button1.Text = "&Thêm";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(448, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 24);
			this.label8.TabIndex = 51;
			this.label8.Text = "Sản Phẩm Cung Cấp:";
			// 
			// txtSanPhamCungCap
			// 
			this.txtSanPhamCungCap.Location = new System.Drawing.Point(448, 32);
			this.txtSanPhamCungCap.Multiline = true;
			this.txtSanPhamCungCap.Name = "txtSanPhamCungCap";
			this.txtSanPhamCungCap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSanPhamCungCap.Size = new System.Drawing.Size(312, 40);
			this.txtSanPhamCungCap.TabIndex = 6;
			this.txtSanPhamCungCap.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(392, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 49;
			this.label7.Text = "&Ghi Chú:";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(448, 80);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtGhiChu.Size = new System.Drawing.Size(312, 48);
			this.txtGhiChu.TabIndex = 7;
			this.txtGhiChu.Text = "";
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(112, 104);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(168, 20);
			this.txtSoDT.TabIndex = 4;
			this.txtSoDT.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Số Điện Thọai:";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(112, 136);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(168, 20);
			this.txtMail.TabIndex = 5;
			this.txtMail.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "E-Mail:";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(448, 136);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(312, 20);
			this.txtDiaChi.TabIndex = 8;
			this.txtDiaChi.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(392, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Địa Chỉ:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Mã Nhà Cung Ứng:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã Nhóm:";
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(104, 168);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 3;
			this.btDau.Text = "|<<";
			// 
			// cmbMa
			// 
			this.cmbMa.Location = new System.Drawing.Point(112, 8);
			this.cmbMa.Name = "cmbMa";
			this.cmbMa.Size = new System.Drawing.Size(168, 21);
			this.cmbMa.TabIndex = 1;
			this.cmbMa.Click += new System.EventHandler(this.cmbMa_Click);
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(152, 168);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 16;
			this.btLui.Text = "<";
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(200, 168);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 15;
			this.btToi.Text = ">";
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(248, 168);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 14;
			this.btCuoi.Text = ">>|";
			// 
			// btThemNhaCUng
			// 
			this.btThemNhaCUng.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btThemNhaCUng.Location = new System.Drawing.Point(288, 8);
			this.btThemNhaCUng.Name = "btThemNhaCUng";
			this.btThemNhaCUng.TabIndex = 9;
			this.btThemNhaCUng.Text = "&Thêm";
			this.btThemNhaCUng.Click += new System.EventHandler(this.btThemNhaCUng_Click);
			// 
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Location = new System.Drawing.Point(344, 168);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 11;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(432, 168);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 12;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(520, 168);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 13;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(608, 168);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 14;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// cmMaNhom_CungUng
			// 
			this.cmMaNhom_CungUng.Location = new System.Drawing.Point(112, 40);
			this.cmMaNhom_CungUng.Name = "cmMaNhom_CungUng";
			this.cmMaNhom_CungUng.Size = new System.Drawing.Size(168, 21);
			this.cmMaNhom_CungUng.TabIndex = 2;
			this.cmMaNhom_CungUng.Click += new System.EventHandler(this.cmMaNhom_CungUng_Click);
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(112, 72);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(168, 20);
			this.txtTen.TabIndex = 3;
			this.txtTen.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "Tên Nhà Cung Ứng:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 23);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nhà Cung Ứng.";
			// 
			// dataGrid_CungUng
			// 
			this.dataGrid_CungUng.DataMember = "";
			this.dataGrid_CungUng.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGrid_CungUng.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_CungUng.Location = new System.Drawing.Point(0, 134);
			this.dataGrid_CungUng.Name = "dataGrid_CungUng";
			this.dataGrid_CungUng.Size = new System.Drawing.Size(784, 224);
			this.dataGrid_CungUng.TabIndex = 22;
			// 
			// Nha_Cung_Ung
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(784, 358);
			this.Controls.Add(this.dataGrid_CungUng);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Nha_Cung_Ung";
			this.Text = "Thong_ke_Nha_Cung_Ung";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_CungUng)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Nhom_Nha_Cung_Ung NhaCUng = new Nhom_Nha_Cung_Ung();
			NhaCUng.Load_Data_NhaCungUng();
			NhaCUng.TatPhim();
			NhaCUng.ShowDialog();			
		}
		//Đổ Data vào DataGrid
		connet ket_noi = new connet();
		DataTable dtNhaCungUng = new DataTable();
		DataTable dtLoaiNhaCungUng = new DataTable();
		public int n=0;
		public void Load_Data_TKeNhaCungUng()
		{
		
			string sqlNhaCungUng="select * from NhaCungUng";
			dtNhaCungUng = ket_noi.getDataTable(sqlNhaCungUng);
			string SqlLoaiNhaCUng ="select MaLoai from LoaiNhaCungUng";
			dtLoaiNhaCungUng = ket_noi.getDataTable(SqlLoaiNhaCUng);

			dataGrid_CungUng.DataSource=dtNhaCungUng;//Dịnh vào Combo Box để đựa ra Text Box

			cmbMa.DataSource=dtNhaCungUng;
			cmbMa.DisplayMember="MaNhaCungUng";
			cmbMa.ValueMember="MaNhaCungUng";

			cmMaNhom_CungUng.DataSource=dtLoaiNhaCungUng;
			cmMaNhom_CungUng.DisplayMember="MaLoai";
			cmMaNhom_CungUng.ValueMember="MaLoai";

			txtTen.DataBindings.Clear();
			txtTen.DataBindings.Add("Text",dtNhaCungUng,"TenNhaCungUng");

			txtSoDT.DataBindings.Clear();
			txtSoDT.DataBindings.Add("Text",dtNhaCungUng,"SoDienThoai");

			txtMail.DataBindings.Clear();
			txtMail.DataBindings.Add("Text",dtNhaCungUng,"Mail");

			txtDiaChi.DataBindings.Clear();
			txtDiaChi.DataBindings.Add("Text",dtNhaCungUng,"DiaChi");

			txtSanPhamCungCap.DataBindings.Clear();
			txtSanPhamCungCap.DataBindings.Add("Text",dtNhaCungUng,"SanPhamCungCap");		

			txtGhiChu.DataBindings.Clear();
			txtGhiChu.DataBindings.Add("Text",dtNhaCungUng,"GhiChu");
		}
		public void MoPhim()
		{
			button1.Enabled=true;
			btDau.Enabled=true;
			btLui.Enabled=true;
			btToi.Enabled=true;
			btCuoi.Enabled=true;
			btThemNhaCUng.Enabled=true;
			btXoa.Enabled=true;
			btSua.Enabled=true;			
			btLuu.Enabled=false;
			btHuy.Enabled=false;
		}
		public void TatPhim()	
		{
			button1.Enabled=false;
			btDau.Enabled=false;
			btLui.Enabled=false;
			btToi.Enabled=false;
			btCuoi.Enabled=false;
			btThemNhaCUng.Enabled=false;
			btXoa.Enabled=false;
			btSua.Enabled=false;			
			btLuu.Enabled=true;
			btHuy.Enabled=true;
		}
		public void Clear_FrCungUng()
		{
			txtTen.Clear();
			txtGhiChu.Clear();
			txtMail.Clear();
			txtSoDT.Clear();
			txtDiaChi.Clear();
			txtSanPhamCungCap.Clear();
		}
		//Thêm Xóa Sửa
		public void Getinfor()
		{			
			ket_noi.MaCU = cmbMa.Text;		
			ket_noi.MaNhomCU = cmMaNhom_CungUng.Text;
			ket_noi.TenCU = txtTen.Text;			
			ket_noi.DTCU = txtSoDT.Text;	
			ket_noi.MailCU = txtMail.Text;	
			ket_noi.DChiCU = txtDiaChi.Text;	
			ket_noi.SanPhamCU = txtSanPhamCungCap.Text;	
			ket_noi.GhiChuCU = txtGhiChu.Text;	
		}
		private int Sqlcommand(int mode,string maCU, string maNhomCU, string HoTen, string DT, string Email, string Di_Chi, string SanPha, string Ghichu)
		{
			int i=0;
			try
			{	
				SqlCommand sqlcmd = new SqlCommand("Stor_NhaCungUng", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@Ma",SqlDbType.NVarChar).Value= maCU;
				sqlcmd.Parameters.Add("@MaNhom",SqlDbType.NVarChar).Value=maNhomCU;
				sqlcmd.Parameters.Add("@HoTen",SqlDbType.NVarChar).Value=HoTen;
				sqlcmd.Parameters.Add("@DT",SqlDbType.NVarChar).Value=DT;
				sqlcmd.Parameters.Add("@mail",SqlDbType.NVarChar).Value=Email;
				sqlcmd.Parameters.Add("@D_Chi",SqlDbType.NVarChar).Value=Di_Chi;
				sqlcmd.Parameters.Add("@SanPham",SqlDbType.NVarChar).Value=SanPha;
				sqlcmd.Parameters.Add("@GChu",SqlDbType.NVarChar).Value=Ghichu;
				i = sqlcmd.ExecuteNonQuery();			
			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			return i;
		}

		private void btThemNhaCUng_Click(object sender, System.EventArgs e)
		{
			n=1;
			TatPhim();
			Clear_FrCungUng();
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			Load_Data_TKeNhaCungUng();
		}
CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			Getinfor();
			
				string str="select * from NhaCungUng  where MaNhaCungUng='"+cmbMa.Text+"'" ;
				if(KiemTra.kiemtraRong(txtTen,"Tên Nhà Cung Ứng"))
				{
					if(KiemTra.kiemtraRong(txtSoDT,"Số Điện Thoại "))
					{
						if(KiemTra.kiemtra_DaTonTai(cmbMa,"Mã Nhà Cung Ứng ",str))
						{
							if(KiemTra.kiemtraSo(txtSoDT,"Số Điện Thoại "))
							{
								if(n==1)
								{
									if(Sqlcommand(1,ket_noi.MaCU,ket_noi.MaNhomCU,ket_noi.TenCU,ket_noi.DTCU, ket_noi.MailCU, ket_noi.DChiCU, ket_noi.SanPhamCU, ket_noi.GhiChuCU)!=0)
									{						
										MessageBox.Show("Bạn Đã Thêm Thàng Công!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}			
								}
								else
									if(n==2)
								{				
									if(Sqlcommand(0,ket_noi.MaCU,ket_noi.MaNhomCU,ket_noi.TenCU,ket_noi.DTCU, ket_noi.MailCU, ket_noi.DChiCU, ket_noi.SanPhamCU, ket_noi.GhiChuCU)!=0)
									{
										MessageBox.Show("Da cap nhat!!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
							}
						}	
					}		
				}
			
			
//			Load_Data_TKeNhaCungUng();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.MaCU,ket_noi.MaNhomCU,ket_noi.TenCU,ket_noi.DTCU, ket_noi.MailCU, ket_noi.DChiCU, ket_noi.SanPhamCU, ket_noi.GhiChuCU)!=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_TKeNhaCungUng();
				}
			}
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			TatPhim();
		}

		private void cmbMa_Click(object sender, System.EventArgs e)
		{
			Load_Data_TKeNhaCungUng();
		}

		private void cmMaNhom_CungUng_Click(object sender, System.EventArgs e)
		{
			Load_Data_TKeNhaCungUng();
		}

		
	}
}
