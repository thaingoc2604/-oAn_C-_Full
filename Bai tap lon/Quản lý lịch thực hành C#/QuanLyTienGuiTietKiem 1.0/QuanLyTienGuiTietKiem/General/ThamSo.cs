using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using QuanLyTienGuiTietKiem.Report;

namespace QuanLyTienGuiTietKiem.General
{
    public class ThamSo
    {
        public static String DatabaseName;
    }

    #region Load form main
    public static class LoadMain
    {
        public static int STT = 001;

        #region goi form quan ly
        static frmQuyen m_FrmQuyen = null;

        public static void HienThiQuyen()
        {
            if (m_FrmQuyen == null || m_FrmQuyen.IsDisposed)
            {
                m_FrmQuyen = new frmQuyen();
                m_FrmQuyen.MdiParent = frmMain.ActiveForm;
                m_FrmQuyen.Show();
            }
            else
                m_FrmQuyen.Activate();
        }

        static frmPhanQuyen m_FrmPhanQuyen = null;
        public static void HienThiPhanQuyen()
        {
            if (m_FrmPhanQuyen == null || m_FrmPhanQuyen.IsDisposed)
            {
                m_FrmPhanQuyen = new frmPhanQuyen();
                m_FrmPhanQuyen.MdiParent = frmMain.ActiveForm;
                m_FrmPhanQuyen.Show();
            }
            else
                m_FrmPhanQuyen.Activate();
        }

        static frmChiTietPhatSinhGD m_FrmChiTietPhatSinhGD = null;
        public static void HienThiChiTietPhatSinhGD()
        {
            if (m_FrmChiTietPhatSinhGD == null || m_FrmChiTietPhatSinhGD.IsDisposed)
            {
                m_FrmChiTietPhatSinhGD = new frmChiTietPhatSinhGD();
                m_FrmChiTietPhatSinhGD.MdiParent = frmMain.ActiveForm;
                m_FrmChiTietPhatSinhGD.Show();
            }
            else
                m_FrmChiTietPhatSinhGD.Activate();
        }

        static frmDMKyLaiTK m_FrmDMKyLaiTK = null;
        public static void HienThiDMKyLaiTK()
        {
            if (m_FrmDMKyLaiTK == null || m_FrmDMKyLaiTK.IsDisposed)
            {
                m_FrmDMKyLaiTK = new frmDMKyLaiTK();
                m_FrmDMKyLaiTK.MdiParent = frmMain.ActiveForm;
                m_FrmDMKyLaiTK.Show();
            }
            else
                m_FrmDMKyLaiTK.Activate();
        }

        static frmDMLoaiGiaoDich m_FrmDMLoaiGiaoDich = null;
        public static void HienThiDMLoaiGiaoDich()
        {
            if (m_FrmDMLoaiGiaoDich == null || m_FrmDMLoaiGiaoDich.IsDisposed)
            {
                m_FrmDMLoaiGiaoDich = new frmDMLoaiGiaoDich();
                m_FrmDMLoaiGiaoDich.MdiParent = frmMain.ActiveForm;
                m_FrmDMLoaiGiaoDich.Show();
            }
            else
                m_FrmDMLoaiGiaoDich.Activate();
        }

        static frmDMLoaiTien m_FrmDMLoaiTien = null;
        public static void HienThiDMLoaiTien()
        {
            if (m_FrmDMLoaiTien == null || m_FrmDMLoaiTien.IsDisposed)
            {
                m_FrmDMLoaiTien = new frmDMLoaiTien();
                m_FrmDMLoaiTien.MdiParent = frmMain.ActiveForm;
                m_FrmDMLoaiTien.Show();
            }
            else
                m_FrmDMLoaiTien.Activate();
        }

        static frmDMTaiKhoan m_FrmDMTaiKhoan = null;
        public static void HienThiDMTaiKhoan()
        {
            if (m_FrmDMTaiKhoan == null || m_FrmDMTaiKhoan.IsDisposed)
            {
                m_FrmDMTaiKhoan = new frmDMTaiKhoan();
                m_FrmDMTaiKhoan.MdiParent = frmMain.ActiveForm;
                m_FrmDMTaiKhoan.Show();
            }
            else
                m_FrmDMTaiKhoan.Activate();
        }

