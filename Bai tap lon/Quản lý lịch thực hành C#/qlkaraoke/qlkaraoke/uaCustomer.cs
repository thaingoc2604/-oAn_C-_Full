using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace qlkaraoke
{
    public partial class uaCustomer : UserControl
    {
        public uaCustomer()
        {
            InitializeComponent();
        }

        private void uaCustomer_Load(object sender, EventArgs e)
        {
            customerTableAdapter.Fill(dataSet1.Customer);
            kindcustomerTableAdapter.Fill(dataSet1.Kindcustomer);
        }
        private void uaCustomerBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = uaCustomerTxtFullname.Text;                
                string cardid = uaCustomerTxtIDNumber.Text;
                string phone = uaCustomerTxtPhone.Text;
                string email = uaCustomerTxtEmail.Text;
                string address = uaCustomerTxtAddress.Text;
                int kind = Int32.Parse(uaCustomerCboKind.SelectedValue.ToString());

                StringBuilder errors = new StringBuilder();
                uaCustomerTxtFullname.BackColor = Color.White;
                if (name == String.Empty)
                {
                    uaCustomerTxtFullname.BackColor = Color.Salmon;
                    errors.AppendLine("Name null !");
                }
                uaCustomerTxtIDNumber.BackColor = Color.White;
                if (cardid == String.Empty)
                {
                    uaCustomerTxtIDNumber.BackColor = Color.Salmon;
                    errors.AppendLine("Card id null !");
                }
                uaCustomerTxtPhone.BackColor = Color.White;
                if (phone == String.Empty)
                {
                    uaCustomerTxtPhone.BackColor = Color.Salmon;
                    errors.AppendLine("Phone null !");
                }
                uaCustomerTxtAddress.BackColor = Color.White;
                if (address == String.Empty)
                {
                    uaCustomerTxtAddress.BackColor = Color.Salmon;
                    errors.AppendLine("Adress null !");
                }

                uaCustomerTxtEmail.BackColor = Color.White;
                Regex re = new Regex(@"^(\w+@\w+\.\w+)$");
                if (re.IsMatch(email) == false)
                {
                    uaCustomerTxtEmail.BackColor = Color.Salmon;
                    errors.AppendLine("Invalid email or null !");
                }

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    customerTableAdapter.Insert(name, cardid, phone, address, email, kind);
                    customerTableAdapter.Fill(dataSet1.Customer);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void uaCustomerBtnUpdate_Click(object sender, EventArgs e)
        {
            int Cust_ID = Int32.Parse(uaCustomerDGList.CurrentRow.Cells[0].Value.ToString());
            qlkaraoke.DataSet1.CustomerRow cust = dataSet1.Customer.FindByCustomer_ID(Cust_ID);
            
            MessageBox.Show(cust["Email"].ToString());
            cust.Name = uaCustomerTxtFullname.Text;
            cust.Card_number = uaCustomerTxtIDNumber.Text;
            cust.Phone = uaCustomerTxtPhone.Text;
            cust.Email = uaCustomerTxtEmail.Text;
            cust.Address = uaCustomerTxtAddress.Text;
            cust.KindCustomer_ID = Int32.Parse(uaCustomerCboKind.SelectedValue.ToString());
            customerTableAdapter.Update(dataSet1.Customer);
            customerTableAdapter.Fill(dataSet1.Customer);
            MessageBox.Show("Update Success!");
        }

        private void uaCustomerBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to delete customer " + uaCustomerDGList.CurrentRow.Cells[1].Value.ToString() + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (ans == DialogResult.Yes)
                {
                    int Cust_ID = Int32.Parse(uaCustomerDGList.CurrentRow.Cells[0].Value.ToString());
                    dataSet1.Customer.FindByCustomer_ID(Cust_ID).Delete();
                    customerTableAdapter.Update(dataSet1.Customer);
                    customerTableAdapter.Fill(dataSet1.Customer);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No value");
            }

        }


        private void uaCustomerDGList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                uaCustomerTxtFullname.Text = uaCustomerDGList.CurrentRow.Cells[1].Value.ToString();
                uaCustomerTxtIDNumber.Text = uaCustomerDGList.CurrentRow.Cells[2].Value.ToString();
                uaCustomerTxtPhone.Text = uaCustomerDGList.CurrentRow.Cells[3].Value.ToString();
                uaCustomerTxtAddress.Text = uaCustomerDGList.CurrentRow.Cells[4].Value.ToString();
                uaCustomerTxtEmail.Text = uaCustomerDGList.CurrentRow.Cells[5].Value.ToString();
                int kindcusID = Int32.Parse(uaCustomerDGList.CurrentRow.Cells[6].Value.ToString());
                uaCustomerCboKind.SelectedValue = kindcusID;
            }
            catch (Exception)
            {

            }

        }


        private void uaCustomerBtnDelete_MouseLeave(object sender, EventArgs e)
        {
            uaCustomerBtnDelete.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaCustomerBtnInsert_MouseLeave(object sender, EventArgs e)
        {
            uaCustomerBtnInsert.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaCustomerBtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            uaCustomerBtnUpdate.BackgroundImage = Properties.Resources.btn1;
        }

        private void uaCustomerBtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            uaCustomerBtnUpdate.BackgroundImage = Properties.Resources.btn2;
        }

        private void uaCustomerBtnInsert_MouseEnter(object sender, EventArgs e)
        {
            uaCustomerBtnInsert.BackgroundImage = Properties.Resources.btn2;
        }

        private void uaCustomerBtnDelete_MouseEnter(object sender, EventArgs e)
        {
            uaCustomerBtnDelete.BackgroundImage = Properties.Resources.btn2;
        }

    }
}
