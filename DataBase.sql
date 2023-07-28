-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           5.7.36 - MySQL Community Server (GPL)
-- SE du serveur:                Win64
-- HeidiSQL Version:             12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour sauzet_boutique
CREATE DATABASE IF NOT EXISTS `sauzet_boutique` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sauzet_boutique`;

-- Listage de la structure de table sauzet_boutique. categorie
CREATE TABLE IF NOT EXISTS `categorie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;

-- Listage des données de la table sauzet_boutique.categorie : ~100 rows (environ)
INSERT INTO `categorie` (`id`, `libelle`) VALUES
	(1, 'lacus'),
	(2, 'tristique'),
	(3, 'Nunc'),
	(4, 'ut'),
	(5, 'eleifend,'),
	(6, 'et'),
	(7, 'primis'),
	(8, 'mus.'),
	(9, 'et'),
	(10, 'ac'),
	(11, 'et'),
	(12, 'TestBlabla'),
	(13, 'semper'),
	(14, 'turpis'),
	(15, 'turpis'),
	(16, 'eget'),
	(17, 'ullamcorper,'),
	(18, 'urna'),
	(19, 'Curabitur'),
	(20, 'risus.'),
	(21, 'Fusce'),
	(22, 'ornare,'),
	(23, 'lectus.'),
	(24, 'nunc.'),
	(25, 'Sed'),
	(27, 'tincidunt'),
	(28, 'at'),
	(29, 'blandit'),
	(30, 'lobortis.'),
	(31, 'purus'),
	(32, 'euismod'),
	(33, 'ornare.'),
	(34, 'tempor'),
	(35, 'Fusce'),
	(36, 'aliquam'),
	(37, 'metus.'),
	(38, 'nisi'),
	(39, 'Nullam'),
	(40, 'tempor'),
	(41, 'lobortis'),
	(42, 'eget'),
	(43, 'euismod'),
	(44, 'et'),
	(45, 'orci'),
	(46, 'scelerisque'),
	(47, 'Fusce'),
	(48, 'amet'),
	(49, 'tincidunt,'),
	(50, 'euismod'),
	(51, 'gravida.'),
	(52, 'ornare'),
	(53, 'tortor'),
	(54, 'vel,'),
	(55, 'posuere'),
	(56, 'mauris'),
	(57, 'elit.'),
	(58, 'tellus'),
	(59, 'Nam'),
	(60, 'orci,'),
	(61, 'ligula'),
	(62, 'velit'),
	(63, 'iaculis,'),
	(64, 'nisl'),
	(65, 'nonummy'),
	(66, 'augue.'),
	(67, 'amet,'),
	(68, 'pede.'),
	(69, 'tincidunt'),
	(70, 'adipiscing'),
	(71, 'nibh'),
	(72, 'enim.'),
	(73, 'egestas'),
	(74, 'conubia'),
	(75, 'scelerisque'),
	(76, 'in'),
	(77, 'Donec'),
	(78, 'facilisis,'),
	(79, 'massa.'),
	(80, 'luctus'),
	(81, 'sed'),
	(82, 'semper'),
	(83, 'Donec'),
	(84, 'Donec'),
	(85, 'nibh'),
	(86, 'vulputate,'),
	(87, 'nec,'),
	(88, 'convallis'),
	(89, 'justo'),
	(90, 'ipsum'),
	(91, 'arcu'),
	(92, 'velit'),
	(93, 'sit'),
	(94, 'In'),
	(95, 'eleifend.'),
	(96, 'diam'),
	(97, 'pede'),
	(98, 'Sed'),
	(99, 'erat'),
	(100, 'LoremIpsum');

-- Listage de la structure de table sauzet_boutique. client
CREATE TABLE IF NOT EXISTS `client` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(30) NOT NULL,
  `prenom` varchar(30) NOT NULL,
  `rue` varchar(255) NOT NULL,
  `codePostal` int(11) NOT NULL,
  `ville` varchar(255) NOT NULL,
  `tel` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=109 DEFAULT CHARSET=latin1;

