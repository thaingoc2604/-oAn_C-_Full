using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLIKH.BusinessObject
{
   public class KhachHang
    {
        private int _MAKH;

        public int MAKH
        {
            get { return _MAKH; }
            set { _MAKH = value; }
        }
        private string _HOVATEN;

       public string HOVATEN
        {
            get { return _HOVATEN; }
            set { _HOVATEN = value; }
        }
       private string _DIACHI;

       public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _BIENSO;

        public string BIENSO
        {
            get { return _BIENSO; }
            set { _BIENSO = value; }
        }
        private string _SOKHUNG;

        public string SOKHUNG
        {
            get { return _SOKHUNG; }
            set { _SOKHUNG = value; }
        }
        private string _SOMAY;

        public string SOMAY
        {
            get { return _SOMAY; }
            set { _SOMAY = value; }
        }
    }
}
