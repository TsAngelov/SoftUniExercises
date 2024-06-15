--- I. Gringotts
USE Gringotts
GO

-- 1.
SELECT COUNT(*) AS [Count]
  FROM WizzardDeposits

-- 2.
SELECT MAX(MagicWandSize) AS LongestMagicWand
  FROM WizzardDeposits
  
-- 3.
SELECT DepositGroup,
	   MAX(MagicWandSize) AS LongestMagicWand
  FROM WizzardDeposits
 GROUP BY DepositGroup

-- 4.
SELECT DepositGroup
  FROM WizzardDeposits
 GROUP BY DepositGroup
 ORDER BY AVG(MagicWandSize)

-- 5.
SELECT DepositGroup,
	   SUM(DepositAmount) AS TotalSum
  FROM WizzardDeposits
 GROUP BY DepositGroup

-- 6.
SELECT DepositGroup,
	   SUM(DepositAmount) AS TotalSum
  FROM WizzardDeposits
 WHERE MagicWandCreator = 'Ollivander family'
 GROUP BY DepositGroup

-- 7.
SELECT DepositGroup,
	   SUM(DepositAmount) AS TotalSum
  FROM WizzardDeposits
 WHERE MagicWandCreator = 'Ollivander family'
 GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
 ORDER BY TotalSum DESC

-- 8.
SELECT DepositGroup,
	   MagicWandCreator,
	   MIN(DepositCharge) AS MinDepositCharge
  FROM WizzardDeposits
 GROUP BY DepositGroup, MagicWandCreator
 ORDER BY MagicWandCreator,
	      DepositGroup

-- 9
SELECT dt.AgeGroup,
	   COUNT(*) AS WizardCount
  FROM (SELECT CASE
				WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
				WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
				WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
				WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
				WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
				WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
				ELSE '[61+]' END AS AgeGroup
		 FROM WizzardDeposits) AS dt
 GROUP BY dt.AgeGroup

-- 10.
SELECT *
  FROM (SELECT LEFT(FirstName, 1) AS FirstLetter
		FROM WizzardDeposits
		 WHERE DepositGroup = 'Troll Chest') AS dt
 GROUP BY dt.FirstLetter
 ORDER BY dt.FirstLetter

-- 11.
SELECT DepositGroup,
	   IsDepositExpired,
	   AVG(DepositInterest) AS AverageInterest
  FROM WizzardDeposits
 WHERE DepositStartDate > '01/01/1985'
 GROUP BY DepositGroup, IsDepositExpired
 ORDER BY DepositGroup DESC,
		  IsDepositExpired

-- 12.
SELECT SUM(dt.Difference) AS SumDifference
  FROM (SELECT 
		       DepositAmount - LEAD(DepositAmount) OVER (ORDER BY Id) AS [Difference]
	    FROM WizzardDeposits) AS dt

--- II. SoftUni
USE SoftUni
GO

-- 13.
SELECT DepartmentID,
	   SUM(Salary) AS TotalSalary
  FROM Employees
 GROUP BY DepartmentID
 ORDER BY DepartmentID

-- 14.
SELECT DepartmentID,
	   MIN(Salary) AS MinimumSalary
  FROM Employees
 WHERE DepartmentID IN (2, 5, 7) AND HireDate > '2000-01-01'
 GROUP BY DepartmentID

-- 15.
SELECT * INTO RichEmployees
  FROM Employees
 WHERE Salary > 30000

DELETE
  FROM RichEmployees
 WHERE ManagerID = 42

UPDATE RichEmployees
   SET Salary += 5000
 WHERE DepartmentID = 1

SELECT DepartmentID,
	   AVG(Salary) AS MaxSalary
  FROM RichEmployees
 GROUP BY DepartmentID

-- 16.
SELECT DepartmentID,
	   MAX(Salary) AS MaxSalary
  FROM Employees
 GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

-- 17.
SELECT COUNT(*) AS COUNT
  FROM Employees
 WHERE ManagerID IS NULL

-- 18.
SELECT DepartmentID,
	   dt.Salary
  FROM (SELECT DepartmentID, Salary, DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS SalaryRank
		FROM Employees
		GROUP BY DepartmentID, Salary) AS dt
  WHERE SalaryRank = 3

-- 19.
WITH CTE_DepartmentAverageSalaries AS
(
	SELECT DepartmentID,
		   AVG(Salary) AS AverageSalary
	  FROM Employees
	 GROUP BY DepartmentID
)

SELECT TOP 10
	   FirstName,
	   LastName,
	   e.DepartmentID
  FROM Employees AS e
  JOIN CTE_DepartmentAverageSalaries AS cte ON cte.DepartmentID = e.DepartmentID
 WHERE e.Salary > cte.AverageSalary
 ORDER BY e.DepartmentID