-- Listage des données de la table sauzet_boutique.client : ~100 rows (environ)
INSERT INTO `client` (`id`, `nom`, `prenom`, `rue`, `codePostal`, `ville`, `tel`, `email`) VALUES
	(3, 'Mays', 'Sean', 'Ap #962-4318 Mi Road', 55810, 'Pontarlier', '02 05 75 78 67', 'metus.in.lorem@protonmail.ca'),
	(4, 'Head', 'Willow', '320-1536 Tellus St.', 53537, 'Épernay', '09 83 36 28 64', 'dui.fusce@hotmail.couk'),
	(5, 'Meyer', 'Dane', 'P.O. Box 197, 3305 Curae St.', 37483, 'Calais', '02 55 86 51 45', 'porttitor.scelerisque@icloud.com'),
	(6, 'Ray', 'Uriah', 'Ap #158-4718 At, Road', 33545, 'Épernay', '04 92 78 92 79', 'sapien.gravida@hotmail.com'),
	(7, 'Clay', 'Quon', '2242 Nam Road', 23773, 'Lille', '02 74 45 03 32', 'rutrum.fusce@google.ca'),
	(8, 'Gomez', 'Kevyn', 'Ap #518-3342 Mi St.', 15867, 'Albi', '03 41 21 43 84', 'mauris@aol.couk'),
	(9, 'Coleman', 'Isaac', 'P.O. Box 138, 8731 Massa Ave', 1257, 'Pau', '08 13 82 84 87', 'orci@hotmail.couk'),
	(10, 'Bass', 'Leslie', '842-2184 Pede Road', 17627, 'Limoges', '07 09 77 79 88', 'scelerisque.lorem.ipsum@google.ca'),
	(11, 'Pugh', 'Boris', 'Ap #428-8833 Nec, Av.', 71042, 'Bergerac', '07 64 25 22 69', 'dictum.magna@yahoo.com'),
	(12, 'Vega', 'Coby', 'Ap #528-1335 Odio Road', 11376, 'Rodez', '04 94 05 87 38', 'sed@icloud.ca'),
	(13, 'Ray', 'Demetria', '871-8792 Vel Street', 67987, 'Vierzon', '08 85 34 22 81', 'sit.amet.orci@google.couk'),
	(14, 'Mcbride', 'Melyssa', 'Ap #327-189 Gravida. Avenue', 24164, 'Narbonne', '07 80 85 84 68', 'vel.convallis@yahoo.edu'),
	(15, 'Cooley', 'Raymond', '9499 Iaculis Rd.', 55140, 'Brive-la-Gaillarde', '04 29 21 59 65', 'nulla@yahoo.org'),
	(16, 'Guerra', 'Griffin', 'P.O. Box 350, 5696 Faucibus. St.', 21184, 'Épinal', '03 46 16 77 57', 'blandit.mattis@protonmail.org'),
	(17, 'Sampson', 'Addison', 'Ap #740-474 Volutpat St.', 77347, 'Limoges', '01 17 83 95 14', 'integer.sem@hotmail.org'),
	(18, 'Reese', 'Shellie', 'Ap #140-6766 Convallis Road', 27444, 'Montigny-lès-Metz', '02 51 51 25 22', 'justo.sit@hotmail.edu'),
	(19, 'Valdez', 'Erasmus', 'P.O. Box 510, 9412 Pharetra. St.', 78973, 'Hénin-Beaumont', '08 17 27 51 03', 'vulputate@google.couk'),
	(20, 'Wood', 'Nero', 'P.O. Box 695, 9936 At Street', 50443, 'Bergerac', '08 72 85 42 62', 'velit.pellentesque.ultricies@protonmail.org'),
	(21, 'Molina', 'Keith', 'P.O. Box 536, 260 Amet Avenue', 11051, 'Charleville-Mézières', '08 52 33 42 63', 'mauris@outlook.ca'),
	(22, 'Stephens', 'Jakeem', '437-5291 Risus. Rd.', 58596, 'Dole', '02 35 90 22 78', 'fusce.fermentum@yahoo.com'),
	(23, 'Stanley', 'Jared', 'P.O. Box 653, 7821 Lacus. St.', 97308, 'La Rochelle', '06 72 02 55 47', 'auctor.vitae.aliquet@protonmail.couk'),
	(24, 'Rodriquez', 'Brandon', 'P.O. Box 689, 4445 Bibendum Rd.', 70788, 'Lille', '02 59 72 38 85', 'nullam@outlook.ca'),
	(25, 'White', 'Deborah', '527-6832 Cum Av.', 42203, 'Amiens', '02 40 52 46 94', 'nunc@aol.edu'),
	(26, 'Castro', 'Zoe', 'P.O. Box 521, 9588 Malesuada. St.', 41781, 'Talence', '03 18 92 17 46', 'orci.tincidunt@aol.org'),
	(27, 'Boyle', 'Jenna', 'P.O. Box 420, 2546 Nunc Rd.', 14542, 'Laon', '01 20 32 27 77', 'fames.ac@protonmail.ca'),
	(28, 'Daniels', 'Gray', '325-4217 Vulputate Road', 10468, 'Dunkerque', '05 74 14 35 81', 'sed.consequat@hotmail.org'),
	(29, 'Harrison', 'Ariel', '924-9804 Non St.', 28483, 'Besançon', '06 53 92 41 56', 'rutrum.justo.praesent@icloud.couk'),
	(30, 'Galloway', 'Macey', 'Ap #268-9923 Molestie Street', 67152, 'Sotteville-lès-Rouen', '05 26 38 76 77', 'id@google.ca'),
	(31, 'Blackwell', 'Raya', 'Ap #878-1777 Libero. Ave', 66498, 'Alès', '02 54 47 97 58', 'semper.tellus.id@google.couk'),
	(32, 'Maynard', 'Ezekiel', '975-6135 Curabitur Road', 47356, 'Rouen', '03 85 47 19 55', 'amet.consectetuer@yahoo.ca'),
	(33, 'Browning', 'Timon', '695-8479 Elit, St.', 64043, 'Clermont-Ferrand', '06 05 89 62 78', 'nam@google.edu'),
	(34, 'Riddle', 'Signe', 'P.O. Box 944, 7901 At, Ave', 32054, 'Lanester', '03 24 42 66 21', 'a.nunc@protonmail.couk'),
	(35, 'Benson', 'Clark', 'Ap #898-2318 Velit St.', 82772, 'Saint-Médard-en-Jalles', '08 83 66 78 12', 'aliquet.phasellus@hotmail.edu'),
	(36, 'Briggs', 'Wanda', '296-4612 Lorem St.', 55555, 'Wattrelos', '03 84 31 43 88', 'cursus.purus@yahoo.org'),
	(37, 'Poole', 'Sharon', 'P.O. Box 700, 450 Ac, St.', 12072, 'Schiltigheim', '02 90 23 41 17', 'cubilia.curae@aol.com'),
	(38, 'Melton', 'Barclay', 'Ap #213-6277 Lorem, St.', 74777, 'Saint-Dié-des-Vosges', '06 87 27 32 54', 'dignissim@google.com'),
	(39, 'Glover', 'Ria', '767-341 In Road', 53095, 'Illkirch-Graffenstaden', '02 26 61 32 81', 'varius@icloud.org'),
	(40, 'Heath', 'Austin', 'Ap #286-2429 Ante. Rd.', 55872, 'Castres', '05 43 37 37 66', 'donec.sollicitudin.adipiscing@protonmail.net'),
	(41, 'Harmon', 'Cadman', '571-5625 Elit, Avenue', 49189, 'Toulouse', '07 42 52 01 14', 'nonummy.ultricies@protonmail.ca'),
	(42, 'Frost', 'Wylie', '280-3880 Magna Avenue', 52446, 'Strasbourg', '07 74 86 54 77', 'elit.curabitur.sed@aol.net'),
	(43, 'Cohen', 'Yvette', '727-2870 Aliquam St.', 36415, 'Colmar', '08 25 74 14 79', 'ac.libero.nec@hotmail.net'),
	(44, 'Mooney', 'Garrett', 'Ap #479-3081 Erat. Av.', 54688, 'Brest', '08 18 48 55 75', 'venenatis.a@protonmail.com'),
	(45, 'Edwards', 'Herrod', '2586 Feugiat Road', 41942, 'Tarbes', '03 67 87 85 63', 'nec@google.net'),
	(46, 'Greene', 'Noelani', '774-1096 Risus St.', 34253, 'Soissons', '04 56 78 57 66', 'dolor.quisque@yahoo.couk'),
	(47, 'Livingston', 'Kieran', 'Ap #361-8492 Penatibus Av.', 51375, 'Cherbourg-Octeville', '04 26 60 42 72', 'nec.imperdiet@hotmail.ca'),
	(48, 'Ellis', 'Madison', 'Ap #125-1677 At St.', 45623, 'La Rochelle', '08 81 74 32 26', 'elit.sed@icloud.edu'),
	(49, 'Price', 'Hyacinth', 'Ap #848-3941 Enim, St.', 43863, 'Ajaccio', '04 32 52 87 56', 'varius@google.edu'),
	(50, 'Rios', 'Jolie', 'Ap #273-3243 Ornare, St.', 25222, 'Thionville', '03 46 76 35 10', 'odio@outlook.ca'),
	(51, 'Maddox', 'Clementine', '693-2175 Mauris Street', 73587, 'Aubagne', '07 21 49 22 03', 'sed.dui.fusce@aol.couk'),
	(52, 'Downs', 'Lois', '203-3245 Nec Ave', 37715, 'Schiltigheim', '03 36 41 76 54', 'euismod.enim@protonmail.edu'),
	(53, 'Lynn', 'Nola', '111-6918 Lacus, Rd.', 81261, 'Brive-la-Gaillarde', '03 55 23 28 56', 'eu.nulla@outlook.org'),
	(54, 'Logan', 'Kirestin', '894-6457 Proin Road', 68620, 'Saint-Quentin', '02 35 86 54 41', 'imperdiet.non.vestibulum@google.couk'),
	(55, 'Baldwin', 'Rhoda', '1126 Lectus Road', 54855, 'Bastia', '04 57 33 60 87', 'in@icloud.com'),
	(56, 'Byrd', 'Zane', '110-7375 Bibendum Rd.', 54141, 'Soissons', '08 13 77 49 78', 'nec.urna@icloud.org'),
	(57, 'Middleton', 'Shelby', 'Ap #944-1851 Sollicitudin Road', 54527, 'Dunkerque', '02 81 63 84 81', 'nec@hotmail.org'),
	(58, 'Steele', 'Ann', '7497 Fermentum Rd.', 52846, 'Bastia', '05 36 48 78 63', 'tortor.at.risus@yahoo.net'),
	(59, 'Gregory', 'Miranda', '2167 Sit St.', 42388, 'Sarreguemines', '01 79 84 02 37', 'elit@icloud.edu'),
	(60, 'Holloway', 'Deborah', 'Ap #383-2289 Montes, Street', 8963, 'Clermont-Ferrand', '08 26 17 21 72', 'imperdiet.non@protonmail.net'),
	(61, 'Craft', 'Lilah', '776-5290 Lectus St.', 78337, 'Auxerre', '08 02 49 10 20', 'tempor.diam@hotmail.org'),
	(62, 'Kelly', 'Dalton', 'Ap #812-9061 Nullam Rd.', 79812, 'Cagnes-sur-Mer', '07 52 68 03 40', 'consectetuer.cursus.et@yahoo.com'),
	(63, 'Anthony', 'Rachel', 'Ap #296-8700 Suspendisse Ave', 71235, 'Alès', '07 56 05 17 60', 'sem@icloud.ca'),
	(64, 'Barrera', 'Jada', '184-8717 Purus, Road', 61655, 'Talence', '08 57 91 00 44', 'sed.sem@google.couk'),
	(65, 'Banks', 'Declan', '377-1671 Phasellus Avenue', 26753, 'Cholet', '06 73 14 83 25', 'faucibus.orci@outlook.org'),
	(66, 'Tate', 'Hilda', 'Ap #153-9992 Dictum Ave', 91351, 'Perpignan', '09 70 70 23 89', 'habitant.morbi@hotmail.ca'),
	(67, 'Moreno', 'Knox', 'P.O. Box 632, 1004 Iaculis, Avenue', 34455, 'Sète', '01 73 31 15 63', 'at.velit@outlook.edu'),
	(68, 'Mcclain', 'Olga', '221-3244 Dolor, Av.', 62184, 'Angers', '03 97 68 19 60', 'non@outlook.couk'),
	(69, 'Meadows', 'Iola', '881-8354 Pretium Rd.', 29768, 'Marcq-en-Baroeul', '04 63 40 42 26', 'fusce.feugiat@yahoo.org'),
	(70, 'Cain', 'Melanie', 'Ap #299-1444 Dignissim Ave', 82116, 'Limoges', '09 75 86 08 76', 'ligula.donec@google.org'),
	(71, 'Johnston', 'Declan', '256-7031 Ut Rd.', 51447, 'Épinal', '07 59 25 96 22', 'adipiscing.lacus.ut@icloud.ca'),
	(72, 'Ochoa', 'Denise', 'Ap #960-9512 Consectetuer Street', 43144, 'Tours', '03 20 36 42 18', 'cum@icloud.com'),
	(73, 'Newton', 'Germane', 'P.O. Box 638, 1877 Purus. Ave', 28159, 'Dunkerque', '05 21 02 58 83', 'at.risus.nunc@aol.couk'),
	(74, 'Chaney', 'Patricia', '447-4971 Augue St.', 19078, 'Brive-la-Gaillarde', '04 29 93 36 94', 'ultricies.sem.magna@aol.org'),
	(75, 'Moss', 'Georgia', '961-3156 Elit. St.', 91808, 'Martigues', '08 56 89 32 38', 'pellentesque.sed@outlook.couk'),
	(76, 'Dodson', 'Dillon', '629-5458 Tincidunt. St.', 83517, 'Châtellerault', '02 14 59 77 62', 'mauris@protonmail.edu'),
	(77, 'Anderson', 'Ezra', 'Ap #134-7146 Dolor Av.', 96644, 'Besançon', '04 71 26 41 85', 'et.netus@protonmail.org'),
	(78, 'Mccormick', 'Patience', '101-5826 Arcu. Av.', 40136, 'Saint-Louis', '05 52 10 43 51', 'nisi.nibh.lacinia@icloud.edu'),
	(79, 'Gates', 'Elliott', 'Ap #593-6443 Dui. Avenue', 49604, 'Hyères', '06 68 22 86 28', 'faucibus.morbi@yahoo.com'),
	(80, 'Tyson', 'Abra', '7156 Vulputate, Rd.', 58235, 'Castres', '07 12 57 65 87', 'eu.tempor@hotmail.edu'),
	(81, 'Ray', 'Ruby', 'P.O. Box 340, 2046 Duis Av.', 87441, 'Saint-Lô', '03 31 85 48 57', 'eu.odio@protonmail.ca'),
	(82, 'Fernandez', 'Irene', 'Ap #497-5687 Faucibus St.', 82976, 'Castres', '05 47 81 63 45', 'non.bibendum.sed@yahoo.edu'),
	(83, 'Buchanan', 'Alyssa', 'P.O. Box 936, 5089 Mauris St.', 4025, 'Épinal', '04 39 24 13 56', 'aliquam.adipiscing@protonmail.org'),
	(84, 'Chapman', 'Callie', '845-1222 Mauris Ave', 93443, 'Périgueux', '08 24 94 26 57', 'ac.orci.ut@icloud.ca'),
	(85, 'Ramos', 'Macon', 'Ap #678-7793 Placerat Road', 14177, 'Rennes', '04 93 43 78 45', 'libero.est@hotmail.net'),
	(86, 'Sims', 'Mikayla', '230-608 Nec Rd.', 41520, 'Le Grand-Quevilly', '07 74 77 39 72', 'at.nisi.cum@google.ca'),
	(87, 'Curry', 'Maryam', '3232 Velit. Rd.', 36611, 'Limoges', '07 59 41 53 55', 'pulvinar.arcu@hotmail.com'),
	(88, 'Woodward', 'Graiden', 'P.O. Box 713, 2726 Sed Rd.', 70678, 'Saint-Brieuc', '06 83 51 81 56', 'rhoncus@yahoo.couk'),
	(89, 'Russo', 'Nehru', '166-5737 Est Rd.', 55318, 'Pontarlier', '06 59 63 12 68', 'in.tincidunt.congue@icloud.com'),
	(90, 'Oneil', 'Rafael', 'Ap #766-2954 Donec Street', 48486, 'Ajaccio', '06 73 13 10 66', 'dui.nec.urna@protonmail.org'),
	(91, 'Burke', 'Xantha', 'Ap #493-4801 Malesuada. Ave', 22746, 'Calais', '02 26 32 78 68', 'phasellus@hotmail.ca'),
	(92, 'Hamilton', 'Irma', 'Ap #143-4703 Nec, Ave', 68204, 'Sens', '07 12 79 43 36', 'justo@protonmail.org'),
	(93, 'Holman', 'Indira', 'P.O. Box 883, 7205 Penatibus St.', 42372, 'Le Mans', '04 18 63 73 72', 'condimentum@aol.net'),
	(94, 'Reid', 'Ferdinand', '177-1551 Aenean Rd.', 98044, 'Dole', '03 60 19 34 57', 'laoreet@google.com'),
	(95, 'Gallagher', 'Ebony', 'P.O. Box 198, 9662 Aliquam Av.', 78751, 'Vannes', '06 47 46 08 76', 'ultrices.posuere.cubilia@yahoo.edu'),
	(96, 'Wall', 'Galvin', '856-6575 Placerat, St.', 77079, 'Troyes', '07 51 92 10 26', 'lacinia.mattis@outlook.ca'),
	(97, 'Summers', 'Jane', '987 Tellus Rd.', 94149, 'Haguenau', '01 66 29 72 81', 'risus.nunc@hotmail.net'),
	(98, 'Morrow', 'Paula', '806-7336 Nisl. Avenue', 4577, 'Creil', '08 42 90 43 71', 'sodales.nisi.magna@icloud.org'),
	(99, 'Clayton', 'Fuller', '335-1014 At, St.', 85276, 'Istres', '03 75 47 54 72', 'elit.pede.malesuada@aol.edu'),
	(100, 'Newman', 'Teegan', '276-6428 Consequat Rd.', 13317, 'Le Puy-en-Velay', '02 82 21 78 41', 'semper.rutrum.fusce@protonmail.org'),
	(101, 'Sampson', 'Oprah', 'Ap #304-6364 At Avenue', 13757, 'Dunkerque', '02 64 46 81 51', 'neque.nullam@outlook.com'),
	(102, 'Mcfarland', 'Echo', 'Ap #587-3661 Quisque Av.', 78814, 'Gap', '06 44 34 53 35', 'ad@google.edu'),
	(107, 'zaertyh', 'zerthgfd', 'koihdia', 18464, 'azi dnh_on', '169684984', 'kjhdibn'),
	(108, 'gdfty', 'eruv', 'cveruv', 55555, 'zfgeyt', '4554555544', 'qfsfefsflkjhlb');

