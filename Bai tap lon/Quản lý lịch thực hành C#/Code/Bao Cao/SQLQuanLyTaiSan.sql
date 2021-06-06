CREATE DATABASE QLTAISAN

CREATE TABLE TAISAN
(
	MATAISAN NCHAR(10)NOT NULL,
	TENTAISAN NVARCHAR(100)NOT NULL,
	MANHOM NCHAR(10)NOT NULL,
	MADVT NCHAR(10)NOT NULL,
	NUOCSX NVARCHAR(100) NULL,
	NAMSX DATETIME NULL,
	LYDOTANG NVARCHAR(100) NULL,
	NGAYTANG DATETIME  NULL,
	SOLUONG INT  NOT NULL,
	NGUYENGIA FLOAT  NOT NULL,
	MUCKHAUHAO FLOAT NOT NULL,
	DAKHAUHAO FLOAT  NULL,
	CONLAI FLOAT  NULL,
	DIEUCHINHTANG FLOAT  NULL,
	GIATRISAUKHITANGGIAM FLOAT  NULL,
	HANSUDUNG INT NOT  NULL,
	BOPHANSUDUNG NVARCHAR(100) NOT NULL,
	MUCDICHSUDUNG NVARCHAR(100) NULL,
	MAPHONGBAN NCHAR (10) NOT NULL,
	SOHOADON NCHAR(10) NOT NULL,

	PRIMARY KEY(MATAISAN)
)

