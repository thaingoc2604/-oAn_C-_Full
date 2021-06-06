using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Accounting
{
    public class ReadXML
    {
        private List<string> XMLlist = null;
        public ReadXML()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public List<string> LoadXML(string xmlpath)
        {
            XMLlist = new List<string>();
            XmlDocument doc = new XmlDocument();
            try
            {

                doc.Load(xmlpath + "\\XMlConfig\\Information.xml");
                XmlElement root = doc.DocumentElement;
                XmlNode ServerName = root.SelectSingleNode("ServerName");
                XmlNode DaTaName = root.SelectSingleNode("DaTaName");
                XmlNode LoginName = root.SelectSingleNode("LoginName");
                XmlNode Password = root.SelectSingleNode("Password");

                if (ServerName == null || DaTaName == null || LoginName == null || Password == null) return null;
                string Sname = ServerName.InnerText;
                XMLlist.Add(Sname);

                string DName = DaTaName.InnerText;
                XMLlist.Add(DName);

                string LName = LoginName.InnerText;
                XMLlist.Add(LName);

                string Pass = Password.InnerText;
                XMLlist.Add(Pass);

              
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }

            return XMLlist;

        }
    }
}
