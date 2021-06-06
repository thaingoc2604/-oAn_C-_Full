using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class TK_ThuChiDAO : DataProvider
    {
        public DataTable GetDSTK_PhieuDaHuy()
        {
            DataTable kq = new DataTable();

            kq = LoadData("sp_DSPhieuDaHhuy");

            return kq;
        }

        public int Khoi_Phuc_Phieu(TKThuChi_DTO tk_DTO)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@stt", tk_DTO.Maso),
            
            };

            return ExecuteNonQuery("sp_Khoi_Phuc_Phieu", sqlParams);
        }

      

         public int Cap_nhat_Phieu(TKThuChi_DTO tk_DTO)
        {
            DateTime ngaythang = new DateTime(tk_DTO.Ngaythang.Year, tk_DTO.Ngaythang.Month, tk_DTO.Ngaythang.Day);
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@stt", tk_DTO.Maso),
                new SqlParameter("@ngaythang", ngaythang),
                new SqlParameter("@Diengiai", tk_DTO.DG),
                new SqlParameter("@Sotienthu", tk_DTO.TienThu),
                new SqlParameter("@Sotienchi", tk_DTO.TienChi),
                new SqlParameter("@SoTon", tk_DTO.SoTon)
            };

            return ExecuteNonQuery("sp_cap_nhat_phieu", sqlParams);
         }

        public int Cap_nhat_Phieu_Thu(TKThuChi_DTO tk_DTO)
        {
            //MessageBox.Show(tk_DTO.DG);
            DateTime ngaythang = new DateTime(tk_DTO.Ngaythang.Year, tk_DTO.Ngaythang.Month, tk_DTO.Ngaythang.Day);
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@stt", tk_DTO.Maso),
                new SqlParameter("@ngaythang", ngaythang),
                new SqlParameter("@Diengiai", tk_DTO.DG),
                new SqlParameter("@Sotienthu", tk_DTO.TienThu),
                new SqlParameter("@Maphieuthu", tk_DTO.Maphieuthu),
                new SqlParameter("@SoTon", tk_DTO.SoTon)
            };

            return ExecuteNonQuery("sp_cap_nhat_phieu_Thu", sqlParams);
        }

        public int Kiem_Tra_Ma_Phieu_Thu(int maphieuthu)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { 
              
                new SqlParameter("@maphieuthu", maphieuthu)
            };

            return LoadData("sp_KTTonTaiMaPhieuThu", sqlParams).Rows.Count;
        }

        public int Kiem_Tra_Ma_Phieu_Chi(int maphieuchi)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { 
              
                new SqlParameter("@maphieuchi", maphieuchi)
            };

            return LoadData("sp_KTTonTaiMaPhieuChi", sqlParams).Rows.Count;
        }


        public int Cap_nhat_Phieu_Chi(TKThuChi_DTO tk_DTO)
        {
            //MessageBox.Show(tk_DTO.DG);
            DateTime ngaythang = new DateTime(tk_DTO.Ngaythang.Year, tk_DTO.Ngaythang.Month, tk_DTO.Ngaythang.Day);
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@stt", tk_DTO.Maso),
                new SqlParameter("@ngaythang", ngaythang),
                new SqlParameter("@Diengiai", tk_DTO.DG),
                new SqlParameter("@MaPhieuChi", tk_DTO.Maphieuchi),
                new SqlParameter("@Sotienchi", tk_DTO.TienChi
                ),
                new SqlParameter("@SoTon", tk_DTO.SoTon)
            };

            return ExecuteNonQuery("sp_cap_nhat_phieu_Chi", sqlParams);
        }

        public int Huy_Phieu(TKThuChi_DTO tk_DTO)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@stt", tk_DTO.Maso),
            
            };

            return ExecuteNonQuery("sp_Huy_phieu", sqlParams);
        }

        public DataTable LayDanhSachSPExel(string path)
        {
            DataTable dt = new DataTable("chungtu");


            dt = ReadExelFile(path);

            dt.Columns[0].ColumnName = "NGAYTHANG";

            dt.Columns[1].ColumnName = "MAPHIEUTHU";

            dt.Columns[2].ColumnName = "MAPHIEUCHI";

            dt.Columns[3].ColumnName = "DIENGIAI";

            dt.Columns[4].ColumnName = "SOTIENTHU";

            dt.Columns[5].ColumnName = "SOTIENCHI";

            dt.Columns[6].ColumnName = "SOTON";

            dt.Columns[7].ColumnName = "MALOAIPHIEU";


            return dt;
        }

        public int KT_PhatSinh(DateTime ngaythang)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ngay", ngaythang.Day), new SqlParameter("@thang", ngaythang.Month)
                                                             , new SqlParameter("@nam", ngaythang.Year) };

            int sodu = 0;
            try
            {
                sodu = (int)ExecuteScalar("sp_kt_phat_sinh", sqlParams);
            }
            catch (Exception e)
            {
                return 0;
            }
            return sodu;
        }


        public DataTable GetDSTK_ThuChi()
        {
            DataTable kq = new DataTable();

            kq=LoadData("sp_DSthuchi");

            return kq;
        }

        public DataTable PhatsinhTrongKy(string ngaybd, string ngaykt)
        {
            DataTable kq = new DataTable();

            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@ngaybd", ngaybd),
                new SqlParameter("@ngaykt", ngaykt)};

            kq = LoadData("sp_PhatSinhTrongKy", sqlParams) as DataTable;


            return kq;
        }

        public DataTable PhatsinhTrongNam(string ngaybd,string ngaykt)
        {
            DataTable kq = new DataTable();

            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@ngaybd", ngaybd),
                new SqlParameter("@ngaykt", ngaykt)};

            kq = LoadData("sp_PhatSinhTrongNam", sqlParams) as DataTable;


            return kq;
        }

        public DataTable PhatsinhTrongQuy(string ngaybd,string ngaykt)
        {
            DataTable kq = new DataTable();

            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@ngaybd", ngaybd),
                new SqlParameter("@ngaykt", ngaykt)};
            

            kq = LoadData("sp_PhatSinhTrongQuy", sqlParams) as DataTable;


            return kq;
        }

        public DataTable Cap_Nhat_SO_Ton_Phieu_Thu(int maphieuthu, Int64 sodu)
        {
            DataTable kq = new DataTable();

            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@maphieuthu", maphieuthu),
                new SqlParameter("@sodu", sodu)};

            kq = LoadData("sp_cap_nhat_so_ton_phieu_Thu", sqlParams) as DataTable;


            return kq;
        }

        public DataTable Cap_Nhat_SO_Ton_Phieu_Chi(int maphieuchi, Int64 sodu)
        {
            DataTable kq = new DataTable();

            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@maphieuchi", maphieuchi),
                new SqlParameter("@sodu", sodu)};

            kq = LoadData("sp_cap_nhat_so_ton_phieu_Chi", sqlParams) as DataTable;


            return kq;
        }

        public DataTable GetDSTK_ThuChi_TheoNgay(DateTime ngaythang)
        {
            DataTable kq = new DataTable();

            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@ngay", ngaythang.Day),
                new SqlParameter("@thang", ngaythang.Month), 
                new SqlParameter("@nam", ngaythang.Year)};

            kq = LoadData("sp_DSthuchitheoNgay", sqlParams) as DataTable;

            //DataTable tb_PhatsinhTrongKy = PhatsinhTrongKy(ngaythang.Month, ngaythang.Year);

            //DataTable tb_PhatsinhTrongNam = PhatsinhTrongNam(ngaythang.Month, ngaythang.Year);

            //DataTable tb_PhatsinhTrongQuy= new DataTable();

            //if (ngaythang.Month <= 3)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(1, 3, ngaythang.Year);

            //if (4 <= ngaythang.Month && ngaythang.Month <= 6)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(4, 6, ngaythang.Year);

            //if (7 <= ngaythang.Month && ngaythang.Month <= 9)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(7, 9, ngaythang.Year);

            //if (10 <= ngaythang.Month && ngaythang.Month <= 12)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(10, 12, ngaythang.Year);

            //DataColumn dtCol1 = new DataColumn("TongThuTrongKy");

            //dtCol1.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol2 = new DataColumn("TongChiTrongKy");

            //dtCol2.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol3 = new DataColumn("TongThuTrongNam");

            //dtCol3.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol4 = new DataColumn("TongChiTrongNam");

            //dtCol4.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol5 = new DataColumn("TongThuTrongQuy");

            //dtCol5.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol6 = new DataColumn("TongChiTrongQuy");

            //dtCol6.DataType = System.Type.GetType("System.Int64");

            //kq.Columns.Add(dtCol1);

            //kq.Columns.Add(dtCol2);

            //kq.Columns.Add(dtCol3);

            //kq.Columns.Add(dtCol4);

            //kq.Columns.Add(dtCol5);

            //kq.Columns.Add(dtCol6);

            //if (kq.Rows.Count == 0)
            //{
            //    kq.Rows.Add(kq.NewRow());
            //}


            //if (tb_PhatsinhTrongKy.Rows.Count > 0)
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = tb_PhatsinhTrongKy.Rows[0]["TongThuTrongKy"];
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongKy"] = tb_PhatsinhTrongKy.Rows[0]["TongChiTrongKy"];
            //}
            //else
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = 0;
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = 0;
            //}

           
                

            //if (tb_PhatsinhTrongNam.Rows.Count > 0)
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongNam"] = tb_PhatsinhTrongNam.Rows[0]["TongThuTrongNam"];
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongNam"] = tb_PhatsinhTrongNam.Rows[0]["TongChiTrongNam"];
            //}
            //else
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongNam"] = 0;
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongNam"] = 0;
            //}

            //if (tb_PhatsinhTrongQuy.Rows.Count > 0)
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongQuy"] = tb_PhatsinhTrongQuy.Rows[0]["TongThuTrongQuy"];
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongQuy"] = tb_PhatsinhTrongQuy.Rows[0]["TongChiTrongQuy"];
            //}
            //else
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongQuy"] = 0;
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongQuy"] = 0;
            //}
                

            return kq;
        }

        public DataTable GetDSTK_ThuChi_TheoThang(DateTime ngaythang)
        {
            DataTable kq = new DataTable();

            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@thang", ngaythang.Month), 
                new SqlParameter("@nam", ngaythang.Year)};

            kq = LoadData("sp_DSthuchitheothang", sqlParams) as DataTable;

            //DataTable tb_PhatsinhTrongKy = PhatsinhTrongKy(ngaythang.Month, ngaythang.Year);

            //DataTable tb_PhatsinhTrongNam = PhatsinhTrongNam(ngaythang.Month, ngaythang.Year);

            //DataTable tb_PhatsinhTrongQuy = new DataTable();

            //if (ngaythang.Month <= 3)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(1, 3, ngaythang.Year);

            //if (4 <= ngaythang.Month && ngaythang.Month <= 6)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(4, 6, ngaythang.Year);

            //if (7 <= ngaythang.Month && ngaythang.Month <= 9)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(7, 9, ngaythang.Year);

            //if (10 <= ngaythang.Month && ngaythang.Month <= 12)
            //    tb_PhatsinhTrongQuy = PhatsinhTrongQuy(10, 12, ngaythang.Year);

            //DataColumn dtCol1 = new DataColumn("TongThuTrongKy");

            //dtCol1.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol2 = new DataColumn("TongChiTrongKy");

            //dtCol2.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol3 = new DataColumn("TongThuTrongNam");

            //dtCol3.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol4 = new DataColumn("TongChiTrongNam");

            //dtCol4.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol5 = new DataColumn("TongThuTrongQuy");

            //dtCol5.DataType = System.Type.GetType("System.Int64");


            //DataColumn dtCol6 = new DataColumn("TongChiTrongQuy");

            //dtCol6.DataType = System.Type.GetType("System.Int64");

            //kq.Columns.Add(dtCol1);

            //kq.Columns.Add(dtCol2);

            //kq.Columns.Add(dtCol3);

            //kq.Columns.Add(dtCol4);

            //kq.Columns.Add(dtCol5);

            //kq.Columns.Add(dtCol6);

            //if (kq.Rows.Count == 0)
            //{
            //    kq.Rows.Add(kq.NewRow());
            //}


            //if (tb_PhatsinhTrongKy.Rows.Count > 0)
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = tb_PhatsinhTrongKy.Rows[0]["TongThuTrongKy"];
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongKy"] = tb_PhatsinhTrongKy.Rows[0]["TongChiTrongKy"];
            //}
            //else
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = 0;
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = 0;
            //}




            //if (tb_PhatsinhTrongNam.Rows.Count > 0)
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongNam"] = tb_PhatsinhTrongNam.Rows[0]["TongThuTrongNam"];
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongNam"] = tb_PhatsinhTrongNam.Rows[0]["TongChiTrongNam"];
            //}
            //else
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongNam"] = 0;
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongNam"] = 0;
            //}

            //if (tb_PhatsinhTrongQuy.Rows.Count > 0)
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongQuy"] = tb_PhatsinhTrongQuy.Rows[0]["TongThuTrongQuy"];
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongQuy"] = tb_PhatsinhTrongQuy.Rows[0]["TongChiTrongQuy"];
            //}
            //else
            //{
            //    kq.Rows[kq.Rows.Count - 1]["TongThuTrongQuy"] = 0;
            //    kq.Rows[kq.Rows.Count - 1]["TongChiTrongQuy"] = 0;
            //}


            return kq;
        }

        public DataTable GetDSTK_ThuChi_TheoGiaiDoan(DateTime ngaybd, DateTime ngaykt)
        {
            DataTable kq = new DataTable();

            string _ngaybd = ngaybd.Year.ToString() + "/" + ngaybd.Month.ToString() + "/" + ngaybd.Day.ToString();

            string _ngaykt = ngaykt.Year.ToString() + "/" + ngaykt.Month.ToString() + "/" + ngaykt.Day.ToString(); ;
            SqlParameter[] sqlParams = new SqlParameter[] { 
                new SqlParameter("@ngaybd", ngaybd), 
                new SqlParameter("@ngaykt", ngaykt)};

            kq = LoadData("sp_DSthuchitheogiaidoan", sqlParams) as DataTable;

            DataTable tb_PhatsinhTrongKy = PhatsinhTrongKy(_ngaybd, _ngaykt);

            DataTable tb_PhatsinhTrongNam = PhatsinhTrongNam(ngaykt.Year.ToString() + "/01/01", _ngaykt);

            DataTable tb_PhatsinhTrongQuy = new DataTable();

            if (ngaykt.Month <= 3)
                tb_PhatsinhTrongQuy = PhatsinhTrongQuy(ngaykt.Year.ToString() + "/01/01", _ngaykt);

            if (4 <= ngaykt.Month && ngaykt.Month <= 6)
                tb_PhatsinhTrongQuy = PhatsinhTrongQuy(ngaykt.Year.ToString() + "/04/01", _ngaykt);

            if (7 <= ngaykt.Month && ngaykt.Month <= 9)
                tb_PhatsinhTrongQuy = PhatsinhTrongQuy(ngaykt.Year.ToString() + "/07/01", _ngaykt);

            if (10 <= ngaykt.Month && ngaykt.Month <= 12)
                tb_PhatsinhTrongQuy = PhatsinhTrongQuy(ngaykt.Year.ToString() + "/10/01", _ngaykt);

            DataColumn dtCol1 = new DataColumn("TongThuTrongKy");

            dtCol1.DataType = System.Type.GetType("System.Int64");


            DataColumn dtCol2 = new DataColumn("TongChiTrongKy");

            dtCol2.DataType = System.Type.GetType("System.Int64");


            DataColumn dtCol3 = new DataColumn("TongThuTrongNam");

            dtCol3.DataType = System.Type.GetType("System.Int64");


            DataColumn dtCol4 = new DataColumn("TongChiTrongNam");

            dtCol4.DataType = System.Type.GetType("System.Int64");


            DataColumn dtCol5 = new DataColumn("TongThuTrongQuy");

            dtCol5.DataType = System.Type.GetType("System.Int64");


            DataColumn dtCol6 = new DataColumn("TongChiTrongQuy");

            dtCol6.DataType = System.Type.GetType("System.Int64");

            kq.Columns.Add(dtCol1);

            kq.Columns.Add(dtCol2);

            kq.Columns.Add(dtCol3);

            kq.Columns.Add(dtCol4);

            kq.Columns.Add(dtCol5);

            kq.Columns.Add(dtCol6);

            if (kq.Rows.Count == 0)
            {
                kq.Rows.Add(kq.NewRow());
            }


            if (tb_PhatsinhTrongKy.Rows.Count > 0)
            {
                kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = tb_PhatsinhTrongKy.Rows[0]["TongThuTrongKy"];
                kq.Rows[kq.Rows.Count - 1]["TongChiTrongKy"] = tb_PhatsinhTrongKy.Rows[0]["TongChiTrongKy"];
            }
            else
            {
                kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = 0;
                kq.Rows[kq.Rows.Count - 1]["TongThuTrongKy"] = 0;
            }




            if (tb_PhatsinhTrongNam.Rows.Count > 0)
            {
                kq.Rows[kq.Rows.Count - 1]["TongThuTrongNam"] = tb_PhatsinhTrongNam.Rows[0]["TongThuTrongNam"];
                kq.Rows[kq.Rows.Count - 1]["TongChiTrongNam"] = tb_PhatsinhTrongNam.Rows[0]["TongChiTrongNam"];
            }
            else
            {
                kq.Rows[kq.Rows.Count - 1]["TongThuTrongNam"] = 0;
                kq.Rows[kq.Rows.Count - 1]["TongChiTrongNam"] = 0;
            }

            if (tb_PhatsinhTrongQuy.Rows.Count > 0)
            {
                kq.Rows[kq.Rows.Count - 1]["TongThuTrongQuy"] = tb_PhatsinhTrongQuy.Rows[0]["TongThuTrongQuy"];
                kq.Rows[kq.Rows.Count - 1]["TongChiTrongQuy"] = tb_PhatsinhTrongQuy.Rows[0]["TongChiTrongQuy"];
            }
            else
            {
                kq.Rows[kq.Rows.Count - 1]["TongThuTrongQuy"] = 0;
                kq.Rows[kq.Rows.Count - 1]["TongChiTrongQuy"] = 0;
            }


            return kq;
        }
    }
}
