-- phpMyAdmin SQL Dump
-- version 4.9.7
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Май 24 2022 г., 18:33
-- Версия сервера: 5.7.21-20-beget-5.7.21-20-1-log
-- Версия PHP: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `kazaku5d_shask`
--

-- --------------------------------------------------------

--
-- Структура таблицы `base`
--
-- Создание: Май 22 2022 г., 11:28
-- Последнее обновление: Май 22 2022 г., 12:33
--

DROP TABLE IF EXISTS `base`;
CREATE TABLE `base` (
  `id` int(11) NOT NULL,
  `base` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `base`
--

INSERT INTO `base` (`id`, `base`) VALUES
(1, 'основного общего образования'),
(2, 'среднего общего образования');

-- --------------------------------------------------------

--
-- Структура таблицы `gender`
--
-- Создание: Май 22 2022 г., 11:14
--

DROP TABLE IF EXISTS `gender`;
CREATE TABLE `gender` (
  `id` int(11) NOT NULL,
  `gender` varchar(20) NOT NULL DEFAULT 'Не определен' COMMENT 'Пол студента'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `groups`
--
-- Создание: Май 22 2022 г., 11:26
--

DROP TABLE IF EXISTS `groups`;
CREATE TABLE `groups` (
  `id` int(11) NOT NULL,
  `id_spec` int(11) NOT NULL,
  `kurs` int(11) NOT NULL DEFAULT '1',
  `name` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `level`
--
-- Создание: Май 22 2022 г., 12:19
-- Последнее обновление: Май 22 2022 г., 12:29
--

DROP TABLE IF EXISTS `level`;
CREATE TABLE `level` (
  `id` int(11) NOT NULL,
  `level` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `level`
--

INSERT INTO `level` (`id`, `level`) VALUES
(1, 'Программа подготовки специалистов среднего звена'),
(2, 'Программа подготовки квалифицированных рабочих, служащих');

-- --------------------------------------------------------

--
-- Структура таблицы `spec`
--
-- Создание: Май 22 2022 г., 11:29
-- Последнее обновление: Май 22 2022 г., 13:00
--

DROP TABLE IF EXISTS `spec`;
CREATE TABLE `spec` (
  `id` int(11) NOT NULL,
  `code` varchar(10) NOT NULL,
  `name` varchar(45) NOT NULL,
  `sokr` varchar(45) NOT NULL,
  `id_level` int(11) NOT NULL,
  `id_base` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `spec`
--

INSERT INTO `spec` (`id`, `code`, `name`, `sokr`, `id_level`, `id_base`) VALUES
(1, '09.02.07', 'Информационные системы и программирование', 'ИТ', 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `students`
--
-- Создание: Май 22 2022 г., 11:24
--

DROP TABLE IF EXISTS `students`;
CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `id_group` int(11) NOT NULL,
  `fam` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `otch` varchar(45) NOT NULL,
  `birthday` date NOT NULL,
  `id_gender` int(11) NOT NULL,
  `year_of_admission` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Таблица студентов';

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `vw_spec`
-- (См. Ниже фактическое представление)
--
DROP VIEW IF EXISTS `vw_spec`;
CREATE TABLE `vw_spec` (
`id` int(11)
,`Код специальности` varchar(10)
,`Наименование специальности` varchar(45)
);

-- --------------------------------------------------------

--
-- Структура для представления `vw_spec`
--
DROP TABLE IF EXISTS `vw_spec`;

CREATE ALGORITHM=UNDEFINED DEFINER=`kazaku5d_shask`@`localhost` SQL SECURITY DEFINER VIEW `vw_spec`  AS SELECT `spec`.`id` AS `id`, `spec`.`code` AS `Код специальности`, `spec`.`name` AS `Наименование специальности` FROM `spec` ;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `base`
--
ALTER TABLE `base`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `gender`
--
ALTER TABLE `gender`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_groups_spec` (`id_spec`);

--
-- Индексы таблицы `level`
--
ALTER TABLE `level`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `spec`
--
ALTER TABLE `spec`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_spec_level` (`id_level`),
  ADD KEY `fk_spec_base` (`id_base`);

--
-- Индексы таблицы `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_students_gender` (`id_gender`),
  ADD KEY `fk_student_groups` (`id_group`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `base`
--
ALTER TABLE `base`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `gender`
--
ALTER TABLE `gender`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `groups`
--
ALTER TABLE `groups`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `level`
--
ALTER TABLE `level`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `spec`
--
ALTER TABLE `spec`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `groups`
--
ALTER TABLE `groups`
  ADD CONSTRAINT `fk_groups_spec` FOREIGN KEY (`id_spec`) REFERENCES `spec` (`id`);

--
-- Ограничения внешнего ключа таблицы `spec`
--
ALTER TABLE `spec`
  ADD CONSTRAINT `fk_spec_base` FOREIGN KEY (`id_base`) REFERENCES `base` (`id`),
  ADD CONSTRAINT `fk_spec_level` FOREIGN KEY (`id_level`) REFERENCES `level` (`id`);

--
-- Ограничения внешнего ключа таблицы `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `fk_student_groups` FOREIGN KEY (`id_group`) REFERENCES `groups` (`id`),
  ADD CONSTRAINT `fk_students_gender` FOREIGN KEY (`id_gender`) REFERENCES `gender` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
