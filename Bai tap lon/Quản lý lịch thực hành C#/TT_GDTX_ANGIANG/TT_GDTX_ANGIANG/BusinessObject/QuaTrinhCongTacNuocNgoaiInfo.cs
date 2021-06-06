using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuaTrinhCongTacNuocNgoaiInfo
    {
         #region Ham Tao       
        public QuaTrinhCongTacNuocNgoaiInfo()
        {
        }

        public QuaTrinhCongTacNuocNgoaiInfo(string maQTCTNN, string maNV, String nuocCongTac, String tenCoQuan, String mucDich, DateTime tuNgay, DateTime denNgay)
        {
            MaQuaTrinhCongTacNuocNgoai = maQTCTNN;
            MaNhanVien = maNV;
            TuNgay = tuNgay;
            DenNgay = denNgay;
            NuocCongTac = nuocCongTac;
            TenCoQuan = tenCoQuan;
            MucDich = mucDich;
           

        }
        #endregion

        #region MAQTCT
        private string m_QTCT;
        public string MaQuaTrinhCongTacNuocNgoai
        {
            get { return m_QTCT; }
            set { m_QTCT = value; }
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

        #region TUNGAY
        private DateTime m_TUNGAY;
        public DateTime TuNgay
        {
            get { return m_TUNGAY; }
            set { m_TUNGAY = value; }
        }
        #endregion

        #region DENNGAY
        private DateTime m_DENNGAY;
        public DateTime DenNgay
        {
            get { return m_DENNGAY; }
            set { m_DENNGAY = value; }
        }
        #endregion

        #region NUOCCONGTAC
        private String m_NUOCCONGTAC;
        public String NuocCongTac
        {
            get { return m_NUOCCONGTAC; }
            set { m_NUOCCONGTAC = value; }
        }
        #endregion

        #region TENCOQUAN
        private String m_TENCOQUAN;
        public String TenCoQuan
        {
            get { return m_TENCOQUAN; }
            set { m_TENCOQUAN = value; }
        }
        #endregion

        #region MUCDICH
        private String m_MUCDICH;
        public String MucDich
        {
            get { return m_MUCDICH; }
            set { m_MUCDICH = value; }
        }
        #endregion
    }
}
