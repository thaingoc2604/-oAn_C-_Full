using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fChangeRoom : Form
    {
        public fChangeRoom()
        {
            InitializeComponent();
        }      

        private void fChangeRoom_Load(object sender, EventArgs e)
        {
            //TODO: Load datagrid from
            qlkaraoke.DataSet1.RoomDataTable roomdt1 = roomTableAdapter1.GetDataByStatus(true);
            this.fChangeRoomCBoxFrom.DataSource = roomdt1;
            this.fChangeRoomCBoxFrom.DisplayMember = "Room_name";
            this.fChangeRoomCBoxFrom.ValueMember = "Room_ID";
            //TODO: Load datagrid to
            qlkaraoke.DataSet1.RoomDataTable roomdt0 = roomTableAdapter1.GetDataByStatus(false);
            this.fChangeRoomCBoxTo.DataSource = roomdt0;
            this.fChangeRoomCBoxTo.DisplayMember = "Room_name";
            this.fChangeRoomCBoxTo.ValueMember = "Room_ID";
        }
        
        private void fChangeRoomBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChangeRoomBtnAccept_Click(object sender, EventArgs e)
        {
            int iRoomFromID = Convert.ToInt32(fChangeRoomCBoxFrom.SelectedValue.ToString());
            int iRoomToID = Convert.ToInt32(fChangeRoomCBoxTo.SelectedValue.ToString());
            //TODO: Update table room true and false
            roomTableAdapter1.UpdateQueryStatus(false, iRoomFromID);
            roomTableAdapter1.UpdateQueryStatus(true, iRoomToID);
            //TODO: Update table bills
            billsTableAdapter1.UpdateQueryRoom(iRoomToID, iRoomFromID);
            MessageBox.Show(iRoomFromID.ToString() + "-" + iRoomToID.ToString());
        }

        private void fChangeRoomBtnAccept_MouseEnter(object sender, EventArgs e)
        {
            fChangeRoomBtnAccept.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fChangeRoomBtnAccept_MouseLeave(object sender, EventArgs e)
        {
            fChangeRoomBtnAccept.Image = qlkaraoke.Properties.Resources.btn11;
        }

        private void fChangeRoomBtnClose_MouseEnter(object sender, EventArgs e)
        {
            fChangeRoomBtnClose.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fChangeRoomBtnClose_MouseLeave(object sender, EventArgs e)
        {
            fChangeRoomBtnClose.Image = qlkaraoke.Properties.Resources.btn11;
        }
    }
}