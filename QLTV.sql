use master
go
create database qltv
go
use qltv
go

--1. Sách (MÃ SÁCH, Tên sách, Tên Tác Giả, theloai, nhaXB, Năm xuất bản)
--2. Độc giả (Mã độc giả, Tên độc giả, Địa chỉ, MÃ THẺ)
--3. Thẻ thư viện (MÃ THẺ, Ngày bắt đầu, Ngày hết hạn, Ghi chú)
--4.ThuThu (MÃ THỦ THƯ, Họ tên, Ngày sinh, Số điện thoại)
--5. Mượn trả (MÃ MƯỢN TRẢ, MÃ THẺ, MÃ Thủ Thư, Ngày mượn)
create table thuThu
(
	matt char(10) not null primary key,
	hoten nvarchar(30),
	ngaysinh date,
	sdt nvarchar(30)
)
create table theTV
(
	mathe char(10) not null primary key,
	ngaybd date,
	ngayhh date
)
create table sach
(
 masach char(10) primary key,
 tensach varchar(30),
 loaisach varchar(30),
 tenTG varchar(30),
 nhaXB varchar(30),
 namXB date
)
create table docGia
(
	madg char(10) not null,
	tendg varchar(30),
	ngaysinh date,
	soCMT varchar(30),
	soDT varchar(30),
	diachi varchar(30),
	mathe char(10) not null,
	primary key(madg,mathe),
	constraint fk_mathe foreign key(mathe) references theTV(mathe)
)
create table muonTraSach
(
	maMT char(10) not null,
	mathe char(10) not null,
	matt char(10) not null,
	ngayMuon date,
	masach char(10) not null,
	daTra nvarchar(30) not null,
	ngayTra date,
	primary key(maMT,mathe,matt,masach),
	constraint fk_mathe_TV foreign key(mathe) references theTV(mathe),
	constraint fk_mtt foreign key(matt) references thuthu(matt),
	constraint fk_sach foreign key(masach) references sach(masach)
)
--4. ThuThu (MÃ THỦ THƯ, Họ tên, Ngày sinh, Số điện thoại)
set dateformat dmy
insert into thuThu values
('TT01',N'Thử thư Anh','20/08/2001','32142141'),
('TT02',N'Thử thư Minh','19/02/2000','56542141'),
('TT03',N'Thử thư Ngọc','30/06/1999','792142141')
--3. Thẻ thư viện (MÃ THẺ, Ngày bắt đầu, Ngày hết hạn)
insert into theTV values
('mt01','20/01/2022','20/12/2022'),
('mt02','20/02/2022','20/1/2023'),
('mt03','20/03/2022','20/2/2023')

--1. Sách (MÃ SÁCH, Tên sách, Tên Tác Giả, theloai, nhaXB, Năm xuất bản)
set dateformat dmy
insert into sach values
('ms01','HQTCSDL','Sách Tin Học',N'NGUYEN VAN A','NXB TPHCM','20/09/2013'),
('ms02','CSDL','Sách Tin Học',N'NGUYEN VAN B','NXB TPHCM','10/05/2015'),
('ms03','CTDL&GT','Sách Tin Học',N'NGUYEN VAN B','NXB TPHCM','16/07/2017')

--5. Mượn trả (MÃ MƯỢN TRẢ, MÃ THẺ, MÃ Thủ thư, Ngày mượn)
insert into muonTraSach values
('mmt01','mt01','TT01','25/06/2022','ms01',N'Đã trả','10/07/2022'),
('mmt02','mt02','TT01','25/05/2022','ms01',N'Chưa Trả',Null),
('mmt03','mt02','TT02','26/05/2022','ms02',N'Đã trả','03/08/2022')
--2. Độc giả (Mã độc giả, Tên độc giả, Địa chỉ, MÃ THẺ)
insert into docGia values
('dg01','Phan Thi A','14/05/2001','213012312','31321312','TPHCM','mt01'),
('dg02','Phan Thi B','14/05/2001','213012312','31321312','TPHCM','mt02'),
('dg03','Phan Thi C','14/05/2001','213012312','31321312','TPHCM','mt02')

select * from sach
update sach set tensach='HQT' where masach='ms01'
select * from muonTraSach
go
-- tạo thủ tục lấy ra thông tin bảng Sách

CREATE proc Select_Sach 
AS 
BEGIN
     SELECT * 
     FROM sach
