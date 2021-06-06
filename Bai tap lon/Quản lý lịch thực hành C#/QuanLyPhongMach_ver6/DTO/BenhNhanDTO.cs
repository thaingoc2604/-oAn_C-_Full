using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BenhNhanDTO
    {
        private int _STTBN;
        private string _Hoten;
        private int _CMND;
        private string _DiaChi;
        private string _GioiTinh;
        private DateTime _NgayKham;
        private int _BacSiPhuTrach;


        public int STTBN
        {
            get { return _STTBN; }
            set { _STTBN = value; }
        }

        public string Hoten
        {
            get { return _Hoten; }
            set { _Hoten = value; }
        }

        public int CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public DateTime NgayKham
        {
            get { return _NgayKham; }
            set { _NgayKham = value; }
        }

        public int BacSiPhuTrach
        {
            get { return _BacSiPhuTrach; }
            set { _BacSiPhuTrach = value; }
        }

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        public BenhNhanDTO()
        {
            this._STTBN = 0;
            this._Hoten = string.Empty;
            //this._CMND = string.Empty;
            this._DiaChi = string.Empty;
            this._GioiTinh = "Nam";
            this._NgayKham = DateTime.Now;
            //this._BacSiPhuTrach = "Unknow";
        }

        public virtual int TinhTien()
        {
            int tongtien = 0;
            return tongtien;
        }
    }
}
