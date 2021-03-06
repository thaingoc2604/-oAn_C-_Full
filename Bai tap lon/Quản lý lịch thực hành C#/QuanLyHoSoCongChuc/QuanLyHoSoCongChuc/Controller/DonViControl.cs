using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class DonViControl
    {
        DonViData m_DonViData = new DonViData();
        NhanVienData m_NhanVienData = new NhanVienData();


        public void HienThiDataGridView(DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_DonViData.LayDsDonVi();
            dg.DataSource = bs;
        }

        public void HienThiComBoBox(ComboBox cmb)
        {
            cmb.DataSource = m_DonViData.LayDsDonVi();
            cmb.DisplayMember = "TenDonVi";
            cmb.ValueMember = "MaDonVi";
        }
        public void HienThiComboBox1(ComboBox cmb)
        {
            DataTable m_DT = m_DonViData.LayDsDonVi();
            cmb.DataSource = m_DT;
            cmb.DisplayMember = "TenDonVi";
            cmb.ValueMember = "MaDonVi";
        }
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaDonVi, TextBox txtTenDonVi, ComboBox cmbMaLoaiDonVi)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_DonViData.LayDsDonVi();
            bS.DataSource = tbl;

            txtMaDonVi.DataBindings.Clear();
            txtMaDonVi.DataBindings.Add("Text", bS, "MaDonVi");
            txtTenDonVi.DataBindings.Clear();
            txtTenDonVi.DataBindings.Add("Text", bS, "TenDonVi");
            cmbMaLoaiDonVi.DataBindings.Clear();
            cmbMaLoaiDonVi.DataBindings.Add("SelectedValue", bS, "MaLoaiDonVi");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_DonViData.ThemDongMoi();
        }

        public void ThemDonVi(DataRow m_Row)
        {
            m_DonViData.ThemDonVi(m_Row);
        }

        public bool LuuDonVi()
        {
            return m_DonViData.LuuDonVi();
        }


        public void HienThiTreeView(TreeView tv)
        {
            DataTable table = m_DonViData.LayDsDonVi();
            System.Windows.Forms.TreeNode n0 = new TreeNode();
            n0.Text = "Đơn vị trực thuộc Huyện Tịnh Biên";
            foreach (DataRow row in table.Rows)
            {
                System.Windows.Forms.TreeNode n1 = new TreeNode();
                n1.Text = row["TenDonVi"].ToString();
                n1.Tag = row["MaDonVi"].ToString();
                n0.Nodes.Add(n1);
            }

            tv.Nodes.Add(n0);
        }

        public void HienDSDonVi(DataGridView dgv, string maPhong)
        {
            dgv.DataSource = m_DonViData.LayDSPhong(maPhong);

        }
        public static IList<DonViInfo> LayDsDonVi(String phong)
        {
            DonViData m_DVData = new DonViData();
            DataTable m_DV = m_DVData.LayDSTheoLoaiDonVi(phong);

            IList<DonViInfo> dS = new List<DonViInfo>();

            foreach (DataRow Row in m_DV.Rows)
            {
                DonViInfo dv = new DonViInfo();

                dv.MaDonVi= Convert.ToString(Row["MaDonVi"]);
                dv.TenDonVi = Convert.ToString(Row["TenDonVi"]);             
                dS.Add(dv);
            }
            return dS;

        }
    }


}


