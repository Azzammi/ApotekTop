-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2017-06-23 09:09:49
-- --------------------------------------
-- Server version 10.1.19-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of tbl_detail_pembelian
-- 

DROP TABLE IF EXISTS `tbl_detail_pembelian`;
CREATE TABLE IF NOT EXISTS `tbl_detail_pembelian` (
  `no` varchar(255) NOT NULL,
  `no_faktur` varchar(50) DEFAULT NULL,
  `kd_supplier` varchar(50) DEFAULT NULL,
  `total` decimal(18,0) DEFAULT NULL,
  `diskon` double DEFAULT NULL,
  `ppn` double DEFAULT NULL,
  `total_harga` decimal(18,0) DEFAULT NULL,
  `bayar` decimal(18,0) DEFAULT NULL,
  `total_sisa` decimal(18,0) DEFAULT NULL,
  `tgl_tempo` date DEFAULT NULL,
  `kasir` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_detail_pembelian
-- 

/*!40000 ALTER TABLE `tbl_detail_pembelian` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_detail_pembelian` ENABLE KEYS */;

-- 
-- Definition of tbl_detail_penjualan
-- 

DROP TABLE IF EXISTS `tbl_detail_penjualan`;
CREATE TABLE IF NOT EXISTS `tbl_detail_penjualan` (
  `no_faktur` varchar(50) NOT NULL,
  `tgl_transaksi` date DEFAULT NULL,
  `total` decimal(18,0) DEFAULT NULL,
  `diskon` double DEFAULT NULL,
  `ppn` double DEFAULT NULL,
  `total_harga` decimal(18,0) DEFAULT NULL,
  `bayar` decimal(18,0) DEFAULT NULL,
  `kembali` decimal(18,0) DEFAULT NULL,
  `total_sisa` decimal(18,0) DEFAULT NULL,
  `tgl_tempo` date DEFAULT NULL,
  PRIMARY KEY (`no_faktur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_detail_penjualan
-- 

/*!40000 ALTER TABLE `tbl_detail_penjualan` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_detail_penjualan` ENABLE KEYS */;

-- 
-- Definition of tbl_kategori
-- 

DROP TABLE IF EXISTS `tbl_kategori`;
CREATE TABLE IF NOT EXISTS `tbl_kategori` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `Kategori` varchar(100) DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_kategori
-- 

/*!40000 ALTER TABLE `tbl_kategori` DISABLE KEYS */;
INSERT INTO `tbl_kategori`(`id`,`Kategori`,`Keterangan`) VALUES
(1,'Obat Keras',NULL),
(2,'Obat Psikotropoka',NULL),
(3,'Obat Warung',NULL);
/*!40000 ALTER TABLE `tbl_kategori` ENABLE KEYS */;

-- 
-- Definition of tbl_konversi
-- 

DROP TABLE IF EXISTS `tbl_konversi`;
CREATE TABLE IF NOT EXISTS `tbl_konversi` (
  `id_item` varchar(50) DEFAULT NULL,
  `id_satuan` varchar(50) DEFAULT NULL,
  `Qty` int(11) DEFAULT NULL,
  `isDefault` bit(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_konversi
-- 

/*!40000 ALTER TABLE `tbl_konversi` DISABLE KEYS */;
INSERT INTO `tbl_konversi`(`id_item`,`id_satuan`,`Qty`,`isDefault`) VALUES
('100001','1',1,0),
('100001','6',1,1),
('100001','1',1,1),
('100001','1',1,0),
('100001','6',1,1),
('100002','1',1,1),
('100002','6',1,1),
('100003','6',1,0),
('100003','6',1,1),
('100004','1',1,0),
('100004','2',1,1),
('100005','1',1,0),
('100005','6',1,1),
('100006','1',1,0),
('100006','6',1,1),
('100007','1',1,0),
('100007','6',1,1),
('100008','2',1,1),
('100009','2',1,1),
('100010','1',1,0),
('100010','6',1,1),
('100011','1',1,0),
('100011','6',1,1),
('100012','1',1,0),
('100012','6',1,1),
('100013','1',1,0),
('100013','6',1,1),
('100014','1',1,0),
('100014','6',1,1),
('100015','2',1,1),
('100016','2',1,1),
('100017','1',1,0),
('100017','6',1,1),
('100018','1',1,0),
('100018','6',1,1),
('100019','1',1,0),
('100019','6',1,1),
('100020','1',1,0),
('100020','6',1,1),
('100021','1',1,0),
('100021','6',1,1),
('100022','2',1,1),
('100023','2',1,1),
('100024','1',1,0),
('100024','6',1,1),
('100025','1',1,0),
('100025','6',1,1),
('100026','1',1,0),
('100026','6',1,1),
('100027','1',1,0),
('100027','6',1,1),
('100028','1',1,0),
('100028','6',1,1),
('100029','1',1,0),
('100029','6',1,1),
('100030','1',1,0),
('100030','6',1,1),
('100031','1',1,0),
('100031','6',1,1),
('100032','1',1,0),
('100032','6',1,1),
('100033','1',1,0),
('100033','6',1,1),
('100034','1',1,0),
('100034','6',1,1),
('100035','1',1,0),
('100035','6',1,1),
('100036','1',1,0),
('100036','6',1,1),
('100037','1',1,0),
('100037','6',1,1),
('100038','1',1,0),
('100038','6',1,1),
('100039','1',1,0),
('100039','6',1,1),
('100040','1',1,0),
('100040','6',1,1),
('100041','1',1,0),
('100041','6',1,1),
('100042','1',1,0),
('100042','6',1,1),
('100043','1',1,0),
('100043','6',1,1),
('100044','1',1,0),
('100044','6',1,1),
('100045','1',1,0),
('100045','6',1,1),
('100046','2',1,1),
('100047','2',1,1),
('100048','1',1,0),
('100048','6',1,1),
('100049','1',1,0),
('100049','6',1,1),
('100050','1',1,0),
('100050','6',1,1),
('100051','2',1,1),
('100052','1',1,0),
('100052','6',1,1),
('100053','1',1,0),
('100053','6',1,1),
('100054','1',1,0),
('100054','6',1,1),
('100055','1',1,0),
('100055','6',1,1),
('100055','1',1,0),
('100055','6',1,1),
('100056','1',1,0),
('100056','6',1,1),
('100057','1',1,0),
('100057','6',1,1),
('100058','1',1,0),
('100058','6',1,1),
('100059','1',1,0),
('100059','6',1,1),
('100060','2',1,1),
('100061','1',1,0),
('100061','6',1,1),
('100062','1',1,0),
('100062','6',1,1),
('100063','1',1,0),
('100063','6',1,1),
('100064','1',1,0),
('100064','6',1,1),
('100065','1',1,0),
('100065','6',1,1),
('100066','1',1,0),
('100066','6',1,1),
('100067','1',1,0),
('100067','6',1,1),
('100068','1',1,0),
('100068','6',1,1),
('100069','1',1,0),
('100069','6',1,1),
('100070','1',1,0),
('100070','6',1,1),
('100071','1',1,0),
('100071','6',1,1),
('100072','1',1,0),
('100072','6',1,1),
('100073','1',1,0),
('100073','6',1,1),
('100074','2',1,1),
('100075','1',1,0),
('100075','6',1,1),
('100076','1',1,0),
('100076','6',1,1),
('100077','1',1,0),
('100077','6',1,1),
('100078','1',1,0),
('100078','6',1,1),
('100079','1',1,0),
('100079','6',1,1),
('100080','1',1,0),
('100080','6',1,1),
('100081','1',1,0),
('100081','6',1,1),
('100082','1',1,0),
('100082','6',1,1),
('100083','1',1,0),
('100083','6',1,1),
('100084','2',1,1),
('100085','1',1,0),
('100085','6',1,1),
('100086','1',1,0),
('100086','6',1,1),
('100087','1',1,0),
('100087','6',1,1),
('100088','1',1,0),
('100088','6',1,1),
('100089','1',1,0),
('100089','6',1,1),
('100090','2',1,1),
('100091','2',1,1),
('100092','2',1,1),
('100093','2',1,1),
('100094','2',1,1),
('100095','1',1,0),
('100095','6',1,1),
('100096','2',1,1),
('100097','2',1,1),
('100098','2',1,1),
('100099','1',1,0),
('100099','6',1,1),
('100100','1',1,0),
('100100','6',1,1);
/*!40000 ALTER TABLE `tbl_konversi` ENABLE KEYS */;

-- 
-- Definition of tbl_obat
-- 

DROP TABLE IF EXISTS `tbl_obat`;
CREATE TABLE IF NOT EXISTS `tbl_obat` (
  `id_obat` varchar(50) NOT NULL,
  `Merek` varchar(100) DEFAULT NULL,
  `nama_obat` varchar(255) DEFAULT NULL,
  `tipe` varchar(100) DEFAULT NULL,
  `kategori` varchar(50) DEFAULT NULL,
  `satuan_stock` varchar(50) DEFAULT NULL,
  `satuan_jual` varchar(50) DEFAULT NULL,
  `harga_pokok` decimal(18,0) DEFAULT NULL,
  `harga_jual` decimal(18,0) DEFAULT NULL,
  `margin_jual` int(11) DEFAULT NULL,
  `status_resep` bit(1) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_obat
-- 

/*!40000 ALTER TABLE `tbl_obat` DISABLE KEYS */;
INSERT INTO `tbl_obat`(`id_obat`,`Merek`,`nama_obat`,`tipe`,`kategori`,`satuan_stock`,`satuan_jual`,`harga_pokok`,`harga_jual`,`margin_jual`,`status_resep`,`keterangan`) VALUES
('100001','','abate','Kaplet','Obat Psikotropoka','Lusin','pcs',750,765,2,1,''),
('100002','','abc menthol b','Bubuk','Obat Keras','Lusin','Lusin',23000,0,1,1,''),
('100003','','acifar cream','Bubuk','Obat Keras','Lusin','pcs',22500,0,1,1,''),
('100004','','acitral','Tablet','Obat Psikotropoka','Lusin','Botol',22500,0,1,1,''),
('100005','','aclonac cr 20','Tablet','Obat Psikotropoka','Lusin','pcs',31000,0,1,1,''),
('100006','','acnes foam wash','Kaplet','Obat Psikotropoka','Lusin','pcs',11000,0,1,1,''),
('100007','','acnes pore strip','Tablet','Obat Psikotropoka','Lusin','pcs',8415,0,1,1,''),
('100008','','acnol','Bubuk','Obat Keras','Botol','Botol',8000,0,1,1,''),
('100009','','actifed plus expect 60 ml hijau','Bubuk','Obat Keras','Botol','Botol',30000,0,1,1,''),
('100010','','acyclovir cream','Kaplet','Obat Psikotropoka','Lusin','pcs',4000,0,1,1,''),
('100011','','acyclovir tab 200','Tablet','Obat Psikotropoka','Lusin','pcs',4000,0,1,1,''),
('100012','','acyclovir tab 400','Kaplet','Obat Psikotropoka','Lusin','pcs',4200,0,1,1,''),
('100013','','adem sari','Bubuk','Obat Warung','Lusin','pcs',1500,0,1,0,''),
('100014','','akurat','Kaplet','Obat Psikotropoka','Lusin','pcs',9000,0,1,1,''),
('100015','','albothyl 10','Syrup','Obat Warung','Botol','Botol',31000,0,1,0,''),
('100016','','alco drops','Syrup','Obat Psikotropoka','Botol','Botol',42000,0,1,1,''),
('100017','','alleron','Kaplet','Obat Warung','Lusin','pcs',1000,0,1,0,''),
('100018','','allopurinol','Kaplet','Obat Psikotropoka','Lusin','pcs',2000,0,1,1,''),
('100019','','allopurinol 300 berno','Tablet','Obat Psikotropoka','Lusin','pcs',3500,0,1,1,''),
('100020','','alofar 100','Kaplet','Obat Psikotropoka','Lusin','pcs',2000,0,1,1,''),
('100021','','alofar 300','Kaplet','Obat Psikotropoka','Lusin','pcs',3700,0,1,1,''),
('100022','','alphamor syr','Syrup','Obat Keras','Botol','Botol',6000,0,1,1,''),
('100023','','alumy syr','Syrup','Obat Keras','Botol','Botol',8000,0,1,1,''),
('100024','','alivita tab','Tablet','Obat Psikotropoka','Lusin','pcs',3500,0,1,1,''),
('100025','','amaryl 1','Tablet','Obat Psikotropoka','Lusin','pcs',27000,0,1,1,''),
('100026','','amaryl 2','Tablet','Obat Psikotropoka','Lusin','pcs',49000,0,1,1,''),
('100027','','ambeven','Kaplet','Obat Psikotropoka','Lusin','pcs',12000,0,1,1,''),
('100028','','ambroxol syr','Kapsul','Obat Keras','Lusin','pcs',4200,0,1,1,''),
('100029','','ambroxol tab','Kapsul','Obat Keras','Lusin','pcs',1500,0,1,1,''),
('100030','','aminophylin','Tablet','Obat Keras','Lusin','pcs',150,0,1,1,''),
('100031','','amlodipin 10 hj','Tablet','Obat Keras','Lusin','pcs',10000,0,1,1,''),
('100032','','amlodipin 10 pharma ','Kaplet','Obat Psikotropoka','Lusin','pcs',7000,0,1,1,''),
('100033','','amlodipin 5 berno','Kaplet','Obat Psikotropoka','Lusin','pcs',5500,0,1,1,''),
('100034','','amlodipin 5 dx','Kaplet','Obat Psikotropoka','Lusin','pcs',4500,0,1,1,''),
('100035','','amlodipin 5 hj','Kaplet','Obat Psikotropoka','Lusin','pcs',5500,0,1,1,''),
('100036','','amlodipin berno 10','Kaplet','Obat Psikotropoka','Lusin','pcs',10000,0,1,1,''),
('100037','','amlodipin promed 10','Kaplet','Obat Psikotropoka','Lusin','pcs',7000,0,1,1,''),
('100038','','amor test strip','Tablet','Obat Keras','Lusin','pcs',10000,0,1,1,''),
('100039','','amoxicillin','Kaplet','Obat Keras','Lusin','pcs',4000,0,1,1,''),
('100040','','amoxicillin hj 500','Kaplet','Obat Keras','Lusin','pcs',4000,0,1,1,''),
('100041','','amoxicillin kf','Kaplet','Obat Keras','Lusin','pcs',4000,0,1,1,''),
('100042','','amoxtera 500','Kapsul','Obat Psikotropoka','Lusin','pcs',4000,0,1,1,''),
('100043','','ampicillin 500','Tablet','Obat Keras','Lusin','pcs',5000,0,1,1,''),
('100044','','anacetine syr','Kaplet','Obat Warung','Lusin','pcs',6000,0,1,0,''),
('100045','','anak sumang ','Tablet','Obat Keras','Lusin','pcs',250,0,1,0,''),
('100046','','anakonidin','Syrup','Obat Warung','Botol','Botol',10000,0,1,0,''),
('100047','','anakonidin 30','Syrup','Obat Keras','Botol','Botol',6000,0,1,0,''),
('100048','','anastan','Kaplet','Obat Keras','Lusin','pcs',2500,0,1,1,''),
('100049','','andalan laktasi','Tablet','Obat Warung','Lusin','pcs',12000,0,1,0,''),
('100050','','andalan tab 28 s','Tablet','Obat Keras','Lusin','pcs',4500,0,1,0,''),
('100051','','anflat syr','Syrup','Obat Psikotropoka','Botol','Botol',13000,0,1,1,''),
('100052','','antalgin','Tablet','Obat Psikotropoka','Lusin','pcs',2000,0,1,1,''),
('100053','','antalgin corsa ','Tablet','Obat Psikotropoka','Lusin','pcs',2000,0,1,1,''),
('100054','','antalgin mef','Tablet','Obat Psikotropoka','Lusin','pcs',2500,0,1,1,''),
('100055','','antangin jr 5s','Kaplet','Obat Warung','Lusin','pcs',11000,0,1,0,''),
('100056','','antangin jrg syr 15 ml sach','Kaplet','Obat Warung','Lusin','pcs',2000,0,1,0,''),
('100057','','antangin jrg tab','Kaplet','Obat Warung','Lusin','pcs',2000,0,1,0,''),
('100058','','antasida doen tab ','Tablet','Obat Keras','Lusin','pcs',1000,0,1,1,''),
('100059','','antimo 50mg tab 10s','Kaplet','Obat Warung','Lusin','pcs',4000,0,1,0,''),
('100060','','apialys drop','Syrup','Obat Keras','Botol','Botol',31000,0,1,1,''),
('100061','','ardium','Tablet','Obat Psikotropoka','Lusin','pcs',50000,0,1,1,''),
('100062','','armsling','Tablet','Obat Psikotropoka','Lusin','pcs',20000,0,1,1,''),
('100063','','asam mefenamat','Kaplet','Obat Psikotropoka','Lusin','pcs',20000,0,1,1,''),
('100064','','asam mefenamat 500 landson','Kaplet','Obat Psikotropoka','Lusin','pcs',2000,0,1,1,''),
('100065','','ascardia 160','Tablet','Obat Keras','Lusin','pcs',13000,0,1,1,''),
('100066','','asepso','Tablet','Obat Keras','Lusin','pcs',5500,0,1,1,''),
('100067','','asmasoho','Tablet','Obat Keras','Lusin','pcs',2500,0,1,1,''),
('100068','','asmasolon','Tablet','Obat Psikotropoka','Lusin','pcs',2000,0,1,1,''),
('100069','','astherin','Kaplet','Obat Psikotropoka','Lusin','pcs',3000,0,1,1,''),
('100070','','atorvastatin','Kaplet','Obat Psikotropoka','Lusin','pcs',50000,0,1,1,''),
('100071','','avail day ','Tablet','Obat Psikotropoka','Lusin','pcs',25500,0,1,1,''),
('100072','','avail pantyliner','Tablet','Obat Psikotropoka','Lusin','pcs',25500,0,1,1,''),
('100073','','bsy dark brown','Tablet','Obat Keras','Lusin','pcs',11000,0,1,0,''),
('100074','','baby cough','Bubuk','Obat Warung','Botol','Botol',3500,0,1,0,''),
('100075','','balm lang 20g','Kaplet','Obat Warung','Lusin','pcs',6500,0,1,0,''),
('100076','','balpirik extra kuat','Tablet','Obat Warung','Lusin','pcs',5500,0,1,0,''),
('100077','','balpirik kayu putih 20g','Kaplet','Obat Warung','Lusin','pcs',5000,0,1,0,''),
('100078','','balsam otot geliga 10g','cream','Obat Warung','Lusin','pcs',4000,0,1,0,''),
('100079','','balsam telon tresno djoyo kecil','cream','Obat Warung','Lusin','pcs',6500,0,1,0,''),
('100080','','batugin 330','Tablet','Obat Psikotropoka','Lusin','pcs',34000,0,1,1,''),
('100081','','baycuten','Kaplet','Obat Psikotropoka','Lusin','pcs',51000,0,1,1,''),
('100082','','becom c','Tablet','Obat Keras','Lusin','pcs',13500,0,1,1,''),
('100083','','becom z','Tablet','Obat Keras','Lusin','pcs',17500,0,1,1,''),
('100084','','becombion drops 15ml','Syrup','Obat Warung','Botol','Botol',25000,0,1,0,''),
('100085','','bedak lulur putih ','Bubuk','Obat Warung','Lusin','pcs',2000,0,1,0,''),
('100086','','benoson 15','Kaplet','Obat Keras','Lusin','pcs',23000,0,1,1,''),
('100087','','benoson 5','Kaplet','Obat Keras','Lusin','pcs',11500,0,1,1,''),
('100088','','benoson n 15','Kaplet','Obat Keras','Lusin','pcs',25000,0,1,1,''),
('100089','','bephanten','Tablet','Obat Psikotropoka','Lusin','pcs',46000,0,1,1,''),
('100090','','berlosid syr','Syrup','Obat Psikotropoka','Botol','Botol',5000,0,1,1,''),
('100091','','betadine 5','cair','Obat Warung','Botol','Botol',3500,0,1,0,''),
('100092','','betadine feminine hygiene 60 ml','cair','Obat Warung','Botol','Botol',20000,0,1,0,''),
('100093','','betadine kumur ','cair','Obat Warung','Botol','Botol',9000,0,1,0,''),
('100094','','betadine sabun 60','cair','Obat Warung','Botol','Botol',20000,0,1,0,''),
('100095','','betadine salep 10','cream','Obat Warung','Lusin','pcs',14000,0,1,0,''),
('100096','','betadine soap 100','cair','Obat Warung','Botol','Botol',27500,0,1,0,''),
('100097','','betadine sol 30 ml','cair','Obat Warung','Botol','Botol',15000,0,1,0,''),
('100098','','betadine sol 60ml','cair','Obat Warung','Botol','Botol',25000,0,1,0,''),
('100099','','betadine vag douche 100','cair','Obat Warung','Lusin','pcs',45000,0,1,0,''),
('100100','','betadine vag douche 100 plus','cream','Obat Warung','Lusin','pcs',47500,0,1,0,'');
/*!40000 ALTER TABLE `tbl_obat` ENABLE KEYS */;

-- 
-- Definition of tbl_obat_keluar
-- 

DROP TABLE IF EXISTS `tbl_obat_keluar`;
CREATE TABLE IF NOT EXISTS `tbl_obat_keluar` (
  `id_keluar` varchar(20) NOT NULL,
  `id_obat` varchar(50) DEFAULT NULL,
  `tgl_expired` date DEFAULT NULL,
  `tgl_transaksi` date DEFAULT NULL,
  `jam_keluar` time DEFAULT NULL,
  `stock_keluar` int(11) DEFAULT NULL,
  `no_faktur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_keluar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_obat_keluar
-- 

/*!40000 ALTER TABLE `tbl_obat_keluar` DISABLE KEYS */;
INSERT INTO `tbl_obat_keluar`(`id_keluar`,`id_obat`,`tgl_expired`,`tgl_transaksi`,`jam_keluar`,`stock_keluar`,`no_faktur`) VALUES
('100001','100003','2017-03-10 00:00:00','2017-02-27 00:00:00','07:28:24',4,'27022017100001');
/*!40000 ALTER TABLE `tbl_obat_keluar` ENABLE KEYS */;

-- 
-- Definition of tbl_obat_masuk
-- 

DROP TABLE IF EXISTS `tbl_obat_masuk`;
CREATE TABLE IF NOT EXISTS `tbl_obat_masuk` (
  `id_masuk` varchar(20) NOT NULL,
  `id_obat` varchar(50) DEFAULT NULL,
  `tgl_expired` date DEFAULT NULL,
  `tgl_transaksi` date DEFAULT NULL,
  `jam_masuk` time DEFAULT NULL,
  `stock_masuk` int(11) DEFAULT NULL,
  `no_faktur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_masuk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_obat_masuk
-- 

/*!40000 ALTER TABLE `tbl_obat_masuk` DISABLE KEYS */;
INSERT INTO `tbl_obat_masuk`(`id_masuk`,`id_obat`,`tgl_expired`,`tgl_transaksi`,`jam_masuk`,`stock_masuk`,`no_faktur`) VALUES
('PO100001','100004','2017-03-08 00:00:00','2017-03-08 00:00:00','09:14:35',16,'123123'),
('PO100002','100004','2017-03-25 00:00:00','2017-03-08 00:00:00','09:18:54',100,'5656'),
('PO100003','100003','2018-03-03 00:00:00','2017-03-12 00:00:00','09:27:09',20,'5757'),
('PO100004','100005','2017-03-08 00:00:00','2017-03-13 00:00:00','09:29:09',112,'9090'),
('PO100005','100001','2017-03-31 00:00:00','2017-03-03 00:00:00','10:00:06',10,'909090'),
('PO100006','100003','2017-03-09 00:00:00','2017-03-09 00:00:00','09:36:50',9,'55555'),
('PO100007','100002','2017-03-09 00:00:00','2017-03-09 00:00:00','10:13:19',7678,'234234'),
('PO100008','100003','2017-03-09 00:00:00','2017-03-09 00:00:00','12:30:30',1230,'555555'),
('PO100009','100003','2017-03-10 00:00:00','2017-03-10 00:00:00','08:32:47',777,'124'),
('PO100010','100003','2017-03-10 00:00:00','2017-03-10 00:00:00','08:35:13',123,'2333'),
('PO100012','100004','2017-03-10 00:00:00','2017-03-10 00:00:00','08:54:57',8,'898989'),
('PO100013','100005','2017-03-10 00:00:00','2017-03-10 00:00:00','10:00:02',1230,'322344'),
('PO100014','100006','2017-03-10 00:00:00','2017-04-01 00:00:00','10:03:58',10,'345345'),
('PO100015','100007','2017-03-10 00:00:00','2017-03-10 00:00:00','10:05:11',32420,'23525'),
('PO100016','100008','2017-03-10 00:00:00','2017-03-10 00:00:00','10:10:58',5,'23525');
/*!40000 ALTER TABLE `tbl_obat_masuk` ENABLE KEYS */;

-- 
-- Definition of tbl_obat_stock
-- 

DROP TABLE IF EXISTS `tbl_obat_stock`;
CREATE TABLE IF NOT EXISTS `tbl_obat_stock` (
  `No` int(50) NOT NULL AUTO_INCREMENT,
  `id_obat` varchar(50) DEFAULT NULL,
  `satuan_utama` varchar(50) DEFAULT NULL,
  `stock_utama` int(11) DEFAULT '0',
  `satuan_turunan` varchar(50) DEFAULT NULL,
  `stock_turunan` int(11) DEFAULT '0',
  `tgl_expired` date DEFAULT NULL,
  PRIMARY KEY (`No`)
) ENGINE=InnoDB AUTO_INCREMENT=107 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_obat_stock
-- 

/*!40000 ALTER TABLE `tbl_obat_stock` DISABLE KEYS */;
INSERT INTO `tbl_obat_stock`(`No`,`id_obat`,`satuan_utama`,`stock_utama`,`satuan_turunan`,`stock_turunan`,`tgl_expired`) VALUES
(9,'100004',NULL,0,'Lusin',8,'2017-03-10 00:00:00'),
(12,'100007','Lusin',0,'pcs',32420,'2017-03-10 00:00:00'),
(13,'100008','Botol',5,'Botol',0,'2017-03-10 00:00:00'),
(14,'100009','Botol',NULL,'Botol',NULL,NULL),
(15,'100010','Lusin',NULL,'pcs',NULL,NULL),
(16,'100011','Lusin',NULL,'pcs',NULL,NULL),
(17,'100012','Lusin',NULL,'pcs',NULL,NULL),
(18,'100013','Lusin',NULL,'pcs',NULL,NULL),
(19,'100014','Lusin',NULL,'pcs',NULL,NULL),
(20,'100015','Botol',NULL,'Botol',NULL,NULL),
(21,'100016','Botol',NULL,'Botol',NULL,NULL),
(22,'100017','Lusin',NULL,'pcs',NULL,NULL),
(23,'100018','Lusin',NULL,'pcs',NULL,NULL),
(24,'100019','Lusin',NULL,'pcs',NULL,NULL),
(25,'100020','Lusin',NULL,'pcs',NULL,NULL),
(26,'100021','Lusin',NULL,'pcs',NULL,NULL),
(27,'100022','Botol',NULL,'Botol',NULL,NULL),
(28,'100023','Botol',NULL,'Botol',NULL,NULL),
(29,'100024','Lusin',NULL,'pcs',NULL,NULL),
(30,'100025','Lusin',NULL,'pcs',NULL,NULL),
(31,'100026','Lusin',NULL,'pcs',NULL,NULL),
(32,'100027','Lusin',NULL,'pcs',NULL,NULL),
(33,'100028','Lusin',NULL,'pcs',NULL,NULL),
(34,'100029','Lusin',NULL,'pcs',NULL,NULL),
(35,'100030','Lusin',NULL,'pcs',NULL,NULL),
(36,'100031','Lusin',NULL,'pcs',NULL,NULL),
(37,'100032','Lusin',NULL,'pcs',NULL,NULL),
(38,'100033','Lusin',NULL,'pcs',NULL,NULL),
(39,'100034','Lusin',NULL,'pcs',NULL,NULL),
(40,'100035','Lusin',NULL,'pcs',NULL,NULL),
(41,'100036','Lusin',NULL,'pcs',NULL,NULL),
(42,'100037','Lusin',NULL,'pcs',NULL,NULL),
(43,'100038','Lusin',NULL,'pcs',NULL,NULL),
(44,'100039','Lusin',NULL,'pcs',NULL,NULL),
(45,'100040','Lusin',NULL,'pcs',NULL,NULL),
(46,'100041','Lusin',NULL,'pcs',NULL,NULL),
(47,'100042','Lusin',NULL,'pcs',NULL,NULL),
(48,'100043','Lusin',NULL,'pcs',NULL,NULL),
(49,'100044','Lusin',NULL,'pcs',NULL,NULL),
(50,'100045','Lusin',NULL,'pcs',NULL,NULL),
(51,'100046','Botol',NULL,'Botol',NULL,NULL),
(52,'100047','Botol',NULL,'Botol',NULL,NULL),
(53,'100048','Lusin',NULL,'pcs',NULL,NULL),
(54,'100049','Lusin',NULL,'pcs',NULL,NULL),
(55,'100050','Lusin',NULL,'pcs',NULL,NULL),
(56,'100051','Botol',NULL,'Botol',NULL,NULL),
(57,'100052','Lusin',NULL,'pcs',NULL,NULL),
(58,'100053','Lusin',NULL,'pcs',NULL,NULL),
(59,'100054','Lusin',NULL,'pcs',NULL,NULL),
(60,'100055','Lusin',NULL,'pcs',NULL,NULL),
(61,'100055','Lusin',NULL,'pcs',NULL,NULL),
(62,'100056','Lusin',NULL,'pcs',NULL,NULL),
(63,'100057','Lusin',NULL,'pcs',NULL,NULL),
(64,'100058','Lusin',NULL,'pcs',NULL,NULL),
(65,'100059','Lusin',NULL,'pcs',NULL,NULL),
(66,'100060','Botol',NULL,'Botol',NULL,NULL),
(67,'100061','Lusin',NULL,'pcs',NULL,NULL),
(68,'100062','Lusin',NULL,'pcs',NULL,NULL),
(69,'100063','Lusin',NULL,'pcs',NULL,NULL),
(70,'100064','Lusin',NULL,'pcs',NULL,NULL),
(71,'100065','Lusin',NULL,'pcs',NULL,NULL),
(72,'100066','Lusin',NULL,'pcs',NULL,NULL),
(73,'100067','Lusin',NULL,'pcs',NULL,NULL),
(74,'100068','Lusin',NULL,'pcs',NULL,NULL),
(75,'100069','Lusin',NULL,'pcs',NULL,NULL),
(76,'100070','Lusin',NULL,'pcs',NULL,NULL),
(77,'100071','Lusin',NULL,'pcs',NULL,NULL),
(78,'100072','Lusin',NULL,'pcs',NULL,NULL),
(79,'100073','Lusin',NULL,'pcs',NULL,NULL),
(80,'100074','Botol',NULL,'Botol',NULL,NULL),
(81,'100075','Lusin',NULL,'pcs',NULL,NULL),
(82,'100076','Lusin',NULL,'pcs',NULL,NULL),
(83,'100077','Lusin',NULL,'pcs',NULL,NULL),
(84,'100078','Lusin',NULL,'pcs',NULL,NULL),
(85,'100079','Lusin',NULL,'pcs',NULL,NULL),
(86,'100080','Lusin',NULL,'pcs',NULL,NULL),
(87,'100081','Lusin',NULL,'pcs',NULL,NULL),
(88,'100082','Lusin',NULL,'pcs',NULL,NULL),
(89,'100083','Lusin',NULL,'pcs',NULL,NULL),
(90,'100084','Botol',NULL,'Botol',NULL,NULL),
(91,'100085','Lusin',NULL,'pcs',NULL,NULL),
(92,'100086','Lusin',NULL,'pcs',NULL,NULL),
(93,'100087','Lusin',NULL,'pcs',NULL,NULL),
(94,'100088','Lusin',NULL,'pcs',NULL,NULL),
(95,'100089','Lusin',NULL,'pcs',NULL,NULL),
(96,'100090','Botol',NULL,'Botol',NULL,NULL),
(97,'100091','Botol',NULL,'Botol',NULL,NULL),
(98,'100092','Botol',NULL,'Botol',NULL,NULL),
(99,'100093','Botol',NULL,'Botol',NULL,NULL),
(100,'100094','Botol',NULL,'Botol',NULL,NULL),
(101,'100095','Lusin',NULL,'pcs',NULL,NULL),
(102,'100096','Botol',NULL,'Botol',NULL,NULL),
(103,'100097','Botol',NULL,'Botol',NULL,NULL),
(104,'100098','Botol',NULL,'Botol',NULL,NULL),
(105,'100099','Lusin',NULL,'pcs',NULL,NULL),
(106,'100100','Lusin',NULL,'pcs',NULL,NULL);
/*!40000 ALTER TABLE `tbl_obat_stock` ENABLE KEYS */;

-- 
-- Definition of tbl_pembelian
-- 

DROP TABLE IF EXISTS `tbl_pembelian`;
CREATE TABLE IF NOT EXISTS `tbl_pembelian` (
  `id_pembelian` varchar(40) NOT NULL,
  `no_faktur` varchar(50) DEFAULT NULL,
  `tgl_pembelian` date DEFAULT NULL,
  `kd_supplier` varchar(50) DEFAULT NULL,
  `kd_obat` varchar(50) DEFAULT NULL,
  `satuan_stock` varchar(50) DEFAULT NULL,
  `qty` smallint(6) DEFAULT NULL,
  `harga_satuan` decimal(18,0) DEFAULT NULL,
  `diskon` double DEFAULT NULL,
  `ppn` double DEFAULT NULL,
  `sub_total` decimal(18,0) DEFAULT NULL,
  `tgl_expired` date DEFAULT NULL,
  `kasir` varchar(50) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_pembelian`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_pembelian
-- 

/*!40000 ALTER TABLE `tbl_pembelian` DISABLE KEYS */;
INSERT INTO `tbl_pembelian`(`id_pembelian`,`no_faktur`,`tgl_pembelian`,`kd_supplier`,`kd_obat`,`satuan_stock`,`qty`,`harga_satuan`,`diskon`,`ppn`,`sub_total`,`tgl_expired`,`kasir`,`keterangan`) VALUES
('PB100001','123123','2017-03-08 00:00:00','12341','100004','Botol',16,50000006,0,0,800000096,'2017-03-08 00:00:00',NULL,'Apa kek'),
('PB100002','5656','2017-03-08 00:00:00','12341','100004','Botol',100,567456346345,0,0,56745634634500,'2017-03-25 00:00:00',NULL,'ASDADS'),
('PB100003','5757','2017-03-12 00:00:00','12341','100003','Lusin',20,1600000000,0,0,32000000000,'2018-03-03 00:00:00',NULL,'akjdaksd'),
('PB100004','9090','2017-03-13 00:00:00','12341','100005','Lusin',112,800000000,0,0,89600000000,'2017-03-08 00:00:00',NULL,'asasa'),
('PB100005','909090','2017-03-03 00:00:00','12341','100001','Lusin',10,1231212123,5,0,12927727292,'2017-03-31 00:00:00',NULL,'adad'),
('PB100006','55555','2017-03-09 00:00:00','12341','100003','Lusin',9,12124142,0,0,109117278,'2017-03-09 00:00:00',NULL,'dasdasd'),
('PB100007','234234','2017-03-09 00:00:00','12341','100002','Lusin',7678,80909,0,0,621219302,'2017-03-09 00:00:00',NULL,'hjl'),
('PB100008','555555','2017-03-09 00:00:00','12341','100003','Lusin',1230,14123123124,0,0,17371441442520,'2017-03-09 00:00:00',NULL,'adsadasd'),
('PB100009','124','2017-03-10 00:00:00','12341','100003','Lusin',777,69689789798,0,0,54148966673046,'2017-03-10 00:00:00',NULL,'opoop'),
('PB100010','2333','2017-03-10 00:00:00','12341','100003','Lusin',123,124124124,0,0,15267267252,'2017-03-10 00:00:00',NULL,'dadasd'),
('PB100012','898989','2017-03-10 00:00:00','12341','100004','Lusin',8,76887878687678,0,0,615103029501424,'2017-03-10 00:00:00',NULL,''),
('PB100013','322344','2017-03-10 00:00:00','12341','100005','Lusin',1230,1123124125,0,0,1381442673750,'2017-03-10 00:00:00',NULL,''),
('PB100014','345345','2017-04-01 00:00:00','12341','100006','Butir',10,14124124,10,0,155365364,'2017-03-10 00:00:00',NULL,'fwrewr'),
('PB100015','23525','2017-03-10 00:00:00','12341','100007',NULL,32425,453282340,0,0,14694116862800,'2017-03-10 00:00:00',NULL,'sdfsd'),
('PB100016','23525','2017-03-10 00:00:00','12341','100008','Botol',5,114234234,10,0,628288287,'2017-03-10 00:00:00',NULL,'dasd');
/*!40000 ALTER TABLE `tbl_pembelian` ENABLE KEYS */;

-- 
-- Definition of tbl_penjualan
-- 

DROP TABLE IF EXISTS `tbl_penjualan`;
CREATE TABLE IF NOT EXISTS `tbl_penjualan` (
  `id_penjualan` varchar(50) NOT NULL,
  `no_faktur` varchar(100) DEFAULT NULL,
  `id_obat` varchar(50) DEFAULT NULL,
  `tgl_jual` date DEFAULT NULL,
  `customer` varchar(100) DEFAULT NULL,
  `qty` smallint(6) DEFAULT NULL,
  `sub_total` decimal(18,0) DEFAULT NULL,
  `diskon` double DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `tgl_expired` date DEFAULT NULL,
  PRIMARY KEY (`id_penjualan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_penjualan
-- 

/*!40000 ALTER TABLE `tbl_penjualan` DISABLE KEYS */;
INSERT INTO `tbl_penjualan`(`id_penjualan`,`no_faktur`,`id_obat`,`tgl_jual`,`customer`,`qty`,`sub_total`,`diskon`,`Keterangan`,`tgl_expired`) VALUES
('100001','27022017100001','100003','2017-02-27 00:00:00','',4,50000,20,'','2017-03-10 00:00:00');
/*!40000 ALTER TABLE `tbl_penjualan` ENABLE KEYS */;

-- 
-- Definition of tbl_satuan
-- 

DROP TABLE IF EXISTS `tbl_satuan`;
CREATE TABLE IF NOT EXISTS `tbl_satuan` (
  `id_satuan` int(11) NOT NULL AUTO_INCREMENT,
  `Satuan` varchar(100) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_satuan`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_satuan
-- 

/*!40000 ALTER TABLE `tbl_satuan` DISABLE KEYS */;
INSERT INTO `tbl_satuan`(`id_satuan`,`Satuan`,`keterangan`) VALUES
(1,'Lusin',NULL),
(2,'Botol',NULL),
(3,'Butir',NULL),
(4,'liter',NULL),
(5,'lusin',NULL),
(6,'pcs',NULL);
/*!40000 ALTER TABLE `tbl_satuan` ENABLE KEYS */;

-- 
-- Definition of tbl_supplier
-- 

DROP TABLE IF EXISTS `tbl_supplier`;
CREATE TABLE IF NOT EXISTS `tbl_supplier` (
  `kd_supp` varchar(50) NOT NULL,
  `nm_supp` varchar(100) DEFAULT NULL,
  `alamat_supp` varchar(100) DEFAULT NULL,
  `kota_supp` varchar(100) DEFAULT NULL,
  `telp_supp` int(19) DEFAULT NULL,
  `email_supp` varchar(100) DEFAULT NULL,
  `nm_kontak_supp` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kd_supp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_supplier
-- 

/*!40000 ALTER TABLE `tbl_supplier` DISABLE KEYS */;
INSERT INTO `tbl_supplier`(`kd_supp`,`nm_supp`,`alamat_supp`,`kota_supp`,`telp_supp`,`email_supp`,`nm_kontak_supp`) VALUES
('12341','PT. CORONEt CROWN','Jl. Petamburan','Jakarta',9090924,'lkjlj@gmail.com','Muhmad');
/*!40000 ALTER TABLE `tbl_supplier` ENABLE KEYS */;

-- 
-- Definition of tbl_tipe
-- 

DROP TABLE IF EXISTS `tbl_tipe`;
CREATE TABLE IF NOT EXISTS `tbl_tipe` (
  `id_tipe` int(11) NOT NULL AUTO_INCREMENT,
  `tipe` varchar(100) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_tipe`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_tipe
-- 

/*!40000 ALTER TABLE `tbl_tipe` DISABLE KEYS */;
INSERT INTO `tbl_tipe`(`id_tipe`,`tipe`,`keterangan`) VALUES
(1,'Bubuk',''),
(2,'Kaplet',''),
(3,'Tablet',''),
(4,'Syrup',''),
(5,'Kapsul',''),
(6,'cream',''),
(7,'cair','');
/*!40000 ALTER TABLE `tbl_tipe` ENABLE KEYS */;

-- 
-- Definition of tbl_user
-- 

DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE IF NOT EXISTS `tbl_user` (
  `id_user` varchar(50) NOT NULL,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `level` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tbl_user
-- 

/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;

/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2017-06-23 09:09:50
-- Total time: 0:0:0:1:109 (d:h:m:s:ms)
