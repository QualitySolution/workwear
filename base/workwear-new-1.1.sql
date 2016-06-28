SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema workwear
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `workwear` ;
CREATE SCHEMA IF NOT EXISTS `workwear` DEFAULT CHARACTER SET utf8 ;
USE `workwear` ;

-- -----------------------------------------------------
-- Table `users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `users` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `login` VARCHAR(45) NOT NULL,
  `deactivated` TINYINT(1) NOT NULL DEFAULT 0,
  `email` VARCHAR(60) NULL DEFAULT NULL,
  `description` TEXT NULL DEFAULT NULL,
  `admin` TINYINT(1) NOT NULL DEFAULT FALSE,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `base_parameters`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `base_parameters` (
  `name` VARCHAR(20) NOT NULL,
  `str_value` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`name`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `objects`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `objects` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `address` VARCHAR(200) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posts` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1;


-- -----------------------------------------------------
-- Table `leaders`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `leaders` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `units`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `units` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `item_types`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `item_types` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `category` ENUM('wear', 'property') NULL DEFAULT 'wear',
  `units_id` INT UNSIGNED NULL DEFAULT NULL,
  `on_norms` TINYINT(1) NOT NULL DEFAULT 1,
  `norm_quantity` INT UNSIGNED NULL DEFAULT NULL,
  `norm_life` INT UNSIGNED NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_item_types_1_idx` (`units_id` ASC),
  CONSTRAINT `fk_item_types_1`
    FOREIGN KEY (`units_id`)
    REFERENCES `units` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1;


-- -----------------------------------------------------
-- Table `nomenclature`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `nomenclature` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `type_id` INT UNSIGNED NULL DEFAULT NULL,
  `size` VARCHAR(5) NULL DEFAULT NULL,
  `growth` VARCHAR(7) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_nomenclature_type_idx` (`type_id` ASC),
  CONSTRAINT `fk_nomenclature_type`
    FOREIGN KEY (`type_id`)
    REFERENCES `item_types` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `wear_cards`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wear_cards` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `card_number` VARCHAR(15) NULL DEFAULT NULL,
  `last_name` VARCHAR(20) NULL,
  `first_name` VARCHAR(20) NULL,
  `patronymic_name` VARCHAR(20) NULL,
  `object_id` INT UNSIGNED NULL DEFAULT NULL,
  `hire_date` DATE NULL DEFAULT NULL,
  `dismiss_date` DATE NULL DEFAULT NULL,
  `post_id` INT UNSIGNED NULL DEFAULT NULL,
  `leader_id` INT UNSIGNED NULL DEFAULT NULL,
  `wear_size` VARCHAR(5) NULL DEFAULT NULL,
  `growth` INT UNSIGNED NULL DEFAULT NULL,
  `sex` ENUM('F','M') NULL DEFAULT NULL,
  `fill_date` DATE NULL DEFAULT NULL,
  `user_id` INT UNSIGNED NULL DEFAULT NULL,
  `photo` MEDIUMBLOB NULL DEFAULT NULL,
  `photo_size` INT UNSIGNED NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_wear_cards_object_idx` (`object_id` ASC),
  INDEX `fk_wear_cards_post_idx` (`post_id` ASC),
  INDEX `fk_wear_cards_leader_idx` (`leader_id` ASC),
  INDEX `fk_wear_cards_user_idx` (`user_id` ASC),
  CONSTRAINT `fk_wear_cards_object`
    FOREIGN KEY (`object_id`)
    REFERENCES `objects` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_wear_cards_post`
    FOREIGN KEY (`post_id`)
    REFERENCES `posts` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_wear_cards_leader`
    FOREIGN KEY (`leader_id`)
    REFERENCES `leaders` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_wear_cards_user`
    FOREIGN KEY (`user_id`)
    REFERENCES `users` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `stock_income`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `stock_income` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `operation` ENUM('enter','return','object') NOT NULL,
  `number` VARCHAR(8) NULL DEFAULT NULL,
  `date` DATE NOT NULL,
  `wear_card_id` INT UNSIGNED NULL DEFAULT NULL,
  `user_id` INT UNSIGNED NULL DEFAULT NULL,
  `object_id` INT UNSIGNED NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_stock_income_wear_card_idx` (`wear_card_id` ASC),
  INDEX `fk_stock_income_user_idx` (`user_id` ASC),
  INDEX `fk_stock_income_object_idx` (`object_id` ASC),
  CONSTRAINT `fk_stock_income_wear_card`
    FOREIGN KEY (`wear_card_id`)
    REFERENCES `wear_cards` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_income_user`
    FOREIGN KEY (`user_id`)
    REFERENCES `users` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_income_object`
    FOREIGN KEY (`object_id`)
    REFERENCES `objects` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `stock_expense`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `stock_expense` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `operation` ENUM('employee','object') NOT NULL DEFAULT 'employee',
  `wear_card_id` INT UNSIGNED NULL DEFAULT NULL,
  `object_id` INT UNSIGNED NULL DEFAULT NULL,
  `date` DATE NOT NULL,
  `user_id` INT UNSIGNED NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_stock_expense_wear_card_idx` (`wear_card_id` ASC),
  INDEX `fk_stock_expense_user_idx` (`user_id` ASC),
  INDEX `fk_stock_expense_object_id_idx` (`object_id` ASC),
  CONSTRAINT `fk_stock_expense_wear_card`
    FOREIGN KEY (`wear_card_id`)
    REFERENCES `wear_cards` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_expense_user`
    FOREIGN KEY (`user_id`)
    REFERENCES `users` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_expense_object_id`
    FOREIGN KEY (`object_id`)
    REFERENCES `objects` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `object_places`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `object_places` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `object_id` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_object_places_object_id_idx` (`object_id` ASC),
  CONSTRAINT `fk_object_places_object_id`
    FOREIGN KEY (`object_id`)
    REFERENCES `objects` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1;


