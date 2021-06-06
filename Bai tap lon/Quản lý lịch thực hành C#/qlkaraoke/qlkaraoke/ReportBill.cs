using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fReportBill : Form
    {
        public int Room_ID;
        public fReportBill(int Room_ID)
        {
            this.Room_ID = Room_ID;
            InitializeComponent();
        }

        private void fReportBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Bills' table. You can move, or remove it, as needed.
            this.BillsTableAdapter.Fill(this.DataSet1.Bills);
            // TODO: This line of code loads data into the 'DataSet1.Room' table. You can move, or remove it, as needed.
            this.RoomTableAdapter.Fill(this.DataSet1.Room);
            // TODO: This line of code loads data into the 'DataSet1.Promotion' table. You can move, or remove it, as needed.
            this.PromotionTableAdapter.Fill(this.DataSet1.Promotion);
            // TODO: This line of code loads data into the 'DataSet1.View_Bill' table. You can move, or remove it, as needed.            
            this.View_BillTableAdapter.FillByRoom_Status(this.DataSet1.View_Bill, this.Room_ID, true);
            
            this.reportViewer1.RefreshReport();
        }
    }
}