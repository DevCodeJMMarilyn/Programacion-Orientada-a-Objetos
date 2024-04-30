-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-04-2024 a las 09:43:33
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `registro`
--
DROP DATABASE IF EXISTS `registro`;
CREATE DATABASE IF NOT EXISTS `registro` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `registro`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro`
--
-- Creación: 25-04-2024 a las 06:18:37
-- Última actualización: 25-04-2024 a las 07:33:37
--

CREATE TABLE `registro` (
  `id` int(11) NOT NULL,
  `formato` varchar(50) NOT NULL,
  `nombre_album` varchar(200) NOT NULL,
  `artista` varchar(100) NOT NULL,
  `precio_normal` decimal(10,0) NOT NULL,
  `precio_con_descuento` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `registro`
--

INSERT INTO `registro` (`id`, `formato`, `nombre_album`, `artista`, `precio_normal`, `precio_con_descuento`) VALUES
(5, 'Vinilo', 'Aries', 'Luis Miguel', 10, 0),
(6, 'Cassette', 'Sacrifice', 'Elthon John', 6, 0),
(7, 'Disco', 'Obras Cumbres', 'Soda Stereo', 3, 0),
(8, 'Cassette', 'Whitney', 'Whitney Houston', 8, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `registro`
--
ALTER TABLE `registro`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `registro`
--
ALTER TABLE `registro`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
