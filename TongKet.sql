create database QuanLyShowroomOto
go
-- drop database QuanLyShowroomOto

use QuanLyShowroomOto
go

create table CHUCVU
(
	MaCV char(5) primary key,
	TenCV nvarchar(30) not null,
)
go

create table NHANVIEN
(
	MaNV char(5) Primary key,
	Ho nvarchar(50)  not null,
	Ten nvarchar(30) not null,
	GioiTinh bit  not null, -- 1 la nam, 0 la nu
	NgaySinh Date not null,
	CMND char(12) not null,
	Sdt char(12),
	Email char(50),
	Luong int not null,
	MaCV char(5) foreign key references CHUCVU(MaCV) ON DELETE SET NULL ON UPDATE CASCADE,
	NgayVaoLam Date not null,
	TrangThai bit not null, --1 la dang lam viec, 0 la da nghi viec
	check (Luong > 0)
)
Go

create table TAIKHOAN
(
	TenTaiKhoan char(20) primary key,
	MatKhau char(20) not null,
	MaNV char(5) foreign key references NHANVIEN(MaNV) ON DELETE CASCADE ON UPDATE CASCADE,
)
go

create table KHACHHANG
(
	MaKH char(5) primary key,
	HoTen nvarchar(50) not null ,
	GioiTinh bit not null , -- 1 la nam, 0 la nu
	NgaySinh Datetime not null,
	CMND char(12) not null ,
	Sdt char(12) not null ,
	NgheNghiep nvarchar(30),
	DiaChi nvarchar(50) not null,
)
go

create table XE
(
	MaXe char(5) primary key,
	NhanHieu char(10) not null ,
	MauSac nchar(10) not null ,
	Loai nvarchar(30) not null ,
	NamSX int not null ,
	SoGhe int not null ,
	GiaBan int,
	SoLuong int not null,
	check ( SoGhe >= 1 and SoLuong >= 0 and NamSX>0)
)
go

create table DONNHAPHANG
(
	MaDon char(7) primary key,
	NgayNhap Datetime not null ,
	XacNhan bit not null, -- 1 la Da thanh toan, 0 la Chua thanh toan
	NVXacNhan char(5) foreign key references NHANVIEN(MaNV)
)
GO

create table CHITIETNHAPXE
(
	MaDon char(7) foreign key references DONNHAPHANG(MaDon) ON DELETE CASCADE,
	MaXe char(5) foreign key references XE(MaXe) not null,
	SoLuong int not null ,
	GiaNhap int not null ,
	constraint PK_CHITIETNHAPXE primary key (MaDon, MaXe),
	check (SoLuong > 0 and GiaNhap > 0)
)
go

create table HOPDONG
(
	MaHD char(7) primary key,
	NgayKy Datetime not null ,
	NgayNhanXe Datetime not null,
	Thue int not null,
	TongChiPhi int not null,
	SoLanThanhToan int not null,
	MaKH char(5) foreign key references KHACHHANG(MaKH) not null,
	MaXe char(5) foreign key references XE(MaXe)  not null,
	MaNV char(5) foreign key references NHANVIEN(MaNV) not null 
)
go

create table THANHTOANHOPDONG
(
	MaGD char(5) primary key,
	MaHD char(7) foreign key references HOPDONG(MaHD) not null,
	SoTienGD int,
	PhuongThucThanhToan bit, -- 1 la Ngan Hang, 0 la Tien Mat
	XacNhan bit not null , -- 1 la Da xác nhận thanh toan, 0 la Chua xác nhận thanh toan 
	NgayThanhToan Datetime,
	NVXacNhan char(5) foreign key references NHANVIEN(MaNV),
	HanChot	DateTime
)
go 

create table BAODUONG
(
	MaHD char(7) foreign key references HOPDONG(MaHD) not null,
	NgayBD datetime not null,
	NVXacNhan char(5) foreign key references NHANVIEN(MaNV)
)
go

-- ============================================================================ TRIGGER
use QuanLyShowroomOto
go

-- Ngay ky phai nho hon ngay nhan xe
create trigger trigger_NgayThanhToan_NgayKy
on THANHTOANHOPDONG
after update
as
begin 
	declare @NgayThanhToan datetime =( select NgayThanhToan from inserted) 
	declare @MaHD char(7) = ( select MaHD from inserted) 
	declare @NgayKy datetime = (select NgayKy from HOPDONG WHERE @MaHD = HOPDONG.MaHD)
	if(datediff(DAY,@NgayKy, @NgayThanhToan) <  0)
	begin
		print(N'Ngày Thanh Toán Hợp Đồng phải sau Ngày Ký Hợp Đồng');
		rollback
	end
end
go

-- Ngay bao duong lon hon ngay nhan
create trigger tringger_NgayBD_NgayNhanXe
on BAODUONG
after insert
as
begin 
	declare @NgayBD datetime, @NgayNhan datetime
	select @NgayBD = inserted.NgayBD, @NgayNhan = HOPDONG.NgayNhanXe
	from inserted, HOPDONG
	where inserted.MaHD = HOPDONG.MaHD

	if(datediff(day,@NgayNhan, @NgayBD) <  0)
	begin
		rollback
	end
end
go

--trigger cho số lượng xe khi thay đổi ở bảng nhập hàng 
create trigger trigger_Insert_SLXe_NhapHang
on CHITIETNHAPXE
after insert
as
begin
	declare @SLXeNhap int, @Maxe char(5)
	select @SLXeNhap = inserted.SoLuong, @Maxe = inserted.MaXe
	from inserted

	update XE
	set SoLuong = XE.SoLuong + @SLXeNhap
	where MaXe = @Maxe
end
go

create trigger trigger_Delete_SLXe_NhapHang
on CHITIETNHAPXE
after delete
as
begin
	declare @SLXeNhap int, @Maxe char(5)
	select @SLXeNhap = deleted.SoLuong, @Maxe = deleted.MaXe
	from deleted

	update XE
	set SoLuong = SoLuong - @SLXeNhap
	where MaXe = @Maxe
end
go

create trigger trigger_Update_SLXe_NhapHang
on CHITIETNHAPXE
after update
as
begin
	declare @SLXeThayDoi int, @Maxe char(5)
	select @SLXeThayDoi = inserted.SoLuong - deleted.SoLuong, @Maxe = deleted.MaXe
	from inserted inner join deleted on inserted.MaXe = deleted.MaXe
	

	update XE
	set SoLuong = SoLuong + @SLXeThayDoi
	where MaXe = @Maxe
end
go

--trigger cho số lượng xe khi thay đổi ở bảng nhập hàng và hợp đồng
create trigger trigger_TaoHopDong_Xe
on HOPDONG
after insert
as
begin
	declare @MaXe char(5) = (select MaXe from inserted)
	declare @SoLuong int = (select SoLuong from Xe where MaXe = @MaXe)
	if(@SoLuong>=1)
	begin
		update XE
		set SoLuong = SoLuong - 1
		where MaXe = @MaXe
	end
	else 
	begin
		print(N'Hết Xe')
		rollback
	end
end
go


create trigger trigger_Don_Chitiet
on CHITIETNHAPXE
after delete
as
begin
	declare @MaDon char = (select TOP(1) MaDon from deleted)

	delete from DONNHAPHANG
	where MaDon = @MaDon
end
go

-- trigger ngày sinh < ngày vào làm
create trigger trigger_NgaySinh_NgayVaoLam
on NHANVIEN
after insert
as
begin 
	declare @NgaySinh datetime =( select NgaySinh from inserted) 
	declare @NgayVaoLam datetime = (select NgayVaoLam from inserted)
	if(datediff(day,@NgaySinh, @NgayVaoLam) <  0)
	begin
		print(N'Ngày sinh phải nhỏ hơn ngày vào làm')
		rollback
	end
