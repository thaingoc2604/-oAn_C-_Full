using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fReserveRoom : Form
    {
        public fReserveRoom()
        {
            InitializeComponent();
        }

        private void fReserveRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.dataSet1.Room);
        }

        private void fReserveRoomBtnAccept_Click(object sender, EventArgs e)
        {
            //TODO: get value Res
            string strNameCustomer = this.fReserveRoomTxtCustomerName.Text;
            string strAddress = this.fReserveRoomTxtAddress.Text;
            string strTel = this.fReserveRoomTxtTel.Text;
            string strDes = this.fReserveRoomTxtMoreDes.Text;
            DateTime dater = this.fReserveRoomDTimeFrom.Value;
            string strTime = this.fReserveRoomTxtTime2.Text;
            int iRoom_ID = Convert.ToInt32(this.fReserveRoomTxtCBoxKindRoom.SelectedValue.ToString());
            int iPerson = 0;
            //TODO: check value
            if (strNameCustomer.Trim() == "")
            {
                MessageBox.Show("Name Customer not null!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (strTime.Trim() == "")
            {
                MessageBox.Show("Time not null!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (strTime.Length != 4)
            {
                MessageBox.Show("Time must 4 number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    int iTime = Convert.ToInt32(strTime);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tim is number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (fReserveRoomTxtPerson.Text.Trim() == "")
            {
                MessageBox.Show("Peson not null!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    iPerson = Convert.ToInt32(this.fReserveRoomTxtPerson.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Person is number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            if (strTel.Trim() != "")
            {
                try
                {
                    int iTel = Convert.ToInt32(strTel);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tel is number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //TODO: Insert values into table ReserveRoom
            reserveroomTableAdapter1.InsertQuery(strNameCustomer, dater, strTime, iRoom_ID, iPerson, strAddress, strTel);
            //TODO: Message success
            MessageBox.Show("Accept success!","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fReserveRoomBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fReserveRoomBtnAccept_MouseEnter(object sender, EventArgs e)
        {
            fReserveRoomBtnAccept.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fReserveRoomBtnAccept_MouseLeave(object sender, EventArgs e)
        {
            fReserveRoomBtnAccept.Image = qlkaraoke.Properties.Resources.btn11;
        }

        private void fReserveRoomBtnClose_MouseEnter(object sender, EventArgs e)
        {
            fReserveRoomBtnClose.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fReserveRoomBtnClose_MouseLeave(object sender, EventArgs e)
        {
            fReserveRoomBtnClose.Image = qlkaraoke.Properties.Resources.btn11;
        }
    }
}