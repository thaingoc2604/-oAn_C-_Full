using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QuanLyTV
{
    class AccessHelper
    {
        
        public OleDbConnection connection;
        public OleDbDataAdapter adapter;
        public DataSet dataset;
        public OleDbCommand command;
        public int KetNoi = 0;
        public static string TenNhanVienDangNhap = "";
        public static string MaNhanVienDangNhap = "";
        public static int TruyCap;
        public static int luutrusach = 0;
        public static int Mo = 0;
        public void KetNoiData()
        {
             try
            {
                string connectionString;
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
                connection = new OleDbConnection(connectionString);
                
                connection.Open();
                KetNoi = 1 ;
              
                

            }
            catch(Exception b)

            {
                MessageBox.Show("Loi : " + b.Message);
            }
            
        }

        public DataTable ExecuteDataTable(  string sql )
        {
            
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);

            DataSet dataset = new DataSet(); // 1 tap cac data table
            
            adapter.Fill(dataset);
           
            return dataset.Tables[0];
            
            
           
        }

        public void ExecuteNonQuery(string sql)
        {
            KetNoiData();
            try
            {
                command = new OleDbCommand(sql,connection);
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public string XuLiMaSach(string a)
        {
            string KetQua = "";
            string[] DB = new string[] { "KT", "PL", "KH", "MT", "AR", "XH", "TN", "LS", "VH" };
            string[] TheLoai = new string[] { "Kinh Tế", "Pháp Luật", "Khoa Học", "Công Nghệ Thông Tin", "Kiến Trúc", "Xã Hội", "Tự Nhiên", "Lịch Sử", "Văn Học" };
            a = a.ToUpper();
            char[] charSeparators = new char[] { '-' };
            string[] result;
            result = a.Split(charSeparators, StringSplitOptions.None);
            for (int i = 0; i < 9; i++)
            {
                if (string.Equals(result[0], DB[i]))
                {
                    KetQua = KetQua + "Sách thuộc thể loại : " + TheLoai[i] + "\nNằm ở tủ thứ : " + result[1] + " \nThuộc ngăn thứ : " + result[2];
                }
            }
            return KetQua;
        }
        
            public int SoSanhMaSach(string a,string b)
        {
            
            
            
            a = a.ToUpper();
            char[] charSeparators = new char[] { '-' };
            string[] result;
            result = a.Split(charSeparators,StringSplitOptions.None);
            for (int i = 0; i < 9; i++)
            { 
                if(string.Equals(result[0],b))
                {
                    return 1;
                }
            }
            return 0;

        }
        public int SoSanhTenSach(string a, string b)
        {



            a = a.ToLower();
            
            for (int i = 0; i < 9; i++)
            {
                if (string.Equals(a,b))
                {
                    return 1;
                }
            }
            return 0;

        }

        public string XuLiNgay(string a)
        {
            char[] charSeparators = new char[] {' '};
            string[] result;
            result = a.Split(charSeparators, StringSplitOptions.None);
            return result[0];
        }
        public DataTable TaoTable(string a)
        {
            string connectionString;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Bin/Quanlythuvien.mdb";
            connection = new OleDbConnection(connectionString);
            adapter = new OleDbDataAdapter(a,connection);
            dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset.Tables[0];

        }
        
       

    }
}
