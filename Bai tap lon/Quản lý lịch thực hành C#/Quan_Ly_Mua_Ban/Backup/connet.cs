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
	/// Summary description for connet.
	/// </summary>
	public class connet
	{
		private string str_Connection ="server=.;database=QuanLyMuaBan;uid=sa;pwd= ;integrated security=SSPI;Connect Timeout=5";
		public SqlConnection con;
		public DataTable dt=new DataTable();
		string mMaNhom, mTenNhom, mHeSoGiam, mMaLoaiHang, mTenLoaiHangHoa, mHangSXuat,
			mMaNhaCUng, mTenNhaCUng,mTenLoaiHang,
			//Form Khách Hàng
			mMaKhachhang, mMaNhomKH, mHoTenKhachang, mDiaChi, mDT, mEmail, mGhiChu,
			//Form Nhà Cung Ứng
			CU_Ma, CU_MaNhom, CU_Ten, CU_SoDT, CU_Mail, CU_DiaChi,CU_SanPham, CU_GChu,
			//Form Hàng Hóa
			HHMa, HHLoai, HHTenHang, HHGiaBan, HHSoLuong, HHTon, HHMoTa, HHHinh, HHTenHinh,
			//Form Phiếu Thu
			mSoHoDongban, mSoPhieuThu, mTien, mTienDaNop, mNgayNop, mNguoiNop, mTienCon,
			//Form Hợp Đồng Bán
			mSoHDongB, mMaKHang, mGiatri, mNguoiNhap, mNgayKy, mNgayHetHang, mNgayThanhLy,mNoiDung,mStrMaHD,
			//Form Giá
			mNgay, mMaHang,mGiaMua, mGiaBan, mThue,			
			//From Chi tiết Hợp đồng bán , mua
			mSoHDBan, mMaHangHoa, mSoLuong, mTriGia, mCTHeSoGiam, mTongGia, mLuongHienTai,
			//From Quản Trị chương trình
			mUserName, mPass, mPower, mChucDanh, mHoTen,
			//Tìm Kiếm
			mString,
			//Lưu Hợp Đồng
			lSoHD, lMaKH, lTongC, lNguoiKy, lNgayKy, lNgayHH, lNgayTL, lNoiDung
			;
//		long ;
		//Giá Bán
//		string ;
		bool  
			//Form Quản trị
			mAdmin, mNV, mKhach;

		public connet()
		{		
			if(TestConnection()==false)
			{
				MessageBox.Show("Chương trình cần SQL Server mới có thể chạy được!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				Application.Exit();
			}
			else
			{
				OpenConnection();
			}
		}
		public void OpenConnection()
		{				
			
					con = new SqlConnection(str_Connection);
					if(con.State == ConnectionState.Closed)
						con.Open();				
					
		}
		public bool TestConnection()
		{
			ConnectSQL msgSQL = new ConnectSQL();
			msgSQL.Show("Connecting to SQL Server...");

			SqlConnection test_Con = new SqlConnection(str_Connection);
			try
			{
				test_Con.Open();
				//MessageBox.Show("Đã kết nối được với SQL Server 'banhang'","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
				test_Con.Close();
				msgSQL.Close();
				return true;
			}
			catch
			{
//				MessageBox.Show("Không kết nối được với SQL Server!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					Application.Exit();
						return false;	
			}
		}

		public SqlConnection getConnection
		{
			get{return con;}
		}
		public DataSet getDataset(string str)
		{
			SqlDataAdapter da=new SqlDataAdapter(str,con);
			DataSet ds=new DataSet();
			da.Fill(ds);
			return ds;
		}
		public DataTable getDataTable(string sql) 
		{
			SqlDataAdapter da = new SqlDataAdapter(sql, getConnection);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}

		//Property
		//Tìm kiếm
		public string TimString
		{
			get			{return mString;}
			set			{mString = value;}
		}
		//Nhóm Khách Hàng
		public string MaNhom
		{
			get			{return mMaNhom;}
			set			{mMaNhom = value;}
		}
		public string TenNhom
		{
			get			{return mTenNhom;}
			set			{mTenNhom = value;}
		}
		public string HeSoGiam
		{
			get			{return mHeSoGiam;}
			set			{mHeSoGiam = value;}
		}

		//Nhà Cung Ứng
		public string MaNhaCUng
		{
			get			{return mMaNhaCUng;}
			set			{mMaNhaCUng = value;}
		}
		public string TenNhaCUng
		{
			get			{return mTenNhaCUng;}
			set			{mTenNhaCUng = value;}
		}
		public string TenLoaiHang_CungUng
		{
			get			{return mTenLoaiHang;}
			set			{mTenLoaiHang = value;}
		}
		//Loại Hànng Hóa
		public string MaLoaiHang
		{
			get			{return mMaLoaiHang;}
			set			{mMaLoaiHang = value;}
		}
		public string TenLoai_Hang
		{
			get			{return mTenLoaiHangHoa;}
			set			{mTenLoaiHangHoa = value;}
		}
		public string NhaSanXuat
		{
			get			{return mHangSXuat;}
			set			{mHangSXuat = value;}
		}
		
		//Property của Form Khách hàng
		public string MaKhachHang
		{
			get			{return mMaKhachhang;}
			set			{mMaKhachhang = value;}
		}
		public string MaNhomKhachHang
		{
			get			{return mMaNhomKH;}
			set			{mMaNhomKH = value;}
		}
		public string HoTenKhachHang
		{
			get			{return mHoTenKhachang;}
			set			{mHoTenKhachang = value;}
		}
		public string DiaChi
		{
			get			{return mDiaChi;}
			set			{mDiaChi = value;}
		}
		public string SDT
		{
			get			{return mDT;}
			set			{mDT = value;}
		}
		public string EMail
		{
			get			{return mEmail;}
			set			{mEmail = value;}
		}
		public string GhiCh
		{
			get			{return mGhiChu;}
			set			{mGhiChu = value;}
		}
		// //Form Nhà Cung Ứng
		public string MaCU
		{
			get			{return CU_Ma;}
			set			{CU_Ma = value;}
		}
		public string MaNhomCU
		{
			get			{return CU_MaNhom;}
			set			{CU_MaNhom = value;}
		}
		public string TenCU
		{
			get			{return CU_Ten;}
			set			{CU_Ten = value;}
		}
		public string DTCU
		{
			get			{return CU_SoDT;}
			set			{CU_SoDT = value;}
		}
		public string MailCU
		{
			get			{return CU_Mail;}
			set			{CU_Mail = value;}
		}
		public string DChiCU
		{
			get			{return CU_DiaChi;}
			set			{CU_DiaChi = value;}
		}
		public string SanPhamCU
		{
			get			{return CU_SanPham;}
			set			{CU_SanPham = value;}
		}
		public string GhiChuCU
		{
			get			{return CU_GChu;}
			set			{CU_GChu = value;}
		}
		//Form Hàng Hóa	
		public string MaHH
		{
			get			{return HHMa;}
			set			{HHMa = value;}
		}
		public string LoaiHH
		{
			get			{return HHLoai;}
			set			{HHLoai = value;}
		}
		public string TenHangHH
		{
			get			{return HHTenHang;}
			set			{HHTenHang = value;}
		}
//		public string TriGiaHH
//		{
//			get			{return HHTriGia;}
//			set			{HHTriGia = value;}
//		}
		public string GiaBanHH
		{
			get			{return HHGiaBan;}
			set			{HHGiaBan = value;}
		}
		public string SoLuongHH
		{
			get			{return HHSoLuong;}
			set			{HHSoLuong = value;}
		}
		public string TonHH
		{
			get			{return HHTon;}
			set			{HHTon = value;}
		}
		public string MoTaHH
		{
			get			{return HHMoTa;}
			set			{HHMoTa = value;}
		}
		public string HinhHH
		{
			get			{return HHHinh;}
			set			{HHHinh = value;}
		}
		public string TenHinhHH
		{
			get			{return HHTenHinh;}
			set			{HHTenHinh = value;}
		}
		//Form Phiếu Thu
		public string PTSoHopDongBan
		{
			get			{return mSoHoDongban;}
			set			{mSoHoDongban = value;}
		}
		public string PTSoPhieu
		{
			get			{return mSoPhieuThu;}
			set			{mSoPhieuThu = value;}
		}
		public string PTTien
		{
			get			{return mTien;}
			set			{mTien = value;}
		}
		public string PTTienDaNop
		{
			get			{return mTienDaNop;}
			set			{mTienDaNop = value;}
		}
		public string PTNgayNop
		{
			get			{return mNgayNop;}
			set			{mNgayNop = value;}
		}
		public string PTNguoiNop
		{
			get			{return mNguoiNop;}
			set			{mNguoiNop = value;}
		}
		public string PTTCon
		{
			get			{return mTienCon;}
			set			{mTienCon = value;}
		}
		//Form Hợp Đồng Bán
		public string HBSo
		{
			get			{return mSoHDongB;}
			set			{mSoHDongB = value;}
		}		
		public string HBMaKHang
		{
			get			{return mMaKHang;}
			set			{mMaKHang = value;}
		}
		public string HBGia
		{
			get			{return mGiatri;}
			set			{mGiatri = value;}
		}
		public string HBNguoiNhap
		{
			get			{return mNguoiNhap;}
			set			{mNguoiNhap = value;}
		}
		public string HBNgayKy
		{
			get			{return mNgayKy;}
			set			{mNgayKy = value;}
		}
		public string HBNgayHetHang
		{
			get			{return mNgayHetHang;}
			set			{mNgayHetHang = value;}
		}
		public string HBNgayThanhLy
		{
			get			{return mNgayThanhLy;}
			set			{mNgayThanhLy = value;}		
		}
		public string HBNoiDung
		{
			get			{return mNoiDung;}
			set			{mNoiDung = value;}
		}
		public string HBmaKH
		{
			get			{return mStrMaHD;}
			set			{mStrMaHD = value;}
		}
		//Giá
		public string GNgay
		{
			get			{return mNgay;}
			set			{mNgay = value;}
		}
		public string GMaHang
		{
			get			{return mMaHang;}
			set			{mMaHang = value;}
		}
		public string GGiaMua
		{
			get			{return mGiaMua;}
			set			{mGiaMua = value;}
		}
		public string GGiaBan
		{
			get			{return mGiaBan;}
			set			{mGiaBan = value;}
		}
		public string GThue
		{
			get			{return mThue;}
			set			{mThue = value;}
		}
		//Form Chi Tiết Hợp Đồng Bán
		public string CTBSoHD
		{
			get			{return mSoHDBan;}
			set			{mSoHDBan = value;}
		}
		public string CTBMaHang
		{
			get			{return mMaHangHoa;}
			set			{mMaHangHoa = value;}
		}
		public string CTBSoLuong
		{
			get			{return mSoLuong;}
			set			{mSoLuong = value;}
		}
		public string CTBLuongTon
		{
			get			{return mLuongHienTai;}
			set			{mLuongHienTai = value;}
		}
		public string CTBTriGia
		{
			get			{return mTriGia;}
			set			{mTriGia = value;}
		}
		public string CTBHeSo
		{
			get			{return mCTHeSoGiam;}
			set			{mCTHeSoGiam = value;}
		}
		public string CTBTong
		{
			get			{return mTongGia;}
			set			{mTongGia = value;}
		}
		//From Quản trị
		public string QTUser
		{
			get			{return mUserName;}
			set			{mUserName = value;}
		}
		public string QTPass
		{
			get			{return mPass;}
			set			{mPass = value;}
		}
		public string QTPower
		{
			get			{return mPower;}
			set			{mPower = value;}
		}
		public bool QTAdmin
		{
			get			{return mAdmin;}
			set			{mAdmin = value;}
		}
		public bool QTNV
		{
			get			{return mNV;}
			set			{mNV = value;}
		}
		public bool QTKhach
		{
			get			{return mKhach;}
			set			{mKhach = value;}
		}
		public string QTChucDanh
		{
			get			{return mChucDanh;}
			set			{mChucDanh = value;}
		}
		public string QTHoTen
		{
			get			{return mHoTen;}
			set			{mHoTen = value;}
		}
//Lưu Trữ Hợp Đồng 
		public string LSoHD
		{
			get			{return lSoHD;}
			set			{lSoHD = value;}
		}
		public string LMaKH
		{
			get			{return lMaKH;}
			set			{lMaKH = value;}
		}
		public string LTongCong
		{
			get			{return lTongC;}
			set			{lTongC = value;}
		}
		public string LNguoiKy
		{
			get			{return lNguoiKy;}
			set			{lNguoiKy = value;}
		}        
		public string LNgayKy
		{
			get			{return lNgayKy;}
			set			{lNgayKy = value;}
		}
		public string LNgayHH
		{
			get			{return lNgayHH;}
			set			{lNgayHH = value;}
		}
		public string LNgayThanhLy
		{
			get			{return lNgayTL;}
			set			{lNgayTL = value;}
		}
		public string LNoiDung
		{
			get			{return lNoiDung;}
			set			{lNoiDung = value;}
		}
		//lSoHD, lMaKH, lTongC, lNguoiKy, lNgayKy, lNgayHH, lNgayTL, lNoiDung
	}
}
