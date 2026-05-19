-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2026 at 05:44 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `estrante_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllogincredentials`
--

CREATE TABLE `tbllogincredentials` (
  `loginID` int(11) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `userID` int(11) NOT NULL,
  `is_active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbllogincredentials`
--

INSERT INTO `tbllogincredentials` (`loginID`, `user_username`, `user_password`, `userID`, `is_active`) VALUES
(9, 'Christoffe', 'hotdog', 7, 1),
(10, 'Christoffe', 'hotdog', 8, 1),
(11, '', '', 9, 1),
(12, 'Pacman', 'BAHALANA', 10, 1),
(13, 'Joseph', 'HAYS', 11, 1),
(14, '', 'HAYS', 12, 1),
(15, 'Jepuy', 'jbcutie', 13, 1),
(16, '', '', 14, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbluserinformation`
--

CREATE TABLE `tbluserinformation` (
  `userID` int(11) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `emailAddress` varchar(150) NOT NULL,
  `homeAddress` varchar(200) NOT NULL,
  `birthDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluserinformation`
--

INSERT INTO `tbluserinformation` (`userID`, `firstname`, `middlename`, `lastname`, `emailAddress`, `homeAddress`, `birthDate`) VALUES
(7, 'cj', 'Anonuevo', 'Estrante', 'cj@gmail.com', 'blk 7', '2006-01-02'),
(8, 'cj', 'Anonuevo', 'Estrante', 'cj@gmail.com', 'blk 7', '2006-01-02'),
(9, 'chris', 'anonuevo', 'Estrante', '', '', '2026-05-06'),
(10, 'Chris', 'Anonuevo', 'Estrante', 'cj@gmail.com', 'sitio syete', '2006-01-02'),
(11, 'Joseph', 'Herrera', 'Anonuevo', 'Joseph@gmail.com', 'Kalye Trece', '2004-05-02'),
(12, 'chris', 'anonuevo', 'Estrante', 'Chris@gmail.com', '', '2026-05-06'),
(13, 'Joharie', 'Zosobrado', 'Bayamba', 'jb@gmail.com', 'Cv', '2004-12-01'),
(14, 'Buboy', '', '', '', '', '2026-05-17');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllogincredentials`
--
ALTER TABLE `tbllogincredentials`
  ADD PRIMARY KEY (`loginID`);

--
-- Indexes for table `tbluserinformation`
--
ALTER TABLE `tbluserinformation`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllogincredentials`
--
ALTER TABLE `tbllogincredentials`
  MODIFY `loginID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbluserinformation`
--
ALTER TABLE `tbluserinformation`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
