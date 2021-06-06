using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DonThuoc_BenhNhanNamGiuong_DaXepChoDTO : DonThuocDTO
    {
        public override int TongTienThuoc(int tienthuoc)
        {
            return base.TongTienThuoc(tienthuoc)-(10*base.TongTienThuoc(tienthuoc)/100);
        }
    }
}
