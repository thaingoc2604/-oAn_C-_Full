using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fMainUser : Form
    {
        public string sUserName;
        public fMainUser(string UserName)
        {
            InitializeComponent();
            this.sUserName = UserName;
        }
        
        private void fMainUser_Load(object sender, EventArgs e)
        {
            //TODO: load list view
            qlkaraoke.DataSet1.RoomDataTable rt = roomTableAdapter1.GetData();
            int numRoom = rt.Count;
            for (int i = 0; i < numRoom; i++)
            {     
                ListViewItem lsv = fMainUserListView1.Items.Add(rt[i]["Room_name"].ToString());
                lsv.Name = rt[i]["Room_ID"].ToString();
                if ((bool)rt[i]["Status"])
                {
                    lsv.ImageIndex = 0;
                }
                else
                {
                    lsv.ImageIndex = 1;
                }
                //lsv.ToolTipText = "tooltip 1";
            }
            //TODO: Load status
            fMainUseStatus1.Text = this.sUserName;
        }
        
        private void fMainUserBtnView_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = fMainUserListView1.SelectedItems[0].Name;
                qlkaraoke.DataSet1.RoomDataTable rtID = roomTableAdapter1.GetDataByID(Convert.ToInt32(ID));
                if ((bool)rtID[0]["Status"])
                {
                    fRoom fRoom = new fRoom(ID);
                    fRoom.ShowDialog();
                }
            }
            catch(Exception){
                MessageBox.Show("Select room, please!","Note",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void fMainUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            fLogin flo = new fLogin();
            flo.Visible = true;
        }

        private void fMainUserListView1_DoubleClick(object sender, EventArgs e)
        {
            string ID = fMainUserListView1.SelectedItems[0].Name;
            qlkaraoke.DataSet1.RoomDataTable rtID = roomTableAdapter1.GetDataByID(Convert.ToInt32(ID));
            if ((bool)rtID[0]["Status"])
            {
                fRoom fRoom = new fRoom(ID);
                fRoom.ShowDialog();
            }
        }

        private void fMainUserBtnStart_Click(object sender, EventArgs e)
        {
            string Room_ID = fMainUserListView1.SelectedItems[0].Name;
            qlkaraoke.DataSet1.RoomDataTable rtID = roomTableAdapter1.GetDataByID(Convert.ToInt32(Room_ID));
            if (!(bool)rtID[0]["Status"])
            {
                //TODO: billscode
                qlkaraoke.DataSet1.BillsDataTable billdtget = billsTableAdapter1.GetData();
                int numRowBill = billdtget.Count + 1;
                //TODO: Insert Bills
                string strBillCode = DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + numRowBill.ToString();
                //MessageBox.Show(Room_ID);
                billsTableAdapter1.InsertQueryStartRoom(strBillCode, DateTime.Now, Convert.ToInt32(Room_ID), true);
                //TODO: Update Room
                roomTableAdapter1.UpdateQueryStartRoom(DateTime.Now, true, Convert.ToInt32(Room_ID));
                fMainUserListView1.SelectedItems[0].ImageIndex = 0;
                fMainUserListView1.Refresh();
            }                
        }

        private void fMainUserBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.fMainUseStatus3.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            qlkaraoke.DataSet1.MessageDataTable messdt = messageTableAdapter1.GetDataByRec(this.sUserName);
            if (messdt.Count > 0)
            {
                this.fMainUseStatus2.Text = "You have " + messdt.Count.ToString() + " new message!";
            }
        }

        private void fMainUseStatus2_Click(object sender, EventArgs e)
        {
            qlkaraoke.DataSet1.MessageDataTable messdt = messageTableAdapter1.GetDataByRec(this.sUserName);
            if (messdt.Count > 0)
            {
                fMessage fm = new fMessage();
                fm.ShowDialog();
            }
        }

        private void reserveRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReserveRoom fr = new fReserveRoom();
            fr.ShowDialog();
        }

        private void leaveFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLeaveForm lef = new fLeaveForm();
            lef.ShowDialog();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMessage fmess = new fMessage();
            fmess.ShowDialog();
        }

        private void chageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangeRoom fch = new fChangeRoom();
            fch.ShowDialog();
        }

        private void fMainUserBtnPrintOrder_Click(object sender, EventArgs e)
        {
            fReportBill fre = new fReportBill(32);
            fre.ShowDialog();
        }

        private void fMainUserBtnView_MouseEnter(object sender, EventArgs e)
        {
            fMainUserBtnView.Image = Properties.Resources.btn21;
        }

        private void fMainUserBtnView_MouseLeave(object sender, EventArgs e)
        {
            fMainUserBtnView.Image = Properties.Resources.btn11;
        }

        private void fMainUserBtnStart_MouseEnter(object sender, EventArgs e)
        {
            fMainUserBtnStart.Image = Properties.Resources.btn21;

        }

        private void fMainUserBtnStart_MouseLeave(object sender, EventArgs e)
        {
            fMainUserBtnStart.Image = Properties.Resources.btn11;
        }

        private void fMainUserBtnClose_MouseEnter(object sender, EventArgs e)
        {
            fMainUserBtnClose.Image = Properties.Resources.btn21;
        }

        private void fMainUserBtnClose_MouseLeave(object sender, EventArgs e)
        {
            fMainUserBtnClose.Image = Properties.Resources.btn11;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAboutUs about = new fAboutUs();
            about.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin flo = new fLogin();
            flo.Visible = true;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewRoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fMainUserBtnView_Click(sender, e);
        }
    }
}