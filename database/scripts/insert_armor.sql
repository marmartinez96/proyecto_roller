USE [Roll_play]
GO

INSERT INTO [dbo].[Armor]([name],[armor_class],[str_req],[stealth_dis],[type])
     VALUES
           ('Leather Armor', 11, null, 0, 3),
		   ('Padded Armor', 11, null, 1, 3),
		   ('Studded Leather Armor', 12, null, 0, 3),
		   ('Breastplate', 14, null, 0, 2),
		   ('Chainshirt', 13, null, 0, 2),
		   ('Half Plate Armor', 15, null, 1, 2),
		   ('Hide Armor', 12, null, 0, 2),
		   ('Scale Mail', 14, null, 1, 2),
		   ('Chain Mail', 16, 13, 1, 1),
		   ('Plate Armor', 18, 15, 1, 1),
		   ('Ring Mail', 14, null, 1, 1),
		   ('Splint Armor', 17, 15, 1, 1),
		   ('Shield', 2, null, 0, 4)
GO


