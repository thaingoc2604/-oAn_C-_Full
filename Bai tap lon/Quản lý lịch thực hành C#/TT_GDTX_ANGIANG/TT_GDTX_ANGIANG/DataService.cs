using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TT_GDTX_ANGIANG
{

    public class DataService : DataTable
    {


        static SqlConnection m_Connection;

        public SqlConnection Connection
        {
            get { return m_Connection; }
            set { m_Connection = value; }
        }

        public SqlDataAdapter m_DataAdapter;

        public SqlDataAdapter DataAdapter
        {
            get { return m_DataAdapter; }
            set { m_DataAdapter = value; }
        }
        SqlCommand m_Command;

        //string strConn = "Data Source=locohost; Initial Catalog=QLNSTL; User Id=sa; Password=;";
        string strConn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLNSTL_TTGDTX_AG; Trusted_Connection=Yes;";


        public DataService()
        {
        }



        /// <summary>
        /// Update()
        /// </summary>
        public bool Update()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
            try
            {
                this.DataAdapter.Update(this);
            }
            catch (SqlException e)
            {
                if (e.ToString().Contains("Cannot insert duplicate key"))
                {
                    MessageBox.Show("Trùng mã, không thể thêm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (e.ToString().Contains("DELETE statement conflicted with COLUMN REFERENCE"))
                {
                    MessageBox.Show("Dữ liệu đã được tham chiếu, không thể xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


        public void Connect()
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                try
                {
                    m_Connection = new SqlConnection(strConn);
                    m_Connection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kết nối cơ sở dữ liệu không thành công.", "Thông báo");
                }
            }
        }

        public void Load(SqlCommand command)
        {
            this.Connect();
            m_Command = command;
            m_Command.Connection = m_Connection;

            m_DataAdapter = new SqlDataAdapter(m_Command);

            this.Clear();
            m_DataAdapter.Fill(this);
        }


    }
}