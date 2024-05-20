USE [Geography]
Go

SELECT
	   m.MountainRange
	   ,p.PeakName
	   ,p.Elevation
FROM Peaks AS p
JOIN Mountains AS m ON p.MountainId = m.Id AND m.MountainRange = 'Rila' 
ORDER BY p.Elevation DESC