END;
EXEC Select_Sach;
-- tạo thủ tục thêm thông tin sách
go
create proc Insert_sach
@masach char(10),@tensach nvarchar(30),
@loaisach nvarchar(30),@tenTG nvarchar(30),
@nhaXB nvarchar(30),@namXB nvarchar(30)
AS
	insert into sach(masach,tensach,loaisach,tenTG,nhaXB,namXB)
	values (@masach,@tensach,@loaisach,@tenTG,@nhaXB,@namXB)
go
-- tạo thủ tục xóa sách
create proc delete_sach
@masach char(10)
as
begin 
delete from sach
where masach = @masach 
end
go
-- tạo thủ tục cập nhật thông tin sách
create proc Update_sach
@masach char(10),@tensach nvarchar(30),
@loaisach nvarchar(30),@tenTG nvarchar(30),
@nhaXB nvarchar(30),@namXB nvarchar(30)
as
begin
UPDATE sach
set masach=@masach,tensach=@tensach,loaisach=@loaisach,
    tenTG=@tenTG,nhaXB=@nhaXB,namXB=@namXB
WHERE masach = @masach
END 
go
-- tạo thủ tục tìm kiếm sách
create proc search_sach 
@tensach nvarchar(30),@loaisach nvarchar(30),
@masach nvarchar(30),@tenTG nvarchar(30),
@namXB nvarchar(30),@nhaXB nvarchar(30)
as
	select * from sach
	where tensach like '%' +@tensach+'%' or loaisach like '%' +@loaisach+'%' or
	masach like '%' +@masach+'%' or tenTG like '%' +@tenTG+'%' or
	nhaXB like '%' +@nhaXB+'%' or namXB like '%' +@namXB +'%'

go
-- tạo thủ tục lấy ra thông tin bảng muonTraSach

CREATE proc Select_muonTraSach 
AS 
BEGIN
     SELECT * 
     FROM muonTraSach
END;
EXEC Select_muonTraSach;

-- tạo thủ tục thêm thông tin mượn trả sách
go
create proc Insert_muonTraSach
@maMT char(10),@mathe nvarchar(30),
@matt nvarchar(30),@ngaymuon date,
@masach nvarchar(30),@daTra nvarchar(30),@ngayTra date
AS
	insert into muonTraSach(maMT,mathe,matt,ngayMuon,masach,daTra,ngayTra)
	values (@maMT,@mathe,@matt,@ngaymuon,@masach,@daTra,@ngayTra)
go
-- tạo thủ tục xóa mượn trả sách
create proc delete_muonTraSach
@masach char(10)
as
begin 
delete from sach
where masach = @masach 
end
go
-- tạo thủ tục cập nhật thông tin mượn Trả sách
create proc Update_muonTraSach
@maMT char(10),@mathe nvarchar(30),
@matt nvarchar(30),@ngaymuon date,
@masach nvarchar(30),@daTra nvarchar(30),@ngayTra date
as
begin
UPDATE muonTraSach
set maMT=@maMT,mathe=@mathe,matt=@matt,
    ngayMuon=@ngaymuon,masach=@masach,daTra=@daTra,ngayTra = @ngayTra
WHERE masach = @masach
END 
go
--
-- tạo thủ tục lấy ra thông tin Độc Giả

CREATE proc Select_DocGia
AS 
BEGIN
     SELECT * 
     FROM docGia
END;
EXEC Select_DocGia;
go
-- tạo thủ tục thêm thông tin Độc Giả
create proc Insert_DocGia
@madg char(10),@tendg nvarchar(30),
@ngaysinh date, @socmt nvarchar(30),
@sdt nvarchar(30),@diachi nvarchar(30),@mathe char(10)
AS
	insert into docGia(madg,tendg,ngaysinh,soCMT,soDT,diachi,mathe)
	values (@madg,@tendg,@ngaysinh,@socmt,@sdt,@diachi,@mathe)
go

-- tạo thủ tục xóa Độc Giả
create proc delete_docgia
@madg char(10)
as
begin 
delete from docGia
where madg = @madg
end
go
-- tạo thủ tục cập nhật thông tin Độc Giả
create proc Update_docgia
@madg char(10),@tendg nvarchar(30),
@ngaysinh date, @socmt nvarchar(30),
@sdt nvarchar(30),@diachi nvarchar(30),@mathe char(10)
as
begin
UPDATE docGia
set madg=@madg,tendg=@tendg,ngaysinh=@ngaysinh,
    soCMT=@socmt,soDT=@sdt,diachi=@diachi,mathe=@mathe
WHERE madg = @madg
END 
go