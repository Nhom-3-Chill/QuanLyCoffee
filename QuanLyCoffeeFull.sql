-- Tạo database
-- CREATE DATABASE QuanLyCoffee

USE QuanLyCoffee
go

CREATE TABLE NHANVIEN(
MaNV VARCHAR(20) NOT NULL PRIMARY KEY,
Email VARCHAR(50) NOT NULL,
TenNV NVARCHAR(50) NOT NULL,
DiaChi NVARCHAR(100) NOT NULL,
VaiTro TINYINT NOT NULL,
TinhTrang TINYINT NOT NULL,
SoDT VARCHAR(15) NOT NULL,
MatKhau VARCHAR(MAX) CONSTRAINT df_NV_MK DEFAULT ('1') NOT NULL
);
go


CREATE TABLE KHACHHANG(
MaKH VARCHAR(20) NOT NULL PRIMARY KEY,
TenKhach NVARCHAR(50) NOT NULL,
SoDT VARCHAR(15) NOT NULL,
Email VARCHAR(50) NOT NULL,
DiaChi NVARCHAR(100) NOT NULL
);
go

CREATE TABLE HOADON(
MaHD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NgayLapHD DATE NOT NULL,
TongThanhTien FLOAT NOT NULL,
MaKH VARCHAR(20) NOT NULL,
MaNV VARCHAR(20) NOT NULL,
CONSTRAINT fk_HD_NV FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV),
CONSTRAINT fk_HD_KH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
);
go

CREATE TABLE CHITIETHOADON(
MaChiTietHD INT IDENTITY(1,1) NOT NULL,
MaTD INT NOT NULL UNIQUE,
SoLuong INT NOT NULL,
PRIMARY KEY(MaChiTietHD, MaTD),
CONSTRAINT fk_CT_HD FOREIGN KEY (MaChiTietHD) REFERENCES HOADON(MaHD)
);
go

CREATE TABLE THUCDON(
MaTD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
TenTD NVARCHAR(50) NOT NULL,
Gia FLOAT NOT NULL,
HinhAnh VARCHAR(400) NOT NULL,
CONSTRAINT fk_TD_CT FOREIGN KEY (MaTD) REFERENCES CHITIETHOADON(MaTD)
);
GO

-- PROCEDURE NHÂN VIÊN
create procedure DangNhap @email varchar(50), @matkhau varchar(max)
as
begin
	declare @check int
	if exists(select * from nhanvien where Email=@email and MatKhau=@matkhau)
		set @check=1
	else set @check=0
	select @check
end
go

create procedure QuenMatKhau @email varchar(50)
as 
begin
	declare @check int
	if exists(select * from nhanvien where email=@email)
		set @check=1
	else set @check=0
	select @check
end
go

create procedure TaoMatKhau @email varchar(50), @matkhau varchar(max)
as
begin
	update nhanvien set MatKhau=@matkhau where Email=@email
end
go

create procedure DoiMatKhau @email varchar(50), @matkhaucu varchar(max),@matkhaumoi varchar(max)
as
begin
	declare @check int
	if exists(select * from nhanvien where Email=@email and MatKhau=@matkhaucu)
		begin
			set @check=1
			update NHANVIEN set MatKhau=@matkhaumoi where Email=@email
		end
	else set @check=0
	select @check
end
go

create procedure DanhSachNV 
as
begin
	SET NOCOUNT ON;
	select MaNV,Email,TenNV,DiaChi,VaiTro,TinhTrang,SoDT from nhanvien
end
go

create procedure VaiTro @email varchar(50)
as
begin
	select VaiTro from nhanvien where Email=@email
end
go

create procedure TinhTrang @email varchar(50)
as
begin
	select TinhTrang from nhanvien where Email=@email
end
go

create procedure LuuNV
@manv VARCHAR(20),
@email VARCHAR(50),
@tennv NVARCHAR(50),
@diachi NVARCHAR(100),
@vaitro TINYINT,
@tinhtrang TINYINT,
@sdt VARCHAR(15)
as
begin
	insert into NHANVIEN(MaNV,Email,TenNV,DiaChi,VaiTro,TinhTrang,SoDT) values(@manv,@email,@tennv,@diachi,@vaitro,@tinhtrang,@sdt)
