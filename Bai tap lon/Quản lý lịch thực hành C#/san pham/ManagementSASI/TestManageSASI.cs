using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManagementSASI
{
    class TestManageSASI
    {
        private string Ltrim(string s)//xoa trrai dau cach
        {
            string tmp = string.Copy(s);
            while (tmp[0] == ' ')
            {
                tmp = tmp.Remove(0, 1);//no se tim o vi tri nao va de xoa di
            } return tmp;
        }
        private string Rtrim(string s)//xoa phai dau cach
        {
            string tmp = string.Copy(s);
            while (tmp[tmp.Length - 1] == ' ')
            {
                tmp = tmp.Remove(tmp.Length - 1, 1);//tim o vi tri cuoi vi bat dau là 0 va xoa di
            } return tmp;
        }
        private string Trim(string s)
        {
            string tmp = string.Copy(s);
            tmp = Ltrim(s); tmp = Rtrim(s);
            while (tmp.IndexOf("  ") > 0)
            {
                tmp = tmp.Remove(tmp.IndexOf("  "), 1);//tim thay ki tu rong lien tiep thi xoa bot di con 1

            }
            return tmp;
        }

       
        public string Standardized(string s)
        {
            string tmp = string.Copy(s);
            tmp = Trim(tmp);//xoa 2 dau cach lien nhau de lai 
            StringBuilder t = new StringBuilder(tmp);
            t[0] = char.ToUpper(t[0]);
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == ' ')
                    t[i + 1] = char.ToUpper(t[i + 1]);
            }
            tmp = t.ToString();
            return tmp;
        }


        public  string Standardized1(string s)
        {
            string tmp = string.Copy(s);
            tmp = Trim(tmp);//xoa 2 dau cach lien nhau de lai 
            StringBuilder t = new StringBuilder(tmp);
            t[0] = char.ToUpper(t[0]);
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == ' ')
                    t[1] = char.ToUpper(t[1]);
            }
            tmp = t.ToString();
            return tmp;
        }

        public string Standardized2(string s)
        {
            string tmp = string.Copy(s);
            tmp = Trim(tmp);//xoa 2 dau cach lien nhau de lai 
            StringBuilder t = new StringBuilder(tmp);
            t[0] = char.ToUpper(t[0]);
            tmp = t.ToString();
            return tmp;
        }
        //
        public bool NumbericEntryOnly(char ey)
        {
            if ((ey > '0' && ey < '9') || (ey < 'a' && ey > 'z'))
            {
                return false;
            }
            return true;
        }

        public bool ABCAlphabetEmTryOnly(char ey)
        {
            if ((ey < '0' && ey > '9') || (ey > 'a' && ey < 'z') || (ey > 'A' && ey < 'Z'))
            {
                return false;
            }
            return true;
        }

        public static string ToString(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }

        public static string ToString(double number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            double decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDouble(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }


        static bool test = true;
        static frmClass frmclass = null;
        static frmStudentToRegisters frmstr = null;
        static frmSASIClass frmsasiclass = null;

        //frmStudentToRegisters frmstr = new frmStudentToRegisters();
        public void ShowfrmSASIClass()
        {
            if (test)
            {
                if (frmsasiclass == null || frmsasiclass.IsDisposed)
                {
                    frmsasiclass = new frmSASIClass();
                    frmsasiclass.MdiParent = frmMain.ActiveForm;
                    frmsasiclass.WindowState = FormWindowState.Maximized;
                    frmsasiclass.Show();
                    frmsasiclass.Focus();
                }
                if (frmsasiclass != null)
                    frmsasiclass.Activate();
            }
            else
            {
                if (frmsasiclass != null)
                    frmsasiclass.Activate();
            }
            if (frmstr != null)
            {
                frmstr.Close();
            }


        }

        public void ShowfrmClass()
        {
            if (test)
            {
                if (frmclass == null || frmclass.IsDisposed)
                {
                    frmclass = new frmClass();
                    frmclass.MdiParent = frmMain.ActiveForm;
                    frmclass.WindowState = FormWindowState.Maximized;
                    frmclass.Show();
                    frmclass.Focus();
                }
                if (frmclass != null)
                    frmclass.Activate();
            }
            else
            {
                if (frmclass != null)
                    frmclass.Activate();
            }

        }

       
        public void ShowfrmStudentToRegisTer()
        {
            if (test)
            {
                if (frmstr == null || frmstr.IsDisposed)
                {
                    frmstr = new frmStudentToRegisters();
                    frmstr.MdiParent = frmMain.ActiveForm;
                    frmstr.WindowState = FormWindowState.Maximized;
                    frmstr.Show();
                    frmstr.Focus();
                }
                if (frmstr != null)
                    frmstr.Activate();
            }
            else
            {
                if (frmstr != null)
                    frmstr.Activate();
            }
            if (frmsasiclass != null)
            {
                frmsasiclass.Close();
            }
        }

      
    }
}
