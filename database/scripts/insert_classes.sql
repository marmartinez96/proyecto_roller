USE [Roll_play]
GO

INSERT INTO [dbo].[Class]([name],[hitdie],[saving_throw_1],[saving_throw_2],[skill_qty],[tool_qty],[is_spellcaster])
     VALUES
	 ('Barbarian', 12, 1, 3, 2, 0, 0),
	 ('Bard', 8, 2, 6, 3, 3, 1),
	 ('Cleric', 8, 5, 6, 2, 0, 1),
	 ('Druid', 8, 4, 5, 2, 0, 1),
	 ('Fighter', 10, 1, 3, 2, 0, 0),
	 ('Monk', 8, 1, 2, 2, 1, 0),
	 ('Paladin', 10, 5, 6, 2, 0, 1),
	 ('Ranger', 10, 1, 2, 3, 0, 1),
	 ('Rogue', 8, 2, 4, 4, 0, 0),
	 ('Sorcerer', 6, 3, 6, 2, 0, 1),
	 ('Warlock', 8, 5, 6, 2, 0, 1),
	 ('Wizard', 6, 4, 5, 2, 0, 1)
GO

