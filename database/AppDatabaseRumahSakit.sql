-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.6-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for rumah_sakit
CREATE DATABASE IF NOT EXISTS `rumah_sakit` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `rumah_sakit`;

-- Dumping structure for table rumah_sakit.dokter
CREATE TABLE IF NOT EXISTS `dokter` (
  `NIP` varchar(12) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `jenis_kelamin` varchar(1) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `no_telp` varchar(20) DEFAULT NULL,
  `gaji_pokok` int(11) DEFAULT NULL,
  PRIMARY KEY (`NIP`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table rumah_sakit.dokter: ~5 rows (approximately)
/*!40000 ALTER TABLE `dokter` DISABLE KEYS */;
INSERT INTO `dokter` (`NIP`, `nama`, `jenis_kelamin`, `alamat`, `no_telp`, `gaji_pokok`) VALUES
	('001', 'Aldy', 'L', 'Jalan Buntu 1', '081333533325', 1500000),
	('002', 'Adit', 'L', 'Jalan Buntu 2', '082122299910', 1500000),
	('003', 'Haechal', 'L', 'Jalan Buntu 3', '085929099952', 1250000),
	('004', 'Dika', 'L', 'Jalan Buntu 4', '085239393930', 1200000),
	('005', 'Bayu', 'L', 'Jl Anu', '0211111111', 1000000);
/*!40000 ALTER TABLE `dokter` ENABLE KEYS */;

-- Dumping structure for table rumah_sakit.pasien
CREATE TABLE IF NOT EXISTS `pasien` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `nama_pasien` varchar(50) NOT NULL,
  `jenis_kelamin` char(1) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `umur` int(3) NOT NULL,
  `berat_badan` int(3) NOT NULL,
  `tinggi_badan` int(3) NOT NULL,
  `golongan_darah` varchar(2) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Dumping data for table rumah_sakit.pasien: ~4 rows (approximately)
/*!40000 ALTER TABLE `pasien` DISABLE KEYS */;
INSERT INTO `pasien` (`ID`, `nama_pasien`, `jenis_kelamin`, `alamat`, `no_telp`, `umur`, `berat_badan`, `tinggi_badan`, `golongan_darah`) VALUES
	(1, 'Bagas', 'L', 'Jalan Mundur 1', '0341411002', 12, 35, 130, 'A'),
	(2, 'Vika', 'P', 'Jalan Maju 2', '0341415378', 16, 55, 150, 'O'),
	(3, 'Putra', 'L', 'Jalan Terus 3', '081592098233', 25, 78, 175, 'AB'),
	(4, 'Putri', 'P', 'Jalan Dulu Aja 4', '082133099872', 30, 67, 170, 'B'),
	(5, 'Adi', 'L', 'Jl 1', '081188899', 33, 60, 160, 'O');
/*!40000 ALTER TABLE `pasien` ENABLE KEYS */;

-- Dumping structure for table rumah_sakit.penyakit
CREATE TABLE IF NOT EXISTS `penyakit` (
  `kode_penyakit` varchar(50) NOT NULL DEFAULT '0',
  `nama_penyakit` varchar(20) NOT NULL,
  `golongan` varchar(5) NOT NULL DEFAULT '',
  PRIMARY KEY (`kode_penyakit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table rumah_sakit.penyakit: ~8 rows (approximately)
/*!40000 ALTER TABLE `penyakit` DISABLE KEYS */;
INSERT INTO `penyakit` (`kode_penyakit`, `nama_penyakit`, `golongan`) VALUES
	('1', 'Demam', '1'),
	('2', 'Batuk', '1'),
	('3', 'Diare', '2'),
	('4', 'DBD', '2'),
	('5', 'Typhus', '2'),
	('6', 'Stroke', '3'),
	('7', 'Infeksi dalam', '3'),
	('8', 'Ambeien', '1');
/*!40000 ALTER TABLE `penyakit` ENABLE KEYS */;

-- Dumping structure for table rumah_sakit.transaksi
CREATE TABLE IF NOT EXISTS `transaksi` (
  `no_transaksi` int(11) NOT NULL AUTO_INCREMENT,
  `id_pasien` int(11) NOT NULL DEFAULT 0,
  `nip_dokter` varchar(12) NOT NULL,
  `kode_penyakit` varchar(20) NOT NULL,
  `biaya_perawatan` int(12) NOT NULL,
  PRIMARY KEY (`no_transaksi`),
  KEY `FK_transaksi_dokter` (`nip_dokter`),
  KEY `FK_transaksi_pasien` (`id_pasien`),
  KEY `FK_transaksi_penyakit` (`kode_penyakit`),
  CONSTRAINT `FK_transaksi_dokter` FOREIGN KEY (`nip_dokter`) REFERENCES `dokter` (`NIP`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_transaksi_pasien` FOREIGN KEY (`id_pasien`) REFERENCES `pasien` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_transaksi_penyakit` FOREIGN KEY (`kode_penyakit`) REFERENCES `penyakit` (`kode_penyakit`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Dumping data for table rumah_sakit.transaksi: ~6 rows (approximately)
/*!40000 ALTER TABLE `transaksi` DISABLE KEYS */;
INSERT INTO `transaksi` (`no_transaksi`, `id_pasien`, `nip_dokter`, `kode_penyakit`, `biaya_perawatan`) VALUES
	(1, 1, '001', '2', 50000),
	(2, 3, '004', '6', 200000),
	(3, 4, '002', '4', 160000),
	(4, 4, '002', '3', 250000),
	(5, 2, '004', '5', 100000);
/*!40000 ALTER TABLE `transaksi` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
