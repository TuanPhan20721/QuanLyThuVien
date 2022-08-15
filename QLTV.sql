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
create table nguoidung
(
	tenDangNhap nvarchar(30),
	matkhau nvarchar(30),
	quyen nvarchar(30)
)
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
insert into nguoidung values
('admin','123','admin'),
('user','123','user')
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

--1. Sách (MÃ SÁCH, Tên sách, theloai, Tên Tác Giả, nhaXB, Năm xuất bản)
set dateformat dmy
insert into sach values
('ms01','Java Web','Sach Tin Hoc',N'NGUYEN VAN A','NXB TPHCM','20/09/2013'),
('ms02','Nhap Mon LT','Sach Tin Hoc',N'NGUYEN VAN B','NXB TPHCM','10/05/2015'),
('ms03','Anh Van B1','Sach Ngoai Ngu',N'NGUYEN VAN B','NXB TPHCM','16/07/2017')

--5. Mượn trả (MÃ MƯỢN TRẢ, MÃ THẺ, MÃ Thủ thư, Ngày mượn)
insert into muonTraSach values
('mmt01','mt01','TT01','25/06/2022','ms01',N'Đã trả','10/07/2022'),
('mmt02','mt02','TT01','25/05/2022','ms01',N'Chưa Trả',Null),
('mmt03','mt02','TT02','26/05/2022','ms02',N'Đã trả','03/08/2022'),
('mmt04','mt01','TT01','26/05/2022','ms01',N'Đã trả','05/06/2022')
--2. Độc giả (Mã độc giả, Tên độc giả, Địa chỉ, MÃ THẺ)
insert into docGia values
('dg01','Phan Thi A','14/05/2001','213012312','31321312','TPHCM','mt01'),
('dg02','Phan Thi B','14/05/2001','213012312','31321312','TPHCM','mt02'),
('dg03','Phan Thi C','14/05/2001','213012312','31321312','TPHCM','mt02')

select * from sach
update sach set tensach='HQT' where masach='ms01'
select * from muonTraSach
go
---------------Phan Văn Tuấn------------------
----------------------------FUNCTION
--1. Viết hàm truyền vào mã sách sẽ trả về tổng số sách đã trả của mã sách đó 
go
create function tra_ve_TongSo_Sach_datra(@masach nvarchar(10))
returns int
as
begin
	declare @sosach int
	set @sosach = (select COUNT(@masach) from muonTraSach where masach =@masach and daTra=N'Đã trả')
	return @sosach
end
go

declare @ms nvarchar(10) 
set @ms = dbo.tra_ve_TongSo_Sach_datra('ms01')
print 'Tong so sach da tra cua ma sach ms01 la:'+ @ms  
go
--2. viết hàm thống kê sách mượn

create function travebang()
returns table return 
	select s.masach,s.tensach,mt.daTra,mt.ngayTra
	from sach s inner join muonTraSach mt on s.masach = mt.masach
	group by s.masach,s.tensach,mt.daTra,mt.ngayTra

go
select * from travebang()
------------------------CUSOR
--- Bai tap Cursor
--1/ Viết cursor hiển thị mã sách, tên sách và tổng số phieu muon tra.
declare hienThi_TT cursor dynamic
for
select s.masach ,s.tensach,count(mt.maMT) as TongSoPhieu_MT
from sach s,muonTraSach mt
where s.masach = mt.masach group by s.masach,s.tensach

open hienThi_TT
declare @masach char(10),@tensach nvarchar(20),@tongSoPhieu_MT int
fetch next from  hienThi_TT into @masach,@tensach,@tongSoPhieu_MT 
while(@@FETCH_STATUS =0)
begin
	print 'Ma sach: '+@masach+'Ten sach:'+@tensach+N'     Tong so phieu muon tra tuong ung là : '+cast(@tongSoPhieu_MT as varchar(5))
	fetch next from hienThi_TT into @masach,@tensach,@tongSoPhieu_MT
end
close hienThi_TT
deallocate hienThi_TT
go
--2/ Viết cursor hiển thị mã, họ tên, địa chỉ và tuổi của từng độc giả.
declare hienThi_docgia cursor dynamic
for
select dg.madg ,dg.tendg,dg.diachi,(YEAR(GETDATE())-YEAR(dg.ngaysinh)) as tuoi
from docGia dg

