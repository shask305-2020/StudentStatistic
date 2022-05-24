CREATE VIEW vw_groups AS
select `g`.`id` AS `id_group`,`g`.`kurs` AS `Курс`,`g`.`name` AS `Наименование`,
concat_ws(' ',`s`.`code`,`s`.`name`) AS `Специальность` from (`groups` AS `g` join `spec` AS `s` on((`g`.`id` = `s`.`id`))) order by `g`.`name`