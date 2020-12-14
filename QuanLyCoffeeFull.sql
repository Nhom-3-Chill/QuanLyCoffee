-- Tạo database
--CREATE DATABASE QuanLyCoffeeFull
--go
USE QuanLyCoffeeFull
go

CREATE TABLE NHANVIEN(
MaNV VARCHAR(20) NOT NULL PRIMARY KEY,
Email VARCHAR(50) NOT NULL,
TenNV NVARCHAR(50) NOT NULL,
DiaChi NVARCHAR(100) NOT NULL,
VaiTro TINYINT NOT NULL,
TinhTrang TINYINT NOT NULL,
SoDT VARCHAR(15) NOT NULL,
MatKhau VARCHAR(MAX) CONSTRAINT df_NV_MK DEFAULT ('12425519629871422563496318401889194171') NOT NULL
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

CREATE TABLE THUCDON(
MaTD INT IDENTITY(1,1) PRIMARY KEY,
TenTD NVARCHAR(50) NOT NULL,
Gia FLOAT NOT NULL,
HinhAnh VARCHAR(400) NOT NULL,
);
GO

CREATE TABLE CHITIETHOADON(
MaChiTietHD INT IDENTITY(1,1) NOT NULL,
MaHD INT not null,
MaTD INT not null,
SoLuong INT NOT NULL,
PRIMARY KEY(MaChiTietHD,MaTD),
CONSTRAINT fk_CT_HD FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD),
CONSTRAINT fk_CT_TD FOREIGN KEY (MaTD) REFERENCES THUCDON(MaTD)
);
go

--select *, sum(TongThanhTien) as 'doanhthu' from hoadon group by MaHD, NgayLapHD, TongThanhTien, MaKH, MaNV
-- select sum(TongThanhTien) as 'doanhthu' from hoadon
-- Report hóa đơn
--select top(3) hd.MaHD, nv.MaNV, kh.TenKhach, td.TenTD, ct.SoLuong, td.Gia, (ct.SoLuong * td.Gia) as 'ThanhTien', hd.TongThanhTien
--from THUCDON td inner join CHITIETHOADON ct on td.MaTD = ct.MaTD 
--				inner join HOADON hd on ct.MaHD = hd.MaHD
--				inner join NHANVIEN nv on nv.MaNV = hd.MaNV
--				inner join KHACHHANG kh on kh.MaKH = hd.MaKH
--group by hd.MaHD, nv.MaNV, kh.TenKhach, td.TenTD, ct.SoLuong, td.Gia, hd.TongThanhTien
--order by hd.MaHD desc
--go
--select * from HOADON

-- Report thống kê
--select hd.MaHD, hd.NgayLapHD, kh.MaKH, nv.MaNV
--from HOADON hd inner join KHACHHANG kh on hd.MaKH = kh.MaKH
--			   inner join NHANVIEN nv on nv.MaNV = hd.MaNV
--group by hd.MaHD, hd.NgayLapHD, kh.MaKH, nv.MaNV 
--go

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

exec LuuNV 'NV001', 'ducminh110xz@gmail.com', N'Trần Đức Minh', 'HCM', 1, 0, '0493628561'
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
	select * from THUCDON where TenTD like '%' + @TenTD + '%'
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

create procedure XemTopMon @ngaybd date, @ngaykt date
as
begin
	select TenTD as'TenMon', sum(SoLuong)as 'TongSoLuong' from THUCDON
				join CHITIETHOADON on THUCDON.MaTD=CHITIETHOADON.MaTD
					join HOADON on CHITIETHOADON.MaHD=HOADON.MaHD
	where NgayLapHD between @ngaybd and @ngaykt
	group by TenTD
	order by TenTD desc;
end
go

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

create procedure DonGiaMon @tenmon NVARCHAR(50)
as
begin
	select Gia from THUCDON where TenTD = @tenmon
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

create procedure LayMaHD
as
begin
	select top 1 MaHD from HOADON
	order by MaHD desc;
end
go
--select * from hoadon

create procedure LuuHD 
@mahd int,
@tentd nvarchar(50),
@soluong int
as 
declare @matd int
	select @matd = MaTD from THUCDON where TenTD = @tentd
begin
	insert into CHITIETHOADON(MaHD,MaTD,SoLuong) 
		values (@mahd,@matd,@soluong)
end
go
 
create procedure XemchitietHD @mahd int
as
begin
	select MaHD, TenTD, sum(SoLuong)as 'SoLuong' from CHITIETHOADON join THUCDON on CHITIETHOADON.MaTD=THUCDON.MaTD
	where MaHD = @mahd
	group by MaHD,TenTD
end
