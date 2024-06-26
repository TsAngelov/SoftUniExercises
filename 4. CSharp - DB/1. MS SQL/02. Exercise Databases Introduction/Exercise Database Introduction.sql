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
CREATE DATABASE Movies

CREATE TABLE Directors
(
	Id INT PRIMARY KEY IDENTITY,
	DirectorName VARCHAR(50) NOT NULL,
	Notes VARCHAR(MAX)
)
CREATE TABLE Genres
(
	Id INT PRIMARY KEY IDENTITY,
	GenreName VARCHAR(30) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName VARCHAR(30) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Movies
(
	Id INT PRIMARY KEY IDENTITY,
	Title VARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear SMALLINT,
	[Length] TIME,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Rating DECIMAL(10,1),
	Notes VARCHAR(MAX)
)

INSERT INTO Directors(DirectorName)
VALUES('Petar'),
	  ('Ivan'),
	  ('Oceit'),
	  ('Patronov'),
	  ('CekoRonaldo')

INSERT INTO Genres(GenreName)
VALUES('Comedy'),
	  ('Horror'),
	  ('Criminal'),
	  ('Romance'),
	  ('Sci-Fi')

INSERT INTO Categories(CategoryName)
VALUES('High Rated'),
	  ('Low Rated'),
	  ('Best Pick'),
	  ('Recommended'),
	  ('New')

INSERT INTO Movies(Title, DirectorId, GenreId, CategoryId)
VALUES('Komediq', 1, 1, 1),
	  ('Ujas', 2, 2, 2),
	  ('Ot Mestoprestaplenieto Maqmi', 3, 3, 3),
	  ('Romantika', 4, 4, 4),
	  ('Izmislici', 5, 5, 5)

-- 14.
CREATE DATABASE CarRental
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName VARCHAR(30) NOT NULL,
	DailyRate DECIMAL(2,2),
	WeeklyRate DECIMAL(2,2),
	MonthlyRate DECIMAL(2,2),
	WeekendRate DECIMAL(2,2),
)

CREATE TABLE Cars
(
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber VARCHAR(10) NOT NULL,
	Manufacturer VARCHAR(30) NOT NULL,
	Model VARCHAR(20),
	CarYear SMALLINT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors TINYINT,
	Picture VARBINARY(MAX),
	Condition VARCHAR(20),
	Available VARCHAR(3) NOT NULL
		CHECK(Available in('Yes', 'No'))
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	Title VARCHAR(15) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenseNumber VARCHAR(20) NOT NULL,
	FullName VARCHAR(30) NOT NULL,
	[Address] VARCHAR(30),
	City VARCHAR(30) NOT NULL,
	ZIPCode VARCHAR(10),
	Notes VARCHAR(MAX)
)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	CarId INT FOREIGN KEY REFERENCES Cars(Id),
	TankLevel DECIMAL(3,2),
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	StartDate DATETIME2,
	EndDate DATETIME2,
	TotalDays INT,
	RateApplied DECIMAL(2,2),
	TaxRate DECIMAL(2,2),
	OrderStatus VARCHAR(15),
	Notes VARCHAR(MAX)
)

INSERT INTO Categories(CategoryName)
Values('SUV'),
	  ('Sedan'),
	  ('Coupe')

INSERT INTO Cars(PlateNumber, Manufacturer, CarYear, Available)
Values('EH8938BM', 'Volkswagen', 2010, 'Yes'),
	  ('CB777777', 'Mercedes', 2024, 'No'),
	  ('XAXAXAXA', 'BMW', 2020, 'No')

INSERT INTO Employees(FirstName, LastName, Title)
Values('Patrona', 'Lachenov', 'Intern'),
	  ('Ceco', 'Mercedes', 'Boss'),
	  ('Vladko', 'Malkiq', 'Assistant')

INSERT INTO Customers(DriverLicenseNumber, FullName, City)
Values('123456789', 'Petar Petrov', 'Dermanci'),
	  ('987654321', 'Oceit Petrov', 'Pleven'),
	  ('123798456', 'Mario Jiviq', 'Karlukovo')

INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId)
Values(1, 1, 1),
	  (2, 2, 2),
	  (3, 3, 3)

-- 15.
CREATE DATABASE Hotel
GO

USE Hotel
GO

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	Title VARCHAR(10),
	Notes VARCHAR(MAX)
)

CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY IDENTITY(1000, 1),
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	PhoneNumber VARCHAR(10),
	EmergencyName VARCHAR(15),
	EmergencyNumber VARCHAR(10),
	Notes VARCHAR(MAX)
)

CREATE TABLE RoomStatus
(
	RoomStatus VARCHAR(3) PRIMARY KEY,
	Notes VARCHAR(MAX)
)

CREATE TABLE RoomTypes
(
	RoomType VARCHAR(10) PRIMARY KEY,
	Notes VARCHAR(MAX)
)