end
go

-- ============================================================================ VIEW
use QuanLyShowroomOto
go

-- view quản lý khách hàng ---
create view vw_Quan_Ly_KH
as
	select MaKH,HoTen,case GioiTinh when 1 then N'Nam' when 0 then N'Nữ' end as GioiTinh,NgaySinh,CMND,Sdt,NgheNghiep,DiaChi
	from KHACHHANG 
go


create view vw_Thanh_Toan_Hop_Dong
as
select MaGD,THANHTOANHOPDONG.MaHD, KHACHHANG.HoTen, case PhuongThucThanhToan when 1 then N'Chuyển Khoản' when 0 then N'Tiền Mặt' end as PhuongThucThanhToan, SoTienGD, NgayThanhToan, HanChot,XacNhan, NHANVIEN.MaNV
from THANHTOANHOPDONG inner join HOPDONG on THANHTOANHOPDONG.MaHD = HOPDONG.MaHD
		        inner join KHACHHANG on HOPDONG.MaKH = KHACHHANG.MaKH
	               left outer join NHANVIEN on THANHTOANHOPDONG.NVXacNhan = NHANVIEN.MaNV
go

create view vw_Thanh_Toan_Hop_Dong_Chua_Xac_Nhan
as
select MaGD,THANHTOANHOPDONG.MaHD, KHACHHANG.HoTen, SoTienGD, HanChot
from THANHTOANHOPDONG inner join HOPDONG on THANHTOANHOPDONG.MaHD = HOPDONG.MaHD
					  inner join KHACHHANG on HOPDONG.MaKH = KHACHHANG.MaKH
					  left outer join NHANVIEN on THANHTOANHOPDONG.NVXacNhan = NHANVIEN.MaNV
where XacNhan = 0
			
go

create view vw_Thanh_Toan_Hop_Dong_Qua_Han
as
select MaGD,THANHTOANHOPDONG.MaHD, KHACHHANG.HoTen, SoTienGD, HanChot
from THANHTOANHOPDONG inner join HOPDONG on THANHTOANHOPDONG.MaHD = HOPDONG.MaHD
			 inner join KHACHHANG on HOPDONG.MaKH = KHACHHANG.MaKH
			 left outer join NHANVIEN on THANHTOANHOPDONG.NVXacNhan = NHANVIEN.MaNV
where XacNhan = 0 and datediff(DAY,GETDATE(), THANHTOANHOPDONG.HanChot) <  0
go

-- view quản lý nhân viên  
create view vw_Quan_Ly_NV
as
select NHANVIEN.MaNV, Ho, Ten, case GioiTinh when 1 then N'Nam' when 0 then N'Nữ' end as GioiTinh, 
		NgaySinh, CMND, Sdt, Email, Luong, NgayVaoLam, CHUCVU.TenCV, 
		case NHANVIEN.TrangThai when 1 then N'Đang làm' else N'Đã nghỉ' end as TrangThai
from NHANVIEN left outer join CHUCVU on NHANVIEN.MaCV = CHUCVU.MaCV
go

-- view quản lý chức vụ
create view vw_Chuc_vu
as
	select CHUCVU.MaCV, TenCV, sum(case when NHANVIEN.MaNV is null then 0 else 1 end) as SoLuong
	from CHUCVU left outer join NHANVIEN on CHUCVU.MaCV = NHANVIEN.MaCV
	group by CHUCVU.MaCV, TenCV
go

-- view tiền thu được của show room
create view vw_Tien_Thu
as
	select case XacNhan when 0 then N'Chưa thanh toán' else 'Đã thanh toán' end as TrangThai, sum(SoTienGD) as Tien
	from THANHTOANHOPDONG
	group by XacNhan
go

-- view tiền chi ra của show room
create view vw_Tien_Chi
as
	select case XacNhan when 0 then N'Chưa thanh toán' else 'Đã thanh toán' end as TrangThai, Sum(CHITIETNHAPXE.SoLuong * CHITIETNHAPXE.GiaNhap) as Tien
	from DONNHAPHANG inner join CHITIETNHAPXE on DONNHAPHANG.MaDon = CHITIETNHAPXE.MaDon
	group by XacNhan
go

-- view nhân viên đã nghĩ việc
create view vw_nhan_vien_da_nghi_viec
as
	select NHANVIEN.MaNV, Ho, Ten, case GioiTinh when 1 then N'Nam' when 0 then N'Nữ' end as GioiTinh, 
			NgaySinh, CMND, Sdt, Email, Luong, NgayVaoLam, CHUCVU.TenCV
	from NHANVIEN left outer join CHUCVU on NHANVIEN.MaCV = CHUCVU.MaCV
	where NHANVIEN.TrangThai = 0
go

create view vw_Don_Chitiet_Nhaphang
as
select d.MaDon, c.MaXe, d.NgayNhap, c.SoLuong, c.GiaNhap, case d.XacNhan when 1 then N'Đã được xác nhận' when 0 then N'Chưa được xác nhận' end as XacNhan, d.NVXacNhan
from DONNHAPHANG d join CHITIETNHAPXE c ON d.MaDon = c.MaDon
go

create view vw_Kho_Xe
as
select *
from XE
go

-- view đơn hàng
create view vw_DonHang
as
select MaDon, NgayNhap, case XacNhan when 1 then N'Đã được xác nhận' when 0 then N'Chưa được xác nhận' end as XacNhan, NVXacNhan
from DONNHAPHANG
go

-- view hợp đồng
create view vw_Hop_dong 
as
select HOPDONG.MaHD, NgayKy, NgayNhanXe,
	   KHACHHANG.MaKH,KHACHHANG.HoTen, KHACHHANG.CMND as CMND_KH, case KHACHHANG.GioiTinh when 1 then N'Nam' when 0 then N'Nữ' end as GioiTinh, KHACHHANG.DiaChi, KHACHHANG.NgaySinh, KHACHHANG.Sdt, KHACHHANG.NgheNghiep,
	   NHANVIEN.MaNV, NHANVIEN.CMND as CMND_NV, CONCAT(NHANVIEN.Ho, ' ', NHANVIEN.Ten) as HoTenNV,
	   XE.MaXe,CONCAT(XE.NhanHieu, ' ', XE.Loai) as TenXe, XE.MauSac, XE.NamSX, XE.SoGhe,
	   Thue, GiaBan, TongChiPhi, HOPDONG.SoLanThanhToan
from HOPDONG inner join XE on HOPDONG.MaXe = XE.MaXe
			 inner join KHACHHANG on HOPDONG.MaKH = KHACHHANG.MaKH
			 inner join NHANVIEN on HOPDONG.MaNV = NHANVIEN.MaNV
go

-- view Thông tin bảo dưỡng
create view vw_Thong_Tin_Bao_Duong
as
select HOPDONG.MaHD, NgayBD, NVXacNhan
from BAODUONG inner join HOPDONG on BAODUONG.MaHD = HOPDONG.MaHD
			  inner join NHANVIEN on NHANVIEN.MaNV = BAODUONG.NVXacNhan
go
-- ============================================================================ FUNCTION AND PROC
use QuanLyShowroomOto
go

create procedure procedure__them_chitietnhapxe
@MaDon char(7),
@MaXe char(5),
@SoLuong int, 
@GiaNhap int
as
begin 
	insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values(@MaDon, @MaXe, @SoLuong, @GiaNhap)
end
go

create procedure procedure__them_donnhaphang
@MaDon char(7),
@NgayNhap datetime,
@XacNhan bit,
@NVXacNhan char(5)
as
begin 
	insert into DONNHAPHANG(MaDon, NgayNhap,XacNhan, NVXacNhan) values(@MaDon, @NgayNhap,@XacNhan, @NVXacNhan )
