CREATE DATABASE QUANLYTOURDULICH;
USE QUANLYTOURDULICH;
CREATE TABLE LOAITOUR (
	Id_Loai NVARCHAR(50) PRIMARY KEY,
	Ten_Loai NVARCHAR(100) NOT NULL
)

CREATE TABLE TOUR (
	Id_Tour NVARCHAR(50) PRIMARY KEY,
	Ten_Tour NVARCHAR(100) NOT NULL,
	Dacdiem_Tour NVARCHAR(MAX),
	Id_Loai NVARCHAR(50) NOT NULL FOREIGN KEY (Id_Loai) REFERENCES LOAITOUR(Id_Loai)
)

CREATE TABLE DIADIEM (
	Id_DiaDiem NVARCHAR(50) PRIMARY KEY,
	Ten_DiaDiem NVARCHAR(100) NOT NULL
)

CREATE TABLE CHITIETTOUR(
	Id_Tour NVARCHAR(50),
	Id_DiaDiem NVARCHAR(50),
	Thutu INT NOT NULL,
	PRIMARY KEY (Id_Tour, Id_DiaDiem),
	FOREIGN KEY (Id_Tour) REFERENCES TOUR(Id_Tour),
	FOREIGN KEY (Id_DiaDiem) REFERENCES DIADIEM(Id_DiaDiem)
)

CREATE TABLE GIA (
	Id_Gia NVARCHAR(50) PRIMARY KEY,
	Id_Tour NVARCHAR(50) FOREIGN KEY (Id_Tour) REFERENCES TOUR(Id_Tour),
	Gia NVARCHAR(50) NOT NULL,
	Thoigianbatdau NVARCHAR(50) NOT NULL,
	Thoigianketthuc NVARCHAR(50) NOT NULL
)

CREATE TABLE DOANDULICH (
	Id_Doan NVARCHAR(50) PRIMARY KEY,
	Ten_Doan NVARCHAR(100) NOT NULL,
	Id_Tour NVARCHAR(50) FOREIGN KEY (Id_Tour) REFERENCES TOUR(Id_Tour),
	Ngaykhoihanh NVARCHAR(20) NOT NULL,
	Ngayketthuc NVARCHAR(20) NOT NULL,
	Doanhthu BIGINT NOT NULL,
	Noidung NVARCHAR(200)
)


CREATE TABLE KHACH (
	Id_Khach NVARCHAR(50) PRIMARY KEY,
	Hoten_Khach NVARCHAR(50) NOT NULL,
	Cmnd_Khach NVARCHAR(50) NOT NULL,
	Diachi_Khach NVARCHAR(50),
	Gioitinh_Khach NVARCHAR(10),
	Sdt_Khach NVARCHAR(20) NOT NULL,
	Quoctich NVARCHAR(50),
	Tinh_Trang int NOT NULL
)

CREATE TABLE CHITIETDOAN(
	Id_Doan NVARCHAR(50), 
	Id_Khach NVARCHAR(50),
	PRIMARY KEY (Id_Doan, Id_Khach), 
	FOREIGN KEY (Id_Doan) REFERENCES DOANDULICH (Id_Doan),
	FOREIGN KEY (Id_Khach) REFERENCES KHACH (Id_Khach)
)

CREATE TABLE NHANVIEN (
	Id_NV NVARCHAR(50) PRIMARY KEY,
	Hoten_NV NVARCHAR(50) NOT NULL,
	Email_NV NVARCHAR(50),
	Sdt_NV NVARCHAR(20),
	Gioitinh_NV NVARCHAR(10),
	Tinh_Trang int NOT NULL
)

CREATE TABLE PHANCONG (
	Id_Doan NVARCHAR(50),
	Id_NV NVARCHAR(50),
	Nhiemvu NVARCHAR(50) NOT NULL,
	PRIMARY KEY (Id_Doan, Id_NV),
	FOREIGN KEY (Id_Doan) REFERENCES DOANDULICH(Id_Doan),
	FOREIGN KEY (Id_NV) REFERENCES NHANVIEN(Id_NV)
)

CREATE TABLE LOAICHIPHI(
	Id_LoaiChiPhi NVARCHAR(50) PRIMARY KEY,
	Ten_LoaiChiPhi NVARCHAR(50) NOT NULL
)

