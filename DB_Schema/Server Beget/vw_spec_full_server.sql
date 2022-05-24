CREATE VIEW `vw_spec` AS
select `spec`.`id` AS `id`,`spec`.`code` AS `Код специальности`,
`spec`.`name` AS `Наименование специальности` from `spec`