-------------------------------------------------
CREATE TABLE CONGCU
(
	MACONGCU NCHAR(10)NOT NULL,
	TENCONGCU NVARCHAR(100)NOT NULL,
	MANHOM NCHAR(10)NOT NULL,
	MADVT NCHAR(10)NOT NULL,
	NUOCSX NVARCHAR(100) NULL,
	NAMSX DATETIME NULL,
	LYDOTANG NVARCHAR(100) NULL,
	NGAYTANG DATETIME  NULL,
	SOLUONG INT  NOT NULL,
	NGUYENGIA FLOAT  NOT NULL,
	MUCKHAUHAO FLOAT NOT NULL,
	DAKHAUHAO FLOAT  NULL,
	CONLAI FLOAT  NULL,
	DIEUCHINHTANG FLOAT  NULL,
	GIATRISAUKHITANGGIAM FLOAT  NULL,
	HANSUDUNG INT NOT NULL,
	BOPHANSUDUNG NVARCHAR(100) NOT NULL,
	MAPHONGBAN NCHAR (10) NOT NULL,
	MUCDICHSUDUNG NVARCHAR(100) NULL,
	SOHOADON NCHAR(100) NOT NULL,

	PRIMARY KEY(MACONGCU)
)
-------------------------------------------------
CREATE TABLE NHOMTAISANCONGCU
(
	CAPBAT NCHAR (10) NOT NULL,
	MANHOM NCHAR (10) NOT NULL,
	TENNHOM NVARCHAR (100) NOT NULL,
	MADONVITINH NCHAR(10)NOT NULL,

	PRIMARY KEY (MANHOM)
)
CREATE TABLE DIADIEM
(
	MADIADIEM NCHAR (10) NOT NULL,
	TENDIADIEM NVARCHAR (100) NOT NULL,
	DIACHI NVARCHAR (100) NOT NULL,
	SODIENTHOAI  NUMERIC NOT NULL,	
	
	PRIMARY KEY (MADIADIEM)
)
CREATE TABLE PHONGBAN
(
	MAPHONGBAN NCHAR (10) NOT NULL,
	TENPHONG NVARCHAR (100) NOT NULL,
	SODIENTHOAI  NUMERIC NOT NULL,
	
	PRIMARY KEY (MAPHONGBAN)
)
CREATE TABLE DONVITINH
(
	MADONVITINH NCHAR (10) NOT NULL,
	TENDONVITINH NVARCHAR (100) NOT NULL,

	PRIMARY KEY (MADONVITINH)
)
CREATE TABLE THANHLYTAISAN
(
	MATAISAN NCHAR(10)NOT NULL,
	TENTAISAN NVARCHAR(100)NOT NULL,
	MANHOM NCHAR(10)NOT NULL,
	MADVT NCHAR(10)NOT NULL,
	NUOCSX NVARCHAR(100) NULL,
	NAMSX DATETIME NULL,
	LYDOTANG NVARCHAR(100) NULL,
	NGAYTANG DATETIME  NULL,
	SOLUONG INT  NOT NULL,
	NGUYENGIA FLOAT  NOT NULL,
	MUCKHAUHAO FLOAT NOT NULL,
	DAKHAUHAO FLOAT  NULL,
	CONLAI FLOAT  NULL,
	DIEUCHINHTANG FLOAT  NULL,
	GIATRISAUKHITANGGIAM FLOAT  NULL,
	HANSUDUNG INT NOT NULL,
	BOPHANSUDUNG NVARCHAR(100) NOT NULL,
	MAPHONGBAN NCHAR (10) NOT NULL,
	MUCDICHSUDUNG NVARCHAR(100) NULL,
	
	PRIMARY KEY(MATAISAN)
)
CREATE TABLE THANHLYCONGCU
(
	MACONGCU NCHAR(10)NOT NULL,
	TENCONGCU NVARCHAR(100)NOT NULL,
	MANHOM NCHAR(10)NOT NULL,
	MADVT NCHAR(10)NOT NULL,
	NUOCSX NVARCHAR(100) NULL,
	NAMSX DATETIME NULL,
	LYDOTANG NVARCHAR(100) NULL,
	NGAYTANG DATETIME  NULL,
	SOLUONG INT  NOT NULL,
	NGUYENGIA FLOAT  NOT NULL,
	MUCKHAUHAO FLOAT NOT NULL,
	DAKHAUHAO FLOAT  NULL,
	CONLAI FLOAT  NULL,
	DIEUCHINHTANG FLOAT  NULL,
	GIATRISAUKHITANGGIAM FLOAT  NULL,
	HANSUDUNG INT NOT NULL,
	BOPHANSUDUNG NVARCHAR(100) NOT NULL,
	MAPHONGBAN NCHAR (10)NOT NULL,
	SOHOADON NCHAR(100) NOT NULL,
	MUCDICHSUDUNG NVARCHAR(100) NULL,

	PRIMARY KEY(MACONGCU)
)
CREATE TABLE NHANVIEN
(
	MANHANVIEN NCHAR (10) NOT NULL,
	TENNHANVIEN NCHAR (100)NOT NULL,
	MAPHONGBAN NCHAR (10) NOT NULL,
	TENDANGNHAP NCHAR(100)NOT NULL,
	MATKHAU NCHAR(100) NULL,
		
	PRIMARY KEY(MANHANVIEN)
)
CREATE TABLE PHIEUXUAT
(
	MAPHIEUXUAT NCHAR (10) NOT NULL,
	MATAISANCONGCU NCHAR (10) NOT NULL,
	BOPHANSUDUNG NVARCHAR(100) NOT NULL,
	MAPHONGBAN NCHAR (10)NOT NULL,
	MANHANVIEN NCHAR (10) NOT NULL,
	NGAYXUAT DATETIME NULL,
	
	PRIMARY KEY(MAPHIEUXUAT)
)
CREATE TABLE THUETAISAN
(
	MAPHIEUTHUE NCHAR (10) NOT NULL,
	MATAISAN NCHAR(10)NOT NULL,		
	TENTAISAN NVARCHAR(100)NOT NULL,
	MANHOM NCHAR(10)NOT NULL,
	MADVT NCHAR(10)NOT NULL,	
	LYDOTANG NVARCHAR(100) NULL,
	NGAYTANG DATETIME  NULL,
	SOLUONG INT  NOT NULL,
	GIATHUE FLOAT  NOT NULL,
	DATHANHTOAN FLOAT NULL, 
	CONLAI FLOAT  NULL,
	THOIGIANSUDUNG DATETIME  NOT NULL,
	BOPHANSUDUNG NVARCHAR(100) NOT NULL,
	MAPHONGBAN NCHAR (10)NOT NULL,
	MUCDICHSUDUNG NVARCHAR(100) NULL,
	SOHOADON NCHAR(100) NOT NULL,

	PRIMARY KEY(MAPHIEUTHUE)
)
