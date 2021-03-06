using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class frmRule : DevComponents.DotNetBar.Office2007Form
    {
        public frmRule()
        {
            InitializeComponent();
        }

        private void frmRule_Load(object sender, EventArgs e)
        {
            Rule rules = Shared.allRules;
            txtMinMoney.Value = rules.SoDuTKToiThieu;
            txtTransDays.Value = rules.SoNgayGD;
            txtSameBank.Value = rules.CPCKCungNH;
            txtOtherBank.Value = rules.CPCKKhacNH;
            txtMinSend.Value = rules.SoTienGuiToiThieu;
            txtMaxWithdrawDay.Value = rules.SoTienRutToiDaMotNgay;
            txtMaxTimeWithdrawDay.Value = rules.SoLanRutToiDaMotNgay;
            txtMaxWithdrawTran.Value = rules.SoTienRutToiDaGD;
            txtMinWithdrawTran.Value = rules.SoTienRutToiThieuGD;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;            
            decimal nSoDuTKToiThieu = (decimal)txtMinMoney.Value;
            decimal nSoTienGuiToiThieu = (decimal)txtMinSend.Value;
            int nSoLanRutToiDaMotNgay = (int)txtMaxTimeWithdrawDay.Value;
            decimal nSoTienRutToiDaMotNgay = (decimal)txtMaxWithdrawDay.Value;
            decimal nSoTienRutToiThieuGD = (decimal)txtMinWithdrawTran.Value;
            decimal nSoTienRutToiDaGD = (decimal)txtMaxWithdrawTran.Value;
            float nCPCKCungNH = (float)txtSameBank.Value;
            float nCPCKKhacNH = (float)txtOtherBank.Value;
            int nSoNgayGD = (int)txtTransDays.Value;

            Rule newRule = new Rule(nSoDuTKToiThieu, nSoTienGuiToiThieu, nSoLanRutToiDaMotNgay, nSoTienRutToiDaMotNgay, nSoTienRutToiThieuGD, nSoTienRutToiDaGD, nCPCKCungNH, nCPCKKhacNH, nSoNgayGD);
            string err = newRule.Validate();
            if (err != "")
            {
                Program.ShowMsg(err, true);
                this.Cursor = Cursors.Default;
                return;
            }

            if (newRule.Save())
            {
                Program.ShowMsg("Đã cập nhật các quy định.");
                Shared.allRules = newRule;
            }
            else Program.ShowMsg("Không thể cập nhật các quy định!!!");
            this.Cursor = Cursors.Default;
        }
    }
}