using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAO
{
    public class SoDu_DAO: DataProvider
    {
        public Int64 Get_SoDu_Theo_Ngay(DateTime ngaythang)
        {
          //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngay", ngaythang.Day), new SqlParameter("@thang", ngaythang.Month)
                                                             , new SqlParameter("@nam", ngaythang.Year) };

           // MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            //int sodu;
            //try
            //{
            //    sodu = (int)ExecuteScalar("sp_get_so_Du_Theo_Ngay", sqlParams);
            //}
            //catch (Exception e)
            //{
            //    return 0;
            //}
           
            object O=ExecuteScalar("sp_get_so_Du_Theo_Ngay", sqlParams);

            if (O == null)
                return 0;
           
            return  Int64.Parse(decimal.Parse(O.ToString()).ToString("0.#"));

        }

        public Int64 Get_SoChi_Theo_Ngay(DateTime ngaythang)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngay", ngaythang.Day), new SqlParameter("@thang", ngaythang.Month)
                                                             , new SqlParameter("@nam", ngaythang.Year) };

            // MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            int sodu = 0;
            try
            {
                sodu = (int)ExecuteScalar("sp_get_so_chi_Theo_Ngay", sqlParams);
            }
            catch (Exception e)
            {
                return 0;
            }
            return sodu;
        }

        public Int64 Get_SoThu_Theo_Ngay(DateTime ngaythang)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngay", ngaythang.Day), new SqlParameter("@thang", ngaythang.Month)
                                                             , new SqlParameter("@nam", ngaythang.Year) };

            // MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            int sodu = 0;
            try
            {
                sodu = (int)ExecuteScalar("sp_get_so_Thu_Theo_Ngay", sqlParams);
            }
            catch (Exception e)
            {
                return 0;
            }
            return sodu;
        }

      
        public int kt_ton_tai_so_Thu_Theo_Ngay(DateTime ngaythang)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngay", ngaythang.Day), new SqlParameter("@thang", ngaythang.Month)
                                                             , new SqlParameter("@nam", ngaythang.Year) };
           
            try
            {
                DateTime temp = (DateTime)ExecuteScalar("sp_kt_ton_tai_so_Thu_Theo_Ngay", sqlParams);
            }
            catch (Exception e)
            {
                return 0;
            }
            return 1;
        }

        public int kt_ton_tai_so_Chi_Theo_Ngay(DateTime ngaythang)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngay", ngaythang.Day), new SqlParameter("@thang", ngaythang.Month)
                                                             , new SqlParameter("@nam", ngaythang.Year) };

            try
            {
                DateTime temp = (DateTime)ExecuteScalar("sp_kt_ton_tai_so_Chi_Theo_Ngay", sqlParams);
            }
            catch (Exception e)
            {
                return 0;
            }
            return 1;
        }

        public int kt_ton_tai_so_Du_Theo_Ngay(DateTime ngaythang)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngay", ngaythang.Day), new SqlParameter("@thang", ngaythang.Month)
                                                             , new SqlParameter("@nam", ngaythang.Year) };

            try
            {
                DateTime temp = (DateTime)ExecuteScalar("sp_kt_ton_tai_so_Du_Theo_Ngay", sqlParams);
            }
            catch (Exception e)
            {
                return 0;
            }
            return 1;
        }


        public int ThemSoDu(DateTime ngaythang, Int64 sodu)
        {
            DateTime _ngaythang = new DateTime(ngaythang.Year, ngaythang.Month, ngaythang.Day);
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngaythang", _ngaythang), new SqlParameter("@sodu", sodu) };

            return (int)ExecuteNonQuery("sp_them_so_du_Theo_Ngay", sqlParams);
                    
        }

        public int ThemSoThu(DateTime ngaythang, Int64 sothu)
        {
            DateTime _ngaythang = new DateTime(ngaythang.Year, ngaythang.Month, ngaythang.Day);

            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngaythang", _ngaythang), new SqlParameter("@sothu", sothu) };

            return (int)ExecuteNonQuery("sp_them_so_thu_Theo_Ngay", sqlParams);

        }

        public int ThemSoChi(DateTime ngaythang, Int64 sochi)
        {
            DateTime _ngaythang = new DateTime(ngaythang.Year, ngaythang.Month, ngaythang.Day);

            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngaythang", _ngaythang), new SqlParameter("@sochi", sochi) };

            return (int)ExecuteNonQuery("sp_them_so_chi_Theo_Ngay", sqlParams);

        }

        public int capnhatSoDu(DateTime ngaythang, Int64 sodu)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngaythang", ngaythang), new SqlParameter("@sodu", sodu) };
            return (int)ExecuteNonQuery("sp_cap_nhat_so_du_Theo_Ngay", sqlParams);

        }

        public int capnhatSoThu(DateTime ngaythang, Int64 sothu)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngaythang", ngaythang), new SqlParameter("@sothu", sothu) };
            return (int)ExecuteNonQuery("sp_cap_nhat_so_Thu_Theo_Ngay", sqlParams);

        }

        public int capnhatSoChi(DateTime ngaythang, Int64 sochi)
        {
            //  MessageBox.Show(ngaythang.Day.ToString() + "/" + ngaythang.Month.ToString() + "/" + ngaythang.Year.ToString());
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngaythang", ngaythang), new SqlParameter("@sochi", sochi) };
            return (int)ExecuteNonQuery("sp_cap_nhat_so_chi_Theo_Ngay", sqlParams);

        }

        public DataTable DsSoTon()
        {
            DataTable tb = LoadData("SP_DSSoDu");

            return tb;
        }

        public DataTable DsSoTon_Theo_Thang(int thang, int nam)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@thang", thang), new SqlParameter("@nam", nam) };

            DataTable tb = LoadData("SP_DSSoDu_ThangNam",sqlParams);

            return tb;
        }


    }
}
