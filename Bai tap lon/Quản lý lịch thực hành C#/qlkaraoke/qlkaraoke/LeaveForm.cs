using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fLeaveForm : Form
    {
        public fLeaveForm()
        {
            InitializeComponent();
        }

        private void fLeaveForm_Load(object sender, EventArgs e)
        {
            qlkaraoke.DataSet1.EmployeeDataTable empdt = employeeTableAdapter1.GetDataByAdmin();
            this.fLeaveFormCBoxReceiver.DataSource = empdt;
            this.fLeaveFormCBoxReceiver.DisplayMember = "Full_name";
            this.fLeaveFormCBoxReceiver.ValueMember = "Employee_ID";
        }

        private void fLeaveFormBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void reset()
        {
            //TODO: Set Empty
            this.fLeaveFormDTimeFrom.Value = DateTime.Now.Date;
            this.fLeaveFormDTimeTo.Value = DateTime.Now.Date;
            this.fLeaveFormTxtFullName.Text = string.Empty;
            this.fLeaveFormCBoxReceiver.SelectedIndex = -1;
            this.fLeaveFormTxtReason.Text = string.Empty;
            this.fLeaveFormTxtMoreDes.Text = string.Empty;
        }
        private void fLeaveFormBtnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void fLeaveFormBtnSend_Click(object sender, EventArgs e)
        {
            //TODO: Get value
            DateTime daterFrom = this.fLeaveFormDTimeFrom.Value;
            DateTime daterTo = this.fLeaveFormDTimeTo.Value;
            string strFullName = this.fLeaveFormTxtFullName.Text;
            string strReceiver = this.fLeaveFormCBoxReceiver.SelectedValue.ToString();
            string strReason = this.fLeaveFormTxtReason.Text;
            string strDes = this.fLeaveFormTxtMoreDes.Text;
            //TODO: Check form
            if (strFullName.Trim() == "")
            {
                MessageBox.Show("Name not null!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            else if (strReason.Trim() == "")
            {
                MessageBox.Show("Reason not null!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            else if (daterFrom.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Date from >= Date current!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            else if (daterFrom.Date >= daterTo.Date)
            {
                MessageBox.Show("Date to > date from!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            else
            {
                //TODO: Insert values into table Leave form
                leaveformTableAdapter1.InsertQuery(strReason, strFullName, daterFrom, strReceiver, daterTo);
                //TODO: Message success
                MessageBox.Show("Send success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
        }

        private void fLeaveFormBtnSend_MouseEnter(object sender, EventArgs e)
        {
            fLeaveFormBtnSend.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fLeaveFormBtnSend_MouseLeave(object sender, EventArgs e)
        {
            fLeaveFormBtnSend.Image = qlkaraoke.Properties.Resources.btn11;
        }

        private void fLeaveFormBtnReset_MouseEnter(object sender, EventArgs e)
        {
            fLeaveFormBtnReset.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fLeaveFormBtnReset_MouseLeave(object sender, EventArgs e)
        {
            fLeaveFormBtnReset.Image = qlkaraoke.Properties.Resources.btn11;
        }

        private void fLeaveFormBtnClose_MouseEnter(object sender, EventArgs e)
        {
            fLeaveFormBtnClose.Image = qlkaraoke.Properties.Resources.btn21;
        }

        private void fLeaveFormBtnClose_MouseLeave(object sender, EventArgs e)
        {
            fLeaveFormBtnClose.Image = qlkaraoke.Properties.Resources.btn11;
        }
    }
}