        static frmKhachHang m_FrmKhachHang = null;
        public static void HienThiKhachHang()
        {
            if (m_FrmKhachHang == null || m_FrmKhachHang.IsDisposed)
            {
                m_FrmKhachHang = new frmKhachHang();
                m_FrmKhachHang.MdiParent = frmMain.ActiveForm;
                m_FrmKhachHang.Show();
            }
            else
                m_FrmKhachHang.Activate();
        }

        static frmLaiSuatTietKiem m_FrmLaiSuatTietKiem = null;
        public static void HienThiLaiSuatTietKiem()
        {
            if (m_FrmLaiSuatTietKiem == null || m_FrmLaiSuatTietKiem.IsDisposed)
            {
                m_FrmLaiSuatTietKiem = new frmLaiSuatTietKiem();
                m_FrmLaiSuatTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmLaiSuatTietKiem.Show();
            }
            else
                m_FrmLaiSuatTietKiem.Activate();
        }

        static frmLoaiTietKiem m_FrmLoaiTietKiem = null;
        public static void HienThiLoaiTietKiem()
        {
            if (m_FrmLoaiTietKiem == null || m_FrmLoaiTietKiem.IsDisposed)
            {
                m_FrmLoaiTietKiem = new frmLoaiTietKiem();
                m_FrmLoaiTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmLoaiTietKiem.Show();
            }
            else
                m_FrmLoaiTietKiem.Activate();
        }

        //static frmMoSoTietKiem m_FrmMoSoTietKiem = null;
        //public static void HienThiMoSoTietKiem(int maso)
        //{
        //    if (m_FrmMoSoTietKiem == null || m_FrmMoSoTietKiem.IsDisposed)
        //    {
        //        m_FrmMoSoTietKiem = new frmMoSoTietKiem();
        //        m_FrmMoSoTietKiem.MaSo = maso;
        //        m_FrmMoSoTietKiem.MdiParent = frmMain.ActiveForm;
        //        m_FrmMoSoTietKiem.Show();
        //    }
        //    else
        //        m_FrmMoSoTietKiem.Activate();
        //}

        static frmMoSoTietKiem m_FrmMoSoTietKiem = null;
        public static void HienThiMoSoTietKiem()
        {
            if (m_FrmMoSoTietKiem == null || m_FrmMoSoTietKiem.IsDisposed)
            {
                m_FrmMoSoTietKiem = new frmMoSoTietKiem();
                m_FrmMoSoTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmMoSoTietKiem.Show();
            }
            else
                m_FrmMoSoTietKiem.Activate();
        }

        static frmNhanVien m_FrmNhanVien = null;
        public static void HienThiNhanVien()
        {
            if (m_FrmNhanVien == null || m_FrmNhanVien.IsDisposed)
            {
                m_FrmNhanVien = new frmNhanVien();
                m_FrmNhanVien.MdiParent = frmMain.ActiveForm;
                m_FrmNhanVien.Show();
            }
            else
                m_FrmNhanVien.Activate();
        }

        static frmPhatSinhTietKiem m_FrmPhatSinhTietKiem = null;
        public static void HienThiPhatSinhTietKiem()
        {
            if (m_FrmPhatSinhTietKiem == null || m_FrmPhatSinhTietKiem.IsDisposed)
            {
                m_FrmPhatSinhTietKiem = new frmPhatSinhTietKiem();
                m_FrmPhatSinhTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmPhatSinhTietKiem.Show();
            }
            else
                m_FrmPhatSinhTietKiem.Activate();
        }

        static frmPhongGiaoDich m_FrmPhongGiaoDich = null;
        public static void HienThiPhongGiaoDich()
        {
            if (m_FrmPhongGiaoDich == null || m_FrmPhongGiaoDich.IsDisposed)
            {
                m_FrmPhongGiaoDich = new frmPhongGiaoDich();
                m_FrmPhongGiaoDich.MdiParent = frmMain.ActiveForm;
                m_FrmPhongGiaoDich.Show();
            }
            else
                m_FrmPhongGiaoDich.Activate();
        }

        static frmQuayGiaoDich m_FrmQuayGiaoDich = null;
        public static void HienThiQuayGiaoDich()
        {
            if (m_FrmQuayGiaoDich == null || m_FrmQuayGiaoDich.IsDisposed)
            {
                m_FrmQuayGiaoDich = new frmQuayGiaoDich();
                m_FrmQuayGiaoDich.MdiParent = frmMain.ActiveForm;
                m_FrmQuayGiaoDich.Show();
            }
            else
                m_FrmQuayGiaoDich.Activate();
        }

