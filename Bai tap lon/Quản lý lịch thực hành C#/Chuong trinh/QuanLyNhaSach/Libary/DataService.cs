using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach
{
    public class DataService : DataTable
    {
        static SqlConnection m_Connection;
        SqlDataAdapter m_DataAdapter;
        SqlCommand m_Command;
        ErrorInfo er_Info = new ErrorInfo();
        
        // chuỗi kết nối của OleDB
        //string connectStringOle = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QUANLYNHASACH;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";
        // chuỗi kết nối với đặc quyền Windows
        string connectString = "Initial Catalog=QUANLYNHASACH;Integrated Security=True";
        // chuỗi kết nối với UserName và password
        
        //string strConnect = "Data Source=localhost;Initial Catalog=QUANLYNHASACH;User Id=sa;password=";
        // chuỗi kết nối với CSDL ACCESS
        string strConnect_Access = "provider=Microsoft.Jet.OLEDB.4.0;data source=E:\\QuanLySinhVien\\Database\\QuanLySinhVien.mdb;";


        //---------------------------------------------------------
        //---------------------------------------------------------
        // Các biến dành cho Provider SqlClient
        public SqlConnection ms_connect = null;
        SqlDataAdapter ms_dataAdapter = null;
        SqlCommand cmd = new SqlCommand();
        DataSet dataset;

        //---------------------------------------------------------
        // Contructor dành cho Provider SqlClient
        public DataService()
        {
            ms_connect = new SqlConnection(connectString);
            OpenConnection();
        }
        //---------------------------------------------------------
        // Các biến dành cho Provider OleDB
        public OleDbConnection ole_connect = null;
        OleDbCommand ole_cmd = null;
        OleDbDataAdapter ole_dataAdapter = null;
        //OleDbDataReader ole_reader = null;
        //---------------------------------------------------------        
        // Constructor dành cho Provuder OleDB
        public DataService(string Access)
        {
            ole_connect = new OleDbConnection(strConnect_Access);
            ole_connect.Open();
            ole_cmd = new OleDbCommand();

        }
        //---------------------------------------------------------
        // Hàm hủy lớp DataService
        protected override void Dispose(bool disposing)
        {
            CloseConnection();
            base.Dispose(disposing);
        }
        //---------------------------------------------------------		
        // Hàm mở kết nối
        private bool OpenConnection()
        {
            try
            {
                ms_connect.Open();
                if (ms_connect.State != ConnectionState.Open)
                    return false;
            }
            catch
            {
                MessageBox.Show("Không kết nối được");
                return false;
            }
            return true;
        }
        //---------------------------------------------------------
        //Ham dong ket noi
        private void CloseConnection()
        {
            if (ms_connect.State != ConnectionState.Closed)
                ms_connect.Close();
        }
        //---------------------------------------------------------
        //Hàm tạo Adapter cho Sql
        public void CreateAdapter()
        {
            ms_dataAdapter = new SqlDataAdapter();
        }
        //---------------------------------------------------------
        // Hàm tạo Adapter cho OleDB
        public void CreateAdapter_Access()
        {
            ole_dataAdapter = new OleDbDataAdapter();
        }
        //---------------------------------------------------------
        //Ham lay du lieu tu co so du lieu
        public int LoadFromDB(string strSQL)
        {
            cmd.CommandType = CommandType.StoredProcedure;

            ms_dataAdapter = new SqlDataAdapter(strSQL, this.ms_connect);
            try
            {
                return ms_dataAdapter.Fill(this);
            }
            catch
            {
                return 0;
            }
        }
        //---------------------------------------------------------
        // Trả về một table Access
        public DataTable Table_Access(string strSQL)
        {
            DataSet dataset = new DataSet();
            ole_cmd.CommandType = CommandType.StoredProcedure;
            ole_dataAdapter = new OleDbDataAdapter(strSQL, ole_connect);
            ole_dataAdapter.Fill(dataset);
            return dataset.Tables[0];
        }
        //---------------------------------------------------------
        // Trả về một table SQL Server
        public DataTable Table(string strSQL)
        {
            DataTable table = new DataTable();
            dataset = new DataSet();
            cmd.CommandType = CommandType.StoredProcedure;
            ms_dataAdapter = new SqlDataAdapter(strSQL, this.ms_connect);
            ms_dataAdapter.Fill(dataset);
            table = dataset.Tables[0];
            return table;
        }
        //---------------------------------------------------------
        /// Trả về giá trị tương ứng giữa DisplayMember và ValueMember
        public string Value(string sql, string column)
        {
            DataTable table = Table(sql);
            DataRow row = table.Rows[0];
            string _value = row[column].ToString();
            return _value;
        }
        //---------------------------------------------------------
        // Hàm update theo các kiểu: Insert, Delete, Update
        public void AddTypeUpdate(SqlCommand comd, int type)
        {
            comd.Connection = this.ms_connect;
            switch (type)
            {
                case 1:
                    ms_dataAdapter.UpdateCommand = comd;
                    break;
                case 2:
                    ms_dataAdapter.InsertCommand = comd;
                    break;
                case 3:
                    ms_dataAdapter.DeleteCommand = comd;
                    break;
            }
        }
        //---------------------------------------------------------
        // Hàm update lưới dữ liệu (update cho 1 DataAdapter)
        public void Update()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(ms_dataAdapter);
            ms_dataAdapter.Update(this);
        }
        //---------------------------------------------------------
        // Thuc thi cau lenh Sql
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand cmd = ms_connect.CreateCommand();
            cmd.CommandText = strSQL;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { MessageBox.Show("Không thực thi được câu lệnh SQL"); }
        }
        //---------------------------------------------------------
        // Load dữ liệu lên DataAdapter - sử dụng khi muốn update DataAdapter
        public void Load(SqlCommand command)
        {
            ms_connect = new SqlConnection(connectString);
            ms_connect.Open();
            cmd = command;
            cmd.Connection = ms_connect;
            ms_dataAdapter = new SqlDataAdapter(cmd);
            ms_dataAdapter.Fill(this);
        }

        // Ham tra ve ArrayList
        public ArrayList execute_query(string sql)
        {
            if (OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, ms_connect);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    ArrayList arrList = new ArrayList();
                    byte field_quantity = (byte)reader.FieldCount;

                    while (reader.Read())
                    {
                        string[] arr = new string[field_quantity];

                        for (byte i = 0; i < field_quantity; i++)
                            arr[i] = reader[i].ToString();

                        arrList.Add(arr);
                    }

                    reader.Close();
                    return arrList;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }

            return null;
        }
        

        public void Load1(SqlCommand command)
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(connectString);
                m_Connection.Open();
            }
            m_Command = command;
            m_Command.Connection = m_Connection;            
            this.Clear();
            m_DataAdapter = new SqlDataAdapter(m_Command);
            m_DataAdapter.Fill(this);
        }

        public void Execute(SqlCommand command)
        {
            /*if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
            }
            m_Command = command;
            m_Command.Connection = m_Connection;
            m_Command.ExecuteNonQuery();         */
            command.Connection = m_Connection;
            command.ExecuteNonQuery();

        }
        public ErrorInfo Execute1(SqlCommand cmd)
        {
            cmd.Connection = m_Connection;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                er_Info.Loi = 0;
                er_Info.Message = e.Message;
                return er_Info;
            }

            er_Info.Loi = 1;
            return er_Info;
        }
        public object ExecuteScalar(SqlCommand command)
        {
            return command.ExecuteScalar();
        }
    }

}