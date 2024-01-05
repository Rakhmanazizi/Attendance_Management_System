-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 05 Jan 2024 pada 08.24
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendance`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `event`
--

CREATE TABLE `event` (
  `id` int(11) NOT NULL,
  `nama_event` varchar(60) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `tempat` varchar(60) DEFAULT NULL,
  `instruktur` int(11) DEFAULT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `event`
--

INSERT INTO `event` (`id`, `nama_event`, `tanggal`, `tempat`, `instruktur`, `deskripsi`) VALUES
(5, NULL, NULL, NULL, NULL, NULL),
(6, 'HARLAH', '2024-01-24', 'PURBALINGGA', 32, 'HARLAH LIMAPUSAKA KE-10 DI PCNU PURBALINGGA'),
(8, 'BANSOS', '2024-01-10', 'PURBALINGGA', 32, 'BANSOS DI GOR PURBALINGGA'),
(10, 'HARLAH', '2024-01-04', 'GEDUNG PCNU', 33, 'harlah limapusaka ke-10'),
(11, 'SOSKAM', '2024-01-04', 'SEKOLAH DI PURBALINGGA', 33, 'Sosialisasi kampus'),
(12, 'BANSOS', '2024-01-04', 'PURBALINGGA', 33, 'BANSOS KE WARGA SEKITAR'),
(14, 'coba event', '2024-01-05', 'tempat event', 35, 'Deskripsikan Kolom ini'),
(15, 'Dies Natalis IKPM', '2024-01-23', 'SEMARANG', 33, 'DIES NATALIS IKPM KE-11'),
(16, 'HELLO', '2024-01-24', 'HELLO', 33, 'HELLO'),
(17, 'BANDUNG', '2024-01-11', 'BANDUNG', 37, 'BANDUNG JAWA BARAT'),
(18, 'COBA COBA', '2024-01-17', 'COBA COBA COBA', 35, 'COBA COBA'),
(19, 'BUKBER', '2024-01-25', 'SOROWAJAN', 43, 'BUKBER SANTAI'),
(20, 'TRY IT', '2024-01-05', 'TRY IT', 52, 'TRY IT '),
(21, 'TRY EVENT ', '2024-01-11', 'INDONESIA', 53, 'TRY EVENT DESCRIPTION');

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `event_view`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `event_view` (
`id` int(11)
,`nama_event` varchar(60)
,`tanggal` date
,`tempat` varchar(60)
,`instruktur` varchar(60)
,`deskripsi` text
);

-- --------------------------------------------------------

--
-- Struktur dari tabel `kehadiran`
--

CREATE TABLE `kehadiran` (
  `id` int(11) NOT NULL,
  `id_event` int(11) DEFAULT NULL,
  `id_user` int(11) DEFAULT NULL,
  `status` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `kehadiran`
--

INSERT INTO `kehadiran` (`id`, `id_event`, `id_user`, `status`) VALUES
(17, 14, 11, 'Telat'),
(18, 6, 11, 'Hadir'),
(19, 11, 11, 'Hadir'),
(20, 17, 39, 'Hadir'),
(21, 16, 50, 'Hadir'),
(22, 21, 54, 'Hadir');

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `kehadiran_view`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `kehadiran_view` (
`id` int(11)
,`id_event` int(11)
,`id_user` int(11)
,`status` varchar(60)
,`nama_event` varchar(60)
,`tempat` varchar(60)
,`tanggal` date
,`instruktur` int(11)
,`nama_peserta` varchar(60)
,`nama_instruktur` varchar(60)
);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(60) DEFAULT NULL,
  `nama_lengkap` varchar(60) DEFAULT NULL,
  `password` varchar(60) DEFAULT NULL,
  `role` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id`, `username`, `nama_lengkap`, `password`, `role`) VALUES
