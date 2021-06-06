using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{
    public partial class uaGoods : UserControl
    {
        public uaGoods()
        {
            InitializeComponent();
        }

        private void uaGoods_Load(object sender, EventArgs e)
        {

        }

        private void uaGoodsBtnInsert_Click(object sender, EventArgs e)
        {

        }

        private void uaGoodsBtnDelete_MouseLeave(object sender, EventArgs e)
        {
            uaGoodsBtnDelete.BackgroundImage = Properties.Resources.btn1;
        }
        private void uaGoodsBtnDelete_MouseEnter(object sender, EventArgs e)
        {
            uaGoodsBtnDelete.BackgroundImage = Properties.Resources.btn2;
        }
        private void uaGoodsBtnInsert_MouseLeave(object sender, EventArgs e)
        {
            uaGoodsBtnInsert.BackgroundImage = Properties.Resources.btn1;
        }

        private void uaGoodsBtnInsert_MouseEnter(object sender, EventArgs e)
        {
            uaGoodsBtnInsert.BackgroundImage = Properties.Resources.btn2;
        }

        private void uaGoodsBtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            uaGoodsBtnUpdate.BackgroundImage = Properties.Resources.btn1;
        }

        private void uaGoodsBtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            uaGoodsBtnUpdate.BackgroundImage = Properties.Resources.btn2;
        }
    }
}
