-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.37-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             10.1.0.5464
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

-- Data exporting was unselected.
-- Dumping structure for table rumah_sakit.pasien
CREATE TABLE IF NOT EXISTS `pasien` (
  `ID` varchar(12) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jenis_kelamin` char(1) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `umur` int(3) NOT NULL,
  `berat_badan` int(3) NOT NULL,
  `tinggi_badan` int(3) NOT NULL,
  `golongan_darah` varchar(2) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table rumah_sakit.penyakit
CREATE TABLE IF NOT EXISTS `penyakit` (
  `kode_penyakit` varchar(20) NOT NULL,
  `nama_penyakit` varchar(20) NOT NULL,
  `golongan` int(1) NOT NULL,
  PRIMARY KEY (`kode_penyakit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
-- Dumping structure for table rumah_sakit.transaksi
CREATE TABLE IF NOT EXISTS `transaksi` (
  `no_transaksi` varchar(10) NOT NULL,
  `id_pasien` varchar(12) NOT NULL,
  `id_dokter` varchar(12) NOT NULL,
  `kode_penyakit` varchar(20) NOT NULL,
  `biaya_perawatan` int(12) NOT NULL,
  PRIMARY KEY (`no_transaksi`),
  KEY `FK_transaksi_dokter` (`id_dokter`),
  KEY `FK_transaksi_pasien` (`id_pasien`),
  KEY `FK_transaksi_penyakit` (`kode_penyakit`),
  CONSTRAINT `FK_transaksi_dokter` FOREIGN KEY (`id_dokter`) REFERENCES `dokter` (`NIP`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_transaksi_pasien` FOREIGN KEY (`id_pasien`) REFERENCES `pasien` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_transaksi_penyakit` FOREIGN KEY (`kode_penyakit`) REFERENCES `penyakit` (`kode_penyakit`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
