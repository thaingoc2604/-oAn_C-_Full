using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TT_GDTX_ANGIANG.Controller;
using TT_GDTX_ANGIANG.BusinessObject;
using TT_GDTX_ANGIANG.DataLayer;

namespace TT_GDTX_ANGIANG
{
    public partial class frm_LISH_DANHSACHTRUNGTUYEN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_LISH_DANHSACHTRUNGTUYEN()
        {
            InitializeComponent();
        }

        #region Property
        private string m_Enable;
        public string An_Hien
        {
            get { return m_Enable; }
            set { m_Enable = value; }
        }
        #endregion

        #region ctrlTrungTuyen
        private KetQuaTuyenDungCtrl m_ctrlTrungTuyen;
        public KetQuaTuyenDungCtrl ctrlTrungTuyen
        {
            get { return m_ctrlTrungTuyen; }
            set { m_ctrlTrungTuyen = value; }
        }
        #endregion               

        #region PhanQuyen_Xem
        public void PhanQuyen_Xem_An()
        {
            //this.Xoa_toolStripButton.Enabled = false;
            //this.GoRa_toolStripButton.Enabled = false;
        }
        public void PhanQuyen_Xem_Hien()
        {
            //this.Xoa_toolStripButton.Enabled = true;
            //this.GoRa_toolStripButton.Enabled = true;
        }
        #endregion

        private void frm_LISH_DANHSACHTRUNGTUYEN_Load(object sender, EventArgs e)
        {
            if (An_Hien == "Xem")
            {
                this.PhanQuyen_Xem_An();
            }
            else
            {
                this.PhanQuyen_Xem_Hien();
            }
            this.ReLoad();
        }

        #region ReLoad()
        public void ReLoad()
        {
            if (ctrlTrungTuyen == null)
                ctrlTrungTuyen = new KetQuaTuyenDungCtrl();
            ctrlTrungTuyen.HienThi_dsTrungTuyen(this.listView1, 1);
        }
        #endregion


        #region Thoat_toolStripButton_Click        
       
        private void Thoat_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}