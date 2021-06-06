using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DonThuocDTO
    {
        private int _sttDT;
        private string _TenThuoc;
        private DateTime _NgayCapThuoc;
        private int _TienThuoc;

        public int sttDT
        {
            get { return _sttDT; }
            set { _sttDT = value; }
        }

        public string TenThuoc
        {
            get { return _TenThuoc; }
            set { _TenThuoc = value; }
        }

        public DateTime NgayCapThuoc
        {
            get { return _NgayCapThuoc; }
            set { _NgayCapThuoc = value; }
        }

        public int TienThuoc
        {
            get { return _TienThuoc; }
            set { _TienThuoc = value; }
        }

        public DonThuocDTO()
        {
            this._TenThuoc = string.Empty;
            this._NgayCapThuoc = DateTime.Now;
            this._TienThuoc = 0;
        }

        public virtual int TongTienThuoc(int tienthuoc)
        {
            return tienthuoc;
        }
    }
}
