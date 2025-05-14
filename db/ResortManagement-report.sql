use DbQuanLyResort
go
set dateformat dmy

---EXEC sp_TimChiTietDatPhongTheoTenLH @tenLH = 'A101'
---Drop PROCEDURE DSDatTiecTheoThang
---EXEC DSDatTiecTheoNgay '2025-05-05';
---EXEC DSDatTiecTheoThang 2025, 05;
---EXEC DSDatTiecTheoNam 2025;

-----Tìm loại hình lưu tru
go
CREATE PROCEDURE sp_TimKiemLoaiHinhLuuTru
    @tenLH NVARCHAR(5)
AS
BEGIN
    SELECT *
    FROM LoaiHinhLuuTru
    WHERE tenLH = @tenLH;
END;

-----Tìm chi tiết đặt phòng theo tên loại hình.
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
END;

-----Tìm đặt tiệc theo ngày.
go
CREATE PROCEDURE DSDatTiecTheoNgay
    @SearchDate DATE
AS
BEGIN
    SELECT 
        DT.maDT,
        KH.MaKH,
        KH.TenKH,
        DT.maS,
        DT.ngayDT,
        DT.ngayBatDau,
        DT.ngayKetThuc,
        DT.tongTien,
        DT.giaTriDC,
        DT.ghiChu,
        DT.MaNhanSu
    FROM DatTiec DT
    JOIN KhachHang KH ON DT.MaKH = KH.MaKH
    WHERE DT.ngayDT = @SearchDate
    ORDER BY DT.ngayDT;
END;

-----Tìm đặt tiệc theo tháng.
go
CREATE PROCEDURE DSDatTiecTheoThang
    @Year INT,
    @Month INT
AS
BEGIN
    SELECT 
        DT.maDT,
        KH.MaKH,
        KH.TenKH,
        DT.maS,
        DT.ngayDT,
        DT.ngayBatDau,
        DT.ngayKetThuc,
        DT.tongTien,
        DT.giaTriDC,
        DT.ghiChu,
        DT.MaNhanSu
    FROM DatTiec DT
    JOIN KhachHang KH ON DT.MaKH = KH.MaKH
    WHERE YEAR(DT.ngayDT) = @Year AND MONTH(DT.ngayDT) = @Month
    ORDER BY DT.ngayDT;
END;

-----Tìm đặt tiệc theo năm.
go
CREATE PROCEDURE DSDatTiecTheoNam
    @SearchYear INT
AS
BEGIN
    SELECT 
        DT.maDT,
        KH.MaKH,
        KH.TenKH,
        DT.maS,
        DT.ngayDT,
        DT.ngayBatDau,
        DT.ngayKetThuc,
        DT.tongTien,
        DT.giaTriDC,
        DT.ghiChu,
        DT.MaNhanSu
    FROM DatTiec DT
    JOIN KhachHang KH ON DT.MaKH = KH.MaKH
    WHERE YEAR(DT.ngayDT) = @SearchYear
    ORDER BY DT.ngayDT;
END;