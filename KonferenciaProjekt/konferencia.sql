-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Feb 07. 13:23
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `konferencia`
--
CREATE DATABASE IF NOT EXISTS `konferencia` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `konferencia`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `eloadasok`
--

CREATE TABLE `eloadasok` (
  `eloadasid` int(1) NOT NULL,
  `cim` varchar(48) DEFAULT NULL,
  `sorok` int(1) DEFAULT NULL,
  `szekek` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `eloadasok`
--

INSERT INTO `eloadasok` (`eloadasid`, `cim`, `sorok`, `szekek`) VALUES
(1, 'Babits Mihály gondolati lírája (Tóth Miklós)', 3, 6),
(2, 'Petőfi Sándor hatása az utókorra (Kovács Pál)', 5, 6),
(3, 'Móricz Zsigmond titkos szerelme (Mészáros Panna)', 4, 9),
(4, 'Esterházy Péter zsengéiről (Lukovecz Hanna)', 5, 7);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ertekelesek`
--

CREATE TABLE `ertekelesek` (
  `eloadasid` int(1) DEFAULT NULL,
  `sor` int(1) DEFAULT NULL,
  `szek` int(1) DEFAULT NULL,
  `ertekeles` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `ertekelesek`
--

INSERT INTO `ertekelesek` (`eloadasid`, `sor`, `szek`, `ertekeles`) VALUES
(1, 1, 1, 0),
(1, 1, 2, 0),
(1, 1, 3, 2),
(1, 1, 4, 3),
(1, 1, 5, 0),
(1, 1, 6, 2),
(1, 2, 1, 0),
(1, 2, 2, 1),
(1, 2, 3, 2),
(1, 2, 4, 2),
(1, 2, 5, 0),
(1, 2, 6, 0),
(1, 3, 1, 0),
(1, 3, 2, 2),
(1, 3, 3, 0),
(1, 3, 4, 1),
(1, 3, 5, 0),
(1, 3, 6, 0),
(2, 1, 1, 2),
(2, 1, 2, 0),
(2, 1, 3, 0),
(2, 1, 4, 2),
(2, 1, 5, 2),
(2, 1, 6, 3),
(2, 2, 1, 1),
(2, 2, 2, 0),
(2, 2, 3, 0),
(2, 2, 4, 2),
(2, 2, 5, 3),
(2, 2, 6, 0),
(2, 3, 1, 0),
(2, 3, 2, 1),
(2, 3, 3, 3),
(2, 3, 4, 0),
(2, 3, 5, 1),
(2, 3, 6, 3),
(2, 4, 1, 1),
(2, 4, 2, 0),
(2, 4, 3, 3),
(2, 4, 4, 1),
(2, 4, 5, 3),
(2, 4, 6, 3),
(2, 5, 1, 3),
(2, 5, 2, 1),
(2, 5, 3, 3),
(2, 5, 4, 0),
(2, 5, 5, 2),
(2, 5, 6, 2),
(3, 1, 1, 1),
(3, 1, 2, 1),
(3, 1, 3, 2),
(3, 1, 4, 3),
(3, 1, 5, 3),
(3, 1, 6, 3),
(3, 1, 7, 2),
(3, 1, 8, 0),
(3, 1, 9, 3),
(3, 2, 1, 2),
(3, 2, 2, 3),
(3, 2, 3, 3),
(3, 2, 4, 2),
(3, 2, 5, 1),
(3, 2, 6, 1),
(3, 2, 7, 2),
(3, 2, 8, 3),
(3, 2, 9, 0),
(3, 3, 1, 0),
(3, 3, 2, 2),
(3, 3, 3, 2),
(3, 3, 4, 3),
(3, 3, 5, 3),
(3, 3, 6, 3),
(3, 3, 7, 0),
(3, 3, 8, 3),
(3, 3, 9, 2),
(3, 4, 1, 2),
(3, 4, 2, 2),
(3, 4, 3, 3),
(3, 4, 4, 0),
(3, 4, 5, 1),
(3, 4, 6, 2),
(3, 4, 7, 3),
(3, 4, 8, 2),
(3, 4, 9, 0),
(3, 5, 1, 1),
(3, 5, 2, 0),
(3, 5, 3, 2),
(3, 5, 4, 1),
(3, 5, 5, 0),
(3, 5, 6, 2),
(3, 5, 7, 3),
(3, 5, 8, 2),
(3, 5, 9, 3),
(3, 6, 1, 0),
(3, 6, 2, 2),
(3, 6, 3, 3),
(3, 6, 4, 0),
(3, 6, 5, 0),
(3, 6, 6, 3),
(3, 6, 7, 1),
(3, 6, 8, 0),
(3, 6, 9, 2),
(3, 7, 1, 2),
(3, 7, 2, 0),
(3, 7, 3, 2),
(3, 7, 4, 1),
(3, 7, 5, 1),
(3, 7, 6, 2),
(3, 7, 7, 0),
(3, 7, 8, 0),
(3, 7, 9, 0),
(3, 8, 1, 2),
(3, 8, 2, 1),
(3, 8, 3, 0),
(3, 8, 4, 2),
(3, 8, 5, 1),
(3, 8, 6, 0),
(3, 8, 7, 1),
(3, 8, 8, 0),
(3, 8, 9, 1),
(3, 9, 1, 3),
(3, 9, 2, 1),
(3, 9, 3, 2),
(3, 9, 4, 0),
(3, 9, 5, 2),
(3, 9, 6, 2),
(3, 9, 7, 0),
(3, 9, 8, 0),
(3, 9, 9, 2),
(4, 1, 1, 2),
(4, 1, 2, 1),
(4, 1, 3, 0),
(4, 1, 4, 2),
(4, 1, 5, 1),
(4, 1, 6, 3),
(4, 1, 7, 0),
(4, 2, 1, 2),
(4, 2, 2, 3),
(4, 2, 3, 3),
(4, 2, 4, 2),
(4, 2, 5, 0),
(4, 2, 6, 1),
(4, 2, 7, 1),
(4, 3, 1, 0),
(4, 3, 2, 3),
(4, 3, 3, 1),
(4, 3, 4, 2),
(4, 3, 5, 1),
(4, 3, 6, 0),
(4, 3, 7, 3),
(4, 4, 1, 2),
(4, 4, 2, 1),
(4, 4, 3, 1),
(4, 4, 4, 2),
(4, 4, 5, 0),
(4, 4, 6, 2),
(4, 4, 7, 3),
(4, 5, 1, 2),
(4, 5, 2, 0),
(4, 5, 3, 3),
(4, 5, 4, 1),
(4, 5, 5, 3),
(4, 5, 6, 1),
(4, 5, 7, 3);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `eloadasok`
--
ALTER TABLE `eloadasok`
  ADD PRIMARY KEY (`eloadasid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `eloadasok`
--
ALTER TABLE `eloadasok`
  MODIFY `eloadasid` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