-- Listage de la structure de table sauzet_boutique. commande
CREATE TABLE IF NOT EXISTS `commande` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date DEFAULT NULL,
  `idClient` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idClient` (`idClient`),
  CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`idClient`) REFERENCES `client` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;

-- Listage des données de la table sauzet_boutique.commande : ~102 rows (environ)
INSERT INTO `commande` (`id`, `date`, `idClient`) VALUES
	(1, '2023-12-04', 97),
	(2, '2023-10-10', 8),
	(3, '2023-04-07', 48),
	(4, '2022-05-25', 12),
	(5, '2023-04-03', 84),
	(6, '2022-11-27', 80),
	(7, '2023-09-17', 72),
	(8, '2022-09-02', 42),
	(9, '2024-01-25', 5),
	(10, '2022-04-28', 32),
	(11, '2022-08-14', 60),
	(12, '2023-10-29', 9),
	(13, '2023-02-18', 49),
	(14, '2022-09-29', 82),
	(15, '2023-12-14', 24),
	(16, '2023-07-17', 45),
	(17, '2022-09-15', 97),
	(18, '2022-05-27', 71),
	(19, '2023-09-04', 92),
	(20, '2023-03-20', 88),
	(21, '2023-12-19', 36),
	(22, '2022-12-06', 33),
	(23, '2023-11-22', 9),
	(24, '2022-06-09', 5),
	(25, '2024-03-04', 7),
	(26, '2022-12-12', 56),
	(27, '2023-01-20', 73),
	(28, '2022-05-29', 52),
	(29, '2023-12-24', 37),
	(30, '2023-05-10', 39),
	(31, '2023-07-06', 8),
	(32, '2022-06-02', 3),
	(33, '2023-03-22', 76),
	(34, '2022-12-14', 24),
	(35, '2022-09-20', 22),
	(36, '2023-01-12', 44),
	(37, '2023-03-27', 31),
	(38, '2023-11-17', 18),
	(39, '2023-01-31', 74),
	(40, '2023-08-18', 99),
	(41, '2023-04-19', 69),
	(42, '2022-12-05', 25),
	(43, '2023-10-05', 39),
	(44, '2022-12-27', 53),
	(45, '2023-10-25', 23),
	(46, '2023-05-21', 43),
	(47, '2023-03-07', 4),
	(48, '2022-03-28', 44),
	(49, '2024-03-06', 6),
	(50, '2023-05-23', 11),
	(51, '2023-03-28', 97),
	(52, '2023-01-11', 19),
	(53, '2022-11-11', 37),
	(54, '2023-09-14', 92),
	(55, '2023-06-29', 80),
	(56, '2023-02-24', 100),
	(57, '2024-03-03', 5),
	(58, '2022-05-07', 89),
	(59, '2023-09-15', 72),
	(60, '2023-08-10', 65),
	(61, '2022-06-20', 46),
	(62, '2023-04-19', 53),
	(63, '2023-11-04', 33),
	(64, '2022-07-24', 93),
	(65, '2024-01-29', 12),
	(66, '2023-01-21', 5),
	(67, '2023-02-18', 38),
	(68, '2023-02-16', 57),
	(69, '2023-04-07', 13),
	(70, '2022-08-05', 94),
	(71, '2022-12-23', 90),
	(72, '2024-02-09', 91),
	(73, '2022-10-19', 70),
	(74, '2023-10-11', 49),
	(75, '2023-03-18', 73),
	(76, '2022-12-24', 5),
	(77, '2023-08-22', 73),
	(78, '2024-01-02', 57),
	(79, '2022-06-14', 27),
	(80, '2023-08-13', 99),
	(81, '2023-09-10', 21),
	(82, '2024-03-06', 32),
	(83, '2022-10-28', 64),
	(84, '2023-01-17', 20),
	(85, '2022-05-23', 48),
	(86, '2022-06-12', 24),
	(87, '2023-02-15', 58),
	(88, '2022-10-22', 27),
	(89, '2023-06-15', 43),
	(90, '2023-09-05', 53),
	(91, '2022-05-06', 27),
	(92, '2023-09-18', 9),
	(93, '2023-03-15', 9),
	(94, '2022-12-29', 89),
	(95, '2022-05-06', 37),
	(96, '2023-04-18', 71),
	(97, '2022-08-21', 9),
	(98, '2023-10-17', 23),
	(99, '2023-08-28', 52),
	(100, '2022-04-06', 99);

-- Listage de la structure de table sauzet_boutique. fournisseur
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(30) NOT NULL,
  `rue` varchar(255) NOT NULL,
  `codePostal` int(11) NOT NULL,
  `ville` varchar(255) NOT NULL,
  `tel` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=latin1;

-- Listage des données de la table sauzet_boutique.fournisseur : ~100 rows (environ)
INSERT INTO `fournisseur` (`id`, `nom`, `rue`, `codePostal`, `ville`, `tel`, `email`) VALUES
	(3, 'Pierce', '608-1982 Arcu Rd.', 41117, 'Toulon', '03 48 66 35 56', 'eu.tempor@icloud.net'),
	(4, 'Anthony', '597-7243 Nisl St.', 4455, 'Saint-Lô', '04 83 41 33 78', 'nisi.magna.sed@aol.edu'),
	(5, 'Barry', 'P.O. Box 317, 540 Orci Rd.', 17186, 'Castres', '08 53 16 60 51', 'pellentesque.massa@yahoo.ca'),
	(6, 'Conley', 'Ap #789-8282 Quis, Av.', 22778, 'Niort', '06 56 65 27 45', 'sed.pede@aol.couk'),
	(7, 'Barrera', 'Ap #171-2449 Nulla. Rd.', 17415, 'Auxerre', '06 81 10 38 53', 'vulputate.nisi.sem@protonmail.com'),
	(8, 'Harper', 'Ap #150-4177 Eget St.', 92375, 'Chalon-sur-Saône', '08 70 68 17 22', 'sapien.gravida@yahoo.ca'),
	(9, 'Turner', '797-5167 Libero Rd.', 1210, 'Saint-Quentin', '05 84 19 44 10', 'cras.convallis.convallis@hotmail.couk'),
	(10, 'Watts', '350-5559 Vulputate Street', 47301, 'Ajaccio', '05 53 22 24 93', 'mollis.phasellus.libero@protonmail.edu'),
	(11, 'Holden', '664-5308 Amet Av.', 58773, 'Créteil', '05 20 57 01 11', 'ante.dictum@yahoo.couk'),
	(12, 'Shaw', '979-815 Euismod Av.', 92959, 'Le Grand-Quevilly', '04 32 44 98 99', 'ipsum.dolor.sit@hotmail.edu'),
	(13, 'Chandler', '860-9632 At Av.', 39446, 'Toulouse', '06 49 41 07 42', 'malesuada.fames@google.couk'),
	(14, 'Parker', 'P.O. Box 773, 6707 Maecenas Ave', 77744, 'La Seyne-sur-Mer', '06 23 47 25 02', 'nibh.quisque@hotmail.couk'),
	(15, 'Hodges', '998-9671 Dui St.', 46086, 'Châlons-en-Champagne', '06 83 71 85 93', 'placerat.velit@aol.net'),
	(16, 'Hyde', '2061 Proin St.', 61694, 'Saint-Brieuc', '07 24 35 74 68', 'dui@protonmail.org'),
	(17, 'Myers', '548-5386 Vitae Avenue', 71256, 'Le Mans', '07 48 36 69 36', 'sodales.purus.in@yahoo.couk'),
	(18, 'Byrd', '125-407 Blandit St.', 60324, 'Moulins', '04 62 46 74 77', 'lectus.pede@google.edu'),
	(19, 'Pitts', 'P.O. Box 114, 2370 A St.', 35472, 'Saint-Lô', '01 35 91 74 67', 'cras@icloud.net'),
	(20, 'Long', '2091 Pede Road', 2937, 'Lunel', '09 08 34 83 41', 'hendrerit.neque.in@yahoo.net'),
	(21, 'Kirby', 'Ap #217-1787 Non St.', 78438, 'La Rochelle', '07 38 33 17 54', 'donec@yahoo.couk'),
	(22, 'Good', '616-4267 Venenatis St.', 21579, 'Albi', '08 73 52 77 26', 'maecenas.mi@protonmail.couk'),
	(23, 'Villarreal', '725-7173 In, St.', 12034, 'Toulouse', '08 56 43 42 19', 'integer.in@icloud.couk'),
	(24, 'Bishop', 'Ap #162-9305 Fames Ave', 4855, 'Montigny-lès-Metz', '02 30 64 97 50', 'egestas.fusce.aliquet@yahoo.couk'),
	(25, 'Strickland', '623-707 Sem St.', 32283, 'Moulins', '06 90 47 60 73', 'at@aol.org'),
	(26, 'Larson', 'Ap #238-8939 Duis St.', 97117, 'Saint-Louis', '05 18 91 01 25', 'ultricies@hotmail.couk'),
	(27, 'Hubbard', '6636 Ornare, St.', 67766, 'Saint-Quentin', '03 12 27 02 89', 'lorem.ut@icloud.net'),
	(28, 'Hawkins', '6810 Eget St.', 93566, 'Toulon', '05 28 03 64 03', 'suspendisse.dui.fusce@yahoo.edu'),
	(29, 'Cain', 'P.O. Box 889, 6539 Auctor, Avenue', 43278, 'Saint-Dié-des-Vosges', '03 36 30 13 56', 'augue.eu@yahoo.com'),
	(30, 'Carter', 'Ap #116-760 Hymenaeos. Street', 55607, 'Ajaccio', '05 55 80 19 43', 'laoreet.ipsum.curabitur@hotmail.com'),
	(31, 'Juarez', 'Ap #559-6325 Ultrices. Av.', 17977, 'Creil', '03 47 17 31 17', 'nisl.quisque@yahoo.ca'),
	(32, 'Hess', '755-7829 Elit, St.', 67194, 'Angoulême', '03 75 33 47 05', 'justo@google.org'),
	(33, 'Estes', 'Ap #546-3601 Duis Avenue', 78100, 'Mâcon', '06 25 19 87 34', 'neque@aol.net'),
	(34, 'Richard', '166-3972 A St.', 77477, 'Caen', '06 82 82 21 08', 'donec.elementum@google.org'),
	(35, 'Joseph', 'P.O. Box 872, 1189 Interdum Avenue', 15618, 'Vernon', '01 72 77 45 13', 'pellentesque.habitant@outlook.edu'),
	(36, 'Armstrong', '989-5216 Proin Ave', 19612, 'Montauban', '06 93 42 87 67', 'feugiat.tellus@icloud.couk'),
	(37, 'Ellison', '3521 Metus. Rd.', 53804, 'Bastia', '08 57 71 84 47', 'sed.auctor@aol.net'),
	(38, 'Leach', '397-4157 Neque Rd.', 43127, 'Épernay', '06 61 42 70 44', 'sem.pellentesque@icloud.couk'),
	(39, 'Sweeney', 'Ap #866-7516 Eget St.', 66898, 'Bastia', '03 60 59 50 79', 'quis.tristique.ac@yahoo.com'),
	(40, 'Moreno', 'Ap #914-5442 Facilisis Ave', 51956, 'Montbéliard', '06 19 24 38 44', 'eget.tincidunt@hotmail.net'),
	(41, 'Griffin', 'Ap #212-4958 Metus Av.', 25589, 'Haguenau', '05 46 82 93 17', 'nec@icloud.com'),
	(42, 'Daniels', 'P.O. Box 302, 5119 Amet, St.', 28130, 'Brive-la-Gaillarde', '09 23 30 01 35', 'faucibus@outlook.couk'),
	(43, 'Whitley', '765-2911 Auctor Street', 3266, 'Limoges', '07 64 26 18 32', 'arcu.imperdiet.ullamcorper@yahoo.ca'),
	(44, 'Ramos', 'P.O. Box 725, 5984 Sollicitudin Rd.', 63883, 'Chalon-sur-Saône', '06 24 18 65 33', 'euismod.mauris.eu@outlook.couk'),
	(45, 'Sloan', '9642 Lobortis Av.', 75722, 'Montbéliard', '02 24 11 66 03', 'convallis.ante@hotmail.net'),
	(46, 'Owens', '9537 A Road', 81467, 'Saint-Louis', '07 22 30 38 66', 'est@hotmail.couk'),
	(47, 'Hayes', 'Ap #579-3837 Tellus. St.', 30404, 'Nancy', '09 22 40 20 81', 'sit.amet@aol.net'),
	(48, 'Petersen', 'Ap #477-7682 In Ave', 69707, 'Poitiers', '08 75 31 42 91', 'libero.nec@outlook.ca'),
	(49, 'Franklin', '6296 A Av.', 24237, 'Cholet', '04 33 34 54 24', 'auctor.ullamcorper@hotmail.edu'),
	(50, 'Dalton', 'Ap #482-1690 Enim. Street', 33844, 'Bègles', '03 88 65 57 64', 'cras@outlook.net'),
	(51, 'Nunez', 'Ap #497-2201 Mattis Avenue', 24606, 'Le Mans', '04 84 80 67 87', 'elit.a.feugiat@aol.com'),
	(52, 'Russell', 'Ap #246-7683 Nulla Ave', 35393, 'Rodez', '04 47 37 01 72', 'mauris@hotmail.ca'),
	(53, 'Heath', 'Ap #479-9719 Arcu St.', 18433, 'Joué-lès-Tours', '07 75 78 47 21', 'mi.fringilla@icloud.net'),
	(54, 'Gutierrez', 'P.O. Box 145, 7377 Proin Road', 62574, 'Saint-Louis', '01 81 40 76 83', 'leo.in.lobortis@google.net'),
	(55, 'Hubbard', 'Ap #242-1845 Donec Ave', 68375, 'Roubaix', '02 24 51 04 29', 'ultrices.posuere@google.couk'),
	(56, 'Jimenez', 'P.O. Box 307, 8096 Lorem Road', 77882, 'Colmar', '07 37 72 90 30', 'nulla.in@aol.couk'),
	(57, 'Mullen', 'Ap #969-3554 Volutpat Rd.', 15526, 'Schiltigheim', '04 65 04 87 25', 'a.sollicitudin@hotmail.org'),
	(58, 'Shepherd', '2125 Id Street', 30084, 'Cagnes-sur-Mer', '04 68 17 23 66', 'pede.blandit.congue@outlook.com'),
	(59, 'Mckenzie', '280 Et Av.', 73152, 'Arras', '02 47 21 89 07', 'tempus.lorem@outlook.edu'),
	(60, 'Gentry', '126-4765 Neque. Street', 64134, 'Le Petit-Quevilly', '07 14 18 86 70', 'sem.magna@icloud.com'),
	(61, 'Beach', '937-6405 Et St.', 87764, 'Auxerre', '03 55 64 02 26', 'ornare.lectus@icloud.com'),
	(62, 'Davis', 'P.O. Box 989, 5888 Lorem. Road', 85274, 'Vandoeuvre-lès-Nancy', '09 03 25 94 37', 'fusce.mi@yahoo.org'),
	(63, 'Noble', '920-5354 Natoque Av.', 75607, 'La Rochelle', '02 27 20 56 50', 'porttitor.scelerisque@hotmail.net'),
	(64, 'Conrad', 'Ap #106-8219 Libero. Street', 57794, 'Châteauroux', '02 50 37 46 41', 'molestie.pharetra@yahoo.org'),
	(65, 'Mejia', 'P.O. Box 435, 2948 Tempus Street', 58584, 'Vertou', '02 13 14 06 11', 'nam@icloud.ca'),
	(66, 'House', 'Ap #722-9230 Lorem. Av.', 53311, 'Marseille', '08 35 41 10 53', 'lobortis.mauris@outlook.couk'),
	(67, 'Mason', 'Ap #765-6439 Nibh St.', 61002, 'Bordeaux', '01 72 18 46 46', 'tempus.mauris@protonmail.org'),
	(68, 'Russo', 'Ap #771-6568 Sit Av.', 40144, 'Saint-Étienne-du-Rouvray', '04 76 86 66 18', 'non.egestas@protonmail.net'),
	(69, 'Flores', '135-3830 Aliquam Av.', 88780, 'Brive-la-Gaillarde', '06 51 18 25 56', 'iaculis.lacus.pede@protonmail.net'),
	(70, 'Norris', 'Ap #749-6448 Nonummy Street', 40173, 'Limoges', '05 38 38 54 35', 'vel.venenatis.vel@aol.edu'),
	(71, 'Faulkner', '5498 Tellus. Ave', 16358, 'Caen', '05 71 40 58 65', 'sem.magna@hotmail.org'),
	(72, 'Moon', 'Ap #582-9273 Imperdiet, Street', 13988, 'Joué-lès-Tours', '04 13 26 29 33', 'lacinia@aol.org'),
	(73, 'Byrd', 'Ap #898-7722 Mauris Av.', 85244, 'Nancy', '03 86 51 67 78', 'et.tristique@protonmail.com'),
	(74, 'Padilla', 'Ap #323-234 Ridiculus Rd.', 18137, 'Sens', '04 85 74 51 24', 'iaculis@protonmail.net'),
	(75, 'Cooley', '729-1628 Ut Av.', 56949, 'Gap', '09 41 39 74 25', 'fringilla@hotmail.couk'),
	(76, 'Valentine', 'P.O. Box 557, 6102 Cursus Av.', 78662, 'Antibes', '01 54 86 69 63', 'cubilia.curae.donec@google.org'),
	(77, 'Cain', '848-7940 Gravida St.', 21366, 'Creil', '08 43 13 21 27', 'etiam.gravida@google.net'),
	(78, 'Bishop', '192-8310 Et Avenue', 67166, 'Épinal', '03 20 64 29 51', 'nisi@icloud.com'),
	(79, 'O\'donnell', 'Ap #213-5466 Vulputate Rd.', 52418, 'Montpellier', '03 82 25 35 78', 'sed.congue@protonmail.ca'),
	(80, 'Farley', '408-9602 Orci Av.', 11747, 'Le Grand-Quevilly', '02 66 54 21 11', 'dui@hotmail.ca'),
	(81, 'Austin', 'Ap #956-644 Lorem Av.', 63172, 'Sotteville-lès-Rouen', '05 77 27 63 67', 'et.lacinia@aol.couk'),
	(82, 'Lynn', '1429 Dictum Street', 42783, 'Illkirch-Graffenstaden', '05 24 14 74 31', 'cras.pellentesque@google.edu'),
	(83, 'Ellis', '192-7086 Cras Av.', 73173, 'Orléans', '06 57 32 69 59', 'mauris@yahoo.edu'),
	(84, 'Cobb', 'Ap #907-6228 Urna Ave', 48504, 'Schiltigheim', '09 24 20 87 38', 'at.auctor.ullamcorper@protonmail.org'),
	(85, 'Ramirez', 'Ap #500-4752 Convallis Rd.', 44847, 'Orléans', '05 53 09 16 66', 'orci@aol.com'),
	(86, 'Tucker', 'P.O. Box 684, 1082 Nisl. Rd.', 48857, 'Martigues', '01 93 41 55 35', 'rhoncus.nullam@outlook.ca'),
	(87, 'Livingston', '3588 Luctus Rd.', 66803, 'Poitiers', '06 58 91 63 38', 'auctor.nunc@protonmail.com'),
	(88, 'Dyer', 'Ap #547-3792 Dolor, St.', 52829, 'Bastia', '05 34 48 89 62', 'fringilla.purus.mauris@yahoo.ca'),
	(89, 'Rosario', '996-5308 Fames St.', 20249, 'Perpignan', '02 31 59 86 74', 'dui.fusce@outlook.net'),
	(90, 'Hale', '655-1419 Mus. Rd.', 75248, 'Auxerre', '07 22 53 52 65', 'commodo.auctor.velit@yahoo.org'),
	(91, 'Owens', 'Ap #684-7003 Phasellus Avenue', 18154, 'Pessac', '04 31 77 41 35', 'curabitur.ut.odio@protonmail.edu'),
	(92, 'Douglas', 'Ap #143-903 Semper Street', 87114, 'Vierzon', '08 11 57 62 17', 'cum@aol.ca'),
	(93, 'Hooper', '632 Dolor Ave', 14511, 'Wattrelos', '06 55 30 41 75', 'vel.convallis@outlook.edu'),
	(94, 'Camacho', '225-1947 Dictum Avenue', 41794, 'Troyes', '01 37 31 37 72', 'velit.pellentesque.ultricies@yahoo.org'),
	(95, 'Gregory', 'P.O. Box 382, 1903 Nam St.', 38013, 'Nancy', '06 58 46 22 76', 'nam.porttitor.scelerisque@outlook.ca'),
	(96, 'Matthews', '290-8497 Orci St.', 37135, 'Chartres', '04 36 08 65 69', 'arcu.aliquam.ultrices@protonmail.couk'),
	(97, 'Dorsey', 'Ap #989-5774 Magna. Rd.', 25251, 'Angoulême', '03 07 33 05 30', 'volutpat@protonmail.edu'),
	(98, 'Arnold', '3930 Semper, Rd.', 72865, 'Asnières-sur-Seine', '05 54 40 66 34', 'suscipit@aol.net'),
	(99, 'Schroeder', '663-978 Odio Ave', 24136, 'Montauban', '08 23 19 47 53', 'aliquet@outlook.edu'),
	(100, 'Graham', 'Ap #366-7847 Phasellus Road', 41352, 'Rueil-Malmaison', '06 41 40 81 81', 'integer@yahoo.ca'),
	(101, 'Whitaker', 'P.O. Box 804, 9766 Faucibus. Avenue', 92989, 'Montluçon', '06 52 36 02 37', 'mauris.vel.turpis@outlook.ca'),
	(102, 'Britt', '1611 Amet Rd.', 71427, 'Évreux', '08 62 18 88 16', 'in.at.pede@aol.ca');

-- Listage de la structure de table sauzet_boutique. lignedecommande
CREATE TABLE IF NOT EXISTS `lignedecommande` (
  `idCommande` int(11) NOT NULL,
  `idProduit` int(11) NOT NULL,
  `quantite` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCommande`,`idProduit`),
  KEY `idProduit` (`idProduit`),
  KEY `idCommande` (`idCommande`),
  CONSTRAINT `lignedecommande_ibfk_1` FOREIGN KEY (`idCommande`) REFERENCES `commande` (`id`),
  CONSTRAINT `lignedecommande_ibfk_2` FOREIGN KEY (`idProduit`) REFERENCES `produit` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Listage des données de la table sauzet_boutique.lignedecommande : ~100 rows (environ)
