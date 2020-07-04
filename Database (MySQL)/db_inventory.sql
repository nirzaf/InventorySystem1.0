-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 04, 2020 at 02:52 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE `tblautonumber` (
  `ID` int(11) NOT NULL,
  `STRT` varchar(30) NOT NULL,
  `END` varchar(30) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE `tblitems` (
  `ITEMID` varchar(30) NOT NULL,
  `NAME` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(90) NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `PRICE` double NOT NULL,
  `QTY` int(11) NOT NULL,
  `UNIT` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblperson`
--

CREATE TABLE `tblperson` (
  `ID` int(11) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `ID` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `PARA` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_in_out`
--

CREATE TABLE `tblstock_in_out` (
  `STOCKOUTID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL,
  `REMARKS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_return`
--

CREATE TABLE `tblstock_return` (
  `STOCKRETURNID` int(11) NOT NULL,
  `STOCKRETURNNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `RETURNDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `OWNER_CUS_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblsuplier`
--

CREATE TABLE `tblsuplier` (
  `ID` int(11) NOT NULL,
  `SUPLIERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction`
--

CREATE TABLE `tbltransaction` (
  `STOCKINID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) DEFAULT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblvendor`
--

CREATE TABLE `tblvendor` (
  `VENDORID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `name` varchar(90) DEFAULT NULL,
  `user_name` varchar(90) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `name`, `user_name`, `pass`, `type`) VALUES
(1, 'abcd', 'user', '12dea96fec20593566ab75692c9949596833adc9', 'Staff'),
(3, 'Fazzy', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblitems`
--
ALTER TABLE `tblitems`
  ADD PRIMARY KEY (`ITEMID`);

--
-- Indexes for table `tblperson`
--
ALTER TABLE `tblperson`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CUSID` (`SUPLIERCUSTOMERID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  ADD PRIMARY KEY (`STOCKOUTID`);

--
-- Indexes for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  ADD PRIMARY KEY (`STOCKRETURNID`);

--
-- Indexes for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `SUPID` (`SUPLIERID`);

--
-- Indexes for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  ADD PRIMARY KEY (`STOCKINID`);

--
-- Indexes for table `tblvendor`
--
ALTER TABLE `tblvendor`
  ADD PRIMARY KEY (`VENDORID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tblperson`
--
ALTER TABLE `tblperson`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  MODIFY `STOCKOUTID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- AUTO_INCREMENT for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  MODIFY `STOCKRETURNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  MODIFY `STOCKINID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tblvendor`
--
ALTER TABLE `tblvendor`
  MODIFY `VENDORID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
