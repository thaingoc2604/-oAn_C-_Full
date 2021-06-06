using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Manager_Fortunes.BusinessObject;

namespace Manager_Fortunes.Datalayer
{
   public class NhapCongCuData
    {
       DataServices data = new DataServices();
       SqlCommand sqlCommand;
       public DataTable DSCongCu()
       {
           SqlCommand cmd = new SqlCommand("select * from NHAPCONGCU");
           data.Load(cmd);
           return data;
       }
       public DataTable MaCongCu(string id)
       {
           SqlCommand cmd = new SqlCommand("select * from NHAPCONGCU where MACONGCU=@id");
           cmd.Parameters.Add("@id", SqlDbType.NVarChar, 10).Value = id;
           return data;
       }
       public void NhapCongCu(CongCuInfo nhapcongcu)
       {
           sqlCommand = new SqlCommand();
           sqlCommand.CommandText = "insert into NHAPCONGCU(SOHOADON,MACONGCU,TENCONGCU,MANHOM,MADONVITINH,SOLUONG,NGUYENGIA,MUCKHAUHAO,DAKHAUHAO,CONLAI,NUOCSANXUAT,HANSUDUNG,LYDOTANG,NGAYTANG,NGAYKHAUHAO,MABOPHAN,MAPHONGBAN,MUCDICHSUDUNG,GHICHU)"+
              "values(@sohoadon,@macongcu,@tencongcu,@manhom,@madonvitinh,@soluong,@nguyengia,@muckhauhao,@dakhauhao,@conlai,@nuocsanxuat,@hansudung,@lydotang,@ngaytang,@ngaykhauhao,@mabophan,@maphongban,@mucdichsudung,@ghichu);";
           sqlCommand.Parameters.Add("@sohoadon", SqlDbType.NChar, 10).Value = nhapcongcu.Sohoadon;
           sqlCommand.Parameters.Add("@macongcu", SqlDbType.NChar, 10).Value = nhapcongcu.Macongcu;
           sqlCommand.Parameters.Add("@tencongcu", SqlDbType.NVarChar, 100).Value = nhapcongcu.Tencongcu;
           sqlCommand.Parameters.Add("@manhom", SqlDbType.NChar, 10).Value = nhapcongcu.Manhom;
           sqlCommand.Parameters.Add("@madonvitinh", SqlDbType.NChar, 10).Value = nhapcongcu.Madonvitinh;
           sqlCommand.Parameters.Add("@soluong", SqlDbType.Int).Value = nhapcongcu.Soluong;
           sqlCommand.Parameters.Add("@nguyengia", SqlDbType.Float).Value = nhapcongcu.Nguyengia;
           sqlCommand.Parameters.Add("@muckhauhao", SqlDbType.Float).Value = nhapcongcu.Muckhauhao;
           sqlCommand.Parameters.Add("@dakhauhao", SqlDbType.Float).Value = nhapcongcu.Dakhauhao;
           sqlCommand.Parameters.Add("@conlai", SqlDbType.Float).Value = nhapcongcu.Conlai;
           sqlCommand.Parameters.Add("@nuocsanxuat", SqlDbType.NVarChar, 100).Value = nhapcongcu.NuocSX;
           sqlCommand.Parameters.Add("@hansudung", SqlDbType.Float).Value = nhapcongcu.Hansudung;
           sqlCommand.Parameters.Add("@lydotang", SqlDbType.NVarChar, 100).Value = nhapcongcu.Lydotang;
           sqlCommand.Parameters.Add("@ngaytang", SqlDbType.DateTime).Value = nhapcongcu.Ngaytang;
           sqlCommand.Parameters.Add("@ngaykhauhao", SqlDbType.DateTime).Value = nhapcongcu.Ngaykhauhao;
           sqlCommand.Parameters.Add("@mabophan", SqlDbType.NChar, 10).Value = nhapcongcu.Mabophansudung;
           sqlCommand.Parameters.Add("@maphongban", SqlDbType.NChar, 10).Value = nhapcongcu.Maphongban;
           sqlCommand.Parameters.Add("@muchdichsudung", SqlDbType.NVarChar, 100).Value = nhapcongcu.Mucdichsudung;
           sqlCommand.Parameters.Add("@ghichu", SqlDbType.NVarChar,-1).Value = nhapcongcu.Ghichu;
           data.Load(sqlCommand);
           
       }
       public bool XoaCongCu(string Macongcu)
       {
           sqlCommand = new SqlCommand();
           sqlCommand.CommandText = "delete from NHAPCONGCU where MACONGCU=@macongcu";
           sqlCommand.Parameters.Add("@macongcu", SqlDbType.NChar, 10).Value = Macongcu;
           try
           {
               data.Update(sqlCommand);
               return true;
           }
           catch
           {
               return false;}
       }
    }
}