end
go

create procedure XoaNV @email varchar(50)
as
begin
	delete nhanvien where Email=@email
end
go

create procedure SuaNV 
@manv VARCHAR(20),
@email VARCHAR(50),
@tennv NVARCHAR(50),
@diachi NVARCHAR(100),
@vaitro TINYINT,
@tinhtrang TINYINT,
@sdt VARCHAR(15)
as
begin
	update nhanvien set MaNV=@manv, TenNV=@tennv, DiaChi=@diachi, VaiTro=@vaitro, TinhTrang=@tinhtrang, SoDT=@sdt
	where Email=@email
end
go

create procedure TimKiemNV @tennv nvarchar(50)
as
begin
	select MaNV,Email,TenNV,DiaChi,VaiTro,TinhTrang,SoDT from nhanvien
	where TenNV like '%'+@tennv+'%'
end
go

-- PROCEDURE KHÁCH HÀNG
create procedure DanhSachKH
as
begin
	set nocount on;
	select MaKH,TenKhach,SoDT,Email,DiaChi from khachhang
end
go

create procedure LuuKH
@makh VARCHAR(20),
@tenkhach NVARCHAR(50),
@sodt VARCHAR(15),
@email VARCHAR(50),
@diachi NVARCHAR(100)
as
begin 
	insert into KHACHHANG(MaKH,TenKhach,SoDT,Email,DiaChi) values(@makh,@tenkhach,@sodt,@email,@diachi)
end
go

create procedure XoaKH @makh VARCHAR(20)
as
begin
	delete KHACHHANG where MaKH = @makh
end
go

create procedure SuaKH
@makh VARCHAR(20),
@tenkhach NVARCHAR(50),
@sodt VARCHAR(15),
@email VARCHAR(50),
@diachi NVARCHAR(100)
as
begin
	update KHACHHANG set TenKhach = @tenkhach, SoDT = @sodt, Email = @email, DiaChi = @diachi
	where MaKH = @makh 
end
go

create procedure TimKiemKH @tenkhach NVARCHAR(50)
as
begin
	select * from khachhang where TenKhach like '%' + @tenkhach + '%'
end
go

-- PROCEDURE THỰC ĐƠN
create procedure DanhSachTD
as
begin 
	set nocount on;
	select * from THUCDON
end
go

create procedure InsertTD
@TenTD nvarchar(50), @Gia float,  
@HinhAnh varchar(400)
as
begin 
	insert into THUCDON(TenTD,Gia,HinhAnh) values(@TenTD,@Gia,@HinhAnh)
end
go

create procedure SuaTD	
@MaTD int,   @TenTD nvarchar(50),
@Gia float,  @HinhAnh varchar(400)
as
begin 
	update THUCDON set TenTD=@TenTD, Gia=@Gia, HinhAnh=@HinhAnh 
		where MaTD=@MaTD 
end
go

create procedure DeleteTD @MaTD int
as 
begin
	delete from THUCDON where MaTD=@MaTD 
end
go

create procedure SearchTD @TenTD NVARCHAR(50)
as
begin
	select * from THUCDON where TenTD=@TenTD 
end
go

-- PROCEDURE THỐNG KÊ
create procedure XemThongKe @ngaybd date, @ngaykt date
as
begin
	select * from HOADON
	where NgayLapHD between @ngaybd and @ngaykt
end
GO

-- PROCEDURE HÓA ĐƠN
create procedure DanhSanhMon
as
begin
	select TenTD from THUCDON
end
go

create procedure DanhSanhKH
as
begin
	select TenKhach from KHACHHANG
end
go

create procedure ThanhToan
@TenKH nvarchar(50),
@TenNV nvarchar(50),
@Ngaylap date,
@TongTien float
as
declare @manv varchar(20) 
	select @manv = MaNV from NHANVIEN where TenNV=@TenNV
declare @makh varchar(20)
	select @makh = MaKH from KHACHHANG where TenKhach=@TenKH
begin
	insert into HOADON(NgayLapHD,TongThanhTien,MaKH,MaNV) 
		values(@Ngaylap,@TongTien,@makh,@manv);
end
go