        static frmSoTietKiem m_FrmSoTietKiem = null;
        public static void HienThiSoTietKiem()
        {
            if (m_FrmSoTietKiem == null || m_FrmSoTietKiem.IsDisposed)
            {
                m_FrmSoTietKiem = new frmSoTietKiem();
                m_FrmSoTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmSoTietKiem.Show();
            }
            else
                m_FrmSoTietKiem.Activate();
        }

        static frmTaiKhoan m_FrmTaiKhoan = null;
        public static void HienThiTaiKhoan()
        {
            if (m_FrmTaiKhoan == null || m_FrmTaiKhoan.IsDisposed)
            {
                m_FrmTaiKhoan = new frmTaiKhoan();
                m_FrmTaiKhoan.MdiParent = frmMain.ActiveForm;
                m_FrmTaiKhoan.Show();
            }
            else
                m_FrmTaiKhoan.Activate();
        }

        static frmGiaoDichVien m_FrmGiaoDichVien = null;
        public static void HienThiGiaoDichVien()
        {
            if (m_FrmGiaoDichVien == null || m_FrmGiaoDichVien.IsDisposed)
            {
                m_FrmGiaoDichVien = new frmGiaoDichVien();
                m_FrmGiaoDichVien.MdiParent = frmMain.ActiveForm;
                m_FrmGiaoDichVien.Show();
            }
            else
                m_FrmGiaoDichVien.Activate();
        }

        static frmNhomNguoiDung m_FrmNhomNguoiDung = null;
        public static void HienThiNhomNguoiDung()
        {
            if (m_FrmNhomNguoiDung == null || m_FrmNhomNguoiDung.IsDisposed)
            {
                m_FrmNhomNguoiDung = new frmNhomNguoiDung();
                m_FrmNhomNguoiDung.MdiParent = frmMain.ActiveForm;
                m_FrmNhomNguoiDung.Show();
            }
            else
                m_FrmNhomNguoiDung.Activate();
        }

        static frmPhanNhomNguoiDung m_FrmPhanNhomNguoiDung = null;
        public static void HienThiPhanNhomNguoiDung()
        {
            if (m_FrmPhanNhomNguoiDung == null || m_FrmPhanNhomNguoiDung.IsDisposed)
            {
                m_FrmPhanNhomNguoiDung = new frmPhanNhomNguoiDung();
                m_FrmPhanNhomNguoiDung.MdiParent = frmMain.ActiveForm;
                m_FrmPhanNhomNguoiDung.Show();
            }
            else
                m_FrmPhanNhomNguoiDung.Activate();
        }

        static frmSoDuTietKiem m_FrmSoDuTietKiem = null;
        public static void HienThiSoDuTietKiem()
        {
            if (m_FrmSoDuTietKiem == null || m_FrmSoDuTietKiem.IsDisposed)
            {
                m_FrmSoDuTietKiem = new frmSoDuTietKiem();
                m_FrmSoDuTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmSoDuTietKiem.Show();
            }
            else
                m_FrmSoDuTietKiem.Activate();
        }

        static frmRutLaiSuatTienTietKiem m_FrmRutTietKiem = null;
        public static void HienThiRutTietKiem()
        {
            if (m_FrmRutTietKiem == null || m_FrmRutTietKiem.IsDisposed)
            {
                m_FrmRutTietKiem = new frmRutLaiSuatTienTietKiem();
                m_FrmRutTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmRutTietKiem.Show();
            }
            else
                m_FrmRutTietKiem.Activate();
        }

        static frmGuiVonKKH m_FrmGuiVonKKH = null;
        public static void HienThiGuiVonKKH()
        {
            if (m_FrmGuiVonKKH == null || m_FrmGuiVonKKH.IsDisposed)
            {
                m_FrmGuiVonKKH = new frmGuiVonKKH();
                m_FrmGuiVonKKH.MdiParent = frmMain.ActiveForm;
                m_FrmGuiVonKKH.Show();
            }
            else
                m_FrmGuiVonKKH.Activate();
        }

