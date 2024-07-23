USE [Roll_play]
GO

INSERT INTO [dbo].[Background_proficiencies]([tool_id],[skill_id],[background_id],[tool_cat],[language])
     VALUES
	 --acolyte
	 (null, 11, 1, null, null), --insight
	 (null, 9, 1, null, null), --religion
	 (null, null, 1, null, 1), --lang
	 (null, null, 1, null, 1), --lang
	 --charlatan
	 (8, null, 2, null, null), --disguise kit
	 (9, null, 2, null, null), --forgery kit
	 (null, 15, 2, null, null), --deception
	 (null, 3, 2, null, null), --sleight of hand
	 --criminal
	 (null, 15, 3, null, null), --deception
	 (null, 4, 3, null, null), --stealth
	 (null, null, 3, 3, null), --gaming set
	 (20, null, 3, null, null), --thieves tools
	 --criminal spy
	 (null, 15, 4, null, null), --deception
	 (null, 4, 4, null, null), --stealth
	 (null, null, 4, 3, null), --gaming set
	 (20, null, 4, null, null), --thieves tools
	 --entertainer
	 (null, 2, 5, null, null), --acrobatics
	 (null, 17, 5, null, null), --performance
	 (8, null, 5, null, null), --disguise kit
	 (null, null, 5, 4, null), --instrument
	 --entertainer gladiator
	 (null, 2, 6, null, null), --acrobatics
	 (null, 17, 6, null, null), --performance
	 (8, null, 6, null, null), --disguise kit
	 (null, null, 6, 4, null), --instrument
	 --folk hero
	 (null, 10, 7, null, null), --animal handling
	 (null, 14, 7, null, null), --survival
	 (null, null, 7, 2, null), --artisan tools
	 (24, null, 7, null, null), --vehicles(land)
	 --guild artisan
	 (null, 11, 8, null, null), --insight
	 (null, 18, 8, null, null), --persuasion
	 (null, null, 8, 2, null), --artisan tools
	 (null, null, 8, null, 1), --language
	 --guild artisan merchant
	 (null, 11, 9, null, null), --insight
	 (null, 18, 9, null, null), --persuasion
	 (null, null, 9, null, 1), --language
	 --hermit
	 (null, 12, 10, null, null), --medicine
	 (null, 9, 10, null, null), --religion
	 (11, null, 10, null, null), --herbalism kit
	 (null, null, 10, null, 1), --lang
	 --noble
	 (null, 6, 11, null, null), --history
	 (null, 18, 11, null, null), --persuasion
	 (null, null, 11, 3, null), --gaming set
	 (null, null, 11, null, 1), --lang
	 --noble knight
	 (null, 6, 12, null, null), --history
	 (null, 18, 12, null, null), --persuasion
	 (null, null, 12, 3, null), --gaming set
	 (null, null, 12, null, 1), --lang
	 --noble retainers
	 (null, 6, 13, null, null), --history
	 (null, 18, 13, null, null), --persuasion
	 (null, null, 13, 3, null), --gaming set
	 (null, null, 13, null, 1), --lang
	 --outlander
	 (null, 1, 14, null, null), --athletics
	 (null, 14, 14, null, null), --survival
	 (null, null, 14, 4, null), --intrument
	 (null, null, 14, null, 1), --lang
	 --sage
	 (null, 5, 15, null, null), --arcana
	 (null, 6, 15, null, null), --history
	 (null, null, 15, null, 1), --lang 
	 (null, null, 15, null, 1), --lang
	 --sailor
	 (null, 1, 16, null, null), --athletics
	 (null, 13, 16, null, null), --perception
	 (15, null, 16, null, null), --navigators tools
	 (25, null, 16, null, null), --vehicles water
	 --sailor pirate
	 (null, 1, 17, null, null), --athletics
	 (null, 13, 17, null, null), --perception
	 (15, null, 17, null, null), --navigators tools
	 (25, null, 17, null, null), --vehicles water
	 --soldier
	 (null, 1, 18, null, null), --athletics
	 (null, 16, 18, null, null), --intimidation
	 (null, null, 18, 3, null), --gaming set
	 (24, null, 18, null, null), --vehicles land
	 --urchin
	 (null, 3, 19, null, null), --sleight of hand
	 (null, 4, 19, null, null), --stealth
	 (8, null, 19, null, null), --disguise kit
	 (20, null, 19, null, null) --thieves tools
GO
