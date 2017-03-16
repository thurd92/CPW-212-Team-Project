USE master
GO


IF DB_ID('MediaDB') IS NOT NULL
	DROP DATABASE MediaDB
GO

CREATE DATABASE MediaDB
GO

USE MediaDB
GO

CREATE TABLE CastList
(
	
	CastID			int				PRIMARY KEY		IDENTITY
	,CastList		varchar(300)	NULL  --Provided in a comma-separated list
)
GO

CREATE TABLE Awards
(
	AwardsID		int				PRIMARY KEY		IDENTITY
	,AwardsName		varchar(50)		NULL
)
GO

CREATE TABLE Movies
(
	MovieID			int				PRIMARY KEY		IDENTITY
	,MovieName		varchar(50)		NOT NULL
	,MovieGenre		varchar(30)		NULL
	,CastID			int				NULL		REFERENCES CastList(CastID)
	,AwardsID		int				NULL		REFERENCES Awards(AwardsID)
)
GO

CREATE TABLE TVShows
(
	TVID			int				PRIMARY KEY		IDENTITY
	,TVName			varchar(50)		NOT NULL
	,TVGenre		varchar(30)		NULL
	,CastID			int				NULL		REFERENCES CastList(CastID)
	,AwardsID		int				NULL		REFERENCES Awards(AwardsID)
)
GO

INSERT INTO CastList
	(CastList)
VALUES
	('CastListWouldGoHere'),
	('CastListWouldAlsoGoHere')

INSERT INTO Awards
	(AwardsName)
VALUES
	('AwardTitleOne'),
	('AwardTitleTwo')

INSERT INTO Movies
	(MovieName, MovieGenre, CastID, AwardsID)
VALUES
	('The Lion King', 'Fantasy', 1, 1)

INSERT INTO TVShows
	(TVName, TVGenre, CastID, AwardsID)
VALUES
	('Spongebob Squarepants', 'Cartoon', 2, 2)
	select* from Movies