USE [Geography]

GO

CREATE VIEW v_HighestPeak AS
 SELECT TOP (1) *
       FROM Peaks
   ORDER BY Elevation DESC

GO

SELECT *
FROM dbo.v_HighestPeak