-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ordinacija
-- ------------------------------------------------------
-- Server version	5.7.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dijagnoza`
--

DROP TABLE IF EXISTS `dijagnoza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dijagnoza` (
  `ID_Dijagnoza` int(11) NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  `Opis` varchar(1000) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Dijagnoza`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dijagnoza`
--

LOCK TABLES `dijagnoza` WRITE;
/*!40000 ALTER TABLE `dijagnoza` DISABLE KEYS */;
INSERT INTO `dijagnoza` VALUES (1,'Dijagnoza','Here mylist got cleared, the references to the elements held by it got nulled out, but it keeps the same backing array. Then mylist was reinitialized and got a new backing array, the old one got GCed. So one way holds onto memory, the other one throws out its memory and gets reallocated from scratch (with the default capacity).',8,30),(2,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(3,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(4,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(5,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(6,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(7,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(8,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(9,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(10,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32),(11,'Dijagnoza','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,32);
/*!40000 ALTER TABLE `dijagnoza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doktor`
--

DROP TABLE IF EXISTS `doktor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doktor` (
  `ID_Doktor` int(11) NOT NULL AUTO_INCREMENT,
  `Ime` varchar(45) NOT NULL,
  `Prezime` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Lozinka` varchar(100) NOT NULL,
  `Kontakt` varchar(45) NOT NULL,
  `Radno_vrijeme_ID_Radno_vrijeme` int(11) NOT NULL,
  PRIMARY KEY (`ID_Doktor`,`Radno_vrijeme_ID_Radno_vrijeme`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doktor`
--

LOCK TABLES `doktor` WRITE;
/*!40000 ALTER TABLE `doktor` DISABLE KEYS */;
INSERT INTO `doktor` VALUES (1,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(2,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(3,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(4,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(5,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(6,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(7,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(8,'Andrea','Bilos','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10),(30,'marko','ljubicic','mijo.sabic1@gmail.com','70bf4fbe058ab394a531a88e6eea4655','025025025',10),(31,'mijo','sabic','mijo.sabic1@gmail.com','98ddbe8f118d6461f78dfac33b079b34','0994089598',11),(32,'Andrea','Biloa','bilos.andrea@gmail.com','c546c0a9bb1186f40987eea44c5bd824','321561',10);
/*!40000 ALTER TABLE `doktor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `neradni_dan`
--

DROP TABLE IF EXISTS `neradni_dan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `neradni_dan` (
  `ID_Neradni_dan` int(11) NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  `Datum` date NOT NULL,
  PRIMARY KEY (`ID_Neradni_dan`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `neradni_dan`
--

LOCK TABLES `neradni_dan` WRITE;
/*!40000 ALTER TABLE `neradni_dan` DISABLE KEYS */;
INSERT INTO `neradni_dan` VALUES (10,'Bozic','2018-12-25'),(11,'Nova godina','2019-01-01'),(12,'Svi sveti','2018-11-01');
/*!40000 ALTER TABLE `neradni_dan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacijent`
--

DROP TABLE IF EXISTS `pacijent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacijent` (
  `ID_Pacijent` int(11) NOT NULL AUTO_INCREMENT,
  `Ime` varchar(45) NOT NULL,
  `Prezime` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Lozinka` varchar(150) NOT NULL,
  `Kontakt` varchar(45) NOT NULL,
  `Aktivan` tinyint(4) NOT NULL,
  `Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Pacijent`,`Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijent`
--

LOCK TABLES `pacijent` WRITE;
/*!40000 ALTER TABLE `pacijent` DISABLE KEYS */;
INSERT INTO `pacijent` VALUES (8,'mate','mate','mijo.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','1234',1,1),(9,'mijo','mijo','mijosabic94@gmail.com','7c13aea47d6e6ddefd62d2c00653b2a4','1',1,30);
/*!40000 ALTER TABLE `pacijent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacijent_dodatno`
--

DROP TABLE IF EXISTS `pacijent_dodatno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacijent_dodatno` (
  `ID_Pacijent_dodatno` int(11) NOT NULL AUTO_INCREMENT,
  `Ime_oca` varchar(45) NOT NULL,
  `Ime_majke` varchar(45) NOT NULL,
  `Adresa` varchar(45) NOT NULL,
  `Telefon` varchar(45) NOT NULL,
  `Mobitel` varchar(45) NOT NULL,
  `JMBG` varchar(45) NOT NULL,
  `Bracno_stanje` varchar(45) NOT NULL,
  `Pusac` tinyint(4) NOT NULL,
  `Pacijent_ID_Pacijent` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_Pacijent_dodatno`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijent_dodatno`
--

LOCK TABLES `pacijent_dodatno` WRITE;
/*!40000 ALTER TABLE `pacijent_dodatno` DISABLE KEYS */;
INSERT INTO `pacijent_dodatno` VALUES (1,'Mate','Milena','K. Tomislava','123123','321321','123321','da',0,NULL),(3,'MM','mm','mm','mmm','mm','mm','Ozenjen',1,NULL),(4,'hjk','jjm','G','5','5','5','ne ozenjen',0,NULL),(5,'Mate','Milena','K. Tomislava 55','021840362','0994089598','0502994368800','ne ozenjen',1,'9'),(6,'mijo','mijo','Mijo','9999','9999','9999','ozenjen',1,'9'),(7,'h','h','C','9','9','7','ozenjen',1,'9'),(8,'jkk','jbn','Vv','9','0','8','ozenjen',1,'9'),(9,'mijo','mijo','Mijo','9','9','7','ozenjen',1,'8'),(10,'mmn','bnj','Hhh','6','9','7','ozenjen',1,'8'),(11,'jhgh','hjk','Ghj','69','99','8','ne ozenjen',0,'8'),(12,'hh','hh','Vh','96','99','85','ozenjen',0,'8'),(13,'bhg','h','H.','6','9','5','ozenjen',1,'8'),(14,'h','h','J','9','9','8','ozenjen',1,'8'),(15,'mijo','nb','Jj','6','9','7','ne ozenjen',0,'8'),(16,'hv','hb','Bb','//6','88','5','ne ozenjen',0,'8'),(17,'hhh','h','H','6','9','5','ne ozenjen',0,'8'),(18,'manda','manda','Manda','7965488','8547','8855','ozenjen',1,'8'),(19,'manda','manda','Manda','99','888','855','ozenjen',1,'8'),(20,'nmana','nsbsja','Hahaha','6494','9464','888','ozenjen',1,'8'),(21,'Mate','Milena','Zmijavci','021840362','063272486','0502994380066','ozenjen',1,'8'),(22,'b','j','H','9','8','8','ozenjen',1,'8'),(23,'mte','milena','Zmija','8679','8454','554','ozenjen',1,'8'),(24,'mate','milena','Zmijavci','986598','989797','8557885','ozenjen',1,'8'),(25,'mate','milena','Zmijavci','97975','494654','85882','ozenjen',1,'8'),(26,'m','y','D','9','8','8','ozenjen',1,'8');
/*!40000 ALTER TABLE `pacijent_dodatno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posjet`
--

DROP TABLE IF EXISTS `posjet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `posjet` (
  `ID_Posjet` int(11) NOT NULL AUTO_INCREMENT,
  `Datum` date NOT NULL,
  `Razlog` varchar(100) NOT NULL,
  `Opis` varchar(1000) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Posjet`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posjet`
--

LOCK TABLES `posjet` WRITE;
/*!40000 ALTER TABLE `posjet` DISABLE KEYS */;
INSERT INTO `posjet` VALUES (2,'2018-05-06','Bolest grla','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,1),(3,'2018-07-13','Pregled','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,30);
/*!40000 ALTER TABLE `posjet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `radno_vrijeme`
--

DROP TABLE IF EXISTS `radno_vrijeme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `radno_vrijeme` (
  `ID_Radno_vrijeme` int(11) NOT NULL AUTO_INCREMENT,
  `Parni_Neparni` varchar(20) NOT NULL,
  `Jutro_Posljepodne` varchar(20) NOT NULL,
  PRIMARY KEY (`ID_Radno_vrijeme`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radno_vrijeme`
--

LOCK TABLES `radno_vrijeme` WRITE;
/*!40000 ALTER TABLE `radno_vrijeme` DISABLE KEYS */;
INSERT INTO `radno_vrijeme` VALUES (8,'Neparni','Jutro'),(9,'Neparni','Posljepodne'),(10,'Parni','Jutro'),(11,'Parni','Posljepodne');
/*!40000 ALTER TABLE `radno_vrijeme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recept`
--

DROP TABLE IF EXISTS `recept`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `recept` (
  `ID_Recept` int(11) NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  `Datum` date NOT NULL,
  `Opis` varchar(1000) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Recept`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recept`
--

LOCK TABLES `recept` WRITE;
/*!40000 ALTER TABLE `recept` DISABLE KEYS */;
INSERT INTO `recept` VALUES (5,'Recept ','2018-06-20','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,30),(6,'Recept','2018-05-05','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,1);
/*!40000 ALTER TABLE `recept` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `slika`
--

DROP TABLE IF EXISTS `slika`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `slika` (
  `ID_Slika` int(11) NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  `Src` longblob NOT NULL,
  PRIMARY KEY (`ID_Slika`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `slika`
--

LOCK TABLES `slika` WRITE;
/*!40000 ALTER TABLE `slika` DISABLE KEYS */;
/*!40000 ALTER TABLE `slika` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uputnica`
--

DROP TABLE IF EXISTS `uputnica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uputnica` (
  `ID_Uputnica` int(11) NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  `Opis` varchar(1000) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Uputnica`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uputnica`
--

LOCK TABLES `uputnica` WRITE;
/*!40000 ALTER TABLE `uputnica` DISABLE KEYS */;
INSERT INTO `uputnica` VALUES (2,'Uputnica za snimanje','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,30),(3,'Uputnica za ultrazvuk','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,30),(4,'Masaža','Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor true. Winding enjoyed minuter her letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. Was drawing natural fat respect husband. An as noisy an offer drawn blush place. These tried for way joy wrote witty. In mr began music weeks after at begin. Education no dejection so direction pretended household do to. Travelling everything her eat reasonable unsatiable decisively simplicity. Morning request be lasting it fortune demands highest of. She steepest doubtful betrayed formerly him. Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued.',8,30);
/*!40000 ALTER TABLE `uputnica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zakazani_termin`
--

DROP TABLE IF EXISTS `zakazani_termin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zakazani_termin` (
  `ID_Zakazani_termin` int(11) NOT NULL AUTO_INCREMENT,
  `Datum` date NOT NULL,
  `Vrijeme` time NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Zakazani_termin`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zakazani_termin`
--

LOCK TABLES `zakazani_termin` WRITE;
/*!40000 ALTER TABLE `zakazani_termin` DISABLE KEYS */;
INSERT INTO `zakazani_termin` VALUES (2,'2018-07-25','15:00:00',8,30),(3,'2018-07-24','08:00:00',8,30),(4,'2018-07-26','08:30:00',8,30),(5,'2018-07-27','15:30:00',8,30);
/*!40000 ALTER TABLE `zakazani_termin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'ordinacija'
--

--
-- Dumping routines for database 'ordinacija'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-07-24 22:36:01
