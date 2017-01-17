USE master

IF DB_ID('MediaCatalog') IS NOT NULL
	DROP DATABASE MediaCatalog
GO

CREATE DATABASE MediaCatalog
GO

USE MediaCatalog

CREATE TABLE MovieInfo
(
	MovieID int PRIMARY KEY IDENTITY,
	Name varchar(15) NOT NULL,
	Genre varchar(15) Null,
	[Year] int NOT NULL,
	Rating int NOT NULL,
	Director varchar(15) NULL

)

GO

/*INSERT INTO 
	VALUES ()
		   ,()
		   ,()
		   ,()*/

CREATE TABLE TvShows
(
	Name varchar(15) NOT NULL,
	NumberOfSeasons int NOT NULL,
	YearsRunning int NULL,
	CountryOfOrigin varchar(15) NULL,
)

CREATE TABLE [Cast]
(
	MovieID int NOT NULL,
	CastName varchar(15) NOT NULL,
	RolePlayed varchar(15) NOT Null
)

CREATE TABLE Awards
(
	CastName varchar(15) NOT NULL,
	AwardType varchar(15) NOT NULL,
	AwarderFor varchar(15) NULL,
	YearAwarded char(4) NOT NULL
)