INSERT INTO `lignedecommande` (`idCommande`, `idProduit`, `quantite`) VALUES
	(1, 30, 91),
	(2, 16, 86),
	(7, 2, 45),
	(7, 23, 27),
	(8, 56, 98),
	(8, 87, 12),
	(9, 69, 78),
	(9, 82, 100),
	(11, 59, 45),
	(15, 69, 63),
	(16, 76, 5),
	(17, 18, 49),
	(18, 18, 96),
	(18, 60, 92),
	(19, 46, 58),
	(20, 5, 45),
	(20, 39, 77),
	(22, 33, 60),
	(24, 19, 19),
	(24, 83, 81),
	(25, 23, 4),
	(25, 26, 32),
	(27, 66, 73),
	(27, 72, 18),
	(29, 48, 71),
	(29, 60, 44),
	(30, 37, 38),
	(31, 41, 62),
	(33, 14, 37),
	(34, 44, 41),
	(40, 88, 45),
	(40, 98, 28),
	(43, 56, 81),
	(43, 68, 87),
	(44, 66, 70),
	(45, 17, 53),
	(45, 83, 78),
	(46, 7, 20),
	(46, 33, 96),
	(46, 48, 22),
	(47, 42, 26),
	(48, 44, 36),
	(49, 33, 31),
	(49, 67, 21),
	(50, 50, 0),
	(50, 70, 11),
	(50, 78, 18),
	(51, 34, 99),
	(51, 86, 43),
	(53, 15, 54),
	(53, 75, 69),
	(54, 56, 54),
	(54, 69, 90),
	(55, 3, 79),
	(56, 23, 8),
	(57, 34, 69),
	(58, 45, 90),
	(58, 85, 74),
	(61, 16, 27),
	(63, 49, 45),
	(63, 65, 91),
	(64, 42, 11),
	(64, 65, 96),
	(66, 4, 11),
	(67, 15, 55),
	(67, 89, 19),
	(69, 9, 25),
	(69, 10, 63),
	(70, 15, 15),
	(70, 35, 61),
	(72, 60, 14),
	(73, 56, 53),
	(73, 93, 22),
	(75, 34, 19),
	(75, 90, 59),
	(75, 99, 6),
	(77, 3, 80),
	(78, 31, 97),
	(78, 73, 94),
	(80, 74, 7),
	(81, 67, 77),
	(82, 29, 73),
	(82, 62, 39),
	(83, 51, 3),
	(85, 30, 43),
	(86, 5, 10),
	(87, 26, 88),
	(87, 89, 69),
	(89, 50, 80),
	(89, 86, 39),
	(91, 7, 66),
	(94, 5, 20),
	(95, 9, 39),
	(95, 86, 51),
	(95, 87, 62),
	(97, 26, 5),
	(98, 54, 10),
	(99, 24, 19),
	(99, 30, 13),
	(100, 75, 57);

