-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2023, 20:52:41
-- Sunucu sürümü: 8.0.28
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `gp_final`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hizmet`
--

CREATE TABLE `hizmet` (
  `id` int NOT NULL,
  `h_adi` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `h_icerik` varchar(700) COLLATE utf8mb4_unicode_ci NOT NULL,
  `k_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hizmetler`
--

CREATE TABLE `hizmetler` (
  `id` int NOT NULL,
  `h_ad` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL,
  `h_detayi` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tur` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `hizmetler`
--

INSERT INTO `hizmetler` (`id`, `h_ad`, `h_detayi`, `tur`) VALUES
(1, 'Periodik bakım', 'Toyota Garanti ON’a geçin, her periyodik bakımda 1 yıl garanti kazanın! Türkiye’de bir ilk. 10 yıla kadar ücretsiz garanti Toyota’da. Size Özel Kampanyalar. Yenilikçi Teknoloji. Üstün Kalite.', 0),
(2, 'Standart bakım', 'dsfsdf sdf sfd fsdf sdf', 0),
(3, 'Kış Bakımı', 'dsfsdf sdf sfd fsdf sdf', 1),
(4, 'Bahar Bakımı', 'dsfsdf sdf sfd fsdf sdffdgdfg', 2),
(5, 'Klima', 'dsfsdf sdf sfd fsdf sdffdgdfg', 3),
(6, 'Isıtma Sorunu', 'dsfsdf sdf sfd fsdf sdffdgdfg', 3),
(7, 'Soğutma Sorunu', 'dsfsdf sdf sfd fsdf sdffdgdfg', 3),
(8, 'Motor Boğma', 'dsfsdf sdf sfd fsdf sdffdgdfg', 4),
(9, 'Marş Basma', 'dsfsdf sdf sfd fsdf sdffdgdfg', 4),
(10, 'Fren Balata', 'dsfsdf sdf sfd fsdf sdffdgdfg', 5),
(11, 'Lastik Yok', 'dsfsdf sdf sfd fsdf sdffdgdfg', 6);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `randevular`
--

CREATE TABLE `randevular` (
  `id` int NOT NULL,
  `saat` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `deger` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ad_soyad` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tel` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `eposta` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `marka` varchar(500) COLLATE utf8mb4_unicode_ci NOT NULL,
  `km` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `plk` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tarih` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `k_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `randevular`
--

INSERT INTO `randevular` (`id`, `saat`, `deger`, `ad_soyad`, `tel`, `eposta`, `marka`, `km`, `plk`, `tarih`, `k_id`) VALUES
(1, '01:00', 'Standart bakım', '1', '2', '3', '4', '5', '6', 'sdf', 5),
(2, '00:00', 'Periodik bakım', '1', '2', '3', '4', '5', '6', '2.01.2023 20:15:18', 5),
(3, '01:00', 'Marş Basma', '1gjhjghj', '05555555', 'hjgk@', 'jjjh', 'hj', 'jjhhh', '12.01.2023 23:07:47', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uyeler`
--

CREATE TABLE `uyeler` (
  `id` int NOT NULL,
  `kullanici_adi` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sifre` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `yetki` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `uyeler`
--

INSERT INTO `uyeler` (`id`, `kullanici_adi`, `sifre`, `yetki`) VALUES
(1, '1', '2', 0),
(2, 'ben', 'robot', 0),
(4, 'admin', '1', 0),
(5, '12', '12', 1),
(6, '00', '00', 0);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `hizmet`
--
ALTER TABLE `hizmet`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `hizmetler`
--
ALTER TABLE `hizmetler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `randevular`
--
ALTER TABLE `randevular`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `uyeler`
--
ALTER TABLE `uyeler`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `hizmet`
--
ALTER TABLE `hizmet`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `hizmetler`
--
ALTER TABLE `hizmetler`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `randevular`
--
ALTER TABLE `randevular`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `uyeler`
--
ALTER TABLE `uyeler`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
