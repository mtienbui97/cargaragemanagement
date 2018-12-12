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
-- Table structure for table `phutung`
--

DROP TABLE IF EXISTS `phutung`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phutung` (
  `MaPT` char(6) NOT NULL,
  `TenPT` varchar(50) DEFAULT NULL,
  `MoTa` text,
  `HangSX` varchar(50) DEFAULT NULL,
  `GiaPT` int(11) DEFAULT NULL,
  `ThoiHanBH` int(11) DEFAULT NULL,
  `DVT` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`MaPT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phutung`
--

LOCK TABLES `phutung` WRITE;
/*!40000 ALTER TABLE `phutung` DISABLE KEYS */;
INSERT INTO `phutung` VALUES ('PT001','Bánh đà động cơ','','VOLKS WAGEN',2000000,6,'cái'),('PT0010','Piston phanh trước','','Toyota',320000,12,'cái'),('PT0011','Giảm sóc trước','','Toyota',2700000,36,'cái'),('PT0012','Giảm chấn','','Toyota',5200000,36,'cái'),('PT0013','Rô tuyn lái trong hai bên','','Toyota',1900000,36,'cái'),('PT002','Tấm che dưới động cơ','','VOLKS WAGEN',2500000,12,'tấm'),('PT003','Cầu chì 60A yellow','','VOLKS WAGEN',80000,3,'cái'),('PT004','Cầu chì 40A green','','VOLKS WAGEN',85000,3,'cái'),('PT005','Panel cửa sau trái','','Toyota',29500000,36,'cái'),('PT006','ốp thành cửa sau trái','','Toyota',700000,36,'cái'),('PT007','Lốp Yokohana Nhật 195/65R15','','Toyota',2300000,12,'cái'),('PT008','Lốp BrigdeStone nhật 245/45R19','','Toyota',7800000,36,'cái'),('PT009','Má phanh tay','','Toyota',420000,12,'cái');
/*!40000 ALTER TABLE `phutung` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-14  1:50:21