-- Listage de la structure de table sauzet_boutique. produit
CREATE TABLE IF NOT EXISTS `produit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `description` varchar(500) DEFAULT NULL,
  `prix` decimal(10,2) DEFAULT NULL,
  `image` varchar(100) DEFAULT NULL,
  `idCategorie` int(11) DEFAULT NULL,
  `idFournisseur` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idCategorie` (`idCategorie`),
  KEY `idFournisseur` (`idFournisseur`),
  CONSTRAINT `produit_ibfk_1` FOREIGN KEY (`idCategorie`) REFERENCES `categorie` (`id`),
  CONSTRAINT `produit_ibfk_2` FOREIGN KEY (`idFournisseur`) REFERENCES `fournisseur` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;

-- Listage des données de la table sauzet_boutique.produit : ~100 rows (environ)
INSERT INTO `produit` (`id`, `nom`, `description`, `prix`, `image`, `idCategorie`, `idFournisseur`) VALUES
	(1, 'eu enim. Etiam imperdiet', 'condimentum. Donec at arcu. Vestibulum ante ipsum primis in faucibus', 20.00, 'bbc.co.uk/sub/cars', 49, 38),
	(2, 'at arcu. Vestibulum ante ipsum', 'dui, semper et, lacinia vitae, sodales at, velit. Pellentesque ultricies', 37.00, 'yahoo.com/one', 62, 83),
	(3, 'Sed congue, elit', 'facilisi. Sed neque. Sed eget lacus. Mauris non dui nec', 43.00, 'facebook.com/fr', 43, 34),
	(4, 'commodo tincidunt', 'inceptos hymenaeos. Mauris ut quam vel sapien imperdiet ornare. In', 58.00, 'zoom.us/sub/cars', 65, 38),
	(5, 'natoque penatibus', 'elementum, dui quis accumsan convallis, ante lectus convallis est, vitae', 5.00, 'nytimes.com/group/9', 15, 54),
	(6, 'eget mollis lectus', 'ipsum dolor sit amet, consectetuer adipiscing elit. Aliquam auctor, velit', 88.00, 'cnn.com/user/110', 11, 78),
	(7, 'non', 'dapibus quam quis diam. Pellentesque habitant morbi tristique senectus et', 54.00, 'reddit.com/group/9', 76, 56),
	(8, 'libero. Proin', 'lorem, luctus ut, pellentesque eget, dictum placerat, augue. Sed molestie.', 49.00, 'nytimes.com/user/110', 89, 86),
	(9, 'fringilla cursus', 'magna tellus faucibus leo, in lobortis tellus justo sit amet', 60.00, 'walmart.com/user/110', 63, 32),
	(10, 'Curabitur ut', 'ac arcu. Nunc mauris. Morbi non sapien molestie orci tincidunt', 28.00, 'youtube.com/settings', 17, 70),
	(11, 'Curabitur dictum. Phasellus', 'quam. Pellentesque habitant morbi tristique senectus et netus et malesuada', 84.00, 'twitter.com/sub', 22, 65),
	(12, 'a sollicitudin', 'libero. Integer in magna. Phasellus dolor elit, pellentesque a, facilisis', 4.00, 'nytimes.com/sub/cars', 84, 81),
	(13, 'Vivamus non', 'ultrices sit amet, risus. Donec nibh enim, gravida sit amet,', 13.00, 'facebook.com/site', 61, 26),
	(14, 'eget odio.', 'vitae nibh. Donec est mauris, rhoncus id, mollis nec, cursus', 59.00, 'naver.com/sub/cars', 98, 29),
	(15, 'in, hendrerit', 'ullamcorper, velit in aliquet lobortis, nisi nibh lacinia orci, consectetuer', 53.00, 'baidu.com/site', 64, 39),
	(16, 'primis in faucibus orci luctus', 'hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida', 42.00, 'cnn.com/site', 6, 81),
	(17, 'elit. Etiam', 'tempus risus. Donec egestas. Duis ac arcu. Nunc mauris. Morbi', 32.00, 'facebook.com/settings', 36, 19),
	(18, 'sem', 'tempus scelerisque, lorem ipsum sodales purus, in molestie tortor nibh', 48.00, 'baidu.com/settings', 9, 61),
	(19, 'blandit viverra. Donec tempus,', 'Curae Donec tincidunt. Donec vitae erat vel pede blandit congue.', 26.00, 'youtube.com/site', 84, 68),
	(20, 'tempor diam dictum sapien.', 'Integer mollis. Integer tincidunt aliquam arcu. Aliquam ultrices iaculis odio.', 51.00, 'zoom.us/en-ca', 96, 101),
	(21, 'semper auctor.', 'magna nec quam. Curabitur vel lectus. Cum sociis natoque penatibus', 36.00, 'instagram.com/user/110', 69, 13),
	(22, 'nulla vulputate dui, nec', 'vehicula. Pellentesque tincidunt tempus risus. Donec egestas. Duis ac arcu.', 47.00, 'twitter.com/fr', 84, 23),
	(23, 'molestie tortor nibh sit amet', 'Donec consectetuer mauris id sapien. Cras dolor dolor, tempus non,', 23.00, 'zoom.us/en-us', 38, 89),
	(24, 'montes, nascetur ridiculus', 'euismod mauris eu elit. Nulla facilisi. Sed neque. Sed eget', 7.00, 'yahoo.com/settings', 25, 11),
	(25, 'dignissim magna a', 'convallis ligula. Donec luctus aliquet odio. Etiam ligula tortor, dictum', 59.00, 'youtube.com/sub', 16, 65),
	(26, 'risus', 'est mauris, rhoncus id, mollis nec, cursus a, enim. Suspendisse', 86.00, 'zoom.us/fr', 2, 35),
	(27, 'in felis. Nulla', 'in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu', 44.00, 'instagram.com/site', 25, 48),
	(28, 'purus. Duis elementum, dui', 'ipsum primis in faucibus orci luctus et ultrices posuere cubilia', 35.00, 'youtube.com/fr', 48, 49),
	(29, 'rutrum magna. Cras', 'elit, a feugiat tellus lorem eu metus. In lorem. Donec', 54.00, 'reddit.com/sub/cars', 66, 43),
	(30, 'et ipsum', 'bibendum fermentum metus. Aenean sed pede nec ante blandit viverra.', 58.00, 'walmart.com/settings', 44, 60),
	(31, 'neque.', 'ac ipsum. Phasellus vitae mauris sit amet lorem semper auctor.', 24.00, 'zoom.us/en-ca', 63, 10),
	(32, 'Nulla facilisi. Sed neque. Sed', 'morbi tristique senectus et netus et malesuada fames ac turpis', 2.00, 'bbc.co.uk/settings', 82, 52),
	(33, 'dapibus rutrum, justo.', 'nascetur ridiculus mus. Aenean eget magna. Suspendisse tristique neque venenatis', 29.00, 'pinterest.com/en-us', 72, 67),
	(34, 'ipsum nunc id enim.', 'nibh sit amet orci. Ut sagittis lobortis mauris. Suspendisse aliquet', 56.00, 'baidu.com/en-us', 63, 71),
	(35, 'justo faucibus lectus, a', 'justo faucibus lectus, a sollicitudin orci sem eget massa. Suspendisse', 51.00, 'baidu.com/sub', 82, 95),
	(36, 'Ut nec urna et', 'varius. Nam porttitor scelerisque neque. Nullam nisl. Maecenas malesuada fringilla', 99.00, 'naver.com/sub/cars', 36, 65),
	(37, 'egestas. Aliquam', 'egestas rhoncus. Proin nisl sem, consequat nec, mollis vitae, posuere', 44.00, 'wikipedia.org/en-ca', 52, 77),
	(38, 'Duis risus odio,', 'congue, elit sed consequat auctor, nunc nulla vulputate dui, nec', 54.00, 'wikipedia.org/one', 84, 43),
	(39, 'amet diam eu', 'elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu', 10.00, 'guardian.co.uk/sub/cars', 28, 8),
	(40, 'sed, hendrerit a, arcu.', 'tempus scelerisque, lorem ipsum sodales purus, in molestie tortor nibh', 54.00, 'netflix.com/one', 65, 83),
	(41, 'dolor. Quisque', 'luctus sit amet, faucibus ut, nulla. Cras eu tellus eu', 70.00, 'ebay.com/group/9', 47, 18),
	(42, 'amet ornare lectus justo eu', 'in consequat enim diam vel arcu. Curabitur ut odio vel', 34.00, 'instagram.com/one', 3, 61),
	(43, 'vulputate eu, odio.', 'euismod est arcu ac orci. Ut semper pretium neque. Morbi', 56.00, 'naver.com/sub', 74, 37),
	(44, 'felis ullamcorper', 'ipsum primis in faucibus orci luctus et ultrices posuere cubilia', 9.00, 'ebay.com/group/9', 71, 83),
	(45, 'neque tellus, imperdiet non,', 'est tempor bibendum. Donec felis orci, adipiscing non, luctus sit', 18.00, 'ebay.com/en-ca', 68, 49),
	(46, 'Suspendisse', 'sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero', 22.00, 'yahoo.com/site', 99, 82),
	(47, 'Morbi non sapien molestie orci', 'cursus non, egestas a, dui. Cras pellentesque. Sed dictum. Proin', 3.00, 'reddit.com/one', 88, 50),
	(48, 'magna a neque. Nullam', 'metus. In lorem. Donec elementum, lorem ut aliquam iaculis, lacus', 93.00, 'bbc.co.uk/user/110', 56, 25),
	(49, 'nec mauris blandit mattis.', 'auctor, velit eget laoreet posuere, enim nisl elementum purus, accumsan', 29.00, 'youtube.com/sub', 63, 43),
	(50, 'nonummy. Fusce fermentum fermentum', 'sapien. Aenean massa. Integer vitae nibh. Donec est mauris, rhoncus', 83.00, 'wikipedia.org/settings', 86, 22),
	(51, 'sit', 'scelerisque, lorem ipsum sodales purus, in molestie tortor nibh sit', 14.00, 'baidu.com/en-us', 24, 47),
	(52, 'mi tempor lorem,', 'dui, nec tempus mauris erat eget ipsum. Suspendisse sagittis. Nullam', 16.00, 'cnn.com/sub', 37, 40),
	(53, 'mauris a nunc. In', 'blandit viverra. Donec tempus, lorem fringilla ornare placerat, orci lacus', 63.00, 'guardian.co.uk/settings', 50, 64),
	(54, 'mauris eu elit. Nulla facilisi.', 'justo. Praesent luctus. Curabitur egestas nunc sed libero. Proin sed', 98.00, 'cnn.com/sub', 23, 30),
	(55, 'magnis dis', 'euismod in, dolor. Fusce feugiat. Lorem ipsum dolor sit amet,', 26.00, 'ebay.com/en-ca', 44, 91),
	(56, 'molestie', 'in sodales elit erat vitae risus. Duis a mi fringilla', 69.00, 'wikipedia.org/settings', 63, 95),
	(57, 'adipiscing lobortis', 'sollicitudin a, malesuada id, erat. Etiam vestibulum massa rutrum magna.', 9.00, 'yahoo.com/site', 46, 77),
	(58, 'semper et, lacinia', 'lectus quis massa. Mauris vestibulum, neque sed dictum eleifend, nunc', 9.00, 'reddit.com/one', 86, 88),
	(59, 'Duis', 'velit. Sed malesuada augue ut lacus. Nulla tincidunt, neque vitae', 25.00, 'pinterest.com/en-us', 64, 27),
	(60, 'sodales at,', 'vehicula aliquet libero. Integer in magna. Phasellus dolor elit, pellentesque', 63.00, 'wikipedia.org/en-us', 28, 95),
	(61, 'ullamcorper, nisl arcu iaculis enim,', 'egestas. Sed pharetra, felis eget varius ultrices, mauris ipsum porta', 36.00, 'naver.com/sub', 9, 37),
	(62, 'lobortis, nisi nibh lacinia', 'neque. Nullam ut nisi a odio semper cursus. Integer mollis.', 79.00, 'pinterest.com/en-us', 28, 60),
	(63, 'sem magna nec', 'et risus. Quisque libero lacus, varius et, euismod et, commodo', 31.00, 'nytimes.com/one', 8, 28),
	(64, 'ultricies adipiscing, enim mi', 'turpis. In condimentum. Donec at arcu. Vestibulum ante ipsum primis', 67.00, 'yahoo.com/sub', 29, 39),
	(65, 'Fusce mollis.', 'Quisque varius. Nam porttitor scelerisque neque. Nullam nisl. Maecenas malesuada', 98.00, 'whatsapp.com/group/9', 16, 23),
	(66, 'eros nec tellus. Nunc', 'Nunc mauris elit, dictum eu, eleifend nec, malesuada ut, sem.', 32.00, 'youtube.com/en-ca', 63, 21),
	(67, 'posuere', 'In lorem. Donec elementum, lorem ut aliquam iaculis, lacus pede', 55.00, 'baidu.com/sub/cars', 53, 85),
	(68, 'auctor velit.', 'sit amet, consectetuer adipiscing elit. Etiam laoreet, libero et tristique', 29.00, 'netflix.com/en-us', 24, 13),
	(69, 'adipiscing, enim mi tempor', 'sed, sapien. Nunc pulvinar arcu et pede. Nunc sed orci', 38.00, 'walmart.com/site', 6, 18),
	(70, 'massa. Suspendisse', 'auctor, nunc nulla vulputate dui, nec tempus mauris erat eget', 31.00, 'reddit.com/sub', 86, 3),
	(71, 'ut eros non', 'posuere cubilia Curae Phasellus ornare. Fusce mollis. Duis sit amet', 58.00, 'whatsapp.com/one', 68, 66),
	(72, 'lorem, vehicula et,', 'tincidunt vehicula risus. Nulla eget metus eu erat semper rutrum.', 98.00, 'reddit.com/site', 44, 30),
	(73, 'vulputate eu, odio.', 'arcu. Vivamus sit amet risus. Donec egestas. Aliquam nec enim.', 89.00, 'yahoo.com/site', 58, 10),
	(74, 'ornare, lectus ante dictum', 'facilisis non, bibendum sed, est. Nunc laoreet lectus quis massa.', 62.00, 'pinterest.com/sub/cars', 48, 34),
	(75, 'nec, malesuada ut,', 'sapien molestie orci tincidunt adipiscing. Mauris molestie pharetra nibh. Aliquam', 76.00, 'bbc.co.uk/sub', 83, 26),
	(76, 'torquent per conubia', 'a odio semper cursus. Integer mollis. Integer tincidunt aliquam arcu.', 92.00, 'google.com/en-us', 49, 63),
	(77, 'lorem, sit amet', 'lacus. Cras interdum. Nunc sollicitudin commodo ipsum. Suspendisse non leo.', 5.00, 'nytimes.com/one', 21, 3),
	(78, 'at auctor ullamcorper,', 'aliquet nec, imperdiet nec, leo. Morbi neque tellus, imperdiet non,', 81.00, 'yahoo.com/en-us', 47, 50),
	(79, 'pede. Praesent eu dui.', 'lectus convallis est, vitae sodales nisi magna sed dui. Fusce', 13.00, 'twitter.com/fr', 36, 35),
	(80, 'massa non', 'Duis cursus, diam at pretium aliquet, metus urna convallis erat,', 51.00, 'nytimes.com/one', 79, 10),
	(81, 'Etiam gravida molestie arcu.', 'augue scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan sed,', 87.00, 'baidu.com/en-us', 85, 41),
	(82, 'eget magna. Suspendisse tristique', 'nisl. Nulla eu neque pellentesque massa lobortis ultrices. Vivamus rhoncus.', 73.00, 'netflix.com/sub/cars', 44, 19),
	(83, 'imperdiet nec,', 'lorem lorem, luctus ut, pellentesque eget, dictum placerat, augue. Sed', 10.00, 'guardian.co.uk/sub', 81, 34),
	(84, 'placerat. Cras dictum ultricies', 'diam vel arcu. Curabitur ut odio vel est tempor bibendum.', 59.00, 'pinterest.com/site', 28, 39),
	(85, 'eleifend nec, malesuada ut,', 'laoreet, libero et tristique pellentesque, tellus sem mollis dui, in', 68.00, 'yahoo.com/group/9', 27, 37),
	(86, 'est arcu', 'Mauris vel turpis. Aliquam adipiscing lobortis risus. In mi pede,', 34.00, 'pinterest.com/site', 63, 51),
	(87, 'tellus. Aenean egestas hendrerit neque.', 'hendrerit. Donec porttitor tellus non magna. Nam ligula elit, pretium', 96.00, 'netflix.com/sub/cars', 93, 53),
	(88, 'Duis sit amet', 'orci, in consequat enim diam vel arcu. Curabitur ut odio', 0.00, 'reddit.com/sub', 80, 65),
	(89, 'Mauris magna. Duis dignissim', 'velit justo nec ante. Maecenas mi felis, adipiscing fringilla, porttitor', 56.00, 'walmart.com/site', 97, 12),
	(90, 'arcu', 'scelerisque mollis. Phasellus libero mauris, aliquam eu, accumsan sed, facilisis', 24.00, 'wikipedia.org/settings', 86, 30),
	(91, 'nibh. Phasellus nulla.', 'lorem, sit amet ultricies sem magna nec quam. Curabitur vel', 47.00, 'cnn.com/site', 18, 32),
	(92, 'ipsum primis in faucibus orci', 'nonummy ut, molestie in, tempus eu, ligula. Aenean euismod mauris', 43.00, 'reddit.com/one', 33, 69),
	(93, 'Quisque libero lacus, varius', 'pharetra. Quisque ac libero nec ligula consectetuer rhoncus. Nullam velit', 99.00, 'google.com/en-us', 81, 43),
	(94, 'neque', 'egestas. Aliquam nec enim. Nunc ut erat. Sed nunc est,', 25.00, 'nytimes.com/fr', 19, 87),
	(95, 'sociosqu ad litora torquent per', 'parturient montes, nascetur ridiculus mus. Donec dignissim magna a tortor.', 80.00, 'google.com/one', 85, 5),
	(96, 'mauris. Morbi', 'dictum placerat, augue. Sed molestie. Sed id risus quis diam', 42.00, 'walmart.com/fr', 70, 94),
	(97, 'Nunc', 'mauris. Suspendisse aliquet molestie tellus. Aenean egestas hendrerit neque. In', 59.00, 'whatsapp.com/sub', 61, 31),
	(98, 'Duis cursus, diam at', 'lacus. Cras interdum. Nunc sollicitudin commodo ipsum. Suspendisse non leo.', 74.00, 'facebook.com/sub/cars', 4, 50),
	(99, 'ornare, lectus', 'aliquet odio. Etiam ligula tortor, dictum eu, placerat eget, venenatis', 87.00, 'baidu.com/sub', 31, 26),
	(100, 'ac', 'dictum eu, eleifend nec, malesuada ut, sem. Nulla interdum. Curabitur', 95.00, 'baidu.com/settings', 72, 11);

