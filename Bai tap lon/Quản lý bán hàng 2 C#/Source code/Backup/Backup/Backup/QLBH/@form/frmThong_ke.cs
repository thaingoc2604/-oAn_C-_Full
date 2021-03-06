using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient ;
using CrystalDecisions.Shared;
namespace QLBH._forms
{
    public partial class frmThong_ke : Form
    {
        public frmThong_ke()
        {
            InitializeComponent();
        }
       public string str = "";   // lấy giá trị thiết lập chế độ Modify/Add
       OracleCommand cmdForm = new OracleCommand();
       _class.clsORACEL clsCon = new QLBH._class.clsORACEL();
        _class.cls_myFunctions clsmyFunction = new QLBH._class.cls_myFunctions();

        private void com_nam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThong_ke_Load(object sender, EventArgs e)
        {
            
            clsCon.comboFill(com_nam, "(select distinct TO_char(ngayxuat,'YYYY') as nam from hoa_don_xuat) union (select distinct to_char(ngaynhap,'YYYY') as nam from hoa_don_nhap)", "Nam", "nam", "nam");
            clsCon.comboFill(com_thang, "(select distinct TO_char(ngayxuat,'MM') as thang from hoa_don_xuat) union (select distinct to_char(ngaynhap,'MM') as thang from hoa_don_nhap)", "Thang", "thang", "thang");
            clsCon.dataGridFill("select  sohdn,maloai,mahang,soluongn,dongian from chi_tiet_nhap where sohdn in (select sohdn from hoa_don_nhap where to_char(ngaynhap,'MM')='" + com_thang.Text + "' and to_char(ngaynhap,'YYYY')='" + com_nam.Text + "')", grid_view, "thong_ke");
            try
            {
                clsCon.cmdOpen(cmdForm);
                cmdForm.CommandText = "select  sum(soluongn*dongian) as tt from chi_tiet_nhap where sohdn in (select sohdn from hoa_don_nhap where to_char(ngaynhap,'MM')='" + com_thang.Text + "' and to_char(ngaynhap,'YYYY')='" + com_nam.Text + "')";
                txt_tt.Text = cmdForm.ExecuteScalar().ToString();  
                grid_view.Columns[0].HeaderText = "Số hoá đơn nhập";
                grid_view.Columns[1].HeaderText = "Mã loại";
                grid_view.Columns[2].HeaderText = "Mã hàng";
                grid_view.Columns[3].HeaderText = "Số lượng";
                grid_view.Columns[4].HeaderText = "Đơn giá";
            }
            catch (Exception ex)
            {
                clsmyFunction.setMessageBox(ex.Message, 3);
            }

        }

        private void btn_thong_ke_Click(object sender, EventArgs e)
        {
            if (radio_nhap.Checked == true)
            {
                clsCon.dataGridFill("select  sohdn,maloai,mahang,soluongn,dongian from chi_tiet_nhap where sohdn in (select sohdn from hoa_don_nhap where to_char(ngaynhap,'MM')='" + com_thang.Text + "' and to_char(ngaynhap,'YYYY')='" + com_nam.Text + "')", grid_view, "thong_ke");
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "select  sum(soluongn*dongian) as tt from chi_tiet_nhap where sohdn in (select sohdn from hoa_don_nhap where to_char(ngaynhap,'MM')='" + com_thang.Text + "' and to_char(ngaynhap,'YYYY')='" + com_nam.Text + "')";
                    txt_tt.Text=cmdForm.ExecuteScalar ().ToString();
                    grid_view.Columns[0].HeaderText = "Số hoá đơn nhập";
                    grid_view.Columns[1].HeaderText = "Mã loại";
                    grid_view.Columns[2].HeaderText = "Mã hàng";
                    grid_view.Columns[3].HeaderText = "Số lượng";
                    grid_view.Columns[4].HeaderText = "Đơn giá";
                }
                catch (Exception ex)
                {
                    clsmyFunction.setMessageBox(ex.Message, 3);
                }
            }
            else 
            {
                clsCon.dataGridFill("select  sohdx,maloai,mahang,soluong,dongia from chi_tiet_xuat where sohdx in (select sohdx from hoa_don_xuat where to_char(ngayxuat,'MM')='" + com_thang.Text + "' and to_char(ngayxuat,'YYYY')='" + com_nam.Text + "')", grid_view, "thong_ke");
                 try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "select  sum(soluong*dongia) as tt from chi_tiet_xuat where sohdx in (select sohdx from hoa_don_xuat where to_char(ngayxuat,'MM')='" + com_thang.Text + "' and to_char(ngayxuat,'YYYY')='" + com_nam.Text + "')";
                    txt_tt.Text = cmdForm.ExecuteScalar().ToString();
                grid_view.Columns[0].HeaderText = "Số hoá đơn xuất";
                grid_view.Columns[1].HeaderText = "Mã loại";
                grid_view.Columns[2].HeaderText = "Mã hàng";
                grid_view.Columns[3].HeaderText = "Số lượng";
                grid_view.Columns[4].HeaderText = "Đơn giá";
                }
            catch (Exception ex)
            {
                clsmyFunction.setMessageBox(ex.Message, 3);
            }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            btn_thong_ke_Click(sender, e);
            if (radio_xuat.Checked == true)
            {
                Report.thong_ke_x rp_tk = new QLBH.Report.thong_ke_x();
                rp_tk.SetDataSource(grid_view.DataSource);
                QLBH._forms.frm_report frm_rp_tk = new QLBH._forms.frm_report();
                frm_rp_tk.Text = "Thống kê";
                frm_rp_tk.ReportViewer1.ReportSource = rp_tk;

                ParameterValues myparameterValues = new ParameterValues();
                ParameterDiscreteValue myparamDiscreteValue = new ParameterDiscreteValue();
                myparamDiscreteValue.Value = "THỐNG KÊ XUẤT THÁNG " + com_thang.Text + " NĂM " + com_nam.Text;
                myparameterValues.Add(myparamDiscreteValue);
                rp_tk.DataDefinition.ParameterFields["title"].ApplyCurrentValues(myparameterValues);
                myparamDiscreteValue.Value = txt_tt.Text;
                rp_tk.DataDefinition.ParameterFields["tong_tien"].ApplyCurrentValues(myparameterValues);
                frm_rp_tk.Show();
            }
            else
            {
                Report.thong_ke_n rp_tk = new QLBH.Report.thong_ke_n();
                rp_tk.SetDataSource(grid_view.DataSource);
                QLBH._forms.frm_report frm_rp_tk = new QLBH._forms.frm_report();
                frm_rp_tk.Text = "Thống kê";
                frm_rp_tk.ReportViewer1.ReportSource = rp_tk;

                ParameterValues myparameterValues = new ParameterValues();
                ParameterDiscreteValue myparamDiscreteValue = new ParameterDiscreteValue();
                myparamDiscreteValue.Value = "THỐNG KÊ NHẬP THÁNG " + com_thang.Text + " NĂM " + com_nam.Text;
                myparameterValues.Add(myparamDiscreteValue);
                rp_tk.DataDefinition.ParameterFields["title"].ApplyCurrentValues(myparameterValues);
                myparamDiscreteValue.Value = txt_tt.Text;
                rp_tk.DataDefinition.ParameterFields["tong_tien"].ApplyCurrentValues(myparameterValues);
                frm_rp_tk.Show();
            }


            
        }

       
      
       
        }


       

    
}