CREATE TABLE CHIPHI (
	Id_LoaiChiPhi NVARCHAR(50) NOT NULL,
	Id_Doan NVARCHAR(50) NOT NULL,
	Gia NVARCHAR(30) NOT NULL,
	PRIMARY KEY (Id_LoaiChiPhi, Id_Doan),
	FOREIGN KEY (Id_Doan) REFERENCES DOANDULICH(Id_Doan),
	FOREIGN KEY (Id_LoaiChiPhi) REFERENCES LOAICHIPHI(Id_LoaiChiPhi),	
)
--LOAI TOUR
INSERT INTO LOAITOUR (Id_Loai,Ten_Loai) VALUES ('LT001', N'Ẩm thực');
INSERT INTO LOAITOUR (Id_Loai,Ten_Loai) VALUES ('LT002', N'Xã hội và gia đình');
INSERT INTO LOAITOUR (Id_Loai,Ten_Loai) VALUES ('LT003', N'Di động');
INSERT INTO LOAITOUR (Id_Loai,Ten_Loai) VALUES ('LT004', N'Kết hợp nghề nghiệp');
INSERT INTO LOAITOUR (Id_Loai,Ten_Loai) VALUES ('LT005', N'Teambuilding');
INSERT INTO LOAITOUR (Id_Loai,Ten_Loai) VALUES ('LT006', N'Văn hóa, lịch sử');

--TOUR
INSERT INTO TOUR (Id_Tour,Ten_Tour,Dacdiem_Tour,Id_Loai) VALUES ('ATDN001', N'Tour du lịch ẩm thực Đà Nẵng nửa ngày', N'Chụp ảnh Cầu Quay Sông Hàn. Phố đi bộ Bạch Đằng. Thưởng thức món ăn đặc sản tại Đà Nẵng như: Bánh xèo, Nem Lụi, Bánh cuốn Thịt Heo, chè Xuân Trang.','LT001');
INSERT INTO TOUR (Id_Tour,Ten_Tour,Dacdiem_Tour,Id_Loai) VALUES ('XGVT001', N'Du lịch Vũng Tàu 2 ngày, 1 đêm', N'Tham quan Nông Trại Cừu. Khám phá Ngôi nhà úp ngược độc đáo. Tham quan viếng Chùa Phước Hải (Chùa Bún Riêu). Tham quan check-in tại Ngôi nhà úp ngược. Tắm biển tại Bãi Sau - bãi biển đẹp nhất Vũng Tàu. Ngắm toàn cảnh thành phố Vũng Tàu trên tượng chúa Kito Vua. Thưởng thức các món ăn đặc sản nơi miền biển','LT002');
INSERT INTO TOUR (Id_Tour,Ten_Tour,Dacdiem_Tour,Id_Loai) VALUES ('KNNT001', N'Tour thực tập thực tế Nha Trang – Đà Lạt 5 ngày 4 đêm', N'Được trực tiếp thực hiện tất cả các công việc trong toàn bộ quy trình nghiệp vụ hướng dẫn một đoàn khách, từ khâu chuẩn bị trước chuyến đi, tới các hoạt động tổ chức vận chuyển, lưu trú, ăn uống và hướng dẫn tham quan trên phương tiện di chuyển cũng như tại các điểm du lịch.', 'LT004');
INSERT INTO TOUR (Id_Tour,Ten_Tour,Dacdiem_Tour,Id_Loai) VALUES ('TBHN001', N'Tour du lịch Hà Nội - Hạ Long Teambuilding 2 ngày 1 đêm', N'Được hòa mình với khung cảnh thơ mộng nơi biển cả bao la, và tham gia những hoạt động giải trí vô cùng hấp dẫn, thú vị.', 'LT005');
INSERT INTO TOUR (Id_Tour,Ten_Tour,Dacdiem_Tour,Id_Loai) VALUES ('VLHN001', N'Tour du lịch văn hóa - lịch sử Hà Nội', N'Hà Nội không quá lớn, không sầm uất và nhộn nhịp như Sài Gòn, nhưng luôn để lại ấn tượng sâu sắc trong lòng du khách bởi nét trầm tư, lãng mạn mà chỉ thành phố cổ kính này mới có. Chỉ với 3 ngày lưu lại thủ đô Hà Nội, bạn có thể tìm hiểu nền văn hóa lịch sử của trung tâm kinh tế-văn hóa-chính trị của đất nước.','LT004'); 