-- Listage de la structure de procédure sauzet_boutique. GetCategorie
DELIMITER //
CREATE PROCEDURE `GetCategorie`()
BEGIN
	SELECT * FROM categorie;
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. GetClient
DELIMITER //
CREATE PROCEDURE `GetClient`()
BEGIN
	SELECT * FROM client;
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. GetCommande
DELIMITER //
CREATE PROCEDURE `GetCommande`()
BEGIN
 SELECT * FROM commande;
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. GetFournisseur
DELIMITER //
CREATE PROCEDURE `GetFournisseur`()
BEGIN
	SELECT * FROM fournisseur;
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. GetLDC
DELIMITER //
CREATE PROCEDURE `GetLDC`()
BEGIN
 SELECT * FROM lignedecommande;
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. GetProduit
DELIMITER //
CREATE PROCEDURE `GetProduit`()
BEGIN
 SELECT * FROM produit;
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. RechercheCategorie
DELIMITER //
CREATE PROCEDURE `RechercheCategorie`(
	IN `paramValeur` VARCHAR(50)
)
BEGIN
	SELECT * FROM categorie 
	WHERE (
		id LIKE CONCAT('%', paramValeur,'%') 
		OR libelle LIKE CONCAT('%', paramValeur,'%'));
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. RechercheClient
DELIMITER //
CREATE PROCEDURE `RechercheClient`(
	IN `paramValeur` VARCHAR(50)
)
BEGIN
	SELECT * FROM client 
	WHERE (
		id LIKE CONCAT('%', paramValeur,'%') 
		OR nom LIKE CONCAT('%', paramValeur,'%')
		OR prenom LIKE CONCAT('%', paramValeur,'%')
		OR rue LIKE CONCAT('%', paramValeur,'%')
		OR codePostal LIKE CONCAT('%', paramValeur,'%')
		OR ville LIKE CONCAT('%', paramValeur,'%')
		OR tel LIKE CONCAT('%', paramValeur,'%')
		OR email LIKE CONCAT('%', paramValeur,'%'));
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. RechercheCommande
DELIMITER //
CREATE PROCEDURE `RechercheCommande`(
	IN `paramValeur` VARCHAR(50)
)
BEGIN
	SELECT commande.id,commande.date,commande.idClient, CONCAT(UPPER(nom),' ',prenom) AS Patronyme
	FROM commande,client
	WHERE (commande.idClient = client.id) 
		AND (commande.id LIKE CONCAT('%', paramValeur,'%') 
		OR date LIKE CONCAT('%', paramValeur,'%')
		OR idClient LIKE CONCAT('%', paramValeur,'%')
		OR CONCAT(UPPER(nom),' ',prenom) LIKE CONCAT('%', paramValeur,'%'));
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. RechercheFournisseur
DELIMITER //
CREATE PROCEDURE `RechercheFournisseur`(
	IN `paramValeur` VARCHAR(50)
)
BEGIN
	SELECT *
	FROM fournisseur
	WHERE (
		id LIKE CONCAT('%', paramValeur,'%') 
		OR nom LIKE CONCAT('%', paramValeur,'%')
		OR rue LIKE CONCAT('%', paramValeur,'%')
		OR codePostal LIKE CONCAT('%', paramValeur,'%')
		OR ville LIKE CONCAT('%', paramValeur,'%')
		OR tel LIKE CONCAT('%', paramValeur,'%')
		OR email LIKE CONCAT('%', paramValeur,'%'));
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. RechercheLDC
DELIMITER //
CREATE PROCEDURE `RechercheLDC`(
	IN `paramValeur` VARCHAR(50)
)
BEGIN
	SELECT idCommande,DATE AS dateCommande,CONCAT(UPPER(client.nom),' ',client.prenom) AS PatronymeClient,idProduit,produit.nom AS nomProduit,quantite 
	FROM lignedecommande,produit,commande,client 
	WHERE (lignedecommande.idProduit = produit.id) 
		AND (lignedecommande.idCommande = commande.id) 
		AND (commande.idClient = client.id) 
		AND (idCommande LIKE CONCAT('%', paramValeur,'%') 
		OR commande.date LIKE CONCAT('%', paramValeur,'%')
		OR CONCAT(UPPER(client.nom),' ',client.prenom) LIKE CONCAT('%', paramValeur,'%')
		OR idProduit LIKE CONCAT('%', paramValeur,'%')
		OR produit.nom LIKE CONCAT('%', paramValeur,'%')
		OR lignedecommande.quantite LIKE CONCAT('%', paramValeur,'%'));
