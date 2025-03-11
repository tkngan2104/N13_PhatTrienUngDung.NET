---tao database.
create database DbQuanLyResort
go
use DbQuanLyResort
go

---tao bang du lieu.

-----QUẢN LÝ KHÁCH HÀNG.
create table KhachHang(
	MaKH nvarchar(10) not null,
	TenKH nvarchar(20) not null,
	SoDT nvarchar(10) not null,
	NgaySinh datetime,
	GioiTinh nvarchar(20) not null,
	Diachi nvarchar(20) not null,
	Email nvarchar(20) not null,
	CCCD nvarchar(12) not null,
	QuocTich nvarchar(50) not null,
	primary key(MaKH))

-----QUẢN LÝ NHÂN SỰ
create table ChucVu(
	MaChucVu varchar(5) PRIMARY KEY NOT NULL,
    TenChucVu NVARCHAR(50) NOT NULL)

create table NhanSu(
	MaNhanSu varchar(8) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    SDT NVARCHAR(15),
    CCCD NVARCHAR(12),
    Email NVARCHAR(100) UNIQUE,
    DiaChi TEXT,
    MaChucVu varchar(5),
    NgayVaoLam DATE,
    Luong DECIMAL(15,2),
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu) ON DELETE SET NULL)

-----QUẢN LÝ RESORT
create table CoSoVatChat(
	maCSVC varchar(7) not null primary key,
	tenCSVC nvarchar(45) not null,
	giaTien float,
	trangThai nvarchar(45) not null)

create table LoaiPhong(
	maLP varchar(5) not null primary key,
	tenLP nvarchar(45) not null)

create table LoaiGiuong(
	maLG varchar(5) not null primary key,
	tenLG nvarchar(45) not null)

create table Phong(
	maPhong varchar(5) not null primary key,
	maLP varchar(5) not null references LoaiPhong(maLP),
	maLG varchar(5) not null references LoaiGiuong(maLG),
	giaP float not null,
	trangThai nvarchar(45) not null)

create table DatPhong(
	MaNhanSu varchar(8) references NhanSu(MaNhanSu),
	maDP varchar(12) not null primary key, ---6: DT0001, 6: ddmmyy
	maKH nvarchar(10) not null references KhachHang(maKH),
	ngayDatPhong date not null,
	ngayTraPhong date)

create table ChiTietDatPhong(
	maDP varchar(12) not null references DatPhong(maDP),
	maCTDP varchar(12) not null primary key,
	maLP varchar(5) not null references LoaiPhong(maLP),
	maLG varchar(5) not null references LoaiGiuong(maLG),
	soLuong int not null)

create table DichVu(
	maDV varchar(5) not null primary key,
	tenDV nvarchar(45) not null,
	giaTien int not null)

create table

create table SuDungDichVu(
	maSDDV varchar(8) not null primary key,
	maDV varchar(5) not null references DichVu(maDV),
	maDP varchar(12) not null references DatPhong(maDP),
	soLuong int not null,
	tongTien float not null)

CREATE TABLE HoaDon (
    maHD VARCHAR(10) NOT NULL PRIMARY KEY, 
    maDP VARCHAR(12) NOT NULL REFERENCES DatPhong(maDP), 
    maSDDV VARCHAR(8) NOT NULL REFERENCES SuDungDichVu(MaSDDV),
    maCSVC VARCHAR(7) REFERENCES CoSoVatChat(maCSVC),
    ngayLap DATE NOT NULL,  
    tongTien float NOT NULL)

create table LoaiMonAn (
	maLMA varchar(7) not null primary key,
	tenLMA nvarchar(45) not null)

create table MonAn (
	maMA varchar(7) not null primary key,
	maLMA varchar(7) not null references LoaiMonAn(maLMA),
	tenMA nvarchar(45) not null,
	giaTien float not null,
	mieuTa nvarchar(150) not null)

create table ComboMonAn (
	maCB varchar(7) not null primary key,
	tenCB nvarchar(150) not null,
	maMA varchar(7) not null references MonAn(maMA),
	giaCB float not null)

insert into DichVu(maDV, tenDV, giaTien)
values ('DV001', N'Đặt tiệc', 35000000)