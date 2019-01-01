CREATE DATABASE  IF NOT EXISTS `quanlygarageoto` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `quanlygarageoto`;
-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: quanlygarageoto
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `chitietbaoduong`
--

DROP TABLE IF EXISTS `chitietbaoduong`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `chitietbaoduong` (
  `MaCTBD` char(6) NOT NULL,
  `TrangThai` tinyint(1) DEFAULT NULL,
  `Phi` int(11) DEFAULT NULL,
  `FK_MaPT` char(6) DEFAULT NULL,
  `FK_MaDV_CTBD` char(6) DEFAULT NULL,
  `FK_MaHD` char(6) DEFAULT NULL,
  `FK_MaCV` char(6) NOT NULL,
  `SoLuong` int(11) DEFAULT NULL,
  `DonGia` int(11) DEFAULT NULL,
  PRIMARY KEY (`MaCTBD`),
  KEY `FK_MaDV_idx` (`FK_MaDV_CTBD`),
  KEY `FK_MaHD_idx` (`FK_MaHD`),
  KEY `FK_MaCV_idx` (`FK_MaCV`),
  KEY `FK_MaPT_idx` (`FK_MaPT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitietbaoduong`
--

LOCK TABLES `chitietbaoduong` WRITE;
/*!40000 ALTER TABLE `chitietbaoduong` DISABLE KEYS */;
INSERT INTO `chitietbaoduong` VALUES ('CT0001',1,2800000,'PT0001','DV0001','HD0001','CV0001',1,2800000),('CT002',1,2300000,'PT007','DV001','HD001','CV0013',1,2300000),('CT003',1,2300000,'PT007','DV001','HD001','CV0013',1,2300000),('CT004',1,2300000,'PT007','DV002','HD001','CV0013',1,2300000),('CT005',1,15600000,'PT008','DV002','HD001','CV0013',2,7800000),('CT006',1,2300000,'PT007','DV003','HD001','CV0013',1,2300000),('CT007',1,80000,'PT003','DV003','HD001','CV0009',1,80000),('CT008',1,2300000,'PT007','DV004','HD002','CV0013',1,2300000),('CT009',1,80000,'PT003','DV004','HD002','CV0009',1,80000),('CT010',1,2300000,'PT007','DV005','HD003','CV0013',1,2300000),('CT011',1,2700000,'PT0011','DV005','HD003','CV0010',1,2700000),('CT012',1,80000,'PT003','DV006','HD004','CV0009',1,80000),('CT013',1,2300000,'PT007','DV006','HD004','CV0013',1,2300000),('CT014',1,2000000,'PT001','DV007','HD005','CV0008',1,2000000),('CT015',1,2300000,'PT007','DV007','HD005','CV0013',1,2300000),('CT016',1,2000000,'PT001','DV008','HD006','CV0008',1,2000000),('CT017',1,2700000,'PT0011','DV008','HD006','CV0010',1,2700000),('CT018',1,2300000,'PT007','DV009','HD007','CV0013',1,2300000),('CT019',1,2300000,'PT007','DV010','HD008','CV0013',1,2300000),('CT020',1,2300000,'PT007','DV011','HD009','CV0013',1,2300000),('CT021',1,320000,'PT0010','DV012','HD010','CV0008',1,320000),('CT022',1,2500000,'PT002','DV012','HD010','CV0011',1,2500000),('CT023',1,2300000,'PT007','DV013','HD011','CV0013',1,2300000),('CT024',1,2700000,'PT0011','DV013','HD011','CV0010',1,2700000),('CT025',1,6000000,'PT001','DV014','HD012','CV0008',3,2000000),('CT026',1,2300000,'PT007','DV015','HD013','CV0013',1,2300000),('CT027',1,2700000,'PT0011','DV015','HD013','CV0010',1,2700000),('CT028',1,2300000,'PT007','DV016','HD014','CV0013',1,2300000),('CT029',1,7800000,'PT008','DV016','HD014','CV0013',1,7800000);
/*!40000 ALTER TABLE `chitietbaoduong` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chucvu`
--

DROP TABLE IF EXISTS `chucvu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `chucvu` (
  `MaCV` int(11) NOT NULL,
  `TenCV` varchar(45) NOT NULL,
  PRIMARY KEY (`MaCV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chucvu`
--

LOCK TABLES `chucvu` WRITE;
/*!40000 ALTER TABLE `chucvu` DISABLE KEYS */;
INSERT INTO `chucvu` VALUES (1,'Kỹ thuật viên'),(2,'Tổ trưởng'),(3,'Quản lí');
/*!40000 ALTER TABLE `chucvu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `congviec`
--

DROP TABLE IF EXISTS `congviec`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `congviec` (
  `MaCV` char(6) NOT NULL,
  `TenCV` varchar(50) DEFAULT NULL,
  `MoTa` text,
  PRIMARY KEY (`MaCV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `congviec`
--

LOCK TABLES `congviec` WRITE;
/*!40000 ALTER TABLE `congviec` DISABLE KEYS */;
INSERT INTO `congviec` VALUES ('CV0001','Kiểm tra vành và ốc',''),('CV0002','Kiểm tra lốp',''),('CV0003','Kiểm tra ống xả',''),('CV0004','Thay dầu',''),('CV0005','KT ắc quy',''),('CV0006','KT nội thât',''),('CV0007','KT đèn',''),('CV0008','KT phanh',''),('CV0009','Bảo dưỡng hộp số',''),('CV0010','KT giảm sốc, lò xo, thanh giằng',''),('CV0011','KT ngoại thất xe',''),('CV0012','Sơn xe',''),('CV0013','Thay lốp',''),('CV0014','KT rotor',''),('CV0015','KT hệ thống làm mát','');
/*!40000 ALTER TABLE `congviec` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dichvu`
--

DROP TABLE IF EXISTS `dichvu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dichvu` (
  `MaDV` char(6) NOT NULL,
  `NgayBD` date DEFAULT NULL,
  `FK_SoXe` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`MaDV`),
  KEY `FK_SoXe` (`FK_SoXe`),
  CONSTRAINT `dichvu_ibfk_1` FOREIGN KEY (`FK_SoXe`) REFERENCES `xe` (`soxe`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dichvu`
--

LOCK TABLES `dichvu` WRITE;
/*!40000 ALTER TABLE `dichvu` DISABLE KEYS */;
INSERT INTO `dichvu` VALUES ('DV001','2018-06-15','59-V1 793.79'),('DV002','2018-06-15','63-V2 145.20'),('DV003','2018-06-15','63-V2 145.20'),('DV004','2018-06-15','63-V2 145.20'),('DV005','2018-06-15','59-V1 793.79'),('DV006','2018-06-15','59-V1 793.79'),('DV007','2018-06-15','59-V1 793.79'),('DV008','2018-06-15','59-V1 793.79'),('DV009','2018-06-15','59-V1 793.79'),('DV010','2018-06-15','59-V1 793.79'),('DV011','2018-06-15','59-V1 793.79'),('DV012','2018-06-15','72-H2 000.20'),('DV013','2018-06-18','59-V1 793.79'),('DV014','2018-06-18','59-V1 793.79'),('DV015','2018-06-18','59-V1 793.79'),('DV016','2018-06-18','59-V2 178.20');
/*!40000 ALTER TABLE `dichvu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hoadon`
--

DROP TABLE IF EXISTS `hoadon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hoadon` (
  `MaHD` char(6) NOT NULL,
  `NgayLapHD` date DEFAULT NULL,
  `TongTien` int(11) DEFAULT NULL,
  `FK_MaKH` char(6) NOT NULL,
  `ThanhTien` int(11) DEFAULT NULL,
  `GiamGia` int(11) DEFAULT NULL,
  PRIMARY KEY (`MaHD`),
  KEY `FK_MaKH_idx` (`FK_MaKH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hoadon`
--

LOCK TABLES `hoadon` WRITE;
/*!40000 ALTER TABLE `hoadon` DISABLE KEYS */;
INSERT INTO `hoadon` VALUES ('HD001','2018-06-15',2980000,'KH002',2980000,0),('HD002','2018-06-15',2980000,'KH002',2980000,0),('HD003','2018-06-15',5600000,'KH001',5600000,0),('HD004','2018-06-15',2980000,'KH001',2980000,0),('HD005','2018-06-15',4900000,'KH001',4900000,0),('HD006','2018-06-15',5300000,'KH001',5300000,0),('HD007','2018-06-15',2900000,'KH001',2900000,0),('HD008','2018-06-15',2900000,'KH001',2900000,0),('HD009','2018-06-15',2900000,'KH001',2900000,0),('HD010','2018-06-15',3420000,'KH003',3249000,171000),('HD011','2018-06-18',5600000,'KH001',5320000,280000),('HD012','2018-06-18',6600000,'KH001',6270000,330000),('HD013','2018-06-18',5600000,'KH001',5320000,280000),('HD014','2018-06-18',10700000,'KH001',10700000,0);
/*!40000 ALTER TABLE `hoadon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khachhang`
--

DROP TABLE IF EXISTS `khachhang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `khachhang` (
  `MaKH` char(6) NOT NULL,
  `TenKH` varchar(50) NOT NULL,
  `NamSinh` year(4) DEFAULT NULL,
  `DiaChi` text,
  `SDT` varchar(20) NOT NULL,
  PRIMARY KEY (`MaKH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khachhang`
--

LOCK TABLES `khachhang` WRITE;
/*!40000 ALTER TABLE `khachhang` DISABLE KEYS */;
INSERT INTO `khachhang` VALUES ('KH001','Phạm Quỳnh',1997,'Thu Duc','01652794722'),('KH002','Phạm Vĩnh',1996,'Quan 7','0165121314'),('KH003','Trần Nguyên',1980,'Quận 9','0987654323'),('KH004','Nguyễn Khoa',1990,'Quận 5','0982562578'),('KH005','Đoàn Minh Tiến',1997,'Quận Tân Bình','0167733766'),('KH006','Trần Minh Quốc',1992,'Quận 1','0167733799'),('KH007','Phạm Quỳnh',1997,'Phú Nhuận','0986754231'),('KH008','Phạm Quỳnh',1991,'Vũng Tàu','0986754444');
/*!40000 ALTER TABLE `khachhang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `nhanvien` (
  `MaNV` char(11) NOT NULL,
  `TenNV` varchar(50) NOT NULL,
  `NamSinh` varchar(30) DEFAULT NULL,
  `DiaChi` text,
  `SDT` varchar(20) DEFAULT NULL,
  `ChucVu` int(11) DEFAULT NULL,
  PRIMARY KEY (`MaNV`,`TenNV`),
  KEY `ChucVu_idx` (`ChucVu`),
  CONSTRAINT `FK_ChucVu` FOREIGN KEY (`ChucVu`) REFERENCES `chucvu` (`macv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien`
--

LOCK TABLES `nhanvien` WRITE;
/*!40000 ALTER TABLE `nhanvien` DISABLE KEYS */;
INSERT INTO `nhanvien` VALUES ('1','Meo','0000-00-00','TpHCM','01286861020',1),('2','doremon','0.000169204737563451','Thu Duc','01652794722',2),('NV003','Quỳnh','1997','TpHCM','01652794722',1);
/*!40000 ALTER TABLE `nhanvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phancong`
--

DROP TABLE IF EXISTS `phancong`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phancong` (
  `MaPC` char(6) NOT NULL,
  `NgayPC` date DEFAULT NULL,
  `GhiChu` varchar(45) DEFAULT NULL,
  `MaNV` char(6) DEFAULT NULL,
  `MaCV` char(6) DEFAULT NULL,
  `MaDV` char(6) DEFAULT NULL,
  PRIMARY KEY (`MaPC`),
  KEY `FK_MaCV_idx` (`MaCV`),
  KEY `FK_MaNV_idx` (`MaNV`),
  KEY `FK_MaDV_idx` (`MaDV`),
  CONSTRAINT `FK_MaCV` FOREIGN KEY (`MaCV`) REFERENCES `congviec` (`macv`),
  CONSTRAINT `FK_MaDV` FOREIGN KEY (`MaDV`) REFERENCES `dichvu` (`madv`),
  CONSTRAINT `FK_MaNV` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`manv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phancong`
--

LOCK TABLES `phancong` WRITE;
/*!40000 ALTER TABLE `phancong` DISABLE KEYS */;
INSERT INTO `phancong` VALUES ('PC001','2018-06-15','','1','CV0013','DV011'),('PC002','2018-06-15','thay mới','1','CV0008','DV012'),('PC003','2018-06-15','thay mới','1','CV0011','DV012'),('PC004','2018-06-18','sửa chữa','1','CV0013','DV013'),('PC005','2018-06-18','sửa chữa','1','CV0010','DV013'),('PC006','2018-06-18','','1','CV0008','DV014'),('PC007','2018-06-18','','1','CV0013','DV015'),('PC008','2018-06-18','','1','CV0005','DV015'),('PC009','2018-06-18','','1','CV0010','DV015'),('PC010','2018-06-18','','1','CV0013','DV016');
/*!40000 ALTER TABLE `phancong` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phutung`
--

DROP TABLE IF EXISTS `phutung`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phutung` (
  `MaPT` char(6) NOT NULL,
  `TenPT` varchar(50) DEFAULT NULL,
  `HangSX` varchar(50) DEFAULT NULL,
  `GiaPT` int(11) DEFAULT NULL,
  `ThoiHanBH` int(11) DEFAULT NULL,
  `DVT` varchar(10) DEFAULT NULL,
  `MoTa` char(6) DEFAULT NULL,
  PRIMARY KEY (`MaPT`),
  KEY `FK_CongViec` (`MoTa`),
  CONSTRAINT `FK_CongViec` FOREIGN KEY (`MoTa`) REFERENCES `congviec` (`macv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phutung`
--

LOCK TABLES `phutung` WRITE;
/*!40000 ALTER TABLE `phutung` DISABLE KEYS */;
INSERT INTO `phutung` VALUES ('PT001','Bánh đà động cơ','VOLKS WAGEN',2000000,6,'cái','CV0008'),('PT0010','Piston phanh trước','Toyota',320000,12,'cái','CV0008'),('PT0011','Giảm sóc trước','Toyota',2700000,36,'cái','CV0010'),('PT0012','Giảm chấn','Toyota',5200000,36,'cái','CV0010'),('PT0013','Rô tuyn lái trong hai bên','Toyota',1900000,36,'cái','CV0014'),('PT002','Tấm che dưới động cơ','VOLKS WAGEN',2500000,12,'tấm','CV0011'),('PT003','Cầu chì 60A yellow','VOLKS WAGEN',80000,3,'cái','CV0009'),('PT004','Cầu chì 40A green','VOLKS WAGEN',85000,3,'cái','CV0009'),('PT005','Panel cửa sau trái','Toyota',29500000,36,'cái','CV0011'),('PT006','ốp thành cửa sau trái','Toyota',700000,36,'cái','CV0011'),('PT007','Lốp Yokohana Nhật 195/65R15','Toyota',2300000,12,'cái','CV0013'),('PT008','Lốp BrigdeStone nhật 245/45R19','Toyota',7800000,36,'cái','CV0013'),('PT009','Má phanh tay','Toyota',420000,12,'cái','CV0008');
/*!40000 ALTER TABLE `phutung` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taikhoan`
--

DROP TABLE IF EXISTS `taikhoan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `taikhoan` (
  `MaTK` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(10) NOT NULL,
  `Password` char(6) NOT NULL,
  `TinhTrang` tinyint(4) DEFAULT NULL,
  `FK_NV` char(6) DEFAULT NULL,
  PRIMARY KEY (`MaTK`),
  KEY `FK_NhanVien_idx` (`FK_NV`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taikhoan`
--

LOCK TABLES `taikhoan` WRITE;
/*!40000 ALTER TABLE `taikhoan` DISABLE KEYS */;
INSERT INTO `taikhoan` VALUES (1,'1','1',1,'1'),(2,'doremon','2',1,'2'),(3,'quynh','123456',1,'NV003');
/*!40000 ALTER TABLE `taikhoan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `xe`
--

DROP TABLE IF EXISTS `xe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `xe` (
  `SoXe` varchar(20) NOT NULL,
  `HangSX` varchar(50) DEFAULT NULL,
  `TenXe` varchar(50) DEFAULT NULL,
  `NamSX` varchar(5) DEFAULT NULL,
  `MaKH` char(6) NOT NULL,
  PRIMARY KEY (`SoXe`),
  KEY `FK_MaKH_idx` (`MaKH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `xe`
--

LOCK TABLES `xe` WRITE;
/*!40000 ALTER TABLE `xe` DISABLE KEYS */;
INSERT INTO `xe` VALUES ('56-S2 989.11','Honda','Civic Black','2018','KH004'),('58-G7 999.88','Honda','Odyssey White','2017','KH006'),('59-V1 793.79','Toyota','Vios White','2000','KH001'),('59-V2 178.20','Toyota','Innova Black','2017','KH001'),('59-V2 324.75','Toyota','Fortuner Black','2015','KH001'),('62-G7 777.88','Honda','Odyssey Black','2014','KH007'),('62-G9 555.89','Honda','City Black','2014','KH006'),('63-V2 145.20','Toyota','Innova Black','2017','KH002'),('72-H2 000.20','Toyota','Camry Black','2017','KH003'),('72-S2 111.11','Honda','CR-V Black','2018','KH003'),('79-B2 234.11','Honda','Accord Black','2015','KH004'),('79-H1 431.89','Honda','City Black','2015','KH005');
/*!40000 ALTER TABLE `xe` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-27 21:26:01
