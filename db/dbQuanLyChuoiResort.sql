﻿﻿---tao database.
create database DbQuanLyResort
go
use DbQuanLyResort
go
SET DATEFORMAT ymd;

go

---drop database DbQuanLyResort

---tao bang du lieu.

----QUẢN LÝ KHÁCH HÀNG.

create table KhachHang(
	MaKH nvarchar(10) not null,
	TenKH nvarchar(50) not null,
	SoDT nvarchar(10) not null,
	NgaySinh date,
	GioiTinh nvarchar(20) not null,
	Diachi nvarchar(20) not null,
	Email nvarchar(200) not null,
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
	GioiTinh nvarchar(3),
    NgaySinh DATE,
    SDT NVARCHAR(15),
    CCCD NVARCHAR(12),
    Email NVARCHAR(100) UNIQUE,
    DiaChi NTEXT,
    MaChucVu varchar(5),
    NgayVaoLam DATE,
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu) ON DELETE SET NULL)

-----QUẢN LÝ RESORT

---khu A1 : khu tòa nhà (5 tòa).

---khu A2 : khu villa (8 cái).


create table LoaiHinhLuuTru (
	maLH varchar(10) not null primary key, ---VIP0001, THG0001, 0001
	tenLH varchar(5) not null,
	loaiHinh nvarchar(45) not null, ---phòng vip, phòng thường, villa
	slNguoi int not null, --- 1, 2, 3, 4, 5, 7
	giaTien float not null,
	trangThai nvarchar(45) not null, ---trống, có người, đă đặt, đang dọn dẹp, đang bảo trì
	ghiChu nvarchar(120))

create table DatPhong(
	MaNhanSu varchar(8) references NhanSu(MaNhanSu),
	maDP varchar(12) not null primary key, ---6: DP0001, 6: ddmmyy
	MaKH nvarchar(10) not null references KhachHang(MaKH),
	ngayDatPhong date not null)

create table ChiTietDatPhong(
	maDP varchar(12) not null references DatPhong(maDP),
	maCTDP varchar(13) not null primary key,
	maLH varchar(10) references LoaiHinhLuuTru(maLH),
	ngayTraPhong date)

create table DichVu(
	maDV varchar(5) not null primary key,
	tenDV nvarchar(45) not null,
	giaTien int not null)

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
	giaCB float not null)

create table ChiTietCombo (
	maCTCB varchar(7) not null primary key,
	maCB varchar(7) references ComboMonAn(maCB),
	maMA varchar(7) references MonAn(maMA))

create table SanhDatTiec (
	maS varchar(5) not null primary key,
	tenS nvarchar(45) not null,
	giaSDT float)

create table DatTiec (
	MaNhanSu varchar(8) references NhanSu(MaNhanSu),
	maDT varchar(12) not null primary key, ---6: DT0001, 6: ddmmyy
	MaKH nvarchar(10) not null references KhachHang(MaKH),
	ngayDT date not null,
	maS varchar(5) not null references SanhDatTiec(maS),
	ghiChu nvarchar(250),
	ngayBatDau date not null,
	ngayKetThuc date,
	tongTien float not null,
	giaTriDC float not null)

create table ChiTiecDatTiec(
	maCTDT varchar(14) not null primary key, ---6 : ddmmyy, 6 : CTDT0001
	maDT varchar(12) not null references DatTiec(maDT),
	maCB varchar(7) references ComboMonAn(maCB),
	maMA varchar(7) references MonAn(maMA),
	soLuong int not null)

create table ChiTietDatDichVu (
	maCTDDV varchar(12) not null primary key,
    maDT varchar(12) NOT NULL references DatTiec(maDT),
    maDV varchar(5) NOT NULL references DichVu(maDV),
    soLuong INT NOT NULL,
    ghiChu nvarchar(250))

create table SuDungDichVu(
	maSDDV varchar(8) not null primary key,
	maDV varchar(5) not null references DichVu(maDV),
	maCTDP varchar(13) not null references ChiTietDatPhong(maCTDP),
	soLuong int not null,
	tongTien float not null)

CREATE TABLE HoaDonDatPhong (
	MaNhanSu varchar(8) references NhanSu(MaNhanSu),
    maHDDP varchar(10) NOT NULL primary key, 
    maCTDP varchar(13) not null references ChiTietDatPhong(maCTDP),
    maSDDV varchar(8) not null references SuDungDichVu(MaSDDV),
    ngayLap date not null,  
    tongTien float not null,
	trangThai nvarchar(150) not null)

create table HoaDonDatTiec (
	MaNhanSu varchar(8) references NhanSu(MaNhanSu),
	maHDDT varchar(12) not null primary key,
	maDT varchar(12) NOT NULL references DatTiec(maDT),
	ngayLap date not null,
	tongTien float not null,
	trangThai nvarchar(150) not null)

create table TaiKhoan (
	taikhoan varchar(10) primary key,
	matkhau varchar(10) not null,
	MaNhanSu varchar(8) references NhanSu(MaNhanSu))

insert into TaiKhoan (taikhoan, matkhau, MaNhanSu) values
('CEO','2104','CEO'),
('NV001','123','NV001'), ---quản lý nhân sự
('NV011','456','NV011'), ---quản lý lễ tân
('NV031','789','NV031') ---phục vụ

---delete from TaiKhoan where taikhoan = '004'