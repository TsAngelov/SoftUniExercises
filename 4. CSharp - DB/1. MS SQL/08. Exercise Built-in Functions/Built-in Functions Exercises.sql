--- I SoftUni
USE SoftUni
GO

-- 1.
 
SELECT FirstName,
	   LastName
  FROM Employees
 WHERE FirstName LIKE 'Sa%'
 
 
-- 2.
SELECT FirstName,
	   LastName
  FROM Employees
 WHERE LastName LIKE '%ei%'
 
-- 3.
SELECT FirstName
  FROM Employees
 WHERE DepartmentID IN (3,10)
   AND Year(HireDate) BETWEEN 1995 AND 2005
 
-- 4.
SELECT FirstName,
	   LastName
  FROM Employees
 WHERE JobTitle NOT LIKE '%engineer%'
 
-- 5.
SELECT [Name]
  FROM Towns
 WHERE LEN([Name]) BETWEEN 5 AND 6
 ORDER BY [Name]
 
-- 6.
SELECT *
  FROM Towns
 WHERE [Name] LIKE '[MKBE]%'
 ORDER BY [Name]
 
-- 7.
SELECT *
  FROM Towns
 WHERE [Name] NOT LIKE '[RBD]%'
 ORDER BY [Name]
 
-- 8.
GO
CREATE VIEW V_EmployeesHiredAfter2000 AS 
SELECT FirstName,
	   LastName
  FROM Employees
 WHERE YEAR(HireDate) > 2000
 GO
 
-- 9.
SELECT FirstName,
	   LastName
  FROM Employees
 WHERE LEN(LastName) = 5
 
-- 10.
SELECT EmployeeID,
       FirstName,
	   LastName,
	   Salary,
	   DENSE_RANK()
	   OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
  FROM Employees
 WHERE Salary BETWEEN 10000 AND 50000
 ORDER BY Salary DESC
 
 
-- 11.
-- Common Table Expression
WITH CTE_RankedEmployees AS
(
	SELECT EmployeeID,
		   FirstName,
		   LastName,
		   Salary,
		   DENSE_RANK()
		   OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
	  FROM Employees
	 WHERE Salary BETWEEN 10000 AND 50000
 
)
SELECT *
FROM CTE_RankedEmployees
WHERE [Rank] = 2
ORDER BY Salary DESC

--- II Geography
USE Geography
GO

-- 12.
SELECT CountryName,
	   IsoCode
  FROM Countries
  WHERE CountryName LIKE '%a%a%a%'
 ORDER BY IsoCode
 
-- 13.

SELECT PeakName, 
	   RiverName,
	   LOWER(CONCAT(PeakName, RIGHT(RiverName, LEN(RiverName) - 1))) AS Mix
  FROM Peaks, Rivers
 WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
 ORDER BY Mix

--- III Diablo
USE Diablo
GO

-- 14.
SELECT TOP(50)
	   [Name],
	   FORMAT([Start], 'yyyy-MM-dd') AS [Start]
  FROM Games
 WHERE YEAR([Start]) BETWEEN 2011 AND 2012
 ORDER BY [Start],
          [Name]

-- 15.
SELECT Username,
       SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email)) AS [Email Provider]
  FROM Users
 ORDER BY [Email Provider],
          Username

-- 16.
SELECT Username,
	   IpAddress
  FROM Users
 WHERE IpAddress LIKE '___.1%.%.___'
 ORDER BY Username

-- 17.
SELECT [Name] AS Game,
	   [Part of the Day] = CASE
								WHEN DATEPART(HOUR, [Start]) < 12 THEN 'Morning'
								WHEN DATEPART(HOUR, [Start]) < 18 THEN 'Afternoon'
								ELSE 'Evening' END,
	   [Duration] = CASE
								WHEN Duration <= 3 THEN 'Extra Short'
								WHEN Duration <= 6 THEN 'Short'
								WHEN Duration > 6 THEN 'Long'
								ELSE 'Extra Long' END

  FROM Games
 ORDER BY [Name],
          Duration,
		  [Part of the Day]

--- IV
USE Orders
GO

-- 18.
SELECT ProductName,
	   OrderDate,
	   DATEADD(DAY, 3, OrderDate) AS [Pay Due],
	   DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
  FROM Orders

-- 19.
CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL,
	Birthdate DATETIME2 NOT NULL
)

INSERT INTO People
VALUES('Victor', '2000-12-07'),
	  ('Steven', '1992-09-10'),
	  ('Stephen', '1910-09-19'),
	  ('John', '2010-01-06')

SELECT [Name],
	   DATEDIFF(YEAR, Birthdate, GETDATE()) AS [Age in Years],
	   DATEDIFF(MONTH, Birthdate, GETDATE()) AS [Age in Months],
	   DATEDIFF(DAY, Birthdate, GETDATE()) AS [Age in Days],
	   DATEDIFF(MINUTE, Birthdate, GETDATE()) AS [Age in Minutes]
  FROM People