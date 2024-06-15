USE SoftUni
GO

-- 1.

SELECT DepartmentID,
	   SUM(Salary) AS SalarySum
  FROM Employees
 GROUP BY DepartmentID
 ORDER BY DepartmentID
