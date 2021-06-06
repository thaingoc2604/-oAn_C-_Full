using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLIKH.BusinessObject
{
   public  class NguoiDung
    {
        private int m_ID;

        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        private string m_UserName;

        public string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }
        private string m_Password;

        public string PassWord
        {
            get { return m_Password; }
            set { m_Password = value; }
        }
        private int m_Authorizatior;

        public int Authorizator
        {
            get { return m_Authorizatior; }
            set { m_Authorizatior = value; }
        }
        public NguoiDung()
        {

        }
        public NguoiDung(int id, string username, string pass, int authority)
        {
            m_ID = id;
            m_UserName = username;
            m_Password = pass;
            m_Authorizatior = authority;
        }
    }
}