        static frmDuyetSoTietKiem m_FrmDuyetSoTietKiem = null;
        public static void HienThiDuyetSoTietKiem()
        {
            if (m_FrmDuyetSoTietKiem == null || m_FrmDuyetSoTietKiem.IsDisposed)
            {
                m_FrmDuyetSoTietKiem = new frmDuyetSoTietKiem();
                m_FrmDuyetSoTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmDuyetSoTietKiem.Show();
            }
            else
                m_FrmDuyetSoTietKiem.Activate();
        }
        #endregion

        #region goi form in phieu
        static frmInPhieuChi m_FrmInPhieuChi = null;
        public static void HienThiInPhieuChi()
        {
            if (m_FrmInPhieuChi == null || m_FrmInPhieuChi.IsDisposed)
            {
                m_FrmInPhieuChi = new frmInPhieuChi();
                m_FrmInPhieuChi.MdiParent = frmMain.ActiveForm;
                m_FrmInPhieuChi.Show();
            }
            else
                m_FrmInPhieuChi.Activate();
        }

        static frmInPhieuThu m_FrmInPhieuThu = null;
        public static void HienThiInPhieuThu()
        {
            if (m_FrmInPhieuThu == null || m_FrmInPhieuThu.IsDisposed)
            {
                m_FrmInPhieuThu = new frmInPhieuThu();
                m_FrmInPhieuThu.MdiParent = frmMain.ActiveForm;
                m_FrmInPhieuThu.Show();
            }
            else
                m_FrmInPhieuThu.Activate();
        }

        static frmInSoCoKyHan m_FrmInSoCoKyHan = null;
        public static void HienThiInSoCoKyHan()
        {
            if (m_FrmInSoCoKyHan == null || m_FrmInSoCoKyHan.IsDisposed)
            {
                m_FrmInSoCoKyHan = new frmInSoCoKyHan();
                m_FrmInSoCoKyHan.MdiParent = frmMain.ActiveForm;
                m_FrmInSoCoKyHan.Show();
            }
            else
                m_FrmInSoCoKyHan.Activate();
        }

        static frmInSoKhongKyHan m_FrmInSoKhongKyHan = null;
        public static void HienThiInSoKhongKyHan()
        {
            if (m_FrmInSoKhongKyHan == null || m_FrmInSoKhongKyHan.IsDisposed)
            {
                m_FrmInSoKhongKyHan = new frmInSoKhongKyHan();
                m_FrmInSoKhongKyHan.MdiParent = frmMain.ActiveForm;
                m_FrmInSoKhongKyHan.Show();
            }
            else
                m_FrmInSoKhongKyHan.Activate();
        }

        static frmInSoCoKH m_FrmInSoCoKH = null;
        public static void HienThiInSoCoKH()
        {
            if (m_FrmInSoCoKH == null || m_FrmInSoCoKH.IsDisposed)
            {
                m_FrmInSoCoKH = new frmInSoCoKH();
                m_FrmInSoCoKH.MdiParent = frmMain.ActiveForm;
                m_FrmInSoCoKH.Show();
            }
            else
                m_FrmInSoCoKH.Activate();
        }

        static frmInPhieuLuuTienGui m_FrmInPhieuLuuTienGui = null;
        public static void HienThiInPhieuLuuTienGui()
        {
            if (m_FrmInPhieuLuuTienGui == null || m_FrmInPhieuLuuTienGui.IsDisposed)
            {
                m_FrmInPhieuLuuTienGui = new frmInPhieuLuuTienGui();
                m_FrmInPhieuLuuTienGui.MdiParent = frmMain.ActiveForm;
                m_FrmInPhieuLuuTienGui.Show();
            }
            else
                m_FrmInPhieuLuuTienGui.Activate();
        }
        #endregion

        #region goi form bao cao

        static frmInDanhSachNhanVien m_FrmInDanhSachNhanVien = null;
        public static void HienThiInDanhSachNhanVien()
        {
            if (m_FrmInDanhSachNhanVien == null || m_FrmInDanhSachNhanVien.IsDisposed)
            {
                m_FrmInDanhSachNhanVien = new frmInDanhSachNhanVien();
                m_FrmInDanhSachNhanVien.MdiParent = frmMain.ActiveForm;
                m_FrmInDanhSachNhanVien.Show();
            }
            else
                m_FrmInDanhSachNhanVien.Activate();
        }