--DIAIDEM
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('DN001', N'Quán Bánh xèo Bà Dưỡng');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('DN002', N'Cầu Quay Sông Hàn');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('DN003', N'Phố đi bộ Bạch Đằng');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('DN004', N'Bánh cuốn Thịt Heo');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('DN005', N'Chè Xuân Trang');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('VT001', N'Nông Trại Cừu');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('VT002', N'Bạch Dinh');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('VT003', N'Bãi Sau');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('VT004', N'Nhà Úp Ngược');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('VT005', N'Tượng Chúa KiTô');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('VT006', N'Thích Ca Phật Đài');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('VT007', N'Chùa Phước Hải');

INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('NT001', N'Khu tưởng niệm chiến sĩ Gạc Ma');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('NT002', N'Chùa Long Sơn');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('DL001', N'Vườn hoa thành phố Đà Lạt');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('DL002', N'Quảng trường Lâm Viên  Đà Lạt');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('KH001', N'Bãi biển Dốc Lết ');


INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HL001', N' Bảo tàng Hạ Long');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HL002', N'Núi Bài Thơ');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem)VALUES ('HL003', N'Hạ Long Park');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HL004', N'Bãi tắm');

INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN001', N'Khu phố cổ');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN002', N'Văn Miếu Quốc Tử Giám');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN003', N'Nhà Hát Lớn');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN004', N'Lăng Chủ tịch Hồ Chí Minh');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN005', N'Chùa Một Cột');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN006', N'Bảo tàng Hồ Chí Minh');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN007', N'Nhà tù Hỏa Lò');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN008', N'Chả cá Lã Vọng');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN009', N'Bảo tàng Phụ Nữ Việt Nam');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN010', N'Bảo tàng Dân tộc học');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN011', N'Bảo tàng lịch sử quân sự Việt Nam');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN012', N'Nhà hát múa rối Thăng Long');
INSERT INTO DIADIEM (Id_DiaDiem, Ten_DiaDiem) VALUES ('HN013', N'Hồ Tây');


--CHITIETTOUR
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('ATDN001', 'DN001', 1)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('ATDN001', 'DN002', 2)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('ATDN001', 'DN003', 3)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('ATDN001', 'DN004', 4)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('ATDN001', 'DN005', 5)

INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('XGVT001', 'VT001', 1);
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('XGVT001', 'VT002', 2);
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('XGVT001', 'VT003', 3);
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('XGVT001', 'VT004', 4);
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('XGVT001', 'VT005', 5);
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('XGVT001', 'VT006', 6);
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('XGVT001', 'VT007', 7);

INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('KNNT001', 'NT001', 1)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('KNNT001', 'NT002', 2)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('KNNT001', 'KH001', 3)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('KNNT001', 'DL001', 4)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('KNNT001', 'DL002', 5)

INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('TBHN001', 'HL001', 1)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('TBHN001', 'HL002', 2)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('TBHN001', 'HL003', 3)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('TBHN001', 'HL004', 4)

INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN001', 1)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN002', 2)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN003', 3)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN004', 4)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN005', 5)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN006', 6)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN007', 7)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN008', 8)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN009', 9)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN010', 10)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN011', 11)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN012', 12)
INSERT INTO CHITIETTOUR(Id_Tour,Id_DiaDiem,Thutu) VALUES ('VLHN001', 'HN013', 13)

--GIA
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_ATDN_XUAN','ATDN001',800000,'2021-1-1','2021-3-31');
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_XGVT_XUAN','XGVT001',1900000,'2021-1-1','2021-4-1');
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_XGVT_HE','XGVT001',1950000,'2021-4-1','2021-7-1');
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_XGVT_THU','XGVT001',1700000,'2021-7-1','2021-10-1');
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_XGVT_DONG','XGVT001',1700000,'2021-10-1','2021-1-1');
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_KNNT','KNNT001',1800000,'2021-7-1','2021-7-5');
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_TBHN','TBHN001',1500000,'2021-6-15','2021-6-16');
INSERT INTO GIA(Id_Gia,Id_Tour,Gia,Thoigianbatdau,Thoigianketthuc) VALUES ('GIA_VLHN','VLHN001',1880000,'2021-6-15','2021-6-16');

