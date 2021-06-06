using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Accounting
{
    public class WriteXML
    {
        // private string _LogoPath = string.Empty;
        private string _BannerPath = string.Empty;
        private string _CompanyName = string.Empty;
        private string _AdminEmail = string.Empty;
        private string _CompanyIntroduction = string.Empty;
        private string _CompanyAddress = string.Empty;
        private string _CompanyPhone = string.Empty;
        public WriteXML(string BannerPath, string CompanyName, string AdminEmail, string CompanyAddress, string CompanyPhone, string CompanyIntroduction)
        {
            //_LogoPath = LogoPath;
            _BannerPath = BannerPath;
            _CompanyName = CompanyName;
            _AdminEmail = AdminEmail;
            _CompanyIntroduction = CompanyIntroduction;
            _CompanyAddress = CompanyAddress;
            _CompanyPhone = CompanyPhone;
        }
        public void SaveXML(string xmlPath)
        {

            XmlTextWriter writer = new XmlTextWriter(xmlPath + "\\XMlConfig\\Information.xml", null);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 6;
            writer.WriteStartDocument();
            writer.WriteStartElement("Information");

            //writer.WriteStartElement("LogoPath");
            //writer.WriteString(_LogoPath);
            //writer.WriteEndElement();

            writer.WriteStartElement("BannerPath");
            writer.WriteString(_BannerPath);
            writer.WriteEndElement();

            writer.WriteStartElement("CompanyName");
            writer.WriteString(_CompanyName);
            writer.WriteEndElement();

            writer.WriteStartElement("AdminEmail");
            writer.WriteString(_AdminEmail);
            writer.WriteEndElement();

            writer.WriteStartElement("CompanyAddress");
            writer.WriteString(_CompanyAddress);
            writer.WriteEndElement();

            writer.WriteStartElement("CompanyPhone");
            writer.WriteString(_CompanyPhone);
            writer.WriteEndElement();

            writer.WriteStartElement("CompanyIntroduction");
            writer.WriteString(_CompanyIntroduction);
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();




        }
    }
}
