select * from sys.tables whereexists (select * from sys.tables where name = 'BuoiHoc') and exists (select * from sys.tables where name = 'ThoiKhoaBieu') and exists (select * from sys.tables where name = 'PhongHoc') and exists (select * from sys.tables where name = 'DeNghi') and exists (select * from sys.tables where name = 'Lop') and exists (select * from sys.tables where name = 'PhanCong')and exists (select * from sys.tables where name = 'NguoiDung')and exists (select * from sys.tables where name = 'NganhHoc')and exists (select * from sys.tables where name = 'MonHoc')and exists (select * from sys.tables where name = 'TrinhDo')and exists (select * from sys.tables where name = 'GiangVien')and exists (select * from sys.tables where name = 'SinhVien')