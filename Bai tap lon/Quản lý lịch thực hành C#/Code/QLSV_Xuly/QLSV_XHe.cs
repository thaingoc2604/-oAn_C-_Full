using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSV_Database;
using System.Data;
using System.Windows.Forms;
namespace QLSV_Xuly
{
    public class QLSV_XHe
    {
        QLSV_DHe qlsv_dHe = new QLSV_DHe();

        private string Mahe;
        private string ghichu;
        private string Tenhe;

        public string MAHE
        {
            get { return Mahe; }
            set { Mahe = value; }
        }
       

        public string TENHE
        {
            get { return Tenhe; }
            set { Tenhe = value; }
        }
       

        public string GHICHU
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dHe.LoadDL_He();
            return dt;
        }

        public void ThemHe()
        {
            try
            {
                qlsv_dHe.ThemHe(MAHE, TENHE, GHICHU);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        public void CapNhatHe()
        {
            try
            {
              
                qlsv_dHe.CapNhatHe(MAHE, TENHE, GHICHU);
            }
            catch
            {

            }
        }
        public void XoaHe()
        {
            try
            {
                qlsv_dHe.XoaHe(MAHE);
            }
            catch
            { 
            
            }
        }

        public string TaoMaHe()
        {
            string ma = "";
            try
            {
               ma = qlsv_dHe.TaoMaHe();
            }
            catch

            { 
            
            }
            return ma;
        }
    }
}
