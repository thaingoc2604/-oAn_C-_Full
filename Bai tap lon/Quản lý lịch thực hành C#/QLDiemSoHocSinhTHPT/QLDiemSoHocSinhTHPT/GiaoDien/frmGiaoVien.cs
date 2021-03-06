using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Controller;
using QLDiemSoHocSinhTHPT.Report;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmGiaoVien : Form
    {
        #region Controller
        private GiaoVienController m_Controller;

        public GiaoVienController Controller
        {
            get { return m_Controller; }
            set { m_Controller = value; }
        }

        #endregion

        #region MonHocController
        private MonHocController m_MonHocController;

        public MonHocController MonHocController
        {
            get { return m_MonHocController; }
            set { m_MonHocController = value; }
        }

        #endregion

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        public frmGiaoVien(GiaoVienController ctrl)
        {
            this.Controller = ctrl;
            InitializeComponent();
        }

        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            //Khoi tao doi tuong m_Controller
            if (this.Controller == null)
            {
                this.Controller = new GiaoVienController();
            }

            //Khoi tao doi tuong m_MonHocController
            if (this.MonHocController == null)
            {
                this.MonHocController = new MonHocController();
            }

            //Hien thi ComboBox mon hoc
            this.MonHocController.HienThiCombobox(this.cmbMonHoc);
            //Hien thi DataGridViewComboBoxColumn mon hoc
            this.MonHocController.HienThiDataGridComboBoxColumn(this.colMonHoc);

            //Hien thi DS Giao vien
            this.Controller.HienThiDS(this.dgvDS, this.bnDS, this.txtMaGiaoVien, this.txtHoTen, this.dpNgaySinh, this.cbxGioiTinh, this.cmbMonHoc, this.txtDienThoai, this.txtNoiSinh, this.txtDiaChi);

            //Neu trong danh sach khong co dong nao
            if (this.dgvDS.Rows.Count == 0)
            {
                this.btXoa.Enabled = false;
                this.itXoa.Enabled = false;
            }
        }

        /// <summary>
        /// Phat sinh MaGiaoVien tu dong
        /// </summary>
        /// <returns></returns>
        public string PhatSinhMa()
        {
            if (this.Controller == null)
            {
                this.Controller = new GiaoVienController();
            }
            string lastID = this.Controller.LayMaCuoi();
            int numOfLastID;
            //khi chua co record nao trong csdl this lastID se la "", khi co ta bat dau tu 1
            if (lastID == "")
            {
                numOfLastID = 1;
            }
            else
            {
                numOfLastID = int.Parse(lastID.Substring(2, 4));
                numOfLastID++;
            }
            return "GV" + (numOfLastID + 10000).ToString().Substring(1, 4);
        }

        /// <summary>
        /// Click nut Them Moi hoac context menu Them Moi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThemMoi_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)this.bnDS.BindingSource.AddNew();
            row["MaGiaoVien"] = this.PhatSinhMa();
            row["GioiTinh"] = true;
            this.bnDS.BindingSource.MoveLast();

            this.btThemMoi.Enabled = false;
            this.btXoa.Enabled = false;
            this.btBoQua.Enabled = true;
            this.btLuu.Enabled = true;

            this.itThemMoi.Enabled = false;
            this.itXoa.Enabled = false;
            this.itBoQua.Enabled = true;
            this.itLuu.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBoQua_Click(object sender, EventArgs e)
        {
            this.Controller.Data.LayDS();

            this.btThemMoi.Enabled = true;
            this.btXoa.Enabled = true;
            this.btLuu.Enabled = false;
            this.btBoQua.Enabled = false;

            this.itThemMoi.Enabled = true;
            this.itXoa.Enabled = true;
            this.itLuu.Enabled = false;
            this.itBoQua.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLuu_Click(object sender, EventArgs e)
        {
            //Dua con tro de bindingNavigatorPositionItem
            this.bindingNavigatorPositionItem.Focus();
            //Bind de dong cuoi de cap nhat thong tin tren DataGridView
            this.bnDS.BindingSource.Position = int.Parse(this.bindingNavigatorPositionItem.Text);
            //Neu luu thanh cong
            if (!this.Controller.Update())
            {
                MessageBox.Show("Không thể lưu!", "Lưu Giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Controller.Data.LayDS();
            }

            this.btThemMoi.Enabled = true;
            this.btXoa.Enabled = true;
            this.btBoQua.Enabled = false;
            this.btLuu.Enabled = false;

            this.itThemMoi.Enabled = true;
            this.itXoa.Enabled = true;
            this.itBoQua.Enabled = false;
            this.itLuu.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không?", "Xóa Giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = this.dgvDS.SelectedRows.GetEnumerator();
                //Truong hop co nhieu dong duoc chon
                if (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    this.dgvDS.Rows.Remove(row);
                    while (ie.MoveNext())
                    {
                        row = (DataGridViewRow)ie.Current;
                        this.dgvDS.Rows.Remove(row);
                    }
                }
                else    //Chi chon mot dong
                {
                    this.bnDS.BindingSource.RemoveCurrent();
                }

                if (this.Controller.Update())
                {
                    MessageBox.Show("Đã xóa!", "Xóa Giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Neu trong danh sach khong con dong nao
                    if (this.dgvDS.Rows.Count == 0)
                    {
                        this.btXoa.Enabled = false;
                        this.itXoa.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Xóa Giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    this.Controller.Data.LayDS();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDS_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa không?", "Xóa Giáo viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //Neu chon No, cancel thao tac xoa
                e.Cancel = true;
            }
            else
            {
                /*
                 * Vi thao tac xoa chi co tac dung tren DataGridView nen ta cancel di
                 * Sau co xoa theo cach cua ta
                 * */
                e.Cancel = true;
                IEnumerator ie = this.dgvDS.SelectedRows.GetEnumerator();
                if (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    this.dgvDS.Rows.Remove(row);
                    while (ie.MoveNext())
                    {
                        row = (DataGridViewRow)ie.Current;
                        this.dgvDS.Rows.Remove(row);
                    }
                }
                else
                {
                    this.bnDS.BindingSource.RemoveCurrent();
                }

                if (this.Controller.Update())
                {
                    MessageBox.Show("Đã xóa!", "Xóa Giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Neu trong danh sach khong con dong nao
                    if (this.dgvDS.Rows.Count == 0)
                    {
                        this.btXoa.Enabled = false;
                        this.itXoa.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Xóa chủ đề", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Controller = new GiaoVienController();
                    this.Controller.Data.LayDS();
                    //this.Controller.DisplayList(this.dgvList, this.bn);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /* 
             * Khi co mot cell trong DataGridView bo thay doi gia tri
             * Ta cho enable va disable cac button va cac item context menu cho phu hop
             * */
            this.btBoQua.Enabled = true;
            this.btLuu.Enabled = true;
            this.btThemMoi.Enabled = false;
            this.btXoa.Enabled = false;

            this.itBoQua.Enabled = true;
            this.itLuu.Enabled = true;
            this.itThemMoi.Enabled = false;
            this.itXoa.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGiaoVien_Shown(object sender, EventArgs e)
        {
            this.btThemMoi.Enabled = true;
            this.btXoa.Enabled = true;

            this.itThemMoi.Enabled = true;
            this.itXoa.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThemMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc frm_MonHoc = new frmMonHoc(this.MonHocController);
            frm_MonHoc.WindowState = FormWindowState.Normal;
            frm_MonHoc.Show();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            rptFrmDSGV frm_DSGV = new rptFrmDSGV();
            frm_DSGV.Show();
        }        
    }
}