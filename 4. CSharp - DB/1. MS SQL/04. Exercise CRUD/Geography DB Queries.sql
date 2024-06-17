USE Geography
GO

-- 22.
  SELECT [PeakName]
    FROM Peaks
ORDER BY [PeakName]

-- 23.
SELECT TOP (30)
           [CountryName], 
		   [Population]
	  FROM Countries
	 WHERE [ContinentCode] = 'EU'
  ORDER BY [Population] DESC,
           [CountryName]

-- 24.
   SELECT [CountryName],
          [CountryCode],
CASE WHEN [CurrencyCode] = 'EUR' THEN 'Euro'
	 ELSE 'Not Euro' END AS [Currency]
     FROM Countries
 ORDER BY [CountryName]
