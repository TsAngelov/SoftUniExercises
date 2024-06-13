USE SoftUni
GO

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