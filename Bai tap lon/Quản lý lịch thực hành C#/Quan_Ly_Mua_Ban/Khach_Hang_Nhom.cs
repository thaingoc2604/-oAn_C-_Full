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
	/// Summary description for Khach_Hang_Nhom.
	/// </summary>
	public class Khach_Hang_Nhom : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenNhom;
		private System.Windows.Forms.ComboBox cmbMaNhom;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.TextBox txtHeSo;
		private System.Windows.Forms.Button btHuy;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		connet ket_noi = new connet();
		DataTable dtMaNhom = new DataTable();
		public int n=0;

		public Khach_Hang_Nhom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Khach_Hang_Nhom));
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenNhom = new System.Windows.Forms.TextBox();
			this.cmbMaNhom = new System.Windows.Forms.ComboBox();
			this.btDau = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtHeSo = new System.Windows.Forms.TextBox();
			this.btHuy = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btThem = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btLui = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhóm Khách Hàng";
			// 
			// txtTenNhom
			// 
			this.txtTenNhom.Location = new System.Drawing.Point(104, 40);
			this.txtTenNhom.Name = "txtTenNhom";
			this.txtTenNhom.Size = new System.Drawing.Size(168, 20);
			this.txtTenNhom.TabIndex = 2;
			this.txtTenNhom.Text = "";
			// 
			// cmbMaNhom
			// 
			this.cmbMaNhom.Location = new System.Drawing.Point(104, 8);
			this.cmbMaNhom.Name = "cmbMaNhom";
			this.cmbMaNhom.Size = new System.Drawing.Size(168, 21);
			this.cmbMaNhom.TabIndex = 1;
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(48, 104);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 7;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Hệ số giảm giá:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Mã Nhóm:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Tên Nhóm:";
			// 
			// txtHeSo
			// 
			this.txtHeSo.Location = new System.Drawing.Point(104, 72);
			this.txtHeSo.Name = "txtHeSo";
			this.txtHeSo.Size = new System.Drawing.Size(168, 20);
			this.txtHeSo.TabIndex = 3;
			this.txtHeSo.Text = "";
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(144, 136);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 12;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(56, 136);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 11;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btSua
			// 
			this.btSua.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btSua.Location = new System.Drawing.Point(104, 168);
			this.btSua.Name = "btSua";
			this.btSua.TabIndex = 5;
			this.btSua.Text = "&Sửa";
			this.btSua.Click += new System.EventHandler(this.btSua_Click);
			// 
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Location = new System.Drawing.Point(192, 168);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 6;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// btThem
			// 
			this.btThem.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btThem.Location = new System.Drawing.Point(16, 168);
			this.btThem.Name = "btThem";
			this.btThem.TabIndex = 4;
			this.btThem.Text = "&Thêm";
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(192, 104);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 10;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(144, 104);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 9;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(96, 104);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 8;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtHeSo);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btDau);
			this.panel1.Controls.Add(this.cmbMaNhom);
			this.panel1.Controls.Add(this.txtTenNhom);
			this.panel1.Controls.Add(this.btLui);
			this.panel1.Controls.Add(this.btToi);
			this.panel1.Controls.Add(this.btCuoi);
			this.panel1.Controls.Add(this.btThem);
			this.panel1.Controls.Add(this.btXoa);
			this.panel1.Controls.Add(this.btSua);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.btHuy);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 200);
			this.panel1.TabIndex = 17;
			// 
			// Khach_Hang_Nhom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 246);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Khach_Hang_Nhom";
			this.Text = "Nhom Khach Hang";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

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
			cmbMaNhom.Focus();
			Load_Data_NhomKH();
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
			cmbMaNhom.Focus();
		}
		//Kiểm tra lỗi
		
		public void ClearForm()
		{
			cmbMaNhom.Text="";
			txtHeSo.Clear();
			txtTenNhom.Clear();			
		}

		private void btThem_Click(object sender, System.EventArgs e)
		{
			n=1;
			MoPhim();
			ClearForm();
			cmbMaNhom.SendToBack();								
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			MoPhim();			
			Load_Data_NhomKH();					
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{
			TatPhim();
		}
		public void Load_Data_NhomKH()
		{
		
				string sqlNhomKH="select * from NhomKhachHang";
				dtMaNhom = ket_noi.getDataTable(sqlNhomKH);

				cmbMaNhom.DataSource=dtMaNhom;//Dịnh vào Combo Box để đựa ra Text Box
				cmbMaNhom.DisplayMember="MaNhomKH";
				cmbMaNhom.ValueMember="MaNhomKH";

				txtTenNhom.DataBindings.Clear();
				txtTenNhom.DataBindings.Add("Text",dtMaNhom,"TenNhomKH");
				txtHeSo.DataBindings.Clear();
				txtHeSo.DataBindings.Add("Text",dtMaNhom,"HeSoGiam");
		
		}
		public void Getinfor()
		{			
			ket_noi.MaNhom = cmbMaNhom.Text;		
			ket_noi.TenNhom = txtTenNhom.Text;
			ket_noi.HeSoGiam = txtHeSo.Text;			
		}
		private int Sqlcommand(int mode,string maNhom, string TenNhom, string HeSo)
		{
			int i=0;
			try
			{				
				SqlCommand sqlcmd = new SqlCommand("NhomKH", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@MaNhom",SqlDbType.NVarChar).Value= maNhom;
				sqlcmd.Parameters.Add("@TenNhom",SqlDbType.NVarChar).Value=TenNhom;
				sqlcmd.Parameters.Add("@HeSo",SqlDbType.NVarChar).Value=HeSo;
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
			if(KiemTra.kiemtraRong_ComBo(cmbMaNhom,"Mã Nhóm"))
			{
				string str="select * from NhomKhachHang  where MaNhomKH='"+cmbMaNhom.Text+"'" ;
				if(KiemTra.kiemtraRong(txtTenNhom,"Tên Nhóm"))
				{
					if(KiemTra.kiemtraRong(txtHeSo,"Hệ số "))
					{
						if(KiemTra.kiemtra_DaTonTai(cmbMaNhom,"Mã Nhóm ",str))
						{
							if(KiemTra.kiemtraHeSo(txtHeSo,"Hệ số "))
							{
								if(n==1)
								{
									if(Sqlcommand(1,ket_noi.MaNhom,ket_noi.TenNhom,ket_noi.HeSoGiam)!=0)
									{						
										MessageBox.Show("Da them xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}			
								}
								else
									if(n==2)
								{				
									if(Sqlcommand(0,ket_noi.MaNhom,ket_noi.TenNhom,ket_noi.HeSoGiam)!=0)
									{
										MessageBox.Show("Da cap nhat xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
							}
						}	
					}		
				}
			}
//			Load_Data_NhomKH();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.MaNhom,ket_noi.TenNhom,ket_noi.HeSoGiam) !=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_NhomKH();
				}
			}
		}

		public void FirstRecord()
		{
			this.BindingContext[dtMaNhom].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtMaNhom].Position = dtMaNhom.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtMaNhom].Position += 1;
			
			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtMaNhom].Position -= 1;			
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
		
	}
}