CREATE TABLE BedTypes
(
	BedType VARCHAR(10) PRIMARY KEY,
	Notes VARCHAR(MAX)
)

CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY IDENTITY (100,1),
	RoomType VARCHAR(10) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType VARCHAR(10) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate DECIMAL(4,2),
	RoomStatus VARCHAR(3) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes VARCHAR(MAX)
)

CREATE TABLE Payments
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeID INT FOREIGN KEY REFERENCES Employees(Id),
	PaymentDate DATETIME2,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	FirstDateOccupied DATETIME2,
	LastDateOccupied DATETIME2,
	TotalDays INT,
	AmountCharged DECIMAL(10,2),
	TaxRate DECIMAL(4,2),
	TaxAmount DECIMAL(6,2),
	PaymentTotal DECIMAL(10,2),
	Notes VARCHAR(MAX)
)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeID INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATETIME2,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
	RateApplied DECIMAL(4,2),
	PhoneCharge DECIMAL(6,2),
	Notes VARCHAR(MAX)
)

INSERT INTO Employees(FirstName, LastName)
VALUES('Partona', 'Patronov'),
	  ('Ceco', 'Gurba'),
	  ('Petar', 'Mazdata')

INSERT INTO Customers(FirstName, LastName)
VALUES('Ocet', 'Petrov'),
	  ('Mesi', 'Petrov'),
	  ('Patrona', 'Junior')

INSERT INTO RoomStatus(RoomStatus)
VALUES('DND'),
	  ('OCC'),
	  ('DO')

INSERT INTO RoomTypes(RoomType)
VALUES('Single'),
	  ('Double'),
	  ('King')

INSERT INTO BedTypes(BedType)
VALUES('Single'),
	  ('Queen'),
	  ('King')

INSERT INTO Rooms(RoomType, BedType, RoomStatus)
VALUES('Single', 'Single', 'DND'),
	  ('Double', 'Queen', 'OCC'),
	  ('King', 'King', 'DO')

INSERT INTO Payments(EmployeeID, AccountNumber)
VALUES(1, 1000),
	  (2, 1001),
	  (3, 1002)

INSERT INTO Occupancies(EmployeeID, AccountNumber, RoomNumber)
VALUES (1, 1000, 100),
	   (2, 1001, 101),
	   (3, 1002, 102)

-- 16.
CREATE DATABASE SoftUni
GO
 
CREATE TABLE Towns
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(15) NOT NULL
)
 
CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	AddressText  VARCHAR(15) NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id)
)
 
CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(15) NOT NULL,
)
 
CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(15) NOT NULL,
	MiddleName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	JobTitle VARCHAR(15) NOT NULL,
	DepartmentID INT FOREIGN KEY REFERENCES Departments(Id),
	HireDate DATETIME2 NOT NULL,
	Salary DECIMAL(6,2) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id)
)
 
-- 18.
INSERT INTO Towns
VALUES ('Sofia'),
	   ('Plovdiv'),
	   ('Varna'),
	   ('Burgas')
 
INSERT INTO Departments
VALUES ('Engineering'),
	   ('Sales'),
	   ('Marketing'),
	   ('SD'),
	   ('QA')
 
INSERT INTO Addresses
VALUES ('Ulica', 1)
 
INSERT INTO Employees
VALUES ('Ivan', 'Ivanov', 'Ivanov', '.NET Dev', 13, '2013-01-01', 3500.00, 1),
	   ('Petar', 'Petrov', 'Petrov', 'Senior Eng', 10, '2004-03-02', 4000.00, 1),
	   ('Maria', 'Petrova', 'Ivanova', 'Intern', 14, '2016-08-28', 525.25, 1),
	   ('Georgi', 'Terziev', 'Ivanov', 'CEO', 11, '2007-12-09', 3000.00, 1),
	   ('Peter', 'Pan', 'Pan', 'Intern', 12, '2016-08-28', 599.88, 1)
 
-- 19.
SELECT *
  FROM Towns
 
SELECT *
  FROM Departments
 
SELECT *
  FROM Employees
 
-- 20.
SELECT *
  FROM Towns
 ORDER BY [Name]
 
SELECT *
  FROM Departments
 ORDER BY [Name]
 
SELECT *
  FROM Employees
 ORDER BY [Salary] DESC
 
-- 21.
SELECT [Name]
  FROM Towns
 ORDER BY [Name]
 
SELECT [Name]
  FROM Departments
 ORDER BY [Name]
 
SELECT [FirstName], [LastName], [JobTitle], [Salary]
  FROM Employees
 ORDER BY [Salary] DESC
 
-- 22.
UPDATE Employees
SET Salary += Salary * 0.1
 
SELECT [Salary]
  FROM Employees
 
-- 23.
UPDATE Payments
SET TaxRate -= TaxRate * 0.03
 
SELECT [TaxRate]
  FROM Payments
 
-- 24.
TRUNCATE TABLE Occupancies