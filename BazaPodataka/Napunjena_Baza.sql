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
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dijagnoza`
--

LOCK TABLES `dijagnoza` WRITE;
/*!40000 ALTER TABLE `dijagnoza` DISABLE KEYS */;
INSERT INTO `dijagnoza` VALUES (1,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',1,1),(2,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',1,1),(3,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',2,2),(4,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',3,3),(5,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',4,4),(6,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',5,5),(7,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',6,6),(8,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',7,7),(9,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',8,8),(10,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',1,1),(11,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',2,2),(12,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',3,3),(13,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',4,4),(14,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',5,5),(15,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',6,6),(16,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',7,7),(17,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',8,8),(18,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',1,1),(19,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',2,2),(20,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',3,3),(21,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',4,4),(22,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',5,5),(23,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',6,6),(24,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',7,7),(25,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',8,8),(26,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',1,1),(27,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',2,2),(28,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',3,3),(29,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',4,4),(30,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',5,5),(31,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',6,6),(32,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',7,7),(33,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',8,8),(34,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',1,1),(35,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',2,2),(36,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',3,3),(37,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',4,4),(38,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',5,5),(39,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',6,6),(40,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',7,7),(41,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',8,8),(42,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',1,1),(43,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',2,2),(44,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',3,3),(45,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',4,4),(46,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',5,5),(47,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',6,6),(48,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',7,7),(49,'Dijagnoza 1','Zadovoljstvo nam je da vam omogućimo pretraživanje medicinskog šifarnika bolesti, odnosno 10. reviziju Međunarodne klasifikaciju bolesti (MKB 10). Dovoljno je da u formi desno ukucate početak šifre bolesti ili zadate ključnu reč iz naziva bolesti na srpskom ili latinskom jeziku. Pretraživanje možete da suzite i izborom jedne ili više grupa bolesti. Deseta revizija MKB utvrđena je 1990. Godine i od strane pojedinih zemalja primenuje se od 1993. Godine. Ova revizija MKB uvodi alfanumeričku šifru sa slovom na prvom i brojem na drugom, trećem i četvrtom mestu. Neke kategorije su date samo sa tri mesta - bez broja na četvrtom mestu iza decimale.',8,8);
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doktor`
--