end
go

create proc procedure_xoa_khach_hang @MaKH char(5)
as
begin 
	declare @KHinHD char(5)

	select @KHinHD = HOPDONG.MaKH 
	FROM KHACHHANG left outer join HOPDONG on KHACHHANG.MaKH = HOPDONG.MaKH
	where KHACHHANG.MaKH = @MaKH

	if(@KHinHD is not null)
	begin
		print(N'Không xoá được, do khách hàng đã ký hợp đồng mua xe')
	end
	else
		delete from KHACHHANG 
		WHERE KHACHHANG.MaKH = @MaKH
end
go

create proc procedure_so_luong_khach_hang
as
begin
	select count(*)
	from KHACHHANG
end
go

create proc procedure_khach_hang_va_xe
as
begin
	select KHACHHANG.HoTen, XE.Loai, XE.GiaBan from KHACHHANG inner join HOPDONG on KHACHHANG.MaKH = HOPDONG.MaKH inner join XE on HOPDONG.MaXe = XE.MaXe
end
go

create proc procedure_thong_tin_khach_hang_thanh_toan(@name nvarchar(50))
as
begin
	select KHACHHANG.HoTen, THANHTOANHOPDONG.SoTienGD, case THANHTOANHOPDONG.PhuongThucThanhToan when 1 then N'Chuyển Khoản' when 0 then N'Tiền Mặt' end as PhuongThucThanhToan, FORMAT (THANHTOANHOPDONG.NgayThanhToan,'dd-MM-yyyy') as NgayThanhToan
	from KHACHHANG inner join HOPDONG on KHACHHANG.MaKH = HOPDONG.MaKH 
	inner join THANHTOANHOPDONG on HOPDONG.MaHD = THANHTOANHOPDONG.MaHD
	Where KHACHHANG.HoTen LIKE CONCAT('%', @name, '%')
end
go

create proc procedure_thong_tin_khach_hang_thanh_toan_pro
as
begin
	select HOPDONG.MaHD, KHACHHANG.HoTen, SUM(THANHTOANHOPDONG.SoTienGD) as SoTienDaTra, HOPDONG.TongChiPhi, (HOPDONG.TongChiPhi - SUM(THANHTOANHOPDONG.SoTienGD)) as SoTienConThieu
	from KHACHHANG inner join HOPDONG on KHACHHANG.MaKH = HOPDONG.MaKH 
	inner join THANHTOANHOPDONG on HOPDONG.MaHD = THANHTOANHOPDONG.MaHD
	WHERE THANHTOANHOPDONG.XacNhan = 1
	group by KHACHHANG.HoTen,  HOPDONG.MaHD, HOPDONG.TongChiPhi
end
go

create proc procedure_tim_kiem_khach_hang_bang_thong_tin(@thongTin nvarchar(50))
as
begin
	select * 
	from vw_Quan_Ly_KH
	where CONCAT(MaKH, ' ', HoTen, ' ', CMND, ' ', Sdt, ' ') like CONCAT('%', @thongTin, '%')
end
go


CREATE PROCEDURE procedure_sua_khach_hang(@MaKH char(5),@HoTen char(40),@GioiTinh bit,@NgaySinh datetime,@CMND char(12),@Sdt char(12),@NgheNghiep nvarchar(30),@DiaChi nvarchar(50))
AS
BEGIN
	UPDATE KHACHHANG 
	set HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, SDT = @SDT, NgheNghiep = @NgheNghiep, DiaChi = @DiaChi 
	WHERE MaKH = @MaKH
END
go

create function function_top_khach_hang_mua_xe(@top int)
returns @table table(
	MaKH char(5),
	HoTen nvarchar(50),
	SoLuongXeMua int
)
as
begin
	insert into @table
	select TOP (@top) KHACHHANG.MaKH, KHACHHANG.HoTen,Count(HOPDONG.MaKH) as SoLuongXeMua from KHACHHANG inner join HOPDONG on KHACHHANG.MaKH = HOPDONG.MaKH 
	group by KHACHHANG.MaKH, KHACHHANG.HoTen
	order by SoLuongXeMua desc
	return 
end
go

create function function_so_khach_hang_mua_xe_tren_sl(@sl int)
returns @table table(
	MaKH char(5),
	HoTen nvarchar(50),
	SoLuongXeMua int
)
as
begin
	insert into @table
	select KHACHHANG.MaKH, KHACHHANG.HoTen,Count(HOPDONG.MaKH) as SoLuongXeMua from KHACHHANG inner join HOPDONG on KHACHHANG.MaKH = HOPDONG.MaKH 
	group by KHACHHANG.MaKH, KHACHHANG.HoTen
	HAVING Count(HOPDONG.MaKH) >= (@sl)
	order by SoLuongXeMua desc
	return 
end
go

-- chức năng thanh toán hợp đồng --
create proc procedure_thanh_toan_hop_dong(@phuongthucthanhtoan bit, @time datetime, @maNV char(5), @maGD char(5))
as
begin
UPDATE THANHTOANHOPDONG SET PhuongThucThanhToan = @phuongthucthanhtoan,  XacNhan = 1,NgayThanhToan = @time, NVXacNhan = @maNV where MaGD = @maGD 
end
go

-- chức năng chọn nhân viên thu ngân
create proc procedure_chon_nhan_vien_thu_ngan
as
begin
Select MaNV FROM NHANVIEN WHERE MaCV ='CV007'
end
go
-- chức năng xóa nhân viên có liên quan đến data quan trọng

create proc procedure_xoa_nhan_vien @MaNV char(5)
as
begin
	declare @NVTaoHD char(5)
	declare @NVXacNhanThanhToan char(5) 
	declare @NVBaoDuong char(5)
	declare @NVNhapHang char(5)
	select @NVTaoHD = HOPDONG.MaNV, @NVXacNhanThanhToan = THANHTOANHOPDONG.NVXacNhan, @NVBaoDuong = BAODUONG.NVXacNhan, @NVNhapHang = DONNHAPHANG.NVXacNhan
	from NHANVIEN left outer join HOPDONG on NHANVIEN.MaNV = HOPDONG.MaNV
				  left outer join THANHTOANHOPDONG on NHANVIEN.MaNV = THANHTOANHOPDONG.NVXacNhan
				  left outer join BAODUONG on NHANVIEN.MaNV = BAODUONG.NVXacNhan
				  left outer join DONNHAPHANG on NHANVIEN.MaNV = DONNHAPHANG.NVXacNhan
	where NHANVIEN.MaNV = @MaNV

	

	if(@NVTaoHD is not null or @NVXacNhanThanhToan is not null or @NVBaoDuong is not null or @NVNhapHang is not null)
	begin
		print(N'Không xóa được, do nhân viên này có liên quan đến 1 số dữ liệu quan trọng')
	end
	else
		delete from NHANVIEN
		where MaNV = @MaNV
end
go

-- chức năng tìm kiếm nhân viên bằng mã nv, họ tên, CMND, sđt, email
create proc procedure_tim_kiem_nhan_vien_bang_thong_tin(@thongTin nvarchar(50))
as
begin
	select * 
	from vw_Quan_Ly_NV
	where CONCAT(MaNV, ' ', Ho, ' ', Ten, ' ', CMND, ' ', Sdt, ' ', Email, ' ') like CONCAT('%', @thongTin, '%') 
end
go

