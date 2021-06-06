//Đề Tài Quản Lý Món Ăn Ngon
//Sinh Viên Thực Hiện: Nguyễn Hoàng Vũ - 10200681 - NCTH4A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUI_tier;
using Entities;
namespace prQuanLyMonAn
{
    public partial class frm_LoaiMon : Form
    {
        B_LoaiMon objlm = new B_LoaiMon();        
        bool Them_moi = false;
        public  BindingSource bsLoaiMon;        
        public static string maloai_DuocChon = ""; 
        public static string matenloai_DuocChon = "";
        public frm_LoaiMon()
        {

            InitializeComponent();            
        }

        private void frm_LoaiMon_Load(object sender, EventArgs e)
        {
            Binding_LoaiMon();                        
            bsLoaiMon.PositionChanged += new EventHandler(bsLoaiMon_PositionChanged);
            Xuat_DS_LoaiMon();
        }
        
        private void Binding_LoaiMon()
        {

            DataTable LoaiMon = objlm.gettb_LoaiMon();
            LoaiMon.Columns.Add(@"Ma-TenLoai", typeof(string), "MaLoai + '-' + TenLoai");
            bsLoaiMon = new BindingSource();
            bsLoaiMon.DataSource = LoaiMon;                      
        }

        private string LayMaLoai_DuocChon()
        {            
            DataRow dong = ((DataRowView)bsLoaiMon.Current).Row;
            maloai_DuocChon = dong["MaLoai"].ToString();
            return maloai_DuocChon;
        }

        private string LayMaTenLoai_DuocChon()
        {
            matenloai_DuocChon = "";
            DataRow dong = ((DataRowView)bsLoaiMon.Current).Row;        
            matenloai_DuocChon = dong["Ma-TenLoai"].ToString();
            return maloai_DuocChon;
        }

        private void bsLoaiMon_PositionChanged(object sender, EventArgs e)
        {
            if (Them_moi) 
            {
                return;
            }
            Xuat_TenLoai_TextBox();
        }

        private void TuyChinh_Label()
        {

            if (Them_moi)
            {                
                // Yêu cầu nhập lên label:
                lblMaLoai.Text = @"Nhập Mã Loại: L??";
                lblTenLoai.Text = "Nhập Tên Loại:";
            }
            else
            {
                // Hiện lại label mặc định:
                lblMaLoai.Text = "Tên đầy đủ của loại món";
                lblTenLoai.Text = "Tên loại món (Tự update khi sửa)";
            }
        }

        private void TuyChinh_Button()
        {
            // Nếu đã nhấn nút Them_Moi lần đầu tiên:            
            if (Them_moi)
            {
                // Ẩn nút Xóa (Vì chúng ta đang ở trạng thái thêm)
                btnXoa.Enabled = false;
                btnXem.Enabled = false;
            }
            else // Nếu đã nhấn nút Them_Moi lần tiếp theo:
            {
                // Hiện nút Xóa (Vì chúng ta đã thêm xong rồi,trở về trạng thái ban đầu)
                btnXoa.Enabled = true;
                btnXem.Enabled = true;
            }
        }
                
        private void Xuat_DS_LoaiMon_ListView()
        {
            lstDanhSach.SelectionMode = SelectionMode.One; 
            lstDanhSach.DataSource = bsLoaiMon; 
            lstDanhSach.DisplayMember = "TenLoai";
            lstDanhSach.ValueMember = "MaLoai";
        }
                
        private void Xuát_DS_LoaiMon_ComboBox()
        {
     
            cboMaLoai.DataSource = bsLoaiMon;
            cboMaLoai.DisplayMember = "Ma-TenLoai"; 
            cboMaLoai.ValueMember = "MaLoai"; 
        }
        
        private void Xuat_TenLoai_TextBox()
        {
        
            txtTenLoai.DataBindings.Clear();            
            txtTenLoai.DataBindings.Add("Text", bsLoaiMon, "TenLoai");
        }


        private void Xuat_DS_LoaiMon()
        {   

            Binding_LoaiMon();

            TuyChinh_Label();

            TuyChinh_Button();

            Xuat_DS_LoaiMon_ListView();

            Xuát_DS_LoaiMon_ComboBox();

            Xuat_TenLoai_TextBox();
        }

        private void ChuanBi_Nhap()
        {

            Them_moi = true;

            TuyChinh_Label();
            TuyChinh_Button();
            lstDanhSach.SelectionMode = SelectionMode.None; 
            cboMaLoai.Text = "";
            txtTenLoai.Text = "";

            txtTenLoai.DataBindings.Clear();

            cboMaLoai.Select(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            if (Them_moi) 
            {
               
                Them_moi = false;


                string maloai_ThemMoi = cboMaLoai.Text;
                string tenloai_ThemMoi = txtTenLoai.Text;                
                LoaiMon lm = new LoaiMon(maloai_ThemMoi, tenloai_ThemMoi);                
                if (objlm.ThemLoaiMon(lm) == 1)
                {

                    Xuat_DS_LoaiMon();
                    string matenloai_DuocChon = LayMaTenLoai_DuocChon();
                    MessageBox.Show("Thêm Loại Món " + maloai_ThemMoi + "-" + tenloai_ThemMoi + " Thành Công");

                    bsLoaiMon.Position = bsLoaiMon.Count - 1;
                }
                else
                {
                    MessageBox.Show("Thêm Loại Món " + maloai_ThemMoi + "-" + tenloai_ThemMoi + " Thất Bại");

                    ChuanBi_Nhap();
                }
            }
            else
            {

                ChuanBi_Nhap();
            }
        }        

        private void btnXoa_Click(object sender, EventArgs e)
        {          
       
            maloai_DuocChon = LayMaLoai_DuocChon();
            string matenloai_DuocChon = LayMaTenLoai_DuocChon();
            if (objlm.XoaLoaiMon_Theo_MaLoai(maloai_DuocChon) == 1)
            {
                Xuat_DS_LoaiMon();
                MessageBox.Show("Xóa Loại Món: " + matenloai_DuocChon + " Thành Công");                
            }
            else
            {
                MessageBox.Show("Xóa Loại Món: " + matenloai_DuocChon + " Thất Bại");
           
            }
            bsLoaiMon.Position = bsLoaiMon.Count - 1;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            maloai_DuocChon = LayMaLoai_DuocChon();
            ThongTinMonAn f = new ThongTinMonAn();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn Có Muốn Thoát Ứng Dụng Không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes) ;
            this.Close();
        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Them_moi)
            {
                this.cboMaLoai.SelectedItem = null;
                this.cboMaLoai.Text = "";
            }
        }

        private void cboMaLoai_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                Them_moi = false;
                Xuat_DS_LoaiMon();
            }

        }

        private void txtTenLoai_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                Them_moi = false;
                Xuat_DS_LoaiMon();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable loai_Bang = objlm.gettb_LoaiMon();
            PHAN_MEM.exportDataToExcel("DS_MonAn", loai_Bang);
        }
    }
}
