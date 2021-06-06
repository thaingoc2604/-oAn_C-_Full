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
	public class Loai_Hang_Hoa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btDau;
		private System.Windows.Forms.Button btLui;
		private System.Windows.Forms.Button btToi;
		private System.Windows.Forms.Button btCuoi;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Button btHuy;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		connet ket_noi = new connet();
		DataTable dtLoaiHang = new DataTable();

		
		private System.Windows.Forms.ComboBox cmbMaLoai;
		private System.Windows.Forms.TextBox txtHangSXuat;
		private System.Windows.Forms.TextBox txtTenLoai;
		public int n=0;


		public Loai_Hang_Hoa()
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtHangSXuat = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btDau = new System.Windows.Forms.Button();
			this.cmbMaLoai = new System.Windows.Forms.ComboBox();
			this.txtTenLoai = new System.Windows.Forms.TextBox();
			this.btLui = new System.Windows.Forms.Button();
			this.btToi = new System.Windows.Forms.Button();
			this.btCuoi = new System.Windows.Forms.Button();
			this.btThem = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btSua = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();
			this.btHuy = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loại Hàng.";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(104, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mã Hàng Loại:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Tên Loại:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Nhà Sản Xuất:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(104, 80);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 20);
			this.textBox3.TabIndex = 7;
			this.textBox3.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Nước Sản Xuất:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(104, 112);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(160, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtHangSXuat);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.btDau);
			this.panel1.Controls.Add(this.cmbMaLoai);
			this.panel1.Controls.Add(this.txtTenLoai);
			this.panel1.Controls.Add(this.btLui);
			this.panel1.Controls.Add(this.btToi);
			this.panel1.Controls.Add(this.btCuoi);
			this.panel1.Controls.Add(this.btThem);
			this.panel1.Controls.Add(this.btXoa);
			this.panel1.Controls.Add(this.btSua);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.btHuy);
			this.panel1.Location = new System.Drawing.Point(4, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 201);
			this.panel1.TabIndex = 18;
			// 
			// txtHangSXuat
			// 
			this.txtHangSXuat.Location = new System.Drawing.Point(104, 72);
			this.txtHangSXuat.Name = "txtHangSXuat";
			this.txtHangSXuat.Size = new System.Drawing.Size(168, 20);
			this.txtHangSXuat.TabIndex = 3;
			this.txtHangSXuat.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Tên Loại:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 5;
			this.label7.Text = "Mã Loại:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Hảng Sản Xuất:";
			// 
			// btDau
			// 
			this.btDau.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btDau.Location = new System.Drawing.Point(48, 104);
			this.btDau.Name = "btDau";
			this.btDau.Size = new System.Drawing.Size(32, 23);
			this.btDau.TabIndex = 3;
			this.btDau.Text = "|<<";
			this.btDau.Click += new System.EventHandler(this.btDau_Click);
			// 
			// cmbMaLoai
			// 
			this.cmbMaLoai.Location = new System.Drawing.Point(104, 8);
			this.cmbMaLoai.Name = "cmbMaLoai";
			this.cmbMaLoai.Size = new System.Drawing.Size(168, 21);
			this.cmbMaLoai.TabIndex = 1;
			// 
			// txtTenLoai
			// 
			this.txtTenLoai.Location = new System.Drawing.Point(104, 40);
			this.txtTenLoai.Name = "txtTenLoai";
			this.txtTenLoai.Size = new System.Drawing.Size(168, 20);
			this.txtTenLoai.TabIndex = 2;
			this.txtTenLoai.Text = "";
			// 
			// btLui
			// 
			this.btLui.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLui.Location = new System.Drawing.Point(96, 104);
			this.btLui.Name = "btLui";
			this.btLui.Size = new System.Drawing.Size(32, 23);
			this.btLui.TabIndex = 16;
			this.btLui.Text = "<";
			this.btLui.Click += new System.EventHandler(this.btLui_Click);
			// 
			// btToi
			// 
			this.btToi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btToi.Location = new System.Drawing.Point(144, 104);
			this.btToi.Name = "btToi";
			this.btToi.Size = new System.Drawing.Size(32, 23);
			this.btToi.TabIndex = 15;
			this.btToi.Text = ">";
			this.btToi.Click += new System.EventHandler(this.btToi_Click);
			// 
			// btCuoi
			// 
			this.btCuoi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btCuoi.Location = new System.Drawing.Point(192, 104);
			this.btCuoi.Name = "btCuoi";
			this.btCuoi.Size = new System.Drawing.Size(32, 23);
			this.btCuoi.TabIndex = 14;
			this.btCuoi.Text = ">>|";
			this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
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
			// btXoa
			// 
			this.btXoa.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btXoa.Location = new System.Drawing.Point(192, 168);
			this.btXoa.Name = "btXoa";
			this.btXoa.TabIndex = 6;
			this.btXoa.Text = "&Xóa";
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
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
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btLuu.Location = new System.Drawing.Point(56, 136);
			this.btLuu.Name = "btLuu";
			this.btLuu.TabIndex = 10;
			this.btLuu.Text = "&Lưu";
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// btHuy
			// 
			this.btHuy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btHuy.Location = new System.Drawing.Point(144, 136);
			this.btHuy.Name = "btHuy";
			this.btHuy.TabIndex = 9;
			this.btHuy.Text = "&Hủy";
			this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
			// 
			// Loai_Hang_Hoa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 246);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Loai_Hang_Hoa";
			this.Text = "Loai_Hang_Hoa";
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
			cmbMaLoai.Focus();
