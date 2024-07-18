CREATE TABLE Class (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  level int,
  hitdie int,
  saving_throw_1 int,
  saving_throw_2 int,
  skill_qty int,
  is_spellcaster bit
);

CREATE TABLE Race (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  speed int,
  size nvarchar(50)
);

CREATE TABLE Racial_abilities (
  id int PRIMARY KEY IDENTITY(1,1),
  race_id int,
  ability_1 int,
  ability_2 int
);

CREATE TABLE Abilities (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50)
);

CREATE TABLE Languages (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50)
);

CREATE TABLE Racial_languages (
  id int PRIMARY KEY IDENTITY(1,1),
  language_id int, 
  race_id int
);

CREATE TABLE Racial_feats (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  description nvarchar(50),
  race_id int
);

CREATE TABLE Skills (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50)
);

CREATE TABLE Tools (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50)
);

CREATE TABLE Tool_type (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
);

CREATE TABLE Background (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  equipment nvarchar(4000),
  languages_qty int,
  feature nvarchar(4000)
);

CREATE TABLE Background_proficiencies (
  id int PRIMARY KEY IDENTITY(1,1),
  tool_id int,
  skill_id int,
  background_id int,
  tool_cat int,
  laguage bit
);

CREATE TABLE Class_skill_pool (
  id int PRIMARY KEY IDENTITY(1,1),
  class_id int,
  skill_id int
);

CREATE TABLE Weapon (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  type int,
  range int,
  damage int,
  reach int,
  min_range int,
  max_range int
);

CREATE TABLE Weapon_type (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50)
);

CREATE TABLE Weapon_range (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50)
);

CREATE TABLE Armor (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  armor_class int,
  str_req int,
  stealth_dis bit,
  type int
);

CREATE TABLE Armor_type (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50)
);

CREATE TABLE Class_proficiencies (
  id int PRIMARY KEY IDENTITY(1,1),
  class_id int,
  armor_id int,
  weapon_type_id int,
  single_weapon int
);

CREATE TABLE Spells (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  casting_time nvarchar(50),
  range int,
  components nvarchar(50),
  duration nvarchar(50),
  school nvarchar(50),
  concentration bit
);

CREATE TABLE Class_spells (
  id int PRIMARY KEY IDENTITY(1,1),
  class_id int,
  spell_id int
);

CREATE TABLE Class_features (
  id int PRIMARY KEY IDENTITY(1,1),
  class_id int,
  name nvarchar(50),
  description nvarchar(50),
  level int
);

CREATE TABLE Optional_features (
  id int PRIMARY KEY IDENTITY(1,1),
  name nvarchar(50),
  prerequisite nvarchar(50),
  type nvarchar(50),
  level int,
  feature_id int
);

ALTER TABLE Class ADD FOREIGN KEY (saving_throw_1) REFERENCES Abilities (id);

ALTER TABLE Class ADD FOREIGN KEY (saving_throw_2) REFERENCES Abilities (id);

ALTER TABLE Racial_abilities ADD FOREIGN KEY (race_id) REFERENCES Race (id);

ALTER TABLE Racial_abilities ADD FOREIGN KEY (ability_1) REFERENCES Abilities (id);

ALTER TABLE Racial_abilities ADD FOREIGN KEY (ability_2) REFERENCES Abilities (id);

ALTER TABLE Racial_languages ADD FOREIGN KEY (language_id) REFERENCES Languages (id);

ALTER TABLE Racial_languages ADD FOREIGN KEY (race_id) REFERENCES Race (id);

ALTER TABLE Racial_feats ADD FOREIGN KEY (race_id) REFERENCES Race (id);

ALTER TABLE Background_proficiencies ADD FOREIGN KEY (tool_id) REFERENCES Tools (id);

ALTER TABLE Background_proficiencies ADD FOREIGN KEY (skill_id) REFERENCES Skills (id);

ALTER TABLE Background_proficiencies ADD FOREIGN KEY (background_id) REFERENCES Background (id);

ALTER TABLE Class_skill_pool ADD FOREIGN KEY (class_id) REFERENCES Class (id);

ALTER TABLE Class_skill_pool ADD FOREIGN KEY (skill_id) REFERENCES Skills (id);

ALTER TABLE Weapon ADD FOREIGN KEY (type) REFERENCES Weapon_type (id);

ALTER TABLE Weapon ADD FOREIGN KEY (range) REFERENCES Weapon_range (id);

ALTER TABLE Armor ADD FOREIGN KEY (type) REFERENCES Armor_type (id);

ALTER TABLE Class_proficiencies ADD FOREIGN KEY (class_id) REFERENCES Class (id);

ALTER TABLE Class_proficiencies ADD FOREIGN KEY (armor_id) REFERENCES Armor_type (id);

ALTER TABLE Class_proficiencies ADD FOREIGN KEY (weapon_type_id) REFERENCES Weapon_type (id);

ALTER TABLE Class_proficiencies ADD FOREIGN KEY (single_weapon) REFERENCES Weapon (id);

ALTER TABLE Class_spells ADD FOREIGN KEY (class_id) REFERENCES Class (id);

ALTER TABLE Class_spells ADD FOREIGN KEY (spell_id) REFERENCES Spells (id);

ALTER TABLE Class_features ADD FOREIGN KEY (class_id) REFERENCES Class (id);

ALTER TABLE Optional_features ADD FOREIGN KEY (feature_id) REFERENCES Class_features (id);

ALTER TABLE Tools ADD FOREIGN KEY (tool_type) REFERENCES Tool_type(id)

ALTER TABLE Background_proficiencies ADD FOREIGN KEY (tool_cat) REFERENCES Tool_type(id)
