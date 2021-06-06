using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Fortunes.BusinessObject
{
   public class ThueTaiSan
    {
        public ThueTaiSan()
        {
            m_NhomTaiSanCongCu = new NhomTaiSanCongCu();
            m_DonViTinh = new DonViTinh();
            m_PhongBan = new PhongBan();
            m_DiaDiem = new DiaDiem();
            m_LyDoTang = new LyDo();
        }
        
        private string m_MaPhieuThe;
        public string MaPhieuthue
        {
            get { return m_MaPhieuThe; }
            set { m_MaPhieuThe = value; }
        }
        
        private string m_MaTaiSan;
        public string MaTaiSan
        {
            get { return m_MaTaiSan; }
            set { m_MaTaiSan = value; }
        }

        private string m_TenTaiSan;
        public string TenTaiSan
        {
            get { return m_TenTaiSan; }
            set { m_TenTaiSan = value; }
        }

        private NhomTaiSanCongCu m_NhomTaiSanCongCu;
        public NhomTaiSanCongCu NhomTaiSanCongCu
        {
            get { return m_NhomTaiSanCongCu; }
            set { m_NhomTaiSanCongCu = value; }
        }

        private DonViTinh m_DonViTinh;
        public DonViTinh DonViTinh
        {
            get { return m_DonViTinh; }
            set { m_DonViTinh = value; }
        }

        private LyDo m_LyDoTang;
        public LyDo LyDoTang
        {
            get { return m_LyDoTang; }
            set { m_LyDoTang = value; }
        }

        private DateTime m_NgayTang;
        public DateTime NgayTang
        {
            get { return m_NgayTang; }
            set { m_NgayTang = value; }
        }

        private int m_SoLuong;
        public int SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

        private float m_GiaThue;
        public float GiaThue
        {
            get { return m_GiaThue; }
            set { m_GiaThue = value; }
        }

        private float m_ThanhTien;
        public float ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }

        private float m_DaThanhToan;
        public float DaThanhToan
        {
            get { return m_DaThanhToan; }
            set { m_DaThanhToan = value; }
        }

        private float m_ConLai;
        public float ConLai
        {
            get { return m_ConLai; }
            set { m_ConLai = value; }
        }

        private DateTime m_ThoigianSudung;
        public DateTime ThoigianSudung
        {
            get { return m_ThoigianSudung; }
            set { m_ThoigianSudung = value; }
        }

        private string m_BoPhanSudung;
        public string BoPhanSuDung
        {
            get { return m_BoPhanSudung; }
            set { m_BoPhanSudung = value; }
        }

        private string m_MucDich;
        public string MucDich
        {
            get { return m_MucDich; }
            set { m_MucDich = value; }
        }

        private PhongBan m_PhongBan;
        public PhongBan PhongBan
        {
            get { return m_PhongBan; }
            set { m_PhongBan = value; }
        }


       private DiaDiem m_DiaDiem;
       public DiaDiem DiaDiem
       {
           get { return m_DiaDiem; }
           set { m_DiaDiem = value; }
       }
    }
}
