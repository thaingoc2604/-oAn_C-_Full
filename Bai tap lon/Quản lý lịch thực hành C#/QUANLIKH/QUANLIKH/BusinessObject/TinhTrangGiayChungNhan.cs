using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLIKH.BusinessObject
{
    public class TinhTrangGiayChungNhan
    {
        private int _MATINHTRANG;

        public int MATINHTRANG
        {
            get { return _MATINHTRANG; }
            set { _MATINHTRANG = value; }
        }
        private string _TENTINHTRANG;

        public string TENTINHTRANG
        {
            get { return _TENTINHTRANG; }
            set { _TENTINHTRANG = value; }
        }
    }
}
