using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using QLHSTPTTHSP.Initiation;
using QLHSTPTTHSP.BusinessObjects;

namespace QLHSTPTTHSP.DataLayer
{
    public class NienHocData
    {
        MySqlCommand mySqlCommand;
        DataServices dataServices = new DataServices();
        /// <summary>
        /// Lấy bảng niên học
        /// </summary>
        /// <returns>Bảng</returns>
        public DataTable LayBangNienHoc()
        {
            mySqlCommand = new MySqlCommand("select * from nien_hoc;");           
            dataServices.Load(mySqlCommand);
            return dataServices;
        }
        /// <summary>
        /// Lấy bảng nien_hoc dựa vào ma_nien_hoc
        /// </summary>
        /// <returns>Bảng</returns>
        public DataTable BangNienHoc(string maNienHoc)
        {
            mySqlCommand = new MySqlCommand("select * from nien_hoc where ma_nien_hoc = @manienhoc;");
            mySqlCommand.Parameters.Add("@manienhoc", MySqlDbType.VarChar, 6).Value = maNienHoc;
            dataServices.Load(mySqlCommand);
            return dataServices;
        }
        /// <summary>
        /// Lấy một cột trong bảng niên học
        /// </summary>
        /// <param name="fieldName">tên trường cần lấy</param>
        /// <returns>Một cột thuộc bảng niên học</returns>
        public DataTable LayBangNienHoc(string fieldName)
        {
            mySqlCommand = new MySqlCommand("select " + fieldName + " from nien_hoc;");
            dataServices.Load(mySqlCommand);
            return dataServices;
        }
        /// <summary>
        /// Thêm 1 dòng mới từ bảng nien_hoc
        /// </summary>
        /// <returns></returns>
        public DataRow ThemDongMoi()
        {
            return dataServices.NewRow();
        }
        /// <summary>
        /// Thêm 1 niên học mới vào bảng nien_hoc
        /// </summary>
        /// <param name="row"></param>
        public void ThemNienHoc(DataRow row)
        {
            dataServices.Rows.Add(row); 
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
        /// Cập nhật với câu lệnh SQL. 
        /// </summary>
        /// <returns>Kết quả cập nhật có bao nhiêu dòng bị tác động</returns>
        public int CapNhat(NienHocInfo nienHocInfo)
        {
            mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandText = "update nien_hoc set tg_bat_dau=@tgbatdau, tg_ket_thuc=@tgketthuc where ma_nien_hoc = @manienhoc;";
            mySqlCommand.Parameters.Add("@manienhoc", MySqlDbType.VarChar, 6).Value = nienHocInfo.MaNienHoc;
            mySqlCommand.Parameters.Add("@tgbatdau", MySqlDbType.Date).Value = nienHocInfo.ThoiGianBatDau;
            mySqlCommand.Parameters.Add("@tgketthuc", MySqlDbType.Date).Value = nienHocInfo.ThoiGianKetThuc;
            try
            {
                DataServices.OpenConnection(true);
                return dataServices.ExecuteUpdate(mySqlCommand);
            }
            catch { return 0; }
        }
    }
}
