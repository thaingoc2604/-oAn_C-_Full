use  dbEvents
GO
-------------- Khoi tao database
if exists
(
    select name from sysobjects
    where name = 'Init_Database' and type = 'p'
)
begin
 drop proc Init_Database
end;
GO
create proc Init_Database
as
BEGIN
	DECLARE @Sql NVARCHAR(500) DECLARE @Cursor CURSOR
	SET @Cursor = CURSOR FAST_FORWARD FOR
	SELECT DISTINCT sql = 'ALTER TABLE [' + tc2.TABLE_NAME + '] DROP [' + rc1.CONSTRAINT_NAME + ']'
	FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc1
	LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc2 ON tc2.CONSTRAINT_NAME =rc1.CONSTRAINT_NAME
	OPEN @Cursor FETCH NEXT FROM @Cursor INTO @Sql
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
	Exec SP_EXECUTESQL @Sql
	FETCH NEXT FROM @Cursor INTO @Sql
	END
	CLOSE @Cursor DEALLOCATE @Cursor
	EXEC sp_MSForEachTable 'DROP TABLE ?'
END
GO
EXEC Init_Database
------------------------------------------------------
GO
----------------------------------------------------------
use dbEvents

--1 bang chuong trinh
create table ChuongTrinh
(
	MaCT varchar(5) not null,
	TenCT nvarchar(50) not null,
	MoTaCT nvarchar(100) null,
	constraint PK_ChuongTrinh primary key(MaCT),
	constraint TenCT_Like check (MaCT like 'CT[0-9][0-9][0-9]')
)
go

--2 bang nhan vien
create table NhanVien
(
	MaNV varchar(5) not null,
	TenNV nvarchar(50) not null,
	GioiTinh bit null default(0),
	NgaySinh date null,
	DiaChi nvarchar(100) null,
	DienThoai varchar(20) null,
	Email varchar(50) null,
	HeSoLuong float default(2.34) not null,
	constraint PK_NhanVien primary key(MaNV),
	constraint MaNV_Like check (MaNV like 'NV[0-9][0-9][0-9]') 
)
go

--3 bang khach hang
create table KhachHang
(
	MaKH varchar(8) not null,
	TenKH nvarchar(50) not null,
	DiaChi nvarchar(100) null,
	DienThoai varchar(20) null,
	Email varchar(50) null,
	constraint PK_KhachHang primary key(MaKH),
	constraint MaKH_Like check (MaKH like 'KH[0-9][0-9][0-9][0-9][0-9][0-9]')
)
go