END//
DELIMITER ;

-- Listage de la structure de procédure sauzet_boutique. RechercheProduit
DELIMITER //
CREATE PROCEDURE `RechercheProduit`(
	IN `paramValeur` VARCHAR(50)
)
BEGIN
	select produit.id,produit.nom,produit.description,produit.prix,produit.image,produit.idCategorie,categorie.libelle,produit.idFournisseur,fournisseur.nom AS nomFournisseur 
	from produit,categorie,fournisseur 
	WHERE (produit.idCategorie = categorie.id) 
	AND (produit.idFournisseur = fournisseur.id)
	AND (produit.id LIKE CONCAT('%', paramValeur,'%')
	OR produit.nom LIKE CONCAT('%', paramValeur,'%')
	OR produit.description LIKE CONCAT('%', paramValeur,'%')
	OR produit.prix LIKE CONCAT('%', paramValeur,'%')
	OR produit.image LIKE CONCAT('%', paramValeur,'%')
	OR produit.idCategorie LIKE CONCAT('%', paramValeur,'%')
	OR categorie.libelle LIKE CONCAT('%', paramValeur,'%')
	OR produit.idFournisseur LIKE CONCAT('%', paramValeur,'%')
	OR fournisseur.nom LIKE CONCAT('%', paramValeur,'%'));
