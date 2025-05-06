use DbQuanLyResort
go
set dateformat dmy
go

-----SELECT



-----CHỨC VỤ
go
insert into ChucVu (MaChucVu, TenChucVu) values
('CV001', N'Giám đốc điều hành'),
('CV002', N'Giám đốc tài chính'),
('CV003', N'Giám đốc nhân sự'),
('CV004', N'Giám đốc marketing'),
('CV005', N'Giám đốc vận hành'),
('CV006', N'Quản lý nhân sự'),
('CV007', N'Nhân viên lễ tân'),
('CV008', N'Nhân viên vệ sinh'),
('CV009', N'Nhân viên phục vụ nhà hàng'),
('CV010', N'Nhân viên bếp'),
('CV011', N'Nhân viên quầy bar'),
('CV012', N'Nhân viên bảo trì, kỹ thuật'),
('CV013', N'Nhân viên kho'),
('CV014', N'Nhân viên an ninh'),
('CV015', N'Nhân viên chăm sóc khách hàng'),
('CV016', N'Nhân viên spa'),
('CV017', N'Nhân viên marketing'),
('CV018', N'Nhân viên kế toán'),
('CV019', N'Nhân viên hành chính'),
('CV020', N'Nhân viên tổ chức sự kiện'),
('CV021', N'Nhân viên bán hàng');

-----NHÂN VIÊN

go
insert into NhanSu(MaNhanSu, HoTen, NgaySinh, SDT, CCCD, Email, DiaChi, MaChucVu, NgayVaoLam, Luong) values

---ban điều hành.
('CEO',N'Đào Minh Trí','06/04/2025','0011223344','667788990011','minhtri@gmail.com',N'21 Lê Văn Thịnh, Thủ Đức, TP HCM','CV001',NULL,NULL),
('GD001', N'Nguyễn Minh Tuấn', '01/01/1985', '0912345678', '123456789012', 'minhtuan@gmail.com', N'12 Nguyễn Huệ, Quận 1, TP HCM', 'CV002', '06/04/2024', 25000000),
('GD002', N'Phạm Thanh Hương', '10/03/1990', '0934567890', '223456789013', 'thanhhuong@gmail.com', N'22 Lê Quang Định, Bình Thạnh, TP HCM', 'CV003','06/04/2024', 28000000),
('GD003', N'Lê Quốc Anh', '15/07/1982', '0945678901', '323456789014', 'quocanh@gmail.com', N'33 Phạm Ngọc Thạch, Quận 3, TP HCM', 'CV004', '06/04/2024', 27000000),
('GD004', N'Trần Thị Lan', '25/12/1987', '0956789012', '423456789015', 'thilan@gmail.com', N'44 Trần Quang Khải, Quận 1, TP HCM', 'CV005', '06/04/2024', 25000000),
---quản lý nhân sự.
('NV001', N'Nguyễn Minh Tuấn', '01/01/1985', '0912345679', '123456789013', 'minhtuan2@gmail.com', N'12 Nguyễn Huệ, Quận 1, TP HCM', 'CV006', '06/04/2024', 25000000),
('NV002', N'Phan Thị Lan', '12/05/1990', '0912345679', '123456789018', 'lanphan@gmail.com', N'10 Lê Lợi, Quận 1, TP HCM', 'CV006', '06/04/2024', 27000000),
('NV003', N'Lê Minh Quân', '23/08/1987', '0912345680', '123456789014', 'minhquan@gmail.com', N'15 Hai Bà Trưng, Quận 3, TP HCM', 'CV006', '06/04/2024', 29000000),
('NV004', N'Hoàng Thị Mai', '30/09/1992', '0912345681', '123456789015', 'hoangmai@gmail.com', N'25 Đinh Tiên Hoàng, Quận 1, TP HCM', 'CV006', '06/04/2024', 28000000),
('NV005', N'Nguyễn Thị Bích', '11/11/1995', '0912345682', '123456789016', 'nguyebich@gmail.com', N'16 Nguyễn Trãi, Quận 5, TP HCM', 'CV006', '06/04/2024', 26000000),
('NV006', N'Võ Minh Tuấn', '14/07/1991', '0912345683', '123456789017', 'vominhtuan@gmail.com', N'8 Lý Tự Trọng, Quận 1, TP HCM', 'CV006', '06/04/2024', 25000000),
('NV007', N'Trần Thị Ngọc', '17/02/1993', '0912345684', '123456789018', 'ngoctran@gmail.com', N'30 Phạm Ngọc Thạch, Quận 3, TP HCM', 'CV006', '06/04/2024', 24000000),
('NV008', N'Nguyễn Thị Hương', '25/06/1994', '0912345685', '123456789019', 'nguyenhuong@gmail.com', N'3 Nguyễn Thị Minh Khai, Quận 1, TP HCM', 'CV006', '06/04/2024', 23000000),
('NV009', N'Phạm Minh Trí', '04/02/1989', '0912345686', '123456789020', 'phamminttri@gmail.com', N'20 Lê Lai, Quận 3, TP HCM', 'CV006', '06/04/2024', 22000000),
('NV010', N'Nguyễn Quốc Duy', '10/03/1988', '0912345687', '123456789021', 'quocduy@gmail.com', N'18 Nguyễn Chí Thanh, Quận 5, TP HCM', 'CV006', '06/04/2024', 21000000),

---nhân viên lễ tân.
('NV011', N'Nguyễn Thị Lan', '21/06/1990', '0912345690', '223456789012', 'lannguyen@gmail.com', N'15 Lê Lợi, Quận 1, TP HCM', 'CV007', '06/04/2024', 12000000),
('NV012', N'Lê Văn Cường', '15/02/1992', '0912345691', '223456789013', 'vancuong@gmail.com', N'17 Nguyễn Thiện Thuật, Quận 3, TP HCM', 'CV007', '06/04/2024', 13000000),
('NV013', N'Phan Mai Chi', '30/09/1995', '0912345692', '223456789014', 'maichi@gmail.com', N'25 Nguyễn Thái Học, Quận 1, TP HCM', 'CV007', '06/04/2024', 11000000),
('NV014', N'Hoàng Hải Yến', '19/12/1994', '0912345693', '223456789015', 'haiyen@gmail.com', N'7 Lê Lai, Quận 3, TP HCM', 'CV007', '06/04/2024', 12500000),
('NV015', N'Nguyễn Minh Khoa', '22/07/1991', '0912345694', '223456789016', 'minhkhoa@gmail.com', N'12 Nguyễn Huệ, Quận 1, TP HCM', 'CV007', '06/04/2024', 12000000),
('NV016', N'Võ Minh Thu', '25/03/1993', '0912345695', '223456789017', 'minhthu@gmail.com', N'6 Hai Bà Trưng, Quận 5, TP HCM', 'CV007', '06/04/2024', 13000000),
('NV017', N'Phạm Bích Dung', '12/06/1992', '0912345696', '223456789018', 'bichdung@gmail.com', N'11 Lý Tự Trọng, Quận 1, TP HCM', 'CV007', '06/04/2024', 13500000),
('NV018', N'Nguyễn Thị Mai', '13/07/1990', '0912345697', '223456789019', 'nguyenmai@gmail.com', N'3 Phan Văn Trị, Quận 5, TP HCM', 'CV007', '06/04/2024', 14000000),
('NV019', N'Lê Minh An', '05/02/1988', '0912345698', '223456789020', 'minhan@gmail.com', N'20 Lê Lai, Quận 1, TP HCM', 'CV007', '06/04/2024', 11000000),
('NV020', N'Hoàng Ngọc Bích', '16/04/1991', '0912345699', '223456789021', 'hoangbich@gmail.com', N'8 Nguyễn Chí Thanh, Quận 3, TP HCM', 'CV007', '06/04/2024', 12000000),

---nhân viên vệ sinh.
('NV021', N'Nguyễn Thị Lan', '23/06/1987', '0912345700', '323456789012', 'lannguyen2@gmail.com', N'15 Nguyễn Tri Phương, Quận 10, TP HCM', 'CV008', '06/04/2024', 10000000),
('NV022', N'Phan Mai Linh', '10/05/1992', '0912345701', '323456789013', 'mailin@gmail.com', N'3 Lý Thường Kiệt, Quận 5, TP HCM', 'CV008', '06/04/2024', 11000000),
('NV023', N'Hoàng Hải Long', '20/02/1991', '0912345702', '323456789014', 'hailong@gmail.com', N'5 Nguyễn Huệ, Quận 3, TP HCM', 'CV008', '06/04/2024', 10500000),
('NV024', N'Nguyễn Minh Tuấn', '16/09/1990', '0912345703', '323456789015', 'minhtuan3@gmail.com', N'12 Nguyễn Thái Bình, Quận 1, TP HCM', 'CV008', '06/04/2024', 10000000),
('NV025', N'Lê Thị Bích', '08/04/1993', '0912345704', '323456789016', 'bichle@gmail.com', N'7 Lê Lai, Quận 5, TP HCM', 'CV008', '06/04/2024', 10000000),
('NV026', N'Võ Minh Thu', '13/03/1994', '0912345705', '323456789017', 'minhthu2@gmail.com', N'15 Đinh Tiên Hoàng, Quận 1, TP HCM', 'CV008', '06/04/2024', 10500000),
('NV027', N'Phạm Thị Dung', '22/06/1991', '0912345706', '323456789018', 'dungpham@gmail.com', N'8 Nguyễn Chí Thanh, Quận 3, TP HCM', 'CV008', '06/04/2024', 11000000),
('NV028', N'Nguyễn Mai Kiều', '30/11/1993', '0912345707', '323456789019', 'maikieu@gmail.com', N'20 Lý Tự Trọng, Quận 1, TP HCM', 'CV008', '06/04/2024', 10500000),
('NV029', N'Lê Minh Tâm', '15/05/1989', '0912345708', '323456789020', 'minhtam@gmail.com', N'5 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV008', '06/04/2024', 10000000),
('NV030', N'Hoàng Ngọc Lan', '25/10/1990', '0912345709', '323456789021', 'hoanglan@gmail.com', N'25 Phan Văn Trị, Quận 5, TP HCM', 'CV008', '06/04/2024', 11000000),

---nhân viên phục vụ nhà hàng.
('NV031', N'Trần Minh Tuấn', '01/12/1987', '0912345710', '423456789012', 'minhtuan9@gmail.com', N'10 Nguyễn Huệ, Quận 1, TP HCM', 'CV009', '06/04/2024', 15000000),
('NV032', N'Lê Thi Mai', '22/09/1990', '0912345711', '423456789013', 'thimai@gmail.com', N'7 Lê Lai, Quận 5, TP HCM', 'CV009', '06/04/2024', 14000000),
('NV033', N'Nguyễn Bảo Chi', '13/05/1994', '0912345712', '423456789014', 'baochi@gmail.com', N'5 Đinh Tiên Hoàng, Quận 1, TP HCM', 'CV009', '06/04/2024', 14500000),
('NV034', N'Hoàng Tiến Dũng', '18/11/1992', '0912345713', '423456789015', 'tiendung@gmail.com', N'3 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV009', '06/04/2024', 15000000),
('NV035', N'Phan Thanh Bình', '27/08/1991', '0912345714', '423456789016', 'thanbinh@gmail.com', N'15 Nguyễn Thái Bình, Quận 1, TP HCM', 'CV009', '06/04/2024', 14000000),
('NV036', N'Lê Thanh Tâm', '14/07/1995', '0912345715', '423456789017', 'thanhtam@gmail.com', N'25 Nguyễn Tri Phương, Quận 3, TP HCM', 'CV009', '06/04/2024', 13000000),
('NV037', N'Nguyễn Hải Duy', '20/03/1993', '0912345716', '423456789018', 'haiduy@gmail.com', N'12 Lý Tự Trọng, Quận 1, TP HCM', 'CV009', '06/04/2024', 13500000),
('NV038', N'Hoàng Thị Bích', '30/10/1990', '0912345717', '423456789019', 'bichhoang@gmail.com', N'10 Lê Lợi, Quận 1, TP HCM', 'CV009', '06/04/2024', 14500000),
('NV039', N'Phan Thị Mai', '03/05/1994', '0912345718', '423456789020', 'thimai2@gmail.com', N'25 Nguyễn Chí Thanh, Quận 5, TP HCM', 'CV009', '06/04/2024', 15000000),
('NV040', N'Nguyễn Minh Tú', '21/07/1988', '0912345719', '423456789021', 'minhtu@gmail.com', N'7 Lý Thường Kiệt, Quận 1, TP HCM', 'CV009', '06/04/2024', 16000000),

---nhân viên bếp.
('NV041', N'Trần Đình Hoàng', '10/03/1986', '0912345720', '523456789012', 'dinhhoang@gmail.com', N'12 Nguyễn Thái Học, Quận 3, TP HCM', 'CV010', '06/04/2024', 18000000),
('NV042', N'Lê Minh Tân', '25/04/1991', '0912345721', '523456789013', 'minhtan@gmail.com', N'6 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV010', '06/04/2024', 17500000),
('NV043', N'Nguyễn Thị Thảo', '18/06/1994', '0912345722', '523456789014', 'thao.nguyen@gmail.com', N'8 Lý Thường Kiệt, Quận 1, TP HCM', 'CV010', '06/04/2024', 19000000),
('NV044', N'Hoàng Thị Hoa', '04/02/1992', '0912345723', '523456789015', 'hoathao@gmail.com', N'10 Nguyễn Trãi, Quận 5, TP HCM', 'CV010', '06/04/2024', 18000000),
('NV045', N'Phan Tùng Lâm', '22/11/1989', '0912345724', '523456789016', 'tunglam@gmail.com', N'3 Nguyễn Thái Bình, Quận 1, TP HCM', 'CV010', '06/04/2024', 18500000),
('NV046', N'Lê Minh Châu', '30/09/1993', '0912345725', '523456789017', 'minhchau@gmail.com', N'15 Lê Lai, Quận 5, TP HCM', 'CV010', '06/04/2024', 17000000),
('NV047', N'Nguyễn Bảo Duy', '25/12/1991', '0912345726', '523456789018', 'baoduy@gmail.com', N'12 Lê Lợi, Quận 1, TP HCM', 'CV010', '06/04/2024', 16500000),
('NV048', N'Hoàng Ngọc Thủy', '07/08/1990', '0912345727', '523456789019', 'hoangthuy@gmail.com', N'5 Đinh Tiên Hoàng, Quận 3, TP HCM', 'CV010', '06/04/2024', 18000000),
('NV049', N'Phan Hải Yến', '15/04/1992', '0912345728', '523456789020', 'haiyen2@gmail.com', N'25 Nguyễn Chí Thanh, Quận 5, TP HCM', 'CV010', '06/04/2024', 17500000),
('NV050', N'Nguyễn Quốc Tuấn', '20/07/1988', '0912345729', '523456789021', 'quoc.tuan@gmail.com', N'20 Lý Tự Trọng, Quận 1, TP HCM', 'CV010', '06/04/2024', 18000000),

