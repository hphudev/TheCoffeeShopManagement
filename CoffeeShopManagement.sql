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
	GIA INT,
	TINHTRANG BIT )

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

CREATE TABLE CHITIEU (
	ID NVARCHAR(7) PRIMARY KEY,
	THOIGIAN SMALLDATETIME NOT NULL,
	NOIDUNG NVARCHAR(100) NOT NULL,
	MANV NVARCHAR(4),
	SOTIEN INT NOT NULL,
	CONSTRAINT FK_TRALUONG_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV) )

SET DATEFORMAT DMY
INSERT INTO CHITIEU VALUES ('CT00001', '12/1/2020', N'Trả lương', 'NV01', '100000')
INSERT INTO CHITIEU VALUES ('CT00002', '30/11/2020', N'Trả lương', 'NV01', '150000')
INSERT INTO CHITIEU VALUES ('CT00003', '29/11/2020', N'Trả lương', 'NV01', '200000')
