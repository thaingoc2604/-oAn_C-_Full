using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manager_Fortunes.DaTaService
{
    public class DataService: DataTable
    {
        static SqlConnection m_Connection;
        SqlDataAdapter m_DataAdapter;
        SqlCommand m_Command;
        //string strConn = "Data Source=localhost;Initial Catalog=QLTINDUC;User Id=sa;Password=sa;";
        string strConn = "Data Source=LINH\\SQLEXPRESS;Initial Catalog=QLTS; Trusted_Connection=Yes;";
               
        private void open()
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
            }
        }

        public void select(SqlCommand command)
        {
            open();
            m_Command = command;
            m_Command.Connection = m_Connection;

            this.Clear();
            
            m_DataAdapter = new SqlDataAdapter(m_Command);                        
            m_DataAdapter.Fill(this);            
        }

        public void Update()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);
            m_DataAdapter.Update(this);
        }

        public void ExcutiveNonQuery(SqlCommand cmd)
        {
            open();
            cmd.Connection = m_Connection;
            cmd.ExecuteNonQuery();
            
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            open();           
            cmd.Connection = m_Connection;
            return cmd.ExecuteScalar();
            
        }

    }
}
