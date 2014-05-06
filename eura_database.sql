/*
Navicat MySQL Data Transfer

Source Server         : Test
Source Server Version : 50522
Source Host           : localhost:3306
Source Database       : eura_database

Target Server Type    : MYSQL
Target Server Version : 50522
File Encoding         : 65001

Date: 2014-05-06 10:39:16
*/
CREATE DATABASE IF NOT EXISTS `eura_database`;
SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for empleado
-- ----------------------------
DROP TABLE IF EXISTS `empleado`;
CREATE TABLE `empleado` (
  `id_empleado` int(10) NOT NULL,
  `nombre` varchar(40) COLLATE latin1_spanish_ci DEFAULT NULL,
  `username` varchar(30) COLLATE latin1_spanish_ci DEFAULT NULL,
  `password` varchar(16) COLLATE latin1_spanish_ci DEFAULT NULL,
  `puesto` int(10) DEFAULT NULL,
  `status` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_empleado`),
  KEY `FK_puesto_employee` (`puesto`),
  CONSTRAINT `FK_puesto_employee` FOREIGN KEY (`puesto`) REFERENCES `puesto` (`id_puesto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Table structure for entrada
-- ----------------------------
DROP TABLE IF EXISTS `entrada`;
CREATE TABLE `entrada` (
  `id_entrada` int(10) NOT NULL,
  `concepto` varchar(60) COLLATE latin1_spanish_ci DEFAULT NULL,
  `nota` int(10) DEFAULT NULL,
  `proveedor` int(10) DEFAULT NULL,
  `empleado` int(10) DEFAULT NULL,
  `precio` double(10,2) DEFAULT NULL,
  `cantidad` int(10) DEFAULT NULL,
  `tipo_unidad` varchar(10) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_entrada`),
  KEY `FK_PROV_ENT` (`proveedor`),
  KEY `FK_EMP_ENT` (`empleado`),
  CONSTRAINT `FK_EMP_ENT` FOREIGN KEY (`empleado`) REFERENCES `empleado` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_PROV_ENT` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Table structure for material
-- ----------------------------
DROP TABLE IF EXISTS `material`;
CREATE TABLE `material` (
  `id_material` int(10) NOT NULL,
  `unidad` varchar(6) COLLATE latin1_spanish_ci DEFAULT NULL,
  `concepto` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `cantidad` int(10) DEFAULT NULL,
  `num_nota` int(10) DEFAULT NULL,
  `fecha_entrada` varchar(15) COLLATE latin1_spanish_ci DEFAULT NULL,
  `notas` varchar(150) COLLATE latin1_spanish_ci DEFAULT NULL,
  `kg` double(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_material`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Table structure for movimientos_sistema
-- ----------------------------
DROP TABLE IF EXISTS `movimientos_sistema`;
CREATE TABLE `movimientos_sistema` (
  `id_movimiento` int(10) NOT NULL,
  `tipo` varchar(60) COLLATE latin1_spanish_ci DEFAULT NULL,
  `descripcion` varchar(200) COLLATE latin1_spanish_ci DEFAULT NULL,
  `fecha` varchar(10) COLLATE latin1_spanish_ci DEFAULT NULL,
  `empleado` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_movimiento`),
  KEY `FK_EMP_MOVSIS` (`empleado`),
  CONSTRAINT `FK_EMP_MOVSIS` FOREIGN KEY (`empleado`) REFERENCES `empleado` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Table structure for obra_destino
-- ----------------------------
DROP TABLE IF EXISTS `obra_destino`;
CREATE TABLE `obra_destino` (
  `id_obra` int(10) NOT NULL,
  `obra` varchar(40) COLLATE latin1_spanish_ci DEFAULT NULL,
  `direccion` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_obra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Table structure for proveedor
-- ----------------------------
DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE `proveedor` (
  `id_proveedor` int(10) NOT NULL,
  `RFC` varchar(30) COLLATE latin1_spanish_ci DEFAULT NULL,
  `razon_social` varchar(70) COLLATE latin1_spanish_ci DEFAULT NULL,
  `direccion` varchar(200) COLLATE latin1_spanish_ci DEFAULT NULL,
  `telefono_contacto` varchar(30) COLLATE latin1_spanish_ci DEFAULT NULL,
  `email` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `status` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `website` varchar(70) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Table structure for puesto
-- ----------------------------
DROP TABLE IF EXISTS `puesto`;
CREATE TABLE `puesto` (
  `id_puesto` int(10) NOT NULL,
  `puesto` varchar(40) COLLATE latin1_spanish_ci DEFAULT NULL,
  `descripcion` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_puesto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Table structure for salida
-- ----------------------------
DROP TABLE IF EXISTS `salida`;
CREATE TABLE `salida` (
  `id_salida` int(10) NOT NULL,
  `fecha_salida` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `kg` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `obra` int(10) DEFAULT NULL,
  `nota` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `num_salidas` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_salida`),
  KEY `FK_OBRA_SAL` (`obra`),
  CONSTRAINT `FK_OBRA_SAL` FOREIGN KEY (`obra`) REFERENCES `obra_destino` (`id_obra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;
