-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 14-08-2014 a las 05:39:07
-- Versión del servidor: 5.6.12-log
-- Versión de PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `bdtaller`
--
CREATE DATABASE IF NOT EXISTS `bdtaller` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `bdtaller`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detaseg`
--

CREATE TABLE IF NOT EXISTS `tabt_detaseg` (
  `direccion_detseg` varchar(45) DEFAULT NULL,
  `telefono_detseg` varchar(45) DEFAULT NULL,
  `email_detseg` varchar(45) DEFAULT NULL,
  `idaseguradora_detseg` int(11) NOT NULL,
  KEY `fk_tabt_detaseg_tab_aseguradora1_idx` (`idaseguradora_detseg`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detfact`
--

CREATE TABLE IF NOT EXISTS `tabt_detfact` (
  `idfactura_detfact` int(11) NOT NULL,
  `idservicio_detfact` int(11) NOT NULL,
  `idrepuesto_detfact` int(11) NOT NULL,
  `valor_detfact` decimal(2,2) DEFAULT NULL,
  KEY `fk_tabt_detfact_tab_factura1_idx` (`idfactura_detfact`),
  KEY `fk_tabt_detfact_tabt_servicio1_idx` (`idservicio_detfact`),
  KEY `fk_tabt_detfact_tab_repuesto1_idx` (`idrepuesto_detfact`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detprov`
--

CREATE TABLE IF NOT EXISTS `tabt_detprov` (
  `direccion_detprov` varchar(45) NOT NULL,
  `telefono_detprov` varchar(45) DEFAULT NULL,
  `email_detprov` varchar(45) DEFAULT NULL,
  `idproveedor_detprov` int(11) NOT NULL,
  KEY `fk_tabt_detprov_tab_proveedor1_idx` (`idproveedor_detprov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_det_cliente`
--

CREATE TABLE IF NOT EXISTS `tabt_det_cliente` (
  `domicilio_detcte` varchar(45) DEFAULT NULL,
  `telefono_detcte` varchar(45) DEFAULT NULL,
  `movil_detcte` varchar(45) DEFAULT NULL,
  `email_detcte` varchar(45) DEFAULT NULL,
  `idcliente_detcte` int(11) NOT NULL,
  KEY `fk_tabt_det_cliente_tab_cliente_idx` (`idcliente_detcte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_det_emp`
--

CREATE TABLE IF NOT EXISTS `tabt_det_emp` (
  `domicilio_detemp` varchar(45) DEFAULT NULL,
  `telefono_detemp` varchar(45) DEFAULT NULL,
  `movil_detemp` varchar(45) DEFAULT NULL,
  `email_detemp` varchar(45) DEFAULT NULL,
  `idempleado_detemp` int(11) NOT NULL,
  KEY `fk_tabt_det_emp_tab_empleado1_idx` (`idempleado_detemp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_servicio`
--

CREATE TABLE IF NOT EXISTS `tabt_servicio` (
  `id_servicio` int(11) NOT NULL,
  `idcliente_servicio` int(11) NOT NULL,
  `idautomovil_servicio` int(11) NOT NULL,
  `idempleado_servicio` int(11) NOT NULL,
  `idtiposervicio_servicio` int(11) NOT NULL,
  PRIMARY KEY (`id_servicio`),
  KEY `fk_tab_servicio_tab_cliente1_idx` (`idcliente_servicio`),
  KEY `fk_tabt_servicio_tab_automovil1_idx` (`idautomovil_servicio`),
  KEY `fk_tabt_servicio_tab_empleado1_idx` (`idempleado_servicio`),
  KEY `fk_tabt_servicio_tab_tiposervicio1_idx` (`idtiposervicio_servicio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_aseguradora`
--

CREATE TABLE IF NOT EXISTS `tab_aseguradora` (
  `id_aseg` int(11) NOT NULL,
  `descripcion_aseg` varchar(45) DEFAULT NULL,
  `idautomovil_aseg` int(11) NOT NULL,
  PRIMARY KEY (`id_aseg`),
  KEY `fk_tab_aseguradora_tab_automovil1_idx` (`idautomovil_aseg`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_automovil`
--

CREATE TABLE IF NOT EXISTS `tab_automovil` (
  `id_auto` int(11) NOT NULL,
  `matricula_auto` varchar(45) DEFAULT NULL,
  `modelo_auto` varchar(45) DEFAULT NULL,
  `color_auto` varchar(45) DEFAULT NULL,
  `estado_auto` varchar(45) DEFAULT NULL,
  `kilometros_auto` varchar(45) DEFAULT NULL,
  `numpolisa_auto` varchar(45) DEFAULT NULL,
  `idcliente_auto` int(11) NOT NULL,
  PRIMARY KEY (`id_auto`),
  KEY `fk_tab_automovil_tab_cliente1_idx` (`idcliente_auto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_bodega`
--

CREATE TABLE IF NOT EXISTS `tab_bodega` (
  `id_bodega` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_bodega`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_cliente`
--

CREATE TABLE IF NOT EXISTS `tab_cliente` (
  `id_cte` int(11) NOT NULL,
  `nombre1_cte` varchar(45) DEFAULT NULL,
  `nombre2_cte` varchar(45) DEFAULT NULL,
  `apellido1_cte` varchar(45) DEFAULT NULL,
  `apellido2_cte` varchar(45) DEFAULT NULL,
  `nit_cte` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_cte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_departamento`
--

CREATE TABLE IF NOT EXISTS `tab_departamento` (
  `id_depto` int(11) NOT NULL,
  `descripcion_depto` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_depto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_empleado`
--

CREATE TABLE IF NOT EXISTS `tab_empleado` (
  `id_emp` int(11) NOT NULL,
  `nombre1_emp` varchar(45) DEFAULT NULL,
  `nombre2_emp` varchar(45) DEFAULT NULL,
  `apellido1_emp` varchar(45) DEFAULT NULL,
  `apellido2_emp` varchar(45) DEFAULT NULL,
  `fechaalta_emp` varchar(45) DEFAULT NULL,
  `fechabaja_emp` decimal(2,2) DEFAULT NULL,
  `salario_emp` varchar(45) DEFAULT NULL,
  `iddepartament_emp` int(11) NOT NULL,
  `idjornada_emp` int(11) NOT NULL,
  PRIMARY KEY (`id_emp`),
  KEY `fk_tab_empleado_tab_departamento1_idx` (`iddepartament_emp`),
  KEY `fk_tab_empleado_tab_jornada1_idx` (`idjornada_emp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_estante`
--

CREATE TABLE IF NOT EXISTS `tab_estante` (
  `id_estante` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_estante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_factura`
--

CREATE TABLE IF NOT EXISTS `tab_factura` (
  `id_fact` int(11) NOT NULL,
  `fecha_fact` varchar(45) DEFAULT NULL,
  `idcliente_fact` int(11) NOT NULL,
  PRIMARY KEY (`id_fact`),
  KEY `fk_tab_factura_tab_cliente1_idx` (`idcliente_fact`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_inventario`
--

CREATE TABLE IF NOT EXISTS `tab_inventario` (
  `id_invent` int(11) NOT NULL,
  `fecha_inventario` varchar(45) DEFAULT NULL,
  `id_repto` int(11) NOT NULL,
  `id_ubicacion` int(11) NOT NULL,
  PRIMARY KEY (`id_invent`),
  KEY `fk_tab_inventario_tab_repuesto1_idx` (`id_repto`),
  KEY `fk_tab_inventario_tab_ubicacion1_idx` (`id_ubicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='	';

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_jornada`
--

CREATE TABLE IF NOT EXISTS `tab_jornada` (
  `id_jornada` int(11) NOT NULL,
  `descripcion_jornada` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_jornada`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_proveedor`
--

CREATE TABLE IF NOT EXISTS `tab_proveedor` (
  `id_prov` int(11) NOT NULL,
  `nombre_prov` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_prov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_repuesto`
--

CREATE TABLE IF NOT EXISTS `tab_repuesto` (
  `id_repto` int(11) NOT NULL,
  `descripcion_repto` varchar(45) DEFAULT NULL,
  `marca_repto` varchar(45) DEFAULT NULL,
  `precio_repto` decimal(2,2) DEFAULT NULL,
  `existencia_repto` int(11) DEFAULT NULL,
  `idproveedor_repto` int(11) NOT NULL,
  PRIMARY KEY (`id_repto`),
  KEY `fk_tab_repuesto_tab_proveedor1_idx` (`idproveedor_repto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_tiposervicio`
--

CREATE TABLE IF NOT EXISTS `tab_tiposervicio` (
  `id_tserv` int(11) NOT NULL,
  `descripcion_tserv` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_tserv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_tipusuario`
--

CREATE TABLE IF NOT EXISTS `tab_tipusuario` (
  `id_tipuser` int(11) NOT NULL,
  `descripcion_tipuser` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_tipuser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_ubicacion`
--

CREATE TABLE IF NOT EXISTS `tab_ubicacion` (
  `id_ubica` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `id_bodega` int(11) NOT NULL,
  `id_estante` int(11) NOT NULL,
  PRIMARY KEY (`id_ubica`),
  KEY `fk_tab_ubicacion_tab_bodega1_idx` (`id_bodega`),
  KEY `fk_tab_ubicacion_tab_estante1_idx` (`id_estante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tab_usuario`
--

CREATE TABLE IF NOT EXISTS `tab_usuario` (
  `id_user` int(11) NOT NULL,
  `usuario_user` varchar(45) DEFAULT NULL,
  `contraseña_user` varchar(45) DEFAULT NULL,
  `idempleado_user` int(11) NOT NULL,
  `idtipusuario_user` int(11) NOT NULL,
  PRIMARY KEY (`id_user`),
  KEY `fk_tab_usuario_tab_empleado1_idx` (`idempleado_user`),
  KEY `fk_tab_usuario_tab_tipusuario1_idx` (`idtipusuario_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tabt_detaseg`
--
ALTER TABLE `tabt_detaseg`
  ADD CONSTRAINT `fk_tabt_detaseg_tab_aseguradora1` FOREIGN KEY (`idaseguradora_detseg`) REFERENCES `tab_aseguradora` (`id_aseg`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabt_detfact`
--
ALTER TABLE `tabt_detfact`
  ADD CONSTRAINT `fk_tabt_detfact_tab_factura1` FOREIGN KEY (`idfactura_detfact`) REFERENCES `tab_factura` (`id_fact`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tabt_detfact_tabt_servicio1` FOREIGN KEY (`idservicio_detfact`) REFERENCES `tabt_servicio` (`id_servicio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tabt_detfact_tab_repuesto1` FOREIGN KEY (`idrepuesto_detfact`) REFERENCES `tab_repuesto` (`id_repto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabt_detprov`
--
ALTER TABLE `tabt_detprov`
  ADD CONSTRAINT `fk_tabt_detprov_tab_proveedor1` FOREIGN KEY (`idproveedor_detprov`) REFERENCES `tab_proveedor` (`id_prov`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabt_det_cliente`
--
ALTER TABLE `tabt_det_cliente`
  ADD CONSTRAINT `fk_tabt_det_cliente_tab_cliente` FOREIGN KEY (`idcliente_detcte`) REFERENCES `tab_cliente` (`id_cte`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabt_det_emp`
--
ALTER TABLE `tabt_det_emp`
  ADD CONSTRAINT `fk_tabt_det_emp_tab_empleado1` FOREIGN KEY (`idempleado_detemp`) REFERENCES `tab_empleado` (`id_emp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabt_servicio`
--
ALTER TABLE `tabt_servicio`
  ADD CONSTRAINT `fk_tab_servicio_tab_cliente1` FOREIGN KEY (`idcliente_servicio`) REFERENCES `tab_cliente` (`id_cte`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tabt_servicio_tab_automovil1` FOREIGN KEY (`idautomovil_servicio`) REFERENCES `tab_automovil` (`id_auto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tabt_servicio_tab_empleado1` FOREIGN KEY (`idempleado_servicio`) REFERENCES `tab_empleado` (`id_emp`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tabt_servicio_tab_tiposervicio1` FOREIGN KEY (`idtiposervicio_servicio`) REFERENCES `tab_tiposervicio` (`id_tserv`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_aseguradora`
--
ALTER TABLE `tab_aseguradora`
  ADD CONSTRAINT `fk_tab_aseguradora_tab_automovil1` FOREIGN KEY (`idautomovil_aseg`) REFERENCES `tab_automovil` (`id_auto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_automovil`
--
ALTER TABLE `tab_automovil`
  ADD CONSTRAINT `fk_tab_automovil_tab_cliente1` FOREIGN KEY (`idcliente_auto`) REFERENCES `tab_cliente` (`id_cte`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_empleado`
--
ALTER TABLE `tab_empleado`
  ADD CONSTRAINT `fk_tab_empleado_tab_departamento1` FOREIGN KEY (`iddepartament_emp`) REFERENCES `tab_departamento` (`id_depto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tab_empleado_tab_jornada1` FOREIGN KEY (`idjornada_emp`) REFERENCES `tab_jornada` (`id_jornada`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_factura`
--
ALTER TABLE `tab_factura`
  ADD CONSTRAINT `fk_tab_factura_tab_cliente1` FOREIGN KEY (`idcliente_fact`) REFERENCES `tab_cliente` (`id_cte`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_inventario`
--
ALTER TABLE `tab_inventario`
  ADD CONSTRAINT `fk_tab_inventario_tab_repuesto1` FOREIGN KEY (`id_repto`) REFERENCES `tab_repuesto` (`id_repto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tab_inventario_tab_ubicacion1` FOREIGN KEY (`id_ubicacion`) REFERENCES `tab_ubicacion` (`id_ubica`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_repuesto`
--
ALTER TABLE `tab_repuesto`
  ADD CONSTRAINT `fk_tab_repuesto_tab_proveedor1` FOREIGN KEY (`idproveedor_repto`) REFERENCES `tab_proveedor` (`id_prov`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_ubicacion`
--
ALTER TABLE `tab_ubicacion`
  ADD CONSTRAINT `fk_tab_ubicacion_tab_bodega1` FOREIGN KEY (`id_bodega`) REFERENCES `tab_bodega` (`id_bodega`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tab_ubicacion_tab_estante1` FOREIGN KEY (`id_estante`) REFERENCES `tab_estante` (`id_estante`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tab_usuario`
--
ALTER TABLE `tab_usuario`
  ADD CONSTRAINT `fk_tab_usuario_tab_empleado1` FOREIGN KEY (`idempleado_user`) REFERENCES `tab_empleado` (`id_emp`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tab_usuario_tab_tipusuario1` FOREIGN KEY (`idtipusuario_user`) REFERENCES `tab_tipusuario` (`id_tipuser`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
