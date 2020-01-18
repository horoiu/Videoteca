-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 18, 2020 at 11:21 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbvideoteca`
--

-- --------------------------------------------------------

--
-- Table structure for table `clienti`
--

CREATE TABLE `clienti` (
  `idc` int(11) NOT NULL,
  `numepre` varchar(50) NOT NULL,
  `CNP` int(11) NOT NULL,
  `adresa` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clienti`
--

INSERT INTO `clienti` (`idc`, `numepre`, `CNP`, `adresa`) VALUES
(1, 'Radu Hartagan', 11984643, 'Targu Mures - Sanpaul'),
(2, 'Sorin Cristea', 555872387, 'Ilfov - Bucuresti');

-- --------------------------------------------------------

--
-- Table structure for table `domenii`
--

CREATE TABLE `domenii` (
  `idd` int(11) NOT NULL,
  `denumire` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `domenii`
--

INSERT INTO `domenii` (`idd`, `denumire`) VALUES
(1, 'Actiune'),
(2, 'Groaza'),
(5, 'Dragoste'),
(6, 'Animatie'),
(7, 'Comedie');

-- --------------------------------------------------------

--
-- Table structure for table `filme`
--

CREATE TABLE `filme` (
  `idf` int(11) NOT NULL,
  `denumire` varchar(50) NOT NULL,
  `anul` int(11) DEFAULT NULL,
  `imagine` varchar(30) DEFAULT NULL,
  `nrtotal` int(11) DEFAULT NULL,
  `nrdisponibile` int(11) DEFAULT NULL,
  `iddomeniu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `filme`
--

INSERT INTO `filme` (`idf`, `denumire`, `anul`, `imagine`, `nrtotal`, `nrdisponibile`, `iddomeniu`) VALUES
(1, 'The Matrix', 2000, 'The_Matrix.jpg', NULL, NULL, 1),
(2, 'Hobbit', 2009, 'Hobbit.jpg', NULL, NULL, 2),
(3, 'Titanic', 1997, 'Titanic.jpg', NULL, NULL, 5),
(4, 'Tom & Jerry', 1993, 'Tom_Jerry.jpg', NULL, NULL, 6),
(5, 'Mr. Bean', 2005, 'mr-bean.jpg', NULL, NULL, 7),
(6, 'Tantalaul si Gogomanul', 2006, 'tantalaul-si-gogomanul.jpg', NULL, NULL, 7),
(7, 'Letters to Juliet', 1995, 'Letters_to_Juliet.jpg', NULL, NULL, 5),
(8, 'Moana', 2014, 'Moana.gif', NULL, NULL, 6),
(9, 'Mary Poppins', 2019, 'Mary-Poppins.jpg', NULL, NULL, 1),
(10, 'Spider Man', 2009, 'spider-man.jpg', NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Table structure for table `imprumuturi`
--

CREATE TABLE `imprumuturi` (
  `idi` int(11) NOT NULL,
  `idfilm` int(11) NOT NULL,
  `idclient` int(11) NOT NULL,
  `data_inchirierii` date NOT NULL,
  `data_restituirii` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `roluri`
--

CREATE TABLE `roluri` (
  `idr` int(11) NOT NULL,
  `denumire_rol` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `roluri`
--

INSERT INTO `roluri` (`idr`, `denumire_rol`) VALUES
(1, 'admin'),
(2, 'angajat');

-- --------------------------------------------------------

--
-- Table structure for table `utilizatori`
--

CREATE TABLE `utilizatori` (
  `idu` int(11) NOT NULL,
  `nume_prenume` varchar(50) NOT NULL,
  `user` varchar(50) NOT NULL,
  `parola` varchar(50) NOT NULL,
  `idrol` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `utilizatori`
--

INSERT INTO `utilizatori` (`idu`, `nume_prenume`, `user`, `parola`, `idrol`) VALUES
(1, 'Marian Horoiu', 'Admin', 'admin', 1),
(2, 'Gheorghe Muresanu', 'Angajat', 'angajat', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clienti`
--
ALTER TABLE `clienti`
  ADD PRIMARY KEY (`idc`);

--
-- Indexes for table `domenii`
--
ALTER TABLE `domenii`
  ADD PRIMARY KEY (`idd`);

--
-- Indexes for table `filme`
--
ALTER TABLE `filme`
  ADD PRIMARY KEY (`idf`),
  ADD KEY `iddomeniu` (`iddomeniu`);

--
-- Indexes for table `imprumuturi`
--
ALTER TABLE `imprumuturi`
  ADD PRIMARY KEY (`idi`),
  ADD KEY `idfilm` (`idfilm`),
  ADD KEY `idclient` (`idclient`);

--
-- Indexes for table `roluri`
--
ALTER TABLE `roluri`
  ADD PRIMARY KEY (`idr`);

--
-- Indexes for table `utilizatori`
--
ALTER TABLE `utilizatori`
  ADD PRIMARY KEY (`idu`),
  ADD KEY `idrol` (`idrol`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clienti`
--
ALTER TABLE `clienti`
  MODIFY `idc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `domenii`
--
ALTER TABLE `domenii`
  MODIFY `idd` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `filme`
--
ALTER TABLE `filme`
  MODIFY `idf` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `imprumuturi`
--
ALTER TABLE `imprumuturi`
  MODIFY `idi` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `roluri`
--
ALTER TABLE `roluri`
  MODIFY `idr` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `utilizatori`
--
ALTER TABLE `utilizatori`
  MODIFY `idu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `filme`
--
ALTER TABLE `filme`
  ADD CONSTRAINT `filme_ibfk_1` FOREIGN KEY (`iddomeniu`) REFERENCES `domenii` (`idd`);

--
-- Constraints for table `imprumuturi`
--
ALTER TABLE `imprumuturi`
  ADD CONSTRAINT `imprumuturi_ibfk_1` FOREIGN KEY (`idfilm`) REFERENCES `filme` (`idf`),
  ADD CONSTRAINT `imprumuturi_ibfk_2` FOREIGN KEY (`idclient`) REFERENCES `clienti` (`idc`);

--
-- Constraints for table `utilizatori`
--
ALTER TABLE `utilizatori`
  ADD CONSTRAINT `utilizatori_ibfk_1` FOREIGN KEY (`idrol`) REFERENCES `roluri` (`idr`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