--DOANDULICH
INSERT INTO DOANDULICH (Id_Doan,Ten_Doan,Id_Tour,Ngaykhoihanh,Ngayketthuc,Doanhthu,Noidung)
	VALUES ('DOAN01032021', N'Tour du lịch ẩm thực Đà Nẵng nửa ngày','ATDN001', '01/03/2021','03/01/2021',1600000,N'Thưởng thức những món ăn đặc sản: Bánh xèo, Nem Lụi, Bánh cuốn Thịt Heo, chè Xuân Trang. Tham quan chụp ảnh Cầu Quay Sông Hàn, Phố đi bộ Bạch Đằng.');

INSERT INTO DOANDULICH (Id_Doan,Ten_Doan,Id_Tour,Ngaykhoihanh,Ngayketthuc,Doanhthu,Noidung)
	VALUES ('DOANVT101921', N'Đoàn DL Vũng Tàu 2N1Đ','XGVT001', '19/10/2021','20/10/2021',10200000,N'Tự do khám phá Vũng Tàu về đêm. Đến Nông Trại Cừu, Đến Bạch Dinh, Nhà Úp Ngược, Tượng Chúa KiTô, Thích Ca Phật Đài, Chùa Phước Hải. Tham quan mua sắm tại Trung tâm thương mại Bò Sữa Long Thành.');

--KHACH
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0001', N'Trần Nguyễn Khánh Hân', '079234312456', N'368 Nguyễn Trãi P8 Q5, TPHCM',N'Nữ', '0903671984',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich,Tinh_Trang)
	VALUES ('KH0002', N'Trần Minh Tuấn', '075679453126', N'368 Nguyễn Trãi P8 Q5, TPHCM','Nam', '0978954324',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0003', N'Nguyễn Thanh Phương', '084467842111', N'800 Nguyễn Văn Linh, Tân Phú Q7, TPHCM',N'Nữ', '098488463',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0004', N'Mai Ngọc Tú', '085544789410', N'109/34B/6 Bến Vân Đồn P9 Q4, TPHCM',N'Nữ', '0334852689',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0005', N'Nguyễn Quang Minh', '097522668900', N'109/34B/6 Bến Vân Đồn P9 Q4, TPHCM','Nam', '0906074481',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0006', N'Trần Minh Vương', '024686532468', N'5 Bế Văn Cấm, Tân Kiểng Q7, TPHCM','Nam' , '0886422462',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0007', N'Nguyễn Anh Minh', '097468641905', N'38 Trương Định, Võ Thị Sáu, Q3, TPHCM','Nam', '0906074481',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0008', N'Dương Thanh Thảo', '032762988123', N'567 Tỉnh Lộ 15, Nhuận Đức, Củ Chi, TPHCM', N'Nữ', '0938665891',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0009', N'Lê Thùy Linh', '013855368963', N'76 Nguyễn Trãi, Phường Phạm Ngũ Lão, Q1, TPHCM', N'Nữ', '0981989334',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0010', N'Trần Văn Hùng', '074467985221', N'39600 Số 3, Tân Kiểng, Q7, TPHCM', 'Nam', '0976540980',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0011', N'Nguyễn Minh Long', '055976246906', N'424/12 Nguyễn Thượng Hiền, Phường 4, Q3, TPHCM', 'Nam', '0979000980', N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0012', N'Phạm Kiều Oanh', '076345987534', N'98 Số 8, P11, Q6, TPHCM', N'Nữ', '0903458712',N'Việt Nam',1)
INSERT INTO KHACH (Id_Khach,Hoten_Khach,Cmnd_Khach,Diachi_Khach,Gioitinh_Khach,Sdt_Khach,Quoctich, Tinh_Trang)
	VALUES ('KH0013', N'Trần Gia Hân', '034098435721', N'95 Lương Nhữ Học, P10, Q5, TPHCM', N'Nữ', '0867712498',N'Việt Nam',1)

