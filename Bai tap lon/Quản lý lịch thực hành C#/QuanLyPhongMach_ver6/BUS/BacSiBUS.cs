using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class BacSiBUS
    {
        public static List<BacSiDTO> SelectAllBacSi()
        {
            return BacSiDAO.SelectAllBacSi();
        }

        public static BacSiDTO SelectBacSiByID(string txtUser, string txtPass)
        {
            return BacSiDAO.SelectBacSiByID(txtUser, txtPass);
        }

        public static bool ChangePassWord(BacSiDTO bacsi,string Newpassword)
        {
            return BacSiDAO.ChangePassWord(bacsi,Newpassword);
        }

        public static List<BacSiDTO> SelectAllCacSiForTraCuu()
        {
            return BacSiDAO.SelectAllCacSiForTraCuu();
        }

        public static bool UpdateBacSi(BacSiDTO bacsi)
        {
            return BacSiDAO.UpdateBacSi(bacsi);
        }

        public static bool InsertBacSi(BacSiDTO bacsi)
        {
            return BacSiDAO.InsertBacSi(bacsi);
        }
    }
}
