using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class uaMessage : UserControl
    {
        public uaMessage()
        {
            InitializeComponent();
        }

        private void uaMessageCboxReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uaMessage_Load(object sender, EventArgs e)
        {
            employeeTableAdapter.FillByPermission(dataSet1.Employee);       
        }



        private void uaMessageBtnSend_MouseLeave(object sender, EventArgs e)
        {
            uaMessageBtnSend.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaMessageBtnSend_MouseEnter(object sender, EventArgs e)
        {
            uaMessageBtnSend.BackgroundImage = Properties.Resources.btn2;
        }
        private void uaMessageBtnReset_MouseLeave(object sender, EventArgs e)
        {
            uaMessageBtnReset.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaMessageBtnReset_MouseEnter(object sender, EventArgs e)
        {
            uaMessageBtnReset.BackgroundImage = Properties.Resources.btn2;
        }

        private void uaMessageBtnSend_Click(object sender, EventArgs e)
        {
            string receiver = uaMessageCboxReceiver.SelectedValue.ToString();
            string title = uaMessageTxtTitle.Text;
            string content = uaMessageRtxtContent.Text;
            messageTableAdapter1.Insert("Admin", receiver, DateTime.Now, DateTime.Now,content, false);
            messageTableAdapter1.Update(dataSet1.Message);
            MessageBox.Show("Message has been sent successfully!");
        }

        private void uaMessageBtnReset_Click(object sender, EventArgs e)
        {
            uaMessageTxtTitle.Text = "";
            uaMessageRtxtContent.Text = "";
        }
    }
}
