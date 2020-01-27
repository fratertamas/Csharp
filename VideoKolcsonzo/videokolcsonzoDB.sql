-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Dec 10. 12:33
-- Kiszolgáló verziója: 10.1.38-MariaDB
-- PHP verzió: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `videokolcsonzo`
--
CREATE DATABASE IF NOT EXISTS `videokolcsonzo` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `videokolcsonzo`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `film`
--

CREATE TABLE `film` (
  `Film_Id` int(11) NOT NULL,
  `Cim` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Adathordozo` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `film`
--

INSERT INTO `film` (`Film_Id`, `Cim`, `Adathordozo`) VALUES
(1, 'Star Wars1', 'DVD'),
(2, 'Star Wars2', 'VHS'),
(3, 'Star Wars3', 'Blue-Ray'),
(4, 'Terminátor 1', 'VHS'),
(5, 'Avatar', 'Blue-Ray'),
(6, 'Joker', 'Blue-Ray'),
(7, 'Bosszúállók: Végjáték', 'Blue-Ray'),
(8, 'Toy Story 4', 'DVD'),
(9, 'Szörny Rt.', 'VHS'),
(10, 'Szörnyecskék 1.', 'VHS'),
(11, 'Terminátor 2.', 'DVD');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kolcsonzes`
--

CREATE TABLE `kolcsonzes` (
  `Kolcsonzes_Id` int(11) NOT NULL,
  `Ugyfel_Id` int(11) NOT NULL,
  `Film_Id` int(11) NOT NULL,
  `Ar` int(11) DEFAULT NULL,
  `Kolcsonzes_nap` int(11) DEFAULT NULL,
  `Kolcsonzes_datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kolcsonzes`
--

INSERT INTO `kolcsonzes` (`Kolcsonzes_Id`, `Ugyfel_Id`, `Film_Id`, `Ar`, `Kolcsonzes_nap`, `Kolcsonzes_datum`) VALUES
(1, 1, 1, 100, 10, '2018-05-05'),
(2, 2, 2, 200, 5, '2018-06-06'),
(3, 3, 3, 300, 14, '2018-04-04'),
(6, 7, 1, 500, 11, '2019-12-09'),
(7, 9, 10, 120, 3, '2019-12-25'),
(8, 12, 7, 1500, 30, '2020-01-03'),
(9, 10, 6, 250, 4, '2019-12-10');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ugyfel`
--

CREATE TABLE `ugyfel` (
  `Ugyfel_Id` int(11) NOT NULL,
  `Nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Ir_szam` int(11) DEFAULT NULL,
  `Varos` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `Utca` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `Hazszam` int(11) DEFAULT NULL,
  `Tel_sz` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ugyfel`
--

INSERT INTO `ugyfel` (`Ugyfel_Id`, `Nev`, `Ir_szam`, `Varos`, `Utca`, `Hazszam`, `Tel_sz`) VALUES
(1, 'Tóth Péter', 1111, 'Budapest', 'Széles utca', 1, '06701234567'),
(2, 'Varga Béla', 2222, 'Győr', 'Szűk utca', 2, '06301234567'),
(3, 'Molnár Anna', 3333, 'Eger', 'Poros utca', 3, '06201234567'),
(4, 'Teszt Elek', 1221, 'Budapest', 'Anna', 10, '0660555666'),
(5, 'Péter Áron', 4400, 'Nyíregyháza', 'Állomás út', 1, '06302226666'),
(6, 'Próba Béla', 1223, 'Budapest', 'Tuzliliom', 12, '06201115555'),
(7, 'Gipsz Jakab', 4400, 'Nyíregyháza', 'Nagyvárad utca', 8, '05101112222'),
(8, 'Kovács Ákos', 1225, 'Budapest', 'Tenkes utca', 4, '06508889999'),
(9, 'Komuves Kelemen', 1225, 'Budapest', 'Bartók Béla út', 5, '06101112222'),
(10, 'Dobó István', 3300, 'Eger', 'Vár', 1, '06202223333'),
(11, 'Papp Lóránt', 1223, 'Budapest', 'Park utca', 1, '06303334444'),
(12, 'Lakatos Arnold', 1238, 'Budapest', 'Rézönto utca', 33, '06404445555');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`Film_Id`);

--
-- A tábla indexei `kolcsonzes`
--
ALTER TABLE `kolcsonzes`
  ADD PRIMARY KEY (`Kolcsonzes_Id`),
  ADD KEY `FK_Kolcsonzes_Ugyfel` (`Ugyfel_Id`),
  ADD KEY `FK_Kolcsonzes_Film` (`Film_Id`);

--
-- A tábla indexei `ugyfel`
--
ALTER TABLE `ugyfel`
  ADD PRIMARY KEY (`Ugyfel_Id`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `kolcsonzes`
--
ALTER TABLE `kolcsonzes`
  ADD CONSTRAINT `FK_Kolcsonzes_Film` FOREIGN KEY (`Film_Id`) REFERENCES `film` (`Film_Id`),
  ADD CONSTRAINT `FK_Kolcsonzes_Ugyfel` FOREIGN KEY (`Ugyfel_Id`) REFERENCES `ugyfel` (`Ugyfel_Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