END//
DELIMITER ;

-- Listage de la structure de déclencheur sauzet_boutique. !DeleteCategorie
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER';
DELIMITER //
CREATE TRIGGER `!DeleteCategorie` BEFORE DELETE ON `categorie` FOR EACH ROW BEGIN
   DELETE FROM produit WHERE idCategorie = OLD.id; 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Listage de la structure de déclencheur sauzet_boutique. !DeleteClient
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER';
DELIMITER //
CREATE TRIGGER `!DeleteClient` BEFORE DELETE ON `client` FOR EACH ROW BEGIN
   DELETE FROM commande WHERE idClient = OLD.id; 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Listage de la structure de déclencheur sauzet_boutique. !DeleteCommande
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER';
DELIMITER //
CREATE TRIGGER `!DeleteCommande` BEFORE DELETE ON `commande` FOR EACH ROW BEGIN
   DELETE FROM lignedecommande WHERE idCommande = OLD.id; 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Listage de la structure de déclencheur sauzet_boutique. !DeleteFournisseur
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER';
DELIMITER //
CREATE TRIGGER `!DeleteFournisseur` BEFORE DELETE ON `fournisseur` FOR EACH ROW BEGIN
   DELETE FROM produit WHERE idFournisseur = OLD.id; 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Listage de la structure de déclencheur sauzet_boutique. !DeleteProduit
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER';
DELIMITER //
CREATE TRIGGER `!DeleteProduit` BEFORE DELETE ON `produit` FOR EACH ROW ## Déclencheur fesant un delete dans la table Produit à chaque delete de la table categorie.
BEGIN
   DELETE FROM lignedecommande WHERE idProduit = OLD.id; 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