-- chức năng sửa thông tin nhân viên
create proc procedure_sua_nhan_vien @MaNV char(5), @Ho nvarchar(10), @Ten nvarchar(20), @GioiTinh bit, @NgaySinh date, @CMND char(12), @Sdt char(12), @Email char(50), @Luong int, @MaCV char(5), @NgayVaoLam date, @TrangThai bit --By NVA
as
begin
	update NHANVIEN
	set Ho = @Ho, ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, Sdt = @Sdt, Email = @Email, Luong = @Luong, MaCV = @MaCV, NgayVaoLam = @NgayVaoLam, TrangThai = @TrangThai
	where MaNV = @MaNV
end
go

-- Chức năng thêm chức vụ
create procedure procedure_them_chucvu  @MaCV char(5), @TenCV nvarchar(30)
as
begin 
	declare @countMCV int
	declare @countTCV int
	set @countMCV = dbo.function_dem_ma_chuc_vu(@MaCV)
	set @countTCV = dbo.function_dem_ten_chuc_vu(@MaCV, @TenCV)
	if(@countMCV > 0 or @countTCV > 0)
	begin
		print(N'Tên chức vụ hoặc mã chức vụ đã tồn tại')
	end
	else
	begin
		insert into CHUCVU(MaCV, TenCV) values(@MaCV, @TenCV)
	end
end
go

-- chức năng đếm mã chức vụ
create function function_dem_ma_chuc_vu(@MaCV char(5))
returns int
as
begin
	declare @count int
	select @count = count(*) from CHUCVU where MaCV = @MaCV
	return @count
end
go

-- chức năng đếm tên chức vụ
create function function_dem_ten_chuc_vu(@MaCV char(5), @TenCV nvarchar(30))
returns int
as
begin
	declare @count int
	select @count = count(*) from CHUCVU where MaCV != @MaCV and TenCV = @TenCV
	return @count
end
go

-- chức năng xóa chức vụ
create proc procedure_xoa_chuc_vu(@MaCV char(5))
as
begin
	delete from CHUCVU
	where MaCV = @MaCV
end
go

-- chức năng chỉnh sửa chức vụ
create proc procedure_sua_chuc_vu(@MaCV char(5), @TenCV nvarchar(30))
as
begin
	declare @countTCV int
	set @countTCV = dbo.function_dem_ten_chuc_vu(@MaCV, @TenCV)
	if(@countTCV > 0)
	begin 
		print(N'Tên chức vụ đã tồn tại')
	end
	else
	begin
		update CHUCVU
		set TenCV = @TenCV
		where MaCV = @MaCV
	end
end
go

-- chức năng bảng thu nhập của công ty
create function bang_thu_nhap()
returns @BangThuChi table (MucTieu char(4), Tien int)
as
begin
	declare @thu int, @chi int
	select @thu = sum(SoTienGD)
	from THANHTOANHOPDONG
	where XacNhan = 1

	select @chi = sum(CHITIETNHAPXE.SoLuong * CHITIETNHAPXE.GiaNhap)
	from DONNHAPHANG inner join CHITIETNHAPXE on DONNHAPHANG.MaDon = CHITIETNHAPXE.MaDon
	where DONNHAPHANG.XacNhan = 1

	if(@thu is null)
		set @thu = 0
	if(@chi is null)
		set @chi = 0
	
	insert into @BangThuChi values('Thu', @thu)
	insert into @BangThuChi values('Chi', @chi)
	return 
end
go

-- chức năng bảng thu nhập show room trong khoảng thời gian
create function bang_thu_nhap_theo_khoang_thoi_gian(@time1 date, @time2 date)
returns @BangThuChi table (MucTieu char(4), Tien int)
as
begin
	declare @thu int, @chi int
	select @thu = sum(SoTienGD)
	from THANHTOANHOPDONG
	where XacNhan = 1 and NgayThanhToan between format(@time1, 'yyyy-MM-dd') and format(@time2, 'yyyy-MM-dd')

	if @thu is null
	begin
		set @thu = 0
	end

	select @chi = sum(CHITIETNHAPXE.SoLuong * CHITIETNHAPXE.GiaNhap)
	from DONNHAPHANG inner join CHITIETNHAPXE on DONNHAPHANG.MaDon = CHITIETNHAPXE.MaDon
	where DONNHAPHANG.XacNhan = 1 and NgayNhap between format(@time1, 'yyyy-MM-dd') and format(@time2, 'yyyy-MM-dd')

	if @chi is null
	begin
		set @chi = 0
	end

	insert into @BangThuChi values('Thu', @thu)
	insert into @BangThuChi values('Chi', @chi)
	return 
end
go

-- chức năng xếp hạng nhân viên theo số lượng xe
create proc procdure_top_nhan_vien_ban_xe_theo_so_luong(@time1 date, @time2 date, @top int)
as
begin
	select Top (@top) NHANVIEN.MaNV, CONCAT((Ho), ' ', (Ten)) as HoTen, count(*) as SoLuongXeBan
	from NHANVIEN inner join HOPDONG on NHANVIEN.MaNV = HOPDONG.MaNV
	where NHANVIEN.TrangThai = 1 and HOPDONG.NgayKy between format(@time1, 'yyyy-MM-dd') and format(@time2, 'yyyy-MM-dd') 
	group by NHANVIEN.MaNV, Ho, Ten
	order by SoLuongXeBan desc
end
go

-- chức năng lấy mã nhân viên bán hàng
create function function_lay_ma_nhan_vien_ban_xe()
returns char(5)
as
begin
	declare @MaCV char(5)
	select @MaCV = MaCV
	from NHANVIEN inner join HOPDONG on NHANVIEN.MaNV = HOPDONG.MaNV
	return @MaCV
end
go

-- chức năng sắp xếp tất cả NV theo lương tăng hoặc giảm
create procedure procedure_nhan_vien_theo_luong_tang_hoac_giam(@tang int)
as
begin
	if(@tang = 1)
	begin
		select *
		from vw_Quan_Ly_NV
		order by Luong ASC
	end
	else
	begin
		select *
		from vw_Quan_Ly_NV
		order by Luong DESC
	end
end
go

-- chức năng xem số lương xe bán trong 1 năm
create function function_bang_quan_ly_ban_xe(@time1 int)
returns @bang table(Thang int, SoLuong int)
as
begin
	declare @thang int
	declare @SL int
	set @thang = 1
	while @thang < 13
	begin
		select @Sl = count(*)
		from HOPDONG
		where MONTH(HOPDONG.NgayKy) = @thang and YEAR(HOPDONG.NgayKy) = @time1
		insert into @bang values(@thang, @SL)
		set @thang = @thang + 1
	end
	return
end
go

-- chức năng kiểm tra tồn tại mã nhân viên 

create function function_ma_nhan_vien(@MaNV char(5))
returns int
as
begin
	declare @count int
	select @count = count(*)
	from NHANVIEN 
	where NHANVIEN.MaNV = @MaNV
	return @count
end
go

-- chức năng thêm nhân viên
create procedure procedure_them_nhan_vien
@MaNV char(5),
@Ho nvarchar(10),
@Ten nvarchar(30),
@GioiTinh bit,
@NgaySinh date,
@CMND char(12),
@SDT char(12),
@Email nchar(50),
@Luong int,
@MaCV char(5),  
@NgayVaoLam date
as
begin 
	if dbo.function_ma_nhan_vien(@MaNV) = 1
	begin
		print(N'Mã nhân viên đã tồn tại')
	end
	else
	begin
		insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, SDT, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
		values(@MaNV, @Ho, @Ten, @GioiTinh, @NgaySinh, @CMND, @SDT, @Email, @Luong, @MaCV, @NgayVaoLam, 1)
	end
end
go

-- Đếm số lần bảo dưỡng
create function function_dem_so_lan_bao_duong(@MaHD char(7) )
returns int
as
begin
	declare @SoLan int
	select @SoLan = count(*) from BAODUONG where MaHD = @MaHD
	return @SoLan