open hienThi_docgia
declare @madg nchar(10),@tendg nvarchar(20),@diachi nvarchar(10),@tuoi int
fetch next from  hienThi_docgia into @madg,@tendg,@diachi,@tuoi 
while(@@FETCH_STATUS =0)
begin
	print 'Ma doc gia: '+@madg+' Ten doc gia: ' +@tendg+'        Dia chi: '+@diachi+'          Tuoi cua doc gia: '+cast(@tuoi as varchar(5))+' tuoi'
	fetch next from hienThi_docgia into @madg,@tendg,@diachi,@tuoi
end
close hienThi_docgia
deallocate hienThi_docgia
go
------------------------TRIGGER
--1. Tạo trigger kiểm tra loại sách khi insert,update

create trigger check_loaiSach on sach
for insert,update
as
	if((select loaisach from inserted) ='Sach Tin Hoc' 
	 or (select loaisach from inserted) ='Sach Ngoai Ngu' )
	commit tran
	begin
		print 'loai sach phai la sach tin hoc or sach ngoai ngu'
		rollback tran
	end
go	
insert into sach values
('ms04','Java Web','Sach Kinh Di',N'NGUYEN VAN A','NXB TPHCM','20/09/2013')
drop trigger check_loaiSach
go
--2. viet trigger kiem tra ngay tra lon hon ngay muon
create trigger check_ngay on theTV
for insert,update
as
	if((select ngayhh from inserted)>(select ngaybd from inserted))
	 commit tran
	 else
	 begin
		print 'Ngay het han phai lon hon ngay bat dau'
		rollback tran
	 end
go
insert into theTV values
('mt04','22/12/2022','20/12/2022')
drop trigger check_ngay
 go
---------------------------PROCEDURE
-- tạo thủ tục lấy ra thông tin bảng Sách
CREATE proc Select_Sach 
AS 
BEGIN
     SELECT * 
     FROM sach
END;
EXEC Select_Sach;
go

-- tạo thủ tục thêm thông tin sách
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
----------Nguyễn Trọng Khánh---------------
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
---------------Cao Công Đoàn-----------------
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
---------- Đặng Huỳnh Đức - 2001190480
-- Tạo thủ tục lấy tên cột 
CREATE FUNCTION LAY_TEN_COT (@TENBANG NVARCHAR(50))
RETURNS TABLE
AS
	RETURN (SELECT COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME like @TENBANG)
GO
--DROP FUNCTION LAY_TEN_COT
--SELECT * FROM LAY_TEN_COT('ThuThu')
--GO
-- Tạo thủ tục tìm theo thủ thư, dùng dynamic SQL để truy vấn
CREATE FUNCTION TIM_KIEM_THU_THU()  
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM thuThu
GO
-- Tạo thủ tục tìm theo sách, dùng dynamic SQL để truy vấn
CREATE FUNCTION TIM_KIEM_SACH()  
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM sach
GO
-- Tạo thủ tục tìm theo Thẻ thư viện, dùng dynamic SQL để truy vấn
CREATE FUNCTION TIM_KIEM_THE_THU_VIEN()  
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM theTV
GO
-- Tạo thủ tục tìm theo Độc giả, dùng dynamic SQL để truy vấn
CREATE FUNCTION TIM_KIEM_DOC_GIA()  
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM docGia
GO
-- Tạo thủ tục lấy masterdata, dùng dynamic SQL để truy vấn
CREATE FUNCTION LAY_MASTER_DATA()  
RETURNS TABLE  
AS  
RETURN  
    SELECT madg,tendg,DG.ngaysinh as ngaysinh_dg,soCMT,soDT,diachi,maMT,ngayMuon,S.masach,daTra,ngayTra,tensach,loaisach,tenTG,nhaXB,namXB,MTS.mathe,ngaybd,ngayhh,MTS.matt,hoten,TT.ngaysinh as ngaysinh_tt,sdt
	FROM docGia DG,thuthu TT,sach S,muonTraSach MTS, theTV T
	WHERE TT.matt = MTS.matt AND S.masach = MTS.masach AND T.mathe = DG.mathe AND MTS.mathe = T.mathe
GO

CREATE FUNCTION LAY_DANH_SACH_MUON_TRA()
RETURNS TABLE  
AS  
RETURN  
    SELECT S.masach,tensach,loaisach,tenTG,nhaXB,namXB,maMT,mathe,matt,ngayMuon,daTra,ngayTra
	FROM sach S,muonTraSach MTS
	WHERE S.masach = MTS.masach 
GO