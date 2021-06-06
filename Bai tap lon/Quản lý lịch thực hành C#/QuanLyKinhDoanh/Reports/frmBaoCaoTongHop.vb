Public Class frmBaoCaoTongHop
    Friend intIndex As Integer = 0
    Private Sub frmBaoCaoTongHop_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmBaoCaoTongHop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Tạo nguồn dữ liệu cho listbox
        Me.lstBaoCao.Items.Add("Bảng kê bán hàng")
        Me.lstBaoCao.Items.Add("Bảng kê mua hàng")
        Me.lstBaoCao.Items.Add("Công nợ phải trả nhà cung cấp")
        Me.lstBaoCao.Items.Add("Công nợ phải thu khách hàng")
        Me.lstBaoCao.Items.Add("Nhập kho")
        Me.lstBaoCao.Items.Add("Xuất kho")
        Me.lstBaoCao.Items.Add("Bảng báo giá")
        Me.lstBaoCao.Items.Add("Hóa đơn VAT")
        Me.lstBaoCao.Items.Add("Phiếu chi")
        Me.lstBaoCao.Items.Add("Phiếu thu")
        Me.lstBaoCao.Items.Add("Danh sách khách hàng")
        Me.lstBaoCao.Items.Add("Danh sách nhà cung cấp")
        Me.lstBaoCao.Items.Add("Danh sách nhân viên")
        Me.lstBaoCao.Items.Add("Danh sách hàng tồn")
        Me.lstBaoCao.SelectedIndex = intIndex
        'Tạo ngày mặc định
        Me.mskTuNgay.Text = DateAdd(DateInterval.Month, -1, Now)
        Me.mskDenNgay.Text = Now

    End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnInBC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInBC.Click
        Dim strSQL As String = ""
        If Me.lstBaoCao.SelectedIndex = -1 Then
            frmMsgOK.HienThi("Bạn chưa chọn báo cáo", "Thông báo")
        Else
            Select Case Me.lstBaoCao.SelectedIndex
                Case 0  'In Bảng kê bán hàng
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From BC_BangKe_BanHang Where NgayXK >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayXK <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'"
                        frmBaoCao.PreviewReport(strSQL, 0)
                        frmBaoCao.ShowDialog()
                    End If
                Case 1  'In bảng kê mua hàng
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From BC_BangKe_MuaHang Where NgayNK >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayNK <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'"
                        frmBaoCao.PreviewReport(strSQL, 1)
                        frmBaoCao.ShowDialog()
                    End If
                Case 2  'In Công nợ phải trả nhà cung cấp
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From BC_MuaHang_Theo_NCC Where NgayNK >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayNK <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'"
                        frmBaoCao.PreviewReport(strSQL, 2)
                        frmBaoCao.ShowDialog()
                    End If
                Case 3  'In công nợ phải thu khách hàng
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From BC_BanHang_Theo_KhachHang Where NgayXK >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayXK <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'"
                        frmBaoCao.PreviewReport(strSQL, 3)
                        frmBaoCao.ShowDialog()
                    End If
                Case 4  'In Phiếu nhập kho
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From view_PhieuNhapKho Where NgayNK >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayNK <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'" & "; Select * From view_CTPhieuNhapKho"
                        frmBaoCao.PreviewReport(strSQL, 4)
                        frmBaoCao.ShowDialog()
                    End If

                Case 5  'In Phiếu xuất kho
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From view_PhieuXuatKho Where NgayXK >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayXK <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'" & "; Select * From view_CTPhieuXuatKho"
                        frmBaoCao.PreviewReport(strSQL, 5)
                        frmBaoCao.ShowDialog()
                    End If

                Case 6  'In báo giá
                    strSQL = "Select * From view_HangHoa"
                    frmBaoCao.PreviewReport(strSQL, 6)
                    frmBaoCao.ShowDialog()

                Case 7  'In Hóa đơn VAT
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From view_KhachHang_HoaDon Where NgayHDBH >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayHDBH <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'" & "; Select * From view_CTHDBanHang "
                        frmBaoCao.PreviewReport(strSQL, 7)
                        frmBaoCao.ShowDialog()
                    End If
                Case 8  'In phiếu chi
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From View_PhieuChi Where NgayPC >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayPC <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'"
                        frmBaoCao.PreviewReport(strSQL, 8) '8 = phiếu chi
                        frmBaoCao.ShowDialog()
                    End If
                Case 9  'In phiếu thu
                    If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
                        frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
                    Else
                        strSQL = "Select * From View_PhieuThu Where NgayPT >='" & NhapLieu.CDateTime(Me.mskTuNgay) & "' And NgayPT <='" & NhapLieu.CDateTime(Me.mskDenNgay) & "'"
                        frmBaoCao.PreviewReport(strSQL, 9) '9 = phiếu chi
                        frmBaoCao.ShowDialog()
                    End If
                Case 10 'In danh sách khách hàng
                    strSQL = "Select * From view_KhachHang"
                    frmBaoCao.PreviewReport(strSQL, 10)
                    frmBaoCao.ShowDialog()
                Case 11 'In danh sách nhà cung cấp
                    strSQL = "Select * From view_NhaCC"
                    frmBaoCao.PreviewReport(strSQL, 11)
                    frmBaoCao.ShowDialog()
                Case 12 'In danh sách nhân viên
                    strSQL = "Select * From view_NhanVien"
                    frmBaoCao.PreviewReport(strSQL, 12) '12=in danh sách nhân viên
                    frmBaoCao.ShowDialog()
                Case 13 'In danh sách hàng tồn
                    strSQL = "Select * From view_HangTon"
                    frmBaoCao.PreviewReport(strSQL, 13) '13=in danh sách hàng tồn
                    frmBaoCao.ShowDialog()
            End Select
        End If
    End Sub
End Class