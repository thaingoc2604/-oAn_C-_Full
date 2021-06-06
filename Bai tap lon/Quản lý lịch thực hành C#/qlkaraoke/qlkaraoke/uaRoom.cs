using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class uaRoom : UserControl
    {
        public uaRoom()
        {
            InitializeComponent();
        }

        private void uaRoom_Load(object sender, EventArgs e)
        {
            roomTableAdapter.Fill(dataSet1.Room);
            kindroomTableAdapter.Fill(dataSet1.Kindroom);
        }

        private void uaRoomBtnInsert_Click(object sender, EventArgs e)
        {
            string room_name = uaRoomTxtRoomName.Text;
            string desc = uaRoomTxtDescription.Text;
            bool status = uaRoomcboxStatus.Checked;
            int kind_id = (int)uaRoomCBoxKind.SelectedValue;
            roomTableAdapter.InsertQuery(room_name, kind_id, status, desc);
            roomTableAdapter.Fill(dataSet1.Room);
        }
        private void uaRoomBtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void uaRoomBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to delete Room " + uaRoomDGList.CurrentRow.Cells[1].Value.ToString() + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (ans == DialogResult.Yes)
                {
                    int Cust_ID = Int32.Parse(uaRoomDGList.CurrentRow.Cells[0].Value.ToString());
                    dataSet1.Room.FindByRoom_ID(Cust_ID).Delete();
                    roomTableAdapter.Update(dataSet1.Room);
                    roomTableAdapter.Fill(dataSet1.Room);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No value");
            }
        }



        private void uaRoomBtnDelete_MouseLeave(object sender, EventArgs e)
        {
            uaRoomBtnDelete.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaRoomBtnDelete_MouseEnter(object sender, EventArgs e)
        {
            uaRoomBtnDelete.BackgroundImage = Properties.Resources.btn2;
        }
        private void uaRoomBtnInsert_MouseLeave(object sender, EventArgs e)
        {
            uaRoomBtnInsert.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaRoomBtnInsert_MouseEnter(object sender, EventArgs e)
        {
            uaRoomBtnInsert.BackgroundImage = Properties.Resources.btn2;
        }
        private void uaRoomBtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            uaRoomBtnUpdate.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaRoomBtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            uaRoomBtnUpdate.BackgroundImage = Properties.Resources.btn2;
        }

        private void uaRoomDGList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
