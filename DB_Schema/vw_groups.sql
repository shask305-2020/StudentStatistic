CREATE VIEW `shask`.`vw_groups` AS
SELECT G.`id_group`, concat_ws(' ', S.`code`, S.`name`) AS 'Специальность', G.`kurs` AS 'Курс', G.`name` AS 'Наименование'
FROM `shask`.`groups` AS G
INNER JOIN `shask`.`spec` AS S