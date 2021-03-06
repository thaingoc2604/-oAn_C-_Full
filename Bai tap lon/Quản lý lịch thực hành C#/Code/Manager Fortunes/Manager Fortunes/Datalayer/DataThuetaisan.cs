using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Manager_Fortunes.BusinessObject;
using Manager_Fortunes.DaTaService;
namespace Manager_Fortunes.Datalayer
{
   
    public class DataThuetaisan
    {
        DaTaService.DataService ds = new Manager_Fortunes.DaTaService.DataService();
        

        public DataThuetaisan()
        {

        }
        public DataTable LayDSThueTaiSan()
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from THUETAISAN");
                ds.select(com);
                return ds;

            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy danh sách tài sản thuê không thành công. " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable LayDSLyDo()
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from LYDOTANG");
                ds.select(com);
                return ds;

            }
            catch (Exception e)
            {
                MessageBox.Show("Lấy danh sách tài sản thuê không thành công. " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void LuuTaiSanThue(ThueTaiSan ts)
        {
            try
            {
                SqlCommand com = new SqlCommand("insert into THUETAISAN values(@MAPHIEUTHUE,@MATAISAN,@TENTAISAN,@MANHOM,@MADVT,@LYDOTANG,@NGAYTANG,@SOLUONG,@GIATHUE,@THANHTIEN,@DATHANHTOAN,@CONLAI,@THOIGIANSUDUNG,@MADIADIEM,@MAPHONGBAN,@MUCDICHSUDUNG)");
                com.Parameters.Add("MAPHIEUTHUE", SqlDbType.NChar, 10).Value = ts.MaPhieuthue;
                com.Parameters.Add("MATAISAN", SqlDbType.NChar, 10).Value = ts.MaTaiSan;
                com.Parameters.Add("TENTAISAN", SqlDbType.NVarChar, 100).Value = ts.TenTaiSan;
                com.Parameters.Add("MANHOM", SqlDbType.NChar, 10).Value = ts.NhomTaiSanCongCu.MaNhom;
                com.Parameters.Add("MADVT", SqlDbType.NChar, 10).Value = ts.DonViTinh.MaDonViTinh;
                com.Parameters.Add("LYDOTANG", SqlDbType.NVarChar, 100).Value = ts.LyDoTang.MaLyDo;
                com.Parameters.Add("NGAYTANG", SqlDbType.DateTime).Value = ts.NgayTang;
                com.Parameters.Add("SOLUONG", SqlDbType.Int).Value = ts.SoLuong;
                com.Parameters.Add("GIATHUE", SqlDbType.Float).Value = ts.GiaThue;
                com.Parameters.Add("THANHTIEN", SqlDbType.Float).Value = ts.ThanhTien;
                com.Parameters.Add("DATHANHTOAN", SqlDbType.Float).Value = ts.DaThanhToan;
                com.Parameters.Add("CONLAI", SqlDbType.Float).Value = ts.ConLai;
                com.Parameters.Add("THOIGIANSUDUNG", SqlDbType.DateTime).Value = ts.ThoigianSudung;
                com.Parameters.Add("MADIADIEM", SqlDbType.NChar, 10).Value = ts.DiaDiem.MaDiaDiem;
                com.Parameters.Add("MAPHONGBAN", SqlDbType.NChar, 10).Value = ts.PhongBan.MaPhong;
                com.Parameters.Add("MUCDICHSUDUNG", SqlDbType.NVarChar, 100).Value = ts.MucDich;

                ds.ExcutiveNonQuery(com);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lưu tài sản không thành công. " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void XoaTaiSanThue(ThueTaiSan ts)
        {
            try
            {
                SqlCommand com = new SqlCommand("delete from THUETAISAN where MAPHIEUTHUE=@ma");
                com.Parameters.Add("ma", SqlDbType.NChar, 10).Value = ts.MaPhieuthue;
                ds.ExcutiveNonQuery(com);
            }
            catch (Exception et)
            {
                MessageBox.Show("Xóa tài sản không được. " + et.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        public void CapNhatTaiSanThue(ThueTaiSan ts)
        {
            try
            {
                SqlCommand com = new SqlCommand("update THUETAISAN set TENTAISAN = @tents , MANHOM =@manhom, MADVT= @madvt,LYDOTANG =@lydo,NGAYTANG = @ngtang,SOLUONG = @sluong,GIATHUE = @giathue,DATHANHTOAN = @datra,CONLAI = @conlai,THOIGIANSUDUNG = @hanswdung,MADIADIEM = @madiadiem,MAPHONGBAN= @maphg,MUCDICHSUDUNG = @mucdich where MAPHIEUTHUE = @maphieu");

                com.Parameters.Add("maphieu", SqlDbType.NChar, 10).Value = ts.MaPhieuthue;
                com.Parameters.Add("tents", SqlDbType.NVarChar, 100).Value = ts.TenTaiSan;
                com.Parameters.Add("manhom", SqlDbType.NChar, 10).Value = ts.NhomTaiSanCongCu.MaNhom;
                com.Parameters.Add("madvt", SqlDbType.NChar, 10).Value = ts.DonViTinh.MaDonViTinh;
                com.Parameters.Add("lydo", SqlDbType.NVarChar, 100).Value = ts.LyDoTang;
                com.Parameters.Add("ngtang", SqlDbType.DateTime).Value = ts.NgayTang;
                com.Parameters.Add("sluong", SqlDbType.Int).Value = ts.SoLuong;
                com.Parameters.Add("giathue", SqlDbType.Float).Value = ts.GiaThue;
                com.Parameters.Add("datra", SqlDbType.Float).Value = ts.DaThanhToan;
                com.Parameters.Add("conlai", SqlDbType.Float).Value = ts.ConLai;
                com.Parameters.Add("hansudung", SqlDbType.DateTime).Value = ts.ThoigianSudung;
                com.Parameters.Add("madiadiem", SqlDbType.NChar, 10).Value = ts.DiaDiem.MaDiaDiem;
                com.Parameters.Add("maphg", SqlDbType.NChar, 10).Value = ts.PhongBan.MaPhong;
                com.Parameters.Add("mucdich", SqlDbType.NVarChar, 100).Value = ts.MucDich;

                ds.ExcutiveNonQuery(com);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật tài sản không thành công. " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable TimKiemTaiSan(string tentaisan,DevComponents.DotNetBar.Controls.CheckBoxX chonnhom, string manhom, DateTime tungay, DateTime denngay, DateTime hansudungtu, DateTime hansudungden, string diadiem, string phongban)
        {

            SqlCommand com = new SqlCommand();
            
            string sql = "Select * from THUETAISAN where (TENTAISAN like '%' + @tentaisan + '%')";
            com.Parameters.Add("tentaisan", SqlDbType.NVarChar, 100).Value = tentaisan;
            
            //chọn nhóm
            if (chonnhom.CheckState == CheckState.Checked)
            {
               sql += "(MANHOM like '%' + @tennhom + '%')";
               com.Parameters.Add("tennhom", SqlDbType.NVarChar).Value = manhom;
            }
            
            com.CommandText = sql;
            ds.select(com);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }


    }
}
