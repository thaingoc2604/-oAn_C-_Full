Public Class frmBaoCao
    Dim ds As New DataSet
   
    Friend Sub PreviewReport(ByVal strSQL As String, ByVal intReport As Integer)
        ds = objConnect.GetDataSet(strSQL)
        Select Case intReport
            Case 0  'In Bảng kê bán hàng
                Dim rpt As New rptBC_BangKe_BanHang
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 1  'In in bảng kê mua hàng
                Dim rpt As New rptBC_BangKe_MuaHang
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 2  'In Công nợ phải trả nhà cung cấp
                Dim rpt As New rptBC_MuaHang_Theo_NCC
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 3  'In công nợ phải thu khách hàng
                Dim rpt As New rptBC_BanHang_Theo_KhachHang
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 4  'In phiếu nhập kho
                Dim rpt As New rptPhieuNhapKho
                Dim rpt1 As CrystalDecisions.CrystalReports.Engine.ReportDocument = rpt.Subreports(0)
                rpt1.SetDataSource(ds.Tables(1))
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 5  'In Phiếu xuất kho
                Dim rpt As New rptPhieuXuatKho
                Dim rpt1 As CrystalDecisions.CrystalReports.Engine.ReportDocument = rpt.Subreports(0)
                rpt1.SetDataSource(ds.Tables(1))
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 6 'In danh sách hàng hóa
                Dim rpt As New rptHangHoa
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 7  'In Hóa đơn VAT
                Dim rpt As New rptHoaDonVAT
                Dim rpt1 As CrystalDecisions.CrystalReports.Engine.ReportDocument = rpt.Subreports(0)
                rpt1.SetDataSource(ds.Tables(1))
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 8  'In phiếu chi
                Dim rpt As New rptPhieuChi
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 9  'In phiếu thu
                Dim rpt As New rptPhieuThu
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
            Case 10  'In danh sách khách hàng
                Dim rpt As New rptKhachHang
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt

            Case 11  'In danh sách nhà cung cấp
                Dim rpt As New rptNhaCC
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt

            Case 12  'In danh sách nhân viên
                Dim rpt As New rptNhanVien
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt

            Case 13  'In danh sách hàng tồn
                Dim rpt As New rptHangTon
                rpt.SetDataSource(ds.Tables(0))
                rpt.Refresh()
                Me.CrystalReportViewer1.ReportSource = rpt
        End Select
    End Sub

End Class