-- 1.

CREATE FUNCTION udf_GetSalaryLevel(@Salary MONEY)
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @result NVARCHAR(10)

	IF(@Salary < 30000)
		SET @result = 'Low'
	ELSE IF(@Salary <= 50000)
		SET @result = 'Average'
	ELSE
		SET @result = 'High'
	RETURN @result
END

GO

SELECT FirstName,
	   LastName,
	   Salary,
	   dbo.udf_GetSalaryLevel(Salary) AS SalaryLevel
  FROM Employees