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
    public partial class ThongTinMonAn : Form
    {
        bool Them_moi = false;
        string mamon;
        string tenmon;
        DataTable monan_Bang;
        B_MonAn objMA = new B_MonAn();
        BindingSource bsMonAn = new BindingSource();
        public ThongTinMonAn()
        {
            InitializeComponent();
        }

        private void ThongTinMonAn_Load(object sender, EventArgs e)
        {            
        
            Binding_MonAn();
            bsMonAn.PositionChanged += new EventHandler(bsMonAn_PositionChanged);
            Xuat_DS_MonAn();
            Xuat_DS_Dgv();
        }

        private void bsMonAn_PositionChanged(object sender, EventArgs e)
        {
            if (Them_moi)
            {
                return;
            }
            Xuat_DS_MonAn();
        } 

        private void Binding_MonAn()
        {
            monan_Bang = objMA.gettbMonAn_theo_MaLoai(frm_LoaiMon.maloai_DuocChon);

            bsMonAn.DataSource = monan_Bang;
        }
        
        private void Xuat_DS_MonAn()
        {
            if (bsMonAn.Count > 0)
            {
                DataRow dong = ((DataRowView)bsMonAn.Current).Row; 
                txtMaMon.Text = dong["MaM"].ToString();
                txtTenMon.Text = dong["TenM"].ToString();
                cboMaLoai.Text = frm_LoaiMon.maloai_DuocChon;
                rtxtSucKhoe.Text = dong["SucKhoe"].ToString();
                rtxtNguyenLieu.Text = dong["NguyenLieu"].ToString();
                rtxtCachLam.Text = dong["ThucHien"].ToString();
                rtxtChuY.Text = dong["ChuY"].ToString();

                cboMaLoai.Enabled = false;                
            }            
        }

        private void Xuat_DS_Dgv()
        {
            dgvDSMonAn.DataSource = bsMonAn;
        }
     

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (bsMonAn.Count > 0)
            {                
                DataRow dong = ((DataRowView)bsMonAn.Current).Row;
                mamon = dong["MaM"].ToString();
                tenmon = dong["TenM"].ToString();
                int i = objMA.XoaMonAn_Theo_MaMon(mamon);
                if (i == 1)
                {
                    Xuat_DS_MonAn();
                    MessageBox.Show("Xóa Món: " + mamon + "-" + tenmon + " Thành Công");

                    monan_Bang = objMA.gettbMonAn_theo_MaLoai(frm_LoaiMon.maloai_DuocChon);
                    Binding_MonAn();
                    Xuat_DS_Dgv();
                }
                else
                {                    
                    MessageBox.Show("Xóa Món: " + mamon + "-" + tenmon + " Thất Bại");                    

                }                
                bsMonAn.Position = bsMonAn.Count - 1;
            }            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ChuanBi_Nhap();
            Them_moi = true;            
        }

        private void Nhap_DS_MonAn()
        {
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Mã món không thể rổng!");
                txtMaMon.Select();
                return;
            }
            else
            {                

                string mamon = txtMaMon.Text;
                string tenmon = txtTenMon.Text;
                string maloai = frm_LoaiMon.maloai_DuocChon;
                string suckhoe = rtxtSucKhoe.Text;
                string nguyenlieu = rtxtNguyenLieu.Text;
                string cachlam = rtxtCachLam.Text;
                string chuy = rtxtChuY.Text;
                MonAn ma = new MonAn(mamon, tenmon, maloai, suckhoe, nguyenlieu, cachlam, chuy);
                if (objMA.ThemMonAn(ma) == 1)
                {
                    MessageBox.Show("Thêm Món " + txtMaMon.Text + "-" + txtTenMon.Text + " Thành Công");   
                    monan_Bang = objMA.gettbMonAn_theo_MaLoai(frm_LoaiMon.maloai_DuocChon);
                    Binding_MonAn();
                    Xuat_DS_Dgv();
                    bsMonAn.Position = bsMonAn.Count - 1;
                }
                else
                {
                    MessageBox.Show("Thêm Món " + txtMaMon.Text + "-" + txtTenMon.Text + " Thất Bại");

                    ChuanBi_Nhap();
                }                
            }            
        }

        private void ChuanBi_Nhap()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            rtxtSucKhoe.Text = "";
            rtxtCachLam.Text = "";
            rtxtNguyenLieu.Text = "";
            rtxtChuY.Text = "";
            txtMaMon.Select();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them_moi)
            {
                Nhap_DS_MonAn();
                Xuat_DS_MonAn();
            }
            Them_moi = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                      
            DataRow dong = ((DataRowView)bsMonAn.Current).Row;
            string mamon = dong["MaM"].ToString();
            string maloai = dong["Maloai"].ToString();

            string mamonmoi = txtMaMon.Text;            
            string tenmonmoi = txtTenMon.Text;
            string maloaimoi = frm_LoaiMon.maloai_DuocChon;
            string suckhoemoi = rtxtSucKhoe.Text;
            string nguyenlieumoi = rtxtNguyenLieu.Text;
            string cachlammoi = rtxtCachLam.Text;
            string chuymoi = rtxtChuY.Text;
            MonAn monmoi = new MonAn(mamonmoi, tenmonmoi, maloaimoi, suckhoemoi, nguyenlieumoi, cachlammoi, chuymoi);
                        
            if (objMA.SuaMonAn_TheoMaMon(monmoi, mamon) == 1)
            {
                MessageBox.Show("Sữa món ăn thành công!");
                bsMonAn.EndEdit();

                monan_Bang = objMA.gettbMonAn_theo_MaLoai(frm_LoaiMon.maloai_DuocChon);
                bsMonAn.DataSource = monan_Bang;
                Xuat_DS_Dgv();

            }
            else
            {
                MessageBox.Show("Sữa món ăn thất bại!");
            }

            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (rdoExportTheoLoai.Checked)
            {
                DataTable mon_TheoMaLoai_Bang = objMA.gettbMonAn_theo_MaLoai(frm_LoaiMon.maloai_DuocChon);
                PHAN_MEM.exportDataToExcel("DS_MonAn loại: " + frm_LoaiMon.maloai_DuocChon, mon_TheoMaLoai_Bang);
            }
            else
            {                
                DataTable mon_Bang = objMA.gettbMonAn();
                PHAN_MEM.exportDataToExcel("DS_MonAn", mon_Bang);
            }
        }

        private void txtTimMonAn_TextChanged(object sender, EventArgs e)
        {
            string tenmongandung = txtTimMonAn.Text;
            monan_Bang = objMA.TimTenMon_TheoLoai(tenmongandung, frm_LoaiMon.maloai_DuocChon);            

            bsMonAn.DataSource = monan_Bang;
            Xuat_DS_Dgv();
            
        }
    }
}
