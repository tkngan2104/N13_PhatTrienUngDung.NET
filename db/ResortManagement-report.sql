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