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
	/// Summary description for Chi_Tiet_K_Hang.
	/// </summary>
	public class Nhom_Nha_Cung_Ung : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaNhaC_Ung;
		private System.Windows.Forms.TextBox txtTenNhaC_Ung;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTenLoaiHang;
		private System.Windows.Forms.ComboBox cmbMaNhaCUng;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Nhom_Nha_Cung_Ung()
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
			this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTenNhaC_Ung = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btDau = new System.Windows.Forms.Button();
			this.cmbMaNhaCUng = new System.Windows.Forms.ComboBox();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btThem = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.txtMaNhaC_Ung = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtTenLoaiHang);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtTenNhaC_Ung);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btDau);
			this.panel1.Controls.Add(this.cmbMaNhaCUng);
			this.panel1.Controls.Add(this.btLui);
			this.panel1.Controls.Add(this.btToi);
			this.panel1.Controls.Add(this.btCuoi);
			this.panel1.Controls.Add(this.btThem);
			this.panel1.Controls.Add(this.btXoa);
			this.panel1.Controls.Add(this.btSua);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.btHuy);
			this.panel1.Controls.Add(this.txtMaNhaC_Ung);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(290, 199);
			this.panel1.TabIndex = 19;
			// 
			// txtTenLoaiHang
			// 
			this.txtTenLoaiHang.Location = new System.Drawing.Point(112, 72);
			this.txtTenLoaiHang.Name = "txtTenLoaiHang";
			this.txtTenLoaiHang.Size = new System.Drawing.Size(168, 20);
			this.txtTenLoaiHang.TabIndex = 3;
			this.txtTenLoaiHang.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Tên Loại Hàng:";
			// 
			// txtTenNhaC_Ung
			// 
			this.txtTenNhaC_Ung.Location = new System.Drawing.Point(112, 40);
			this.txtTenNhaC_Ung.Name = "txtTenNhaC_Ung";
			this.txtTenNhaC_Ung.Size = new System.Drawing.Size(168, 20);
			this.txtTenNhaC_Ung.TabIndex = 2;
			this.txtTenNhaC_Ung.Text = "";
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
			this.label2.Text = "Tên Nhà Cung Ứng:";
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(56, 104);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 3;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// cmbMaNhaCUng
			// 
			this.cmbMaNhaCUng.Location = new System.Drawing.Point(112, 8);
			this.cmbMaNhaCUng.Name = "cmbMaNhaCUng";
			this.cmbMaNhaCUng.Size = new System.Drawing.Size(168, 21);
			this.cmbMaNhaCUng.TabIndex = 1;
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(104, 104);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 16;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(152, 104);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 15;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(200, 104);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 14;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btThem
			// 
			this.btThem.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btThem.Location = new System.Drawing.Point(24, 168);
			this.btThem.Name = "btThem";
			this.btThem.TabIndex = 4;
			this.btThem.Text = "&Thêm";
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Location = new System.Drawing.Point(200, 168);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 6;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(112, 168);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 5;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(64, 136);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 10;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(152, 136);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 9;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// txtMaNhaC_Ung
			// 
			this.txtMaNhaC_Ung.Location = new System.Drawing.Point(112, 8);
			this.txtMaNhaC_Ung.Name = "txtMaNhaC_Ung";
			this.txtMaNhaC_Ung.Size = new System.Drawing.Size(168, 20);
			this.txtMaNhaC_Ung.TabIndex = 17;
			this.txtMaNhaC_Ung.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Nhóm Nhà Cung Ứng.";
			// 
			// Nhom_Nha_Cung_Ung
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 246);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Nhom_Nha_Cung_Ung";
			this.Text = "Nhom_Nha_Cung_Ung";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		connet ket_noi = new connet();
		DataTable dtLoaiCUng = new DataTable();
		public int n=0;

		public void Load_Data_NhaCungUng()
		{		
			string sqlLoaiNhaCUng="select * from Loainhacungung";
			dtLoaiCUng = ket_noi.getDataTable(sqlLoaiNhaCUng);

			cmbMaNhaCUng.DataSource=dtLoaiCUng;//Dịnh vào Combo Box để đựa ra Text Box
			cmbMaNhaCUng.DisplayMember="MaLoai";
			cmbMaNhaCUng.ValueMember="MaLoai";				

			txtTenNhaC_Ung.DataBindings.Clear();
			txtTenNhaC_Ung.DataBindings.Add("Text",dtLoaiCUng,"TenNhaCungUng");
			txtTenLoaiHang.DataBindings.Clear();
			txtTenLoaiHang.DataBindings.Add("Text",dtLoaiCUng,"TenLoaiHang");		
		
		}
		public void TatPhim()
		{
			btLuu.Enabled = false;
			btHuy.Enabled = false;
			btThem.Enabled = true;
			btXoa.Enabled = true;
			btSua.Enabled = true;
			btCuoi.Enabled = true;
			btLui.Enabled = true;
			btToi.Enabled = true;
			btDau.Enabled = true;
			cmbMaNhaCUng.Focus();
		}
		public void MoPhim()
		{
			btLuu.Enabled = true;
			btHuy.Enabled = true;
			btThem.Enabled = false;
			btXoa.Enabled = false;
			btSua.Enabled = false;
			btCuoi.Enabled = false;
			btLui.Enabled = false;
			btToi.Enabled = false;
			btDau.Enabled = false;						
			cmbMaNhaCUng.Focus();
		}

		public void Getinfor()
		{
			ket_noi.MaNhaCUng = cmbMaNhaCUng.Text;
			ket_noi.TenNhaCUng = txtTenNhaC_Ung.Text;
			ket_noi.TenLoaiHang_CungUng = txtTenLoaiHang.Text;
			
		}
		private int Sqlcommand(int mode,string maLoai, string TenNhom, string Hang)
		{
			int i=0;
			try
			{				
				SqlCommand sqlcmd = new SqlCommand("LoaiNhaCungUng_Stor", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@MaLoai",SqlDbType.NVarChar,10).Value= maLoai;
				sqlcmd.Parameters.Add("@TenLoai",SqlDbType.NVarChar,30).Value=TenNhom;
				sqlcmd.Parameters.Add("@LoaiHang",SqlDbType.NVarChar,35).Value= Hang;
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
			if(KiemTra.kiemtraRong_ComBo(cmbMaNhaCUng,"Mã Nhà Cung Ứng "))
			{
				string str="select * from LoaiNhaCungUng  where MaLoai='"+cmbMaNhaCUng.Text+"'" ;
				if(KiemTra.kiemtraRong(txtTenNhaC_Ung,"Tên Nhà Cung Ứng "))
				{
					if(KiemTra.kiemtraRong(txtTenLoaiHang,"Tên Loại Hàng "))
					{
						if(KiemTra.kiemtra_DaTonTai(cmbMaNhaCUng,"Mã Nhà Cung Ứng ",str))
						{						
								if(n==1)
								{		
									if(Sqlcommand(1,ket_noi.MaNhaCUng,ket_noi.TenNhaCUng,ket_noi.TenLoaiHang_CungUng)!=0)
									{							
										MessageBox.Show("Da them xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}			
								}
								else
									if(n==2)
								{				
									if(Sqlcommand(0,ket_noi.MaNhaCUng,ket_noi.TenNhaCUng,ket_noi.TenLoaiHang_CungUng)!=0)
									{
										MessageBox.Show("Da cap nhat xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
									}
								}
							
						}	
					}		
				}
			}
			
//					Load_Data_NhaCungUng();
		}

		private void btThem_Click(object sender, System.EventArgs e)
		{
			MoPhim();
			txtTenNhaC_Ung.Clear();
			txtTenLoaiHang.Clear();
			cmbMaNhaCUng.Focus();
			n=1;
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			MoPhim();
			cmbMaNhaCUng.Focus();			
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			TatPhim();
			Load_Data_NhaCungUng();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.MaNhaCUng,ket_noi.TenNhaCUng,ket_noi.TenLoaiHang_CungUng) !=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_NhaCungUng();
				}
			}
		}
		public void FirstRecord()
		{
			this.BindingContext[dtLoaiCUng].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtLoaiCUng].Position = dtLoaiCUng.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtLoaiCUng].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtLoaiCUng].Position -= 1;			
		}


		private void btLui_Click(object sender, System.EventArgs e)
		{
			PreviousRecord();
		}

		private void btDau_Click(object sender, System.EventArgs e)
		{
			FirstRecord();
		}

		private void btToi_Click(object sender, System.EventArgs e)
		{
			NextRecord();
		}

		private void btCuoi_Click(object sender, System.EventArgs e)
		{
			LastRecord();
		}

	}
}