end
go

-- Chức năng thêm Hợp Đồng
create procedure procedure__them_thanhtoanhopdong -- Phú sửa
@MaGD char(5),
@MaHD char(7),
@SoTienGD int,
@XacNhan bit,
@HanChot datetime
as
begin
	insert into THANHTOANHOPDONG(MaGD, MaHD,SoTienGD,XacNhan , HanChot) values(@MaGD, @MaHD, @SoTienGD, @XacNhan , @HanChot)
end
go

-- Chức năng liệt kê nhân viên bảo dưỡng
create proc procedure_NV_bao_duong-- (@TenCV nvarchar(30))
as
begin
	select *
	from NHANVIEN inner join CHUCVU on NHANVIEN.MaCV = CHUCVU.MaCV
	where NHANVIEN.MaCV = 'CV004' 
end
go

-- Chức năng xem thông tin NV bảo dưỡng 
create proc procedure_TT_NV_BaoDuong(@MaNV char(5))
as
begin
	select CONCAT(Ho,' ',Ten) as HoTenNV , CMND , Sdt , Email
	from NHANVIEN 
	where MaNV = @MaNV
end
go

-- Chức năng  liệt kê thông tin nhân viên bán hàng
create proc procedure_NV_ban_hang
as
begin
	select *
	from NHANVIEN
	where NHANVIEN.MaCV = 'CV003' 
end
go

-- Chức năng tìm giá bán của xe
create proc procedure_GiaBan_cuaXe(@MaXe char (5))
as
begin
	select GiaBan
	from vw_Kho_Xe
	where MaXe = @MaXe
end
go

-- Chức năng tìm thông tin bảo dưỡng của 1 HD
create proc procedure_BaoDuong_CuaHD(@MaHD char(7))
as
begin
	select *
	from vw_Thong_Tin_Bao_Duong 
	where MaHD = @MaHD
end
go

-- Chức năng tìm thông tin HD theo tên xe
create proc procedute_FindHD_TheoTenXe(@TenXe nvarchar(41))
as
begin
	select * 
	from vw_Hop_Dong 
	where TenXe like @TenXe
end
go

-- Chức năng tìm thông tin HD theo tên KH
create proc procedute_FindHD_TheoTenKH(@TenKH nvarchar(50))
as
begin
	select * 
	from vw_Hop_Dong 
	where HoTen like @TenKH
end
go

-- Chức năng tìm thông tin HD theo Mã HD
create proc procedute_FindHD_TheoMaHD(@MaHD char(7))
as
begin
	select * 
	from vw_Hop_Dong 
	where MaHD like @MaHD
end
go

-- Chức năng liệt kê những nhân viên có thể sửa HD
create proc procedure_NV_SuaHD
as
begin
	select *
	from NHANVIEN
	where NHANVIEN.MaCV = 'CV003' or NHANVIEN.MaCV = 'CV001'
end
go

-- chức năng thêm bảo dưỡng
create procedure procedure__them_baoduong
@MaHD char(7),
@NgayBD datetime, 
@NVXacNhan char(5)
as
begin
	insert into BAODUONG(MaHD, NgayBD, NVXacNhan) values(@MaHD, @NgayBD, @NVXacNhan)
end
go

-- Chức năng liệt kê tt bảo dưỡng của 1 HD

create proc procedure_Thongtin_BaoDuong_CuaHD (@MaHD char (7))
as
begin
	select * 
	from vw_Thong_Tin_Bao_Duong 
	where MaHD = @MaHD
end
go

-- chức năng thêm hợp đồng 
create procedure procedure__them_hopdong
@MaHD char(7),
@NgayKy datetime,
@NgayNhanXe datetime,
@Thue int,
@TongChiPhi int,
@SoLanThanhToan int,
@MaKH char(5),
@MaXe char(5),
@MaNV char(5)
as
begin
	insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe,MaNV) values(@MaHD, @NgayKy, @NgayNhanXe, @Thue, @TongChiPhi, @SoLanThanhToan, @MaKH, @MaXe,@MaNV )
end
go

-- Chức năng thêm khách hàng
create procedure procedure__them_khachhang
@MaKH char(5),
@HoTen nvarchar(40),
@GioiTinh bit,
@NgaySinh datetime,
@CMND char(12),
@Sdt char(12),
@NgheNghiep nvarchar(30),
@DiaChi nvarchar(50)
as
begin
	insert into KHACHHANG(MaKH, HoTen, GioiTinh, NgaySinh, CMND, SDT, NgheNghiep, DiaChi) 
	values(@MaKH, @HoTen, @GioiTinh, @NgaySinh, @CMND, @SDT, @NgheNghiep, @DiaChi)
end
go

-- chức năng tìm kiếm theo mã xe, nhãn hiệu xe
create proc procedure_tim_kiem_ma_xe_nhan_xe @Text nvarchar(30)
as
begin
	SELECT * 
	FROM vw_Kho_Xe 
	WHERE CONCAT(MaXe,NhanHieu,Loai) LIKE CONCAT('%', @Text, '%')
end
go

-- chức năng thêm xe
create procedure procedure__them_xe 
@MaXe char(5),
@NhanHieu char(10),
@MauSac varchar(10),
@Loai nvarchar(30),
@NamSX int,
@SoGhe int,
@GiaBan int,
@SoLuong int
as
begin 
	insert into XE(MaXe, NhanHieu, MauSac, Loai, NamSX, SoGhe, GiaBan, SoLuong) values(@MaXe, @NhanHieu, @MauSac, @Loai, @NamSX, @SoGhe, @GiaBan, @SoLuong)
end
go
-- ========================================= TRANSACTION ==============================================

-- chức năng tạo tài khoản
create proc tao_login
@loginname varchar(50),
@pass varchar(50),
@username varchar(50),
@role varchar(50)
as
	declare @ret int
	exec @ret = SP_ADDLOGIN @loginname, @pass, 'QuanLyShowroomOto'
	if (@ret = 1) -- login name bi trung
		return 1

	exec @ret = SP_GRANTDBACCESS @loginname, @username
	if (@ret = 1) -- username bi trung
	begin
		exec SP_DROPLOGIN @loginname
		return 2
	end

if (@role = 'QL')
begin
	exec sp_addsrvrolemember @loginname, 'SecurityAdmin'
	exec sp_addsrvrolemember @loginname, 'DBCreator'
	exec sp_addsrvrolemember @loginname, 'ProcessAdmin'
	exec sp_addrolemember 'QL', @username
end
else if(@role = 'NVBH')
begin
	exec sp_addsrvrolemember @loginname, 'SecurityAdmin'
	exec sp_addrolemember 'NVBH', @username
end
else if(@role = 'NVTT')
begin
	exec sp_addsrvrolemember @loginname, 'SecurityAdmin'
	exec sp_addrolemember 'NVTT', @username
end
else if(@role = 'NVBD')
begin
	exec sp_addsrvrolemember @loginname, 'SecurityAdmin'
	exec sp_addrolemember 'NVBD', @username
end
else
begin
	exec sp_addsrvrolemember @loginname, 'SecurityAdmin'
	exec sp_addrolemember 'NVQK', @username
end
	insert into TAIKHOAN values(@loginname, @pass, @username)
return 0 -- Thanh Cong

go

create proc xoa_login
@loginname varchar(50),
@username varchar(50)
as
	exec SP_DROPUSER @username
	exec SP_DROPLOGIN @loginname
	delete from TAIKHOAN
	where MaNV = @loginname

