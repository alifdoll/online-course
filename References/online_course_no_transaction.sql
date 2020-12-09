-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2020 at 11:00 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `online_course`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `id` char(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `description` varchar(500) NOT NULL,
  `language` varchar(45) NOT NULL,
  `harga` double NOT NULL,
  `release_date` datetime NOT NULL,
  `id_topic` char(11) NOT NULL,
  `id_instructor` char(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`id`, `nama`, `description`, `language`, `harga`, `release_date`, `id_topic`, `id_instructor`) VALUES
('01001', 'Web Development For Beginner', 'This is a course for people that are interested in web development', 'English', 25000, '2019-09-18 13:18:05', '01', '01'),
('02001', 'Calculus 1', 'A course for someone that wants to strengthen their calculus basics', 'English', 15000, '2020-07-14 11:10:06', '02', '02'),
('02002', 'Calculus 2', 'The Continuation of Calculus 1 course', 'English', 25000, '2020-10-02 12:11:09', '02', '02'),
('03001', 'Bahasa Spanyol untuk Pemula', 'Ini adalah course bahasa spanyol untuk pemula.', 'Indonesia', 30000, '2020-08-04 09:10:10', '03', '03');

-- --------------------------------------------------------

--
-- Table structure for table `enroll`
--

CREATE TABLE `enroll` (
  `id_student` int(11) NOT NULL,
  `id_course` char(11) NOT NULL,
  `start_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `instructor`
--

CREATE TABLE `instructor` (
  `id` char(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `bio` varchar(500) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `instructor`
--

INSERT INTO `instructor` (`id`, `nama`, `bio`, `username`, `password`) VALUES
('01', 'Ankit Mistry', 'I am Ankit Mistry,i teach programming', 'ankit123', 'ankit321'),
('02', 'Gane Bewell', 'Hi, Iam Gane Bewell, i teach Mathematics', 'gaban', 'buymoregames'),
('03', 'Ahmed Fazi', 'Hai semuanya, saya adalah guru bahasa inggris dan spanyol', 'ahmedcool', 'ahmed456');

-- --------------------------------------------------------

--
-- Table structure for table `nota_jual`
--

CREATE TABLE `nota_jual` (
  `no_nota` char(20) NOT NULL,
  `tanggal` datetime NOT NULL,
  `student_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `nota_jual_detil`
--

CREATE TABLE `nota_jual_detil` (
  `no_nota` char(20) NOT NULL,
  `id_course` char(11) NOT NULL,
  `harga` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `nama`, `username`, `password`) VALUES
(1, 'Muhammad Alifian Fajar Pratama', 'alifdoll', 'alif123321'),
(2, 'Armando Diaz', 'zaidodnam', '656zaid666'),
(3, 'Azriel Rizky Wibisono', 'jisatsu', '09302020');

-- --------------------------------------------------------

--
-- Table structure for table `topic`
--

CREATE TABLE `topic` (
  `id` char(11) NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `topic`
--

INSERT INTO `topic` (`id`, `nama`) VALUES
('01', 'Pemrograman'),
('02', 'Mathematics'),
('03', 'Bahasa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_course_topic1_idx` (`id_topic`),
  ADD KEY `fk_course_instructor1_idx` (`id_instructor`);

--
-- Indexes for table `enroll`
--
ALTER TABLE `enroll`
  ADD PRIMARY KEY (`id_student`,`id_course`),
  ADD KEY `fk_course_has_student_student1_idx` (`id_student`),
  ADD KEY `fk_course_has_student_course1_idx` (`id_course`);

--
-- Indexes for table `instructor`
--
ALTER TABLE `instructor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `nota_jual`
--
ALTER TABLE `nota_jual`
  ADD PRIMARY KEY (`no_nota`),
  ADD KEY `fk_nota_jual_student1_idx` (`student_id`);

--
-- Indexes for table `nota_jual_detil`
--
ALTER TABLE `nota_jual_detil`
  ADD PRIMARY KEY (`no_nota`,`id_course`),
  ADD KEY `fk_course_has_nota_jual_nota_jual1_idx` (`no_nota`),
  ADD KEY `fk_course_has_nota_jual_course1_idx` (`id_course`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `topic`
--
ALTER TABLE `topic`
  ADD PRIMARY KEY (`id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `course`
--
ALTER TABLE `course`
  ADD CONSTRAINT `fk_course_instructor1` FOREIGN KEY (`id_instructor`) REFERENCES `instructor` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_course_topic1` FOREIGN KEY (`id_topic`) REFERENCES `topic` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `enroll`
--
ALTER TABLE `enroll`
  ADD CONSTRAINT `fk_course_has_student_course1` FOREIGN KEY (`id_course`) REFERENCES `course` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_course_has_student_student1` FOREIGN KEY (`id_student`) REFERENCES `student` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `nota_jual`
--
ALTER TABLE `nota_jual`
  ADD CONSTRAINT `fk_nota_jual_student1` FOREIGN KEY (`student_id`) REFERENCES `student` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `nota_jual_detil`
--
ALTER TABLE `nota_jual_detil`
  ADD CONSTRAINT `fk_course` FOREIGN KEY (`id_course`) REFERENCES `course` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_no_nota` FOREIGN KEY (`no_nota`) REFERENCES `nota_jual` (`no_nota`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
