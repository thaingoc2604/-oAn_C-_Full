using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLIKH.BusinessObject
{
    public class HopDong
    {
        private int _SOHOPDONG;

        public int SOHOPDONG
        {
            get { return _SOHOPDONG; }
            set { _SOHOPDONG = value; }
        }
        private int _MADAILY;

        public int MADAILY
        {
            get { return _MADAILY; }
            set { _MADAILY = value; }
        }
        private string _TENHOPDONG;

        public string TENHOPDONG
        {
            get { return _TENHOPDONG; }
            set { _TENHOPDONG = value; }
        }
        private string _NGAYKY;

        public string NGAYKY
        {
            get { return _NGAYKY; }
            set { _NGAYKY = value; }
        }
        private string _NGAYHETHAN;

        public string NGAYHETHAN
        {
            get { return _NGAYHETHAN; }
            set { _NGAYHETHAN = value; }
        }
        private string _NGAYTHANHLY;

        public string NGAYTHANHLY
        {
            get { return _NGAYTHANHLY; }
            set { _NGAYTHANHLY = value; }
        }
    }
}
