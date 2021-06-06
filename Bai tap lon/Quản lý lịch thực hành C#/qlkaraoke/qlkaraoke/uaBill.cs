using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class uaBill : UserControl
    {
        public uaBill()
        {
            InitializeComponent();
        }

        private void uaBill_Load(object sender, EventArgs e)
        {
            customerTableAdapter.Fill(dataSet1.Customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Cust_ID = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            qlkaraoke.DataSet1.CustomerRow cust = dataSet1.Customer.FindByCustomer_ID(Cust_ID);
            cust.Name = "test data grid";
        }
    }
}
