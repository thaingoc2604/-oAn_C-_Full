using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using QLHSTPTTHSP.Initiation;
using QLHSTPTTHSP.BusinessObjects;

namespace QLHSTPTTHSP.DataLayer
{
    public class GiaoVienData
    {
        //MySqlCommand mySqlCommand;
        DataServices dataServices = new DataServices();
        

        /// <summary>
        /// Lấy n cột trong bảng giáo viên
        /// </summary>
        /// <param name="fieldName">tên trường cần lấy</param>
        /// <returns>n cột thuộc bảng </returns>
        //public DataTable LayBangGiaoVien(string fieldName1, string fieldName2)
        //{
        //    //mySqlCommand = new MySqlCommand("select " + fieldName1 + "," + fieldName2 + " from giao_vien;");
        //    mySqlCommand = new MySqlCommand("select * from giao_vien;");
        //    dataServices.Load(mySqlCommand);
        //    return dataServices;
        //}
    }
}
