-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 05 Jan 2024 pada 14.38
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
-- Database: `attendance_bc`
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
(1, 'EVENT SATU', '2024-01-06', 'PLACE', 2, 'PLACE'),
(3, 'EVENT DUA', '2024-01-17', 'PLACE DUA', 7, 'EVENT DUA');

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
,`instruktur` int(11)
,`nama_lengkap` varchar(60)
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
  `status` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `kehadiran`
--

INSERT INTO `kehadiran` (`id`, `id_event`, `id_user`, `status`) VALUES
(1, 3, 4, 'Telat'),
(2, 1, 4, 'Hadir');

-- --------------------------------------------------------

--
-- Stand-in struktur untuk tampilan `kehadiran_view`
-- (Lihat di bawah untuk tampilan aktual)
--
CREATE TABLE `kehadiran_view` (
`id` int(11)
,`id_event` int(11)
,`nama_event` varchar(60)
,`instruktur` int(11)
,`tempat` varchar(60)
,`tanggal` date
,`id_user` int(11)
,`nama_peserta` varchar(60)
,`nama_instruktur` varchar(60)
,`status` varchar(15)
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
(1, 'admin', 'admin', 'admin', 'admin'),
(2, 'instruktur', 'instruktur', 'instruktur', 'instruktur'),
(4, 'member', 'member', 'member', 'member'),
(7, 'INSTRUKTUR-2', 'INSTRUKTUR DUA', 'INSTRUKTUR-2', 'instruktur');

-- --------------------------------------------------------

--
-- Struktur untuk view `event_view`
--
DROP TABLE IF EXISTS `event_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `event_view`  AS SELECT `event`.`id` AS `id`, `event`.`nama_event` AS `nama_event`, `event`.`tanggal` AS `tanggal`, `event`.`tempat` AS `tempat`, `event`.`instruktur` AS `instruktur`, `user`.`nama_lengkap` AS `nama_lengkap`, `event`.`deskripsi` AS `deskripsi` FROM (`event` join `user` on(`event`.`instruktur` = `user`.`id`)) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `kehadiran_view`
--
DROP TABLE IF EXISTS `kehadiran_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `kehadiran_view`  AS SELECT `kehadiran`.`id` AS `id`, `kehadiran`.`id_event` AS `id_event`, `event`.`nama_event` AS `nama_event`, `event`.`instruktur` AS `instruktur`, `event`.`tempat` AS `tempat`, `event`.`tanggal` AS `tanggal`, `kehadiran`.`id_user` AS `id_user`, `user_peserta`.`nama_lengkap` AS `nama_peserta`, `user_instruktur`.`nama_lengkap` AS `nama_instruktur`, `kehadiran`.`status` AS `status` FROM (((`kehadiran` join `event` on(`kehadiran`.`id_event` = `event`.`id`)) join `user` `user_peserta` on(`kehadiran`.`id_user` = `user_peserta`.`id`)) join `user` `user_instruktur` on(`event`.`instruktur` = `user_instruktur`.`id`)) ;

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
  ADD KEY `id_user_fk` (`id_user`),
  ADD KEY `id_event_fk` (`id_event`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username_unique` (`username`),
  ADD UNIQUE KEY `pass_unique` (`password`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `event`
--
ALTER TABLE `event`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `kehadiran`
--
ALTER TABLE `kehadiran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `instruktur_fk` FOREIGN KEY (`instruktur`) REFERENCES `user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `kehadiran`
--
ALTER TABLE `kehadiran`
  ADD CONSTRAINT `id_event_fk` FOREIGN KEY (`id_event`) REFERENCES `event` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `id_user_fk` FOREIGN KEY (`id_user`) REFERENCES `user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
