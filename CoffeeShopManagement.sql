﻿CREATE DATABASE QLQCP
USE QLQCP

CREATE TABLE KHACHHANG (
	MAKH NVARCHAR(7) PRIMARY KEY,  
	HOTEN NVARCHAR(50),
	DCHI NVARCHAR(100),
	SDT NVARCHAR(20) UNIQUE, 
	NGAYSINH SMALLDATETIME, 
	DOANHSO INT, 
	NGAYDK SMALLDATETIME, 
	GIOITINH NVARCHAR(5), 
	SOLANTOIQUAN INT, 
	LOAIKH NVARCHAR(10) )

CREATE TABLE NHANVIEN (
	MANV NVARCHAR(4) PRIMARY KEY, 
	HOTEN NVARCHAR(50), 
	DCHI NVARCHAR(100),
	NGVL SMALLDATETIME,
	SDT NVARCHAR(20) UNIQUE,  
	CMND NVARCHAR(20) UNIQUE,
	GIOITINH NVARCHAR(5), 
	LUONG INT, 
	CHUCVU NVARCHAR(20) )

CREATE TABLE MON (
	MAMON NVARCHAR(4) PRIMARY KEY, 
	TENMON NVARCHAR(50) UNIQUE, 
	DVT NVARCHAR(10), 
	SOLANPHUCVU INT,
	GIA INT )

CREATE TABLE HOADON (
	SOHD NVARCHAR(7) PRIMARY KEY,
	NGHD SMALLDATETIME, 
	MAKH NVARCHAR(7), 
	MANV NVARCHAR(4),
	TRIGIA INT,
	GIAMGIA INT,
	CONSTRAINT FK_HOADON_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV),
	CONSTRAINT FK_HOADON_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH) )

CREATE TABLE CTHD (
	SOHD NVARCHAR(7) NOT NULL, 
	MAMON NVARCHAR(4) NOT NULL,
	SL INT,
	CONSTRAINT PK_CTHD PRIMARY KEY (SOHD, MAMON),
	CONSTRAINT FK_CTHD_SOHD FOREIGN KEY (SOHD) REFERENCES HOADON (SOHD),
	CONSTRAINT FK_CTHD_MAMON FOREIGN KEY (MAMON) REFERENCES MON (MAMON) )

CREATE TABLE TAIKHOAN (
	ID NVARCHAR(4) PRIMARY KEY,
	TENDN NVARCHAR(50) UNIQUE,
	MATKHAU NVARCHAR(100),
	TINHTRANG BIT
	CONSTRAINT FK_TAIKHOAN_MANV FOREIGN KEY (ID) REFERENCES NHANVIEN (MANV) )

USE QLQCP

ALTER TABLE KHACHHANG
ADD CONSTRAINT U_SDT UNIQUE (SDT)

ALTER TABLE NHANVIEN
ADD CONSTRAINT U_SDT_NV UNIQUE (SDT)
ALTER TABLE NHANVIEN
ADD CONSTRAINT U_CMND UNIQUE (CMND)

ALTER TABLE MON
ADD CONSTRAINT U_TENMON UNIQUE (TENMON)

ALTER TABLE TAIKHOAN
ADD CONSTRAINT U_TAIKHOAN UNIQUE (TENDN)

INSERT INTO KHACHHANG VALUES (N'KH006', N'Lê Trọng Phúc', 'NULL', N'096', '2001/01/08', 0, '2020/11/29', N'Nam', 0, N'Bạc')

INSERT INTO KHACHHANG (MAKH) VALUES ('KH00001')
INSERT INTO HOADON VALUES ('HD00001', '2020/11/28', 'KH00001', 'NV01', 200000, 10000)
INSERT INTO HOADON VALUES ('HD00002', '2020/11/27', 'KH00001', 'NV01', 100000, 5000)
INSERT INTO HOADON VALUES ('HD00003', '2020/11/26', 'KH00001', 'NV01', 150000, 0)