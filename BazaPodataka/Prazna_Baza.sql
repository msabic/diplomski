-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ordinacija
-- ------------------------------------------------------
-- Server version	5.7.20-log

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
  `Opis` varchar(500) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Dijagnoza`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dijagnoza`
--

LOCK TABLES `dijagnoza` WRITE;
/*!40000 ALTER TABLE `dijagnoza` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doktor`
--

LOCK TABLES `doktor` WRITE;
/*!40000 ALTER TABLE `doktor` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `neradni_dan`
--

LOCK TABLES `neradni_dan` WRITE;
/*!40000 ALTER TABLE `neradni_dan` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijent`
--

LOCK TABLES `pacijent` WRITE;
/*!40000 ALTER TABLE `pacijent` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijent_dodatno`
--

LOCK TABLES `pacijent_dodatno` WRITE;
/*!40000 ALTER TABLE `pacijent_dodatno` DISABLE KEYS */;
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
  `Opis` varchar(500) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Posjet`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posjet`
--

LOCK TABLES `posjet` WRITE;
/*!40000 ALTER TABLE `posjet` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radno_vrijeme`
--

LOCK TABLES `radno_vrijeme` WRITE;
/*!40000 ALTER TABLE `radno_vrijeme` DISABLE KEYS */;
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
  `Opis` varchar(500) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Recept`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recept`
--

LOCK TABLES `recept` WRITE;
/*!40000 ALTER TABLE `recept` DISABLE KEYS */;
/*!40000 ALTER TABLE `recept` ENABLE KEYS */;
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
  `Opis` varchar(500) NOT NULL,
  `Pacijent_ID_Pacijent` int(11) NOT NULL,
  `Pacijent_Doktor_ID_Doktor` int(11) NOT NULL,
  PRIMARY KEY (`ID_Uputnica`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uputnica`
--

LOCK TABLES `uputnica` WRITE;
/*!40000 ALTER TABLE `uputnica` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zakazani_termin`
--

LOCK TABLES `zakazani_termin` WRITE;
/*!40000 ALTER TABLE `zakazani_termin` DISABLE KEYS */;
/*!40000 ALTER TABLE `zakazani_termin` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-01 12:01:23
