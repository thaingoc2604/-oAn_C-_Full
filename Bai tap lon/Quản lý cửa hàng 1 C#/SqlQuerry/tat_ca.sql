select tblNhaCungCap.MaNCC,tblChiTietHDN.MaMatH,tblNhaCungCap.TenNCC,tblMatHang.TenMatH,tblHoaDonNhap.MaHD,tblMatHang.SoLuong,tblHoaDonNhap.NgayNhap,tblMatHang.DonGia,tblHoaDonNhap.DonViTinh
from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)
	inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)
	inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)
