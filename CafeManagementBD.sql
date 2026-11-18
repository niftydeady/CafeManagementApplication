/*
SQLyog Community v13.1.5  (64 bit)
MySQL - 8.1.0 : Database - cafemanagementdb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`cafemanagementdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `cafemanagementdb`;

/*Table structure for table `category` */

DROP TABLE IF EXISTS `category`;

CREATE TABLE `category` (
  `stockNameID` varchar(255) NOT NULL,
  `price` double NOT NULL,
  `type` varchar(255) NOT NULL,
  PRIMARY KEY (`stockNameID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `category` */

/*Table structure for table `customertb` */

DROP TABLE IF EXISTS `customertb`;

CREATE TABLE `customertb` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `orderhistory` int NOT NULL,
  `email` varchar(255) NOT NULL,
  `rewards` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `customertb` */

/*Table structure for table `menutb` */

DROP TABLE IF EXISTS `menutb`;

CREATE TABLE `menutb` (
  `menuNameID` int NOT NULL,
  `user` varchar(255) NOT NULL,
  `stockNameID` varchar(255) NOT NULL,
  `price` double NOT NULL,
  `quantity` int NOT NULL,
  `type` varchar(255) NOT NULL,
  `rewards` double NOT NULL,
  PRIMARY KEY (`menuNameID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `menutb` */

/*Table structure for table `menutotal` */

DROP TABLE IF EXISTS `menutotal`;

CREATE TABLE `menutotal` (
  `orderID` int NOT NULL,
  `priceItem` double NOT NULL,
  `rewardsTotal` double NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  PRIMARY KEY (`orderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `menutotal` */

/*Table structure for table `orderhistorytb` */

DROP TABLE IF EXISTS `orderhistorytb`;

CREATE TABLE `orderhistorytb` (
  `orderHistoryID` int NOT NULL,
  `total` double NOT NULL,
  PRIMARY KEY (`orderHistoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `orderhistorytb` */

/*Table structure for table `orderreceipt` */

DROP TABLE IF EXISTS `orderreceipt`;

CREATE TABLE `orderreceipt` (
  `orderID` int NOT NULL,
  `total` double NOT NULL,
  `receiptNO` int NOT NULL,
  `rewards` double NOT NULL,
  PRIMARY KEY (`orderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `orderreceipt` */

/*Table structure for table `rewardstb` */

DROP TABLE IF EXISTS `rewardstb`;

CREATE TABLE `rewardstb` (
  `orderID` int NOT NULL,
  `total` double NOT NULL,
  PRIMARY KEY (`orderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `rewardstb` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
