using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DETAI
{
    class clsdieudong
    {
        public SqlConnection sc = frmMain.me.libsql.getCon();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        //lấy dữ liệu theo mã nhân viên
        public DataSet laydl(string ma)
        {
            ds.Clear();
            string sel_ = "select * from tbl_QuaTrinhDieuDong where manv ='"+ma+"'";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "DieuDong");
            sc.Close();
            return ds;
        }
        //2 phương thức thêm có mã tổ và không có mã tổ
        public void them(string soqd, string manv, DateTime ngayqd, int macvcu,
                         string  mapbcu, string  matocu,int macvmoi,
                         string  mapbmoi, string matomoi, string ghichu)
        {
            
                mysql.ExecuteNonQuery("insert_tbl_QuaTrinhDieuDong",
                                    CommandType.StoredProcedure,
                                    "@SoQD_1", soqd,
                                    "@MaNV_2", manv,
                                    "@ngayqd_3", ngayqd,
                                    "@MaCVcu_4", macvcu,
                                    "@MaPBCu_5", mapbcu,
                                    "@MaTocu_6", matocu,
                                    "@MaCVmoi_7", macvmoi,
                                    "@MaPBmoi_8", mapbmoi,
                                    "@MaTomoi_9", matomoi,
                                    "@GhiChu_10", ghichu);
           
        }
        public void them(string soqd, string manv, DateTime ngayqd,
                            int macvcu, string mapbcu, string matocu,
                            int macvmoi, string mapbmoi, string ghichu)
        {

            mysql.ExecuteNonQuery("insert_tbl_QuaTrinhDieuDong_koTo",
                                CommandType.StoredProcedure,
                                "@SoQD_1", soqd,
                                "@MaNV_2", manv,
                                "@ngayqd_3", ngayqd,
                                "@MaCVcu_4", macvcu,
                                "@MaPBCu_5", mapbcu,
                                "@MaTocu_6", matocu,
                                "@MaCVmoi_7", macvmoi,
                                "@MaPBmoi_8", mapbmoi,
                                "@GhiChu_9", ghichu);
                               

        }
        //xóa
        public void xoa(string soqd)
        {
                mysql.ExecuteNonQuery("delete_tbl_QuaTrinhDieuDong",
                                        CommandType.StoredProcedure,
                                        "@SoQD_1",soqd);
  
        }
        //cập nhật
        public void sua(string soqd, string manv, DateTime ngayqd,
                        int macvcu, string mapbcu, string matocu,
                        int macvmoi, string mapbmoi, string matomoi,
                        string ghichu)
        {
                mysql.ExecuteNonQuery("update_tbl_QuaTrinhDieuDong",
                                    CommandType.StoredProcedure,
                                    "@SoQD_1", soqd,
                                    "@MaNV_2", manv,
                                    "@ngayqd_3", ngayqd,
                                    "@MaCVcu_4", macvcu,
                                    "@MaPBCu_5", mapbcu,
                                    "@MaTocu_6", matocu,
                                    "@MaCVmoi_7", macvmoi,
                                    "@MaPBmoi_8", mapbmoi,
                                    "@MaTomoi_9", matomoi,
                                    "@GhiChu_10", ghichu);
  
        }
 
    }
}
