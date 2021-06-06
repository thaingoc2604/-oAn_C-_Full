using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DETAI
{
    public partial class frmPhanQuyen : Form
    {
        //khai báo biến toàn cục
        clsUser cUser = new clsUser();
        clsUser_Right cUser_Right = new clsUser_Right();
        DataSet ds = new DataSet();
        public frmPhanQuyen()
        {
            InitializeComponent();
            cboNguoiDung.DataSource = cUser.taocombo();
            cboNguoiDung.DisplayMember = "User.ID";
            cboNguoiDung.ValueMember = "User.ID";
            update(cboNguoiDung.SelectedValue.ToString());
            
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            
        }
        
        public void update(string ma)
        {
            string sqlupd = "Update tbl_User_Form set rights=@right where idform=@id and username='"+ma+"'";
            SqlCommand cmdupd = new SqlCommand(sqlupd, cUser_Right.sc);
            SqlParameter right = new SqlParameter("@right", SqlDbType.Bit, 1, "rights");
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int, 4, "idform");

            cmdupd.Parameters.AddRange(new SqlParameter[] { right, id });
            cUser_Right.sda.UpdateCommand = cmdupd;
            cUser_Right.ds.Clear();
            cUser_Right.sda.Fill(cUser_Right.ds, "User_Right");
            cUser_Right.sc.Close();
            
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {
            cUser_Right.sc.Open();
            cUser_Right.sda.Update(cUser_Right.ds, "User_Right");
            cUser_Right.sc.Close();
        }

        private void cboNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPhanQuyen.DataSource = cUser_Right.laydl(cboNguoiDung.SelectedValue.ToString());
            dgvPhanQuyen.DataMember = "User_Right";
            DataGridViewImageColumn dgvIC = new DataGridViewImageColumn();
            dgvIC.Image = new Bitmap(Application.StartupPath + "\\Hinh\\hinhform.gif");
            dgvIC.Name = "imageform";
            dgvIC.HeaderText = "";
            if (dgvPhanQuyen.Columns[0].Name != "imageform")
                dgvPhanQuyen.Columns.Insert(0, dgvIC);
            dgvPhanQuyen.Refresh();
            update(cboNguoiDung.SelectedValue.ToString());
        }
    }
}