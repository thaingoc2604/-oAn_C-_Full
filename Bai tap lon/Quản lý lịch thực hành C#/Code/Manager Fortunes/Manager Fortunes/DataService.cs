using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Manager_Fortunes
{

    public class DataService : DataTable
    {
        static SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        private static OleDbConnection m_Connection;

        //public static String m_ConnectString = "Provider=SQLNCLI;Server=MINHPHUOC-PC\\SQLEXPRESS;Database=QLTS;Trusted_Connection=yes;";
        //public static String m_ConnectString = "Provider=SQLNCLI;Server=DANGKHOA\\SQLEXPRESS;Database=QLTS;Trusted_Connection=yes;";
        public static String m_ConnectString = "Provider=SQLNCLI;Server=LINH\\SQLEXPRESS;Database=QLTS;Trusted_Connection=yes;";

        private OleDbCommand m_Command;


        private OleDbDataAdapter m_DataAdapter;

        public DataService() { }


        public OleDbCommand Command
        {
            get { return m_Command; }
            set { m_Command = value; }
        }

        public void Load(OleDbCommand command)
        {

            m_Command = command;
            try
            {

                m_Command.Connection = m_Connection;

                m_DataAdapter = new OleDbDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                this.Clear();
                m_DataAdapter.Fill(this);

            }
            catch (Exception e)
            {
                String str = e.Message;
            }
        }


        public static bool OpenConnection()
        {
            try
            {
                if (m_Connection == null)

                    m_Connection = new OleDbConnection(m_ConnectString);


                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch (Exception e)
            {
                m_Connection.Close();
                String str = e.Message;
                MessageBox.Show(str);
                return false;
            }

        }
        /// <summary>
        /// Closes the connection of this data service.
        /// </summary>
        public void CloseConnection()
        {
            m_Connection.Close();
        }

        /// <summary>
        /// Update DataTable
        /// </summary>
        /// <returns></returns>
        public int ExecuteNoneQuery()
        {
            int result = 0;
            OleDbTransaction tr = null;
            try
            {
                tr = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = tr;

                m_DataAdapter = new OleDbDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                OleDbCommandBuilder builder = new OleDbCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);


                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();

            }
            return result;
        }
        /// <summary>
        /// Thuc thi mot command
        /// </summary>
        /// <param name="command">OleDb hay Store Procedure</param>
        /// <returns></returns>
        public int ExecuteNoneQuery(OleDbCommand cmd)
        {

            int result = 0;
            OleDbTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteNonQuery();

                this.AcceptChanges();

                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                MessageBox.Show(e.Message.ToString());
                //throw;
            }
            return result;

        }

        public object ExecuteScalar(OleDbCommand cmd)
        {
            object result = null;
            OleDbTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteScalar();

                this.AcceptChanges();

                tr.Commit();

                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                MessageBox.Show(e.Message);
                //throw;
            }
            return result;
        }



        internal void Update()
        {
            OleDbCommandBuilder sql = new OleDbCommandBuilder(m_DataAdapter);
            m_DataAdapter.Update(this);

        }




    }
}