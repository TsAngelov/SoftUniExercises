-- CTRL + SHIFT + R => Refresh Editor
-- CTRL + K, CTRL + C => Comment selection

-- 01.
CREATE DATABASE Minions
USE Minions
GO

-- 02.
CREATE TABLE Minions
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(50),
	Age INT
)
CREATE TABLE Towns
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(50)
)

-- 03.
	-- Option 1
ALTER TABLE Minions
ADD TownId INT

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)

	-- Option 2
ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCES Towns(Id)


-- 04.
INSERT INTO Towns
Values(1, 'Sofia'),
	  (2, 'Plovdiv'),
	  (3, 'Varna')

INSERT INTO Minions (Id, [Name], Age, TownId)
Values(1, 'Kevin', 22, 1),
	  (2, 'Bob', 15, 3),
	  (3, 'Steward', NULL, 2)

-- 05.
TRUNCATE TABLE Minions

-- 06.
DROP TABLE Minions
DROP TABLE Towns

-- 07.
CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200),
	Picture VARBINARY(MAX),
	Height DECIMAL(3,2),
	[Weight] DECIMAL(5,2),
	Gender CHAR(1) NOT NULL,
		CHECK(Gender in('m', 'f')),
	Birthdate DATETIME2 NOT NULL,
	Biography VARCHAR(MAX)
)

INSERT INTO People ([Name], Gender, Birthdate)
Values ('Petar', 'm', '2006-01-23'),
	   ('Patrona', 'f', '2000-01-01'),
	   ('Oceit', 'm', '2006-05-13'),
	   ('Dimanqna', 'f', '2010-04-22'),
	   ('Ceko', 'm', '2001-01-01')

-- 08. 
CREATE TABLE Users
(
	Id BIGINT PRIMARY KEY IDENTITY,	
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX),
	LastLoginTime DATETIME2,
	IsDeleted BIT
)

INSERT INTO Users (Username, [Password])
Values ('Partona', 'Lachen123'),
	   ('Petar', 'Viki123'),
	   ('Oceit', '60VLutenicata'),
	   ('Ceco', 'Merkeles1234!C220'),
	   ('Gospoja', '123Masivcheta123')

-- 09. Delete Primary Key
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC074F4B1B8D

			-- Composite Primary Key (Primary Key combined from two fields)
ALTER TABLE Users
ADD CONSTRAINT PK_UsersTable PRIMARY KEY(Id, Username)

-- 10.
ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordIsAtleastFiveSymbols
CHECK(LEN([Password]) >= 5)


-- 11.
ALTER TABLE Users
ADD CONSTRAINT DF_LoginValue
DEFAULT GETDATE() FOR LastLoginTime

-- 12.
ALTER TABLE Users
DROP CONSTRAINT PK_UsersTable

ALTER TABLE Users
ADD CONSTRAINT PK_UsersTable PRIMARY KEY(Id)

ALTER TABLE Users
ADD CONSTRAINT CHK_UsernameIsAtleastThreeSymbols
CHECK(LEN(Username) >= 3)

-- 13.


