-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 01, 2020 at 07:47 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `online_course_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `id` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(500) NOT NULL,
  `language` varchar(45) NOT NULL,
  `release_date` date NOT NULL,
  `id_topic` int(11) NOT NULL,
  `id_instructor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`id`, `name`, `description`, `language`, `release_date`, `id_topic`, `id_instructor`) VALUES
(1, 'Web Development For Beginner', 'This is a course for people that are interested in web development', 'English', '2020-08-12', 1, 1),
(2, 'Calculus 1', 'A course for someone that wants to strengthen their basics in calculus', 'English', '2019-02-06', 2, 2),
(3, 'Bahasa Inggris Komplit', 'Course bahasa inggris lengkap untuk pemula dan yang ingin lulus TOEFL dan IELTS.', 'Indonesia', '2020-03-24', 3, 3),
(4, 'Bahasa Spanyol untuk Pemula', 'Ini adalah course bahasa spanyol untuk pemula.', 'Indonesia', '2020-06-15', 3, 3);

-- --------------------------------------------------------

--
-- Table structure for table `enroll`
--

CREATE TABLE `enroll` (
  `id_course` int(11) NOT NULL,
  `id_student` int(11) NOT NULL,
  `start_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `enroll`
--

INSERT INTO `enroll` (`id_course`, `id_student`, `start_date`) VALUES
(1, 1, '2020-08-23'),
(2, 2, '2020-06-08'),
(4, 2, '2020-07-07');

-- --------------------------------------------------------

--
-- Table structure for table `instructor`
--

CREATE TABLE `instructor` (
  `id` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `bio` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `instructor`
--

INSERT INTO `instructor` (`id`, `username`, `password`, `nama`, `bio`) VALUES
(1, 'ankit', 'ankit', 'Ankit Mistry', 'I am Ankit Mistry,i teach programming'),
(2, 'gaban', 'buymoregames', 'Gane Bewell', 'Hi, Iam Gane Bewell, i teach Mathematics'),
(3, 'ahmedcool', 'ahmed456', 'Ahmed Fazi', 'Hai semuanya, saya adalah guru bahasa inggris dan spanyol');

-- --------------------------------------------------------

--
-- Table structure for table `nota_jual`
--

CREATE TABLE `nota_jual` (
  `no_nota` char(11) NOT NULL,
  `tanggal` date NOT NULL,
  `id_student` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `nota_jual`
--

INSERT INTO `nota_jual` (`no_nota`, `tanggal`, `id_student`) VALUES
('20200608001', '2020-06-08', 2),
('20200707002', '2020-07-07', 2),
('20200823001', '2020-09-23', 1);

-- --------------------------------------------------------

--
-- Table structure for table `nota_jual_detil`
--

CREATE TABLE `nota_jual_detil` (
  `no_nota` char(11) NOT NULL,
  `id_course` int(11) NOT NULL,
  `harga` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `nota_jual_detil`
--

INSERT INTO `nota_jual_detil` (`no_nota`, `id_course`, `harga`) VALUES
('20200608001', 2, 15000),
('20200707002', 4, 30000),
('20200823001', 1, 25000);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `username`, `password`, `name`) VALUES
(1, 'alifdoll', 'alif123321', 'Muhammad Alifian Fajar Pratama'),
(2, 'zaid', 'zaidodnam', 'Armando Diaz'),
(3, 'jisatsu', '09302020', 'Azriel Rizky Wibisono');

-- --------------------------------------------------------

--
-- Table structure for table `topic`
--

CREATE TABLE `topic` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `topic`
--

INSERT INTO `topic` (`id`, `nama`) VALUES
(1, 'Programming'),
(2, 'Mathematics'),
(3, 'Language');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_course_topic_idx` (`id_topic`),
  ADD KEY `fk_course_instructor1_idx` (`id_instructor`);

--
-- Indexes for table `enroll`
--
ALTER TABLE `enroll`
  ADD PRIMARY KEY (`id_course`,`id_student`),
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
  ADD KEY `fk_nota_jual_student1_idx` (`id_student`);

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
  ADD CONSTRAINT `fk_course_topic` FOREIGN KEY (`id_topic`) REFERENCES `topic` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

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
  ADD CONSTRAINT `fk_nota_jual_student1` FOREIGN KEY (`id_student`) REFERENCES `student` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `nota_jual_detil`
--
ALTER TABLE `nota_jual_detil`
  ADD CONSTRAINT `fk_course_has_nota_jual_course1` FOREIGN KEY (`id_course`) REFERENCES `course` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_course_has_nota_jual_nota_jual1` FOREIGN KEY (`no_nota`) REFERENCES `nota_jual` (`no_nota`) ON DELETE NO ACTION ON UPDATE NO ACTION;
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
