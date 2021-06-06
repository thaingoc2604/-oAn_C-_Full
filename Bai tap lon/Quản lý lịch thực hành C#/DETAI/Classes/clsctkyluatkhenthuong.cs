using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DETAI
{
    class clsctkyluatkhenthuong
    {
        public SqlConnection sc = frmMain.me.libsql.getCon();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds1 = new DataSet();
        public DataSet ds2 = new DataSet();
        //lấy dữ liệu theo mã nhân viên
        public DataSet laydl(string manv)
        {
            ds.Clear();
            string sel_ = "select * "
            + "from tbl_CTKhenThuongKyLuat a inner join tbl_DMkhenthuongkyluat b on"+
            " b.maloai =a.maloai"+
            " where a.MaNV ='" + manv + "'";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "NV_KLKT");
            sc.Close();
            return ds;
        }
        //xóa
        public void xoa(string soqd)
        {
            mysql.ExecuteNonQuery("delete_tbl_CTKhenThuongKyLuat", CommandType.StoredProcedure,
                                    "@SoQD_1", soqd);
        }
        //thêm
        public void them(string soqd, DateTime ngayqd, string manv, int maloai, string noidung, string hinhthuc, int sotien, string ghichu)
        {
            mysql.ExecuteNonQuery("insert_tbl_CTKhenThuongKyLuat", CommandType.StoredProcedure,
                                    "@SoQD_1", soqd,
                                    "@NgayQD_2",ngayqd,
                                    "@MaNV_3",manv,
                                    "@MaLoai_4",maloai,
                                    "@NoiDung_5",noidung,
                                    "@HinhThuc_6",hinhthuc,
                                    "@mucthuongphat_7",sotien,
                                    "@ghichu_8",ghichu);
        }
        //cập nhật
        public void sua(string soqd, DateTime ngayqd, string manv, int maloai, string noidung, string hinhthuc, int sotien, string ghichu)
        {
            mysql.ExecuteNonQuery("update_tbl_CTKhenThuongKyLuat", CommandType.StoredProcedure,
                                    "@SoQD_1", soqd,
                                    "@NgayQD_2", ngayqd,
                                    "@MaNV_3", manv,
                                    "@MaLoai_4", maloai,
                                    "@NoiDung_5", noidung,
                                    "@HinhThuc_6", hinhthuc,
                                    "@mucthuongphat_7", sotien,
                                    "@ghichu_8", ghichu);
        }
        //lấy dữ liệu để tạo combobox
        public DataSet layloai()
        {
            ds1.Clear();
             string sel_ = "select * "
            + "from tbl_DMKhenThuongKyLuat";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds1, "DMKTKL");
            sc.Close();
            return ds1;
        }
    }
}
