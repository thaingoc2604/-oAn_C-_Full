using System;
using System.Data;
using System.Data.SqlClient;

namespace qlks
{
	//	Lớp kết nối và xử lý cơ sở dữ liệu
	public class SqlHelper
	{
		private const string COMP_NAME=".";
		private const string DB_NAME="QLKS";
		private const string USER_NAME="sa";
		private const string PASSWORD="";
		public static string ConnectString="data source="+COMP_NAME+";database="+DB_NAME+";uid="+USER_NAME+";password="+PASSWORD;
		public SqlHelper()
		{
			//
			// Constructor
			//
		}
        //Download source code tại Sharecode.vn
		public static DataTable ExecuteQuery(
			string sql,
			CommandType commandType,
			params object[] pars)
		{
			SqlConnection con=new SqlConnection(ConnectString);
			
			SqlCommand com=new SqlCommand(sql,con);
			com.CommandType=commandType;

			for (int i=0;i<pars.Length;i+=2)
			{
				SqlParameter par=new SqlParameter(pars[i].ToString(),pars[i+1]);
				com.Parameters.Add(par);
			}

			SqlDataAdapter dad=new SqlDataAdapter(com);

			DataSet dst=new DataSet();
			dad.Fill(dst);
			
			return dst.Tables[0];
		}

		public static void ExecuteNonQuery(
			string sql,
			CommandType commandType,
			params object[] pars)
		{
			SqlConnection con=new SqlConnection(ConnectString);
			con.Open();
			
			SqlCommand com=new SqlCommand(sql,con);
			com.CommandType=commandType;

			for (int i=0;i<pars.Length;i+=2)
			{
				SqlParameter par=new SqlParameter(pars[i].ToString(),pars[i+1]);
				com.Parameters.Add(par);
			}

			com.ExecuteNonQuery();
		}

	}
}