---nhân viên quầy bar.
('NV051', N'Lê Thị Thanh', '16/01/1995', '0912345730', '623456789012', 'thanhle@gmail.com', N'3 Phạm Ngọc Thạch, Quận 3, TP HCM', 'CV011', '06/04/2024', 16000000),
('NV052', N'Nguyễn Minh Thi', '25/03/1993', '0912345731', '623456789013', 'minhthi@gmail.com', N'12 Nguyễn Huệ, Quận 1, TP HCM', 'CV011', '06/04/2024', 15500000),
('NV053', N'Hoàng Thị Lan', '03/09/1989', '0912345732', '623456789014', 'hoanglan2@gmail.com', N'10 Lý Tự Trọng, Quận 5, TP HCM', 'CV011', '06/04/2024', 15000000),
('NV054', N'Phan Ngọc Tâm', '10/05/1991', '0912345733', '623456789015', 'ngoctam@gmail.com', N'8 Nguyễn Chí Thanh, Quận 3, TP HCM', 'CV011', '06/04/2024', 14000000),
('NV055', N'Nguyễn Thị Minh', '28/02/1992', '0912345734', '623456789016', 'nguyenminh@gmail.com', N'7 Lê Lai, Quận 1, TP HCM', 'CV011', '06/04/2024', 14500000),
('NV056', N'Trần Đăng Duy', '18/06/1988', '0912345735', '623456789017', 'dangduy@gmail.com', N'5 Đinh Tiên Hoàng, Quận 1, TP HCM', 'CV011', '06/04/2024', 15000000),
('NV057', N'Lê Thị Bảo', '01/09/1990', '0912345736', '623456789018', 'baole@gmail.com', N'12 Nguyễn Trãi, Quận 3, TP HCM', 'CV011', '06/04/2024', 15500000),
('NV058', N'Nguyễn Bảo Tân', '17/07/1993', '0912345737', '623456789019', 'baotan@gmail.com', N'6 Lý Thường Kiệt, Quận 5, TP HCM', 'CV011', '06/04/2024', 16000000),
('NV059', N'Hoàng Minh Tín', '20/02/1994', '0912345738', '623456789020', 'minhtin@gmail.com', N'8 Nguyễn Thái Học, Quận 1, TP HCM', 'CV011', '06/04/2024', 14500000),
('NV060', N'Phan Thiên Hương', '12/04/1991', '0912345739', '623456789021', 'thienhuong@gmail.com', N'3 Nguyễn Thiện Thuật, Quận 5, TP HCM', 'CV011', '06/04/2024', 15000000),

---nhân viên bảo trì, kỹ thuật.
('NV061', N'Nguyễn Minh Hòa', '22/02/1987', '0912345740', '723456789012', 'minhhoa@gmail.com', N'5 Lý Thường Kiệt, Quận 3, TP HCM', 'CV012', '06/04/2024', 22000000),
('NV062', N'Trần Thị Bích', '14/03/1992', '0912345741', '723456789013', 'bichtran@gmail.com', N'7 Nguyễn Chí Thanh, Quận 1, TP HCM', 'CV012', '06/04/2024', 23000000),
('NV063', N'Hoàng Minh Tân', '19/06/1988', '0912345742', '723456789014', 'minhtan2@gmail.com', N'10 Đinh Tiên Hoàng, Quận 5, TP HCM', 'CV012', '06/04/2024', 24000000),
('NV064', N'Lê Thi Lan', '17/07/1990', '0912345743', '723456789015', 'thilan1@gmail.com', N'15 Lý Tự Trọng, Quận 1, TP HCM', 'CV012', '06/04/2024', 22500000),
('NV065', N'Nguyễn Bảo Trân', '05/02/1991', '0912345744', '723456789016', 'baotran@gmail.com', N'25 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV012', '06/04/2024', 23000000),
('NV066', N'Phan Thi Hoàng', '26/11/1993', '0912345745', '723456789017', 'thihoang@gmail.com', N'3 Nguyễn Lương Bằng, Quận 1, TP HCM', 'CV012', '06/04/2024', 21500000),
('NV067', N'Lê Minh Quang', '10/01/1990', '0912345746', '723456789018', 'minhquang@gmail.com', N'6 Nguyễn Trãi, Quận 3, TP HCM', 'CV012', '06/04/2024', 22000000),
('NV068', N'Hoàng Thị Mỹ', '23/09/1992', '0912345747', '723456789019', 'mymhoang@gmail.com', N'20 Lý Tự Trọng, Quận 5, TP HCM', 'CV012', '06/04/2024', 23000000),
('NV069', N'Nguyễn Thị Bảo', '04/08/1994', '0912345748', '723456789020', 'baonguyen@gmail.com', N'7 Nguyễn Thiện Thuật, Quận 1, TP HCM', 'CV012', '06/04/2024', 24000000),
('NV070', N'Phan Quỳnh Lan', '13/03/1988', '0912345749', '723456789021', 'quynhlan@gmail.com', N'15 Nguyễn Huệ, Quận 3, TP HCM', 'CV012', '06/04/2024', 22500000),

---nhân viên kho.
('NV071', N'Nguyễn Thi Thanh', '02/05/1993', '0912345750', '823456789012', 'thithanh@gmail.com', N'12 Lý Tự Trọng, Quận 5, TP HCM', 'CV013', '06/04/2024', 15000000),
('NV072', N'Phan Minh Thịnh', '28/08/1991', '0912345751', '823456789013', 'minhthinh@gmail.com', N'15 Đinh Tiên Hoàng, Quận 1, TP HCM', 'CV013', '06/04/2024', 14500000),
('NV073', N'Hoàng Thị Bích', '17/11/1989', '0912345752', '823456789014', 'hoangbich2@gmail.com', N'5 Nguyễn Thái Học, Quận 3, TP HCM', 'CV013', '06/04/2024', 15000000),
('NV074', N'Lê Quý Trân', '06/10/1992', '0912345753', '823456789015', 'quytran@gmail.com', N'12 Nguyễn Huệ, Quận 5, TP HCM', 'CV013', '06/04/2024', 14000000),
('NV075', N'Nguyễn Tiến Lộc', '09/01/1987', '0912345754', '823456789016', 'tienloc@gmail.com', N'25 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV013', '06/04/2024', 13500000),
('NV076', N'Hoàng Minh Duy', '15/02/1994', '0912345755', '823456789017', 'minhduy2@gmail.com', N'30 Phạm Ngọc Thạch, Quận 5, TP HCM', 'CV013', '06/04/2024', 14000000),
('NV077', N'Phan Thị Nhung', '20/09/1990', '0912345756', '823456789018', 'thinhung@gmail.com', N'5 Nguyễn Lương Bằng, Quận 3, TP HCM', 'CV013', '06/04/2024', 13000000),
('NV078', N'Lê Minh Tâm', '17/07/1988', '0912345757', '823456789019', 'minhtam2@gmail.com', N'12 Lý Tự Trọng, Quận 1, TP HCM', 'CV013', '06/04/2024', 14500000),
('NV079', N'Nguyễn Phú Quý', '22/11/1991', '0912345758', '823456789020', 'phuquy@gmail.com', N'10 Lê Lai, Quận 1, TP HCM', 'CV013', '06/04/2024', 15000000),
('NV080', N'Hoàng Phú Thái', '28/12/1990', '0912345759', '823456789021', 'phuthai@gmail.com', N'25 Nguyễn Thái Bình, Quận 3, TP HCM', 'CV013', '06/04/2024', 13500000),

---nhân viên an ninh.
('NV081', N'Nguyễn Minh Tuấn', '10/03/1986', '0912345760', '923456789012', 'minhtuan4@gmail.com', N'7 Lý Thường Kiệt, Quận 5, TP HCM', 'CV014', '06/04/2024', 16000000),
('NV082', N'Lê Thi Hoàng', '22/06/1992', '0912345761', '923456789013', 'hoangthi@gmail.com', N'3 Nguyễn Huệ, Quận 1, TP HCM', 'CV014', '06/04/2024', 15500000),
('NV083', N'Nguyễn Bảo Quân', '18/09/1991', '0912345762', '923456789014', 'baoson@gmail.com', N'12 Nguyễn Lương Bằng, Quận 1, TP HCM', 'CV014', '06/04/2024', 15000000),
('NV084', N'Phan Thị Tuyết', '03/05/1989', '0912345763', '923456789015', 'thituyet@gmail.com', N'6 Lý Tự Trọng, Quận 5, TP HCM', 'CV014', '06/04/2024', 16000000),
('NV085', N'Hoàng Thị Lan', '27/07/1993', '0912345764', '923456789016', 'lanhoang@gmail.com', N'10 Nguyễn Chí Thanh, Quận 3, TP HCM', 'CV014', '06/04/2024', 17000000),
('NV086', N'Nguyễn Minh Kiên', '15/02/1990', '0912345765', '923456789017', 'minhkien@gmail.com', N'8 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV014', '06/04/2024', 15500000),
('NV087', N'Lê Quỳnh Anh', '23/06/1994', '0912345766', '923456789018', 'quynhanh@gmail.com', N'7 Nguyễn Chí Thanh, Quận 5, TP HCM', 'CV014', '06/04/2024', 15000000),
('NV088', N'Phan Tiến Thành', '11/11/1992', '0912345767', '923456789019', 'tienthanh@gmail.com', N'20 Nguyễn Huệ, Quận 1, TP HCM', 'CV014', '06/04/2024', 14000000),
('NV089', N'Nguyễn Quốc Hưng', '04/03/1987', '0912345768', '923456789020', 'quochung@gmail.com', N'5 Nguyễn Thái Bình, Quận 3, TP HCM', 'CV014', '06/04/2024', 16000000),
('NV090', N'Hoàng Thái Hòa', '01/08/1991', '0912345769', '923456789021', 'thaithai@gmail.com', N'8 Đinh Tiên Hoàng, Quận 5, TP HCM', 'CV014', '06/04/2024', 14500000),

---nhân viên chăm sóc khách hàng.
('NV091', N'Nguyễn Thị Mỹ Linh', '14/06/1990', '0912345770', '023456789012', 'mylinh@gmail.com', N'10 Nguyễn Huệ, Quận 1, TP HCM', 'CV015', '06/04/2024', 17000000),
('NV092', N'Lê Thi Thảo', '03/04/1991', '0912345771', '023456789013', 'thao.le@gmail.com', N'15 Đinh Tiên Hoàng, Quận 3, TP HCM', 'CV015', '06/04/2024', 16000000),
('NV093', N'Hoàng Quang Huy', '20/07/1988', '0912345772', '023456789014', 'quanghuy@gmail.com', N'7 Nguyễn Thái Bình, Quận 5, TP HCM', 'CV015', '06/04/2024', 15500000),
('NV094', N'Phan Thị Thanh Mai', '02/12/1992', '0912345773', '023456789015', 'thanhtmai@gmail.com', N'6 Nguyễn Chí Thanh, Quận 1, TP HCM', 'CV015', '06/04/2024', 14500000),
('NV095', N'Nguyễn Quỳnh Anh', '05/08/1994', '0912345774', '023456789016', 'quynhanh1@gmail.com', N'10 Nguyễn Lương Bằng, Quận 5, TP HCM', 'CV015', '06/04/2024', 15000000),
('NV096', N'Lê Quốc Anh', '18/03/1993', '0912345775', '023456789017', 'quocanh2@gmail.com', N'8 Lý Thường Kiệt, Quận 3, TP HCM', 'CV015', '06/04/2024', 16500000),
('NV097', N'Hoàng Thị Phương', '10/09/1991', '0912345776', '023456789018', 'phuonghoang@gmail.com', N'12 Lê Lai, Quận 1, TP HCM', 'CV015', '06/04/2024', 15500000),
('NV098', N'Nguyễn Thiên Hương', '20/11/1990', '0912345777', '023456789019', 'thienhuongnguyen@gmail.com', N'15 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV015', '06/04/2024', 14500000),
('NV099', N'Phan Minh Tú', '14/07/1989', '0912345778', '023456789020', 'minhtu8@gmail.com', N'10 Nguyễn Chí Thanh, Quận 3, TP HCM', 'CV015', '06/04/2024', 16000000),
('NV100', N'Lê Thi Thanh Tuyền', '25/10/1992', '0912345779', '023456789021', 'thituyentle@gmail.com', N'8 Đinh Tiên Hoàng, Quận 1, TP HCM', 'CV015', '06/04/2024', 15000000),

---nhân viên spa.
('NV101', N'Nguyễn Thị Hương', '02/06/1988', '0912345780', '123456789014', 'huongnguyen@gmail.com', N'5 Nguyễn Thiện Thuật, Quận 1, TP HCM', 'CV016', '06/04/2024', 20000000),
('NV102', N'Lê Thị Lan', '11/04/1991', '0912345781', '123456789019', 'lanle@gmail.com', N'12 Nguyễn Huệ, Quận 5, TP HCM', 'CV016', '06/04/2024', 21000000),
('NV103', N'Hoàng Tiến Duy', '18/02/1992', '0912345782', '123456789014', 'tienduy@gmail.com', N'8 Lý Thường Kiệt, Quận 3, TP HCM', 'CV016', '06/04/2024', 19000000),
('NV104', N'Phan Thị Mai', '27/09/1993', '0912345783', '123456789015', 'thimai3@gmail.com', N'20 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV016', '06/04/2024', 20000000),
('NV105', N'Nguyễn Minh Đức', '02/05/1989', '0912345784', '123456789016', 'minhduc@gmail.com', N'15 Đinh Tiên Hoàng, Quận 5, TP HCM', 'CV016', '06/04/2024', 22000000),
('NV106', N'Lê Quý Tâm', '15/07/1991', '0912345785', '123456789017', 'quytam@gmail.com', N'12 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV016', '06/04/2024', 21500000),
('NV107', N'Hoàng Thi Lan', '04/12/1994', '0912345786', '123456789018', 'lanhoang2@gmail.com', N'7 Nguyễn Lương Bằng, Quận 3, TP HCM', 'CV016', '06/04/2024', 21000000),
('NV108', N'Nguyễn Thị Quỳnh', '17/10/1992', '0912345787', '123456789019', 'quynhnguyen@gmail.com', N'8 Nguyễn Chí Thanh, Quận 1, TP HCM', 'CV016', '06/04/2024', 20500000),
('NV109', N'Phan Minh Kiên', '09/08/1987', '0912345788', '123456789020', 'minhkien2@gmail.com', N'25 Nguyễn Huệ, Quận 3, TP HCM', 'CV016', '06/04/2024', 22000000),
('NV110', N'Lê Bảo Minh', '23/06/1993', '0912345789', '123456789021', 'baominh@gmail.com', N'5 Nguyễn Thái Bình, Quận 5, TP HCM', 'CV016', '06/04/2024', 21000000),

