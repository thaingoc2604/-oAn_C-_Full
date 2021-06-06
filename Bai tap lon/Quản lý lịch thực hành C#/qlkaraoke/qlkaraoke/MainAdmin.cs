using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class fMainAdmin : Form
    {
        public fMainAdmin()
        {
            InitializeComponent();
        }

        private void toolbtnCustomer_Click(object sender, EventArgs e)
        {
            uaCustomer customer = new uaCustomer();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(customer);
            customer.Dock = DockStyle.Fill;
        }

        private void toolbtnEmployee_Click(object sender, EventArgs e)
        {
            /*
            if (toolbtnEmployee.)
            {
                toolbtnEmployee.BackColor = Color.Red;
            }
            else
            {
                toolbtnEmployee.BackColor = Color.Transparent;
            }
            */
            uaEmployee employee = new uaEmployee();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(employee);
            employee.Dock = DockStyle.Fill;
        }



        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAboutUs fabout = new fAboutUs();
            fabout.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolbtnEmployee_MouseEnter(object sender, EventArgs e)
        {
            toolbtnEmployee.Image = Properties.Resources.employee21;
        }
        private void toolbtnEmployee_MouseLeave(object sender, EventArgs e)
        {
            toolbtnEmployee.Image = Properties.Resources.employee1;
        }

        private void toolbtnCustomer_MouseEnter(object sender, EventArgs e)
        {
            toolbtnCustomer.Image = Properties.Resources.customer21;
        }
        private void toolbtnCustomer_MouseLeave(object sender, EventArgs e)
        {
            toolbtnCustomer.Image = Properties.Resources.customer1;
        }

        private void toolbtnGoods_MouseEnter(object sender, EventArgs e)
        {
            toolbtnGoods.Image = Properties.Resources.good21;
        }
        private void toolbtnGoods_MouseLeave(object sender, EventArgs e)
        {
            toolbtnGoods.Image = Properties.Resources.good1;
        }

        private void toolbtnRoom_MouseEnter(object sender, EventArgs e)
        {
            toolbtnRoom.Image = Properties.Resources.room21;
        }
        private void toolbtnRoom_MouseLeave(object sender, EventArgs e)
        {
            toolbtnRoom.Image = Properties.Resources.room1;
        }

        private void toolbtnPromotion_MouseEnter(object sender, EventArgs e)
        {
            toolbtnPromotion.Image = Properties.Resources.promotion21;
        }
        private void toolbtnPromotion_MouseLeave(object sender, EventArgs e)
        {
            toolbtnPromotion.Image = Properties.Resources.promotion1;
        }

        private void toolbtnBill_MouseEnter(object sender, EventArgs e)
        {
            toolbtnBill.Image = Properties.Resources.bill21;
        }
        private void toolbtnBill_MouseLeave(object sender, EventArgs e)
        {
            toolbtnBill.Image = Properties.Resources.bill1;
        }

        private void toolbtnChart_MouseEnter(object sender, EventArgs e)
        {
            toolbtnChart.Image = Properties.Resources.chart21;
        }
        private void toolbtnChart_MouseLeave(object sender, EventArgs e)
        {
            toolbtnChart.Image = Properties.Resources.chart11;
        }

        private void toolbtnRoom_Click(object sender, EventArgs e)
        {
            uaRoom room = new uaRoom();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(room);
            room.Dock = DockStyle.Fill;
        }

        private void toolbtnGoods_Click(object sender, EventArgs e)
        {
            uaGoods good = new uaGoods();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(good);
            good.Dock = DockStyle.Fill;
        }

        private void toolbtnPromotion_Click(object sender, EventArgs e)
        {
            uaPromotion promotion = new uaPromotion();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(promotion);
            promotion.Dock = DockStyle.Fill;
        }

        private void toolbtnBill_Click(object sender, EventArgs e)
        {
            uaBill bill = new uaBill();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(bill);
            bill.Dock = DockStyle.Fill;
        }

        private void toolbtnChart_Click(object sender, EventArgs e)
        {
            uaChart chart = new uaChart();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(chart);
            chart.Dock = DockStyle.Fill;
        }

        private void toolBtnLogout_MouseEnter(object sender, EventArgs e)
        {
            toolBtnLogout.Image = Properties.Resources.logout_icon21;
        }

        private void toolBtnLogout_MouseLeave(object sender, EventArgs e)
        {
            toolBtnLogout.Image = Properties.Resources.logout_icon1;
        }

        private void checkUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program is up to date", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolBtnMessage_Click(object sender, EventArgs e)
        {
            uaMessage mess = new uaMessage();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(mess);
            mess.Dock = DockStyle.Fill;
        }

        private void toolBtnMessage_MouseEnter(object sender, EventArgs e)
        {
            toolBtnMessage.Image = Properties.Resources.mail_icon21;
        }

        private void toolBtnMessage_MouseLeave(object sender, EventArgs e)
        {
            toolBtnMessage.Image = Properties.Resources.mail_icon1;
        }

        private void toolBtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to logout ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                this.Close();
                fLogin flo = new fLogin();
                flo.Visible = true;
            }
        }

        private void toolbtnEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStrip1.BackColor = Color.White;
            e.ClickedItem.BackColor = Color.Red;

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin flo = new fLogin();
            flo.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolbtnEmployee_Click(sender,e);
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolBtnMessage_Click(sender, e);
        }

        private void checkLeaveFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uaLeaveForm leave = new uaLeaveForm();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(leave);
            leave.Dock = DockStyle.Fill;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolbtnCustomer_Click(sender,e);
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolbtnRoom_Click(sender, e);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolbtnGoods_Click(sender,e);
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolbtnPromotion_Click(sender, e);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolbtnBill_Click(sender, e);
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolbtnChart_Click(sender, e);
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAboutUs about = new fAboutUs();
            about.ShowDialog();
        }

        private void fMainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            fLogin flo = new fLogin();
            flo.Visible = true;
        }
    }
}