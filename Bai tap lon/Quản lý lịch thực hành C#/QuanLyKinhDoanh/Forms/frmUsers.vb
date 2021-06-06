Public Class frmUsers
    Dim strMa_Cu As String
    Private Sub frmUsers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    'Phương thức đặt thuộc tính Enabled =True cho các điều khiển nhập liệu
    Private Sub HieuNangDieuKhien()
        Me.txtMaNV.Enabled = True
        Me.txtMatKhau.Enabled = True
        Me.grbCongViec.Enabled = True
        Me.txtMaNV.Focus()
    End Sub

    'Phương thức đặt thuộc tính Enabled =True cho các điều khiển nhập liệu
    Private Sub VoHieuNangDieuKhien()
        Me.txtMaNV.Enabled = False
        Me.txtMatKhau.Enabled = False
        Me.grbCongViec.Enabled = False
    End Sub

    Private Sub ResetValues()
        Me.txtMaNV.Text = ""
        Me.txtMatKhau.Text = ""
        Me.chkNhanSu.Checked = False
        Me.chkKho.Checked = False
        Me.chkMuaHang.Checked = False
        Me.chkBanHang.Checked = False
        Me.chkPhanQuyen.Checked = False
    End Sub

    Private Sub btnThem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Me.btnSua.Enabled = False
        Me.btnXoa.Enabled = False
        Me.btnHuyBo.Enabled = True
        Me.btnLuu.Enabled = True
        Me.btnThem.Enabled = False
        Call ResetValues()
        Call HieuNangDieuKhien()
    End Sub

    Sub LoadData()
        Dim DT As New DataTable
        Dim strSQL As String = "Select NSD,MatKhau,NhanSu,Kho,MuaHang,BanHang,PhanQuyen,Active From sys_NSD Where NSD <>'admin'"
        DT = objConnect.GetDataTable(strSQL)
        Me.DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        For i As Integer = 0 To DT.Rows.Count - 1
            Me.DataGridView.Rows.Add()
            Me.DataGridView.Rows(i).Cells(colMaNV.Index).Value = DT(i)(0)
            Me.DataGridView.Rows(i).Cells(colMatKhau.Index).Value = DT(i)(1)
            Me.DataGridView.Rows(i).Cells(colNhanSu.Index).Value = IIf(DT(i)(2) = 1, True, False)
            Me.DataGridView.Rows(i).Cells(colKho.Index).Value = IIf(DT(i)(3) = 1, True, False)
            Me.DataGridView.Rows(i).Cells(colMuaHang.Index).Value = IIf(DT(i)(4) = 1, True, False)
            Me.DataGridView.Rows(i).Cells(colBanHang.Index).Value = IIf(DT(i)(5) = 1, True, False)
            Me.DataGridView.Rows(i).Cells(colPhanQuyen.Index).Value = IIf(DT(i)(6) = 1, True, False)
        Next
        Me.btnSua.Enabled = False
        Me.btnLuu.Enabled = False
        Me.btnHuyBo.Enabled = False
        If Me.DataGridView.RowCount > 0 Then
            Me.btnXoa.Enabled = True
        Else
            Me.btnXoa.Enabled = False
        End If
    End Sub

    Private Sub frmUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LoadData()
        Call VoHieuNangDieuKhien()
    End Sub

    Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Dim strSQL As String
        If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa đủ", "Thông báo")
        Else
            If objConnect.DaTonTai("Select * From tblNhanVien Where MaNV Like N'" & Me.txtMaNV.Text.Trim & "'") = False Then
                frmMsgOK.HienThi("Nhân viên này không tồn tại trong hệ    thống", "Thông báo")
                Me.txtMaNV.Focus()
            Else
                If objConnect.DaTonTai("Select * From sys_NSD Where NSD Like N'" & Me.txtMaNV.Text.Trim & "' And NSD Not Like N'" & strMa_Cu & "'") = True Then
                    frmMsgOK.HienThi("Người sử dụng này đã tồn tại", "Thông báo")
                    Me.txtMaNV.Focus()
                Else
                    'Thực hiện sửa giá trị mới vào CSDL
                    Dim NhanSu, Kho, MuaHang, BanHang, PhanQuyen As Integer
                    NhanSu = IIf(Me.chkNhanSu.Checked = True, 1, 0)
                    Kho = IIf(Me.chkKho.Checked = True, 1, 0)
                    MuaHang = IIf(Me.chkMuaHang.Checked = True, 1, 0)
                    BanHang = IIf(Me.chkBanHang.Checked = True, 1, 0)
                    PhanQuyen = IIf(Me.chkPhanQuyen.Checked = True, 1, 0)
                    strSQL = "Update sys_NSD Set NSD =N'" & Me.txtMaNV.Text.Trim.ToString & "',MatKhau = N'" & Me.txtMatKhau.Text.Trim.ToString & "',NhanSu=N'" & NhanSu & "',Kho=N'" & Kho & "',Muahang=N'" & MuaHang & "',BanHang=N'" & BanHang & "',PhanQuyen=N'" & PhanQuyen & "' Where NSD like N'" & strMa_Cu & "'"
                    objConnect.RunSQL(strSQL)
                    'Làm mới dữ liệu trên DataGridView
                    Me.DataGridView.Rows.Clear()
                    Call LoadData()
                    Call ResetValues()
                    Me.btnHuyBo.Enabled = False
                    Me.btnSua.Enabled = False
                    Me.btnThem.Enabled = True
                    Call VoHieuNangDieuKhien()
                End If
            End If
        End If
    End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim strSQL As String
        If NhapLieu.ChuaDuThongTin("NN", ErrorProvider) = True Then
            frmMsgOK.HienThi("Thông tin bạn nhập vào chưa đủ", "Thông báo")
        Else
            If objConnect.DaTonTai("Select * From tblNhanVien Where MaNV Like N'" & Me.txtMaNV.Text.Trim & "'") = False Then
                frmMsgOK.HienThi("Nhân viên này không tồn tại trong hệ     thống", "Thông báo")
                Me.txtMaNV.Focus()
            Else
                If objConnect.DaTonTai("Select * From sys_NSD Where NSD Like N'" & Me.txtMaNV.Text.Trim & "'") = True Then
                    frmMsgOK.HienThi("Người sử dụng này đã tồn tại", "Thông báo")
                    Me.txtMaNV.Focus()
                Else
                    'Thực hiện sửa giá trị mới vào CSDL
                    Dim NhanSu, Kho, MuaHang, BanHang, PhanQuyen As Integer
                    NhanSu = IIf(Me.chkNhanSu.Checked = True, 1, 0)
                    Kho = IIf(Me.chkKho.Checked = True, 1, 0)
                    MuaHang = IIf(Me.chkMuaHang.Checked = True, 1, 0)
                    BanHang = IIf(Me.chkBanHang.Checked = True, 1, 0)
                    PhanQuyen = IIf(Me.chkPhanQuyen.Checked = True, 1, 0)
                    strSQL = "Insert into  sys_NSD (NSD,MatKhau,NhanSu,Kho,MuaHang,BanHang,PhanQuyen) Values (N'" & Me.txtMaNV.Text.Trim & "',N'" & Me.txtMatKhau.Text.Trim & "',N'" & NhanSu & "',N'" & Kho & "',N'" & MuaHang & "',N'" & BanHang & "',N'" & PhanQuyen & "')"
                    objConnect.RunSQL(strSQL)
                    'Làm mới dữ liệu trên DataGridView
                    Me.DataGridView.Rows.Clear()
                    Call LoadData()
                    Call HieuNangDieuKhien()
                    Call ResetValues()
                End If
            End If
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If Me.DataGridView.RowCount > 0 Then
            If Me.DataGridView.CurrentRow.Cells(colMaNV.Index).Value = pMaNV Then
                frmMsgOK.HienThi("Nhân viên này đang sử dụng hệ thống", "Thông báo", False)
            Else
                If frmMsgYesNo.HienThi("Bạn có chắc chắn muốn xóa không ?", "Thông báo", False) = Windows.Forms.DialogResult.Yes Then
                    objConnect.RunSQL("Delete From sys_NSD Where NSD=N'" & Me.DataGridView.CurrentRow.Cells(colMaNV.Index).Value & "'")
                    Call LoadData()
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.Click
        If Me.btnThem.Enabled = True And Me.DataGridView.RowCount > 0 Then
            strMa_Cu = Me.DataGridView.CurrentRow.Cells(colMaNV.Index).Value
            Me.txtMaNV.Text = Me.DataGridView.CurrentRow.Cells(colMaNV.Index).Value
            Me.txtMatKhau.Text = Me.DataGridView.CurrentRow.Cells(colMatKhau.Index).Value
            Me.chkNhanSu.Checked = Me.DataGridView.CurrentRow.Cells(colNhanSu.Index).Value
            Me.chkKho.Checked = Me.DataGridView.CurrentRow.Cells(colKho.Index).Value
            Me.chkMuaHang.Checked = Me.DataGridView.CurrentRow.Cells(colMuaHang.Index).Value
            Me.chkBanHang.Checked = Me.DataGridView.CurrentRow.Cells(colBanHang.Index).Value
            Me.chkPhanQuyen.Checked = Me.DataGridView.CurrentRow.Cells(colPhanQuyen.Index).Value
            Me.btnThem.Enabled = False
            'Hiện nút sửa
            Me.btnSua.Enabled = True
            Me.btnHuyBo.Enabled = True
            Call HieuNangDieuKhien()
        End If
    End Sub

    Private Sub btnHuyBo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHuyBo.Click
        Call ResetValues()
        Me.btnHuyBo.Enabled = False
        Me.btnThem.Enabled = True
        If DataGridView.RowCount > 0 Then
            Me.btnXoa.Enabled = True
        Else
            Me.btnXoa.Enabled = False
        End If
        Me.btnSua.Enabled = False
        Me.btnLuu.Enabled = False
        Call VoHieuNangDieuKhien()
        NhapLieu.RemoveErrorProvider("NN", ErrorProvider)   'Ẩn điều khiển Errprovider nếu vẫn xuất hiện trên điều khiển nhập liệu
    End Sub
End Class