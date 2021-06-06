using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo ;
//học cách viết từ web
namespace DETAI
{
    class clsdocfile
    {
        public string strLine1, strLine2, strLine3, strLine4;
        public void docfile()
        {            
            try
            {
                FileStream aFile = new FileStream("book.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                string input;
                int i = 1;
                while ((input = sr.ReadLine()) != null)
                {
                    switch (i)
                    {
                        case 1:
                            strLine1 = input;                            
                            i++;
                            break;
                        case 2:
                            strLine2 = input;
                            i++;
                            break;
                        case 3:
                            strLine3 = input;
                            i++;
                            break;
                        case 4:
                            strLine4 = input;                            
                            i++;
                            break;
                    }
                }
                aFile.Close();
                sr.Close();             
            }
            catch 
            {               
                MessageBox.Show("File lưu trữ tên sever và database không tồn tại","Thông báo");
                Application.Exit();
            }            
        }
        public void ghifile(string line1,string line2,string line3,string line4)
        {
            FileStream aFile = new FileStream("book.txt", FileMode.Open);
            StreamWriter strwriter = new StreamWriter(aFile, Encoding.UTF8);
            strwriter.WriteLine("server:"+line1);
            strwriter.WriteLine("database:"+line2);
            strwriter.WriteLine("username:"+line3);
            strwriter.WriteLine("pass:"+line4);
            strwriter.Flush();
            strwriter.Close();
            aFile.Close();
        }
    }
}
