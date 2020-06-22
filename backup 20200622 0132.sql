-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.20


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema db_ddsretorno
--

CREATE DATABASE IF NOT EXISTS db_ddsretorno;
USE db_ddsretorno;

--
-- Definition of table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
CREATE TABLE `tb_cliente` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) DEFAULT NULL,
  `EMPRESA` varchar(50) DEFAULT NULL,
  `OBS` text,
  `TELEFONE` varchar(45) DEFAULT NULL,
  `DATA_RETORNO` varchar(45) DEFAULT NULL,
  `ITEM_BACKLOG` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_cliente`
--

/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` (`ID`,`NOME`,`EMPRESA`,`OBS`,`TELEFONE`,`DATA_RETORNO`,`ITEM_BACKLOG`) VALUES 
 (1,'Bruna','BSB','Pesquisa de NFs','11965846686','19/06/2020','2776'),
 (2,'Marcia','TransRV','Despesas salvas com valor zerado','1137336548','13/06/2020','2782'),
 (3,'Marcos','Simlog','Ajustar a barra de rolagem dentro da tela do portal mercado livre.','1123245343','21/06/2020','2808'),
 (4,'Vitor','Mistral','valor individual de cada entrega','11998949984','19/06/2020','2804');
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;


--
-- Definition of table `tb_concluido`
--

DROP TABLE IF EXISTS `tb_concluido`;
CREATE TABLE `tb_concluido` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) DEFAULT NULL,
  `EMPRESA` varchar(50) DEFAULT NULL,
  `OBS` text,
  `TELEFONE` varchar(45) DEFAULT NULL,
  `DATA_RETORNO` varchar(45) DEFAULT NULL,
  `ITEM_BACKLOG` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_concluido`
--

/*!40000 ALTER TABLE `tb_concluido` DISABLE KEYS */;
INSERT INTO `tb_concluido` (`ID`,`NOME`,`EMPRESA`,`OBS`,`TELEFONE`,`DATA_RETORNO`,`ITEM_BACKLOG`) VALUES 
 (1,'Franccesco','DDS','Lançamento Agregado - Adiantamento','11966059946','21/06/2020','2806'),
 (2,'Franccesco','DDS','Precisa fazer instalação.','11984354654','21/06/2020','5687');
/*!40000 ALTER TABLE `tb_concluido` ENABLE KEYS */;


--
-- Definition of table `tb_login`
--

DROP TABLE IF EXISTS `tb_login`;
CREATE TABLE `tb_login` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `USUARIO` varchar(50) NOT NULL,
  `SENHA` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_login`
--

/*!40000 ALTER TABLE `tb_login` DISABLE KEYS */;
INSERT INTO `tb_login` (`ID`,`USUARIO`,`SENHA`) VALUES 
 (1,'admin','123456');
/*!40000 ALTER TABLE `tb_login` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
