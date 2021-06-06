using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Quan_Ly_Mua_Ban
{
	/// <summary>
	/// Summary description for CheckError.
	/// </summary>
	public class CheckError
	{
		connet ket_noi = new connet();
//		DataTable dt = new DataTable();
//		
		
		public CheckError()
		{
			
		}

		public bool KiemTraSoRong(TextBox txt)
		{
			bool SoRong = true;
			try
			{
				int x = int.Parse(txt.Text);
			}
			catch
			{
				SoRong = false;
				txt.Text="0";
			}
			return SoRong;
		}
		public bool KiemTraHeSoRong(TextBox txt)
		{
			bool HeSoRong = true;
			try
			{
				float x = float.Parse(txt.Text);
			}
			catch
			{
				HeSoRong = false;
				txt.Text="0.0";
			}
			return HeSoRong;
		}
		public bool KiemTraSoNguyen(TextBox txt)
		{
			bool so = true;
			try
			{
				int i = int.Parse(txt.Text);
			}
			catch
			{
				so = false;
			}
			return so;
		}
		public bool kiemtraSo(TextBox txt,string loi)
		{
			bool so = true;
			try
			{
				int i = int.Parse(txt.Text);
			}
			catch
			{
				so = false;
				MessageBox.Show(loi+" phải là số!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt.Text = "";
				txt.Focus();
			}
			return so;
		}
		public bool KiemTraThue(TextBox txt,string loi)
		{
			bool so = true;
			try
			{
				float i = float.Parse(txt.Text);
			}
			catch
			{
				so = false;
				MessageBox.Show(loi+" phải là số!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt.Text = "0.0";
				txt.Focus();
			}
			return so;
		}
		public bool KiemTraHeSoNguyen(TextBox txt)
		{
			bool so = true;
			try
			{
				float i = float.Parse(txt.Text);
			}
			catch
			{
				so = false;
			}
			return so;
		}
		public bool kiemtraHeSo(TextBox txt,string loi)
		{
			bool so = true;
			try
			{
				float i = float.Parse(txt.Text);
			}
			catch
			{
				so = false;
				MessageBox.Show(loi+" phải là số!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt.Text = "";
				txt.Focus();
			}
			return so;
		}
		public bool kiemtraTien(TextBox txt,string loi)
		{
			
			bool tien = true;
			try
			{
				float i = float.Parse(txt.Text);
			}
			catch
			{
				tien = false;
				MessageBox.Show(loi+" phải là số", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt.Text = "0";
				txt.Focus();
			}
			return tien;
		}
		public bool kiemtraTcong(ComboBox cbo,string sql)
		{
			bool co=true;
			DataSet ds=new DataSet();
			ds=ket_noi.getDataset(sql);
			if(ds.Tables[0].Rows.Count==0)
			{
				co=false;
			}
			return co;
		}
		
		public bool KiemKhongTonTai(TextBox txt)
		{
			bool khong = true;
			try
			{
					txt.Text="0";
			}
			catch
			{
				khong=false;
			}
			return khong;
		}

		public bool kiemtraTTai(ComboBox cbo,string loi,string sql)
		{
			bool co=true;
			DataSet ds=new DataSet();
			ds=ket_noi.getDataset(sql);
			if(ds.Tables[0].Rows.Count==0)
			{
				co=false;
				MessageBox.Show("Không tồn tại "+loi,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cbo.Text="";
				cbo.Focus();
			}
			return co;
		}

		
		public bool kiemtra_DaTonTai(ComboBox cbo,string loi,string sql)//
		{
				bool co=true;
				DataSet ds=new DataSet();
				ds=ket_noi.getDataset(sql);
				if(ds.Tables[0].Rows.Count!=0)
				{
					co=false;
					MessageBox.Show("Đã tồn tại "+loi,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					cbo.Focus();
				}
				return co;		
		}
		public bool ktRong(ComboBox cbo,string loi)
		{
			bool rong=true;
			if(cbo.Text.Trim()=="")
			{
				rong=false;
				MessageBox.Show("Bạn chưa nhập "+loi,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cbo.Focus();
			}
			return rong;
		}

		public bool kiemtraRong_ComBo(ComboBox cmb,string loi)
		{
			bool rong=true;
			if(cmb.Text.Trim()=="")
			{
				rong=false;
				MessageBox.Show("Bạn chưa nhập "+loi,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cmb.Focus();
			}
			return rong;
		}
		public bool kiemtraRong(TextBox txt,string loi)
		{
			bool rong=true;
			if(txt.Text.Trim()=="")
			{
				rong=false;
				MessageBox.Show("Bạn chưa nhập "+loi,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txt.Focus();
			}
			return rong;
		}
//		public bool KiemTraPass(TextBox txt,string loi)
//		{
//			bool pass=true;
//			if(txt.Text.Trim()!
//		}
	}
}
