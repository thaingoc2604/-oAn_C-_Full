using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Fortunes
{
    public partial class DataServices : DataTable
    {
        static SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        string connectionString = "Data Source=LINH\\SQLEXPRESS;Initial Catalog=QL_TAISAN;Integrated Security=True";

        public DataServices()
        {
            InitializeComponent();
        }

        public DataServices(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void Load(SqlCommand command)
        {
            if (sqlConnection == null || sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
            }
            this.sqlCommand = command;
            this.sqlCommand.Connection = sqlConnection;
            this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
            sqlConnection.Close();
            this.Clear();
            this.sqlDataAdapter.Fill(this);

        }
        public void Update(SqlCommand sqlCommand)
        {
            if (sqlConnection == null || sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
            }
            this.sqlCommand = sqlCommand;
            this.sqlCommand.Connection = sqlConnection;

            int i = this.sqlCommand.ExecuteNonQuery();
        }
    }
}