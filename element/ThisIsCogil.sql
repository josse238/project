CREATE DATABASE ThisIsCogil;
USE DATABASE ThisIsCogil;
-- Membuat Tabel Admin
CREATE TABLE Admin (
    username VARCHAR(50) PRIMARY KEY,
    password VARCHAR(50)
);
-- Menambahkan Admin Default
INSERT INTO Admin (username, password) VALUES ('admin', 'admin');
-- Membuat Tabel User
CREATE TABLE User (
    id_user INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100),
    email VARCHAR(100),
    no_tlp VARCHAR(20),
    password VARCHAR(50)
);
-- Membuat Tabel mobil
CREATE TABLE mobil (
    id_mobil INT AUTO_INCREMENT PRIMARY KEY,
    lokasi_sewa VARCHAR(100),
    merk VARCHAR(50),
    type_mobil VARCHAR(50),
    jumlah_penumpang INT,
    jumlah_bagasi INT,
    harga DECIMAL(10, 2),
    lepas_kunci ENUM('ya', 'tidak')
);
-- Membuat Tabel hotel
CREATE TABLE hotel (
    id_hotel INT AUTO_INCREMENT PRIMARY KEY,
    nama_hotel VARCHAR(100),
    hotel_bintang INT CHECK (hotel_bintang >= 1 AND hotel_bintang <= 5),
    lokasi VARCHAR(100),
    kota VARCHAR(50),
    propinsi VARCHAR(50),
    harga INT
);
 