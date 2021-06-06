using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using EventManager.Enums;
using EventManager.DataAccess;
using System.Linq;

namespace EventManager.Utilities
{
    /// <summary>
    /// Class tiện ích. Gồm những phương thức tĩnh.
    /// </summary>
    public static class UtilitiesClass
    {
        /// <summary>
        /// Mã hóa chuỗi bằng MD5
        /// </summary>
        /// <param name="text">Chuỗi cần mã hóa</param>
        /// <returns>String: Chuỗi sau khi mã hóa</returns>
        public static string MaHoaMD5(string text)
        {
            text = text.Trim();
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            //chuyển chuỗi truyền vào sang khối các byte
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            //băm MD5
            bytes = md5Hasher.ComputeHash(bytes);
            StringBuilder str = new StringBuilder();
            foreach (byte b in bytes)
            {
                str.Append(b.ToString("x2"));
            }
            return str.ToString();
        }

        public static string SinhMaTuDong(TableNames tableName)
        {
            try
            {
                dbEventsManagementDataContext db = new dbEventsManagementDataContext();
                string id = "", newId;
                
                if (tableName == TableNames.NhanVien)
                {
                    var x = db.NhanViens.OrderByDescending(nv => nv.MaNV).Take(1);
                    foreach (var i in x)
                    {
                        id = i.MaNV;
                    }
                    if(!string.IsNullOrEmpty(id))
                    {
                        newId = "NV" + (int.Parse(id.Substring(2)) + 1).ToString("000");
                        return newId;
                    }
                    return "NV001";
                }
                if (tableName == TableNames.ChuongTrinh)
                {
                    var x = db.ChuongTrinhs.OrderByDescending(nv => nv.MaCT).Take(1);
                    foreach (var i in x)
                    {
                        id = i.MaCT;
                    }
                    if (!string.IsNullOrEmpty(id))
                    {
                        newId = "CT" + (int.Parse(id.Substring(2)) + 1).ToString("000");
                        return newId;
                    }
                    return "CT001";
                }
                if (tableName == TableNames.KhachHang)
                {
                    var x = db.KhachHangs.OrderByDescending(nv => nv.MaKH).Take(1);
                    foreach (var i in x)
                    {
                        id = i.MaKH;
                    }
                    if (!string.IsNullOrEmpty(id))
                    {
                        newId = "KH" + (int.Parse(id.Substring(2)) + 1).ToString("000000");
                        return newId;
                    }
                    return "KH000001";
                }
                if (tableName == TableNames.ChiTietCT)
                {
                    var x = db.ChiTietCTs.OrderByDescending(ct => ct.ID).Take(1);
                    foreach (var i in x)
                    {
                        id = i.ID.ToString();
                    }
                    if (!string.IsNullOrEmpty(id))
                    {
                        newId = (int.Parse(id)+1).ToString();
                        return newId;
                    }
                    return "1";
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            return string.Empty;
        }
    }
}