-- -----------------------------------------------------
-- Table `stock_expense_detail`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `stock_expense_detail` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `stock_expense_id` INT UNSIGNED NOT NULL,
  `nomenclature_id` INT UNSIGNED NOT NULL,
  `stock_income_detail_id` INT UNSIGNED NOT NULL,
  `quantity` INT UNSIGNED NOT NULL,
  `object_place_id` INT UNSIGNED NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_stock_expense_detail_stock_expense_idx` (`stock_expense_id` ASC),
  INDEX `fk_stock_expense_detail_nomenclature_idx` (`nomenclature_id` ASC),
  INDEX `fk_stock_expense_detail_enter_row_idx` (`stock_income_detail_id` ASC),
  INDEX `fk_stock_expense_detail_placement_idx` (`object_place_id` ASC),
  CONSTRAINT `fk_stock_expense_detail_stock_expense`
    FOREIGN KEY (`stock_expense_id`)
    REFERENCES `stock_expense` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_expense_detail_nomenclature`
    FOREIGN KEY (`nomenclature_id`)
    REFERENCES `nomenclature` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_expense_detail_enter_row`
    FOREIGN KEY (`stock_income_detail_id`)
    REFERENCES `stock_income_detail` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_expense_detail_placement`
    FOREIGN KEY (`object_place_id`)
    REFERENCES `object_places` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `stock_income_detail`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `stock_income_detail` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `stock_income_id` INT UNSIGNED NOT NULL,
  `nomenclature_id` INT UNSIGNED NOT NULL,
  `quantity` INT UNSIGNED NOT NULL,
  `life_percent` DECIMAL(3,2) UNSIGNED NOT NULL DEFAULT 1,
  `stock_expense_detail_id` INT UNSIGNED NULL DEFAULT NULL,
  `cost` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  INDEX `fk_stock_income_detail_stock_income_idx` (`stock_income_id` ASC),
  INDEX `fk_stock_income_detail_nomenclature_idx` (`nomenclature_id` ASC),
  INDEX `fk_stock_income_detail_stock_expense_idx` (`stock_expense_detail_id` ASC),
  CONSTRAINT `fk_stock_income_detail_stock_income`
    FOREIGN KEY (`stock_income_id`)
    REFERENCES `stock_income` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_income_detail_nomenclature`
    FOREIGN KEY (`nomenclature_id`)
    REFERENCES `nomenclature` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_income_detail_stock_expense`
    FOREIGN KEY (`stock_expense_detail_id`)
    REFERENCES `stock_expense_detail` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `stock_write_off`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `stock_write_off` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `date` DATE NOT NULL,
  `user_id` INT UNSIGNED NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_stock_write_off_user_idx` (`user_id` ASC),
  CONSTRAINT `fk_stock_write_off_user`
    FOREIGN KEY (`user_id`)
    REFERENCES `users` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `stock_write_off_detail`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `stock_write_off_detail` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `stock_write_off_id` INT UNSIGNED NOT NULL,
  `stock_expense_detail_id` INT UNSIGNED NULL DEFAULT NULL,
  `stock_income_detail_id` INT UNSIGNED NULL DEFAULT NULL,
  `nomenclature_id` INT UNSIGNED NOT NULL,
  `quantity` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_stock_write_off_detail_write_off_idx` (`stock_write_off_id` ASC),
  INDEX `fk_stock_write_off_detail_expense_idx` (`stock_expense_detail_id` ASC),
  INDEX `fk_stock_write_off_detail_income_idx` (`stock_income_detail_id` ASC),
  INDEX `fk_stock_write_off_detail_nomenclature_idx` (`nomenclature_id` ASC),
  CONSTRAINT `fk_stock_write_off_detail_write_off`
    FOREIGN KEY (`stock_write_off_id`)
    REFERENCES `stock_write_off` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_write_off_detail_expense`
    FOREIGN KEY (`stock_expense_detail_id`)
    REFERENCES `stock_expense_detail` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_write_off_detail_income`
    FOREIGN KEY (`stock_income_detail_id`)
    REFERENCES `stock_income_detail` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_stock_write_off_detail_nomenclature`
    FOREIGN KEY (`nomenclature_id`)
    REFERENCES `nomenclature` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `read_news`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `read_news` (
  `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `user_id` INT UNSIGNED NULL DEFAULT NULL,
  `feed_id` VARCHAR(64) NOT NULL,
  `items` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_read_news_user_id_idx` (`user_id` ASC),
  CONSTRAINT `fk_read_news_user_id`
    FOREIGN KEY (`user_id`)
    REFERENCES `users` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `base_parameters`
-- -----------------------------------------------------
START TRANSACTION;
USE `workwear`;
INSERT INTO `base_parameters` (`name`, `str_value`) VALUES ('product_name', 'workwear');
INSERT INTO `base_parameters` (`name`, `str_value`) VALUES ('version', '1.1');
INSERT INTO `base_parameters` (`name`, `str_value`) VALUES ('edition', 'gpl');

COMMIT;
