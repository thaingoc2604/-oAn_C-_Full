using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fMessage : Form
    {
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Message' table. You can move, or remove it, as needed.
            this.messageTableAdapter.FillByDesc(this.dataSet1.Message);
            //TODO: show information message by selected row
            qlkaraoke.DataSet1.MessageDataTable messdt = messageTableAdapter.GetDataByDesc();
            if (messdt.Count > 0)
            {
                this.fMessageLbSender.Text = messdt[0]["Sender"].ToString();
                this.fMessageLbContent.Text = messdt[0]["Mess_content"].ToString();
            }

        }

        private void fMessageUserBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMessageUserBtnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgRow = this.fMessageUserDGRList.CurrentRow;
            int iMess_ID  = Convert.ToInt32(dgRow.Cells[0].Value.ToString());
            //TODO: delete row selected
            messageBindingSource.RemoveCurrent();
            messageTableAdapter.DeleteQueryID(iMess_ID);
        }

        private void fMessageUserDGRList_Click(object sender, EventArgs e)
        {
            //TODO: show information message by selected row
            DataGridViewRow dgRow = this.fMessageUserDGRList.CurrentRow;
            int iMess_ID = Convert.ToInt32(dgRow.Cells[0].Value.ToString());
            qlkaraoke.DataSet1.MessageDataTable messdt = messageTableAdapter.GetDataByID(iMess_ID);
            if(messdt.Count>0)
            {
                this.fMessageLbSender.Text = messdt[0]["Sender"].ToString();
                this.fMessageLbContent.Text = messdt[0]["Mess_content"].ToString();
            }
        }

        private void fMessageUserBtnComplete_Click(object sender, EventArgs e)
        {
            //TODO: update status message by mess_id
            DataGridViewRow dgRow = this.fMessageUserDGRList.CurrentRow;
            int iMess_ID = Convert.ToInt32(dgRow.Cells[0].Value.ToString());
            messageTableAdapter.UpdateQueryStatus(true,iMess_ID);
        }

        private void fMessageUserBtnComplete_MouseEnter(object sender, EventArgs e)
        {
            fMessageUserBtnComplete.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fMessageUserBtnComplete_MouseLeave(object sender, EventArgs e)
        {
            fMessageUserBtnComplete.Image = qlkaraoke.Properties.Resources.btn11;
        }

        private void fMessageUserBtnDelete_MouseEnter(object sender, EventArgs e)
        {
            fMessageUserBtnDelete.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fMessageUserBtnDelete_MouseLeave(object sender, EventArgs e)
        {
            fMessageUserBtnDelete.Image = qlkaraoke.Properties.Resources.btn11;
        }

        private void fMessageUserBtnClose_MouseEnter(object sender, EventArgs e)
        {
            fMessageUserBtnClose.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fMessageUserBtnClose_MouseLeave(object sender, EventArgs e)
        {
            fMessageUserBtnClose.Image = qlkaraoke.Properties.Resources.btn11;
        }
    }
}