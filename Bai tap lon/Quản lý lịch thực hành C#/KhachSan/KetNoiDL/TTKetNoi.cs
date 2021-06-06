using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace KetNoiDL
{
    public class TTKetNoi
    {
        OleDbConnection con = new OleDbConnection();

        public TTKetNoi()
        {
            string s = "Provider=Microsoft.jet.oledb.4.0;data source=KhachSan.mdb";
            con.ConnectionString = s;
            con.Open();
        }

        public DataSet getBang(string s)
        {
            DataSet ds = new DataSet();
            string sql = "select * from " + s;
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, s);

            return ds;
        }


        public OleDbDataReader getDataReader(string TenBang)
        {
            string sql = "select * from " + TenBang;
            OleDbCommand comd = new OleDbCommand(sql, con);
            return comd.ExecuteReader();
        }


        public DataView getDataView(string tenbang)
        {
            DataView dv = new DataView();
            dv.Table = getBang(tenbang).Tables[0];
            return dv;
        }


        public DataView getChiTietPhong(string maP)
        {
            DataSet ds = new DataSet();
            string sql = "select ThietBi.MaTB,Ten,SoLuong,HangSX,Gia from ChiTietPhong,ThietBi where ChiTietPhong.MaTB=ThietBi.MaTB and MaPhong='" + maP +"'";

            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, "CTP");

            DataView view = new DataView();
            view.Table = ds.Tables[0];
            return view;
        }

        #region HangPhong
        public bool KiemTraHangPhong(string hangphong)//false: trùng || true: Không Trùng
        {
            DataSet ds = new DataSet();
            string sql = "select * from HangPhong where LoaiPhong='"+ hangphong +"'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }

        public void ThemHangPhong(string hangphong,double gia)
        {
            string sql = "insert into HangPhong(LoaiPhong,DonGia) values('"+hangphong+"',"+gia+")";
            OleDbCommand com = new OleDbCommand(sql,con);
            com.ExecuteNonQuery();
        }

        public void XoaHangPhong(string hangphong)
        {
            string sql = "delete * from HangPhong where LoaiPhong='"+hangphong+"'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void UpdateHangPhong(string hangphong, string dongia)
        {
            string sql = "update HangPhong set DonGia='"+dongia+"' where LoaiPhong='" + hangphong + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }
        #endregion HangPhong

        #region ThietBi
        public bool KiemTraMaTB(string maTB)//false: trùng || true: Không Trùng
        {
            DataSet ds = new DataSet();
            string sql = "select * from ThietBi where MaTB='" + maTB + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }

        public void ThemThietBi(string maTB, string ten,string hangsx,double gia)
        {
            string sql = "insert into ThietBi values('" + maTB + "','" + ten + "','" + hangsx + "'," + gia + ")";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void XoaThietBi(string matb)
        {
            string sql = "delete * from ThietBi where MaTB='" + matb + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void UpdateThietBi(string matb, string ten,string hangsx,string gia)
        {
            string sql = "update ThietBi set Ten='" + ten + "', HangSX='"+ hangsx +"', Gia='"+gia+"' where MaTB='" + matb + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }
        #endregion ThietBi

        #region KhachHang
        public bool KTmaKH(string makh)
        {
            string sql = "select * from KhachHang where MaKH='"+makh+"'";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }

        

        public void ThemKhachHang(string maKH, string ten, string cmnd, string sodt, string diachi)
        {
            string sql = "insert into KhachHang values('" + maKH + "','" + ten + "','" + cmnd + "','" + sodt + "','" + diachi + "')";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void XoaKhachHang(string makh)
        {
            string sql = "delete * from KhachHang where MaKH='" + makh + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void UpdateKhachHang(string makh, string ten, string cmnd, string sodt,string dc)
        {
            string sql = "update KhachHang set TenKH='" + ten + "', SoCMND='" + cmnd + "', SoDT='" + sodt + "', DiaChi='" +dc+ "' where MaKH='" + makh + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        #endregion KhachHang
        public bool KTCTHD(string maHD)
        {
            string sql = "select * from ChiTietHD where MaHD='" + maHD + "'";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }

        public bool KTmaHD(string maHD)
        {
            string sql = "select * from HoaDon where MaHD='" + maHD + "'";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }
        public DataView getDSPhong()
        {
            string sql = "select MaPhong,LoaiPhong,TinhTrang from Phong where TinhTrang=true";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);

            DataSet tb = new DataSet();
            da.Fill(tb);

            DataView dv = new DataView();
            dv.Table=tb.Tables[0];

            return dv;
        }

        public DataRow getDonGia(string loaip)
        {
            string sql = "select * from HangPhong where LoaiPhong='"+loaip+"'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);

            DataSet tb = new DataSet();
            da.Fill(tb);

            DataRow dr = tb.Tables[0].Rows[0];

            return dr;
        }

        public void ThemHoaDon(string maHD, string ngayThue, string ngayTra)
        {
            string sql = "insert into HoaDon(MaHD,NgayThue,NgayTra) values('" + maHD + "','" + ngayThue + "','" + ngayTra + "')";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void ThemHoaDon(string maHD, string ngayThue)
        {
            string sql = "insert into HoaDon(MaHD,NgayThue) values('" + maHD + "','" + ngayThue + "')";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void ThemChiTietHoaDon(string maHD, string makh, string maphong)
        {
            string sql = "insert into ChiTietHD(MaHD,MaKH,MaPhong) values('" + maHD + "','" + makh + "','" + maphong + "')";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public bool KiemTraMaPhong(string map)//false: trùng || true: Không Trùng
        {
            DataSet ds = new DataSet();
            string sql = "select * from Phong where MaPhong='" + map + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }

        public void ThemPhong(string map, string loaip, int songuoi, bool tinhtrang)
        {
            string sql = "insert into Phong values('" + map + "','" + loaip + "'," + songuoi + "," + tinhtrang + ")";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void XoaPhong(string map)
        {
            string sql = "delete * from Phong where MaPhong='" + map + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void UpdatePhong(string map, string loaip, int songuoi, bool tinhtrang)
        {
            string sql = "update Phong set LoaiPhong='" + loaip + "', SoNguoi=" + songuoi + ", TinhTrang=" + tinhtrang + " where MaPhong='" + map + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void UpdatePhong(string map, bool tinhtrang)
        {
            string sql = "update Phong set TinhTrang=" + tinhtrang + " where MaPhong='" + map + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public void UpdateCTHoaDon(string mahd, DateTime ngaytra)
        {
            string sql = "update HoaDon set NgayTra=#" + ngaytra + "# where MaHD='" + mahd + "'";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.ExecuteNonQuery();
        }

        public bool KiemTraNV(string MaNV,string pass)
        {
            DataSet ds = new DataSet();
            string sql = "select * from NhanVien where TenNV='" + MaNV + "' and Pass='" + pass + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }

        public bool KTHoaDon(string mahd)
        {
            DataSet ds = new DataSet();
            string sql = "select * from HoaDon where MaHD='" + mahd + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }

        public bool KTCTHoaDon(string mahd,string map,string makh)
        {
            DataSet ds = new DataSet();
            string sql = "select * from ChiTietHD where MaHD='" + mahd + "' and MaKH='" + mahd + "' and MaPhong='" + map + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }

        public bool KTHDTT(string mahd)
        {
            DataSet ds = new DataSet();
            string sql = "select * from HoaDon where NgayTra is null and MaHD='" + mahd + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                return false;
            return true;
        }
    }
}