LOCK TABLES `doktor` WRITE;
/*!40000 ALTER TABLE `doktor` DISABLE KEYS */;
INSERT INTO `doktor` VALUES (1,'Mijo','Mijic','mijo@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',1),(2,'Mijo','Mijic','mijo@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',1),(3,'Ante','Antic','ante@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',2),(4,'Marko','Markic','marko@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',3),(5,'Petar','Peric','petar@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',4),(6,'Stipe','Stipic','stipe@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',1),(7,'Josip','Josipovic','josip@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',2),(8,'Jozo','Jozic','jozo@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',3),(9,'Marijo','Marijo','marijo@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',4),(10,'Mate','Matic','mate@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `neradni_dan`
--

LOCK TABLES `neradni_dan` WRITE;
/*!40000 ALTER TABLE `neradni_dan` DISABLE KEYS */;
INSERT INTO `neradni_dan` VALUES (1,'Nova godina','2018-01-01'),(2,'Velika Gospa','2018-08-15'),(3,'Svi Sveti','2018-11-01'),(4,'Bozic','2018-12-25'),(5,'Nova godina','2019-01-01');
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
INSERT INTO `pacijent` VALUES (1,'Mijo','Mijic','mijo.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',1,1),(2,'Mijo','Mijic','mijo.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,1),(3,'Petar','Peric','petar.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,2),(4,'Mate','Matic','mate.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,3),(5,'Jozo','Jozic','jozo.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,4),(6,'Kreso','Kresic','kreso.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,5),(7,'Dinko','Dinkic','dinko.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,6),(8,'Vinko','Vinkic','vinko.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,7),(9,'Stipe','Stipic','stipe.sabic1@gmail.com','4e084d2115590422b01863d5cad324ac','063272486',0,8);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijent_dodatno`
--

LOCK TABLES `pacijent_dodatno` WRITE;
/*!40000 ALTER TABLE `pacijent_dodatno` DISABLE KEYS */;
INSERT INTO `pacijent_dodatno` VALUES (1,'Mate','Milena','Zmijavci','036272486','063272486','12345678911','ozenjen',1,'1');
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
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posjet`
--

LOCK TABLES `posjet` WRITE;
/*!40000 ALTER TABLE `posjet` DISABLE KEYS */;
INSERT INTO `posjet` VALUES (1,'2018-02-02','Razlog','Opis posjeta',1,1),(2,'2018-02-02','Razlog','Opis posjeta',1,1),(3,'2018-02-02','Razlog','Opis posjeta',1,1),(4,'2018-02-02','Razlog','Opis posjeta',1,1),(5,'2018-02-02','Razlog','Opis posjeta',1,1),(6,'2018-02-02','Razlog','Opis posjeta',2,2),(7,'2018-02-02','Razlog','Opis posjeta',3,3),(8,'2018-02-02','Razlog','Opis posjeta',4,4),(9,'2018-02-02','Razlog','Opis posjeta',5,5),(10,'2018-02-02','Razlog','Opis posjeta',6,6),(11,'2018-02-02','Razlog','Opis posjeta',7,7),(12,'2018-02-02','Razlog','Opis posjeta',8,8),(13,'2018-02-02','Razlog','Opis posjeta',1,1),(14,'2018-02-02','Razlog','Opis posjeta',2,2),(15,'2018-02-02','Razlog','Opis posjeta',3,3),(16,'2018-02-02','Razlog','Opis posjeta',4,4),(17,'2018-02-02','Razlog','Opis posjeta',5,5),(18,'2018-02-02','Razlog','Opis posjeta',6,6),(19,'2018-02-02','Razlog','Opis posjeta',7,7),(20,'2018-02-02','Razlog','Opis posjeta',8,8),(21,'2018-02-02','Razlog','Opis posjeta',1,1),(22,'2018-02-02','Razlog','Opis posjeta',2,2),(23,'2018-02-02','Razlog','Opis posjeta',3,3),(24,'2018-02-02','Razlog','Opis posjeta',4,4),(25,'2018-02-02','Razlog','Opis posjeta',5,5),(26,'2018-02-02','Razlog','Opis posjeta',6,6),(27,'2018-02-02','Razlog','Opis posjeta',7,7),(28,'2018-02-02','Razlog','Opis posjeta',8,8),(29,'2018-02-02','Razlog','Opis posjeta',1,1),(30,'2018-02-02','Razlog','Opis posjeta',2,2),(31,'2018-02-02','Razlog','Opis posjeta',3,3),(32,'2018-02-02','Razlog','Opis posjeta',4,4),(33,'2018-02-02','Razlog','Opis posjeta',5,5),(34,'2018-02-02','Razlog','Opis posjeta',6,6),(35,'2018-02-02','Razlog','Opis posjeta',7,7),(36,'2018-02-02','Razlog','Opis posjeta',8,8),(37,'2018-02-02','Razlog','Opis posjeta',1,1),(38,'2018-02-02','Razlog','Opis posjeta',2,2),(39,'2018-02-02','Razlog','Opis posjeta',3,3),(40,'2018-02-02','Razlog','Opis posjeta',4,4),(41,'2018-02-02','Razlog','Opis posjeta',5,5),(42,'2018-02-02','Razlog','Opis posjeta',6,6),(43,'2018-02-02','Razlog','Opis posjeta',7,7),(44,'2018-02-02','Razlog','Opis posjeta',8,8);
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radno_vrijeme`
--

LOCK TABLES `radno_vrijeme` WRITE;
/*!40000 ALTER TABLE `radno_vrijeme` DISABLE KEYS */;
INSERT INTO `radno_vrijeme` VALUES (1,'Neparni','Jutro'),(2,'Neparni','Posljepodne'),(3,'Parni','Jutro'),(4,'Parni','Posljepodne');
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
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recept`
--

LOCK TABLES `recept` WRITE;
/*!40000 ALTER TABLE `recept` DISABLE KEYS */;
INSERT INTO `recept` VALUES (1,'Nazic','2018-03-03','Opis recepta',1,1),(2,'Naziv','2018-03-03','Opis recepta',1,1),(3,'Naziv','2018-03-03','Opis recepta',2,2),(4,'Naziv','2018-03-03','Opis recepta',3,3),(5,'Naziv','2018-03-03','Opis recepta',4,4),(6,'Naziv','2018-03-03','Opis recepta',5,5),(7,'Naziv','2018-03-03','Opis recepta',6,6),(8,'Naziv','2018-03-03','Opis recepta',7,7),(9,'Naziv','2018-03-03','Opis recepta',8,8),(10,'Naziv','2018-03-03','Opis recepta',1,1),(11,'Naziv','2018-03-03','Opis recepta',2,2),(12,'Naziv','2018-03-03','Opis recepta',3,3),(13,'Naziv','2018-03-03','Opis recepta',4,4),(14,'Naziv','2018-03-03','Opis recepta',5,5),(15,'Naziv','2018-03-03','Opis recepta',6,6),(16,'Naziv','2018-03-03','Opis recepta',7,7),(17,'Naziv','2018-03-03','Opis recepta',8,8),(18,'Naziv','2018-03-03','Opis recepta',1,1),(19,'Naziv','2018-03-03','Opis recepta',2,2),(20,'Naziv','2018-03-03','Opis recepta',3,3),(21,'Naziv','2018-03-03','Opis recepta',4,4),(22,'Naziv','2018-03-03','Opis recepta',5,5),(23,'Naziv','2018-03-03','Opis recepta',6,6),(24,'Naziv','2018-03-03','Opis recepta',7,7),(25,'Naziv','2018-03-03','Opis recepta',8,8),(26,'Naziv','2018-03-03','Opis recepta',1,1),(27,'Naziv','2018-03-03','Opis recepta',2,2),(28,'Naziv','2018-03-03','Opis recepta',3,3),(29,'Naziv','2018-03-03','Opis recepta',4,4),(30,'Naziv','2018-03-03','Opis recepta',5,5),(31,'Naziv','2018-03-03','Opis recepta',6,6),(32,'Naziv','2018-03-03','Opis recepta',7,7),(33,'Naziv','2018-03-03','Opis recepta',8,8),(34,'Naziv','2018-03-03','Opis recepta',1,1),(35,'Naziv','2018-03-03','Opis recepta',2,2),(36,'Naziv','2018-03-03','Opis recepta',3,3),(37,'Naziv','2018-03-03','Opis recepta',4,4),(38,'Naziv','2018-03-03','Opis recepta',5,5),(39,'Naziv','2018-03-03','Opis recepta',6,6),(40,'Naziv','2018-03-03','Opis recepta',7,7),(41,'Naziv','2018-03-03','Opis recepta',8,8),(42,'Naziv','2018-03-03','Opis recepta',1,1),(43,'Naziv','2018-03-03','Opis recepta',2,2),(44,'Naziv','2018-03-03','Opis recepta',3,3),(45,'Naziv','2018-03-03','Opis recepta',4,4),(46,'Naziv','2018-03-03','Opis recepta',5,5),(47,'Naziv','2018-03-03','Opis recepta',6,6),(48,'Naziv','2018-03-03','Opis recepta',7,7),(49,'Naziv','2018-03-03','Opis recepta',8,8),(50,'Naziv','2018-03-03','Opis recepta',1,1),(51,'Naziv','2018-03-03','Opis recepta',2,2),(52,'Naziv','2018-03-03','Opis recepta',3,3),(53,'Naziv','2018-03-03','Opis recepta',4,4),(54,'Naziv','2018-03-03','Opis recepta',5,5),(55,'Naziv','2018-03-03','Opis recepta',6,6),(56,'Naziv','2018-03-03','Opis recepta',7,7),(57,'Naziv','2018-03-03','Opis recepta',8,8),(58,'Naziv','2018-03-03','Opis recepta',1,1),(59,'Naziv','2018-03-03','Opis recepta',2,2),(60,'Naziv','2018-03-03','Opis recepta',3,3),(61,'Naziv','2018-03-03','Opis recepta',4,4),(62,'Naziv','2018-03-03','Opis recepta',5,5),(63,'Naziv','2018-03-03','Opis recepta',6,6),(64,'Naziv','2018-03-03','Opis recepta',7,7),(65,'Naziv','2018-03-03','Opis recepta',8,8);
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
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uputnica`
--

LOCK TABLES `uputnica` WRITE;
/*!40000 ALTER TABLE `uputnica` DISABLE KEYS */;
INSERT INTO `uputnica` VALUES (1,'Naziv Uputnice','Opis Uputnice',1,1),(2,'Naziv Uputnice','Opis Uputnice',1,1),(3,'Naziv Uputnice','Opis Uputnice',2,2),(4,'Naziv Uputnice','Opis Uputnice',3,3),(5,'Naziv Uputnice','Opis Uputnice',4,4),(6,'Naziv Uputnice','Opis Uputnice',5,5),(7,'Naziv Uputnice','Opis Uputnice',6,6),(8,'Naziv Uputnice','Opis Uputnice',7,7),(9,'Naziv Uputnice','Opis Uputnice',8,8),(10,'Naziv Uputnice','Opis Uputnice',1,1),(11,'Naziv Uputnice','Opis Uputnice',2,2),(12,'Naziv Uputnice','Opis Uputnice',3,3),(13,'Naziv Uputnice','Opis Uputnice',4,4),(14,'Naziv Uputnice','Opis Uputnice',5,5),(15,'Naziv Uputnice','Opis Uputnice',6,6),(16,'Naziv Uputnice','Opis Uputnice',7,7),(17,'Naziv Uputnice','Opis Uputnice',8,8),(18,'Naziv Uputnice','Opis Uputnice',1,1),(19,'Naziv Uputnice','Opis Uputnice',2,2),(20,'Naziv Uputnice','Opis Uputnice',3,3),(21,'Naziv Uputnice','Opis Uputnice',4,4),(22,'Naziv Uputnice','Opis Uputnice',5,5),(23,'Naziv Uputnice','Opis Uputnice',6,6),(24,'Naziv Uputnice','Opis Uputnice',7,7),(25,'Naziv Uputnice','Opis Uputnice',8,8),(26,'Naziv Uputnice','Opis Uputnice',1,1),(27,'Naziv Uputnice','Opis Uputnice',2,2),(28,'Naziv Uputnice','Opis Uputnice',3,3),(29,'Naziv Uputnice','Opis Uputnice',4,4),(30,'Naziv Uputnice','Opis Uputnice',5,5),(31,'Naziv Uputnice','Opis Uputnice',6,6),(32,'Naziv Uputnice','Opis Uputnice',7,7),(33,'Naziv Uputnice','Opis Uputnice',8,8),(34,'Naziv Uputnice','Opis Uputnice',1,1),(35,'Naziv Uputnice','Opis Uputnice',2,2),(36,'Naziv Uputnice','Opis Uputnice',3,3),(37,'Naziv Uputnice','Opis Uputnice',4,4),(38,'Naziv Uputnice','Opis Uputnice',5,5),(39,'Naziv Uputnice','Opis Uputnice',6,6),(40,'Naziv Uputnice','Opis Uputnice',7,7),(41,'Naziv Uputnice','Opis Uputnice',8,8),(42,'Naziv Uputnice','Opis Uputnice',1,1),(43,'Naziv Uputnice','Opis Uputnice',2,2),(44,'Naziv Uputnice','Opis Uputnice',3,3),(45,'Naziv Uputnice','Opis Uputnice',4,4),(46,'Naziv Uputnice','Opis Uputnice',5,5),(47,'Naziv Uputnice','Opis Uputnice',6,6),(48,'Naziv Uputnice','Opis Uputnice',7,7),(49,'Naziv Uputnice','Opis Uputnice',8,8),(50,'Naziv Uputnice','Opis Uputnice',1,1),(51,'Naziv Uputnice','Opis Uputnice',2,2),(52,'Naziv Uputnice','Opis Uputnice',3,3),(53,'Naziv Uputnice','Opis Uputnice',4,4),(54,'Naziv Uputnice','Opis Uputnice',5,5),(55,'Naziv Uputnice','Opis Uputnice',6,6),(56,'Naziv Uputnice','Opis Uputnice',7,7),(57,'Naziv Uputnice','Opis Uputnice',8,8),(58,'Naziv Uputnice','Opis Uputnice',1,1),(59,'Naziv Uputnice','Opis Uputnice',2,2),(60,'Naziv Uputnice','Opis Uputnice',3,3),(61,'Naziv Uputnice','Opis Uputnice',4,4),(62,'Naziv Uputnice','Opis Uputnice',5,5),(63,'Naziv Uputnice','Opis Uputnice',6,6),(64,'Naziv Uputnice','Opis Uputnice',7,7),(65,'Naziv Uputnice','Opis Uputnice',8,8);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zakazani_termin`
--

LOCK TABLES `zakazani_termin` WRITE;
/*!40000 ALTER TABLE `zakazani_termin` DISABLE KEYS */;
INSERT INTO `zakazani_termin` VALUES (1,'2018-08-02','14:00:00',1,1);
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

-- Dump completed on 2018-08-01 22:55:12
