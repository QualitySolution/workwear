﻿ALTER TABLE `workwear_depot`.`item_types` 
CHANGE COLUMN `wear_category` `wear_category` ENUM('Wear', 'Shoes', 'Headgear', 'Gloves', 'PPE') NULL DEFAULT NULL ;