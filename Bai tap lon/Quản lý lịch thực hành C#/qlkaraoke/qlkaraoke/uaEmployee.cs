using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class uaEmployee : UserControl
    {
        public uaEmployee()
        {
            InitializeComponent();
        }

        private void uaEmployee_Load(object sender, EventArgs e)
        {
            employeeTableAdapter.Fill(dataSet1.Employee);
            uaEmployeeCboSex.SelectedIndex = 0;
            uaEmployeeCboPermission.SelectedIndex = 0;
        }

        private void uaEmployeeBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                string name = uaEmployeeTxtFullName.Text;
                System.DateTime birthday = uaEmployeeDateTimeBirth.Value;
                string sex = uaEmployeeCboSex.SelectedItem.ToString();
                string address = uaEmployeeTxtAddress.Text;
                string phone = uaEmployeeTxtPhone.Text;
                string permission = uaEmployeeCboPermission.SelectedItem.ToString();
                string username = uaEmployeeTxtUserName.Text;
                string password = uaEmployeeTxtPassword.Text;
                string jobtitle = uaEmployeeTxtJobtitle.Text;
                string salary = uaEmployeeTxtSalary.Text;
                Validatedata(uaEmployeeTxtFullName, name, errors, "Name");
                Validatedata(uaEmployeeTxtAddress, address, errors, "Address");
                Validatedata(uaEmployeeTxtPhone, phone, errors, "Phone");
                Validatedata(uaEmployeeTxtJobtitle, jobtitle, errors, "Job Title");

                try
                {
                    double.Parse(salary);
                    uaEmployeeTxtSalary.BackColor = Color.White;
                }
                catch (Exception)
                {
                    uaEmployeeTxtSalary.BackColor = Color.Salmon;
                    errors.AppendLine("Salary null or invalid type !");
                }

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    employeeTableAdapter.Insert(username, password, permission, name, birthday, sex, address, jobtitle, phone, double.Parse(salary));
                    employeeTableAdapter.Fill(dataSet1.Employee);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }
        private void uaEmployeeBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Emp_ID = Int32.Parse(uaEmployeeDGList.CurrentRow.Cells[0].Value.ToString());
                qlkaraoke.DataSet1.EmployeeRow emp = dataSet1.Employee.FindByEmployee_ID(Emp_ID);
                emp.Full_name = uaEmployeeTxtFullName.Text;
                emp.Birth_date = uaEmployeeDateTimeBirth.Value;
                emp.Sex = uaEmployeeCboSex.SelectedItem.ToString();
                emp.Address = uaEmployeeTxtAddress.Text;
                emp.Phone_number = uaEmployeeTxtPhone.Text;
                emp.Permission = uaEmployeeCboPermission.SelectedItem.ToString();
                emp.Username = uaEmployeeTxtUserName.Text;
                emp.Password = uaEmployeeTxtPassword.Text;
                emp.Job_title = uaEmployeeTxtJobtitle.Text;
                emp.Salary = double.Parse(uaEmployeeTxtSalary.Text);
                employeeTableAdapter.Update(dataSet1.Employee);
                employeeTableAdapter.Fill(dataSet1.Employee);
                MessageBox.Show("Update Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Update Error!");
            }

        }

        private void uaEmployeeBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to delete employee " + uaEmployeeDGList.CurrentRow.Cells[1].Value.ToString() + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (ans == DialogResult.Yes)
                {

                    int Emp_ID = Int32.Parse(uaEmployeeDGList.CurrentRow.Cells[0].Value.ToString());
                    dataSet1.Employee.FindByEmployee_ID(Emp_ID).Delete();
                    employeeTableAdapter.Update(dataSet1.Employee);
                    employeeTableAdapter.Fill(dataSet1.Employee);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No value");
            }

        }




        private void uaEmployeeCboPermission_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (uaEmployeeCboPermission.SelectedIndex == 2)
            {
                lblUsername.Visible = false;
                lblPassword.Visible = false;
                uaEmployeeTxtUserName.Visible = false;
                uaEmployeeTxtPassword.Visible = false;
            }
            else
            {
                lblUsername.Visible = true;
                lblPassword.Visible = true;
                uaEmployeeTxtUserName.Visible = true;
                uaEmployeeTxtPassword.Visible = true;
            }
        }

        public void Validatedata(TextBox txt, string str, StringBuilder err, string name)
        {
            txt.BackColor = Color.White;
            if (str == String.Empty)
            {
                txt.BackColor = Color.Salmon;
                err.AppendLine(name + " null!");
            }
        }


        private void uaEmployeeDGList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                uaEmployeeTxtFullName.Text = uaEmployeeDGList.CurrentRow.Cells[1].Value.ToString();
                uaEmployeeDateTimeBirth.Value = System.DateTime.Parse(uaEmployeeDGList.CurrentRow.Cells[2].Value.ToString());
                uaEmployeeCboSex.SelectedItem = uaEmployeeDGList.CurrentRow.Cells[3].Value;
                uaEmployeeTxtAddress.Text = uaEmployeeDGList.CurrentRow.Cells[4].Value.ToString();
                uaEmployeeTxtPhone.Text = uaEmployeeDGList.CurrentRow.Cells[5].Value.ToString();
                uaEmployeeCboPermission.SelectedItem = uaEmployeeDGList.CurrentRow.Cells[6].Value;
                uaEmployeeTxtUserName.Text = uaEmployeeDGList.CurrentRow.Cells[7].Value.ToString();
                uaEmployeeTxtPassword.Text = uaEmployeeDGList.CurrentRow.Cells[8].Value.ToString();
                uaEmployeeTxtJobtitle.Text = uaEmployeeDGList.CurrentRow.Cells[9].Value.ToString();
                uaEmployeeTxtSalary.Text = uaEmployeeDGList.CurrentRow.Cells[10].Value.ToString();

            }
            catch (Exception)
            {

            }
        }


        private void uaEmployeeBtnDelete_MouseLeave(object sender, EventArgs e)
        {
            uaEmployeeBtnDelete.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaEmployeeBtnDelete_MouseEnter(object sender, EventArgs e)
        {
            uaEmployeeBtnDelete.BackgroundImage = Properties.Resources.btn2;
        }
        private void uaEmployeeBtnInsert_MouseLeave(object sender, EventArgs e)
        {
            uaEmployeeBtnInsert.BackgroundImage = Properties.Resources.btn1;
        }

        private void uaEmployeeBtnInsert_MouseEnter(object sender, EventArgs e)
        {
            uaEmployeeBtnInsert.BackgroundImage = Properties.Resources.btn2;
        }
        private void uaEmployeeBtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            uaEmployeeBtnUpdate.BackgroundImage = Properties.Resources.btn1;
        }

        private void uaEmployeeBtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            uaEmployeeBtnUpdate.BackgroundImage = Properties.Resources.btn2;
        }
    }
}
