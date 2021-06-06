using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Fortunes.BusinessObject
{
    public class LyDo
    {
        public LyDo()
        {

        }
        private string m_MaLyDo;
        public string MaLyDo
        {
            get { return m_MaLyDo; }
            set { m_MaLyDo = value; }
        }

        private string m_TenLyDo;
        public string TenLyDo
        {
            get { return m_TenLyDo; }
            set { m_TenLyDo = value; }
        }
    }
}
