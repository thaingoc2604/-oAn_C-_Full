using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class PhongBanData
    {
        DataService ds = new DataService();
        public DataTable LayTTPhongBan()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM PhongBan");
                ds.Load(cmd);
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy thông tin phòng ban không thành công." + e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        //public DataTable LayDSPhongBan(string MaPhong)
        //{
        //    //try
        //    //{
        //    //    OleDbCommand cmd = new OleDbCommand("SELECT nv.MA_NV as MA_NV, nv.Ho +' '+nv.Ten AS HO_TEN, nv.GIOI_TINH as GIOI_TINH, nv.NGAY_SINH as NGAY_SINH, nv.QUE_QUAN as QUE_QUAN, cv.TEN_CHUC_VU as TEN_CHUC_VU, nv.SO_CMND as SO_CMND, nv.DI_DONG as DI_DONG " +
        //    //         " FROM Nhan_Vien AS nv, PhongBan AS pb, CHUC_VU cv " +
        //    //         "WHERE nv.MA_CHUC_VU = cv.MA_CHUC_VU and nv.MA_PHONG = pb.ma_Phong AND pb.MA_PHONG=@ma");
        //    //    cmd.Parameters.Add("@ma", OleDbType.VarChar).Value = maPhong;
        //    //    ds.Load(cmd);
        //    //    return ds;
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    MessageBox.Show("Lấy thông tin phòng ban không thành công." + e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    return null;
        //    //}
        //}

        //public void Update()
        //{
        //    ds.Update();
        //}


        //************************* Them Phong Ban***************
        //public BusinessObject.Error ThemPhongBan(BusinessObject.PhongBanInfo PhongBan)
        //{
        //    OleDbCommand cmd = new OleDbCommand("insert into PhongBan  values(@maphong,@tenphong)");
        //    cmd.Parameters.Add("maphong", OleDbType.Char).Value = PhongBan.MaPhongBan;
        //    cmd.Parameters.Add("tenphong", OleDbType.VarChar).Value = PhongBan.TenPhongBan;
        //    return ds.ExecuteNonQuery(cmd);
        //}
        ////*************************Xoa Phong Ban****************************
        //public BusinessObject.Error XoaPhongBan(BusinessObject.PhongBanInfo PhongBan)
        //{
        //    OleDbCommand cmd = new OleDbCommand("delete from PhongBan where MaPhong=@maphong");
        //    cmd.Parameters.Add("maphong", OleDbType.Char).Value = PhongBan.MaPhongBan;
        //    return ds.ExecuteNonQuery(cmd);
        //}
        //public BusinessObject.Error CapNhatPhongBan(BusinessObject.PhongBanInfo PhongBan)
        //{
        //    OleDbCommand cmd = new OleDbCommand("update PhongBan set TenPhong=@tenphong where MaPhong=@maphong");
        //    cmd.Parameters.Add("tenphong", OleDbType.VarChar).Value = PhongBan.TenPhongBan;
        //    cmd.Parameters.Add("maphong", OleDbType.Char).Value = PhongBan.MaPhongBan;
        //    return ds.ExecuteNonQuery(cmd);
        //}
    }
}



