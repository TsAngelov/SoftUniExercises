--- I SoftUni
USE SoftUni
GO

-- 1.
SELECT TOP 5
	   e.EmployeeID,
	   e.JobTitle,
	   e.AddressID,
	   a.AddressText
  FROM Employees AS e
  JOIN Addresses AS a ON e.AddressID = a.AddressID
 ORDER BY e.AddressID

-- 2.
SELECT TOP 50
	   e.FirstName,
	   e.LastName,
	   t.[Name] AS Town,
	   a.AddressText
  FROM Employees AS e
  JOIN Addresses AS a ON e.AddressID = a.AddressID
  JOIN Towns AS t ON a.TownID = t.TownID
 ORDER BY e.FirstName,
	      e.LastName

-- 3.
SELECT e.EmployeeID,
	   e.FirstName,
	   e.LastName,
	   d.[Name] AS DepartmentName
  FROM Employees AS e
  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
 WHERE d.[Name] = 'Sales'
 ORDER BY e.EmployeeID

-- 4.
SELECT TOP 5
	   e.EmployeeID,
	   e.FirstName,
	   e.Salary,
	   d.[Name] AS DepartmentName
  FROM Employees AS e
  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
 WHERE e.Salary > 15000
 ORDER BY e.DepartmentID

-- 5.
SELECT TOP 3
	   e.EmployeeID,
	   e.FirstName
  FROM Employees AS e
  LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
 WHERE ProjectID IS NULL
 ORDER BY e.EmployeeID

-- 6.
SELECT e.FirstName,
	   e.LastName,
	   e.HireDate,
	   d.[Name] AS DeptName
  FROM Employees AS e
  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
 WHERE d.[Name] IN ('Sales', 'Finance')
 ORDER BY e.HireDate

-- 7.
SELECT TOP 5
	   e.EmployeeID,
	   e.FirstName,
	   p.[Name] AS ProjectName
  FROM Employees AS e
  JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
  JOIN Projects AS p ON ep.ProjectID = p.ProjectID
   WHERE p.StartDate > '2002-08-13' AND p.EndDate IS NULL
 ORDER BY e.EmployeeID

-- 8.
SELECT TOP 5
	   e.EmployeeID,
	   e.FirstName,
	   (CASE 
			WHEN YEAR(p.StartDate) >= 2005 THEN NULL 
			ELSE p.[Name]
	    END) AS ProjectName
  FROM Employees AS e
  JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
  JOIN Projects AS p ON ep.ProjectID = p.ProjectID
 WHERE e.EmployeeID = 24

-- 9.
SELECT e.EmployeeID,
	   e.FirstName,
	   e.ManagerID,
	   m.FirstName AS ManagerName
  FROM Employees AS e
  JOIN Employees AS m ON e.ManagerID = m.EmployeeID
 WHERE e.ManagerID IN (3,7)
 ORDER BY e.EmployeeID

-- 10.
SELECT TOP 50
       e.EmployeeID,
	   CONCAT_WS(' ', e.FirstName, e.LastName) AS EmployeeName,
	   CONCAT_WS(' ', m.FirstName, m.LastName) AS ManagerName,
	   d.[Name] AS DepartmentName
  FROM Employees AS e
  JOIN Employees AS m ON e.ManagerID = m.EmployeeID
  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
 ORDER BY e.EmployeeID

-- 11.
SELECT MIN(dt.avgSalary) AS MinAverageSalary
  FROM
	   (SELECT AVG(Salary) AS avgSalary
		  FROM Employees
		 GROUP BY DepartmentID) AS dt

--- II Geography
USE Geography
GO

-- 12.
SELECT mc.CountryCode,
	   m.MountainRange,
	   p.PeakName,
	   p.Elevation
  FROM Peaks AS p
  JOIN Mountains AS m ON p.MountainId = m.Id
  JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
 WHERE mc.CountryCode = 'BG' AND p.Elevation > 2835
 ORDER BY p.Elevation DESC

-- 13.
SELECT CountryCode,
       COUNT(MountainID)
  FROM MountainsCountries
  WHERE CountryCode IN ('BG', 'RU', 'US')
 GROUP BY CountryCode

-- 14.
SELECT TOP 5
	   c.CountryName,
	   r.RiverName
  FROM Countries AS c
  LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
  LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
 WHERE c.ContinentCode = 'AF'
 ORDER BY c.CountryName

-- 15.
SELECT ContinentCode, CurrencyCode, CurrencyUsage
  FROM

	(SELECT *,
	DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY CurrencyUsage DESC) AS CurrencyRank

	FROM
			(SELECT ContinentCode, 
				   CurrencyCode,
				   COUNT(CurrencyCode) AS CurrencyUsage
			  FROM Countries
			 GROUP BY ContinentCode, CurrencyCode) AS dt
	WHERE CurrencyUsage > 1) AS dt2
 WHERE CurrencyRank = 1
 ORDER BY ContinentCode

-- 16.
SELECT COUNT(*) AS [Count]
  FROM Countries AS c
  LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
  WHERE mc.MountainId IS NULL

-- 17.
SELECT TOP 5
	   CountryName,
	   MAX(p.Elevation) AS HighestPeakElevation,
       MAX(r.[Length]) AS LongestRiverLength
  FROM Countries AS c
  LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
  LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
  LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
  LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
  LEFT JOIN Peaks AS p ON p.MountainId = m.Id
 GROUP BY c.CountryName
 ORDER BY HighestPeakElevation DESC,
		  LongestRiverLength DESC,
		  c.CountryName

-- 18
WITH CTE_PeaksRankedByElevation AS
(
	SELECT 
		   c.CountryName,
		   p.PeakName,
		   p.Elevation,
		   m.MountainRange,
		   DENSE_RANK() OVER(PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS PeakRank
	  FROM Countries AS C
	  LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
	  LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
	  LEFT JOIN Peaks AS p ON p.MountainId = m.Id

)

SELECT TOP 5
	   CountryName AS Country,
	   ISNULL(PeakName, '(no highest peak)') AS [Highest Peak Name],
	   ISNULL(Elevation, 0) AS [Highest Peak Elevation],
	   ISNULL(MountainRange, '(no mountain)') AS Mountain
  FROM CTE_PeaksRankedByElevation
 WHERE PeakRank = 1
 ORDER BY CountryName,
		  [Highest Peak Name]



