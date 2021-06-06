using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS_Tier
{
    public class bMaHoavaGiaiMa
    {
        char tach = ':';//kí hiệu phân tách
        public string mahoa(string chuoi)
        {
            //mã hóa
            try
            {
                string s = "";
                byte[] bit = Encoding.Unicode.GetBytes(chuoi);//chuyển chuỗi về mảng byte
                for (int i = 0; i < bit.Length; i++)
                {
                    s += bit[i];
                    if (i < bit.Length - 1) s += tach.ToString();//byte cuối ko cần kí hiệu phân tách
                } return s;//trả về chuỗi đã được mã hóa            
            }
            catch { return ""; }
        }
        public string giaima(string chuoi)
        {
            //giải mã 
            try
            {
                List<byte> bit = new List<byte>();//vì chưa rõ số phần tử nên phải dùng List thay cho mảng byte                                
                string[] temp = chuoi.Split(tach);
                for (int i = 0; i < temp.Length; i++)
                {
                    bit.Add(new byte());//thêm 1 phần tử vào list byte
                    if (temp[i] != "") bit[i] = byte.Parse(temp[i]);
                }
                return Encoding.Unicode.GetString(bit.ToArray());//trả về string ban đầu trước khi mã hóa
            }
            catch { return ""; }
        }
    }
}
