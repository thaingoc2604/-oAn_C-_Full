Public Class frmSuaHoaDonMuaHang
    Dim MaHDM_Cu As String = ""
    Dim NSD_Xoa_Dong As String = "" 'Danh sách bản ghi bị người dùng xóa
    Private Sub btnThemNhaCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemNhaCC.Click
        pThem = True
        frmNhaCC.ShowDialog()
        frmNhaCC.ShowInTaskbar = False
    End Sub
    Private Sub txtPhiVanChuyen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhiVanChuyen.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) < 1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.ColumnIndex = colXoa.Index And e.RowIndex <> Me.DataGridView.RowCount - 1 Then
            If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                If Me.DataGridView.CurrentRow.Cells(colIDR.Index).Value > 0 Then
                    NSD_Xoa_Dong &= Me.DataGridView.CurrentRow.Cells(colIDR.Index).Value & ","
                    objConnect.RunSQL("Update tblChiTietHoaDonMuaHang Set Dangxoa ='True'")
                End If
                Me.DataGridView.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
   

    Private Sub DataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        Dim dg, ck, thue As Double
        Dim sl As Long
        If NhapLieu.DemChuoiCon(Me.DataGridView, 0, Me.DataGridView.CurrentRow.Cells(0).Value) > 1 Then
            Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value = Nothing
            Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value = Nothing
        Else
            'Kiểm tra giá trị tại cột số lượng
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value) Then
                Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value <= 0 Then
                    Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = ""
                Else
                    Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value = Int(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value)
                End If
            End If
            'Kiểm tra giá trị tại cột chiết khấu
            If Not IsNumeric(Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value) Then
                Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value = ""
            Else
                If Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value > 100 Or Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value < 0 Then
                    Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value = ""
                End If
            End If

            'Cập nhật đơn giá bán tự động
            If Len(Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value) > 0 Then
                Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value = objConnect.GetFieldValue("Select tblHangHoa.DGBan From tblHangHoa Where MaH = N'" & Me.DataGridView.CurrentRow.Cells(colMaH.Index).Value & "'")
            End If

            'Tính cột thành tiền
            dg = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value), Me.DataGridView.CurrentRow.Cells(colDGNhap.Index).Value, 0)
            sl = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value), Me.DataGridView.CurrentRow.Cells(colSoLuong.Index).Value, 0)
            ck = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value), Me.DataGridView.CurrentRow.Cells(colChietKhau.Index).Value, 0)
            thue = IIf(IsNumeric(Me.DataGridView.CurrentRow.Cells(colThue.Index).Value), Me.DataGridView.CurrentRow.Cells(colThue.Index).Value, 0)
            Me.DataGridView.CurrentRow.Cells(colThanhTien.Index).Value = FormatNumber(((dg * sl) * (1 + thue / 100 - ck / 100)), 2)
        End If

        
    End Sub

    Private Sub frmSuaHoaDonMuaHang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMainX.LoadData(2)
        objConnect.RunSQL("Update tblChiTietHoaDonMuaHang Set Dangxoa ='False'")
    End Sub

    Private Sub frmSuaHoaDonMuaHang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        'Me.txtNhanVien.Text = pTenNV
        'objConnect.SetDataCombobox(Me.cboNhaCC, "Select MaNCC,TenNCC From tblNhaCC Order by TenNCC")
        objConnect.SetDataComboboxInDataGridView(Me.colMaH, "Select MaH,TenH From tblHangHoa Order by TenH")
        
    End Sub

    'Phương thức xóa dữ liệu trên form
    Private Sub ResetValues()
        Me.txtMaHD.Text = ""
        Me.mskNgayHD.Text = ""
        Me.cboNhaCC.SelectedIndex = -1
        Me.mskNgayGiaoHang.Text = ""
        Me.mskHanThanhToan.Text = ""
        Me.txtPhiVanChuyen.Text = ""
        'Xóa dữ liệu trên gridview
        Me.DataGridView.Rows.Clear()
        'Xóa báo lỗi nếu có
        NhapLieu.RemoveErrorProvider("NN", Me.ErrorProvider)
        Me.mskNgayHD.Focus()
    End Sub

    Private Function BanGhiHopLe() As Boolean
        Dim d As Integer = 0
        Dim N As Boolean
        Dim strMaH, fltDonGia, intSoLuong As String
        For i As Integer = 0 To Me.DataGridView.RowCount - 2
            strMaH = Trim(Me.DataGridView.Rows(i).Cells(colMaH.Index).Value)
            fltDonGia = Trim(Me.DataGridView.Rows(i).Cells(colDGNhap.Index).Value)
            intSoLuong = Trim(Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value)
            If (strMaH <> "" And fltDonGia <> "" And intSoLuong <> "") Then
                d += 1
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = ""
            Else
                Me.DataGridView.Rows.Item(i).HeaderCell.Value = "Lỗi nhập liệu ! bạn phải nhập tên hàng, đơn giá và số lượng"
                N = True
            End If
        Next
        If (d < 1 Or N = True) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim IDR As Long
        Dim MaHDM As String
        Dim MaH As String
        Dim ChietKhau As Double
        Dim SoLuong As Long
        Dim DonGia As Double
        Dim blnSua As Boolean
        If NhapLieu.ChuaDuThongTin("NN", Me.ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa hợp lệ", "Thông báo")
        Else
            If BanGhiHopLe() = False Then
                frmMsgOK.HienThi("Bạn chưa nhập đủ thông tin cho phần chi tiết hóa đơn mua hàng", "Thông báo")
            Else
                For i As Integer = 0 To Me.DataGridView.RowCount - 2 'đếm từ 0 và trừ dòng trắng ở cuối
                    blnSua = IIf(Me.DataGridView.Rows(i).Cells(colIDR.Index).Value < 1, False, True)
                    MaHDM = Me.txtMaHD.Text.Trim
                    MaH = Me.DataGridView.Rows(i).Cells(colMaH.Index).Value
                    SoLuong = Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value
                    DonGia = Me.DataGridView.Rows(i).Cells(colDGNhap.Index).Value
                    Try
                        ChietKhau = IIf(Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value = "", 0, Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value)
                    Catch ex As Exception
                    End Try
                    IDR = Me.DataGridView.Rows(i).Cells(colIDR.Index).Value
                    Call Save(MaHDM, MaH, ChietKhau, SoLuong, DonGia, IDR, blnSua)

                Next
                If NSD_Xoa_Dong.Trim <> "" Then
                    'Thực hiện xóa các dòng trong do người dùng thực hiện xóa 
                    NSD_Xoa_Dong = Strings.Left(NSD_Xoa_Dong, Len(NSD_Xoa_Dong) - 1)
                    Dim strDelete As String = "Delete From tblChiTietHoaDonMuaHang Where IDR in (" & NSD_Xoa_Dong & ")"
                    objConnect.RunSQL(strDelete)
                End If
                frmMainX.LoadData(2)
                'Đóng form sửa
                frmMsgOK.HienThi("Sửa thành công", "Thông báo")
                Me.Dispose()
            End If
        End If
    End Sub
    'Phương thức này dùng để lưu giá trị vào CSDL
    Sub Save(ByVal MaHDM As String, ByVal MaH As String, ByVal ChietKhau As Double, ByVal SoLuong As Long, ByVal DonGia As Double, ByVal IDR As Long, ByVal blnSua As Boolean)
        Dim strUpdate_HDM As String = "Update tblHoaDonMuaHang Set MaHDMH=N'" & Me.txtMaHD.Text.Trim & "',"
        strUpdate_HDM &= "NgayHDMH=N'" & NhapLieu.CDateTime(Me.mskNgayHD) & "',"
        strUpdate_HDM &= "MaNV = N'" & pMaNV & "',MaNCC=N'" & Me.cboNhaCC.SelectedValue & "',"
        strUpdate_HDM &= "NgayGiaoHang=N'" & NhapLieu.CDateTime(mskNgayGiaoHang) & "',"
        strUpdate_HDM &= "HanThanhToan=N'" & NhapLieu.CDateTime(mskHanThanhToan) & "',"
        strUpdate_HDM &= "PhiVanChuyen=N'" & Me.txtPhiVanChuyen.Text.Trim & "' "
        strUpdate_HDM &= "Where MaHDMH =N'" & MaHDM_Cu & "'"

        Dim strInsertCT_HDM As String = "Insert into tblChiTietHoaDonMuaHang(MaHDMH,MaH,GiamGia,DonGia,SoLuong) Values(N'" & Me.txtMaHD.Text.Trim & "',N'" & MaH & "',N'" & ChietKhau & "',N'" & DonGia & "',N'" & SoLuong & "')"
        Dim strUpdateCT_HDM As String = "Update tblChiTietHoaDonMuaHang Set MaHDMH=N'" & Me.txtMaHD.Text.Trim & "',MaH=N'" & MaH & "',GiamGia=N'" & ChietKhau & "',SoLuong=N'" & SoLuong & "',DonGia=N'" & DonGia & "' Where IDR=N'" & IDR & "'"
        objConnect.RunSQL(strUpdate_HDM)
        If blnSua = True Then
            objConnect.RunSQL(strUpdateCT_HDM)
        Else
            objConnect.RunSQL(strInsertCT_HDM)
        End If
    End Sub

    Friend Sub LoadData(ByVal MaHDM As String)
        Dim tblHDM As New DataTable
        Dim tblCTHDM As New DataTable
        Dim strSQL_HDM As String = "Select HD.MaHDMH,HD.NgayHDMH,HD.MaNCC,NV.HoTen,HD.NgayGiaoHang,HD.HanThanhToan,HD.PhiVanChuyen From tblHoaDonMuaHang AS HD,tblNhanVien as NV Where HD.MaNV=NV.MaNV And MaHDMH=N'" & MaHDM & "'"
        Dim strSql_CTHDM As String = "Select MaH,DonGia,SoLuong,GiamGia,ThueNhap,([DonGia]*[SoLuong])*(1+ThueNhap*0.01-GiamGia*0.01) As ThanhTien,IDR From tblChiTietHoaDonMuaHang Where MaHDMH=N'" & MaHDM & "'"
        'đổ dữ liệu vào tblPNK
        tblHDM = objConnect.GetDataTable(strSQL_HDM)
        'Đổ dữ liệu vào tblChiTietHoaDonMua
        tblCTHDM = objConnect.GetDataTable(strSql_CTHDM)
        'Lưu giá trị cũ của phiếu nhập kho để làm điều kiện Update
        MaHDM_Cu = tblHDM.Rows(0).Item(0)
        'Đổ dữ liệu lên form phần master
        Me.txtMaHD.Text = tblHDM.Rows(0).Item(0)           'Mã HDMH
        Me.mskNgayHD.Text = tblHDM.Rows(0).Item(1)
        Me.cboNhaCC.SelectedValue = tblHDM.Rows(0).Item(2)
        Me.txtNhanVien.Text = tblHDM.Rows(0).Item(3)
        Me.mskNgayGiaoHang.Text = tblHDM.Rows(0).Item(4)
        Me.mskHanThanhToan.Text = tblHDM.Rows(0).Item(5)
        Me.txtPhiVanChuyen.Text = tblHDM.Rows(0).Item(6)
        'Đổ dữ liệu lên form phần chi tiết
        For i As Integer = 0 To tblCTHDM.Rows.Count - 1
            Me.DataGridView.Rows.Add()
            Me.DataGridView.Rows(i).Cells(colMaH.Index).Value = tblCTHDM(i)(0)
            Me.DataGridView.Rows(i).Cells(colDGNhap.Index).Value = tblCTHDM(i)(1)
            Me.DataGridView.Rows(i).Cells(colSoLuong.Index).Value = tblCTHDM(i)(2)
            Me.DataGridView.Rows(i).Cells(colChietKhau.Index).Value = tblCTHDM(i)(3)
            Me.DataGridView.Rows(i).Cells(colThue.Index).Value = tblCTHDM(i)(4)
            Me.DataGridView.Rows(i).Cells(colThanhTien.Index).Value = tblCTHDM(i)(5)
            Me.DataGridView.Rows(i).Cells(colIDR.Index).Value = tblCTHDM(i)(6)
        Next
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Me.Dispose()
    End Sub
End Class