using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BenhNhanDAO
    {
        public static bool Insert_BenhNhanThuong(BenhNhanDTO benhnhan)
        {
            try
            {
                List<SqlParameter> listBN = new List<SqlParameter>();

                listBN.Add(new SqlParameter("@hoten", benhnhan.Hoten));
                listBN.Add(new SqlParameter("@CMND", benhnhan.CMND));
                listBN.Add(new SqlParameter("@diachi", benhnhan.DiaChi));
                listBN.Add(new SqlParameter("@gioitinh", benhnhan.GioiTinh));
                listBN.Add(new SqlParameter("@ngaykham", benhnhan.NgayKham));
                listBN.Add(new SqlParameter("@BSphutrach", benhnhan.BacSiPhuTrach));

                int n = DataAccessHelper.ExcuteNonQuery("sp_InsertBenhNhan_BenhNhanThuong", listBN);
                if (n == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Insert_BenhNhanNamVien(BenhNhanDTO benhnhan)
        {
            try
            {
                List<SqlParameter> listBN = new List<SqlParameter>();

                listBN.Add(new SqlParameter("@hoten", benhnhan.Hoten));
                listBN.Add(new SqlParameter("@CMND", benhnhan.CMND));
                listBN.Add(new SqlParameter("@diachi", benhnhan.DiaChi));
                listBN.Add(new SqlParameter("@gioitinh", benhnhan.GioiTinh));
                listBN.Add(new SqlParameter("@ngaykham", benhnhan.NgayKham));
                listBN.Add(new SqlParameter("@BSphutrach", benhnhan.BacSiPhuTrach));

                int n = DataAccessHelper.ExcuteNonQuery("sp_InsertBenhNhan_BenhNhanNamGiuong_ChuaXepCho", listBN);
                if (n > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BenhNhanDTO> SelectAllBenhNhanNamGiuong_ChuaXepCho()
        {
            try
            {
                List<BenhNhanDTO> List_BenhNhan = new List<BenhNhanDTO>();

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_selectAllBenhNhanNamGiuong_ChuaXepCho");

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BenhNhanDTO benhnhan = new BenhNhanDTO();

                        benhnhan.STTBN = int.Parse(row["Mã Bệnh Nhân"].ToString());
                        benhnhan.Hoten = row["Họ Tên Bệnh Nhân"].ToString();
                        benhnhan.CMND = int.Parse(row["Số Chứng Minh Nhân Dân"].ToString());
                        benhnhan.DiaChi = row["Địa Chỉ"].ToString();
                        benhnhan.BacSiPhuTrach = int.Parse(row["sttBS"].ToString());

                        List_BenhNhan.Add(benhnhan);
                    }
                }
                return List_BenhNhan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BenhNhanDTO> SelectAllBenhNhan()
        {
            try
            {
                List<BenhNhanDTO> List_BenhNhan = new List<BenhNhanDTO>();

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_SelectAllBenhNhan");

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BenhNhanDTO Benhnhan = new BenhNhanDTO();

                        Benhnhan.STTBN = int.Parse(row["Mã Bệnh Nhân"].ToString());
                        Benhnhan.Hoten = row["Họ Tên Bệnh Nhân"].ToString();
                        Benhnhan.CMND = int.Parse(row["CMND"].ToString());
                        Benhnhan.DiaChi = row["Địa Chỉ"].ToString();
                        Benhnhan.NgayKham = DateTime.Parse(row["Ngày Khám Bệnh"].ToString());
                        Benhnhan.BacSiPhuTrach = int.Parse(row["Bác Sĩ Điều Trị"].ToString());
                        Benhnhan.GioiTinh = row["Giới Tính"].ToString();

                        List_BenhNhan.Add(Benhnhan);
                    }
                }
                return List_BenhNhan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BenhNhanDTO> SelectBenhNhanByHoTen(string hoten)
        {
            try
            {
                List<BenhNhanDTO> List_BenhNhan = new List<BenhNhanDTO>();

                List<SqlParameter> sqlparams = new List<SqlParameter>();

                sqlparams.Add(new SqlParameter("@hoten",hoten));

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_SelectAllBenhNhanByHoTen", sqlparams);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BenhNhanDTO Benhnhan = new BenhNhanDTO();

                        Benhnhan.STTBN = int.Parse(row["Mã Bệnh Nhân"].ToString());
                        Benhnhan.Hoten = row["Họ Tên Bệnh Nhân"].ToString();
                        Benhnhan.CMND = int.Parse(row["CMND"].ToString());
                        Benhnhan.DiaChi = row["Địa Chỉ"].ToString();
                        Benhnhan.NgayKham = DateTime.Parse(row["Ngày Khám Bệnh"].ToString());
                        Benhnhan.BacSiPhuTrach = int.Parse(row["Bác Sĩ Điều Trị"].ToString());
                        Benhnhan.GioiTinh = row["Giới Tính"].ToString();

                        List_BenhNhan.Add(Benhnhan);
                    }
                }
                return List_BenhNhan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BenhNhanDTO> SelectAllBenhNhanByBacSiDieuTri(int sttBS)
        {
            try
            {
                List<BenhNhanDTO> List_BenhNhan = new List<BenhNhanDTO>();

                List<SqlParameter> sqlparams = new List<SqlParameter>();

                sqlparams.Add(new SqlParameter("sttBS",sttBS));

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_SelectAllBenhNhanByBacSiDieuTri", sqlparams);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BenhNhanDTO Benhnhan = new BenhNhanDTO();

                        Benhnhan.STTBN = int.Parse(row["Mã Bệnh Nhân"].ToString());
                        Benhnhan.Hoten = row["Họ Tên Bệnh Nhân"].ToString();
                        Benhnhan.CMND = int.Parse(row["CMND"].ToString());
                        Benhnhan.DiaChi = row["Địa Chỉ"].ToString();
                        Benhnhan.NgayKham = DateTime.Parse(row["Ngày Khám Bệnh"].ToString());
                        Benhnhan.BacSiPhuTrach = int.Parse(row["Bác Sĩ Điều Trị"].ToString());
                        Benhnhan.GioiTinh = row["Giới Tính"].ToString();

                        List_BenhNhan.Add(Benhnhan);
                    }
                }
                return List_BenhNhan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BenhNhanDTO> SelectAllBenhNhanByBacSiAndGioiTinh(int sttBS, string gioitinh)
        {
            try
            {
                List<BenhNhanDTO> List_BenhNhan = new List<BenhNhanDTO>();

                List<SqlParameter> sqlparams = new List<SqlParameter>();

                sqlparams.Add(new SqlParameter("@sttBS", sttBS));
                sqlparams.Add(new SqlParameter("@gioitinh", gioitinh));

                DataTable dt = DataAccessHelper.ExcuteQuery("sp_SelectAllBenhNhanByBacSiDieuTri", sqlparams);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        BenhNhanDTO Benhnhan = new BenhNhanDTO();

                        Benhnhan.STTBN = int.Parse(row["Mã Bệnh Nhân"].ToString());
                        Benhnhan.Hoten = row["Họ Tên Bệnh Nhân"].ToString();
                        Benhnhan.CMND = int.Parse(row["CMND"].ToString());
                        Benhnhan.DiaChi = row["Địa Chỉ"].ToString();
                        Benhnhan.NgayKham = DateTime.Parse(row["Ngày Khám Bệnh"].ToString());
                        Benhnhan.BacSiPhuTrach = int.Parse(row["Bác Sĩ Điều Trị"].ToString());
                        Benhnhan.GioiTinh = row["Giới Tính"].ToString();

                        List_BenhNhan.Add(Benhnhan);
                    }
                }
                return List_BenhNhan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool UpdateBenhNhan(BenhNhanDTO benhnhan)
        {
            try
            {
                List<SqlParameter> sqlparams = new List<SqlParameter>();
                sqlparams.Add(new SqlParameter("@sttBN", benhnhan.STTBN));
                sqlparams.Add(new SqlParameter("@hoten", benhnhan.Hoten));
                sqlparams.Add(new SqlParameter("@CMND", benhnhan.CMND));
                sqlparams.Add(new SqlParameter("@diachi", benhnhan.DiaChi));
                sqlparams.Add(new SqlParameter("@gioitinh", benhnhan.GioiTinh));
                sqlparams.Add(new SqlParameter("@ngaykham", benhnhan.NgayKham));
                sqlparams.Add(new SqlParameter("@BSphutrach", benhnhan.BacSiPhuTrach));

                int n = DataAccessHelper.ExcuteNonQuery("sp_UpdateThongTinBenhNhan", sqlparams);
                if (n > 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