go
create proc procedure_tao_hop_dong(@MaHD char(7),@NgayKy datetime,@NgayNhanXe datetime,@Thue int,@TongChiPhi int
,@SoLanThanhToan int,@MaKH char(5),@MaXe char(5),@MaNV char(5), 
@MaGD1 char(5),@SoTienGD1 int,@XacNhan1 bit,@HanChot1 datetime,
@MaGD2 char(5),@SoTienGD2 int,@XacNhan2 bit,@HanChot2 datetime,
@MaGD3 char(5),@SoTienGD3 int,@XacNhan3 bit,@HanChot3 datetime)
as
begin
	SET XACT_ABORT ON
	BEGIN TRAN
	declare @i int, @MaGD char(5),@SoTienGD int,@XacNhan bit,@HanChot datetime

	BEGIN TRY
	exec procedure__them_hopdong @MaHD,@NgayKy,@NgayNhanXe,@Thue,@TongChiPhi,@SoLanThanhToan,@MaKH,@MaXe,@MaNV
	if @MaGD1 != ''
	begin
		exec procedure__them_thanhtoanhopdong @MaGD1,@MaHD,@SoTienGD1,@XacNhan1,@HanChot1

	end
	if @MaGD2 != ''
	begin
		exec procedure__them_thanhtoanhopdong @MaGD2,@MaHD,@SoTienGD2,@XacNhan2,@HanChot2

	end
	if @MaGD3 != ''
	begin
		exec procedure__them_thanhtoanhopdong @MaGD3,@MaHD,@SoTienGD3,@XacNhan3,@HanChot3

	end
	COMMIT
	END TRY
	BEGIN CATCH
	   ROLLBACK
	   DECLARE @ErrorMessage NVARCHAR(2000)
	   SELECT @ErrorMessage = N'Lỗi: ' + ERROR_MESSAGE()
	   RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
end
go

---------------------------------------ROLE-----------------------------------------------
------------------------------------------------------------------------------------------

-- Nhân viên Bảo Dưỡng
create ROLE [NVBD]
GO

ALTER AUTHORIZATION ON ROLE::[NVBD] TO [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[function_dem_so_lan_bao_duong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[function_dem_so_lan_bao_duong] TO [NVBD] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[function_dem_so_lan_bao_duong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[function_dem_so_lan_bao_duong] TO [NVBD] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[HOPDONG] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[HOPDONG] TO [NVBD] AS [dbo]
GO
GRANT SELECT ON [dbo].[HOPDONG] TO [NVBD] AS [dbo]
GO
GRANT UPDATE ON [dbo].[HOPDONG] TO [NVBD] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[BAODUONG] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[BAODUONG] TO [NVBD] AS [dbo]
GO
GRANT SELECT ON [dbo].[BAODUONG] TO [NVBD] AS [dbo]
GO
GRANT UPDATE ON [dbo].[BAODUONG] TO [NVBD] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_baoduong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_baoduong] TO [NVBD] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_BaoDuong_CuaHD] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_BaoDuong_CuaHD] TO [NVBD] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_NV_bao_duong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_NV_bao_duong] TO [NVBD] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_TT_NV_BaoDuong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_TT_NV_BaoDuong] TO [NVBD] AS [dbo]
GO

-- Nhân viên Bán Hàng - NVBH
CREATE ROLE [NVBH]
GO
ALTER AUTHORIZATION ON ROLE::[NVBH] TO [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[HOPDONG] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[HOPDONG] TO [NVBH] AS [dbo]
GO
GRANT SELECT ON [dbo].[HOPDONG] TO [NVBH] AS [dbo]
GO
GRANT UPDATE ON [dbo].[HOPDONG] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[KHACHHANG] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[KHACHHANG] TO [NVBH] AS [dbo]
GO
GRANT SELECT ON [dbo].[KHACHHANG] TO [NVBH] AS [dbo]
GO
GRANT UPDATE ON [dbo].[KHACHHANG] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Hop_dong] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Hop_dong] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Kho_Xe] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Kho_Xe] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Quan_Ly_KH] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Quan_Ly_KH] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_hopdong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_hopdong] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_khachhang] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_khachhang] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_thanhtoanhopdong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_thanhtoanhopdong] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_GiaBan_cuaXe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_GiaBan_cuaXe] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_khach_hang_va_xe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_khach_hang_va_xe] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_NV_ban_hang] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_NV_ban_hang] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_NV_SuaHD] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_NV_SuaHD] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_so_luong_khach_hang] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_so_luong_khach_hang] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_tim_kiem_khach_hang_bang_thong_tin] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_tim_kiem_khach_hang_bang_thong_tin] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedute_FindHD_TheoMaHD] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedute_FindHD_TheoMaHD] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedute_FindHD_TheoTenKH] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedute_FindHD_TheoTenKH] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedute_FindHD_TheoTenXe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedute_FindHD_TheoTenXe] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_tim_kiem_ma_xe_nhan_xe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_tim_kiem_ma_xe_nhan_xe] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[function_so_khach_hang_mua_xe_tren_sl] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[function_so_khach_hang_mua_xe_tren_sl] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[function_top_khach_hang_mua_xe] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[function_top_khach_hang_mua_xe] TO [NVBH] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_tao_hop_dong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_tao_hop_dong] TO [NVBH] AS [dbo]
GO

-- Nhân viên Thu Ngân - NVTT
CREATE ROLE [NVTT]
GO

ALTER AUTHORIZATION ON ROLE::[NVTT] TO [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[THANHTOANHOPDONG] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[THANHTOANHOPDONG] TO [NVTT] AS [dbo]
GO
GRANT SELECT ON [dbo].[THANHTOANHOPDONG] TO [NVTT] AS [dbo]
GO
GRANT UPDATE ON [dbo].[THANHTOANHOPDONG] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Thanh_Toan_Hop_Dong] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Thanh_Toan_Hop_Dong] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Thanh_Toan_Hop_Dong_Chua_Xac_Nhan] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Thanh_Toan_Hop_Dong_Chua_Xac_Nhan] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Thanh_Toan_Hop_Dong_Qua_Han] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Thanh_Toan_Hop_Dong_Qua_Han] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_thanhtoanhopdong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_thanhtoanhopdong] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_chon_nhan_vien_thu_ngan] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_chon_nhan_vien_thu_ngan] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_sua_khach_hang] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_sua_khach_hang] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_thanh_toan_hop_dong] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_thanh_toan_hop_dong] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_thong_tin_khach_hang_thanh_toan] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_thong_tin_khach_hang_thanh_toan] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_thong_tin_khach_hang_thanh_toan_pro] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_thong_tin_khach_hang_thanh_toan_pro] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_xoa_khach_hang] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_xoa_khach_hang] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_so_luong_khach_hang] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_so_luong_khach_hang] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_khach_hang_va_xe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_khach_hang_va_xe] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_tim_kiem_khach_hang_bang_thong_tin] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_tim_kiem_khach_hang_bang_thong_tin] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_tim_kiem_khach_hang_bang_thong_tin] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_tim_kiem_khach_hang_bang_thong_tin] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Quan_Ly_KH] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Quan_Ly_KH] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[function_so_khach_hang_mua_xe_tren_sl] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[function_so_khach_hang_mua_xe_tren_sl] TO [NVTT] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[function_top_khach_hang_mua_xe] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[function_top_khach_hang_mua_xe] TO [NVTT] AS [dbo]
GO


-- Nhân viên Quản Kho - NVQK
CREATE ROLE [NVQK]
GO

