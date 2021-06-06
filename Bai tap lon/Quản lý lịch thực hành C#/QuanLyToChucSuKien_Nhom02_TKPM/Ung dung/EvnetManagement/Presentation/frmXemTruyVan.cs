using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace EventManager.Presentation
{
    public partial class frmXemTruyVan :XtraForm
    {
        public frmXemTruyVan()
        {
            InitializeComponent();
        }

        public string TruyVan
        {
            set { richTextBoxEx1.Text = value; }
            get { return richTextBoxEx1.Text; }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxEx1.WordWrap = checkEdit1.Checked;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public delegate void TruyenKetQua(string query);
        public TruyenKetQua ketQua;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                    if (ketQua != null)
                    {
                        ketQua(richTextBoxEx1.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}