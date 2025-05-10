use DbQuanLyResort
go
set dateformat dmy
go

CREATE PROCEDURE sp_TimKiemLoaiHinhLuuTru
    @tenLH NVARCHAR(5)
AS
BEGIN
    SELECT *
    FROM LoaiHinhLuuTru
    WHERE tenLH = @tenLH;
END;

go

CREATE PROCEDURE sp_TimChiTietDatPhongTheoTenLH
    @tenLH VARCHAR(50)
AS
BEGIN
    SELECT 
        ctdp.maCTDP,
        ctdp.maDP,
        ctdp.maLH,
        lhlt.tenLH,
        lhlt.loaiHinh,
        ctdp.ngayTraPhong
    FROM 
        ChiTietDatPhong ctdp
    JOIN 
        LoaiHinhLuuTru lhlt ON ctdp.maLH = lhlt.maLH
    WHERE 
        lhlt.tenLH LIKE '%' + @tenLH + '%'
END

EXEC sp_TimChiTietDatPhongTheoTenLH @tenLH = 'A101'

select * from DatTiec
----Danh sách đặt tiệc theo ngày tháng năm.
go
CREATE PROCEDURE DSDatTiecTheoNgay
    @SearchDate DATE
AS
BEGIN
    SELECT 
        MaNhanSu,
        maDT,
        MaKH,
        ngayDT,
        maS,
        ghiChu,
        ngayBatDau,
        ngayKetThuc,
        tongTien,
        giaTriDC
    FROM 
        DatTiec
    WHERE 
        ngayDT = @SearchDate
    ORDER BY 
        ngayDT;
END;

EXEC DSDatTiecTheoNgay '2025-05-05';

go
CREATE PROCEDURE DSDatTiecTheoThang
    @Year INT,
    @Month INT
AS
BEGIN
    SELECT 
        MaNhanSu,
        maDT,
        MaKH,
        ngayDT,
        maS,
        ghiChu,
        ngayBatDau,
        ngayKetThuc,
        tongTien,
        giaTriDC
    FROM 
        DatTiec
    WHERE 
        YEAR(ngayDT) = @Year AND MONTH(ngayDT) = @Month
    ORDER BY 
        ngayDT;
END;

EXEC DSDatTiecTheoThang 2025, 05;

go
CREATE PROCEDURE DSDatTiecTheoNam
    @Year INT
AS
BEGIN
    SELECT 
        MaNhanSu,
        maDT,
        MaKH,
        ngayDT,
        maS,
        ghiChu,
        ngayBatDau,
        ngayKetThuc,
        tongTien,
        giaTriDC
    FROM 
        DatTiec
    WHERE 
        YEAR(ngayDT) = @Year
    ORDER BY 
        ngayDT;
END;

EXEC DSDatTiecTheoNam 2025;