        static frmInDanhSachSoCuaNgay m_FrmInDanhSachSoCuaNgay = null;
        public static void HienThiInDanhSachSoCuaNgay()
        {
            if (m_FrmInDanhSachSoCuaNgay == null || m_FrmInDanhSachSoCuaNgay.IsDisposed)
            {
                m_FrmInDanhSachSoCuaNgay = new frmInDanhSachSoCuaNgay();
                m_FrmInDanhSachSoCuaNgay.MdiParent = frmMain.ActiveForm;
                m_FrmInDanhSachSoCuaNgay.Show();
            }
            else
                m_FrmInDanhSachSoCuaNgay.Activate();
        }

        #endregion

        #region goi form Tim kiem
        static frmTimSoTietKiem m_FrmTimSoTietKiem = null;
        public static void HienThiTimSoTietKiem()
        {
            if (m_FrmTimSoTietKiem == null || m_FrmTimSoTietKiem.IsDisposed)
            {
                m_FrmTimSoTietKiem = new frmTimSoTietKiem();
                m_FrmTimSoTietKiem.MdiParent = frmMain.ActiveForm;
                m_FrmTimSoTietKiem.Show();
            }
            else
                m_FrmTimSoTietKiem.Activate();
        }
        #endregion

        #region goi form quan ly
        #endregion
    }
    #endregion

    #region Ket not DBMS
    public class DBMS
    {

    }
    #endregion

