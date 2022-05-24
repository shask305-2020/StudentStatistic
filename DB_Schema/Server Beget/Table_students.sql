CREATE TABLE IF NOT EXISTS `shasku5d_shask`.`students` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_group` INT NOT NULL COMMENT 'ИД группы',
  `fam` VARCHAR(45) NOT NULL COMMENT 'Фамилия',
  `name` VARCHAR(45) NOT NULL COMMENT 'Имя',
  `otch` VARCHAR(45) NOT NULL COMMENT 'Отчество',
  `birthday` DATE NOT NULL,
  `id_gender` INT NOT NULL COMMENT 'Пол',
  `year_of_admission` YEAR(4) NOT NULL COMMENT 'Год поступления',
  PRIMARY KEY (`id`),
  INDEX `fk_students_groups_idx` (`id_group` ASC) VISIBLE,
  INDEX `fk_students_gender_idx` (`id_gender` ASC) VISIBLE,
  CONSTRAINT `fk_students_groups`
    FOREIGN KEY (`id_group`)
    REFERENCES `shasku5d_shask`.`groups` (`id`),
  CONSTRAINT `fk_students_gender`
    FOREIGN KEY (`id_gender`)
    REFERENCES `shasku5d_shask`.`gender` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3