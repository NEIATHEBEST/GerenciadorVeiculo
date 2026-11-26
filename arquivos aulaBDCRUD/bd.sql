


CREATE DATABASE  `nomebanco` 
USE `nomebanco`;


CREATE TABLE IF NOT EXISTS `TABELA` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `atributo1` varchar(50) DEFAULT NULL,
  `atributo2` varchar(100) DEFAULT NULL,
  `atributo3` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
); 

INSERT INTO TABELA (atributo1,atributo2,atributo3)VALUES('INFO1','INFO2','INFO3');
