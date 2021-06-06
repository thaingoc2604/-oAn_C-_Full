using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class QuaTrinhDaoTaoInfo
    {
        #region Ham Tao       
        public QuaTrinhDaoTaoInfo()
        {
        }

        public QuaTrinhDaoTaoInfo(String maQTDT, string maNV, string namNhapHoc, string namTotNghiep, String noiDaoTao, String nganhDaoTao, String hinhThucDaotao, String bangDuocCap)
        {
            MaQuaTrinhDaoTao = maQTDT;
            MaNhanVien = maNV;
            NamNhapHoc = namNhapHoc;
            NamTotNghiep = namTotNghiep;
            NoiDaoTao = noiDaoTao;
            NganhDaoTao = nganhDaoTao;
            HinhThucDaoTao = hinhThucDaotao;
            BangDuocCap = bangDuocCap;

        }
        #endregion

        #region MAQTDT
        private string m_QTDT;
        public string MaQuaTrinhDaoTao
        {
            get { return m_QTDT; }
            set { m_QTDT = value; }
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

        #region NAMNHAPHOC
        private string m_NAMNHAPHOC;
        public string NamNhapHoc
        {
            get { return m_NAMNHAPHOC; }
            set { m_NAMNHAPHOC = value; }
        }
        #endregion

        #region NAMTOTNGHIEP
        private string m_NAMTOTNGHIEP;
        public string NamTotNghiep
        {
            get { return m_NAMTOTNGHIEP; }
            set { m_NAMTOTNGHIEP = value; }
        }
        #endregion

        #region NOIDAOTAO(nvarchar(255),Null)
        private String m_NOIDAOTAO;
        public String NoiDaoTao
        {
            get { return m_NOIDAOTAO; }
            set { m_NOIDAOTAO = value; }
        }
        #endregion

        #region NGANHDAOTAO(nvarchar(255),Null)
        private String m_NGANHDAOTAO;
        public String NganhDaoTao
        {
            get { return m_NGANHDAOTAO; }
            set { m_NGANHDAOTAO = value; }
        }
        #endregion

        #region HINHTHUCDAOTAO(nvarchar(255),Null)
        private String m_HINHTHUCDAOTAO;
        public String HinhThucDaoTao
        {
            get { return m_HINHTHUCDAOTAO; }
            set { m_HINHTHUCDAOTAO = value; }
        }
        #endregion

        #region BANGDUOCCAP(nvarchar(255),Null)
        private String m_BANGDUOCCAP;
        public String BangDuocCap
        {
            get { return m_BANGDUOCCAP; }
            set { m_BANGDUOCCAP = value; }
        }
        #endregion
    }
}
