using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SIINHVIEN
{
    public partial class Form1 : Form
    {
        protected OleDbConnection con;
        public OleDbConnection connect()
        {
            try
            {
                con=new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
                con.Open();
            }
            catch(Exception)
            {
                throw;
            }
            return con;
        }
        private OleDbDataAdapter oda;
        public Form1()
        {
            InitializeComponent();
        }
        public DataSet GetKhoa()
        {
            OleDbConnection con = connect();
            DataSet ds = new DataSet();
            oda = new OleDbDataAdapter("Select * from Table_Khoa",con);
            oda.Fill(ds);
            return ds;
        }
        public DataSet GetLop(string makhoa)
        {
            OleDbConnection con = connect();
            DataSet ds = new DataSet();
            oda = new OleDbDataAdapter("Select * from Table_Lop where KhoaID='"+makhoa+"'", con);
            oda.Fill(ds);
            return ds;
        }
        public DataSet GetSinhVien(string lopID)
        {
            OleDbConnection con = connect();
            DataSet ds = new DataSet();
            oda = new OleDbDataAdapter("Select * from Table_SinhVien where LopID='" + lopID + "'", con);
            oda.Fill(ds);
            return ds;
        }
        public int ThemSV(string masv, string ten, string diachi, string ngays, string malop)
        {
            try
            {
                int x = 0;
                OleDbCommand cm=new OleDbCommand("Insert into Table_SinhVien values('"+masv+"','"+ten+"','"+diachi+"','"+ngays+"','"+malop+"')",con);
                x=cm.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch(Exception)
            {
                throw;
            }
        }
        public int XoaSV(string masv)
        {
            try
            {
                int x = 0;
                OleDbCommand cm = new OleDbCommand("Delete from Table_SinhVien where SinhVienID='" + masv + "'", con);
                x = cm.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int SuaSV(string ten, string diachi, string ngays, string masv)
        {
            try
            {
                int x = 0;
                OleDbCommand cm = new OleDbCommand("Update Table_SinhVien set SinhVienName='"+ten+"', SinhVienAR='"+diachi+"', SinhVienNS='"+ngays+"' where SinhVienID='"+masv+"'", con);
                x = cm.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void LoadTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode nodedanhsach, nodekhoa,nodelop;
            nodedanhsach = treeView1.Nodes.Add("Danh sách các khoa");
            nodedanhsach.ImageIndex = 0;
            DataTable tablekhoa = GetKhoa().Tables[0];
            for (int i = 0; i < tablekhoa.Rows.Count; i++)
            {
                nodekhoa = nodedanhsach.Nodes.Add("Khoa: " + tablekhoa.Rows[i][1].ToString());
                nodekhoa.Tag = tablekhoa.Rows[i][0].ToString();
                nodekhoa.ImageIndex = 1;
                DataTable tablelop = GetLop(nodekhoa.Tag.ToString()).Tables[0];
                for (int j = 0; j < tablelop.Rows.Count; j++)
                {
                    nodelop = nodekhoa.Nodes.Add("Lớp: " + tablelop.Rows[j][1].ToString());
                    nodelop.Tag = tablelop.Rows[j][0].ToString();
                    nodelop.ImageIndex = 2;
                    nodelop.Nodes.Add("Giáo viên: " + tablelop.Rows[j][2].ToString());
                    nodelop.Nodes.Add("Vị trí: " + tablelop.Rows[j][3].ToString());
                }
            }
            treeView1.ExpandAll();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTreeView();
            label7.Visible = false;
            button_luu.Enabled = false;
            linkLabel1.Enabled = false;
        }
        public void LoadDSKhoa()
        {
            dataGridView1.DataSource = GetKhoa().Tables[0];
        }
        public void LoadDSLop(string malop)
        {
            dataGridView1.DataSource = GetLop(malop).Tables[0];
        }
        public void LoadDSSinhVien(string malop)
        {
            dataGridView1.DataSource = GetSinhVien(malop).Tables[0];
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                LoadDSKhoa();
                int row = dataGridView1.RowCount;
                label_thongke.Text = "Tổng số khoa là: " + row.ToString();
                label7.Text = "A";
                Clear();
                status();
            }
            if (e.Node.Level == 1)
            {
                LoadDSLop(e.Node.Tag.ToString());
                int row = dataGridView1.RowCount;
                label_thongke.Text = "Tổng số lớp thuộc khoa " + e.Node.Tag.ToString() + " là :" + row.ToString();
                label7.Text = "A";
                Clear();
                status();
            }
            if (e.Node.Level == 2)
            {
                LoadDSSinhVien(e.Node.Tag.ToString());
                int row = dataGridView1.RowCount;
                label_thongke.Text = "Tổng số sinh viên trong lớp "+e.Node.Tag.ToString()+ " là: " + row.ToString();
                label7.Text = "B";
                textBox_malop.Text=e.Node.Tag.ToString();
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && label7.Text=="B")
            {
                textBox_ma.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox_ten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox_diachi.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox_ns.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox_malop.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pictureBox1.Image = Image.FromFile("Image/" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + ".jpg");
            }
        }
        public void Clear()
        {
            textBox_ma.Text = null;
            textBox_ten.Text = null;
            textBox_diachi.Text = null;
            textBox_ns.Text = null;
        }
        public void status()
        {
            button_them.Text = "Thêm Sv";
            button_them.Enabled = true;
            button_luu.Enabled = false;
            button_sua.Text = "Chỉnh sửa";
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            linkLabel1.Enabled = false;
            pictureBox1.Image = null;
            
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            if (button_them.Text == "Thêm Sv")
            {
                if (textBox_malop.Text == "")
                {
                    MessageBox.Show("Chọn lớp trước khi thêm sinh viên!");
                }
                else
                {
                    button_them.Text = "Hủy bỏ";
                    button_luu.Enabled = true;
                    button_sua.Enabled = false;
                    button_xoa.Enabled = false;
                    Clear();
                    pictureBox1.Image = null;
                    linkLabel1.Enabled = true;
                }
            }
            else
            {
                Clear();
                status();
                
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (button_sua.Text == "Chỉnh sửa")
            {
                textBox_ma.Enabled = false;
                textBox_malop.Enabled = false;
                button_sua.Text = "Hủy bỏ";
                button_them.Enabled = false;
                button_xoa.Enabled = false;
                button_luu.Enabled = true;
            }
            else
            {
                textBox_ma.Enabled = true;
                textBox_malop.Enabled = true;
                Clear();
                status();
              
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok ==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (button_them.Text == "Hủy bỏ")
            {
                if (textBox_ma.Text == "")
                {
                    MessageBox.Show("Nhập vào mã sinh viên");
                    textBox_ma.Focus();
                }
                else
                {
                    if (textBox_ten.Text == "")
                    {
                        MessageBox.Show("Nhập vào tên sinh viên");
                        textBox_ten.Focus();
                    }
                    else
                    {
                        if (textBox_diachi.Text == "")
                        {
                            MessageBox.Show("Nhập vào địa chỉ sinh viên");
                            textBox_diachi.Focus();
                        }
                        else
                        {
                            if (textBox_ns.Text == "")
                            {
                                MessageBox.Show("Nhập vào ngày sinh của sinh viên");
                                textBox_ns.Focus();
                            }
                            else
                            {
                                if(pictureBox1.Image==null)
                                {
                                    MessageBox.Show("Chọn hình sinh viên");
                                }
                                else
                                {
                                    try
                                    {
                                        int kq = ThemSV(textBox_ma.Text, textBox_ten.Text, textBox_diachi.Text, textBox_ns.Text, textBox_malop.Text);
                                        if (kq == 1)
                                        {
                                            pictureBox1.Image.Save("Image//" + textBox_ma.Text + ".jpg");
                                            MessageBox.Show("Đã thêm sinh viên: " + textBox_ten.Text);
                                            LoadTreeView();
                                            LoadDSSinhVien(textBox_malop.Text);
                                            Clear();
                                            status();
                                           
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Trùng mã sinh viên");
                                        textBox_ma.Text = "";
                                        textBox_ma.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (button_sua.Text == "Hủy bỏ")
            {
                if (textBox_ma.Text == "")
                {
                    MessageBox.Show("Chọn sinh viên muốn sửa");
                }
                else
                {
                    if(textBox_ten.Text==""||textBox_diachi.Text==""||textBox_ns.Text=="")
                    {
                        MessageBox.Show("Nhập vào thông tin");
                    }
                    else
                    {
                        int kq = SuaSV(textBox_ten.Text, textBox_diachi.Text, textBox_ns.Text, textBox_ma.Text);
                        if (kq == 1)
                        {
                            MessageBox.Show("Đã cập nhật");
                            Clear();
                            status();
                            LoadTreeView();
                            LoadDSSinhVien(textBox_malop.Text);
                        }
                    }
                }
            }
        }
        string filename;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName == "")
                {
                    return;
                }
                else
                {
                    filename = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(filename.ToString());

                }
            }
            catch
            {
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (textBox_ma.Text == "")
            {
                MessageBox.Show("Chọn sinh viên muốn xóa");
            }
            else
            {
                DialogResult ok;
                ok = MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên: " + textBox_ten.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    int kq = XoaSV(textBox_ma.Text);
                    if (kq == 1)
                    {  
                        MessageBox.Show("Xóa thành công");
                        Clear();
                        status();
                        LoadTreeView();
                        LoadDSSinhVien(textBox_malop.Text);
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
