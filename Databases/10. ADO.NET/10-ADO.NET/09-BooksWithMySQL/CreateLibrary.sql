CREATE DATABASE  IF NOT EXISTS `library` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `library`;

DROP TABLE IF EXISTS `books`;
CREATE TABLE `books` (
  `idbooks` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(200) NOT NULL,
  `author` varchar(100) NOT NULL,
  `publishDate` datetime NOT NULL,
  `isbn` bigint(13) NOT NULL,
  PRIMARY KEY (`idbooks`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;