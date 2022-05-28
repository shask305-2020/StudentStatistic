CREATE VIEW `vw_students`
AS
SELECT `students`.`id`, `students`.`fam` AS 'Фамилия', `students`.`name` AS 'Имя', `students`.`otch` AS 'Отчество', `groups`.`name` AS 'Группа',
`gender`.`gender` AS 'Пол', `students`.`birthday` AS 'День рождения', `students`.`year_of_admission` AS 'Год зачисления'
FROM `students` INNER JOIN `groups` ON `students`.`id_group` = `groups`.`id`
INNER JOIN `gender` ON `students`.`id_gender` = `gender`.`id`