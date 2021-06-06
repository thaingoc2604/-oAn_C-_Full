using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DTO;
namespace BUS_Tier
{
    public class bDeThi
    {
        public int count = 0; //tổng số câu hỏi của đề thi
        public int time = 0;//thời gian cho mỗi câu hỏi
        public List<bCauHoi> cauhoi = new List<bCauHoi>();
        public void Themcauhoi(string noidung, string dapan, string dapandung, string mucdo, string tinchi, int time)
        {
            bCauHoi ch = new bCauHoi();
            ch.noi_dung = noidung;
            ch.dap_an = dapan;
            ch.muc_do = mucdo;
            ch.dap_an_dung = dapandung;
            ch.tin_chi = tinchi;
            this.time = time;
            cauhoi.Add(ch);//thêm câu hỏi vào danh sách
            count++;
        }
        //gọi khi nhập đề thi từ file
        public void ThemTuFile(string path)
        {
            try
            {
                bMaHoavaGiaiMa m = new bMaHoavaGiaiMa();//giải mã câu hỏi
                string[] s = File.ReadAllLines(path);
                this.time = int.Parse(m.giaima(s[0]));
                for (int i = 1; i < s.Length; i++)
                {
                    s[i] = m.giaima(s[i]);
                    if (s[i] != "" && s[i].IndexOf(';') > 0)
                    {
                        string[] s2 = s[i].Split(';');
                        Themcauhoi(s2[0], s2[1] + ";" + s2[2] + ";" + s2[3] + ";" + s2[4], s2[5], s2[6], s2[7], this.time);
                    }
                }
            }
            catch
            {
                //throw new Exception();
            }
        }

        //gọi khi nhập từ 1 listview trong phần tạo bộ đề thi trắc nghiệm
        public int TongSo()
        {
            return this.count;//số câu hỏi trong đề thi
        }
    }
}
