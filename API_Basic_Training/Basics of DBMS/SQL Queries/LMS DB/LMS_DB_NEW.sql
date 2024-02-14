-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: lms
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aut01`
--

DROP TABLE IF EXISTS `aut01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aut01` (
  `T01F01` int NOT NULL COMMENT 'AUTHOR ID',
  `T01F02` varchar(30) NOT NULL COMMENT 'AUTHOR NAME',
  PRIMARY KEY (`T01F01`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aut01`
--

LOCK TABLES `aut01` WRITE;
/*!40000 ALTER TABLE `aut01` DISABLE KEYS */;
INSERT INTO `aut01` VALUES (1,'JK Rowling'),(2,'William Shakespeare'),(3,'Chetan Bhagat');
/*!40000 ALTER TABLE `aut01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boo01`
--

DROP TABLE IF EXISTS `boo01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `boo01` (
  `O01F01` int NOT NULL AUTO_INCREMENT COMMENT 'BOOK ID',
  `O01F02` varchar(50) NOT NULL COMMENT 'BOOK TITLE',
  `O01F03` int NOT NULL COMMENT 'AUTHOR ID',
  `O01F04` varchar(20) DEFAULT NULL COMMENT 'GENRE',
  PRIMARY KEY (`O01F01`),
  KEY `O01F03` (`O01F03`),
  KEY `idx_O01F02` (`O01F02`),
  CONSTRAINT `boo01_ibfk_1` FOREIGN KEY (`O01F03`) REFERENCES `aut01` (`T01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boo01`
--

LOCK TABLES `boo01` WRITE;
/*!40000 ALTER TABLE `boo01` DISABLE KEYS */;
INSERT INTO `boo01` VALUES (1,'Harry Potter',1,'Fiction'),(2,'Harry Potter 2',1,'Fiction'),(3,'Hamlet',2,'Drama'),(4,'Half Girlfriend',3,'Love-Story');
/*!40000 ALTER TABLE `boo01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boo02`
--

DROP TABLE IF EXISTS `boo02`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `boo02` (
  `O02F01` int NOT NULL AUTO_INCREMENT COMMENT 'BORROW ID',
  `O02F02` int NOT NULL COMMENT 'USER ID',
  `O02F03` int NOT NULL COMMENT 'BOOK ID',
  `O02F04` date NOT NULL COMMENT 'BORROW DATE',
  `O02F05` date NOT NULL COMMENT 'RETURN DATE',
  PRIMARY KEY (`O02F01`),
  KEY `O02F02` (`O02F02`),
  KEY `O02F03` (`O02F03`),
  CONSTRAINT `boo02_ibfk_1` FOREIGN KEY (`O02F02`) REFERENCES `use01` (`E01F01`),
  CONSTRAINT `boo02_ibfk_2` FOREIGN KEY (`O02F03`) REFERENCES `boo01` (`O01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boo02`
--

LOCK TABLES `boo02` WRITE;
/*!40000 ALTER TABLE `boo02` DISABLE KEYS */;
INSERT INTO `boo02` VALUES (1,1,2,'2023-11-28','2023-12-13'),(2,2,3,'2023-11-26','2023-12-11'),(3,3,1,'2023-11-25','2023-12-10');
/*!40000 ALTER TABLE `boo02` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `borrowedbooksview`
--

DROP TABLE IF EXISTS `borrowedbooksview`;
/*!50001 DROP VIEW IF EXISTS `borrowedbooksview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `borrowedbooksview` AS SELECT 
 1 AS `Borrower`,
 1 AS `BookTitle`,
 1 AS `BorrowDate`,
 1 AS `ReturnDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tra01`
--

DROP TABLE IF EXISTS `tra01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tra01` (
  `A01F01` int NOT NULL AUTO_INCREMENT COMMENT 'TRANSACTION ID',
  `A01F02` int NOT NULL COMMENT 'USER ID',
  `A01F03` varchar(1) NOT NULL COMMENT 'TRANSACTION TYPE',
  `A01F04` date DEFAULT NULL COMMENT 'TRANSACTION DATE',
  PRIMARY KEY (`A01F01`),
  KEY `A01F02` (`A01F02`),
  CONSTRAINT `tra01_ibfk_1` FOREIGN KEY (`A01F02`) REFERENCES `use01` (`E01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tra01`
--

LOCK TABLES `tra01` WRITE;
/*!40000 ALTER TABLE `tra01` DISABLE KEYS */;
INSERT INTO `tra01` VALUES (1,1,'B','2023-11-28'),(2,2,'B','2023-11-26'),(3,3,'B','2023-11-25'),(4,1,'R','2023-11-20');
/*!40000 ALTER TABLE `tra01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `use01`
--

DROP TABLE IF EXISTS `use01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `use01` (
  `E01F01` int NOT NULL AUTO_INCREMENT COMMENT 'USER ID',
  `E01F02` varchar(20) NOT NULL COMMENT 'USERNAME',
  `E01F03` varchar(16) NOT NULL COMMENT 'PASSWORD',
  PRIMARY KEY (`E01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `use01`
--

LOCK TABLES `use01` WRITE;
/*!40000 ALTER TABLE `use01` DISABLE KEYS */;
INSERT INTO `use01` VALUES (1,'Raj','raj123'),(2,'aum','aum123'),(3,'dev','dev123');
/*!40000 ALTER TABLE `use01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `borrowedbooksview`
--

/*!50001 DROP VIEW IF EXISTS `borrowedbooksview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`Admin`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `borrowedbooksview` AS select `use01`.`E01F02` AS `Borrower`,`boo01`.`O01F02` AS `BookTitle`,`boo02`.`O02F04` AS `BorrowDate`,`boo02`.`O02F05` AS `ReturnDate` from ((`boo02` join `use01` on((`boo02`.`O02F02` = `use01`.`E01F01`))) join `boo01` on((`boo02`.`O02F03` = `boo01`.`O01F01`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-25 11:10:22