    #region Xu ly tap tin Xml
    public class XML
    {
        public static XmlDocument ReadXml(String fileName)
        {
            XmlDocument XmlDocument = new XmlDocument();
            try
            {
                XmlDocument.Load(fileName);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + fileName, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return XmlDocument;
        }

        public static void WriteXml(String fileName, String serverName, String dataBase, String costatus)
        {
            XmlTextWriter XmlWrite = new XmlTextWriter(fileName, null);
            XmlWrite.Formatting = Formatting.Indented;

            XmlWrite.WriteStartDocument();
            XmlWrite.WriteComment("Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            XmlWrite.WriteStartElement("config");

            XmlWrite.WriteStartElement("costatus");
            XmlWrite.WriteString(costatus);
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("servername");
            XmlWrite.WriteString(serverName);
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("username");
            XmlWrite.WriteString("");
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("password");
            XmlWrite.WriteString("");
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("database");
            XmlWrite.WriteString(dataBase);
            XmlWrite.WriteEndElement();

            XmlWrite.WriteEndElement();
            XmlWrite.WriteEndDocument();

            XmlWrite.Close();
        }

        public static void XMLWriter(String fileName, String serverName, String userName, String passWord, String dataBase, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(fileName, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servername");
            xmlW.WriteString(serverName);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(userName);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(passWord);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(dataBase);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

    }
    #endregion

    #region Quy dinh
    public class QuyDinh
    {
        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "00000" + autoNum;
            else if (autoNum >= 10 && autoNum < 100000)
                return "0000" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "000" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "00" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "0" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "" + autoNum;
            else
                return "";
        }

        private String m_TenNganHang;
        public String TenNganHang
        {
            get { return m_TenNganHang; }
            set { m_TenNganHang = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }
    }
    #endregion

    #region In chu
    public class Num2Str
    {
        public Num2Str()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        // Hàm này có thực hiện cắt các số 0
        // ví dụ 005 sẽ đọc là không trăm linh năm
        private string Group32StrX(string num)
        {
            string[] No = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string kq, tram, chuc, donvi;
            // Trăm
            if (num.Substring(0, 1) == "0")
            { tram = ""; }
            else
            { tram = No[Convert.ToByte(num.Substring(0, 1))] + " trăm "; }
            // Chục
            switch (num.Substring(1, 1))
            {
                case "0": if (num.Substring(2, 1) != "0" && num.Substring(0, 1) != "0")
                    {
                        chuc = "linh ";
                    }
                    else { chuc = ""; }; break;
                case "1": chuc = "mười "; break;
                default:
                    chuc = No[Convert.ToByte(num.Substring(1, 1))] + " mươi "; break;
            }
            // Đơn vị
            switch (num.Substring(2, 1))
            {
                case "0": donvi = ""; break;
                case "1": if ((num.Substring(1, 1) == "0") || (num.Substring(1, 1) == "1"))
                    {
                        donvi = "một";
                    }
                    else
                    {
                        donvi = "mốt";
                    }; break;
                case "5":
                    if (num.Substring(1, 1) != "0")
                    {
                        donvi = "lăm";
                    }
                    else
                    {
                        donvi = "năm";
                    }; break;
                default:
                    donvi = No[Convert.ToByte(num.Substring(2, 1))]; break;
            }
            kq = tram + chuc + donvi;
            return kq;
        }

        private string IntNum2Str(string num)
        {
            string[] Cap = { "", " nghìn ", " triệu ", " tỷ ", " nghìn tỷ ", " triệu tỷ ", " tỷ tỷ ", " nghìn tỷ tỷ " };
            string kq = "", str = num, g3, kqtg;
            int caps = 0;
            while (str.Length > 3)
            {
                g3 = str.Substring(str.Length - 3, 3);
                str = str.Substring(0, str.Length - 3);
                if (g3 != "000")
                { kqtg = Group32StrX(g3) + Cap[Convert.ToByte(caps)]; }
                else { kqtg = ""; }
                kq = kqtg + kq;
                caps++;
            }
            //Chuẩn bị trước khi sử dụng hàm Group32Str1
            while (str.Length < 3)
            { str = "0" + str; }

            if ((str == "000") && (num.Length <= 3))
            { kqtg = "không"; }
            else
            { kqtg = Group32StrX(str) + Cap[Convert.ToByte(caps)]; }
            kq = kqtg + kq;
            return kq;
        }

        private string FracNum2Str(string num)
        {
            string[] No = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string kq = "";
            for (int i = 0; i < num.Length; i++)
            {
                kq += No[Convert.ToByte(num.Substring(i, 1))] + " ";
            }
            return kq;
        }

        private string No2Str(string num)
        {
            string intstr, fracstr, am;
            // Xử lý khi là số âm
            if (num.Substring(0, 1) == "-")
            {
                am = "âm ";
                num = num.Replace("-", "");
            }
            else { am = ""; }

            string[] str = num.Split('.');
            // Số quá lớn nhiều hơn 27 chữ số
            if (str[0].Length > 28)
                throw new Exception("Số lớn quá không hiển thị được! ");

            string s;
            // Xử lý phần số, nếu là có số thập phân hoặc không
            if (str.Length == 2)
            {
                intstr = IntNum2Str(str[0]);
                if (str[1].Length <= 2)
                {
                    if (str[1].Substring(0, 1) == "0")
                    {
                        fracstr = FracNum2Str(str[1]);
                    }
                    else
                    {
                        fracstr = IntNum2Str(str[1]);
                    }
                }
                else
                {
                    fracstr = FracNum2Str(str[1]);
                }
                s = (intstr + " phảy " + fracstr);
            }
            else
            {
                intstr = IntNum2Str(str[0]);
                s = intstr;
            }
            s = am + s;
            string chuhoa = s.Substring(0, 1).ToUpper();
            s = s.Substring(1, s.Length - 1);
            return (chuhoa + s);
        }

        public string NumNormalize(string num)
        {
            char ThousandSpace = ',';
            char PointScape = '.';
            string[] s = num.Split('.');
            string g3, str = "";
            while (s[0].Length > 3)
            {
                g3 = s[0].Substring(s[0].Length - 3, 3);
                s[0] = s[0].Substring(0, s[0].Length - 3);
                str = ThousandSpace + g3 + str;
            }
            str = s[0] + str;
            if (s.Length == 2)
            {
                str = (str + PointScape + s[1]);
            }
            return str.Replace("-,", "-");
        }

        public string NumberToString(string no)
        {
            // xử lý trường hợp dáu phảy thay cho dấu chấm
            if (no.IndexOf(",", 0, 1) != 0) { no = no.Replace(",", "."); }
            // Xoá các ký tự trắng ở đầu và cuối
            no = no.Trim();
            // Xử lý khi nó là chữ chứ không phải là số
            if (no == "0") return "không";
            if (no == "") return "không";
            double val;
            try
            {
                val = Convert.ToDouble(no);
            }
            catch
            {
                throw new Exception("Đây không phải là số");
            }
            // tiêu diệt các số không
            while (no.Substring(0, 1) == "0")
            {
                no = no.Substring(1, no.Length - 1);
            }

            if (no.IndexOf(".", 0, 1) != -1)
            {
                while (no.Substring(no.Length - 1, 1) == "0")
                {
                    no = no.Substring(0, no.Length - 1);
                }
            }
            no = No2Str(no);

            return no;
        }
    #endregion
    }
}
