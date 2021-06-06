using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BacSiDTO
    {
        private int _sttBS;
        private string _TenBacSi;
        private string _UserName;
        private string _PassWord;
        private string _DiaChi;
        private float _DienThoai;

        public int sttBS
        {
            get { return _sttBS; }
            set { _sttBS = value; }
        }

        public string TenBacSi
        {
            get { return _TenBacSi; }
            set { _TenBacSi = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public float SoDienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        public BacSiDTO()
        {
            this._TenBacSi = string.Empty;
            this._UserName = "UnKnow";
            this._PassWord = "UnKnow";
            this._DiaChi = string.Empty;
            this._DienThoai = 0000000000;
        }
    }
}
