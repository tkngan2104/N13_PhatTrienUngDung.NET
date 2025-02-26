---tao database.
create database DbQuanLyResort
go
use DbQuanLyResort
go

---tao bang du lieu.

-----quan ly du lieu resort.

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

create table ChucVu(
	MaChucVu varchar(5) primary key not null,
	TenChucVu nvarchar(50) not null)

create table NhanSu(
	MaNhanSu varchar(8) primary key,
	HoTen nvarchar(50) NOT NULL,
    NgaySinh date,
    SDT nvarchar(15),
    CCCD nvarchar(12),
    Email nvarchar(100) unique,
    DiaChi text,
    MaChucVu varchar(5),
    NgayVaoLam date,
    Luong decimal(15,2),
    foreign key (MaChucVu) references ChucVu(MaChucVu) on delete set null)

create table LoaiPhong(
	maLP varchar(5) not null primary key,
	tenLP nvarchar(45) not null)

create table DichVu(
	maDV varchar(5) not null primary key,
	tenDV nvarchar(45) not null,
	giaTien int not null)

-----quan ly co so vat chat.

create table LoaiGiuong(
	maLG varchar(5) not null primary key,
	tenLG nvarchar(45) not null)

create table Phong(
	maPhong varchar(5) not null primary key,
	maLP varchar(5) not null references LoaiPhong(maLP),
	maLG varchar(5) not null references LoaiGiuong(maLG),
	giaP float not null,
	trangThai nvarchar(45) not null)

create table CoSoVatChat(
	maCSVC varchar(7) not null primary key,
	tenCSVC nvarchar(45) not null,
	giaTien float,
	trangThai nvarchar(45) not null)

-----quan ly chuc nang phan mem.

create table DatPhong(
	MaNhanSu varchar(8) references NhanSu(MaNhanSu),
	maDP varchar(12) not null primary key, ---6: DT0001, 6: ddmmyy
	MaKH nvarchar(10) not null references KhachHang(MaKH),
	ngayDatPhong date not null,
	ngayTraPhong date,
	thanhtien float not null)

create table ChiTietDatPhong(
	maDP varchar(12) not null references DatPhong(maDP),
	maCTDP varchar(12) not null primary key,
	maPhong varchar(5) not null references Phong(maPhong),
	soLuong int not null,
	donGia float not null)

create table SuDungDichVu(
	maSDDV varchar(8) not null primary key,
	maDV varchar(5) not null references DichVu(maDV),
	maDP varchar(12) not null references DatPhong(maDP),
	soLuong int not null,
	tongTien float not null)

create table HoaDon (
    maHD varchar(10) not null primary key, 
    maDP varchar(12) not null references DatPhong(maDP), 
    maSDDV varchar(8) not null references SuDungDichVu(MaSDDV),
    maCSVC varchar(7) references CoSoVatChat(maCSVC),
    ngayLap date not null,  
    tongTien float not null)