---nhân viên marketing.
('NV111', N'Nguyễn Bảo Khánh', '13/07/1990', '0912345790', '223456789020', 'baokhanh@gmail.com', N'10 Lý Thường Kiệt, Quận 3, TP HCM', 'CV017', '06/04/2024', 25000000),
('NV112', N'Phan Thi Thanh', '06/04/1991', '0912345791', '223456789013', 'thanhphan@gmail.com', N'8 Nguyễn Chí Thanh, Quận 1, TP HCM', 'CV017', '06/04/2024', 26000000),
('NV113', N'Lê Quang Huy', '19/02/1989', '0912345792', '223456789014', 'quanghuy2@gmail.com', N'15 Đinh Tiên Hoàng, Quận 5, TP HCM', 'CV017', '06/04/2024', 24000000),
('NV114', N'Nguyễn Thị Tuyết', '11/12/1994', '0912345793', '223456789015', 'tuyetnguyen@gmail.com', N'5 Nguyễn Thiện Thuật, Quận 1, TP HCM', 'CV017', '06/04/2024', 23000000),
('NV115', N'Hoàng Thi Duyên', '29/03/1993', '0912345794', '223456789016', 'thiduyen@gmail.com', N'10 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV017', '06/04/2024', 25000000),
('NV116', N'Phan Quang Lâm', '25/01/1992', '0912345795', '223456789017', 'quanglam@gmail.com', N'8 Nguyễn Huệ, Quận 3, TP HCM', 'CV017', '06/04/2024', 24000000),
('NV117', N'Lê Minh Thạch', '18/07/1988', '0912345796', '223456789018', 'minhthach@gmail.com', N'20 Lý Tự Trọng, Quận 1, TP HCM', 'CV017', '06/04/2024', 23000000),
('NV118', N'Nguyễn Hồng Linh', '10/06/1991', '0912345797', '223456789019', 'honglinh@gmail.com', N'15 Nguyễn Thái Bình, Quận 5, TP HCM', 'CV017', '06/04/2024', 24000000),
('NV119', N'Hoàng Minh Thu', '23/10/1994', '0912345798', '223456789020', 'minhthu5@gmail.com', N'5 Đinh Tiên Hoàng, Quận 1, TP HCM', 'CV017', '06/04/2024', 25000000),
('NV120', N'Phan Thi Thanh Sơn', '15/04/1992', '0912345799', '223456789021', 'thanhtson@gmail.com', N'10 Nguyễn Tri Phương, Quận 3, TP HCM', 'CV017', '06/04/2024', 24500000),

---nhân viên kế toán.
('NV121', N'Nguyễn Hoàng Bảo', '25/12/1990', '0912345800', '323456789012', 'baonhnguyen@gmail.com', N'12 Lý Thường Kiệt, Quận 1, TP HCM', 'CV018', '06/04/2024', 27000000),
('NV122', N'Phan Hồng Minh', '13/11/1987', '0912345801', '323456789013', 'hongminh@gmail.com', N'15 Nguyễn Lương Bằng, Quận 5, TP HCM', 'CV018', '06/04/2024', 28000000),
('NV123', N'Lê Thi Bảo Ngọc', '05/03/1992', '0912345802', '323456789014', 'baongoc@gmail.com', N'25 Nguyễn Chí Thanh, Quận 3, TP HCM', 'CV018', '06/04/2024', 26000000),
('NV124', N'Nguyễn Thanh Hòa', '20/06/1989', '0912345803', '323456789015', 'thanhhoa@gmail.com', N'10 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV018', '06/04/2024', 25000000),
('NV125', N'Hoàng Minh Thư', '18/05/1991', '0912345804', '323456789016', 'minhthu6@gmail.com', N'8 Lý Tự Trọng, Quận 3, TP HCM', 'CV018', '06/04/2024', 24000000),
('NV126', N'Phan Tiến Duy', '08/08/1993', '0912345805', '323456789017', 'tienduy1@gmail.com', N'12 Nguyễn Huệ, Quận 5, TP HCM', 'CV018', '06/04/2024', 23000000),
('NV127', N'Lê Quỳnh Tiên', '22/02/1994', '0912345806', '323456789018', 'quynhtiend@gmail.com', N'6 Nguyễn Thiện Thuật, Quận 1, TP HCM', 'CV018', '06/04/2024', 22000000),
('NV128', N'Nguyễn Tiến Bảo', '17/09/1990', '0912345807', '323456789019', 'tienbao@gmail.com', N'15 Nguyễn Thái Bình, Quận 3, TP HCM', 'CV018', '06/04/2024', 21000000),
('NV129', N'Hoàng Thi Lan', '03/07/1992', '0912345808', '323456789020', 'thanhlan@gmail.com', N'10 Nguyễn Chí Thanh, Quận 1, TP HCM', 'CV018', '06/04/2024', 23000000),
('NV130', N'Phan Thi Hồng', '16/04/1991', '0912345809', '323456789021', 'hongphan@gmail.com', N'20 Đinh Tiên Hoàng, Quận 5, TP HCM', 'CV018', '06/04/2024', 24000000),

---nhân viên hành chính.
('NV131', N'Nguyễn Thu Thảo', '29/05/1990', '0912345810', '423456789012', 'thuthao@gmail.com', N'15 Nguyễn Lương Bằng, Quận 1, TP HCM', 'CV019', '06/04/2024', 19000000),
('NV132', N'Phan Hùng Duy', '23/12/1988', '0912345811', '423456789013', 'hungduy@gmail.com', N'12 Nguyễn Tri Phương, Quận 3, TP HCM', 'CV019', '06/04/2024', 20000000),
('NV133', N'Lê Quang Thanh', '19/09/1994', '0912345812', '423456789014', 'quangthanh@gmail.com', N'8 Lý Thường Kiệt, Quận 1, TP HCM', 'CV019', '06/04/2024', 18000000),
('NV134', N'Hoàng Thi Thanh', '11/03/1991', '0912345813', '423456789015', 'thithanh1@gmail.com', N'5 Nguyễn Thiện Thuật, Quận 5, TP HCM', 'CV019', '06/04/2024', 17000000),
('NV135', N'Nguyễn Minh Quyền', '08/10/1993', '0912345814', '423456789016', 'minhquyen@gmail.com', N'25 Đinh Tiên Hoàng, Quận 3, TP HCM', 'CV019', '06/04/2024', 19000000),
('NV136', N'Phan Minh Tín', '14/07/1992', '0912345815', '423456789017', 'minhtin1@gmail.com', N'12 Nguyễn Chí Thanh, Quận 1, TP HCM', 'CV019', '06/04/2024', 18500000),
('NV137', N'Lê Thi Khánh', '20/02/1990', '0912345816', '423456789018', 'khanhle@gmail.com', N'15 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV019', '06/04/2024', 20000000),
('NV138', N'Hoàng Quý Bình', '10/11/1991', '0912345817', '423456789019', 'quybinh@gmail.com', N'7 Nguyễn Huệ, Quận 3, TP HCM', 'CV019', '06/04/2024', 21000000),
('NV139', N'Nguyễn Thị Bình', '22/05/1989', '0912345818', '423456789020', 'binhnguyen@gmail.com', N'25 Nguyễn Lương Bằng, Quận 1, TP HCM', 'CV019', '06/04/2024', 18000000),
('NV140', N'Phan Hồng Thái', '02/09/1992', '0912345819', '423456789021', 'hongthai@gmail.com', N'10 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV019', '06/04/2024', 19000000),

---nhân viên tổ chức sự kiện.
('NV141', N'Lê Minh Hữu', '09/01/1990', '0912345820', '523456789012', 'minhhuu@gmail.com', N'20 Nguyễn Huệ, Quận 1, TP HCM', 'CV020', '06/04/2024', 22000000),
('NV142', N'Nguyễn Tiến Tân', '23/12/1991', '0912345821', '523456789013', 'tientan@gmail.com', N'8 Đinh Tiên Hoàng, Quận 3, TP HCM', 'CV020', '06/04/2024', 23000000),
('NV143', N'Phan Minh Hoa', '15/04/1994', '0912345822', '523456789014', 'minhhoa1@gmail.com', N'15 Nguyễn Chí Thanh, Quận 5, TP HCM', 'CV020', '06/04/2024', 24000000),
('NV144', N'Hoàng Quý Hòa', '20/09/1988', '0912345823', '523456789015', 'quyhoa@gmail.com', N'7 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV020', '06/04/2024', 25000000),
('NV145', N'Lê Thi Tuyết', '10/06/1992', '0912345824', '523456789016', 'thituyet1@gmail.com', N'5 Nguyễn Lương Bằng, Quận 3, TP HCM', 'CV020', '06/04/2024', 26000000),
('NV146', N'Nguyễn Thanh Tú', '05/03/1993', '0912345825', '523456789017', 'thanhtu@gmail.com', N'8 Nguyễn Thiện Thuật, Quận 5, TP HCM', 'CV020', '06/04/2024', 27000000),
('NV147', N'Phan Minh Thi', '07/10/1990', '0912345826', '523456789018', 'minhthi1@gmail.com', N'15 Nguyễn Tri Phương, Quận 1, TP HCM', 'CV020', '06/04/2024', 24000000),
('NV148', N'Lê Quang Kiên', '22/02/1994', '0912345827', '523456789019', 'quangkien@gmail.com', N'10 Lý Thường Kiệt, Quận 5, TP HCM', 'CV020', '06/04/2024', 25000000),
('NV149', N'Hoàng Minh Thức', '30/08/1991', '0912345828', '523456789020', 'minhthuc@gmail.com', N'12 Nguyễn Huệ, Quận 3, TP HCM', 'CV020', '06/04/2024', 26000000),
('NV150', N'Nguyễn Thị Minh', '10/04/1992', '0912345829', '523456789021', 'minhnguyen@gmail.com', N'20 Nguyễn Lương Bằng, Quận 1, TP HCM', 'CV020', '06/04/2024', 23000000),

---nhân viên bán hàng
('NV151', N'Nguyễn Thanh Hải', '28/11/1991', '0912345830', '623456789012', 'thanhhai@gmail.com', N'12 Nguyễn Huệ, Quận 3, TP HCM', 'CV021', '06/04/2024', 22000000),
('NV152', N'Phan Thị Mai Linh', '13/07/1990', '0912345831', '623456789013', 'mailinhlien@gmail.com', N'15 Nguyễn Lương Bằng, Quận 1, TP HCM', 'CV021', '06/04/2024', 23000000),
('NV153', N'Lê Thị Lan Hương', '21/02/1992', '0912345832', '623456789014', 'lanhuong@gmail.com', N'10 Đinh Tiên Hoàng, Quận 5, TP HCM', 'CV021', '06/04/2024', 24000000),
('NV154', N'Nguyễn Phú Quý', '02/03/1994', '0912345833', '623456789015', 'phuquy1@gmail.com', N'25 Nguyễn Thái Bình, Quận 3, TP HCM', 'CV021', '06/04/2024', 25000000),
('NV155', N'Hoàng Thị Thảo Nguyên', '17/09/1991', '0912345834', '623456789016', 'thaonguyen@gmail.com', N'8 Nguyễn Thiện Thuật, Quận 1, TP HCM', 'CV021', '06/04/2024', 26000000),
('NV156', N'Phan Quang Học', '22/05/1990', '0912345835', '623456789017', 'quanghoc@gmail.com', N'7 Nguyễn Tri Phương, Quận 5, TP HCM', 'CV021', '06/04/2024', 27000000),
('NV157', N'Lê Thi Bảo Quỳnh', '08/10/1993', '0912345836', '623456789018', 'baothi@gmail.com', N'10 Lý Tự Trọng, Quận 1, TP HCM', 'CV021', '06/04/2024', 22000000),
('NV158', N'Nguyễn Kim Duy', '03/04/1992', '0912345837', '623456789019', 'kimduy@gmail.com', N'15 Nguyễn Chí Thanh, Quận 3, TP HCM', 'CV021', '06/04/2024', 23000000),
('NV159', N'Hoàng Thị Trúc Mai', '06/08/1990', '0912345838', '623456789020', 'trucmai@gmail.com', N'5 Nguyễn Lương Bằng, Quận 1, TP HCM', 'CV021', '06/04/2024', 24000000),
('NV160', N'Phan Minh Tâm', '18/12/1993', '0912345839', '623456789021', 'minhtam1@gmail.com', N'20 Nguyễn Thái Bình, Quận 5, TP HCM', 'CV021', '06/04/2024', 25000000);

-----KHÁCH HÀNG