--CHITIETDOAN
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach) VALUES ('DOAN01032021', 'KH0001')
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach) VALUES ('DOAN01032021', 'KH0002')
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach) VALUES ('DOANVT101921', 'KH0003')
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach) VALUES ('DOANVT101921', 'KH0004')
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach) VALUES ('DOANVT101921', 'KH0005')
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach)VALUES ('DOANVT101921', 'KH0006')
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach) VALUES ('DOANVT101921', 'KH0007')
INSERT INTO CHITIETDOAN(Id_Doan,Id_Khach) VALUES ('DOANVT101921', 'KH0008')

--NHANVIEN
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV001', N'Lê Văn Toàn', 'levantoan98@gmail.com', '0745327652', 'Nam',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV002', N'Phạm Hoài Thương', 'phamhoaithuong@gmail.com', '0346024759', N'Nữ',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV003', N'Nguyễn Ngọc Cao', 'nguyenngoccao@gmail.com', '0775233987', 'Nam',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV004', N'Nguyễn Thanh Tâm', 'nguyenthanhtam@gmail.com', '0787345877', 'Nam',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV005', N'Lê Kim Bảo', 'lekimbao@gmail.com', '0875345873', 'Nam',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV006', N'Nguyễn Thanh Lam', 'nguyenthanhlam@gmail.com', '0965234741', N'Nữ',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV007', N'Trần Thanh Phong', 'tranthanhphong@gmail.com', '0923765247', 'Nam',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV008', N'Lê Hương Giang', 'lehuonggiang@gmail.com', '0842466803', N'Nữ',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV009', N'Cao Mỹ Linh', 'caomylinh@gmail.com', '0946247966', N'Nữ',1)
INSERT INTO NHANVIEN (Id_NV,Hoten_NV,Email_NV,Sdt_NV,Gioitinh_NV, Tinh_Trang)
	VALUES ('NV010', N'Nguyễn Minh Huy', 'nguyenminhhuy@gmail.com', '0864589696', 'Nam',1)

--PHANCONG
INSERT INTO PHANCONG (Id_Doan,Id_NV,Nhiemvu)
	VALUES ('DOAN01032021', 'NV001', N'Lái xe')
INSERT INTO PHANCONG (Id_Doan,Id_NV,Nhiemvu)
	VALUES ('DOAN01032021', 'NV006', N'Phục vụ')
INSERT INTO PHANCONG (Id_Doan,Id_NV,Nhiemvu)
	VALUES ('DOAN01032021', 'NV010', N'Hướng dẫn viên')
INSERT INTO PHANCONG (Id_Doan,Id_NV,Nhiemvu)
	VALUES ('DOANVT101921', 'NV002', N'Hướng dẫn viên')
INSERT INTO PHANCONG (Id_Doan,Id_NV,Nhiemvu)
	VALUES ('DOANVT101921', 'NV003', N'Lái xe')
INSERT INTO PHANCONG (Id_Doan,Id_NV,Nhiemvu)
	VALUES ('DOANVT101921', 'NV006', N'Phục vụ')

--LOAICHIPHI
INSERT INTO LOAICHIPHI(Id_LoaiChiPhi, Ten_LoaiChiPhi)
	VALUES ('CP001',N'Bữa ăn')
INSERT INTO LOAICHIPHI(Id_LoaiChiPhi, Ten_LoaiChiPhi)
	VALUES ('CP002',N'Khách sạn')
INSERT INTO LOAICHIPHI(Id_LoaiChiPhi, Ten_LoaiChiPhi)
	VALUES ('CP003',N'Xe')

--CHIPHI
INSERT INTO CHIPHI (Id_LoaiChiPhi,Id_Doan,Gia)
	VALUES ('CP001','DOAN01032021',500000)
INSERT INTO CHIPHI (Id_LoaiChiPhi,Id_Doan,Gia)
	VALUES ('CP001','DOANVT101921',2400000)
INSERT INTO CHIPHI (Id_LoaiChiPhi,Id_Doan,Gia)
	VALUES ('CP002','DOANVT101921',2400000)
INSERT INTO CHIPHI (Id_LoaiChiPhi,Id_Doan,Gia)
	VALUES ('CP003','DOANVT101921',550000)