using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qlkaraoke
{     
    public partial class fRoom : Form
    {
       public string roomID;
        public fRoom(string ID)
        {
            this.roomID = ID;
            InitializeComponent();
        }

        private void fRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Promotion' table. You can move, or remove it, as needed.
            this.promotionTableAdapter.Fill(this.dataSet1.Promotion);
            // TODO: This line of code loads data into the 'dataSet1.Kindroom' table. You can move, or remove it, as needed.
            this.kindroomTableAdapter.Fill(this.dataSet1.Kindroom);
            // TODO: This line of code loads data into the 'dataSet1.Kindcustomer' table. You can move, or remove it, as needed.
            this.kindcustomerTableAdapter.Fill(this.dataSet1.Kindcustomer);
            qlkaraoke.DataSet1.BillsDataTable billdt = billsTableAdapter1.GetDataByRoomID(Convert.ToInt32(this.roomID));
            qlkaraoke.DataSet1.PromotionDataTable prodt = promotionTableAdapter.GetDataByStatus();
            qlkaraoke.DataSet1.GoodsDataTable gooddtDis = goodsTableAdapter1.GetDataByDishes();
            qlkaraoke.DataSet1.GoodsDataTable gooddtBebe = goodsTableAdapter1.GetDataByBeberage();
            if (billdt.Count > 0)
            {
                // set value into textfield of form bills
                this.fRoomTxtStartTime.Text = billdt[0]["Start_date"].ToString();
                this.fRoomTxtEndTime.Text = billdt[0]["End_date"].ToString();
                this.fRoomTxtPersonNumber.Text = billdt[0]["Person"].ToString();
                this.fRoomTxtVat.Text = billdt[0]["vat"].ToString();
                this.fRoomTxtTotal.Text = billdt[0]["Total"].ToString();
                //TODO: Load Kind customer
                qlkaraoke.DataSet1.CustomerDataTable customerdt = customerTableAdapter1.GetData();
                
                this.fRoomCBoxKindCustomer.DataSource = customerdt;
                this.fRoomCBoxKindCustomer.DisplayMember = "Name";
                this.fRoomCBoxKindCustomer.ValueMember = "Customer_ID";
                if (billdt[0]["Customer_ID"].ToString() != "")
                {
                    int CustomerID = Convert.ToInt32(billdt[0]["Customer_ID"]);
                    this.fRoomCBoxKindCustomer.SelectedValue = CustomerID;
                }
                //TODO: Load Kind Room
                if (billdt[0]["Kindroom_ID"].ToString() != "")
                {
                    //MessageBox.Show(billdt[0]["Kindroom_ID"].ToString());
                    int kindRoomID = Convert.ToInt32(billdt[0]["Kindroom_ID"].ToString());
                    this.fRoomTxtCBoxKindRoom.SelectedValue = kindRoomID;
                }

                if (prodt.Count > 0)
                {
                    //TODO: load promotions if status = 1
                    
                    this.fRoomCBoxPromotion.DataSource = prodt;
                    this.fRoomCBoxPromotion.DisplayMember = "Pro_name";
                    this.fRoomCBoxPromotion.ValueMember = "Pro_ID";
                    if (billdt[0]["Pro_ID"].ToString()!= "")
                    {
                        int proID = Convert.ToInt32(billdt[0]["Pro_ID"]);
                        this.fRoomCBoxPromotion.SelectedValue = proID;
                    }
                }
                //TODO: Add Dishers
                if (gooddtDis.Count > 0)
                {
                    for (int i = 0; i < gooddtDis.Count; i++)
                    {
                        fRoomCBoxListDishes.Items.Add(new item(gooddtDis[i]["Goods_name"].ToString(), Convert.ToInt32(gooddtDis[i]["Goods_ID"])));
                    }
                    //TODO: select Disher selected
                    string[] arrDis = billdt[0]["Dishers_ID"].ToString().Split(',');

                    for (int it = 0; it < this.fRoomCBoxListDishes.Items.Count; it++)
                    {

                        item itDis = (item)this.fRoomCBoxListDishes.Items[it];
                        for (int r = 0; r < arrDis.Length; r++)
                        {
                            if (itDis.iID.ToString() == arrDis[r].ToString())
                                this.fRoomCBoxListDishes.SetItemChecked(it, true);
                        }
                    }
                }
                //TODO: Add Beberages
                if (gooddtBebe.Count > 0)
                {
                    for (int y = 0; y < gooddtBebe.Count; y++)
                    {
                        fRoomCBoxListBeberage.Items.Add(new item(gooddtBebe[y]["Goods_name"].ToString(), Convert.ToInt32(gooddtBebe[y]["Goods_ID"])));
                    }
                    //TODO: select Beberages selected
                    string[] arrBeber = billdt[0]["Beberages_ID"].ToString().Split(',');

                    for (int ib = 0; ib < this.fRoomCBoxListBeberage.Items.Count; ib++)
                    {

                        item itBeber = (item)this.fRoomCBoxListBeberage.Items[ib];
                        for (int a = 0; a < arrBeber.Length; a++)
                        {
                            if (itBeber.iID.ToString() == arrBeber[a].ToString())
                                this.fRoomCBoxListBeberage.SetItemChecked(ib, true);
                        }
                    }
                }               
            }
        }

        private void fRoomBtnPayment_Click(object sender, EventArgs e)
        {
            //TODO: check vat null
            if (this.fRoomTxtVat.Text == "")
            {
                this.fRoomTxtVat.Text = "10";
            }
            try
            {
                //TODO: get bills by current room ID
                qlkaraoke.DataSet1.BillsDataTable billdt2 = billsTableAdapter1.GetDataByRoomID(Convert.ToInt32(this.roomID));
                int Bills_ID = Convert.ToInt32(billdt2[0]["Bill_ID"]);
                //TODO: get price customer folow kindCustomer of Customer
                int Customer_ID = Convert.ToInt32(this.fRoomCBoxKindCustomer.SelectedValue.ToString());
                qlkaraoke.DataSet1.CustomerDataTable customerdt = customerTableAdapter1.GetDataByID(Customer_ID);
                int kindCustomerID = Convert.ToInt32(customerdt[0]["Kindcustomer_ID"]);
                qlkaraoke.DataSet1.KindcustomerDataTable kindCustomerdt = kindcustomerTableAdapter.GetDataByID(kindCustomerID);
                //TODO: get Discount
                int icustomerDis = 0;
                if (kindCustomerdt.Count > 0)
                {
                    icustomerDis = Convert.ToInt32(kindCustomerdt[0]["Discount"]);
                }
                //TODO: get price Room folow kindRoom of Room
                int kindRoomID = Convert.ToInt32(this.fRoomTxtCBoxKindRoom.SelectedValue.ToString());
                //qlkaraoke.DataSet1.RoomDataTable roomdt = roomTableAdapter1.GetDataByID(Room_ID);
                //int kindRoomID = Convert.ToInt32(roomdt[0]["Kindroom_ID"]);
                qlkaraoke.DataSet1.KindroomDataTable kindRoomdt = kindroomTableAdapter.GetDataByID(kindRoomID);
                int iroomPrice = 0;
                if (kindRoomdt.Count > 0)
                {
                    iroomPrice = Convert.ToInt32(kindRoomdt[0]["Kind_price"]);
                }
                //TODO: get ProID
                int Pro_ID = Convert.ToInt32(this.fRoomCBoxPromotion.SelectedValue.ToString());
                //TOD: get Endtime
                this.fRoomTxtEndTime.Text = DateTime.Now.ToString();
                //TODO: Get vat
                int iVat = Convert.ToInt32(this.fRoomTxtVat.Text);
                int iPriceDis = 0;
                int iPriceBeber = 0;
                string strDis = "";
                string strBeber = "";
                string strDis_ID = "";
                string strBeber_ID = "";
                int iTotalGoods = 0;
                //TODO: get value Disher
                int iTotalNumDis = this.fRoomCBoxListDishes.CheckedItems.Count;
                for (int i = 0; i < iTotalNumDis; i++)
                {
                    item itDis = (item)this.fRoomCBoxListDishes.CheckedItems[i];
                    qlkaraoke.DataSet1.GoodsDataTable gooddt = goodsTableAdapter1.GetDataByID(Convert.ToInt32(itDis.iID.ToString()));
                    iPriceDis += Convert.ToInt32(gooddt[0]["Goods_price"].ToString());
                    if (iTotalNumDis > 1)
                    {
                        strDis += gooddt[0]["Goods_name"].ToString();
                        strDis_ID += itDis.iID.ToString();
                        if (i < (iTotalNumDis - 1))
                        {
                            strDis += ",";
                            strDis_ID += ",";
                        }
                    }
                    else
                    {
                        strDis += gooddt[0]["Goods_name"].ToString();
                        strDis_ID += itDis.iID.ToString();
                    }
                    iTotalGoods++;
                }
                //TODO: get value Beberage
                int iTotalNumBebe = this.fRoomCBoxListBeberage.CheckedItems.Count;
                for (int y = 0; y < iTotalNumBebe; y++)
                {
                    item itBeber = (item)this.fRoomCBoxListBeberage.CheckedItems[y];
                    qlkaraoke.DataSet1.GoodsDataTable gooddt = goodsTableAdapter1.GetDataByID(Convert.ToInt32(itBeber.iID.ToString()));
                    iPriceBeber += Convert.ToInt32(gooddt[0]["Goods_price"].ToString());
                    if (iTotalNumBebe > 1)
                    {
                        strBeber += gooddt[0]["Goods_name"].ToString();
                        strBeber_ID += itBeber.iID.ToString();
                        if (y < (iTotalNumBebe - 1))
                        {
                            strBeber += ",";
                            strBeber_ID += ",";
                        }
                    }
                    else
                    {
                        strBeber += gooddt[0]["Goods_name"].ToString();
                        strBeber_ID += itBeber.iID.ToString();
                    }
                    iTotalGoods++;
                }
                //TODO: Total
                int iTotal = (iroomPrice + iPriceDis + iPriceBeber) - icustomerDis;
                int iTotalvat = iTotal + ((iVat * iTotal) / 100);
                this.fRoomTxtTotal.Text = iTotalvat.ToString();
                //TODO: Update when button payment click
                billsTableAdapter1.UpdateQueryPayment(DateTime.Now, iTotalGoods, Customer_ID, iVat, Pro_ID, iTotalvat, iTotal, strBeber, strDis, strDis_ID, strBeber_ID, kindRoomID, Bills_ID);
                //TODO: message success
                MessageBox.Show("Payment success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                //MessageBox.Show("Vat only number, please!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fRoomBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fRoomBtnBill_Click(object sender, EventArgs e)
        {
            fReportBill fre = new fReportBill(Convert.ToInt32(roomID));
            fre.ShowDialog();
        }

        private void fRoomBtnPayment_MouseEnter(object sender, EventArgs e)
        {
            fRoomBtnPayment.Image = Properties.Resources.btn21;
        }

        private void fRoomBtnPayment_MouseLeave(object sender, EventArgs e)
        {
            fRoomBtnPayment.Image = Properties.Resources.btn11;
        }

        private void fRoomBtnBill_MouseEnter(object sender, EventArgs e)
        {
            fRoomBtnBill.Image = Properties.Resources.btn21;
        }

        private void fRoomBtnBill_MouseLeave(object sender, EventArgs e)
        {
            fRoomBtnBill.Image = Properties.Resources.btn11;
        }

        private void fRoomBtnClose_MouseEnter(object sender, EventArgs e)
        {
            fRoomBtnClose.Image = Properties.Resources.btn21;
        }

        private void fRoomBtnClose_MouseLeave(object sender, EventArgs e)
        {
            fRoomBtnClose.Image = Properties.Resources.btn11;
        }

       
    }
}