--- I. SoftUni
USE SoftUni
GO

-- 1.
CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
	SELECT FirstName,
		   LastName
	  FROM Employees
	 WHERE Salary > 35000

EXEC usp_GetEmployeesSalaryAbove35000
GO

-- 2.
CREATE PROC usp_GetEmployeesSalaryAboveNumber @NUMBER DECIMAL(18,4)
AS
	SELECT FirstName,
		   LastName
	  FROM Employees
	 WHERE Salary >= @NUMBER

EXEC usp_GetEmployeesSalaryAboveNumber 48100
GO

-- 3.
CREATE PROC usp_GetTownsStartingWith @BEGIN VARCHAR(10)
AS
	SELECT [Name] AS Town
	  FROM Towns
	 WHERE [Name] LIKE (@BEGIN + '%')

EXEC usp_GetTownsStartingWith 'b'
GO

-- 4.
CREATE PROC usp_GetEmployeesFromTown @TOWN VARCHAR(20)
AS
	SELECT e.FirstName,
		   e.LastName
	  FROM Employees AS e
	  JOIN Addresses AS a ON e.AddressID = a.AddressID
	  JOIN Towns AS t ON a.TownID = t.TownID
	 WHERE t.[Name] = @TOWN

EXEC usp_GetEmployeesFromTown 'Sofia'
GO

-- 5.
CREATE FUNCTION ufn_GetSalaryLevel(@Salary DECIMAL(18,4))
RETURNS VARCHAR(10)
AS
	BEGIN
	DECLARE @result VARCHAR(10)

	IF(@Salary < 30000) 
	  SET @result = 'Low'
	ELSE IF(@Salary BETWEEN 30000 AND 50000)
	  SET @result = 'Average'
	ELSE
	  SET @result = 'High'

	RETURN @RESULT
	END

GO

SELECT FirstName,
	   LastName,
	   Salary,
	   dbo.ufn_GetSalaryLevel(Salary) AS SalaryLevel
  FROM Employees
GO

-- 6.
CREATE PROC usp_EmployeesBySalaryLevel @Level VARCHAR(10)
AS
	SELECT FirstName, LastName
	  FROM Employees
	 WHERE dbo.ufn_GetSalaryLevel(Salary) = @Level

EXEC usp_EmployeesBySalaryLevel 'High'
GO

-- 7.
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
	BEGIN
		DECLARE @wordLength INT = LEN(@word)
		DECLARE @iterator INT = 1

		WHILE(@iterator <= @wordLength)
		BEGIN
			IF(CHARINDEX(SUBSTRING(@word, @iterator, 1), @setOfLetters) = 0)
				RETURN 0;
			SET @iterator += 1
		END
		RETURN 1
	END

GO

SELECT 'oistmiahf' AS SetOfLetters,
	   'halves' AS Word,
	   dbo.ufn_IsWordComprised('oistmiahf','halves')
			
GO

-- 8.
CREATE  OR ALTER PROC usp_deleteEmployeesFromDepartment @departmentId INT
AS
BEGIN
	DECLARE @deletedEmployees TABLE(Id INT)

	-- 1. DELETED EMPLOYEES
	INSERT INTO @deletedEmployees
	SELECT EmployeeID
	  FROM Employees
	 WHERE DepartmentID = @departmentId

	 -- 2. Set ManagerID to be nullable
	 ALTER TABLE Departments
	 ALTER COLUMN ManagerID INT NULL

	 -- 3. Nullify ManagerIds
	 UPDATE Departments
	   SET ManagerID = NULL
	  WHERE ManagerID IN
	  (
		SELECT Id FROM @deletedEmployees
	  )

	 -- 4. Delete from EmployeesProject
	 DELETE FROM EmployeesProjects
	 WHERE EmployeeID IN
	 (
		SELECT Id FROM @deletedEmployees
	 )

	 -- 5. Nullify Employees Managers
	 UPDATE Employees
	    SET ManagerID = NULL
	  WHERE ManagerID IN
	  (
		SELECT Id FROM @deletedEmployees
	  )

	  -- 6. Delete
	  DELETE FROM Employees
	   WHERE DepartmentID = @departmentId

	  DELETE FROM Departments
		WHERE DepartmentID = @departmentId


	  SELECT COUNT(*) 
	    FROM Employees 
	   WHERE DepartmentID = @departmentId
END
GO

--- II. Bank
USE Bank
GO

-- 9.
CREATE PROC usp_GetHoldersFullName
AS
	SELECT CONCAT_WS(' ', FirstName, LastName) AS [Full Name]
	  FROM AccountHolders
GO

EXEC usp_GetHoldersFullName
GO

-- 10.
CREATE PROC usp_GetHoldersWithBalanceHigherThan @Balance MONEY
AS
	SELECT FirstName,
		   LastName
	   FROM AccountHolders AS ah
	   JOIN Accounts AS a ON a.AccountHolderId = ah.Id
	 GROUP BY AccountHolderId, FirstName, LastName
	 HAVING SUM(Balance) > @Balance
	 ORDER BY FirstName,
			  LastName

GO

-- 11.
CREATE OR ALTER FUNCTION ufn_CalculateFutureValue(@sum DECIMAL(10,4), @yearlyInterestRate FLOAT, @years INT)
RETURNS DECIMAL(10,4)
AS
	BEGIN 
		RETURN @sum * POWER((1 + @yearlyInterestRate), @years)
	END
GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
GO

-- 12.
CREATE PROC usp_CalculateFutureValueForAccount(@accountId INT, @interestRate FLOAT)
AS
	DECLARE @period INT = 5

	SELECT ah.Id AS [Account Id],
		   ah.FirstName,
		   ah.LastName,
		   a.Balance AS [Current Balance],
		   dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, @period) AS [Balance in 5 years]

	  FROM AccountHolders AS ah
	   JOIN Accounts AS a ON a.AccountHolderId = ah.Id
	  WHERE a.Id = @accountId
GO

EXEC usp_CalculateFutureValueForAccount 1, 0.1

	




	

