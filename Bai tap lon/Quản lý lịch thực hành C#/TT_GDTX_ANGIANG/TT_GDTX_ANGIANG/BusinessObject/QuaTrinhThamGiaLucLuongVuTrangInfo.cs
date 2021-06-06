using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuaTrinhThamGiaLucLuongVuTrangInfo
    {
         #region Ham Tao       
        public QuaTrinhThamGiaLucLuongVuTrangInfo()
        {
        }

        public QuaTrinhThamGiaLucLuongVuTrangInfo(String maQTTGLLVT,string maNV, DateTime ngayNN,  DateTime ngayXN, String chucVu, String quanHamCaoNhat)
        {
            MaQuaTrinhThamGiaLucLuongVuTrang = maQTTGLLVT;
            MaNhanVien = maNV;
            NgayNN = ngayNN;
            NgayXN = ngayXN;
            ChucVu = chucVu;
            QuanHamCaoNhat = quanHamCaoNhat;           

        }
        #endregion

        #region MAQTTGLLVT
        private string m_QTTGLLVT;
        public string MaQuaTrinhThamGiaLucLuongVuTrang
        {
            get { return m_QTTGLLVT; }
            set { m_QTTGLLVT = value; }
        }
        #endregion

        #region MANHANVIEN
        private string m_MANHANVIEN;
        public string MaNhanVien
        {
            get { return m_MANHANVIEN; }
            set { m_MANHANVIEN = value; }
        }
        #endregion

        #region NGAYNN
        private DateTime m_NGAYNN;
        public DateTime NgayNN
        {
            get { return m_NGAYNN; }
            set { m_NGAYNN = value; }
        }
        #endregion

        #region NGAYXN
        private DateTime m_NGAYXN;
        public DateTime NgayXN
        {
            get { return m_NGAYXN; }
            set { m_NGAYXN = value; }
        }
        #endregion

        #region CHUCVU
        private String m_CHUCVU;
        public String ChucVu
        {
            get { return m_CHUCVU; }
            set { m_CHUCVU = value; }
        }
        #endregion

        #region QUANHAMCAONHAT(nvarchar(255),Null)
        private String m_QUANHAMCAONHAT;
        public String QuanHamCaoNhat
        {
            get { return m_QUANHAMCAONHAT; }
            set { m_QUANHAMCAONHAT = value; }
        }
        #endregion

        
    }
}