ALTER AUTHORIZATION ON ROLE::[NVQK] TO [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[CHITIETNHAPXE] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[CHITIETNHAPXE] TO [NVQK] AS [dbo]
GO
GRANT SELECT ON [dbo].[CHITIETNHAPXE] TO [NVQK] AS [dbo]
GO
GRANT UPDATE ON [dbo].[CHITIETNHAPXE] TO [NVQK] AS [dbo]
GO
GRANT DELETE ON [dbo].[CHITIETNHAPXE] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[DONNHAPHANG] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[DONNHAPHANG] TO [NVQK] AS [dbo]
GO
GRANT SELECT ON [dbo].[DONNHAPHANG] TO [NVQK] AS [dbo]
GO
GRANT UPDATE ON [dbo].[DONNHAPHANG] TO [NVQK] AS [dbo]
GO
GRANT DELETE ON [dbo].[DONNHAPHANG] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[XE] TO  SCHEMA OWNER 
GO
GRANT INSERT ON [dbo].[XE] TO [NVQK] AS [dbo]
GO
GRANT SELECT ON [dbo].[XE] TO [NVQK] AS [dbo]
GO
GRANT UPDATE ON [dbo].[XE] TO [NVQK] AS [dbo]
GO
GRANT DELETE ON [dbo].[XE] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[NHANVIEN] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[NHANVIEN] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_chitietnhapxe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_chitietnhapxe] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_chitietnhapxe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_chitietnhapxe] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_donnhaphang] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_donnhaphang] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure_tim_kiem_ma_xe_nhan_xe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure_tim_kiem_ma_xe_nhan_xe] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_Kho_Xe] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_Kho_Xe] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[vw_DonHang] TO  SCHEMA OWNER 
GO
GRANT SELECT ON [dbo].[vw_DonHang] TO [NVQK] AS [dbo]
GO

ALTER AUTHORIZATION ON [dbo].[procedure__them_xe] TO  SCHEMA OWNER 
GO
GRANT EXECUTE ON [dbo].[procedure__them_xe] TO [NVQK] AS [dbo]
GO

-- Quản Lý - QL

CREATE ROLE [QL]
GO

ALTER AUTHORIZATION ON ROLE::[QL] TO [dbo]
GO

ALTER ROLE [db_owner] ADD MEMBER QL

---------------------------------------DATA-----------------------------------------------
------------------------------------------------------------------------------------------
-- Chức vụ
insert into CHUCVU(MaCV, TenCV) values('CV001', N'Quản lý')
insert into CHUCVU(MaCV, TenCV) values('CV002', N'Quản kho')
insert into CHUCVU(MaCV, TenCV) values('CV003', N'Nhân viên bán hàng')
insert into CHUCVU(MaCV, TenCV) values('CV004', N'Nhân viên bảo dưỡng')
insert into CHUCVU(MaCV, TenCV) values('CV005', N'Bảo vệ')
insert into CHUCVU(MaCV, TenCV) values('CV006', N'Lao công')
insert into CHUCVU(MaCV, TenCV) values('CV007', N'Thu ngân')

go
-- Nhân viên bảo vệ CV005
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV001', N'Nguyễn Văn', N'Bảo', 1, '2000/03/25', '203648603215', '0339123545', 'nvb@gmail.com', 8, 'CV005', '02/04/2020', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV002', N'Nguyễn Văn', N'Vệ', 1, '1999/01/15', '203054153215', '0306549754', 'nvv@gmail.com', 8, 'CV005', '2020/03/02', 1)

-- Nhân viên bán hàng CV003
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV003', N'Lê Thị', N'Đào', 0, '1998/08/17', '202108774864', '0346498652', 'ltd@gmail.com', 15, 'CV003', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV004', N'Bá Văn', N'Hoa', 1, '1992/10/1', '207891227856', '0787566526', 'bvh@gmail.com', 15, 'CV003', '2020/01/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV005', N'Trịnh Bảo', N'Tuấn', 1, '1995/12/24', '374802756774', '0570826522', 'tbt@gmail.com', 15, 'CV003', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV006', N'Đào Thị', N'Tú', 0, '2000/04/4', '275880772405', '0346498652', 'dtt@gmail.com', 15, 'CV003', '2020/02/15', 1)
	 
-- Nhân viên quản lý CV001
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV007', N'Dư Tứ', N'Quản', 0, '1980/08/3', '07896384512', '04567807861', 'dtq@gmail.com', 20, 'CV001', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV008', N'Đặng Văn', N'Lý', 1, '1985/5/4', '12805864078', '0415708645', 'dvl@gmail.com', 20, 'CV001', '2020/02/15', 1)

-- Nhân viên bảo dưỡng CV004
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV009', N'Bùi Văn', N'Bảo', 1, '1990/08/5', '240578556745', '0389641586', 'bvb@gmail.com', 10, 'CV004', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV010', N'Bùi Văn', N'Dương', 1, '1990/01/24', '274802784596', '0456780678', 'bvd@gmail.com', 10, 'CV004', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV011', N'Lê Tùng', N'Thanh', 1, '1992/03/7', '427082784512', '0234503878', 'ltt@gmail.com', 10, 'CV004', '2020/02/15', 1)

-- Nhân viên thu ngân CV007
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV012', N'Đào Thị', N'Nga', 0, '2000/10/4', '423042351487', '063541684', 'dtn@gmail.com', 9, 'CV007', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV013', N'Nguyễn Tuyết', N'Nhi', 0, '1999/1/21', '7485741874', '037452864', 'ntn@gmail.com', 9, 'CV007', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV014', N'Nguyễn Như', N'Ngọc', 0, '2000/07/12', '74867412147', '0783232741', 'nnn@gmail.com', 9, 'CV007', '2020/02/15', 1)

-- Nhân viên lao công CV006
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV015', N'Lâm Văn', N'Lao', 1, '1980/07/1', '452057423541', '0374863774', 'lvl@gmail.com', 6, 'CV006', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV016', N'Đinh Chấn', N'Công', 1, '1979/01/13', '123748067887', '0346527959', 'dcc@gmail.com', 6, 'CV006', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV017', N'Nguyễn Văn', N'Sang', 1, '1990/08/4', '106085445278', '0348567841', 'nvs@gmail.com', 6, 'CV006', '2020/02/15', 1)

-- Nhân viên quản kho CV002
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV018', N'Lý Thị', N'Kha', 0, '1978/08/23', '437820341587', '0378467148', 'ltk@gmail.com', 12, 'CV002', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV019', N'Đinh Trí', N'Tuệ', 0, '1985/12/11', '742807418574', '0456345678', 'dtt@gmail.com', 12, 'CV002', '2020/02/15', 1)
insert into NHANVIEN(MaNV, Ho, Ten, GioiTinh, NgaySinh, CMND, Sdt, Email, Luong, MaCV, NgayVaoLam, TrangThai) 
	values('NV020', N'Đinh Trí', N'Thanh', 0, '1985/12/11', '742807419848', '0456345678', 'dtt@gmail.com', 12, 'CV002', '2020/02/15', 1)
go

--Khách Hàng

insert into KHACHHANG(MaKH,HoTen,GioiTinh,NgaySinh,CMND,Sdt,NgheNghiep,DiaChi)
	values('KH01',N'Lê Văn Khách',1,'1980/5/15','52156234532','0953873874',N'CEO',N'Sài Gòn')
insert into KHACHHANG(MaKH,HoTen,GioiTinh,NgaySinh,CMND,Sdt,NgheNghiep,DiaChi)
	values('KH02',N'Đào Thị Hàng',0,'1995/3/24','81646429736','036725984',N'CEO',N'Thủ Đức')
insert into KHACHHANG(MaKH,HoTen,GioiTinh,NgaySinh,CMND,Sdt,NgheNghiep,DiaChi)
	values('KH03',N'Lê Văn Mít',1,'1982/9/30','63755169732','0166487296',N'CEO',N'Dĩ An')
insert into KHACHHANG(MaKH,HoTen,GioiTinh,NgaySinh,CMND,Sdt,NgheNghiep,DiaChi)
	values('KH04',N'Nguyễn Thị Thùy Chê',0,'1987/10/22','32466232649','0982888000',N'CEO',N'Thủ Dầu Một')

