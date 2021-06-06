using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace QuayThuoc
{
    class connect
    {
        /*
        Truy cap - login
         * 
                 string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                string chuoi = "select*from Login where Name='" + textBox1.Text + "' and Pass='" + textBox2.Text + "'";
                cmd.CommandText = chuoi;
                //SqlDataAdapter da = cmd.ExecuteReader();
                SqlDataReader sqldr = cmd.ExecuteReader();
                if (sqldr.Read())
                {
                    MessageBox.Show("okie ");
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Loi rui");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
//////////////////////////////////////////////
*/
    /*  
  ////////////////////////////////////// them nguoi dung\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                string ketnoi = "server=(local);database=thuoc;user=sa;password=sa";
            SqlConnection con = new SqlConnection(ketnoi);
            con.Open();
            //

            try{

            string chuoithem="insert into Login (ID,Name,Pass) values('"+textBox3.Text+"','"+textBox1.Text+"','"+textBox2.Text+"')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection=con;    
            cmd.CommandText=chuoithem;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Thanh Cong");
                xoatext();

                cmd.Dispose();
                con.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
///////////////////////////////////
    */


    }
}
