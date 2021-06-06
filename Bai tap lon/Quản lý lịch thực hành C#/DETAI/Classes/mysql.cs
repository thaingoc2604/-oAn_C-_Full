using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Windows.Forms;
namespace DETAI
{
    public class mysql
    {
        private string user = "";
        
        private string scon = "";
        public string GetUser()
        {
            return user;
        }
        public mysql(string servername, string data, string u, string p)
        {
            scon = "server=" + servername.Trim() + ";database=" + data.Trim() +
                ";uid=" + u.Trim() + ";pwd=" + p.Trim();
            user = u.Trim();
        }
        public mysql(mysql sql)
        {
            scon = sql.scon;
            user = sql.user;
        }
        public SqlConnection getCon()

        {
            return new SqlConnection(scon);
        }
        public static void ExecuteNonQuery(
            string sql,
            CommandType commandType,
            params object[] pars)
        {
            mysql c=new mysql(frmMain.me.libsql);
            SqlConnection con =c.getCon() ;
            con.Open();

            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = commandType;

            for (int i = 0; i < pars.Length; i += 2)
            {
                SqlParameter par = new SqlParameter(pars[i].ToString(),
                    pars[i + 1]);
                com.Parameters.Add(par);
            }
            try
            {
                com.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                if (e.Number == 2627)
                    MessageBox.Show("Mã này đã tồn tại", "Thông Báo");
                else
                {
                    //MessageBox.Show("" + e.Number + " " + e.Errors + e.Message);
                    MessageBox.Show("Không thể thực hiện", "Thông Báo");
                }

            }
        }
        //hàm trả về ngày từ một chuỗi nhập vào textbox, flag =0 :laydl len, flag=1 :them
        static public DateTime TraVeNgay(string s, int flag)
        {
            int ngay = 0, thang = 0, nam = 0;
            string m = s;
            nam = Int32.Parse(s.Substring(s.Length - 4, 4));
            s = s.Substring(0, s.Length - 4);
            for (int i = s.Length; i > 0; i--)
                if (s.Contains("/") == true) s = s.Substring(0, s.Length - 1);
            thang = Int32.Parse(s);
            ngay = Int32.Parse(m.Substring(s.Length + 1, 
                m.Length - 6 - s.Length));
            return flag == 0 ? new DateTime(nam, thang, ngay) : new DateTime(nam, ngay, thang);
        }

        //ham trả ngày về chuỗi
        static public string NgayToString(string n)
        {
            if(n=="") return "";
            n = n.Substring(0, 10);
            for (int i = 0; i < n.Length; i++)
            {
                if (n.Contains(" ") == true)
                    n = n.Substring(0, 10 - i - 1);
                else break;
            }
            DateTime d = TraVeNgay(n, 0);
            string ng = "", th = "", na = "";
            ng = d.Day.ToString();
            th = d.Month.ToString();
            na = d.Year.ToString();
            return ng + "/" + th + "/" + na;
        }

        //ham kiem tra ngay
        static public bool KiemTraNgay(string s)
        {
            try
            {
                string snam = s.Substring(s.LastIndexOf("/") + 1, 
                    s.Length - s.LastIndexOf("/") - 1);
                string sngay = s.Substring(0, s.IndexOf("/"));
                string sthang = s.Substring(s.IndexOf("/") + 1, 
                    s.Length - sngay.Length - snam.Length - 2);
                int nam = int.Parse(snam);
                int thang = int.Parse(sthang);
                int ngay = int.Parse(sngay);

                if ((nam < 1900) || (nam > 9999))
                    return false;
                if ((thang > 12) || (thang < 1))
                    return false;
                else
                {
                    switch (thang)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (ngay > 31)
                                return false;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (ngay > 30)
                                return false;
                            break;
                        default:
                            if ((nam % 4) == 0 && (nam % 100) != 0 || (nam % 1000) == 0)
                            {
                                if (ngay > 29)
                                    return false;
                            }
                            else
                                if (ngay > 28)
                                    return false;
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng ngày", "Thông báo");

            }

            return true;
        }
        
    }
    
    
}