go

-- Xe
insert into XE(MaXe, NhanHieu, MauSac, Loai, NamSX, SoGhe, GiaBan, SoLuong) values('X0001', 'Toyota', N'Trắng', N'CAMRY 2.0G', 2019, 5, 1050, 14)
insert into XE(MaXe, NhanHieu, MauSac, Loai, NamSX, SoGhe, GiaBan, SoLuong) values('X0002', 'Honda', N'Đen', N'CR-V', 2020, 7, 1118, 10)
insert into XE(MaXe, NhanHieu, MauSac, Loai, NamSX, SoGhe, GiaBan, SoLuong) values('X0003', 'Ford', N'Trắng', N'Ecosport Ecoboost', 2022, 5, 686, 7)
insert into XE(MaXe, NhanHieu, MauSac, Loai, NamSX, SoGhe, GiaBan, SoLuong) values('X0004', 'Mitsubishi', N'Đỏ', N'Xpander 1.5 MT (CBU)', 2022, 7, 630, 5)
insert into XE(MaXe, NhanHieu, MauSac, Loai, NamSX, SoGhe, GiaBan, SoLuong) values('X0005', 'Lexus', N'Đỏ', N'Lexus IS 300 Standard', 2022, 5, 2130, 30) 
insert into XE(MaXe, NhanHieu, MauSac, Loai, NamSX, SoGhe, GiaBan, SoLuong) values('X0006', 'Hyundai', N'Xanh Đen', N'Santafe 2.2 diesel thường', 2021, 7, 1130, 20)

go

--Chi Tiết Nhập Đơn

insert into DONNHAPHANG(MaDon,NgayNhap,XacNhan,NVXacNhan)
	values('MD01','2022/3/12',1,'NV018')
insert into DONNHAPHANG(MaDon,NgayNhap,XacNhan,NVXacNhan)
	values('MD02','2022/3/10',1,'NV018')
insert into DONNHAPHANG(MaDon,NgayNhap,XacNhan,NVXacNhan)
	values('MD03','2021/12/29',1,'NV018')
insert into DONNHAPHANG(MaDon,NgayNhap,XacNhan,NVXacNhan)
	values('MD04','2022/4/12',0,'NV019')
insert into DONNHAPHANG(MaDon,NgayNhap,XacNhan,NVXacNhan)
	values('MD05','2022/4/14',0,'NV019')
insert into DONNHAPHANG(MaDon,NgayNhap,XacNhan,NVXacNhan)
	values('MD06','2022/2/22',1,'NV019')

-- Chi Tiết Nhập Xe
go
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD01', 'X0001', 10, 900)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD01', 'X0002', 10, 1000)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD02', 'X0006', 5, 850)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD03', 'X0003', 5, 500)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD03', 'X0004', 1, 500)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD03', 'X0005', 20, 1500)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD04', 'X0001', 4, 950)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD04', 'X0003', 2, 450)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD05', 'X0006', 15, 900)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD06', 'X0004', 4, 400)
insert into CHITIETNHAPXE(MaDon, MaXe, SoLuong, GiaNhap) values('MD06', 'X0005', 10, 1700)

go

--Hợp Đồng
insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe , MaNV ) 
	values ('HD01', '2022/2/22', '2022/2/24', 0, 1050 * 1.1, 1 ,'KH01', 'X0001', 'NV003')
insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe , MaNV ) 
	values ('HD02', '2022/1/22', '2022/1/24', 0.1 * 1050, 1050 , 2 ,'KH02', 'X0001', 'NV003')
insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe , MaNV ) 
	values ('HD03', '2022/3/22', '2022/3/24', 0.1 * 1118 , 1118 , 3 ,'KH02', 'X0002', 'NV003')
insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe , MaNV ) 
	values ('HD04', '2022/1/10', '2022/2/20', 0.1 * 686, 686 , 1 ,'KH03', 'X0003', 'NV004')
insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe , MaNV ) 
	values ('HD05', '2022/2/10', '2022/2/20', 0.1 * 630, 630 , 2 ,'KH03', 'X0004', 'NV004')
insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe , MaNV ) 
	values ('HD06', '2022/3/10', '2022/3/20', 0.1*2130, 2130 , 3 ,'KH04', 'X0005', 'NV005')
insert into HOPDONG(MaHD, NgayKy, NgayNhanXe, Thue, TongChiPhi, SoLanThanhToan, MaKH, MaXe , MaNV ) 
	values ('HD07', '2022/4/10', '2022/4/15', 0.1*1130, 1130 , 1 ,'KH04', 'X0006', 'NV005')

-- Thanh Toan
go
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD001', 'HD01', 1155, 1, 1, '2022/2/23', 'NV013', '2022/4/22')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD002', 'HD02', 500, 1, 1, '2022/2/22', 'NV012', '2022/3/22')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD003', 'HD03', 500, 1, 1,'2022/3/22', 'NV012', '2022/5/22')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD004', 'HD02', 550, null, 0,null, null, '2022/4/22')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD005', 'HD03', 500, null, 0,null, null, '2022/4/23')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD006', 'HD03', 118, null, 0,null, null, '2022/8/24')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD007', 'HD04', 686, 0, 1,'2022/1/11', 'NV013', '2022/2/20')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD008', 'HD05', 500, 0, 1,'2022/2/11', 'NV014', '2022/3/10')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD009', 'HD05', 130, null, 0,null, null, '2022/4/20')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD010', 'HD06', 1000, 1, 1,'2022/3/11', 'NV014', '2022/5/10')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD011', 'HD06', 1000, 1, 1,'2022/5/11', 'NV014', '2022/6/12')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD012', 'HD06', 130, null, 0,null, null, '2022/8/2')
insert into THANHTOANHOPDONG(MaGD, MaHD, SoTienGD, PhuongThucThanhToan, XacNhan, NgayThanhToan,NVXacNhan, HanChot)
values('GD013', 'HD07', 113, 1, 1,'2022/5/9', 'NV014', '2022/6/10')
go

--Bảo dưỡng
go
insert into BAODUONG(MaHD,NgayBD,NVXacNhan) values('HD01', '2022/3/24', 'NV009')
insert into BAODUONG(MaHD,NgayBD,NVXacNhan) values('HD02', '2022/2/24', 'NV010')
insert into BAODUONG(MaHD,NgayBD,NVXacNhan) values('HD03', '2022/4/24', 'NV010')
insert into BAODUONG(MaHD,NgayBD,NVXacNhan) values('HD04', '2022/3/20', 'NV011')
insert into BAODUONG(MaHD,NgayBD,NVXacNhan) values('HD05', '2022/3/20', 'NV011')
insert into BAODUONG(MaHD,NgayBD,NVXacNhan) values('HD06', '2022/4/20', 'NV011')
insert into BAODUONG(MaHD,NgayBD,NVXacNhan) values('HD07', '2022/5/15', 'NV011')
-- Tạo Các Login
exec tao_login 'NV007', '123', 'NV007', 'QL' -- Login này thuộc role QL (Quản Lý)
exec tao_login 'NV005', '123', 'NV005', 'NVBH' -- Login này thuộc role NVBH (Nhân viên bán hàng)
exec tao_login 'NV019', '123', 'NV019', 'NVQK' -- Login này thuộc role NVQK (Nhân viên quản kho)
exec tao_login 'NV012', '123', 'NV012', 'NVTT' -- Login này thuộc role NVTT (Nhân viên thanh toán)
exec tao_login 'NV009', '123', 'NV009', 'NVBD' -- Login này thuộc role NVBD (Nhân viên bảo dưỡng)