go
insert into KhachHang (MaKH, TenKH, SoDT, NgaySinh, GioiTinh, Diachi, Email, CCCD, QuocTich) values
('KH0001', N'Nguyễn Thị Mai', '0123456789', '1985/06/15', N'Nữ', N'Hà Nội', 'mai.yen@email.com', '123456789012', N'Việt Nam'),
('KH0002', N'Lê Minh Tú', '0987654321', '1990/08/20', N'Nam', N'Hà Nội', 'tu.le@email.com', '234567890123', N'Việt Nam'),
('KH0003', N'Phạm Lan Anh', '0912345678', '1988/04/05', N'Nữ', N'Hà Nội', 'lan.anh@email.com', '345678901234', N'Việt Nam'),
('KH0004', N'Trương Quốc Anh', '0909876543', '1995/02/12', N'Nam', N'Hà Nội', 'quoc.anh@email.com', '456789012345', N'Việt Nam'),
('KH0005', N'Nguyễn Hoàng Nam', '0934123456', '1992/11/22', N'Nam', N'TP. Hồ Chí Minh', 'hoangnam.nguyen@email.com', '567890123456', N'Việt Nam'),
('KH0006', N'Hồ Thị Lan', '0976123456', '1987/09/17', N'Nữ', N'Hà Nội', 'lan.ho@email.com', '678901234567', N'Việt Nam'),
('KH0007', N'Phan Minh Tuấn', '0965123456', '1993/10/11', N'Nam', N'Đà Nẵng', 'tuan.phan@email.com', '789012345678', N'Việt Nam'),
('KH0008', N'Nguyễn Văn Hải', '0906345123', '1986/02/25', N'Nam', N'TP. Hồ Chí Minh', 'hai.nguyen@email.com', '890123456789', N'Việt Nam'),
('KH0009', N'Trần Minh Tâm', '0912340987', '1994/07/30', N'Nam', N'Hải Phòng', 'tam.tran@email.com', '901234567890', N'Việt Nam'),
('KH0010', N'Võ Thị Thu', '0987123456', '1987/12/10', N'Nữ', N'Đà Nẵng', 'thu.vo@email.com', '012345678901', N'Việt Nam'),
('KH0011', N'Nguyễn Đình Mạnh', '0967890123', '1991/03/17', N'Nam', N'Bình Dương', 'manh.nguyen@email.com', '123456789234', N'Việt Nam'),
('KH0012', N'Hoàng Thanh Tuyền', '0935612345', '1995/01/05', N'Nữ', N'TP. Hồ Chí Minh', 'tuyen.hoang@email.com', '234567890345', N'Việt Nam'),
('KH0013', N'Phan Thanh Bình', '0905346789', '1993/06/15', N'Nam', N'Hà Nội', 'binh.phan@email.com', '345678901456', N'Việt Nam'),
('KH0014', N'Phạm Thị Hương', '0912564789', '1992/11/22', N'Nữ', N'Đà Nẵng', 'huong.pham@email.com', '456789012567', N'Việt Nam'),
('KH0015', N'Trần Duy Phước', '0945123678', '1990/09/08', N'Nam', N'Hà Nội', 'phuoc.tran@email.com', '567890123678', N'Việt Nam'),
('KH0016', N'Nguyễn Thị Thanh', '0976345210', '1988/04/17', N'Nữ', N'Hà Nội', 'thanh.nguyen@email.com', '678901234789', N'Việt Nam'),
('KH0017', N'Lê Thiên An', '0901234567', '1991/05/25', N'Nữ', N'TP. Hồ Chí Minh', 'an.le@email.com', '789012345890', N'Việt Nam'),
('KH0018', N'Võ Minh Hoàng', '0968745632', '1989/01/14', N'Nam', N'Hà Nội', 'hoang.vo@email.com', '890123456901', N'Việt Nam'),
('KH0019', N'Nguyễn Mạnh Hùng', '0913456789', '1994/10/12', N'Nam', N'TP. Hồ Chí Minh', 'hung.nguyen@email.com', '901234567012', N'Việt Nam'),
('KH0020', N'Trương Thị Lan', '0923456789', '1996/06/03', N'Nữ', N'Hải Phòng', 'lan.truong@email.com', '012345678123', N'Việt Nam'),
('KH0021', N'Nguyễn Minh Tuấn', '0934567890', '1993/02/25', N'Nam', N'Hà Nội', 'tuan.nguyen@email.com', '234567890123', N'Việt Nam'),
('KH0022', N'Phan Thị Thu', '0902123456', '1989/04/30', N'Nữ', N'Đà Nẵng', 'thu.phan@email.com', '345678901234', N'Việt Nam'),
('KH0023', N'Võ Thị Bích', '0978123456', '1992/07/05', N'Nữ', N'TP. Hồ Chí Minh', 'bich.vo@email.com', '456789012345', N'Việt Nam'),
('KH0024', N'Nguyễn Thị Lan', '0912345678', '1990/09/21', N'Nữ', N'Hà Nội', 'lan.nguyen@email.com', '567890123456', N'Việt Nam'),
('KH0025', N'Nguyễn Hoàng Thắng', '0965789123', '1994/12/02', N'Nam', N'TP. Hồ Chí Minh', 'thang.nguyen@email.com', '678901234567', N'Việt Nam'),
('KH0026', N'Phạm Tuấn Kiệt', '0932567890', '1991/11/19', N'Nam', N'Hải Phòng', 'kiet.pham@email.com', '789012345678', N'Việt Nam'),
('KH0027', N'Lê Thanh Thảo', '0904234567', '1988/06/10', N'Nữ', N'Đà Nẵng', 'thao.le@email.com', '890123456789', N'Việt Nam'),
('KH0028', N'Võ Ngọc Bảo', '0912789654', '1992/01/05', N'Nam', N'TP. Hồ Chí Minh', 'bao.vo@email.com', '901234567890', N'Việt Nam'),
('KH0029', N'Trương Quang Huy', '0904789653', '1993/10/15', N'Nam', N'Hà Nội', 'huy.truong@email.com', '012345678901', N'Việt Nam'),
('KH0030', N'Nguyễn Kim Liên', '0971564789', '1991/04/07', N'Nữ', N'Hải Phòng', 'lien.nguyen@email.com', '123456789012', N'Việt Nam'),
('KH0031', N'Phan Quang Tuấn', '0903654789', '1995/08/15', N'Nam', N'TP. Hồ Chí Minh', 'tuan.phan@email.com', '234567890123', N'Việt Nam'),
('KH0032', N'Trần Đình Mạnh', '0982435789', '1990/03/03', N'Nam', N'Hà Nội', 'manh.tran@email.com', '345678901234', N'Việt Nam'),
('KH0033', N'Nguyễn Thị Tuyết', '0913456879', '1987/05/24', N'Nữ', N'TP. Hồ Chí Minh', 'tuyet.nguyen@email.com', '456789012345', N'Việt Nam'),
('KH0034', N'Hoàng Thị Bích', '0962345678', '1992/01/11', N'Nữ', N'Đà Nẵng', 'bich.hoang@email.com', '567890123456', N'Việt Nam'),
('KH0035', N'Võ Quang Hiếu', '0975678943', '1994/06/15', N'Nam', N'Hải Phòng', 'hieu.vo@email.com', '678901234567', N'Việt Nam'),
('KH0036', N'Nguyễn Thị Nhung', '0904567890', '1989/07/22', N'Nữ', N'TP. Hồ Chí Minh', 'nhung.nguyen@email.com', '789012345678', N'Việt Nam'),
('KH0037', N'Phan Thành Công', '0961234789', '1990/08/12', N'Nam', N'Hà Nội', 'cong.phan@email.com', '890123456789', N'Việt Nam'),
('KH0038', N'Võ Thị Tường', '0906547891', '1995/09/09', N'Nữ', N'Đà Nẵng', 'tuong.vo@email.com', '901234567890', N'Việt Nam'),
('KH0039', N'Lê Tuấn Anh', '0934678901', '1994/12/20', N'Nam', N'TP. Hồ Chí Minh', 'anh.le@email.com', '012345678901', N'Việt Nam'),
('KH0040', N'Nguyễn Thị Như', '0912678912', '1991/04/17', N'Nữ', N'Hà Nội', 'nhu.nguyen@email.com', '123456789234', N'Việt Nam'),
('KH0041', N'Phan Minh Triết', '0987654321', '1992/09/22', N'Nam', N'Hải Phòng', 'triet.phan@email.com', '234567890345', N'Việt Nam'),
('KH0042', N'Hoàng Minh Tuấn', '0901122334', '1993/05/15', N'Nam', N'TP. Hồ Chí Minh', 'tuan.hoang@email.com', '345678901456', N'Việt Nam'),
('KH0043', N'Nguyễn Quỳnh Hoa', '0976123456', '1991/10/10', N'Nữ', N'Hà Nội', 'hoa.nguyen@email.com', '456789012567', N'Việt Nam'),
('KH0044', N'Phan Minh Hải', '0961234987', '1990/06/28', N'Nam', N'TP. Hồ Chí Minh', 'hai.phan@email.com', '567890123678', N'Việt Nam'),
('KH0045', N'Võ Đình Cảnh', '0916789321', '1995/11/18', N'Nam', N'Đà Nẵng', 'canh.vo@email.com', '678901234789', N'Việt Nam'),
('KH0046', N'Nguyễn Minh Tú', '0906543210', '1994/04/23', N'Nam', N'TP. Hồ Chí Minh', 'tu.nguyen@email.com', '789012345890', N'Việt Nam'),
('KH0047', N'Nguyễn Văn Duy', '0965412378', '1995/02/17', N'Nam', N'Hà Nội', 'duy.nguyen@email.com', '234567890654', N'Việt Nam'),
('KH0048', N'Phan Thiên An', '0936587432', '1991/11/06', N'Nữ', N'Đà Nẵng', 'an.phan@email.com', '345678901765', N'Việt Nam'),
('KH0049', N'Võ Ngọc Minh', '0912457896', '1992/03/15', N'Nam', N'TP. Hồ Chí Minh', 'minh.vo@email.com', '456789012876', N'Việt Nam'),
('KH0050', N'Nguyễn Thị Cẩm', '0904536879', '1994/08/30', N'Nữ', N'Hải Phòng', 'cam.nguyen@email.com', '567890123987', N'Việt Nam'),
('KH0051', N'Phạm Quang Duy', '0976341567', '1990/12/12', N'Nam', N'TP. Hồ Chí Minh', 'duy.pham@email.com', '678901234098', N'Việt Nam'),
('KH0052', N'Hoàng Thị Thuý', '0968745123', '1987/10/22', N'Nữ', N'Hà Nội', 'thuy.hoang@email.com', '789012345209', N'Việt Nam'),
('KH0053', N'Lê Thanh Tùng', '0915647382', '1995/03/09', N'Nam', N'Đà Nẵng', 'tung.le@email.com', '890123456310', N'Việt Nam'),
('KH0054', N'Võ Hoàng Ngọc', '0905632978', '1991/07/01', N'Nam', N'TP. Hồ Chí Minh', 'ngoc.vo@email.com', '901234567421', N'Việt Nam'),
('KH0055', N'Nguyễn Hữu Thanh', '0987654320', '1992/05/25', N'Nam', N'Hải Phòng', 'thanh.nguyen@email.com', '012345678532', N'Việt Nam'),
('KH0056', N'Phan Quang Hiền', '0912345670', '1993/06/07', N'Nữ', N'TP. Hồ Chí Minh', 'hien.phan@email.com', '123456789643', N'Việt Nam'),
('KH0057', N'Lê Tuấn Kiệt', '0976123451', '1990/01/23', N'Nam', N'Hà Nội', 'kiet.le@email.com', '234567890754', N'Việt Nam'),
('KH0058', N'Võ Đình Sơn', '0965432123', '1994/04/15', N'Nam', N'TP. Hồ Chí Minh', 'son.vo@email.com', '345678901865', N'Việt Nam'),
('KH0059', N'Nguyễn Thị Quỳnh', '0912345673', '1992/12/18', N'Nữ', N'Đà Nẵng', 'quynh.nguyen@email.com', '456789012976', N'Việt Nam'),
('KH0060', N'Phạm Thanh Mai', '0976543210', '1993/02/10', N'Nữ', N'TP. Hồ Chí Minh', 'mai.pham@email.com', '567890123087', N'Việt Nam'),
('KH0061', N'Võ Minh Tài', '0905674321', '1995/03/03', N'Nam', N'Hải Phòng', 'tai.vo@email.com', '678901234198', N'Việt Nam'),
('KH0062', N'Nguyễn Quang Hải', '0918765432', '1991/09/21', N'Nam', N'TP. Hồ Chí Minh', 'hai.nguyen@email.com', '789012345209', N'Việt Nam'),
('KH0063', N'Phan Thanh Hưng', '0907654323', '1990/05/07', N'Nam', N'Đà Nẵng', 'hung.phan@email.com', '890123456310', N'Việt Nam'),
('KH0064', N'Võ Thị Tịnh', '0965432710', '1992/11/18', N'Nữ', N'TP. Hồ Chí Minh', 'tinh.vo@email.com', '901234567421', N'Việt Nam'),
('KH0065', N'Nguyễn Quốc Hưng', '0932456789', '1994/07/10', N'Nam', N'Đà Nẵng', 'hung.nguyen@email.com', '012345678532', N'Việt Nam'),
('KH0066', N'Phan Thiết Thảo', '0906789321', '1992/02/25', N'Nữ', N'Hà Nội', 'thao.phan@email.com', '123456789643', N'Việt Nam'),
('KH0067', N'Võ Minh Hùng', '0972345671', '1990/03/19', N'Nam', N'Hải Phòng', 'hung.vo@email.com', '345678901865', N'Việt Nam'),
('KH0068', N'Nguyễn Thị Minh', '0901234598', '1994/12/12', N'Nữ', N'TP. Hồ Chí Minh', 'minh.nguyen@email.com', '456789012976', N'Việt Nam'),
('KH0069', N'Phan Quang Hùng', '0967890432', '1995/08/17', N'Nam', N'Đà Nẵng', 'hung.phan@email.com', '567890123087', N'Việt Nam'),
('KH0070', N'Võ Thị Thanh', '0934567890', '1991/11/13', N'Nữ', N'TP. Hồ Chí Minh', 'thanh.vo@email.com', '678901234198', N'Việt Nam'),
('KH0071', N'Nguyễn Quang Hải', '0902345679', '1994/05/17', N'Nam', N'TP. Hồ Chí Minh', 'hai.nguyen@email.com', '789012345209', N'Việt Nam'),
('KH0072', N'Phan Minh Hùng', '0971234567', '1992/06/29', N'Nam', N'TP. Hồ Chí Minh', 'hung.phan@email.com', '234567890230', N'Việt Nam'),
('KH0073', N'Lê Thi Minh', '0916547389', '1995/01/01', N'Nữ', N'Đà Nẵng', 'minh.le@email.com', '345678901341', N'Việt Nam'),
('KH0074', N'Võ Quang Hữu', '0909876543', '1990/09/30', N'Nam', N'TP. Hồ Chí Minh', 'huu.vo@email.com', '456789012452', N'Việt Nam'),
('KH0075', N'Nguyễn Văn Sơn', '0976554321', '1993/05/18', N'Nam', N'Hà Nội', 'son.nguyen@email.com', '567890123563', N'Việt Nam'),
('KH0076', N'Phan Quốc Tuấn', '0903456789', '1994/02/11', N'Nam', N'Đà Nẵng', 'tuan.phan@email.com', '678901234674', N'Việt Nam'),
('KH0077', N'Lê Thị Thanh', '0912345670', '1995/12/05', N'Nữ', N'TP. Hồ Chí Minh', 'thanh.le@email.com', '789012345785', N'Việt Nam'),
('KH0078', N'Võ Minh Tuấn', '0973456789', '1991/08/18', N'Nam', N'Đà Nẵng', 'tuan.vo@email.com', '890123456896', N'Việt Nam'),
('KH0079', N'Nguyễn Thị Liên', '0936547891', '1993/04/27', N'Nữ', N'TP. Hồ Chí Minh', 'lien.nguyen@email.com', '901234567907', N'Việt Nam'),
('KH0080', N'Phan Minh Hải', '0902345678', '1990/07/19', N'Nam', N'TP. Hồ Chí Minh', 'hai.phan@email.com', '012345678018', N'Việt Nam'),
('KH0081', N'Lê Quang Hiệp', '0965454321', '1991/03/25', N'Nam', N'Hà Nội', 'hiep.le@email.com', '123456789019', N'Việt Nam'),
('KH0082', N'Võ Quỳnh Hằng', '0915678900', '1993/07/17', N'Nữ', N'TP. Hồ Chí Minh', 'hang.vo@email.com', '234567890120', N'Việt Nam'),
('KH0083', N'Nguyễn Văn Khoa', '0934897564', '1990/06/04', N'Nam', N'Đà Nẵng', 'khoa.nguyen@email.com', '345678901231', N'Việt Nam'),
('KH0084', N'Phan Thị Vân', '0904321789', '1994/12/09', N'Nữ', N'TP. Hồ Chí Minh', 'van.phan@email.com', '456789012342', N'Việt Nam'),
('KH0085', N'Lê Thanh Tâm', '0976543212', '1992/09/18', N'Nữ', N'Đà Nẵng', 'tam.le@email.com', '567890123453', N'Việt Nam'),
('KH0086', N'Võ Minh Trung', '0935678901', '1990/11/13', N'Nam', N'Hà Nội', 'trung.vo@email.com', '678901234564', N'Việt Nam'),
('KH0087', N'Nguyễn Thị Nhung', '0962345678', '1994/10/30', N'Nữ', N'TP. Hồ Chí Minh', 'nhung.nguyen@email.com', '789012345675', N'Việt Nam'),
('KH0088', N'Phan Thi Ngọc', '0903123456', '1991/02/15', N'Nữ', N'Đà Nẵng', 'ngoc.phan@email.com', '890123456786', N'Việt Nam'),
('KH0089', N'Lê Minh Duy', '0973234567', '1995/06/10', N'Nam', N'TP. Hồ Chí Minh', 'duy.le@email.com', '901234567897', N'Việt Nam'),
('KH0090', N'Võ Quốc Huy', '0934567899', '1993/08/23', N'Nam', N'Đà Nẵng', 'huy.vo@email.com', '012345678908', N'Việt Nam'),
('KH0091', N'Nguyễn Minh Khuê', '0902345987', '1992/07/13', N'Nữ', N'TP. Hồ Chí Minh', 'khuê.nguyen@email.com', '123456789019', N'Việt Nam'),
('KH0092', N'Phan Trần Hùng', '0965432189', '1991/10/30', N'Nam', N'TP. Hồ Chí Minh', 'hung.phan@email.com', '234567890120', N'Việt Nam'),
('KH0093', N'Lê Thi Kim', '0932456789', '1994/09/25', N'Nữ', N'Đà Nẵng', 'kim.le@email.com', '345678901231', N'Việt Nam'),
('KH0094', N'Võ Minh Hoàng', '0965678901', '1995/04/07', N'Nam', N'TP. Hồ Chí Minh', 'hoang.vo@email.com', '456789012342', N'Việt Nam'),
('KH0095', N'Nguyễn Thị Tuyết', '0906543210', '1993/03/05', N'Nữ', N'Đà Nẵng', 'tuyet.nguyen@email.com', '567890123453', N'Việt Nam'),
('KH0096', N'Phan Minh Đức', '0976789012', '1990/02/16', N'Nam', N'TP. Hồ Chí Minh', 'duc.phan@email.com', '678901234564', N'Việt Nam'),
('KH0097', N'Lê Thanh Nhàn', '0934556789', '1992/06/20', N'Nữ', N'TP. Hồ Chí Minh', 'nhan.le@email.com', '789012345675', N'Việt Nam'),
('KH0098', N'Võ Đình Quang', '0962345678', '1994/05/22', N'Nam', N'Hà Nội', 'quang.vo@email.com', '890123456786', N'Việt Nam'),
('KH0099', N'Nguyễn Minh Khôi', '0912345678', '1993/12/01', N'Nam', N'Đà Nẵng', 'khoi.nguyen@email.com', '901234567897', N'Việt Nam'),
('KH0100', N'Phan Minh Bình', '0901234567', '1990/01/15', N'Nam', N'TP. Hồ Chí Minh', 'binh.phan@email.com', '012345678908', N'Việt Nam'),
('KH0101', N'Phạm Minh Thu', '0916342587', '1996/01/05', N'Nữ', N'Hà Nội', 'thi.mai@email.com', '000012345678', N'Việt Nam'),
('KH0102', N'Nguyễn Thi Thanh', '0963425867', '1994/02/20', N'Nữ', N'TP. Hồ Chí Minh', 'thanh.nguyen@email.com', '000123456789', N'Việt Nam'),
('KH0103', N'Võ Minh Thành', '0935234678', '1995/03/18', N'Nam', N'Hà Nội', 'thanh.vo@email.com', '000234567890', N'Việt Nam'),
('KH0104', N'Lê Quốc Duy', '0976723456', '1990/12/04', N'Nam', N'Đà Nẵng', 'duy.le@email.com', '000345678901', N'Việt Nam'),
('KH0105', N'Nguyễn Thị Lan', '0901123456', '1993/08/17', N'Nữ', N'TP. Hồ Chí Minh', 'lan.nguyen@email.com', '000456789012', N'Việt Nam'),
('KH0106', N'Phan Hoàng Nam', '0912212345', '1992/06/23', N'Nam', N'TP. Hồ Chí Minh', 'nam.phan@email.com', '000567890123', N'Việt Nam'),
('KH0107', N'Lê Minh Quân', '0934345678', '1995/10/28', N'Nam', N'Đà Nẵng', 'quan.le@email.com', '000678901234', N'Việt Nam'),
('KH0108', N'Nguyễn Thi Mai', '0909876543', '1991/09/10', N'Nữ', N'TP. Hồ Chí Minh', 'mai.nguyen@email.com', '000789012345', N'Việt Nam'),
('KH0109', N'Phan Trường Giang', '0976543210', '1994/11/03', N'Nam', N'TP. Hồ Chí Minh', 'giang.phan@email.com', '000890123456', N'Việt Nam'),
('KH0110', N'Lê Hữu Phước', '0932123456', '1992/05/21', N'Nam', N'Hà Nội', 'phuoc.le@email.com', '001234567890', N'Việt Nam'),
('KH0111', N'Nguyễn Quốc Hùng', '0912233445', '1993/07/14', N'Nam', N'TP. Hồ Chí Minh', 'hung.nguyen@email.com', '001345678901', N'Việt Nam'),
('KH0112', N'Võ Tâm Nguyên', '0976543212', '1995/03/06', N'Nam', N'Hà Nội', 'nguyen.vo@email.com', '001456789012', N'Việt Nam'),
('KH0113', N'Phan Trần Mỹ', '0915432167', '1994/12/10', N'Nữ', N'TP. Hồ Chí Minh', 'my.phan@email.com', '001567890123', N'Việt Nam'),
('KH0114', N'Lê Minh Quang', '0934567891', '1990/04/18', N'Nam', N'Hà Nội', 'quang.le@email.com', '001678901234', N'Việt Nam'),
('KH0115', N'Nguyễn Tất Đạt', '0903456789', '1992/08/02', N'Nam', N'TP. Hồ Chí Minh', 'dat.nguyen@email.com', '001789012345', N'Việt Nam'),
('KH0116', N'Phan Như Quỳnh', '0965789123', '1995/10/16', N'Nữ', N'Hà Nội', 'quynh.phan@email.com', '001890123456', N'Việt Nam'),
('KH0117', N'Lê Tùng Sơn', '0972123456', '1991/12/22', N'Nam', N'Đà Nẵng', 'son.le@email.com', '001234567890', N'Việt Nam'),
('KH0118', N'Nguyễn Thanh Vân', '0934345678', '1993/09/07', N'Nữ', N'TP. Hồ Chí Minh', 'van.nguyen@email.com', '001345678901', N'Việt Nam'),
('KH0119', N'Phan Trọng Duy', '0909876543', '1994/05/19', N'Nam', N'Hà Nội', 'duy.phan@email.com', '001456789012', N'Việt Nam'),
('KH0120', N'Lê Hà Thảo', '0932123456', '1995/01/29', N'Nữ', N'TP. Hồ Chí Minh', 'thao.le@email.com', '001567890123', N'Việt Nam'),
('KH0121', N'Nguyễn Văn Hải', '0916789123', '1992/11/10', N'Nam', N'Hà Nội', 'hai.nguyen@email.com', '001678901234', N'Việt Nam'),
('KH0122', N'Phan Văn Khoa', '0909876543', '1991/10/05', N'Nam', N'Đà Nẵng', 'khoa.phan@email.com', '001789012345', N'Việt Nam'),
('KH0123', N'Lê Hoàng Sơn', '0971234567', '1993/03/30', N'Nam', N'TP. Hồ Chí Minh', 'son.le@email.com', '001890123456', N'Việt Nam'),
('KH0124', N'Nguyễn Thi Mai', '0902345678', '1994/07/15', N'Nữ', N'Hà Nội', 'mai.nguyen@email.com', '002345678901', N'Việt Nam'),
('KH0125', N'Nguyễn Hoàng Nam', '0932123456', '1995/01/29', N'Nam', N'TP. Hồ Chí Minh', 'nam.nguyen@email.com', '001234567890', N'Việt Nam'),
('KH0126', N'Phan Trọng Duy', '0912123456', '1993/06/20', N'Nam', N'Đà Nẵng', 'duy.phan@email.com', '001345678901', N'Việt Nam'),
('KH0127', N'Lê Ngọc Bích', '0976342123', '1994/03/05', N'Nữ', N'TP. Hồ Chí Minh', 'bich.le@email.com', '001456789012', N'Việt Nam'),
('KH0128', N'Nguyễn Thành Hưng', '0901456789', '1991/08/01', N'Nam', N'TP. Hồ Chí Minh', 'hung.nguyen@email.com', '001567890123', N'Việt Nam'),
('KH0129', N'Phan Quang Thành', '0964321567', '1990/04/25', N'Nam', N'TP. Hồ Chí Minh', 'thanh.phan@email.com', '001678901234', N'Việt Nam'),
('KH0130', N'Lê Minh Anh', '0903214321', '1993/09/10', N'Nữ', N'Đà Nẵng', 'anh.le@email.com', '001789012345', N'Việt Nam'),
('KH0131', N'Nguyễn Thị Hải', '0932345678', '1994/12/10', N'Nữ', N'Hà Nội', 'hai.nguyen@email.com', '001890123456', N'Việt Nam'),
('KH0132', N'Phan Văn Cường', '0916789123', '1995/03/15', N'Nam', N'TP. Hồ Chí Minh', 'cuong.phan@email.com', '002345678901', N'Việt Nam'),
('KH0133', N'Lê Duy Bình', '0971234567', '1992/11/17', N'Nam', N'TP. Hồ Chí Minh', 'binh.le@email.com', '002456789012', N'Việt Nam'),
('KH0134', N'Nguyễn Thị Diệu', '0903456789', '1994/05/30', N'Nữ', N'Hà Nội', 'dieu.nguyen@email.com', '002567890123', N'Việt Nam'),
('KH0135', N'Phan Thanh Tâm', '0972112233', '1993/07/18', N'Nam', N'TP. Hồ Chí Minh', 'tam.phan@email.com', '002678901234', N'Việt Nam'),
('KH0136', N'Lê Hoàng Anh', '0935342123', '1991/02/02', N'Nam', N'Hà Nội', 'anh.le@email.com', '002789012345', N'Việt Nam'),
('KH0137', N'Nguyễn Thái Sơn', '0909123456', '1992/10/25', N'Nam', N'TP. Hồ Chí Minh', 'son.nguyen@email.com', '002890123456', N'Việt Nam'),
('KH0138', N'Phan Thị Hạnh', '0965732189', '1994/08/10', N'Nữ', N'Đà Nẵng', 'hanh.phan@email.com', '003456789012', N'Việt Nam'),
('KH0139', N'Lê Trọng Minh', '0936112233', '1995/06/18', N'Nam', N'TP. Hồ Chí Minh', 'minh.le@email.com', '003567890123', N'Việt Nam'),
('KH0140', N'Nguyễn Quang Hải', '0972123456', '1993/09/09', N'Nam', N'TP. Hồ Chí Minh', 'hai.nguyen@email.com', '003678901234', N'Việt Nam'),
('KH0141', N'Phan Trần Đình', '0919988776', '1992/01/10', N'Nam', N'Hà Nội', 'dinh.phan@email.com', '003789012345', N'Việt Nam'),
('KH0142', N'Lê Thanh Hải', '0975567890', '1991/12/25', N'Nam', N'TP. Hồ Chí Minh', 'hai.le@email.com', '003890123456', N'Việt Nam'),
('KH0143', N'Nguyễn Minh Tuấn', '0905325678', '1993/04/28', N'Nam', N'TP. Hồ Chí Minh', 'tuan.nguyen@email.com', '004567890123', N'Việt Nam'),
('KH0144', N'Phan Tùng Linh', '0962547890', '1992/08/18', N'Nam', N'Hà Nội', 'linh.phan@email.com', '004678901234', N'Việt Nam'),
('KH0145', N'Lê Thị Kim', '0932123456', '1994/10/10', N'Nữ', N'TP. Hồ Chí Minh', 'kim.le@email.com', '004789012345', N'Việt Nam'),
('KH0146', N'Nguyễn Đức Mạnh', '0914567890', '1995/03/22', N'Nam', N'Đà Nẵng', 'manh.nguyen@email.com', '004890123456', N'Việt Nam'),
('KH0147', N'Phan Quốc An', '0976543210', '1990/12/15', N'Nam', N'TP. Hồ Chí Minh', 'an.phan@email.com', '005678901234', N'Việt Nam'),
('KH0148', N'Lê Minh Quang', '0932654321', '1994/05/11', N'Nam', N'Đà Nẵng', 'quang.le@email.com', '005789012345', N'Việt Nam'),
('KH0149', N'Nguyễn Thị Hà', '0905678901', '1991/08/14', N'Nữ', N'TP. Hồ Chí Minh', 'ha.nguyen@email.com', '005890123456', N'Việt Nam'),
('KH0150', N'Phan Trọng Tiến', '0966543210', '1992/02/05', N'Nam', N'Hà Nội', 'tien.phan@email.com', '006567890123', N'Việt Nam'),
('KH0151', N'Lê Hoàng Minh', '0932112233', '1993/07/25', N'Nam', N'TP. Hồ Chí Minh', 'minh.le@email.com', '006678901234', N'Việt Nam'),
('KH0152', N'Nguyễn Thị Mai', '0909876543', '1991/09/10', N'Nữ', N'Hà Nội', 'mai.nguyen@email.com', '006789012345', N'Việt Nam'),
('KH0153', N'Phan Lý Thu', '0975342111', '1992/11/04', N'Nữ', N'Đà Nẵng', 'thu.phan@email.com', '007345678901', N'Việt Nam'),
('KH0154', N'Lê Minh Duy', '0934345678', '1990/06/18', N'Nam', N'TP. Hồ Chí Minh', 'duy.le@email.com', '007456789012', N'Việt Nam'),
('KH0155', N'Nguyễn Hồng Sơn', '0912345678', '1992/08/12', N'Nam', N'Đà Nẵng', 'son.nguyen@email.com', '007567890123', N'Việt Nam'),
('KH0156', N'Phan Minh Quang', '0976123456', '1993/04/20', N'Nam', N'TP. Hồ Chí Minh', 'quang.phan@email.com', '007678901234', N'Việt Nam'),
('KH0157', N'Lê Thị Lan', '0908765432', '1991/02/02', N'Nữ', N'Hà Nội', 'lan.le@email.com', '007789012345', N'Việt Nam'),
('KH0158', N'Nguyễn Thi Thanh', '0932123456', '1995/09/16', N'Nữ', N'TP. Hồ Chí Minh', 'thanh.nguyen@email.com', '007890123456', N'Việt Nam'),
('KH0159', N'Phan Thi Ngọc', '0976543210', '1994/05/28', N'Nữ', N'Hà Nội', 'ngoc.phan@email.com', '008567890123', N'Việt Nam'),
('KH0160', N'Lê Hoàng Lâm', '0936547890', '1990/10/02', N'Nam', N'TP. Hồ Chí Minh', 'lam.le@email.com', '008678901234', N'Việt Nam'),
('KH0161', N'Nguyễn Hoàng Minh', '0902345678', '1995/03/21', N'Nam', N'TP. Hồ Chí Minh', 'minh.nguyen@email.com', '008789012345', N'Việt Nam'),
('KH0162', N'Phan Minh Thi', '0973216548', '1992/04/13', N'Nữ', N'Hà Nội', 'thi.phan@email.com', '008890123456', N'Việt Nam'),
('KH0163', N'Lê Thanh Sơn', '0917456283', '1993/01/17', N'Nam', N'TP. Hồ Chí Minh', 'son.le@email.com', '009345678901', N'Việt Nam'),
('KH0164', N'Nguyễn Tấn Hải', '0965234789', '1990/07/21', N'Nam', N'TP. Hồ Chí Minh', 'hai.nguyen@email.com', '009456789012', N'Việt Nam'),
('KH0165', N'Phan Tân Cương', '0906543210', '1995/05/15', N'Nam', N'TP. Hồ Chí Minh', 'cuong.phan@email.com', '009567890123', N'Việt Nam'),
('KH0166', N'Lê Bảo Lâm', '0976123456', '1994/11/10', N'Nam', N'Hà Nội', 'lam.le@email.com', '009678901234', N'Việt Nam'),
('KH0167', N'Nguyễn Thi Mến', '0912345678', '1992/09/14', N'Nữ', N'Hà Nội', 'men.nguyen@email.com', '009789012345', N'Việt Nam'),
('KH0168', N'Phan Thi Bích', '0931345678', '1993/06/26', N'Nữ', N'TP. Hồ Chí Minh', 'bich.phan@email.com', '009890123456', N'Việt Nam'),
('KH0169', N'Lê Thi Bảo', '0976543210', '1990/05/20', N'Nữ', N'TP. Hồ Chí Minh', 'bao.le@email.com', '010123456789', N'Việt Nam'),
('KH0170', N'Nguyễn Tân Hoàng', '0909876543', '1994/08/05', N'Nam', N'Hà Nội', 'hoang.nguyen@email.com', '010234567890', N'Việt Nam'),
('KH0171', N'Phan Trường Long', '0912233445', '1993/10/25', N'Nam', N'TP. Hồ Chí Minh', 'long.phan@email.com', '010345678901', N'Việt Nam'),
('KH0172', N'Lê Tịnh Duy', '0978776543', '1992/02/18', N'Nam', N'Đà Nẵng', 'duy.le@email.com', '010456789012', N'Việt Nam'),
('KH0173', N'Nguyễn Tiến Hòa', '0906543210', '1994/04/12', N'Nam', N'Hà Nội', 'hoa.nguyen@email.com', '010567890123', N'Việt Nam'),
('KH0174', N'Phan Thị Thuý', '0914567890', '1995/11/22', N'Nữ', N'TP. Hồ Chí Minh', 'thuy.phan@email.com', '010678901234', N'Việt Nam'),
('KH0175', N'Lê Thi Mai', '0965321432', '1991/01/04', N'Nữ', N'TP. Hồ Chí Minh', 'mai.le@email.com', '010789012345', N'Việt Nam'),
('KH0176', N'Nguyễn Tử Tâm', '0913456789', '1994/09/23', N'Nam', N'Hà Nội', 'tam.nguyen@email.com', '010890123456', N'Việt Nam'),
('KH0177', N'Phan Tấn Hùng', '0909876543', '1992/12/11', N'Nam', N'Đà Nẵng', 'hung.phan@email.com', '011234567890', N'Việt Nam'),
('KH0178', N'Lê Duy Khánh', '0973217654', '1993/02/14', N'Nam', N'TP. Hồ Chí Minh', 'khanh.le@email.com', '011345678901', N'Việt Nam'),
('KH0179', N'Nguyễn Thi Quế', '0917654321', '1991/03/15', N'Nữ', N'TP. Hồ Chí Minh', 'que.nguyen@email.com', '011456789012', N'Việt Nam'),
('KH0180', N'Phan Thanh Lâm', '0965432123', '1994/07/08', N'Nam', N'TP. Hồ Chí Minh', 'lam.phan@email.com', '011567890123', N'Việt Nam'),
('KH0181', N'Phan Ngọc Thị', '0965432187', '1995/11/09', N'Nữ', N'Đà Nẵng', 'thi.phan@email.com', '012456789012', N'Việt Nam'),
('KH0182', N'Lê Tuấn Anh', '0907654321', '1994/02/13', N'Nam', N'TP. Hồ Chí Minh', 'anh.le@email.com', '012567890123', N'Việt Nam'),
('KH0183', N'Nguyễn Đức Mạnh', '0972345678', '1991/09/28', N'Nam', N'Hà Nội', 'manh.nguyen@email.com', '012678901234', N'Việt Nam'),
('KH0184', N'Phan Xuân Thanh', '0967876543', '1994/03/10', N'Nam', N'TP. Hồ Chí Minh', 'thanh.phan@email.com', '012789012345', N'Việt Nam'),
('KH0185', N'Lê Minh Hieu', '0903217654', '1993/07/18', N'Nam', N'TP. Hồ Chí Minh', 'hieu.le@email.com', '012890123456', N'Việt Nam'),
('KH0186', N'Nguyễn Hoàng Long', '0912123456', '1992/01/25', N'Nam', N'Hà Nội', 'long.nguyen@email.com', '013012345678', N'Việt Nam'),
('KH0187', N'Phan Trúc Lan', '0976745123', '1994/11/12', N'Nữ', N'TP. Hồ Chí Minh', 'lan.phan@email.com', '013123456789', N'Việt Nam'),
('KH0188', N'Lê Thị Thu Hà', '0903217654', '1991/05/05', N'Nữ', N'Hà Nội', 'ha.le@email.com', '013234567890', N'Việt Nam'),
('KH0189', N'Nguyễn Quỳnh Trang', '0912134567', '1995/07/11', N'Nữ', N'TP. Hồ Chí Minh', 'trang.nguyen@email.com', '013345678901', N'Việt Nam'),
('KH0190', N'Phan Trí Thi', '0971326547', '1992/03/15', N'Nữ', N'TP. Hồ Chí Minh', 'thi.phan@email.com', '013456789012', N'Việt Nam'),
('KH0191', N'Lê Minh Thành', '0907876543', '1991/06/17', N'Nam', N'Đà Nẵng', 'thanh.le@email.com', '013567890123', N'Việt Nam'),
('KH0192', N'Nguyễn Thị Thuận', '0967674321', '1993/04/19', N'Nữ', N'TP. Hồ Chí Minh', 'thuan.nguyen@email.com', '013678901234', N'Việt Nam'),
('KH0193', N'Phan Minh Duy', '0972123456', '1995/01/30', N'Nam', N'Hà Nội', 'duy.phan@email.com', '013789012345', N'Việt Nam'),
('KH0194', N'Lê Thanh Hải', '0905674321', '1994/09/03', N'Nam', N'TP. Hồ Chí Minh', 'hai.le@email.com', '013890123456', N'Việt Nam'),
('KH0195', N'Nguyễn Đình Phú', '0911234567', '1990/12/20', N'Nam', N'Hà Nội', 'phu.nguyen@email.com', '014123456789', N'Việt Nam'),
('KH0196', N'Phan Thị Mai', '0968456712', '1992/02/13', N'Nữ', N'TP. Hồ Chí Minh', 'mai.phan@email.com', '014234567890', N'Việt Nam'),
('KH0197', N'Lê Tâm Lan', '0909876543', '1991/06/25', N'Nữ', N'Hà Nội', 'lan.le@email.com', '014345678901', N'Việt Nam'),
('KH0198', N'Nguyễn Quỳnh Anh', '0912135467', '1993/10/14', N'Nữ', N'TP. Hồ Chí Minh', 'anh.nguyen@email.com', '014456789012', N'Việt Nam'),
('KH0199', N'Phan Quốc Bình', '0973234567', '1992/12/06', N'Nam', N'Hà Nội', 'binh.phan@email.com', '014567890123', N'Việt Nam'),
('KH0200', N'Lê Hồng Sơn', '0908765432', '1994/03/29', N'Nam', N'TP. Hồ Chí Minh', 'son.le@email.com', '014678901234', N'Việt Nam');

