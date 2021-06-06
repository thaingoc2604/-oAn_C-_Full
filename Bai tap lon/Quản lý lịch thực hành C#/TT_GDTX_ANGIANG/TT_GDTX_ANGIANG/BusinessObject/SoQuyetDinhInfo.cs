using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class SoQuyetDinhInfo
    {
        #region Constructor
        public SoQuyetDinhInfo()
        {
        }

        public SoQuyetDinhInfo(string maSoQD, DateTime ngayQD,String loaiQD,  String noiDung, String nguoiQD, String chucVu)
        {
            MaSoQuyetDinh = maSoQD;
            NgayQuyetDinh = ngayQD;
            LoaiQuyetDinh = loaiQD;
            NoiDung = noiDung;
            NguoiQuyetDinh = nguoiQD;
            ChucVu = chucVu;
        }

        public SoQuyetDinhInfo(string maSoQD, String loaiQD)
        {
            MaSoQuyetDinh = maSoQD;
            LoaiQuyetDinh = loaiQD;
        }
               
        #endregion

        #region MASOQD
        private string m_MASOQD;
        public string MaSoQuyetDinh
        {
            get { return m_MASOQD; }
            set { m_MASOQD = value; }
        }
        #endregion

        #region NGAYQD
        private DateTime m_NGAYQD;
        public DateTime NgayQuyetDinh
        {
            get { return m_NGAYQD; }
            set { m_NGAYQD = value; }
        }
        #endregion

        #region LOAIQD
        private String m_LOAIQD;
        public String LoaiQuyetDinh
        {
            get { return m_LOAIQD; }
            set { m_LOAIQD = value; }
        }
        #endregion


        #region NOIDUNG
        private String m_NOIDUNG;
        public String NoiDung
        {
            get { return m_NOIDUNG; }
            set { m_NOIDUNG = value; }
        }
        #endregion

        #region NGUOIQD
        private String m_NGUOIQD;
        public String NguoiQuyetDinh
        {
            get { return m_NGUOIQD; }
            set { m_NGUOIQD = value; }
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
    }
}