(9, 'admin', 'admin', 'admin', 'admin'),
(10, 'zidnykarim', 'Muhammad Zidny Al-karim', 'zidny14', 'member'),
(11, 'Rakhman', 'Muhammad Arif Rakhman Azizi', 'rakhman', 'member'),
(12, 'Ilham', 'Ilham Ulinnuha', 'ilham', 'member'),
(27, 'liviarindika', 'Jetri Livia Rindika', 'viavia', 'member'),
(32, 'teyana', 'TIA NURUL AFIFAH', 'TEYANA', 'instruktur'),
(33, 'TRIYAA', 'TRIYA BAROKAH', 'TRIYA', 'instruktur'),
(34, 'MAAYY', 'MAY SAFIRA', 'MAY', 'instruktur'),
(35, 'IIN', 'IIN SHOLIHAH', 'IIN', 'instruktur'),
(36, 'SASAAASA', 'AISYA HANUM', 'SASA', 'instruktur'),
(37, 'TATA', 'MASITA HANUM', 'TATA', 'instruktur'),
(38, 'admin2', 'admin dua', 'admin2', 'admin'),
(39, 'puspita', 'Puspita Nur Baeti', 'puspita', 'member'),
(40, 'ULFI', 'DWI ULFAH LUTHFIANA', 'ULFI', 'member'),
(43, 'maruf', 'Ma\'ruf Nurmaarif', 'maruf', 'instruktur'),
(45, 'admin4', 'admin4', 'admin4', 'admin'),
(48, 'arman', 'Arman Maulana', 'arman', 'member'),
(49, 'RIAN', 'ARIANSYAH', 'RIAN', 'instruktur'),
(50, 'amalun', 'ihlasul amal', 'amal', 'member'),
(52, 'operator', 'operator', 'operator', 'instruktur'),
(53, 'instructor', 'instructor', 'instructor', 'instruktur'),
(54, 'member', 'member', 'member', 'member');

-- --------------------------------------------------------

--
-- Struktur untuk view `event_view`
--
DROP TABLE IF EXISTS `event_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `event_view`  AS SELECT `event`.`id` AS `id`, `event`.`nama_event` AS `nama_event`, `event`.`tanggal` AS `tanggal`, `event`.`tempat` AS `tempat`, `user`.`username` AS `instruktur`, `event`.`deskripsi` AS `deskripsi` FROM (`event` join `user` on(`event`.`instruktur` = `user`.`id`)) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `kehadiran_view`
--
DROP TABLE IF EXISTS `kehadiran_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `kehadiran_view`  AS SELECT `kehadiran`.`id` AS `id`, `kehadiran`.`id_event` AS `id_event`, `kehadiran`.`id_user` AS `id_user`, `kehadiran`.`status` AS `status`, `event`.`nama_event` AS `nama_event`, `event`.`tempat` AS `tempat`, `event`.`tanggal` AS `tanggal`, `event`.`instruktur` AS `instruktur`, `user`.`nama_lengkap` AS `nama_peserta`, `instruktur`.`nama_lengkap` AS `nama_instruktur` FROM (((`kehadiran` join `event` on(`kehadiran`.`id_event` = `event`.`id`)) join `user` on(`kehadiran`.`id_user` = `user`.`id`)) join `user` `instruktur` on(`event`.`instruktur` = `instruktur`.`id`)) ;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`id`),
  ADD KEY `instruktur_fk` (`instruktur`);

--
-- Indeks untuk tabel `kehadiran`
--
ALTER TABLE `kehadiran`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_event_fk` (`id_event`),
  ADD KEY `id_user_fk` (`id_user`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `password_unique` (`password`),
  ADD UNIQUE KEY `username_unique` (`username`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `event`
--
ALTER TABLE `event`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT untuk tabel `kehadiran`
--
ALTER TABLE `kehadiran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `instruktur_fk` FOREIGN KEY (`instruktur`) REFERENCES `user` (`id`);

--
-- Ketidakleluasaan untuk tabel `kehadiran`
--
ALTER TABLE `kehadiran`
  ADD CONSTRAINT `id_event_fk` FOREIGN KEY (`id_event`) REFERENCES `event` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `id_user_fk` FOREIGN KEY (`id_user`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