-----SẢNH

go
insert into SanhDatTiec (maS, tenS, giaSDT) values
('SANHA',N'Sảnh A',7000000),
('SANHB',N'Sảnh B',9000000),
('SANHC',N'Sảnh C',12000000),
('SANHD',N'Sảnh D',15000000),
('SANHE',N'Sảnh E',20000000);

-----PHÒNG

insert into LoaiHinhLuuTru(maLH, tenLH, loaiHinh, slNguoi, giaTien, trangThai, ghiChu) values

----1ng: 1tr5, 2ng: 3tr, 3ng: 4tr5, 4ng: 6tr

-----toà A

---tòa A, tầng 1
('THG0001', 'A101', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0002', 'A102', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0003', 'A103', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0004', 'A104', N'Phòng thường', 2, 3000000, N'Đang dọn dẹp', null),
('THG0005', 'A105', N'Phòng thường', 2, 3000000, N'Trống', null),
('THG0006', 'A106', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0007', 'A107', N'Phòng thường', 2, 3000000, N'Đang bảo trì', null),

---tòa A, tầng 2
('THG0008', 'A201', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0009', 'A202', N'Phòng thường', 2, 3000000, N'Đang dọn dẹp', null),
('THG0010', 'A203', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0011', 'A204', N'Phòng thường', 2, 3000000, N'Trống', null),
('THG0012', 'A205', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0013', 'A206', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0014', 'A207', N'Phòng thường', 2, 3000000, N'Đã đặt', null),

---tòa A, tầng 3
('THG0015', 'A301', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0016', 'A302', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0017', 'A303', N'Phòng thường', 3, 4500000, N'Trống', null),
('THG0018', 'A304', N'Phòng thường', 3, 4500000, N'Có người', null),
('THG0019', 'A305', N'Phòng thường', 3, 4500000, N'Đang dọn dẹp', null),
('THG0020', 'A306', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0021', 'A307', N'Phòng thường', 3, 4500000, N'Trống', null),

---tòa A, tầng 4
('THG0022', 'A401', N'Phòng thường', 4, 6000000, N'Đã đặt', null),
('THG0023', 'A402', N'Phòng thường', 4, 6000000, N'Đang dọn dẹp', null),
('THG0024', 'A403', N'Phòng thường', 4, 6000000, N'Trống', null),
('THG0025', 'A404', N'Phòng thường', 4, 6000000, N'Có người', null),
('THG0026', 'A405', N'Phòng thường', 4, 6000000, N'Đang dọn dẹp', null),
('THG0027', 'A406', N'Phòng thường', 4, 6000000, N'Đã đặt', null),
('THG0028', 'A407', N'Phòng thường', 4, 6000000, N'Trống', null),

---tòa A, tầng 5
('THG0029', 'A501', N'Phòng thường', 1, 1500000, N'Đã đặt', null),
('THG0030', 'A502', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0031', 'A503', N'Phòng thường', 1, 1500000, N'Trống', null),
('THG0032', 'A504', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0033', 'A505', N'Phòng thường', 1, 1500000, N'Đã đặt', null),
('THG0034', 'A506', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0035', 'A507', N'Phòng thường', 1, 1500000, N'Đã đặt', null),

---tòa A, tầng 6 (VIP)
('VIP0001', 'A601', N'Phòng vip', 4, 12000000, N'Trống', null),
('VIP0002', 'A602', N'Phòng vip', 4, 12000000, N'Có người', null),

-----toà B

---tòa B, tầng 1
('THG0036', 'B101', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0037', 'B102', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0038', 'B103', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0039', 'B104', N'Phòng thường', 2, 3000000, N'Đang dọn dẹp', null),
('THG0040', 'B105', N'Phòng thường', 2, 3000000, N'Trống', null),
('THG0041', 'B106', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0042', 'B107', N'Phòng thường', 2, 3000000, N'Đang bảo trì', null),

---tòa B, tầng 2
('THG0043', 'B201', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0044', 'B202', N'Phòng thường', 2, 3000000, N'Đang dọn dẹp', null),
('THG0045', 'B203', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0046', 'B204', N'Phòng thường', 2, 3000000, N'Trống', null),
('THG0047', 'B205', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0048', 'B206', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0049', 'B207', N'Phòng thường', 2, 3000000, N'Đã đặt', null),

---tòa B, tầng 3
('THG0050', 'B301', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0051', 'B302', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0052', 'B303', N'Phòng thường', 3, 4500000, N'Trống', null),
('THG0053', 'B304', N'Phòng thường', 3, 4500000, N'Có người', null),
('THG0054', 'B305', N'Phòng thường', 3, 4500000, N'Đang dọn dẹp', null),
('THG0055', 'B306', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0056', 'B307', N'Phòng thường', 3, 4500000, N'Trống', null),

---tòa B, tầng 4
('THG0057', 'B401', N'Phòng thường', 4, 6000000, N'Đã đặt', null),
('THG0058', 'B402', N'Phòng thường', 4, 6000000, N'Đang dọn dẹp', null),
('THG0059', 'B403', N'Phòng thường', 4, 6000000, N'Trống', null),
('THG0060', 'B404', N'Phòng thường', 4, 6000000, N'Có người', null),
('THG0061', 'B405', N'Phòng thường', 4, 6000000, N'Đang dọn dẹp', null),
('THG0062', 'B406', N'Phòng thường', 4, 6000000, N'Đã đặt', null),
('THG0063', 'B407', N'Phòng thường', 4, 6000000, N'Trống', null),

---tòa B, tầng 5
('THG0064', 'B501', N'Phòng thường', 1, 1500000, N'Đã đặt', null),
('THG0065', 'B502', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0066', 'B503', N'Phòng thường', 1, 1500000, N'Trống', null),
('THG0067', 'B504', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0068', 'B505', N'Phòng thường', 1, 1500000, N'Đã đặt', null),
('THG0069', 'B506', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0070', 'B507', N'Phòng thường', 1, 1500000, N'Đã đặt', null),

---tòa B, tầng 6 (VIP)
('VIP0003', 'B601', N'Phòng vip', 4, 12000000, N'Trống', null),
('VIP0004', 'B602', N'Phòng vip', 4, 12000000, N'Có người', null),

-----toà C

---tòa C, tầng 1
('THG0071', 'C101', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0072', 'C102', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0073', 'C103', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0074', 'C104', N'Phòng thường', 2, 3000000, N'Đang dọn dẹp', null),
('THG0075', 'C105', N'Phòng thường', 2, 3000000, N'Trống', null),
('THG0076', 'C106', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0077', 'C107', N'Phòng thường', 2, 3000000, N'Đang bảo trì', null),

---tòa C, tầng 2
('THG0078', 'C201', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0079', 'C202', N'Phòng thường', 2, 3000000, N'Đang dọn dẹp', null),
('THG0080', 'C203', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0081', 'C204', N'Phòng thường', 2, 3000000, N'Trống', null),
('THG0082', 'C205', N'Phòng thường', 2, 3000000, N'Đã đặt', null),
('THG0083', 'C206', N'Phòng thường', 2, 3000000, N'Có người', null),
('THG0084', 'C207', N'Phòng thường', 2, 3000000, N'Đã đặt', null),

---tòa C, tầng 3
('THG0085', 'C301', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0086', 'C302', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0087', 'C303', N'Phòng thường', 3, 4500000, N'Trống', null),
('THG0088', 'C304', N'Phòng thường', 3, 4500000, N'Có người', null),
('THG0089', 'C305', N'Phòng thường', 3, 4500000, N'Đang dọn dẹp', null),
('THG0090', 'C306', N'Phòng thường', 3, 4500000, N'Đã đặt', null),
('THG0091', 'C307', N'Phòng thường', 3, 4500000, N'Trống', null),

---tòa C, tầng 4
('THG0092', 'C401', N'Phòng thường', 4, 6000000, N'Đã đặt', null),
('THG0093', 'C402', N'Phòng thường', 4, 6000000, N'Đang dọn dẹp', null),
('THG0094', 'C403', N'Phòng thường', 4, 6000000, N'Trống', null),
('THG0095', 'C404', N'Phòng thường', 4, 6000000, N'Có người', null),
('THG0096', 'C405', N'Phòng thường', 4, 6000000, N'Đang dọn dẹp', null),
('THG0097', 'C406', N'Phòng thường', 4, 6000000, N'Đã đặt', null),
('THG0098', 'C407', N'Phòng thường', 4, 6000000, N'Trống', null),

---tòa C, tầng 5
('THG0100', 'C501', N'Phòng thường', 1, 1500000, N'Đã đặt', null),
('THG0101', 'C502', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0102', 'C503', N'Phòng thường', 1, 1500000, N'Trống', null),
('THG0103', 'C504', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0104', 'C505', N'Phòng thường', 1, 1500000, N'Đã đặt', null),
('THG0105', 'C506', N'Phòng thường', 1, 1500000, N'Có người', null),
('THG0106', 'C507', N'Phòng thường', 1, 1500000, N'Đã đặt', null),

---tòa C, tầng 6 (VIP)
('VIP0005', 'C601', N'Phòng vip', 4, 12000000, N'Trống', null),
('VIP0006', 'C602', N'Phòng vip', 4, 12000000, N'Có người', null),

-----villa

---1ng
('V001', '001', N'Villa', 1, 3000000, N'Trống', null),
('V002', '002', N'Villa', 1, 3000000, N'Trống', null),
('V003', '003', N'Villa', 1, 3000000, N'Trống', null),
('V004', '004', N'Villa', 1, 3000000, N'Trống', null),
('V005', '005', N'Villa', 1, 3000000, N'Trống', null),

---2ng
('V006', '006', N'Villa', 2, 6000000, N'Trống', null),
('V007', '007', N'Villa', 2, 6000000, N'Trống', null),
('V008', '008', N'Villa', 2, 6000000, N'Trống', null),
('V009', '009', N'Villa', 2, 6000000, N'Trống', null),
('V010', '010', N'Villa', 2, 6000000, N'Trống', null),

---3ng
('V011', '011', N'Villa', 3, 9000000, N'Trống', null),
('V012', '012', N'Villa', 3, 9000000, N'Trống', null),
('V013', '013', N'Villa', 3, 9000000, N'Trống', null),
('V014', '014', N'Villa', 3, 9000000, N'Trống', null),
('V015', '015', N'Villa', 3, 9000000, N'Trống', null),

---4ng
('V016', '016', N'Villa', 4, 12000000, N'Trống', null),
('V017', '017', N'Villa', 4, 12000000, N'Trống', null),
('V018', '018', N'Villa', 4, 12000000, N'Trống', null),
('V019', '019', N'Villa', 4, 12000000, N'Trống', null),
('V020', '020', N'Villa', 4, 12000000, N'Trống', null),

---5ng
('V021', '021', N'Villa', 5, 15000000, N'Trống', null),
('V022', '022', N'Villa', 5, 15000000, N'Trống', null),
('V023', '023', N'Villa', 5, 15000000, N'Trống', null),
('V024', '024', N'Villa', 5, 15000000, N'Trống', null),
('V025', '025', N'Villa', 5, 15000000, N'Trống', null),

---6ng
('V026', '026', N'Villa', 6, 18000000, N'Trống', null),
('V027', '027', N'Villa', 6, 18000000, N'Trống', null),
('V028', '028', N'Villa', 6, 18000000, N'Trống', null),
('V029', '029', N'Villa', 6, 18000000, N'Trống', null),
('V030', '030', N'Villa', 6, 18000000, N'Trống', null),

---7ng
('V031', '031', N'Villa', 7, 2100000, N'Trống', null),
('V032', '032', N'Villa', 7, 2100000, N'Trống', null),
('V033', '033', N'Villa', 7, 2100000, N'Trống', null),
('V034', '034', N'Villa', 7, 2100000, N'Trống', null),
('V035', '035', N'Villa', 7, 2100000, N'Trống', null);

-----DỊCH VỤ

go
insert into DichVu (maDV, tenDV, giaTien) values
('DV001', N'Dịch vụ spa', 700000),
('DV002', N'Thuê phòng Deluxe', 2000000),
('DV003', N'Chèo thuyền kayak', 300000),
('DV004', N'Dịch vụ đưa đón sân bay', 600000),
('DV005', N'Lớp yoga buổi sáng', 150000),
('DV006', N'Chuyến tham quan núi', 750000),
('DV007', N'Tiệc nướng ngoài trời', 1700000),
('DV008', N'Tour du lịch trong thành phố', 2500000),
('DV009', N'Dịch vụ tổ chức sự kiện', 3000000),
('DV010', N'Thuê xe đạp', 150000),
('DV011', N'Thuê xe máy', 200000),
('DV012', N'Thuê xe ô tô', 1200000),
('DV013', N'Thuê thuyền cano', 1500000),
('DV014', N'Dịch vụ tắm hơi', 350000),
('DV015', N'Dịch vụ giặt ủi', 50000),
('DV016', N'Dịch vụ thêm giường', 150000),
('DV017', N'Buffet bữa sáng', 350000),
('DV018', N'Buffet bữa tối', 500000),
('DV019', N'Thực đơn phục vụ tại phòng', 50000),
('DV020', N'Minibar - Thức uống & đồ ăn nhẹ trong phòng', 30000);

-----LOẠI MÓN ĂN

go
insert into LoaiMonAn (maLMA, tenLMA) values
('LMA01', N'Món Á'),
('LMA02', N'Món Âu'),
('LMA03', N'Món Nhật'),
('LMA04', N'Món Hàn'),
('LMA05', N'Món Trung'),
('LMA06', N'Món Việt');

-----MÓN ĂN

--khai vị : k, chính : c, tráng miệng : t, đồ uống : d
--MAK01
--MAC01
--MAT01
--MAD01

go
insert into MonAn (maMA, maLMA, tenMA, giaTien, mieuTa) values

-- Món Á (LMA01)

---khai vị
('MAK01', 'LMA01', N'Bánh Mì Kẹp Gà Nướng', 5000000, N'Món khai vị gồm bánh mì nướng giòn, kẹp thịt gà nướng cùng rau sống và sốt mayonnaise.'),
('MAK02', 'LMA01', N'Súp Bánh Mì Xíu Mại', 6000000, N'Súp bánh mì truyền thống kết hợp với xíu mại tôm thịt, ăn kèm hành lá, gia vị đặc trưng.'),
('MAK03', 'LMA01', N'Gỏi Cuốn Tôm Thịt', 2500000, N'Món khai vị truyền thống với tôm, thịt heo, bún và rau sống, chấm nước mắm chua ngọt.'),
('MAK04', 'LMA01', N'Gỏi Cuốn Chay', 2500000, N'Món khai vị chay với bún, rau sống, đậu hũ, chấm nước mắm chua ngọt.'),

---Đồ uống
('MAD01', 'LMA01', N'Trà Sen Vàng', 1200000, N'Trà xanh ướp sen, hương thơm dịu nhẹ, giúp thanh lọc cơ thể và hỗ trợ tiêu hoá.'),
('MAD02', 'LMA01', N'Nước Dừa Tươi', 2500000, N'Nước dừa tươi mát, bổ dưỡng, giúp thanh nhiệt cơ thể.'),
('MAD03', 'LMA01', N'Trà Dâu Tằm', 4000000, N'Trà dâu tằm thơm mát, có tác dụng giải nhiệt.'),
('MAD04', 'LMA01', N'Nước Mía Tươi', 2800000, N'Nước mía tươi ép, ngọt thanh và bổ dưỡng.'),

---Món chính
('MAC01', 'LMA01', N'Sườn Heo Nướng Mật Ong', 20000000, N'Sườn heo nướng mật ong, thấm đẫm hương vị ngọt ngào, ăn kèm cơm chiên.'),
('MAC02', 'LMA01', N'Cà Ri Gà Cà Chua', 18000000, N'Món cà ri gà với cà chua và gia vị đặc trưng, ăn kèm bánh mì hoặc cơm.'),
('MAC03', 'LMA01', N'Lẩu Tôm Hùm Tươi', 35000000, N'Lẩu tôm hùm tươi ngon, nước lẩu ngọt đậm đà từ xương và gia vị.'),
('MAC04', 'LMA01', N'Thịt Lợn Sốt Xí Muội', 15000000, N'Thịt lợn kho với xí muội, kết hợp giữa ngọt, mặn và chua.'),
('MAC05', 'LMA01', N'Mực Xào Dưa Chua', 12000000, N'Mực xào dưa chua thơm ngon, kết hợp vị mặn của mực và vị chua của dưa.'),
('MAC06', 'LMA01', N'Bò Wagyu Nướng Đá', 28200000, N'Miếng thịt bò Wagyu nướng trực tiếp trên đá nóng, kết hợp gia vị đặc trưng.'),
('MAC07', 'LMA01', N'Foie Gras Nướng Mật Ong', 18800000, N'Gan ngỗng nướng nhẹ với mật ong, ăn kèm bánh mì nướng giòn.'),

---Tráng miệng
('MAT01', 'LMA01', N'Chè Khúc Bạch', 1800000, N'Món tráng miệng mát lạnh với khúc bạch, nhãn, hạnh nhân rang và nước đường thanh mát.'),
('MAT02', 'LMA01', N'Chè Ba Màu', 1800000, N'Món tráng miệng với ba màu thạch, đậu xanh, và nước cốt dừa béo ngậy.'),
('MAT03', 'LMA01', N'Bánh Cốm Xoài', 4500000, N'Món tráng miệng với xoài chín, bánh cốm mềm mịn, nước cốt dừa béo ngậy.'),
('MAT04', 'LMA01', N'Thạch Chanh Leo', 3500000, N'Thạch chanh leo mát lạnh, ăn kèm nước cốt dừa, tạo cảm giác sảng khoái.'),

-- Món Âu (LMA02)

---Khai vị
('MAK05', 'LMA02', N'Gà Xé Phay Sốt Mù Tạt', 7500000, N'Gà xé phay trộn với sốt mù tạt và rau xanh, có vị chua nhẹ.'),
('MAK06', 'LMA02', N'Tôm Sốt Aioli', 8500000, N'Tôm tươi ăn kèm sốt aioli, tạo ra sự kết hợp vị ngọt và béo ngậy.'),
('MAK07', 'LMA02', N'Salad Cá Hồi Hun Khói', 7200000, N'Cá hồi hun khói, rau xanh tươi, dầu olive và sốt chanh dây.'),
('MAK08', 'LMA02', N'Soup Măng Tây', 6500000, N'Soup măng tây nhẹ nhàng, thơm ngon, phù hợp làm khai vị.'),

---Đồ uống
('MAD05', 'LMA02', N'Rượu Vang Đỏ Ý', 12000000, N'Rượu vang nhập khẩu từ Ý, hương vị đậm đà, hậu vị mượt mà.'),
('MAD06', 'LMA02', N'Rượu Vang Trắng', 9000000, N'Rượu vang trắng nhẹ, thơm mát, dùng kèm món chính.'),
('MAD07', 'LMA02', N'Trà Xanh Lúa Mạch', 3000000, N'Trà xanh lúa mạch với hương thơm dịu, giúp thanh lọc cơ thể.'),
('MAD08', 'LMA02', N'Nước Ép Cam', 2500000, N'Nước cam ép tươi nguyên chất, giúp bổ sung vitamin C.'),
('MAC08', 'LMA02', N'Bò Bít Tết Sốt Tiêu Đen', 28000000, N'Bít tết bò thượng hạng ăn kèm sốt tiêu đen đậm đà.'),

---Món chính
('MAC09', 'LMA02', N'Cà Ri Hải Sản Nướng', 24000000, N'Cà ri hải sản nướng với nước sốt cay nồng.'),
('MAC10', 'LMA02', N'Tôm Nướng Sốt Phô Mai', 21500000, N'Tôm nướng ăn kèm sốt phô mai đặc biệt, béo ngậy.'),
('MAC11', 'LMA02', N'Pizza Hải Sản', 15500000, N'Pizza với hải sản tươi ngon, sốt cà chua và phô mai tan chảy.'),
('MAC12', 'LMA02', N'Mì Ý Sốt Pesto', 12500000, N'Mì Ý xào sốt pesto thơm ngon, ăn kèm rau tươi.'),
('MAC13', 'LMA02', N'Sườn Cừu Nướng', 42300000, N'Sườn cừu nướng trên than hồng, phục vụ cùng nước sốt gia truyền.'),
('MAC14', 'LMA02', N'Tôm Càng Xanh Sốt Bơ Tỏi', 16450000, N'Tôm càng xanh tươi sống, chế biến với sốt bơ tỏi thượng hạng.'),

---Tráng miệng
('MAT05', 'LMA02', N'Bánh Choux Nướng', 6000000, N'Bánh choux nhân kem ngọt mềm, ăn kèm sốt chocolate.'),
('MAT06', 'LMA02', N'Gelato Dâu Tây', 5500000, N'Kem gelato dâu tây mát lạnh, ngọt thanh.'),
('MAT07', 'LMA02', N'Tiramisu', 7500000, N'Món tráng miệng Ý với lớp kem mềm mịn, cà phê và cacao.'),
('MAT08', 'LMA02', N'Panna Cotta Dâu', 5600000, N'Món tráng miệng kiểu Ý mềm mịn, ăn kèm sốt dâu tươi.'),

-- Món Nhật (LMA03)

---Tráng miệng
('MAK09', 'LMA03', N'Sashimi Cá Hồi', 12000000, N'Cá hồi tươi ngon, thái mỏng, ăn kèm với nước tương và gừng.'),
('MAK10', 'LMA03', N'Gỏi Rong Biển Wakame', 4250000, N'Rong biển Wakame trộn mè rang, giấm gạo và nước tương Nhật.'),
('MAK11', 'LMA03', N'Salad Tôm Nhật', 8500000, N'Salad tôm Nhật tươi ngon, kết hợp với rau và sốt wasabi nhẹ.'),
('MAK12', 'LMA03', N'Chả Cá Cơm Sốt Miso', 6500000, N'Chả cá cơm chiên giòn, ăn kèm sốt miso đậm đà.'),

---Đồ uống
('MAD09', 'LMA03', N'Trái Cây Ép Nhật Bản', 3500000, N'Nước ép trái cây tươi Nhật Bản, thanh mát, bổ dưỡng.'),
('MAD10', 'LMA03', N'Trà Yuzu', 4000000, N'Trái yuzu tươi pha trà thơm ngon, thanh lọc cơ thể.'),
('MAD11', 'LMA03', N'Nước Uống Sake', 7000000, N'Sake Nhật Bản, rượu nhẹ, thơm ngon, dùng lạnh.'),
('MAD12', 'LMA03', N'Trà Matcha Nóng', 3800000, N'Trà xanh Nhật nguyên chất, pha nóng, giúp thư giãn và thanh lọc.'),

---Món chính
('MAC15', 'LMA03', N'Sushi Tôm Tươi', 24000000, N'Sushi với tôm tươi, ăn kèm với wasabi và nước tương.'),
('MAC16', 'LMA03', N'Mì Udon Tôm Tempura', 21000000, N'Mì udon nóng với tôm tempura giòn, nước dùng đậm đà.'),
('MAC17', 'LMA03', N'Cơm Nắm Nhật Bản', 15000000, N'Cơm nắm trộn rong biển và cá hồi tươi ngon.'),
('MAC18', 'LMA03', N'Steak Cá Hồi Nhật', 29000000, N'Steak cá hồi Nhật nướng mềm, ăn kèm nước sốt thơm ngon.'),
('MAC19', 'LMA03', N'Sashimi Cá Ngừ', 28000000, N'Cá ngừ tươi ngon thái mỏng, ăn kèm với nước tương và gừng.'),
('MAC20', 'LMA03', N'Súp Hào Nhồi Trứng Cá', 21150000, N'Hào tươi nhồi trứng cá, được chế biến thành súp thơm ngon, bổ dưỡng.'),
('MAC21', 'LMA03', N'Gà Nướng Tỏi Thảo Mộc', 17625000, N'Gà tươi nướng chín đều, thơm ngon với gia vị thảo mộc tự nhiên.'),

---Tráng miệng
('MAT09', 'LMA03', N'Chè Đậu Đỏ Nhật Bản', 5000000, N'Chè đậu đỏ Nhật Bản ngọt mát, ăn kèm bánh mochi.'),
('MAT10', 'LMA03', N'Bánh Matcha Nhật Bản', 6500000, N'Bánh matcha Nhật Bản mềm mịn, vị đắng nhẹ, ăn kèm kem vani.'),
('MAT11', 'LMA03', N'Bánh Mochi Đậu Xanh', 5000000, N'Bánh mochi nhân đậu xanh, mềm mịn, ngọt nhẹ.'),
('MAT12', 'LMA03', N'Mochi Kem Trà Xanh', 6200000, N'Bánh mochi mềm mịn nhân kem matcha mát lạnh, món tráng miệng thanh tao.'),

-- Món Hàn (LMA04)

---Khai vị
('MAK13', 'LMA04', N'Kimchi Chua Ngọt', 2500000, N'Kimchi cải thảo lên men tự nhiên, chua ngọt vừa phải.'),
('MAK14', 'LMA04', N'Chả Giò Hàn Quốc', 5500000, N'Chả giò chiên giòn, nhân thịt và rau củ, ăn kèm kimchi.'),
('MAK15', 'LMA04', N'Gimbap (Cơm Cuộn)', 3500000, N'Cơm cuộn rong biển, rau và thịt bò, ăn kèm kimchi.'),
('MAK16', 'LMA04', N'Kimchi Tươi Của Nhà', 2500000, N'Kimchi cải thảo được ủ thủ công, vị cay nồng và giòn tan.'),

---Đồ uống
('MAD13', 'LMA04', N'Mật Ong Gừng', 3500000, N'Nước mật ong pha gừng tươi, giúp giải cảm, ấm bụng.'),
('MAD14', 'LMA04', N'Trái Cây Nước Ép', 4000000, N'Nước ép trái cây tươi, giúp bổ sung vitamin C.'),
('MAD15', 'LMA04', N'Nước Gạo Nguyên Chất', 3000000, N'Nước gạo tươi thanh mát, bổ dưỡng.'),
('MAD16', 'LMA04', N'Rượu Gạo Makgeolli', 7200000, N'Rượu truyền thống Hàn Quốc, mùi thơm nhẹ, vị ngọt dịu, dùng lạnh.'),

---Món chính
('MAC22', 'LMA04', N'Gà Nướng Mật Ong Hàn Quốc', 22000000, N'Gà nướng mật ong đậm đà, kết hợp với gia vị Hàn Quốc.'),
('MAC23', 'LMA04', N'Lẩu Gà Hàn Quốc', 28000000, N'Lẩu gà Hàn Quốc với nấm, rau củ và gia vị cay nồng.'),
('MAC24', 'LMA04', N'Bánh Bao Kim Chi', 15000000, N'Bánh bao nhồi kim chi cay cay, ăn kèm thịt bò xào.'),
('MAC25', 'LMA04', N'Tôm Càng Xanh Xào Tỏi', 18000000, N'Tôm càng xanh xào tỏi thơm lừng, ăn kèm cơm trắng.'),
('MAC26', 'LMA04', N'Mỳ Xào Kim Chi', 12000000, N'Mỳ xào với kim chi cay, thịt bò và rau củ, đậm đà hương vị.'),
('MAC27', 'LMA04', N'Gỏi Cá Ngừ', 18800000, N'Gỏi cá ngừ tươi, kèm rau sống và nước mắm chua ngọt.'),
('MAC28', 'LMA04', N'Tôm Càng Xanh Chiên Giòn', 17625000, N'Tôm càng xanh chiên giòn với gia vị đậm đà, chấm kèm nước sốt đặc biệt.'),

---Tráng miệng
('MAT13', 'LMA04', N'Bánh Gạo Tteok', 4800000, N'Bánh gạo Hàn Quốc ngọt nhẹ, nhân đậu đỏ, ăn kèm chè xanh.'),
('MAT14', 'LMA04', N'Kem Sữa Dừa', 5000000, N'Kem sữa dừa mát lạnh, ngọt béo, có chút hương thơm đặc biệt.'),
('MAT15', 'LMA04', N'Bánh Pudding Hàn Quốc', 4200000, N'Bánh pudding mềm mịn với hương vị ngọt dịu.'),
('MAT16', 'LMA04', N'Bánh Gạo Mật Ong (Yaksik)', 5800000, N'Món tráng miệng truyền thống với gạo nếp, hạt dẻ, táo tàu và mật ong.'),

-- Món Trung (LMA05)

---Khai vị
('MAK17', 'LMA05', N'Sủi Cảo', 6800000, N'Sủi cảo nhân thịt tươi ngon, ăn kèm với nước chấm đặc biệt.'),
('MAK18', 'LMA05', N'Xá Xíu Cuộn Dưa Leo', 6200000, N'Thịt xá xíu thái mỏng, cuộn với dưa leo và sốt tương gừng.'),
('MAK19', 'LMA05', N'Bao Tử Xào Cần Tây', 5000000, N'Bao tử heo xào với cần tây giòn ngon, ăn kèm gia vị đặc biệt.'),
('MAK20', 'LMA05', N'Mực Nhồi Thịt', 7500000, N'Mực nhồi thịt xay, hấp mềm, ăn kèm nước sốt đậm đà.'),

---Đồ uống
('MAD17', 'LMA05', N'Nước Nhãn Đường Phèn', 2500000, N'Nước nhãn ngọt mát, pha đường phèn thanh mát.'), 
('MAD18', 'LMA05', N'Rượu Bạch Mai', 6500000, N'Rượu bạch mai thơm ngon, nồng ấm, giúp kích thích tiêu hóa.'), 
('MAD19', 'LMA05', N'Nước Mơ', 3000000, N'Nước mơ ngọt thanh, mát lạnh.'),
('MAD20', 'LMA05', N'Trà Ô Long Nóng', 3800000, N'Trà ô long pha nóng, hương thơm nhẹ, giúp cân bằng vị giác.'),

---Món chính
('MAC29', 'LMA05', N'Vịt Quay Quảng Đông', 38000000, N'Vịt quay da giòn, thịt mềm, ăn kèm bánh tráng và nước sốt đặc biệt.'),
('MAC30', 'LMA05', N'Cháo Lươn Hấp', 22000000, N'Cháo lươn với nước dùng ngọt thanh, lươn tươi ngon, ăn kèm hành lá.'),
('MAC31', 'LMA05', N'Chân Gà Hấp Tỏi', 12000000, N'Chân gà hấp tỏi, mềm ngon, ăn kèm sốt chua ngọt.'),
('MAC32', 'LMA05', N'Xíu Mại Hải Sản', 20000000, N'Xíu mại nhân hải sản tươi ngon, ăn kèm nước sốt đặc biệt.'),
('MAC33', 'LMA05', N'Chân Gà Ngâm Sả Tắc', 9500000, N'Chân gà ngâm sả tắc giòn ngon, đậm đà hương vị.'),
('MAC34', 'LMA05', N'Chả Cá Lã Vọng', 22325000, N'Chả cá Lã Vọng thơm ngon, được chế biến từ cá tươi ngon nhất, ăn kèm rau sống.'),
('MAC35', 'LMA05', N'Vịt Quay Bắc Kinh', 38500000, N'Vịt quay da giòn, thịt mềm, ăn kèm bánh tráng, hành và nước chấm đặc biệt.'),

---Tráng miệng
('MAT17', 'LMA05', N'Chè Đậu Xanh', 3500000, N'Chè đậu xanh ngọt thanh, ăn kèm dừa tươi.'),
('MAT18', 'LMA05', N'Bánh Bao Ngọt', 4500000, N'Bánh bao ngọt nhân đậu đỏ, bột mềm mịn.'),
('MAT19', 'LMA05', N'Chè Sen Long', 7500000, N'Chè sen long với các nguyên liệu từ sen và nước cốt dừa, mát lạnh.'),
('MAT20', 'LMA05', N'Chè Dương Chi Cam Lộ', 7800000, N'Món tráng miệng nổi tiếng Quảng Đông với bưởi, xoài, trân châu và nước cốt dừa mát lạnh.'),

-- Món Việt (LMA06)

---Khai vị
('MAK21', 'LMA06', N'Bánh Xèo', 4500000, N'Bánh xèo giòn rụm, nhân tôm, thịt, giá đỗ, ăn kèm rau sống.'),
('MAK22', 'LMA06', N'Nem Rán Hà Nội', 6200000, N'Chả giò giòn tan, nhân thịt và mộc nhĩ, ăn kèm rau sống và nước mắm chua ngọt.'),
('MAK23', 'LMA06', N'Chả Cá Lã Vọng', 4500000, N'Chả cá Lã Vọng nướng thơm ngon, ăn kèm bún và rau sống.'),
('MAK24', 'LMA06', N'Nộm Gà Bắp Cải', 3500000, N'Nộm gà xé phay với bắp cải, rau thơm và nước mắm chua ngọt.'),

---Đồ uống
('MAD21', 'LMA06', N'Nước Mát Lá Nha Đam', 2800000, N'Nước uống mát gan, làm từ lá nha đam tươi, thanh mát, tốt cho sức khoẻ.'),
('MAD22', 'LMA06', N'Nước Mía', 2500000, N'Nước mía tươi ngọt thanh, mát lạnh.'),
('MAD23', 'LMA06', N'Đá Me', 2200000, N'Nước me ngọt thanh, mát lạnh.'), 
('MAD24', 'LMA06', N'Nước Dừa Tươi', 3000000, N'Nước dừa tươi mát, bổ dưỡng cho sức khỏe.'),

---Món chính
('MAC36', 'LMA06', N'Lẩu Thái Hải Sản', 28000000, N'Lẩu Thái với hải sản tươi ngon, nước dùng cay đặc trưng.'),
('MAC37', 'LMA06', N'Bánh Canh Cua', 22000000, N'Bánh canh cua với nước lèo ngọt thanh, thịt cua tươi ngon.'),
('MAC38', 'LMA06', N'Gà Hấp Sả', 17000000, N'Gà hấp sả tươi ngon, kết hợp gia vị đậm đà.'),
('MAC39', 'LMA06', N'Cháo Lòng', 15000000, N'Cháo lòng đặc biệt, nước dùng ngọt, lòng non thơm ngon.'),
('MAC40', 'LMA06', N'Món Bún Riêu', 13000000, N'Bún riêu cua thơm ngon, nước dùng đậm đà, ăn kèm rau sống.'),
('MAC41', 'LMA06', N'Lẩu Hải Sản Cao Cấp', 42300000, N'Lẩu hải sản với các loại hải sản tươi ngon nhất, nước dùng đậm đà.'),
('MAC42', 'LMA06', N'Bún Bò Huế Đặc Biệt', 18500000, N'Món đặc sản Huế với nước dùng cay thơm, chả, giò heo và bún sợi to.'),

---Tráng miệng
('MAT21', 'LMA06', N'Chè Trôi Nước', 3500000, N'Chè trôi nước mềm mịn, ăn kèm nước đường ngọt ngào.'),
('MAT22', 'LMA06', N'Bánh Chuối Nướng', 4000000, N'Bánh chuối nướng giòn, thơm mùi dừa và chuối chín.'),
('MAT23', 'LMA06', N'Chè Bắp', 3500000, N'Chè bắp ngọt ngào, thơm mát, ăn kèm nước cốt dừa.'),
('MAT24', 'LMA06', N'Bánh Chuối Nướng', 4200000, N'Món tráng miệng dân dã với chuối chín, dừa và nước cốt dừa nướng vàng ươm.');

-----COMBO MÓN ĂN

insert into ComboMonAn (maCB, tenCB, giaCB) values
('CB00001', 'Buffet Sáng', 250000),
('CB00002', 'Buffet Tối', 350000),
('CB00003', 'Thực đơn gọi món tại phòng', 300000),
('CB00004', 'Thực đơn tiệc truyền thống', 500000),
('CB00005', 'Thực đơn tiệc hiện đại', 600000);

-----CHI TIẾT COMBO

insert into ChiTietCombo (maCTCB, maCB, maMA) values

-- Combo buffet sáng (CB00001)

('CTCB001', 'CB00001', 'MA0001'),
('CTCB002', 'CB00001', 'MA0002'),
('CTCB003', 'CB00001', 'MA0003'),
('CTCB004', 'CB00001', 'MA0004'),
('CTCB005', 'CB00001', 'MA0005'),
('CTCB006', 'CB00001', 'MA0006'),
('CTCB007', 'CB00001', 'MA0007'),
('CTCB008', 'CB00001', 'MA0008'),
('CTCB009', 'CB00001', 'MA0009'),
('CTCB010', 'CB00001', 'MA0010'),

-- Combo buffet tối (CB00002)

('CTCB011', 'CB00002', 'MA0011'),
('CTCB012', 'CB00002', 'MA0012'),
('CTCB013', 'CB00002', 'MA0013'),
('CTCB014', 'CB00002', 'MA0014'),
('CTCB015', 'CB00002', 'MA0015'),
('CTCB016', 'CB00002', 'MA0016'),
('CTCB017', 'CB00002', 'MA0017'),
('CTCB018', 'CB00002', 'MA0018'),
('CTCB019', 'CB00002', 'MA0019'),
('CTCB020', 'CB00002', 'MA0020'),

-- Combo gọi món tại phòng (CB00003)

('CTCB021', 'CB00003', 'MA0001'),
('CTCB022', 'CB00003', 'MA0002'),
('CTCB023', 'CB00003', 'MA0003'),
('CTCB024', 'CB00003', 'MA0004'),
('CTCB025', 'CB00003', 'MA0005'),
('CTCB026', 'CB00003', 'MA0006'),
('CTCB027', 'CB00003', 'MA0007'),
('CTCB028', 'CB00003', 'MA0008'),
('CTCB029', 'CB00003', 'MA0009'),
('CTCB030', 'CB00003', 'MA0010'),
('CTCB031', 'CB00003', 'MA0011'),
('CTCB032', 'CB00003', 'MA0012'),
('CTCB033', 'CB00003', 'MA0013'),
('CTCB034', 'CB00003', 'MA0014'),
('CTCB035', 'CB00003', 'MA0015'),
('CTCB036', 'CB00003', 'MA0016'),
('CTCB037', 'CB00003', 'MA0017'),
('CTCB038', 'CB00003', 'MA0018'),
('CTCB039', 'CB00003', 'MA0019'),
('CTCB040', 'CB00003', 'MA0020'),

-- Combo tiệc truyền thống (CB00004)

('CTCB041', 'CB00004', 'MA0021'), 
('CTCB042', 'CB00004', 'MA0023'), 
('CTCB043', 'CB00004', 'MA0026'), 
('CTCB044', 'CB00004', 'MA0024'),
('CTCB045', 'CB00004', 'MA0025'),
('CTCB046', 'CB00004', 'MA0027'),
('CTCB047', 'CB00004', 'MA0015'),
('CTCB048', 'CB00004', 'MA0019'),
('CTCB049', 'CB00004', 'MA0028'),
('CTCB050', 'CB00004', 'MA0010'),

-- Combo tiệc hiện đại (CB00005)

('CTCB051', 'CB00005', 'MA0022'), 
('CTCB052', 'CB00005', 'MA0024'), 
('CTCB053', 'CB00005', 'MA0027'), 
('CTCB054', 'CB00005', 'MA0021'),
('CTCB055', 'CB00005', 'MA0025'),
('CTCB056', 'CB00005', 'MA0017'),
('CTCB057', 'CB00005', 'MA0016'),
('CTCB058', 'CB00005', 'MA0013'),
('CTCB059', 'CB00005', 'MA0014'),
('CTCB060', 'CB00005', 'MA0008');

