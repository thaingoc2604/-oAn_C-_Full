using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLIKH.BusinessObject
{
    public class MucBaoHiem
    {
        private int _MALOAI;

        public int MALOAI
        {
            get { return _MALOAI; }
            set { _MALOAI = value; }
        }
        private string _PHIBAOHIEM;

        public string PHIBAOHIEM
        {
            get { return _PHIBAOHIEM; }
            set { _PHIBAOHIEM = value; }
        }
        private string _MUCTRACHNHIEM;
        public string MUCTRACHNHIEM
        {
            get { return _MUCTRACHNHIEM; }
            set { _MUCTRACHNHIEM = value; }
        }
        private string _DIENGIAI;

        public string DIENGIAI
        {
            get { return _DIENGIAI; }
            set { _DIENGIAI = value; }
        }
    }
}
