using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using QLHSTPTTHSP.Initiation;
using QLHSTPTTHSP.BusinessObjects;

namespace QLHSTPTTHSP.DataLayer
{
    public class ToChuyenMonData
    {
        MySqlCommand mySqlCommand;
        DataServices dataServices = new DataServices();
        /// <summary>
        /// Lấy bảng Tổ chuyên môn
        /// </summary>
        /// <returns>Bảng</returns>
        public DataTable LayBangToChuyenMon()
        {
            mySqlCommand = new MySqlCommand("select * from to_chuyen_mon;");
            dataServices.Load(mySqlCommand);
            return dataServices;
        }

        /// <summary>
        /// Lấy một cột trong bảng 
        /// </summary>
        /// <param name="fieldName">tên trường cần lấy</param>
        /// <returns>Một cột thuộc bảng </returns>
        public DataTable LayBangToChuyenMon(string fieldName)
        {
            mySqlCommand = new MySqlCommand("select " + fieldName + " from to_chuyen_mon;");
            dataServices.Load(mySqlCommand);
            return dataServices;
        }
        /// <summary>
        /// Tạo ra 1 dòng mới từ bảng to_chuyen_mon
        /// </summary>
        /// <returns></returns>
        public DataRow ThemDongMoi()
        {
            return dataServices.NewRow();
        }
        /// <summary>
        /// Thêm 1 dòng vào bảng
        /// </summary>
        /// <param name="row"></param>
        public void ThemToChuyenMon(DataRow row)
        {
            dataServices.Rows.Add(row);
        }
        /// <summary>
        /// Lấy bảng Chi tiết tổ chuyên môn dựa vào mã tổ chuyên môn
        /// </summary>
        /// <returns>Bảng</returns>
        public DataTable BangChiTietToChuyenMon(string maToChuyenMon)
        {
            mySqlCommand = new MySqlCommand("select gv.ho_ten_giao_vien as ho_ten_giao_vien, cgv.ten_chuyen_mon as ma_chuyen_mon, gv.ma_giao_vien from giao_vien gv, chi_tiet_to_chuyen_mon c, chuyen_mon_giao_vien cgv where c.ma_to_chuyen_mon=@matochuyenmon and gv.ma_chuyen_mon=cgv.ma_chuyen_mon and gv.ma_giao_vien=c.ma_giao_vien;");
            mySqlCommand.Parameters.Add("@matochuyenmon", MySqlDbType.VarChar, 6).Value = maToChuyenMon;
            dataServices.Load(mySqlCommand);
            return dataServices;
        }
        public DataTable BangGiaoVienKhongThuocTo(string maToChuyenMon)
        {
            string query1 = "(select gv.ma_giao_vien, gv.ho_ten_giao_vien, cmgv.ten_chuyen_mon from giao_vien gv, chuyen_mon_giao_vien cmgv where gv.ma_chuyen_mon=cmgv.ma_chuyen_mon) ";
            string query2 = "(select * from chi_tiet_to_chuyen_mon ct where ct.ma_to_chuyen_mon=@matochuyenmon) ";
            mySqlCommand = new MySqlCommand("select a.ho_ten_giao_vien as ho_ten_giao_vien, a.ten_chuyen_mon as ma_chuyen_mon, a.ma_giao_vien from " + query1 + " a left join " + query2 + " b using(ma_giao_vien) where b.ma_giao_vien is null;");
            mySqlCommand.Parameters.Add("@matochuyenmon", MySqlDbType.VarChar, 6).Value = maToChuyenMon;
            dataServices.Load(mySqlCommand);
            return dataServices;
        }
        /// <summary>
        /// Cập nhật những thay đổi
        /// </summary>
        /// <returns>Kết quả cập nhật có bao nhiêu dòng bị tác động</returns>
        public int CapNhat()
        {
            DataServices.OpenConnection(true);
            return dataServices.ExecuteUpdate();
        }
        /// <summary>
        /// Xóa những chi tiết của tổ chuyên môn khi Tổ chuyên môn đã bị xóa
        /// </summary>
        /// <param name="maToChuyenMon"></param>
        /// <returns></returns>
        public bool XoaChiTietToChuyenMon(string maToChuyenMon)
        {
            mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = "delete from chi_tiet_to_chuyen_mon where ma_to_chuyen_mon=@matochuyenmon;";
            mySqlCommand.Parameters.Add("@matochuyenmon", MySqlDbType.VarChar, 6).Value = maToChuyenMon;
            try
            {
                DataServices.OpenConnection(true);
                return dataServices.ExecuteUpdate(mySqlCommand) > 0;
            }
            catch { return false; }
        }
        /// <summary>
        /// Thêm Giáo viên vào tổ chuyên môn
        /// </summary>
        /// <param name="maToChuyenMon"></param>
        /// <param name="maGiaoVien"></param>
        /// <returns></returns>
        public bool ThemGiaoVienVaoToChuyenMon(string maToChuyenMon, string maGiaoVien)
        {
            mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = "insert into chi_tiet_to_chuyen_mon(ma_to_chuyen_mon,ma_giao_vien) values(@matochuyenmon,@magiaovien);";
            mySqlCommand.Parameters.Add("@matochuyenmon", MySqlDbType.VarChar, 6).Value = maToChuyenMon;
            mySqlCommand.Parameters.Add("@magiaovien", MySqlDbType.VarChar, 9).Value = maGiaoVien;
            try
            {
                DataServices.OpenConnection(true);
                return dataServices.ExecuteUpdate(mySqlCommand) > 0;
            }
            catch { return false; }
        }
        /// <summary>
        /// Xóa 1 giáo viên ra khỏi Tổ chuyên môn
        /// </summary>
        /// <param name="maToChuyenMon"></param>
        /// <returns></returns>
        public bool XoaGiaoVienKhoiToChuyenMon(string maToChuyenMon, string maGiaoVien)
        {
            mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = "delete from chi_tiet_to_chuyen_mon where ma_to_chuyen_mon=@matochuyenmon and ma_giao_vien=@magiaovien;";
            mySqlCommand.Parameters.Add("@matochuyenmon", MySqlDbType.VarChar, 6).Value = maToChuyenMon;
            mySqlCommand.Parameters.Add("@magiaovien", MySqlDbType.VarChar, 9).Value = maGiaoVien;
            try
            {
                DataServices.OpenConnection(true);
                return dataServices.ExecuteUpdate(mySqlCommand) > 0;
            }
            catch { return false; }
        }
    }
}
