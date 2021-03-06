using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Data.OleDb;
using ADOX;

namespace ManagementSASI
{
    public partial class frmStudent : DevExpress.XtraEditors.XtraForm
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
        private void LoadGridView()
        {
            var query = db.LoadGridViewStudent1();
            //XtraMessageBox.Show("1");
            grcStudent.DataSource = query;
            //XtraMessageBox.Show("2");
        }
        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStudentCode.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mã sinh viên", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtStudentCode.Focus();
            }
            else
            {
                if (txtStudentName.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên sinh viên", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtStudentName.Focus();
                }
                else
                {
                    Student s = new Student();
                    s.StudentCode = txtStudentCode.Text;
                    s.FullName = txtStudentName.Text;
                    s.Birthday = dtpBirthDay.Text;
                    s.PriorityCode = "";
                    db.Students.InsertOnSubmit(s);
                    db.SubmitChanges();
                    LoadGridView();
                }
            }
        }

        private void grcStudent_Click(object sender, EventArgs e)
        {
            try
            {
            txtStudentCode.Text = grvStudent.GetRowCellDisplayText(grvStudent.FocusedRowHandle, "Mã_sinh_viên");
            txtStudentName.Text = grvStudent.GetRowCellDisplayText(grvStudent.FocusedRowHandle, "Tên_sinh_viên");
            dtpBirthDay.Text = grvStudent.GetRowCellDisplayText(grvStudent.FocusedRowHandle, "Ngày_sinh");
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn sửa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Student s = db.Students.SingleOrDefault(c => c.StudentCode == txtStudentCode.Text);
                if (s != null)
                {
                    s.FullName = txtStudentName.Text;
                    s.Birthday = dtpBirthDay.Text;
                    s.PriorityCode = "";
                    db.SubmitChanges();
                    LoadGridView();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa không ?", Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Student s = db.Students.SingleOrDefault(c => c.StudentCode == txtStudentCode.Text);
                if (s != null)
                {
                    db.Students.DeleteOnSubmit(s);
                    db.SubmitChanges();
                    LoadGridView();
                }
            }
        }

        private void btnAddExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Chọn file";
            fdlg.Filter = "Excel Sheet(*.xls)|*.xls|(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = fdlg.FileName;
                int viTriBatDau = fileName.LastIndexOf('\\') + 1;
                string tenFile = fileName.Substring(viTriBatDau);
                string path = fileName.Replace("\\", "\\\\");
                Import(path);
                Application.DoEvents();
                int l = 0;
                bool ok1 = true; int k = 0;
                for (int i = 0; i < grvStudent.RowCount; i++)
                {
                    var query = from c in db.Students
                                select new { c.StudentCode };
                    bool ok = true;
                    foreach (var item in query)
                    {
                        if (grvStudent.GetRowCellDisplayText(i, "Mã_sinh_viên").ToString() == item.StudentCode)
                        {
                            ok = false; ok1 = false;
                            k++;
                            break;
                        }
                    }
                    if (ok)
                    {
                        if (grvStudent.GetRowCellDisplayText(i, "Mã_sinh_viên").Length ==8)
                        {
                            Student s = new Student();
                            s.StudentCode = grvStudent.GetRowCellDisplayText(i, "Mã_sinh_viên").ToString();

                            s.FullName = grvStudent.GetRowCellDisplayText(i, "Tên_sinh_viên").ToString();
                            s.Birthday = grvStudent.GetRowCellDisplayText(i, "Ngày_sinh").ToString();
                            s.PriorityCode = "";
                            db.Students.InsertOnSubmit(s);
                            db.SubmitChanges();
                            l++;
                        }
                    }

                }
                if (ok1 == false)
                {
                    XtraMessageBox.Show(k + " đã bị trùng ", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LoadGridView();
                XtraMessageBox.Show("Đã nhập " + l + " sinh viên");
            }


        }
        public static string SelectedTable1 = string.Empty;




        public void Import(string strPart)
        {
            //try
            //{
            string[] strTable = GetTableExcel(strPart);
            frmSelectTableExcel frm = new frmSelectTableExcel(strTable);
            frm.ShowDialog(this);
            frm.Dispose();
            if ((SelectedTable1 != string.Empty) && (SelectedTable1 != null))
            {
                DataTable dt = GetDataTableExcel(strPart, SelectedTable1);
                grcStudent.DataSource = dt.DefaultView;
            }
            //}
            //catch { }


        }

        // /// <summary>
        // /// lay ban trong excle
        // /// </summary>
        // /// <param name="strFileName"></param>
        // /// <returns></returns>
        // /// 
        
        public static String[] GetTableExcel(string strFileName)
        {
            string[] strTables = new string[100];
            Catalog oCatlog = new Catalog();
            ADOX.Table otable = new ADOX.Table();
            ADODB.Connection oconn = new ADODB.Connection();
            string re = strFileName.Substring(strFileName.Length - 3);
            if (re == "xls")
            {
                oconn.Open("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";", "", "", 0);

            }
            else
            {
                oconn.Open("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";", "", "", 0);
            }
            oCatlog.ActiveConnection = oconn;
            if (oCatlog.Tables.Count > 0)
            {
                int item = 0;
                foreach (ADOX.Table tab in oCatlog.Tables)
                {
                    if (tab.Type == "TABLE")
                    {
                        strTables[item] = tab.Name;
                        item++;
                    }
                }
            }
            return strTables;
        }

        // /// <summary>
        // /// 
        // /// </summary>
        // /// <param name="strFileName"></param>
        // /// <param name="Table"></param>
        // /// <returns></returns>
        public static DataTable GetDataTableExcel(string strFileName, string Table)
        {
            string re = strFileName.Substring(strFileName.Length - 3);
            OleDbConnection conn;
            if (re == "xls")
            {
                conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
            }
            else
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
            }
            conn.Open();
            string strQuery = "SELECT*FROM [" + Table + "]";
            OleDbDataAdapter da = new OleDbDataAdapter(strQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

    }
}