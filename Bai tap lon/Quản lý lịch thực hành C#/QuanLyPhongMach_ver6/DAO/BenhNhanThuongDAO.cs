using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BenhNhanThuongDAO
    {
        public static List<BenhNhanThuongDTO> SelectAllBenhNhanThuong()
        {
            try
            {
                List<BenhNhanThuongDTO> List_BenhNhanThuong = new List<BenhNhanThuongDTO>();

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_SelectAllBenhNhanThuong");

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BenhNhanThuongDTO benhnhan = new BenhNhanThuongDTO();

                        benhnhan.sttBNT = int.Parse(row["sttBNT"].ToString());
                        benhnhan.STTBN = int.Parse(row["Mã Bệnh Nhân"].ToString());
                        benhnhan.Hoten = row["Họ Tên Bệnh Nhân"].ToString();
                        benhnhan.CMND = int.Parse(row["Số Chứng Minh Nhân Dân"].ToString());
                        benhnhan.DiaChi = row["Địa Chỉ"].ToString();
                        benhnhan.BacSiPhuTrach = int.Parse(row["sttBS"].ToString());

                        List_BenhNhanThuong.Add(benhnhan);
                    }
                }
                return List_BenhNhanThuong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
