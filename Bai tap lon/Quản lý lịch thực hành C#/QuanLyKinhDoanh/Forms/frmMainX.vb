Public Class frmMainX
    Friend FormID As Integer
    Private Sub btiNhanVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiNhanVien.Click       
        FormID = 1
        LoadData(FormID)
    End Sub

    Private Sub btiBoPhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiBoPhan.Click        
        FormID = 20
        LoadData(FormID)
    End Sub

    Private Sub btiChucVu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiChucVu.Click        
        FormID = 21
        LoadData(FormID)
    End Sub

    Private Sub btiTinhTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiTinhTP.Click       
        FormID = 26
        LoadData(FormID)
    End Sub

    Private Sub btiNhomHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiNhomHang.Click        
        FormID = 23
        LoadData(FormID)
    End Sub

    Private Sub btiHangHoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiHangHoa.Click        
        FormID = 27
        LoadData(FormID)
    End Sub

    Private Sub btiNhaCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiNhaCC.Click       
        FormID = 22
        LoadData(FormID)
    End Sub

    Private Sub btiLapPhieuChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiLapPhieuChi.Click        
        FormID = 4
        LoadData(FormID)
    End Sub

    Private Sub btiNhapKho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiNhapKho.Click        
        FormID = 3
        LoadData(FormID)
    End Sub

    Private Sub btiXuatKho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiXuatKho.Click       
        FormID = 6
        LoadData(FormID)
    End Sub

    Private Sub btiKho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiKho.Click       
        FormID = 25
        LoadData(FormID)
    End Sub

    Private Sub btiKhachHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiKhachHang.Click       
        FormID = 24
        LoadData(FormID)
    End Sub

    Private Sub btiLapPhieuThu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiLapPhieuThu.Click       
        FormID = 7
        LoadData(FormID)
    End Sub

    Private Sub mnuDoiMatKhau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDoiMatKhau.Click
        frmDoiMatKhau.ShowDialog()
        frmDoiMatKhau.ShowInTaskbar = False
    End Sub

    Private Sub mnuNguoiSuDung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNguoiSuDung.Click
        frmUsers.ShowDialog()
        frmUsers.ShowInTaskbar = False
    End Sub

    Private Sub mnuThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThoat.Click
        If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn thoát khỏi chương trình không ?", "Thông báo") = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    'Private Sub mnuBoPhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmBoPhan.ShowDialog()
    '    frmBoPhan.ShowInTaskbar = False
    'End Sub

    'Private Sub mnuChucVu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmChucVu.ShowDialog()
    '    frmChucVu.ShowInTaskbar = False
    'End Sub

    'Private Sub mnuTinhTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmTinhTP.ShowDialog()
    '    frmTinhTP.ShowInTaskbar = False
    'End Sub

    Private Sub mnuNCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmNhaCC.ShowDialog()
        frmNhaCC.ShowInTaskbar = False
    End Sub

    Private Sub mnuNhomHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmNhomHang.ShowDialog()
        frmNhomHang.ShowInTaskbar = False
    End Sub

    Private Sub mnuVatTuHangHoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmHangHoa.ShowDialog()
        frmHangHoa.ShowInTaskbar = False
    End Sub

    Private Sub mnuPhieuChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPhieuChi.ShowDialog()
        frmPhieuChi.ShowInTaskbar = False
    End Sub

    

    Private Sub mnuKhoHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmKho.ShowDialog()
        frmKho.ShowInTaskbar = False
    End Sub

    Private Sub mnuKhachHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmKhachHang.ShowDialog()
        frmKhachHang.ShowInTaskbar = False
    End Sub

    Private Sub mnuPhieuThu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPhieuThu.ShowDialog()
        frmPhieuThu.ShowInTaskbar = False
    End Sub

    Private Sub mnuTacGia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTacGia.ShowDialog()
        frmTacGia.ShowInTaskbar = False
    End Sub

    Private Sub mnuBangKeBanHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBangKeBanHang.Click
        frmBaoCaoTongHop.intIndex = 0
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBangKeMuaHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBangKeMuaHang.Click
        frmBaoCaoTongHop.intIndex = 1
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuCongNoPhaiTraNCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCongNoPhaiTraNCC.Click
        frmBaoCaoTongHop.intIndex = 2
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuCongNoPhaiThuKH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCongNoPhaiThuKH.Click
        frmBaoCaoTongHop.intIndex = 3
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBCNhapKho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBCNhapKho.Click
        frmBaoCaoTongHop.intIndex = 4
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBCXuatKho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBCXuatKho.Click
        frmBaoCaoTongHop.intIndex = 5
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBaoGia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBaoGia.Click
        frmBaoCaoTongHop.intIndex = 6
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuHoaDonVAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHoaDonVAT.Click
        frmBaoCaoTongHop.intIndex = 7
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBCPhieuChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBCPhieuChi.Click
        frmBaoCaoTongHop.intIndex = 8
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBCPhieuThu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBCPhieuThu.Click
        frmBaoCaoTongHop.intIndex = 9
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBCDanhSachKH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBCDanhSachKH.Click
        frmBaoCaoTongHop.intIndex = 10
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBCDanhSachNCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBCDanhSachNCC.Click
        frmBaoCaoTongHop.intIndex = 11
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub mnuBCDanhSachNhanVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBCDanhSachNhanVien.Click
        frmBaoCaoTongHop.intIndex = 12
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    
    Private Sub frmMainX_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    'Private Sub mnuDanhSachNhanVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FormID = 1
    '    LoadData(FormID)
    'End Sub

    Sub PhanQuyen()
        Dim DT As New DataTable
        DT = objConnect.GetDataTable("Select NSD,MatKhau,NhanSu,Kho,MuaHang,BanHang,Quy,PhanQuyen,Active From Sys_NSD Where Active='1'")
        If DT(0)(2).ToString = 1 Then 'Nhân sự
            mnuBoPhan.Enabled = True
            mnuChucVu.Enabled = True
            mnuTinhTP.Enabled = True
            mnuDanhSachNhanVien.Enabled = True
            btiBoPhan.Enabled = True
            btiChucVu.Enabled = True
            btiTinhTP.Enabled = True
            btiNhanVien.Enabled = True
        Else
            mnuBoPhan.Enabled = False
            mnuChucVu.Enabled = False
            mnuTinhTP.Enabled = False
            mnuDanhSachNhanVien.Enabled = False
            btiBoPhan.Enabled = False
            btiChucVu.Enabled = False
            btiTinhTP.Enabled = False
            btiNhanVien.Enabled = False
        End If

        If DT(0)(3).ToString = 1 Then   'Nhóm kho
            mnuNhapKho.Enabled = True
            mnuXuatKho.Enabled = True
            mnuKhoHang.Enabled = True
            btiNhapKho.Enabled = True
            btiXuatKho.Enabled = True
            btiKho.Enabled = True
        Else
            mnuNhapKho.Enabled = False
            mnuXuatKho.Enabled = False
            mnuKhoHang.Enabled = False
            btiNhapKho.Enabled = False
            btiXuatKho.Enabled = False
            btiKho.Enabled = False
        End If

        'menu Mua hang
        If DT(0)(4).ToString = 1 Then
            mnuNCC.Enabled = True
            mnuNhomHang.Enabled = True
            mnuVatTuHangHoa.Enabled = True
            mnuPhieuChi.Enabled = True
            btiLapPhieuChi.Enabled = True
            btiHoaDonMuaHang.Enabled = True
            mnuHoaDonMuaHang.Enabled = True
        Else
            If DT(0)(3) = 1 Then
                mnuNCC.Enabled = True
                mnuNhomHang.Enabled = True
                mnuVatTuHangHoa.Enabled = True
                btiNhaCC.Enabled = True
                btiNhomHang.Enabled = True
                btiHangHoa.Enabled = True
                mnuPhieuChi.Enabled = True
                btiLapPhieuChi.Enabled = True
            Else
                mnuNCC.Enabled = False
                mnuNhomHang.Enabled = False
                mnuVatTuHangHoa.Enabled = False
                btiNhaCC.Enabled = False
                btiNhomHang.Enabled = False
                btiHangHoa.Enabled = False
                mnuPhieuChi.Enabled = False
                btiLapPhieuChi.Enabled = False
            End If

        End If
        'menu Bán hàng
        If DT(0)(5).ToString = 1 Then
            mnuKhachHang.Enabled = True
            mnuPhieuThu.Enabled = True
            btiKhachHang.Enabled = True
            btiLapPhieuThu.Enabled = True
            btiHoaDonBanHang.Enabled = True
            mnuHoaDonBanHang.Enabled = True
        Else
            If DT(0)(3) = 1 Then
                mnuKhachHang.Enabled = True
                mnuPhieuThu.Enabled = True
                btiKhachHang.Enabled = True
                btiLapPhieuThu.Enabled = True
                mnuPhieuThu.Enabled = True
                btiLapPhieuThu.Enabled = True
                btiHoaDonBanHang.Enabled = True
                mnuHoaDonBanHang.Enabled = True
            Else
                mnuKhachHang.Enabled = False
                mnuPhieuThu.Enabled = False
                btiKhachHang.Enabled = False
                btiLapPhieuThu.Enabled = False
                mnuPhieuThu.Enabled = False
                btiLapPhieuThu.Enabled = False
                btiHoaDonBanHang.Enabled = False
                mnuHoaDonBanHang.Enabled = False
            End If
        End If

        If DT(0)(7) = 1 Then
            mnuNguoiSuDung.Enabled = True
        Else
            mnuNguoiSuDung.Enabled = False
        End If

        If DT(0)(3) = 1 Or DT(0)(4) = 1 Or DT(0)(5) = 1 Then
            mnuBaoCao.Enabled = True
        Else
            mnuBaoCao.Enabled = False
        End If

    End Sub

    Private Sub frmMainX_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call PhanQuyen()
        FormID = 27
        LoadData(FormID)
    End Sub

    Private Sub mnuBCHangTon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBCHangTon.Click
        frmBaoCaoTongHop.intIndex = 13
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    '----------------------------------------------------------------
    Friend Sub LoadData(ByVal FormID As Integer, Optional ByVal strTimKiem As String = "")
        Dim strColumnsHeader As String = ""
        Dim strSQL As String = ""
        Select Case FormID
            Case 1  'Nhan vien
                lblDanhSach.Text = "Nhân viên"
                strColumnsHeader = "Mã NV,Họ tên,Giới tính,Ngày sinh,Bộ phận,Chức vụ,Địa chỉ,Tỉnh TP,Điện thoại,CMND,Ngày cấp,Nơi cấp,Ngày vào công ty,Ngày thôi việc,Kết hôn,Dân tộc,Tôn giáo,Trình độ, Chuyên ngành,Ngoại ngữ,Đường dẫn ảnh"
                strSQL = "SELECT tblNhanVien.MaNV, tblNhanVien.HoTen, tblNhanVien.GioiTinh, tblNhanVien.NgaySinh,"
                strSQL &= "tblBoPhan.TenBP, tblChucVu.TenCV, tblNhanVien.DiaChi, tblTinhTP.TenTinhTP,"
                strSQL &= "tblNhanVien.DienThoai, tblNhanVien.CMND, tblNhanVien.NgayCap, tblNhanVien.NoiCap,"
                strSQL &= "tblNhanVien.NgayVaoCongTy, tblNhanVien.NgayThoiViec, tblNhanVien.KetHon, tblNhanVien.DanToc,"
                strSQL &= "tblNhanVien.TonGiao, tblNhanVien.TrinhDo, tblNhanVien.ChuyenNganh, tblNhanVien.NgoaiNgu,tblNhanVien.PhoTo,"
                strSQL &= "tblNhanVien.MaBP, tblNhanVien.MaCV, tblNhanVien.MaTinhTP "
                strSQL &= "FROM (tblChucVu RIGHT JOIN (tblBoPhan RIGHT JOIN tblNhanVien ON tblBoPhan.MaBP = tblNhanVien.MaBP) ON tblChucVu.MaCV = tblNhanVien.MaCV) LEFT JOIN tblTinhTP ON tblNhanVien.MaTinhTP = tblTinhTP.MaTinhTP;"                
            Case 2  'Hoa don mua hang
                lblDanhSach.Text = "Hóa đơn mua hàng"
                strColumnsHeader = "Mã hóa đơn,Ngày HĐ, Nhà cung cấp,Nhân viên lập HĐ,Ngày giao hàng,Hạn thanh toán, Chi phí vận chuyển,Tiền thuế, Tiền chiết khấu, Tổng tiền hóa đơn,Tiền đã trả nhà cung cấp, Tiền còn nợ nhà cung cấp"
                strSQL = "SELECT MaHDMH,NgayHDMH,TenNCC,HoTen,NgayGiaoHang,HanThanhToan,PhiVanChuyen,TienThue,TienGiamGia,TongTien,TienDaTra,TienConNo,MaNCC,MaNV From View_DS_HDMH"
            Case 3  ' Nhap kho
                lblDanhSach.Text = "Phiếu nhập kho"               
                strColumnsHeader = "Mã PNK,Ngày NK,Kho,Nhân viên,Nhà CC,Địa chỉ NCC,Người giao hàng,Số điện thoại"
                strSQL = "SELECT tblPhieuNhapKho.MaPNK, tblPhieuNhapKho.NgayNK, tblKho.TenKho, tblNhanVien.HoTen, tblNhaCC.TenNCC,tblNhaCC.DiaChi, tblPhieuNhapKho.NguoiGH,tblNhaCC.DienThoai, tblPhieuNhapKho.MaKho, tblPhieuNhapKho.MaNV, tblPhieuNhapKho.MaNCC "
                strSQL &= "FROM tblNhaCC RIGHT JOIN (tblNhanVien RIGHT JOIN (tblKho RIGHT JOIN tblPhieuNhapKho ON tblKho.MaKho = tblPhieuNhapKho.MaKho) ON tblNhanVien.MaNV = tblPhieuNhapKho.MaNV) ON tblNhaCC.MaNCC = tblPhieuNhapKho.MaNCC"
            Case 4  ' Tra tien nha cung cap
                lblDanhSach.Text = "Thanh toán trả tiền nhà cung cấp"
                strColumnsHeader = "Mã Phiếu chi,Ngày thanh toán, Mã hóa đơn mua hàng,Số tiền thanh toán,Nhà cung cấp,Nhân viên lập phiếu chi,Người nhận tiền TT,Lý do chi,Chứng từ kém theo"
                strSQL = "Select MaPC,NgayPC,MaHDMH,SoTien,TenNCC,HoTen,NguoiNhan,LyDoChi,KemTheoChungTu,MaNCC,MaNV From View_DS_PhieuChi"
            Case 5  'Hoa don ban hang
                lblDanhSach.Text = "Hóa đơn bán hàng"
                strColumnsHeader = "Mã hóa đơn,Ngày HĐ, Khách hàng,Nhân viên lập HĐ,Ngày giao hàng,Hạn thanh toán, Chi phí vận chuyển,Tiền thuế, Tiền chiết khấu, Tổng tiền hóa đơn,Tiền đã thu của khách hàng, Tiền còn phải thu của KH"
                strSQL = "SELECT MaHDBH,NgayHDBH,TenKH,HoTen,NgayGiaoHang,HanThanhToan,PhiVanChuyen,TienThue,TienGiamGia,TongTien,TienDaThu,TienConNo,MaKH,MaNV From View_DS_HDBH"
            Case 6  ' xuat kho
                lblDanhSach.Text = "Phiếu xuất kho"        
                strColumnsHeader = "Mã PXK,Ngày XK,Kho,Nhân viên,Khách hàng,Địa chỉ KH,Số điện thoại KH"
                strSQL = "SELECT tblPhieuXuatKho.MaPXK, tblPhieuXuatKho.NgayXK, tblKho.TenKho, tblNhanVien.HoTen, tblKhachHang.TenKH,tblKhachHang.DiaChi,tblKhachHang.DienThoai, tblPhieuXuatKho.MaKho, tblPhieuXuatKho.MaKH, tblPhieuXuatKho.MaNV,tblKhachHang.TenKH,tblKhachHang.DiaChi,tblKhachHang.CongTy "
                strSQL &= "FROM tblKhachHang RIGHT JOIN (tblNhanVien RIGHT JOIN (tblKho RIGHT JOIN tblPhieuXuatKho ON tblKho.MaKho = tblPhieuXuatKho.MaKho) ON tblNhanVien.MaNV = tblPhieuXuatKho.MaNV) ON tblKhachHang.MaKH = tblPhieuXuatKho.MaKH "               
            Case 7  'Thu tien khach hang
                lblDanhSach.Text = "Thu tiền khách hàng"              
                strColumnsHeader = "Mã Phiếu thu,Ngày thanh toán, Mã hóa đơn bán hàng,Số tiền thanh toán,Khách hàng,Nhân viên lập phiếu thu,Người nộp tiền TT,Lý do thu,Chứng từ kém theo"
                strSQL = "Select MaPT,NgayPT,MaHDBH,SoTien,TenKH,HoTen,NguoiNop,LyDoThu,KemTheoChungTu,MaKH,MaNV From View_DS_PhieuThu"

                

            Case 20 'Bo phan 
                lblDanhSach.Text = "Phòng ban - Bộ phận"
                strColumnsHeader = "Mã bộ phận,Tên bộ phận,Địa chỉ,Điện thoại,Fax"            
                strSQL = "Select MaBP,TenBP,DiaChi,DienThoai,Fax From tblBoPhan Order by TenBP"                
            Case 21 'Chuc vu
                lblDanhSach.Text = "Công việc - Chức vụ"
                strColumnsHeader = "Mã chức vụ,Tên chức vụ,Tên chức vụ trong sổ BHXH,Phụ cấp"                
                strSQL = "Select MaCV,TenCV,TenCVBH,PhuCap From tblChucVu Order by TenCV"                
            Case 22 'Nha cung cap
                lblDanhSach.Text = "Nhà cung cấp"               
                strColumnsHeader = "Mã NCC,Tên NCC,Người đại diện,Địa chỉ,Tỉnh TP,MST,Số tài khoản,Mở tại,Điện thoại,Email,Fax,Website,Mô tả"
                strSQL = "Select MaNCC,TenNCC,DaiDien,DiaChi,TenTinhTP,MST,SoTaiKhoan,"
                strSQL &= "NganHang,DienThoai,Email,Fax,Website,MoTa,tblNhaCC.MaTinhTP "
                strSQL &= "From tblTinhTP RIGHT JOIN tblNhaCC ON tblTinhTP.MaTinhTP=tblNhaCC.MaTinhTP "
                strSQL &= "Order by TenNCC"                
            Case 23 'Nhom hang
                lblDanhSach.Text = "Nhóm hàng"
                strColumnsHeader = "Mã nhóm,Tên nhóm,Mô tả"                
                strSQL = "Select * From tblNhomHang Order by TenNhom"                
            Case 24 ' Khach hang
                lblDanhSach.Text = "Khách hàng"                
                strColumnsHeader = "Mã KH,Tên KH,Công ty,Người đại diện,Địa chỉ,Tỉnh TP,MST,Số tài khoản,Mở tại,Điện thoại,Email,Fax,Website"
                strSQL = "Select MaKH,TenKH,CongTy,DaiDien,DiaChi,TenTinhTP,MST,SoTaiKhoan,"
                strSQL &= "NganHang,DienThoai,Email,Fax,Website,KhachLe,tblKhachHang.MaTinhTP "
                strSQL &= ("From tblTinhTP RIGHT JOIN tblKhachHang ON tblTinhTP.MaTinhTP=tblKhachHang.MaTinhTP ")
                strSQL &= ("Order by TenKH")                
            Case 25 'Kho
                lblDanhSach.Text = "Kho"
                strColumnsHeader = "Mã kho,Tên kho,Địa chỉ,Điện thoại"               
                strSQL = "Select MaKho,TenKho,DiaChi,DienThoai From tblKho Order by TenKho"                
            Case 26 'Tinh thanh pho
                lblDanhSach.Text = "Tỉnh thành phố"
                strColumnsHeader = "Mã Tỉnh,Tên tỉnh,Quốc gia"               
                strSQL = "Select * From tblTinhTP Order by TenTinhTP"                
            Case 27 'Vat tu hang hoa
                lblDanhSach.Text = "Vật tư hàng hóa"
                strSQL = "Select MaH,TenH,DVT,TenNhom,SL_Nhap,SL_Xuat,SL_Ton,DGBan,ThueVAT,XuatSu,PhoTo,MaNhom From View_frmHangHoa"
                strColumnsHeader = "Mã hàng,Tên hàng,ĐVT,Nhóm hàng,Số lượng nhập,Số lượng bán,Số lượng tồn,Đơn giá bán,Thuế VAT(%),Xuất sứ,Đường dẫn ảnh"
        End Select

        '----------------------
        'Tải dữ liệu vào DataGridView

        If strTimKiem = "" Then 'Ở chế độ load thông thường
            objConnect.Load_DataGridView(Me.DataGridView, strColumnsHeader, strSQL)
            'Đếm số bản ghi
            lblTongSoBanGhi.Text = "Tổng số bản ghi: " & Me.DataGridView.RowCount
        Else
            objConnect.Load_DataGridView(Me.DataGridView, strColumnsHeader, strTimKiem)
            'Đếm số bản ghi
            lblTongSoBanGhi.Text = "Kết quả tìm kiếm: " & Me.DataGridView.RowCount
        End If

        If (Me.DataGridView.RowCount < 1) Then
            Me.btnIn.Enabled = False
            Me.btnXoa.Enabled = False
            Me.btnSua.Enabled = False
        Else
            Me.DataGridView.Item(0, 0).Selected = True
            If (FormID = 1 Or FormID = 3 Or FormID = 4 Or FormID = 5 Or FormID = 6 Or FormID = 7 Or FormID = 22 Or FormID = 24 Or FormID = 27) Then
                Me.btnIn.Enabled = True
            Else
                Me.btnIn.Enabled = False
            End If
            Me.btnXoa.Enabled = True
            Me.btnSua.Enabled = True
        End If
    End Sub

    '----------------------------------------------------------------
    Friend Sub ThemMoi(ByVal FormID As Integer)
        pThem = True
        Select Case FormID
            Case 1  'Nhan vien
                frmNhanVien.Text = "Thêm mới nhân viên"
                frmNhanVien.ShowDialog()
                frmNhanVien.ShowInTaskbar = False
            Case 2  'Hoa don mua hang
                frmHoaDonMuaHang.Text = "Thêm mới hóa đơn mua hàng"
                frmHoaDonMuaHang.ShowDialog()
                frmHoaDonMuaHang.ShowInTaskbar = False
            Case 3  ' Nhap kho
                frmPhieuNhapKho.Text = "Thêm mới phiếu nhập kho"
                frmPhieuNhapKho.ShowDialog()
                frmPhieuNhapKho.ShowInTaskbar = False
            Case 4  ' Tra tien nha cung cap
                frmPhieuChi.Text = "Thêm mới phiếu chi"
                frmPhieuChi.ShowDialog()
                frmPhieuChi.ShowInTaskbar = False
            Case 5  'Hoa don ban hang
                frmHoaDonBanHang.Text = "Thêm mới hóa đơn bán hàng"
                frmHoaDonBanHang.ShowDialog()
                frmHoaDonBanHang.ShowInTaskbar = False
            Case 6  ' xuat kho
                frmPhieuXuatKho.Text = "Thêm mới phiếu xuất kho"
                frmPhieuXuatKho.ShowDialog()
                frmPhieuXuatKho.ShowInTaskbar = False
            Case 7  'Thu tien khach hang
                frmPhieuThu.Text = "Thêm mới phiếu thu"
                frmPhieuThu.ShowDialog()
                frmPhieuThu.ShowInTaskbar = False


            Case 20 'Bo phan 
                frmBoPhan.Text = "Thêm mới bộ phận"
                frmBoPhan.ShowDialog()
                frmBoPhan.ShowInTaskbar = False
            Case 21 'Chuc vu
                frmChucVu.Text = "Thêm mới chức vụ"
                frmChucVu.ShowDialog()
                frmChucVu.ShowInTaskbar = False
            Case 22 'Nha cung cap
                frmNhaCC.Text = "Thêm mới nhà cung cấp"
                frmNhaCC.ShowDialog()
                frmNhaCC.ShowInTaskbar = False
            Case 23 'Nhom hang
                frmNhomHang.Text = "Thêm mới nhóm hàng"
                frmNhomHang.ShowDialog()
                frmNhomHang.ShowInTaskbar = False
            Case 24 ' Khach hang
                frmKhachHang.Text = "Thêm mới khách hàng"
                frmKhachHang.ShowDialog()
                frmKhachHang.ShowInTaskbar = False
            Case 25 'Kho
                frmKho.Text = "Thêm mới kho"
                frmKho.ShowDialog()
                frmKho.ShowInTaskbar = False
            Case 26 'Tinh thanh pho
                frmTinhTP.Text = "Thêm mới tỉnh thành phố"
                frmTinhTP.ShowDialog()
                frmTinhTP.ShowInTaskbar = False
            Case 27 'Vat tu hang hoa
                frmHangHoa.Text = "Thêm mới hàng hóa"
                frmHangHoa.ShowDialog()
                frmHangHoa.ShowInTaskbar = False
        End Select
    End Sub

    '----------------------------------------------------------------
    Friend Sub SuaChua(ByVal FormID As Integer)
        pThem = False   'Sua
        Select Case FormID
            Case 1  'Nhan vien                
                pstrMa_Cu = Me.DataGridView.CurrentRow.Cells("MaNV").Value.ToString
                frmNhanVien.txtMaNV.Text = Me.DataGridView.CurrentRow.Cells("MaNV").Value.ToString
                frmNhanVien.txtHoTen.Text = Me.DataGridView.CurrentRow.Cells("HoTen").Value.ToString
                frmNhanVien.chkNam.Checked = IIf(Me.DataGridView.CurrentRow.Cells("GioiTinh").Value.ToString = "Nam", True, False)
                frmNhanVien.mskNgaySinh.Text = (Me.DataGridView.CurrentRow.Cells("NgaySinh").Value.ToString)
                objConnect.SetDataCombobox(frmNhanVien.cboMaBP, "Select MaBP,TenBP From tblBoPhan Order by TenBP")                
                frmNhanVien.cboMaBP.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaBP").Value.ToString
                objConnect.SetDataCombobox(frmNhanVien.cboMaCV, "Select MaCV,TenCV From tblChucVu Order by TenCV")
                frmNhanVien.cboMaCV.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaCV").Value.ToString
                frmNhanVien.txtDiaChi.Text = Me.DataGridView.CurrentRow.Cells("DiaChi").Value.ToString
                objConnect.SetDataCombobox(frmNhanVien.cboMaTinhTP, "Select MaTinhTP,TenTinhTP From tblTinhTP Order by TenTinhTP")
                frmNhanVien.cboMaTinhTP.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value.ToString
                frmNhanVien.mskDienThoai.Text = Me.DataGridView.CurrentRow.Cells("DienThoai").Value.ToString
                frmNhanVien.txtCMND.Text = Me.DataGridView.CurrentRow.Cells("CMND").Value.ToString
                frmNhanVien.mskNgayCap.Text = Me.DataGridView.CurrentRow.Cells("NgayCap").Value
                frmNhanVien.txtNoiCap.Text = Me.DataGridView.CurrentRow.Cells("NoiCap").Value.ToString
                frmNhanVien.mskNgayVaoCongTy.Text = Me.DataGridView.CurrentRow.Cells("NgayVaoCongTy").Value.ToString
                frmNhanVien.mskNgayThoiViec.Text = Me.DataGridView.CurrentRow.Cells("NgayThoiViec").Value.ToString
                frmNhanVien.chkChua.Checked = IIf(Me.DataGridView.CurrentRow.Cells("KetHon").Value.ToString = "Chưa", True, False)
                frmNhanVien.txtDanToc.Text = Me.DataGridView.CurrentRow.Cells("DanToc").Value.ToString
                frmNhanVien.txtTonGiao.Text = Me.DataGridView.CurrentRow.Cells("TonGiao").Value.ToString
                frmNhanVien.txtTrinhDo.Text = Me.DataGridView.CurrentRow.Cells("TrinhDo").Value.ToString
                frmNhanVien.txtChuyenNganh.Text = Me.DataGridView.CurrentRow.Cells("ChuyenNganh").Value.ToString
                frmNhanVien.txtNgoaiNgu.Text = Me.DataGridView.CurrentRow.Cells("NgoaiNgu").Value.ToString
                frmNhanVien.txtDuongDan.Text = Me.DataGridView.CurrentRow.Cells("PhoTo").Value.ToString
                'Hiển thị ảnh
                If Len(frmNhanVien.txtDuongDan.Text.Trim) > 0 Then
                    Try
                        frmNhanVien.picPhoto.Image = Image.FromFile(frmNhanVien.txtDuongDan.Text)
                    Catch ex As Exception
                        frmMsgOK.HienThi("Không tìm thấy file ảnh theo đường đường dẫn đã lưu, vui lòng chọn lại đường dẫn", "Thông báo")
                    End Try
                Else
                    frmNhanVien.picPhoto.Image = Nothing
                End If

                frmNhanVien.Text = "Sửa thông tin nhân viên"
                frmNhanVien.ShowDialog()
                frmNhanVien.ShowInTaskbar = False

            Case 2  'Hoa don mua hang  
                Try
                    objConnect.SetDataCombobox(frmSuaHoaDonMuaHang.cboNhaCC, "Select MaNCC,TenNCC From tblNhaCC Order by TenNCC")
                    'objConnect.SetDataComboboxInDataGridView(frmHoaDonMuaHang.colMaH, "Select MaH,TenH From tblHangHoa Order by TenH")
                    frmSuaHoaDonMuaHang.LoadData(Me.DataGridView.CurrentRow.Cells("MaHDMH").Value)
                    frmSuaHoaDonMuaHang.ShowDialog()
                    frmSuaHoaDonMuaHang.ShowInTaskbar = False
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 3  ' Nhap kho 
                Try
                    'Tạo nguồn dữ liệu cho các combobox
                    objConnect.SetDataCombobox(frmSuaPhieuNhapKho.cboNhaCC, "Select MaNCC,TenNCC From tblNhaCC Order by TenNCC")
                    objConnect.SetDataCombobox(frmSuaPhieuNhapKho.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
                    'phần chi tiết
                    ' objConnect.SetDataComboboxInDataGridView(frmPhieuNhapKho.colMaH, "Select MaH,TenH From tblHangHoa")
                    frmSuaPhieuNhapKho.LoadData(Me.DataGridView.CurrentRow.Cells("MaPNK").Value)
                    frmSuaPhieuNhapKho.ShowDialog()
                    frmSuaPhieuNhapKho.ShowInTaskbar = False
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 4  ' Tra tien nha cung cap
                objConnect.SetDataCombobox(frmPhieuChi.cboMaHD, "Select MaHDMH,MaHDMH AS M From tblHoaDonMuaHang")
                frmPhieuChi.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaPC").Value
                frmPhieuChi.txtMaPhieuChi.Text = Me.DataGridView.CurrentRow.Cells("MaPC").Value.ToString
                frmPhieuChi.mskNgayPC.Text = Me.DataGridView.CurrentRow.Cells("NgayPC").Value.ToString
                frmPhieuChi.cboMaHD.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaHDMH").Value.ToString
                frmPhieuChi.txtNhanVien.Text = pTenNV
                frmPhieuChi.txtNguoiNhan.Text = Me.DataGridView.CurrentRow.Cells("NguoiNhan").Value.ToString
                frmPhieuChi.txtLyDoChi.Text = Me.DataGridView.CurrentRow.Cells("LyDoChi").Value.ToString
                frmPhieuChi.txtKemTheo.Text = Me.DataGridView.CurrentRow.Cells("KemTheoChungTu").Value.ToString
                frmPhieuChi.txtSoTien.Text = Me.DataGridView.CurrentRow.Cells("SoTien").Value.ToString
                frmPhieuChi.Text = "Sửa thông tin phiếu chi"
                frmPhieuChi.ShowDialog()
                frmPhieuChi.ShowInTaskbar = False
            Case 5  'Hoa don ban hang
                Try
                    objConnect.SetDataCombobox(frmSuaHoaDonBanHang.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
                    'objConnect.SetDataComboboxInDataGridView(frmSuaHoaDonBanHang.colMaH, "Select MaH,TenH From tblHangHoa Order by TenH")
                    frmSuaHoaDonBanHang.LoadData(Me.DataGridView.CurrentRow.Cells("MaHDBH").Value)
                    frmSuaHoaDonBanHang.ShowDialog()
                    frmSuaHoaDonBanHang.ShowInTaskbar = False
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

               
            Case 6  ' xuat kho   
                Try
                    'Tạo nguồn dữ liệu cho các combobox
                    objConnect.SetDataCombobox(frmSuaPhieuXuatKho.cboKhachHang, "Select MaKH,TenKH From tblKhachHang Order by TenKH")
                    objConnect.SetDataCombobox(frmSuaPhieuXuatKho.cboMaKho, "Select MaKho,TenKho From tblKho Order by TenKho")
                    'phần chi tiết                
                    'objConnect.SetDataComboboxInDataGridView(frmPhieuXuatKho.colMaH, "SELECT MaH, TenH FROM tblHangHoa")
                    frmSuaPhieuXuatKho.LoadData(Me.DataGridView.CurrentRow.Cells("MaPXK").Value)
                    frmSuaPhieuXuatKho.ShowDialog()
                    frmSuaPhieuXuatKho.ShowInTaskbar = False
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 7  'Thu tien khach hang
                objConnect.SetDataCombobox(frmPhieuThu.cboMaHD, "Select MaHDBH,MaHDBH AS M From tblHoaDonBanHang")
                frmPhieuThu.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaPT").Value.ToString
                frmPhieuThu.txtMaPhieuThu.Text = Me.DataGridView.CurrentRow.Cells("MaPT").Value.ToString
                frmPhieuThu.mskNgayPT.Text = Me.DataGridView.CurrentRow.Cells("NgayPT").Value.ToString
                frmPhieuThu.cboMaHD.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaHDBH").Value.ToString
                frmPhieuThu.txtNhanVien.Text = pTenNV
                frmPhieuThu.txtNguoiNop.Text = Me.DataGridView.CurrentRow.Cells("NguoiNop").Value.ToString
                frmPhieuThu.txtLyDoThu.Text = Me.DataGridView.CurrentRow.Cells("LyDoThu").Value.ToString
                frmPhieuThu.txtKemTheo.Text = Me.DataGridView.CurrentRow.Cells("KemTheoChungTu").Value.ToString
                frmPhieuThu.txtSoTien.Text = Me.DataGridView.CurrentRow.Cells("SoTien").Value.ToString
                frmPhieuThu.Text = "Sửa thông tin phiếu thu"
                frmPhieuThu.ShowDialog()
                frmPhieuThu.ShowInTaskbar = False
            

            Case 20 'Bo phan 
                frmBoPhan.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaBP").Value
                frmBoPhan.strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenBP").Value
                frmBoPhan.txtMaBP.Text = Me.DataGridView.CurrentRow.Cells("MaBP").Value.ToString
                frmBoPhan.txtTenBP.Text = Me.DataGridView.CurrentRow.Cells("TenBP").Value.ToString
                frmBoPhan.txtDiaChi.Text = Me.DataGridView.CurrentRow.Cells("DiaChi").Value.ToString
                frmBoPhan.mskDienThoai.Text = Me.DataGridView.CurrentRow.Cells("DienThoai").Value.ToString
                frmBoPhan.mskFax.Text = Me.DataGridView.CurrentRow.Cells("Fax").Value.ToString
                frmBoPhan.Text = "Sửa thông tin phòng ban"
                frmBoPhan.ShowDialog()
                frmBoPhan.ShowInTaskbar = False
            Case 21 'Chuc vu
                'Lưu dữ liệu cũ
                frmChucVu.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaCV").Value
                frmChucVu.strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenCV").Value
                frmChucVu.txtMaCV.Text = Me.DataGridView.CurrentRow.Cells("MaCV").Value.ToString
                frmChucVu.txtTenCV.Text = Me.DataGridView.CurrentRow.Cells("TenCV").Value.ToString
                frmChucVu.txtTenCVBHXH.Text = Me.DataGridView.CurrentRow.Cells("TenCVBH").Value.ToString
                frmChucVu.txtPhuCap.Text = Me.DataGridView.CurrentRow.Cells("PhuCap").Value.ToString
                frmChucVu.Text = "Sửa thông tin công việc - chức vụ"
                frmChucVu.ShowDialog()
                frmChucVu.ShowInTaskbar = False
            Case 22 'Nha cung cap
                'tạo nguồn dữ liệu cho combobox tỉnh thành phố
                objConnect.SetDataCombobox(frmNhaCC.cboMaTinhTP, "Select MaTinhTP,TenTinhTP From tblTinhTP Order by TenTinhTP")
                frmNhaCC.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaNCC").Value.ToString
                frmNhaCC.txtTenNCC.Text = Me.DataGridView.CurrentRow.Cells("TenNCC").Value.ToString
                frmNhaCC.txtDaiDien.Text = Me.DataGridView.CurrentRow.Cells("DaiDien").Value.ToString
                frmNhaCC.txtDiaChi.Text = Me.DataGridView.CurrentRow.Cells("DiaChi").Value.ToString
                frmNhaCC.cboMaTinhTP.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value.ToString
                frmNhaCC.txtMST.Text = Me.DataGridView.CurrentRow.Cells("MST").Value.ToString
                frmNhaCC.txtTaiKhoan.Text = Me.DataGridView.CurrentRow.Cells("SoTaiKhoan").Value.ToString
                frmNhaCC.txtNganHang.Text = Me.DataGridView.CurrentRow.Cells("NganHang").Value.ToString
                frmNhaCC.mskDienThoai.Text = Me.DataGridView.CurrentRow.Cells("DienThoai").Value.ToString
                frmNhaCC.txtEmail.Text = Me.DataGridView.CurrentRow.Cells("Email").Value.ToString
                frmNhaCC.mskFax.Text = Me.DataGridView.CurrentRow.Cells("Fax").Value.ToString
                frmNhaCC.txtWebsite.Text = Me.DataGridView.CurrentRow.Cells("Website").Value.ToString
                frmNhaCC.txtMoTa.Text = Me.DataGridView.CurrentRow.Cells("MoTa").Value.ToString
                frmNhaCC.Text = "Sửa thông tin nhà cung cấp"
                frmNhaCC.ShowDialog()
                frmNhaCC.ShowInTaskbar = False
            Case 23 'Nhom hang
                frmNhomHang.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaNhom").Value.ToString
                frmNhomHang.strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenNhom").Value.ToString
                frmNhomHang.txtTenNhom.Text = Me.DataGridView.CurrentRow.Cells("TenNhom").Value.ToString
                frmNhomHang.txtMoTa.Text = Me.DataGridView.CurrentRow.Cells("MoTa").Value.ToString
                frmNhomHang.Text = "Sửa thông tin nhóm hàng"
                frmNhomHang.ShowDialog()
                frmNhomHang.ShowInTaskbar = False
            Case 24 ' Khach hang
                'tạo nguồn dữ liệu cho combobox tỉnh thành phố
                objConnect.SetDataCombobox(frmKhachHang.cboMaTinhTP, "Select MaTinhTP,TenTinhTP From tblTinhTP Order by TenTinhTP")
                frmKhachHang.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaKH").Value.ToString
                frmKhachHang.txtTenKH.Text = Me.DataGridView.CurrentRow.Cells("TenKH").Value.ToString
                frmKhachHang.txtCongTy.Text = Me.DataGridView.CurrentRow.Cells("CongTy").Value.ToString
                frmKhachHang.txtDaiDien.Text = Me.DataGridView.CurrentRow.Cells("DaiDien").Value.ToString
                frmKhachHang.txtDiaChi.Text = Me.DataGridView.CurrentRow.Cells("DiaChi").Value.ToString
                frmKhachHang.cboMaTinhTP.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value.ToString
                frmKhachHang.txtMST.Text = Me.DataGridView.CurrentRow.Cells("MST").Value.ToString
                frmKhachHang.txtTaiKhoan.Text = Me.DataGridView.CurrentRow.Cells("SoTaiKhoan").Value.ToString
                frmKhachHang.txtNganHang.Text = Me.DataGridView.CurrentRow.Cells("NganHang").Value.ToString
                frmKhachHang.mskDienThoai.Text = Me.DataGridView.CurrentRow.Cells("DienThoai").Value.ToString
                frmKhachHang.txtEmail.Text = Me.DataGridView.CurrentRow.Cells("Email").Value.ToString
                frmKhachHang.mskFax.Text = Me.DataGridView.CurrentRow.Cells("Fax").Value.ToString
                frmKhachHang.txtWebsite.Text = Me.DataGridView.CurrentRow.Cells("Website").Value.ToString
                frmKhachHang.chkKhachLe.Checked = Me.DataGridView.CurrentRow.Cells("KhachLe").Value.ToString
                frmKhachHang.Text = "Sửa thông tin khách hàng"
                frmKhachHang.ShowDialog()
                frmKhachHang.ShowInTaskbar = False
            Case 25 'Kho
                frmKho.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaKho").Value
                frmKho.strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenKho").Value.ToString
                frmKho.txtTenKho.Text = Me.DataGridView.CurrentRow.Cells("TenKho").Value.ToString
                frmKho.txtDiaChi.Text = Me.DataGridView.CurrentRow.Cells("DiaChi").Value.ToString
                frmKho.mskDienThoai.Text = Me.DataGridView.CurrentRow.Cells("DienThoai").Value.ToString
                frmKho.Text = "Sửa thông tin kho hàng"
                frmKho.ShowDialog()
                frmKho.ShowInTaskbar = False
            Case 26 'Tinh thanh pho
                frmTinhTP.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value
                frmTinhTP.strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenTinhTP").Value.ToString
                frmTinhTP.txtTenTinhTP.Text = Me.DataGridView.CurrentRow.Cells("TenTinhTP").Value.ToString
                frmTinhTP.txtQuocGia.Text = Me.DataGridView.CurrentRow.Cells("QuocGia").Value.ToString
                frmTinhTP.Text = "Sửa thông tin tỉnh thành phố"
                frmTinhTP.ShowDialog()
                frmTinhTP.ShowInTaskbar = False
            Case 27 'Vat tu hang hoa
                objConnect.SetDataCombobox(frmHangHoa.cboMaNhom, "Select MaNhom,TenNhom From tblNhomHang Order by TenNhom")
                frmHangHoa.strMa_Cu = Me.DataGridView.CurrentRow.Cells("MaH").Value.ToString
                frmHangHoa.strTen_Cu = Me.DataGridView.CurrentRow.Cells("TenH").Value.ToString

                frmHangHoa.txtMaHang.Text = Me.DataGridView.CurrentRow.Cells("MaH").Value.ToString
                frmHangHoa.txtTenHang.Text = Me.DataGridView.CurrentRow.Cells("TenH").Value.ToString
                frmHangHoa.cboDVT.Text = Me.DataGridView.CurrentRow.Cells("DVT").Value.ToString
                frmHangHoa.txtSoLuongNhap.Text = Me.DataGridView.CurrentRow.Cells("SL_Nhap").Value.ToString
                frmHangHoa.txtSoLuongBan.Text = Me.DataGridView.CurrentRow.Cells("SL_Xuat").Value.ToString
                frmHangHoa.txtSoLuongTon.Text = Me.DataGridView.CurrentRow.Cells("SL_Ton").Value.ToString
                frmHangHoa.txtDGBan.Text = Me.DataGridView.CurrentRow.Cells("DGBan").Value.ToString
                frmHangHoa.txtThueVAT.Text = Me.DataGridView.CurrentRow.Cells("ThueVAT").Value.ToString
                frmHangHoa.txtXuatSu.Text = Me.DataGridView.CurrentRow.Cells("XuatSu").Value.ToString
                frmHangHoa.txtDuongDan.Text = Me.DataGridView.CurrentRow.Cells("PhoTo").Value.ToString
                frmHangHoa.cboMaNhom.SelectedValue = Me.DataGridView.CurrentRow.Cells("MaNhom").Value.ToString

                'Hiển thị ảnh
                If Len(frmHangHoa.txtDuongDan.Text.Trim) > 0 Then
                    Try
                        frmHangHoa.picPhoto.Image = Image.FromFile(frmHangHoa.txtDuongDan.Text)
                    Catch ex As Exception
                        frmMsgOK.HienThi("Không tìm thấy file ảnh theo đường đường dẫn đã lưu, vui lòng chọn lại đường dẫn", "Thông báo")
                    End Try
                Else
                    frmHangHoa.picPhoto.Image = Nothing
                End If

                frmHangHoa.Text = "Sửa thông tin hàng hóa"
                frmHangHoa.ShowDialog()
                frmHangHoa.ShowInTaskbar = False
        End Select
    End Sub

    '----------------------------------------------------------------
    Friend Sub Xoa(ByVal FormID As Integer)
        Select Case FormID
            Case 1  'Nhan vien
                Dim strSQL As String = "Delete From tblNhanVien Where MaNV Like N'" & Me.DataGridView.CurrentRow.Cells("MaNV").Value & "'"
                Dim blnPhieuNhapKho, blnPhieuXuatKho As Boolean
                blnPhieuNhapKho = objConnect.DaTonTai("Select * From tblPhieuNhapKho Where MaNV Like N'" & Me.DataGridView.CurrentRow.Cells("MaNV").Value & "'")
                blnPhieuXuatKho = objConnect.DaTonTai("Select * From tblPhieuXuatKho Where MaNV Like N'" & Me.DataGridView.CurrentRow.Cells("MaNV").Value & "'")
                If (blnPhieuNhapKho Or blnPhieuXuatKho) = True Then
                    frmMsgOK.HienThi("Mã nhân viên này đang được sử dụng bạn  không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)
                    End If
                End If
            Case 2  'Hoa don mua hang
                Try
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        'Xóa dữ liệu 
                        objConnect.RunSQL("Delete From tblChiTietHoaDonMuaHang Where MaHDMH=N'" & Me.DataGridView.CurrentRow.Cells("MaHDMH").Value & "'")
                        objConnect.RunSQL("Delete From tblHoaDonMuaHang Where MaHDMH=N'" & Me.DataGridView.CurrentRow.Cells("MaHDMH").Value & "'")
                    End If
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 3  ' Nhap kho
                Try
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        'Xóa dữ liệu 
                        objConnect.RunSQL("Delete From tblCTPhieuNhapKho Where MaPNK=N'" & Me.DataGridView.CurrentRow.Cells("MaPNK").Value & "'")
                        objConnect.RunSQL("Delete From tblPhieuNhapKho Where MaPNK=N'" & Me.DataGridView.CurrentRow.Cells("MaPNK").Value & "'")
                    End If
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 4  ' Tra tien nha cung cap
                Dim strSQL As String = "Delete From tblPhieuChi Where MaPC Like N'" & Me.DataGridView.CurrentRow.Cells("MaPC").Value & "'"
                If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                    objConnect.RunSQL(strSQL)
                End If
            Case 5  'Hoa don ban hang
                Try
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        'Xóa dữ liệu 
                        objConnect.RunSQL("Delete From tblChiTietHoaDonBanHang Where MaHDBH=N'" & Me.DataGridView.CurrentRow.Cells("MaHDBH").Value & "'")
                        objConnect.RunSQL("Delete From tblHoaDonBanHang Where MaHDBH=N'" & Me.DataGridView.CurrentRow.Cells("MaHDBH").Value & "'")
                    End If
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 6  ' xuat kho
                Try
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        'Xóa dữ liệu 
                        objConnect.RunSQL("Delete From tblCTPhieuXuatKho Where MaPXK=N'" & Me.DataGridView.CurrentRow.Cells("MaPXK").Value & "'")
                        objConnect.RunSQL("Delete From tblHDBanHang Where MaPXK=N'" & Me.DataGridView.CurrentRow.Cells("MaPXK").Value & "'")
                        objConnect.RunSQL("Delete From tblPhieuXuatKho Where MaPXK=N'" & Me.DataGridView.CurrentRow.Cells("MaPXK").Value & "'")
                    End If
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 7  'Thu tien khach hang
                Dim strSQL As String = "Delete From tblPhieuThu Where MaPT Like N'" & Me.DataGridView.CurrentRow.Cells("MaPT").Value & "'"
                If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                    objConnect.RunSQL(strSQL)
                End If
           
            Case 20 'Bo phan 
                Dim strSQL As String = "Delete From tblBoPhan Where MaBP Like N'" & Me.DataGridView.CurrentRow.Cells("MaBP").Value & "'"
                Dim blnNhanVien As Boolean
                blnNhanVien = objConnect.DaTonTai("Select * From tblNhanVien Where MaBP Like N'" & Me.DataGridView.CurrentRow.Cells("MaBP").Value & "'")
                If (blnNhanVien) = True Then
                    frmMsgOK.HienThi("Bộ phận này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
            Case 21 'Chuc vu
                Dim strSQL As String = "Delete From tblChucVu Where MaCV Like N'" & Me.DataGridView.CurrentRow.Cells("MaCV").Value & "'"
                Dim blnNhanVien As Boolean
                blnNhanVien = objConnect.DaTonTai("Select * From tblNhanVien Where MaCV Like N'" & Me.DataGridView.CurrentRow.Cells("MaCV").Value & "'")
                If (blnNhanVien) = True Then
                    frmMsgOK.HienThi("Bộ phận này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
            Case 22 'Nha cung cap
                Dim strSQL As String = "Delete From tblNhaCC Where MaNCC Like N'" & Me.DataGridView.CurrentRow.Cells("MaNCC").Value & "'"
                Dim blnPhieuNhapKho As Boolean
                blnPhieuNhapKho = objConnect.DaTonTai("Select * From tblPhieuNhapKho Where MaNCC Like N'" & Me.DataGridView.CurrentRow.Cells("MaNCC").Value & "'")
                If (blnPhieuNhapKho) = True Then
                    frmMsgOK.HienThi("Mã nhà cung cấp này đang được sử dụng   bạn không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
            Case 23 'Nhom hang
                Dim strSQL As String = "Delete From tblNhomHang Where MaNhom Like N'" & Me.DataGridView.CurrentRow.Cells("MaNhom").Value & "'"
                Dim blnHangHoa As Boolean
                blnHangHoa = objConnect.DaTonTai("Select * From tblHangHoa Where MaNhom Like N'" & Me.DataGridView.CurrentRow.Cells("MaNhom").Value & "'")
                If (blnHangHoa) = True Then
                    frmMsgOK.HienThi("Tên nhóm này đang được sử dụng bạn không thể xóa nó", "Thông báo")
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo") = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
            Case 24 ' Khach hang
                Dim strSQL As String = "Delete From tblKhachHang Where MaKH Like N'" & Me.DataGridView.CurrentRow.Cells("MaKH").Value & "'"
                Dim blnPhieuXuatKho As Boolean
                blnPhieuXuatKho = objConnect.DaTonTai("Select * From tblPhieuXuatKho Where MaKH Like N'" & Me.DataGridView.CurrentRow.Cells("MaKH").Value & "'")
                If (blnPhieuXuatKho) = True Then
                    frmMsgOK.HienThi("Mã khách hàng này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
            Case 25 'Kho
                Dim strSQL As String = "Delete From tblKho Where MaKho Like N'" & Me.DataGridView.CurrentRow.Cells("MaKho").Value & "'"
                Dim blnPhieuNhapKho, blnPhieuXuatKho As Boolean
                blnPhieuNhapKho = objConnect.DaTonTai("Select * From tblPhieuNhapKho Where MaKho Like N'" & Me.DataGridView.CurrentRow.Cells("MaKho").Value & "'")
                blnPhieuXuatKho = objConnect.DaTonTai("Select * From tblPhieuXuatKho Where MaKho Like N'" & Me.DataGridView.CurrentRow.Cells("MaKho").Value & "'")
                If (blnPhieuNhapKho Or blnPhieuXuatKho) = True Then
                    frmMsgOK.HienThi("Kho này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
            Case 26 'Tinh thanh pho
                Dim strSQL As String = "Delete From tblTinhTP Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'"
                Dim blnNhanVien, blnKhachHang, blnNhaCC As Boolean
                blnNhanVien = objConnect.DaTonTai("Select * From tblNhanVien Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'")
                blnKhachHang = objConnect.DaTonTai("Select * From tblKhachHang Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'")
                blnNhaCC = objConnect.DaTonTai("Select * From tblNhaCC Where MaTinhTP Like N'" & Me.DataGridView.CurrentRow.Cells("MaTinhTP").Value & "'")
                If (blnNhanVien Or blnKhachHang Or blnNhaCC) = True Then
                    frmMsgOK.HienThi("Tên tỉnh thành phố này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
            Case 27 'Vat tu hang hoa
                Dim strSQL As String = "Delete From tblHangHoa Where MaH Like N'" & Me.DataGridView.CurrentRow.Cells("MaH").Value & "'"
                Dim blnCTPhieuNhapKho, blnCTPhieuXuatKho As Boolean
                blnCTPhieuNhapKho = objConnect.DaTonTai("Select * From tblCTPhieuNhapKho Where MaH Like N'" & Me.DataGridView.CurrentRow.Cells("MaH").Value & "'")
                blnCTPhieuXuatKho = objConnect.DaTonTai("Select * From tblCTPhieuXuatKho Where MaH Like N'" & Me.DataGridView.CurrentRow.Cells("MaH").Value & "'")
                If (blnCTPhieuNhapKho Or blnCTPhieuXuatKho) = True Then
                    frmMsgOK.HienThi("Mã hàng này đang được sử dụng bạn không thể xóa nó", "Thông báo", False)
                Else
                    If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                        objConnect.RunSQL(strSQL)                        
                    End If
                End If
        End Select
        'Lay lai du lieu len luoi
        LoadData(FormID)
        Me.DataGridView.Focus()
    End Sub

    '----------------------------------------------------------------
    Friend Sub InBC(ByVal FormID As Integer)
        Select Case FormID
            Case 1  'Nhan vien
                Dim strSQL As String
                Dim strMaNV As String
                strMaNV = NhapLieu.LayMa(Me.DataGridView, 0)
                strSQL = "Select * From view_NhanVien Where MaNV in (" & strMaNV & ")"
                frmBaoCao.PreviewReport(strSQL, 12) '12=in danh sách nhân viên
                frmBaoCao.ShowDialog()
            Case 2  'Hoa don mua hang

            Case 3  ' Nhap kho
                Try
                    Dim strSQL As String
                    Dim strMaPNK As String
                    strMaPNK = NhapLieu.LayMa(Me.DataGridView, 0)
                    strSQL = "Select * From view_PhieuNhapKho Where MaPNK =N'" & Me.DataGridView.CurrentRow.Cells("MaPNK").Value & "'" & "; Select * From view_CTPhieuNhapKho Where MaPNK=N'" & Me.DataGridView.CurrentRow.Cells("MaPNK").Value & "'"
                    'strSQL = "Select * From view_PhieuNhapKho Where MaPNK =N'" & Me.DataGridView.CurrentRow.Cells("MaPNK").Value & "'" & "; Select * From view_CTPhieuNhapKho Where MaPNK in (" & strMaPNK & ")"
                    frmBaoCao.PreviewReport(strSQL, 4)
                    frmBaoCao.ShowDialog()
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 4  ' Tra tien nha cung cap
                Dim strSQL As String
                strSQL = "Select * From View_PhieuChi Where MaPC=N'" & Me.DataGridView.CurrentRow.Cells("MaPC").Value & "'"
                frmBaoCao.PreviewReport(strSQL, 8) '8 = phiếu chi
                frmBaoCao.ShowDialog()
            Case 5  'Hoa don ban hang
                Try
                    Dim strSQL As String
                    strSQL = "Select * From view_KhachHang_HoaDon Where MaHDBH =N'" & Me.DataGridView.CurrentRow.Cells("MaHDBH").Value & "'" & "; Select * From view_CTHDBanHang Where MaHDBH =N'" & Me.DataGridView.CurrentRow.Cells("MaHDBH").Value & "'"
                    frmBaoCao.PreviewReport(strSQL, 7)
                    frmBaoCao.ShowDialog()
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

            Case 6  ' xuat kho
                Try
                    Dim strSQL As String
                    Dim strMaPXK As String
                    strMaPXK = NhapLieu.LayMa(Me.DataGridView, 0)
                    strSQL = "Select * From view_PhieuXuatKho Where MaPXK ='" & Me.DataGridView.CurrentRow.Cells("MaPXK").Value & "'" & "; Select * From view_CTPhieuXuatKho Where MaPXK in (" & strMaPXK & ")"
                    frmBaoCao.PreviewReport(strSQL, 5)
                    frmBaoCao.ShowDialog()
                Catch ex As Exception
                    MsgBox("Chọn bản ghi cần sửa", MsgBoxStyle.OkOnly, "Thông báo")
                End Try

                
            Case 7  'Thu tien khach hang
                Dim strSQL As String
                strSQL = "Select * From View_PhieuThu Where MaPT=N'" & Me.DataGridView.CurrentRow.Cells("MaPT").Value & "'"
                frmBaoCao.PreviewReport(strSQL, 9) '9 = phiếu thu
                frmBaoCao.ShowDialog()            
            Case 22 'Nha cung cap
                Dim strSQL As String
                Dim strMaNCC As String
                strMaNCC = NhapLieu.LayMa(Me.DataGridView, 0)
                strSQL = "Select * From view_NhaCC Where MaNCC in (" & strMaNCC & ")"
                frmBaoCao.PreviewReport(strSQL, 11)
                frmBaoCao.ShowDialog()
            Case 24 ' Khach hang
                Dim strSQL As String
                Dim strMaNV As String
                strMaNV = NhapLieu.LayMa(Me.DataGridView, 0)
                strSQL = "Select * From view_KhachHang Where MaKH in (" & strMaNV & ")"
                frmBaoCao.PreviewReport(strSQL, 10) '12=in danh sách nhân viên
                frmBaoCao.ShowDialog()            
            Case 27 'Vat tu hang hoa
                Dim strSQL As String
                Dim strMaH As String
                strMaH = NhapLieu.LayMa(Me.DataGridView, 0)
                strSQL = "Select * From view_HangHoa Where MaH in (" & strMaH & ")"
                frmBaoCao.PreviewReport(strSQL, 6)
                frmBaoCao.ShowDialog()
        End Select
    End Sub


    Private Sub btiHoaDonMuaHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiHoaDonMuaHang.Click
        FormID = 2
        LoadData(FormID)
    End Sub

    Private Sub btiHoaDonBanHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiHoaDonBanHang.Click
        FormID = 5
        LoadData(FormID)
    End Sub

    Private Sub btiTinhGiaBan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        ThemMoi(FormID)
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        SuaChua(FormID)
    End Sub

    
    Private Sub btiBaoCao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btiBaoCao.Click
        frmBaoCaoTongHop.ShowDialog()
        frmBaoCaoTongHop.ShowInTaskbar = False
    End Sub

    Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Xoa(FormID)
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        InBC(FormID)
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Select Case FormID
            Case 1  'Nhan vien
                frmTimKiemNhanVien.ShowDialog()
                frmTimKiemNhanVien.ShowInTaskbar = False
            Case 2  'Hoa don mua hang
                frmTimKiemHoaDonMuaHang.ShowDialog()
                frmTimKiemHoaDonMuaHang.ShowInTaskbar = False
            Case 3  ' Nhap kho
                frmTimKiemPhieuNhapKho.ShowDialog()
                frmTimKiemPhieuNhapKho.ShowInTaskbar = False
            Case 4  ' Tra tien nha cung cap
                frmTimKiemPhieuChi.ShowDialog()
                frmTimKiemPhieuChi.ShowInTaskbar = False
            Case 5  'Hoa don ban hang
                frmTimKiemHoaDonBanHang.ShowDialog()
                frmTimKiemHoaDonBanHang.ShowInTaskbar = False
            Case 6  ' xuat kho
                frmTimKiemPhieuXuatKho.ShowDialog()
                frmTimKiemPhieuXuatKho.ShowInTaskbar = False
            Case 7  'Thu tien khach hang
                frmTimKiemPhieuThu.ShowDialog()
                frmTimKiemPhieuThu.ShowInTaskbar = False            
            Case 22 'Nha cung cap
                frmTimKiemNhaCC.ShowDialog()
                frmTimKiemNhaCC.ShowInTaskbar = False
            
            Case 24 ' Khach hang
                frmTimKiemKhachHang.ShowDialog()
                frmTimKiemKhachHang.ShowInTaskbar = False           
            Case 27 'Vat tu hang hoa
                frmTimKiemHangHoa.ShowDialog()
                frmTimKiemHangHoa.ShowInTaskbar = False
        End Select
    End Sub

    Private Sub btnNap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNap.Click
        LoadData(FormID)
    End Sub

    
    Private Sub mnuNhapKho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormID = 3
        LoadData(FormID)
    End Sub

    Private Sub mnuHoaDonMuaHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHoaDonMuaHang.Click
        FormID = 2
        LoadData(FormID)
    End Sub

    

    Private Sub mnuHoaDonBanHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHoaDonBanHang.Click
        FormID = 5
        LoadData(FormID)
    End Sub

    Private Sub mnuXuatKho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuXuatKho.Click
        FormID = 6
        LoadData(FormID)
    End Sub

    
   

    
   
    Private Sub mnuBoPhan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBoPhan.Click
        FormID = 20
        LoadData(FormID)
    End Sub

    Private Sub mnuChucVu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChucVu.Click
        FormID = 21
        LoadData(FormID)
    End Sub

    Private Sub mnuNCC_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNCC.Click
        FormID = 22
        LoadData(FormID)
    End Sub

    Private Sub mnuKhoHang_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKhoHang.Click
        FormID = 25
        LoadData(FormID)
    End Sub

    Private Sub mnuKhachHang_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKhachHang.Click
        FormID = 24
        LoadData(FormID)
    End Sub

    Private Sub mnuNhomHang_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNhomHang.Click
        FormID = 23
        LoadData(FormID)
    End Sub

    Private Sub mnuTinhTP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTinhTP.Click
        FormID = 26
        LoadData(FormID)
    End Sub

    Private Sub mnuVatTuHangHoa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVatTuHangHoa.Click
        FormID = 27
        LoadData(FormID)
    End Sub

    Private Sub mnuDanhSachNhanVien_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDanhSachNhanVien.Click
        FormID = 1
        LoadData(FormID)
    End Sub

    Private Sub mnuNhapKho_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNhapKho.Click
        FormID = 3
        LoadData(FormID)
    End Sub

    Private Sub mnuPhieuChi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPhieuChi.Click
        FormID = 4
        LoadData(FormID)
    End Sub

    Private Sub mnuPhieuThu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPhieuThu.Click
        FormID = 7
        LoadData(FormID)
    End Sub

    Private Sub mnuTacGia_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTacGia.Click
        frmTacGia.ShowDialog()
        frmTacGia.ShowInTaskbar = False
    End Sub

    Private Sub mnuTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTimKiem.Click
        Select Case FormID
            Case 1  'Nhan vien
                frmTimKiemNhanVien.ShowDialog()
                frmTimKiemNhanVien.ShowInTaskbar = False
            Case 2  'Hoa don mua hang
                frmTimKiemHoaDonMuaHang.ShowDialog()
                frmTimKiemHoaDonMuaHang.ShowInTaskbar = False
            Case 3  ' Nhap kho
                frmTimKiemPhieuNhapKho.ShowDialog()
                frmTimKiemPhieuNhapKho.ShowInTaskbar = False
            Case 4  ' Tra tien nha cung cap
                frmTimKiemPhieuChi.ShowDialog()
                frmTimKiemPhieuChi.ShowInTaskbar = False
            Case 5  'Hoa don ban hang
                frmTimKiemHoaDonBanHang.ShowDialog()
                frmTimKiemHoaDonBanHang.ShowInTaskbar = False
            Case 6  ' xuat kho
                frmTimKiemPhieuXuatKho.ShowDialog()
                frmTimKiemPhieuXuatKho.ShowInTaskbar = False
            Case 7  'Thu tien khach hang
                frmTimKiemPhieuThu.ShowDialog()
                frmTimKiemPhieuThu.ShowInTaskbar = False
            Case 22 'Nha cung cap
                frmTimKiemNhaCC.ShowDialog()
                frmTimKiemNhaCC.ShowInTaskbar = False

            Case 24 ' Khach hang
                frmTimKiemKhachHang.ShowDialog()
                frmTimKiemKhachHang.ShowInTaskbar = False
            Case 27 'Vat tu hang hoa
                frmTimKiemHangHoa.ShowDialog()
                frmTimKiemHangHoa.ShowInTaskbar = False
        End Select
    End Sub

    Private Sub mnuNap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNap.Click
        LoadData(FormID)
    End Sub

    Private Sub mnuThemMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThemMoi.Click
        ThemMoi(FormID)
    End Sub

    Private Sub mnuSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSua.Click
        SuaChua(FormID)
    End Sub

    Private Sub mnuXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuXoa.Click
        Xoa(FormID)
    End Sub

    Private Sub ThemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ThemMoi(FormID)
    End Sub

    Private Sub SuaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SuaChua(FormID)
    End Sub

    Private Sub XoaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Xoa(FormID)
    End Sub

    Private Sub TimKiemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case FormID
            Case 1  'Nhan vien
                frmTimKiemNhanVien.ShowDialog()
                frmTimKiemNhanVien.ShowInTaskbar = False
            Case 2  'Hoa don mua hang
                frmTimKiemHoaDonMuaHang.ShowDialog()
                frmTimKiemHoaDonMuaHang.ShowInTaskbar = False
            Case 3  ' Nhap kho
                frmTimKiemPhieuNhapKho.ShowDialog()
                frmTimKiemPhieuNhapKho.ShowInTaskbar = False
            Case 4  ' Tra tien nha cung cap
                frmTimKiemPhieuChi.ShowDialog()
                frmTimKiemPhieuChi.ShowInTaskbar = False
            Case 5  'Hoa don ban hang
                frmTimKiemHoaDonBanHang.ShowDialog()
                frmTimKiemHoaDonBanHang.ShowInTaskbar = False
            Case 6  ' xuat kho
                frmTimKiemPhieuXuatKho.ShowDialog()
                frmTimKiemPhieuXuatKho.ShowInTaskbar = False
            Case 7  'Thu tien khach hang
                frmTimKiemPhieuThu.ShowDialog()
                frmTimKiemPhieuThu.ShowInTaskbar = False
            Case 22 'Nha cung cap
                frmTimKiemNhaCC.ShowDialog()
                frmTimKiemNhaCC.ShowInTaskbar = False

            Case 24 ' Khach hang
                frmTimKiemKhachHang.ShowDialog()
                frmTimKiemKhachHang.ShowInTaskbar = False
            Case 27 'Vat tu hang hoa
                frmTimKiemHangHoa.ShowDialog()
                frmTimKiemHangHoa.ShowInTaskbar = False
        End Select
    End Sub

    Private Sub NapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadData(FormID)
    End Sub
End Class