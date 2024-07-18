USE [Roll_play]
GO

INSERT INTO [dbo].[Background]([name],[equipment],[languages_qty],[feature])
     VALUES
           ('Acolyte', 'A holy symbol (a gift to you when you entered the priesthood), a prayer book or prayer wheel, 5 sticks of incense, vestments, a set of common clothes, and a belt pouch containing 15 gp',2,'Shelter of the Faithful'),
		   ('Charlatan', 'A set of fine clothes, a disguise kit, tools of the con of your choice (ten stoppered bottles filled with colored liquid, a set of weighted dice, a deck of marked cards, or a signet ring of an imaginary duke), and a belt pouch containing 15 gp', 0, 'False Identity'),
		   ('Criminal', 'A crowbar, a set of dark common clothes including a hood, and a belt pouch containing 15 gp', 0, 'Criminal Contact'),
		   ('Criminal (Spy)', 'A crowbar, a set of dark common clothes including a hood, and a belt pouch containing 15 gp', 0, 'Spy Contact'),
		   ('Entertainer', 'A musical instrument (one of your choice), the favor of an admirer (love letter, lock of hair, or trinket), costume clothes, and a belt pouch containing 15 gp', 0, 'By Popular Demand'),
		   ('Entertainer (Gladiator)', 'An inexpensive but unusual weapon, such as a trident or net (one of your choice),  the favor of an admirer (love letter, lock of hair, or trinket), costume clothes, and a belt pouch containing 15 gp', 0, 'By Popular Demand'),
		   ('Folk Hero', 'A set of artisan"s tools (one of your choice), a shovel, an iron pot, a set of common clothes, and a belt pouch containing 10 gp', 0, 'Rustic Hospotality'),
		   ('Guild Artisan', 'A set of artisan"s tools (one of your choice), a letter of introduction from your guild, a set of traveler"s clothes, and a belt pouch containing 15 gp', 1, 'Guild membership'),
		   ('Guild Artisan (Guild Merchant)', 'A set of artisan"s tools (one of your choice) or a mule and cart, a letter of introduction from your guild, a set of traveler"s clothes, and a belt pouch containing 15 gp', 1, 'Guild membership'),
		   ('Hermit','A scroll case stuffed full of notes from your studies or prayers, a winter blanket, a set of common clothes, an herbalism kit, and 5 gp', 1, 'Discovery'),
		   ('Noble', 'A set of fine clothes, a signet ring, a scroll of pedigree, and a purse containing 25 gp', 1, 'Position of Privilege'),
		   ('Noble (Knight)', 'A set of fine clothes, a signet ring, a scroll of pedigree, and a purse containing 25 gp', 1, 'Retainers'),
		   ('Noble (Retainers)', 'A set of fine clothes, a signet ring, a scroll of pedigree, and a purse containing 25 gp', 1, 'Retainers'),
		   ('Outlander', 'A staff, a hunting trap, a trophy from an animal you killed, a set of traveler"s clothes, and a belt pouch containing 10 gp', 1, 'Wanderer'),
		   ('Sage', 'A bottle of black ink, a quill, a small knife, a letter from a dead colleague posing a question you have not yet been able to answer, a set of common clothes, and a belt pouch containing 10 gp', 2, 'Researcher'),
		   ('Sailor', 'A belaying pin (club), silk rope (50 feet), a lucky charm such as a rabbit foot or a small stone with a hole in the center (or you may roll for a random trinket on the Trinkets table in chapter 5), a set of common clothes, and a belt pouch containing 10 gp', 0, 'Ship"s Passage'),
		   ('Sailor (Pirate)', 'A belaying pin (club), silk rope (50 feet), a lucky charm such as a rabbit foot or a small stone with a hole in the center (or you may roll for a random trinket on the Trinkets table in chapter 5), a set of common clothes, and a belt pouch containing 10 gp', 0, 'Bad Reputation'),
		   ('Soldier', 'An insignia of rank, a trophy taken from a fallen enemy (a dagger, broken blade, or piece of a banner), a bone dice set or playing card set, a set of common clothes, and a belt pouch containing 10 gp', 0, 'Military Rank'),
		   ('Urchin', 'A small knife, a map of the city you grew up in, a pet mouse, a token to remember your parents by, a set of common clothes, and a belt pouch containing 10 gp', 0, 'City Secrets')
GO
