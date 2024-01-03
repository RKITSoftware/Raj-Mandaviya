-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: basics_of_dbms
-- ------------------------------------------------------
-- Server version	8.0.35

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
-- Table structure for table `cus01`
--

DROP TABLE IF EXISTS `cus01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cus01` (
  `s01f01` int NOT NULL AUTO_INCREMENT COMMENT 'id',
  `S01F02` varchar(45) DEFAULT NULL COMMENT 'name',
  `S01F03` int DEFAULT NULL COMMENT 'AGE',
  PRIMARY KEY (`s01f01`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cus01`
--

LOCK TABLES `cus01` WRITE;
/*!40000 ALTER TABLE `cus01` DISABLE KEYS */;
INSERT INTO `cus01` VALUES (1,'Harsh',25),(2,'Param',32),(3,'Raj 1',20),(4,'Pravin',36);
/*!40000 ALTER TABLE `cus01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emp01`
--

DROP TABLE IF EXISTS `emp01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emp01` (
  `p01f01` int NOT NULL AUTO_INCREMENT COMMENT 'id',
  `p01f02` varchar(30) DEFAULT NULL COMMENT 'name',
  `p01f03` varchar(20) DEFAULT NULL COMMENT 'role',
  `p01f04` int DEFAULT NULL COMMENT 'age',
  `p01f05` int DEFAULT NULL COMMENT 'salary',
  `p01f06` varchar(50) DEFAULT NULL COMMENT 'department',
  PRIMARY KEY (`p01f01`),
  KEY `name_age_idx` (`p01f02`,`p01f04`)
) ENGINE=InnoDB AUTO_INCREMENT=1003 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emp01`
--

LOCK TABLES `emp01` WRITE;
/*!40000 ALTER TABLE `emp01` DISABLE KEYS */;
INSERT INTO `emp01` VALUES (1,'raj','SDE',22,50000,'MGMT'),(2,'Dev','SDE',20,50000,'MGMT'),(3,'SUPER AUM','HR',NULL,66000,'MGMT'),(1001,'Dev','SDE',20,50000,'DEV TEAM'),(1002,'SUPER AUM','HR',21,60000,'MGMT');
/*!40000 ALTER TABLE `emp01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `humans`
--

DROP TABLE IF EXISTS `humans`;
/*!50001 DROP VIEW IF EXISTS `humans`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `humans` AS SELECT 
 1 AS `P01F02`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!50001 DROP VIEW IF EXISTS `sales`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `sales` AS SELECT 
 1 AS `PERSON`,
 1 AS `AMOUNT`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tra01`
--

DROP TABLE IF EXISTS `tra01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tra01` (
  `A01F01` int NOT NULL AUTO_INCREMENT COMMENT 'id',
  `A01F02` int NOT NULL COMMENT 'AMOUNT',
  `A01F03` int DEFAULT NULL COMMENT 'CUSTOMER ID',
  PRIMARY KEY (`A01F01`),
  KEY `A01F03_idx` (`A01F03`),
  CONSTRAINT `CUS-TRA-FK` FOREIGN KEY (`A01F03`) REFERENCES `cus01` (`s01f01`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tra01`
--

LOCK TABLES `tra01` WRITE;
/*!40000 ALTER TABLE `tra01` DISABLE KEYS */;
INSERT INTO `tra01` VALUES (1,5000,2),(2,2000,2),(3,2315,1),(4,1100,3),(5,500,NULL);
/*!40000 ALTER TABLE `tra01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `humans`
--

/*!50001 DROP VIEW IF EXISTS `humans`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `humans` AS select `emp01`.`p01f02` AS `P01F02` from `emp01` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `sales`
--

/*!50001 DROP VIEW IF EXISTS `sales`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `sales` AS select `cus01`.`S01F02` AS `PERSON`,`tra01`.`A01F02` AS `AMOUNT` from (`cus01` join `tra01`) where (`cus01`.`s01f01` = `tra01`.`A01F03`) */;
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

-- Dump completed on 2023-11-27 14:40:35