--4 bang chi tiet chuong trinh
create table ChiTietCT
(
	ID int identity(1,1) not null,
	MaKH varchar(8) not null,
	MaCT varchar(5) not null,
	MaNV varchar(5) not null,
	NgayBatDau smalldatetime not null,
	NgayKetThuc smalldatetime not null,
	MoTa nvarchar(100) null,
	SoNguoiThamGia int null,
	DiaDiem nvarchar(100) null,
	MucPhat int default(0) not null,
	constraint PK_ChiTietCT primary key(ID),
	constraint MaKH_Like_ChiTietCT check (MaKH like 'KH[0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint TenCT_Like_ChiTietCT check (MaCT like 'CT[0-9][0-9][0-9]'),
	constraint MaNV_Like_ChiTietCT check (MaNV like 'NV[0-9][0-9][0-9]')
)
go

--5 bang ke hoach chi tra
create table KeHoachChiTra
(
	IdCTCT int not null,
	GiaiDoan tinyint not null,
	Phi int not null,
	MoTaPhi nvarchar(100) null,
	PhuongThucTT nvarchar(50) default(N'Tiền mặt') null,
	NgayTTTheoKH smalldatetime not null,
	NgayThatSuTT smalldatetime null,
	constraint PK_KeHoachChiTra primary key(IdCTCT, GiaiDoan),
)
go

--6 bang PhiPhat
create table PhiPhat
(
	IdCTCT int not null,
	GiaiDoan tinyint not null,
	PhiPhat int not null,
	constraint PK_PhiPhat primary key(IdCTCT, GiaiDoan)
)

--7 bang nguoi dung va phan quyen cho nguoi dung
create table NguoiDung
(
	Username varchar(20)  primary key,
	Password varchar(35) not null,
	TenNguoiDung nvarchar(30),
	Quyen tinyint default(0) not null ,
	MoTaQuyen nvarchar(50)
)

--khoa ngoai
alter table ChiTietCT add constraint FK_ChiTietCT_KhachHang
	foreign key(MaKH) references KhachHang(MaKH)
go
	
alter table ChiTietCT add constraint FK_ChiTietCT_ChuongTrinh
	foreign key(MaCT) references ChuongTrinh(MaCT)
go
	
alter table ChiTietCT add constraint FK_ChiTietCT_NhanVien
	foreign key(MaNV) references NhanVien(MaNV)
go

alter table KeHoachChiTra add constraint FK_KeHoachChiTra_ChiTietCT
	foreign key(IdCTCT) references ChiTietCT(ID)
go

--Function chuyển có dấu thành không dấu
GO
if exists
(
    select name from sysobjects
    where name = 'fnChuyenKhongDau' and type = 'fn'
)
begin
 drop function fnChuyenKhongDau
end;
GO
CREATE FUNCTION dbo.fnChuyenKhongDau(@strInput NVARCHAR(50)) 
RETURNS NVARCHAR(50)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(50)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS =     N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
GO

--function
--1 function tinh tong no cua 1 khach hang
create function fc_TongNo (@maKH varchar(8))
returns int
as
	begin
		declare @no int
		set @no = (select sum(Phi)
			   from KeHoachChiTra k join ChiTietCT c on k.IdCTCT = c.ID
			   where MaKH = @maKH and NgayThatSuTT is null
			  )
		if(@no is null)
			set @no = 0
		return @no
	end
go

--2 function tinh tong phi chua thanh toan cua 1 chi tiet chuong trinh
create function fc_TongPhiChuaThanhToan (@IdCTCT int)
returns int
as
	begin
		declare @kq int
		set @kq = (select sum(Phi)
				   from KeHoachChiTra
				   where IdCTCT = @IdCTCT and NgayThatSuTT is null)
		return @kq
	end
go

--3 function tinh tong chi phi cua khach hang
create function fc_TongPhi (@maKH varchar(8))
returns int
as
	begin
		declare @phi int
		set @phi = (select sum(Phi)
					from KhachHang k left join ChiTietCT ctct on k.MaKH = ctct.MaKH
						 left join KeHoachChiTra khct on ctct.ID = khct.IdCTCT
					where k.MaKH = @maKH)
		if(@phi is null)
			set @phi = 0
		return @phi
	end
go

--4 function dem so lan bi phat cua 1 khach hang
create function fc_demSoLanPhat (@maKH varchar(8))
returns int
as
	begin
		declare @kq int
		set @kq = (select count(*) from (select MaKH from KhachHang) as kh
							left join (select ID, MaKH from ChiTietCT) as ct on kh.MaKH = ct.MaKH
							left join (select * from PhiPhat) as p on ct.ID = p.IdCTCT
							where kh.MaKH = @maKH and PhiPhat is not null)
		if(@kq is null)
			set @kq = 0
		return @kq
	end
go

--5 function truy van thong tin tat ca cac hop dong theo ma khach hang
create function fc_thongTinHD (@maKH varchar(8))
returns table
as
		return
			(select ct.ID,k.TenKH,c.TenCT,n.TenNV,ct.NgayBatDau,ct.NgayKetThuc,ct.MoTa,ct.SoNguoiThamGia,ct.DiaDiem,ct.MucPhat
			from ChiTietCT ct 
				left join KhachHang k on ct.MaKH=k.MaKH
				left join NhanVien n on ct.MaNV=n.MaNV
				left join ChuongTrinh c on ct.MaCT=c.MaCT
			where ct.MaKH = @maKH
			)
go

--6 function xep loai khach hang
create function fc_XepLoaiKH (@maKH varchar(8), @soCTDky int)
returns nvarchar(10)
as
	begin
		declare @tongPhi int, @soLanTreHan int, @tongNo int, @tiLeNo float, @hopDongNhoNhat int;
		set @tongPhi = dbo.fc_TongPhi(@maKH);
		set @soLanTreHan = dbo.fc_demSoLanPhat(@maKH);
		set @tongNo = dbo.fc_TongNo(@maKH);
		set @hopDongNhoNhat = (select min (giaTri)
							   from (select SUM(Phi) as giaTri
									from KeHoachChiTra k, ChiTietCT c
									where k.IdCTCT =c.ID and c.MaKH = @maKH
									group by k.IdCTCT)as tam)
		if(@soCTDky >= 3 and @hopDongNhoNhat >= 5000000 and @soLanTreHan <= 3)
			return N'VIP';
		if(@tongPhi >= 60000000 and @soLanTreHan <= 3)
			return N'VIP';
		if(@soCTDky >= 3 and @hopDongNhoNhat >= 3000000 and @soLanTreHan <= 5)
			return N'Thân thiết';
		if(@tongPhi >= 40000000 and @soLanTreHan <= 5)
			return N'Thân thiết';
		if(@soCTDky >= 3 and @tongPhi >= 20000000 and @soLanTreHan <= 5)
			return N'Tiềm năng';
		if(@soCTDky = 1 and @hopDongNhoNhat >= 10000000 and @soLanTreHan < 1)
			return N'Tiềm năng';
		if(@soLanTreHan >= 10)
			return N'Nợ xấu';
		if(@tiLeNo >= 0.50)
			return N'Nợ xấu';
		return N'Thường'
	end
go

--view
--1 view xem thong tin chi tiet cua khach hang
create view view_ThongTinKH
as
	select kh.MaKH, kh.TenKH, COUNT(ctct.ID) as SoCTDky
		   ,dbo.fc_TongPhi(kh.MaKH) as TongPhi
		   ,dbo.fc_demSoLanPhat(kh.MaKH) as SoLanTreHan
		   ,dbo.fc_TongNo(kh.MaKH) as TongNo
		   ,dbo.fc_XepLoaiKH(kh.MaKH, COUNT(ctct.ID)) as XepLoai
		   ,kh.DienThoai,kh.Email,kh.DiaChi
	from KhachHang kh left join ChiTietCT ctct on kh.MaKH = ctct.MaKH
	group by kh.MaKH , kh.TenKH, kh.DienThoai, kh.Email,kh.DiaChi
go

--2 view thong tin nhan vien
create view view_ThongTinNV
as
	select nv.MaNV, nv.TenNV, COUNT(ct.ID) as SoCTDky
	from NhanVien nv, ChiTietCT ct
	where nv.MaNV = ct.MaNV
	group by nv.MaNV, nv.TenNV
go

--trigger
--1 trigger tinh toan thanh toan co tre han ko. neu co thi insert vao bang phi phat
create trigger tg_KeHoachChiTra_insert
on KeHoachChiTra
for insert
as
	begin
		declare @id int
		set @id = (select IdCTCT from inserted)
		if((select NgayTTTheoKH from inserted) >= (select NgayBatDau from ChiTietCT where ID = @id))
			begin
				rollback
				raiserror(N'Ngày thanh toán theo kế hoạch phải trước ngày tổ chức chương trình', 16, 1)
			end
		else
			begin
				if (not((select NgayThatSuTT from inserted) is null))
					begin
						declare @soNgayQuaHan int
						set @soNgayQuaHan = datediff(day,(select NgayTTTheoKH from inserted)
														, (select NgayThatSuTT from inserted))
						if (@soNgayQuaHan > 0)--thanh toan tre han
							begin
								declare @giaiDoan tinyint, @phiPhat int, @mucPhat int
								set @giaiDoan = (select GiaiDoan from inserted)
								set @mucPhat = (select MucPhat from ChiTietCT where ID = @id)
								set @phiPhat = @mucPhat * @soNgayQuaHan
								insert into PhiPhat(IdCTCT, GiaiDoan, PhiPhat)
										values(@id, @giaiDoan, @phiPhat)
							end
					end
			end
	end
go

--2 trigger ko cho cap nhat cac cot Phi, NgayTTTheoKH, NgayThatSuTT
--		va cap nhat PhiPhat
create trigger tg_KeHoachChiTra_update
on KeHoachChiTra
for update
as
	begin
		if((select NgayTTTheoKH from inserted)<>(select NgayTTTheoKH from deleted)
			or (select Phi from inserted)<>(select Phi from deleted))
			begin
				rollback
				raiserror(N'Bạn không thể thay đổi thuộc tính NgayTTTheoKH và/hoặc Phi', 16, 1)
			end
		else
			begin
				declare @soNgayQuaHan int, @id int, @giaiDoan tinyint
				set @id = (select IdCTCT from deleted)
				set @giaiDoan = (select GiaiDoan from deleted)
				set @soNgayQuaHan = datediff(day,(select NgayTTTheoKH from KeHoachChiTra 
													where IdCTCT = @id and GiaiDoan = @giaiDoan)
												,(select NgayThatSuTT from inserted))
				if (@soNgayQuaHan > 0)--thanh toan tre han
					begin
						declare @phiPhat int, @mucPhat int
						set @mucPhat = (select MucPhat from ChiTietCT where ID = @id)
						set @phiPhat = @mucPhat * @soNgayQuaHan
						--if chua co trong bang phi phat thi insert vao bang phi phat
						if(not exists(select * from PhiPhat where IdCTCT = @id and GiaiDoan = @giaiDoan))
							begin
								insert into PhiPhat(IdCTCT, GiaiDoan, PhiPhat)
										values(@id, @giaiDoan, @phiPhat)
							end
						else--if đã có rồi thì update lại
							begin
								update PhiPhat set PhiPhat = @phiPhat 
								where IdCTCT = @id and GiaiDoan = @giaiDoan
							end
					end
				else--thanh toan dung han
					begin
						--đã có trong bảng Phí Phạt thì xóa
						if(exists(select * from PhiPhat where IdCTCT = @id and GiaiDoan = @giaiDoan))
							begin
								delete from PhiPhat where IdCTCT = @id and GiaiDoan = @giaiDoan 
							end
					end
			end
	end
go

--3 trigger update nguoi dung khi update nhan vien
create trigger tg_NhanVien_update
	on NhanVien
	for update
	as
		begin
			declare @maNV varchar(5), @tenNV nvarchar(50)
			set @maNV=(select MaNV from inserted)
			set @tenNV=(select TenNV from inserted)
			update NguoiDung set TenNguoiDung = @tenNV where Username = @maNV
		end
go

--4 trigger update nguoi dung khi update khach hang
create trigger tg_KhachHang_update
	on KhachHang
	for update
	as
		begin
			declare @maKH varchar(8), @tenKH nvarchar(50)
			set @maKH=(select MaKH from inserted)
			set @tenKH=(select TenKH from inserted)
			update NguoiDung set TenNguoiDung = @tenKH where Username = @maKH
		end
go

--5 trigger xoa nguoi dung khi xoa nhan vien
create trigger tg_NhanVien_delete
	on NhanVien
	for delete
	as
		begin
			declare @maNV varchar(5)
			set @maNV=(select MaNV from deleted)
			delete from NguoiDung where Username = @maNV
			if(@@error<>0)
				begin
					rollback tran
					return
				end
		end
go

--6 trigger xoa nguoi dung khi xoa khach hang
create trigger tg_KhachHang_delete
	on KhachHang
	for delete
	as
		begin
			declare @maKH varchar(8)
			set @maKH=(select MaKH from deleted)
			delete from NguoiDung where Username = @maKH
			if(@@error<>0)
				begin
					rollback tran
					return
				end
		end
go

--procedure

--1 proc them chuong trinh
create proc sp_themChuongTrinh 
	@MaCT		varchar(5),
	@TenCT		nvarchar(50),
	@MoTa		nvarchar(100) = null
as
	set xact_abort on
	begin tran
		begin try
			if (not exists(select MaCT from ChuongTrinh where MaCT = @MaCT))
				begin
					insert into ChuongTrinh(MaCT, TenCT, MoTaCT) 
					values(@MaCT, @TenCT, @MoTa)
				end
			else
				begin
					RAISERROR('Không thể thêm chương trình này vì mã chương trình này đã có.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
			return -1
		end catch
go

--2 proc sua chuong trinh
create proc sp_suaChuongTrinh
	@MaCT		varchar(5),
	@TenCT		nvarchar(50),
	@MoTa		nvarchar(100)
as
	set xact_abort on
	begin tran
		begin try
			if (exists(select MaCT from ChuongTrinh where MaCT = @MaCT))
				begin
					update ChuongTrinh set TenCT = @TenCT, MoTaCT = @MoTa 
					where MaCT = @MaCT
				end
			else
				begin
					RAISERROR('Không thể cập nhật vì chương trình này chưa tồn tại.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--3 proc xoa chuong trinh
create proc sp_xoaChuongTrinh
	@MaCT		varchar(5)
as
	set xact_abort on
	begin tran
		begin try
			if (exists(select MaCT from ChuongTrinh where MaCT = @MaCT))
				begin
					delete from ChuongTrinh where MaCT = @MaCT
				end
			else
				begin
					RAISERROR('Xóa không thành công vì chương trình này không tồn tại.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--4 proc them khach hang
create proc sp_themKhachHang
	@MaKH		varchar(8),
	@TenKH		nvarchar(50),
	@DiaChi		nvarchar(100) = null,
	@DienThoai	varchar(20) = null,
	@Email		varchar(50) = null
as
	set xact_abort on
	begin tran
		begin try
			if(not exists(select MaKH from KhachHang where MaKH = @MaKH))
				begin
					insert into KhachHang(MaKH, TenKH, DiaChi, DienThoai, Email)
					values(@MaKH, @TenKH, @DiaChi, @DienThoai, @Email)
				end
			else
				begin
					RAISERROR('Không thể thêm khách hàng này vì mã khách hàng này đã có.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--5 proc sua khach hang
create proc sp_suaKhachHang
	@MaKH		varchar(8),
	@TenKH		nvarchar(50),
	@DiaChi		nvarchar(100),
	@DienThoai	varchar(20),
	@Email		varchar(50)
as
	set xact_abort on
	begin tran
		begin try
			if (exists(select MaKH from KhachHang where MaKH = @MaKH))
				begin
					update KhachHang set TenKH = @TenKH, DiaChi = @DiaChi, DienThoai = @DienThoai, Email = @Email
					where MaKH = @MaKH
				end
			else
				begin
					RAISERROR('Không thể cập nhật vì khách hàng này chưa tồn tại.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--6 proc xoa khach hang
create proc sp_xoaKhachHang
	@MaKH		varchar(5)
as
	set xact_abort on
	begin tran
		begin try
			if (exists(select MaKH from KhachHang where MaKH = @MaKH))
				begin
					delete from KhachHang where MaKH = @MaKH
				end
			else
				begin
					RAISERROR('Xóa không thành công vì khách hàng này không tồn tại.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--7 proc them nhan vien
create proc sp_themNhanVien
	@MaNV		varchar(5),
	@TenNV		nvarchar(50),
	@GioiTinh	bit = 0,
	@NgaySinh	date = null,
	@DiaChi		nvarchar(100) = null,
	@DienThoai	varchar(20) = null,
	@Email		varchar(50) = null,
	@HeSoLuong	float = 2.34
as
	set xact_abort on
	begin tran
		begin try
			if(not exists(select MaNV from NhanVien where MaNV = @MaNV))
				begin
					insert into NhanVien(MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, DienThoai, Email, HeSoLuong)
					values(@MaNV, @TenNV, @GioiTinh, @NgaySinh, @DiaChi, @DienThoai, @Email, @HeSoLuong)
				end
			else
				begin
					RAISERROR('Không thể thêm nhân viên này vì mã nhân viên này đã có.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--8 proc sua nhan vien
create proc sp_suaNhanVien
	@MaNV		varchar(5),
	@TenNV		nvarchar(50),
	@GioiTinh	bit,
	@NgaySinh	date,
	@DiaChi		nvarchar(100),
	@DienThoai	varchar(20),
	@Email		varchar(50),
	@HeSoLuong	float
as
	set xact_abort on
	begin tran
		begin try
			if(exists(select MaNV from NhanVien where MaNV = @MaNV))
				begin
					update NhanVien set TenNV = @TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh,
						DiaChi = @DiaChi, DienThoai = @DienThoai, Email = @Email, HeSoLuong = @HeSoLuong
					where MaNV = @MaNV
				end
			else
				begin
					RAISERROR('Không thể cập nhật nhân viên này vì nhân viên này chưa tồn tại.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--9 proc xoa nhan vien
create proc sp_xoaNhanVien
	@MaNV		varchar(5)
as
	set xact_abort on
	begin tran
		begin try
			if(exists(select MaNV from NhanVien where MaNV = @MaNV))
				begin
					delete from NhanVien where MaNV = @MaNV
				end
			else
				begin
					raiserror('Xóa không thành công vì nhân viên này không tồn tại', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--10 proc them chi tiet chuong trinh
create proc sp_themChiTietCT
	@MaKH			varchar(8),
	@MaCT			varchar(5),
	@MaNV			varchar(5),
	@NgayBatDau		smalldatetime,
	@NgayKetThuc	smalldatetime,
	@SoNguoiThamGia	int = null,
	@MucPhat		int = 0,
	@DiaDiem		nvarchar(100) = null,
	@MoTa			nvarchar(100) = null
as
	set xact_abort on
	begin tran
		begin try
			insert into ChiTietCT(MaKH, MaCT, MaNV, NgayBatDau, NgayKetThuc, SoNguoiThamGia, MucPhat, DiaDiem, MoTa)
			values(@MaKH, @MaCT, @MaNV, @NgayBatDau, @NgayKetThuc, @SoNguoiThamGia, @MucPhat, @DiaDiem, @MoTa)
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--11 proc them ke hoach chi tra
create proc sp_themKeHoachChiTra
	@IdCTCT			int,
	@GiaiDoan		tinyint,
	@Phi			int,
	@NgayTTTheoKH	smalldatetime,
	@MoTaPhi		nvarchar(100) = null,
	@PhuongThucTT	nvarchar(50) = N'Tiền mặt'
as
	set xact_abort on
	begin tran
		begin try
			if(not exists(select IdCTCT, GiaiDoan from KeHoachChiTra where IdCTCT = @IdCTCT and GiaiDoan = @GiaiDoan))
				begin
					insert into KeHoachChiTra(IdCTCT, GiaiDoan, Phi, NgayTTTheoKH, MoTaPhi, PhuongThucTT)
					values(@IdCTCT, @GiaiDoan, @Phi, @NgayTTTheoKH, @MoTaPhi, @PhuongThucTT)
				end
			else
				begin
					RAISERROR('Không thể thêm kế hoạch chi trả này này vì nó đã tồn tại.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--12 proc thanh toan phi cho 1 giai doan
create proc sp_thanhToan
	@IdCTCT		int,
	@GiaiDoan	tinyint,
	@NgayThatSuTT smalldatetime
as
	set xact_abort on
	begin tran
		begin try
			if(exists(select IdCTCT, GiaiDoan from KeHoachChiTra where IdCTCT = @IdCTCT and GiaiDoan = @GiaiDoan))
				begin
					update KeHoachChiTra set NgayThatSuTT = @NgayThatSuTT where IdCTCT = @IdCTCT and GiaiDoan = @GiaiDoan
				end
			else
				begin
					RAISERROR('Thao tác thanh toán thất bại do không tồn tại 1 kế hoạch chi trả này.', 16, 1)
				end
			commit
			return 1
		end try
		begin catch
			rollback
			declare @error nvarchar(2000)
			set @error = error_message()
			raiserror(@error, 16, 1)
		end catch
go

--13 proc tong no cua khach hang
create proc sp_tongNo
	@maKH varchar(8)
as
	begin
		return dbo.fc_TongNo(@maKH)
	end
go

--14 proc danh sach chuong trinh co ngay bat dau dc truyen vao
create proc sp_chuongTrinhTrongNgay
	@ngay date
as
	begin
		select TenCT, TenKH, SoNguoiThamGia, NgayKetThuc, DiaDiem, MucPhat, TenNV
		from ChuongTrinh ct, 
			 (select * from ChiTietCT where convert(date,NgayBatDau) = @ngay) ctct, 
			 KhachHang kh, 
			 NhanVien nv
		where ctct.MaKH = kh.MaKH and ctct.MaCT = ct.MaCT
			  and ctct.MaNV = nv.MaNV
	end
go

--15 proc thong ke khach hang dang ky nhieu chuong trinh 
create proc sp_thongKeKH
as
	begin
		select * from view_ThongTinKH order by SoCTDky desc
	end
go

--16 proc thong ke cac thanh toan qua han
create proc sp_ThanhToanCanThuTuan
	@ngay date
as
	begin
		select kh.MaKH, kh.TenKH, k.IdCTCT, k.GiaiDoan, convert(varchar, k.NgayTTTheoKH, 103) as NgayTTTheoKH, k.Phi, nv.TenNV, kh.DienThoai, kh.Email, kh.DiaChi
		from (select * 
		      from KeHoachChiTra 
		      where NgayTTTheoKH between @ngay and DATEADD(DAY,7,@ngay) and NgayThatSuTT is null) as k,
		      KhachHang kh, NhanVien nv, 
		      ChiTietCT ct
		where k.IdCTCT = ct.ID and kh.MaKH=ct.MaKH and nv.MaNV=ct.MaNV
		order by k.NgayTTTheoKH	
	end
go

--insert du lieu
INSERT [dbo].[NguoiDung] ([Username], [Password], [TenNguoiDung], [Quyen], [MoTaQuyen]) VALUES (N'admin', N'202cb962ac59075b964b07152d234b70', N'Nguyễn An Vĩ', 0, N'Admin')
go