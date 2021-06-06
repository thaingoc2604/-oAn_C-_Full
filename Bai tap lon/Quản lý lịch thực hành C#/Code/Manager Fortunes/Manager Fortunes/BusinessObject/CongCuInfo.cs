using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Fortunes.BusinessObject
{
   public  class CongCuInfo
   {

       public CongCuInfo()
       { }
       public CongCuInfo(string MaCongCu, string TenCongCu)
       {
           this.m_Macongcu = Macongcu;
           this.m_Tencongcu = Tencongcu;
       }
       //public CongCuInfo()
       //{
 
       //}
        private string m_Sohoadon;
        public string Sohoadon
        {
            get { return m_Sohoadon; }
            set { value = m_Sohoadon; }
        }
        private string m_Macongcu;
        public string Macongcu
        {
            get { return m_Macongcu; }
            set { value = m_Macongcu; }
        }
        private string m_Tencongcu;
        public string Tencongcu
        {
            get { return m_Tencongcu; }
            set { value = m_Tencongcu; }
        }
        private string m_Manhom;
        public string Manhom
        {
            get { return m_Manhom; }
            set { value = m_Manhom; }
        }
        private string m_Madonvitinh;
       public string Madonvitinh
        {
            get { return m_Madonvitinh; }
            set { value = m_Madonvitinh; }
        }
        private string m_NuocSX;
        public string NuocSX
        {
            get { return m_NuocSX; }
            set { value = m_NuocSX; }
        }
        
        private int m_Hansudung;
        public int Hansudung
        {
            get { return m_Hansudung; }
            set { value = m_Hansudung; }
        }
        private string m_Lydotang;
        public string Lydotang
        {
            get { return m_Lydotang; }
            set { value = m_Lydotang; }
        }
        private DateTime m_Ngaytang;
        public DateTime Ngaytang
        {
            get { return m_Ngaytang; }
            set { value = m_Ngaytang; }
        }
       private DateTime m_Ngaykhauhao;
       public DateTime Ngaykhauhao
       {
           get { return m_Ngaykhauhao; }
           set { value = m_Ngaykhauhao; }
       }
                
        private int m_Soluong;
        public int Soluong
        {
            get { return m_Soluong; }
            set { value = m_Soluong; }
        }
        private float m_Nguyengia;
        public float Nguyengia
        {
            get { return m_Nguyengia; }
            set { value = m_Nguyengia; }
        }
       
        private float m_Muckhauhao;
        public float Muckhauhao
        {
            get { return m_Muckhauhao; }
            set { value = m_Muckhauhao; }
        }
        private float m_Dakhauhao;
        public float Dakhauhao
        {
            get { return m_Dakhauhao; }
            set { value = m_Dakhauhao; }
        }
        private float m_Conlai;
        public float Conlai
        {
            get { return m_Conlai; }
            set { value = m_Conlai; }
        }
      
        private string m_Bophansudung;
        public string Bophansudung
        {
            get { return m_Bophansudung; }
            set { value = m_Bophansudung; }
        }
       string m_Mabophansudung;
       public string Mabophansudung
       {
           get { return m_Mabophansudung; }
           set { m_Mabophansudung = value; }
       }
        private string m_Maphongban;
        public string Maphongban
        {
            get { return m_Maphongban; }
            set { value = m_Maphongban; }
        }
        private string m_Mucdichsudung;
        public string Mucdichsudung
        {
            get { return m_Mucdichsudung; }
            set { value = m_Mucdichsudung; }
        }
       private string m_Ghichu;
       public string Ghichu
       {
           get { return m_Ghichu; }
           set { value = m_Ghichu; }
       }

   }
}
