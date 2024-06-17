USE SoftUni
GO

-- 1.
SELECT TOP(50)
	   e.FirstName,
	   e.LastName,
	   t.[Name] AS Town,
	   a.AddressText
  FROM Employees AS e
  JOIN Addresses AS a ON e.AddressID = a.AddressID
  JOIN Towns as t ON t.TownID = a.TownID
 ORDER BY FirstName,
		  LastName

-- 2.
SELECT e.EmployeeID,
	   e.FirstName,
	   e.LastName,
	   d.[Name] AS DepartmentName
  FROM Employees AS e
  JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
 WHERE d.[Name] = 'Sales'
 ORDER BY e.EmployeeID

-- 3.
SELECT e.FirstName,
	   e.LastName,
	   e.HireDate,
	   d.[Name] AS DeptName
  FROM Employees AS e
  JOIN Departments AS d ON d.DepartmentID = e.DepartmentID 
 WHERE 
		HireDate > '1/1/1999'
		AND d.[Name] IN ('Sales', 'Finance')
  ORDER BY e.HireDate

-- 4.
SELECT TOP(50)
	   e.EmployeeID,
	   CONCAT_WS(' ', e.FirstName, e.LastName) AS EmployeeName, 
	   CONCAT_WS(' ', em.FirstName, em.LastName) AS ManagerName,
	   d.[Name] AS DepartmentName
  FROM Employees AS e
  JOIN Employees AS em ON e.ManagerID = em.EmployeeID
  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
 ORDER BY e.EmployeeID

-- 5.
SELECT TOP(1) 
       AVG(Salary) AS AvgSalary
  FROM Employees
 GROUP BY DepartmentId
 ORDER BY AvgSalary

 -- Subquery
SELECT MIN(dt.AvgSalary) AS MinAvgSalary
  FROM (SELECT AVG(Salary) AS AvgSalary
		  FROM Employees
		 GROUP BY DepartmentId) AS dt

 -- Common Table Expression
WITH CTE_MinAvgSalary
     (AvgSalary)
  AS
  (
	SELECT AVG(Salary) AS AvgSalary
	FROM Employees
	GROUP BY DepartmentId
   )

SELECT MIN(AvgSalary) FROM CTE_MinAvgSalary