//			Load_Data_Loai_Hang();
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
			cmbMaLoai.Focus();
		}
		public void Clear_Text()
		{
			cmbMaLoai.Text="";
			txtTenLoai.Clear();
			txtHangSXuat.Clear();			
		}

		public void Load_Data_Loai_Hang()
		{
		
			string sqlLoaiHang="select * from LoaiHang";
			dtLoaiHang = ket_noi.getDataTable(sqlLoaiHang);

			cmbMaLoai.DataSource=dtLoaiHang;//Dịnh vào Combo Box để đựa ra Text Box
			cmbMaLoai.DisplayMember="MaLoaiHang";
			cmbMaLoai.ValueMember="MaLoaiHang";

			txtTenLoai.DataBindings.Clear();
			txtTenLoai.DataBindings.Add("Text",dtLoaiHang,"TenHang");
			txtHangSXuat.DataBindings.Clear();
			txtHangSXuat.DataBindings.Add("Text",dtLoaiHang,"HangSXuat");
		
		}
		public void Getinfor()
		{
			ket_noi.MaLoaiHang = cmbMaLoai.Text;
			ket_noi.TenLoai_Hang = txtTenLoai.Text;
			ket_noi.NhaSanXuat = txtHangSXuat.Text;			
		}
		private int Sqlcommand(int mode,string strMaLoai, string strTenLoai, string strNuoc)
		{
			int i=0;
			try
			{				
				SqlCommand sqlcmd = new SqlCommand("Stor_LoaiHang", ket_noi.getConnection);
				sqlcmd.CommandType = CommandType.StoredProcedure;
				sqlcmd.Parameters.Add("@mode",SqlDbType.NVarChar).Value= mode;
				sqlcmd.Parameters.Add("@MaLoai",SqlDbType.NVarChar).Value= strMaLoai;
				sqlcmd.Parameters.Add("@TenLoai",SqlDbType.NVarChar).Value= strTenLoai;
				sqlcmd.Parameters.Add("@Nuoc",SqlDbType.NVarChar).Value= strNuoc;
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
			this.BindingContext[dtLoaiHang].Position = 0;			
		}
		public void LastRecord()
		{
			this.BindingContext[dtLoaiHang].Position = dtLoaiHang.Rows.Count - 1;
	
		}
		public void NextRecord()
		{
			this.BindingContext[dtLoaiHang].Position += 1;			
		}
		public void PreviousRecord()
		{
			this.BindingContext[dtLoaiHang].Position -= 1;			
		}
		CheckError KiemTra = new CheckError();
		private void btLuu_Click(object sender, System.EventArgs e)
		{
			Getinfor();
			if(KiemTra.kiemtraRong_ComBo(cmbMaLoai,"Mã Lọai"))
			{
				string str="select * from LoaiHang  where MaLoaiHang='"+cmbMaLoai.Text+"'" ;
				if(KiemTra.kiemtraRong(txtTenLoai,"Tên Loai"))
				{
					if(KiemTra.kiemtraRong(txtHangSXuat,"Hãng sản xuất "))
					{
						if(KiemTra.kiemtra_DaTonTai(cmbMaLoai,"Mã Loại ",str))
						{
							if(n==1)
								{		
									if(Sqlcommand(1,ket_noi.MaLoaiHang,ket_noi.TenLoai_Hang,ket_noi.NhaSanXuat)!=0)
									{							
										MessageBox.Show("Da them xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}			
								}
								else
									if(n==2)
								{				
									if(Sqlcommand(0,ket_noi.MaLoaiHang,ket_noi.TenLoai_Hang,ket_noi.NhaSanXuat)!=0)
									{
										MessageBox.Show("Da cap nhat xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);			
									}
								}
							
						}	
					}		
				}
			}
			
//			Load_Data_Loai_Hang();
		}

		private void btThem_Click(object sender, System.EventArgs e)
		{
			n=1;
			Clear_Text();
			MoPhim();			
		}

		private void btSua_Click(object sender, System.EventArgs e)
		{
			n=2;
			MoPhim();
		}

		private void btHuy_Click(object sender, System.EventArgs e)
		{

			Load_Data_Loai_Hang();
			TatPhim();
		}

		private void btXoa_Click(object sender, System.EventArgs e)
		{
			DialogResult dlr = new DialogResult();
			dlr=MessageBox.Show("Bạn có chắn là xóa mẫu tin này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
			if(dlr==DialogResult.OK)
			{
				Getinfor();
				if(Sqlcommand(-1,ket_noi.MaLoaiHang,ket_noi.TenLoai_Hang,ket_noi.NhaSanXuat) !=0)
				{		
					MessageBox.Show("Da xoa xong roi !!!! ", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Load_Data_Loai_Hang();
				}
			}

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

		private void Loai_Hang_Hoa_Click(object sender, System.EventArgs e)
		{
			Thong_ke_Hang_Hoa HangHoa = new Thong_ke_Hang_Hoa();
			HangHoa.Load_Data_TKeMatHang();
		}

		private void Loai_Hang_Hoa_Closed(object sender, System.EventArgs e)
		{
			Thong_ke_Hang_Hoa HangHoa = new Thong_ke_Hang_Hoa();
			HangHoa.Load_Data_TKeMatHang();
			MoPhim();
			this.Close();
//			Load_Data_TKeMatHang();
		}
	}
}
